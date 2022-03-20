using UnityEngine;

namespace Spine.Unity
{
    [Serializable]
    public class MeshGenerator
    {
        // Fields
        public Spine.Unity.MeshGenerator.Settings settings;
        private const float BoundsMinDefault = ∞;
        private const float BoundsMaxDefault = -∞;
        private readonly Spine.ExposedList<UnityEngine.Vector3> vertexBuffer;
        private readonly Spine.ExposedList<UnityEngine.Vector2> uvBuffer;
        private readonly Spine.ExposedList<UnityEngine.Color32> colorBuffer;
        private readonly Spine.ExposedList<Spine.ExposedList<int>> submeshes;
        private UnityEngine.Vector2 meshBoundsMin;
        private UnityEngine.Vector2 meshBoundsMax;
        private float meshBoundsThickness;
        private int submeshIndex;
        private Spine.SkeletonClipping clipper;
        private float[] tempVerts;
        private int[] regionTriangles;
        private UnityEngine.Vector3[] normals;
        private UnityEngine.Vector4[] tangents;
        private UnityEngine.Vector2[] tempTanBuffer;
        private Spine.ExposedList<UnityEngine.Vector2> uv2;
        private Spine.ExposedList<UnityEngine.Vector2> uv3;
        
        // Properties
        public UnityEngine.Vector3[] VertexBuffer { get; }
        public UnityEngine.Vector2[] UVBuffer { get; }
        public UnityEngine.Color32[] ColorBuffer { get; }
        public int VertexCount { get; }
        
        // Methods
        public UnityEngine.Vector3[] get_VertexBuffer()
        {
            if(this.vertexBuffer != 0)
            {
                    return;
            }
        
        }
        public UnityEngine.Vector2[] get_UVBuffer()
        {
            if(this.uvBuffer != 0)
            {
                    return;
            }
        
        }
        public UnityEngine.Color32[] get_ColorBuffer()
        {
            if(this.colorBuffer != 0)
            {
                    return;
            }
        
        }
        public int get_VertexCount()
        {
            if(this.vertexBuffer != 0)
            {
                    return (int)this;
            }
            
            return (int)this;
        }
        public static void GenerateSingleSubmeshInstruction(Spine.Unity.SkeletonRendererInstruction instructionOutput, Spine.Skeleton skeleton, UnityEngine.Material material)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            int val_10;
            var val_11;
            var val_12;
            val_5 = instructionOutput;
            if(val_5 != 0)
            {
                    val_5.Clear();
            }
            else
            {
                    0.Clear();
            }
            
            Spine.ExposedList<T> val_1 = instructionOutput.submeshInstructions.Resize(newSize:  1);
            Spine.ExposedList<Spine.Attachment> val_5 = instructionOutput.attachments;
            Spine.ExposedList<T> val_2 = val_5.Resize(newSize:  R7);
            if(R7 >= 1)
            {
                    val_5 = val_5 + 16;
                Spine.ExposedList<Spine.Unity.SubmeshInstruction> val_3 = instructionOutput.submeshInstructions + 16;
                do
            {
                mem2[0] = (instructionOutput.submeshInstructions + 16) + 0 + 48;
                val_8 = 0;
                if(((instructionOutput.submeshInstructions + 16) + 0 + 48) != 0)
            {
                    val_6 = ???;
                val_6 = ???;
            }
            
                val_7 = 0;
                val_5 = 0 + 1;
                val_10 = val_8 + 0;
                val_11 = val_8 + 0;
                val_12 = val_7 + 0;
            }
            while(val_6 != val_5);
            
            }
            else
            {
                    val_12 = 0;
                val_11 = 0;
                val_10 = 0;
            }
            
            if(val_5 != 0)
            {
                    instructionOutput.hasActiveClipping = false;
            }
            else
            {
                    mem[16] = 0;
            }
            
