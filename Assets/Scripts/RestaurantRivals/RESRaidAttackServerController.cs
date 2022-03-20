using UnityEngine;

namespace RestaurantRivals
{
    public class RESRaidAttackServerController : MonoBehaviour
    {
        // Fields
        private static int REQUEST_TIMEOUT;
        private const string SERVER_URL_PRODUCTION = "https://restaurant-rivals-api.12gigs.com";
        private const string SERVER_URL_STAGING = "https://restaurant-rivals-stage.12gigs.com";
        protected const string api_ns = "/api/words/restaurants";
        public bool resetting;
        private bool hasParsedEcon;
        private string lastServerResponse;
        private twelvegigs.net.JsonApiRequester apiRequester;
        private int <shieldsLostBetweenSessions>k__BackingField;
        private int <acornsLostBetweenSessions>k__BackingField;
        private System.Collections.Generic.List<string> serverLogs;
        
        // Properties
        public string LastServerResponse { get; }
        private RestaurantRivals.RESPlayer player { get; }
        public static bool IsInitialResponseSuccess { get; set; }
        private string ServerURL { get; }
        public int shieldsLostBetweenSessions { get; set; }
        public int acornsLostBetweenSessions { get; set; }
        
        // Methods
        public string get_LastServerResponse()
        {
        
        }
        private RestaurantRivals.RESPlayer get_player()
        {
            return RestaurantRivals.RESPlayer.Instance;
        }
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
            var val_3 = 23843877;
            val_3 = 11793084 + val_3;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            System.Action val_1 = new System.Action(object:  606701504, method:  new IntPtr(606676480));
            twelvegigs.net.JsonApiRequester val_2 = new twelvegigs.net.JsonApiRequester(ServerURL:  606564320, dequeueHandler:  7454720, logStuff:  true, adminServerURL:  0, throwExceptionsOnRequestFailures:  true);
            this.apiRequester = null;
        }
        public void InitialRequest(System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            var val_5;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6;
            val_5 = 1152921504892043264;
            Player val_1 = App.Player;
            val_6 = 0;
            if((System.String.IsNullOrEmpty(value:  1835037)) == true)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_4 = App.Player;
            Add(key:  1618311216, value:  1835037);
        }
        public void SetMapProfile(System.Nullable<int> level, RestaurantRivals.Map map, System.Nullable<int> stars, System.Nullable<int> shields, string name, System.Nullable<int> avatarid, System.Action<System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            var val_1;
            string val_8;
            var val_10;
            var val_13;
            WordPets.WPTPetTile val_16;
            RestaurantRivals.Map val_17;
            bool val_18;
            var val_19;
            val_16 = stars.HasValue;
            val_17 = map;
            val_18 = static_value_021FC6E4;
            if(val_18 != true)
            {
                    val_18 = true;
            }
            
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            if(14641 < 1)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_4 = App.Player;
            Add(key:  1618311216, value:  1835037);
            if((val_17 & 255) == 0)
            {
                    int val_5 = level.HasValue.Value;
                Add(key:  -1988561632, value:  13152256);
            }
            
            if(val_16 != false)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = val_16.Encode();
                Add(key:  259013552, value:  val_16);
            }
            
            if(name != null)
            {
                    int val_7 = shields.HasValue.Value;
                Add(key:  -1930648688, value:  13152256);
            }
            
            if(val_1 != 0)
            {
                    int val_9 = responseCallback.Value;
                Add(key:  261469680, value:  13152256);
            }
            
            if((System.String.IsNullOrEmpty(value:  val_8)) != true)
            {
                    val_19 = null;
                Add(key:  1679334848, value:  val_8);
            }
            
            if((val_10 & 255) == 0)
            {
                    val_19 = null;
                Add(key:  -1668993520, value:  19755008);
            }
            
