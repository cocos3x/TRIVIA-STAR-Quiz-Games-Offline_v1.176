using UnityEngine;

namespace twelvegigs.Autopilot
{
    public class AutopilotTracker : Tracker
    {
        // Fields
        private string deviceId;
        private string clientVersion;
        
        // Methods
        public void InjectRegularGlobals(string eventName, System.Collections.Generic.Dictionary<string, object> globals)
        {
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            Player val_1 = App.Player;
            GameBehavior val_2 = App.getBehavior;
            GameBehavior val_3 = App.getBehavior;
            if(0 > 0)
            {
                    0 = 1;
            }
            
            string val_4 = 1.ToString();
            globals.Add(key:  1121668752, value:  1121682491);
            string val_6 = 0.NetworkPurchaser.ToString();
            globals.Add(key:  1121668848, value:  1121682491);
            globals.Add(key:  -1987496192, value:  13152256);
            string val_7 = ToString();
            globals.Add(key:  -1050425600, value:  1121682472);
            Player val_8 = App.Player;
            globals.Add(key:  -343208464, value:  8945664);
            Player val_9 = App.Player;
            globals.Add(key:  1121668960, value:  13152256);
            Player val_10 = App.Player;
            globals.Add(key:  -1930648224, value:  15282176);
            val_37 = 1152921504897900544;
            WGBonusRewardsHandler val_11 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            val_38 = 0;
            if((-1976887008) != 0)
            {
                    WGBonusRewardsHandler val_13 = DefaultHandler<WGBonusRewardsHandler>.Instance;
                val_38 = 0;
                if((IsActive(subPackage:  0)) != false)
            {
                    WGBonusRewardsHandler val_15 = DefaultHandler<WGBonusRewardsHandler>.Instance;
                SubscriptionModel val_16 = getCurrentModel(subPackage:  0);
            }
            
            }
            
            val_39 = 1152921504615792640;
            globals.Add(key:  1121669072, value:  8945664);
            Player val_17 = App.Player;
            globals.Add(key:  1121669200, value:  13152256);
            Player val_18 = App.Player;
            globals.Add(key:  1121669328, value:  8945664);
            Player val_19 = App.Player;
            globals.Add(key:  1121669456, value:  13152256);
            Player val_20 = App.Player;
            globals.Add(key:  -1875189520, value:  13152256);
            Player val_21 = App.Player;
            globals.Add(key:  -1875189408, value:  13152256);
            Player val_22 = App.Player;
            globals.Add(key:  -1875189312, value:  13152256);
            Player val_23 = App.Player;
            globals.Add(key:  -1875189200, value:  13152256);
            Player val_24 = App.Player;
            globals.Add(key:  -1875189088, value:  13152256);
            Player val_25 = App.Player;
            globals.Add(key:  -1875188976, value:  13152256);
            Player val_26 = App.Player;
            globals.Add(key:  1121669584, value:  15282176);
            int val_27 = TheLibraryLogic.LifetimeBooksPurchased;
            globals.Add(key:  1121669680, value:  13152256);
            int val_28 = TheLibraryLogic.LifetimeBooksEarned;
            globals.Add(key:  1121669808, value:  13152256);
            int val_29 = TheLibraryLogic.LibraryScore;
            globals.Add(key:  1121669920, value:  13152256);
            int val_30 = TheLibraryLogic.CountCompletedCollections();
            globals.Add(key:  1121670016, value:  13152256);
            int val_31 = TheLibraryLogic.LifetimeBookPacksPurchased;
            val_40 = 0;
            globals.Add(key:  1121670144, value:  13152256);
            if(val_40 == 0)
            {
                    return;
            }
            
            val_39 = 1152921504901095424;
            val_40 = 1152921511094568976;
            twelvegigs.Autopilot.AutopilotManager val_32 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_37 = 1152921504619999232;
            if((-2102212592) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_34 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            globals.Add(key:  1121670272, value:  13152256);
            twelvegigs.Autopilot.AutopilotManager val_35 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            globals.Add(key:  1121670400, value:  13152256);
        }
        public void InjectEventData(string eventName, System.Collections.Generic.Dictionary<string, object> data)
        {
            Player val_1 = App.Player;
            data.Add(key:  -1930531936, value:  1835037);
            data.Add(key:  -201586192, value:  this.deviceId);
            AppConfigs val_2 = App.Configuration;
            data.Add(key:  -233819456, value:  0);
            AppConfigs val_3 = App.Configuration;
            string val_4 = 0.Environment;
            data.Add(key:  1121803008, value:  0);
            AppConfigs val_5 = App.Configuration;
            data.Add(key:  1121803088, value:  4096);
            Player val_6 = App.Player;
            data.Add(key:  -1824276800, value:  33449456);
            string val_7 = DeviceProperties.Platform;
            data.Add(key:  -1928946992, value:  0);
            data.Add(key:  -1931031472, value:  this.clientVersion);
        }
        public override void trackEvent(string eventName, System.Collections.Generic.Dictionary<string, object> data)
        {
            ulong val_6;
            var val_14;
            bool val_15;
            bool val_16;
            val_14 = this;
            val_15 = static_value_021FD1DD;
            if(val_15 != true)
            {
                    val_15 = true;
            }
            
            twelvegigs.Autopilot.AutopilotRequester val_1 = twelvegigs.Autopilot.AutopilotManager.Requester;
            val_16 = val_15;
            if(1 == 0)
            {
                    return;
            }
            
            new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>().InjectRegularGlobals(eventName:  1469310912, globals:  78753792);
            this.InjectEventData(eventName:  1469310912, data:  data);
            if((data.ContainsKey(key:  1470901296)) != true)
            {
                    System.DateTime val_5 = System.DateTime.UtcNow;
                long val_8 = twelvegigs.storage.JsonDictionary.TotalSeconds(dateTime:  new System.DateTime() {dateData = val_6});
                val_14 = null;
                data.Add(key:  1470901296, value:  13205504);
            }
            
            if(data != 0)
            {
                    data.Add(key:  1121943840, value:  78753792);
            }
            else
            {
                    data.Add(key:  1121943840, value:  78753792);
            }
            
            data.Add(key:  1639488864, value:  eventName);
            val_16 = 1;
            if((System.String.op_Equality(a:  eventName, b:  1112912080)) != true)
            {
                    bool val_10 = System.String.op_Equality(a:  eventName, b:  1113679792);
                val_16 = val_10;
            }
            
            twelvegigs.Autopilot.AutopilotRequester val_11 = twelvegigs.Autopilot.AutopilotManager.Requester;
            bool val_12 = UnityEngine.Object.op_Equality(x:  val_10, y:  0);
            if(val_12 == true)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotRequester val_13 = twelvegigs.Autopilot.AutopilotManager.Requester;
            val_12.SendEvent(eventData:  data, sendImmediately:  val_16);
        }
        public override void identify(string id)
        {
            this.deviceId = id;
            string val_1 = DeviceIdPlugin.GetClientVersion();
            this.clientVersion = 0;
        }
        public override void trackEvent(string eventName, string propertyName, string propertyValue)
        {
        
        }
        public override void increment(string eventName, string eventValue)
        {
        
        }
        public override void peopleIncrement(string eventName, string eventValue)
        {
        
        }
        public override void peopleProperty(string propertyName, string propertyValue)
        {
        
        }
        public override void superProperty(string propertyName, string propertyValue)
        {
        
        }
        public override void trackCharge(string quantity, System.Collections.Generic.Dictionary<string, object> data)
        {
        
        }
        public AutopilotTracker()
        {
            this.clientVersion = System.String.alignConst;
        }
    
    }

}
