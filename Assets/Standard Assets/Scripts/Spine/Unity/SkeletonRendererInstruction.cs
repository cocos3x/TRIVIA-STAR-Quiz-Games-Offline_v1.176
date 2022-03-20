using UnityEngine;

namespace Spine.Unity
{
    public class SkeletonRendererInstruction
    {
        // Fields
        public bool immutableTriangles;
        public readonly Spine.ExposedList<Spine.Unity.SubmeshInstruction> submeshInstructions;
        public bool hasActiveClipping;
        public int rawVertexCount;
        public readonly Spine.ExposedList<Spine.Attachment> attachments;
        
        // Methods
        public void Clear()
        {
            this.attachments.Clear(clearArray:  false);
            this.hasActiveClipping = false;
            this.rawVertexCount = 0;
            this.submeshInstructions.Clear(clearArray:  false);
        }
        public void SetWithSubset(Spine.ExposedList<Spine.Unity.SubmeshInstruction> instructions, int startSubmesh, int endSubmesh)
        {
            Spine.Unity.SkeletonRendererInstruction val_15;
            int val_16;
            Spine.ExposedList<Spine.Unity.SubmeshInstruction> val_17;
            var val_18;
            var val_19;
            val_15 = this;
            val_16 = endSubmesh;
            if(this.submeshInstructions != 0)
            {
                    this.submeshInstructions.Clear(clearArray:  false);
                Spine.ExposedList<T> val_2 = this.submeshInstructions.Resize(newSize:  val_16 - startSubmesh);
            }
            else
            {
                    0.Clear(clearArray:  false);
                int val_3 = val_16 - startSubmesh;
                Spine.ExposedList<T> val_4 = 0.Resize(newSize:  val_3);
            }
            
            if(val_3 >= 1)
            {
                    int val_14 = startSubmesh;
                var val_17 = 0;
                val_14 = val_14 + (val_14 << 2);
                val_14 = instructions + (val_14 << 3);
                do
            {
                int val_15 = startSubmesh;
                val_15 = val_15 + 0;
                Spine.ExposedList<Spine.Unity.SubmeshInstruction> val_16 = val_14;
                val_16 = val_16 + val_17;
                Spine.ExposedList<Spine.Unity.SubmeshInstruction> val_5 = val_16 + 32;
                val_16 = val_16 + 16;
                var val_6 = SB + val_17;
                var val_7 = val_6 + 32;
                mem2[0] = ((instructions + ((startSubmesh + (startSubmesh) << 2)) << 3) + 0) + 48;
                var val_8 = val_6 + 16;
                if(((int)this.submeshInstructions & 255) != 0)
            {
                    (int)this.submeshInstructions & 255 = 1;
            }
            
                mem[1152921510889732752] = 1;
                mem2[0] = 0;
                val_17 = instructions;
                val_17 = val_17 + 40;
                val_18 = 0 + 1;
                val_19 = D9 + 0;
            }
            while(val_3 != val_18);
            
                val_15 = val_15;
                val_16 = val_16;
                mem[1152921510889732756] = val_19;
            }
            else
            {
                    this.rawVertexCount = 0;
            }
            
            int val_18 = startSubmesh;
            val_18 = val_18 + (val_18 << 2);
            val_18 = instructions + (val_18 << 3);
            int val_9 = val_16 - 1;
            int val_10 = val_9 + (val_9 << 2);
            val_10 = instructions + (val_10 << 3);
            this.attachments.Clear(clearArray:  false);
            Spine.ExposedList<Spine.Unity.SubmeshInstruction> val_11 = ((instructions + (((endSubmesh - 1) + ((endSubmesh - 1)) << 2)) << 3) + 24) - val_18;
            Spine.ExposedList<T> val_12 = this.attachments.Resize(newSize:  val_11);
            if(val_11 < 1)
            {
                    return;
            }
            
            Spine.ExposedList<Spine.Unity.SubmeshInstruction> val_19 = val_18;
            Spine.ExposedList<Spine.Attachment> val_13 = this.attachments + 16;
            val_15 = mem[instructions + 16 + 20 + 8];
            val_15 = instructions + 16 + 20 + 8;
            val_19 = val_15 + (val_19 << 2);
            val_19 = val_19 + 16;
            do
            {
                Spine.ExposedList<Spine.Unity.SubmeshInstruction> val_20 = val_18;
                val_20 = val_20 + 0;
                mem2[0] = ((instructions + 16 + 20 + 8 + ((instructions + ((startSubmesh + (startSubmesh) << 2)) << 3)) << 2) + 16) + 0 + 48;
                val_18 = 0 + 1;
            }
            while(val_11 != val_18);
        
        }
        public void Set(Spine.Unity.SkeletonRendererInstruction other)
        {
            if(other != 0)
            {
                    this.immutableTriangles = other.immutableTriangles;
                this.hasActiveClipping = other.hasActiveClipping;
            }
            else
            {
                    this.immutableTriangles = false;
                this.hasActiveClipping = true;
            }
            
            this.rawVertexCount = other.rawVertexCount;
            this.attachments.Clear(clearArray:  false);
            this.attachments.GrowIfNeeded(newCount:  other.attachments.Capacity);
            mem2[0] = other.attachments;
            other.attachments.CopyTo(array:  this.attachments);
            this.submeshInstructions.Clear(clearArray:  false);
            this.submeshInstructions.GrowIfNeeded(newCount:  other.submeshInstructions.Capacity);
            mem2[0] = other.submeshInstructions;
            other.submeshInstructions.CopyTo(array:  this.submeshInstructions);
        }
        public static bool GeometryNotEqual(Spine.Unity.SkeletonRendererInstruction a, Spine.Unity.SkeletonRendererInstruction b)
        {
            Spine.ExposedList<Spine.Attachment> val_2;
            Spine.ExposedList<Spine.Attachment> val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            if(((a.hasActiveClipping == true) || (b.hasActiveClipping == true)) || (a.rawVertexCount != b.rawVertexCount))
            {
                goto label_30;
            }
            
            bool val_2 = a.immutableTriangles;
            if(b.immutableTriangles == true)
            {
                    b.immutableTriangles = 1;
            }
            
            val_2 = val_2 >> 5;
            if(val_2 == true)
            {
                goto label_30;
            }
            
            val_2 = b.attachments;
            val_3 = a.attachments;
            if(1 != SL)
            {
                goto label_30;
            }
            
            val_3 = b.submeshInstructions;
            if(a.submeshInstructions != 1)
            {
                goto label_30;
            }
            
            if(SL < 1)
            {
                goto label_16;
            }
            
            val_5 = 0;
            val_6 = a.attachments + 16;
            label_22:
            val_2 = mem[b.hasActiveClipping + 0];
            val_2 = b.hasActiveClipping + 0;
            if(val_2 != null)
            {
                goto label_30;
            }
            
            val_5 = val_5 + 1;
            if(val_5 < SL)
            {
                goto label_22;
            }
            
            label_16:
            if(a.submeshInstructions < 1)
            {
                    return (bool)val_8;
            }
            
            var val_4 = 0;
            val_2 = 0;
            label_31:
            var val_1 = 1 + val_4;
            val_6 = mem[(1 + 0) + 20];
            val_6 = (1 + 0) + 20;
            val_5 = mem[(1 + 0) + 24];
            val_5 = (1 + 0) + 24;
            val_4 = mem[(1 + 0) + 44];
            val_4 = (1 + 0) + 44;
            val_3 = mem[(1 + 0) + 48];
            val_3 = (1 + 0) + 48;
            val_7 = 1;
            if(val_7 == 0)
            {
                    val_7 = 1;
            }
            
            var val_3 = 1;
            val_3 = val_3 + val_4;
            if(val_4 != ((1 + 0) + 44))
            {
                goto label_30;
            }
            
            if(val_3 == ((1 + 0) + 48))
            {
                    (1 + 0) + 48 = mem[(1 + 0) + 40];
                (1 + 0) + 48 = (1 + 0) + 40;
            }
            
            if(((1 + 0) + 40) != ((1 + 0) + 48))
            {
                goto label_30;
            }
            
            if(val_5 == ((1 + 0) + 24))
            {
                    val_3 = mem[(1 + 0) + 20];
                val_3 = (1 + 0) + 20;
            }
            
            if(val_6 != val_3)
            {
                goto label_30;
            }
            
            val_2 = val_2 + 1;
            val_4 = val_4 + 40;
            val_8 = 0;
            if(val_2 < a.submeshInstructions)
            {
                goto label_31;
            }
            
            return (bool)val_8;
            label_30:
            val_8 = 1;
            return (bool)val_8;
        }
        public SkeletonRendererInstruction()
        {
            Spine.ExposedList<Spine.Unity.SubmeshInstruction> val_1 = new Spine.ExposedList<Spine.Unity.SubmeshInstruction>();
            this.rawVertexCount = 0;
            this.submeshInstructions = null;
            Spine.ExposedList<UnityEngine.Material> val_2 = new Spine.ExposedList<UnityEngine.Material>();
            this.attachments = null;
        }
    
    }

}
