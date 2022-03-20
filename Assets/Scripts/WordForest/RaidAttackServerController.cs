using UnityEngine;

namespace WordForest
{
    public class RaidAttackServerController : MonoBehaviour
    {
        // Fields
        private static int REQUEST_TIMEOUT;
        private const string SERVER_URL_PRODUCTION = "https://word-forest-api-raids.12gigs.com";
        private const string SERVER_URL_STAGING = "https://word-forest-stage-raids.12gigs.com";
        protected const string api_ns = "/api/words/forests";
        protected const string acorns_index = "/acorns/";
        protected const string raid_index = "/raid/";
        protected const string attack_index = "/attack/";
        protected const string attack_friends_index = "/attack/friends/";
        protected const string revenges_index = "/revenges/";
        protected const string grow_index = "/grow/";
        protected const string shields_index = "/shields/";
        private twelvegigs.net.JsonApiRequester apiRequester;
        private int <shieldsLostBetweenSessions>k__BackingField;
        private int <acornsLostBetweenSessions>k__BackingField;
        private System.Collections.Generic.List<string> serverLogs;
        
        // Properties
        public static bool IsInitialResponseSuccess { get; set; }
        private string ServerURL { get; }
        public int shieldsLostBetweenSessions { get; set; }
        public int acornsLostBetweenSessions { get; set; }
        
        // Methods
        public static bool get_IsInitialResponseSuccess()
        {
            return UnityEngine.PlayerPrefs.HasKey(key:  260767712);
        }
        public static void set_IsInitialResponseSuccess(bool value)
        {
            UnityEngine.PlayerPrefs.SetInt(key:  260767712, value:  10);
            bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
        }
        private string get_ServerURL()
        {
        
        }
        private void Start()
        {
            var val_3 = 25161017;
            val_3 = 10473272 + val_3;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            System.Action val_1 = new System.Action(object:  261129008, method:  new IntPtr(261103984));
            twelvegigs.net.JsonApiRequester val_2 = new twelvegigs.net.JsonApiRequester(ServerURL:  260991824, dequeueHandler:  7454720, logStuff:  true, adminServerURL:  0, throwExceptionsOnRequestFailures:  true);
            this.apiRequester = null;
        }
        public void InitialRequest(System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            Player val_1 = App.Player;
            if((System.String.IsNullOrEmpty(value:  1835037)) == true)
            {
                    return;
            }
            
            WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_5 = App.Player;
            Add(key:  1618311216, value:  1835037);
            Add(key:  259013552, value:  0);
        }
        public void GetForestProfile(System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            var val_8;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_9;
            val_8 = 1152921504892043264;
            Player val_1 = App.Player;
            val_9 = 0;
            if((System.String.IsNullOrEmpty(value:  1835037)) == true)
            {
                    return;
            }
            
            WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
            val_9 = 0;
            if(3748210 < 1)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_5 = App.Player;
            Add(key:  1618311216, value:  1835037);
            WordForest.WFOPlayer val_6 = WordForest.WFOPlayer.Instance;
            string val_7 = 1115175264 + 13152256;
        }
        public void SetForestProfile(System.Nullable<int> forestLevel, WordForest.Map map, System.Nullable<int> acorns, System.Nullable<int> shields, string fbid, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            var val_7;
            string val_8;
            var val_11;
            WordPets.WPTPetTile val_14;
            WordForest.Map val_15;
            val_14 = acorns.HasValue;
            val_15 = map;
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            if(3748210 < 1)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_3 = App.Player;
            Add(key:  1618311216, value:  1835037);
            if((val_15 & 255) == 0)
            {
                    int val_4 = forestLevel.HasValue.Value;
                Add(key:  -1988561632, value:  13152256);
            }
            
            if(val_14 != false)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = val_14.Encode();
                Add(key:  259013552, value:  val_14);
            }
            
            if(fbid != null)
            {
                    int val_6 = shields.HasValue.Value;
                Add(key:  -702174016, value:  13152256);
            }
            
