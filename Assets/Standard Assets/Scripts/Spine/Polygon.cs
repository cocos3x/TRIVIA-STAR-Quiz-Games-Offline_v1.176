using UnityEngine;

namespace Spine
{
    public class Polygon
    {
        // Fields
        private float[] <Vertices>k__BackingField;
        private int <Count>k__BackingField;
        
        // Properties
        public float[] Vertices { get; set; }
        public int Count { get; set; }
        
        // Methods
        public float[] get_Vertices()
        {
        
        }
        public void set_Vertices(float[] value)
        {
            this.<Vertices>k__BackingField = value;
        }
        public int get_Count()
        {
            return (int)this.<Count>k__BackingField;
        }
        public void set_Count(int value)
        {
            this.<Count>k__BackingField = value;
        }
        public Polygon()
        {
            this.<Vertices>k__BackingField = null;
        }
    
    }

}
