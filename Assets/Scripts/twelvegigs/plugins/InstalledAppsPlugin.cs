using UnityEngine;

namespace twelvegigs.plugins
{
    public class InstalledAppsPlugin
    {
        // Fields
        public const string ON_INSTALLEDAPPS_RESPONDED = "OnInstalledAppsResponded";
        private const string SAVE_GAME_NETWORK_KEY = "InstallApp_SavedGameNetwork";
        private const string IMAGE_SERVER_URL = "https://cdn.12gigs.com/network_games/";
        private static twelvegigs.plugins.InstalledAppsPlugin.GameApp[] appsToCheckForPlatform;
        private static System.Collections.Generic.List<object> <NetworkPromos>k__BackingField;
        private static string lastResponse;
        private static bool initialized;
        private static bool fetching;
        private static bool fetched;
        private static UnityEngine.AndroidJavaObject plugin;
        private static string[] availablePackagesAndroid;
        private static string[] availablePackagesKindle;
        private static string[] availablePackagesIOS;
        
        // Properties
        public static twelvegigs.plugins.InstalledAppsPlugin.GameApp[] PackagesToCheck { get; set; }
        public static System.Collections.Generic.List<object> NetworkPromos { get; set; }
        public static string LastResponse { get; }
        public static bool Fetched { get; }
        
        // Methods
        public static twelvegigs.plugins.InstalledAppsPlugin.GameApp[] get_PackagesToCheck()
        {
            twelvegigs.plugins.InstalledAppsPlugin.Init();
        }
        public static void set_PackagesToCheck(twelvegigs.plugins.InstalledAppsPlugin.GameApp[] value)
        {
            null = null;
            twelvegigs.plugins.InstalledAppsPlugin.appsToCheckForPlatform = value;
        }
        public static System.Collections.Generic.List<object> get_NetworkPromos()
        {
            null = null;
        }
        public static void set_NetworkPromos(System.Collections.Generic.List<object> value)
        {
            null = null;
            twelvegigs.plugins.InstalledAppsPlugin.<NetworkPromos>k__BackingField = value;
        }
        public static string get_LastResponse()
        {
            null = null;
        }
        public static bool get_Fetched()
        {
            null = null;
            return (bool)twelvegigs.plugins.InstalledAppsPlugin.fetched;
        }
        private static void InitializeDefaultAppsToCheckFor()
        {
            var val_2;
            var val_3;
            System.String[] val_4;
            var val_5;
            var val_6;
            var val_8;
            val_2 = 1152921505065738240;
            twelvegigs.plugins.InstalledAppsPlugin.LoadNetworkGamesInfo();
            if(twelvegigs.plugins.InstalledAppsPlugin.appsToCheckForPlatform != null)
            {
                    return;
            }
            
            var val_2 = 9648732;
            val_2 = 26016468 + val_2;
            if(val_2 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_3 = null;
            val_3 = null;
            val_4 = twelvegigs.plugins.InstalledAppsPlugin.availablePackagesAndroid;
            val_5 = 0;
            val_6 = 16;
            twelvegigs.plugins.InstalledAppsPlugin.appsToCheckForPlatform = null;
            val_8 = null;
        }
        public static void Init()
        {
            var val_4;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_4 = 9612677;
            val_4 = 26014748 + val_4;
            if(val_4 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_4 = null;
            val_4 = null;
            if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE == null)
            {
                    return;
            }
            
            val_5 = 1152921505065738240;
            val_6 = null;
            val_6 = null;
            if(twelvegigs.plugins.InstalledAppsPlugin.initialized != true)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1142536528);
                val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
                if(val_7 == 1)
            {
                    val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
                UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
                val_8 = null;
                val_8 = null;
                twelvegigs.plugins.InstalledAppsPlugin.plugin = null;
                twelvegigs.plugins.InstalledAppsPlugin.InitializeDefaultAppsToCheckFor();
                val_6 = null;
                twelvegigs.plugins.InstalledAppsPlugin.initialized = true;
            }
            
            val_6 = null;
            if(twelvegigs.plugins.InstalledAppsPlugin.fetched == true)
            {
                    return;
            }
            
            val_6 = null;
            if(twelvegigs.plugins.InstalledAppsPlugin.fetching == true)
            {
                    return;
            }
            
            val_9 = 1152921505065742349;
            twelvegigs.plugins.InstalledAppsPlugin.fetching = true;
            var val_5 = 9610646;
            val_5 = 26015412 + val_5;
            if(val_5 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_10 = null;
            val_10 = null;
            val_5 = 0;
            System.Action<System.Threading.Tasks.Task, System.Object> val_3 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(1142536688));
            App.networkManager.DoGet(path:  1142537712, onCompleteFunction:  7507968, destroy:  true, immediate:  false, getParams:  val_5, timeout:  20);
        }
        public static void UpdatePromos()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            var val_1 = 9609125;
            val_1 = 26017448 + val_1;
            twelvegigs.plugins.InstalledAppsPlugin.fetched = false;
            if(val_1 == 0)
            {
                    val_1 = null;
                mem2[0] = 1;
            }
            