            if(val_7 != false)
            {
                    int val_9 = responseCallback.Value;
                Add(key:  261469680, value:  13152256);
            }
            
            if((System.String.IsNullOrEmpty(value:  val_8)) != true)
            {
                    Add(key:  -256444704, value:  val_8);
            }
            
            val_15 = val_11;
            val_14 = 0;
            WordForest.WFOPlayer val_12 = WordForest.WFOPlayer.Instance;
            string val_13 = 1115175264 + 13152256;
        }
        public void GrowTree(int treeId, int growthCost, System.Action<bool, System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            int val_11;
            System.Action<twelvegigs.storage.JsonDictionary> val_12;
            System.Action<System.Threading.Tasks.Task, System.Object> val_13;
            val_11 = treeId;
            object val_1 = new System.Object();
            typeof(RaidAttackServerController.<>c__DisplayClass21_0).__il2cppRuntimeField_8 = responseCallback;
            val_12 = 1152921504892043264;
            Player val_2 = App.Player;
            val_13 = 0;
            if((System.String.IsNullOrEmpty(value:  1835037)) == true)
            {
                    return;
            }
            
            WordForest.WFOPlayer val_4 = WordForest.WFOPlayer.Instance;
            val_13 = 0;
            if(3748210 < 1)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_6 = App.Player;
            Add(key:  1618311216, value:  1835037);
            Add(key:  -702174016, value:  13152256);
            typeof(System.Object[]).__il2cppRuntimeField_10 = "/";
            WordForest.WFOPlayer val_7 = WordForest.WFOPlayer.Instance;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            typeof(System.Object[]).__il2cppRuntimeField_18 = "/grow/";
            typeof(System.Object[]).__il2cppRuntimeField_1C = null;
            val_11 = 0;
            string val_8 = +472754880;
            val_12 = null;
            val_12 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  405110784, method:  new IntPtr(261598240));
            val_13 = null;
            val_13 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  405110784, method:  new IntPtr(261599264));
        }
        public void GetEcon()
        {
            var val_5 = 1152921504892043264;
            Player val_1 = App.Player;
            if((System.String.IsNullOrEmpty(value:  1835037)) == true)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_4 = App.Player;
            Add(key:  1618311216, value:  1835037);
        }
        public void GetRaidOpponentPool(System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            Player val_1 = App.Player;
            if((System.String.IsNullOrEmpty(value:  1835037)) == true)
            {
                    return;
            }
            
            WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
            if(3748210 < 1)
            {
                    return;
            }
            
            WordForest.WFOPlayer val_4 = WordForest.WFOPlayer.Instance;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_6 = App.Player;
            Add(key:  1618311216, value:  1835037);
            Add(key:  261832560, value:  13152256);
            UnityEngine.Vector2Int val_7 = WordForest.WFOGameEconHelper.GetRaidEligibleAcornsMinMax(forestLevel:  261844800);
            int val_8 = 0.y;
            Add(key:  -702174016, value:  13152256);
            Add(key:  261832656, value:  13152256);
        }
        public void InitializeRaid(int opponentId, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            var val_7 = 1152921504892043264;
            Player val_1 = App.Player;
            if((System.String.IsNullOrEmpty(value:  1835037)) == true)
            {
                    return;
            }
            
            WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
            if(3748210 < 1)
            {
                    return;
            }
            
            WordForest.WFOPlayer val_4 = WordForest.WFOPlayer.Instance;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_6 = App.Player;
            Add(key:  1618311216, value:  1835037);
            Add(key:  261953040, value:  13152256);
        }
        public void ConcludeRaid(string raidId, System.Collections.Generic.List<int> chosenRewardIndexes, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>> val_11;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_12;
            string val_13;
            var val_14;
            var val_15;
            val_11 = responseCallback;
            val_12 = chosenRewardIndexes;
            val_13 = raidId;
            Player val_1 = App.Player;
            if((System.String.IsNullOrEmpty(value:  1835037)) == true)
            {
                    return;
            }
            
            WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
            if(3748210 < 1)
            {
                    return;
            }
            
            bool val_4 = System.String.IsNullOrEmpty(value:  val_13);
            if(val_12 == 0)
            {
                    return;
            }
            
            if(val_4 == true)
            {
                    return;
            }
            
            if(val_4 < true)
            {
                    return;
            }
            
            val_14 = 0;
            WordForest.WFOPlayer val_5 = WordForest.WFOPlayer.Instance;
            if(0 >= 1)
            {
                    do
            {
                if(0 <= 0)
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_11 = val_11 + 0;
                if(0 < (-1))
            {
                    val_15 = 0;
                string val_6 = 0 + 13152256 + -2100450224(-2100450224);
            }
            else
            {
                    val_15 = 0;
                string val_7 = 0 + 13152256;
            }
            
                val_14 = val_15;
                val_11 = 0 + 1;
            }
            while(val_11 < val_15);
            
            }
            
            val_12 = null;
            val_12 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_9 = App.Player;
            if(val_12 != 0)
            {
                    Add(key:  1618311216, value:  1835037);
            }
            else
            {
                    Add(key:  1618311216, value:  1835037);
            }
            
            Add(key:  262081616, value:  0);
            string val_10 = 261953152 + val_13;
        }
        public void GetAttackOpponentPool(System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            Player val_1 = App.Player;
            if((System.String.IsNullOrEmpty(value:  1835037)) == true)
            {
                    return;
            }
            
            WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
            if(3748210 < 1)
            {
                    return;
            }
            
            WordForest.WFOPlayer val_4 = WordForest.WFOPlayer.Instance;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_6 = App.Player;
            Add(key:  1618311216, value:  1835037);
            Add(key:  261832560, value:  13152256);
            Add(key:  261832656, value:  13152256);
        }
        public void ResolveAttack(int opponentId, int treeId, System.Nullable<bool> autoSuccess, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            var val_6;
            int val_9;
            int val_10;
            bool val_11;
            System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>> val_12;
            val_9 = treeId;
            val_10 = opponentId;
            val_11 = (uint)(autoSuccess.HasValue >> 8) & 255;
            Player val_1 = App.Player;
            if((System.String.IsNullOrEmpty(value:  1835037)) == true)
            {
                    return;
            }
            
            WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
            val_10 = null;
            val_10 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_5 = App.Player;
            Add(key:  1618311216, value:  1835037);
            if(val_10 == 0)
            {
                    val_11 = val_6;
            }
            
            val_12 = responseCallback;
            Add(key:  262330416, value:  13152256);
            if(val_11 != false)
            {
                    bool val_7 = autoSuccess.HasValue.Value;
                Add(key:  262330512, value:  8945664);
                val_12 = val_12;
            }
            
            string val_8 = 262330608 + 13152256;
        }
        public void GetRevengeOpponentPool(System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            Player val_1 = App.Player;
            if((System.String.IsNullOrEmpty(value:  1835037)) == true)
            {
                    return;
            }
            
            WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_5 = App.Player;
            Add(key:  1618311216, value:  1835037);
            string val_6 = 1115175264 + 13152256 + 262450896;
        }
        public void GetFriendsOpponentPool(string[] fbidList, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            Player val_1 = App.Player;
            bool val_2 = System.String.IsNullOrEmpty(value:  1835037);
            if(fbidList == null)
            {
                    return;
            }
            
            if(val_2 == true)
            {
                    return;
            }
            
            if(val_2 == false)
            {
                    return;
            }
            
            WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_5 = App.Player;
            if(null != 0)
            {
                    Add(key:  1618311216, value:  1835037);
            }
            else
            {
                    Add(key:  1618311216, value:  1835037);
            }
            
            Add(key:  262608048, value:  fbidList = fbidList);
        }
        protected virtual bool PreProcessFilter(string apiCall, System.Collections.Generic.Dictionary<string, object> response)
        {
            var val_4;
            if(response == 0)
            {
                goto label_5;
            }
            
            if((response.ContainsKey(key:  1616271776)) == false)
            {
                goto label_2;
            }
            
            object val_2 = response.Item[1616271776];
            response.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(null == 0)
            {
                goto label_5;
            }
            
            label_2:
            val_4 = 1;
            this.AddToServerLogsResponse(endpoint:  apiCall, isSuccess:  true, val:  1616271776);
            return (bool)val_4;
            label_5:
            val_4 = 0;
            string val_3 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  response);
            this.AddToServerLogsResponse(endpoint:  apiCall, isSuccess:  false, val:  response);
            this.HandleError(apiCall:  apiCall, response:  response);
            return (bool)val_4;
        }
        protected virtual void DoRequest(WordForest.RequestType verb, string uri, System.Collections.Generic.Dictionary<string, object> requestParameters, System.Action<System.Collections.Generic.Dictionary<string, object>> onCompleteCallback, bool doPostUpdate = True, object request, System.Action<string, System.Collections.Generic.Dictionary<string, object>> onRequestFails)
        {
            WordForest.RaidAttackServerController val_8;
            var val_9;
            val_8 = this;
            if(new System.Object() != 0)
            {
                    typeof(RaidAttackServerController.<>c__DisplayClass31_0).__il2cppRuntimeField_8 = val_8;
                typeof(RaidAttackServerController.<>c__DisplayClass31_0).__il2cppRuntimeField_C = onCompleteCallback;
                typeof(RaidAttackServerController.<>c__DisplayClass31_0).__il2cppRuntimeField_10 = doPostUpdate;
                typeof(RaidAttackServerController.<>c__DisplayClass31_0).__il2cppRuntimeField_14 = request;
            }
            else
            {
                    mem[8] = val_8;
                mem[12] = onCompleteCallback;
                mem[16] = doPostUpdate;
                mem[20] = request;
            }
            
            typeof(RaidAttackServerController.<>c__DisplayClass31_0).__il2cppRuntimeField_18 = onRequestFails;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.AddToServerLogs(verbType:  405004288, endpoint:  uri, requestParams:  requestParameters);
            string val_2 = 262914160 + uri;
            if( > 3)
            {
                    return;
            }
            
            var val_3 = 10474944 + (10474944 + () << 2);
            if( == 3)
            {
                    10474944 + () << 2 = (10474944 + () << 2) & ((10474944 + () << 2) << (10474944 + () << 2));
                10474944 + () << 2 = (10474944 + () << 2) & ((10474944 + () << 2) >> 1);
                10474944 + () << 2 = (10474944 + () << 2) & (((IP) << (32-2)) | ((IP) << 2));
                10474944 + () << 2 = (10474944 + () << 2) & ((10474944 + () << 2) << 0);
            }
            
            val_8 = this.apiRequester;
            System.Action<System.Threading.Tasks.Task, System.Object> val_4 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  405164032, method:  new IntPtr(262918368));
            val_9 = null;
            val_9 = null;
            val_8.DoPost(path:  262914160, postBody:  requestParameters, onCompleteFunction:  7507968, timeout:  WordForest.RaidAttackServerController.shields_index, destroy:  true, immediate:  false, serverType:  0);
        }
        private void TryPostUpdate(System.Collections.Generic.Dictionary<string, object> responseObject, object request)
        {
            var val_7;
            var val_8;
            var val_9;
            val_7 = "myself";
            if((responseObject.ContainsKey(key:  263071328)) != false)
            {
                    object val_2 = responseObject.Item[263071328];
                val_8 = 0;
                if(responseObject != 0)
            {
                    if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    responseObject = 0;
            }
            
                val_8 = responseObject;
            }
            
                this.ProcessMyselfData(myselfDict:  0);
            }
            
            if((responseObject.ContainsKey(key:  -1125333760)) == false)
            {
                    return;
            }
            
            object val_4 = responseObject.Item[-1125333760];
            val_9 = 0;
            if(responseObject != 0)
            {
                    if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    responseObject = 0;
            }
            
                val_9 = responseObject;
            }
            
            WordForest.WFOGameEcon val_5 = WordForest.WFOGameEcon.Instance;
            0.ParseServerJsonKnobs(jsonDict:  0);
            WordForest.WFOGameEcon val_6 = WordForest.WFOGameEcon.Instance;
            0.CacheServerJsonKnobs(jsonDict:  0);
        }
        private void ProcessMyselfData(System.Collections.Generic.Dictionary<string, object> myselfDict)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_10;
            var val_11;
            var val_12;
            val_10 = myselfDict;
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            mem2[0] = new WordForest.UserForestProfile();
            bool val_4 = WordForest.RaidAttackServerController.IsInitialResponseSuccess;
            if(val_4 != false)
            {
                    val_4.ApplyPossibleAttacksOnMap(localPlayer:  0, myselfDict:  val_10);
                val_4.ApplyPossibleShieldsLost(localPlayer:  0, myDataFromServer:  404684800);
                this.ApplyOtherShits(player:  0, myDataFromServer:  404684800, overrideMapInfo:  false);
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_14.ProcessNewsArticles(news:  404684800);
                return;
            }
            
            if(WordForest.RaidAttackServerController.IsInitialResponseSuccess != false)
            {
                    return;
            }
            
            if(0 != 0)
            {
                    val_11 = 0;
                mem[332] = WordForest.UserForestProfile.__il2cppRuntimeField_name;
            }
            else
            {
                    val_11 = 332;
                mem[332] = WordForest.UserForestProfile.__il2cppRuntimeField_name;
            }
            
            bool val_7 = 0.UpgradePlayer;
            if(val_7 != false)
            {
                    mem[332] = WordForest.UserForestProfile.__il2cppRuntimeField_name;
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_14.ProcessNewsArticles(news:  404684800);
                val_12 = null;
            }
            else
            {
                    val_7.ApplyPossibleAttacksOnMap(localPlayer:  0, myselfDict:  val_10);
                val_7.ApplyPossibleShieldsLost(localPlayer:  0, myDataFromServer:  404684800);
                this.ApplyOtherShits(player:  0, myDataFromServer:  404684800, overrideMapInfo:  true);
                twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_1C.Notify(note:  0, data:  0);
                val_12 = null;
            }
            
            WordForest.RaidAttackServerController.IsInitialResponseSuccess = false;
        }
        private void ApplyOtherShits(WordForest.WFOPlayer player, WordForest.UserForestProfile myDataFromServer, bool overrideMapInfo = False)
        {
            WordForest.RaidAttackServerController val_7;
            var val_8;
            val_7 = this;
            int val_2 = player.acorns - myDataFromServer.acorns;
            if(val_2 >= 1)
            {
                    System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                int val_4 = UnityEngine.Mathf.Abs(value:  val_2);
                if(null != 0)
            {
                    Add(key:  -1928004976, value:  13152256);
            }
            else
            {
                    Add(key:  -1928004976, value:  13152256);
            }
            
                Add(key:  -1928142032, value:  -1108687296);
                var val_7 = 25146606;
                val_7 = 10478932 + val_7;
                if(val_7 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_8 = null;
                val_8 = null;
                val_7 = App.trackerManager;
                val_7.track(eventName:  -740081888, data:  78753792);
                mem[1152921513460137860] = val_2;
            }
            
            if(player != 0)
            {
                    player.currentChestID = myDataFromServer.level;
            }
            else
            {
                    mem[336] = myDataFromServer.level;
            }
            
            player.currentForestID = myDataFromServer.level;
            if(overrideMapInfo == true)
            {
                    336 = myDataFromServer.map;
            }
            
            if(336 != 0)
            {
                goto label_16;
            }
            
            label_20:
            player.acorns = myDataFromServer.acorns;
            player.raidsSent = myDataFromServer.raidsSent;
            player.raidsReceived = myDataFromServer.raidsReceived;
            player.attacksSent = myDataFromServer.attacksSent;
            player.attacksReceived = myDataFromServer.attacksReceived;
            return;
            label_16:
            System.Collections.Generic.List<WordForest.MapItem> val_5 = 336.GetForestData();
            if(336 == 0)
            {
                goto label_20;
            }
            
            System.Collections.Generic.List<WordForest.MapItem> val_6 = myDataFromServer.map.GetForestData();
            if(myDataFromServer.map >= 1)
            {
                    myDataFromServer.map = myDataFromServer.map;
                player.forestMapData = myDataFromServer.map;
            }
            
            goto label_20;
        }
        private void ApplyPossibleShieldsLost(WordForest.WFOPlayer localPlayer, WordForest.UserForestProfile myDataFromServer)
        {
            localPlayer.shields = System.Math.Min(val1:  localPlayer.shields, val2:  myDataFromServer.shields);
        }
        private void ApplyPossibleAttacksOnMap(WordForest.WFOPlayer localPlayer, System.Collections.Generic.Dictionary<string, object> myselfDict)
        {
            var val_9;
            var val_10;
            var val_11;
            System.Collections.Generic.List<WordForest.MapItem> val_1 = localPlayer.forestMapData.GetForestData();
            val_9 = "attacks_to_apply";
            if((myselfDict.ContainsKey(key:  263605424)) == false)
            {
                    return;
            }
            
            object val_3 = myselfDict.Item[263605424];
            string val_4 = myselfDict.ToString();
            int val_5 = System.Int32.Parse(s:  myselfDict, style:  511);
            if(val_5 < 1)
            {
                    return;
            }
            
            label_20:
            val_10 = val_5;
            label_16:
            if(localPlayer.forestMapData != 0)
            {
                    val_11 = UnityEngine.Random.Range(min:  0, max:  511);
            }
            else
            {
                    int val_7 = UnityEngine.Random.Range(min:  0, max:  511);
                val_11 = val_7;
            }
            
            if(val_7 <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.Collections.Generic.List<System.Collections.Generic.List<WordForest.MapItem>> val_9 = localPlayer.forestMapData.area;
            val_9 = val_9 + (val_11 << 2);
            bool val_8 = System.String.op_Inequality(a:  R7 + 8, b:  -1402413584);
            if(val_8 == true)
            {
                goto label_12;
            }
            
            if(val_8 <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.Collections.Generic.List<System.Collections.Generic.List<WordForest.MapItem>> val_10 = localPlayer.forestMapData.area;
            val_10 = val_10 + (val_11 << 2);
            if((R7 + 16) == 1)
            {
                goto label_15;
            }
            
            label_12:
            val_9 = 10 - 1;
            if(val_9 >= 1)
            {
                goto label_16;
            }
            
            return;
            label_15:
            if((R7 + 16) <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.Collections.Generic.List<System.Collections.Generic.List<WordForest.MapItem>> val_11 = localPlayer.forestMapData.area;
            val_9 = 10 - 1;
            val_11 = val_11 + (val_11 << 2);
            mem2[0] = 2;
            if(val_9 >= 1)
            {
                    val_11 = val_10 - 1;
            }
            
            if(val_10 >= 2)
            {
                goto label_20;
            }
        
        }
        private void HandleError(string apiCall, System.Collections.Generic.Dictionary<string, object> response)
        {
            CompanyDevices val_1 = CompanyDevices.Instance;
            if(0.CompanyDevice() == false)
            {
                    return;
            }
            
            string val_3 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  response);
            string val_4 = 263762592 + apiCall + 263762704 + response;
            UnityEngine.Debug.LogWarning(message:  263762592);
        }
        public int get_shieldsLostBetweenSessions()
        {
            return (int)this.<shieldsLostBetweenSessions>k__BackingField;
        }
        private void set_shieldsLostBetweenSessions(int value)
        {
            this.<shieldsLostBetweenSessions>k__BackingField = value;
        }
        public int get_acornsLostBetweenSessions()
        {
            return (int)this.<acornsLostBetweenSessions>k__BackingField;
        }
        private void set_acornsLostBetweenSessions(int value)
        {
            this.<acornsLostBetweenSessions>k__BackingField = value;
        }
        public string GetServerLogs()
        {
            string val_4;
            List.Enumerator<T> val_2 = GetEnumerator();
            label_4:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            System.Text.StringBuilder val_5 = AppendLine(value:  val_4);
            goto label_4;
            label_2:
            Dispose();
            if(new System.Text.StringBuilder() != 0)
            {
                    return;
            }
        
        }
        private void AddToServerLogs(string verbType, string endpoint, System.Collections.Generic.Dictionary<string, object> requestParams)
        {
            string val_13;
            var val_14;
            val_13 = endpoint;
            if((val_13.IndexOf(value:  262914160)) >= 0)
            {
                    val_14 = "/api/words/forests";
                if(val_14 == 0)
            {
                    val_14 = "/api/words/forests";
            }
            
                string val_3 = val_13.Substring(startIndex:  ("/api/words/forests".__il2cppRuntimeField_8 + val_1));
                val_13 = val_13;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Type> val_4 = new System.Collections.Generic.Dictionary<System.String, System.Type>(dictionary:  requestParams);
            bool val_5 = Remove(key:  1618311216);
            if((System.String.op_Equality(a:  verbType, b:  1466317008)) != false)
            {
                    WordForest.WFOPlayer val_7 = WordForest.WFOPlayer.Instance;
                string val_8 = 1115175264 + 13152256;
                if((System.String.op_Equality(a:  val_13, b:  1115175264)) != false)
            {
                    bool val_10 = Remove(key:  259013552);
            }
            
            }
            
            string val_11 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  78753792);
            string val_12 = System.String.Format(format:  264463472, arg0:  verbType, arg1:  val_13, arg2:  78753792);
            this.serverLogs.Add(item:  264463472);
        }
        private void AddToServerLogsResponse(string endpoint, bool isSuccess, string val)
        {
            object val_7;
            var val_8;
            val_7 = endpoint;
            if((val_7.IndexOf(value:  262914160)) >= 0)
            {
                    val_8 = "/api/words/forests";
                if(val_8 == 0)
            {
                    val_8 = "/api/words/forests";
            }
            
                string val_3 = val_7.Substring(startIndex:  ("/api/words/forests".__il2cppRuntimeField_8 + val_1));
                val_7 = val_7;
            }
            
            int val_4 = val_7.LastIndexOf(value:  '?');
            if(val_4 >= 0)
            {
                    string val_5 = val_7.Substring(startIndex:  0, length:  val_4);
                val_7 = val_7;
            }
            
            if(isSuccess == true)
            {
                    "ee0000" = "00ee00";
            }
            
            string val_6 = System.String.Format(format:  264604320, arg0:  264604480, arg1:  val_7, arg2:  val);
            this.serverLogs.Add(item:  264604320);
        }
        public void ResetForest()
        {
            var val_9 = 1152921504892043264;
            Player val_1 = App.Player;
            if((System.String.IsNullOrEmpty(value:  1835037)) == true)
            {
                    return;
            }
            
            WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
            if(3748210 < 1)
            {
                    return;
            }
            
            WordForest.WFOPlayer val_4 = WordForest.WFOPlayer.Instance;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_6 = App.Player;
            Add(key:  1618311216, value:  1835037);
            WordForest.WFOPlayer val_7 = WordForest.WFOPlayer.Instance;
            string val_8 = 1115175264 + 13152256 + 264733024;
        }
        public RaidAttackServerController()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.serverLogs = null;
        }
        private static RaidAttackServerController()
        {
            WordForest.RaidAttackServerController.shields_index = 20;
        }
        private void <Start>b__17_0()
        {
            this.apiRequester.Dequeue();
        }
    
    }

}
