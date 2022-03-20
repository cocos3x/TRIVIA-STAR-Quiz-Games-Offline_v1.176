using UnityEngine;
public class ForestMasterPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button buttonClose;
    private UnityEngine.UI.Slider progressBar;
    private UnityEngine.UI.Text progressBarText;
    private UnityEngine.UI.Text coinsRewardText;
    private UnityEngine.UI.Text acornsRewardText;
    private UnityEngine.UI.Button growButton;
    private UnityEngine.UI.Text timerText;
    private DG.Tweening.Sequence timerSequence;
    
    // Methods
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1421000912, method:  new IntPtr(2873915760));
        this.buttonClose.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1421000912, method:  new IntPtr(2873924976));
        this.growButton.m_OnClick.AddListener(call:  162246656);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_16 = 100f;
        val_16 = ((float)CurrentForestGrowth / (float)CurrentMaxGrowth) * val_16;
        int val_8 = UnityEngine.Mathf.RoundToInt(f:  val_16);
        string val_9 = System.String.Format(format:  2124591920, arg0:  13152256);
        decimal val_10 = GetCoinReward(showCurrentLevel:  ForestMasterEventHandler.<Instance>k__BackingField);
        GameEcon val_11 = App.getGameEcon;
        string val_12 = ToString(format:  null);
        GameEcon val_14 = App.getGameEcon;
        string val_15 = ForestMasterEventHandler.<Instance>k__BackingField.GetAcornReward(showCurrentLevel:  true).ToString(format:  null);
        this.SetTimer();
    }
    private void OnDisable()
    {
        if(this.timerSequence == 0)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.timerSequence, complete:  false);
    }
    private void OnDestroy()
    {
        if(this.timerSequence == 0)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.timerSequence, complete:  false);
    }
    private void SetTimer()
    {
        if(this.timerSequence != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.timerSequence, complete:  false);
        }
        
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        this.timerSequence = 0;
        DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  -1420602448, method:  new IntPtr(2874331632));
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.timerSequence, interval:  null);
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.timerSequence, loops:  0);
    }
    private string GetTimerText()
    {
        var val_1;
        var val_8 = 22593219;
        val_8 = 13045900 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        int val_3 = val_1.Days;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        int val_4 = val_1.Hours;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        int val_5 = val_1.Minutes;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        int val_6 = val_1.Seconds;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_7 = System.String.Format(format:  -1536980304, args:  472754880);
    }
    private void OnGrowButtonClicked()
    {
        var val_11;
        var val_12;
        UnityEngine.Object val_13;
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1420365136, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        if(SceneDictator.IsInGameScene() == false)
        {
            goto label_16;
        }
        
        val_11 = 1152921504901095424;
        val_12 = 1152921511021137168;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C) == 0)
        {
            goto label_16;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_6 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C.GetComponentInChildren<System.Object>();
        val_13 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C;
        if(val_13 == 0)
        {
            goto label_16;
        }
        
        if(val_13 == 0)
        {
            goto label_17;
        }
        
        goto label_22;
        label_16:
        GameBehavior val_8 = App.getBehavior;
        if(0 == 5)
        {
                return;
        }
        
        GameBehavior val_9 = App.getBehavior;
        if(0 != 0)
        {
            goto mem[1179404171];
        }
        
        goto mem[1179404171];
        label_17:
        label_22:
        val_13 = 0;
        val_13.CloseAndGoToScene(scene:  5);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1420253136, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public ForestMasterPopup()
    {
    
    }
    private void <SetTimer>b__11_0()
    {
        string val_1 = this.GetTimerText();
        if(this.timerText == 0)
        {
            
        }
    
    }

}
