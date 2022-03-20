using UnityEngine;
public class BBLGameOverZenScreen : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button buttonRestartLevel;
    private UnityEngine.EventSystems.EventTrigger buttonReview;
    private UnityEngine.UI.Text textScoreCurrent;
    private UnityEngine.UI.Text textScoreBest;
    private UnityEngine.UI.Image background;
    private UnityEngine.CanvasGroup contentGroupRoot;
    private UnityEngine.CanvasGroup contentGroupPrelude;
    private UnityEngine.CanvasGroup contentGroupResults;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  2123393712, method:  new IntPtr(2123355376));
        this.buttonRestartLevel.m_OnClick.AddListener(call:  162246656);
        if(new EventTrigger.Entry() != 0)
        {
                typeof(EventTrigger.Entry).__il2cppRuntimeField_8 = 2;
        }
        else
        {
                mem[8] = 2;
        }
        
        UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder> val_3 = new UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder>(object:  2123393712, method:  new IntPtr(2123356400));
        AddListener(call:  162353152);
        System.Collections.Generic.List<Entry> val_4 = this.buttonReview.triggers;
        this.buttonReview.Add(item:  211660800);
        if(new EventTrigger.Entry() != 0)
        {
                typeof(EventTrigger.Entry).__il2cppRuntimeField_8 = 3;
        }
        else
        {
                mem[8] = 3;
        }
        
        UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder> val_6 = new UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder>(object:  2123393712, method:  new IntPtr(2123364592));
        AddListener(call:  162353152);
        System.Collections.Generic.List<Entry> val_7 = this.buttonReview.triggers;
        this.buttonReview.Add(item:  211660800);
    }
    private void OnEnable()
    {
        this.contentGroupResults.alpha = null;
        this.contentGroupPrelude.alpha = null;
        UnityEngine.Color val_1 = color;
        BestBlocksPlayer val_2 = BestBlocksPlayer.Instance;
        string val_3 = 292.ToString();
        BestBlocksPlayer val_4 = BestBlocksPlayer.Instance;
        string val_5 = 288.ToString();
        string val_6 = System.String.Format(format:  2123518576, arg0:  288);
        UnityEngine.GameObject val_7 = this.contentGroupPrelude.gameObject;
        this.contentGroupPrelude.SetActive(value:  true);
        UnityEngine.GameObject val_8 = this.contentGroupResults.gameObject;
        this.contentGroupResults.SetActive(value:  false);
        DG.Tweening.Sequence val_9 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.contentGroupPrelude, endValue:  val_1.r, duration:  val_1.g);
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.contentGroupPrelude);
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_1.r);
        DG.Tweening.TweenCallback val_13 = new DG.Tweening.TweenCallback(object:  2123568272, method:  new IntPtr(2123530960));
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.background, endValue:  val_1.r, duration:  val_1.g);
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.background);
        DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.contentGroupPrelude, endValue:  val_1.r, duration:  val_1.g);
        DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.contentGroupPrelude);
        DG.Tweening.Tweener val_19 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.contentGroupResults, endValue:  val_1.r, duration:  val_1.g);
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.contentGroupResults);
    }
    private void OnClickRestartLevel()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ClearProgress(gameMode:  1);
        UnityEngine.GameObject val_2 = this.gameObject;
        this.SetActive(value:  false);
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private void OnReviewPointerDown(UnityEngine.EventSystems.BaseEventData eventData)
    {
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.contentGroupRoot, endValue:  null, duration:  null);
    }
    private void OnReviewPointerUp(UnityEngine.EventSystems.BaseEventData eventData)
    {
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.contentGroupRoot, endValue:  null, duration:  null);
    }
    public BBLGameOverZenScreen()
    {
    
    }
    private void <OnEnable>b__9_0()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_2 = ShowInterstitial(context:  2);
        UnityEngine.GameObject val_3 = this.contentGroupPrelude.gameObject;
        this.contentGroupPrelude.SetActive(value:  false);
        UnityEngine.GameObject val_4 = this.contentGroupResults.gameObject;
        this.contentGroupResults.SetActive(value:  true);
    }

}
