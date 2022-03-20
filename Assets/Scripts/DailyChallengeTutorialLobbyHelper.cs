using UnityEngine;
public class DailyChallengeTutorialLobbyHelper : MonoSingleton<DailyChallengeTutorialLobbyHelper>
{
    // Fields
    private UnlockableUIDailyChallenge dailyChallengeButton;
    private UGUINetworkedButton netWorkedButton;
    private DynamicToolTip TT;
    
    // Methods
    private void OnEnable()
    {
        GameBehavior val_1 = App.getBehavior;
        GameBehavior val_2 = App.getBehavior;
        if(0 != 0)
        {
                UnityEngine.GameObject val_3 = this.gameObject;
            SLCWindow.CloseWindow(window:  -1443570736, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            return;
        }
        
        object val_4 = UnityEngine.Object.FindObjectOfType<System.Object>();
        this.dailyChallengeButton = public static UnlockableUIDailyChallenge UnityEngine.Object::FindObjectOfType<UnlockableUIDailyChallenge>();
        object val_5 = GetComponent<System.Object>();
        this.netWorkedButton = public static UnlockableUIDailyChallenge UnityEngine.Object::FindObjectOfType<UnlockableUIDailyChallenge>();
        System.Action<System.Boolean> val_6 = new System.Action<System.Boolean>(object:  -1443570736, method:  new IntPtr(2851367440));
        public static UnlockableUIDailyChallenge UnityEngine.Object::FindObjectOfType<UnlockableUIDailyChallenge>().__il2cppRuntimeField_12C = null;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Color val_8 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        System.Nullable<UnityEngine.Color> val_9 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.r});
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_9.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = true;
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Interactable = true;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_14 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        UnityEngine.Transform val_15 = this.dailyChallengeButton.transform;
        Add(item:  this.dailyChallengeButton);
        System.Collections.IEnumerator val_16 = this.WaitAndShowOverlay(overlayContents:  80883712);
        UnityEngine.Coroutine val_17 = this.StartCoroutine(routine:  -1443570736);
    }
    public void QAHACK_CANCEL()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CloseOverlay(onClosed:  0);
        if(this.TT != 0)
        {
                this.TT.Dismiss();
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1443442352, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        this.netWorkedButton.OnConnectionClick = 0;
    }
    private System.Collections.IEnumerator WaitAndShowOverlay(System.Collections.Generic.List<UnityEngine.Transform> overlayContents)
    {
        typeof(DailyChallengeTutorialLobbyHelper.<WaitAndShowOverlay>d__5).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(DailyChallengeTutorialLobbyHelper.<WaitAndShowOverlay>d__5).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(DailyChallengeTutorialLobbyHelper.<WaitAndShowOverlay>d__5).__il2cppRuntimeField_14 = overlayContents;
    }
    private void OnConnectionClicked(bool connected)
    {
        if(connected != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.LaunchDailyChallenge();
            return;
        }
        
        this.ShowConnectionRequired();
    }
    private void ShowConnectionRequired()
    {
        var val_9;
        System.Func<System.Boolean> val_11;
        var val_12;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CloseOverlay(onClosed:  0);
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1443075632, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_5 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_6 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_7 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_9 = null;
        val_9 = null;
        val_11 = DailyChallengeTutorialLobbyHelper.<>c.<>9__7_0;
        if(val_11 == 0)
        {
                val_11 = null;
            val_11 = new System.Func<System.Boolean>(object:  DailyChallengeTutorialLobbyHelper.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2851866640));
            DailyChallengeTutorialLobbyHelper.<>c.<>9__7_0 = val_11;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_11;
        val_12 = null;
        val_12 = null;
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    private void OnDestroy()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.netWorkedButton)) == false)
        {
                return;
        }
        
        mem2[0] = 0;
    }
    private void OnComplete(bool success)
    {
        this.LaunchDailyChallenge();
    }
    private void LaunchDailyChallenge()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 1)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1637058032) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CloseOverlay(onClosed:  0);
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1442731440, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HandleLobbyTutorialClicked();
    }
    public DailyChallengeTutorialLobbyHelper()
    {
    
    }

}
