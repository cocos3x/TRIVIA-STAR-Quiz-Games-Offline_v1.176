using UnityEngine;
public class FirebasePlugin : Tracker, PluginObserver
{
    // Fields
    private bool initialized;
    private Firebase.FirebaseApp app;
    
    // Methods
    private void InitializeFirebaseAndStart()
    {
        if(this.initialized == true)
        {
                return;
        }
        
        System.Threading.Tasks.Task<Firebase.DependencyStatus> val_1 = Firebase.FirebaseApp.CheckAndFixDependenciesAsync();
        System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  R4, method:  new IntPtr(2444788464));
        System.Threading.Tasks.Task val_3 = 0.ContinueWith(continuationAction:  7401472);
    }
    public PluginObserverManager.ObserverType getType()
    {
    
    }
    public string pluginName()
    {
    
    }
    public bool isWorking()
    {
        return (bool)this;
    }
    public bool isInitialized()
    {
        return (bool)this.initialized;
    }
    public string errorMessage()
    {
        if(this.initialized == false)
        {
                return;
        }
        
        if(R1 == 0)
        {
                "Event Tracking is working correctly. " = "Event Tracking is not being used. ";
        }
        
        return -1988223120(-1988223120) + -1988223008(-1988223008);
    }
    public FirebasePlugin()
    {
        if(this.initialized == true)
        {
                return;
        }
        
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        AddObserver(observer:  R4);
        R4.InitializeFirebaseAndStart();
    }
    public override void trackEvent(string eventName, System.Collections.Generic.Dictionary<string, object> data)
    {
    
    }
    public override void trackEvent(string eventName, string propertyName, string propertyValue)
    {
        if(this.initialized == false)
        {
                return;
        }
        
        string val_1 = eventName.ToLower();
        string val_2 = eventName.Replace(oldValue:  1297836560, newValue:  2144339952);
        Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  eventName);
    }
    public override void identify(string id)
    {
    
    }
    public override void increment(string eventName, string eventValue)
    {
    
    }
    public override void peopleIncrement(string eventName, string eventValue)
    {
    
    }
    public override void peopleProperty(string propertyName, string propertyValue)
    {
    
    }
    public override void superProperty(string propertyName, string propertyValue)
    {
    
    }
    public override void trackCharge(string quantity, System.Collections.Generic.Dictionary<string, object> data)
    {
    
    }
    private void <InitializeFirebaseAndStart>b__2_0(System.Threading.Tasks.Task<Firebase.DependencyStatus> task)
    {
        Firebase.DependencyStatus val_1 = task.Result;
        if(task != 0)
        {
                string val_2 = System.String.Format(format:  -1848360496, arg0:  217038848);
            UnityEngine.Debug.LogError(message:  -1848360496);
            return;
        }
        
        Firebase.FirebaseApp val_3 = Firebase.FirebaseApp.DefaultInstance;
        this.app = 0;
        this.initialized = true;
        UnityEngine.Debug.Log(message:  -1848360320);
    }

}
