using UnityEngine;
public class ApiRequester : MonoBehaviour
{
    // Fields
    private string <serverUrl>k__BackingField;
    public bool logging;
    private ApiRequester.RequestHandler onRequestResponse;
    private bool executing;
    private System.Collections.Queue requests;
    private Request currentRequest;
    
    // Properties
    public string serverUrl { get; set; }
    
    // Methods
    public string get_serverUrl()
    {
    
    }
    public void set_serverUrl(string value)
    {
        this.<serverUrl>k__BackingField = value;
    }
    public void add_onRequestResponse(ApiRequester.RequestHandler value)
    {
        var val_2;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  this.onRequestResponse, b:  value);
        if(this.onRequestResponse == 0)
        {
            goto label_1;
        }
        
        val_2 = this.onRequestResponse;
        if(null == null)
        {
            goto label_2;
        }
        
        label_1:
        val_2 = 0;
        label_2:
        if(this.onRequestResponse != 1152921511274117748)
        {
            goto label_3;
        }
    
    }
    public void remove_onRequestResponse(ApiRequester.RequestHandler value)
    {
        var val_2;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  this.onRequestResponse, value:  value);
        if(this.onRequestResponse == 0)
        {
            goto label_1;
        }
        
        val_2 = this.onRequestResponse;
        if(null == null)
        {
            goto label_2;
        }
        
        label_1:
        val_2 = 0;
        label_2:
        if(this.onRequestResponse != 1152921511274246132)
        {
            goto label_3;
        }
    
    }
    public ApiRequester()
    {
        this.executing = false;
        this.requests = new System.Collections.Queue();
    }
    public void doGet(string url)
    {
        var val_4;
        string val_5;
        string val_6;
        Request val_7;
        val_4 = this;
        val_5 = url;
        val_6 = this.<serverUrl>k__BackingField;
        val_7 = null;
        val_7 = new Request(url:  val_6, method:  val_5, parameters:  0);
        if(this.executing != false)
        {
                if(this.requests != 0)
        {
            goto typeof(System.Collections.Queue).__il2cppRuntimeField_13C;
        }
        
        }
        else
        {
                var val_2 = FP - 16;
        }
    
    }
    public bool reachable()
    {
        UnityEngine.NetworkReachability val_1 = UnityEngine.Application.internetReachability;
        if(0 != 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public void doPost(string url, System.Collections.Generic.Dictionary<string, string> post)
    {
        var val_4;
        System.Collections.Generic.Dictionary<System.String, System.String> val_5;
        string val_6;
        string val_7;
        Request val_8;
        val_4 = this;
        val_5 = post;
        val_6 = url;
        val_7 = this.<serverUrl>k__BackingField;
        val_8 = null;
        val_8 = new Request(url:  val_7, method:  val_6, parameters:  val_5);
        if(this.executing != false)
        {
                if(this.requests != 0)
        {
            goto typeof(System.Collections.Queue).__il2cppRuntimeField_13C;
        }
        
        }
        else
        {
                var val_2 = FP - 24;
        }
    
    }
    private void logRequest(string url, System.Collections.Generic.Dictionary<string, string> post)
    {
        string val_6 = url;
        if(post == 0)
        {
            goto label_1;
        }
        
        string val_1 = -1921925632(-1921925632) + val_6 + -1921925728(-1921925728);
        UnityEngine.Debug.Log(message:  -1921925632);
        Dictionary.Enumerator<TKey, TValue> val_2 = 0.GetEnumerator();
        val_6 = ", value : ";
        label_7:
        if(0.MoveNext() == false)
        {
            goto label_4;
        }
        
        string val_4 = -1921925440(-1921925440) + null + -1921925536(-1921925536) + null;
        UnityEngine.Debug.LogWarning(message:  -1921925440);
        goto label_7;
        label_4:
        0.Dispose();
        return;
        label_1:
        string val_5 = -1921925360(-1921925360) + val_6;
        UnityEngine.Debug.Log(message:  -1921925360);
    }
    private void execute(Request request)
    {
        ApiRequester val_10;
        var val_11;
        val_10 = this;
        this.executing = true;
        if(request.parameters == 0)
        {
            goto label_2;
        }
        
        UnityEngine.WWWForm val_1 = new UnityEngine.WWWForm();
        Dictionary.Enumerator<TKey, TValue> val_2 = 0.GetEnumerator();
        label_6:
        if(0.MoveNext() == false)
        {
            goto label_4;
        }
        
        AddField(fieldName:  R4, value:  null);
        goto label_6;
        label_4:
        0.Dispose();
        val_10 = val_10;
        string val_4 = request.getFullUrl();
        UnityEngine.WWW val_5 = null;
        val_11 = val_5;
        val_5 = new UnityEngine.WWW(url:  request, form:  175824896);
        goto label_8;
        label_2:
        string val_6 = request.getFullUrl();
        UnityEngine.WWW val_7 = null;
        val_11 = val_7;
        val_7 = new UnityEngine.WWW(url:  request);
        label_8:
        this.currentRequest = request;
        System.Collections.IEnumerator val_8 = this.WaitForRequest(urlToCall:  190255104);
        UnityEngine.Coroutine val_9 = val_10.StartCoroutine(routine:  -1921768784);
    }
    private void logResponse(UnityEngine.WWW urlToCall)
    {
        var val_5;
        if(urlToCall != 0)
        {
                string val_1 = urlToCall.url;
            val_5 = urlToCall;
        }
        else
        {
                string val_2 = 0.url;
            val_5 = 0;
        }
        
        string val_3 = urlToCall.text;
        string val_4 = -1921664400(-1921664400) + null + -1921664304(-1921664304) + urlToCall;
        UnityEngine.Debug.Log(message:  -1921664400);
    }
    private System.Collections.IEnumerator WaitForRequest(UnityEngine.WWW urlToCall)
    {
        typeof(ApiRequester.<WaitForRequest>d__19).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(ApiRequester.<WaitForRequest>d__19).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
        }
        
        typeof(ApiRequester.<WaitForRequest>d__19).__il2cppRuntimeField_10 = urlToCall;
    }

}
