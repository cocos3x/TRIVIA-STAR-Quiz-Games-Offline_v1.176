using UnityEngine;
public class TournamentsButton : MonoBehaviour
{
    // Fields
    private UGUINetworkedButton button_tournaments;
    private UnityEngine.UI.Text text_tournament_place;
    public System.Action<bool> ExternalClickCallback;
    
    // Methods
    private void Start()
    {
        var val_9;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            goto label_5;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1671729424) != 0)
        {
            goto label_10;
        }
        
        UnityEngine.Debug.LogError(message:  -1671728400);
        label_5:
        UnityEngine.GameObject val_4 = this.button_tournaments.gameObject;
        this.button_tournaments.SetActive(value:  false);
        return;
        label_10:
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_6 = new System.Action(object:  -1671693952, method:  new IntPtr(2623243200));
        System.Delegate val_7 = System.Delegate.Combine(a:  public static TournamentsManager MonoSingleton<TournamentsManager>::get_Instance().__il2cppRuntimeField_14, b:  7454720);
        val_9 = public static TournamentsManager MonoSingleton<TournamentsManager>::get_Instance().__il2cppRuntimeField_14;
        if(val_9 != 0)
        {
                if(val_9 == null)
        {
            goto label_20;
        }
        
        }
        
        val_9 = 0;
        label_20:
        public static TournamentsManager MonoSingleton<TournamentsManager>::get_Instance().__il2cppRuntimeField_14 = val_9;
        System.Action<System.Boolean> val_8 = new System.Action<System.Boolean>(object:  -1671693952, method:  new IntPtr(2623248320));
        this.button_tournaments.OnConnectionClick = null;
        this.UpdateButton();
    }
    private void OnDestroy()
    {
        var val_6;
        System.Action val_7;
        var val_8;
        val_6 = 1152921504901095424;
        val_7 = 1152921511525052144;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1671729424) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = null;
        val_7 = new System.Action(object:  -1671573760, method:  new IntPtr(2623243200));
        System.Delegate val_5 = System.Delegate.Remove(source:  public static TournamentsManager MonoSingleton<TournamentsManager>::get_Instance().__il2cppRuntimeField_14, value:  7454720);
        val_8 = public static TournamentsManager MonoSingleton<TournamentsManager>::get_Instance().__il2cppRuntimeField_14;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_11;
        }
        
        }
        
        val_8 = 0;
        label_11:
        public static TournamentsManager MonoSingleton<TournamentsManager>::get_Instance().__il2cppRuntimeField_14 = val_8;
    }
    private void HandleButtonClicked(bool isConnected)
    {
        var val_12;
        System.Action val_13;
        var val_14;
        var val_15;
        var val_16;
        val_12 = this;
        if(this.ExternalClickCallback != 0)
        {
                this.ExternalClickCallback.Invoke(obj:  isConnected);
            return;
        }
        
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
            val_13 = 0;
            object val_5 = PlaceGameObject<System.Object>(loc:  0);
            val_14 = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
            UnityEngine.GameObject val_6 = R4.gameObject;
            val_15 = R4;
            val_16 = "Internet connection required. Please check your connection and try again!";
            ShowToolTip(objToToolTip:  -1671455184, text:  -1671479392, topToolTip:  true, displayDuration:  null, width:  null, height:  null, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  1080033280, showGotItButton:  false, gotItCallback:  null, showPick:  false, maxFontSize:  null);
        }
    
    }
    private void UpdateButton()
    {
        var val_11;
        var val_12;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                val_11 = 10233500 + 25395454;
            if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
            val_12 = null;
            val_12 = null;
            if(TournamentsManager.pp_last_tournament != null)
        {
                val_11 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1671729424) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.GameObject val_5 = this.button_tournaments.gameObject;
            this.button_tournaments.SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_8 = Ordinal.AddOrdinal(num:  (public static TournamentsManager MonoSingleton<TournamentsManager>::get_Instance().__il2cppRuntimeField_C + 32 + 1));
            string val_9 = System.String.Format(format:  -1671354896, arg0:  13152256, arg1:  (public static TournamentsManager MonoSingleton<TournamentsManager>::get_Instance().__il2cppRuntimeField_C + 32 + 1));
            if(this.text_tournament_place != 0)
        {
                return;
        }
        
            return;
        }
        
        }
        
        }
        
        UnityEngine.GameObject val_10 = this.button_tournaments.gameObject;
        this.button_tournaments.SetActive(value:  false);
    }
    public TournamentsButton()
    {
    
    }

}
