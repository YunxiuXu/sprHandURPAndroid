using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
#pragma warning disable 0108
namespace SprCs {
    public partial class GRVisualDesc : CsObject {
	public GRVisualDesc() { _this = SprExport.Spr_new_GRVisualDesc(); _flag = true; }
	public GRVisualDesc(IntPtr ptr) : base(ptr) {}
	public GRVisualDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRVisualDesc() { if (_flag) { SprExport.Spr_delete_GRVisualDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class GRVisualDescStruct : CsObject {
        public GRVisualDescStruct() {
            GRVisualDesc desc = new GRVisualDesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] GRVisualDesc
	public void ApplyTo(GRVisualDesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(GRVisualDesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator GRVisualDesc(GRVisualDescStruct m) {
	    GRVisualDesc r = new GRVisualDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator GRVisualDescStruct(GRVisualDesc r) {
	    GRVisualDescStruct m = new GRVisualDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class GRFrameTransformMatrix : CsObject {
	public GRFrameTransformMatrix() { _this = SprExport.Spr_new_GRFrameTransformMatrix(); _flag = true; }
	public GRFrameTransformMatrix(IntPtr ptr) : base(ptr) {}
	public GRFrameTransformMatrix(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRFrameTransformMatrix() { if (_flag) { SprExport.Spr_delete_GRFrameTransformMatrix(_this); _flag = false; } }
    }
    public partial class GRFrameDesc : GRVisualDesc {
	public GRFrameDesc() { _this = SprExport.Spr_new_GRFrameDesc(); _flag = true; }
	public GRFrameDesc(IntPtr ptr) : base(ptr) {}
	public GRFrameDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRFrameDesc() { if (_flag) { SprExport.Spr_delete_GRFrameDesc(_this); _flag = false; } }
	public Affinef transform {
	    get { return new Affinef(SprExport.Spr_GRFrameDesc_addr_transform(_this)); }
	    set { SprExport.Spr_GRFrameDesc_set_transform(_this, value); }
	}
    }
    [System.Serializable]
    public class GRFrameDescStruct : GRVisualDescStruct {
        public GRFrameDescStruct() {
            GRFrameDesc desc = new GRFrameDesc();
            ApplyFrom(desc, true);
        }
	public AffinefStruct transform;
// _[Find class node: 2916] GRFrameDesc
	public void ApplyTo(GRFrameDesc r, bool apply_to_base_class=true) {
		r.transform = transform;
		if (apply_to_base_class) {
		    base.ApplyTo((GRVisualDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(GRFrameDesc r, bool apply_to_base_class=true) {
		transform = r.transform;
		if (apply_to_base_class) {
		    base.ApplyFrom((GRVisualDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator GRFrameDesc(GRFrameDescStruct m) {
	    GRFrameDesc r = new GRFrameDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator GRFrameDescStruct(GRFrameDesc r) {
	    GRFrameDescStruct m = new GRFrameDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class GRDummyFrameDesc : GRVisualDesc {
	public GRDummyFrameDesc() { _this = SprExport.Spr_new_GRDummyFrameDesc(); _flag = true; }
	public GRDummyFrameDesc(IntPtr ptr) : base(ptr) {}
	public GRDummyFrameDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRDummyFrameDesc() { if (_flag) { SprExport.Spr_delete_GRDummyFrameDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class GRDummyFrameDescStruct : GRVisualDescStruct {
        public GRDummyFrameDescStruct() {
            GRDummyFrameDesc desc = new GRDummyFrameDesc();
            ApplyFrom(desc, true);
        }
// _[Find class node: 2916] GRDummyFrameDesc
	public void ApplyTo(GRDummyFrameDesc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyTo((GRVisualDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(GRDummyFrameDesc r, bool apply_to_base_class=true) {
		if (apply_to_base_class) {
		    base.ApplyFrom((GRVisualDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator GRDummyFrameDesc(GRDummyFrameDescStruct m) {
	    GRDummyFrameDesc r = new GRDummyFrameDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator GRDummyFrameDescStruct(GRDummyFrameDesc r) {
	    GRDummyFrameDescStruct m = new GRDummyFrameDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class GRKey : CsObject {
	public GRKey() { _this = SprExport.Spr_new_GRKey(); _flag = true; }
	public GRKey(IntPtr ptr) : base(ptr) {}
	public GRKey(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRKey() { if (_flag) { SprExport.Spr_delete_GRKey(_this); _flag = false; } }
	public uint time {
	    get { return SprExport.Spr_GRKey_get_time(_this); }
	    set { SprExport.Spr_GRKey_set_time(_this, value); }
	}
        public vectorwrapper_float values {
            get { return new vectorwrapper_float(SprExport.Spr_GRKey_vector_addr_values(_this)); }
            set { SprExport.Spr_GRKey_vector_set_values(_this, value); }
        }
    }
    public partial class GRAnimationKey : CsObject {
	public GRAnimationKey() { _this = SprExport.Spr_new_GRAnimationKey(); _flag = true; }
	public GRAnimationKey(IntPtr ptr) : base(ptr) {}
	public GRAnimationKey(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRAnimationKey() { if (_flag) { SprExport.Spr_delete_GRAnimationKey(_this); _flag = false; } }
	public int keyType {
	    get { return SprExport.Spr_GRAnimationKey_get_keyType(_this); }
	    set { SprExport.Spr_GRAnimationKey_set_keyType(_this, value); }
	}
    public vectorwrapper_GRKey keys {
        get { return new vectorwrapper_GRKey(SprExport.Spr_GRAnimationKey_vector_get_keys(_this)); }
        set { SprExport.Spr_GRAnimationKey_vector_set_keys(_this, value._this); }
    }
    }
    public partial class GRAnimationDesc : CsObject {
	public GRAnimationDesc() { _this = SprExport.Spr_new_GRAnimationDesc(); _flag = true; }
	public GRAnimationDesc(IntPtr ptr) : base(ptr) {}
	public GRAnimationDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRAnimationDesc() { if (_flag) { SprExport.Spr_delete_GRAnimationDesc(_this); _flag = false; } }
    public vectorwrapper_GRAnimationKey keys {
        get { return new vectorwrapper_GRAnimationKey(SprExport.Spr_GRAnimationDesc_vector_get_keys(_this)); }
        set { SprExport.Spr_GRAnimationDesc_vector_set_keys(_this, value._this); }
    }
	public enum KeyType : int {
	    ROTATION = 0, SCALE = ROTATION + 1, POSITION = SCALE + 1, MATRIX = POSITION + 1
	}
    }
    [System.Serializable]
    public class GRAnimationDescStruct : CsObject {
        public GRAnimationDescStruct() {
            GRAnimationDesc desc = new GRAnimationDesc();
            ApplyFrom(desc, false);
        }
	public vectorwrapper_GRAnimationKey keys = new vectorwrapper_GRAnimationKey();
// _[Find class node: 2916] GRAnimationDesc
	public void ApplyTo(GRAnimationDesc r, bool apply_to_base_class=true) {
		r.keys.clear();
		int _GRAnimationDesc_count_0000 = keys.size();
		for (int i = 0; i < _GRAnimationDesc_count_0000; i++) {
			r.keys.push_back(keys[i]);
		}
	}
	public void ApplyFrom(GRAnimationDesc r, bool apply_to_base_class=true) {
		keys.clear();
		int _GRAnimationDesc_count_0000 = r.keys.size();
		for (int i = 0; i < _GRAnimationDesc_count_0000; i++) {
			keys.push_back(r.keys[i]);
		}
	}
	public static implicit operator GRAnimationDesc(GRAnimationDescStruct m) {
	    GRAnimationDesc r = new GRAnimationDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator GRAnimationDescStruct(GRAnimationDesc r) {
	    GRAnimationDescStruct m = new GRAnimationDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class GRAnimationSetDesc : CsObject {
	public GRAnimationSetDesc() { _this = SprExport.Spr_new_GRAnimationSetDesc(); _flag = true; }
	public GRAnimationSetDesc(IntPtr ptr) : base(ptr) {}
	public GRAnimationSetDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRAnimationSetDesc() { if (_flag) { SprExport.Spr_delete_GRAnimationSetDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class GRAnimationSetDescStruct : CsObject {
        public GRAnimationSetDescStruct() {
            GRAnimationSetDesc desc = new GRAnimationSetDesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] GRAnimationSetDesc
	public void ApplyTo(GRAnimationSetDesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(GRAnimationSetDesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator GRAnimationSetDesc(GRAnimationSetDescStruct m) {
	    GRAnimationSetDesc r = new GRAnimationSetDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator GRAnimationSetDescStruct(GRAnimationSetDesc r) {
	    GRAnimationSetDescStruct m = new GRAnimationSetDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class GRAnimationControllerDesc : CsObject {
	public GRAnimationControllerDesc() { _this = SprExport.Spr_new_GRAnimationControllerDesc(); _flag = true; }
	public GRAnimationControllerDesc(IntPtr ptr) : base(ptr) {}
	public GRAnimationControllerDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRAnimationControllerDesc() { if (_flag) { SprExport.Spr_delete_GRAnimationControllerDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class GRAnimationControllerDescStruct : CsObject {
        public GRAnimationControllerDescStruct() {
            GRAnimationControllerDesc desc = new GRAnimationControllerDesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] GRAnimationControllerDesc
	public void ApplyTo(GRAnimationControllerDesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(GRAnimationControllerDesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator GRAnimationControllerDesc(GRAnimationControllerDescStruct m) {
	    GRAnimationControllerDesc r = new GRAnimationControllerDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator GRAnimationControllerDescStruct(GRAnimationControllerDesc r) {
	    GRAnimationControllerDescStruct m = new GRAnimationControllerDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class GRBlendMeshDesc : CsObject {
	public GRBlendMeshDesc() { _this = SprExport.Spr_new_GRBlendMeshDesc(); _flag = true; }
	public GRBlendMeshDesc(IntPtr ptr) : base(ptr) {}
	public GRBlendMeshDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRBlendMeshDesc() { if (_flag) { SprExport.Spr_delete_GRBlendMeshDesc(_this); _flag = false; } }
    public vectorwrapper_Vec3f positions {
        get { return new vectorwrapper_Vec3f(SprExport.Spr_GRBlendMeshDesc_vector_get_positions(_this)); }
        set { SprExport.Spr_GRBlendMeshDesc_vector_set_positions(_this, value._this); }
    }
    public vectorwrapper_Vec3f normals {
        get { return new vectorwrapper_Vec3f(SprExport.Spr_GRBlendMeshDesc_vector_get_normals(_this)); }
        set { SprExport.Spr_GRBlendMeshDesc_vector_set_normals(_this, value._this); }
    }
    public vectorwrapper_Vec4f colors {
        get { return new vectorwrapper_Vec4f(SprExport.Spr_GRBlendMeshDesc_vector_get_colors(_this)); }
        set { SprExport.Spr_GRBlendMeshDesc_vector_set_colors(_this, value._this); }
    }
    public vectorwrapper_Vec2f texCoords {
        get { return new vectorwrapper_Vec2f(SprExport.Spr_GRBlendMeshDesc_vector_get_texCoords(_this)); }
        set { SprExport.Spr_GRBlendMeshDesc_vector_set_texCoords(_this, value._this); }
    }
        public vectorwrapper_size_t faces {
            get { return new vectorwrapper_size_t(SprExport.Spr_GRBlendMeshDesc_vector_addr_faces(_this)); }
            set { SprExport.Spr_GRBlendMeshDesc_vector_set_faces(_this, value); }
        }
    public vectorwrapper_Vec4f blends {
        get { return new vectorwrapper_Vec4f(SprExport.Spr_GRBlendMeshDesc_vector_get_blends(_this)); }
        set { SprExport.Spr_GRBlendMeshDesc_vector_set_blends(_this, value._this); }
    }
    public vectorwrapper_Vec4f matrixIndices {
        get { return new vectorwrapper_Vec4f(SprExport.Spr_GRBlendMeshDesc_vector_get_matrixIndices(_this)); }
        set { SprExport.Spr_GRBlendMeshDesc_vector_set_matrixIndices(_this, value._this); }
    }
    public vectorwrapper_Vec4f numMatrix {
        get { return new vectorwrapper_Vec4f(SprExport.Spr_GRBlendMeshDesc_vector_get_numMatrix(_this)); }
        set { SprExport.Spr_GRBlendMeshDesc_vector_set_numMatrix(_this, value._this); }
    }
    }
    [System.Serializable]
    public class GRBlendMeshDescStruct : CsObject {
        public GRBlendMeshDescStruct() {
            GRBlendMeshDesc desc = new GRBlendMeshDesc();
            ApplyFrom(desc, false);
        }
	public vectorwrapper_Vec3f positions = new vectorwrapper_Vec3f();
	public vectorwrapper_Vec3f normals = new vectorwrapper_Vec3f();
	public vectorwrapper_Vec4f colors = new vectorwrapper_Vec4f();
	public vectorwrapper_Vec2f texCoords = new vectorwrapper_Vec2f();
	public vectorwrapper_size_t faces = new vectorwrapper_size_t();
	public vectorwrapper_Vec4f blends = new vectorwrapper_Vec4f();
	public vectorwrapper_Vec4f matrixIndices = new vectorwrapper_Vec4f();
	public vectorwrapper_Vec4f numMatrix = new vectorwrapper_Vec4f();
// _[Find class node: 2916] GRBlendMeshDesc
	public void ApplyTo(GRBlendMeshDesc r, bool apply_to_base_class=true) {
		r.positions.clear();
		int _GRBlendMeshDesc_count_0000 = positions.size();
		for (int i = 0; i < _GRBlendMeshDesc_count_0000; i++) {
			r.positions.push_back(positions[i]);
		}
		r.normals.clear();
		int _GRBlendMeshDesc_count_0001 = normals.size();
		for (int i = 0; i < _GRBlendMeshDesc_count_0001; i++) {
			r.normals.push_back(normals[i]);
		}
		r.colors.clear();
		int _GRBlendMeshDesc_count_0002 = colors.size();
		for (int i = 0; i < _GRBlendMeshDesc_count_0002; i++) {
			r.colors.push_back(colors[i]);
		}
		r.texCoords.clear();
		int _GRBlendMeshDesc_count_0003 = texCoords.size();
		for (int i = 0; i < _GRBlendMeshDesc_count_0003; i++) {
			r.texCoords.push_back(texCoords[i]);
		}
		r.faces.clear();
		int _GRBlendMeshDesc_count_0004 = faces.size();
		for (int i = 0; i < _GRBlendMeshDesc_count_0004; i++) {
			r.faces.push_back(faces[i]);
		}
		r.blends.clear();
		int _GRBlendMeshDesc_count_0005 = blends.size();
		for (int i = 0; i < _GRBlendMeshDesc_count_0005; i++) {
			r.blends.push_back(blends[i]);
		}
		r.matrixIndices.clear();
		int _GRBlendMeshDesc_count_0006 = matrixIndices.size();
		for (int i = 0; i < _GRBlendMeshDesc_count_0006; i++) {
			r.matrixIndices.push_back(matrixIndices[i]);
		}
		r.numMatrix.clear();
		int _GRBlendMeshDesc_count_0007 = numMatrix.size();
		for (int i = 0; i < _GRBlendMeshDesc_count_0007; i++) {
			r.numMatrix.push_back(numMatrix[i]);
		}
	}
	public void ApplyFrom(GRBlendMeshDesc r, bool apply_to_base_class=true) {
		positions.clear();
		int _GRBlendMeshDesc_count_0000 = r.positions.size();
		for (int i = 0; i < _GRBlendMeshDesc_count_0000; i++) {
			positions.push_back(r.positions[i]);
		}
		normals.clear();
		int _GRBlendMeshDesc_count_0001 = r.normals.size();
		for (int i = 0; i < _GRBlendMeshDesc_count_0001; i++) {
			normals.push_back(r.normals[i]);
		}
		colors.clear();
		int _GRBlendMeshDesc_count_0002 = r.colors.size();
		for (int i = 0; i < _GRBlendMeshDesc_count_0002; i++) {
			colors.push_back(r.colors[i]);
		}
		texCoords.clear();
		int _GRBlendMeshDesc_count_0003 = r.texCoords.size();
		for (int i = 0; i < _GRBlendMeshDesc_count_0003; i++) {
			texCoords.push_back(r.texCoords[i]);
		}
		faces.clear();
		int _GRBlendMeshDesc_count_0004 = r.faces.size();
		for (int i = 0; i < _GRBlendMeshDesc_count_0004; i++) {
			faces.push_back(r.faces[i]);
		}
		blends.clear();
		int _GRBlendMeshDesc_count_0005 = r.blends.size();
		for (int i = 0; i < _GRBlendMeshDesc_count_0005; i++) {
			blends.push_back(r.blends[i]);
		}
		matrixIndices.clear();
		int _GRBlendMeshDesc_count_0006 = r.matrixIndices.size();
		for (int i = 0; i < _GRBlendMeshDesc_count_0006; i++) {
			matrixIndices.push_back(r.matrixIndices[i]);
		}
		numMatrix.clear();
		int _GRBlendMeshDesc_count_0007 = r.numMatrix.size();
		for (int i = 0; i < _GRBlendMeshDesc_count_0007; i++) {
			numMatrix.push_back(r.numMatrix[i]);
		}
	}
	public static implicit operator GRBlendMeshDesc(GRBlendMeshDescStruct m) {
	    GRBlendMeshDesc r = new GRBlendMeshDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator GRBlendMeshDescStruct(GRBlendMeshDesc r) {
	    GRBlendMeshDescStruct m = new GRBlendMeshDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class GRMeshFace : CsObject {
	public GRMeshFace() { _this = SprExport.Spr_new_GRMeshFace(); _flag = true; }
	public GRMeshFace(IntPtr ptr) : base(ptr) {}
	public GRMeshFace(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRMeshFace() { if (_flag) { SprExport.Spr_delete_GRMeshFace(_this); _flag = false; } }
	public int nVertices {
	    get { return SprExport.Spr_GRMeshFace_get_nVertices(_this); }
	    set { SprExport.Spr_GRMeshFace_set_nVertices(_this, value); }
	}
        public arraywrapper_int indices {
            get { arraywrapper_int wapper = new arraywrapper_int(SprExport.Spr_GRMeshFace_array_addr_indices(_this), 4);
                  return wapper;
            }
            set { SprExport.Spr_GRMeshFace_array_set_indices(_this, value); }
        }
    }
    public partial class GRSkinWeightDesc : CsObject {
	public GRSkinWeightDesc() { _this = SprExport.Spr_new_GRSkinWeightDesc(); _flag = true; }
	public GRSkinWeightDesc(IntPtr ptr) : base(ptr) {}
	public GRSkinWeightDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRSkinWeightDesc() { if (_flag) { SprExport.Spr_delete_GRSkinWeightDesc(_this); _flag = false; } }
	public Affinef offset {
	    get { return new Affinef(SprExport.Spr_GRSkinWeightDesc_addr_offset(_this)); }
	    set { SprExport.Spr_GRSkinWeightDesc_set_offset(_this, value); }
	}
        public vectorwrapper_unsigned_int indices {
            get { return new vectorwrapper_unsigned_int(SprExport.Spr_GRSkinWeightDesc_vector_addr_indices(_this)); }
            set { SprExport.Spr_GRSkinWeightDesc_vector_set_indices(_this, value); }
        }
        public vectorwrapper_float weights {
            get { return new vectorwrapper_float(SprExport.Spr_GRSkinWeightDesc_vector_addr_weights(_this)); }
            set { SprExport.Spr_GRSkinWeightDesc_vector_set_weights(_this, value); }
        }
    }
    [System.Serializable]
    public class GRSkinWeightDescStruct : CsObject {
        public GRSkinWeightDescStruct() {
            GRSkinWeightDesc desc = new GRSkinWeightDesc();
            ApplyFrom(desc, false);
        }
	public AffinefStruct offset;
	public vectorwrapper_unsigned_int indices = new vectorwrapper_unsigned_int();
	public vectorwrapper_float weights = new vectorwrapper_float();
// _[Find class node: 2916] GRSkinWeightDesc
	public void ApplyTo(GRSkinWeightDesc r, bool apply_to_base_class=true) {
		r.offset = offset;
		r.indices.clear();
		int _GRSkinWeightDesc_count_0001 = indices.size();
		for (int i = 0; i < _GRSkinWeightDesc_count_0001; i++) {
			r.indices.push_back(indices[i]);
		}
		r.weights.clear();
		int _GRSkinWeightDesc_count_0002 = weights.size();
		for (int i = 0; i < _GRSkinWeightDesc_count_0002; i++) {
			r.weights.push_back(weights[i]);
		}
	}
	public void ApplyFrom(GRSkinWeightDesc r, bool apply_to_base_class=true) {
		offset = r.offset;
		indices.clear();
		int _GRSkinWeightDesc_count_0001 = r.indices.size();
		for (int i = 0; i < _GRSkinWeightDesc_count_0001; i++) {
			indices.push_back(r.indices[i]);
		}
		weights.clear();
		int _GRSkinWeightDesc_count_0002 = r.weights.size();
		for (int i = 0; i < _GRSkinWeightDesc_count_0002; i++) {
			weights.push_back(r.weights[i]);
		}
	}
	public static implicit operator GRSkinWeightDesc(GRSkinWeightDescStruct m) {
	    GRSkinWeightDesc r = new GRSkinWeightDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator GRSkinWeightDescStruct(GRSkinWeightDesc r) {
	    GRSkinWeightDescStruct m = new GRSkinWeightDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class GRMeshDesc : GRVisualDesc {
	public GRMeshDesc() { _this = SprExport.Spr_new_GRMeshDesc(); _flag = true; }
	public GRMeshDesc(IntPtr ptr) : base(ptr) {}
	public GRMeshDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRMeshDesc() { if (_flag) { SprExport.Spr_delete_GRMeshDesc(_this); _flag = false; } }
    public vectorwrapper_Vec3f vertices {
        get { return new vectorwrapper_Vec3f(SprExport.Spr_GRMeshDesc_vector_get_vertices(_this)); }
        set { SprExport.Spr_GRMeshDesc_vector_set_vertices(_this, value._this); }
    }
    public vectorwrapper_GRMeshFace faces {
        get { return new vectorwrapper_GRMeshFace(SprExport.Spr_GRMeshDesc_vector_get_faces(_this)); }
        set { SprExport.Spr_GRMeshDesc_vector_set_faces(_this, value._this); }
    }
    public vectorwrapper_Vec3f normals {
        get { return new vectorwrapper_Vec3f(SprExport.Spr_GRMeshDesc_vector_get_normals(_this)); }
        set { SprExport.Spr_GRMeshDesc_vector_set_normals(_this, value._this); }
    }
    public vectorwrapper_GRMeshFace faceNormals {
        get { return new vectorwrapper_GRMeshFace(SprExport.Spr_GRMeshDesc_vector_get_faceNormals(_this)); }
        set { SprExport.Spr_GRMeshDesc_vector_set_faceNormals(_this, value._this); }
    }
    public vectorwrapper_Vec4f colors {
        get { return new vectorwrapper_Vec4f(SprExport.Spr_GRMeshDesc_vector_get_colors(_this)); }
        set { SprExport.Spr_GRMeshDesc_vector_set_colors(_this, value._this); }
    }
    public vectorwrapper_Vec2f texCoords {
        get { return new vectorwrapper_Vec2f(SprExport.Spr_GRMeshDesc_vector_get_texCoords(_this)); }
        set { SprExport.Spr_GRMeshDesc_vector_set_texCoords(_this, value._this); }
    }
        public vectorwrapper_int materialList {
            get { return new vectorwrapper_int(SprExport.Spr_GRMeshDesc_vector_addr_materialList(_this)); }
            set { SprExport.Spr_GRMeshDesc_vector_set_materialList(_this, value); }
        }
    }
    [System.Serializable]
    public class GRMeshDescStruct : GRVisualDescStruct {
        public GRMeshDescStruct() {
            GRMeshDesc desc = new GRMeshDesc();
            ApplyFrom(desc, true);
        }
	public vectorwrapper_Vec3f vertices = new vectorwrapper_Vec3f();
	public vectorwrapper_GRMeshFace faces = new vectorwrapper_GRMeshFace();
	public vectorwrapper_Vec3f normals = new vectorwrapper_Vec3f();
	public vectorwrapper_GRMeshFace faceNormals = new vectorwrapper_GRMeshFace();
	public vectorwrapper_Vec4f colors = new vectorwrapper_Vec4f();
	public vectorwrapper_Vec2f texCoords = new vectorwrapper_Vec2f();
	public vectorwrapper_int materialList = new vectorwrapper_int();
// _[Find class node: 2916] GRMeshDesc
	public void ApplyTo(GRMeshDesc r, bool apply_to_base_class=true) {
		r.vertices.clear();
		int _GRMeshDesc_count_0000 = vertices.size();
		for (int i = 0; i < _GRMeshDesc_count_0000; i++) {
			r.vertices.push_back(vertices[i]);
		}
		r.faces.clear();
		int _GRMeshDesc_count_0001 = faces.size();
		for (int i = 0; i < _GRMeshDesc_count_0001; i++) {
			r.faces.push_back(faces[i]);
		}
		r.normals.clear();
		int _GRMeshDesc_count_0002 = normals.size();
		for (int i = 0; i < _GRMeshDesc_count_0002; i++) {
			r.normals.push_back(normals[i]);
		}
		r.faceNormals.clear();
		int _GRMeshDesc_count_0003 = faceNormals.size();
		for (int i = 0; i < _GRMeshDesc_count_0003; i++) {
			r.faceNormals.push_back(faceNormals[i]);
		}
		r.colors.clear();
		int _GRMeshDesc_count_0004 = colors.size();
		for (int i = 0; i < _GRMeshDesc_count_0004; i++) {
			r.colors.push_back(colors[i]);
		}
		r.texCoords.clear();
		int _GRMeshDesc_count_0005 = texCoords.size();
		for (int i = 0; i < _GRMeshDesc_count_0005; i++) {
			r.texCoords.push_back(texCoords[i]);
		}
		r.materialList.clear();
		int _GRMeshDesc_count_0006 = materialList.size();
		for (int i = 0; i < _GRMeshDesc_count_0006; i++) {
			r.materialList.push_back(materialList[i]);
		}
		if (apply_to_base_class) {
		    base.ApplyTo((GRVisualDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(GRMeshDesc r, bool apply_to_base_class=true) {
		vertices.clear();
		int _GRMeshDesc_count_0000 = r.vertices.size();
		for (int i = 0; i < _GRMeshDesc_count_0000; i++) {
			vertices.push_back(r.vertices[i]);
		}
		faces.clear();
		int _GRMeshDesc_count_0001 = r.faces.size();
		for (int i = 0; i < _GRMeshDesc_count_0001; i++) {
			faces.push_back(r.faces[i]);
		}
		normals.clear();
		int _GRMeshDesc_count_0002 = r.normals.size();
		for (int i = 0; i < _GRMeshDesc_count_0002; i++) {
			normals.push_back(r.normals[i]);
		}
		faceNormals.clear();
		int _GRMeshDesc_count_0003 = r.faceNormals.size();
		for (int i = 0; i < _GRMeshDesc_count_0003; i++) {
			faceNormals.push_back(r.faceNormals[i]);
		}
		colors.clear();
		int _GRMeshDesc_count_0004 = r.colors.size();
		for (int i = 0; i < _GRMeshDesc_count_0004; i++) {
			colors.push_back(r.colors[i]);
		}
		texCoords.clear();
		int _GRMeshDesc_count_0005 = r.texCoords.size();
		for (int i = 0; i < _GRMeshDesc_count_0005; i++) {
			texCoords.push_back(r.texCoords[i]);
		}
		materialList.clear();
		int _GRMeshDesc_count_0006 = r.materialList.size();
		for (int i = 0; i < _GRMeshDesc_count_0006; i++) {
			materialList.push_back(r.materialList[i]);
		}
		if (apply_to_base_class) {
		    base.ApplyFrom((GRVisualDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator GRMeshDesc(GRMeshDescStruct m) {
	    GRMeshDesc r = new GRMeshDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator GRMeshDescStruct(GRMeshDesc r) {
	    GRMeshDescStruct m = new GRMeshDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class GRFont : CsObject {
	public GRFont() { _this = SprExport.Spr_new_GRFont(); _flag = true; }
	public GRFont(IntPtr ptr) : base(ptr) {}
	public GRFont(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public GRFont(int h, string f) { _this = SprExport.Spr_new_GRFont_8(h, f); _flag = true; }
	public GRFont(int h) { _this = SprExport.Spr_new_GRFont_9(h); _flag = true; }
	~GRFont() { if (_flag) { SprExport.Spr_delete_GRFont(_this); _flag = false; } }
	public int height {
	    get { return SprExport.Spr_GRFont_get_height(_this); }
	    set { SprExport.Spr_GRFont_set_height(_this, value); }
	}
	public int width {
	    get { return SprExport.Spr_GRFont_get_width(_this); }
	    set { SprExport.Spr_GRFont_set_width(_this, value); }
	}
	public int weight {
	    get { return SprExport.Spr_GRFont_get_weight(_this); }
	    set { SprExport.Spr_GRFont_set_weight(_this, value); }
	}
	public string face {
	    get {
	        IntPtr ptr = SprExport.Spr_GRFont_get_face(_this);
	        string bstr = Marshal.PtrToStringBSTR(ptr);
	        SprExport.Spr_GRFont_FreeString_face(ptr);
	        return bstr;
	    }
	    set {
	        IntPtr pbstr = Marshal.StringToBSTR(value);
	        SprExport.Spr_GRFont_set_face(_this, pbstr);
	    }
	}
	public uint color {
	    get { return SprExport.Spr_GRFont_get_color(_this); }
	    set { SprExport.Spr_GRFont_set_color(_this, value); }
	}
	public bool bItalic {
	    get {
	        byte ret = (byte) SprExport.Spr_GRFont_get_bItalic(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_GRFont_set_bItalic(_this, (char) val);
	    }
	}
	public void SetColor(uint c) {
	    SprExport.Spr_GRFont_SetColor((IntPtr) _this, (uint) c);
	}
    }
    public partial class GRLightDesc : GRVisualDesc {
	public GRLightDesc() { _this = SprExport.Spr_new_GRLightDesc(); _flag = true; }
	public GRLightDesc(IntPtr ptr) : base(ptr) {}
	public GRLightDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRLightDesc() { if (_flag) { SprExport.Spr_delete_GRLightDesc(_this); _flag = false; } }
	public Vec4f ambient {
	    get { return new Vec4f(SprExport.Spr_GRLightDesc_addr_ambient(_this)); }
	    set { SprExport.Spr_GRLightDesc_set_ambient(_this, value); }
	}
	public Vec4f diffuse {
	    get { return new Vec4f(SprExport.Spr_GRLightDesc_addr_diffuse(_this)); }
	    set { SprExport.Spr_GRLightDesc_set_diffuse(_this, value); }
	}
	public Vec4f specular {
	    get { return new Vec4f(SprExport.Spr_GRLightDesc_addr_specular(_this)); }
	    set { SprExport.Spr_GRLightDesc_set_specular(_this, value); }
	}
	public Vec4f position {
	    get { return new Vec4f(SprExport.Spr_GRLightDesc_addr_position(_this)); }
	    set { SprExport.Spr_GRLightDesc_set_position(_this, value); }
	}
	public float range {
	    get { return SprExport.Spr_GRLightDesc_get_range(_this); }
	    set { SprExport.Spr_GRLightDesc_set_range(_this, value); }
	}
	public float attenuation0 {
	    get { return SprExport.Spr_GRLightDesc_get_attenuation0(_this); }
	    set { SprExport.Spr_GRLightDesc_set_attenuation0(_this, value); }
	}
	public float attenuation1 {
	    get { return SprExport.Spr_GRLightDesc_get_attenuation1(_this); }
	    set { SprExport.Spr_GRLightDesc_set_attenuation1(_this, value); }
	}
	public float attenuation2 {
	    get { return SprExport.Spr_GRLightDesc_get_attenuation2(_this); }
	    set { SprExport.Spr_GRLightDesc_set_attenuation2(_this, value); }
	}
	public Vec3f spotDirection {
	    get { return new Vec3f(SprExport.Spr_GRLightDesc_addr_spotDirection(_this)); }
	    set { SprExport.Spr_GRLightDesc_set_spotDirection(_this, value); }
	}
	public float spotFalloff {
	    get { return SprExport.Spr_GRLightDesc_get_spotFalloff(_this); }
	    set { SprExport.Spr_GRLightDesc_set_spotFalloff(_this, value); }
	}
	public float spotInner {
	    get { return SprExport.Spr_GRLightDesc_get_spotInner(_this); }
	    set { SprExport.Spr_GRLightDesc_set_spotInner(_this, value); }
	}
	public float spotCutoff {
	    get { return SprExport.Spr_GRLightDesc_get_spotCutoff(_this); }
	    set { SprExport.Spr_GRLightDesc_set_spotCutoff(_this, value); }
	}
    }
    [System.Serializable]
    public class GRLightDescStruct : GRVisualDescStruct {
        public GRLightDescStruct() {
            GRLightDesc desc = new GRLightDesc();
            ApplyFrom(desc, true);
        }
	public Vec4fStruct ambient;
	public Vec4fStruct diffuse;
	public Vec4fStruct specular;
	public Vec4fStruct position;
	public float range;
	public float attenuation0;
	public float attenuation1;
	public float attenuation2;
	public Vec3fStruct spotDirection;
	public float spotFalloff;
	public float spotInner;
	public float spotCutoff;
// _[Find class node: 2916] GRLightDesc
	public void ApplyTo(GRLightDesc r, bool apply_to_base_class=true) {
		r.ambient = ambient;
		r.diffuse = diffuse;
		r.specular = specular;
		r.position = position;
		r.range = range;
		r.attenuation0 = attenuation0;
		r.attenuation1 = attenuation1;
		r.attenuation2 = attenuation2;
		r.spotDirection = spotDirection;
		r.spotFalloff = spotFalloff;
		r.spotInner = spotInner;
		r.spotCutoff = spotCutoff;
		if (apply_to_base_class) {
		    base.ApplyTo((GRVisualDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(GRLightDesc r, bool apply_to_base_class=true) {
		ambient = r.ambient;
		diffuse = r.diffuse;
		specular = r.specular;
		position = r.position;
		range = r.range;
		attenuation0 = r.attenuation0;
		attenuation1 = r.attenuation1;
		attenuation2 = r.attenuation2;
		spotDirection = r.spotDirection;
		spotFalloff = r.spotFalloff;
		spotInner = r.spotInner;
		spotCutoff = r.spotCutoff;
		if (apply_to_base_class) {
		    base.ApplyFrom((GRVisualDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator GRLightDesc(GRLightDescStruct m) {
	    GRLightDesc r = new GRLightDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator GRLightDescStruct(GRLightDesc r) {
	    GRLightDescStruct m = new GRLightDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class GRMaterialDesc : GRVisualDesc {
	public GRMaterialDesc() { _this = SprExport.Spr_new_GRMaterialDesc(); _flag = true; }
	public GRMaterialDesc(IntPtr ptr) : base(ptr) {}
	public GRMaterialDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public GRMaterialDesc(Vec4f a, Vec4f d, Vec4f s, Vec4f e, float p) { _this = SprExport.Spr_new_GRMaterialDesc_8(a, d, s, e, p); _flag = true; }
	public GRMaterialDesc(Vec4f c, float p) { _this = SprExport.Spr_new_GRMaterialDesc_9(c, p); _flag = true; }
	public GRMaterialDesc(Vec4f c) { _this = SprExport.Spr_new_GRMaterialDesc_10(c); _flag = true; }
	~GRMaterialDesc() { if (_flag) { SprExport.Spr_delete_GRMaterialDesc(_this); _flag = false; } }
	public Vec4f ambient {
	    get { return new Vec4f(SprExport.Spr_GRMaterialDesc_addr_ambient(_this)); }
	    set { SprExport.Spr_GRMaterialDesc_set_ambient(_this, value); }
	}
	public Vec4f diffuse {
	    get { return new Vec4f(SprExport.Spr_GRMaterialDesc_addr_diffuse(_this)); }
	    set { SprExport.Spr_GRMaterialDesc_set_diffuse(_this, value); }
	}
	public Vec4f specular {
	    get { return new Vec4f(SprExport.Spr_GRMaterialDesc_addr_specular(_this)); }
	    set { SprExport.Spr_GRMaterialDesc_set_specular(_this, value); }
	}
	public Vec4f emissive {
	    get { return new Vec4f(SprExport.Spr_GRMaterialDesc_addr_emissive(_this)); }
	    set { SprExport.Spr_GRMaterialDesc_set_emissive(_this, value); }
	}
	public float power {
	    get { return SprExport.Spr_GRMaterialDesc_get_power(_this); }
	    set { SprExport.Spr_GRMaterialDesc_set_power(_this, value); }
	}
	public string texname {
	    get {
	        IntPtr ptr = SprExport.Spr_GRMaterialDesc_get_texname(_this);
	        string bstr = Marshal.PtrToStringBSTR(ptr);
	        SprExport.Spr_GRMaterialDesc_FreeString_texname(ptr);
	        return bstr;
	    }
	    set {
	        IntPtr pbstr = Marshal.StringToBSTR(value);
	        SprExport.Spr_GRMaterialDesc_set_texname(_this, pbstr);
	    }
	}
	public bool IsOpaque() {
	    char ret = SprExport.Spr_GRMaterialDesc_IsOpaque((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public bool Is3D() {
	    char ret = SprExport.Spr_GRMaterialDesc_Is3D((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
    }
    [System.Serializable]
    public class GRMaterialDescStruct : GRVisualDescStruct {
        public GRMaterialDescStruct() {
            GRMaterialDesc desc = new GRMaterialDesc();
            ApplyFrom(desc, true);
        }
	public Vec4fStruct ambient;
	public Vec4fStruct diffuse;
	public Vec4fStruct specular;
	public Vec4fStruct emissive;
	public float power;
	public string texname;
// _[Find class node: 2916] GRMaterialDesc
	public void ApplyTo(GRMaterialDesc r, bool apply_to_base_class=true) {
		r.ambient = ambient;
		r.diffuse = diffuse;
		r.specular = specular;
		r.emissive = emissive;
		r.power = power;
		r.texname = texname;
		if (apply_to_base_class) {
		    base.ApplyTo((GRVisualDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(GRMaterialDesc r, bool apply_to_base_class=true) {
		ambient = r.ambient;
		diffuse = r.diffuse;
		specular = r.specular;
		emissive = r.emissive;
		power = r.power;
		texname = r.texname;
		if (apply_to_base_class) {
		    base.ApplyFrom((GRVisualDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator GRMaterialDesc(GRMaterialDescStruct m) {
	    GRMaterialDesc r = new GRMaterialDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator GRMaterialDescStruct(GRMaterialDesc r) {
	    GRMaterialDescStruct m = new GRMaterialDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class GRCameraDesc : GRVisualDesc {
	public GRCameraDesc() { _this = SprExport.Spr_new_GRCameraDesc(); _flag = true; }
	public GRCameraDesc(IntPtr ptr) : base(ptr) {}
	public GRCameraDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public GRCameraDesc(Vec2f sz, Vec2f c, float f, float b, int t) { _this = SprExport.Spr_new_GRCameraDesc_7(sz, c, f, b, t); _flag = true; }
	public GRCameraDesc(Vec2f sz, Vec2f c, float f, float b) { _this = SprExport.Spr_new_GRCameraDesc_8(sz, c, f, b); _flag = true; }
	public GRCameraDesc(Vec2f sz, Vec2f c, float f) { _this = SprExport.Spr_new_GRCameraDesc_9(sz, c, f); _flag = true; }
	public GRCameraDesc(Vec2f sz, Vec2f c) { _this = SprExport.Spr_new_GRCameraDesc_10(sz, c); _flag = true; }
	public GRCameraDesc(Vec2f sz) { _this = SprExport.Spr_new_GRCameraDesc_11(sz); _flag = true; }
	~GRCameraDesc() { if (_flag) { SprExport.Spr_delete_GRCameraDesc(_this); _flag = false; } }
	public Vec2f size {
	    get { return new Vec2f(SprExport.Spr_GRCameraDesc_addr_size(_this)); }
	    set { SprExport.Spr_GRCameraDesc_set_size(_this, value); }
	}
	public Vec2f center {
	    get { return new Vec2f(SprExport.Spr_GRCameraDesc_addr_center(_this)); }
	    set { SprExport.Spr_GRCameraDesc_set_center(_this, value); }
	}
	public float front {
	    get { return SprExport.Spr_GRCameraDesc_get_front(_this); }
	    set { SprExport.Spr_GRCameraDesc_set_front(_this, value); }
	}
	public float back {
	    get { return SprExport.Spr_GRCameraDesc_get_back(_this); }
	    set { SprExport.Spr_GRCameraDesc_set_back(_this, value); }
	}
	public int type {
	    get { return SprExport.Spr_GRCameraDesc_get_type(_this); }
	    set { SprExport.Spr_GRCameraDesc_set_type(_this, value); }
	}
    }
    [System.Serializable]
    public class GRCameraDescStruct : GRVisualDescStruct {
        public GRCameraDescStruct() {
            GRCameraDesc desc = new GRCameraDesc();
            ApplyFrom(desc, true);
        }
	public Vec2fStruct size;
	public Vec2fStruct center;
	public float front;
	public float back;
	public int type;
// _[Find class node: 2916] GRCameraDesc
	public void ApplyTo(GRCameraDesc r, bool apply_to_base_class=true) {
		r.size = size;
		r.center = center;
		r.front = front;
		r.back = back;
		r.type = type;
		if (apply_to_base_class) {
		    base.ApplyTo((GRVisualDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(GRCameraDesc r, bool apply_to_base_class=true) {
		size = r.size;
		center = r.center;
		front = r.front;
		back = r.back;
		type = r.type;
		if (apply_to_base_class) {
		    base.ApplyFrom((GRVisualDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator GRCameraDesc(GRCameraDescStruct m) {
	    GRCameraDesc r = new GRCameraDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator GRCameraDescStruct(GRCameraDesc r) {
	    GRCameraDescStruct m = new GRCameraDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class GRShadowLightDesc : GRVisualDesc {
	public GRShadowLightDesc() { _this = SprExport.Spr_new_GRShadowLightDesc(); _flag = true; }
	public GRShadowLightDesc(IntPtr ptr) : base(ptr) {}
	public GRShadowLightDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRShadowLightDesc() { if (_flag) { SprExport.Spr_delete_GRShadowLightDesc(_this); _flag = false; } }
	public bool directional {
	    get {
	        byte ret = (byte) SprExport.Spr_GRShadowLightDesc_get_directional(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_GRShadowLightDesc_set_directional(_this, (char) val);
	    }
	}
	public Vec3f position {
	    get { return new Vec3f(SprExport.Spr_GRShadowLightDesc_addr_position(_this)); }
	    set { SprExport.Spr_GRShadowLightDesc_set_position(_this, value); }
	}
	public Vec3f lookat {
	    get { return new Vec3f(SprExport.Spr_GRShadowLightDesc_addr_lookat(_this)); }
	    set { SprExport.Spr_GRShadowLightDesc_set_lookat(_this, value); }
	}
	public Vec3f up {
	    get { return new Vec3f(SprExport.Spr_GRShadowLightDesc_addr_up(_this)); }
	    set { SprExport.Spr_GRShadowLightDesc_set_up(_this, value); }
	}
	public Vec2f size {
	    get { return new Vec2f(SprExport.Spr_GRShadowLightDesc_addr_size(_this)); }
	    set { SprExport.Spr_GRShadowLightDesc_set_size(_this, value); }
	}
	public float fov {
	    get { return SprExport.Spr_GRShadowLightDesc_get_fov(_this); }
	    set { SprExport.Spr_GRShadowLightDesc_set_fov(_this, value); }
	}
	public float front {
	    get { return SprExport.Spr_GRShadowLightDesc_get_front(_this); }
	    set { SprExport.Spr_GRShadowLightDesc_set_front(_this, value); }
	}
	public float back {
	    get { return SprExport.Spr_GRShadowLightDesc_get_back(_this); }
	    set { SprExport.Spr_GRShadowLightDesc_set_back(_this, value); }
	}
	public int texWidth {
	    get { return SprExport.Spr_GRShadowLightDesc_get_texWidth(_this); }
	    set { SprExport.Spr_GRShadowLightDesc_set_texWidth(_this, value); }
	}
	public int texHeight {
	    get { return SprExport.Spr_GRShadowLightDesc_get_texHeight(_this); }
	    set { SprExport.Spr_GRShadowLightDesc_set_texHeight(_this, value); }
	}
	public float offset {
	    get { return SprExport.Spr_GRShadowLightDesc_get_offset(_this); }
	    set { SprExport.Spr_GRShadowLightDesc_set_offset(_this, value); }
	}
	public Vec4f color {
	    get { return new Vec4f(SprExport.Spr_GRShadowLightDesc_addr_color(_this)); }
	    set { SprExport.Spr_GRShadowLightDesc_set_color(_this, value); }
	}
    }
    [System.Serializable]
    public class GRShadowLightDescStruct : GRVisualDescStruct {
        public GRShadowLightDescStruct() {
            GRShadowLightDesc desc = new GRShadowLightDesc();
            ApplyFrom(desc, true);
        }
	public bool directional;
	public Vec3fStruct position;
	public Vec3fStruct lookat;
	public Vec3fStruct up;
	public Vec2fStruct size;
	public float fov;
	public float front;
	public float back;
	public int texWidth;
	public int texHeight;
	public float offset;
	public Vec4fStruct color;
// _[Find class node: 2916] GRShadowLightDesc
	public void ApplyTo(GRShadowLightDesc r, bool apply_to_base_class=true) {
		r.directional = directional;
		r.position = position;
		r.lookat = lookat;
		r.up = up;
		r.size = size;
		r.fov = fov;
		r.front = front;
		r.back = back;
		r.texWidth = texWidth;
		r.texHeight = texHeight;
		r.offset = offset;
		r.color = color;
		if (apply_to_base_class) {
		    base.ApplyTo((GRVisualDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(GRShadowLightDesc r, bool apply_to_base_class=true) {
		directional = r.directional;
		position = r.position;
		lookat = r.lookat;
		up = r.up;
		size = r.size;
		fov = r.fov;
		front = r.front;
		back = r.back;
		texWidth = r.texWidth;
		texHeight = r.texHeight;
		offset = r.offset;
		color = r.color;
		if (apply_to_base_class) {
		    base.ApplyFrom((GRVisualDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator GRShadowLightDesc(GRShadowLightDescStruct m) {
	    GRShadowLightDesc r = new GRShadowLightDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator GRShadowLightDescStruct(GRShadowLightDesc r) {
	    GRShadowLightDescStruct m = new GRShadowLightDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class GRSceneDesc : CsObject {
	public GRSceneDesc() { _this = SprExport.Spr_new_GRSceneDesc(); _flag = true; }
	public GRSceneDesc(IntPtr ptr) : base(ptr) {}
	public GRSceneDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRSceneDesc() { if (_flag) { SprExport.Spr_delete_GRSceneDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class GRSceneDescStruct : CsObject {
        public GRSceneDescStruct() {
            GRSceneDesc desc = new GRSceneDesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] GRSceneDesc
	public void ApplyTo(GRSceneDesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(GRSceneDesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator GRSceneDesc(GRSceneDescStruct m) {
	    GRSceneDesc r = new GRSceneDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator GRSceneDescStruct(GRSceneDesc r) {
	    GRSceneDescStruct m = new GRSceneDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class GRSdkDesc : CsObject {
	public GRSdkDesc() { _this = SprExport.Spr_new_GRSdkDesc(); _flag = true; }
	public GRSdkDesc(IntPtr ptr) : base(ptr) {}
	public GRSdkDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRSdkDesc() { if (_flag) { SprExport.Spr_delete_GRSdkDesc(_this); _flag = false; } }
    }
    [System.Serializable]
    public class GRSdkDescStruct : CsObject {
        public GRSdkDescStruct() {
            GRSdkDesc desc = new GRSdkDesc();
            ApplyFrom(desc, false);
        }
// _[Find class node: 2916] GRSdkDesc
	public void ApplyTo(GRSdkDesc r, bool apply_to_base_class=true) {
	}
	public void ApplyFrom(GRSdkDesc r, bool apply_to_base_class=true) {
	}
	public static implicit operator GRSdkDesc(GRSdkDescStruct m) {
	    GRSdkDesc r = new GRSdkDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator GRSdkDescStruct(GRSdkDesc r) {
	    GRSdkDescStruct m = new GRSdkDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class SFBlendLocation : CsObject {
	public SFBlendLocation() { _this = SprExport.Spr_new_SFBlendLocation(); _flag = true; }
	public SFBlendLocation(IntPtr ptr) : base(ptr) {}
	public SFBlendLocation(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~SFBlendLocation() { if (_flag) { SprExport.Spr_delete_SFBlendLocation(_this); _flag = false; } }
	public uint uBlendMatrix {
	    get { return SprExport.Spr_SFBlendLocation_get_uBlendMatrix(_this); }
	    set { SprExport.Spr_SFBlendLocation_set_uBlendMatrix(_this, value); }
	}
	public uint aWeight {
	    get { return SprExport.Spr_SFBlendLocation_get_aWeight(_this); }
	    set { SprExport.Spr_SFBlendLocation_set_aWeight(_this, value); }
	}
	public uint aMatrixIndices {
	    get { return SprExport.Spr_SFBlendLocation_get_aMatrixIndices(_this); }
	    set { SprExport.Spr_SFBlendLocation_set_aMatrixIndices(_this, value); }
	}
	public uint aNumMatrix {
	    get { return SprExport.Spr_SFBlendLocation_get_aNumMatrix(_this); }
	    set { SprExport.Spr_SFBlendLocation_set_aNumMatrix(_this, value); }
	}
    }
    public partial class GRShaderDesc : CsObject {
	public GRShaderDesc() { _this = SprExport.Spr_new_GRShaderDesc(); _flag = true; }
	public GRShaderDesc(IntPtr ptr) : base(ptr) {}
	public GRShaderDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRShaderDesc() { if (_flag) { SprExport.Spr_delete_GRShaderDesc(_this); _flag = false; } }
	public string vsname {
	    get {
	        IntPtr ptr = SprExport.Spr_GRShaderDesc_get_vsname(_this);
	        string bstr = Marshal.PtrToStringBSTR(ptr);
	        SprExport.Spr_GRShaderDesc_FreeString_vsname(ptr);
	        return bstr;
	    }
	    set {
	        IntPtr pbstr = Marshal.StringToBSTR(value);
	        SprExport.Spr_GRShaderDesc_set_vsname(_this, pbstr);
	    }
	}
	public string fsname {
	    get {
	        IntPtr ptr = SprExport.Spr_GRShaderDesc_get_fsname(_this);
	        string bstr = Marshal.PtrToStringBSTR(ptr);
	        SprExport.Spr_GRShaderDesc_FreeString_fsname(ptr);
	        return bstr;
	    }
	    set {
	        IntPtr pbstr = Marshal.StringToBSTR(value);
	        SprExport.Spr_GRShaderDesc_set_fsname(_this, pbstr);
	    }
	}
	public bool bEnableLighting {
	    get {
	        byte ret = (byte) SprExport.Spr_GRShaderDesc_get_bEnableLighting(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_GRShaderDesc_set_bEnableLighting(_this, (char) val);
	    }
	}
	public bool bEnableTexture2D {
	    get {
	        byte ret = (byte) SprExport.Spr_GRShaderDesc_get_bEnableTexture2D(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_GRShaderDesc_set_bEnableTexture2D(_this, (char) val);
	    }
	}
	public bool bEnableTexture3D {
	    get {
	        byte ret = (byte) SprExport.Spr_GRShaderDesc_get_bEnableTexture3D(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_GRShaderDesc_set_bEnableTexture3D(_this, (char) val);
	    }
	}
	public bool bShadowCreate {
	    get {
	        byte ret = (byte) SprExport.Spr_GRShaderDesc_get_bShadowCreate(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_GRShaderDesc_set_bShadowCreate(_this, (char) val);
	    }
	}
	public bool bShadowRender {
	    get {
	        byte ret = (byte) SprExport.Spr_GRShaderDesc_get_bShadowRender(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_GRShaderDesc_set_bShadowRender(_this, (char) val);
	    }
	}
	public bool bEnableBlending {
	    get {
	        byte ret = (byte) SprExport.Spr_GRShaderDesc_get_bEnableBlending(_this);
	        return (ret == 0) ? false : true;
	    }
	    set {
	        byte val = (byte) (value ? 1 : 0);
	        SprExport.Spr_GRShaderDesc_set_bEnableBlending(_this, (char) val);
	    }
	}
	public int numBlendMatrices {
	    get { return SprExport.Spr_GRShaderDesc_get_numBlendMatrices(_this); }
	    set { SprExport.Spr_GRShaderDesc_set_numBlendMatrices(_this, value); }
	}
    }
    [System.Serializable]
    public class GRShaderDescStruct : CsObject {
        public GRShaderDescStruct() {
            GRShaderDesc desc = new GRShaderDesc();
            ApplyFrom(desc, false);
        }
	public string vsname;
	public string fsname;
	public bool bEnableLighting;
	public bool bEnableTexture2D;
	public bool bEnableTexture3D;
	public bool bShadowCreate;
	public bool bShadowRender;
	public bool bEnableBlending;
	public int numBlendMatrices;
// _[Find class node: 2916] GRShaderDesc
	public void ApplyTo(GRShaderDesc r, bool apply_to_base_class=true) {
		r.vsname = vsname;
		r.fsname = fsname;
		r.bEnableLighting = bEnableLighting;
		r.bEnableTexture2D = bEnableTexture2D;
		r.bEnableTexture3D = bEnableTexture3D;
		r.bShadowCreate = bShadowCreate;
		r.bShadowRender = bShadowRender;
		r.bEnableBlending = bEnableBlending;
		r.numBlendMatrices = numBlendMatrices;
	}
	public void ApplyFrom(GRShaderDesc r, bool apply_to_base_class=true) {
		vsname = r.vsname;
		fsname = r.fsname;
		bEnableLighting = r.bEnableLighting;
		bEnableTexture2D = r.bEnableTexture2D;
		bEnableTexture3D = r.bEnableTexture3D;
		bShadowCreate = r.bShadowCreate;
		bShadowRender = r.bShadowRender;
		bEnableBlending = r.bEnableBlending;
		numBlendMatrices = r.numBlendMatrices;
	}
	public static implicit operator GRShaderDesc(GRShaderDescStruct m) {
	    GRShaderDesc r = new GRShaderDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator GRShaderDescStruct(GRShaderDesc r) {
	    GRShaderDescStruct m = new GRShaderDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class GRShaderFormat : CsObject {
	public GRShaderFormat() { _this = SprExport.Spr_new_GRShaderFormat(); _flag = true; }
	public GRShaderFormat(IntPtr ptr) : base(ptr) {}
	public GRShaderFormat(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRShaderFormat() { if (_flag) { SprExport.Spr_delete_GRShaderFormat(_this); _flag = false; } }
	public enum ShaderType : int {
	    shP3fB4f, shC4bP3fB4f, shC3fP3fB4f, shN3fP3fB4f, shC4fN3fP3fB4f, shT2fP3fB4f, shT2fC4bP3fB4f, shT2fN3fP3fB4f, shT2fC4fN3fP3fB4f
	}
    }
    public partial class GRSphereDesc : GRVisualDesc {
	public GRSphereDesc() { _this = SprExport.Spr_new_GRSphereDesc(); _flag = true; }
	public GRSphereDesc(IntPtr ptr) : base(ptr) {}
	public GRSphereDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRSphereDesc() { if (_flag) { SprExport.Spr_delete_GRSphereDesc(_this); _flag = false; } }
	public float radius {
	    get { return SprExport.Spr_GRSphereDesc_get_radius(_this); }
	    set { SprExport.Spr_GRSphereDesc_set_radius(_this, value); }
	}
	public int slices {
	    get { return SprExport.Spr_GRSphereDesc_get_slices(_this); }
	    set { SprExport.Spr_GRSphereDesc_set_slices(_this, value); }
	}
	public int stacks {
	    get { return SprExport.Spr_GRSphereDesc_get_stacks(_this); }
	    set { SprExport.Spr_GRSphereDesc_set_stacks(_this, value); }
	}
    }
    [System.Serializable]
    public class GRSphereDescStruct : GRVisualDescStruct {
        public GRSphereDescStruct() {
            GRSphereDesc desc = new GRSphereDesc();
            ApplyFrom(desc, true);
        }
	public float radius;
	public int slices;
	public int stacks;
// _[Find class node: 2916] GRSphereDesc
	public void ApplyTo(GRSphereDesc r, bool apply_to_base_class=true) {
		r.radius = radius;
		r.slices = slices;
		r.stacks = stacks;
		if (apply_to_base_class) {
		    base.ApplyTo((GRVisualDesc) r, apply_to_base_class);
		}
	}
	public void ApplyFrom(GRSphereDesc r, bool apply_to_base_class=true) {
		radius = r.radius;
		slices = r.slices;
		stacks = r.stacks;
		if (apply_to_base_class) {
		    base.ApplyFrom((GRVisualDesc) r, apply_to_base_class);
		}
	}
	public static implicit operator GRSphereDesc(GRSphereDescStruct m) {
	    GRSphereDesc r = new GRSphereDesc();
	    m.ApplyTo(r, true);
	    return r;
	}
	public static implicit operator GRSphereDescStruct(GRSphereDesc r) {
	    GRSphereDescStruct m = new GRSphereDescStruct();
	    m.ApplyFrom(r, true);
	    return m;
	}
    }
    public partial class GRVertexElement : CsObject {
	public GRVertexElement() { _this = SprExport.Spr_new_GRVertexElement(); _flag = true; }
	public GRVertexElement(IntPtr ptr) : base(ptr) {}
	public GRVertexElement(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRVertexElement() { if (_flag) { SprExport.Spr_delete_GRVertexElement(_this); _flag = false; } }
	public short stream {
	    get { return SprExport.Spr_GRVertexElement_get_stream(_this); }
	    set { SprExport.Spr_GRVertexElement_set_stream(_this, value); }
	}
	public short offset {
	    get { return SprExport.Spr_GRVertexElement_get_offset(_this); }
	    set { SprExport.Spr_GRVertexElement_set_offset(_this, value); }
	}
	public byte type {
	    get { return SprExport.Spr_GRVertexElement_get_type(_this); }
	    set { SprExport.Spr_GRVertexElement_set_type(_this, value); }
	}
	public byte method {
	    get { return SprExport.Spr_GRVertexElement_get_method(_this); }
	    set { SprExport.Spr_GRVertexElement_set_method(_this, value); }
	}
	public byte usage {
	    get { return SprExport.Spr_GRVertexElement_get_usage(_this); }
	    set { SprExport.Spr_GRVertexElement_set_usage(_this, value); }
	}
	public byte usageIndex {
	    get { return SprExport.Spr_GRVertexElement_get_usageIndex(_this); }
	    set { SprExport.Spr_GRVertexElement_set_usageIndex(_this, value); }
	}
	public static GRVertexElement Position2f(ulong o) {
	    IntPtr ptr = SprExport.Spr_GRVertexElement_Position2f((ulong) o);
            return new GRVertexElement(ptr, true);
	}
	public static GRVertexElement Position3f(ulong o) {
	    IntPtr ptr = SprExport.Spr_GRVertexElement_Position3f((ulong) o);
            return new GRVertexElement(ptr, true);
	}
	public static GRVertexElement Position4f(ulong o) {
	    IntPtr ptr = SprExport.Spr_GRVertexElement_Position4f((ulong) o);
            return new GRVertexElement(ptr, true);
	}
	public static GRVertexElement Normal3f(ulong o) {
	    IntPtr ptr = SprExport.Spr_GRVertexElement_Normal3f((ulong) o);
            return new GRVertexElement(ptr, true);
	}
	public static GRVertexElement TexCoords2f(ulong o) {
	    IntPtr ptr = SprExport.Spr_GRVertexElement_TexCoords2f((ulong) o);
            return new GRVertexElement(ptr, true);
	}
	public static GRVertexElement TexCoords4f(ulong o) {
	    IntPtr ptr = SprExport.Spr_GRVertexElement_TexCoords4f((ulong) o);
            return new GRVertexElement(ptr, true);
	}
	public static GRVertexElement Color4b(ulong o) {
	    IntPtr ptr = SprExport.Spr_GRVertexElement_Color4b((ulong) o);
            return new GRVertexElement(ptr, true);
	}
	public static GRVertexElement Color4f(ulong o) {
	    IntPtr ptr = SprExport.Spr_GRVertexElement_Color4f((ulong) o);
            return new GRVertexElement(ptr, true);
	}
	public static GRVertexElement Color3f(ulong o) {
	    IntPtr ptr = SprExport.Spr_GRVertexElement_Color3f((ulong) o);
            return new GRVertexElement(ptr, true);
	}
	public static GRVertexElement BlendNf(ulong o, ulong n) {
	    IntPtr ptr = SprExport.Spr_GRVertexElement_BlendNf((ulong) o, (ulong) n);
            return new GRVertexElement(ptr, true);
	}
	public static GRVertexElement Blend4f(ulong o) {
	    IntPtr ptr = SprExport.Spr_GRVertexElement_Blend4f((ulong) o);
            return new GRVertexElement(ptr, true);
	}
	public static GRVertexElement Blend3f(ulong o) {
	    IntPtr ptr = SprExport.Spr_GRVertexElement_Blend3f((ulong) o);
            return new GRVertexElement(ptr, true);
	}
	public static GRVertexElement Blend2f(ulong o) {
	    IntPtr ptr = SprExport.Spr_GRVertexElement_Blend2f((ulong) o);
            return new GRVertexElement(ptr, true);
	}
	public static GRVertexElement Blend1f(ulong o) {
	    IntPtr ptr = SprExport.Spr_GRVertexElement_Blend1f((ulong) o);
            return new GRVertexElement(ptr, true);
	}
	public static GRVertexElement MatrixIndicesNf(ulong o, ulong n) {
	    IntPtr ptr = SprExport.Spr_GRVertexElement_MatrixIndicesNf((ulong) o, (ulong) n);
            return new GRVertexElement(ptr, true);
	}
	public static GRVertexElement NumBonesNf(ulong o, ulong n) {
	    IntPtr ptr = SprExport.Spr_GRVertexElement_NumBonesNf((ulong) o, (ulong) n);
            return new GRVertexElement(ptr, true);
	}
	public static GRVertexElement MatrixIndices4f(ulong o) {
	    IntPtr ptr = SprExport.Spr_GRVertexElement_MatrixIndices4f((ulong) o);
            return new GRVertexElement(ptr, true);
	}
	public static GRVertexElement NumBones4f(ulong o) {
	    IntPtr ptr = SprExport.Spr_GRVertexElement_NumBones4f((ulong) o);
            return new GRVertexElement(ptr, true);
	}
    }
    public partial class GRVertexArray : CsObject {
	public GRVertexArray() { _this = SprExport.Spr_new_GRVertexArray(); _flag = true; }
	public GRVertexArray(IntPtr ptr) : base(ptr) {}
	public GRVertexArray(IntPtr ptr, bool flag) : base(ptr, flag) {}
	~GRVertexArray() { if (_flag) { SprExport.Spr_delete_GRVertexArray(_this); _flag = false; } }
	public GRVertexElement format {
	    get { return new GRVertexElement(SprExport.Spr_GRVertexArray_addr_format(_this)); }
	    set { SprExport.Spr_GRVertexArray_set_format(_this, value); }
	}
	public IntPtr buffer {
	    get { return SprExport.Spr_GRVertexArray_get_buffer(_this); }
	    set { SprExport.Spr_GRVertexArray_set_buffer(_this, value); }
	}
    }
    public partial class GRVisualIf : SceneObjectIf {
	public GRVisualIf() { _this = SprExport.Spr_new_GRVisualIf(); _flag = true; }
	public GRVisualIf(IntPtr ptr) : base(ptr) {}
	public GRVisualIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRVisualIf(CsCastObject target) {
		return (target._info.Inherit(GRVisualIf.GetIfInfoStatic()) ? new GRVisualIf(target._this, target._flag) : null);
	}
	~GRVisualIf() { if (_flag) { SprExport.Spr_delete_GRVisualIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRVisualIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRVisualIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRVisualIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRVisualIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void Render(GRRenderIf r) {
	    SprExport.Spr_GRVisualIf_Render((IntPtr) _this, (IntPtr) r);
	}
	public void Rendered(GRRenderIf r) {
	    SprExport.Spr_GRVisualIf_Rendered((IntPtr) _this, (IntPtr) r);
	}
	public void Enable(bool on) {
	    SprExport.Spr_GRVisualIf_Enable((IntPtr) _this, (bool) on);
	}
	public void Enable() {
	    SprExport.Spr_GRVisualIf_Enable_1((IntPtr) _this);
	}
	public bool IsEnabled() {
	    char ret = SprExport.Spr_GRVisualIf_IsEnabled((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public GRMaterialIf GetMaterial() {
	    IntPtr ptr = SprExport.Spr_GRVisualIf_GetMaterial((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRMaterialIf obj = new GRMaterialIf(ptr);
            return obj;
	}
	public void SetMaterial(GRMaterialIf mat) {
	    SprExport.Spr_GRVisualIf_SetMaterial((IntPtr) _this, (IntPtr) mat);
	}
    }
    public partial class GRFrameIf : GRVisualIf {
	public GRFrameIf() { _this = SprExport.Spr_new_GRFrameIf(); _flag = true; }
	public GRFrameIf(IntPtr ptr) : base(ptr) {}
	public GRFrameIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRFrameIf(CsCastObject target) {
		return (target._info.Inherit(GRFrameIf.GetIfInfoStatic()) ? new GRFrameIf(target._this, target._flag) : null);
	}
	~GRFrameIf() { if (_flag) { SprExport.Spr_delete_GRFrameIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRFrameIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRFrameIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRFrameIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRFrameIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public GRFrameIf GetParent() {
	    IntPtr ptr = SprExport.Spr_GRFrameIf_GetParent((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRFrameIf obj = new GRFrameIf(ptr);
            return obj;
	}
	public void SetParent(GRFrameIf fr) {
	    SprExport.Spr_GRFrameIf_SetParent((IntPtr) _this, (IntPtr) fr);
	}
	public int NChildren() {
	    int result = (int) SprExport.Spr_GRFrameIf_NChildren((IntPtr) _this);
	    return result;
	}
	public GRVisualIf GetChildren() {
	    IntPtr ptr = SprExport.Spr_GRFrameIf_GetChildren((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRVisualIf obj = new GRVisualIf(ptr);
            if (obj.GetIfInfo() == GRFrameIf.GetIfInfoStatic()) { return new GRFrameIf(ptr); }
            if (obj.GetIfInfo() == GRDummyFrameIf.GetIfInfoStatic()) { return new GRDummyFrameIf(ptr); }
            if (obj.GetIfInfo() == GRBlendMeshIf.GetIfInfoStatic()) { return new GRBlendMeshIf(ptr); }
            if (obj.GetIfInfo() == GRSkinWeightIf.GetIfInfoStatic()) { return new GRSkinWeightIf(ptr); }
            if (obj.GetIfInfo() == GRMeshIf.GetIfInfoStatic()) { return new GRMeshIf(ptr); }
            if (obj.GetIfInfo() == GRLightIf.GetIfInfoStatic()) { return new GRLightIf(ptr); }
            if (obj.GetIfInfo() == GRMaterialIf.GetIfInfoStatic()) { return new GRMaterialIf(ptr); }
            if (obj.GetIfInfo() == GRCameraIf.GetIfInfoStatic()) { return new GRCameraIf(ptr); }
            if (obj.GetIfInfo() == GRShadowLightIf.GetIfInfoStatic()) { return new GRShadowLightIf(ptr); }
            if (obj.GetIfInfo() == GRSphereIf.GetIfInfoStatic()) { return new GRSphereIf(ptr); }
            return obj;
	}
    }
    public partial class GRDummyFrameIf : GRVisualIf {
	public GRDummyFrameIf() { _this = SprExport.Spr_new_GRDummyFrameIf(); _flag = true; }
	public GRDummyFrameIf(IntPtr ptr) : base(ptr) {}
	public GRDummyFrameIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRDummyFrameIf(CsCastObject target) {
		return (target._info.Inherit(GRDummyFrameIf.GetIfInfoStatic()) ? new GRDummyFrameIf(target._this, target._flag) : null);
	}
	~GRDummyFrameIf() { if (_flag) { SprExport.Spr_delete_GRDummyFrameIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRDummyFrameIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRDummyFrameIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRDummyFrameIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRDummyFrameIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
    }
    public partial class GRAnimationIf : SceneObjectIf {
	public GRAnimationIf() { _this = SprExport.Spr_new_GRAnimationIf(); _flag = true; }
	public GRAnimationIf(IntPtr ptr) : base(ptr) {}
	public GRAnimationIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRAnimationIf(CsCastObject target) {
		return (target._info.Inherit(GRAnimationIf.GetIfInfoStatic()) ? new GRAnimationIf(target._this, target._flag) : null);
	}
	~GRAnimationIf() { if (_flag) { SprExport.Spr_delete_GRAnimationIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRAnimationIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRAnimationIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRAnimationIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRAnimationIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void BlendPose(float time, float weight) {
	    SprExport.Spr_GRAnimationIf_BlendPose((IntPtr) _this, (float) time, (float) weight);
	}
	public void ResetPose() {
	    SprExport.Spr_GRAnimationIf_ResetPose((IntPtr) _this);
	}
	public void LoadInitialPose() {
	    SprExport.Spr_GRAnimationIf_LoadInitialPose((IntPtr) _this);
	}
	public GRAnimationKey GetAnimationKey(int n) {
	    IntPtr ptr = SprExport.Spr_GRAnimationIf_GetAnimationKey((IntPtr) _this, (int) n);
            return new GRAnimationKey(ptr, true);
	}
	public int NAnimationKey() {
	    int result = (int) SprExport.Spr_GRAnimationIf_NAnimationKey((IntPtr) _this);
	    return result;
	}
	public void DeletePose(float t) {
	    SprExport.Spr_GRAnimationIf_DeletePose((IntPtr) _this, (float) t);
	}
    }
    public partial class GRAnimationSetIf : SceneObjectIf {
	public GRAnimationSetIf() { _this = SprExport.Spr_new_GRAnimationSetIf(); _flag = true; }
	public GRAnimationSetIf(IntPtr ptr) : base(ptr) {}
	public GRAnimationSetIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRAnimationSetIf(CsCastObject target) {
		return (target._info.Inherit(GRAnimationSetIf.GetIfInfoStatic()) ? new GRAnimationSetIf(target._this, target._flag) : null);
	}
	~GRAnimationSetIf() { if (_flag) { SprExport.Spr_delete_GRAnimationSetIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRAnimationSetIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRAnimationSetIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRAnimationSetIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRAnimationSetIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void BlendPose(float time, float weight) {
	    SprExport.Spr_GRAnimationSetIf_BlendPose((IntPtr) _this, (float) time, (float) weight);
	}
	public void ResetPose() {
	    SprExport.Spr_GRAnimationSetIf_ResetPose((IntPtr) _this);
	}
	public void LoadInitialPose() {
	    SprExport.Spr_GRAnimationSetIf_LoadInitialPose((IntPtr) _this);
	}
	public ObjectIf GetChildObject(ulong p) {
	    IntPtr ptr = SprExport.Spr_GRAnimationSetIf_GetChildObject((IntPtr) _this, (ulong) p);
            if (ptr == IntPtr.Zero) { return null; } 
            ObjectIf obj = new ObjectIf(ptr);
            if (obj.GetIfInfo() == GRRenderBaseIf.GetIfInfoStatic()) { return new GRRenderBaseIf(ptr); }
            if (obj.GetIfInfo() == GRShaderIf.GetIfInfoStatic()) { return new GRShaderIf(ptr); }
            if (obj.GetIfInfo() == GRRenderIf.GetIfInfoStatic()) { return new GRRenderIf(ptr); }
            if (obj.GetIfInfo() == GRDeviceIf.GetIfInfoStatic()) { return new GRDeviceIf(ptr); }
            if (obj.GetIfInfo() == GRDeviceGLIf.GetIfInfoStatic()) { return new GRDeviceGLIf(ptr); }
            return obj;
	}
	public void SetCurrentAnimationPose(float t) {
	    SprExport.Spr_GRAnimationSetIf_SetCurrentAnimationPose((IntPtr) _this, (float) t);
	}
	public void DeleteAnimationPose(float t) {
	    SprExport.Spr_GRAnimationSetIf_DeleteAnimationPose((IntPtr) _this, (float) t);
	}
	public float GetLastKeyTime() {
	    float result = (float) SprExport.Spr_GRAnimationSetIf_GetLastKeyTime((IntPtr) _this);
	    return result;
	}
    }
    public partial class GRAnimationControllerIf : SceneObjectIf {
	public GRAnimationControllerIf() { _this = SprExport.Spr_new_GRAnimationControllerIf(); _flag = true; }
	public GRAnimationControllerIf(IntPtr ptr) : base(ptr) {}
	public GRAnimationControllerIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRAnimationControllerIf(CsCastObject target) {
		return (target._info.Inherit(GRAnimationControllerIf.GetIfInfoStatic()) ? new GRAnimationControllerIf(target._this, target._flag) : null);
	}
	~GRAnimationControllerIf() { if (_flag) { SprExport.Spr_delete_GRAnimationControllerIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRAnimationControllerIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRAnimationControllerIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRAnimationControllerIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRAnimationControllerIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void BlendPose(string name, float time, float weight) {
            IntPtr remote1 = Marshal.StringToBSTR(name);
	    SprExport.Spr_GRAnimationControllerIf_BlendPose((IntPtr) _this, (IntPtr) remote1, (float) time, (float) weight);
            Marshal.FreeBSTR(remote1);
	}
	public void ResetPose() {
	    SprExport.Spr_GRAnimationControllerIf_ResetPose((IntPtr) _this);
	}
	public void LoadInitialPose() {
	    SprExport.Spr_GRAnimationControllerIf_LoadInitialPose((IntPtr) _this);
	}
	public bool AddChildObject(ObjectIf o) {
	    char ret = SprExport.Spr_GRAnimationControllerIf_AddChildObject((IntPtr) _this, (IntPtr) o);
	    return (ret == 0) ? false : true;
	}
	public bool DelChildObject(ObjectIf o) {
	    char ret = SprExport.Spr_GRAnimationControllerIf_DelChildObject((IntPtr) _this, (IntPtr) o);
	    return (ret == 0) ? false : true;
	}
	public ulong NChildObject() {
	    ulong result = (ulong) SprExport.Spr_GRAnimationControllerIf_NChildObject((IntPtr) _this);
	    return result;
	}
	public ObjectIf GetChildObject(ulong p) {
	    IntPtr ptr = SprExport.Spr_GRAnimationControllerIf_GetChildObject((IntPtr) _this, (ulong) p);
            if (ptr == IntPtr.Zero) { return null; } 
            ObjectIf obj = new ObjectIf(ptr);
            if (obj.GetIfInfo() == GRRenderBaseIf.GetIfInfoStatic()) { return new GRRenderBaseIf(ptr); }
            if (obj.GetIfInfo() == GRShaderIf.GetIfInfoStatic()) { return new GRShaderIf(ptr); }
            if (obj.GetIfInfo() == GRRenderIf.GetIfInfoStatic()) { return new GRRenderIf(ptr); }
            if (obj.GetIfInfo() == GRDeviceIf.GetIfInfoStatic()) { return new GRDeviceIf(ptr); }
            if (obj.GetIfInfo() == GRDeviceGLIf.GetIfInfoStatic()) { return new GRDeviceGLIf(ptr); }
            return obj;
	}
	public GRAnimationSetIf GetAnimationSet(ulong p) {
	    IntPtr ptr = SprExport.Spr_GRAnimationControllerIf_GetAnimationSet((IntPtr) _this, (ulong) p);
            if (ptr == IntPtr.Zero) { return null; } 
            GRAnimationSetIf obj = new GRAnimationSetIf(ptr);
            return obj;
	}
    }
    public partial class GRBlendMeshIf : GRVisualIf {
	public GRBlendMeshIf() { _this = SprExport.Spr_new_GRBlendMeshIf(); _flag = true; }
	public GRBlendMeshIf(IntPtr ptr) : base(ptr) {}
	public GRBlendMeshIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRBlendMeshIf(CsCastObject target) {
		return (target._info.Inherit(GRBlendMeshIf.GetIfInfoStatic()) ? new GRBlendMeshIf(target._this, target._flag) : null);
	}
	~GRBlendMeshIf() { if (_flag) { SprExport.Spr_delete_GRBlendMeshIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRBlendMeshIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRBlendMeshIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRBlendMeshIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRBlendMeshIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
    }
    public partial class GRSkinWeightIf : GRVisualIf {
	public GRSkinWeightIf() { _this = SprExport.Spr_new_GRSkinWeightIf(); _flag = true; }
	public GRSkinWeightIf(IntPtr ptr) : base(ptr) {}
	public GRSkinWeightIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRSkinWeightIf(CsCastObject target) {
		return (target._info.Inherit(GRSkinWeightIf.GetIfInfoStatic()) ? new GRSkinWeightIf(target._this, target._flag) : null);
	}
	~GRSkinWeightIf() { if (_flag) { SprExport.Spr_delete_GRSkinWeightIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRSkinWeightIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRSkinWeightIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRSkinWeightIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRSkinWeightIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
    }
    public partial class GRMeshIf : GRVisualIf {
	public GRMeshIf() { _this = SprExport.Spr_new_GRMeshIf(); _flag = true; }
	public GRMeshIf(IntPtr ptr) : base(ptr) {}
	public GRMeshIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRMeshIf(CsCastObject target) {
		return (target._info.Inherit(GRMeshIf.GetIfInfoStatic()) ? new GRMeshIf(target._this, target._flag) : null);
	}
	~GRMeshIf() { if (_flag) { SprExport.Spr_delete_GRMeshIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRMeshIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRMeshIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRMeshIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRMeshIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public int NVertex() {
	    int result = (int) SprExport.Spr_GRMeshIf_NVertex((IntPtr) _this);
	    return result;
	}
	public int NTriangle() {
	    int result = (int) SprExport.Spr_GRMeshIf_NTriangle((IntPtr) _this);
	    return result;
	}
	public int NFace() {
	    int result = (int) SprExport.Spr_GRMeshIf_NFace((IntPtr) _this);
	    return result;
	}
	public arraywrapper_Vec3f GetVertices() {
	    IntPtr ptr = SprExport.Spr_GRMeshIf_GetVertices((IntPtr) _this);
            int size = 1;   // no way to know array size!
            return new arraywrapper_Vec3f(ptr, size);
	}
	public arraywrapper_Vec3f GetNormals() {
	    IntPtr ptr = SprExport.Spr_GRMeshIf_GetNormals((IntPtr) _this);
            int size = 1;   // no way to know array size!
            return new arraywrapper_Vec3f(ptr, size);
	}
	public arraywrapper_Vec4f GetColors() {
	    IntPtr ptr = SprExport.Spr_GRMeshIf_GetColors((IntPtr) _this);
            int size = 1;   // no way to know array size!
            return new arraywrapper_Vec4f(ptr, size);
	}
	public arraywrapper_Vec2f GetTexCoords() {
	    IntPtr ptr = SprExport.Spr_GRMeshIf_GetTexCoords((IntPtr) _this);
            int size = 1;   // no way to know array size!
            return new arraywrapper_Vec2f(ptr, size);
	}
	public arraywrapper_GRMeshFace GetFaces() {
	    IntPtr ptr = SprExport.Spr_GRMeshIf_GetFaces((IntPtr) _this);
            int size = 1;   // no way to know array size!
            return new arraywrapper_GRMeshFace(ptr, size);
	}
	public arraywrapper_GRMeshFace GetFaceNormals() {
	    IntPtr ptr = SprExport.Spr_GRMeshIf_GetFaceNormals((IntPtr) _this);
            int size = 1;   // no way to know array size!
            return new arraywrapper_GRMeshFace(ptr, size);
	}
	public int[] GetMaterialIndices() {
	    IntPtr ptr = SprExport.Spr_GRMeshIf_GetMaterialIndices((IntPtr) _this);
            int size = 1;   // no way to know array size!
            return new arraywrapper_int(ptr, size);
	}
	public void SwitchCoordinate() {
	    SprExport.Spr_GRMeshIf_SwitchCoordinate((IntPtr) _this);
	}
	public void EnableTex3D(bool on) {
	    SprExport.Spr_GRMeshIf_EnableTex3D((IntPtr) _this, (bool) on);
	}
	public void EnableTex3D() {
	    SprExport.Spr_GRMeshIf_EnableTex3D_1((IntPtr) _this);
	}
	public bool IsTex3D() {
	    char ret = SprExport.Spr_GRMeshIf_IsTex3D((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
	public GRSkinWeightIf CreateSkinWeight(GRSkinWeightDesc desc) {
	    IntPtr ptr = SprExport.Spr_GRMeshIf_CreateSkinWeight((IntPtr) _this, (IntPtr) desc);
            if (ptr == IntPtr.Zero) { return null; } 
            GRSkinWeightIf obj = new GRSkinWeightIf(ptr);
            return obj;
	}
    }
    public partial class GRLightIf : GRVisualIf {
	public GRLightIf() { _this = SprExport.Spr_new_GRLightIf(); _flag = true; }
	public GRLightIf(IntPtr ptr) : base(ptr) {}
	public GRLightIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRLightIf(CsCastObject target) {
		return (target._info.Inherit(GRLightIf.GetIfInfoStatic()) ? new GRLightIf(target._this, target._flag) : null);
	}
	~GRLightIf() { if (_flag) { SprExport.Spr_delete_GRLightIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRLightIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRLightIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRLightIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRLightIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
    }
    public partial class GRMaterialIf : GRVisualIf {
	public GRMaterialIf() { _this = SprExport.Spr_new_GRMaterialIf(); _flag = true; }
	public GRMaterialIf(IntPtr ptr) : base(ptr) {}
	public GRMaterialIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRMaterialIf(CsCastObject target) {
		return (target._info.Inherit(GRMaterialIf.GetIfInfoStatic()) ? new GRMaterialIf(target._this, target._flag) : null);
	}
	~GRMaterialIf() { if (_flag) { SprExport.Spr_delete_GRMaterialIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRMaterialIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRMaterialIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRMaterialIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRMaterialIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public bool IsOpaque() {
	    char ret = SprExport.Spr_GRMaterialIf_IsOpaque((IntPtr) _this);
	    return (ret == 0) ? false : true;
	}
    }
    public partial class GRCameraIf : GRVisualIf {
	public GRCameraIf() { _this = SprExport.Spr_new_GRCameraIf(); _flag = true; }
	public GRCameraIf(IntPtr ptr) : base(ptr) {}
	public GRCameraIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRCameraIf(CsCastObject target) {
		return (target._info.Inherit(GRCameraIf.GetIfInfoStatic()) ? new GRCameraIf(target._this, target._flag) : null);
	}
	~GRCameraIf() { if (_flag) { SprExport.Spr_delete_GRCameraIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRCameraIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRCameraIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRCameraIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRCameraIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public GRFrameIf GetFrame() {
	    IntPtr ptr = SprExport.Spr_GRCameraIf_GetFrame((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRFrameIf obj = new GRFrameIf(ptr);
            return obj;
	}
	public void SetFrame(GRFrameIf fr) {
	    SprExport.Spr_GRCameraIf_SetFrame((IntPtr) _this, (IntPtr) fr);
	}
    }
    public partial class GRShadowLightIf : GRVisualIf {
	public GRShadowLightIf() { _this = SprExport.Spr_new_GRShadowLightIf(); _flag = true; }
	public GRShadowLightIf(IntPtr ptr) : base(ptr) {}
	public GRShadowLightIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRShadowLightIf(CsCastObject target) {
		return (target._info.Inherit(GRShadowLightIf.GetIfInfoStatic()) ? new GRShadowLightIf(target._this, target._flag) : null);
	}
	~GRShadowLightIf() { if (_flag) { SprExport.Spr_delete_GRShadowLightIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRShadowLightIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRShadowLightIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRShadowLightIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRShadowLightIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
    }
    public partial class GRRenderBaseIf : ObjectIf {
	public GRRenderBaseIf() { _this = SprExport.Spr_new_GRRenderBaseIf(); _flag = true; }
	public GRRenderBaseIf(IntPtr ptr) : base(ptr) {}
	public GRRenderBaseIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRRenderBaseIf(CsCastObject target) {
		return (target._info.Inherit(GRRenderBaseIf.GetIfInfoStatic()) ? new GRRenderBaseIf(target._this, target._flag) : null);
	}
	~GRRenderBaseIf() { if (_flag) { SprExport.Spr_delete_GRRenderBaseIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRRenderBaseIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRRenderBaseIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRRenderBaseIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRRenderBaseIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void SetViewport(Vec2f pos, Vec2f sz) {
	    SprExport.Spr_GRRenderBaseIf_SetViewport((IntPtr) _this, (IntPtr) pos, (IntPtr) sz);
	}
	public Vec2f GetViewportPos() {
	    IntPtr ptr = SprExport.Spr_GRRenderBaseIf_GetViewportPos((IntPtr) _this);
            return new Vec2f(ptr, true);
	}
	public Vec2f GetViewportSize() {
	    IntPtr ptr = SprExport.Spr_GRRenderBaseIf_GetViewportSize((IntPtr) _this);
            return new Vec2f(ptr, true);
	}
	public void ClearBuffer(bool color, bool depth) {
	    SprExport.Spr_GRRenderBaseIf_ClearBuffer((IntPtr) _this, (bool) color, (bool) depth);
	}
	public void ClearBuffer(bool color) {
	    SprExport.Spr_GRRenderBaseIf_ClearBuffer_1((IntPtr) _this, (bool) color);
	}
	public void ClearBuffer() {
	    SprExport.Spr_GRRenderBaseIf_ClearBuffer_2((IntPtr) _this);
	}
	public void SwapBuffers() {
	    SprExport.Spr_GRRenderBaseIf_SwapBuffers((IntPtr) _this);
	}
	public void GetClearColor(Vec4f color) {
	    SprExport.Spr_GRRenderBaseIf_GetClearColor((IntPtr) _this, (IntPtr) color);
	}
	public void SetClearColor(Vec4f color) {
	    SprExport.Spr_GRRenderBaseIf_SetClearColor((IntPtr) _this, (IntPtr) color);
	}
	public void BeginScene() {
	    SprExport.Spr_GRRenderBaseIf_BeginScene((IntPtr) _this);
	}
	public void EndScene() {
	    SprExport.Spr_GRRenderBaseIf_EndScene((IntPtr) _this);
	}
	public void PushProjectionMatrix() {
	    SprExport.Spr_GRRenderBaseIf_PushProjectionMatrix((IntPtr) _this);
	}
	public void PopProjectionMatrix() {
	    SprExport.Spr_GRRenderBaseIf_PopProjectionMatrix((IntPtr) _this);
	}
	public void PushModelMatrix() {
	    SprExport.Spr_GRRenderBaseIf_PushModelMatrix((IntPtr) _this);
	}
	public void PopModelMatrix() {
	    SprExport.Spr_GRRenderBaseIf_PopModelMatrix((IntPtr) _this);
	}
	public void ClearBlendMatrix() {
	    SprExport.Spr_GRRenderBaseIf_ClearBlendMatrix((IntPtr) _this);
	}
	public void SetVertexFormat(GRVertexElement e) {
	    SprExport.Spr_GRRenderBaseIf_SetVertexFormat((IntPtr) _this, (IntPtr) e);
	}
	public void DrawDirect(GRRenderBaseIf.TPrimitiveType ty, CsObject vtx, ulong count, ulong stride) {
	    SprExport.Spr_GRRenderBaseIf_DrawDirect((IntPtr) _this, (int) ty, (IntPtr) vtx, (ulong) count, (ulong) stride);
	}
	public void DrawDirect(GRRenderBaseIf.TPrimitiveType ty, CsObject vtx, ulong count) {
	    SprExport.Spr_GRRenderBaseIf_DrawDirect_1((IntPtr) _this, (int) ty, (IntPtr) vtx, (ulong) count);
	}
	public void DrawIndexed(GRRenderBaseIf.TPrimitiveType ty, uint idx, CsObject vtx, ulong count, ulong stride) {
	    SprExport.Spr_GRRenderBaseIf_DrawIndexed((IntPtr) _this, (int) ty, (uint) idx, (IntPtr) vtx, (ulong) count, (ulong) stride);
	}
	public void DrawIndexed(GRRenderBaseIf.TPrimitiveType ty, uint idx, CsObject vtx, ulong count) {
	    SprExport.Spr_GRRenderBaseIf_DrawIndexed_1((IntPtr) _this, (int) ty, (uint) idx, (IntPtr) vtx, (ulong) count);
	}
	public void DrawArrays(GRRenderBaseIf.TPrimitiveType ty, GRVertexArray arrays, ulong count) {
	    SprExport.Spr_GRRenderBaseIf_DrawArrays((IntPtr) _this, (int) ty, (IntPtr) arrays, (ulong) count);
	}
	public void DrawArrays(GRRenderBaseIf.TPrimitiveType ty, ulong idx, GRVertexArray arrays, ulong count) {
	    SprExport.Spr_GRRenderBaseIf_DrawArrays_1((IntPtr) _this, (int) ty, (ulong) idx, (IntPtr) arrays, (ulong) count);
	}
	public void DrawPoint(Vec3f p) {
	    SprExport.Spr_GRRenderBaseIf_DrawPoint((IntPtr) _this, (IntPtr) p);
	}
	public void DrawLine(Vec3f p0, Vec3f p1) {
	    SprExport.Spr_GRRenderBaseIf_DrawLine((IntPtr) _this, (IntPtr) p0, (IntPtr) p1);
	}
	public void DrawSpline(Vec3f p0, Vec3f v0, Vec3f p1, Vec3f v1, int ndiv) {
	    SprExport.Spr_GRRenderBaseIf_DrawSpline((IntPtr) _this, (IntPtr) p0, (IntPtr) v0, (IntPtr) p1, (IntPtr) v1, (int) ndiv);
	}
	public void DrawSpline(Vec3f p0, Vec3f v0, Vec3f p1, Vec3f v1) {
	    SprExport.Spr_GRRenderBaseIf_DrawSpline_1((IntPtr) _this, (IntPtr) p0, (IntPtr) v0, (IntPtr) p1, (IntPtr) v1);
	}
	public void DrawArrow(Vec3f p0, Vec3f p1, float rbar, float rhead, float lhead, int slice, bool solid) {
	    SprExport.Spr_GRRenderBaseIf_DrawArrow((IntPtr) _this, (IntPtr) p0, (IntPtr) p1, (float) rbar, (float) rhead, (float) lhead, (int) slice, (bool) solid);
	}
	public void DrawBox(float sx, float sy, float sz, bool solid) {
	    SprExport.Spr_GRRenderBaseIf_DrawBox((IntPtr) _this, (float) sx, (float) sy, (float) sz, (bool) solid);
	}
	public void DrawBox(float sx, float sy, float sz) {
	    SprExport.Spr_GRRenderBaseIf_DrawBox_1((IntPtr) _this, (float) sx, (float) sy, (float) sz);
	}
	public void DrawSphere(float radius, int slices, int stacks, bool solid) {
	    SprExport.Spr_GRRenderBaseIf_DrawSphere((IntPtr) _this, (float) radius, (int) slices, (int) stacks, (bool) solid);
	}
	public void DrawSphere(float radius, int slices, int stacks) {
	    SprExport.Spr_GRRenderBaseIf_DrawSphere_1((IntPtr) _this, (float) radius, (int) slices, (int) stacks);
	}
	public void DrawEllipsoid(Vec3f radius, int slices, int stacks, bool solid) {
	    SprExport.Spr_GRRenderBaseIf_DrawEllipsoid((IntPtr) _this, (IntPtr) radius, (int) slices, (int) stacks, (bool) solid);
	}
	public void DrawEllipsoid(Vec3f radius, int slices, int stacks) {
	    SprExport.Spr_GRRenderBaseIf_DrawEllipsoid_1((IntPtr) _this, (IntPtr) radius, (int) slices, (int) stacks);
	}
	public void DrawCone(float radius, float height, int slice, bool solid) {
	    SprExport.Spr_GRRenderBaseIf_DrawCone((IntPtr) _this, (float) radius, (float) height, (int) slice, (bool) solid);
	}
	public void DrawCone(float radius, float height, int slice) {
	    SprExport.Spr_GRRenderBaseIf_DrawCone_1((IntPtr) _this, (float) radius, (float) height, (int) slice);
	}
	public void DrawCylinder(float radius, float height, int slice, bool solid, bool cap) {
	    SprExport.Spr_GRRenderBaseIf_DrawCylinder((IntPtr) _this, (float) radius, (float) height, (int) slice, (bool) solid, (bool) cap);
	}
	public void DrawCylinder(float radius, float height, int slice, bool solid) {
	    SprExport.Spr_GRRenderBaseIf_DrawCylinder_1((IntPtr) _this, (float) radius, (float) height, (int) slice, (bool) solid);
	}
	public void DrawCylinder(float radius, float height, int slice) {
	    SprExport.Spr_GRRenderBaseIf_DrawCylinder_2((IntPtr) _this, (float) radius, (float) height, (int) slice);
	}
	public void DrawDisk(float radius, int slice, bool solid) {
	    SprExport.Spr_GRRenderBaseIf_DrawDisk((IntPtr) _this, (float) radius, (int) slice, (bool) solid);
	}
	public void DrawDisk(float radius, int slice) {
	    SprExport.Spr_GRRenderBaseIf_DrawDisk_1((IntPtr) _this, (float) radius, (int) slice);
	}
	public void DrawCapsule(float radius, float height, int slice, bool solid) {
	    SprExport.Spr_GRRenderBaseIf_DrawCapsule((IntPtr) _this, (float) radius, (float) height, (int) slice, (bool) solid);
	}
	public void DrawCapsule(float radius, float height, int slice) {
	    SprExport.Spr_GRRenderBaseIf_DrawCapsule_1((IntPtr) _this, (float) radius, (float) height, (int) slice);
	}
	public void DrawCapsule(float radius, float height) {
	    SprExport.Spr_GRRenderBaseIf_DrawCapsule_2((IntPtr) _this, (float) radius, (float) height);
	}
	public void DrawRoundCone(float rbottom, float rtop, float height, int slice, bool solid) {
	    SprExport.Spr_GRRenderBaseIf_DrawRoundCone((IntPtr) _this, (float) rbottom, (float) rtop, (float) height, (int) slice, (bool) solid);
	}
	public void DrawRoundCone(float rbottom, float rtop, float height, int slice) {
	    SprExport.Spr_GRRenderBaseIf_DrawRoundCone_1((IntPtr) _this, (float) rbottom, (float) rtop, (float) height, (int) slice);
	}
	public void DrawRoundCone(float rbottom, float rtop, float height) {
	    SprExport.Spr_GRRenderBaseIf_DrawRoundCone_2((IntPtr) _this, (float) rbottom, (float) rtop, (float) height);
	}
	public void DrawGrid(float size, int slice, float lineWidth) {
	    SprExport.Spr_GRRenderBaseIf_DrawGrid((IntPtr) _this, (float) size, (int) slice, (float) lineWidth);
	}
	public void DrawGrid(float size, int slice) {
	    SprExport.Spr_GRRenderBaseIf_DrawGrid_1((IntPtr) _this, (float) size, (int) slice);
	}
	public void DrawCurve(Curve3f curve) {
	    SprExport.Spr_GRRenderBaseIf_DrawCurve((IntPtr) _this, (IntPtr) curve);
	}
	public int StartList() {
	    int result = (int) SprExport.Spr_GRRenderBaseIf_StartList((IntPtr) _this);
	    return result;
	}
	public void EndList() {
	    SprExport.Spr_GRRenderBaseIf_EndList((IntPtr) _this);
	}
	public void DrawList(int i) {
	    SprExport.Spr_GRRenderBaseIf_DrawList((IntPtr) _this, (int) i);
	}
	public void ReleaseList(int i) {
	    SprExport.Spr_GRRenderBaseIf_ReleaseList((IntPtr) _this, (int) i);
	}
	public void SetFont(GRFont font) {
	    SprExport.Spr_GRRenderBaseIf_SetFont((IntPtr) _this, (IntPtr) font);
	}
	public void DrawFont(Vec2f pos, string str) {
            IntPtr remote2 = Marshal.StringToBSTR(str);
	    SprExport.Spr_GRRenderBaseIf_DrawFont((IntPtr) _this, (IntPtr) pos, (IntPtr) remote2);
            Marshal.FreeBSTR(remote2);
	}
	public void DrawFont(Vec3f pos, string str) {
            IntPtr remote2 = Marshal.StringToBSTR(str);
	    SprExport.Spr_GRRenderBaseIf_DrawFont_1((IntPtr) _this, (IntPtr) pos, (IntPtr) remote2);
            Marshal.FreeBSTR(remote2);
	}
	public void SetMaterial(GRMaterialDesc mat) {
	    SprExport.Spr_GRRenderBaseIf_SetMaterial((IntPtr) _this, (IntPtr) mat);
	}
	public void SetMaterial(GRMaterialIf mat) {
	    SprExport.Spr_GRRenderBaseIf_SetMaterial_1((IntPtr) _this, (IntPtr) mat);
	}
	public void SetMaterial(int matname) {
	    SprExport.Spr_GRRenderBaseIf_SetMaterial_2((IntPtr) _this, (int) matname);
	}
	public void SetMaterial(int matname, float alpha) {
	    SprExport.Spr_GRRenderBaseIf_SetMaterial_3((IntPtr) _this, (int) matname, (float) alpha);
	}
	public void SetPointSize(float sz, bool smooth) {
	    SprExport.Spr_GRRenderBaseIf_SetPointSize((IntPtr) _this, (float) sz, (bool) smooth);
	}
	public void SetPointSize(float sz) {
	    SprExport.Spr_GRRenderBaseIf_SetPointSize_1((IntPtr) _this, (float) sz);
	}
	public void SetLineWidth(float w, bool smooth) {
	    SprExport.Spr_GRRenderBaseIf_SetLineWidth((IntPtr) _this, (float) w, (bool) smooth);
	}
	public void SetLineWidth(float w) {
	    SprExport.Spr_GRRenderBaseIf_SetLineWidth_1((IntPtr) _this, (float) w);
	}
	public void PushLight(GRLightDesc light) {
	    SprExport.Spr_GRRenderBaseIf_PushLight((IntPtr) _this, (IntPtr) light);
	}
	public void PushLight(GRLightIf light) {
	    SprExport.Spr_GRRenderBaseIf_PushLight_1((IntPtr) _this, (IntPtr) light);
	}
	public void PopLight() {
	    SprExport.Spr_GRRenderBaseIf_PopLight((IntPtr) _this);
	}
	public int NLights() {
	    int result = (int) SprExport.Spr_GRRenderBaseIf_NLights((IntPtr) _this);
	    return result;
	}
	public void SetDepthWrite(bool b) {
	    SprExport.Spr_GRRenderBaseIf_SetDepthWrite((IntPtr) _this, (bool) b);
	}
	public void SetDepthTest(bool b) {
	    SprExport.Spr_GRRenderBaseIf_SetDepthTest((IntPtr) _this, (bool) b);
	}
	public void SetDepthFunc(GRRenderBaseIf.TDepthFunc f) {
	    SprExport.Spr_GRRenderBaseIf_SetDepthFunc((IntPtr) _this, (int) f);
	}
	public void SetAlphaTest(bool b) {
	    SprExport.Spr_GRRenderBaseIf_SetAlphaTest((IntPtr) _this, (bool) b);
	}
	public void SetAlphaMode(GRRenderBaseIf.TBlendFunc src, GRRenderBaseIf.TBlendFunc dest) {
	    SprExport.Spr_GRRenderBaseIf_SetAlphaMode((IntPtr) _this, (int) src, (int) dest);
	}
	public void SetLighting(bool l) {
	    SprExport.Spr_GRRenderBaseIf_SetLighting((IntPtr) _this, (bool) l);
	}
	public void SetTexture2D(bool b) {
	    SprExport.Spr_GRRenderBaseIf_SetTexture2D((IntPtr) _this, (bool) b);
	}
	public void SetTexture3D(bool b) {
	    SprExport.Spr_GRRenderBaseIf_SetTexture3D((IntPtr) _this, (bool) b);
	}
	public uint LoadTexture(string filename) {
            IntPtr remote1 = Marshal.StringToBSTR(filename);
	    uint result = (uint) SprExport.Spr_GRRenderBaseIf_LoadTexture((IntPtr) _this, (IntPtr) remote1);
            Marshal.FreeBSTR(remote1);
	    return result;
	}
	public void SetTextureImage(string id, int components, int xsize, int ysize, int format, string tb) {
            IntPtr remote1 = Marshal.StringToBSTR(id);
	    SprExport.Spr_GRRenderBaseIf_SetTextureImage((IntPtr) _this, (IntPtr) remote1, (int) components, (int) xsize, (int) ysize, (int) format, (string) tb);
            Marshal.FreeBSTR(remote1);
	}
	public void SetBlending(bool b) {
	    SprExport.Spr_GRRenderBaseIf_SetBlending((IntPtr) _this, (bool) b);
	}
	public GRShaderIf CreateShader(GRShaderDesc sd) {
	    IntPtr ptr = SprExport.Spr_GRRenderBaseIf_CreateShader((IntPtr) _this, (IntPtr) sd);
            if (ptr == IntPtr.Zero) { return null; } 
            GRShaderIf obj = new GRShaderIf(ptr);
            return obj;
	}
	public bool SetShader(GRShaderIf shader) {
	    char ret = SprExport.Spr_GRRenderBaseIf_SetShader((IntPtr) _this, (IntPtr) shader);
	    return (ret == 0) ? false : true;
	}
	public void SetShadowLight(GRShadowLightDesc sld) {
	    SprExport.Spr_GRRenderBaseIf_SetShadowLight((IntPtr) _this, (IntPtr) sld);
	}
	public void EnterShadowMapGeneration() {
	    SprExport.Spr_GRRenderBaseIf_EnterShadowMapGeneration((IntPtr) _this);
	}
	public void LeaveShadowMapGeneration() {
	    SprExport.Spr_GRRenderBaseIf_LeaveShadowMapGeneration((IntPtr) _this);
	}
	public enum TPrimitiveType : int {
	    POINTS = 0, LINES = POINTS + 1, LINE_STRIP = LINES + 1, LINE_LOOP = LINE_STRIP + 1, TRIANGLES = LINE_LOOP + 1, TRIANGLE_STRIP = TRIANGLES + 1, TRIANGLE_FAN = TRIANGLE_STRIP + 1, QUADS = TRIANGLE_FAN + 1
	}
	public enum TDepthFunc : int {
	    DF_NEVER = 0, DF_LESS = DF_NEVER + 1, DF_EQUAL = DF_LESS + 1, DF_LEQUAL = DF_EQUAL + 1, DF_GREATER = DF_LEQUAL + 1, DF_NOTEQUAL = DF_GREATER + 1, DF_GEQUAL = DF_NOTEQUAL + 1, DF_ALWAYS = DF_GEQUAL + 1
	}
	public enum TBlendFunc : int {
	    BF_ZERO = 0, BF_ONE = BF_ZERO + 1, BF_SRCCOLOR = BF_ONE + 1, BF_INVSRCCOLOR = BF_SRCCOLOR + 1, BF_SRCALPHA = BF_INVSRCCOLOR + 1, BF_INVSRCALPHA = BF_SRCALPHA + 1, BF_DESTALPHA = BF_INVSRCALPHA + 1, BF_INVDESTALPHA = BF_DESTALPHA + 1, BF_DESTCOLOR = BF_INVDESTALPHA + 1, BF_INVDESTCOLOR = BF_DESTCOLOR + 1, BF_SRCALPHASAT = BF_INVDESTCOLOR + 1, BF_BOTHINVSRCALPHA = BF_SRCALPHASAT + 1, BF_BLENDFACTOR = BF_BOTHINVSRCALPHA + 1, BF_INVBLENDFACTOR = BF_BLENDFACTOR + 1
	}
	public enum TMaterialSample : int {
	    INDIANRED = 0, LIGHTCORAL = INDIANRED + 1, SALMON = LIGHTCORAL + 1, DARKSALMON = SALMON + 1, LIGHTSALMON = DARKSALMON + 1, RED = LIGHTSALMON + 1, CRIMSON = RED + 1, FIREBRICK = CRIMSON + 1, DARKRED = FIREBRICK + 1, PINK = DARKRED + 1, LIGHTPINK = PINK + 1, HOTPINK = LIGHTPINK + 1, DEEPPINK = HOTPINK + 1, MEDIUMVIOLETRED = DEEPPINK + 1, PALEVIOLETRED = MEDIUMVIOLETRED + 1, CORAL = PALEVIOLETRED + 1, TOMATO = CORAL + 1, ORANGERED = TOMATO + 1, DARKORANGE = ORANGERED + 1, ORANGE = DARKORANGE + 1, GOLD = ORANGE + 1, YELLOW = GOLD + 1, LIGHTYELLOW = YELLOW + 1, LEMONCHIFFON = LIGHTYELLOW + 1, LIGHTGOLDENRODYELLOW = LEMONCHIFFON + 1, PAPAYAWHIP = LIGHTGOLDENRODYELLOW + 1, MOCCASIN = PAPAYAWHIP + 1, PEACHPUFF = MOCCASIN + 1, PALEGOLDENROD = PEACHPUFF + 1, KHAKI = PALEGOLDENROD + 1, DARKKHAKI = KHAKI + 1, LAVENDER = DARKKHAKI + 1, THISTLE = LAVENDER + 1, PLUM = THISTLE + 1, VIOLET = PLUM + 1, ORCHILD = VIOLET + 1, FUCHSIA = ORCHILD + 1, MAGENTA = FUCHSIA + 1, MEDIUMORCHILD = MAGENTA + 1, MEDIUMPURPLE = MEDIUMORCHILD + 1, BLUEVIOLET = MEDIUMPURPLE + 1, DARKVIOLET = BLUEVIOLET + 1, DARKORCHILD = DARKVIOLET + 1, DARKMAGENTA = DARKORCHILD + 1, PURPLE = DARKMAGENTA + 1, INDIGO = PURPLE + 1, DARKSLATEBLUE = INDIGO + 1, SLATEBLUE = DARKSLATEBLUE + 1, MEDIUMSLATEBLUE = SLATEBLUE + 1, GREENYELLOW = MEDIUMSLATEBLUE + 1, CHARTREUSE = GREENYELLOW + 1, LAWNGREEN = CHARTREUSE + 1, LIME = LAWNGREEN + 1, LIMEGREEN = LIME + 1, PALEGREEN = LIMEGREEN + 1, LIGHTGREEN = PALEGREEN + 1, MEDIUMSPRINGGREEN = LIGHTGREEN + 1, SPRINGGREEN = MEDIUMSPRINGGREEN + 1, MEDIUMSEAGREEN = SPRINGGREEN + 1, SEAGREEN = MEDIUMSEAGREEN + 1, FORESTGREEN = SEAGREEN + 1, GREEN = FORESTGREEN + 1, DARKGREEN = GREEN + 1, YELLOWGREEN = DARKGREEN + 1, OLIVEDRAB = YELLOWGREEN + 1, OLIVE = OLIVEDRAB + 1, DARKOLIVEGREEN = OLIVE + 1, MEDIUMAQUAMARINE = DARKOLIVEGREEN + 1, DARKSEAGREEN = MEDIUMAQUAMARINE + 1, LIGHTSEAGREEN = DARKSEAGREEN + 1, DARKCYAN = LIGHTSEAGREEN + 1, TEAL = DARKCYAN + 1, AQUA = TEAL + 1, CYAN = AQUA + 1, LIGHTCYAN = CYAN + 1, PALETURQUOISE = LIGHTCYAN + 1, AQUAMARINE = PALETURQUOISE + 1, TURQUOISE = AQUAMARINE + 1, MEDIUMTURQUOISE = TURQUOISE + 1, DARKTURQUOISE = MEDIUMTURQUOISE + 1, CADETBLUE = DARKTURQUOISE + 1, STEELBLUE = CADETBLUE + 1, LIGHTSTEELBLUE = STEELBLUE + 1, POWDERBLUE = LIGHTSTEELBLUE + 1, LIGHTBLUE = POWDERBLUE + 1, SKYBLUE = LIGHTBLUE + 1, LIGHTSKYBLUE = SKYBLUE + 1, DEEPSKYBLUE = LIGHTSKYBLUE + 1, DODGERBLUE = DEEPSKYBLUE + 1, CORNFLOWERBLUE = DODGERBLUE + 1, ROYALBLUE = CORNFLOWERBLUE + 1, BLUE = ROYALBLUE + 1, MEDIUMBLUE = BLUE + 1, DARKBLUE = MEDIUMBLUE + 1, NAVY = DARKBLUE + 1, MIDNIGHTBLUE = NAVY + 1, CORNSILK = MIDNIGHTBLUE + 1, BLANCHEDALMOND = CORNSILK + 1, BISQUE = BLANCHEDALMOND + 1, NAVAJOWHITE = BISQUE + 1, WHEAT = NAVAJOWHITE + 1, BURLYWOOD = WHEAT + 1, TAN = BURLYWOOD + 1, ROSYBROWN = TAN + 1, SANDYBROWN = ROSYBROWN + 1, GOLDENROD = SANDYBROWN + 1, DARKGOLDENROD = GOLDENROD + 1, PERU = DARKGOLDENROD + 1, CHOCOLATE = PERU + 1, SADDLEBROWN = CHOCOLATE + 1, SIENNA = SADDLEBROWN + 1, BROWN = SIENNA + 1, MAROON = BROWN + 1, WHITE = MAROON + 1, SNOW = WHITE + 1, HONEYDEW = SNOW + 1, MINTCREAM = HONEYDEW + 1, AZURE = MINTCREAM + 1, ALICEBLUE = AZURE + 1, GHOSTWHITE = ALICEBLUE + 1, WHITESMOKE = GHOSTWHITE + 1, SEASHELL = WHITESMOKE + 1, BEIGE = SEASHELL + 1, OLDLACE = BEIGE + 1, FLORALWHITE = OLDLACE + 1, IVORY = FLORALWHITE + 1, ANTIQUEWHITE = IVORY + 1, LINEN = ANTIQUEWHITE + 1, LAVENDERBLUSH = LINEN + 1, MISTYROSE = LAVENDERBLUSH + 1, GAINSBORO = MISTYROSE + 1, LIGHTGRAY = GAINSBORO + 1, SILVER = LIGHTGRAY + 1, DARKGRAY = SILVER + 1, GRAY = DARKGRAY + 1, DIMGRAY = GRAY + 1, LIGHTSLATEGRAY = DIMGRAY + 1, SLATEGRAY = LIGHTSLATEGRAY + 1, DARKSLATEGRAY = SLATEGRAY + 1, BLACK = DARKSLATEGRAY + 1, MATERIAL_SAMPLE_END = BLACK + 1
	}
    }
    public partial class GRRenderIf : GRRenderBaseIf {
	public GRRenderIf() { _this = SprExport.Spr_new_GRRenderIf(); _flag = true; }
	public GRRenderIf(IntPtr ptr) : base(ptr) {}
	public GRRenderIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRRenderIf(CsCastObject target) {
		return (target._info.Inherit(GRRenderIf.GetIfInfoStatic()) ? new GRRenderIf(target._this, target._flag) : null);
	}
	~GRRenderIf() { if (_flag) { SprExport.Spr_delete_GRRenderIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRRenderIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRRenderIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRRenderIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRRenderIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void SetDevice(GRDeviceIf dev) {
	    SprExport.Spr_GRRenderIf_SetDevice((IntPtr) _this, (IntPtr) dev);
	}
	public GRDeviceIf GetDevice() {
	    IntPtr ptr = SprExport.Spr_GRRenderIf_GetDevice((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRDeviceIf obj = new GRDeviceIf(ptr);
            if (obj.GetIfInfo() == GRDeviceGLIf.GetIfInfoStatic()) { return new GRDeviceGLIf(ptr); }
            return obj;
	}
	public void SetCamera(GRCameraDesc cam) {
	    SprExport.Spr_GRRenderIf_SetCamera((IntPtr) _this, (IntPtr) cam);
	}
	public GRCameraDesc GetCamera() {
	    IntPtr ptr = SprExport.Spr_GRRenderIf_GetCamera((IntPtr) _this);
            return new GRCameraDesc(ptr, true);
	}
	public void Reshape(Vec2f pos, Vec2f screenSize) {
	    SprExport.Spr_GRRenderIf_Reshape((IntPtr) _this, (IntPtr) pos, (IntPtr) screenSize);
	}
	public Vec2f GetPixelSize() {
	    IntPtr ptr = SprExport.Spr_GRRenderIf_GetPixelSize((IntPtr) _this);
            return new Vec2f(ptr, true);
	}
	public Vec4f GetReservedColor(int matname) {
	    IntPtr ptr = SprExport.Spr_GRRenderIf_GetReservedColor((IntPtr) _this, (int) matname);
            return new Vec4f(ptr, true);
	}
	public Vec3f ScreenToCamera(int x, int y, float depth, bool LorR) {
	    IntPtr ptr = SprExport.Spr_GRRenderIf_ScreenToCamera((IntPtr) _this, (int) x, (int) y, (float) depth, (bool) LorR);
            return new Vec3f(ptr, true);
	}
	public Vec3f ScreenToCamera(int x, int y, float depth) {
	    IntPtr ptr = SprExport.Spr_GRRenderIf_ScreenToCamera_1((IntPtr) _this, (int) x, (int) y, (float) depth);
            return new Vec3f(ptr, true);
	}
	public void EnterScreenCoordinate() {
	    SprExport.Spr_GRRenderIf_EnterScreenCoordinate((IntPtr) _this);
	}
	public void LeaveScreenCoordinate() {
	    SprExport.Spr_GRRenderIf_LeaveScreenCoordinate((IntPtr) _this);
	}
    }
    public partial class GRDeviceIf : GRRenderBaseIf {
	public GRDeviceIf() { _this = SprExport.Spr_new_GRDeviceIf(); _flag = true; }
	public GRDeviceIf(IntPtr ptr) : base(ptr) {}
	public GRDeviceIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRDeviceIf(CsCastObject target) {
		return (target._info.Inherit(GRDeviceIf.GetIfInfoStatic()) ? new GRDeviceIf(target._this, target._flag) : null);
	}
	~GRDeviceIf() { if (_flag) { SprExport.Spr_delete_GRDeviceIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRDeviceIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRDeviceIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRDeviceIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRDeviceIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void Init() {
	    SprExport.Spr_GRDeviceIf_Init((IntPtr) _this);
	}
    }
    public partial class GRDeviceGLIf : GRDeviceIf {
	public GRDeviceGLIf() { _this = SprExport.Spr_new_GRDeviceGLIf(); _flag = true; }
	public GRDeviceGLIf(IntPtr ptr) : base(ptr) {}
	public GRDeviceGLIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRDeviceGLIf(CsCastObject target) {
		return (target._info.Inherit(GRDeviceGLIf.GetIfInfoStatic()) ? new GRDeviceGLIf(target._this, target._flag) : null);
	}
	~GRDeviceGLIf() { if (_flag) { SprExport.Spr_delete_GRDeviceGLIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRDeviceGLIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRDeviceGLIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRDeviceGLIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRDeviceGLIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public bool CheckGLVersion(int major, int minor) {
	    char ret = SprExport.Spr_GRDeviceGLIf_CheckGLVersion((IntPtr) _this, (int) major, (int) minor);
	    return (ret == 0) ? false : true;
	}
	public int GetGLMajorVersion() {
	    int result = (int) SprExport.Spr_GRDeviceGLIf_GetGLMajorVersion((IntPtr) _this);
	    return result;
	}
	public int GetGLMinorVersion() {
	    int result = (int) SprExport.Spr_GRDeviceGLIf_GetGLMinorVersion((IntPtr) _this);
	    return result;
	}
	public void SetGLVersion(int major, int minor) {
	    SprExport.Spr_GRDeviceGLIf_SetGLVersion((IntPtr) _this, (int) major, (int) minor);
	}
    }
    public partial class GRSceneIf : SceneIf {
	public GRSceneIf() { _this = SprExport.Spr_new_GRSceneIf(); _flag = true; }
	public GRSceneIf(IntPtr ptr) : base(ptr) {}
	public GRSceneIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRSceneIf(CsCastObject target) {
		return (target._info.Inherit(GRSceneIf.GetIfInfoStatic()) ? new GRSceneIf(target._this, target._flag) : null);
	}
	~GRSceneIf() { if (_flag) { SprExport.Spr_delete_GRSceneIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRSceneIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRSceneIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRSceneIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRSceneIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public void Render(GRRenderIf r) {
	    SprExport.Spr_GRSceneIf_Render((IntPtr) _this, (IntPtr) r);
	}
	public GRFrameIf GetWorld() {
	    IntPtr ptr = SprExport.Spr_GRSceneIf_GetWorld((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRFrameIf obj = new GRFrameIf(ptr);
            return obj;
	}
	public GRCameraIf GetCamera() {
	    IntPtr ptr = SprExport.Spr_GRSceneIf_GetCamera((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRCameraIf obj = new GRCameraIf(ptr);
            return obj;
	}
	public void SetCamera(GRCameraDesc desc) {
	    SprExport.Spr_GRSceneIf_SetCamera((IntPtr) _this, (IntPtr) desc);
	}
	public void SetCamera() {
	    SprExport.Spr_GRSceneIf_SetCamera_1((IntPtr) _this);
	}
	public GRAnimationControllerIf GetAnimationController() {
	    IntPtr ptr = SprExport.Spr_GRSceneIf_GetAnimationController((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRAnimationControllerIf obj = new GRAnimationControllerIf(ptr);
            return obj;
	}
	public GRSdkIf GetSdk() {
	    IntPtr ptr = SprExport.Spr_GRSceneIf_GetSdk((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRSdkIf obj = new GRSdkIf(ptr);
            return obj;
	}
    }
    public partial class GRSdkIf : SdkIf {
	public GRSdkIf() { _this = SprExport.Spr_new_GRSdkIf(); _flag = true; }
	public GRSdkIf(IntPtr ptr) : base(ptr) {}
	public GRSdkIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRSdkIf(CsCastObject target) {
		return (target._info.Inherit(GRSdkIf.GetIfInfoStatic()) ? new GRSdkIf(target._this, target._flag) : null);
	}
	~GRSdkIf() { if (_flag) { SprExport.Spr_delete_GRSdkIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRSdkIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRSdkIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRSdkIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRSdkIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public GRRenderIf CreateRender() {
	    IntPtr ptr = SprExport.Spr_GRSdkIf_CreateRender((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRRenderIf obj = new GRRenderIf(ptr);
            return obj;
	}
	public GRDeviceGLIf CreateDeviceGL() {
	    IntPtr ptr = SprExport.Spr_GRSdkIf_CreateDeviceGL((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRDeviceGLIf obj = new GRDeviceGLIf(ptr);
            return obj;
	}
	public GRSceneIf CreateScene(GRSceneDesc desc) {
	    IntPtr ptr = SprExport.Spr_GRSdkIf_CreateScene((IntPtr) _this, (IntPtr) desc);
            if (ptr == IntPtr.Zero) { return null; } 
            GRSceneIf obj = new GRSceneIf(ptr);
            return obj;
	}
	public GRSceneIf CreateScene() {
	    IntPtr ptr = SprExport.Spr_GRSdkIf_CreateScene_1((IntPtr) _this);
            if (ptr == IntPtr.Zero) { return null; } 
            GRSceneIf obj = new GRSceneIf(ptr);
            return obj;
	}
	public GRSceneIf GetScene(ulong i) {
	    IntPtr ptr = SprExport.Spr_GRSdkIf_GetScene((IntPtr) _this, (ulong) i);
            if (ptr == IntPtr.Zero) { return null; } 
            GRSceneIf obj = new GRSceneIf(ptr);
            return obj;
	}
	public ulong NScene() {
	    ulong result = (ulong) SprExport.Spr_GRSdkIf_NScene((IntPtr) _this);
	    return result;
	}
	public void MergeScene(GRSceneIf scene0, GRSceneIf scene1) {
	    SprExport.Spr_GRSdkIf_MergeScene((IntPtr) _this, (IntPtr) scene0, (IntPtr) scene1);
	}
	public static GRSdkIf CreateSdk() {
	    IntPtr ptr = SprExport.Spr_GRSdkIf_CreateSdk();
            if (ptr == IntPtr.Zero) { return null; } 
            GRSdkIf obj = new GRSdkIf(ptr);
            return obj;
	}
	public static void RegisterSdk() {
	    SprExport.Spr_GRSdkIf_RegisterSdk();
	}
    }
    public partial class GRShaderIf : ObjectIf {
	public GRShaderIf() { _this = SprExport.Spr_new_GRShaderIf(); _flag = true; }
	public GRShaderIf(IntPtr ptr) : base(ptr) {}
	public GRShaderIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRShaderIf(CsCastObject target) {
		return (target._info.Inherit(GRShaderIf.GetIfInfoStatic()) ? new GRShaderIf(target._this, target._flag) : null);
	}
	~GRShaderIf() { if (_flag) { SprExport.Spr_delete_GRShaderIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRShaderIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRShaderIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRShaderIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRShaderIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
	public int GetProgramID() {
	    int result = (int) SprExport.Spr_GRShaderIf_GetProgramID((IntPtr) _this);
	    return result;
	}
    }
    public partial class GRSphereIf : GRVisualIf {
	public GRSphereIf() { _this = SprExport.Spr_new_GRSphereIf(); _flag = true; }
	public GRSphereIf(IntPtr ptr) : base(ptr) {}
	public GRSphereIf(IntPtr ptr, bool flag) : base(ptr, flag) {}
	public static implicit operator GRSphereIf(CsCastObject target) {
		return (target._info.Inherit(GRSphereIf.GetIfInfoStatic()) ? new GRSphereIf(target._this, target._flag) : null);
	}
	~GRSphereIf() { if (_flag) { SprExport.Spr_delete_GRSphereIf(_this); _flag = false; } }
        public override string ToString() {
            IntPtr ptr = SprExport.Spr_GRSphereIf_ToString((IntPtr) _this);
            string bstr = Marshal.PtrToStringBSTR(ptr);
            SprExport.Spr_GRSphereIf_FreeString((IntPtr) ptr);
            return bstr;
        }
	public IfInfo GetIfInfo() {
	    IntPtr ptr = SprExport.Spr_GRSphereIf_GetIfInfo((IntPtr) _this);
            return new IfInfo(ptr);
	}
	public static IfInfo GetIfInfoStatic() {
	    IntPtr ptr = SprExport.Spr_GRSphereIf_GetIfInfoStatic();
            return new IfInfo(ptr);
	}
    }
	public partial class IfInfoToCsType {
		public static Dictionary<IntPtr, Type> mapGraphics = new Dictionary<IntPtr, Type>() {
			{GRVisualIf.GetIfInfoStatic(), typeof(GRVisualIf)},
			{GRFrameIf.GetIfInfoStatic(), typeof(GRFrameIf)},
			{GRDummyFrameIf.GetIfInfoStatic(), typeof(GRDummyFrameIf)},
			{GRAnimationIf.GetIfInfoStatic(), typeof(GRAnimationIf)},
			{GRAnimationSetIf.GetIfInfoStatic(), typeof(GRAnimationSetIf)},
			{GRAnimationControllerIf.GetIfInfoStatic(), typeof(GRAnimationControllerIf)},
			{GRBlendMeshIf.GetIfInfoStatic(), typeof(GRBlendMeshIf)},
			{GRSkinWeightIf.GetIfInfoStatic(), typeof(GRSkinWeightIf)},
			{GRMeshIf.GetIfInfoStatic(), typeof(GRMeshIf)},
			{GRLightIf.GetIfInfoStatic(), typeof(GRLightIf)},
			{GRMaterialIf.GetIfInfoStatic(), typeof(GRMaterialIf)},
			{GRCameraIf.GetIfInfoStatic(), typeof(GRCameraIf)},
			{GRShadowLightIf.GetIfInfoStatic(), typeof(GRShadowLightIf)},
			{GRRenderBaseIf.GetIfInfoStatic(), typeof(GRRenderBaseIf)},
			{GRRenderIf.GetIfInfoStatic(), typeof(GRRenderIf)},
			{GRDeviceIf.GetIfInfoStatic(), typeof(GRDeviceIf)},
			{GRDeviceGLIf.GetIfInfoStatic(), typeof(GRDeviceGLIf)},
			{GRSceneIf.GetIfInfoStatic(), typeof(GRSceneIf)},
			{GRSdkIf.GetIfInfoStatic(), typeof(GRSdkIf)},
			{GRShaderIf.GetIfInfoStatic(), typeof(GRShaderIf)},
			{GRSphereIf.GetIfInfoStatic(), typeof(GRSphereIf)},
		};
	}
}
