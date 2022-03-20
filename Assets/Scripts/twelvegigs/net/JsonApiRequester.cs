using UnityEngine;

namespace twelvegigs.net
{
    public class JsonApiRequester
    {
        // Fields
        private System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> queue;
        private bool executing;
        private string ServerURL;
        private string adminServerURL;
        private string <UserAgent>k__BackingField;
        private string <XuserAgent>k__BackingField;
        private string <ContentType>k__BackingField;
        public System.Action dequeueHandler;
        private System.Net.CookieContainer cookieJar;
        private bool logging;
        private bool throwExceptions;
        public System.Action<twelvegigs.net.JsonRequestStats, System.Collections.Generic.Dictionary<string, object>> responseTracker;
        
        // Properties
        public string UserAgent { get; set; }
        public string XuserAgent { get; set; }
        public string ContentType { get; set; }
        
        // Methods
        public string get_UserAgent()
        {
        
        }
        public void set_UserAgent(string value)
        {
            this.<UserAgent>k__BackingField = value;
        }
        public string get_XuserAgent()
        {
        
        }
        public void set_XuserAgent(string value)
        {
            this.<XuserAgent>k__BackingField = value;
        }
        public string get_ContentType()
        {
        
        }
        public void set_ContentType(string value)
        {
            this.<ContentType>k__BackingField = value;
        }
        public JsonApiRequester(string ServerURL, System.Action dequeueHandler, bool logStuff, string adminServerURL, bool throwExceptionsOnRequestFailures = True)
        {
            var val_6;
            this.ServerURL = ServerURL;
            this.adminServerURL = adminServerURL;
            this.dequeueHandler = dequeueHandler;
            this.logging = logStuff;
            this.throwExceptions = throwExceptionsOnRequestFailures;
            this.cookieJar = new System.Net.CookieContainer();
            System.Net.Security.RemoteCertificateValidationCallback val_2 = System.Net.ServicePointManager.ServerCertificateValidationCallback;
            System.Net.Security.RemoteCertificateValidationCallback val_3 = new System.Net.Security.RemoteCertificateValidationCallback(object:  0, method:  new IntPtr(1155493152));
            val_6 = 0;
            System.Delegate val_4 = System.Delegate.Combine(a:  0, b:  137113600);
            if(val_6 != 0)
            {
                    if(1179403647 == null)
            {
                goto label_4;
            }
            
            }
            
            val_6 = 0;
            label_4:
            System.Net.ServicePointManager.ServerCertificateValidationCallback = 0;
            System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> val_5 = new System.Collections.Generic.Queue<twelvegigs.net.JsonRequest>();
            this.queue = null;
        }
        public bool Reachable()
        {
            System.Net.IPHostEntry val_1 = System.Net.Dns.GetHostEntry(hostNameOrAddress:  1155619488);
            return true;
        }
        public void DoGet(string path, System.Action<string, System.Collections.Generic.Dictionary<string, object>> onCompleteFunction, bool destroy = False, bool immediate = False, System.Collections.Generic.Dictionary<string, object> getParams, int timeout = 20)
        {
            object val_5;
            bool val_6;
            val_5 = path;
            val_6 = static_value_021FD1F9;
            if(val_6 != true)
            {
                    val_6 = true;
            }
            
            if(getParams != 0)
            {
                    string val_1 = this.ToGetParams(parameters:  getParams);
                string val_2 = System.Uri.EscapeUriString(stringToEscape:  1);
                string val_3 = System.String.Format(format:  1155743872, arg0:  val_5, arg1:  1);
                string val_4 = Replace(oldValue:  1150800832, newValue:  -1467947360);
                val_5 = "{0}?{1}";
            }
            
            this.DoRequest(path:  1155743872, methodType:  1466316768, onCompleteCallback:  onCompleteFunction, postBody:  0, timeout:  timeout, destroy:  destroy, immediate:  false, serverType:  0);
        }
        public void DoPost(string path, object postBody, System.Action<string, System.Collections.Generic.Dictionary<string, object>> onCompleteFunction, int timeout = 20, bool destroy = False, bool immediate = False, twelvegigs.net.ServerType serverType = 0)
        {
            serverType = serverType;
            this.DoRequest(path:  path, methodType:  1466316848, onCompleteCallback:  onCompleteFunction, postBody:  postBody, timeout:  timeout, destroy:  destroy, immediate:  false, serverType:  serverType);
        }
        public void DoPut(string path, object postBody, System.Action<string, System.Collections.Generic.Dictionary<string, object>> onCompleteFunction, int timeout = 20, bool destroy = False, bool immediate = False)
        {
            this.DoRequest(path:  path, methodType:  1466317008, onCompleteCallback:  onCompleteFunction, postBody:  postBody, timeout:  timeout, destroy:  destroy, immediate:  false, serverType:  0);
        }
        public void DoDelete(string path, System.Action<string, System.Collections.Generic.Dictionary<string, object>> onCompleteFunction, int timeout = 20, bool destroy = False, bool immediate = False, System.Collections.Generic.Dictionary<string, object> deleteParams)
        {
            object val_5;
            bool val_6;
            val_5 = path;
            val_6 = static_value_021FD1FC;
            if(val_6 != true)
            {
                    val_6 = true;
            }
            
            if(deleteParams != 0)
            {
                    string val_1 = this.ToGetParams(parameters:  deleteParams);
                string val_2 = System.Uri.EscapeUriString(stringToEscape:  1);
                string val_3 = System.String.Format(format:  1155743872, arg0:  val_5, arg1:  1);
                string val_4 = Replace(oldValue:  1150800832, newValue:  -1467947360);
                val_5 = "{0}?{1}";
            }
            
            this.DoRequest(path:  1155743872, methodType:  1466317088, onCompleteCallback:  onCompleteFunction, postBody:  0, timeout:  timeout, destroy:  destroy, immediate:  false, serverType:  0);
        }
        private void DoRequest(string path, string methodType, System.Action<string, System.Collections.Generic.Dictionary<string, object>> onCompleteCallback, object postBody, int timeout, bool destroy, bool immediate, twelvegigs.net.ServerType serverType = 0)
        {
            string val_6;
            bool val_7;
            var val_8;
            WGBonusRewardsHandler val_1 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            if((UnityEngine.Object.op_Implicit(exists:  -1983121040)) != false)
            {
                    WGBonusRewardsHandler val_3 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            }
            
            if(serverType != 1)
            {
                goto label_10;
            }
            
            val_6 = this.adminServerURL;
            if(val_6 != null)
            {
                goto label_11;
            }
            
            UnityEngine.Debug.LogWarning(message:  1156310752);
            return;
            label_10:
            val_6 = this.ServerURL;
            label_11:
            twelvegigs.net.JsonRequest val_4 = new twelvegigs.net.JsonRequest(url:  val_6, uri:  path, requestType:  methodType, onComplete:  onCompleteCallback, parameters:  postBody, log:  this.logging, timeout:  timeout, destroy:  destroy);
            if(null != 0)
            {
                    typeof(twelvegigs.net.JsonRequest).__il2cppRuntimeField_20 = this.<ContentType>k__BackingField;
                typeof(twelvegigs.net.JsonRequest).__il2cppRuntimeField_18 = this.<UserAgent>k__BackingField;
                typeof(twelvegigs.net.JsonRequest).__il2cppRuntimeField_1C = this.<XuserAgent>k__BackingField;
                typeof(twelvegigs.net.JsonRequest).__il2cppRuntimeField_24 = this.cookieJar;
                val_7 = this.throwExceptions;
            }
            else
            {
                    mem[32] = this.<ContentType>k__BackingField;
                mem[24] = this.<UserAgent>k__BackingField;
                mem[28] = this.<XuserAgent>k__BackingField;
                mem[36] = this.cookieJar;
                val_7 = this.throwExceptions;
            }
            
            typeof(twelvegigs.net.JsonRequest).__il2cppRuntimeField_28 = val_7;
            if(this.responseTracker != 0)
            {
                    System.Delegate val_5 = System.Delegate.Combine(a:  twelvegigs.net.JsonRequest.__il2cppRuntimeField_typeHierarchy, b:  this.responseTracker);
                val_8 = 0;
                typeof(twelvegigs.net.JsonRequest).__il2cppRuntimeField_64 = val_8;
            }
            
            this.launchNetThreadingHandler(request:  459743232);
        }
        public void Dequeue()
        {
            if(true >= 1)
            {
                    twelvegigs.net.JsonRequest val_1 = this.queue.Dequeue();
                this.launchNetThreadingHandler(request:  this.queue);
                return;
            }
            
            this.executing = false;
        }
        private void EnqueueRequest(twelvegigs.net.JsonRequest newRequest)
        {
            this.queue.Enqueue(item:  newRequest);
        }
        private void launchNetThreadingHandler(twelvegigs.net.JsonRequest request)
        {
            System.Action val_3;
            this.executing = true;
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
            if(val_1 != 0)
            {
                    name = request.uri;
            }
            else
            {
                    0.name = request.uri;
            }
            
            object val_2 = AddComponent<System.Object>();
            if(val_1 != 0)
            {
                    typeof(UnityEngine.GameObject).__il2cppRuntimeField_C = request;
                val_3 = this.dequeueHandler;
            }
            else
            {
                    mem[12] = request;
                val_3 = this.dequeueHandler;
            }
            
            typeof(UnityEngine.GameObject).__il2cppRuntimeField_10 = val_3;
            request.threadHandler = val_1;
        }
        private string ToGetParams(System.Collections.Generic.Dictionary<string, object> parameters)
        {
            var val_4;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String> val_6;
            if(parameters == 0)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            val_6 = JsonApiRequester.<>c.<>9__31_0;
            if(val_6 == 0)
            {
                    val_6 = null;
                val_6 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(object:  JsonApiRequester.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(1156928912));
                JsonApiRequester.<>c.<>9__31_0 = val_6;
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_2 = System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.Object, System.Object>, System.Object>(source:  parameters, selector:  7720960);
            TSource[] val_3 = System.Linq.Enumerable.ToArray<System.Object>(source:  parameters);
            return System.String.Join(separator:  1466177632, value:  parameters);
        }
        public static System.Collections.Generic.Dictionary<string, string> GetHashFromQuery(string query)
        {
            string val_11;
            var val_12;
            var val_13;
            val_11 = query;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            val_12 = "&";
            if(val_12 == 0)
            {
                    val_12 = "&";
            }
            
            System.Char[] val_2 = ToCharArray();
            val_13 = 0;
            System.String[] val_3 = val_11.Split(separator:  1466177632);
            string val_4 = val_11 + 16;
            goto label_3;
            label_13:
            int val_5 = 1152921504622235648.IndexOf(value:  1157052176);
            string val_6 = 1152921504622235648.Substring(startIndex:  0, length:  val_5);
            val_11 = 1152921504622235648;
            string val_8 = 1152921504622235648.Substring(startIndex:  val_5 + 1);
            if((System.String.IsNullOrEmpty(value:  15388672)) != true)
            {
                    if((ContainsKey(key:  15388672)) != true)
            {
                    Add(key:  15388672, value:  15388672);
            }
            
            }
            
            val_13 = 1;
            label_3:
            if(val_13 < query.m_firstChar)
            {
                goto label_13;
            }
        
        }
        public static bool ValidateServerCertificate(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            var val_9;
            var val_10;
            val_9 = sslPolicyErrors;
            if(certificate == 0)
            {
                goto label_1;
            }
            
            if(val_9 == 0)
            {
                goto label_5;
            }
            
            val_9 = 0;
            label_22:
            System.Security.Cryptography.X509Certificates.X509ChainStatus[] val_1 = chain.ChainStatus;
            if(val_9 >= chain)
            {
                goto label_5;
            }
            
            System.Security.Cryptography.X509Certificates.X509ChainStatus[] val_2 = chain.ChainStatus;
            System.Security.Cryptography.X509Certificates.X509ChainPolicy val_3 = chain.ChainPolicy;
            chain.RevocationFlag = 1;
            System.Security.Cryptography.X509Certificates.X509ChainPolicy val_4 = chain.ChainPolicy;
            chain.RevocationMode = 1;
            System.Security.Cryptography.X509Certificates.X509ChainPolicy val_5 = chain.ChainPolicy;
            System.TimeSpan val_6 = new System.TimeSpan(hours:  0, minutes:  1, seconds:  0);
            mem2[0] = val_6._ticks;
            System.Security.Cryptography.X509Certificates.X509ChainPolicy val_7 = chain.ChainPolicy;
            chain.VerificationFlags = 4095;
            val_10 = 0;
            if((chain.Build(certificate:  0)) == false)
            {
                    return (bool)val_10;
            }
            
            val_9 = val_9 + 1;
            goto label_22;
            label_5:
            val_10 = 1;
            return (bool)val_10;
            label_1:
            val_10 = 0;
            return (bool)val_10;
        }
    
    }

}