            val_1 = null;
            if((twelvegigs.plugins.InstalledAppsPlugin.<NetworkPromos>k__BackingField) != 0)
            {
                    if(val_1 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_2 = null;
                val_2 = null;
                twelvegigs.plugins.InstalledAppsPlugin.<NetworkPromos>k__BackingField.Clear();
                val_1 = null;
            }
            
            twelvegigs.plugins.InstalledAppsPlugin.Init();
        }
        private static void onNetworkResponse_MoreGames(string method, System.Collections.Generic.Dictionary<string, object> data)
        {
            var val_8;
            var val_9;
            var val_10;
            if(data == 0)
            {
                    return;
            }
            
            val_8 = 1152921510392296080;
            if((data.ContainsKey(key:  1616271776)) == false)
            {
                    return;
            }
            
            object val_2 = data.Item[1616271776];
            val_9 = null;
            data.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(null == 0)
            {
                    return;
            }
            
            if((data.ContainsKey(key:  1142771040)) == false)
            {
                    return;
            }
            
            string val_4 = PrettyPrint.printJSON(obj:  data, types:  false, singleLineOutput:  false);
            val_10 = null;
            val_10 = null;
            twelvegigs.plugins.InstalledAppsPlugin.lastResponse = data;
            object val_5 = data.Item[1142771040];
            twelvegigs.plugins.InstalledAppsPlugin.SaveNetworkGamesInfo(networkGames:  0);
            twelvegigs.plugins.InstalledAppsPlugin.CreateGameAppFromNetwork(networkGames:  0);
            twelvegigs.plugins.InstalledAppsPlugin.fetched = true;
            twelvegigs.plugins.InstalledAppsPlugin.fetching = false;
            NotificationCenter val_6 = NotificationCenter.DefaultCenter;
            System.Collections.Hashtable val_7 = null;
            val_9 = val_7;
            val_7 = new System.Collections.Hashtable();
            0.PostNotification(aSender:  0, aName:  -309439040, aData:  75878400);
        }
        private static void SaveNetworkGamesInfo(System.Collections.Generic.List<object> networkGames)
        {
            string val_1 = MiniJSON.Json.Serialize(obj:  networkGames);
            UnityEngine.PlayerPrefs.SetString(key:  1142895424, value:  networkGames);
            bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
        }
        private static void LoadNetworkGamesInfo()
        {
            System.Collections.Generic.List<System.Object> val_4;
            var val_5;
            string val_6;
            if((UnityEngine.PlayerPrefs.HasKey(key:  1142895424)) == false)
            {
                    return;
            }
            
            val_5 = 0;
            val_6 = mem[R4];
            val_6 = R4;
            string val_2 = UnityEngine.PlayerPrefs.GetString(key:  val_6, defaultValue:  -2141227328);
            object val_3 = MiniJSON.Json.Deserialize(json:  val_6);
            if(val_6 != 0)
            {
                    val_4 = val_6;
                if((R4 + 12) == 0)
            {
                    return;
            }
            
                twelvegigs.plugins.InstalledAppsPlugin.CreateGameAppFromNetwork(networkGames:  val_4);
                return;
            }
        
        }
        private static void CreateGameAppFromNetwork(System.Collections.Generic.List<object> networkGames)
        {
            var val_12;
            var val_13;
            val_12 = null;
            val_12 = null;
            var val_13 = 0;
            twelvegigs.plugins.InstalledAppsPlugin.appsToCheckForPlatform = null;
            List.Enumerator<T> val_1 = GetEnumerator();
            var val_12 = 16;
            label_20:
            if(MoveNext() == false)
            {
                goto label_4;
            }
            
            string val_4 = 0.Item[1679334848];
            string val_5 = 0.Item[-1830072288];
            string val_6 = 0.Trim();
            string val_7 = 0.Item[-270412704];
            InstalledAppsPlugin.GameApp val_8 = new InstalledAppsPlugin.GameApp(gameName:  null, packageName:  null, assetName:  null);
            string val_9 = -268809296(-268809296) + null;
            bool val_11 = twelvegigs.net.ImageRequest.LoadFromPreCache(filename:  -268809296, textureToSet: out  UnityEngine.Texture2D val_10 = 1143139700);
            val_13 = null;
            val_13 = null;
            val_12 = val_12 + 16;
            val_13 = val_13 + 1;
            goto label_20;
            label_4:
            Dispose();
        }
        public static void UpdateInstalledApps()
        {
            var val_16;
            bool val_17;
            var val_18;
            val_16 = null;
            val_16 = null;
            if(twelvegigs.plugins.InstalledAppsPlugin.initialized != true)
            {
                    twelvegigs.plugins.InstalledAppsPlugin.Init();
                val_16 = null;
            }
            
            val_16 = null;
            if(twelvegigs.plugins.InstalledAppsPlugin.fetched == false)
            {
                    return;
            }
            
            GameApp[] val_1 = twelvegigs.plugins.InstalledAppsPlugin.PackagesToCheck;
            if(val_16 == 0)
            {
                    return;
            }
            
            GameApp[] val_2 = twelvegigs.plugins.InstalledAppsPlugin.PackagesToCheck;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_17 = 0;
            GameApp[] val_7 = twelvegigs.plugins.InstalledAppsPlugin.PackagesToCheck;
            T[] val_8 = ToArray();
            System.Collections.Generic.Dictionary<System.String, System.Boolean> val_9 = twelvegigs.plugins.InstalledAppsPlugin.GetInstalledApps(packagesNames:  80883712);
            val_18 = 0;
            GameApp[] val_15 = twelvegigs.plugins.InstalledAppsPlugin.PackagesToCheck;
        }
        private static System.Collections.Generic.Dictionary<string, bool> GetInstalledApps(string[] packagesNames)
        {
            var val_7;
            System.Type val_8;
            var val_9;
            System.String[] val_10;
            var val_11;
            System.Collections.Generic.Dictionary<System.Type, System.Boolean> val_1 = new System.Collections.Generic.Dictionary<System.Type, System.Boolean>();
            val_7 = null;
            val_7 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = packagesNames;
            UnityEngine.AndroidJavaObject val_2 = twelvegigs.plugins.InstalledAppsPlugin.plugin.Call<UnityEngine.AndroidJavaObject>(methodName:  1143392704, args:  472754880);
            val_8 = twelvegigs.plugins.InstalledAppsPlugin.plugin;
            System.Collections.Generic.List<System.Boolean> val_3 = new System.Collections.Generic.List<System.Boolean>();
            val_9 = 0;
            goto label_8;
            label_11:
            char val_4 = val_8.Chars[0];
            if(val_4 != '0')
            {
                    val_9 = 1;
            }
            
            if(val_4 == '0')
            {
                    val_9 = 0;
            }
            
            Add(item:  false);
            val_9 = 1;
            label_8:
            if(val_9 < twelvegigs.plugins.InstalledAppsPlugin.plugin.m_jobject)
            {
                goto label_11;
            }
            
            val_10 = packagesNames;
            val_11 = 0;
            System.String[] val_5 = val_10 + 16;
            goto label_12;
            label_21:
            val_8 = mem[(packagesNames + 16) + 0];
            val_8 = (packagesNames + 16) + 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if((ContainsKey(key:  val_8)) != false)
            {
                    set_Item(key:  val_8, value:  true);
            }
            else
            {
                    Add(key:  val_8, value:  true);
            }
            
            val_10 = packagesNames;
            val_11 = 1;
            label_12:
            if(val_11 < (packagesNames + 12))
            {
                goto label_21;
            }
        
        }
        public static bool IsInstalled(string packageToCheck)
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = 0;
            if((System.String.IsNullOrEmpty(value:  packageToCheck)) == true)
            {
                    return true;
            }
            
