using UnityEngine;

namespace twelvegigs.sweepstakes
{
    public class Distribution
    {
        // Fields
        private string <Type>k__BackingField;
        private System.Nullable<double> value;
        private int <Frequency>k__BackingField;
        
        // Properties
        public string Type { get; set; }
        public double Value { get; }
        public int Frequency { get; set; }
        
        // Methods
        public string get_Type()
        {
        
        }
        protected void set_Type(string value)
        {
            this.<Type>k__BackingField = value;
        }
        public double get_Value()
        {
            if(true == 0)
            {
                    return (double)D0;
            }
            
            return this.value.Value;
        }
        public int get_Frequency()
        {
            return (int)this.<Frequency>k__BackingField;
        }
        protected void set_Frequency(int value)
        {
            this.<Frequency>k__BackingField = value;
        }
        public Distribution(System.Collections.Generic.Dictionary<string, object> distribution)
        {
            var val_12;
            object val_1 = distribution.Item[1350676976];
            string val_2 = distribution.ToString();
            this.<Type>k__BackingField = distribution;
            if((System.String.op_Equality(a:  distribution, b:  1126180576)) != false)
            {
                    object val_4 = distribution.Item[1295281824];
                System.Nullable<System.Double> val_7 = new System.Nullable<System.Double>(value:  System.Math.Round(value:  System.Convert.ToDouble(value:  distribution), digits:  distribution));
            }
            
            val_12 = 1;
            if((distribution.ContainsKey(key:  1126180656)) != false)
            {
                    object val_9 = distribution.Item[1126180656];
                string val_10 = distribution.ToString();
            }
            
            this.<Frequency>k__BackingField = System.Convert.ToInt32(value:  distribution);
        }
    
    }

}
