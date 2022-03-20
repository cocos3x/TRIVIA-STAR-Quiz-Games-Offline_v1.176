using UnityEngine;

namespace Spine
{
    public class Event
    {
        // Fields
        internal readonly Spine.EventData data;
        internal readonly float time;
        internal int intValue;
        internal float floatValue;
        internal string stringValue;
        
        // Properties
        public Spine.EventData Data { get; }
        public float Time { get; }
        public int Int { get; set; }
        public float Float { get; set; }
        public string String { get; set; }
        
        // Methods
        public Spine.EventData get_Data()
        {
        
        }
        public float get_Time()
        {
            return (float)S0;
        }
        public int get_Int()
        {
            return (int)this.intValue;
        }
        public void set_Int(int value)
        {
            this.intValue = value;
        }
        public float get_Float()
        {
            return (float)S0;
        }
        public void set_Float(float value)
        {
            this.floatValue = ;
        }
        public string get_String()
        {
        
        }
        public void set_String(string value)
        {
            this.stringValue = value;
        }
        public Event(float time, Spine.EventData data)
        {
            if(R2 != 0)
            {
                    time = data;
                this.data = R2;
                this.time = time;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  1658600960, message:  1867299536);
        }
        public override string ToString()
        {
            if(this.data != 0)
            {
                    return;
            }
        
        }
    
    }

}
