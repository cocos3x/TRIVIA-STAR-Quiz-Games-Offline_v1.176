using UnityEngine;

namespace WordForest
{
    public class UserForestProfile : EncodableModel
    {
        // Fields
        public int serverId;
        public int avatarId;
        public string name;
        public string facebookId;
        public int level;
        public int acorns;
        public int shields;
        public int raidsSent;
        public int raidsReceived;
        public int attacksSent;
        public int attacksReceived;
        public WordForest.Map map;
        public bool isOffline;
        private bool isDummyAccount;
        private bool <autoCreated>k__BackingField;
        public System.Collections.Generic.List<WordForest.NewsArticle> news;
        
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
            
            if((dict.ContainsKey(key:  -1110236928)) != false)
            {
                    object val_6 = dict.Item[-1110236928];
                string val_7 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  dict);
                object val_8 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  dict);
                this.news = dict;
            }
            
            if((dict.ContainsKey(key:  -1116517696)) == false)
            {
                    return;
            }
            
            object val_10 = dict.Item[-1116517696];
            string val_11 = dict.ToString();
            bool val_13 = System.Boolean.TryParse(value:  dict, result: out  bool val_12 = true);
            if(val_13 == true)
            {
                    val_13 = 0;
                this.<autoCreated>k__BackingField = false;
            }
        
        }
        public void Merge(WordForest.UserForestProfile model)
        {
            model.Merge(model:  model);
            this.map = model.map;
        }
        public static WordForest.UserForestProfile CreateDummyProfile(int baseLevel, bool flexibleBaseLevel = True, float minTreesNormalized = 0.4, float maxTreesNormalized = 0.99)
        {
            var val_17;
            var val_18;
            int val_19;
            var val_20;
            WordForest.WFOGameEcon val_1 = WordForest.WFOGameEcon.Instance;
            if(0 != 0)
            {
                    val_17 = 5761501;
            }
            else
            {
                    val_17 = 5761501;
            }
            
            WordForest.UserForestProfile val_4 = new WordForest.UserForestProfile();
            if(val_4 != 0)
            {
                    typeof(WordForest.UserForestProfile).__il2cppRuntimeField_39 = 1;
                val_18 = UnityEngine.Random.Range(min:  1, max:  1000);
            }
            else
            {
                    typeof(WordForest.UserForestProfile).__il2cppRuntimeField_39 = 1;
                int val_6 = UnityEngine.Random.Range(min:  1, max:  1000);
                val_18 = val_6;
            }
            
            val_6 = 0 - val_18;
            typeof(WordForest.UserForestProfile).__il2cppRuntimeField_8 = val_6;
            typeof(WordForest.UserForestProfile).__il2cppRuntimeField_C = UnityEngine.Random.Range(min:  0, max:  25);
            int val_8 = UnityEngine.Random.Range(min:  1000, max:  10000);
            string val_9 = System.String.Format(format:  259262208, arg0:  13152256);
            if(val_4 != 0)
            {
                    typeof(WordForest.UserForestProfile).__il2cppRuntimeField_10 = "Player{0}";
                val_19 = UnityEngine.Random.Range(min:  800, max:  8000);
            }
            else
            {
                    mem[16] = "Player{0}";
                val_19 = UnityEngine.Random.Range(min:  800, max:  8000);
            }
            
            typeof(WordForest.UserForestProfile).__il2cppRuntimeField_1C = val_19;
            val_20 = 0;
            float val_12 = UnityEngine.Random.Range(min:  minTreesNormalized, max:  maxTreesNormalized);
            var val_13 = 0 + 1392;
            if(val_4 > 0)
            {
                    0 = 1;
            }
            
            if(val_4 == 0)
            {
                    0 = 1;
            }
            
            typeof(WordForest.UserForestProfile).__il2cppRuntimeField_20 = 1;
            if(flexibleBaseLevel != false)
            {
                    val_20 = UnityEngine.Random.Range(min:  0, max:  2);
            }
            
            int val_15 = val_20 + (UnityEngine.Mathf.Max(a:  baseLevel, b:  UnityEngine.Mathf.Min(a:  5761501, b:  348)));
            typeof(WordForest.UserForestProfile).__il2cppRuntimeField_18 = val_15;
            WordForest.Map val_17 = WordForest.WFOGameEconHelper.CreateMap(forestLevel:  val_15, growthLevel:  0, growthPercent:  UnityEngine.Random.Range(min:  0, max:  maxTreesNormalized), dummyProfile:  R2);
            typeof(WordForest.UserForestProfile).__il2cppRuntimeField_34 = val_15;
        }
        public UserForestProfile()
        {
        
        }
    
    }

}
