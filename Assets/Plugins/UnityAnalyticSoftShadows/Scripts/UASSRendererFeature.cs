#if UNITY_2020_1_OR_NEWER
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class UASSRendererFeature : ScriptableRendererFeature
{
    public override void Create()
    {
        name = "UASS Renderer Feature";
    }

    //Called for every camera every frame
    public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
    {
        var components = renderingData.cameraData.camera.GetComponents<UASS>();
        foreach (var component in components) if (component != null && component.isActiveAndEnabled) component.OnPreRenderScriptablePipeline();

        var buffers = renderingData.cameraData.camera.GetCommandBuffers(CameraEvent.BeforeLighting);
        if (buffers.Length > 0)
        {
            var camData = renderingData.cameraData.camera.GetUniversalAdditionalCameraData();
            camData.requiresDepthOption = CameraOverrideOption.On;
            camData.requiresDepthTexture = true;
        }
        bool first = true;
        foreach (var buffer in buffers)
        {
            if (buffer != null)
            {
                var pass = new UASSRenderPass()
                {
                    renderPassEvent = RenderPassEvent.BeforeRenderingOpaques,
                    commandBuffer = buffer,
                    firstRenderPassSetupTexture = first
                };
                first = false;
                pass.ConfigureInput(ScriptableRenderPassInput.Depth);
                pass.ConfigureTarget(BuiltinRenderTextureType.None);
                renderer.EnqueuePass(pass);
            }
        }
    }
    
    class UASSRenderPass : ScriptableRenderPass
    {
        public CommandBuffer commandBuffer;
        public bool firstRenderPassSetupTexture = false;
        
        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            if (commandBuffer != null)
            {
                if (firstRenderPassSetupTexture)
                {
                    var buf = CommandBufferPool.Get("Analytic Soft Shadows");

                    int _analyicShadowsTexture = Shader.PropertyToID("_UASSTexture");
                    buf.ReleaseTemporaryRT(_analyicShadowsTexture);
                    buf.GetTemporaryRT(_analyicShadowsTexture, renderingData.cameraData.camera.pixelWidth, renderingData.cameraData.camera.pixelHeight, 0, FilterMode.Bilinear, GraphicsFormat.R16G16B16A16_SFloat);
                    buf.SetGlobalTexture(_analyicShadowsTexture, new RenderTargetIdentifier(_analyicShadowsTexture, 0, CubemapFace.Unknown, -1));
                    buf.SetRenderTarget(_analyicShadowsTexture);
                    buf.ClearRenderTarget(false, true, Color.white);

                    context.ExecuteCommandBuffer(buf);
                    CommandBufferPool.Release(buf);
                }

                context.ExecuteCommandBuffer(commandBuffer);
            }
        }
        
    }
}
#endif