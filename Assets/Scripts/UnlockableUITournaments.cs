using UnityEngine;
public class UnlockableUITournaments : WGUnlockableUIElement
{
    // Fields
    private UnityEngine.UI.Text text_tournament_place;
    private UnityEngine.GameObject placeTextBackground;
    private UGUINetworkedButton networkedButton;
    
    // Properties
    protected override int UnlockLevel { get; }
    protected override bool FeatureHidden { get; }
    
    // Methods
    private void Awake()
    {
        if(true != 0)
        {
                if(((-2065588224 + (UGUINetworkedButton.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                true = 0;
        }
        
            0 = true;
        }
        
        this.networkedButton = 0;
        if(0 == 0)
        {
                UnityEngine.Debug.LogError(message:  -155474688);
            return;
        }
        
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -155445392, method:  new IntPtr(4139496880));
        this.networkedButton.OnConnectionClick = null;
    }
    protected override int get_UnlockLevel()
    {
        return 50;
    }
    protected override bool get_FeatureHidden()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return true;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        return UnityEngine.Object.op_Equality(x:  -1671729424, y:  0);
    }
    protected override void OnClickUnlocked()
    {
    
    }
    private void OnNetworkedClick(bool isConnected)
    {
        var val_13;
        System.Action val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_13 = this;
        if(isConnected != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GameBehavior val_2 = App.getBehavior;
            if(0 != 0)
        {
            goto (1179403647 + (public TournamentsPopup MetaGameBehavior::ShowUGUIMonolith<TournamentsPopup>(bool showNext).__il2cppRuntimeField_28) << 3) + 192;
        }
        
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_14 = 0;
            object val_5 = PlaceGameObject<System.Object>(loc:  0);
            val_15 = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
            UnityEngine.GameObject val_6 = R4.gameObject;
            val_16 = R4;
            val_17 = "tournament_connection";
            val_18 = "Internet connection required. Please check your connection and try again!";
            string val_10 = Localization.Localize(key:  -509555936, defaultValue:  -1671479392, useSingularKey:  false);
            ShowToolTip(objToToolTip:  -154993296, text:  -509555936, topToolTip:  true, displayDuration:  null, width:  null, height:  null, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  1080033280, showGotItButton:  false, gotItCallback:  null, showPick:  false, maxFontSize:  null);
        }
    
    }
    protected override void UpdateButton()
    {
        var val_10;
        var val_11;
        var val_12;
        this.UpdateButton();
        string val_1 = Localization.Localize(key:  -154901104, defaultValue:  -154901200, useSingularKey:  false);
        val_10 = "tournament_upper";
        this.placeTextBackground.SetActive(value:  false);
        GameBehavior val_2 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        val_10 = 7624168 + 28004786;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        val_11 = null;
        val_11 = null;
        if(TournamentsManager.pp_last_tournament == null)
        {
                return;
        }
        
        val_10 = 1152921504901095424;
        val_12 = 1152921511525052144;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1671729424) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_12 = null;
        string val_8 = Ordinal.AddOrdinal(num:  (public static TournamentsManager MonoSingleton<TournamentsManager>::get_Instance().__il2cppRuntimeField_C + 32 + 1));
        string val_9 = System.String.Format(format:  -1671354896, arg0:  13152256, arg1:  (public static TournamentsManager MonoSingleton<TournamentsManager>::get_Instance().__il2cppRuntimeField_C + 32 + 1));
        val_10 = "{0}{1}";
        this.placeTextBackground.SetActive(value:  true);
    }
    public UnlockableUITournaments()
    {
    
    }

}
