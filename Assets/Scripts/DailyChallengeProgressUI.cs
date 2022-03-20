using UnityEngine;
public class DailyChallengeProgressUI : MonoBehaviour
{
    // Fields
    private const float progressBarTickRate = 0.3;
    private const float transitionFadeDuration = 0.8;
    private UnityEngine.UI.Slider progressBar;
    private UnityEngine.UI.Text progressBarText;
    private UGUINetworkedButton collectButton;
    private UnityEngine.UI.Text collectButtonText;
    private UnityEngine.Transform giftTransform;
    private System.Action onCollectClicked;
    private int currentProgress;
    private int maxProgress;
    
    // Methods
    private void Start()
    {
        System.Action<System.Boolean> val_3;
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  -345058960, method:  new IntPtr(3949883312));
        System.Delegate val_2 = System.Delegate.Combine(a:  this.collectButton.OnConnectionClick, b:  7401472);
        val_3 = this.collectButton.OnConnectionClick;
        if(val_3 != 0)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_3 = 0;
        label_4:
        this.collectButton.OnConnectionClick = val_3;
    }
    public void InitializeWeeklyProgress(int starsToAnimate = 0)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_4 = new System.Action(object:  -2116505760, method:  new IntPtr(3950004528));
        this.UpdateUI(currentProgress:  UnityEngine.Mathf.Max(a:  (public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_38 + 8 - starsToAnimate), b:  0), maxProgress:  public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_64 + 12, onCollect:  7454720, rewardAvailable:  IsWeekRewardAvailable());
    }
    public void InitializeMonthlyProgress(int starsToAnimate = 0)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_4 = new System.Action(object:  -2116505760, method:  new IntPtr(3950117552));
        this.UpdateUI(currentProgress:  UnityEngine.Mathf.Max(a:  (public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_30 + 8 - starsToAnimate), b:  0), maxProgress:  public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_64 + 8, onCollect:  7454720, rewardAvailable:  IsMonthRewardAvailable());
    }
    public void UpdateUI(int currentProgress, int maxProgress, System.Action onCollect, bool rewardAvailable)
    {
        System.Action val_6;
        this.onCollectClicked = 0;
        this.currentProgress = UnityEngine.Mathf.Min(a:  currentProgress, b:  maxProgress);
        val_6 = 0;
        this.maxProgress = maxProgress;
        System.Delegate val_2 = System.Delegate.Combine(a:  0, b:  onCollect);
        if(val_6 != 0)
        {
                if(1179403647 == null)
        {
            goto label_4;
        }
        
        }
        
        val_6 = 0;
        label_4:
        this.onCollectClicked = val_6;
        string val_3 = this.GetProgressBarText(currentAmount:  currentProgress, maxAount:  maxProgress);
        float val_6 = (float)maxProgress;
        val_6 = (float)currentProgress / val_6;
        UnityEngine.GameObject val_4 = this.progressBar.gameObject;
        if(currentProgress < maxProgress)
        {
                0 = 1;
        }
        
        this.progressBar.SetActive(value:  true);
        UnityEngine.GameObject val_5 = this.collectButton.gameObject;
        if(currentProgress >= maxProgress)
        {
                0 = 1;
        }
        
        this.collectButton.SetActive(value:  true);
        this.collectButton.interactable = rewardAvailable;
        if(rewardAvailable == true)
        {
                "COMPLETED" = "TAP TO COLLECT!";
        }
        
        if(this.collectButtonText == 0)
        {
            
        }
    
    }
    public void TweenProgressBar(int amount, float delay = 0)
    {
        var val_14;
        int val_15;
        val_14 = amount;
        val_15 = 35641210;
        if(new System.Object() != 0)
        {
                typeof(DailyChallengeProgressUI.<>c__DisplayClass14_0).__il2cppRuntimeField_C = this;
        }
        else
        {
                mem[12] = this;
        }
        
        typeof(DailyChallengeProgressUI.<>c__DisplayClass14_0).__il2cppRuntimeField_10 = R2;
        if(val_14 < 1)
        {
                return;
        }
        
        int val_14 = this.currentProgress;
        val_14 = val_14 - val_14;
        typeof(DailyChallengeProgressUI.<>c__DisplayClass14_0).__il2cppRuntimeField_8 = (float)val_14;
        string val_2 = val_14.GetProgressBarText(currentAmount:  (int)(float)val_14, maxAount:  this.maxProgress);
        float val_15 = (float)this.maxProgress;
        val_15 = (typeof(DailyChallengeProgressUI.<>c__DisplayClass14_0).__il2cppRuntimeField_8) / val_15;
        UnityEngine.GameObject val_3 = this.progressBar.gameObject;
        this.progressBar.SetActive(value:  true);
        UnityEngine.GameObject val_4 = this.collectButton.gameObject;
        this.collectButton.SetActive(value:  false);
        DG.Tweening.Core.DOGetter<System.Single> val_5 = new DG.Tweening.Core.DOGetter<System.Single>(object:  370712576, method:  new IntPtr(3950416416));
        DG.Tweening.Core.DOSetter<System.Single> val_6 = new DG.Tweening.Core.DOSetter<System.Single>(object:  370712576, method:  new IntPtr(3950417440));
        float val_16 = (float)val_14;
        val_16 = val_16 * 0.3f;
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_7 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  val_16, duration:  null);
        object val_8 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  198828032, delay:  val_16);
        val_14 = null;
        UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  val_16, y:  null, z:  0.3f);
        val_15 = 16076;
        val_15 = 1053609165;
        DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  this.giftTransform, punch:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  val_16, vibrato:  val_15, elasticity:  null);
        object val_11 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.giftTransform, delay:  val_16);
        if(this.currentProgress < this.maxProgress)
        {
                return;
        }
        
        DG.Tweening.TweenCallback val_12 = new DG.Tweening.TweenCallback(object:  370712576, method:  new IntPtr(3950422560));
        object val_13 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  198828032, action:  190734336);
    }
    private void OnCollectButtonClicked(bool connected)
    {
        if(connected == false)
        {
                return;
        }
        
        this.collectButton.interactable = false;
        if(this.onCollectClicked == 0)
        {
                return;
        }
        
        this.onCollectClicked.Invoke();
    }
    private string GetProgressBarText(int currentAmount, int maxAount)
    {
        string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
    }
    public DailyChallengeProgressUI()
    {
    
    }

}
