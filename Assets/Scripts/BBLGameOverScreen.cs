using UnityEngine;
public class BBLGameOverScreen : MonoBehaviour
{
    // Fields
    private BlockPuzzleMagic.GoalDisplayIcon goalDisplayIconPrefab;
    private UnityEngine.RectTransform displayContainer;
    private UnityEngine.UI.Button buttonKeepPlaying;
    private UnityEngine.UI.Button buttonRestartLevel;
    private UnityEngine.UI.Text labelLifeDeductionAmt;
    private UnityEngine.CanvasGroup groupLabelLifeDeduction;
    private UnityEngine.UI.Image background;
    private UnityEngine.CanvasGroup contentGroup;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  2122322608, method:  new IntPtr(2122288368));
        this.buttonKeepPlaying.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  2122322608, method:  new IntPtr(2122297584));
        this.buttonRestartLevel.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        var val_13;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_13 = 0;
        BlockPuzzleMagic.BestBlocksGameEcon val_3 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        string val_4 = 4.ToString();
        this.contentGroup.alpha = null;
        UnityEngine.Color val_5 = color;
        this.contentGroup.blocksRaycasts = false;
        DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.background, endValue:  val_5.r, duration:  val_5.g);
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.background);
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.contentGroup, endValue:  val_5.r, duration:  val_5.g);
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.contentGroup);
        DG.Tweening.TweenCallback val_11 = new DG.Tweening.TweenCallback(object:  2122486832, method:  new IntPtr(2122460784));
        object val_12 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
    }
    private void OnClickKeepPlaying()
    {
        this.contentGroup.blocksRaycasts = false;
        UnityEngine.GameObject val_1 = this.contentGroup.gameObject;
        this.SetActive(value:  false);
    }
    private void OnClickRestartLevel()
    {
        float val_10;
        float val_11;
        var val_18;
        var val_19;
        var val_20;
        object val_1 = new System.Object();
        typeof(BBLGameOverScreen.<>c__DisplayClass11_0).__il2cppRuntimeField_C = this;
        val_18 = null;
        val_18 = null;
        int val_18 = BlockPuzzleMagic.GamePlay.currentLevelFailCount;
        val_18 = val_18 + 1;
        BlockPuzzleMagic.GamePlay.currentLevelFailCount = val_18;
        this.contentGroup.blocksRaycasts = false;
        BestBlocksPlayer val_2 = BestBlocksPlayer.Instance;
        BlockPuzzleMagic.BestBlocksGameEcon val_3 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        int val_4 = 0.DebitLife(amount:  4);
        UnityEngine.Transform val_5 = this.buttonRestartLevel.transform;
        object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  this.groupLabelLifeDeduction, parent:  this.buttonRestartLevel);
        typeof(BBLGameOverScreen.<>c__DisplayClass11_0).__il2cppRuntimeField_8 = this.groupLabelLifeDeduction;
        UnityEngine.Transform val_7 = this.groupLabelLifeDeduction.transform;
        if(this.groupLabelLifeDeduction == 0)
        {
            goto label_11;
        }
        
        val_19 = this.groupLabelLifeDeduction;
        if(null == null)
        {
            goto label_12;
        }
        
        label_11:
        val_19 = 0;
        label_12:
        val_20 = 0;
        UnityEngine.Transform val_8 = this.groupLabelLifeDeduction.transform;
        if(this.groupLabelLifeDeduction != 0)
        {
                if(null == null)
        {
            goto label_15;
        }
        
        }
        
        if(this.groupLabelLifeDeduction != 0)
        {
                label_15:
            if(null != null)
        {
                val_20 = 0;
        }
        else
        {
                val_20 = this.groupLabelLifeDeduction;
        }
        
        }
        
        UnityEngine.Vector2 val_9 = anchoredPosition;
        val_19.anchoredPosition = new UnityEngine.Vector2() {x = val_10, y = val_11};
        DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  0, endValue:  val_9.x, duration:  val_9.y, snapping:  false);
        object val_13 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  0, ease:  6);
        DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions46.DOFade(target:  typeof(BBLGameOverScreen.<>c__DisplayClass11_0).__il2cppRuntimeField_8, endValue:  val_9.x, duration:  val_9.y);
        object val_15 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  typeof(BBLGameOverScreen.<>c__DisplayClass11_0).__il2cppRuntimeField_8, delay:  val_9.x);
        DG.Tweening.TweenCallback val_16 = new DG.Tweening.TweenCallback(object:  274599936, method:  new IntPtr(2122745200));
        object val_17 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  typeof(BBLGameOverScreen.<>c__DisplayClass11_0).__il2cppRuntimeField_8, action:  190734336);
    }
    public BBLGameOverScreen()
    {
    
    }
    private void <OnEnable>b__9_0()
    {
        this.contentGroup.blocksRaycasts = true;
    }

}
