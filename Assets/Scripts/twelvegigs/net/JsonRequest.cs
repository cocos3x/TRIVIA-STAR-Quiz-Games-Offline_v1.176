using UnityEngine;

namespace twelvegigs.net
{
    public class JsonRequest
    {
        // Fields
        public const string GET = "GET";
        public const string POST = "POST";
        public const string PUT = "PUT";
        public const string DELETE = "DELETE";
        private bool requestFailed;
        private string err;
        public bool completed;
        public bool logging;
        protected string url;
        protected string userAgent;
        protected string xUserAgent;
        protected string contentType;
        private System.Net.CookieContainer cookieJar;
        private bool throwExceptionOnRequestFailure;
        protected string uri;
        protected string requestType;
        protected object postParameters;
        protected System.Action<string, System.Collections.Generic.Dictionary<string, object>> onComplete;
        protected System.Collections.Generic.Dictionary<string, object> onCompleteResponse;
        protected System.DateTime start;
        protected double duration;
        protected string formattedJson;
        protected System.Action onExecute;
        protected int timeout;
        protected bool _destroy;
        public NetworkThreadingHandler threadHandler;
        public System.Action<twelvegigs.net.JsonRequestStats, System.Collections.Generic.Dictionary<string, object>> responseTracker;
        public string responseString;
        public System.Net.HttpStatusCode responseStatusCode;
        
        // Properties
        public string UserAgent { get; set; }
        public string XuserAgent { get; set; }
        public string ContentType { get; set; }
        public System.Net.CookieContainer CookieJar { set; }
        public bool ThrowExceptionOnRequestFailure { get; set; }
        public string URI { get; }
        public bool destroy { get; }
        
