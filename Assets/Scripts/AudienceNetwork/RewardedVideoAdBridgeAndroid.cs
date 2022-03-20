using UnityEngine;

namespace AudienceNetwork
{
    internal class RewardedVideoAdBridgeAndroid : RewardedVideoAdBridge
    {
        // Fields
        private static System.Collections.Generic.Dictionary<int, AudienceNetwork.RewardedVideoAdContainer> rewardedVideoAds;
        private static int lastKey;
        
        // Methods
        private UnityEngine.AndroidJavaObject RewardedVideoAdForUniqueId(int uniqueId)
        {
            null = null;
            if((AudienceNetwork.RewardedVideoAdBridgeAndroid.rewardedVideoAds.TryGetValue(key:  uniqueId, value: out  AudienceNetwork.RewardedVideoAdContainer val_1 = 1329073676)) == false)
            {
                    return;
            }
        
        }
        private AudienceNetwork.RewardedVideoAdContainer RewardedVideoAdContainerForUniqueId(int uniqueId)
        {
            null = null;
            bool val_2 = AudienceNetwork.RewardedVideoAdBridgeAndroid.rewardedVideoAds.TryGetValue(key:  uniqueId, value: out  AudienceNetwork.RewardedVideoAdContainer val_1 = 1329185676);
            if(val_2 == true)
            {
                    val_2 = 0;
            }
        
        }
        private string GetStringForuniqueId(int uniqueId, string method)
        {
            bool val_3;
            var val_4;
            val_3 = static_value_021FDB6E;
            if(val_3 != true)
            {
                    val_3 = true;
            }
            
            UnityEngine.AndroidJavaObject val_1 = this.RewardedVideoAdForUniqueId(uniqueId:  uniqueId);
            if(val_3 == 0)
            {
                    return;
            }
            
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_4 == 1)
            {
                    val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_2 = val_3.Call<UnityEngine.AndroidJavaObject>(methodName:  method, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        private string GetImageURLForuniqueId(int uniqueId, string method)
        {
            bool val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_4 = static_value_021FDB6F;
            if(val_4 != true)
            {
                    val_4 = true;
            }
            
            UnityEngine.AndroidJavaObject val_1 = this.RewardedVideoAdForUniqueId(uniqueId:  uniqueId);
            val_5 = 0;
            if(val_4 == 0)
            {
                    return;
            }
            
            val_6 = val_4;
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_7 == 1)
            {
                    val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_2 = val_6.Call<UnityEngine.AndroidJavaObject>(methodName:  method, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            if(val_6 == 0)
            {
                    return;
            }
            
            val_6 = public static T[] System.Array::Empty<System.Object>();
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_8 == 1)
            {
                    val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_3 = val_6.Call<UnityEngine.AndroidJavaObject>(methodName:  1298010048, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            val_5 = val_6;
        }
        public override int Create(string placementId, AudienceNetwork.RewardData rewardData, AudienceNetwork.RewardedVideoAd rewardedVideoAd)
        {
            var val_8;
            UnityEngine.AndroidJavaObject val_9;
            var val_10;
            AudienceNetwork.Utility.AdUtility.Prepare();
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1282230784);
            object val_2 = GetStatic<System.Object>(fieldName:  1282231936);
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_8 == 1)
            {
                    val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_3 = Call<UnityEngine.AndroidJavaObject>(methodName:  1289746816, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            typeof(System.Object[]).__il2cppRuntimeField_14 = placementId;
            val_9 = 0;
            UnityEngine.AndroidJavaObject val_4 = new UnityEngine.AndroidJavaObject(className:  1329538368, args:  472754880);
            AudienceNetwork.RewardedVideoAdBridgeListenerProxy val_5 = new AudienceNetwork.RewardedVideoAdBridgeListenerProxy(rewardedVideoAd:  rewardedVideoAd, bridgedRewardedVideoAd:  179179520);
            if(rewardData != 0)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = rewardData.<UserId>k__BackingField;
                typeof(System.Object[]).__il2cppRuntimeField_14 = rewardData.<Currency>k__BackingField;
                val_9 = null;
                val_9 = new UnityEngine.AndroidJavaObject(className:  1329546704, args:  472754880);
            }
            
            typeof(AudienceNetwork.RewardedVideoAdContainer).__il2cppRuntimeField_8 = rewardedVideoAd;
            if(new System.Object() != 0)
            {
                    typeof(AudienceNetwork.RewardedVideoAdContainer).__il2cppRuntimeField_30 = val_5;
                typeof(AudienceNetwork.RewardedVideoAdContainer).__il2cppRuntimeField_34 = null;
            }
            else
            {
                    mem[52] = null;
                mem[48] = val_5;
            }
            
            typeof(AudienceNetwork.RewardedVideoAdContainer).__il2cppRuntimeField_38 = val_9;
            val_10 = null;
            val_10 = null;
            AudienceNetwork.RewardedVideoAdBridgeAndroid.rewardedVideoAds.Add(key:  AudienceNetwork.RewardedVideoAdBridgeAndroid.lastKey, value:  469274624);
            int val_8 = AudienceNetwork.RewardedVideoAdBridgeAndroid.lastKey;
            val_8 = val_8 + 1;
            AudienceNetwork.RewardedVideoAdBridgeAndroid.lastKey = val_8;
            return (int)AudienceNetwork.RewardedVideoAdBridgeAndroid.lastKey;
        }
        public override int Load(int uniqueId)
        {
            AudienceNetwork.Utility.AdUtility.Prepare();
            AudienceNetwork.RewardedVideoAdContainer val_1 = this.RewardedVideoAdContainerForUniqueId(uniqueId:  uniqueId);
            if(this != 0)
            {
                    uniqueId = 0;
                this.Load(bidPayload:  null);
            }
            
            return (int)uniqueId;
        }
        public override int Load(int uniqueId, string bidPayload)
        {
            AudienceNetwork.Utility.AdUtility.Prepare();
            AudienceNetwork.RewardedVideoAdContainer val_1 = this.RewardedVideoAdContainerForUniqueId(uniqueId:  uniqueId);
            return (int)uniqueId;
        }
        public override bool IsValid(int uniqueId)
        {
            bool val_3;
            var val_4;
            val_3 = static_value_021FDB71;
            if(val_3 != true)
            {
                    val_3 = true;
            }
            
            UnityEngine.AndroidJavaObject val_1 = this.RewardedVideoAdForUniqueId(uniqueId:  uniqueId);
            if(val_3 == 0)
            {
                    return false;
            }
            
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_4 == 1)
            {
                    val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            bool val_2 = val_3.Call<System.Boolean>(methodName:  1298616800, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            val_2 = val_2 ^ 1;
            return (bool)val_2;
        }
        public override bool Show(int uniqueId)
        {
            AudienceNetwork.RewardedVideoAdContainer val_2 = new System.Object().RewardedVideoAdContainerForUniqueId(uniqueId:  uniqueId);
            UnityEngine.AndroidJavaObject val_3 = new System.Object().RewardedVideoAdForUniqueId(uniqueId:  uniqueId);
            typeof(RewardedVideoAdBridgeAndroid.<>c__DisplayClass10_0).__il2cppRuntimeField_8 = new System.Object();
            System.Action val_4 = new System.Action(object:  469221376, method:  new IntPtr(1330024528));
            mem[.ctor() + 8].ExecuteOnMainThread(action:  7454720);
            return true;
        }
        public override void SetExtraHints(int uniqueId, AudienceNetwork.ExtraHints extraHints)
        {
            bool val_3 = static_value_021FDB73;
            if(val_3 != true)
            {
                    val_3 = true;
            }
            
            AudienceNetwork.Utility.AdUtility.Prepare();
            UnityEngine.AndroidJavaObject val_1 = this.RewardedVideoAdForUniqueId(uniqueId:  uniqueId);
            if(val_3 == 0)
            {
                    return;
            }
            
            UnityEngine.AndroidJavaObject val_2 = extraHints.GetAndroidObject();
            typeof(System.Object[]).__il2cppRuntimeField_10 = extraHints;
            val_3.Call(methodName:  1298846128, args:  472754880);
        }
        public override void Release(int uniqueId)
        {
            bool val_3;
            var val_4;
            var val_5;
            val_3 = static_value_021FDB74;
            if(val_3 != true)
            {
                    val_3 = true;
            }
            
            UnityEngine.AndroidJavaObject val_1 = this.RewardedVideoAdForUniqueId(uniqueId:  uniqueId);
            if(val_3 != 0)
            {
                    val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
                if(val_4 == 1)
            {
                    val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
                val_3.Call(methodName:  1300295024, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            }
            
            val_5 = null;
            val_5 = null;
            bool val_2 = AudienceNetwork.RewardedVideoAdBridgeAndroid.rewardedVideoAds.Remove(key:  uniqueId);
        }
        public override void OnLoad(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback)
        {
        
        }
        public override void OnImpression(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback)
        {
        
        }
        public override void OnClick(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback)
        {
        
        }
        public override void OnError(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeErrorCallback callback)
        {
        
        }
        public override void OnWillClose(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback)
        {
        
        }
        public override void OnDidClose(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback)
        {
        
        }
        public override void OnActivityDestroyed(int uniqueId, AudienceNetwork.FBRewardedVideoAdBridgeCallback callback)
        {
        
        }
        public RewardedVideoAdBridgeAndroid()
        {
            this = new System.Object();
        }
        private static RewardedVideoAdBridgeAndroid()
        {
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            AudienceNetwork.RewardedVideoAdBridgeAndroid.rewardedVideoAds = null;
        }
    
    }

}
