using UnityEngine;

namespace Spine
{
    internal class Triangulator
    {
        // Fields
        private readonly Spine.ExposedList<Spine.ExposedList<float>> convexPolygons;
        private readonly Spine.ExposedList<Spine.ExposedList<int>> convexPolygonsIndices;
        private readonly Spine.ExposedList<int> indicesArray;
        private readonly Spine.ExposedList<bool> isConcaveArray;
        private readonly Spine.ExposedList<int> triangles;
        private readonly Spine.Pool<Spine.ExposedList<float>> polygonPool;
        private readonly Spine.Pool<Spine.ExposedList<int>> polygonIndicesPool;
        
        // Methods
        public Spine.ExposedList<int> Triangulate(Spine.ExposedList<float> verticesArray)
        {
            int val_35;
            float val_36;
            float val_37;
            Spine.ExposedList<System.Int32> val_38;
            var val_39;
            Spine.ExposedList<System.Int32> val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            Spine.ExposedList<System.Int32> val_47;
            Spine.ExposedList<System.Int32> val_48;
            val_35 = this;
            if(verticesArray != 0)
            {
                
            }
            else
            {
                    val_36 = 0f;
            }
            
            val_37 = 0;
            if(this.indicesArray != 0)
            {
                    this.indicesArray.Clear(clearArray:  true);
            }
            else
            {
                    0.Clear(clearArray:  true);
            }
            
            Spine.ExposedList<T> val_1 = this.indicesArray.Resize(newSize:  4);
            if(8 >= 2)
            {
                    var val_44 = 0;
                Spine.ExposedList<System.Int32> val_2 = this.indicesArray + 16;
                do
            {
                mem2[0] = val_44;
                val_44 = val_44 + 1;
            }
            while(val_44 < val_37);
            
            }
            
            Spine.ExposedList<T> val_3 = this.isConcaveArray.Resize(newSize:  4);
            val_38 = this.indicesArray;
            if(8 >= 2)
            {
                    do
            {
                mem[16] = Spine.Triangulator.IsConcave(index:  0, vertexCount:  4, vertices:  null, indices:  val_38);
                val_39 = 0 + 1;
            }
            while(val_39 < val_37);
            
            }
            
            this.triangles.Clear(clearArray:  true);
            int val_5 = val_37 - 2;
            val_40 = this.triangles;
            val_5 = (System.Math.Max(val1:  0, val2:  val_5)) << 2;
            val_40.EnsureCapacity(min:  val_5);
            if(8 < 8)
            {
                goto label_20;
            }
            
            label_65:
            val_40 = val_37;
            val_37 = val_37 - 1;
            label_25:
            val_41 = 0;
            var val_7 = val_36 + val_41;
            if(((val_36 + val_41) + 16) == 0)
            {
                goto label_23;
            }
            
            if(1 == 0)
            {
                goto label_28;
            }
            
            var val_8 = 1 + 1;
            goto label_25;
            label_28:
            var val_9 = val_36 + val_41;
            if(((val_36 + val_41) + 16) == 0)
            {
                goto label_29;
            }
            
            val_41 = val_41 - 1;
            if(val_41 >= 1)
            {
                goto label_28;
            }
            
            goto label_29;
            label_23:
            val_42 = mem[this.indicesArray + 12];
            val_42 = this.indicesArray + 12;
            if(val_42 <= val_37)
            {
                    val_42 = mem[this.indicesArray + 12];
                val_42 = this.indicesArray + 12;
            }
            
            Spine.ExposedList<System.Int32> val_10 = val_38 + (val_37 << 2);
            if(val_42 <= val_41)
            {
                    val_42 = mem[this.indicesArray + 12];
                val_42 = this.indicesArray + 12;
            }
            
            Spine.ExposedList<System.Int32> val_11 = val_38 + 0;
            Spine.ExposedList<System.Int32> val_45 = this.indicesArray;
            var val_12 = ((this.indicesArray + ((val_37 - 1)) << 2) + 16) << 1;
            val_45 = val_45 + 4;
            val_43 = 0;
            if(val_43 <= val_12)
            {
                    val_43 = 0;
            }
            
            val_44 = ((this.indicesArray + 0) + 16) << 1;
            var val_13 = val_36 + (val_12 << 2);
            val_12 = val_12 | 1;
            if(val_43 <= val_12)
            {
                    val_44 = val_44;
                val_43 = 0;
            }
            
            var val_14 = val_36 + (val_12 << 2);
            if(val_43 <= val_44)
            {
                    var val_46 = val_44;
                val_43 = 0;
                val_44 = val_46;
            }
            
            val_46 = val_44 | 1;
            val_45 = ((this.indicesArray + 4) + 16) << 1;
            var val_15 = val_36 + (val_44 << 2);
            if(val_43 <= val_46)
            {
                    val_45 = val_45;
                val_43 = 0;
            }
            
            var val_16 = val_36 + (val_46 << 2);
            if(val_43 <= val_45)
            {
                    var val_47 = val_45;
                val_43 = 0;
                val_45 = val_47;
            }
            
            var val_17 = val_36 + (val_45 << 2);
            val_47 = val_45 | 1;
            var val_18 = val_36 + (val_47 << 2);
            var val_19 = 1 + 1;
            if(val_40 != val_37)
            {
                goto label_41;
            }
            
            val_38 = this.indicesArray;
            goto label_52;
            label_41:
            float val_20 = ((val_36 + ((((this.indicesArray + 4) + 16 << 1) | 1)) << 2) + 16) - ((val_36 + ((((this.indicesArray + 0) + 16 << 1) | 1)) << 2) + 16);
            val_38 = this.indicesArray;
            float val_21 = ((val_36 + ((((this.indicesArray + 0) + 16 << 1) | 1)) << 2) + 16) - ((val_36 + ((((this.indicesArray + ((val_37 - 1)) << 2) + 16 << 1) | 1)) << 2) + 16);
            float val_22 = ((val_36 + ((((this.indicesArray + ((val_37 - 1)) << 2) + 16 << 1) | 1)) << 2) + 16) - ((val_36 + ((((this.indicesArray + 4) + 16 << 1) | 1)) << 2) + 16);
            label_53:
            var val_23 = val_36 + val_40;
            if(((val_36 + val_40) + 16) == 0)
            {
                goto label_51;
            }
            
            Spine.ExposedList<System.Int32> val_24 = val_38 + 16;
            var val_25 = ((this.indicesArray + 16) + 16) << 1;
            val_46 = 0;
            if(val_46 <= val_25)
            {
                    val_46 = 0;
            }
            
            var val_26 = val_36 + (val_25 << 2);
            val_25 = val_25 | 1;
            var val_27 = val_36 + (val_25 << 2);
            val_38 = this.indicesArray;
            var val_48 = (val_36 + ((((this.indicesArray + 16) + 16 << 1) | 1)) << 2) + 16;
            float val_28 = ((val_36 + ((((this.indicesArray + 4) + 16 << 1) | 1)) << 2) + 16) - val_48;
            float val_29 = val_48 - ((val_36 + ((((this.indicesArray + ((val_37 - 1)) << 2) + 16 << 1) | 1)) << 2) + 16);
            val_28 = ((val_36 + (((this.indicesArray + ((val_37 - 1)) << 2) + 16 << 1)) << 2) + 16) * val_28;
            if(val_46 < val_25)
            {
                goto label_51;
            }
            
            float val_30 = ((val_36 + ((((this.indicesArray + ((val_37 - 1)) << 2) + 16 << 1) | 1)) << 2) + 16) - val_48;
            float val_31 = val_48 - ((val_36 + ((((this.indicesArray + 0) + 16 << 1) | 1)) << 2) + 16);
            val_30 = ((val_36 + (((this.indicesArray + 0) + 16 << 1)) << 2) + 16) * val_30;
            if(val_46 < val_25)
            {
                goto label_51;
            }
            
            float val_32 = ((val_36 + ((((this.indicesArray + 0) + 16 << 1) | 1)) << 2) + 16) - val_48;
            val_48 = val_48 - ((val_36 + ((((this.indicesArray + 4) + 16 << 1) | 1)) << 2) + 16);
            val_32 = ((val_36 + (((this.indicesArray + 4) + 16 << 1)) << 2) + 16) * val_32;
            if(val_46 >= val_25)
            {
                goto label_52;
            }
            
            label_51:
            var val_33 = val_40 + 1;
            if(val_40 != val_37)
            {
                goto label_53;
            }
            
            label_52:
            val_37 = val_37;
            label_29:
            Spine.ExposedList<System.Int32> val_35 = val_38 + 16;
            this.triangles.Add(item:  (this.indicesArray + 16) + 16);
            Spine.ExposedList<System.Int32> val_36 = val_38 + 0;
            this.triangles.Add(item:  (this.indicesArray + 0) + 16);
            var val_37 = val_41 + 1;
            Spine.ExposedList<System.Int32> val_38 = val_38 + 16;
            this.triangles.Add(item:  (this.indicesArray + 16) + 16);
            this.indicesArray.RemoveAt(index:  0);
            this.isConcaveArray.RemoveAt(index:  0);
            var val_39 = (val_37 + val_41) - 1;
            val_39 = val_37;
            if(val_41 == val_37)
            {
                    val_35 = val_41 - val_37;
            }
            
            var val_41 = val_36 + val_39;
            mem2[0] = Spine.Triangulator.IsConcave(index:  val_37, vertexCount:  val_37, vertices:  null, indices:  val_38);
            var val_43 = val_36 + val_35;
            mem2[0] = Spine.Triangulator.IsConcave(index:  val_35, vertexCount:  val_37, vertices:  null, indices:  val_38);
            if(val_40 > 4)
            {
                goto label_65;
            }
            
            label_20:
            if(val_37 != 3)
            {
                    return;
            }
            
            val_47 = this.triangles;
            if(val_38 == 0)
            {
                    val_47 = this.triangles;
            }
            
            if((this.indicesArray + 12) <= 2)
            {
                    val_47 = this.triangles;
            }
            
            val_40 = val_38;
            if(val_47 == 0)
            {
                    val_47 = this.triangles;
            }
            
            val_47.Add(item:  this.indicesArray + 24);
            val_48 = val_47;
            if(val_47 == 0)
            {
                    val_48 = this.triangles;
            }
            
            val_39 = val_48;
            val_48.Add(item:  this.indicesArray + 16);
            this.triangles.Add(item:  this.indicesArray + 20);
        }
        public Spine.ExposedList<Spine.ExposedList<float>> Decompose(Spine.ExposedList<float> verticesArray, Spine.ExposedList<int> triangles)
        {
            var val_5;
            float val_54;
            object val_55;
            object val_56;
            object val_57;
            var val_58;
            var val_59;
            object val_60;
            var val_61;
            Spine.Triangulator val_62;
            var val_63;
            var val_64;
            var val_65;
            float val_66;
            var val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            var val_72;
            var val_73;
            var val_75;
            var val_76;
            val_54 = triangles;
            if((mem[1152921510874465176] + 12) >= 1)
            {
                    do
            {
                var val_1 = (mem[1152921510874465176] + 8) + 0;
                val_55 = mem[(mem[1152921510874465176] + 8 + 0) + 16];
                val_55 = (mem[1152921510874465176] + 8 + 0) + 16;
                mem[1152921510874465196].Free(obj:  val_55);
            }
            while((mem[1152921510874465176] + 12) != 1);
            
            }
            
            mem[1152921510874465176].Clear(clearArray:  true);
            if((mem[1152921510874465180] + 12) >= 1)
            {
                    do
            {
                var val_2 = (mem[1152921510874465180] + 8) + 0;
                mem[1152921510874465200].Free(obj:  (mem[1152921510874465180] + 8 + 0) + 16);
                val_55 = 0 + 1;
            }
            while((mem[1152921510874465180] + 12) != val_55);
            
            }
            
            mem[1152921510874465180].Clear(clearArray:  true);
            object val_3 = mem[1152921510874465200].Obtain();
            val_56 = mem[1152921510874465200];
            val_56.Clear(clearArray:  true);
            object val_4 = mem[1152921510874465196].Obtain();
            val_57 = mem[1152921510874465196];
            val_57.Clear(clearArray:  true);
            if(val_54 != 0)
            {
                
            }
            
            if(0 < 1)
            {
                goto label_20;
            }
            
            var val_67 = 0;
            label_62:
            val_5 = 0;
            val_58 = 0;
            if(val_58 <= val_67)
            {
                    val_58 = 0;
            }
            
            var val_6 = 0 + 0;
            val_67 = val_67 + 1;
            if(val_58 <= val_67)
            {
                    val_58 = 0;
            }
            
            int val_8 = ((0 + 0) + 16) << 1;
            val_59 = mem[SL + 12];
            val_59 = SL + 12;
            val_60 = val_56;
            if(val_59 <= val_8)
            {
                    val_59 = mem[SL + 12];
                val_59 = SL + 12;
            }
            
            var val_9 = SL + (val_8 << 2);
            val_8 = val_8 | 1;
            val_54 = ((0 + 0) + 20) << 1;
            if(val_59 <= val_8)
            {
                    val_59 = mem[SL + 12];
                val_59 = SL + 12;
            }
            
            var val_10 = SL + (val_8 << 2);
            if(val_59 <= val_54)
            {
                    val_59 = mem[SL + 12];
                val_59 = SL + 12;
            }
            
            var val_11 = SL + (val_54 << 2);
            int val_12 = ((0 + 0) + 24) << 1;
            var val_13 = val_54 | 1;
            if(val_59 <= val_13)
            {
                    val_59 = mem[SL + 12];
                val_59 = SL + 12;
            }
            
            var val_14 = SL + (val_13 << 2);
            if(val_59 <= val_12)
            {
                    val_59 = mem[SL + 12];
                val_59 = SL + 12;
            }
            
            var val_15 = SL + (val_12 << 2);
            var val_17 = SL + ((val_12 | 1) << 2);
            if(0 != val_8)
            {
                goto label_35;
            }
            
            if(val_57 == 0)
            {
                goto label_36;
            }
            
            val_61 = mem[mem[1152921510874465196] + 12];
            val_61 = mem[1152921510874465196] + 12;
            goto label_37;
            label_35:
            val_62 = this;
            if(val_57 != 0)
            {
                goto label_39;
            }
            
            goto label_39;
            label_36:
            val_61 = 0;
            label_37:
            var val_18 = val_61 - 4;
            val_63 = mem[mem[1152921510874465196] + 8 + 12];
            val_63 = mem[1152921510874465196] + 8 + 12;
            if(val_63 <= val_18)
            {
                    val_63 = mem[mem[1152921510874465196] + 8 + 12];
                val_63 = mem[1152921510874465196] + 8 + 12;
            }
            
            var val_19 = (mem[1152921510874465196] + 8) + (val_18 << 2);
            var val_20 = val_61 - 3;
            if(val_63 <= val_20)
            {
                    val_63 = mem[mem[1152921510874465196] + 8 + 12];
                val_63 = mem[1152921510874465196] + 8 + 12;
            }
            
            var val_21 = (mem[1152921510874465196] + 8) + (val_20 << 2);
            var val_22 = val_61 - 2;
            if(val_63 <= val_22)
            {
                    val_63 = mem[mem[1152921510874465196] + 8 + 12];
                val_63 = mem[1152921510874465196] + 8 + 12;
            }
            
            var val_23 = (mem[1152921510874465196] + 8) + (val_22 << 2);
            val_61 = val_61 - 1;
            if(val_63 <= val_61)
            {
                    val_63 = mem[mem[1152921510874465196] + 8 + 12];
                val_63 = mem[1152921510874465196] + 8 + 12;
            }
            
            var val_24 = (mem[1152921510874465196] + 8) + (val_61 << 2);
            float val_25 = ((mem[1152921510874465196] + 8 + ((val_61 - 2)) << 2) + 16) - ((mem[1152921510874465196] + 8 + ((val_61 - 4)) << 2) + 16);
            val_60 = val_56;
            var val_68 = (mem[1152921510874465196] + 8 + ((val_61 - 1)) << 2) + 16;
            val_68 = val_68 - ((mem[1152921510874465196] + 8 + ((val_61 - 3)) << 2) + 16);
            float val_26 = ((SL + (((0 + 0) + 24 << 1)) << 2) + 16) * val_68;
            if(val_63 >= val_61)
            {
                    0 = 1;
            }
            
            if(val_63 == 0)
            {
                    val_63 = mem[mem[1152921510874465196] + 8 + 12];
                val_63 = mem[1152921510874465196] + 8 + 12;
            }
            
            if(val_63 <= 1)
            {
                    val_63 = mem[mem[1152921510874465196] + 8 + 12];
                val_63 = mem[1152921510874465196] + 8 + 12;
            }
            
            if(val_63 <= 2)
            {
                    val_63 = mem[mem[1152921510874465196] + 8 + 12];
                val_63 = mem[1152921510874465196] + 8 + 12;
            }
            
            float val_27 = (mem[1152921510874465196] + 8 + 20) - ((SL + ((((0 + 0) + 24 << 1) | 1)) << 2) + 16);
            float val_28 = (mem[1152921510874465196] + 8 + 16) - ((SL + (((0 + 0) + 24 << 1)) << 2) + 16);
            val_62 = this;
            float val_29 = val_27 * (mem[1152921510874465196] + 8 + 24);
            if(val_63 >= 3)
            {
                    0 = 1;
            }
            
            val_54 = val_54;
            label_39:
            if((mem[1152921510874465196] + 12) >= 1)
            {
                    mem[1152921510874465176].Add(item:  val_57);
                mem[1152921510874465180].Add(item:  val_60);
            }
            else
            {
                    mem[1152921510874465196].Free(obj:  val_57);
                mem[1152921510874465200].Free(obj:  val_56);
                val_54 = val_54;
            }
            
            object val_30 = mem[1152921510874465196].Obtain();
            val_57 = mem[1152921510874465196];
            if(mem[1152921510874465196] != 0)
            {
                    val_57.Clear(clearArray:  true);
                val_64 = 1152921510844547232;
                val_57.Add(item:  val_27);
                val_57.Add(item:  val_27);
                val_57.Add(item:  val_27);
                val_57.Add(item:  val_27);
                val_57.Add(item:  val_27);
            }
            else
            {
                    val_57.Clear(clearArray:  true);
                val_64 = 1152921510844547232;
                val_57.Add(item:  val_27);
                val_57.Add(item:  val_27);
                val_57.Add(item:  val_27);
                val_57.Add(item:  val_27);
                val_57.Add(item:  val_27);
            }
            
            val_57.Add(item:  val_27);
            object val_31 = mem[1152921510874465200].Obtain();
            val_56 = mem[1152921510874465200];
            if(mem[1152921510874465200] != 0)
            {
                    val_56.Clear(clearArray:  true);
                val_65 = 1152921510844548256;
                val_55 = val_8;
                val_56.Add(item:  val_55);
                val_56.Add(item:  val_54);
            }
            else
            {
                    val_56.Clear(clearArray:  true);
                val_65 = 1152921510844548256;
                val_55 = val_8;
                val_56.Add(item:  val_55);
                val_56.Add(item:  val_54);
            }
            
            val_56.Add(item:  val_12);
            float val_33 = ((SL + (((0 + 0) + 20 << 1)) << 2) + 16) - ((SL + (((0 + 0) + 16 << 1)) << 2) + 16);
            float val_34 = (((SL + ((((0 + 0) + 20 << 1) | 1)) << 2) + 16) - ((SL + ((((0 + 0) + 16 << 1) | 1)) << 2) + 16)) * ((SL + (((0 + 0) + 24 << 1)) << 2) + 16);
            if(mem[1152921510874465200] >= 0)
            {
                    0 = 1;
            }
            
            if(((val_67 + 1) + 1) < 0)
            {
                goto label_62;
            }
            
            label_20:
            val_66 = mem[1152921510874465176];
            if((mem[1152921510874465196] + 12) >= 1)
            {
                    val_66.Add(item:  val_57);
                mem[1152921510874465180].Add(item:  val_56);
            }
            
            val_67 = mem[mem[1152921510874465176] + 12];
            val_67 = mem[1152921510874465176] + 12;
            val_68 = mem[1152921510874465180];
            if(val_67 >= 1)
            {
                    val_69 = 0;
                val_5 = val_67;
                do
            {
                var val_36 = (mem[1152921510874465180] + 8) + 0;
                if(((mem[1152921510874465180] + 8 + 0) + 16 + 12) != 0)
            {
                    var val_38 = ((mem[1152921510874465180] + 8 + 0) + 16 + 8) + ((((mem[1152921510874465180] + 8 + 0) + 16 + 12) - 1) << 2);
                var val_39 = (mem[1152921510874465176] + 8) + 0;
                val_56 = mem[(mem[1152921510874465176] + 8 + 0) + 16];
                val_56 = (mem[1152921510874465176] + 8 + 0) + 16;
                if(val_56 != 0)
            {
                    val_70 = mem[(mem[1152921510874465176] + 8 + 0) + 16 + 12];
                val_70 = (mem[1152921510874465176] + 8 + 0) + 16 + 12;
            }
            else
            {
                    val_70 = 0;
            }
            
                var val_40 = val_70 - 4;
                val_71 = mem[(mem[1152921510874465176] + 8 + 0) + 16 + 8 + 12];
                val_71 = (mem[1152921510874465176] + 8 + 0) + 16 + 8 + 12;
                if(val_71 <= val_40)
            {
                    val_71 = mem[(mem[1152921510874465176] + 8 + 0) + 16 + 8 + 12];
                val_71 = (mem[1152921510874465176] + 8 + 0) + 16 + 8 + 12;
            }
            
                var val_41 = ((mem[1152921510874465176] + 8 + 0) + 16 + 8) + (val_40 << 2);
                var val_42 = val_70 - 3;
                if(val_71 <= val_42)
            {
                    val_71 = mem[(mem[1152921510874465176] + 8 + 0) + 16 + 8 + 12];
                val_71 = (mem[1152921510874465176] + 8 + 0) + 16 + 8 + 12;
            }
            
                var val_43 = ((mem[1152921510874465176] + 8 + 0) + 16 + 8) + (val_42 << 2);
                var val_44 = val_70 - 2;
                if(val_71 <= val_44)
            {
                    val_71 = mem[(mem[1152921510874465176] + 8 + 0) + 16 + 8 + 12];
                val_71 = (mem[1152921510874465176] + 8 + 0) + 16 + 8 + 12;
            }
            
                var val_45 = ((mem[1152921510874465176] + 8 + 0) + 16 + 8) + (val_44 << 2);
                val_70 = val_70 - 1;
                if(val_71 > val_70)
            {
                    var val_46 = ((mem[1152921510874465176] + 8 + 0) + 16 + 8) + (val_70 << 2);
                val_67 = val_5;
                val_69 = val_69;
                val_72 = mem[((mem[1152921510874465176] + 8 + 0) + 16 + 8 + ((val_70 - 1)) << 2) + 16];
                val_72 = ((mem[1152921510874465176] + 8 + 0) + 16 + 8 + ((val_70 - 1)) << 2) + 16;
            }
            else
            {
                    var val_47 = ((mem[1152921510874465176] + 8 + 0) + 16 + 8) + (val_70 << 2);
                val_69 = val_69;
                val_72 = mem[((mem[1152921510874465176] + 8 + 0) + 16 + 8 + ((val_70 - 1)) << 2) + 16];
                val_72 = ((mem[1152921510874465176] + 8 + 0) + 16 + 8 + ((val_70 - 1)) << 2) + 16;
                val_71 = mem[(mem[1152921510874465176] + 8 + 0) + 16 + 8 + 12];
                val_71 = (mem[1152921510874465176] + 8 + 0) + 16 + 8 + 12;
                if(val_71 == 0)
            {
                    val_71 = mem[(mem[1152921510874465176] + 8 + 0) + 16 + 8 + 12];
                val_71 = (mem[1152921510874465176] + 8 + 0) + 16 + 8 + 12;
            }
            
                val_67 = val_5;
            }
            
                if(val_71 <= 1)
            {
                    val_71 = mem[(mem[1152921510874465176] + 8 + 0) + 16 + 8 + 12];
                val_71 = (mem[1152921510874465176] + 8 + 0) + 16 + 8 + 12;
            }
            
                if(val_71 <= 2)
            {
                    val_71 = mem[(mem[1152921510874465176] + 8 + 0) + 16 + 8 + 12];
                val_71 = (mem[1152921510874465176] + 8 + 0) + 16 + 8 + 12;
            }
            
                float val_49 = (((mem[1152921510874465176] + 8 + 0) + 16 + 8 + ((val_70 - 2)) << 2) + 16) - (((mem[1152921510874465176] + 8 + 0) + 16 + 8 + ((val_70 - 4)) << 2) + 16);
                val_73 = 0;
                float val_50 = (val_72 - (((mem[1152921510874465176] + 8 + 0) + 16 + 8 + ((val_70 - 3)) << 2) + 16)) * ((mem[1152921510874465176] + 8 + 0) + 16 + 8 + 16);
                if(val_71 >= 3)
            {
                    0 = 1;
            }
            
                do
            {
                if(val_73 == val_69)
            {
                    val_73 = val_69;
            }
            else
            {
                    var val_51 = (mem[1152921510874465180] + 8) + 0;
                val_56 = mem[(mem[1152921510874465180] + 8 + 0) + 16];
                val_56 = (mem[1152921510874465180] + 8 + 0) + 16;
                if(((mem[1152921510874465180] + 8 + 0) + 16 + 12) == 3)
            {
                    var val_52 = (mem[1152921510874465176] + 8) + 0;
                if(((mem[1152921510874465176] + 8 + 0) + 16) != 0)
            {
                    val_75 = (mem[1152921510874465176] + 8 + 0) + 16;
                val_76 = mem[(mem[1152921510874465176] + 8 + 0) + 16 + 8];
                val_76 = (mem[1152921510874465176] + 8 + 0) + 16 + 8;
            }
            else
            {
                    val_75 = 8;
                val_76 = 0;
            }
            
                var val_69 = (mem[1152921510874465176] + 8 + 0) + 16 + 12;
                val_69 = val_69 - 2;
                var val_53 = val_76 + (val_69 << 2);
                val_68 = mem[1152921510874465180];
                val_66 = mem[1152921510874465176];
                if(((mem[1152921510874465180] + 8 + 0) + 16 + 8 + 16) == ((mem[1152921510874465180] + 8 + 0) + 16 + 8 + 16))
            {
                    (mem[1152921510874465180] + 8 + 0) + 16 + 8 + 16 = ((mem[1152921510874465180] + 8 + 0) + 16 + 8 + (((mem[1152921510874465180] + 8 + 0) + 16 + 12 - 1)) << 2) + 16;
                (mem[1152921510874465180] + 8 + 0) + 16 + 8 + 16 = (mem[1152921510874465180] + 8 + 0) + 16 + 8 + 20;
            }
            
                if(((mem[1152921510874465180] + 8 + 0) + 16 + 8 + 16) == ((mem[1152921510874465180] + 8 + 0) + 16 + 8 + 16))
            {
                    var val_55 = val_75 + ((((mem[1152921510874465176] + 8 + 0) + 16 + 12) - 1) << 2);
                float val_56 = ((mem[1152921510874465176] + 8 + 0) + 16 + 8 + 16) - ((val_76 + (((mem[1152921510874465176] + 8 + 0) + 16 + 12 - 2)) << 2) + 16);
                float val_58 = (((mem[1152921510874465176] + 8 + 0) + 16 + 8 + ((val_70 - 2)) << 2) + 16) - (((mem[1152921510874465176] + 8 + 0) + 16 + 8 + ((val_70 - 4)) << 2) + 16);
                float val_60 = (val_72 - (((mem[1152921510874465176] + 8 + 0) + 16 + 8 + ((val_70 - 3)) << 2) + 16)) * ((val_76 + (((mem[1152921510874465176] + 8 + 0) + 16 + 12 - 2)) << 2) + 16);
                float val_61 = ((mem[1152921510874465176] + 8 + 0) + 16 + 8 + 24) * (((mem[1152921510874465176] + 8 + 0) + 16 + 8 + 20) - ((val_75 + (((mem[1152921510874465176] + 8 + 0) + 16 + 12 - 1)) << 2) + 16));
                if(((mem[1152921510874465180] + 8 + 0) + 16 + 8 + 16) >= ((mem[1152921510874465180] + 8 + 0) + 16 + 8 + 16))
            {
                    0 = 1;
            }
            
                if(((mem[1152921510874465180] + 8 + 0) + 16 + 8 + 16) >= ((mem[1152921510874465180] + 8 + 0) + 16 + 8 + 16))
            {
                    0 = 1;
            }
            
            }
            
                val_67 = val_5;
                val_69 = val_69;
            }
            
            }
            
                val_54 = val_73 + 1;
            }
            while(val_54 < val_67);
            
            }
            
                val_55 = val_69 + 1;
            }
            while(val_55 != val_67);
            
            }
            
            if(((mem[1152921510874465176] + 12) - 1) < 0)
            {
                    return;
            }
            
            var val_63 = (mem[1152921510874465176] + 12) + 3;
            val_54 = 1152921510874430928;
            val_66 = 1152921510874439120;
            val_68 = 1152921510874432976;
            do
            {
                int val_64 = val_63 - 4;
                if((mem[1152921510874465176] + 8 + ((mem[1152921510874465176] + 12 + 3)) << 2 + 12) == 0)
            {
                    mem[1152921510874465176].RemoveAt(index:  val_64);
                val_56 = mem[1152921510874465196];
                val_56.Free(obj:  mem[1152921510874465176] + 8 + ((mem[1152921510874465176] + 12 + 3)) << 2);
                mem[1152921510874465180].RemoveAt(index:  val_64);
                mem[1152921510874465200].Free(obj:  mem[1152921510874465180] + 8 + ((mem[1152921510874465176] + 12 + 3)) << 2);
            }
            
                val_55 = val_63 - 1;
            }
            while((val_63 - 5) > 1);
        
        }
        private static bool IsConcave(int index, int vertexCount, float[] vertices, int[] indices)
        {
            index = index + vertexCount;
            index = index - 1;
            int val_1 = index + 1;
            int val_2 = indices[vertexCount] << 1;
            int val_8 = indices[vertexCount];
            int val_3 = indices[index] << 1;
            val_2 = val_2 | 1;
            float val_9 = vertices[val_2];
            float val_10 = vertices[val_2];
            val_3 = val_3 | 1;
            val_8 = val_8 << 1;
            float val_12 = vertices[val_3];
            val_8 = val_8 | 1;
            float val_13 = vertices[val_8];
            float val_4 = val_12 - val_10;
            float val_14 = vertices[val_8];
            float val_5 = val_10 - val_14;
            val_14 = val_14 - val_12;
            val_5 = vertices[val_3] * val_5;
            if(indices[vertexCount] < val_8)
            {
                    0 = 1;
            }
            
            return true;
        }
        private static bool PositiveArea(float p1x, float p1y, float p2x, float p2y, float p3x, float p3y)
        {
            var val_1;
            var val_4 = val_1;
            var val_5 = R1;
            float val_2 = val_5 - val_4;
            val_4 = val_4 - R3;
            val_5 = R3 - val_5;
            val_2 = val_2 * R2;
            if()
            {
                    0 = 1;
            }
            
            return true;
        }
        private static int Winding(float p1x, float p1y, float p2x, float p2y, float p3x, float p3y)
        {
            var val_1;
            var val_5 = val_1;
            var val_3 = R3;
            var val_4 = R2;
            val_3 = val_3 - R1;
            val_4 = val_4 - 0;
            val_5 = val_3 * val_5;
            if()
            {
                    0 = 1;
            }
            
            return 1;
        }
        public Triangulator()
        {
            Spine.ExposedList<UnityEngine.Material> val_1 = new Spine.ExposedList<UnityEngine.Material>();
            this.convexPolygons = null;
            Spine.ExposedList<UnityEngine.Material> val_2 = new Spine.ExposedList<UnityEngine.Material>();
            this.convexPolygonsIndices = null;
            this.indicesArray = new Spine.ExposedList<System.Int32>();
            Spine.ExposedList<System.Boolean> val_4 = new Spine.ExposedList<System.Boolean>();
            this.isConcaveArray = null;
            this.triangles = new Spine.ExposedList<System.Int32>();
            Spine.Pool<System.Object> val_6 = new Spine.Pool<System.Object>(initialCapacity:  16, max:  -2147483648);
            this.polygonPool = null;
            Spine.Pool<System.Object> val_7 = new Spine.Pool<System.Object>(initialCapacity:  16, max:  -2147483648);
            this.polygonIndicesPool = null;
        }
    
    }

}