            val_16 = val_13;
            RestaurantRivals.RESPlayer val_14 = RestaurantRivals.RESPlayer.Instance;
            string val_15 = 1115175264 + 13152256;
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
        protected virtual void DoRequest(RestaurantRivals.RequestType verb, string uri, System.Collections.Generic.Dictionary<string, object> requestParameters, System.Action<System.Collections.Generic.Dictionary<string, object>> onCompleteCallback, bool doPostUpdate = True, object request, System.Action<string, System.Collections.Generic.Dictionary<string, object>> onRequestFails)
        {
            RestaurantRivals.RESRaidAttackServerController val_8;
            var val_9;
            val_8 = this;
            if(new System.Object() != 0)
            {
                    typeof(RESRaidAttackServerController.<>c__DisplayClass21_0).__il2cppRuntimeField_8 = val_8;
                typeof(RESRaidAttackServerController.<>c__DisplayClass21_0).__il2cppRuntimeField_C = onCompleteCallback;
                typeof(RESRaidAttackServerController.<>c__DisplayClass21_0).__il2cppRuntimeField_10 = doPostUpdate;
                typeof(RESRaidAttackServerController.<>c__DisplayClass21_0).__il2cppRuntimeField_14 = request;
            }
            else
            {
                    mem[8] = val_8;
                mem[12] = onCompleteCallback;
                mem[16] = doPostUpdate;
                mem[20] = request;
            }
            
            typeof(RESRaidAttackServerController.<>c__DisplayClass21_0).__il2cppRuntimeField_18 = onRequestFails;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.AddToServerLogs(verbType:  427687936, endpoint:  uri, requestParams:  requestParameters);
            string val_2 = 607199232 + uri;
            if( > 3)
            {
                    return;
            }
            
            var val_3 = 11794748 + (11794748 + () << 2);
            if( == 3)
            {
                    11794748 + () << 2 = (11794748 + () << 2) & ((11794748 + () << 2) << (11794748 + () << 2));
                11794748 + () << 2 = (11794748 + () << 2) & ((11794748 + () << 2) >> 1);
                11794748 + () << 2 = (11794748 + () << 2) & (((IP) << (32-2)) | ((IP) << 2));
                11794748 + () << 2 = (11794748 + () << 2) & ((11794748 + () << 2) << 0);
            }
            
            val_8 = this.apiRequester;
            System.Action<System.Threading.Tasks.Task, System.Object> val_4 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  427794432, method:  new IntPtr(607203440));
            val_9 = null;
            val_9 = null;
            val_8.DoPost(path:  607199232, postBody:  requestParameters, onCompleteFunction:  7507968, timeout:  RestaurantRivals.RESRaidAttackServerController.api_ns, destroy:  true, immediate:  false, serverType:  0);
        }
        private void TryPostUpdate(System.Collections.Generic.Dictionary<string, object> responseObject, object request)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_6 = 35636967;
            if(this.resetting == true)
            {
                    return;
            }
            
            string val_1 = PrettyPrint.printJSON(obj:  responseObject, types:  false, singleLineOutput:  false);
            this.lastServerResponse = responseObject;
            val_7 = "myself";
            if((responseObject.ContainsKey(key:  263071328)) != false)
            {
                    object val_3 = responseObject.Item[263071328];
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
            
            val_9 = "econ";
            if((responseObject.ContainsKey(key:  -1125333760)) == false)
            {
                    return;
            }
            
            object val_5 = responseObject.Item[-1125333760];
            val_10 = 0;
            if(responseObject != 0)
            {
                    if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    responseObject = 0;
            }
            
                val_10 = responseObject;
            }
            
            this.ProcessKnobsData(econDict:  0);
        }
        private void ProcessMyselfData(System.Collections.Generic.Dictionary<string, object> myselfDict)
        {
            if(RestaurantRivals.RESRaidAttackServerController.IsInitialResponseSuccess == true)
            {
                    return;
            }
            
            RestaurantRivals.UserRestaurantProfile val_2 = new RestaurantRivals.UserRestaurantProfile();
            bool val_3 = RestaurantRivals.RESRaidAttackServerController.IsInitialResponseSuccess;
            if(val_3 != false)
            {
                    return;
            }
            
            RestaurantRivals.RESPlayer val_4 = RestaurantRivals.RESPlayer.Instance;
            mem2[0] = RestaurantRivals.UserRestaurantProfile.__il2cppRuntimeField_name;
            RestaurantRivals.RESPlayer val_5 = RestaurantRivals.RESPlayer.Instance;
            mem2[0] = RestaurantRivals.UserRestaurantProfile.__il2cppRuntimeField_namespaze;
            RestaurantRivals.RESPlayer val_6 = RestaurantRivals.RESPlayer.Instance;
            mem2[0] = RestaurantRivals.UserRestaurantProfile.__il2cppRuntimeField_byval_arg;
            RestaurantRivals.RESPlayer val_7 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_8 = RestaurantRivals.RESPlayer.Instance;
            mem2[0] = RestaurantRivals.UserRestaurantProfile.__il2cppRuntimeField_this_arg;
            RestaurantRivals.RESPlayer val_9 = RestaurantRivals.RESPlayer.Instance;
            mem2[0] = RestaurantRivals.UserRestaurantProfile.__il2cppRuntimeField_generic_class;
            RestaurantRivals.RESPlayer val_10 = RestaurantRivals.RESPlayer.Instance;
            val_3.stars = 292810752;
            System.Collections.Generic.List<RestaurantRivals.MapItem> val_11 = GetRestaurantData();
            System.Collections.Generic.List<RestaurantRivals.MapItem> val_12 = GetRestaurantData();
            RestaurantRivals.RESPlayer val_13 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.__il2cppRuntimeField_15C = RestaurantRivals.UserRestaurantProfile.__il2cppRuntimeField_typeDefinition;
            twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_1C.Notify(note:  0, data:  0);
            RestaurantRivals.RESRaidAttackServerController.IsInitialResponseSuccess = false;
            RestaurantRivals.RESPlayer val_15 = RestaurantRivals.RESPlayer.Instance;
            0.SaveState();
        }
        private void ProcessKnobsData(System.Collections.Generic.Dictionary<string, object> econDict)
        {
            RestaurantRivals.RESGameEcon val_1 = RestaurantRivals.RESGameEcon.Instance;
            0.ParseServerJsonKnobs(jsonDict:  econDict);
            this.hasParsedEcon = true;
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
            if((val_13.IndexOf(value:  607199232)) >= 0)
            {
                    val_14 = "/api/words/restaurants";
                if(val_14 == 0)
            {
                    val_14 = "/api/words/restaurants";
            }
            
                string val_3 = val_13.Substring(startIndex:  ("/api/words/restaurants".__il2cppRuntimeField_8 + val_1));
                val_13 = val_13;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Type> val_4 = new System.Collections.Generic.Dictionary<System.String, System.Type>(dictionary:  requestParams);
            bool val_5 = Remove(key:  1618311216);
            if((System.String.op_Equality(a:  verbType, b:  1466317008)) != false)
            {
                    RestaurantRivals.RESPlayer val_7 = RestaurantRivals.RESPlayer.Instance;
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
            if((val_7.IndexOf(value:  607199232)) >= 0)
            {
                    val_8 = "/api/words/restaurants";
                if(val_8 == 0)
            {
                    val_8 = "/api/words/restaurants";
            }
            
                string val_3 = val_7.Substring(startIndex:  ("/api/words/restaurants".__il2cppRuntimeField_8 + val_1));
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
            Player val_1 = App.Player;
            if((System.String.IsNullOrEmpty(value:  1835037)) == true)
            {
                    return;
            }
            
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            if((val_2 + 332) < 1)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Player val_5 = App.Player;
            Add(key:  1618311216, value:  1835037);
            RestaurantRivals.RESPlayer val_6 = RestaurantRivals.RESPlayer.Instance;
            1152921504892043264 = 0;
            string val_7 = 1115175264 + 13152256 + 264733024;
        }
        public RESRaidAttackServerController()
        {
            this.lastServerResponse = "";
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.serverLogs = null;
        }
        private static RESRaidAttackServerController()
        {
            RestaurantRivals.RESRaidAttackServerController.api_ns = 15;
        }
        private void <Start>b__17_0()
        {
            this.apiRequester.Dequeue();
        }
    
    }

}
