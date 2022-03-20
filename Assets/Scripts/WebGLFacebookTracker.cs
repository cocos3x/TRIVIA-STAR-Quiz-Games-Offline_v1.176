using UnityEngine;
public class WebGLFacebookTracker : Tracker
{
    // Fields
    private bool initialized;
    
    // Methods
    public bool isInitialized()
    {
        return (bool)this.initialized;
    }
    public WebGLFacebookTracker()
    {
        this.initialized = true;
    }
    public override void trackEvent(string eventName, System.Collections.Generic.Dictionary<string, object> data)
    {
        if(this.initialized != false)
        {
                FacebookTrackingBridge.TrackEvent(eventName:  eventName);
            return;
        }
        
        string val_1 = -1943952272(-1943952272) + eventName;
        UnityEngine.Debug.Log(message:  -1943952272);
    }
    public override void identify(string id)
    {
    
    }
    public override void trackEvent(string eventName, string propertyName, string propertyValue)
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

}
