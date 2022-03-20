using UnityEngine;

namespace SLC.Billing
{
    public class GoogleIAP
    {
        // Fields
        private static UnityEngine.AndroidJavaObject _plugin;
        
        // Methods
        private static GoogleIAP()
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
            if(0 != 11)
            {
                    return;
            }
            
            UnityEngine.AndroidJavaClass val_2 = new UnityEngine.AndroidJavaClass(className:  1094881392);
            val_6 = public static T[] System.Array::Empty<System.Object>();
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_7 == 1)
            {
                    val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_3 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            val_8 = 0;
            SLC.Billing.GoogleIAP._plugin = null;
            if(null == 0)
            {
                goto label_9;
            }
            
            UnityEngine.AndroidJavaClass val_5 = null;
            if((mem[null + 178]) == 0)
            {
                goto label_10;
            }
            
            val_6 = 0;
            label_12:
            val_9 = mem[mem[null + 88] + 0];
            val_9 = mem[null + 88] + 0;
            if(val_9 == null)
            {
                goto label_11;
            }
            
            val_6 = val_6 + 1;
            if(((uint)val_6 & 65535) < (mem[null + 178]))
            {
                goto label_12;
            }
            
            label_10:
            val_10 = null;
            goto label_13;
            label_11:
            var val_4 = (mem[null + 88]) + 0;
            val_5 = val_5 + (((mem[null + 88] + 0) + 4) << 3);
            label_13:
            label_9:
            if(val_8 == 0)
            {
                    return;
            }
        
        }
        public static void init(string publicKey)
        {
            var val_9;
            UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
            if(0 != 11)
            {
                    return;
            }
            
            WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if(1094997648 == 0)
            {
                    return;
            }
            
            WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            string val_5 = name;
            string val_6 = 1094998672 + 1094997648;
            UnityEngine.Debug.Log(message:  1094998672);
            val_9 = null;
            val_9 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = publicKey;
            WordPets.WPTDataParser val_7 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            string val_8 = name;
            typeof(System.Object[]).__il2cppRuntimeField_14 = public static SLC.Billing.GoogleIAPManager MonoSingletonSelfGenerating<SLC.Billing.GoogleIAPManager>::get_Instance();
            SLC.Billing.GoogleIAP._plugin.Call(methodName:  -1890606496, args:  472754880);
        }
        public static void purchaseProduct(string sku)
        {
            var val_7;
            UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
            if(0 != 11)
            {
                    return;
            }
            
            WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if(1094997648 == 0)
            {
                    UnityEngine.Debug.LogError(message:  1095118976);
                return;
            }
            
            string val_4 = 1095119184 + sku;
            UnityEngine.Debug.Log(message:  1095119184);
            val_7 = null;
            val_7 = null;
            WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            string val_6 = name;
            typeof(System.Object[]).__il2cppRuntimeField_10 = public static SLC.Billing.GoogleIAPManager MonoSingletonSelfGenerating<SLC.Billing.GoogleIAPManager>::get_Instance();
            typeof(System.Object[]).__il2cppRuntimeField_14 = sku;
            SLC.Billing.GoogleIAP._plugin.Call(methodName:  1095119312, args:  472754880);
        }
        public static void subscribe(string sku)
        {
            var val_7;
            UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
            if(0 != 11)
            {
                    return;
            }
            
            WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if(1094997648 == 0)
            {
                    UnityEngine.Debug.LogError(message:  1095118976);
                return;
            }
            
            string val_4 = 1095239616 + sku;
            UnityEngine.Debug.Log(message:  1095239616);
            val_7 = null;
            val_7 = null;
            WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            string val_6 = name;
            typeof(System.Object[]).__il2cppRuntimeField_10 = public static SLC.Billing.GoogleIAPManager MonoSingletonSelfGenerating<SLC.Billing.GoogleIAPManager>::get_Instance();
            typeof(System.Object[]).__il2cppRuntimeField_14 = sku;
            SLC.Billing.GoogleIAP._plugin.Call(methodName:  1095239728, args:  472754880);
        }
        public static void consumeProduct(string purchaseToken)
        {
            var val_6;
            UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
            if(0 != 11)
            {
                    return;
            }
            
            WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if(1094997648 == 0)
            {
                    UnityEngine.Debug.LogError(message:  1095118976);
                return;
            }
            
            val_6 = null;
            val_6 = null;
            WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            string val_5 = name;
            typeof(System.Object[]).__il2cppRuntimeField_10 = public static SLC.Billing.GoogleIAPManager MonoSingletonSelfGenerating<SLC.Billing.GoogleIAPManager>::get_Instance();
            typeof(System.Object[]).__il2cppRuntimeField_14 = purchaseToken;
            SLC.Billing.GoogleIAP._plugin.Call(methodName:  1095360016, args:  472754880);
        }
        public static void AcknowledgeProduct(string purchaseToken)
        {
            var val_6;
            UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
            if(0 != 11)
            {
                    return;
            }
            
            WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if(1094997648 == 0)
            {
                    UnityEngine.Debug.LogError(message:  1095118976);
                return;
            }
            
            val_6 = null;
            val_6 = null;
            WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            string val_5 = name;
            typeof(System.Object[]).__il2cppRuntimeField_10 = public static SLC.Billing.GoogleIAPManager MonoSingletonSelfGenerating<SLC.Billing.GoogleIAPManager>::get_Instance();
            typeof(System.Object[]).__il2cppRuntimeField_14 = purchaseToken;
            SLC.Billing.GoogleIAP._plugin.Call(methodName:  1095480304, args:  472754880);
        }
        public static void queryInventory(string[] products, string[] subscriptions)
        {
            var val_2;
            UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
            if(0 != 11)
            {
                    return;
            }
            
            val_2 = null;
            val_2 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = products;
            typeof(System.Object[]).__il2cppRuntimeField_14 = subscriptions;
            SLC.Billing.GoogleIAP._plugin.Call(methodName:  1095670240, args:  472754880);
        }
        public static void queryHistory()
        {
            var val_2;
            var val_3;
            UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
            if(0 != 11)
            {
                    return;
            }
            
            val_2 = null;
            val_2 = null;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_3 == 1)
            {
                    val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            SLC.Billing.GoogleIAP._plugin.Call(methodName:  1095856064, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        public GoogleIAP()
        {
        
        }
    
    }

}
