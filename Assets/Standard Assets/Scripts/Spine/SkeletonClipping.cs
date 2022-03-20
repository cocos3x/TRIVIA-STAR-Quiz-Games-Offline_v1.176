using UnityEngine;

namespace Spine
{
    public class SkeletonClipping
    {
        // Fields
        internal readonly Spine.Triangulator triangulator;
        internal readonly Spine.ExposedList<float> clippingPolygon;
        internal readonly Spine.ExposedList<float> clipOutput;
        internal readonly Spine.ExposedList<float> clippedVertices;
        internal readonly Spine.ExposedList<int> clippedTriangles;
        internal readonly Spine.ExposedList<float> clippedUVs;
        internal readonly Spine.ExposedList<float> scratch;
        internal Spine.ClippingAttachment clipAttachment;
        internal Spine.ExposedList<Spine.ExposedList<float>> clippingPolygons;
        
        // Properties
        public Spine.ExposedList<float> ClippedVertices { get; }
        public Spine.ExposedList<int> ClippedTriangles { get; }
        public Spine.ExposedList<float> ClippedUVs { get; }
        
        // Methods
        public Spine.ExposedList<float> get_ClippedVertices()
        {
        
        }
        public Spine.ExposedList<int> get_ClippedTriangles()
        {
        
        }
        public Spine.ExposedList<float> get_ClippedUVs()
        {
        
        }
        public bool IsClipping()
        {
            if(this.clipAttachment != 0)
            {
                    this.clipAttachment = 1;
            }
            
            return true;
        }
        public int ClipStart(Spine.Slot slot, Spine.ClippingAttachment clip)
        {
            Spine.ExposedList<System.Single> val_7;
            Spine.ClippingAttachment val_8;
            var val_9;
            var val_11;
            val_8 = clip;
            val_9 = 0;
            if(this.clipAttachment != 0)
            {
                    return 1949290344;
            }
            
            this.clipAttachment = val_8;
            Spine.ExposedList<T> val_1 = this.clippingPolygon.Resize(newSize:  35650824);
            val_8.ComputeWorldVertices(slot:  slot, start:  0, count:  35650824, worldVertices:  this.clippingPolygon, offset:  0, stride:  2);
            Spine.SkeletonClipping.MakeClockwise(polygon:  this.clippingPolygon);
            if(this.triangulator != 0)
            {
                    Spine.ExposedList<System.Int32> val_2 = this.triangulator.Triangulate(verticesArray:  this.clippingPolygon);
                val_11 = this.triangulator;
            }
            else
            {
                    Spine.ExposedList<System.Int32> val_3 = 0.Triangulate(verticesArray:  this.clippingPolygon);
                val_11 = 0;
            }
            
            Spine.ExposedList<Spine.ExposedList<System.Single>> val_4 = this.triangulator.Decompose(verticesArray:  this.clippingPolygon, triangles:  0);
            this.clippingPolygons = this.triangulator;
            ExposedList.Enumerator<T> val_5 = GetEnumerator();
            val_8 = 1152921510844547232;
            label_14:
            if(MoveNext() == false)
            {
                goto label_8;
            }
            
            Spine.SkeletonClipping.MakeClockwise(polygon:  val_7);
            val_7.Add(item:  null);
            val_7.Add(item:  null);
            goto label_14;
            label_8:
            Dispose();
            return 1949290344;
        }
        public void ClipEnd(Spine.Slot slot)
        {
            if(this.clipAttachment == 0)
            {
                    return;
            }
            
            if(this.clipAttachment.endSlot != slot.data)
            {
                    return;
            }
            
            R4.ClipEnd();
        }
        public void ClipEnd()
        {
            if(this.clipAttachment == 0)
            {
                    return;
            }
            
            this.clipAttachment = 0;
            this.clippingPolygons = 0;
            this.clippedVertices.Clear(clearArray:  true);
            this.clippedTriangles.Clear(clearArray:  true);
            this.clippingPolygon.Clear(clearArray:  true);
        }
        public void ClipTriangles(float[] vertices, int verticesLength, int[] triangles, int trianglesLength, float[] uvs)
        {
            System.Single[] val_64;
            Spine.ExposedList<System.Single> val_65;
            Spine.ExposedList<System.Single> val_66;
            Spine.ExposedList<Spine.ExposedList<System.Single>> val_67;
            Spine.SkeletonClipping val_68;
            int val_69;
            System.Int32[] val_70;
            var val_77;
            var val_78;
            var val_79;
            var val_80;
            var val_81;
            val_64 = vertices;
            val_65 = this.clipOutput;
            val_66 = this.clippedVertices;
            val_67 = this.clippingPolygons;
            if(this.clippingPolygons != 0)
            {
                goto label_1;
            }
            
            val_67 = this.clippingPolygons;
            if(val_67 == 0)
            {
                goto label_2;
            }
            
            label_1:
            val_66.Clear(clearArray:  true);
            val_68 = this;
            val_69 = trianglesLength;
            this.clippedUVs.Clear(clearArray:  true);
            this.clippedTriangles.Clear(clearArray:  true);
            if(val_69 < 1)
            {
                    return;
            }
            
            label_81:
            val_70 = triangles;
            if(val_70 == null)
            {
                    val_70 = triangles;
            }
            
            System.Int32[] val_63 = triangles;
            val_63 = val_63 + 0;
            var val_1 = ((triangles + 0) + 16) << 1;
            var val_2 = val_1 | 1;
            float val_64 = val_64[val_1];
            float val_65 = val_64[val_2];
            System.Int32[] val_68 = triangles;
            val_68 = val_68 + 4;
            var val_3 = ((triangles + 4) + 16) << 1;
            var val_4 = val_3 | 1;
            float val_69 = val_64[val_3];
            float val_70 = val_64[val_4];
            float val_71 = uvs[val_3];
            float val_72 = uvs[val_4];
            System.Int32[] val_73 = triangles;
            val_73 = val_73 + 8;
            var val_5 = ((triangles + 8) + 16) << 1;
            val_69 = val_5 | 1;
            float val_74 = val_64[val_5];
            float val_75 = val_64[val_69];
            if(val_67 < 1)
            {
                goto label_56;
            }
            
            val_77 = 0;
            float val_6 = val_65 - val_75;
            val_68 = val_67;
            float val_7 = val_74 - val_69;
            float val_8 = val_75 - val_65;
            val_69 = val_68;
            float val_9 = val_70 - val_75;
            val_6 = val_7 * val_6;
            float val_11 = 1f / val_6;
            label_55:
            System.Single[] val_78 = uvs[val_69];
            Spine.ExposedList<Spine.ExposedList<System.Single>> val_12 = val_68 + 0;
            if((this.Clip(x1:  val_70, y1:  null, x2:  1f, y2:  null, x3:  val_65, y3:  null, clippingArea:  val_64, output:  val_65)) == false)
            {
                goto label_29;
            }
            
            if(val_5 != 0)
            {
                    System.Single[] val_15 = (val_5 & (~1)) + val_78;
                Spine.ExposedList<T> val_16 = val_66.Resize(newSize:  val_15);
                Spine.ExposedList<T> val_17 = this.clippedUVs.Resize(newSize:  val_15);
                if(val_5 >= 1)
            {
                    System.Single[] val_79 = val_78;
                var val_83 = 0;
                var val_82 = 0;
                val_79 = val_65 + (val_79 << 2);
                do
            {
                val_79 = public Spine.ExposedList<T> Spine.ExposedList<Spine.TrackEntry>::Resize(int newSize);
                if(val_79 <= val_82)
            {
                    val_79 = public Spine.ExposedList<T> Spine.ExposedList<Spine.TrackEntry>::Resize(int newSize);
            }
            
                System.Single[] val_20 = val_78 + val_82;
                float val_81 = public Spine.ExposedList<T> Spine.ExposedList<Spine.Attachment>::Resize(int newSize);
                val_20 = val_20 + 1;
                Spine.ExposedList<System.Single> val_21 = val_79 + val_83;
                mem2[0] = public Spine.ExposedList<T> Spine.ExposedList<System.Boolean>::Resize(int newSize);
                float val_22 = val_81 - val_75;
                float val_23 = (public Spine.ExposedList<T> Spine.ExposedList<System.Boolean>::Resize(int newSize)) - val_74;
                mem2[0] = val_81;
                val_22 = (val_64 - val_74) * val_22;
                float val_25 = val_11 * val_22;
                float val_80 = 1f;
                val_80 = val_80 - (val_11 * (val_7 * val_22));
                float val_27 = val_80 - val_25;
                val_81 = val_71 * val_25;
                val_25 = val_72 * val_25;
                System.Single[] val_29 = (val_20 - 1) + 1;
                Spine.ExposedList<System.Single> val_30 = (this.clippedUVs + (val_79 << 2)) + val_83;
                mem2[0] = val_81;
                val_78 = val_5;
                val_82 = (val_82 + 1) + 1;
                val_83 = val_83 + 8;
                mem2[0] = val_25;
            }
            while(val_82 < val_78);
            
            }
            
                var val_31 = val_78 >> 1;
                if(val_78 != null)
            {
                    val_80 = mem[uvs[(((triangles + 8) + 16 << 1) | 1)] + 12];
                val_80 = uvs[(((triangles + 8) + 16 << 1) | 1)] + 12;
            }
            else
            {
                    val_80 = mem[uvs[(((triangles + 8) + 16 << 1) | 1)] + 12];
                val_80 = uvs[(((triangles + 8) + 16 << 1) | 1)] + 12;
            }
            
                var val_32 = val_31 + (val_31 << 1);
                val_32 = val_32 + val_80;
                Spine.ExposedList<T> val_34 = val_78.Resize(newSize:  val_32 - 6);
                if(val_78 >= 6)
            {
                    var val_84 = 1;
                do
            {
                var val_36 = (uvs[(((triangles + 8) + 16 << 1) | 1)] + 8) + (val_80 << 2);
                val_80 = val_80 + 1;
                mem2[0] = 0;
                var val_37 = 0 + val_84;
                mem2[0] = val_37;
                val_37 = val_37 + 1;
                val_80 = val_80 + 1;
                val_84 = val_84 + 1;
                val_80 = val_80 + 1;
                mem2[0] = val_37;
            }
            while(val_84 < (val_31 - 1));
            
            }
            
                var val_85 = 0;
                val_69 = val_68;
                val_85 = val_31 + val_85;
                val_64 = val_64;
                val_65 = val_65;
                val_66 = val_66;
                val_68 = val_67;
                val_77 = val_77;
            }
            
            val_77 = val_77 + 1;
            if(val_77 < val_67)
            {
                goto label_55;
            }
            
            goto label_56;
            label_29:
            System.Single[] val_38 = val_78 + 6;
            Spine.ExposedList<T> val_39 = val_66.Resize(newSize:  val_38);
            Spine.ExposedList<T> val_40 = this.clippedUVs.Resize(newSize:  val_38);
            System.Single[] val_41 = val_78 + 1;
            Spine.ExposedList<System.Single> val_42 = val_65 + (val_78 << 2);
            mem2[0] = val_64;
            Spine.ExposedList<System.Single> val_43 = val_65 + (val_41 << 2);
            mem2[0] = val_65;
            System.Single[] val_44 = val_78 + 2;
            Spine.ExposedList<System.Single> val_45 = val_65 + (val_44 << 2);
            mem2[0] = val_69;
            val_69 = val_78 + 3;
            Spine.ExposedList<System.Single> val_46 = val_65 + (val_69 << 2);
            mem2[0] = val_70;
            System.Single[] val_47 = val_78 + 4;
            Spine.ExposedList<System.Single> val_48 = val_65 + (val_47 << 2);
            mem2[0] = val_74;
            System.Single[] val_49 = val_78 + 5;
            Spine.ExposedList<System.Single> val_50 = val_65 + (val_49 << 2);
            mem2[0] = val_75;
            System.Single[] val_86 = val_78;
            val_86 = this.clippedUVs + (val_86 << 2);
            mem2[0] = uvs[val_1];
            Spine.ExposedList<System.Single> val_51 = this.clippedUVs + (val_41 << 2);
            mem2[0] = uvs[val_2];
            Spine.ExposedList<System.Single> val_52 = this.clippedUVs + (val_44 << 2);
            val_65 = val_65;
            mem2[0] = val_71;
            Spine.ExposedList<System.Single> val_53 = this.clippedUVs + (val_69 << 2);
            mem2[0] = val_72;
            Spine.ExposedList<System.Single> val_54 = this.clippedUVs + (val_47 << 2);
            mem2[0] = uvs[val_5];
            Spine.ExposedList<System.Single> val_55 = this.clippedUVs + (val_49 << 2);
            mem2[0] = uvs[val_69];
            if(val_78 != null)
            {
                    val_81 = mem[uvs[(((triangles + 8) + 16 << 1) | 1)] + 12];
                val_81 = uvs[(((triangles + 8) + 16 << 1) | 1)] + 12;
            }
            else
            {
                    val_81 = mem[uvs[(((triangles + 8) + 16 << 1) | 1)] + 12];
                val_81 = uvs[(((triangles + 8) + 16 << 1) | 1)] + 12;
            }
            
            Spine.ExposedList<T> val_57 = val_78.Resize(newSize:  val_81 + 3);
            var val_58 = (uvs[(((triangles + 8) + 16 << 1) | 1)] + 8) + (val_81 << 2);
            mem2[0] = val_85;
            var val_61 = (uvs[(((triangles + 8) + 16 << 1) | 1)] + 8) + ((val_81 + 1) << 2);
            val_81 = val_81 + 2;
            mem2[0] = val_85 + 1;
            val_68 = val_85 + 2;
            var val_62 = (uvs[(((triangles + 8) + 16 << 1) | 1)] + 8) + (val_81 << 2);
            val_64 = val_64;
            val_66 = val_66;
            mem2[0] = val_68;
            var val_87 = val_85;
            val_87 = val_87 + 3;
            label_56:
            var val_88 = 0;
            val_88 = val_88 + 3;
            if(val_88 < trianglesLength)
            {
                goto label_81;
            }
            
            return;
            label_2:
        }
        internal bool Clip(float x1, float y1, float x2, float y2, float x3, float y3, Spine.ExposedList<float> clippingArea, Spine.ExposedList<float> output)
        {
            var val_2;
            var val_7;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            float val_45;
            var val_46;
            var val_47;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_43 = val_1 + 12;
            var val_4 = val_43 >> 31;
            val_4 = val_43 + (val_4 >> 30);
            val_4 = val_4 & (~3);
            val_43 = val_43 - val_4;
            if(val_43 < 2)
            {
                    val_40 = val_2;
            }
            
            if(val_43 >= 2)
            {
                    val_41 = val_2;
            }
            
            if(val_41 != 0)
            {
                    val_41.Clear(clearArray:  true);
                val_41.Add(item:  x1);
                val_41.Add(item:  x1);
                val_41.Add(item:  x1);
                val_41.Add(item:  x1);
                val_41.Add(item:  x1);
                val_41.Add(item:  x1);
                val_41.Add(item:  x1);
            }
            else
            {
                    0.Clear(clearArray:  true);
                0.Add(item:  x1);
                0.Add(item:  x1);
                0.Add(item:  x1);
                0.Add(item:  x1);
                0.Add(item:  x1);
                0.Add(item:  x1);
                0.Add(item:  x1);
            }
            
            val_41.Add(item:  x1);
            val_40.Clear(clearArray:  true);
            var val_44 = val_1 + 12;
            val_42 = 0;
            val_44 = val_44 - 4;
            goto label_5;
            label_38:
            val_40.Add(item:  x1);
            val_40.Add(item:  x1);
            if(val_42 == val_44)
            {
                goto label_10;
            }
            
            clippingArea.Clear(clearArray:  true);
            val_41 = val_40;
            val_42 = val_7;
            val_40 = clippingArea;
            label_5:
            val_43 = val_41;
            val_44 = mem[val_1 + 8 + 12];
            val_44 = val_1 + 8 + 12;
            if(val_44 <= val_42)
            {
                    val_44 = mem[val_1 + 8 + 12];
                val_44 = val_1 + 8 + 12;
            }
            
            var val_8 = (val_1 + 8) + (val_42 << 2);
            var val_9 = val_42 | 1;
            if(val_44 <= val_9)
            {
                    val_44 = mem[val_1 + 8 + 12];
                val_44 = val_1 + 8 + 12;
            }
            
            var val_10 = (val_1 + 8) + (val_9 << 2);
            var val_11 = val_42 + 2;
            if(val_44 <= val_11)
            {
                    val_44 = mem[val_1 + 8 + 12];
                val_44 = val_1 + 8 + 12;
            }
            
            var val_12 = (val_1 + 8) + (val_11 << 2);
            val_7 = val_11;
            var val_14 = (val_1 + 8) + ((val_42 + 3) << 2);
            if(val_43 != 0)
            {
                    val_45 = mem[val_2 + 8];
                val_45 = val_2 + 8;
            }
            else
            {
                    val_45 = 0f;
            }
            
            var val_15 = (val_2 + 12) - 2;
            if(val_15 < 1)
            {
                goto label_20;
            }
            
            float val_16 = ((val_1 + 8 + (val_7) << 2) + 16) - ((val_1 + 8 + ((val_7 + 2)) << 2) + 16);
            var val_17 = val_45 + 16;
            float val_18 = ((val_1 + 8 + ((val_7 | 1)) << 2) + 16) - ((val_1 + 8 + ((val_7 + 3)) << 2) + 16);
            var val_45 = 0;
            float val_19 = ((val_1 + 8 + ((val_7 + 3)) << 2) + 16) - ((val_1 + 8 + ((val_7 | 1)) << 2) + 16);
            float val_20 = ((val_1 + 8 + ((val_7 + 2)) << 2) + 16) - ((val_1 + 8 + (val_7) << 2) + 16);
            label_36:
            val_46 = 0;
            if(val_46 <= val_45)
            {
                    val_46 = 0;
            }
            
            val_45 = val_45 + 1;
            var val_47 = val_17;
            if(val_46 <= val_45)
            {
                    val_46 = 0;
            }
            
            val_45 = val_45 + 1;
            if(val_46 <= val_45)
            {
                    val_46 = 0;
            }
            
            var val_21 = val_45 + 1;
            var val_46 = (val_45 + 16) + 12;
            float val_23 = val_47 - ((val_1 + 8 + ((val_7 + 2)) << 2) + 16);
            float val_25 = ((val_45 + 16) + 8) - ((val_1 + 8 + ((val_7 + 2)) << 2) + 16);
            val_47 = 1152921510844547232;
            float val_26 = val_16 * (((val_45 + 16) + 4) - ((val_1 + 8 + ((val_7 + 3)) << 2) + 16));
            float val_27 = val_16 * (val_46 - ((val_1 + 8 + ((val_7 + 3)) << 2) + 16));
            if(val_46 <= val_21)
            {
                goto label_26;
            }
            
            if(val_46 > val_21)
            {
                goto label_27;
            }
            
            float val_30 = ((val_1 + 8 + ((val_7 | 1)) << 2) + 16) - ((val_45 + 16) + 4);
            float val_31 = ((val_1 + 8 + (val_7) << 2) + 16) - val_47;
            val_30 = val_30 * (((val_45 + 16) + 8) - val_47);
            val_46 = val_30 / (val_20 * (val_46 - ((val_45 + 16) + 4)));
            if(val_40 == 0)
            {
                goto label_28;
            }
            
            val_40.Add(item:  (val_1 + 8 + (val_7) << 2) + 16);
            goto label_29;
            label_26:
            if(val_46 <= val_21)
            {
                goto label_33;
            }
            
            float val_35 = ((val_1 + 8 + ((val_7 | 1)) << 2) + 16) - ((val_45 + 16) + 4);
            float val_36 = ((val_1 + 8 + (val_7) << 2) + 16) - val_47;
            val_35 = val_35 * (((val_45 + 16) + 8) - val_47);
            val_47 = val_35 / (val_20 * (val_46 - ((val_45 + 16) + 4)));
            if(val_40 == 0)
            {
                goto label_31;
            }
            
            val_40.Add(item:  (val_1 + 8 + (val_7) << 2) + 16);
            goto label_32;
            label_28:
            val_49 = 1152921510844547232;
            0.Add(item:  (val_1 + 8 + (val_7) << 2) + 16);
            label_29:
            val_40.Add(item:  (val_1 + 8 + ((val_7 | 1)) << 2) + 16);
            goto label_33;
            label_31:
            val_50 = 1152921510844547232;
            0.Add(item:  (val_1 + 8 + (val_7) << 2) + 16);
            label_32:
            val_40.Add(item:  (val_1 + 8 + ((val_7 | 1)) << 2) + 16);
            label_27:
            if(val_40 != 0)
            {
                    val_40.Add(item:  (val_1 + 8 + ((val_7 | 1)) << 2) + 16);
            }
            else
            {
                    0.Add(item:  (val_1 + 8 + ((val_7 | 1)) << 2) + 16);
            }
            
            val_40.Add(item:  (val_1 + 8 + ((val_7 | 1)) << 2) + 16);
            label_33:
            val_17 = val_17 + 8;
            if((val_21 - 1) < val_15)
            {
                goto label_36;
            }
            
            label_20:
            val_51 = val_1 + 8;
            val_52 = val_42;
            if((val_2 + 12) != val_40)
            {
                goto label_38;
            }
            
            val_53 = 1;
            val_2.Clear(clearArray:  true);
            return (bool)val_53 & 1;
            label_10:
            if(val_40 != val_2)
            {
                    val_2.Clear(clearArray:  true);
                val_52 = (val_2 + 12) - 2;
                if(val_52 >= 1)
            {
                    var val_48 = 16;
                do
            {
                var val_39 = (val_2 + 8) + val_48;
                val_43 = val_2;
                val_43.Add(item:  x1);
                val_51 = 0 + 1;
                val_48 = val_48 + 4;
            }
            while(val_52 != val_51);
            
            }
            
                val_53 = 1;
                return (bool)val_53 & 1;
            }
            
            val_51 = val_2;
            val_53 = 1;
            Spine.ExposedList<T> val_41 = val_51.Resize(newSize:  (val_2 + 12) - 2);
            return (bool)val_53 & 1;
        }
        private static void MakeClockwise(Spine.ExposedList<float> polygon)
        {
            var val_7;
            var val_8;
            var val_9;
            float val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            if(polygon != 0)
            {
                
            }
            else
            {
                    val_7 = 0;
            }
            
            val_9 = 0;
            var val_1 = R8 - 2;
            if(val_9 <= val_1)
            {
                    val_9 = 0;
            }
            
            var val_8 = val_1;
            val_8 = val_7 + (val_8 << 2);
            var val_9 = (val_7 + ((R8 - 2)) << 2) + 16;
            if(val_9 >= 2)
            {
                    val_10 = 1.401298E-45f;
            }
            else
            {
                    val_9 = 0;
                val_10 = 1.401298E-45f;
                if(val_9 == 0)
            {
                    val_9 = 0;
            }
            
            }
            
            var val_2 = R8 - 1;
            var val_10 = val_2;
            val_9 = val_9 * val_10;
            val_11 = R8 - 3;
            val_10 = val_7 + (val_10 << 2);
            if(val_11 >= 1)
            {
                    var val_3 = val_7 + 16;
                var val_11 = 0;
                do
            {
                val_12 = 0;
                if(val_12 <= val_11)
            {
                    val_12 = 0;
            }
            
                val_11 = val_11 + 1;
                if(val_12 <= val_11)
            {
                    val_12 = 0;
            }
            
                val_11 = val_11 + 1;
                if(val_12 <= val_11)
            {
                    val_12 = 0;
            }
            
                val_11 = val_11 + 1;
                var val_12 = (val_7 + 16) + 12;
                val_11 = val_11 - 1;
                val_13 = val_3 + 8;
                val_12 = val_3 * val_12;
                val_9 = val_9 + val_12;
            }
            while(val_11 < val_11);
            
            }
            
            if(val_11 < 0)
            {
                    return;
            }
            
            if(R8 < 2)
            {
                    return;
            }
            
            var val_5 = 8 + ((R8) << 2);
            var val_13 = 0;
            do
            {
                val_14 = 0;
                if(val_14 <= val_13)
            {
                    val_14 = 0;
            }
            
                var val_6 = val_7 - 0;
                val_13 = val_13 + 1;
                if(val_14 <= val_13)
            {
                    val_14 = 0;
            }
            
                var val_14 = val_1;
                val_14 = val_14 + 0;
                if(val_14 <= val_14)
            {
                    val_14 = 0;
            }
            
                val_13 = val_13 - 1;
                if(val_14 <= val_13)
            {
                    val_14 = 0;
            }
            
                var val_15 = val_2;
                mem2[0] = val_7 + (8 + (R8) << 2);
                val_15 = val_15 + 0;
                if(val_14 <= val_15)
            {
                    val_14 = 0;
            }
            
                var val_7 = val_7 + val_5;
                val_8 = val_13 + 1;
                if(val_14 <= val_8)
            {
                    val_14 = 0;
            }
            
                mem2[0] = (val_7 + (8 + (R8) << 2)) + 4;
                mem2[0] = (val_7 - 0) + 16;
                val_13 = val_8 + 1;
                val_5 = val_5 - 8;
                val_11 = 0 - 2;
                mem2[0] = (val_7 - 0) + 20;
            }
            while(val_13 < (R8 >> 1));
        
        }
        public SkeletonClipping()
        {
            this.triangulator = new Spine.Triangulator();
            this.clippingPolygon = new Spine.ExposedList<System.Single>();
            this.clipOutput = new Spine.ExposedList<System.Single>(capacity:  128);
            this.clippedVertices = new Spine.ExposedList<System.Single>(capacity:  128);
            Spine.ExposedList<System.Int32> val_5 = new Spine.ExposedList<System.Int32>(capacity:  128);
            this.clippedTriangles = null;
            this.clippedUVs = new Spine.ExposedList<System.Single>(capacity:  128);
            this.scratch = new Spine.ExposedList<System.Single>();
        }
    
    }

}
