using UnityEngine;
public class FTUXFeatureWindow : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform window;
    private UnityEngine.UI.Text description;
    private UnityEngine.UI.Button button;
    private UnityEngine.UI.Text buttonText;
    private UnityEngine.GameObject shuffleFtux;
    private UnityEngine.GameObject pickerHintFtux;
    private System.Collections.Generic.List<UnityEngine.UI.Button> ftuxButtons;
    private System.Collections.Generic.List<UnityEngine.Transform> highlightFeatures;
    private UnityEngine.GameObject handPickTarget;
    private bool isSetup;
    private bool isEnabledCalled;
    
    // Methods
    private void OnEnable()
    {
        System.Collections.Generic.List<UnityEngine.Transform> val_11 = this.highlightFeatures;
        val_11.Add(item:  this.window);
        if(this.isSetup != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Interactable = true;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            BlockRaycasts = true;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            T[] val_4 = this.highlightFeatures.ToArray();
            ShowOverlay(contentToOverlay:  this.highlightFeatures);
            Player val_5 = App.Player;
            GameBehavior val_6 = App.getBehavior;
            val_11 = 0;
            if(0 != val_11)
        {
                return;
        }
        
            if(this.handPickTarget == 0)
        {
                return;
        }
        
            this.pickerHintFtux.SetActive(value:  true);
            UnityEngine.Transform val_8 = this.window.transform;
            PluginExtension.MoveLocalY(transform:  this.window, deltaY:  null);
            DG.Tweening.TweenCallback val_9 = new DG.Tweening.TweenCallback(object:  -331872992, method:  new IntPtr(3963069280));
            DG.Tweening.Tween val_10 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1048576000, ignoreTimeScale:  false);
            return;
        }
        
        this.isEnabledCalled = true;
    }
    public void Setup(string description, string buttonText, System.Collections.Generic.List<UnityEngine.GameObject> featureTargets)
    {
        UnityEngine.UI.Button val_3;
        var val_16;
        this.shuffleFtux.SetActive(value:  false);
        this.pickerHintFtux.SetActive(value:  false);
        List.Enumerator<T> val_1 = GetEnumerator();
        label_13:
        if(MoveNext() == false)
        {
            goto label_6;
        }
        
        object val_4 = val_3.GetComponentInChildren<System.Object>();
        this.ftuxButtons.Add(item:  val_3);
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -331680096, method:  new IntPtr(3963241696));
        val_3 + 172.AddListener(call:  162246656);
        UnityEngine.Transform val_6 = val_3.transform;
        this.highlightFeatures.Add(item:  val_3);
        goto label_13;
        label_6:
        Dispose();
        UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  -331680096, method:  new IntPtr(3963241696));
        this.button.m_OnClick.AddListener(call:  162246656);
        Player val_8 = App.Player;
        GameBehavior val_9 = App.getBehavior;
        val_16 = 0;
        if(0 == val_16)
        {
                this.shuffleFtux.SetActive(value:  true);
        }
        else
        {
                Player val_10 = App.Player;
            GameBehavior val_11 = App.getBehavior;
            val_16 = 0;
            if(0 == val_16)
        {
                if((featureTargets + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            this.handPickTarget = featureTargets + 8 + 16;
        }
        
        }
        
        this.isSetup = true;
        if(this.isEnabledCalled == false)
        {
                return;
        }
        
        val_16 = 1152921511559723536;
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Interactable = true;
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = true;
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        T[] val_15 = this.highlightFeatures.ToArray();
        ShowOverlay(contentToOverlay:  this.highlightFeatures);
    }
    private void Close()
    {
        List.Enumerator<T> val_1 = GetEnumerator();
        label_5:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -331507680, method:  new IntPtr(3963241696));
        val_3 + 172.RemoveListener(call:  162246656);
        goto label_5;
        label_2:
        Dispose();
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CloseOverlay(onClosed:  0);
        UnityEngine.GameObject val_6 = this.gameObject;
        SLCWindow.CloseWindow(window:  -331507680, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public FTUXFeatureWindow()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.ftuxButtons = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.highlightFeatures = null;
    }
    private void <OnEnable>b__11_0()
    {
        UnityEngine.Transform val_1 = this.pickerHintFtux.transform;
        UnityEngine.Transform val_2 = this.handPickTarget.transform;
        UnityEngine.Vector3 val_3 = position;
        this.pickerHintFtux.position = new UnityEngine.Vector3();
    }

}