            instructionOutput.rawVertexCount = val_10;
            mem2[0] = skeleton;
            mem2[0] = 0;
            mem2[0] = ???;
            mem2[0] = material;
            Spine.ExposedList<Spine.Unity.SubmeshInstruction> val_4 = instructionOutput.submeshInstructions + 32;
            mem2[0] = 0;
        }
        public static void GenerateSkeletonRendererInstruction(Spine.Unity.SkeletonRendererInstruction instructionOutput, Spine.Skeleton skeleton, System.Collections.Generic.Dictionary<Spine.Slot, UnityEngine.Material> customSlotMaterials, System.Collections.Generic.List<Spine.Slot> separatorSlots, bool generateMeshOverride, bool immutableTriangles = False)
        {
            Spine.Unity.SkeletonRendererInstruction val_13;
            Spine.ExposedList<Spine.Slot> val_14;
            Spine.ExposedList<Spine.Unity.SubmeshInstruction> val_15;
            float val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            Spine.Unity.SkeletonRendererInstruction val_25;
            var val_26;
            val_13 = instructionOutput;
            val_14 = skeleton.drawOrder;
            if(val_13 != 0)
            {
                    val_13.Clear();
                val_15 = instructionOutput.submeshInstructions;
            }
            else
            {
                    0.Clear();
                val_15 = 0f;
            }
            
            Spine.ExposedList<T> val_1 = instructionOutput.attachments.Resize(newSize:  0);
            if(customSlotMaterials != 0)
            {
                    if(customSlotMaterials.Count > 0)
            {
                    0 = 1;
            }
            
            }
            
            if(0 < 1)
            {
                goto label_8;
            }
            
            var val_21 = 0;
            label_73:
            var val_3 = 0 + 0;
            Spine.ExposedList<Spine.Attachment> val_4 = instructionOutput.attachments + 0;
            mem2[0] = (0 + 0) + 16 + 48;
            if(0 != 0)
            {
                    if(((0 + 0) + 16 + 8) == 0)
            {
                    val_18 = ((0 + 0) + 16 + 8) - 0;
                0 = 0;
            }
            
            }
            else
            {
                    val_18 = 0;
            }
            
            if(0 < 1)
            {
                goto label_29;
            }
            
            var val_18 = 0;
            label_33:
            if(0 <= val_18)
            {
                    var val_17 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_17 = val_17 + 0;
            if(((0 + 0) + 16) == ((0 + 0) + 16))
            {
                goto label_32;
            }
            
            val_18 = val_18 + 1;
            if(val_18 < 0)
            {
                goto label_33;
            }
            
            val_19 = 0;
            goto label_34;
            label_32:
            val_19 = 1;
            label_34:
            label_29:
            if(1 == 0)
            {
                goto label_35;
            }
            
            val_14 = instructionOutput.attachments;
            if((val_19 & 255) != 0)
            {
                goto label_36;
            }
            
            val_15 = val_15;
            if((generateMeshOverride == false) || (0 < 1))
            {
                goto label_66;
            }
            
            if(val_15 == 0)
            {
                goto label_39;
            }
            
            val_20 = 1;
            Spine.ExposedList<T> val_5 = val_15.Resize(newSize:  1);
            goto label_40;
            label_35:
            val_14 = instructionOutput.attachments;
            if(1 == 0)
            {
                goto label_41;
            }
            
            val_15 = val_15;
            if((customSlotMaterials.TryGetValue(key:  (0 + 0) + 16, value: out  UnityEngine.Material val_6 = 1982887544)) == true)
            {
                goto label_43;
            }
            
            if(0 == 0)
            {
                goto label_48;
            }
            
            goto label_47;
            label_41:
            val_15 = val_15;
            label_48:
            label_47:
            val_17 = 0;
            label_43:
            if((val_19 & 255) != 0)
            {
                goto label_57;
            }
            
            label_61:
            if(val_15 == 0)
            {
                goto label_58;
            }
            
            val_21 = 1;
            Spine.ExposedList<T> val_8 = val_15.Resize(newSize:  1);
            goto label_59;
            label_57:
            if(0 >= 1)
            {
                    if(0 != val_17)
            {
                goto label_61;
            }
            
            }
            
            val_22 = 0;
            val_23 = 0;
            goto label_62;
            label_58:
            val_21 = 1;
            Spine.ExposedList<T> val_9 = 0.Resize(newSize:  1);
            label_59:
            var val_19 = 0;
            val_23 = 0;
            val_19 = val_19 + 0;
            val_19 = 0 + (val_19 << 3);
            mem2[0] = skeleton;
            mem2[0] = 0;
            mem2[0] = val_21;
            mem2[0] = 0;
            mem2[0] = 1;
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            val_22 = 0;
            mem2[0] = 0;
            val_14 = instructionOutput.attachments;
            label_62:
            val_22 = val_22 + 0;
            val_23 = val_23 + 0;
            goto label_66;
            label_36:
            val_15 = val_15;
            goto label_66;
            label_39:
            val_20 = 2;
            Spine.ExposedList<T> val_12 = 0.Resize(newSize:  2);
            label_40:
            var val_20 = val_21;
            val_20 = val_20 + 4;
            val_20 = 0 + (val_20 << 3);
            mem2[0] = skeleton;
            mem2[0] = val_21;
            mem2[0] = val_21;
            mem2[0] = val_17;
            mem2[0] = 1;
            mem2[0] = 0;
            mem2[0] = val_23;
            mem2[0] = val_22;
            mem2[0] = 0;
            mem2[0] = 1;
            val_14 = instructionOutput.attachments;
            label_66:
            val_21 = val_21 + 1;
            if(val_21 < 0)
            {
                goto label_73;
            }
            
            val_13 = 0;
            val_25 = val_13;
            if(val_13 < 1)
            {
                goto label_74;
            }
            
            val_26 = 1;
            if(val_15 == 0)
            {
                goto label_75;
            }
            
            Spine.ExposedList<T> val_13 = val_15.Resize(newSize:  3);
            goto label_76;
            label_8:
            val_26 = 0;
            val_25 = val_13;
            goto label_78;
            label_74:
            val_26 = 1;
            goto label_78;
            label_75:
            Spine.ExposedList<T> val_14 = 0.Resize(newSize:  3);
            label_76:
            val_14 = skeleton;
            val_16 = 0f;
            var val_22 = val_20;
            val_22 = val_22 + 8;
            val_22 = 0 + (val_22 << 3);
            mem2[0] = val_14;
            mem2[0] = val_21;
            mem2[0] = 0;
            mem2[0] = val_17;
            mem2[0] = 0;
            mem2[0] = val_21;
            mem2[0] = val_16;
            mem2[0] = val_13;
            mem2[0] = 0 + 0;
            mem2[0] = 1;
            label_78:
            if(val_25 != 0)
            {
                    mem2[0] = 0;
                mem2[0] = val_26 & 1;
            }
            else
            {
                    mem[16] = val_26 & 1;
                mem[20] = 0;
            }
            
            mem2[0] = immutableTriangles;
        }
        public static void TryReplaceMaterials(Spine.ExposedList<Spine.Unity.SubmeshInstruction> workingSubmeshInstructions, System.Collections.Generic.Dictionary<UnityEngine.Material, UnityEngine.Material> customMaterialOverride)
        {
            UnityEngine.Material val_4;
            if(0 < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            UnityEngine.Material val_1 = R6 + 28;
            do
            {
                val_4 = mem[(R6 + 28)];
                val_4 = val_1;
                if((customMaterialOverride.TryGetValue(key:  val_4, value: out  UnityEngine.Material val_2 = 1983041528)) != false)
            {
                    val_4 = 0;
                mem2[0] = val_4;
            }
            
                val_4 = val_4 + 1;
                val_1 = val_1 + 40;
            }
            while(val_4 < (R6 + 12));
        
        }
        public void Begin()
        {
            this.vertexBuffer.Clear(clearArray:  false);
            this.colorBuffer.Clear(clearArray:  false);
            this.uvBuffer.Clear(clearArray:  false);
            this.clipper.ClipEnd();
            this.meshBoundsThickness = 0f;
            mem2[0] = 1;
            this.submeshes.Clear(clearArray:  false);
            this.submeshIndex = 0;
        }
        public void AddSubmesh(Spine.Unity.SubmeshInstruction instruction, bool updateTriangles = True)
        {
            Spine.Unity.MeshGenerator val_45;
            Spine.Unity.MeshGenerator val_46;
            Spine.Slot val_47;
            var val_48;
            int val_49;
            float val_50;
            Spine.Unity.MeshGenerator val_51;
            var val_52;
            int val_53;
            System.Single[] val_59;
            Spine.SkeletonClipping val_65;
            var val_66;
            var val_67;
            var val_68;
            bool val_45 = true;
            val_45 = this;
            val_46 = val_45;
            val_45 = val_45 - 1;
            if(val_45 < this.submeshIndex)
            {
                    Spine.ExposedList<T> val_2 = this.submeshes.Resize(newSize:  this.submeshIndex + 1);
                val_45 = val_46;
                if((this.submeshes + (this.submeshIndex << 2)) == 0)
            {
                    Spine.ExposedList<System.Int32> val_4 = new Spine.ExposedList<System.Int32>();
                Spine.ExposedList<Spine.ExposedList<System.Int32>> val_5 = this.submeshes + (this.submeshIndex << 2);
                val_45 = val_46;
                mem2[0] = null;
            }
            
            }
            
            Spine.ExposedList<Spine.ExposedList<System.Int32>> val_6 = this.submeshes + (this.submeshIndex << 2);
            this.submeshIndex.Clear(clearArray:  false);
            val_47 = 0;
            UnityEngine.Color val_7 = UnityEngine.Color.white;
            val_48 = 0;
            UnityEngine.Color32 val_8 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
            float val_46 = instruction.skeleton.a;
            if((instruction.hasClipping & true) != 0)
            {
                goto label_19;
            }
            
            val_49 = instruction.endSlot;
            val_50 = mem[instruction.skeleton.drawOrder + 8];
            val_51 = val_46;
            if((this.settings == 0) || (instruction.preActiveClippingSlotSource < 0))
            {
                goto label_21;
            }
            
            var val_9 = val_50 + (instruction.preActiveClippingSlotSource << 2);
            val_52 = 0;
            if(((mem[instruction.skeleton.drawOrder + 8] + (instruction.preActiveClippingSlotSource) << 2) + 16 + 48) != 0)
            {
                    val_48 = mem[(mem[instruction.skeleton.drawOrder + 8] + (instruction.preActiveClippingSlotSource) << 2) + 16 + 48 + 180];
                val_48 = (mem[instruction.skeleton.drawOrder + 8] + (instruction.preActiveClippingSlotSource) << 2) + 16 + 48 + 180;
                if((((mem[instruction.skeleton.drawOrder + 8] + (instruction.preActiveClippingSlotSource) << 2) + 16 + 48 + 100 + (Spine.ClippingAttachment.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    (mem[instruction.skeleton.drawOrder + 8] + (instruction.preActiveClippingSlotSource) << 2) + 16 + 48 = 0;
            }
            
                val_52 = (mem[instruction.skeleton.drawOrder + 8] + (instruction.preActiveClippingSlotSource) << 2) + 16 + 48;
            }
            
            int val_10 = this.clipper.ClipStart(slot:  (mem[instruction.skeleton.drawOrder + 8] + (instruction.preActiveClippingSlotSource) << 2) + 16, clip:  0);
            label_19:
            val_49 = instruction.endSlot;
            val_51 = val_46;
            val_50 = mem[instruction.skeleton.drawOrder + 8];
            label_21:
            val_53 = instruction.startSlot;
            if(val_53 < val_49)
            {
                    int val_47 = this.submeshIndex;
                val_46 = val_46 * 255f;
                val_47 = val_47 + 8;
                do
            {
                var val_38 = val_50 + (val_53 << 2);
                val_47 = mem[(mem[instruction.skeleton.drawOrder + 8] + (instruction.startSlot) << 2) + 16];
                val_47 = (mem[instruction.skeleton.drawOrder + 8] + (instruction.startSlot) << 2) + 16;
                val_46 = mem[(mem[instruction.skeleton.drawOrder + 8] + (instruction.startSlot) << 2) + 16 + 48];
                val_46 = (mem[instruction.skeleton.drawOrder + 8] + (instruction.startSlot) << 2) + 16 + 48;
                if(val_46 != 0)
            {
                    val_59 = this.tempVerts;
                val_59 = val_59;
                val_49 = val_49;
                val_47 = val_47;
            }
            
                if(val_46 != 0)
            {
                    val_48 = val_49;
                int val_39 = this.clipper.ClipStart(slot:  val_47, clip:  val_46);
                val_53 = val_53;
                val_50 = mem[instruction.skeleton.drawOrder + 8];
                val_49 = val_48;
            }
            
                 =  + 1;
            }
            while( != val_49);
            
                val_65 = this.clipper;
            }
            else
            {
                    val_65 = this.clipper;
            }
            
            mem[this.clipper].ClipEnd();
            float val_70 = (float)val_49;
            this.meshBoundsMin = ;
            mem[1152921510885288492] = ((mem[instruction.skeleton.drawOrder + 8] + (instruction.preActiveClippingSlotSource) << 2) + 16 + 48 + 180 + 16) + 4;
            this.meshBoundsMax = this.meshBoundsMax;
            val_70 = S16 * val_70;
            mem[1152921510885288500] = this.meshBoundsMax;
            this.meshBoundsThickness = val_70;
            if(this.submeshIndex != 0)
            {
                    val_66 = mem[this.submeshIndex + 8];
                val_66 = this.submeshIndex + 8;
            }
            else
            {
                    val_66 = 0;
            }
            
            val_67 = mem[this.submeshIndex + 12];
            val_67 = this.submeshIndex + 12;
            val_68 = 0;
            if(val_67 >= val_68)
            {
                goto label_139;
            }
            
            val_47 = val_68 - 1;
            val_48 = 0;
            goto label_140;
            label_142:
            val_67 = val_67 + 1;
            val_68 = 0;
            label_140:
            var val_44 = val_66 + (val_67 << 2);
            mem2[0] = val_48;
            if(val_47 != val_67)
            {
                goto label_142;
            }
            
            label_139:
            int val_71 = this.submeshIndex;
            val_71 = val_71 + 1;
            this.submeshIndex = val_71;
        }
        public void BuildMesh(Spine.Unity.SkeletonRendererInstruction instruction, bool updateTriangles)
        {
            var val_2;
            Spine.ExposedList<Spine.Unity.SubmeshInstruction> val_3;
            val_2 = instruction;
            val_3 = instruction.submeshInstructions;
            if(instruction.submeshInstructions != 0)
            {
                goto label_1;
            }
            
            val_3 = instruction.submeshInstructions;
            if(val_3 == 0)
            {
                goto label_2;
            }
            
            label_1:
            if(val_3 < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            var val_1 = R8 + 28;
            do
            {
                this.AddSubmesh(instruction:  new Spine.Unity.SubmeshInstruction() {skeleton = mem[(R8 + 28) + (-12)], startSlot = mem[(R8 + 28) + (-8)], endSlot = mem[(R8 + 28) + (-4)], material = mem[(R8 + 28) + (0)], forceSeparate = mem[(R8 + 28) + (4)], preActiveClippingSlotSource = mem[(R8 + 28) + (8)], rawTriangleCount = mem[(R8 + 28) + (12)], rawVertexCount = mem[(R8 + 28) + (16)], rawFirstVertexIndex = (R8 + 28) + 20, hasClipping = ???}, updateTriangles:  ???);
                val_2 = val_2 + 1;
                val_1 = val_1 + 40;
            }
            while(val_3 != val_2);
            
            return;
            label_2:
        }
        public void BuildMeshWithArrays(Spine.Unity.SkeletonRendererInstruction instruction, bool updateTriangles)
        {
            var val_7;
            float val_8;
            Spine.Unity.SkeletonRendererInstruction val_9;
            float val_11;
            float val_12;
            Spine.Unity.MeshGenerator val_70;
            System.Single[] val_71;
            float val_72;
            float val_73;
            float val_74;
            var val_75;
            var val_76;
            var val_77;
            var val_78;
            var val_79;
            var val_80;
            var val_81;
            var val_82;
            var val_83;
            if((instruction + 20) > (mem[1152921510885681432] + 8 + 12))
            {
                    System.Array.Resize<UnityEngine.Vector3>(array: ref  mem[1152921510885681432] + 8, newSize:  instruction + 20);
                val_70 = this;
                System.Array.Resize<UnityEngine.Vector2>(array: ref  mem[1152921510885681436] + 8, newSize:  instruction + 20);
                System.Array.Resize<UnityEngine.Color32>(array: ref  mem[1152921510885681440] + 8, newSize:  instruction + 20);
            }
            else
            {
                    val_70 = 1152921510885681436;
            }
            
            mem2[0] = instruction + 20;
            mem2[0] = instruction + 20;
            mem2[0] = instruction + 20;
            UnityEngine.Color val_4 = UnityEngine.Color.white;
            UnityEngine.Color32 val_5 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
            val_71 = mem[1152921510885681476];
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 9.696258E+32f, y = mem[1152921510885681448]});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 9.696298E+32f, y = mem[1152921510885681456]});
            val_72 = val_11;
            val_8 = val_12;
            val_73 = val_72;
            if((instruction + 12 + 12) < 1)
            {
                goto label_18;
            }
            
            var val_70 = mem[1152921510885681432] + 8;
            val_70 = val_70 + 24;
            Spine.Unity.SkeletonRendererInstruction val_71 = instruction;
            val_71 = val_71 + 16;
            label_168:
            var val_14 = (instruction + 12 + 8) + 0;
            val_72 = mem[(instruction + 12 + 8 + 0) + 16 + 20 + 8];
            val_72 = (instruction + 12 + 8 + 0) + 16 + 20 + 8;
            var val_73 = (instruction + 12 + 8 + 0) + 16 + 60;
            if(mem[1152921510885681425] == false)
            {
                goto label_36;
            }
            
            if(mem[1152921510885681496] != 0)
            {
                goto label_26;
            }
            
            Spine.ExposedList<UnityEngine.Vector2> val_15 = new Spine.ExposedList<UnityEngine.Vector2>();
            mem[1152921510885681496] = null;
            mem[1152921510885681500] = new Spine.ExposedList<UnityEngine.Vector2>();
            if(mem[1152921510885681496] == 0)
            {
                goto label_27;
            }
            
            label_26:
            val_70 = instruction + 20;
            System.Array.Resize<UnityEngine.Vector2>(array: ref  T[] val_17 = 265015304, newSize:  val_70);
            System.Array.Resize<UnityEngine.Vector2>(array: ref  T[] val_18 = 265015304, newSize:  val_70);
            typeof(Spine.ExposedList<T>).__il2cppRuntimeField_C = val_70;
            typeof(Spine.ExposedList<T>).__il2cppRuntimeField_C = val_70;
            if(((instruction + 12 + 8 + 0) + 20) < ((instruction + 12 + 8 + 0) + 24))
            {
                    float val_72 = (instruction + 12 + 8 + 0) + 20;
                do
            {
                var val_19 = val_72 + (val_72 << 2);
                if((((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16) != 0)
            {
                
            }
            
                if(1835037 != 0)
            {
                    val_70 = 386010363;
                if(val_70 >= 1)
            {
                    do
            {
                ExposedList<T>.__il2cppRuntimeField_10 = 35615780;
                ExposedList<T>.__il2cppRuntimeField_14 = 83886592;
                ExposedList<T>.__il2cppRuntimeField_10 = ((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 40;
                ExposedList<T>.__il2cppRuntimeField_14 = 1065353216;
            }
            while(2 < val_70);
            
            }
            
            }
            
                val_72 = val_72 + 1;
                val_72 = val_72;
            }
            while(val_72 != ((instruction + 12 + 8 + 0) + 24));
            
            }
            
            label_36:
            if(((instruction + 12 + 8 + 0) + 20) < ((instruction + 12 + 8 + 0) + 24))
            {
                    val_73 = val_73 * 255f;
                val_73 = val_73;
                val_71 = val_71;
                do
            {
                var val_20 = val_72 + (((instruction + 12 + 8 + 0) + 20) << 2);
                val_70 = mem[((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 48];
                val_70 = ((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 48;
                if(val_70 != 0)
            {
                    val_71 = val_71;
                if((mem[1152921510885681476] + 12) < (((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 48 + 24))
            {
                    mem[1152921510885681476] = null;
            }
            
                val_70.ComputeWorldVertices(slot:  ((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16, worldVertices:  533895840);
                var val_74 = ((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 28;
                var val_75 = ((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 16;
                val_74 = val_73 * val_74;
                val_75 = ((instruction + 12 + 8 + 0) + 16 + 48) * val_75;
                val_74 = val_74 * (((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 48 + 80);
                val_75 = val_75 * (((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 48 + 68);
                if((mem[1152921510885681476] + 12) < 0)
            {
                    (uint)val_74 = (int)val_74;
            }
            
                if(mem[1152921510885681424] != false)
            {
                    var val_76 = ((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 20;
                var val_77 = ((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 24;
                val_76 = ((instruction + 12 + 8 + 0) + 16 + 52) * val_76;
                val_77 = ((instruction + 12 + 8 + 0) + 16 + 56) * val_77;
                val_76 = val_76 * (((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 48 + 72);
                val_75 = val_75 * ((float)(int)(uint)val_74 & 255);
                val_77 = val_77 * (((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 48 + 76);
                val_76 = val_76 * ((float)(int)(uint)val_74 & 255);
                val_77 = val_77 * ((float)(int)(uint)val_74 & 255);
                if(mem[1152921510885681424] < 0)
            {
                    (uint)val_75 = (int)val_75;
            }
            
                if(mem[1152921510885681424] < 0)
            {
                    (uint)val_77 = (int)val_77;
            }
            
                if(mem[1152921510885681424] < 0)
            {
                    (uint)val_76 = (int)val_76;
            }
            
                if((((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 8) == 0)
            {
                    val_74 = (uint)val_75;
            }
            
                if((((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 8) != 0)
            {
                    (((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 8 + 56) - 1 = (uint)val_74;
            }
            
            }
            else
            {
                    var val_86 = ((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 20;
                val_75 = val_75 * 255f;
                var val_87 = ((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 24;
                val_86 = ((instruction + 12 + 8 + 0) + 16 + 52) * val_86;
                val_87 = ((instruction + 12 + 8 + 0) + 16 + 56) * val_87;
                val_86 = val_86 * (((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 48 + 72);
                val_87 = val_87 * (((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 48 + 76);
                val_86 = val_86 * 255f;
                val_87 = val_87 * 255f;
                if(mem[1152921510885681424] < 0)
            {
                    (uint)val_75 = (int)val_75;
            }
            
                if(mem[1152921510885681424] < 0)
            {
                    (uint)val_87 = (int)val_87;
            }
            
                if(mem[1152921510885681424] < 0)
            {
                    (uint)val_86 = (int)val_86;
            }
            
            }
            
                if(4 != 0)
            {
                
            }
            else
            {
                    val_74 = (uint)val_74;
                val_70 = (uint)val_75;
                if(System.Single[].__il2cppRuntimeField_namespaze > 1)
            {
                    val_73 = System.Single[].__il2cppRuntimeField_byval_arg;
            }
            
                if(System.Single[].__il2cppRuntimeField_namespaze < 0)
            {
                    mem[1152921510885681476] + 40 = System.Single[].__il2cppRuntimeField_byval_arg;
            }
            
                if(System.Single[].__il2cppRuntimeField_namespaze < 0)
            {
                    mem[1152921510885681476] + 44 = typeof(System.Single[]).__il2cppRuntimeField_14;
            }
            
            }
            
                if(2 >= 1)
            {
                    Spine.Unity.SkeletonRendererInstruction val_88 = val_71;
                val_88 = val_88 + 16;
                val_9 = val_88;
                var val_89 = mem[1152921510885681432] + 8;
                val_89 = val_89 + 32;
                val_8 = val_89;
                var val_90 = (int)(uint)val_86 & 255;
                val_90 = ((int)val_70 & 255) | (val_90 << 8);
                val_90 = val_90 | (((int)(uint)val_87 & 255) << 16);
                val_90 = val_90 | (val_74 << 24);
                val_7 = val_90;
                do
            {
                mem2[0] = System.Single[].__il2cppRuntimeField_byval_arg;
                mem2[0] = typeof(System.Single[]).__il2cppRuntimeField_14;
                mem2[0] = mem[1152921510885681420] * ((float)(instruction + 12 + 8 + 0) + 20);
                mem2[0] = val_7;
                var val_36 = (((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 48 + 56) + 0;
                var val_37 = val_8 + 0;
                mem2[0] = (((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 48 + 56 + 0) + 16;
                val_71 = null;
                mem2[0] = (((instruction + 12 + 8 + 0) + 16 + 20 + 8 + ((instruction + 12 + 8 + 0) + 20) << 2) + 16 + 48 + 56 + 0) + 20;
                if((mem[1152921510885681432] + 8 + 12) < 0)
            {
                
            }
            else
            {
                    if((mem[1152921510885681432] + 8 + 12) > 4)
            {
                    val_73 = System.Single[].__il2cppRuntimeField_byval_arg;
            }
            
            }
            
                if((mem[1152921510885681432] + 8 + 12) < 0)
            {
                
            }
            else
            {
                    if((mem[1152921510885681432] + 8 + 12) > 4)
            {
                     = typeof(System.Single[]).__il2cppRuntimeField_14;
            }
            
            }
            
                val_70 = 1152921505140742840;
                val_74 = (val_70 + 48) + 12;
            }
            while(2 < 2);
            
                val_8 = ;
            }
            else
            {
                    val_8 = ;
                val_71 = null;
            }
            
                var val_91 = (instruction + 12 + 8 + 0) + 20;
            }
            
                val_72 = val_72;
                val_91 = val_91 + 1;
            }
            while(val_91 != ((instruction + 12 + 8 + 0) + 24));
            
            }
            else
            {
                    val_71 = null;
            }
            
            if(1 != (instruction + 12 + 12))
            {
                goto label_168;
            }
            
            goto label_169;
            label_18:
            label_169:
            UnityEngine.Vector2 val_38 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 9.696267E+32f, y = System.Single[].__il2cppRuntimeField_byval_arg, z = typeof(System.Single[]).__il2cppRuntimeField_14});
            mem[1152921510885681448] = mem[1152921510885681432] + 8;
            mem[1152921510885681452] = 2;
            UnityEngine.Vector2 val_39 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 9.696258E+32f, y = val_73, z = val_8});
            mem[1152921510885681456] = val_7;
            mem[1152921510885681460] = val_8;
            mem[1152921510885681464] = mem[1152921510885681420] * 0f;
            if(updateTriangles == false)
            {
                    return;
            }
            
            val_9 = instruction + 12 + 12;
            if((mem[1152921510885681444] + 12) < (instruction + 12 + 12))
            {
                    Spine.ExposedList<T> val_41 = mem[1152921510885681444].Resize(newSize:  val_9);
                if(val_9 >= 1)
            {
                    var val_92 = 0;
                val_74 = 1152921510781516192;
                val_72 = 1152921510774656032;
                do
            {
                var val_42 = (mem[1152921510885681444] + 8) + 0;
                if(((mem[1152921510885681444] + 8 + 0) + 16) != 0)
            {
                    (mem[1152921510885681444] + 8 + 0) + 16.Clear(clearArray:  false);
            }
            else
            {
                    Spine.ExposedList<System.Int32> val_43 = null;
                val_71 = mem[mem[1152921510885681444] + 8];
                val_71 = mem[1152921510885681444] + 8;
                val_43 = new Spine.ExposedList<System.Int32>();
                var val_44 = val_71 + 0;
                mem2[0] = val_43;
            }
            
                val_92 = val_92 + 1;
            }
            while(val_9 != val_92);
            
            }
            
            }
            
            val_70 = this;
            if(val_9 < 1)
            {
                    return;
            }
            
            label_238:
            var val_45 = 0 + 0;
            val_45 = (instruction + 12 + 8) + (val_45 << 3);
            var val_46 = (mem[1152921510885681444] + 8) + 0;
            if(((instruction + 12 + 8 + ((0 + 0)) << 3) + 40) <= ((mem[1152921510885681444] + 8 + 0) + 16 + 8 + 12))
            {
                goto label_200;
            }
            
            System.Array.Resize<System.Int32>(array: ref  (mem[1152921510885681444] + 8 + 0) + 16 + 8, newSize:  (instruction + 12 + 8 + ((0 + 0)) << 3) + 40);
            goto label_205;
            label_200:
            if(((instruction + 12 + 8 + ((0 + 0)) << 3) + 40) >= ((mem[1152921510885681444] + 8 + 0) + 16 + 8 + 12))
            {
                goto label_205;
            }
            
            val_75 = mem[(mem[1152921510885681444] + 8 + 0) + 16 + 8 + 12];
            val_75 = (mem[1152921510885681444] + 8 + 0) + 16 + 8 + 12;
            if(((instruction + 12 + 8 + ((0 + 0)) << 3) + 40) >= val_75)
            {
                goto label_205;
            }
            
            val_76 = (instruction + 12 + 8 + ((0 + 0)) << 3) + 40;
            goto label_206;
            label_208:
            val_76 = val_76 + 1;
            val_75 = mem[(mem[1152921510885681444] + 8 + 0) + 16 + 8 + 12];
            val_75 = (mem[1152921510885681444] + 8 + 0) + 16 + 8 + 12;
            label_206:
            var val_49 = ((mem[1152921510885681444] + 8 + 0) + 16 + 8) + (val_76 << 2);
            mem2[0] = 0;
            if((val_75 - 1) != val_76)
            {
                goto label_208;
            }
            
            label_205:
            if(((mem[1152921510885681444] + 8 + 0) + 16) != 0)
            {
                    mem2[0] = (instruction + 12 + 8 + ((0 + 0)) << 3) + 40;
            }
            else
            {
                    mem[12] = (instruction + 12 + 8 + ((0 + 0)) << 3) + 40;
            }
            
            val_70 = this;
            val_74 = 1152921504871436288;
            val_77 = mem[(mem[1152921510885681444] + 8 + 0) + 16 + 8];
            val_77 = (mem[1152921510885681444] + 8 + 0) + 16 + 8;
            val_73 = instruction + 12 + 8;
            if(((instruction + 12 + 8 + ((0 + 0)) << 3) + 16) == 0)
            {
                    val_77 = val_77;
            }
            
            val_78 = (instruction + 12 + 8 + ((0 + 0)) << 3) + 20;
            if(((instruction + 12 + 8 + ((0 + 0)) << 3) + 16 + 20) == 0)
            {
                    val_77 = val_77;
            }
            
            val_71 = (instruction + 12 + 8 + ((0 + 0)) << 3) + 24;
            if(val_78 >= val_71)
            {
                goto label_213;
            }
            
            val_8 = val_77 + 16;
            label_237:
            if(((instruction + 12 + 8 + ((0 + 0)) << 3) + 16 + 20 + 8) == 0)
            {
                    val_77 = val_77;
            }
            
            if(((instruction + 12 + 8 + ((0 + 0)) << 3) + 16 + 20 + 8 + 12) <= val_78)
            {
                    val_77 = val_77;
            }
            
            var val_51 = ((instruction + 12 + 8 + ((0 + 0)) << 3) + 16 + 20 + 8) + (val_78 << 2);
            if((((instruction + 12 + 8 + ((0 + 0)) << 3) + 16 + 20 + 8 + ((instruction + 12 + 8 + ((0 + 0)) << 3) + 20) << 2) + 16) == 0)
            {
                    val_77 = val_77;
            }
            
            if((((instruction + 12 + 8 + ((0 + 0)) << 3) + 16 + 20 + 8 + ((instruction + 12 + 8 + ((0 + 0)) << 3) + 20) << 2) + 16 + 48) == 0)
            {
                goto label_217;
            }
            
            val_71 = (instruction + 12 + 8 + ((0 + 0)) << 3) + 24;
            val_79 = ((instruction + 12 + 8 + ((0 + 0)) << 3) + 16 + 20 + 8 + ((instruction + 12 + 8 + ((0 + 0)) << 3) + 20) << 2) + 16 + 48;
            if((((instruction + 12 + 8 + ((0 + 0)) << 3) + 16 + 20 + 8 + ((instruction + 12 + 8 + ((0 + 0)) << 3) + 20) << 2) + 16 + 48 + 64) == 0)
            {
                    val_79 = ((instruction + 12 + 8 + ((0 + 0)) << 3) + 16 + 20 + 8 + ((instruction + 12 + 8 + ((0 + 0)) << 3) + 20) << 2) + 16 + 48;
                val_80 = val_77;
            }
            
            if((((instruction + 12 + 8 + ((0 + 0)) << 3) + 16 + 20 + 8 + ((instruction + 12 + 8 + ((0 + 0)) << 3) + 20) << 2) + 16 + 48 + 64 + 12) < 1)
            {
                goto label_223;
            }
            
            var val_52 = (((instruction + 12 + 8 + ((0 + 0)) << 3) + 16 + 20 + 8 + ((instruction + 12 + 8 + ((0 + 0)) << 3) + 20) << 2) + 16 + 48 + 64) + 16;
            val_81 = 0;
            var val_54 = val_8 + 0;
            val_82 = ((instruction + 12 + 8 + ((0 + 0)) << 3) + 16 + 20 + 8 + ((instruction + 12 + 8 + ((0 + 0)) << 3) + 20) << 2) + 16 + 48 + 64 + 12;
            goto label_224;
            label_228:
            val_81 = 1;
            val_82 = mem[((instruction + 12 + 8 + ((0 + 0)) << 3) + 16 + 20 + 8 + ((instruction + 12 + 8 + ((0 + 0)) << 3) + 20) << 2) + 16 + 48 + 64 + 12];
            val_82 = ((instruction + 12 + 8 + ((0 + 0)) << 3) + 16 + 20 + 8 + ((instruction + 12 + 8 + ((0 + 0)) << 3) + 20) << 2) + 16 + 48 + 64 + 12;
            label_224:
            if(val_82 <= val_81)
            {
                    val_80 = val_77;
            }
            
            var val_93 = (((instruction + 12 + 8 + ((0 + 0)) << 3) + 16 + 20 + 8 + ((instruction + 12 + 8 + ((0 + 0)) << 3) + 20) << 2) + 16 + 48 + 64 + 16) + 4;
            var val_55 = 0 + val_81;
            if(val_80 == 0)
            {
                    val_80 = val_77;
            }
            
            val_93 = val_93 + 0;
            mem2[0] = val_93;
            if(((((instruction + 12 + 8 + ((0 + 0)) << 3) + 16 + 20 + 8 + ((instruction + 12 + 8 + ((0 + 0)) << 3) + 20) << 2) + 16 + 48 + 64 + 12) - 1) != val_81)
            {
                goto label_228;
            }
            
            var val_94 = 0;
            val_73 = instruction + 12 + 8;
            val_94 = val_94 + (((instruction + 12 + 8 + ((0 + 0)) << 3) + 16 + 20 + 8 + ((instruction + 12 + 8 + ((0 + 0)) << 3) + 20) << 2) + 16 + 48 + 64 + 12);
            val_83 = val_78;
            val_71 = (instruction + 12 + 8 + ((0 + 0)) << 3) + 24;
            val_79 = ((instruction + 12 + 8 + ((0 + 0)) << 3) + 16 + 20 + 8 + ((instruction + 12 + 8 + ((0 + 0)) << 3) + 20) << 2) + 16 + 48;
            label_223:
            var val_95 = 0;
            val_70 = this;
            val_95 = val_95 + ((((instruction + 12 + 8 + ((0 + 0)) << 3) + 16 + 20 + 8 + ((instruction + 12 + 8 + ((0 + 0)) << 3) + 20) << 2) + 16 + 48 + 24) >> 1);
            val_74 = 1152921504871436288;
            goto label_229;
            label_217:
            label_229:
            val_72 =  + 1;
            if(val_72 != )
            {
                goto label_237;
            }
            
            label_213:
            var val_98 = 0;
            val_98 = val_98 + 1;
            if(val_98 != val_9)
            {
                goto label_238;
            }
            
            return;
            label_27:
        }
        public void ScaleVertexData(float scale)
        {
            float val_3;
            var val_4;
            var val_6;
            var val_8;
            var val_9;
            if(this.vertexBuffer != 0)
            {
                goto label_1;
            }
            
            this.vertexBuffer = this.vertexBuffer;
            if(this.vertexBuffer == 0)
            {
                goto label_2;
            }
            
            label_1:
            if(R1 >= 1)
            {
                    var val_10 = 0;
                var val_1 = R8 + 24;
                do
            {
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 9.798822E+32f, y = (R8 + 24) + -8, z = (R8 + 24) + -4}, d:  scale);
                val_10 = val_10 + 1;
                mem2[0] = val_4;
                mem2[0] = val_3;
                val_1 = val_1 + 12;
            }
            while(R1 != val_10);
            
            }
            
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 9.798822E+32f, y = mem[1152921510885813928]}, d:  val_2.x);
            mem[1152921510885813928] = val_3;
            mem[1152921510885813932] = val_6;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 9.798815E+32f, y = mem[1152921510885813936]}, d:  val_5.x);
            float val_11 = mem[1152921510885813944];
            val_11 = val_11 * R1;
            mem[1152921510885813936] = val_8;
            mem[1152921510885813940] = val_9;
            mem[1152921510885813944] = val_11;
            return;
            label_2:
        }
        private void AddAttachmentTintBlack(float r2, float g2, float b2, int vertexCount)
        {
            var val_5;
            var val_10;
            Spine.ExposedList<UnityEngine.Vector2> val_11;
            var val_12;
            Spine.ExposedList<UnityEngine.Vector2> val_13;
            Spine.ExposedList<UnityEngine.Vector2> val_14;
            var val_15;
            val_10 = this;
            var val_11 = R3;
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  r2, y:  g2);
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  r2, y:  g2);
            val_11 = this.uv2;
            if(val_11 != 0)
            {
                goto label_2;
            }
            
            this.uv2 = new Spine.ExposedList<UnityEngine.Vector2>();
            val_11 = this.uv2;
            this.uv3 = new Spine.ExposedList<UnityEngine.Vector2>();
            if(val_11 == 0)
            {
                goto label_3;
            }
            
            label_2:
            int val_6 = val_11 + val_5;
            if(val_6 > (public System.Void Spine.ExposedList<Spine.Unity.SubmeshInstruction>::.ctor(int capacity)))
            {
                    System.Array.Resize<UnityEngine.Vector2>(array: ref  this.uv2 + 8, newSize:  val_6);
                val_13 = val_10;
                System.Array.Resize<UnityEngine.Vector2>(array: ref  this.uv3 + 8, newSize:  val_6);
                val_12 = val_11;
            }
            else
            {
                    val_13 = this.uv3;
            }
            
            val_14 = this.uv2;
            mem2[0] = val_6;
            mem2[0] = val_6;
            if(val_5 < 1)
            {
                    return;
            }
            
            var val_10 = this.uv3.version + 8;
            val_10 = val_10 + (val_11 << 3);
            do
            {
                val_13 = R2;
                val_10 = val_11;
                val_11 = val_11 + 0;
                var val_12 = R2 + (val_11 << 3);
                val_12 = val_12 + 0;
                mem2[0] = val_1.x;
                var val_13 = val_10;
                val_12 = val_10;
                val_15 = val_13;
                val_13 = val_13 + 0;
                val_14 = 0 + 1;
                mem2[0] = val_2.x;
            }
            while(val_5 != val_14);
            
            return;
            label_3:
        }
        public void FillVertexData(UnityEngine.Mesh mesh)
        {
            var val_2;
            var val_5;
            float val_9;
            float val_12;
            float val_15;
            float val_19;
            float val_20;
            float val_21;
            float val_27;
            Spine.ExposedList<Spine.ExposedList<System.Int32>> val_28;
            Spine.ExposedList<UnityEngine.Vector3> val_29;
            Spine.Unity.MeshGenerator val_30;
            UnityEngine.Vector3[] val_31;
            float val_32;
            UnityEngine.Mesh val_33;
            float val_34;
            var val_35;
            val_28 = this.submeshes;
            if(this.submeshes != 0)
            {
                goto label_4;
            }
            
            val_28 = this.submeshes;
            if(val_28 == 0)
            {
                goto label_7;
            }
            
            label_4:
            val_29 = this.vertexBuffer;
            if(this.vertexBuffer != 0)
            {
                goto label_6;
            }
            
            val_29 = this.vertexBuffer;
            if(val_29 == 0)
            {
                goto label_7;
            }
            
            label_6:
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            if(this < R7)
            {
                    var val_6 = (SB + 2337972736) + 16;
                do
            {
                mem2[0] = val_2;
                val_6 = val_6 + 12;
            }
            while(R7 != 1152921510886215041);
            
            }
            
            if(mesh != 0)
            {
                    mesh.vertices = SB;
                mesh.uv = null;
            }
            else
            {
                    0.vertices = SB;
                0.uv = null;
            }
            
            val_30 = this;
            mesh.colors32 = ???;
            val_31 = mesh;
            if((System.Single.IsInfinity(f:  val_1.x)) != false)
            {
                    val_32 = ???;
                val_33 = val_31;
                val_33.bounds = new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Extents = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}};
            }
            else
            {
                    UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 1.010918E+33f, y = mem[1152921510886215088]}, b:  new UnityEngine.Vector2() {x = mem[1152921510886215092], y = this.meshBoundsMin});
                UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 1.010917E+33f, y = val_9}, d:  val_8.x);
                UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 1.010916E+33f, y = this.meshBoundsMin}, b:  new UnityEngine.Vector2() {y = val_12});
                UnityEngine.Vector3 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 1.010918E+33f, y = val_15});
                0.center = new UnityEngine.Vector3();
                float val_29 = 0.5f;
                val_29 = mem[1152921510886215096] * val_29;
                UnityEngine.Vector3 val_18 = new UnityEngine.Vector3(x:  val_29, y:  val_17.y, z:  mem[1152921510886215096]);
                0.extents = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
                val_33 = mesh;
                val_34 = val_19;
                val_27 = val_20;
                val_31 = 0;
                if(val_33 == 0)
            {
                    val_34 = val_34;
            }
            
                val_33.bounds = new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = 0f, y = val_34, z = val_27}, m_Extents = new UnityEngine.Vector3() {x = val_21, y = 0f, z = 0f}};
                val_32 = ???;
                val_30 = this;
            }
            
            if(mem[1152921510886215059] != false)
            {
                    val_31 = mem[1152921510886215116];
                if(val_31 != 0)
            {
                    val_35 = mem[mem[1152921510886215116] + 12];
                val_35 = mem[1152921510886215116] + 12;
            }
            else
            {
                    val_31 = null;
                mem[1152921510886215116] = null;
                val_35 = 0;
            }
            
                if(val_35 < 0)
            {
                    System.Array.Resize<UnityEngine.Vector3>(array: ref  T[] val_22 = 1984400844, newSize:  0);
                var val_23 = val_35 + 0;
                val_23 = mem[1152921510886215116] + (val_23 << 2);
                var val_24 = val_23 + 16;
                do
            {
                UnityEngine.Vector3 val_25 = UnityEngine.Vector3.back;
                val_27 = val_5;
                val_35 = val_35 + 1;
                val_32 = ???;
                mem2[0] = val_27;
                val_24 = val_24 + 12;
            }
            while(0 != val_35);
            
                val_33 = mesh;
                val_31 = null;
            }
            
                val_33.normals = val_31;
                val_30 = this;
            }
            
            if(mem[1152921510886215057] != false)
            {
                    val_33.uv2 = mem[1152921510886215128] + 8;
                val_31 = mem[mem[1152921510886215132] + 8];
                val_31 = mem[1152921510886215132] + 8;
                val_33.uv3 = val_31;
            }
            
            if(mem[1152921510886215058] == false)
            {
                    return;
            }
            
            val_27 = 1152921510886215124;
            Spine.Unity.MeshGenerator.SolveTangents2DEnsureSize(tangentBuffer: ref  UnityEngine.Vector4[] val_26 = 1984400848, tempTanBuffer: ref  UnityEngine.Vector2[] val_27 = 1984400852, vertexCount:  0);
            if(val_28 >= 1)
            {
                    var val_28 = val_32 + 16;
                var val_30 = 0;
                do
            {
                val_31 = mem[(val_32 + 16) + 0 + 8];
                val_31 = (val_32 + 16) + 0 + 8;
                val_30 = mem[(val_32 + 16) + 0];
                val_30 = (val_32 + 16) + 0;
                Spine.Unity.MeshGenerator.SolveTangents2DTriangles(tempTanBuffer:  this.tempTanBuffer, triangles:  val_31, triangleCount:  (val_32 + 16) + 0 + 12, vertices:  ???, uvs:  0, vertexCount:  0);
                val_30 = val_30 + 1;
            }
            while(val_28 != val_30);
            
            }
            
            Spine.Unity.MeshGenerator.SolveTangents2DBuffer(tangents:  this.tangents, tempTanBuffer:  this.tempTanBuffer, vertexCount:  0);
            mesh.tangents = this.tangents;
            return;
            label_7:
        }
        public void FillTriangles(UnityEngine.Mesh mesh)
        {
            Spine.ExposedList<Spine.ExposedList<System.Int32>> val_1;
            Spine.ExposedList<Spine.ExposedList<System.Int32>> val_2;
            val_1 = this.submeshes;
            val_2 = val_1;
            if(val_1 != 0)
            {
                goto label_0;
            }
            
            val_2 = this.submeshes;
            if(val_2 == 0)
            {
                goto label_1;
            }
            
            label_0:
            mesh.subMeshCount = R8;
            if(R8 < 1)
            {
                    return;
            }
            
            do
            {
                mesh.SetTriangles(triangles:  R7 + 8, submesh:  0, calculateBounds:  false);
                val_1 = 0 + 1;
            }
            while(R8 != val_1);
            
            return;
            label_1:
        }
        public void FillTrianglesSingle(UnityEngine.Mesh mesh)
        {
            mesh.SetTriangles(triangles:  this.submeshes, submesh:  0, calculateBounds:  false);
        }
        public void TrimExcess()
        {
            this.vertexBuffer.TrimExcess();
            this.uvBuffer.TrimExcess();
            this.colorBuffer.TrimExcess();
            if(this.uv2 != 0)
            {
                    this.uv2.TrimExcess();
            }
            
            if(this.uv3 != 0)
            {
                    this.uv3.TrimExcess();
            }
            
            if(this.normals != null)
            {
                    System.Array.Resize<UnityEngine.Vector3>(array: ref  T[] val_1 = 1984982604, newSize:  this.vertexBuffer);
            }
            
            if(this.tangents == null)
            {
                    return;
            }
            
            System.Array.Resize<UnityEngine.Vector4>(array: ref  T[] val_2 = 1984982608, newSize:  this.vertexBuffer);
        }
        internal static void SolveTangents2DEnsureSize(ref UnityEngine.Vector4[] tangentBuffer, ref UnityEngine.Vector2[] tempTanBuffer, int vertexCount)
        {
            if(tangentBuffer != null)
            {
                    if((mem[tangentBuffer + 12]) >= vertexCount)
            {
                goto label_2;
            }
            
            }
            
            tangentBuffer = null;
            label_2:
            if(tempTanBuffer != null)
            {
                    if((mem[tempTanBuffer + 12]) >= (vertexCount << 1))
            {
                    return;
            }
            
            }
            
            int val_1 = vertexCount << 1;
            tempTanBuffer = null;
        }
        internal static void SolveTangents2DTriangles(UnityEngine.Vector2[] tempTanBuffer, int[] triangles, int triangleCount, UnityEngine.Vector3[] vertices, UnityEngine.Vector2[] uvs, int vertexCount)
        {
            if(triangleCount < 1)
            {
                    return;
            }
            
            do
            {
                int val_22 = triangles[0];
                int val_23 = triangles[0];
                int val_24 = triangles[0];
                UnityEngine.Vector3 val_25 = vertices[val_22 + (val_22 << 1)];
                UnityEngine.Vector3 val_26 = vertices[val_22 + (val_22 << 1)];
                UnityEngine.Vector3 val_27 = vertices[val_23 + (val_23 << 1)];
                UnityEngine.Vector3 val_28 = vertices[val_23 + (val_23 << 1)];
                var val_37 = uvs[val_22 << 3];
                System.Int32[] val_36 = triangles;
                UnityEngine.Vector2 val_6 = (uvs[val_23 << 3]) - val_37;
                UnityEngine.Vector2 val_7 = (uvs[val_24 << 3]) - val_36;
                UnityEngine.Vector2 val_8 = (uvs[val_24 << 3]) - val_37;
                val_36 = (uvs[val_23 << 3]) - val_36;
                val_27 = val_27 - val_25;
                val_28 = val_28 - val_26;
                val_26 = (vertices[val_24 + (val_24 << 1)]) - val_26;
                val_37 = val_6 * val_7;
                val_25 = (vertices[val_24 + (val_24 << 1)]) - val_25;
                if((vertices[val_24 + (val_24 << 1)]) == val_24)
            {
                    1f / val_37 = 0;
            }
            
                UnityEngine.Vector3 val_12 = (val_28 * val_7) * (1f / val_37);
                UnityEngine.Vector3 val_13 = (val_27 * val_7) * (1f / val_37);
                tempTanBuffer[val_24 << 3] = val_13;
                tempTanBuffer[val_24 << 3] = val_12;
                tempTanBuffer[val_23 << 3] = val_13;
                tempTanBuffer[val_23 << 3] = val_12;
                tempTanBuffer[val_22 << 3] = val_13;
                tempTanBuffer[val_22 << 3] = val_12;
                UnityEngine.Vector3 val_17 = (val_26 * val_6) * (1f / val_37);
                UnityEngine.Vector3 val_18 = (val_25 * val_6) * (1f / val_37);
                tempTanBuffer[(val_24 + vertexCount) << 3] = val_18;
                tempTanBuffer[(val_24 + vertexCount) << 3] = val_17;
                tempTanBuffer[(val_23 + vertexCount) << 3] = val_18;
                tempTanBuffer[(val_23 + vertexCount) << 3] = val_17;
                tempTanBuffer[(val_22 + vertexCount) << 3] = val_18;
                tempTanBuffer[(val_22 + vertexCount) << 3] = val_17;
            }
            while((((0 + 1) + 1) + 1) < triangleCount);
        
        }
        internal static void SolveTangents2DBuffer(UnityEngine.Vector4[] tangents, UnityEngine.Vector2[] tempTanBuffer, int vertexCount)
        {
            UnityEngine.Vector4 val_3;
            UnityEngine.Vector4 val_4;
            UnityEngine.Vector4 val_5;
            if(vertexCount < 1)
            {
                    return;
            }
            
            int val_3 = vertexCount;
            var val_7 = 28;
            val_3 = val_3 << 3;
            var val_6 = 0;
            do
            {
                float val_1 = R5 * R5;
                val_5 = val_1;
                val_5 = 1f / val_5;
                val_1 = val_5 * R5;
                val_5 = val_5 * 533908128;
                val_4 = val_1;
                val_3 = val_5;
                int val_4 = vertexCount;
                val_4 = val_4 + val_6;
                var val_5 = val_3;
                float val_2 = val_4 * 1152921505140755104;
                val_5 = val_5 * S4;
                if(val_1 > val_4)
            {
                    -1f = 1f;
            }
            
                val_6 = val_6 + 1;
                tangents[0] = val_3;
                tangents[0] = val_4;
                tangents[0] = 0;
                val_7 = val_7 + 16;
                mem2[0] = -1f;
            }
            while(vertexCount != val_6);
        
        }
        public MeshGenerator()
        {
            this.settings = 1;
            mem[1152921510887804684] = 0;
            mem[1152921510887804688] = 1;
            mem[1152921510887804692] = 0;
            Spine.ExposedList<UnityEngine.Vector3> val_1 = new Spine.ExposedList<UnityEngine.Vector3>(capacity:  4);
            this.vertexBuffer = null;
            Spine.ExposedList<UnityEngine.Vector2> val_2 = new Spine.ExposedList<UnityEngine.Vector2>(capacity:  4);
            this.uvBuffer = null;
            Spine.ExposedList<UnityEngine.Color32> val_3 = new Spine.ExposedList<UnityEngine.Color32>(capacity:  4);
            this.colorBuffer = null;
            Spine.ExposedList<UnityEngine.Material> val_4 = new Spine.ExposedList<UnityEngine.Material>();
            Spine.ExposedList<System.Int32> val_5 = new Spine.ExposedList<System.Int32>(capacity:  6);
            Add(item:  265015296);
            this.submeshes = null;
            this.clipper = new Spine.SkeletonClipping();
            this.tempVerts = null;
            this.regionTriangles = null;
        }
    
    }

}