        // Methods
        public string get_UserAgent()
        {
        
        }
        public void set_UserAgent(string value)
        {
            this.userAgent = value;
        }
        public string get_XuserAgent()
        {
        
        }
        public void set_XuserAgent(string value)
        {
            this.xUserAgent = value;
        }
        public string get_ContentType()
        {
        
        }
        public void set_ContentType(string value)
        {
            this.contentType = value;
        }
        public void set_CookieJar(System.Net.CookieContainer value)
        {
            this.cookieJar = value;
        }
        public bool get_ThrowExceptionOnRequestFailure()
        {
            return (bool)this.throwExceptionOnRequestFailure;
        }
        public void set_ThrowExceptionOnRequestFailure(bool value)
        {
            this.throwExceptionOnRequestFailure = value;
        }
        public string get_URI()
        {
        
        }
        public bool get_destroy()
        {
            return (bool)this._destroy;
        }
        public JsonRequest()
        {
            this.timeout = 20;
            this.throwExceptionOnRequestFailure = true;
        }
        public JsonRequest(string url, string uri, string requestType, System.Action<string, System.Collections.Generic.Dictionary<string, object>> onComplete, object parameters, bool log, int timeout = 20, bool destroy = False)
        {
            System.Action<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_5;
            this.timeout = 20;
            this.throwExceptionOnRequestFailure = true;
            val_1 = new System.Object();
            this.uri = val_1;
            string val_2 = url + val_1;
            this.url = url;
            this.requestType = requestType;
            System.Delegate val_3 = System.Delegate.Combine(a:  this.onComplete, b:  onComplete);
            val_5 = 0;
            if(this.onComplete != 0)
            {
                    if(null != null)
            {
                    val_5 = 0;
            }
            else
            {
                    val_5 = this.onComplete;
            }
            
            }
            
            int val_5 = 1000;
            this.postParameters = parameters;
            this.onComplete = val_5;
            val_5 = timeout * val_5;
            this.logging = false;
            this.timeout = val_5;
            System.Action val_4 = new System.Action(object:  1159107232, method:  typeof(twelvegigs.net.JsonRequest).__il2cppRuntimeField_E8);
            this._destroy = destroy;
            this.onExecute = null;
        }
        public virtual void execute()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            this.start = new System.DateTime();
            this.onExecute.Invoke();
        }
        protected virtual void webRequestExecute()
        {
            System.Threading.WaitHandle val_11;
            var val_12;
            var val_13;
            string val_14;
            System.Threading.WaitHandle val_15;
            val_11 = 0;
            System.Net.WebRequest val_1 = System.Net.WebRequest.Create(requestUriString:  this.url);
            if(this.userAgent != null)
            {
                    UserAgent = this.userAgent;
            }
            
            if(this.xUserAgent != null)
            {
                    val_12 = this;
                val_13 = 0;
                val_14 = this.requestType;
            }
            else
            {
                    val_12 = this;
                val_13 = 0;
                val_14 = this.requestType;
                if( == null)
            {
                    val_13 = 1;
            }
            
            }
            
            if(val_13 != 0)
            {
                    ReadWriteTimeout = this.timeout;
            }
            else
            {
                    ReadWriteTimeout = this.timeout;
            }
            
            if((System.String.op_Equality(a:  val_14, b:  1466316768)) != true)
            {
                    if((System.String.op_Equality(a:  val_14, b:  1466317088)) == false)
            {
                goto label_21;
            }
            
            }
            
            System.AsyncCallback val_4 = new System.AsyncCallback(object:  1159400080, method:  new IntPtr(1159373008));
            label_29:
            val_15 = ;
            if(val_15 == null)
            {
                    label_28:
                val_15 = 0;
            }
            
            if(mem[1179403825] == 0)
            {
                goto label_26;
            }
            
            var val_11 = 0;
            label_25:
            if((mem[1179403735] + 0) == null)
            {
                goto label_24;
            }
            
            val_11 = val_11 + 1;
            if(((uint)val_11 & 65535) < mem[1179403825])
            {
                goto label_25;
            }
            
            goto label_26;
            label_24:
            var val_5 = mem[1179403735] + 0;
            var val_12 = (mem[1179403735] + 0) + 4;
            val_12 = val_15 + (val_12 << 3);
            val_15 = val_12 + 196;
            label_26:
            System.Threading.WaitOrTimerCallback val_6 = new System.Threading.WaitOrTimerCallback(object:  1159400080, method:  new IntPtr(1159374032));
            System.Threading.RegisteredWaitHandle val_7 = System.Threading.ThreadPool.RegisterWaitForSingleObject(waitObject:  val_15, callBack:  41213952, state:  null, millisecondsTimeOutInterval:  this.timeout, executeOnlyOnce:  true);
            return;
            label_21:
            if((System.String.op_Equality(a:  val_14, b:  1466316848)) != true)
            {
                    if((System.String.op_Equality(a:  val_14, b:  1466317008)) == false)
            {
                goto label_28;
            }
            
            }
            
            System.AsyncCallback val_10 = new System.AsyncCallback(object:  1159400080, method:  new IntPtr(1159375056));
            goto label_29;
        }
        private void TimeoutCallback(object state, bool timedOut)
        {
            if(state == 0)
            {
                    return;
            }
            
            if(((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Net.HttpWebRequest.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    state = 0;
                return;
            }
            
            if(R4 == 0)
            {
                
            }
        
        }
        protected void bridgeExecute()
        {
            UnityBridge.Send(url:  this.url, requestType:  this.requestType, data:  this.postParameters, threadHandler:  this.threadHandler);
        }
        public virtual void fireCallback()
        {
            if(this.onComplete != 0)
            {
                    this.onComplete.Invoke(arg1:  this.url, arg2:  this.onCompleteResponse);
            }
            
            this.onComplete = 0;
            this.TrackRequest();
        }
        private void TrackRequest()
        {
            if(this.responseTracker == 0)
            {
                    return;
            }
            
            this.responseTracker.Invoke(arg1:  new twelvegigs.net.JsonRequestStats() {method = mem[this.duration + (0)], url = this.requestType, duration = this.url, responseCode = mem[this.duration + (4)], jsonParams = this.responseStatusCode}, arg2:  mem[this.duration + (8)]);
            this.responseTracker = 0;
        }
        private void finishedRequest(System.IAsyncResult result)
        {
            var val_6;
            var val_7;
            var val_8;
            System.Net.HttpStatusCode val_9;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = result;
            if(result != 0)
            {
                    val_7 = null;
            }
            
            if(result != 0)
            {
                    val_7 = null;
                val_8 = 0;
                if(((System.IAsyncResult.__il2cppRuntimeField_typeHierarchy + (System.Net.HttpWebRequest.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_7)
            {
                    result = 0;
            }
            
                val_8 = result;
            }
            else
            {
                    val_8 = 0;
            }
            
            val_9 = val_8;
            val_9 = 0;
            System.Text.Encoding val_2 = System.Text.Encoding.UTF8;
            this.responseString = new System.IO.StreamReader(stream:  0, encoding:  0);
            this.responseStatusCode = val_9;
            System.Threading.ThreadStart val_4 = new System.Threading.ThreadStart(object:  1160105488, method:  new IntPtr(1160080464));
            System.Threading.Thread val_5 = new System.Threading.Thread(start:  41746432);
            Start();
            Join();
        }
        private void startedPostRequest(System.IAsyncResult result)
        {
            var val_9;
            var val_10;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = result;
            string val_2 = MiniJSON.Json.Serialize(obj:  this.postParameters);
            this.formattedJson = this.postParameters;
            System.IO.StreamWriter val_3 = new System.IO.StreamWriter(stream:  0);
            System.AsyncCallback val_4 = new System.AsyncCallback(object:  1160239152, method:  new IntPtr(1160209872));
            var val_11 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_12;
            }
            
            var val_10 = 0;
            label_14:
            if((mem[1179403735] + 0) == null)
            {
                goto label_13;
            }
            
            val_10 = val_10 + 1;
            if(((uint)val_10 & 65535) < mem[1179403825])
            {
                goto label_14;
            }
            
            label_12:
            val_10 = 0;
            goto label_15;
            label_13:
            var val_5 = mem[1179403735] + 0;
            val_11 = val_11 + (((mem[1179403735] + 0) + 4) << 3);
            val_10 = val_11 + 196;
            label_15:
            System.Threading.WaitOrTimerCallback val_6 = new System.Threading.WaitOrTimerCallback(object:  1160239152, method:  new IntPtr(1159374032));
            System.Threading.RegisteredWaitHandle val_7 = System.Threading.ThreadPool.RegisterWaitForSingleObject(waitObject:  0, callBack:  41213952, state:  0, millisecondsTimeOutInterval:  this.timeout, executeOnlyOnce:  true);
        }
        private void finishedPostRequest(System.IAsyncResult result)
        {
            var val_6;
            var val_7;
            var val_8;
            System.Net.HttpStatusCode val_9;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = result;
            if(result != 0)
            {
                    val_7 = null;
            }
            
            if(result != 0)
            {
                    val_7 = null;
                val_8 = 0;
                if(((System.IAsyncResult.__il2cppRuntimeField_typeHierarchy + (System.Net.HttpWebRequest.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_7)
            {
                    result = 0;
            }
            
                val_8 = result;
            }
            else
            {
                    val_8 = 0;
            }
            
            val_9 = val_8;
            val_9 = 0;
            System.Text.Encoding val_2 = System.Text.Encoding.UTF8;
            this.responseString = new System.IO.StreamReader(stream:  0, encoding:  0);
            this.responseStatusCode = val_9;
            System.Threading.ThreadStart val_4 = new System.Threading.ThreadStart(object:  1160371632, method:  new IntPtr(1160080464));
            System.Threading.Thread val_5 = new System.Threading.Thread(start:  41746432);
            Start();
            Join();
        }
        private void finalizeWithError(System.Net.WebException webEx)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1616271776, value:  8945664);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            Add(item:  824159456);
            Add(key:  490614624, value:  80883712);
            Add(key:  -220247616, value:  13152256);
            string val_3 = webEx.Message;
            Add(key:  1622701360, value:  webEx);
            string val_4 = MiniJSON.Json.Serialize(obj:  78753792);
            this.responseString = null;
            this.requestFailed = true;
            System.Threading.ThreadStart val_5 = new System.Threading.ThreadStart(object:  1160495920, method:  new IntPtr(1160080464));
            if((new System.Threading.Thread(start:  41746432)) != 0)
            {
                    Start();
            }
            else
            {
                    Start();
            }
            
            Join();
        }
        public void finalize()
        {
            ulong val_2;
            double val_5;
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921514357389736}, d2:  new System.DateTime() {dateData = val_2});
            double val_7 = val_5.TotalMilliseconds;
            this.duration = val_5;
            object val_8 = MiniJSON.Json.Deserialize(json:  this.responseString);
            if(this.responseString != null)
            {
                    if(((System.String.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    this.responseString = 0;
            }
            
                0 = this.responseString;
            }
            
            this.completed = true;
            this.onCompleteResponse = 0;
        }
        public virtual void Cleanup()
        {
            this.onComplete = 0;
            this.onCompleteResponse = 0;
            this.onExecute = 0;
            this.threadHandler = 0;
        }
        private void LogClientError(string error)
        {
            var val_1;
            var val_2;
            val_1 = 35665050;
            if(this.throwExceptionOnRequestFailure == false)
            {
                    return;
            }
            
            val_1 = public static T[] System.Array::Empty<System.Object>();
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_2 == 1)
            {
                    val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            D.LogClientError(developer:  error, filter:  1788750208, context:  0, strings:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
    
    }

}
