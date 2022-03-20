using UnityEngine;

namespace twelvegigs.sweepstakes
{
    public class SweepstakesSDK
    {
        // Fields
        private const string UserAgentFormat = "{0}/{1} TinySparkSDK/{2} {3}/{4}";
        private const string xUserAgentFormat = "TinySparkSDK/{0} ({1}; {2})";
        private const string apiFormat = "/v{0}/{1}";
        private const string apiVersion = "1";
        private const int keyLength = 32;
        private twelvegigs.net.JsonApiRequester apiRequester;
        private twelvegigs.sweepstakes.Security security;
        private string apiKey;
        private string apiSecret;
        private string serverUrl;
        private string appVersion;
        private int campaignId;
        private bool enabled;
        private string UserAgent;
        private string xUserAgent;
        private string deviceId;
        private string openUdid;
        private string idfa;
        private System.Collections.Generic.Dictionary<string, object> deviceIdentifiers;
        private string session;
        private string deviceHash;
        private System.Collections.Generic.Dictionary<string, object> user;
        private System.Collections.Generic.Dictionary<string, object> iaps;
        private System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> distribution;
        private System.Collections.Generic.Dictionary<string, object> application;
        private string applicationName;
        private System.Collections.Generic.Dictionary<string, object> assets;
        private double balance;
        private double lastBalance;
        private int entries;
        private int lastEntries;
        
        // Properties
        private bool Disabled { get; }
        public System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> Distribution { get; }
        public double Balance { get; }
        public double LastBalance { get; }
        public int Entries { get; }
        public int LastEntries { get; }
        public bool Initialized { get; }
        
