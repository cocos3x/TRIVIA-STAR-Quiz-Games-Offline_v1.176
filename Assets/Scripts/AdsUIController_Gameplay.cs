using UnityEngine;
public class AdsUIController_Gameplay : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject incentivizedButton;
    private UnityEngine.GameObject petIcon;
    private UnityEngine.GameObject incentivizedButtonOpposer;
    private UnityEngine.GameObject incentivizedPlaceholderWGL;
    private UnityEngine.GameObject removeAdsButton;
    private UnityEngine.GameObject removeAdsButtonOpposer;
    private UnityEngine.GameObject howToPlayButton;
    private UnityEngine.GameObject hintButtonGroup;
    private UnityEngine.GameObject megaHintButtonGroup;
    private UnityEngine.GameObject pickerHintButtonGroup;
    private UnityEngine.GameObject freeHintButtonGroup;
    private UnityEngine.GameObject shuffleButtonGroup;
    
    // Properties
    public UnityEngine.GameObject HintButtonGroup { get; }
    public UnityEngine.GameObject MegaHintButtonGroup { get; }
    public UnityEngine.GameObject PickerHintButtonGroup { get; }
    public UnityEngine.GameObject FreeHintButtonGroup { get; }
    public UnityEngine.GameObject ShuffleButtonGroup { get; }
    
    // Methods
    public UnityEngine.GameObject get_HintButtonGroup()
    {
    
    }
    public UnityEngine.GameObject get_MegaHintButtonGroup()
    {
    
    }
    public UnityEngine.GameObject get_PickerHintButtonGroup()
    {
    
    }
    public UnityEngine.GameObject get_FreeHintButtonGroup()
    {
    
    }
    public UnityEngine.GameObject get_ShuffleButtonGroup()
    {
    
    }
    public void ToggleIncentivizedButton()
    {
        var val_27;
        var val_28;
        var val_29;
        bool val_30;
        bool val_31;
        var val_32;
        if(0 == this.incentivizedButton)
        {
            goto label_56;
        }
        
        var val_24 = 24680067;
        val_24 = 10945720 + val_24;
        if(val_24 == 0)
        {
                mem2[0] = 1;
        }
        
        val_27 = null;
        val_27 = null;
        if(App.game == 1)
        {
            goto label_15;
        }
        
        if(val_24 == 0)
        {
                mem2[0] = 1;
        }
        
        val_28 = null;
        val_28 = null;
        if(App.game == 18)
        {
            goto label_15;
        }
        
        if(val_24 == 0)
        {
                mem2[0] = 1;
        }
        
        val_29 = null;
        val_29 = null;
        if(App.game != 4)
        {
            goto label_21;
        }
        
        label_15:
        UnityEngine.GameObject val_2 = this.incentivizedButton.gameObject;
        label_77:
        this.incentivizedButton.SetActive(value:  false);
        label_56:
        if(0 == this.removeAdsButton)
        {
                return;
        }
        
        val_30 = 0;
        if((AdsManager.ShowAdsControlButtons(fromSettings:  false)) != false)
        {
                val_30 = 1;
            if(this.removeAdsButtonOpposer != 0)
        {
                val_30 = this.removeAdsButtonOpposer.activeSelf ^ 1;
        }
        
        }
        
        this.removeAdsButton.SetActive(value:  val_30);
        return;
        label_21:
        if(this.howToPlayButton != 0)
        {
                val_31 = 0;
            Player val_8 = App.Player;
            if(0 >= 2)
        {
                twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_31 = VideoAdsAllowed ^ 1;
        }
        
            this.howToPlayButton.SetActive(value:  val_31);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.incentivizedButton.SetActive(value:  VideoAdsAllowed);
        if(this.incentivizedPlaceholderWGL != 0)
        {
                this.incentivizedPlaceholderWGL.SetActive(value:  false);
        }
        
        if(this.petIcon == 0)
        {
            goto label_56;
        }
        
        GameBehavior val_15 = App.getBehavior;
        val_32 = 0;
        if(0 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(VideoAdsAllowed != false)
        {
                val_32 = 0;
            WADPets.WADPet val_18 = WADPetsManager.GetPetByAbility(ability:  4);
            if(4.IsActive() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_32 = 1;
            if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_32 = PlayingChallenge ^ 1;
        }
        
        }
        
        }
        
        }
        
        if(this.petIcon != 0)
        {
            goto label_77;
        }
        
        goto label_77;
    }
    public AdsUIController_Gameplay()
    {
    
    }

}
