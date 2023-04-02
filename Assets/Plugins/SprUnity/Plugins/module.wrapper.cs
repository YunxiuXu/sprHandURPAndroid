using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace SprCs {
    public class arraywrapper_GRMeshFace : arraywrapper {
        public arraywrapper_GRMeshFace(int nelm) : base(nelm) {
            _this = SprExport.Spr_array_new_GRMeshFace(nelm);
            _flag = true;
        }
        public arraywrapper_GRMeshFace(IntPtr ptr, int nelm) : base(ptr, nelm) {}
        public arraywrapper_GRMeshFace(IntPtr ptr, int nelm, bool flag) : base(ptr, nelm, flag) {}
        ~arraywrapper_GRMeshFace() {
            if (_flag) { SprExport.Spr_array_delete_GRMeshFace(_this); _flag = false; }
        }
        public GRMeshFace this[int index] {
            get { return new GRMeshFace(SprExport.Spr_array_get_GRMeshFace(_this, index)); }
            set { SprExport.Spr_array_set_GRMeshFace(_this, index, value); }
        }
        public int size() { return (int) _nelm; }
        public static implicit operator List<GRMeshFace>(arraywrapper_GRMeshFace m) {
            List<GRMeshFace> r = new List<GRMeshFace>();
            for (int i = 0; i < (int) m._nelm; i++) {
                IntPtr member = SprExport.Spr_array_get_GRMeshFace(m._this, i);
                r.Add(new GRMeshFace(member));
            }
            return r;
        }
        public static implicit operator arraywrapper_GRMeshFace(List<GRMeshFace> r) {
            int size = r.Count;
            IntPtr ptr = SprExport.Spr_array_new_GRMeshFace(size);
            arraywrapper_GRMeshFace m = new arraywrapper_GRMeshFace(ptr, size, true);
            for (int i = 0; i < size; i++) {
                SprExport.Spr_array_set_GRMeshFace(m._this, i, r[i]);
            }
            return m;
        }
        public static implicit operator GRMeshFace[](arraywrapper_GRMeshFace m) {
            int size = (int) m._nelm;
            GRMeshFace[] r = new GRMeshFace[size];
            for (int i = 0; i < size; i++) {
                 IntPtr ptr = SprExport.Spr_array_get_GRMeshFace(m._this, i);
                 r[i] = new GRMeshFace(ptr);
            }
            return r;
        }
        public static implicit operator GRMeshFace(arraywrapper_GRMeshFace m) {
            int size = (int) m._nelm;
            IntPtr ptr = SprExport.Spr_array_get_GRMeshFace(m._this, 0);
            GRMeshFace r = new GRMeshFace(ptr);
            return r;
        }
        public static implicit operator arraywrapper_GRMeshFace(GRMeshFace[] r) {
            int size = r.Length;
            IntPtr ptr = SprExport.Spr_array_new_GRMeshFace(size);
            arraywrapper_GRMeshFace m = new arraywrapper_GRMeshFace(ptr, size, true);
            for (int i = 0; i < size; i++) {
                SprExport.Spr_array_set_GRMeshFace(m._this, i, r[i]);
            }
            return m;
        }
    }
    public class arraywrapper_PHOpGroupDesc : arraywrapper {
        public arraywrapper_PHOpGroupDesc(int nelm) : base(nelm) {
            _this = SprExport.Spr_array_new_PHOpGroupDesc(nelm);
            _flag = true;
        }
        public arraywrapper_PHOpGroupDesc(IntPtr ptr, int nelm) : base(ptr, nelm) {}
        public arraywrapper_PHOpGroupDesc(IntPtr ptr, int nelm, bool flag) : base(ptr, nelm, flag) {}
        ~arraywrapper_PHOpGroupDesc() {
            if (_flag) { SprExport.Spr_array_delete_PHOpGroupDesc(_this); _flag = false; }
        }
        public PHOpGroupDesc this[int index] {
            get { return new PHOpGroupDesc(SprExport.Spr_array_get_PHOpGroupDesc(_this, index)); }
            set { SprExport.Spr_array_set_PHOpGroupDesc(_this, index, value); }
        }
        public int size() { return (int) _nelm; }
        public static implicit operator List<PHOpGroupDesc>(arraywrapper_PHOpGroupDesc m) {
            List<PHOpGroupDesc> r = new List<PHOpGroupDesc>();
            for (int i = 0; i < (int) m._nelm; i++) {
                IntPtr member = SprExport.Spr_array_get_PHOpGroupDesc(m._this, i);
                r.Add(new PHOpGroupDesc(member));
            }
            return r;
        }
        public static implicit operator arraywrapper_PHOpGroupDesc(List<PHOpGroupDesc> r) {
            int size = r.Count;
            IntPtr ptr = SprExport.Spr_array_new_PHOpGroupDesc(size);
            arraywrapper_PHOpGroupDesc m = new arraywrapper_PHOpGroupDesc(ptr, size, true);
            for (int i = 0; i < size; i++) {
                SprExport.Spr_array_set_PHOpGroupDesc(m._this, i, r[i]);
            }
            return m;
        }
        public static implicit operator PHOpGroupDesc[](arraywrapper_PHOpGroupDesc m) {
            int size = (int) m._nelm;
            PHOpGroupDesc[] r = new PHOpGroupDesc[size];
            for (int i = 0; i < size; i++) {
                 IntPtr ptr = SprExport.Spr_array_get_PHOpGroupDesc(m._this, i);
                 r[i] = new PHOpGroupDesc(ptr);
            }
            return r;
        }
        public static implicit operator PHOpGroupDesc(arraywrapper_PHOpGroupDesc m) {
            int size = (int) m._nelm;
            IntPtr ptr = SprExport.Spr_array_get_PHOpGroupDesc(m._this, 0);
            PHOpGroupDesc r = new PHOpGroupDesc(ptr);
            return r;
        }
        public static implicit operator arraywrapper_PHOpGroupDesc(PHOpGroupDesc[] r) {
            int size = r.Length;
            IntPtr ptr = SprExport.Spr_array_new_PHOpGroupDesc(size);
            arraywrapper_PHOpGroupDesc m = new arraywrapper_PHOpGroupDesc(ptr, size, true);
            for (int i = 0; i < size; i++) {
                SprExport.Spr_array_set_PHOpGroupDesc(m._this, i, r[i]);
            }
            return m;
        }
    }
    public class arraywrapper_PHOpObjDesc : arraywrapper {
        public arraywrapper_PHOpObjDesc(int nelm) : base(nelm) {
            _this = SprExport.Spr_array_new_PHOpObjDesc(nelm);
            _flag = true;
        }
        public arraywrapper_PHOpObjDesc(IntPtr ptr, int nelm) : base(ptr, nelm) {}
        public arraywrapper_PHOpObjDesc(IntPtr ptr, int nelm, bool flag) : base(ptr, nelm, flag) {}
        ~arraywrapper_PHOpObjDesc() {
            if (_flag) { SprExport.Spr_array_delete_PHOpObjDesc(_this); _flag = false; }
        }
        public PHOpObjDesc this[int index] {
            get { return new PHOpObjDesc(SprExport.Spr_array_get_PHOpObjDesc(_this, index)); }
            set { SprExport.Spr_array_set_PHOpObjDesc(_this, index, value); }
        }
        public int size() { return (int) _nelm; }
        public static implicit operator List<PHOpObjDesc>(arraywrapper_PHOpObjDesc m) {
            List<PHOpObjDesc> r = new List<PHOpObjDesc>();
            for (int i = 0; i < (int) m._nelm; i++) {
                IntPtr member = SprExport.Spr_array_get_PHOpObjDesc(m._this, i);
                r.Add(new PHOpObjDesc(member));
            }
            return r;
        }
        public static implicit operator arraywrapper_PHOpObjDesc(List<PHOpObjDesc> r) {
            int size = r.Count;
            IntPtr ptr = SprExport.Spr_array_new_PHOpObjDesc(size);
            arraywrapper_PHOpObjDesc m = new arraywrapper_PHOpObjDesc(ptr, size, true);
            for (int i = 0; i < size; i++) {
                SprExport.Spr_array_set_PHOpObjDesc(m._this, i, r[i]);
            }
            return m;
        }
        public static implicit operator PHOpObjDesc[](arraywrapper_PHOpObjDesc m) {
            int size = (int) m._nelm;
            PHOpObjDesc[] r = new PHOpObjDesc[size];
            for (int i = 0; i < size; i++) {
                 IntPtr ptr = SprExport.Spr_array_get_PHOpObjDesc(m._this, i);
                 r[i] = new PHOpObjDesc(ptr);
            }
            return r;
        }
        public static implicit operator PHOpObjDesc(arraywrapper_PHOpObjDesc m) {
            int size = (int) m._nelm;
            IntPtr ptr = SprExport.Spr_array_get_PHOpObjDesc(m._this, 0);
            PHOpObjDesc r = new PHOpObjDesc(ptr);
            return r;
        }
        public static implicit operator arraywrapper_PHOpObjDesc(PHOpObjDesc[] r) {
            int size = r.Length;
            IntPtr ptr = SprExport.Spr_array_new_PHOpObjDesc(size);
            arraywrapper_PHOpObjDesc m = new arraywrapper_PHOpObjDesc(ptr, size, true);
            for (int i = 0; i < size; i++) {
                SprExport.Spr_array_set_PHOpObjDesc(m._this, i, r[i]);
            }
            return m;
        }
    }
    public class arraywrapper_PHOpParticleDesc : arraywrapper {
        public arraywrapper_PHOpParticleDesc(int nelm) : base(nelm) {
            _this = SprExport.Spr_array_new_PHOpParticleDesc(nelm);
            _flag = true;
        }
        public arraywrapper_PHOpParticleDesc(IntPtr ptr, int nelm) : base(ptr, nelm) {}
        public arraywrapper_PHOpParticleDesc(IntPtr ptr, int nelm, bool flag) : base(ptr, nelm, flag) {}
        ~arraywrapper_PHOpParticleDesc() {
            if (_flag) { SprExport.Spr_array_delete_PHOpParticleDesc(_this); _flag = false; }
        }
        public PHOpParticleDesc this[int index] {
            get { return new PHOpParticleDesc(SprExport.Spr_array_get_PHOpParticleDesc(_this, index)); }
            set { SprExport.Spr_array_set_PHOpParticleDesc(_this, index, value); }
        }
        public int size() { return (int) _nelm; }
        public static implicit operator List<PHOpParticleDesc>(arraywrapper_PHOpParticleDesc m) {
            List<PHOpParticleDesc> r = new List<PHOpParticleDesc>();
            for (int i = 0; i < (int) m._nelm; i++) {
                IntPtr member = SprExport.Spr_array_get_PHOpParticleDesc(m._this, i);
                r.Add(new PHOpParticleDesc(member));
            }
            return r;
        }
        public static implicit operator arraywrapper_PHOpParticleDesc(List<PHOpParticleDesc> r) {
            int size = r.Count;
            IntPtr ptr = SprExport.Spr_array_new_PHOpParticleDesc(size);
            arraywrapper_PHOpParticleDesc m = new arraywrapper_PHOpParticleDesc(ptr, size, true);
            for (int i = 0; i < size; i++) {
                SprExport.Spr_array_set_PHOpParticleDesc(m._this, i, r[i]);
            }
            return m;
        }
        public static implicit operator PHOpParticleDesc[](arraywrapper_PHOpParticleDesc m) {
            int size = (int) m._nelm;
            PHOpParticleDesc[] r = new PHOpParticleDesc[size];
            for (int i = 0; i < size; i++) {
                 IntPtr ptr = SprExport.Spr_array_get_PHOpParticleDesc(m._this, i);
                 r[i] = new PHOpParticleDesc(ptr);
            }
            return r;
        }
        public static implicit operator PHOpParticleDesc(arraywrapper_PHOpParticleDesc m) {
            int size = (int) m._nelm;
            IntPtr ptr = SprExport.Spr_array_get_PHOpParticleDesc(m._this, 0);
            PHOpParticleDesc r = new PHOpParticleDesc(ptr);
            return r;
        }
        public static implicit operator arraywrapper_PHOpParticleDesc(PHOpParticleDesc[] r) {
            int size = r.Length;
            IntPtr ptr = SprExport.Spr_array_new_PHOpParticleDesc(size);
            arraywrapper_PHOpParticleDesc m = new arraywrapper_PHOpParticleDesc(ptr, size, true);
            for (int i = 0; i < size; i++) {
                SprExport.Spr_array_set_PHOpParticleDesc(m._this, i, r[i]);
            }
            return m;
        }
    }
    public class arraywrapper_PHRaycastHit : arraywrapper {
        public arraywrapper_PHRaycastHit(int nelm) : base(nelm) {
            _this = SprExport.Spr_array_new_PHRaycastHit(nelm);
            _flag = true;
        }
        public arraywrapper_PHRaycastHit(IntPtr ptr, int nelm) : base(ptr, nelm) {}
        public arraywrapper_PHRaycastHit(IntPtr ptr, int nelm, bool flag) : base(ptr, nelm, flag) {}
        ~arraywrapper_PHRaycastHit() {
            if (_flag) { SprExport.Spr_array_delete_PHRaycastHit(_this); _flag = false; }
        }
        public PHRaycastHit this[int index] {
            get { return new PHRaycastHit(SprExport.Spr_array_get_PHRaycastHit(_this, index)); }
            set { SprExport.Spr_array_set_PHRaycastHit(_this, index, value); }
        }
        public int size() { return (int) _nelm; }
        public static implicit operator List<PHRaycastHit>(arraywrapper_PHRaycastHit m) {
            List<PHRaycastHit> r = new List<PHRaycastHit>();
            for (int i = 0; i < (int) m._nelm; i++) {
                IntPtr member = SprExport.Spr_array_get_PHRaycastHit(m._this, i);
                r.Add(new PHRaycastHit(member));
            }
            return r;
        }
        public static implicit operator arraywrapper_PHRaycastHit(List<PHRaycastHit> r) {
            int size = r.Count;
            IntPtr ptr = SprExport.Spr_array_new_PHRaycastHit(size);
            arraywrapper_PHRaycastHit m = new arraywrapper_PHRaycastHit(ptr, size, true);
            for (int i = 0; i < size; i++) {
                SprExport.Spr_array_set_PHRaycastHit(m._this, i, r[i]);
            }
            return m;
        }
        public static implicit operator PHRaycastHit[](arraywrapper_PHRaycastHit m) {
            int size = (int) m._nelm;
            PHRaycastHit[] r = new PHRaycastHit[size];
            for (int i = 0; i < size; i++) {
                 IntPtr ptr = SprExport.Spr_array_get_PHRaycastHit(m._this, i);
                 r[i] = new PHRaycastHit(ptr);
            }
            return r;
        }
        public static implicit operator PHRaycastHit(arraywrapper_PHRaycastHit m) {
            int size = (int) m._nelm;
            IntPtr ptr = SprExport.Spr_array_get_PHRaycastHit(m._this, 0);
            PHRaycastHit r = new PHRaycastHit(ptr);
            return r;
        }
        public static implicit operator arraywrapper_PHRaycastHit(PHRaycastHit[] r) {
            int size = r.Length;
            IntPtr ptr = SprExport.Spr_array_new_PHRaycastHit(size);
            arraywrapper_PHRaycastHit m = new arraywrapper_PHRaycastHit(ptr, size, true);
            for (int i = 0; i < size; i++) {
                SprExport.Spr_array_set_PHRaycastHit(m._this, i, r[i]);
            }
            return m;
        }
    }
    public class arraywrapper_Vec2f : arraywrapper {
        public arraywrapper_Vec2f(int nelm) : base(nelm) {
            _this = SprExport.Spr_array_new_Vec2f(nelm);
            _flag = true;
        }
        public arraywrapper_Vec2f(IntPtr ptr, int nelm) : base(ptr, nelm) {}
        public arraywrapper_Vec2f(IntPtr ptr, int nelm, bool flag) : base(ptr, nelm, flag) {}
        ~arraywrapper_Vec2f() {
            if (_flag) { SprExport.Spr_array_delete_Vec2f(_this); _flag = false; }
        }
        public Vec2f this[int index] {
            get { return new Vec2f(SprExport.Spr_array_get_Vec2f(_this, index)); }
            set { SprExport.Spr_array_set_Vec2f(_this, index, value); }
        }
        public int size() { return (int) _nelm; }
        public static implicit operator List<Vec2f>(arraywrapper_Vec2f m) {
            List<Vec2f> r = new List<Vec2f>();
            for (int i = 0; i < (int) m._nelm; i++) {
                IntPtr member = SprExport.Spr_array_get_Vec2f(m._this, i);
                r.Add(new Vec2f(member));
            }
            return r;
        }
        public static implicit operator arraywrapper_Vec2f(List<Vec2f> r) {
            int size = r.Count;
            IntPtr ptr = SprExport.Spr_array_new_Vec2f(size);
            arraywrapper_Vec2f m = new arraywrapper_Vec2f(ptr, size, true);
            for (int i = 0; i < size; i++) {
                SprExport.Spr_array_set_Vec2f(m._this, i, r[i]);
            }
            return m;
        }
        public static implicit operator Vec2f[](arraywrapper_Vec2f m) {
            int size = (int) m._nelm;
            Vec2f[] r = new Vec2f[size];
            for (int i = 0; i < size; i++) {
                 IntPtr ptr = SprExport.Spr_array_get_Vec2f(m._this, i);
                 r[i] = new Vec2f(ptr);
            }
            return r;
        }
        public static implicit operator Vec2f(arraywrapper_Vec2f m) {
            int size = (int) m._nelm;
            IntPtr ptr = SprExport.Spr_array_get_Vec2f(m._this, 0);
            Vec2f r = new Vec2f(ptr);
            return r;
        }
        public static implicit operator arraywrapper_Vec2f(Vec2f[] r) {
            int size = r.Length;
            IntPtr ptr = SprExport.Spr_array_new_Vec2f(size);
            arraywrapper_Vec2f m = new arraywrapper_Vec2f(ptr, size, true);
            for (int i = 0; i < size; i++) {
                SprExport.Spr_array_set_Vec2f(m._this, i, r[i]);
            }
            return m;
        }
    }
    public class arraywrapper_Vec3f : arraywrapper {
        public arraywrapper_Vec3f(int nelm) : base(nelm) {
            _this = SprExport.Spr_array_new_Vec3f(nelm);
            _flag = true;
        }
        public arraywrapper_Vec3f(IntPtr ptr, int nelm) : base(ptr, nelm) {}
        public arraywrapper_Vec3f(IntPtr ptr, int nelm, bool flag) : base(ptr, nelm, flag) {}
        ~arraywrapper_Vec3f() {
            if (_flag) { SprExport.Spr_array_delete_Vec3f(_this); _flag = false; }
        }
        public Vec3f this[int index] {
            get { return new Vec3f(SprExport.Spr_array_get_Vec3f(_this, index)); }
            set { SprExport.Spr_array_set_Vec3f(_this, index, value); }
        }
        public int size() { return (int) _nelm; }
        public static implicit operator List<Vec3f>(arraywrapper_Vec3f m) {
            List<Vec3f> r = new List<Vec3f>();
            for (int i = 0; i < (int) m._nelm; i++) {
                IntPtr member = SprExport.Spr_array_get_Vec3f(m._this, i);
                r.Add(new Vec3f(member));
            }
            return r;
        }
        public static implicit operator arraywrapper_Vec3f(List<Vec3f> r) {
            int size = r.Count;
            IntPtr ptr = SprExport.Spr_array_new_Vec3f(size);
            arraywrapper_Vec3f m = new arraywrapper_Vec3f(ptr, size, true);
            for (int i = 0; i < size; i++) {
                SprExport.Spr_array_set_Vec3f(m._this, i, r[i]);
            }
            return m;
        }
        public static implicit operator Vec3f[](arraywrapper_Vec3f m) {
            int size = (int) m._nelm;
            Vec3f[] r = new Vec3f[size];
            for (int i = 0; i < size; i++) {
                 IntPtr ptr = SprExport.Spr_array_get_Vec3f(m._this, i);
                 r[i] = new Vec3f(ptr);
            }
            return r;
        }
        public static implicit operator Vec3f(arraywrapper_Vec3f m) {
            int size = (int) m._nelm;
            IntPtr ptr = SprExport.Spr_array_get_Vec3f(m._this, 0);
            Vec3f r = new Vec3f(ptr);
            return r;
        }
        public static implicit operator arraywrapper_Vec3f(Vec3f[] r) {
            int size = r.Length;
            IntPtr ptr = SprExport.Spr_array_new_Vec3f(size);
            arraywrapper_Vec3f m = new arraywrapper_Vec3f(ptr, size, true);
            for (int i = 0; i < size; i++) {
                SprExport.Spr_array_set_Vec3f(m._this, i, r[i]);
            }
            return m;
        }
    }
    public class arraywrapper_Vec4f : arraywrapper {
        public arraywrapper_Vec4f(int nelm) : base(nelm) {
            _this = SprExport.Spr_array_new_Vec4f(nelm);
            _flag = true;
        }
        public arraywrapper_Vec4f(IntPtr ptr, int nelm) : base(ptr, nelm) {}
        public arraywrapper_Vec4f(IntPtr ptr, int nelm, bool flag) : base(ptr, nelm, flag) {}
        ~arraywrapper_Vec4f() {
            if (_flag) { SprExport.Spr_array_delete_Vec4f(_this); _flag = false; }
        }
        public Vec4f this[int index] {
            get { return new Vec4f(SprExport.Spr_array_get_Vec4f(_this, index)); }
            set { SprExport.Spr_array_set_Vec4f(_this, index, value); }
        }
        public int size() { return (int) _nelm; }
        public static implicit operator List<Vec4f>(arraywrapper_Vec4f m) {
            List<Vec4f> r = new List<Vec4f>();
            for (int i = 0; i < (int) m._nelm; i++) {
                IntPtr member = SprExport.Spr_array_get_Vec4f(m._this, i);
                r.Add(new Vec4f(member));
            }
            return r;
        }
        public static implicit operator arraywrapper_Vec4f(List<Vec4f> r) {
            int size = r.Count;
            IntPtr ptr = SprExport.Spr_array_new_Vec4f(size);
            arraywrapper_Vec4f m = new arraywrapper_Vec4f(ptr, size, true);
            for (int i = 0; i < size; i++) {
                SprExport.Spr_array_set_Vec4f(m._this, i, r[i]);
            }
            return m;
        }
        public static implicit operator Vec4f[](arraywrapper_Vec4f m) {
            int size = (int) m._nelm;
            Vec4f[] r = new Vec4f[size];
            for (int i = 0; i < size; i++) {
                 IntPtr ptr = SprExport.Spr_array_get_Vec4f(m._this, i);
                 r[i] = new Vec4f(ptr);
            }
            return r;
        }
        public static implicit operator Vec4f(arraywrapper_Vec4f m) {
            int size = (int) m._nelm;
            IntPtr ptr = SprExport.Spr_array_get_Vec4f(m._this, 0);
            Vec4f r = new Vec4f(ptr);
            return r;
        }
        public static implicit operator arraywrapper_Vec4f(Vec4f[] r) {
            int size = r.Length;
            IntPtr ptr = SprExport.Spr_array_new_Vec4f(size);
            arraywrapper_Vec4f m = new arraywrapper_Vec4f(ptr, size, true);
            for (int i = 0; i < size; i++) {
                SprExport.Spr_array_set_Vec4f(m._this, i, r[i]);
            }
            return m;
        }
    }
    public class structwrapper_Affinef : wrapper {
        private IntPtr _ptr;
        public structwrapper_Affinef(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_Affinef(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_Affinef() {}
        ~structwrapper_Affinef() {}
        public Affinef this[int index] {
            get { return new Affinef(SprExport.Spr_GRFrameDesc_struct_get_Affinef(_ptr, index)); }
            set { SprExport.Spr_GRFrameDesc_struct_set_Affinef(_ptr, index, value); }
        }
    }
    public class structwrapper_CDShapeIf_p : wrapper {
        private IntPtr _ptr;
        public structwrapper_CDShapeIf_p(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_CDShapeIf_p(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_CDShapeIf_p() {}
        ~structwrapper_CDShapeIf_p() {}
        public CDShapeIf this[int index] {
            get { return new CDShapeIf(SprExport.Spr_PHRaycastHit_struct_get_CDShapeIf_p(_ptr, index)); }
            set { SprExport.Spr_PHRaycastHit_struct_set_CDShapeIf_p(_ptr, index, value); }
        }
    }
    public class structwrapper_GRVertexElement : wrapper {
        private IntPtr _ptr;
        public structwrapper_GRVertexElement(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_GRVertexElement(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_GRVertexElement() {}
        ~structwrapper_GRVertexElement() {}
        public GRVertexElement this[int index] {
            get { return new GRVertexElement(SprExport.Spr_GRVertexArray_struct_get_GRVertexElement(_ptr, index)); }
            set { SprExport.Spr_GRVertexArray_struct_set_GRVertexElement(_ptr, index, value); }
        }
    }
    public class structwrapper_Matrix3d : wrapper {
        private IntPtr _ptr;
        public structwrapper_Matrix3d(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_Matrix3d(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_Matrix3d() {}
        ~structwrapper_Matrix3d() {}
        public Matrix3d this[int index] {
            get { return new Matrix3d(SprExport.Spr_PHSolidDesc_struct_get_Matrix3d(_ptr, index)); }
            set { SprExport.Spr_PHSolidDesc_struct_set_Matrix3d(_ptr, index, value); }
        }
    }
    public class structwrapper_Matrix3f : wrapper {
        private IntPtr _ptr;
        public structwrapper_Matrix3f(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_Matrix3f(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_Matrix3f() {}
        ~structwrapper_Matrix3f() {}
        public Matrix3f this[int index] {
            get { return new Matrix3f(SprExport.Spr_PHOpParticleDesc_struct_get_Matrix3f(_ptr, index)); }
            set { SprExport.Spr_PHOpParticleDesc_struct_set_Matrix3f(_ptr, index, value); }
        }
    }
    public class structwrapper_PHHapticPointerDesc_HapticRenderMode : wrapper {
        private IntPtr _ptr;
        public structwrapper_PHHapticPointerDesc_HapticRenderMode(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_PHHapticPointerDesc_HapticRenderMode(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_PHHapticPointerDesc_HapticRenderMode() {}
        ~structwrapper_PHHapticPointerDesc_HapticRenderMode() {}
        public PHHapticPointerDesc.HapticRenderMode this[int index] {
            get { return (PHHapticPointerDesc.HapticRenderMode) SprExport.Spr_PHHapticPointerDesc_struct_get_PHHapticPointerDesc_HapticRenderMode(_ptr, index); }
            set { SprExport.Spr_PHHapticPointerDesc_struct_set_PHHapticPointerDesc_HapticRenderMode(_ptr, index, (int) value); }
        }
    }
    public class structwrapper_PHMaterial : wrapper {
        private IntPtr _ptr;
        public structwrapper_PHMaterial(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_PHMaterial(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_PHMaterial() {}
        ~structwrapper_PHMaterial() {}
        public PHMaterial this[int index] {
            get { return new PHMaterial(SprExport.Spr_CDShapeDesc_struct_get_PHMaterial(_ptr, index)); }
            set { SprExport.Spr_CDShapeDesc_struct_set_PHMaterial(_ptr, index, value); }
        }
    }
    public class structwrapper_PHOpHapticControllerDesc_HapticDOFType : wrapper {
        private IntPtr _ptr;
        public structwrapper_PHOpHapticControllerDesc_HapticDOFType(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_PHOpHapticControllerDesc_HapticDOFType(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_PHOpHapticControllerDesc_HapticDOFType() {}
        ~structwrapper_PHOpHapticControllerDesc_HapticDOFType() {}
        public PHOpHapticControllerDesc.HapticDOFType this[int index] {
            get { return (PHOpHapticControllerDesc.HapticDOFType) SprExport.Spr_PHOpHapticControllerDesc_struct_get_PHOpHapticControllerDesc_HapticDOFType(_ptr, index); }
            set { SprExport.Spr_PHOpHapticControllerDesc_struct_set_PHOpHapticControllerDesc_HapticDOFType(_ptr, index, (int) value); }
        }
    }
    public class structwrapper_PHSolidIf_p : wrapper {
        private IntPtr _ptr;
        public structwrapper_PHSolidIf_p(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_PHSolidIf_p(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_PHSolidIf_p() {}
        ~structwrapper_PHSolidIf_p() {}
        public PHSolidIf this[int index] {
            get { return new PHSolidIf(SprExport.Spr_PHRaycastHit_struct_get_PHSolidIf_p(_ptr, index)); }
            set { SprExport.Spr_PHRaycastHit_struct_set_PHSolidIf_p(_ptr, index, value); }
        }
    }
    public class structwrapper_Posed : wrapper {
        private IntPtr _ptr;
        public structwrapper_Posed(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_Posed(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_Posed() {}
        ~structwrapper_Posed() {}
        public Posed this[int index] {
            get { return new Posed(SprExport.Spr_PHFrameDesc_struct_get_Posed(_ptr, index)); }
            set { SprExport.Spr_PHFrameDesc_struct_set_Posed(_ptr, index, value); }
        }
    }
    public class structwrapper_Posef : wrapper {
        private IntPtr _ptr;
        public structwrapper_Posef(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_Posef(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_Posef() {}
        ~structwrapper_Posef() {}
        public Posef this[int index] {
            get { return new Posef(SprExport.Spr_PHOpHapticControllerDesc_struct_get_Posef(_ptr, index)); }
            set { SprExport.Spr_PHOpHapticControllerDesc_struct_set_Posef(_ptr, index, value); }
        }
    }
    public class structwrapper_Quaterniond : wrapper {
        private IntPtr _ptr;
        public structwrapper_Quaterniond(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_Quaterniond(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_Quaterniond() {}
        ~structwrapper_Quaterniond() {}
        public Quaterniond this[int index] {
            get { return new Quaterniond(SprExport.Spr_PHIKEndEffectorDesc_struct_get_Quaterniond(_ptr, index)); }
            set { SprExport.Spr_PHIKEndEffectorDesc_struct_set_Quaterniond(_ptr, index, value); }
        }
    }
    public class structwrapper_Quaternionf : wrapper {
        private IntPtr _ptr;
        public structwrapper_Quaternionf(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_Quaternionf(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_Quaternionf() {}
        ~structwrapper_Quaternionf() {}
        public Quaternionf this[int index] {
            get { return new Quaternionf(SprExport.Spr_PHOpParticleDesc_struct_get_Quaternionf(_ptr, index)); }
            set { SprExport.Spr_PHOpParticleDesc_struct_set_Quaternionf(_ptr, index, value); }
        }
    }
    public class structwrapper_Vec2d : wrapper {
        private IntPtr _ptr;
        public structwrapper_Vec2d(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_Vec2d(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_Vec2d() {}
        ~structwrapper_Vec2d() {}
        public Vec2d this[int index] {
            get { return new Vec2d(SprExport.Spr_PHPointToPlaneMateDesc_struct_get_Vec2d(_ptr, index)); }
            set { SprExport.Spr_PHPointToPlaneMateDesc_struct_set_Vec2d(_ptr, index, value); }
        }
    }
    public class structwrapper_Vec2f : wrapper {
        private IntPtr _ptr;
        public structwrapper_Vec2f(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_Vec2f(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_Vec2f() {}
        ~structwrapper_Vec2f() {}
        public Vec2f this[int index] {
            get { return new Vec2f(SprExport.Spr_HITrackballDesc_struct_get_Vec2f(_ptr, index)); }
            set { SprExport.Spr_HITrackballDesc_struct_set_Vec2f(_ptr, index, value); }
        }
    }
    public class structwrapper_Vec3d : wrapper {
        private IntPtr _ptr;
        public structwrapper_Vec3d(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_Vec3d(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_Vec3d() {}
        ~structwrapper_Vec3d() {}
        public Vec3d this[int index] {
            get { return new Vec3d(SprExport.Spr_PHFemPorousWOMoveDesc_struct_get_Vec3d(_ptr, index)); }
            set { SprExport.Spr_PHFemPorousWOMoveDesc_struct_set_Vec3d(_ptr, index, value); }
        }
    }
    public class structwrapper_Vec3f : wrapper {
        private IntPtr _ptr;
        public structwrapper_Vec3f(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_Vec3f(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_Vec3f() {}
        ~structwrapper_Vec3f() {}
        public Vec3f this[int index] {
            get { return new Vec3f(SprExport.Spr_PHOpHapticRendererDesc_struct_get_Vec3f(_ptr, index)); }
            set { SprExport.Spr_PHOpHapticRendererDesc_struct_set_Vec3f(_ptr, index, value); }
        }
    }
    public class structwrapper_Vec3f_p : wrapper {
        private IntPtr _ptr;
        public structwrapper_Vec3f_p(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_Vec3f_p(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_Vec3f_p() {}
        ~structwrapper_Vec3f_p() {}
        public Vec3f this[int index] {
            get { return new Vec3f(SprExport.Spr_PHOpObjDesc_struct_get_Vec3f_p(_ptr, index)); }
            set { SprExport.Spr_PHOpObjDesc_struct_set_Vec3f_p(_ptr, index, value); }
        }
    }
    public class structwrapper_Vec3i : wrapper {
        private IntPtr _ptr;
        public structwrapper_Vec3i(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_Vec3i(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_Vec3i() {}
        ~structwrapper_Vec3i() {}
        public Vec3i this[int index] {
            get { return new Vec3i(SprExport.Spr_FWUngroundedConstraint_struct_get_Vec3i(_ptr, index)); }
            set { SprExport.Spr_FWUngroundedConstraint_struct_set_Vec3i(_ptr, index, value); }
        }
    }
    public class structwrapper_Vec4d : wrapper {
        private IntPtr _ptr;
        public structwrapper_Vec4d(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_Vec4d(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_Vec4d() {}
        ~structwrapper_Vec4d() {}
        public Vec4d this[int index] {
            get { return new Vec4d(SprExport.Spr_PHHuman1DJointResistanceDesc_struct_get_Vec4d(_ptr, index)); }
            set { SprExport.Spr_PHHuman1DJointResistanceDesc_struct_set_Vec4d(_ptr, index, value); }
        }
    }
    public class structwrapper_Vec4f : wrapper {
        private IntPtr _ptr;
        public structwrapper_Vec4f(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_Vec4f(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_Vec4f() {}
        ~structwrapper_Vec4f() {}
        public Vec4f this[int index] {
            get { return new Vec4f(SprExport.Spr_GRLightDesc_struct_get_Vec4f(_ptr, index)); }
            set { SprExport.Spr_GRLightDesc_struct_set_Vec4f(_ptr, index, value); }
        }
    }
    public class structwrapper_Vec6d : wrapper {
        private IntPtr _ptr;
        public structwrapper_Vec6d(IntPtr ptr) { _ptr = ptr; }
        public structwrapper_Vec6d(IntPtr ptr, bool flag) { _ptr = ptr; _flag = flag; }
        protected structwrapper_Vec6d() {}
        ~structwrapper_Vec6d() {}
        public Vec6d this[int index] {
            get { return new Vec6d(SprExport.Spr_PHSpringDesc_struct_get_Vec6d(_ptr, index)); }
            set { SprExport.Spr_PHSpringDesc_struct_set_Vec6d(_ptr, index, value); }
        }
    }
    public class vectorwrapper_GRAnimationKey : vectorwrapper {
        public vectorwrapper_GRAnimationKey() {
            _this = SprExport.Spr_vector_new_GRAnimationKey();
            _flag = true;
        }
        public vectorwrapper_GRAnimationKey(IntPtr ptr) : base(ptr) {}
        public vectorwrapper_GRAnimationKey(IntPtr ptr, bool flag) : base(ptr, flag) {}
        ~vectorwrapper_GRAnimationKey() {
            if (_flag) { SprExport.Spr_vector_delete_GRAnimationKey(_this); _flag = false; }
        }
        public GRAnimationKey this[int index] {
            get { return new GRAnimationKey(SprExport.Spr_vector_get_GRAnimationKey(_this, index)); }
            set { SprExport.Spr_vector_set_GRAnimationKey(_this, index, value); }
        }
        public int size() { return (int) SprExport.Spr_vector_size_GRAnimationKey(_this); }
        public void push_back(GRAnimationKey value) { SprExport.Spr_vector_push_back_GRAnimationKey(_this, value); }
        public void clear() { SprExport.Spr_vector_clear_GRAnimationKey(_this); }
        public static implicit operator List<GRAnimationKey>(vectorwrapper_GRAnimationKey m) {
            List<GRAnimationKey> r = new List<GRAnimationKey>();
            int size = SprExport.Spr_vector_size_GRAnimationKey(m._this);
            for (int i = 0; i < size; i++) {
                IntPtr member = SprExport.Spr_vector_get_GRAnimationKey(m._this, i);
                r.Add(new GRAnimationKey(member));
            }
            return r;
        }
        public static implicit operator vectorwrapper_GRAnimationKey(List<GRAnimationKey> r) {
            IntPtr ptr = SprExport.Spr_vector_new_GRAnimationKey();
            vectorwrapper_GRAnimationKey m = new vectorwrapper_GRAnimationKey(ptr, true);
            for (int i = 0; i < (int) r.Count; i++) {
                SprExport.Spr_vector_push_back_GRAnimationKey(ptr, r[i]);
            }
            return m;
        }
        public static implicit operator GRAnimationKey[](vectorwrapper_GRAnimationKey m) {
            int size = SprExport.Spr_vector_size_GRAnimationKey(m._this);
            GRAnimationKey[] r = new GRAnimationKey[size];
            for (int i = 0; i < size; i++) {
                 IntPtr ptr = SprExport.Spr_vector_get_GRAnimationKey(m._this, i);
                 r[i] = new GRAnimationKey(ptr);
            }
            return r;
        }
        public static implicit operator vectorwrapper_GRAnimationKey(GRAnimationKey[] r) {
            IntPtr ptr = SprExport.Spr_vector_new_GRAnimationKey();
            vectorwrapper_GRAnimationKey m = new vectorwrapper_GRAnimationKey(ptr, true);
            for (int i = 0; i < r.Length; i++) {
                SprExport.Spr_vector_push_back_GRAnimationKey(m._this, r[i]);
            }
            return m;
        }
    }
    public class vectorwrapper_GRKey : vectorwrapper {
        public vectorwrapper_GRKey() {
            _this = SprExport.Spr_vector_new_GRKey();
            _flag = true;
        }
        public vectorwrapper_GRKey(IntPtr ptr) : base(ptr) {}
        public vectorwrapper_GRKey(IntPtr ptr, bool flag) : base(ptr, flag) {}
        ~vectorwrapper_GRKey() {
            if (_flag) { SprExport.Spr_vector_delete_GRKey(_this); _flag = false; }
        }
        public GRKey this[int index] {
            get { return new GRKey(SprExport.Spr_vector_get_GRKey(_this, index)); }
            set { SprExport.Spr_vector_set_GRKey(_this, index, value); }
        }
        public int size() { return (int) SprExport.Spr_vector_size_GRKey(_this); }
        public void push_back(GRKey value) { SprExport.Spr_vector_push_back_GRKey(_this, value); }
        public void clear() { SprExport.Spr_vector_clear_GRKey(_this); }
        public static implicit operator List<GRKey>(vectorwrapper_GRKey m) {
            List<GRKey> r = new List<GRKey>();
            int size = SprExport.Spr_vector_size_GRKey(m._this);
            for (int i = 0; i < size; i++) {
                IntPtr member = SprExport.Spr_vector_get_GRKey(m._this, i);
                r.Add(new GRKey(member));
            }
            return r;
        }
        public static implicit operator vectorwrapper_GRKey(List<GRKey> r) {
            IntPtr ptr = SprExport.Spr_vector_new_GRKey();
            vectorwrapper_GRKey m = new vectorwrapper_GRKey(ptr, true);
            for (int i = 0; i < (int) r.Count; i++) {
                SprExport.Spr_vector_push_back_GRKey(ptr, r[i]);
            }
            return m;
        }
        public static implicit operator GRKey[](vectorwrapper_GRKey m) {
            int size = SprExport.Spr_vector_size_GRKey(m._this);
            GRKey[] r = new GRKey[size];
            for (int i = 0; i < size; i++) {
                 IntPtr ptr = SprExport.Spr_vector_get_GRKey(m._this, i);
                 r[i] = new GRKey(ptr);
            }
            return r;
        }
        public static implicit operator vectorwrapper_GRKey(GRKey[] r) {
            IntPtr ptr = SprExport.Spr_vector_new_GRKey();
            vectorwrapper_GRKey m = new vectorwrapper_GRKey(ptr, true);
            for (int i = 0; i < r.Length; i++) {
                SprExport.Spr_vector_push_back_GRKey(m._this, r[i]);
            }
            return m;
        }
    }
    public class vectorwrapper_GRMeshFace : vectorwrapper {
        public vectorwrapper_GRMeshFace() {
            _this = SprExport.Spr_vector_new_GRMeshFace();
            _flag = true;
        }
        public vectorwrapper_GRMeshFace(IntPtr ptr) : base(ptr) {}
        public vectorwrapper_GRMeshFace(IntPtr ptr, bool flag) : base(ptr, flag) {}
        ~vectorwrapper_GRMeshFace() {
            if (_flag) { SprExport.Spr_vector_delete_GRMeshFace(_this); _flag = false; }
        }
        public GRMeshFace this[int index] {
            get { return new GRMeshFace(SprExport.Spr_vector_get_GRMeshFace(_this, index)); }
            set { SprExport.Spr_vector_set_GRMeshFace(_this, index, value); }
        }
        public int size() { return (int) SprExport.Spr_vector_size_GRMeshFace(_this); }
        public void push_back(GRMeshFace value) { SprExport.Spr_vector_push_back_GRMeshFace(_this, value); }
        public void clear() { SprExport.Spr_vector_clear_GRMeshFace(_this); }
        public static implicit operator List<GRMeshFace>(vectorwrapper_GRMeshFace m) {
            List<GRMeshFace> r = new List<GRMeshFace>();
            int size = SprExport.Spr_vector_size_GRMeshFace(m._this);
            for (int i = 0; i < size; i++) {
                IntPtr member = SprExport.Spr_vector_get_GRMeshFace(m._this, i);
                r.Add(new GRMeshFace(member));
            }
            return r;
        }
        public static implicit operator vectorwrapper_GRMeshFace(List<GRMeshFace> r) {
            IntPtr ptr = SprExport.Spr_vector_new_GRMeshFace();
            vectorwrapper_GRMeshFace m = new vectorwrapper_GRMeshFace(ptr, true);
            for (int i = 0; i < (int) r.Count; i++) {
                SprExport.Spr_vector_push_back_GRMeshFace(ptr, r[i]);
            }
            return m;
        }
        public static implicit operator GRMeshFace[](vectorwrapper_GRMeshFace m) {
            int size = SprExport.Spr_vector_size_GRMeshFace(m._this);
            GRMeshFace[] r = new GRMeshFace[size];
            for (int i = 0; i < size; i++) {
                 IntPtr ptr = SprExport.Spr_vector_get_GRMeshFace(m._this, i);
                 r[i] = new GRMeshFace(ptr);
            }
            return r;
        }
        public static implicit operator vectorwrapper_GRMeshFace(GRMeshFace[] r) {
            IntPtr ptr = SprExport.Spr_vector_new_GRMeshFace();
            vectorwrapper_GRMeshFace m = new vectorwrapper_GRMeshFace(ptr, true);
            for (int i = 0; i < r.Length; i++) {
                SprExport.Spr_vector_push_back_GRMeshFace(m._this, r[i]);
            }
            return m;
        }
    }
    public class vectorwrapper_HISpidarMotorDesc : vectorwrapper {
        public vectorwrapper_HISpidarMotorDesc() {
            _this = SprExport.Spr_vector_new_HISpidarMotorDesc();
            _flag = true;
        }
        public vectorwrapper_HISpidarMotorDesc(IntPtr ptr) : base(ptr) {}
        public vectorwrapper_HISpidarMotorDesc(IntPtr ptr, bool flag) : base(ptr, flag) {}
        ~vectorwrapper_HISpidarMotorDesc() {
            if (_flag) { SprExport.Spr_vector_delete_HISpidarMotorDesc(_this); _flag = false; }
        }
        public HISpidarMotorDesc this[int index] {
            get { return new HISpidarMotorDesc(SprExport.Spr_vector_get_HISpidarMotorDesc(_this, index)); }
            set { SprExport.Spr_vector_set_HISpidarMotorDesc(_this, index, value); }
        }
        public int size() { return (int) SprExport.Spr_vector_size_HISpidarMotorDesc(_this); }
        public void push_back(HISpidarMotorDesc value) { SprExport.Spr_vector_push_back_HISpidarMotorDesc(_this, value); }
        public void clear() { SprExport.Spr_vector_clear_HISpidarMotorDesc(_this); }
        public static implicit operator List<HISpidarMotorDesc>(vectorwrapper_HISpidarMotorDesc m) {
            List<HISpidarMotorDesc> r = new List<HISpidarMotorDesc>();
            int size = SprExport.Spr_vector_size_HISpidarMotorDesc(m._this);
            for (int i = 0; i < size; i++) {
                IntPtr member = SprExport.Spr_vector_get_HISpidarMotorDesc(m._this, i);
                r.Add(new HISpidarMotorDesc(member));
            }
            return r;
        }
        public static implicit operator vectorwrapper_HISpidarMotorDesc(List<HISpidarMotorDesc> r) {
            IntPtr ptr = SprExport.Spr_vector_new_HISpidarMotorDesc();
            vectorwrapper_HISpidarMotorDesc m = new vectorwrapper_HISpidarMotorDesc(ptr, true);
            for (int i = 0; i < (int) r.Count; i++) {
                SprExport.Spr_vector_push_back_HISpidarMotorDesc(ptr, r[i]);
            }
            return m;
        }
        public static implicit operator HISpidarMotorDesc[](vectorwrapper_HISpidarMotorDesc m) {
            int size = SprExport.Spr_vector_size_HISpidarMotorDesc(m._this);
            HISpidarMotorDesc[] r = new HISpidarMotorDesc[size];
            for (int i = 0; i < size; i++) {
                 IntPtr ptr = SprExport.Spr_vector_get_HISpidarMotorDesc(m._this, i);
                 r[i] = new HISpidarMotorDesc(ptr);
            }
            return r;
        }
        public static implicit operator vectorwrapper_HISpidarMotorDesc(HISpidarMotorDesc[] r) {
            IntPtr ptr = SprExport.Spr_vector_new_HISpidarMotorDesc();
            vectorwrapper_HISpidarMotorDesc m = new vectorwrapper_HISpidarMotorDesc(ptr, true);
            for (int i = 0; i < r.Length; i++) {
                SprExport.Spr_vector_push_back_HISpidarMotorDesc(m._this, r[i]);
            }
            return m;
        }
    }
    public class vectorwrapper_PHPathPoint : vectorwrapper {
        public vectorwrapper_PHPathPoint() {
            _this = SprExport.Spr_vector_new_PHPathPoint();
            _flag = true;
        }
        public vectorwrapper_PHPathPoint(IntPtr ptr) : base(ptr) {}
        public vectorwrapper_PHPathPoint(IntPtr ptr, bool flag) : base(ptr, flag) {}
        ~vectorwrapper_PHPathPoint() {
            if (_flag) { SprExport.Spr_vector_delete_PHPathPoint(_this); _flag = false; }
        }
        public PHPathPoint this[int index] {
            get { return new PHPathPoint(SprExport.Spr_vector_get_PHPathPoint(_this, index)); }
            set { SprExport.Spr_vector_set_PHPathPoint(_this, index, value); }
        }
        public int size() { return (int) SprExport.Spr_vector_size_PHPathPoint(_this); }
        public void push_back(PHPathPoint value) { SprExport.Spr_vector_push_back_PHPathPoint(_this, value); }
        public void clear() { SprExport.Spr_vector_clear_PHPathPoint(_this); }
        public static implicit operator List<PHPathPoint>(vectorwrapper_PHPathPoint m) {
            List<PHPathPoint> r = new List<PHPathPoint>();
            int size = SprExport.Spr_vector_size_PHPathPoint(m._this);
            for (int i = 0; i < size; i++) {
                IntPtr member = SprExport.Spr_vector_get_PHPathPoint(m._this, i);
                r.Add(new PHPathPoint(member));
            }
            return r;
        }
        public static implicit operator vectorwrapper_PHPathPoint(List<PHPathPoint> r) {
            IntPtr ptr = SprExport.Spr_vector_new_PHPathPoint();
            vectorwrapper_PHPathPoint m = new vectorwrapper_PHPathPoint(ptr, true);
            for (int i = 0; i < (int) r.Count; i++) {
                SprExport.Spr_vector_push_back_PHPathPoint(ptr, r[i]);
            }
            return m;
        }
        public static implicit operator PHPathPoint[](vectorwrapper_PHPathPoint m) {
            int size = SprExport.Spr_vector_size_PHPathPoint(m._this);
            PHPathPoint[] r = new PHPathPoint[size];
            for (int i = 0; i < size; i++) {
                 IntPtr ptr = SprExport.Spr_vector_get_PHPathPoint(m._this, i);
                 r[i] = new PHPathPoint(ptr);
            }
            return r;
        }
        public static implicit operator vectorwrapper_PHPathPoint(PHPathPoint[] r) {
            IntPtr ptr = SprExport.Spr_vector_new_PHPathPoint();
            vectorwrapper_PHPathPoint m = new vectorwrapper_PHPathPoint(ptr, true);
            for (int i = 0; i < r.Length; i++) {
                SprExport.Spr_vector_push_back_PHPathPoint(m._this, r[i]);
            }
            return m;
        }
    }
    public class vectorwrapper_PHSplineLimitNode : vectorwrapper {
        public vectorwrapper_PHSplineLimitNode() {
            _this = SprExport.Spr_vector_new_PHSplineLimitNode();
            _flag = true;
        }
        public vectorwrapper_PHSplineLimitNode(IntPtr ptr) : base(ptr) {}
        public vectorwrapper_PHSplineLimitNode(IntPtr ptr, bool flag) : base(ptr, flag) {}
        ~vectorwrapper_PHSplineLimitNode() {
            if (_flag) { SprExport.Spr_vector_delete_PHSplineLimitNode(_this); _flag = false; }
        }
        public PHSplineLimitNode this[int index] {
            get { return new PHSplineLimitNode(SprExport.Spr_vector_get_PHSplineLimitNode(_this, index)); }
            set { SprExport.Spr_vector_set_PHSplineLimitNode(_this, index, value); }
        }
        public int size() { return (int) SprExport.Spr_vector_size_PHSplineLimitNode(_this); }
        public void push_back(PHSplineLimitNode value) { SprExport.Spr_vector_push_back_PHSplineLimitNode(_this, value); }
        public void clear() { SprExport.Spr_vector_clear_PHSplineLimitNode(_this); }
        public static implicit operator List<PHSplineLimitNode>(vectorwrapper_PHSplineLimitNode m) {
            List<PHSplineLimitNode> r = new List<PHSplineLimitNode>();
            int size = SprExport.Spr_vector_size_PHSplineLimitNode(m._this);
            for (int i = 0; i < size; i++) {
                IntPtr member = SprExport.Spr_vector_get_PHSplineLimitNode(m._this, i);
                r.Add(new PHSplineLimitNode(member));
            }
            return r;
        }
        public static implicit operator vectorwrapper_PHSplineLimitNode(List<PHSplineLimitNode> r) {
            IntPtr ptr = SprExport.Spr_vector_new_PHSplineLimitNode();
            vectorwrapper_PHSplineLimitNode m = new vectorwrapper_PHSplineLimitNode(ptr, true);
            for (int i = 0; i < (int) r.Count; i++) {
                SprExport.Spr_vector_push_back_PHSplineLimitNode(ptr, r[i]);
            }
            return m;
        }
        public static implicit operator PHSplineLimitNode[](vectorwrapper_PHSplineLimitNode m) {
            int size = SprExport.Spr_vector_size_PHSplineLimitNode(m._this);
            PHSplineLimitNode[] r = new PHSplineLimitNode[size];
            for (int i = 0; i < size; i++) {
                 IntPtr ptr = SprExport.Spr_vector_get_PHSplineLimitNode(m._this, i);
                 r[i] = new PHSplineLimitNode(ptr);
            }
            return r;
        }
        public static implicit operator vectorwrapper_PHSplineLimitNode(PHSplineLimitNode[] r) {
            IntPtr ptr = SprExport.Spr_vector_new_PHSplineLimitNode();
            vectorwrapper_PHSplineLimitNode m = new vectorwrapper_PHSplineLimitNode(ptr, true);
            for (int i = 0; i < r.Length; i++) {
                SprExport.Spr_vector_push_back_PHSplineLimitNode(m._this, r[i]);
            }
            return m;
        }
    }
    public class vectorwrapper_Vec2f : vectorwrapper {
        public vectorwrapper_Vec2f() {
            _this = SprExport.Spr_vector_new_Vec2f();
            _flag = true;
        }
        public vectorwrapper_Vec2f(IntPtr ptr) : base(ptr) {}
        public vectorwrapper_Vec2f(IntPtr ptr, bool flag) : base(ptr, flag) {}
        ~vectorwrapper_Vec2f() {
            if (_flag) { SprExport.Spr_vector_delete_Vec2f(_this); _flag = false; }
        }
        public Vec2f this[int index] {
            get { return new Vec2f(SprExport.Spr_vector_get_Vec2f(_this, index)); }
            set { SprExport.Spr_vector_set_Vec2f(_this, index, value); }
        }
        public int size() { return (int) SprExport.Spr_vector_size_Vec2f(_this); }
        public void push_back(Vec2f value) { SprExport.Spr_vector_push_back_Vec2f(_this, value); }
        public void clear() { SprExport.Spr_vector_clear_Vec2f(_this); }
        public static implicit operator List<Vec2f>(vectorwrapper_Vec2f m) {
            List<Vec2f> r = new List<Vec2f>();
            int size = SprExport.Spr_vector_size_Vec2f(m._this);
            for (int i = 0; i < size; i++) {
                IntPtr member = SprExport.Spr_vector_get_Vec2f(m._this, i);
                r.Add(new Vec2f(member));
            }
            return r;
        }
        public static implicit operator vectorwrapper_Vec2f(List<Vec2f> r) {
            IntPtr ptr = SprExport.Spr_vector_new_Vec2f();
            vectorwrapper_Vec2f m = new vectorwrapper_Vec2f(ptr, true);
            for (int i = 0; i < (int) r.Count; i++) {
                SprExport.Spr_vector_push_back_Vec2f(ptr, r[i]);
            }
            return m;
        }
        public static implicit operator Vec2f[](vectorwrapper_Vec2f m) {
            int size = SprExport.Spr_vector_size_Vec2f(m._this);
            Vec2f[] r = new Vec2f[size];
            for (int i = 0; i < size; i++) {
                 IntPtr ptr = SprExport.Spr_vector_get_Vec2f(m._this, i);
                 r[i] = new Vec2f(ptr);
            }
            return r;
        }
        public static implicit operator vectorwrapper_Vec2f(Vec2f[] r) {
            IntPtr ptr = SprExport.Spr_vector_new_Vec2f();
            vectorwrapper_Vec2f m = new vectorwrapper_Vec2f(ptr, true);
            for (int i = 0; i < r.Length; i++) {
                SprExport.Spr_vector_push_back_Vec2f(m._this, r[i]);
            }
            return m;
        }
    }
    public class vectorwrapper_Vec3d : vectorwrapper {
        public vectorwrapper_Vec3d() {
            _this = SprExport.Spr_vector_new_Vec3d();
            _flag = true;
        }
        public vectorwrapper_Vec3d(IntPtr ptr) : base(ptr) {}
        public vectorwrapper_Vec3d(IntPtr ptr, bool flag) : base(ptr, flag) {}
        ~vectorwrapper_Vec3d() {
            if (_flag) { SprExport.Spr_vector_delete_Vec3d(_this); _flag = false; }
        }
        public Vec3d this[int index] {
            get { return new Vec3d(SprExport.Spr_vector_get_Vec3d(_this, index)); }
            set { SprExport.Spr_vector_set_Vec3d(_this, index, value); }
        }
        public int size() { return (int) SprExport.Spr_vector_size_Vec3d(_this); }
        public void push_back(Vec3d value) { SprExport.Spr_vector_push_back_Vec3d(_this, value); }
        public void clear() { SprExport.Spr_vector_clear_Vec3d(_this); }
        public static implicit operator List<Vec3d>(vectorwrapper_Vec3d m) {
            List<Vec3d> r = new List<Vec3d>();
            int size = SprExport.Spr_vector_size_Vec3d(m._this);
            for (int i = 0; i < size; i++) {
                IntPtr member = SprExport.Spr_vector_get_Vec3d(m._this, i);
                r.Add(new Vec3d(member));
            }
            return r;
        }
        public static implicit operator vectorwrapper_Vec3d(List<Vec3d> r) {
            IntPtr ptr = SprExport.Spr_vector_new_Vec3d();
            vectorwrapper_Vec3d m = new vectorwrapper_Vec3d(ptr, true);
            for (int i = 0; i < (int) r.Count; i++) {
                SprExport.Spr_vector_push_back_Vec3d(ptr, r[i]);
            }
            return m;
        }
        public static implicit operator Vec3d[](vectorwrapper_Vec3d m) {
            int size = SprExport.Spr_vector_size_Vec3d(m._this);
            Vec3d[] r = new Vec3d[size];
            for (int i = 0; i < size; i++) {
                 IntPtr ptr = SprExport.Spr_vector_get_Vec3d(m._this, i);
                 r[i] = new Vec3d(ptr);
            }
            return r;
        }
        public static implicit operator vectorwrapper_Vec3d(Vec3d[] r) {
            IntPtr ptr = SprExport.Spr_vector_new_Vec3d();
            vectorwrapper_Vec3d m = new vectorwrapper_Vec3d(ptr, true);
            for (int i = 0; i < r.Length; i++) {
                SprExport.Spr_vector_push_back_Vec3d(m._this, r[i]);
            }
            return m;
        }
    }
    public class vectorwrapper_Vec3f : vectorwrapper {
        public vectorwrapper_Vec3f() {
            _this = SprExport.Spr_vector_new_Vec3f();
            _flag = true;
        }
        public vectorwrapper_Vec3f(IntPtr ptr) : base(ptr) {}
        public vectorwrapper_Vec3f(IntPtr ptr, bool flag) : base(ptr, flag) {}
        ~vectorwrapper_Vec3f() {
            if (_flag) { SprExport.Spr_vector_delete_Vec3f(_this); _flag = false; }
        }
        public Vec3f this[int index] {
            get { return new Vec3f(SprExport.Spr_vector_get_Vec3f(_this, index)); }
            set { SprExport.Spr_vector_set_Vec3f(_this, index, value); }
        }
        public int size() { return (int) SprExport.Spr_vector_size_Vec3f(_this); }
        public void push_back(Vec3f value) { SprExport.Spr_vector_push_back_Vec3f(_this, value); }
        public void clear() { SprExport.Spr_vector_clear_Vec3f(_this); }
        public static implicit operator List<Vec3f>(vectorwrapper_Vec3f m) {
            List<Vec3f> r = new List<Vec3f>();
            int size = SprExport.Spr_vector_size_Vec3f(m._this);
            for (int i = 0; i < size; i++) {
                IntPtr member = SprExport.Spr_vector_get_Vec3f(m._this, i);
                r.Add(new Vec3f(member));
            }
            return r;
        }
        public static implicit operator vectorwrapper_Vec3f(List<Vec3f> r) {
            IntPtr ptr = SprExport.Spr_vector_new_Vec3f();
            vectorwrapper_Vec3f m = new vectorwrapper_Vec3f(ptr, true);
            for (int i = 0; i < (int) r.Count; i++) {
                SprExport.Spr_vector_push_back_Vec3f(ptr, r[i]);
            }
            return m;
        }
        public static implicit operator Vec3f[](vectorwrapper_Vec3f m) {
            int size = SprExport.Spr_vector_size_Vec3f(m._this);
            Vec3f[] r = new Vec3f[size];
            for (int i = 0; i < size; i++) {
                 IntPtr ptr = SprExport.Spr_vector_get_Vec3f(m._this, i);
                 r[i] = new Vec3f(ptr);
            }
            return r;
        }
        public static implicit operator vectorwrapper_Vec3f(Vec3f[] r) {
            IntPtr ptr = SprExport.Spr_vector_new_Vec3f();
            vectorwrapper_Vec3f m = new vectorwrapper_Vec3f(ptr, true);
            for (int i = 0; i < r.Length; i++) {
                SprExport.Spr_vector_push_back_Vec3f(m._this, r[i]);
            }
            return m;
        }
    }
    public class vectorwrapper_Vec4f : vectorwrapper {
        public vectorwrapper_Vec4f() {
            _this = SprExport.Spr_vector_new_Vec4f();
            _flag = true;
        }
        public vectorwrapper_Vec4f(IntPtr ptr) : base(ptr) {}
        public vectorwrapper_Vec4f(IntPtr ptr, bool flag) : base(ptr, flag) {}
        ~vectorwrapper_Vec4f() {
            if (_flag) { SprExport.Spr_vector_delete_Vec4f(_this); _flag = false; }
        }
        public Vec4f this[int index] {
            get { return new Vec4f(SprExport.Spr_vector_get_Vec4f(_this, index)); }
            set { SprExport.Spr_vector_set_Vec4f(_this, index, value); }
        }
        public int size() { return (int) SprExport.Spr_vector_size_Vec4f(_this); }
        public void push_back(Vec4f value) { SprExport.Spr_vector_push_back_Vec4f(_this, value); }
        public void clear() { SprExport.Spr_vector_clear_Vec4f(_this); }
        public static implicit operator List<Vec4f>(vectorwrapper_Vec4f m) {
            List<Vec4f> r = new List<Vec4f>();
            int size = SprExport.Spr_vector_size_Vec4f(m._this);
            for (int i = 0; i < size; i++) {
                IntPtr member = SprExport.Spr_vector_get_Vec4f(m._this, i);
                r.Add(new Vec4f(member));
            }
            return r;
        }
        public static implicit operator vectorwrapper_Vec4f(List<Vec4f> r) {
            IntPtr ptr = SprExport.Spr_vector_new_Vec4f();
            vectorwrapper_Vec4f m = new vectorwrapper_Vec4f(ptr, true);
            for (int i = 0; i < (int) r.Count; i++) {
                SprExport.Spr_vector_push_back_Vec4f(ptr, r[i]);
            }
            return m;
        }
        public static implicit operator Vec4f[](vectorwrapper_Vec4f m) {
            int size = SprExport.Spr_vector_size_Vec4f(m._this);
            Vec4f[] r = new Vec4f[size];
            for (int i = 0; i < size; i++) {
                 IntPtr ptr = SprExport.Spr_vector_get_Vec4f(m._this, i);
                 r[i] = new Vec4f(ptr);
            }
            return r;
        }
        public static implicit operator vectorwrapper_Vec4f(Vec4f[] r) {
            IntPtr ptr = SprExport.Spr_vector_new_Vec4f();
            vectorwrapper_Vec4f m = new vectorwrapper_Vec4f(ptr, true);
            for (int i = 0; i < r.Length; i++) {
                SprExport.Spr_vector_push_back_Vec4f(m._this, r[i]);
            }
            return m;
        }
    }
} 
