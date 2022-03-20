using UnityEngine;

namespace twelvegigs.sweepstakes
{
    public class Response
    {
        // Fields
        private string deviceHash;
        private bool enabled;
        private bool error;
        private int time;
        private string id;
        private string endpoint;
        private int seed;
        private bool suspect;
        private string method;
        private string session;
        private System.Nullable<double> balance;
        private System.Nullable<double> lastBalance;
        private System.Nullable<int> entries;
        private System.Nullable<int> lastEntries;
        private bool secure;
        private string signature;
        private System.Collections.Generic.Dictionary<string, object> payload;
        private System.Collections.Generic.Dictionary<string, object> response;
        
        // Properties
        public string DeviceHash { get; }
        public bool Enabled { get; }
        public bool Error { get; }
        public string Endpoint { get; }
        public string Session { get; }
        public System.Nullable<double> Balance { get; }
        public System.Nullable<double> LastBalance { get; }
        public System.Nullable<int> Entries { get; }
        public System.Nullable<int> LastEntries { get; }
        public System.Collections.Generic.Dictionary<string, object> Payload { get; }
        public System.Collections.Generic.Dictionary<string, object> Security { get; }
        
        // Methods
        public string get_DeviceHash()
        {
        
        }
        public bool get_Enabled()
        {
            return (bool)this.enabled;
        }
        public bool get_Error()
        {
            return (bool)this.error;
        }
        public string get_Endpoint()
        {
        
        }
        public string get_Session()
        {
        
        }
        public System.Nullable<double> get_Balance()
        {
            var val_1 = R1 + 48;
            return (System.Nullable<System.Double>)this;
        }
        public System.Nullable<double> get_LastBalance()
        {
            var val_1 = R1 + 64;
            return (System.Nullable<System.Double>)this;
        }
        public System.Nullable<int> get_Entries()
        {
            return (System.Nullable<System.Int32>)this;
        }
        public System.Nullable<int> get_LastEntries()
        {
            return (System.Nullable<System.Int32>)this;
        }
        public System.Collections.Generic.Dictionary<string, object> get_Payload()
        {
        
        }
        public System.Collections.Generic.Dictionary<string, object> get_Security()
        {
        
        }
        public Response(System.Collections.Generic.Dictionary<string, object> rawResponse)
        {
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            float val_47;
            var val_48;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = rawResponse;
            this.error = true;
            val_1 = new System.Object();
            if(val_1 == 0)
            {
                    return;
            }
            
            this.enabled = true;
            if((val_1.ContainsKey(key:  1675191600)) == false)
            {
                goto label_2;
            }
            
            object val_3 = val_1.Item[1675191600];
            if(val_1 == 0)
            {
                goto label_5;
            }
            
            if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_1 = 0;
            }
            
            goto label_5;
            label_2:
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            label_5:
            this.payload = null;
            if((val_1.ContainsKey(key:  1623929152)) == false)
            {
                goto label_6;
            }
            
            object val_6 = val_1.Item[1623929152];
            val_43 = this;
            this.response = 0;
            goto label_10;
            label_6:
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_7 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            val_43 = this;
            this.response = null;
            if(null != 0)
            {
                goto label_68;
            }
            
            label_10:
            label_68:
            if((0.ContainsKey(key:  1622838032)) != false)
            {
                    val_44 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
                string val_9 = Item[1622838032];
                val_45 = this.response;
                val_46 = null;
                UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                this.error = null;
            }
            
            if((ContainsKey(key:  1129588480)) != false)
            {
                    string val_11 = Item[1129588480];
                string val_12 = ToString();
                this.endpoint = this.response;
            }
            
            if((ContainsKey(key:  1129588576)) != false)
            {
                    val_44 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
                string val_14 = Item[1129588576];
                val_45 = this.response;
                val_46 = null;
                UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                System.Collections.Generic.Dictionary<TKey, TValue> val_43 = val_43 ^ 1;
                this.enabled = val_43;
            }
            
            val_47 = "balance";
            if((ContainsKey(key:  -1820671456)) != false)
            {
                    string val_16 = Item[-1820671456];
                System.Nullable<System.Double> val_19 = new System.Nullable<System.Double>(value:  System.Math.Round(value:  System.Convert.ToDouble(value:  78753792), digits:  78753792));
            }
            
            if((ContainsKey(key:  1129588672)) != false)
            {
                    string val_21 = Item[1129588672];
                System.Nullable<System.Int32> val_23 = new System.Nullable<System.Int32>(value:  System.Convert.ToInt32(value:  78753792));
                this.entries = val_23.HasValue;
            }
            
            val_48 = "last";
            if((ContainsKey(key:  1129588768)) != false)
            {
                    string val_25 = Item[1129588768];
                if((0.ContainsKey(key:  -1820671456)) != false)
            {
                    string val_27 = 0.Item[-1820671456];
                val_47 = 0;
                System.Nullable<System.Double> val_30 = new System.Nullable<System.Double>(value:  System.Math.Round(value:  System.Convert.ToDouble(value:  0), digits:  0));
            }
            
                if((0.ContainsKey(key:  1129588672)) != false)
            {
                    string val_32 = 0.Item[1129588672];
                val_48 = 0;
                System.Nullable<System.Int32> val_34 = new System.Nullable<System.Int32>(value:  System.Convert.ToInt32(value:  0));
                this.lastEntries = val_34.HasValue;
            }
            
            }
            
            if((System.String.op_Equality(a:  this.endpoint, b:  1129588848)) == false)
            {
                    return;
            }
            
            if((ContainsKey(key:  1129593040)) != false)
            {
                    string val_37 = Item[1129593040];
                string val_38 = ToString();
                this.session = this.response;
            }
            
            val_48 = "device";
            if((this.payload.ContainsKey(key:  -1824276880)) == false)
            {
                    return;
            }
            
            val_47 = 1152921510385703632;
            object val_40 = this.payload.Item[-1824276880];
            val_48 = 1;
            if((0.ContainsKey(key:  1956388528)) == false)
            {
                    return;
            }
            
            string val_42 = 0.Item[1956388528];
            this.deviceHash = 0;
        }
    
    }

}
