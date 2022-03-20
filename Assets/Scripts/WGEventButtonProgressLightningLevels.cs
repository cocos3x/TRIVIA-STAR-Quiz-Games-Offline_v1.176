using UnityEngine;
public class WGEventButtonProgressLightningLevels : WGEventButtonProgress
{
    // Fields
    protected UnityEngine.UI.Image completedIcon;
    protected LightningLevelsEventHandler lightningEventHandler;
    protected bool showingFinishedState;
    protected DG.Tweening.Tween countdownSeq;
    protected DG.Tweening.Tween refreshSeq;
    
    // Methods
    public override void Initialize(WGEventHandler handler)
    {
        LightningLevelsEventHandler val_4 = 0;
        mem[1152921512874479812] = handler;
        this.lightningEventHandler = ;
        DG.Tweening.TweenCallback val_1 = new DG.Tweening.TweenCallback(object:  -322301792, method:  typeof(WGEventButtonProgressLightningLevels).__il2cppRuntimeField_F0);
        DG.Tweening.Tween val_2 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1048576000, ignoreTimeScale:  false);
        object val_3 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  1048576000, loops:  0, loopType:  0);
        this.refreshSeq = 1048576000;
    }
    protected void OnDestroy()
    {
        this.StopUpdate();
    }
    public override void Refresh()
    {
        var val_11;
        var val_12;
        var val_13;
        DG.Tweening.TweenCallback val_28;
        int val_29;
        val_28 = 1152921504901095424;
        val_29 = 1152921512015582112;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(this.countdownSeq != 0)
        {
                if((DG.Tweening.TweenExtensions.IsPlaying(t:  this.countdownSeq)) != false)
        {
                object val_3 = DG.Tweening.TweenExtensions.Pause<System.Object>(t:  this.countdownSeq);
        }
        
        }
        
        if(this.showingFinishedState == true)
        {
                return;
        }
        
        float val_6 = alpha;
        if((public static LightningLevelsUIController MonoSingleton<LightningLevelsUIController>::get_Instance()) <= 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_29 = this.lightningEventHandler.<CacheOverallEventProgress>k__BackingField;
        UnityEngine.GameObject val_8 = gameObject;
        val_28 = val_28;
        if(this.lightningEventHandler > val_29)
        {
                SetActive(value:  false);
            UnityEngine.GameObject val_9 = this.completedIcon.gameObject;
            this.completedIcon.SetActive(value:  true);
            this.StopUpdate();
            return;
        }
        
        SetActive(value:  true);
        UnityEngine.GameObject val_10 = this.completedIcon.gameObject;
        this.completedIcon.SetActive(value:  false);
        val_28 = val_28;
        double val_15 = val_13.TotalSeconds;
        if(this.lightningEventHandler < 0)
        {
                if(this.countdownSeq == 0)
        {
            goto label_32;
        }
        
        }
        
        UnityEngine.GameObject val_16 = this.gameObject;
        this.SetActive(value:  true);
        double val_17 = val_11.TotalSeconds;
        if(this <= 0)
        {
                return;
        }
        
        double val_18 = val_11.TotalSeconds;
        if(this > 0)
        {
                return;
        }
        
        if(this.countdownSeq != 0)
        {
                return;
        }
        
        UnityEngine.Transform val_19 = this.transform;
        val_12 = 0;
        val_11 = 0;
        UnityEngine.Vector3 val_20 = new UnityEngine.Vector3(x:  3113767840, y:  null, z:  null);
        DG.Tweening.Tweener val_21 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  -322025568, punch:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, duration:  3113767840, vibrato:  1065353216, elasticity:  null);
        object val_22 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  -322025568, loops:  10, loopType:  0);
        val_29 = 1152921504797581312;
        DG.Tweening.TweenCallback val_23 = new DG.Tweening.TweenCallback(object:  -322025568, method:  new IntPtr(3972914656));
        object val_24 = DG.Tweening.TweenSettingsExtensions.OnStepComplete<System.Object>(t:  -322025568, action:  190734336);
        val_28 = null;
        val_28 = new DG.Tweening.TweenCallback(object:  -322025568, method:  new IntPtr(3972916704));
        object val_26 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  -322025568, action:  190734336);
        this.countdownSeq = this;
        return;
        label_32:
        UnityEngine.GameObject val_27 = this.gameObject;
        this.SetActive(value:  false);
    }
    public void DoCompleteEfx()
    {
        UnityEngine.GameObject val_1 = R5.gameObject;
        R5.SetActive(value:  true);
        this.Play();
    }
    public void DoCompleteAnimation()
    {
        UnityEngine.GameObject val_1 = static_value_021FA3DA.gameObject;
        static_value_021FA3DA.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.completedIcon.gameObject;
        this.completedIcon.SetActive(value:  true);
        UnityEngine.Color val_3 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        this.completedIcon.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        UnityEngine.Transform val_4 = this.completedIcon.transform;
        UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
        this.completedIcon.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
        DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.completedIcon, endValue:  null, duration:  null);
        object val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.completedIcon, ease:  1);
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.completedIcon);
        UnityEngine.Transform val_11 = this.completedIcon.transform;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.completedIcon, endValue:  new UnityEngine.Vector3(), duration:  val_12.x);
        object val_14 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.completedIcon, ease:  30);
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.completedIcon);
        this.StopUpdate();
    }
    protected void StopUpdate()
    {
        this.showingFinishedState = true;
        if(this.refreshSeq != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.refreshSeq, complete:  false);
        }
        
        this.refreshSeq = 0;
        if(this.countdownSeq != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.countdownSeq, complete:  false);
        }
        
        this.countdownSeq = 0;
    }
    public WGEventButtonProgressLightningLevels()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }
    private void <Refresh>b__7_0()
    {
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        this.localScale = new UnityEngine.Vector3();
    }
    private void <Refresh>b__7_1()
    {
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  -321251168, endValue:  null, duration:  null);
        this.StopUpdate();
    }

}