            val_6 = 1152921505065738240;
            val_7 = null;
            val_7 = null;
            if(twelvegigs.plugins.InstalledAppsPlugin.initialized == false)
            {
                    return true;
            }
            
            typeof(System.String[]).__il2cppRuntimeField_10 = packageToCheck;
            System.Collections.Generic.Dictionary<System.String, System.Boolean> val_2 = twelvegigs.plugins.InstalledAppsPlugin.GetInstalledApps(packagesNames:  477709520);
            val_5 = 0;
            val_6 = null;
            if((TryGetValue(key:  packageToCheck, value: out  bool val_3 = true)) == false)
            {
                    return true;
            }
            
            if(val_5 != 0)
            {
                    val_5 = 1;
            }
            
            return true;
        }
        public static void OpenApp(string package, string referrerMarket)
        {
            var val_1 = null;
            if(twelvegigs.plugins.InstalledAppsPlugin.plugin == 0)
            {
                    twelvegigs.plugins.InstalledAppsPlugin.Init();
                val_1 = null;
            }
            
            val_1 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = package;
            typeof(System.Object[]).__il2cppRuntimeField_14 = referrerMarket;
            twelvegigs.plugins.InstalledAppsPlugin.plugin.Call(methodName:  1143672112, args:  472754880);
        }
        public static string[] defaultPackagesToUse()
        {
            null = null;
        }
        public InstalledAppsPlugin()
        {
        
        }
        private static InstalledAppsPlugin()
        {
            twelvegigs.plugins.InstalledAppsPlugin.lastResponse = "";
            twelvegigs.plugins.InstalledAppsPlugin.initialized = false;
            twelvegigs.plugins.InstalledAppsPlugin.fetching = false;
            twelvegigs.plugins.InstalledAppsPlugin.fetched = false;
            twelvegigs.plugins.InstalledAppsPlugin.plugin = false;
            twelvegigs.plugins.InstalledAppsPlugin.availablePackagesAndroid = null;
            typeof(System.String[]).__il2cppRuntimeField_10 = "com.superluckycasino.doubleup.slots.vegas.kindle.free";
            typeof(System.String[]).__il2cppRuntimeField_14 = "com.slotsfavorites.slots.kindle";
            typeof(System.String[]).__il2cppRuntimeField_18 = "com.twelvegigs.heaven.bingo.kindle";
            typeof(System.String[]).__il2cppRuntimeField_1C = "com.topfreegames.solitaire";
            typeof(System.String[]).__il2cppRuntimeField_20 = "com.superluckycasino.nolimit.slots.vegas.kindle.free";
            typeof(System.String[]).__il2cppRuntimeField_24 = "com.twelvegigs.heaven.vpoker.kindle";
            typeof(System.String[]).__il2cppRuntimeField_28 = "com.genina.android.blackjack.view";
            typeof(System.String[]).__il2cppRuntimeField_2C = "com.obamaslots.slots.kindle";
            typeof(System.String[]).__il2cppRuntimeField_30 = "com.shakespeare.slots.kindle";
            typeof(System.String[]).__il2cppRuntimeField_34 = "com.slotsfairytale.slots.kindle";
            twelvegigs.plugins.InstalledAppsPlugin.availablePackagesKindle = null;
            typeof(System.String[]).__il2cppRuntimeField_10 = "1050745469";
            typeof(System.String[]).__il2cppRuntimeField_14 = "1071897064";
            typeof(System.String[]).__il2cppRuntimeField_18 = "836865209";
            typeof(System.String[]).__il2cppRuntimeField_1C = "950325630";
            typeof(System.String[]).__il2cppRuntimeField_20 = "677489316";
            typeof(System.String[]).__il2cppRuntimeField_24 = "485761300";
            typeof(System.String[]).__il2cppRuntimeField_28 = "544933682";
            typeof(System.String[]).__il2cppRuntimeField_2C = "799157423";
            typeof(System.String[]).__il2cppRuntimeField_30 = "594736876";
            typeof(System.String[]).__il2cppRuntimeField_34 = "514165346";
            twelvegigs.plugins.InstalledAppsPlugin.availablePackagesIOS = null;
        }
    
    }

}
