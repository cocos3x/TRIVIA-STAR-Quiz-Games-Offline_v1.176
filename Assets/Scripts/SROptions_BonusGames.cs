using UnityEngine;
public class SROptions_BonusGames : SuperLuckySROptionsParent<SROptions_BonusGames>, INotifyPropertyChanged
{
    // Properties
    public string PossibleRewardWheel { get; }
    public string PossibleRewardSlots { get; }
    
    // Methods
    public static void NotifyPropertyChanged(string propertyName)
    {
        if((SuperLuckySROptionsParent<T>._Instance) == 0)
        {
                return;
        }
        
        goto typeof(T).__il2cppRuntimeField_EC;
    }
    public void Back()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        var val_6 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_5 = 0;
        label_4:
        val_5 = 0;
        val_6 = mem[mem[1179403735] + 0];
        val_6 = mem[1179403735] + 0;
        if(val_6 == null)
        {
            goto label_3;
        }
        
        val_5 = val_5 + 1;
        val_5 = (uint)val_5 & 65535;
        if(val_5 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_7 = 0;
        goto label_5;
        label_3:
        var val_2 = mem[1179403735] + 0;
        val_6 = val_6 + (((mem[1179403735] + 0) + 4) << 3);
        val_7 = val_6 + 332;
        label_5:
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_5 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_5 = (uint)val_6 & 65535;
        if(val_5 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_8 = 0;
        goto label_10;
        label_8:
        var val_4 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 292;
        label_10:
        SuperLuckySROptionsController.OpenGameSpecificOptionsController();
    }
    public string get_PossibleRewardWheel()
    {
        var val_3;
        AwardType val_1 = BonusGameWheelPopup.QAHACK_ForceAwardType;
        if(0 != 0)
        {
                AwardType val_2 = BonusGameWheelPopup.QAHACK_ForceAwardType;
            val_3 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            return;
        }
        
        val_3 = "Random";
    }
    public void WheelForceDefault()
    {
        BonusGameWheelPopup.QAHACK_ForceAwardType = 0;
        SROptions_BonusGames.NotifyPropertyChanged(propertyName:  -901306544);
    }
    public void WheelForceCoins()
    {
        BonusGameWheelPopup.QAHACK_ForceAwardType = 1;
        SROptions_BonusGames.NotifyPropertyChanged(propertyName:  -901306544);
    }
    public void WheelForceGolden()
    {
        BonusGameWheelPopup.QAHACK_ForceAwardType = 2;
        SROptions_BonusGames.NotifyPropertyChanged(propertyName:  -901306544);
    }
    public string get_PossibleRewardSlots()
    {
        var val_3;
        GameEventRewardType val_1 = BonusGameSlotMachinePopup.QAHACK_ForceAwardType;
        if(0 != 0)
        {
                GameEventRewardType val_2 = BonusGameSlotMachinePopup.QAHACK_ForceAwardType;
            val_3 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            return;
        }
        
        val_3 = "Random";
    }
    public void SlotsForceDefault()
    {
        BonusGameSlotMachinePopup.QAHACK_ForceAwardType = 0;
        SROptions_BonusGames.NotifyPropertyChanged(propertyName:  -900858432);
    }
    public void SlotsForceCoins()
    {
        BonusGameSlotMachinePopup.QAHACK_ForceAwardType = 1;
        SROptions_BonusGames.NotifyPropertyChanged(propertyName:  -900858432);
    }
    public void SlotsForceGolden()
    {
        BonusGameSlotMachinePopup.QAHACK_ForceAwardType = 2;
        SROptions_BonusGames.NotifyPropertyChanged(propertyName:  -900858432);
    }
    public SROptions_BonusGames()
    {
    
    }

}
