using UnityEngine;

namespace Spine
{
    public class SkeletonBounds
    {
        // Fields
        private Spine.ExposedList<Spine.Polygon> polygonPool;
        private float minX;
        private float minY;
        private float maxX;
        private float maxY;
        private Spine.ExposedList<Spine.BoundingBoxAttachment> <BoundingBoxes>k__BackingField;
        private Spine.ExposedList<Spine.Polygon> <Polygons>k__BackingField;
        
        // Properties
        public Spine.ExposedList<Spine.BoundingBoxAttachment> BoundingBoxes { get; set; }
        public Spine.ExposedList<Spine.Polygon> Polygons { get; set; }
        public float MinX { get; set; }
        public float MinY { get; set; }
        public float MaxX { get; set; }
        public float MaxY { get; set; }
        public float Width { get; }
        public float Height { get; }
        
        // Methods
        public Spine.ExposedList<Spine.BoundingBoxAttachment> get_BoundingBoxes()
        {
        
        }
        private void set_BoundingBoxes(Spine.ExposedList<Spine.BoundingBoxAttachment> value)
        {
            this.<BoundingBoxes>k__BackingField = value;
        }
        public Spine.ExposedList<Spine.Polygon> get_Polygons()
        {
        
        }
        private void set_Polygons(Spine.ExposedList<Spine.Polygon> value)
        {
            this.<Polygons>k__BackingField = value;
        }
        public float get_MinX()
        {
            return (float)S0;
        }
        public void set_MinX(float value)
        {
            this.minX = ;
        }
        public float get_MinY()
        {
            return (float)S0;
        }
        public void set_MinY(float value)
        {
            this.minY = ;
        }
        public float get_MaxX()
        {
            return (float)S0;
        }
        public void set_MaxX(float value)
        {
            this.maxX = ;
        }
        public float get_MaxY()
        {
            return (float)S0;
        }
        public void set_MaxY(float value)
        {
            this.maxY = ;
        }
        public float get_Width()
        {
            float val_1 = this.minX;
            val_1 = this.maxX - val_1;
            return (float)val_1;
        }
        public float get_Height()
        {
            float val_1 = this.minY;
            val_1 = this.maxY - val_1;
            return (float)val_1;
        }
        public SkeletonBounds()
        {
            this.polygonPool = new Spine.ExposedList<UnityEngine.Material>();
            Spine.ExposedList<UnityEngine.Material> val_2 = new Spine.ExposedList<UnityEngine.Material>();
            this.<BoundingBoxes>k__BackingField = null;
            this.<Polygons>k__BackingField = new Spine.ExposedList<UnityEngine.Material>();
        }
        public void Update(Spine.Skeleton skeleton, bool updateAabb)
        {
            Spine.SkeletonBounds val_6;
            object val_7;
            Spine.Skeleton val_8;
            Spine.ExposedList<Spine.BoundingBoxAttachment> val_9;
            var val_10;
            var val_11;
            val_6 = this;
            this.<BoundingBoxes>k__BackingField.Clear(clearArray:  true);
            if((this.<Polygons>k__BackingField) >= 1)
            {
                    var val_5 = 0;
                do
            {
                var val_1 = (this.<Polygons>k__BackingField + 8) + 0;
                this.polygonPool.Add(item:  (this.<Polygons>k__BackingField + 8 + 0) + 16);
                val_5 = val_5 + 1;
            }
            while((this.<Polygons>k__BackingField) != val_5);
            
            }
            
            this.<Polygons>k__BackingField.Clear(clearArray:  true);
            val_8 = skeleton;
            val_9 = this.<BoundingBoxes>k__BackingField;
            if(val_8 >= 1)
            {
                    do
            {
                val_7 = mem[Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg + 48];
                val_7 = Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg + 48;
                if(val_7 != 0)
            {
                    val_9.Add(item:  val_7);
                if(val_8 >= 1)
            {
                    Spine.Skeleton val_2 = val_8 - 1;
                Spine.ExposedList<Spine.Polygon> val_3 = this.polygonPool + (val_2 << 2);
                this.polygonPool.RemoveAt(index:  val_2);
            }
            else
            {
                    Spine.Polygon val_4 = null;
                val_10 = val_4;
                val_4 = new Spine.Polygon();
            }
            
                this.<Polygons>k__BackingField.Add(item:  265920512);
                if(val_10 != 0)
            {
                    typeof(Spine.Polygon).__il2cppRuntimeField_C = Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg + 48 + 24;
            }
            else
            {
                    mem[12] = Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg + 48 + 24;
            }
            
                val_11 = null;
                typeof(Spine.Polygon).__il2cppRuntimeField_8 = null;
                val_7.ComputeWorldVertices(slot:  Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg, worldVertices:  533895840);
            }
            
                val_6 = 0 + 1;
            }
            while(val_8 != val_6);
            
            }
            
            if(updateAabb == false)
            {
                    return;
            }
            
            this.AabbCompute();
        }
        private void AabbCompute()
        {
            var val_5;
            float val_6;
            float val_7;
            float val_8;
            float val_9;
            float val_10;
            var val_11;
            val_5 = this;
            if(true >= 1)
            {
                    val_6 = -2.147484E+09f;
                val_7 = 2.147484E+09f;
                val_8 = 3472883712;
                val_9 = 1325400064;
                do
            {
                val_10 = mem[Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg + 8];
                val_10 = Spine.ExposedList<T>.__il2cppRuntimeField_byval_arg + 8;
                var val_1 =  + 16;
                var val_7 = 0;
                val_11 = 0;
                if(val_11 <= val_7)
            {
                    val_11 = 0;
            }
            
                val_9 = 1325400064;
                val_7 = (val_7 + 1) + 1;
                val_7 = 1325400064;
                val_6 = 3472883712;
                float val_6 = System.Math.Max(val1:  System.Math.Max(val1:  System.Math.Min(val1:  System.Math.Min(val1:  null, val2:  null), val2:  null), val2:  null), val2:  null);
                val_8 = 3472883712;
                val_1 = val_1 + 8;
                var val_8 = 0;
                val_8 = val_8 + 1;
            }
            while(val_8 != true);
            
            }
            else
            {
                    val_9 = 2.147484E+09f;
                val_8 = -2.147484E+09f;
                val_7 = 1325400064;
                val_6 = 3472883712;
            }
            
            this.minX = val_7;
            this.minY = val_9;
            this.maxX = val_6;
            this.maxY = val_8;
        }
        public bool AabbContainsPoint(float x, float y)
        {
            var val_1 = 0;
            if()
            {
                    return true;
            }
            
            if()
            {
                    return true;
            }
            
            if()
            {
                    return (bool)val_1;
            }
            
            if()
            {
                    val_1 = 1;
            }
            
            return true;
        }
        public bool AabbIntersectsSegment(float x1, float y1, float x2, float y2)
        {
            var val_1;
            var val_4;
            var val_8 = R1;
            var val_4 = R3;
            float val_6 = this.minY;
            float val_7 = this.maxY;
            val_4 = 0;
            if()
            {
                    return (bool)val_4;
            }
            
            var val_5 = val_1;
            if()
            {
                    return (bool)val_4;
            }
            
            if()
            {
                    return (bool)val_4;
            }
            
            if()
            {
                    return (bool)val_4;
            }
            
            val_4 = val_4 - val_8;
            val_4 = 1;
            val_5 = val_5 - R2;
            float val_2 = this.minX - val_8;
            val_4 = val_5 / val_4;
            if()
            {
                    if(<0)
            {
                    return (bool)val_4;
            }
            
            }
            
            float val_3 = this.maxX - val_8;
            if()
            {
                    if(<0)
            {
                    return (bool)val_4;
            }
            
            }
            
            val_6 = val_6 - R2;
            val_6 = val_6 / val_4;
            val_6 = val_6 + val_8;
            if()
            {
                    if(<0)
            {
                    return (bool)val_4;
            }
            
            }
            
            val_7 = val_7 - R2;
            val_7 = val_7 / val_4;
            val_8 = val_7 + val_8;
            if()
            {
                    0 = 1;
            }
            
            if(<0)
            {
                    0 = 1;
            }
            
            val_4 = 1;
            return (bool)val_4;
        }
        public bool AabbIntersectsSkeleton(Spine.SkeletonBounds bounds)
        {
            if(bounds >= 0)
            {
                    return true;
            }
            
            if(bounds <= 0)
            {
                    return true;
            }
            
            if(bounds >= 0)
            {
                    return true;
            }
            
            if(bounds > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool ContainsPoint(Spine.Polygon polygon, float x, float y)
        {
            var val_7;
            System.Single[] val_8;
            var val_9;
            var val_10;
            var val_13;
            val_7 = polygon;
            if(polygon != 0)
            {
                    val_8 = polygon.<Vertices>k__BackingField;
            }
            else
            {
                    val_8 = 0f;
            }
            
            if((polygon.<Count>k__BackingField) >= 1)
            {
                    var val_1 = val_8 + 16;
                int val_2 = (polygon.<Count>k__BackingField) - 2;
                val_9 = 0;
                do
            {
                val_7 = 0;
                val_10 = 0;
                if(val_10 <= (val_7 + 1))
            {
                    val_10 = 0;
            }
            
                int val_4 = val_2 + 1;
                var val_5 = val_8 + (val_4 << 2);
                if(0 < 0)
            {
                    if(0 >= val_4)
            {
                goto label_7;
            }
            
            }
            
                if((0 >= val_4) && (0 < 0))
            {
                    label_7:
                val_13 = 0;
                if(val_13 <= val_7)
            {
                    val_13 = 0;
            }
            
                float val_6 = ((val_8 + (((polygon.<Count>k__BackingField - 2) + 1)) << 2) + 16) - ((val_8 + 16) + 4);
                var val_7 = val_8 + (val_2 << 2);
                val_6 = (R3 - ((val_8 + 16) + 4)) / val_6;
                var val_11 = (val_8 + ((polygon.<Count>k__BackingField - 2)) << 2) + 16;
                val_11 = val_11 - val_1;
                if(0 < 0)
            {
                    val_9 = val_9 ^ 1;
            }
            
            }
            
                val_1 = val_1 + 8;
            }
            while((val_7 + 2) < (polygon.<Count>k__BackingField));
            
                return (bool)val_9 & 1;
            }
            
            val_9 = 0;
            return (bool)val_9 & 1;
        }
        public Spine.BoundingBoxAttachment ContainsPoint(float x, float y)
        {
            var val_2;
            if(R6 < 1)
            {
                    return;
            }
            
            val_2 = 4;
            do
            {
                var val_1 = val_2 - 4;
                if((R8 + 12.ContainsPoint(polygon:  R8 + 16, x:  x, y:  y)) == true)
            {
                    return;
            }
            
                val_2 = val_2 + 1;
            }
            while((val_2 - 3) < R6);
        
        }
        public Spine.BoundingBoxAttachment IntersectsSegment(float x1, float y1, float x2, float y2)
        {
            float val_3 = R3;
            if(R6 < 1)
            {
                    return;
            }
            
            val_3 = 4;
            do
            {
                var val_2 = val_3 - 4;
                if((R8 + 12.IntersectsSegment(polygon:  R8 + 16, x1:  x1, y1:  y1, x2:  x2, y2:  y2)) == true)
            {
                    return;
            }
            
                val_3 = val_3 + 1;
            }
            while((val_3 - 3) < R6);
        
        }
        public bool IntersectsSegment(Spine.Polygon polygon, float x1, float y1, float x2, float y2)
        {
            var val_4;
            var val_5;
            System.Single[] val_16;
            var val_17;
            var val_18;
            var val_19;
            if(polygon != 0)
            {
                    val_16 = polygon.<Vertices>k__BackingField;
            }
            else
            {
                    val_16 = 0;
            }
            
            val_17 = 0;
            int val_1 = (polygon.<Count>k__BackingField) - 2;
            if(0 <= val_1)
            {
                    val_17 = 0;
            }
            
            var val_2 = val_16 + (val_1 << 2);
            if((polygon.<Count>k__BackingField) >= 1)
            {
                    float val_6 = R2 * val_4;
                var val_7 = val_16 + 16;
                float val_8 = R3 - val_4;
                var val_17 = 0;
                do
            {
                val_18 = 0;
                if(val_18 <= val_17)
            {
                    val_18 = 0;
            }
            
                val_17 = val_17 + 1;
                float val_11 = ((val_16 + ((polygon.<Count>k__BackingField - 2)) << 2) + 16) - val_7;
                float val_12 = ((val_16 + ((polygon.<Count>k__BackingField - 2)) << 2) + 16) * ((val_16 + 16) + 4);
                float val_13 = (val_7 + (((polygon.<Count>k__BackingField) - 1) << 2)) - ((val_16 + 16) + 4);
                float val_15 = (R2 - val_5) * val_13;
                val_11 = (val_6 * val_11) / val_15;
                if(val_18 >= val_17)
            {
                    if(val_18 <= val_17)
            {
                goto label_9;
            }
            
            }
            
                if((val_18 >= val_17) && (val_18 <= val_17))
            {
                    label_9:
                if(val_18 >= val_17)
            {
                    if(val_18 <= val_17)
            {
                goto label_13;
            }
            
            }
            
                if((val_18 >= val_17) && (val_18 <= val_17))
            {
                    label_13:
                val_13 = val_6 * val_13;
                float val_16 = val_13 / val_15;
                if(val_18 >= val_17)
            {
                    if(val_18 <= val_17)
            {
                goto label_17;
            }
            
            }
            
                if((val_18 >= val_17) && (val_18 <= val_17))
            {
                    label_17:
                val_19 = 1;
                if(val_18 >= val_17)
            {
                    if(val_18 <= val_17)
            {
                    return (bool)val_19;
            }
            
            }
            
                if(val_18 >= val_17)
            {
                    if(val_18 <= val_17)
            {
                    return (bool)val_19;
            }
            
            }
            
            }
            
            }
            
            }
            
                val_17 = val_17 + 1;
                val_7 = val_7 + 8;
            }
            while(val_17 < (polygon.<Count>k__BackingField));
            
            }
            
            val_19 = 0;
            return (bool)val_19;
        }
        public Spine.Polygon GetPolygon(Spine.BoundingBoxAttachment attachment)
        {
            int val_1 = this.<BoundingBoxes>k__BackingField.IndexOf(item:  attachment);
            if(val_1 == 1)
            {
                    return;
            }
            
            val_1 = (this.<Polygons>k__BackingField) + (val_1 << 2);
        }
    
    }

}
