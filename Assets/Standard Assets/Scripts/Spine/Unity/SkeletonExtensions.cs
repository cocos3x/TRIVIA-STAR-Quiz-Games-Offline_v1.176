using UnityEngine;

namespace Spine.Unity
{
    public static class SkeletonExtensions
    {
        // Fields
        private const float ByteToFloat = 0.003921569;
        
        // Methods
        public static UnityEngine.Color GetColor(Spine.Skeleton s)
        {
            float val_2;
            float val_3;
            float val_4;
            if(R1 != 0)
            {
                    val_2 = mem[R1 + 48];
                val_2 = R1 + 48;
                val_3 = mem[R1 + 52];
                val_3 = R1 + 52;
                val_4 = mem[R1 + 56];
                val_4 = R1 + 56;
            }
            else
            {
                    val_2 = 2.571435E-39f;
                val_3 = 8.407791E-45f;
                val_4 = 7.286752E-44f;
            }
            
            s = new UnityEngine.Color(r:  R1 + 60, g:  null, b:  null, a:  null);
            return new UnityEngine.Color() {r = R1 + 60};
        }
        public static UnityEngine.Color GetColor(Spine.RegionAttachment a)
        {
            float val_2;
            float val_3;
            float val_4;
            if(R1 != 0)
            {
                    val_2 = mem[R1 + 72];
                val_2 = R1 + 72;
                val_3 = mem[R1 + 76];
                val_3 = R1 + 76;
                val_4 = mem[R1 + 80];
                val_4 = R1 + 80;
            }
            else
            {
                    val_2 = 3.587324E-43f;
                val_3 = 5.605194E-45f;
                val_4 = 5.605194E-45f;
            }
            
            a = new UnityEngine.Color(r:  R1 + 84, g:  null, b:  null, a:  null);
            return new UnityEngine.Color() {r = R1 + 84};
        }
        public static UnityEngine.Color GetColor(Spine.MeshAttachment a)
        {
            float val_2;
            float val_3;
            float val_4;
            if(R1 != 0)
            {
                    val_2 = mem[R1 + 68];
                val_2 = R1 + 68;
                val_3 = mem[R1 + 72];
                val_3 = R1 + 72;
                val_4 = mem[R1 + 76];
                val_4 = R1 + 76;
            }
            else
            {
                    val_2 = 3.587324E-43f;
                val_3 = 3.587324E-43f;
                val_4 = 5.605194E-45f;
            }
            
            a = new UnityEngine.Color(r:  R1 + 80, g:  null, b:  null, a:  null);
            return new UnityEngine.Color() {r = R1 + 80};
        }
        public static void SetColor(Spine.Skeleton skeleton, UnityEngine.Color color)
        {
            if(skeleton != 0)
            {
                    skeleton.a = color.a;
                skeleton.r = color.r;
                skeleton.g = color.g;
            }
            else
            {
                    mem[60] = color.a;
                mem[48] = color.r;
                mem[52] = color.g;
            }
            
            skeleton.b = color.b;
        }
        public static void SetColor(Spine.Skeleton skeleton, UnityEngine.Color32 color)
        {
            byte val_1 = color.r >> 24;
            if(skeleton != 0)
            {
                    float val_5 = (float)val_1;
                float val_6 = (float)(int)color.r & 255;
                float val_7 = (float)(uint)(color.r >> 8) & 255;
                val_5 = val_5 * 0.003921569f;
                val_6 = val_6 * 0.003921569f;
                val_7 = val_7 * 0.003921569f;
                skeleton.a = val_5;
                skeleton.r = val_6;
                skeleton.g = val_7;
            }
            else
            {
                    mem[60] = (float)val_1 * 0.003921569f;
                mem[48] = ((float)(int)color.r & 255) * 0.003921569f;
                mem[52] = ((float)(uint)(color.r >> 8) & 255) * 0.003921569f;
            }
            
            float val_8 = (float)(uint)(color.r >> 16) & 255;
            val_8 = val_8 * 0.003921569f;
            skeleton.b = val_8;
        }
        public static void SetColor(Spine.Slot slot, UnityEngine.Color color)
        {
            if(slot != 0)
            {
                    slot.a = color.a;
                slot.r = color.r;
                slot.g = color.g;
            }
            else
            {
                    mem[28] = color.a;
                mem[16] = color.r;
                mem[20] = color.g;
            }
            
            slot.b = color.b;
        }
        public static void SetColor(Spine.Slot slot, UnityEngine.Color32 color)
        {
            byte val_1 = color.r >> 24;
            if(slot != 0)
            {
                    float val_5 = (float)val_1;
                float val_6 = (float)(int)color.r & 255;
                float val_7 = (float)(uint)(color.r >> 8) & 255;
                val_5 = val_5 * 0.003921569f;
                val_6 = val_6 * 0.003921569f;
                val_7 = val_7 * 0.003921569f;
                slot.a = val_5;
                slot.r = val_6;
                slot.g = val_7;
            }
            else
            {
                    mem[28] = (float)val_1 * 0.003921569f;
                mem[16] = ((float)(int)color.r & 255) * 0.003921569f;
                mem[20] = ((float)(uint)(color.r >> 8) & 255) * 0.003921569f;
            }
            
            float val_8 = (float)(uint)(color.r >> 16) & 255;
            val_8 = val_8 * 0.003921569f;
            slot.b = val_8;
        }
        public static void SetColor(Spine.RegionAttachment attachment, UnityEngine.Color color)
        {
            if(attachment != 0)
            {
                    attachment.a = color.a;
                attachment.r = color.r;
                attachment.g = color.g;
            }
            else
            {
                    mem[84] = color.a;
                mem[72] = color.r;
                mem[76] = color.g;
            }
            
            attachment.b = color.b;
        }
        public static void SetColor(Spine.RegionAttachment attachment, UnityEngine.Color32 color)
        {
            byte val_1 = color.r >> 24;
            if(attachment != 0)
            {
                    float val_5 = (float)val_1;
                float val_6 = (float)(int)color.r & 255;
                float val_7 = (float)(uint)(color.r >> 8) & 255;
                val_5 = val_5 * 0.003921569f;
                val_6 = val_6 * 0.003921569f;
                val_7 = val_7 * 0.003921569f;
                attachment.a = val_5;
                attachment.r = val_6;
                attachment.g = val_7;
            }
            else
            {
                    mem[84] = (float)val_1 * 0.003921569f;
                mem[72] = ((float)(int)color.r & 255) * 0.003921569f;
                mem[76] = ((float)(uint)(color.r >> 8) & 255) * 0.003921569f;
            }
            
            float val_8 = (float)(uint)(color.r >> 16) & 255;
            val_8 = val_8 * 0.003921569f;
            attachment.b = val_8;
        }
        public static void SetColor(Spine.MeshAttachment attachment, UnityEngine.Color color)
        {
            if(attachment != 0)
            {
                    attachment.a = color.a;
                attachment.r = color.r;
                attachment.g = color.g;
            }
            else
            {
                    mem[80] = color.a;
                mem[68] = color.r;
                mem[72] = color.g;
            }
            
            attachment.b = color.b;
        }
        public static void SetColor(Spine.MeshAttachment attachment, UnityEngine.Color32 color)
        {
            byte val_1 = color.r >> 24;
            if(attachment != 0)
            {
                    float val_5 = (float)val_1;
                float val_6 = (float)(int)color.r & 255;
                float val_7 = (float)(uint)(color.r >> 8) & 255;
                val_5 = val_5 * 0.003921569f;
                val_6 = val_6 * 0.003921569f;
                val_7 = val_7 * 0.003921569f;
                attachment.a = val_5;
                attachment.r = val_6;
                attachment.g = val_7;
            }
            else
            {
                    mem[80] = (float)val_1 * 0.003921569f;
                mem[68] = ((float)(int)color.r & 255) * 0.003921569f;
                mem[72] = ((float)(uint)(color.r >> 8) & 255) * 0.003921569f;
            }
            
            float val_8 = (float)(uint)(color.r >> 16) & 255;
            val_8 = val_8 * 0.003921569f;
            attachment.b = val_8;
        }
        public static void SetPosition(Spine.Bone bone, UnityEngine.Vector2 position)
        {
            if(bone != 0)
            {
                    bone.x = position.x;
            }
            else
            {
                    mem[24] = position.x;
            }
            
            bone.y = position.y;
        }
        public static void SetPosition(Spine.Bone bone, UnityEngine.Vector3 position)
        {
            if(bone != 0)
            {
                    bone.x = position.x;
            }
            else
            {
                    mem[24] = position.x;
            }
            
            bone.y = position.y;
        }
        public static UnityEngine.Vector2 GetLocalPosition(Spine.Bone bone)
        {
            float val_2;
            if(R1 != 0)
            {
                    val_2 = mem[R1 + 24];
                val_2 = R1 + 24;
            }
            else
            {
                    val_2 = 0f;
            }
            
            mem2[0] = 0;
            mem2[0] = 0;
            bone = new UnityEngine.Vector2(x:  null, y:  null);
            return new UnityEngine.Vector2();
        }
        public static UnityEngine.Vector2 GetSkeletonSpacePosition(Spine.Bone bone)
        {
            float val_2;
            if(R1 != 0)
            {
                    val_2 = mem[R1 + 92];
                val_2 = R1 + 92;
            }
            else
            {
                    val_2 = 0f;
            }
            
            mem2[0] = 0;
            mem2[0] = 0;
            bone = new UnityEngine.Vector2(x:  null, y:  null);
            return new UnityEngine.Vector2();
        }
        public static UnityEngine.Vector2 GetSkeletonSpacePosition(Spine.Bone bone, UnityEngine.Vector2 boneLocal)
        {
            boneLocal.x.LocalToWorld(localX:  null, localY:  null, worldX: out  boneLocal.y, worldY: out  R3);
            return new UnityEngine.Vector2();
        }
        public static UnityEngine.Vector3 GetWorldPosition(Spine.Bone bone, UnityEngine.Transform spineGameObjectTransform)
        {
            float val_3;
            if(spineGameObjectTransform != 0)
            {
                
            }
            else
            {
                    val_3 = 0f;
            }
            
            UnityEngine.Vector3 val_1 = new UnityEngine.Vector3(x:  null, y:  null);
            UnityEngine.Vector3 val_2 = bone.TransformPoint(position:  new UnityEngine.Vector3() {x = R2, y = val_1.x, z = val_1.y});
            return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public static UnityEngine.Quaternion GetQuaternion(Spine.Bone bone)
        {
            float val_2;
            if(R1 != 0)
            {
                    val_2 = mem[R1 + 96];
                val_2 = R1 + 96;
            }
            else
            {
                    val_2 = 0f;
            }
            
            float val_2 = 0.5f;
            val_2 = 0 * val_2;
            bone = new UnityEngine.Quaternion(x:  val_2, y:  null, z:  0, w:  null);
            return new UnityEngine.Quaternion() {x = val_2};
        }
        public static UnityEngine.Vector3 GetWorldPosition(Spine.PointAttachment attachment, Spine.Slot slot, UnityEngine.Transform spineGameObjectTransform)
        {
            slot.ComputeWorldPosition(bone:  spineGameObjectTransform, ox: out  float val_1 = 6.220906E+33f, oy: out  float val_2 = 6.220909E+33f);
            UnityEngine.Vector3 val_3 = attachment.TransformPoint(position:  new UnityEngine.Vector3() {x = R3, y = 0f, z = 0f});
            return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public static UnityEngine.Vector3 GetWorldPosition(Spine.PointAttachment attachment, Spine.Bone bone, UnityEngine.Transform spineGameObjectTransform)
        {
            bone.ComputeWorldPosition(bone:  spineGameObjectTransform, ox: out  float val_1 = 6.305443E+33f, oy: out  float val_2 = 6.305445E+33f);
            UnityEngine.Vector3 val_3 = attachment.TransformPoint(position:  new UnityEngine.Vector3() {x = R3, y = 0f, z = 0f});
            return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public static UnityEngine.Matrix4x4 GetMatrix4x4(Spine.Bone bone)
        {
            float val_1;
            float val_2;
            float val_3;
            float val_4;
            float val_5;
            if(R1 != 0)
            {
                    val_1 = mem[R1 + 84];
                val_1 = R1 + 84;
                val_2 = mem[R1 + 88];
                val_2 = R1 + 88;
                val_3 = mem[R1 + 92];
                val_3 = R1 + 92;
                val_4 = mem[R1 + 96];
                val_4 = R1 + 96;
                val_5 = mem[R1 + 100];
                val_5 = R1 + 100;
            }
            else
            {
                    val_1 = 1.401298E-45f;
                val_2 = 0f;
                val_3 = 0f;
                val_4 = 0f;
                val_5 = 9.343217E-38f;
            }
            
            bone.data = 0;
            bone.skeleton = 0;
            mem2[0] = val_1;
            mem2[0] = val_4;
            bone.parent = val_2;
            bone.children = val_5;
            bone.shearY = val_3;
            bone.ax = R1 + 104;
            bone.ay = 0;
            bone.arotation = 1f;
            bone.scaleY = 0f;
            bone.shearX = 0f;
            return new UnityEngine.Matrix4x4() {m00 = 0f, m10 = R1 + 104, m20 = 1f, m32 = 0f, m13 = 6.384913E+33f};
        }
        public static void GetWorldToLocalMatrix(Spine.Bone bone, out float ia, out float ib, out float ic, out float id)
        {
            float val_2;
            float val_3;
            float val_4;
            if(bone != 0)
            {
                    val_2 = bone.a;
                val_3 = bone.b;
                val_4 = bone.c;
            }
            else
            {
                    val_2 = 1.401298E-45f;
                val_3 = 0f;
                val_4 = 0f;
            }
            
            float val_2 = bone.d;
            float val_1 = val_2 * val_2;
            val_1 = 1f / val_1;
            val_2 = val_2 * val_1;
            val_1 = val_2 * val_1;
            ia = val_2;
            ib = 1f;
            ic = ;
            id = val_1;
        }
        public static UnityEngine.Vector2 WorldToLocal(Spine.Bone bone, UnityEngine.Vector2 worldPosition)
        {
            worldPosition.x.WorldToLocal(worldX:  null, worldY:  null, localX: out  worldPosition.y, localY: out  R3);
            return new UnityEngine.Vector2();
        }
        public static UnityEngine.Material GetMaterial(Spine.Attachment a)
        {
            var val_1;
            var val_2;
            if(a != 0)
            {
                    val_1 = 0;
                if(0 != 0)
            {
                    val_2 = 0;
                if(35615780 == 0)
            {
                    return;
            }
            
                return;
            }
            
            }
            
            val_2 = 0;
        }
        public static UnityEngine.Vector2[] GetLocalVertices(Spine.VertexAttachment va, Spine.Slot slot, UnityEngine.Vector2[] buffer)
        {
            Spine.Bone val_13;
            var val_14;
            Spine.Slot val_15;
            int val_16;
            var val_17;
            float val_18;
            val_13 = va;
            val_14 = buffer;
            val_15 = slot;
            val_16 = va.worldVerticesLength;
            int val_1 = val_16 >> 1;
            if(val_14 == null)
            {
                    val_14 = null;
                if(null == 0)
            {
                    val_14 = 0;
            }
            
            }
            
            if(0 < val_1)
            {
                goto label_4;
            }
            
            if(va.bones == null)
            {
                goto label_5;
            }
            
            val_17 = null;
            val_13.ComputeWorldVertices(slot:  val_15, worldVertices:  533895840);
            val_13 = slot.bone;
            if(val_13 == 0)
            {
                goto label_7;
            }
            
            val_18 = slot.bone.worldX;
            goto label_8;
            label_5:
            if(val_16 < 2)
            {
                    return;
            }
            
            val_16 = va.vertices;
            do
            {
                var val_2 = 0 + 1;
                UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  null, y:  null);
                var val_4 = val_14 + 0;
                val_17 = 0 + 2;
                val_15 = 0 + 1;
                mem2[0] = val_3.x;
            }
            while(val_15 < val_1);
            
            return;
            label_7:
            val_18 = 0f;
            label_8:
            Spine.Unity.SkeletonExtensions.GetWorldToLocalMatrix(bone:  val_13, ia: out  float val_5 = 6.776902E+33f, ib: out  float val_6 = 6.7769E+33f, ic: out  float val_7 = 6.776897E+33f, id: out  0f);
            if(val_16 < 2)
            {
                    return;
            }
            
            var val_17 = 0;
            do
            {
                var val_9 = val_17 + 1;
                Il2CppType val_10 = System.Single[].__il2cppRuntimeField_byval_arg - val_18;
                float val_11 = typeof(System.Single[]).__il2cppRuntimeField_14 - slot.bone.worldY;
                float val_12 = val_11 * 0f;
                val_11 = val_11 * 0f;
                UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_11, y:  null);
                val_16 = val_13.y;
                var val_14 = val_14 + 0;
                val_13 = 1152921505140742840;
                val_17 = val_17 + 2;
                val_15 = 0 + 1;
                mem2[0] = val_13.x;
                mem2[0] = val_16;
            }
            while(val_15 < val_1);
            
            return;
            label_4:
            string val_15 = System.String.Format(format:  2007424064, arg0:  val_1, arg1:  13152256);
            System.ArgumentException val_16 = new System.ArgumentException(message:  2007424064, paramName:  1348647120);
        }
        public static UnityEngine.Vector2[] GetWorldVertices(Spine.VertexAttachment a, Spine.Slot slot, UnityEngine.Vector2[] buffer)
        {
            var val_6;
            Spine.Slot val_7;
            int val_8;
            var val_10;
            val_6 = buffer;
            val_7 = slot;
            val_8 = a.worldVerticesLength;
            int val_1 = val_8 >> 1;
            if(val_6 == null)
            {
                    val_6 = null;
                if(null == 0)
            {
                    val_6 = 0;
            }
            
            }
            
            if(0 >= val_1)
            {
                    a.ComputeWorldVertices(slot:  val_7, worldVertices:  533895840);
                if(val_8 < 2)
            {
                    return;
            }
            
                do
            {
                var val_2 = 0 + 1;
                UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  null, y:  null);
                if(0 <= 0)
            {
                    val_10 = val_6;
            }
            
                var val_4 = val_10 + 0;
                val_7 = 0 + 1;
                val_8 = 0 + 2;
                mem2[0] = val_3.x;
                mem2[0] = val_3.y;
            }
            while(val_7 < val_1);
            
                return;
            }
            
            string val_5 = System.String.Format(format:  2007424064, arg0:  static_value_021FF0EB, arg1:  13152256);
            System.ArgumentException val_6 = new System.ArgumentException(message:  2007424064, paramName:  1348647120);
        }
    
    }

}
