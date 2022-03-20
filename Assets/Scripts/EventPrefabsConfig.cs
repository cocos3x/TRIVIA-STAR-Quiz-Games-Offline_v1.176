using UnityEngine;
public class EventPrefabsConfig : MonoBehaviour
{
    // Fields
    protected WGEventButtonV2 evtBtnAttackMadness;
    protected WGEventButtonProgress evtProgressAttackMadness;
    protected WGEventButtonV2 evtBtnRaidMadness;
    protected WGEventButtonProgress evtProgressRaidMadness;
    protected WGEventButtonV2 evtBtnForestMaster;
    protected WGEventButtonProgress evtProgressForestMaster;
    protected WGEventButtonV2 evtBtnLightningLevels;
    protected WGEventButtonProgress evtProgressLightningLevels;
    protected WGEventButtonV2 evtBtnIslandParadise;
    protected WGEventButtonProgress evtProgressIslandParadise;
    protected WGEventButtonV2 evtBtnWordHunt;
    protected WGEventButtonProgress evtProgressWordHunt;
    protected UnityEngine.Sprite evtIconWordHunt;
    protected WGEventButtonV2 evtBtnWildWordWeekend;
    protected WGEventButtonProgress evtProgressWildWordWeekend;
    
    // Properties
    public UnityEngine.Sprite EventIconWordHunt { get; }
    
    // Methods
    public UnityEngine.Sprite get_EventIconWordHunt()
    {
    
    }
    public WGEventButtonV2 GetEventButtonPrefab(string eventId)
    {
        WGEventButtonV2 val_9;
        var val_10;
        uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  eventId);
        if(val_1 > 2902602938)
        {
            goto label_1;
        }
        
        if(val_1 > 999457290)
        {
            goto label_2;
        }
        
        if(val_1 == 145907821)
        {
            goto label_3;
        }
        
        val_9 = 0;
        if(val_1 != 999457290)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  eventId, b:  -1549997168)) == true)
        {
                val_9 = this.evtBtnAttackMadness;
        }
        
        return;
        label_1:
        if(val_1 > 3244402182)
        {
            goto label_6;
        }
        
        if(val_1 == 3165936380)
        {
            goto label_7;
        }
        
        val_9 = 0;
        if(val_1 != 3244402182)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  eventId, b:  -1425319472)) == true)
        {
                val_9 = this.evtBtnForestMaster;
        }
        
        return;
        label_2:
        if(val_1 == 2902602938)
        {
            goto label_10;
        }
        
        val_9 = 0;
        if(val_1 != 1751534916)
        {
                return;
        }
        
        val_10 = "HotNSpicy";
        goto label_12;
        label_6:
        if(val_1 == 3671570374)
        {
            goto label_13;
        }
        
        val_9 = 0;
        if(val_1 != 4210228650)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  eventId, b:  -1266462304)) == true)
        {
                val_9 = this.evtBtnLightningLevels;
        }
        
        return;
        label_3:
        val_10 = "IslandParadiseSymbol";
        label_12:
        if((System.String.op_Equality(a:  eventId, b:  -1266461296)) == true)
        {
                val_9 = this.evtBtnIslandParadise;
        }
        
        return;
        label_7:
        if((System.String.op_Equality(a:  eventId, b:  -1298909328)) == true)
        {
                val_9 = this.evtBtnWordHunt;
        }
        
        return;
        label_10:
        if((System.String.op_Equality(a:  eventId, b:  -1280644912)) == true)
        {
                val_9 = this.evtBtnWildWordWeekend;
        }
        
        return;
        label_13:
        if((System.String.op_Equality(a:  eventId, b:  -1298907488)) == true)
        {
                val_9 = this.evtBtnRaidMadness;
        }
    
    }
    public WGEventButtonProgress GetEventProgressPrefab(string eventId)
    {
        WGEventButtonProgress val_9;
        var val_10;
        uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  eventId);
        if(val_1 > 2902602938)
        {
            goto label_1;
        }
        
        if(val_1 > 999457290)
        {
            goto label_2;
        }
        
        if(val_1 == 145907821)
        {
            goto label_3;
        }
        
        val_9 = 0;
        if(val_1 != 999457290)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  eventId, b:  -1549997168)) == true)
        {
                val_9 = this.evtProgressAttackMadness;
        }
        
        return;
        label_1:
        if(val_1 > 3244402182)
        {
            goto label_6;
        }
        
        if(val_1 == 3165936380)
        {
            goto label_7;
        }
        
        val_9 = 0;
        if(val_1 != 3244402182)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  eventId, b:  -1425319472)) == true)
        {
                val_9 = this.evtProgressForestMaster;
        }
        
        return;
        label_2:
        if(val_1 == 2902602938)
        {
            goto label_10;
        }
        
        val_9 = 0;
        if(val_1 != 1751534916)
        {
                return;
        }
        
        val_10 = "HotNSpicy";
        goto label_12;
        label_6:
        if(val_1 == 3671570374)
        {
            goto label_13;
        }
        
        val_9 = 0;
        if(val_1 != 4210228650)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  eventId, b:  -1266462304)) == true)
        {
                val_9 = this.evtProgressLightningLevels;
        }
        
        return;
        label_3:
        val_10 = "IslandParadiseSymbol";
        label_12:
        if((System.String.op_Equality(a:  eventId, b:  -1266461296)) == true)
        {
                val_9 = this.evtProgressIslandParadise;
        }
        
        return;
        label_7:
        if((System.String.op_Equality(a:  eventId, b:  -1298909328)) == true)
        {
                val_9 = this.evtProgressWordHunt;
        }
        
        return;
        label_10:
        if((System.String.op_Equality(a:  eventId, b:  -1280644912)) == true)
        {
                val_9 = this.evtProgressWildWordWeekend;
        }
        
        return;
        label_13:
        if((System.String.op_Equality(a:  eventId, b:  -1298907488)) == true)
        {
                val_9 = this.evtProgressRaidMadness;
        }
    
    }
    public EventPrefabsConfig()
    {
    
    }

}
