using UnityEngine;
public class WGServerController : MonoSingleton<WGServerController>
{
    // Fields
    protected System.Action<System.Collections.Generic.Dictionary<string, object>> dataFilter;
    private const string WG_SERVER_UPDATE = "OnWGServerUpateNotification";
    protected const string api_ns = "/api/word";
    protected const string worlds_index = "/worlds/";
    protected const string chapters_index = "/chapters/";
    protected const string progress_index = "/progress/";
    protected const string defintion_index = "/definitions/";
    
    // Methods
    public void GetWordDefinition(string word, System.Action<System.Collections.Generic.Dictionary<string, object>> callback, System.Action<System.Collections.Generic.Dictionary<string, object>> onFailure)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        string val_2 = 48518176 + word;
    }
    protected virtual bool PreProcessFilter(string apiCall, System.Collections.Generic.Dictionary<string, object> response, System.Action<System.Collections.Generic.Dictionary<string, object>> failure)
    {
        var val_5;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_6;
        var val_7;
        var val_8;
        val_5 = failure;
        val_6 = response;
        val_7 = 35627551;
        if(val_6 == 0)
        {
            goto label_5;
        }
        
        val_7 = "success";
        if((val_6.ContainsKey(key:  1616271776)) == false)
        {
            goto label_2;
        }
        
        object val_2 = val_6.Item[1616271776];
        val_7 = val_6;
        val_7.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        if(null == 0)
        {
            goto label_5;
        }
        
        label_2:
        if(this.dataFilter != 0)
        {
                this.dataFilter.Invoke(obj:  val_6);
        }
        
        if((val_6.ContainsKey(key:  48658960)) == false)
        {
            goto label_7;
        }
        
        object val_4 = val_6.Item[48658960];
        val_6 = val_6;
        val_5 = null;
        val_6.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        if(null == 0)
        {
                val_8 = 1;
        }
        
        return (bool)val_8;
        label_5:
        val_8 = 0;
        if(val_5 == 0)
        {
                return (bool)val_8;
        }
        
        val_5.Invoke(obj:  val_6);
        return (bool)val_8;
        label_7:
        val_8 = 1;
        return (bool)val_8;
    }
    public virtual void RegisterDataFilter(System.Action<System.Collections.Generic.Dictionary<string, object>> callback)
    {
        this.dataFilter = callback;
    }
    protected virtual void DoRequest(WGServerController.RequestType verb, string uri, System.Collections.Generic.Dictionary<string, object> requestParameters, System.Action<System.Collections.Generic.Dictionary<string, object>> onCompleteCallback, bool doPostUpdate = True, System.Action<System.Collections.Generic.Dictionary<string, object>> failureCallback)
    {
        System.Action<System.Threading.Tasks.Task, System.Object> val_7;
        var val_8;
        val_7 = verb;
        if(new System.Object() != 0)
        {
                typeof(WGServerController.<>c__DisplayClass5_0).__il2cppRuntimeField_8 = this;
            typeof(WGServerController.<>c__DisplayClass5_0).__il2cppRuntimeField_C = failureCallback;
            typeof(WGServerController.<>c__DisplayClass5_0).__il2cppRuntimeField_10 = onCompleteCallback;
        }
        else
        {
                mem[8] = this;
            mem[12] = failureCallback;
            mem[16] = onCompleteCallback;
        }
        
        typeof(WGServerController.<>c__DisplayClass5_0).__il2cppRuntimeField_14 = doPostUpdate;
        if(val_7 > 3)
        {
                return;
        }
        
        var val_2 = 7011472 + (7011472 + (verb) << 2);
        if(val_7 == 3)
        {
                7011472 = 7011472;
            7011472 = 2813952;
        }
        
        if(val_7 == 3)
        {
                mem2[0] = 7011472 + IP + this;
        }
        
        var val_7 = 28614518;
        val_7 = 7011540 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        val_7 = null;
        val_7 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  393236480, method:  new IntPtr(48928112));
        App.networkManager.DoGet(path:  uri, onCompleteFunction:  7507968, destroy:  true, immediate:  false, getParams:  requestParameters, timeout:  20);
    }
    private void TryPostUpdate(System.Collections.Generic.Dictionary<string, object> responseObject)
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  49092912, aName:  49068784);
    }
    public WGServerController()
    {
    
    }

}
