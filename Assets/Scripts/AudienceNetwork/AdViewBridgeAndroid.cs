using UnityEngine;

namespace AudienceNetwork
{
    internal class AdViewBridgeAndroid : AdViewBridge
    {
        // Fields
        private static System.Collections.Generic.Dictionary<int, AudienceNetwork.AdViewContainer> adViews;
        private static int lastKey;
        
        // Methods
        private UnityEngine.AndroidJavaObject AdViewForAdViewId(int uniqueId)
        {
            null = null;
            if((AudienceNetwork.AdViewBridgeAndroid.adViews.TryGetValue(key:  uniqueId, value: out  AudienceNetwork.AdViewContainer val_1 = 1297673740)) == false)
            {
                    return;
            }
        
        }
        private AudienceNetwork.AdViewContainer AdViewContainerForAdViewId(int uniqueId)
        {
            null = null;
            bool val_2 = AudienceNetwork.AdViewBridgeAndroid.adViews.TryGetValue(key:  uniqueId, value: out  AudienceNetwork.AdViewContainer val_1 = 1297785740);
            if(val_2 == true)
            {
                    val_2 = 0;
            }
        
        }
        private string GetStringForAdViewId(int uniqueId, string method)
        {
            bool val_3;
            var val_4;
            val_3 = static_value_021FDB0F;
            if(val_3 != true)
            {
                    val_3 = true;
            }
            
            UnityEngine.AndroidJavaObject val_1 = this.AdViewForAdViewId(uniqueId:  uniqueId);
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
        private string GetImageURLForAdViewId(int uniqueId, string method)
        {
            bool val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_4 = static_value_021FDB10;
            if(val_4 != true)
            {
                    val_4 = true;
            }
            
            UnityEngine.AndroidJavaObject val_1 = this.AdViewForAdViewId(uniqueId:  uniqueId);
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
        private UnityEngine.AndroidJavaObject JavaAdSizeFromAdSize(AudienceNetwork.AdSize size)
        {
            var val_3;
            var val_4;
            val_3 = 0;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1298130320);
            if(size == 2)
            {
                goto label_1;
            }
            
            if(size == 1)
            {
                goto label_2;
            }
            
            if(size != 0)
            {
                    return;
            }
            
            val_4 = "BANNER_HEIGHT_50";
            goto label_5;
            label_1:
            val_4 = "RECTANGLE_HEIGHT_250";
            goto label_5;
            label_2:
            val_4 = "BANNER_HEIGHT_90";
            label_5:
            object val_2 = GetStatic<System.Object>(fieldName:  1298130672);
            val_3 = null;
        }
        public override int Create(string placementId, AudienceNetwork.AdView adView, AudienceNetwork.AdSize size)
        {
            var val_8;
            var val_9;
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
            UnityEngine.AndroidJavaObject val_4 = System.Object[].__il2cppRuntimeField_namespaze.JavaAdSizeFromAdSize(size:  size);
            typeof(System.Object[]).__il2cppRuntimeField_18 = System.Object[].__il2cppRuntimeField_namespaze;
            UnityEngine.AndroidJavaObject val_5 = new UnityEngine.AndroidJavaObject(className:  1298259168, args:  472754880);
            typeof(AudienceNetwork.AdViewContainer).__il2cppRuntimeField_8 = adView;
            if(new System.Object() != 0)
            {
                    typeof(AudienceNetwork.AdViewContainer).__il2cppRuntimeField_24 = null;
            }
            else
            {
                    mem[36] = null;
            }
            
            typeof(AudienceNetwork.AdViewContainer).__il2cppRuntimeField_20 = new AudienceNetwork.AdViewBridgeListenerProxy(adView:  adView, bridgedAdView:  179179520);
            val_9 = null;
            val_9 = null;
            AudienceNetwork.AdViewBridgeAndroid.adViews.Add(key:  AudienceNetwork.AdViewBridgeAndroid.lastKey, value:  467836928);
            int val_8 = AudienceNetwork.AdViewBridgeAndroid.lastKey;
            val_8 = val_8 + 1;
            AudienceNetwork.AdViewBridgeAndroid.lastKey = val_8;
            return (int)AudienceNetwork.AdViewBridgeAndroid.lastKey;
        }
        public override int Load(int uniqueId)
        {
            AudienceNetwork.Utility.AdUtility.Prepare();
            AudienceNetwork.AdViewContainer val_1 = this.AdViewContainerForAdViewId(uniqueId:  uniqueId);
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
            AudienceNetwork.AdViewContainer val_1 = this.AdViewContainerForAdViewId(uniqueId:  uniqueId);
            return (int)uniqueId;
        }
        public override bool IsValid(int uniqueId)
        {
            bool val_3;
            var val_4;
            val_3 = static_value_021FDB13;
            if(val_3 != true)
            {
                    val_3 = true;
            }
            
            UnityEngine.AndroidJavaObject val_1 = this.AdViewForAdViewId(uniqueId:  uniqueId);
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
        public override bool Show(int uniqueId, double x, double y, double width, double height)
        {
            float val_1;
            float val_2;
            float val_3;
            float val_10;
            UnityEngine.AndroidJavaRunnable val_11;
            object val_12;
            var val_13;
            var val_14;
            val_10 = R2;
            val_11 = 35642132;
            val_12 = null;
            val_12 = new System.Object();
            if(val_12 != 0)
            {
                    typeof(AdViewBridgeAndroid.<>c__DisplayClass11_0).__il2cppRuntimeField_10 = val_2;
                typeof(AdViewBridgeAndroid.<>c__DisplayClass11_0).__il2cppRuntimeField_18 = val_1;
                typeof(AdViewBridgeAndroid.<>c__DisplayClass11_0).__il2cppRuntimeField_28 = val_10;
                typeof(AdViewBridgeAndroid.<>c__DisplayClass11_0).__il2cppRuntimeField_30 = val_3;
                UnityEngine.AndroidJavaObject val_4 = val_12.AdViewForAdViewId(uniqueId:  uniqueId);
                typeof(AdViewBridgeAndroid.<>c__DisplayClass11_0).__il2cppRuntimeField_20 = val_12;
            }
            else
            {
                    mem[16] = val_2;
                mem[24] = val_1;
                mem[40] = val_10;
                mem[48] = val_3;
                UnityEngine.AndroidJavaObject val_5 = mem[48].AdViewForAdViewId(uniqueId:  uniqueId);
                val_10 = 32;
                mem[32] = 48;
                val_12 = mem[32];
            }
            
            if(val_12 == 0)
            {
                goto label_3;
            }
            
            UnityEngine.AndroidJavaClass val_6 = new UnityEngine.AndroidJavaClass(className:  1282230784);
            object val_7 = GetStatic<System.Object>(fieldName:  1282231936);
            if(val_12 == 0)
            {
                goto label_5;
            }
            
            val_13 = val_12;
            typeof(AdViewBridgeAndroid.<>c__DisplayClass11_0).__il2cppRuntimeField_8 = null;
            goto label_6;
            label_3:
            val_14 = 0;
            return (bool)val_14;
            label_5:
            val_13 = 8;
            mem[8] = null;
            label_6:
            val_10 = null;
            val_11 = null;
            val_11 = new UnityEngine.AndroidJavaRunnable(object:  467730432, method:  new IntPtr(1298728912));
            typeof(System.Object[]).__il2cppRuntimeField_10 = val_11;
            Call(methodName:  1298729936, args:  472754880);
            val_14 = 1;
            return (bool)val_14;
        }
        public override void SetExtraHints(int uniqueId, AudienceNetwork.ExtraHints extraHints)
        {
            bool val_3 = static_value_021FDB15;
            if(val_3 != true)
            {
                    val_3 = true;
            }
            
            UnityEngine.AndroidJavaObject val_1 = this.AdViewForAdViewId(uniqueId:  uniqueId);
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
            var val_7;
            object val_1 = new System.Object();
            UnityEngine.AndroidJavaClass val_2 = new UnityEngine.AndroidJavaClass(className:  1282230784);
            object val_3 = GetStatic<System.Object>(fieldName:  1282231936);
            UnityEngine.AndroidJavaObject val_4 = AdViewForAdViewId(uniqueId:  uniqueId);
            typeof(AdViewBridgeAndroid.<>c__DisplayClass13_0).__il2cppRuntimeField_8 = null;
            val_7 = null;
            val_7 = null;
            bool val_5 = AudienceNetwork.AdViewBridgeAndroid.adViews.Remove(key:  uniqueId);
            UnityEngine.AndroidJavaRunnable val_6 = new UnityEngine.AndroidJavaRunnable(object:  467783680, method:  new IntPtr(1298963344));
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            Call(methodName:  1298729936, args:  472754880);
        }
        public override void OnLoad(int uniqueId, AudienceNetwork.FBAdViewBridgeCallback callback)
        {
        
        }
        public override void OnImpression(int uniqueId, AudienceNetwork.FBAdViewBridgeCallback callback)
        {
        
        }
        public override void OnClick(int uniqueId, AudienceNetwork.FBAdViewBridgeCallback callback)
        {
        
        }
        public override void OnError(int uniqueId, AudienceNetwork.FBAdViewBridgeErrorCallback callback)
        {
        
        }
        public override void OnFinishedClick(int uniqueId, AudienceNetwork.FBAdViewBridgeCallback callback)
        {
        
        }
        public AdViewBridgeAndroid()
        {
            this = new System.Object();
        }
        private static AdViewBridgeAndroid()
        {
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            AudienceNetwork.AdViewBridgeAndroid.adViews = null;
        }
    
    }

}
