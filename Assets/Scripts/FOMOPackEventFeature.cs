using UnityEngine;
public class FOMOPackEventFeature : LocalGameEventSpawner<FOMOPackEventFeature>
{
    // Fields
    private static bool showFOMO;
    private GameEventV2 myProxyEvent;
    
    // Methods
    public override void InitSpwaner()
    {
    
    }
    protected override bool CanAddProxyEvent()
    {
        FOMOPackEventHandler val_1 = FOMOPackEventHandler.<Instance>k__BackingField;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    protected override void PopulateProxyEvent(ref GameEventV2 proxyEvent)
    {
        if(proxyEvent == 0)
        {
                null = 1152921504616751196;
        }
        
        timeEnd = System.DateTime.MaxValue;
        timeExpire = System.DateTime.MaxValue;
        this.myProxyEvent = proxyEvent;
    }
    protected override void UpdateProxyEventHandler(ref WGEventHandler proxyEventHandler)
    {
        var val_2;
        WGEventHandler val_3;
        GameEventV2 val_4;
        val_2 = 35639150;
        val_3 = proxyEventHandler;
        if(val_3 != 0)
        {
                val_4 = null;
            val_2 = mem[mem[proxyEventHandler] + 180];
            val_2 = mem[proxyEventHandler] + 180;
        }
        
        val_3 = proxyEventHandler;
        if(val_3 != 0)
        {
                val_4 = this.myProxyEvent;
        }
    
    }
    protected override bool ShouldRemoveProxyEvent(WGEventHandler handler)
    {
        var val_2;
        if(handler != 0)
        {
                val_2 = null;
        }
        
        val_2 = null;
        if(0 != val_2)
        {
                handler = 0;
        }
        
        goto mem[1179404315];
    }
    protected override object AddProxyEventTrackingData(ref System.Collections.Generic.Dictionary<string, object> trackingData)
    {
    
    }
    protected override string GetProxyEventTrackingName()
    {
    
    }
    public FOMOPackEventFeature()
    {
    
    }
    private static FOMOPackEventFeature()
    {
        FOMOPackEventFeature.showFOMO = true;
    }

}