        // Methods
        private bool get_Disabled()
        {
            bool val_1 = this.enabled;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> get_Distribution()
        {
        
        }
        public double get_Balance()
        {
            return (double)D0;
        }
        public double get_LastBalance()
        {
            return (double)D0;
        }
        public int get_Entries()
        {
            return (int)this.entries;
        }
        public int get_LastEntries()
        {
            return (int)this.lastEntries;
        }
        public bool get_Initialized()
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  this.session);
            val_1 = val_1 ^ 1;
            return (bool)val_1;
        }
        public SweepstakesSDK(string serverUrl, string applicationVersion, string apiKey, string apiSecret, int campaignId)
        {
            var val_7;
            string val_8;
            this.apiKey = System.String.alignConst;
            this.apiSecret = System.String.alignConst;
            this.serverUrl = System.String.alignConst;
            this.enabled = true;
            this.appVersion = System.String.alignConst;
            this.UserAgent = System.String.alignConst;
            this.xUserAgent = System.String.alignConst;
            this.deviceId = System.String.alignConst;
            this.openUdid = System.String.alignConst;
            this.idfa = System.String.alignConst;
            val_1 = new System.Object();
            this.apiKey = val_1;
            this.apiSecret = apiSecret;
            this.serverUrl = serverUrl;
            this.appVersion = applicationVersion;
            this.campaignId = campaignId;
            this.security = new System.Object();
            this.SaveDeviceIdentifiers();
            if(this.apiKey.m_stringLength != 32)
            {
                goto label_2;
            }
            
            if(this.apiSecret.m_stringLength != 32)
            {
                goto label_4;
            }
            
            System.Action val_3 = new System.Action(object:  1133491856, method:  new IntPtr(1133440976));
            twelvegigs.net.JsonApiRequester val_4 = new twelvegigs.net.JsonApiRequester(ServerURL:  this.serverUrl, dequeueHandler:  7454720, logStuff:  false, adminServerURL:  0, throwExceptionsOnRequestFailures:  true);
            this.apiRequester = null;
            typeof(twelvegigs.net.JsonApiRequester).__il2cppRuntimeField_20 = "application/json";
            this.apiRequester.<UserAgent>k__BackingField = this.UserAgent;
            this.apiRequester.<XuserAgent>k__BackingField = this.xUserAgent;
            return;
            label_2:
            val_7 = "Invalid apiKey: \'{0}\'";
            val_8 = this.apiKey;
            goto label_8;
            label_4:
            val_7 = "Invalid apiSecret: \'{0}\'";
            val_8 = this.apiSecret;
            label_8:
            string val_5 = System.String.Format(format:  1133462608, arg0:  val_8);
            System.Exception val_6 = new System.Exception(message:  1133462608);
        }
        private string Url(string endpoint)
        {
            return System.String.Format(format:  1133637200, arg0:  1633189168, arg1:  endpoint);
        }
        public void Initialize(System.Action<string, System.Collections.Generic.Dictionary<string, object>> onCompleteFunction)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1378226336, value:  this.apiKey);
            Add(key:  -1771322192, value:  78753792);
            Add(key:  1133761584, value:  13152256);
            Add(key:  1133765776, value:  this.deviceIdentifiers);
            Add(key:  1675191600, value:  78753792);
            this.DoPost(endpoint:  1129588848, postData:  78753792, onCompleteFunction:  onCompleteFunction, checkInitialization:  false);
        }
        public void Terminate(System.Action<string, System.Collections.Generic.Dictionary<string, object>> onCompleteFunction)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.DoPost(endpoint:  1133894256, postData:  78753792, onCompleteFunction:  onCompleteFunction, checkInitialization:  true);
        }
        public void Ping(System.Action<string, System.Collections.Generic.Dictionary<string, object>> onCompleteFunction)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.DoPost(endpoint:  1134014544, postData:  78753792, onCompleteFunction:  onCompleteFunction, checkInitialization:  true);
        }
        public void Perform(string name, System.Collections.Generic.List<object> parameters, System.Action<string, System.Collections.Generic.Dictionary<string, object>> onCompleteFunction)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if((new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>()) != 0)
            {
                    Add(key:  1679334848, value:  name);
            }
            else
            {
                    Add(key:  1679334848, value:  name);
            }
            
            Add(key:  1673410464, value:  parameters);
            Add(key:  1675191600, value:  78753792);
            this.DoPost(endpoint:  1134143008, postData:  78753792, onCompleteFunction:  onCompleteFunction, checkInitialization:  true);
        }
        public void Redeem(int count, System.Action<string, System.Collections.Generic.Dictionary<string, object>> onCompleteFunction)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1348647040, value:  13152256);
            Add(key:  1675191600, value:  78753792);
            this.DoPost(endpoint:  1134271488, postData:  78753792, onCompleteFunction:  onCompleteFunction, checkInitialization:  true);
        }
        public void Log(System.Collections.Generic.List<string> logs, System.Action<string, System.Collections.Generic.Dictionary<string, object>> onCompleteFunction)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1134395856, value:  logs);
            Add(key:  1675191600, value:  78753792);
            this.DoPost(endpoint:  1788750416, postData:  78753792, onCompleteFunction:  onCompleteFunction, checkInitialization:  true);
        }
        public void LogAnalytics(System.Collections.Generic.List<AnalyticsEvent> events, System.Action<string, System.Collections.Generic.Dictionary<string, object>> onCompleteFunction)
        {
            twelvegigs.sweepstakes.Distribution val_4;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            List.Enumerator<T> val_2 = GetEnumerator();
            label_5:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = val_4.ToDictionary();
            Add(item:  val_4);
            goto label_5;
            label_2:
            Dispose();
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_7 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1956399680, value:  80883712);
            Add(key:  1675191600, value:  78753792);
            this.DoPost(endpoint:  1269189856, postData:  78753792, onCompleteFunction:  onCompleteFunction, checkInitialization:  true);
        }
        public void Payout(string email, string firstName, string lastName, string addressOne, string city, string state, string zip, uint phone, string birthdate, string payMethod, System.Action<string, System.Collections.Generic.Dictionary<string, object>> onCompleteFunction, string addressTwo = "")
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if(val_2 != 0)
            {
                    Add(key:  -1931027184, value:  email);
            }
            else
            {
                    Add(key:  -1931027184, value:  email);
            }
            
            Add(key:  -1850788784, value:  firstName);
            if(val_2 != 0)
            {
                    Add(key:  -1850788688, value:  lastName);
            }
            else
            {
                    Add(key:  -1850788688, value:  lastName);
            }
            
            Add(key:  1134692640, value:  addressOne);
            if(val_2 != 0)
            {
                    Add(key:  1134692736, value:  addressTwo);
            }
            else
            {
                    Add(key:  1134692736, value:  addressTwo);
            }
            
            Add(key:  1134692832, value:  city);
            if(val_2 != 0)
            {
                    Add(key:  1134692912, value:  state);
            }
            else
            {
                    Add(key:  1134692912, value:  state);
            }
            
            Add(key:  1134692992, value:  zip);
            if(val_2 != 0)
            {
                    Add(key:  1134693072, value:  16773120);
            }
            else
            {
                    Add(key:  1134693072, value:  16773120);
            }
            
            Add(key:  1134693152, value:  birthdate);
            Add(key:  1373043792, value:  payMethod);
            Add(key:  1675191600, value:  78753792);
            this.DoPost(endpoint:  1134693248, postData:  78753792, onCompleteFunction:  onCompleteFunction, checkInitialization:  true);
        }
        public void Amoe(string email, System.Action<string, System.Collections.Generic.Dictionary<string, object>> onCompleteFunction)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1931027184, value:  email);
            Add(key:  1675191600, value:  78753792);
            this.DoPost(endpoint:  1134858576, postData:  78753792, onCompleteFunction:  onCompleteFunction, checkInitialization:  true);
        }
        public void Coupon(string code, System.Action<string, System.Collections.Generic.Dictionary<string, object>> onCompleteFunction)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1495693168, value:  code);
            Add(key:  1675191600, value:  78753792);
            this.DoPost(endpoint:  1134987040, postData:  78753792, onCompleteFunction:  onCompleteFunction, checkInitialization:  true);
        }
        private void DoPost(string endpoint, System.Collections.Generic.Dictionary<string, object> postData, System.Action<string, System.Collections.Generic.Dictionary<string, object>> onCompleteFunction, bool checkInitialization = True)
        {
            twelvegigs.sweepstakes.SweepstakesSDK val_7;
            bool val_8;
            System.Threading.Tasks.Task val_9;
            object val_10;
            val_7 = this;
            val_8 = checkInitialization;
            val_9 = endpoint;
            val_10 = null;
            val_10 = new System.Object();
            if(val_10 != 0)
            {
                    typeof(SweepstakesSDK.<>c__DisplayClass57_0).__il2cppRuntimeField_8 = val_7;
            }
            else
            {
                    val_10 = 8;
                mem[8] = val_7;
            }
            
            typeof(SweepstakesSDK.<>c__DisplayClass57_0).__il2cppRuntimeField_C = onCompleteFunction;
            if(val_8 != false)
            {
                    if((System.String.IsNullOrEmpty(value:  this.session)) != false)
            {
                    UnityEngine.Debug.LogError(message:  1135123696);
                System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                typeof(SweepstakesSDK.<>c__DisplayClass57_0).__il2cppRuntimeField_C.Invoke(arg1:  val_9, arg2:  78753792);
                return;
            }
            
            }
            
            string val_3 = mem[8].Url(endpoint:  val_9);
            val_9 = val_10;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = this.SignRequest(payload:  postData);
            val_7 = val_7;
            val_8 = null;
            val_8 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  458678272, method:  new IntPtr(1135128016));
            this.apiRequester.DoPost(path:  mem[8], postBody:  1135153040, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, serverType:  0);
        }
        private void OnSweepstakesResponse(string method, System.Collections.Generic.Dictionary<string, object> data, System.Action<string, System.Collections.Generic.Dictionary<string, object>> onCompleteFunction)
        {
            var val_5;
            twelvegigs.sweepstakes.Response val_1 = new twelvegigs.sweepstakes.Response(rawResponse:  data);
            this.enabled = twelvegigs.sweepstakes.Response.__il2cppRuntimeField_namespaze;
            if((System.String.op_Equality(a:  twelvegigs.sweepstakes.Response.__il2cppRuntimeField_this_arg, b:  1129588848)) != false)
            {
                    this.OnInitialize(response:  458412032);
            }
            else
            {
                    if((System.String.op_Equality(a:  twelvegigs.sweepstakes.Response.__il2cppRuntimeField_this_arg, b:  1133894256)) != false)
            {
                    this.OnTerminate(response:  458412032);
            }
            else
            {
                    if((System.String.op_Equality(a:  twelvegigs.sweepstakes.Response.__il2cppRuntimeField_this_arg, b:  1134143008)) != false)
            {
                    this.OnPerform(response:  458412032);
            }
            else
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = twelvegigs.sweepstakes.Response.__il2cppRuntimeField_this_arg;
                UnityEngine.Debug.LogWarningFormat(format:  1135273936, args:  472754880);
            }
            
            }
            
            }
            
            if(val_5 != false)
            {
                    double val_6 = Value;
                this.balance = ;
            }
            
            if((onCompleteFunction & 255) == 0)
            {
                    this.entries = twelvegigs.sweepstakes.Response.__il2cppRuntimeField_nestedTypes.Value;
            }
            
            if(val_5 != false)
            {
                    double val_8 = Value;
                this.lastBalance = ;
            }
            
            if((onCompleteFunction & 255) == 0)
            {
                    this.lastEntries = twelvegigs.sweepstakes.Response.__il2cppRuntimeField_interfaceOffsets.Value;
            }
            
            if(onCompleteFunction == 0)
            {
                    return;
            }
            
            onCompleteFunction.Invoke(arg1:  twelvegigs.sweepstakes.Response.__il2cppRuntimeField_this_arg, arg2:  twelvegigs.sweepstakes.Response.__il2cppRuntimeField_unity_user_data);
        }
        private void OnInitialize(twelvegigs.sweepstakes.Response response)
        {
            var val_18;
            var val_20;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_21;
            var val_22;
            var val_23;
            var val_24;
            float val_25;
            var val_26;
            var val_27;
            val_20 = response;
            bool val_1 = System.String.IsNullOrEmpty(value:  response.session);
            if(val_1 == false)
            {
                    0 = this;
                val_1 = response.session;
                mem[1152921514332267840] = val_1;
            }
            
            bool val_2 = System.String.IsNullOrEmpty(value:  response.deviceHash);
            if(val_2 == false)
            {
                    0 = this;
                val_2 = response.deviceHash;
                mem[1152921514332267844] = val_2;
            }
            
            val_21 = response.payload;
            val_22 = 1152921510392296080;
            if((val_21.ContainsKey(key:  1135422960)) != false)
            {
                    val_21 = response.payload;
                object val_4 = val_21.Item[1135422960];
                val_23 = 0;
                if(val_21 != 0)
            {
                    if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_21 = 0;
            }
            
                val_23 = val_21;
            }
            
                mem[1152921514332267852] = val_23;
            }
            
            if(response.error == true)
            {
                    return;
            }
            
            if((response.payload.ContainsKey(key:  -1824276416)) != false)
            {
                    object val_6 = response.payload.Item[-1824276416];
                val_24 = 0;
                if(response.payload != 0)
            {
                    if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    response.payload = 0;
            }
            
                val_24 = response.payload;
            }
            
                mem[1152921514332267848] = val_24;
            }
            
            if((response.payload.ContainsKey(key:  1135439424)) != false)
            {
                    val_25 = 1152921510385703632;
                object val_8 = response.payload.Item[1135439424];
                mem[1152921514332267860] = 0;
                if((0.ContainsKey(key:  1679334848)) != false)
            {
                    string val_10 = mem[1152921514332267860].Item[1679334848];
                mem[1152921514332267864] = mem[1152921514332267860];
            }
            
            }
            
            if((response.payload.ContainsKey(key:  1135447712)) != false)
            {
                    object val_12 = response.payload.Item[1135447712];
                val_26 = 0;
                if(response.payload != 0)
            {
                    if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    response.payload = 0;
            }
            
                val_26 = response.payload;
            }
            
                mem[1152921514332267868] = val_26;
            }
            
            val_21 = response.payload;
            if((val_21.ContainsKey(key:  1135455984)) == false)
            {
                    return;
            }
            
            object val_14 = response.payload.Item[1135455984];
            val_21 = null;
            val_21 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            mem[1152921514332267856] = val_21;
            val_20 = 0;
            List.Enumerator<T> val_16 = GetEnumerator();
            val_22 = 1152921504685600768;
            val_25 = 1152921514332242752;
            label_40:
            if(MoveNext() == false)
            {
                goto label_36;
            }
            
            val_27 = 0;
            if(val_18 != 0)
            {
                    if(((val_18 + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_18 = 0;
            }
            
                val_27 = val_18;
            }
            
            twelvegigs.sweepstakes.Distribution val_19 = new twelvegigs.sweepstakes.Distribution(distribution:  0);
            Add(item:  458305536);
            goto label_40;
            label_36:
            Dispose();
        }
        private void OnTerminate(twelvegigs.sweepstakes.Response response)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5;
            string val_6;
            val_5 = response.payload;
            val_6 = "destroyed";
            if((val_5.ContainsKey(key:  1135643840)) == false)
            {
                    return;
            }
            
            object val_2 = response.payload.Item[1135643840];
            string val_3 = response.payload.ToString();
            val_5 = this.session;
            val_6 = 0;
            if((response.payload.Equals(value:  val_5)) != true)
            {
                    UnityEngine.Debug.LogWarning(message:  1135652128);
            }
            
            this.session = val_6;
        }
        private void OnPerform(twelvegigs.sweepstakes.Response response)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = response.payload;
            if((val_5.ContainsKey(key:  1616271776)) == false)
            {
                    return;
            }
            
            object val_2 = response.payload.Item[1616271776];
            response.payload.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_3 = null.ToString();
            val_5;
            string val_4 = 1135805015 + 1297836560 + 13152256;
            typeof(System.Object[]).__il2cppRuntimeField_10 = val_5;
            UnityEngine.Debug.LogErrorFormat(format:  1135792928, args:  472754880);
        }
        private void SaveDeviceIdentifiers()
        {
            var val_14;
            string val_1 = DeviceIdPlugin.GetDeviceId();
            this.deviceId = 0;
            System.Byte[] val_2 = twelvegigs.sweepstakes.HashUtil.ToByte(text:  null);
            string val_3 = twelvegigs.sweepstakes.HashUtil.SHA512(bytes:  null);
            this.openUdid = 0;
            string val_4 = this.deviceId.Replace(oldValue:  -1861811360, newValue:  1098586544);
            this.deviceId = this.deviceId;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            string val_6 = DeviceIdPlugin.GetGoogleAdId();
            typeof(System.String[]).__il2cppRuntimeField_10 = 0;
            Add(key:  1135925520, value:  477709520);
            string val_7 = DeviceIdPlugin.GetDeviceId();
            string val_8 = 0.Replace(oldValue:  -1861811360, newValue:  1098586544);
            typeof(System.String[]).__il2cppRuntimeField_10 = 0;
            Add(key:  1135925616, value:  477709520);
            typeof(System.String[]).__il2cppRuntimeField_10 = this.openUdid;
            Add(key:  1135929808, value:  477709520);
            this.deviceIdentifiers = null;
            UnityEngine.RuntimePlatform val_9 = UnityEngine.Application.platform;
            if((-7) < 2)
            {
                goto label_21;
            }
            
            if(0 == 11)
            {
                goto label_22;
            }
            
            if(0 != 0)
            {
                goto label_23;
            }
            
            label_21:
            val_14 = "iOS";
            goto label_24;
            label_23:
            UnityEngine.RuntimePlatform val_10 = UnityEngine.Application.platform;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            UnityEngine.Debug.LogWarningFormat(format:  1135929984, args:  472754880);
            label_22:
            val_14 = "Android";
            label_24:
            typeof(System.Object[]).__il2cppRuntimeField_10 = "Unity";
            string val_11 = UnityEngine.Application.version;
            typeof(System.Object[]).__il2cppRuntimeField_14 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_18 = this.appVersion;
            typeof(System.Object[]).__il2cppRuntimeField_1C = val_14;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "0.0";
            string val_12 = System.String.Format(format:  1135934256, args:  472754880);
            this.UserAgent = "{0}/{1} TinySparkSDK/{2} {3}/{4}";
            string val_13 = System.String.Format(format:  1135938496, arg0:  this.appVersion, arg1:  -771794112, arg2:  1293254912);
            this.xUserAgent = "TinySparkSDK/{0} ({1}; {2})";
        }
        private System.Collections.Generic.Dictionary<string, object> SignRequest(System.Collections.Generic.Dictionary<string, object> payload)
        {
            WordPets.WPTPetTile val_14;
            var val_15;
            var val_16;
            string val_1 = this.security.RequestId();
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  this.security);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1350676976, value:  this.xUserAgent);
            Add(key:  -1824276880, value:  78753792);
            Add(key:  1136091584, value:  13152256);
            Add(key:  1956820704, value:  13152256);
            typeof(System.String[]).__il2cppRuntimeField_10 = this.apiKey;
            typeof(System.String[]).__il2cppRuntimeField_14 = this.apiSecret;
            string val_6 = this.campaignId.ToString();
            typeof(System.String[]).__il2cppRuntimeField_18 = this.campaignId;
            typeof(System.String[]).__il2cppRuntimeField_1C = this.security;
            string val_7 = this.security.UnixTimestamp().ToString();
            typeof(System.String[]).__il2cppRuntimeField_20 = ;
            string val_8 = UnityEngine.Random.Range(min:  1, max:  99999999).ToString();
            typeof(System.String[]).__il2cppRuntimeField_24 = ;
            val_14 = payload;
            string val_9 = val_14.Item[1675191600];
            val_15 = 0;
            if(val_14 != 0)
            {
                    val_14 = null;
                val_16 = 1152921510371125184;
                if(((payload + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_14)
            {
                    val_14 = 0;
            }
            
                val_15 = val_14;
            }
            else
            {
                    val_16 = 1152921510371125184;
            }
            
            string val_10 = val_14.Sign(signParams:  477709520, payload:  0);
            Add(key:  1470913968, value:  val_14);
            if((System.String.IsNullOrEmpty(value:  this.session)) != true)
            {
                    set_Item(key:  1129593040, value:  this.session);
            }
            
            if((System.String.IsNullOrEmpty(value:  this.deviceHash)) != true)
            {
                    System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_13 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                Add(key:  1956388528, value:  this.deviceHash);
                set_Item(key:  -1824276880, value:  78753792);
            }
            
            payload.Add(key:  1615541136, value:  78753792);
        }
        private void <.ctor>b__45_0()
        {
            this.apiRequester.Dequeue();
        }
    
    }

}
