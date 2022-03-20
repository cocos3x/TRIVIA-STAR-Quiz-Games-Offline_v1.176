using UnityEngine;
public class LocalGameEventExampleFeature : LocalGameEventSpawner<LocalGameEventExampleFeature>
{
    // Fields
    private static bool showExample;
    private GameEventV2 myProxyEvent;
    
    // Methods
    public override void InitSpwaner()
    {
    
    }
    protected override bool CanAddProxyEvent()
    {
        return false;
    }
    protected override void PopulateProxyEvent(ref GameEventV2 proxyEvent)
    {
        this.myProxyEvent = proxyEvent;
    }
    protected override void UpdateProxyEventHandler(ref WGEventHandler proxyEventHandler)
    {
        var val_1;
        WGEventHandler val_2;
        val_1 = 35632349;
        val_2 = proxyEventHandler;
        if(val_2 != 0)
        {
                val_1 = mem[mem[proxyEventHandler] + 180];
            val_1 = mem[proxyEventHandler] + 180;
        }
        
        val_2 = proxyEventHandler;
        if(val_2 != 0)
        {
            
        }
    
    }
    protected override bool ShouldRemoveProxyEvent(WGEventHandler handler)
    {
        return false;
    }
    protected override string GetProxyEventTrackingName()
    {
    
    }
    public LocalGameEventExampleFeature()
    {
    
    }
    private static LocalGameEventExampleFeature()
    {
    
    }

}
