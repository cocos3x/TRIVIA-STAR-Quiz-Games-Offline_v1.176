using UnityEngine;

namespace AudienceNetwork
{
    internal class InterstitialAdBridgeAndroid : InterstitialAdBridge
    {
        // Fields
        private static System.Collections.Generic.Dictionary<int, AudienceNetwork.InterstitialAdContainer> interstitialAds;
        private static int lastKey;
        
        // Methods
        private UnityEngine.AndroidJavaObject InterstitialAdForuniqueId(int uniqueId)
        {
            null = null;
            if((AudienceNetwork.InterstitialAdBridgeAndroid.interstitialAds.TryGetValue(key:  uniqueId, value: out  AudienceNetwork.InterstitialAdContainer val_1 = 1312186108)) == false)
            {
                    return;
            }
        
        }
        private AudienceNetwork.InterstitialAdContainer InterstitialAdContainerForuniqueId(int uniqueId)
        {
            null = null;
            bool val_2 = AudienceNetwork.InterstitialAdBridgeAndroid.interstitialAds.TryGetValue(key:  uniqueId, value: out  AudienceNetwork.InterstitialAdContainer val_1 = 1312298108);
            if(val_2 == true)
            {
                    val_2 = 0;
            }
        
        }
        private string GetStringForuniqueId(int uniqueId, string method)
        {
            bool val_3;
            var val_4;
            val_3 = static_value_021FDB42;
            if(val_3 != true)
            {
                    val_3 = true;
            }
            
            UnityEngine.AndroidJavaObject val_1 = this.InterstitialAdForuniqueId(uniqueId:  uniqueId);
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
            val_4 = static_value_021FDB43;
            if(val_4 != true)
            {
                    val_4 = true;
            }
            
            UnityEngine.AndroidJavaObject val_1 = this.InterstitialAdForuniqueId(uniqueId:  uniqueId);
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
        public override int Create(string placementId, AudienceNetwork.InterstitialAd interstitialAd)
        {
            var val_7;
            var val_8;
            AudienceNetwork.Utility.AdUtility.Prepare();
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1282230784);
            object val_2 = GetStatic<System.Object>(fieldName:  1282231936);
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_7 == 1)
            {
                    val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_3 = Call<UnityEngine.AndroidJavaObject>(methodName:  1289746816, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            typeof(System.Object[]).__il2cppRuntimeField_14 = placementId;
            UnityEngine.AndroidJavaObject val_4 = new UnityEngine.AndroidJavaObject(className:  1312646704, args:  472754880);
            typeof(AudienceNetwork.InterstitialAdContainer).__il2cppRuntimeField_8 = interstitialAd;
            if(new System.Object() != 0)
            {
                    typeof(AudienceNetwork.InterstitialAdContainer).__il2cppRuntimeField_2C = null;
            }
            else
            {
                    mem[44] = null;
            }
            
            typeof(AudienceNetwork.InterstitialAdContainer).__il2cppRuntimeField_28 = new AudienceNetwork.InterstitialAdBridgeListenerProxy(interstitialAd:  interstitialAd, bridgedInterstitialAd:  179179520);
            val_8 = null;
            val_8 = null;
            AudienceNetwork.InterstitialAdBridgeAndroid.interstitialAds.Add(key:  AudienceNetwork.InterstitialAdBridgeAndroid.lastKey, value:  468582400);
            int val_7 = AudienceNetwork.InterstitialAdBridgeAndroid.lastKey;
            val_7 = val_7 + 1;
            AudienceNetwork.InterstitialAdBridgeAndroid.lastKey = val_7;
            return (int)AudienceNetwork.InterstitialAdBridgeAndroid.lastKey;
        }
        public override int Load(int uniqueId)
        {
            AudienceNetwork.Utility.AdUtility.Prepare();
            AudienceNetwork.InterstitialAdContainer val_1 = this.InterstitialAdContainerForuniqueId(uniqueId:  uniqueId);
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
            AudienceNetwork.InterstitialAdContainer val_1 = this.InterstitialAdContainerForuniqueId(uniqueId:  uniqueId);
            return (int)uniqueId;
        }
        public override bool IsValid(int uniqueId)
        {
            bool val_3;
            var val_4;
            val_3 = static_value_021FDB45;
            if(val_3 != true)
            {
                    val_3 = true;
            }
            
            UnityEngine.AndroidJavaObject val_1 = this.InterstitialAdForuniqueId(uniqueId:  uniqueId);
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
            bool val_2;
            var val_3;
            val_2 = static_value_021FDB46;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            UnityEngine.AndroidJavaObject val_1 = this.InterstitialAdForuniqueId(uniqueId:  uniqueId);
            if(val_2 == 0)
            {
                    return false;
            }
            
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_3 != 1)
            {
                    return val_2.Call<System.Boolean>(methodName:  -1352033280, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            }
            
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            return val_2.Call<System.Boolean>(methodName:  -1352033280, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        public override void Release(int uniqueId)
        {
            bool val_3;
            var val_4;
            var val_5;
            val_3 = static_value_021FDB47;
            if(val_3 != true)
            {
                    val_3 = true;
            }
            
            UnityEngine.AndroidJavaObject val_1 = this.InterstitialAdForuniqueId(uniqueId:  uniqueId);
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
            bool val_2 = AudienceNetwork.InterstitialAdBridgeAndroid.interstitialAds.Remove(key:  uniqueId);
        }
        public override void SetExtraHints(int uniqueId, AudienceNetwork.ExtraHints extraHints)
        {
            bool val_3 = static_value_021FDB48;
            if(val_3 != true)
            {
                    val_3 = true;
            }
            
            AudienceNetwork.Utility.AdUtility.Prepare();
            UnityEngine.AndroidJavaObject val_1 = this.InterstitialAdForuniqueId(uniqueId:  uniqueId);
            if(val_3 == 0)
            {
                    return;
            }
            
            UnityEngine.AndroidJavaObject val_2 = extraHints.GetAndroidObject();
            typeof(System.Object[]).__il2cppRuntimeField_10 = extraHints;
            val_3.Call(methodName:  1298846128, args:  472754880);
        }
        public override void OnLoad(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeCallback callback)
        {
        
        }
        public override void OnImpression(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeCallback callback)
        {
        
        }
        public override void OnClick(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeCallback callback)
        {
        
        }
        public override void OnError(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeErrorCallback callback)
        {
        
        }
        public override void OnWillClose(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeCallback callback)
        {
        
        }
        public override void OnDidClose(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeCallback callback)
        {
        
        }
        public override void OnActivityDestroyed(int uniqueId, AudienceNetwork.FBInterstitialAdBridgeCallback callback)
        {
        
        }
        public InterstitialAdBridgeAndroid()
        {
            this = new System.Object();
        }
        private static InterstitialAdBridgeAndroid()
        {
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            AudienceNetwork.InterstitialAdBridgeAndroid.interstitialAds = null;
        }
    
    }

}
