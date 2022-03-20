using UnityEngine;

namespace RestaurantRivals
{
    public class UserRestaurantProfile : EncodableModel
    {
        // Fields
        public int serverId;
        public int avatarId;
        public string name;
        public string facebookId;
        public int level;
        public decimal credits;
        public int stars;
        public int shields;
        public RestaurantRivals.Map map;
        private bool isDummyAccount;
        private bool <autoCreated>k__BackingField;
        
        // Properties
        public bool IsDummyAccount { get; set; }
        protected bool autoCreated { get; set; }
        
        // Methods
        public bool get_IsDummyAccount()
        {
            if(this.isDummyAccount == true)
            {
                    return true;
            }
            
            if((this.<autoCreated>k__BackingField) == true)
            {
                    this.<autoCreated>k__BackingField = 1;
            }
            
            return true;
        }
        public void set_IsDummyAccount(bool value)
        {
            this.isDummyAccount = value;
        }
        protected void set_autoCreated(bool value)
        {
            this.<autoCreated>k__BackingField = value;
        }
        protected bool get_autoCreated()
        {
            return (bool)this.<autoCreated>k__BackingField;
        }
        public override void Decode(System.Collections.Generic.Dictionary<string, object> dict, EncodableModel.TemplateModel sourceModel = 0)
        {
            this.Decode(jasonObject:  dict, sourceModel:  0);
            if((dict.ContainsKey(key:  259013552)) != false)
            {
                    object val_2 = dict.Item[259013552];
                string val_3 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  dict);
                object val_4 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  dict);
                this.map = dict;
            }
            
            if((dict.ContainsKey(key:  -1116517696)) == false)
            {
                    return;
            }
            
            object val_6 = dict.Item[-1116517696];
            string val_7 = dict.ToString();
            bool val_9 = System.Boolean.TryParse(value:  dict, result: out  bool val_8 = true);
            if(val_9 == true)
            {
                    val_9 = 0;
                this.<autoCreated>k__BackingField = false;
            }
        
        }
        public void Merge(RestaurantRivals.UserRestaurantProfile model)
        {
            model.Merge(model:  model);
            this.map = model.map;
        }
        public void ProgressMapForAttack()
        {
            RestaurantRivals.Map val_1 = RestaurantRivals.RESGameEconHelper.ProgressMapForAttack(level:  this.level, map:  this.map);
            this.map = this.level;
        }
        public static RestaurantRivals.UserRestaurantProfile CreateDummyProfile(int baseLevel, bool forAttack = False, int objectAmount = -1)
        {
            int val_12;
            var val_13;
            int val_14;
            var val_15;
            var val_16;
            var val_17;
            RestaurantRivals.RESGameEcon val_1 = RestaurantRivals.RESGameEcon.Instance;
            val_12 = UnityEngine.Mathf.Clamp(value:  baseLevel, min:  1, max:  200);
            RestaurantRivals.UserRestaurantProfile val_3 = new RestaurantRivals.UserRestaurantProfile();
            if(val_3 != 0)
            {
                    typeof(RestaurantRivals.UserRestaurantProfile).__il2cppRuntimeField_38 = 1;
                val_13 = UnityEngine.Random.Range(min:  1, max:  1000);
            }
            else
            {
                    mem[56] = 1;
                int val_5 = UnityEngine.Random.Range(min:  1, max:  1000);
                val_13 = val_5;
            }
            
            val_5 = 0 - val_13;
            typeof(RestaurantRivals.UserRestaurantProfile).__il2cppRuntimeField_8 = val_5;
            typeof(RestaurantRivals.UserRestaurantProfile).__il2cppRuntimeField_C = UnityEngine.Random.Range(min:  0, max:  25);
            int val_7 = UnityEngine.Random.Range(min:  1000, max:  10000);
            string val_8 = System.String.Format(format:  259262208, arg0:  13152256);
            if(val_3 != 0)
            {
                    val_14 = val_3;
                typeof(RestaurantRivals.UserRestaurantProfile).__il2cppRuntimeField_18 = val_12;
                RestaurantRivals.UserRestaurantProfile.__il2cppRuntimeField_this_arg.__il2cppRuntimeField_18 = 0;
                RestaurantRivals.UserRestaurantProfile.__il2cppRuntimeField_this_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFF8 = "Player{0}";
            }
            else
            {
                    mem[16] = "Player{0}";
                mem[48] = 0;
                val_14 = 24;
                mem[24] = val_12;
                val_12 = mem[24];
            }
            
            val_15 = null;
            val_15 = null;
            decimal val_9 = RestaurantRivals.RESGameEconHelper.GetRaidTreasureAmount(level:  597247744, maxValueLimit:  new System.Decimal() {flags = val_12, hi = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_C});
            if(val_3 != 0)
            {
                
            }
            
            typeof(RestaurantRivals.UserRestaurantProfile).__il2cppRuntimeField_2C = 0;
            if(objectAmount != 1)
            {
                    RestaurantRivals.Map val_10 = RestaurantRivals.RESGameEconHelper.CreateFTUXDummyMap(level:  val_14, progress:  objectAmount);
            }
            else
            {
                    if(forAttack != false)
            {
                    val_16 = 1;
                val_17 = 1;
            }
            else
            {
                    val_16 = 0;
                val_17 = 0;
            }
            
                RestaurantRivals.Map val_11 = RestaurantRivals.RESGameEconHelper.CreateDummyMap(level:  val_14, minObjects:  0, forAttack:  false);
            }
            
            typeof(RestaurantRivals.UserRestaurantProfile).__il2cppRuntimeField_34 = val_14;
        }
        public UserRestaurantProfile()
        {
        
        }
    
    }

}
