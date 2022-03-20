using UnityEngine;

namespace Spine
{
    public class VertexAttachment : Attachment
    {
        // Fields
        private static int nextID;
        private static readonly object nextIdLock;
        internal readonly int id;
        internal int[] bones;
        internal float[] vertices;
        internal int worldVerticesLength;
        
        // Properties
        public int Id { get; }
        public int[] Bones { get; set; }
        public float[] Vertices { get; set; }
        public int WorldVerticesLength { get; set; }
        
        // Methods
        public int get_Id()
        {
            return (int)this.id;
        }
        public int[] get_Bones()
        {
        
        }
        public void set_Bones(int[] value)
        {
            this.bones = value;
        }
        public float[] get_Vertices()
        {
        
        }
        public void set_Vertices(float[] value)
        {
            this.vertices = value;
        }
        public int get_WorldVerticesLength()
        {
            return (int)this.worldVerticesLength;
        }
        public void set_WorldVerticesLength(int value)
        {
            this.worldVerticesLength = value;
        }
        public VertexAttachment(string name)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            System.Threading.Monitor.Enter(obj:  Spine.VertexAttachment.nextIdLock, lockTaken: ref  bool val_1 = true);
            val_4 = null;
            val_4 = null;
            Spine.VertexAttachment.nextID = Spine.VertexAttachment.nextID + 1;
            int val_3 = 134215680;
            val_3 = val_3 & (Spine.VertexAttachment.nextID << 11);
            this.id = val_3;
            if(0 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  Spine.VertexAttachment.nextIdLock);
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        public void ComputeWorldVertices(Spine.Slot slot, float[] worldVertices)
        {
            this.ComputeWorldVertices(slot:  slot, start:  0, count:  this.worldVerticesLength, worldVertices:  worldVertices, offset:  0, stride:  2);
        }
        public void ComputeWorldVertices(Spine.Slot slot, int start, int count, float[] worldVertices, int offset, int stride = 2)
        {
            var val_31;
            Spine.Slot val_32;
            var val_33;
            int val_34;
            Spine.ExposedList<System.Single> val_35;
            int val_36;
            var val_37;
            var val_38;
            var val_39;
            int val_40;
            float val_41;
            float val_42;
            float val_43;
            float val_44;
            float val_45;
            var val_46;
            var val_47;
            System.Single[] val_48;
            var val_49;
            float val_50;
            float val_51;
            float val_52;
            float val_53;
            float val_54;
            float val_55;
            var val_56;
            var val_57;
            var val_58;
            System.Single[] val_59;
            var val_60;
            float val_61;
            float val_62;
            float val_63;
            float val_64;
            float val_65;
            float val_66;
            int val_67;
            var val_68;
            var val_69;
            var val_70;
            val_31 = count;
            val_32 = start;
            val_33 = this;
            int val_1 = val_31 >> 1;
            val_34 = stride;
            if(slot.bone == 0)
            {
                    val_31 = val_34;
                val_34 = val_31;
            }
            
            val_35 = slot.attachmentVertices;
            if(this.bones == null)
            {
                goto label_2;
            }
            
            if(val_32 < 1)
            {
                goto label_3;
            }
            
            val_36 = offset;
            val_37 = 0;
            var val_31 = 0;
            do
            {
                if(slot.bone.skeleton <= val_37)
            {
                    val_31 = val_37;
                val_37 = val_31;
            }
            
                val_31 = val_31 + 2;
                int val_32 = this.bones[val_37];
                val_38 = val_32 + 0;
                val_32 = val_37 + val_32;
                val_39 = val_32 + 1;
            }
            while(val_31 < val_32);
            
            goto label_6;
            label_2:
            val_40 = offset;
            if(slot.bone == 0)
            {
                goto label_8;
            }
            
            val_41 = slot.bone.a;
            val_42 = slot.bone.b;
            val_43 = slot.bone.worldX;
            val_44 = slot.bone.c;
            val_45 = slot.bone.worldY;
            goto label_9;
            label_3:
            val_38 = 0;
            val_39 = 0;
            val_36 = offset;
            label_6:
            val_40 = slot.bone.skeleton;
            if(val_40 == 0)
            {
                    val_39 = val_39;
            }
            
            if((slot.bone.skeleton + 12) == 0)
            {
                    val_40 = val_39;
                val_39 = val_40;
            }
            
            val_32 = slot;
            var val_33 = slot.bone.skeleton + 12 + 8;
            if(val_35 == 0)
            {
                    var val_35 = val_39;
                val_39 = val_35;
            }
            
            if(val_33 != 0)
            {
                    if(val_32 <= val_36)
            {
                    return;
            }
            
                val_35 = val_38 + 0;
                val_31 = 0;
                val_33 = val_33 + 16;
                System.Single[] val_34 = this.vertices;
                val_34 = val_34 + 16;
                do
            {
                val_35 = val_39 + 1;
                if((this.bones + 12) <= val_39)
            {
                    val_46 = val_39;
            }
            
                System.Int32[] val_2 = this.bones + 0;
                var val_39 = (this.bones + 0) + 16;
                var val_3 = val_39 + val_35;
                if(val_35 < val_3)
            {
                    var val_38 = val_31;
                var val_37 = val_35;
                var val_4 = val_33 + 0;
                System.Single[] val_5 = val_34 + (val_35 << 2);
                var val_6 = val_46 + 5;
                do
            {
                val_46 = val_6 - 4;
                val_47 = val_33;
                if(val_47 == 0)
            {
                    val_47 = val_33;
            }
            
                var val_36 = val_33;
                val_36 = val_36 + ((this.bones + ((val_46 + 5)) << 2) << 2);
                val_48 = this.vertices;
                if(val_48 == null)
            {
                    val_48 = this.vertices;
            }
            
                val_49 = val_33;
                if(val_49 == 0)
            {
                    val_49 = val_33;
            }
            
                val_37 = val_37 + 1;
                val_38 = val_38 + 1;
                val_37 = val_37 + 1;
                System.Single[] val_9 = val_5 + val_4;
                float val_10 = (((this.vertices + 16) + ((val_38 + 0)) << 2) + 4) + (((slot.bone.skeleton + 12 + 8 + 16) + 0) + 4);
                if(((slot.bone.skeleton + 12 + 8 + (this.bones + ((val_46 + 5)) << 2) << 2) + 16) != 0)
            {
                    val_50 = mem[(slot.bone.skeleton + 12 + 8 + (this.bones + ((val_46 + 5)) << 2) << 2) + 16 + 84];
                val_50 = (slot.bone.skeleton + 12 + 8 + (this.bones + ((val_46 + 5)) << 2) << 2) + 16 + 84;
                val_51 = mem[(slot.bone.skeleton + 12 + 8 + (this.bones + ((val_46 + 5)) << 2) << 2) + 16 + 88];
                val_51 = (slot.bone.skeleton + 12 + 8 + (this.bones + ((val_46 + 5)) << 2) << 2) + 16 + 88;
            }
            else
            {
                    val_50 = 1.401298E-45f;
                val_51 = 0f;
            }
            
                val_50 = ((slot.bone.skeleton + 12 + 8 + (this.bones + ((val_46 + 5)) << 2) << 2) + 16 + 92) + (val_9 * val_50);
                if(((slot.bone.skeleton + 12 + 8 + (this.bones + ((val_46 + 5)) << 2) << 2) + 16) != 0)
            {
                    val_52 = mem[(slot.bone.skeleton + 12 + 8 + (this.bones + ((val_46 + 5)) << 2) << 2) + 16 + 96];
                val_52 = (slot.bone.skeleton + 12 + 8 + (this.bones + ((val_46 + 5)) << 2) << 2) + 16 + 96;
                val_53 = mem[(slot.bone.skeleton + 12 + 8 + (this.bones + ((val_46 + 5)) << 2) << 2) + 16 + 100];
                val_53 = (slot.bone.skeleton + 12 + 8 + (this.bones + ((val_46 + 5)) << 2) << 2) + 16 + 100;
            }
            else
            {
                    val_52 = 0f;
                val_53 = 9.343217E-38f;
            }
            
                System.Single[] val_12 = val_9 * val_52;
                val_38 = val_38 + 1;
                val_37 = val_37 + 1;
                val_4 = val_4 + 8;
                val_5 = val_5 + 12;
                val_39 = val_39 - 1;
                val_6 = val_6 + 1;
                val_12 = ((slot.bone.skeleton + 12 + 8 + (this.bones + ((val_46 + 5)) << 2) << 2) + 16 + 104) + val_12;
            }
            while(((slot.bone.skeleton + 12 + 8 + (this.bones + ((val_46 + 5)) << 2) << 2) + 16) != 0);
            
                val_31 = val_38 + (val_39 << 1);
                val_56 = val_3;
                val_35 = val_37 + (val_39 + (val_39 << 1));
            }
            else
            {
                    val_55 = 0;
                val_56 = val_35;
                val_54 = 0;
            }
            
                val_40 = worldVertices;
                val_32 = slot;
                val_40[val_36] = val_54;
                val_40[val_36 + 1] = val_55;
                val_33 = val_36 + stride;
            }
            while(val_33 < val_32);
            
                return;
            }
            
            if(val_32 <= val_36)
            {
                    return;
            }
            
            System.Single[] val_40 = this.vertices;
            val_40 = val_40 + 16;
            var val_14 = val_38 + 0;
            do
            {
                val_35 = val_39 + 1;
                if((this.bones + 12) <= val_39)
            {
                    val_57 = val_39;
            }
            
                var val_42 = (this.bones + 0) + 16;
                val_31 = val_42 + val_35;
                if(val_35 < val_31)
            {
                    var val_41 = val_14;
                var val_16 = val_57 + 5;
                System.Single[] val_17 = val_40 + (val_41 << 2);
                do
            {
                val_57 = val_16 - 4;
                val_58 = val_33;
                if(val_58 == 0)
            {
                    val_58 = val_33;
            }
            
                var val_19 = val_58 + ((this.bones + ((val_57 + 5)) << 2) << 2);
                val_59 = this.vertices;
                if(val_59 == null)
            {
                    val_59 = this.vertices;
            }
            
                val_60 = mem[this.vertices + 12];
                val_60 = this.vertices + 12;
                if(val_60 <= val_41)
            {
                    val_60 = mem[this.vertices + 12];
                val_60 = this.vertices + 12;
            }
            
                val_41 = val_41 + 1;
                if(val_60 <= val_41)
            {
                    val_60 = mem[this.vertices + 12];
                val_60 = this.vertices + 12;
            }
            
                val_41 = val_41 + 1;
                if(((slot.bone.skeleton + 12 + 8 + (this.bones + ((val_57 + 5)) << 2) << 2) + 16) != 0)
            {
                    val_61 = mem[(slot.bone.skeleton + 12 + 8 + (this.bones + ((val_57 + 5)) << 2) << 2) + 16 + 84];
                val_61 = (slot.bone.skeleton + 12 + 8 + (this.bones + ((val_57 + 5)) << 2) << 2) + 16 + 84;
                val_62 = mem[(slot.bone.skeleton + 12 + 8 + (this.bones + ((val_57 + 5)) << 2) << 2) + 16 + 88];
                val_62 = (slot.bone.skeleton + 12 + 8 + (this.bones + ((val_57 + 5)) << 2) << 2) + 16 + 88;
            }
            else
            {
                    val_61 = 1.401298E-45f;
                val_62 = 0f;
            }
            
                val_61 = ((slot.bone.skeleton + 12 + 8 + (this.bones + ((val_57 + 5)) << 2) << 2) + 16 + 92) + (val_17 * val_61);
                if(((slot.bone.skeleton + 12 + 8 + (this.bones + ((val_57 + 5)) << 2) << 2) + 16) != 0)
            {
                    val_63 = mem[(slot.bone.skeleton + 12 + 8 + (this.bones + ((val_57 + 5)) << 2) << 2) + 16 + 96];
                val_63 = (slot.bone.skeleton + 12 + 8 + (this.bones + ((val_57 + 5)) << 2) << 2) + 16 + 96;
                val_64 = mem[(slot.bone.skeleton + 12 + 8 + (this.bones + ((val_57 + 5)) << 2) << 2) + 16 + 100];
                val_64 = (slot.bone.skeleton + 12 + 8 + (this.bones + ((val_57 + 5)) << 2) << 2) + 16 + 100;
            }
            else
            {
                    val_63 = 0f;
                val_64 = 9.343217E-38f;
            }
            
                System.Single[] val_21 = val_17 * val_63;
                val_41 = val_41 + 1;
                val_17 = val_17 + 12;
                val_42 = val_42 - 1;
                val_16 = val_16 + 1;
                val_21 = ((slot.bone.skeleton + 12 + 8 + (this.bones + ((val_57 + 5)) << 2) << 2) + 16 + 104) + val_21;
            }
            while(((slot.bone.skeleton + 12 + 8 + (this.bones + ((val_57 + 5)) << 2) << 2) + 16) != 0);
            
                var val_43 = val_14;
                val_67 = val_36;
                val_35 = stride;
                val_32 = slot;
                val_43 = val_43 + (val_42 + (val_42 << 1));
                val_68 = val_31;
            }
            else
            {
                    val_66 = 0;
                val_65 = 0;
                val_68 = val_35;
                val_35 = stride;
            }
            
                val_40 = worldVertices;
                if(val_40 == null)
            {
                    val_68 = val_68;
            }
            
                if((this.bones + 0) <= val_36)
            {
                    val_68 = val_68;
            }
            
                val_40[val_36] = val_65;
                val_33 = val_36 + val_35;
                val_40[val_36 + 1] = val_66;
            }
            while(val_33 < val_32);
            
            return;
            label_8:
            val_43 = 0f;
            val_45 = 9.343217E-38f;
            val_41 = 1.401298E-45f;
            val_42 = 0f;
            val_44 = 0f;
            label_9:
            if(slot <= val_40)
            {
                    return;
            }
            
            val_35 = stride << 2;
            do
            {
                val_69 = this.vertices;
                if(this.vertices == null)
            {
                    val_69 = this.vertices;
            }
            
                val_70 = mem[this.vertices + 12];
                val_70 = this.vertices + 12;
                if(val_70 <= val_32)
            {
                    val_70 = mem[this.vertices + 12];
                val_70 = this.vertices + 12;
            }
            
                mem2[0] = val_43 + (val_42 * (((this.vertices + (start) << 2) + 16) + 4));
                int val_29 = val_40 + 1;
                val_32 = (val_32 + 1) + 1;
                mem2[0] = val_45 + (slot.bone.d * (((this.vertices + (start) << 2) + 16) + 4));
                val_40 = val_40 + stride;
                val_33 = ((this.vertices + (val_32 << 2)) + 16) + 8;
            }
            while(val_40 < slot);
        
        }
        public virtual bool ApplyDeform(Spine.VertexAttachment sourceAttachment)
        {
            this = this - sourceAttachment;
            this = this >> 5;
            return (bool)this;
        }
        private static VertexAttachment()
        {
            Spine.VertexAttachment.nextID = 0;
            Spine.VertexAttachment.nextIdLock = new System.Object();
        }
    
    }

}
