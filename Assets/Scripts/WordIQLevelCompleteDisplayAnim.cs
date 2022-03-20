using UnityEngine;
public class WordIQLevelCompleteDisplayAnim : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text iqStat;
    private UnityEngine.UI.Text iqStatIncreaseFactor;
    private UnityEngine.UI.Text iqStatIncreaseFactor2;
    private UnityEngine.CanvasGroup newWordsGroup;
    private UnityEngine.UI.Button[] newWordButtons;
    private UnityEngine.UI.Text[] newWordButtonTexts;
    private WordIQMilestoneDisplay milestoneDisplay;
    private UnityEngine.CanvasGroup wholeDisplayGroup;
    private float whole_y_local_pos_start;
    private float whole_y_local_pos_end;
    private float statTweenDuration;
    private IQGains levelGains;
    private System.Collections.Generic.List<string> topThreeNewWords;
    private const float startDelay = 0.5;
    
    // Methods
    public void Setup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_2 = WordIQManagerUI.FormatPoints(iqPoints:  null);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.levelGains = null;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_5 = this.newWordsGroup.gameObject;
        this.newWordsGroup.SetActive(value:  false);
        if(this.levelGains != 0)
        {
                float val_6 = this.levelGains.Total;
            if(this.levelGains > 0)
        {
                string val_7 = Localization.Localize(key:  -930634336, defaultValue:  -930634448, useSingularKey:  false);
            string val_8 = WordIQManagerUI.FormatPoints(iqPoints:  this.levelGains);
            string val_9 = -930634336(-930634336) + 1297836560 + this.levelGains.levelClearPoints;
            UnityEngine.GameObject val_10 = this.iqStatIncreaseFactor2.gameObject;
            if(this.iqStatIncreaseFactor2 > 0)
        {
                0 = 1;
        }
        
            this.iqStatIncreaseFactor2.SetActive(value:  true);
            string val_11 = Localization.Localize(key:  -930613632, defaultValue:  -930613744, useSingularKey:  false);
            string val_12 = WordIQManagerUI.FormatPoints(iqPoints:  this.levelGains);
            string val_13 = -930613632(-930613632) + 1297836560 + this.levelGains.newWordsFoundPoints;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.milestoneDisplay.UpdateMilestoneDisplay(newMilestoneIndex:  GetMilestone(iqPoints:  this.levelGains));
        UnityEngine.Transform val_17 = this.wholeDisplayGroup.transform;
        UnityEngine.Vector3 val_18 = new UnityEngine.Vector3(x:  this.levelGains, y:  null, z:  null);
        this.wholeDisplayGroup.localPosition = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
    }
    public void ShowWithoutAnim()
    {
        this.wholeDisplayGroup.alpha = null;
        UnityEngine.Transform val_1 = this.wholeDisplayGroup.transform;
        UnityEngine.Transform val_2 = this.wholeDisplayGroup.transform;
        UnityEngine.Vector3 val_3 = localPosition;
        UnityEngine.Transform val_5 = this.wholeDisplayGroup.transform;
        UnityEngine.Vector3 val_6 = localPosition;
        UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  val_6.x, y:  val_6.y, z:  val_6.z);
        this.wholeDisplayGroup.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        UnityEngine.GameObject val_9 = this.newWordsGroup.gameObject;
        if(this.newWordsGroup.activeSelf == false)
        {
                return;
        }
        
        this.newWordsGroup.alpha = val_6.x;
    }
    public void Play()
    {
        var val_10;
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.wholeDisplayGroup, endValue:  null, duration:  null);
        object val_2 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.wholeDisplayGroup, delay:  null);
        DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  -930241600, method:  new IntPtr(3364688384));
        System.Delegate val_4 = System.Delegate.Combine(a:  R6, b:  190734336);
        val_10 = R6;
        if(val_10 != 0)
        {
                if(val_10 == null)
        {
            goto label_4;
        }
        
        }
        
        val_10 = 0;
        label_4:
        mem2[0] = val_10;
        UnityEngine.Transform val_5 = this.wholeDisplayGroup.transform;
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.wholeDisplayGroup, endValue:  null, duration:  null, snapping:  this.whole_y_local_pos_end);
        object val_7 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.wholeDisplayGroup, delay:  null);
        UnityEngine.GameObject val_8 = this.newWordsGroup.gameObject;
        if(this.newWordsGroup.activeSelf == false)
        {
                return;
        }
        
        this.newWordsGroup.alpha = null;
    }
    public void BeginAnimations()
    {
        this.Invoke(methodName:  -930137216, time:  null);
    }
    public void BeginTweeningStat()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(this.activeInHierarchy == false)
        {
                return;
        }
        
        System.Collections.IEnumerator val_3 = R4.TweenStat();
        UnityEngine.Coroutine val_4 = R4.StartCoroutine(routine:  R4);
    }
    public void OnNewWordClicked(int index)
    {
    
    }
    private System.Collections.IEnumerator TweenStat()
    {
        object val_1 = new System.Object();
        typeof(WordIQLevelCompleteDisplayAnim.<TweenStat>d__20).__il2cppRuntimeField_8 = 0;
        typeof(WordIQLevelCompleteDisplayAnim.<TweenStat>d__20).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator ShowMilestoneReached(int milestoneIndex, float milestoneAmount)
    {
        typeof(WordIQLevelCompleteDisplayAnim.<ShowMilestoneReached>d__21).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WordIQLevelCompleteDisplayAnim.<ShowMilestoneReached>d__21).__il2cppRuntimeField_18 = milestoneIndex;
            typeof(WordIQLevelCompleteDisplayAnim.<ShowMilestoneReached>d__21).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
            mem[24] = milestoneIndex;
        }
        
        typeof(WordIQLevelCompleteDisplayAnim.<ShowMilestoneReached>d__21).__il2cppRuntimeField_14 = R2;
    }
    public WordIQLevelCompleteDisplayAnim()
    {
        this.whole_y_local_pos_start = -35f;
        this.whole_y_local_pos_end = 35f;
        this.statTweenDuration = 1f;
    }
    private void <Play>b__16_0()
    {
        this.BeginAnimations();
    }

}
