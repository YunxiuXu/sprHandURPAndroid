Analytic Soft Shadows
Created by Jolly Theory
Email: jollytheorygames@gmail.com

-----
USAGE:

URP:
1) Import URP2020 or URP2021 package depending on your version of Unity by double clicking it. (File overrides are intended)
2) Add UASSRendererFeature to your URP Renderer (URP Renderer asset > Renderer Features > add UASS Renderer Feature)
3) Add 'UASS' component to your camera. Add multiple for mulltiple soft-shadow-generating lights.
4) Use 'Lit + AnalyticShadows' shader instead of 'Lit' shader on objects that you want to receive analytic soft shadows. ('Universal Render Pipeline/Lit + AnalyticShadows') (It is a copy of Lit shader, without any extra parameters)
5) Add UASSSphere/Capsule/Box components to objects that should cast shadows, there can be multiple per object. You will have to approximate your shadow shapes from these three basic shapes.
6) Turn off MeshRenderer's 'Cast Shadows' for appropriate meshes, or set 'Shadow Type' to 'No Shadows' for your entire light. (In places where you don't want old shadowmaps shadows mixing with new analytic shadows)
7) Adjust the algorithm and light angle settings to fit your scene. Try increasing bias if you see any self-shadowing artifacts. Done.
For custom shaders: Sample a global screen texture called "_UASSTexture" in your shader, .x component will have analytic soft shadows in it, you can then use it however you want.

Built-in render pipeline:
1) Set your camera to Deferred rendering path.
2) Add 'UASS' component to your camera. Add multiple for mulltiple soft-shadow-generating lights.
3) Add UASSSphere/Capsule/Box components to objects that should cast shadows, you can have multiple of them per object. You will have to approximate your shadow shapes from these three basic shapes.
4) Turn off MeshRenderer's 'Cast Shadows' for appropriate meshes, or set 'Shadow Type' to 'No Shadows' for your entire light. (In places where you don't want old shadowmaps shadows mixing with new analytic shadows)
5) Adjust the algorithm and light angle settings to fit your scene. Try increasing bias if you see any self-shadowing artifacts. Done.
In built-in, all shaders that are opaque and render to the depth buffer can receive shadows, no custom shaders or materials required. Shaders that are not opaque and don't render to the depth buffer may need to be adjusted to receive shadows.

----
TIPS:

- You can add more than one UASS component to your camera to have multiple lights casting shadows. It's recommended to not go higher than three UASS components for performance reasons.
- You can rightclick on Collider components to turn them into UASS counterparts (Rightclick BoxCollider -> 'Turn into UASSBox').
- Tools/UASS/* menu has helpful functions that you can use for, for example, quickly converting all of a ragdoll's colliders to UASS shadowcasters.
- Try right clicking on 'UnityAnalyticSoftShadows' folder -> Reimport, if you're having import issues.