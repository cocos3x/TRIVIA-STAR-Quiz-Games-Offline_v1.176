using UnityEngine;
public class FPHTokenDisplay : MonoBehaviour
{
    // Fields
    private const float textTweenDuration = 0.3;
    private UnityEngine.UI.Text tokenTitleText;
    private UnityEngine.UI.Text tokenText;
    private UnityEngine.UI.Text vowelText;
    private UnityEngine.UI.Text consonantText;
    private UnityEngine.CanvasGroup ootDisplayBanner;
    private UnityEngine.UI.Text ootBannerTextBody;
    private int tokenAmount;
    
    // Methods
    public void Setup(int initial)
    {
        string val_1 = initial.ToString();
        WordForest.WFOGameEcon val_2 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        string val_3 = GetLetterCostDisplay(cost:  public System.Void System.Collections.Generic.List<FPHLetterSlotState>::.ctor().__il2cppRuntimeField_154);
        string val_4 = System.String.Format(format:  -1616523904, arg0:  -1653671872);
        string val_5 = ToUpper();
        string val_6 = this.vowelText.GetLetterCostDisplay(cost:  public System.Void System.Collections.Generic.List<FPHLetterSlotState>::.ctor().__il2cppRuntimeField_150);
        string val_7 = System.String.Format(format:  -1616519664, arg0:  this.vowelText);
        string val_8 = ToUpper();
        this.tokenAmount = initial;
    }
    public void UpdateState(FPHGameplayState state)
    {
        int val_9 = this.tokenAmount;
        if(val_9 == (state.<tokensRemaining>k__BackingField))
        {
                return;
        }
        
        DG.Tweening.Core.DOGetter<System.Int32> val_1 = new DG.Tweening.Core.DOGetter<System.Int32>(object:  -1616359968, method:  new IntPtr(2678576160));
        DG.Tweening.Core.DOSetter<System.Int32> val_2 = new DG.Tweening.Core.DOSetter<System.Int32>(object:  -1616359968, method:  new IntPtr(2678577184));
        DG.Tweening.Tweener val_3 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  state.<tokensRemaining>k__BackingField, duration:  null);
        val_9 = null;
        val_9 = new DG.Tweening.TweenCallback(object:  -1616359968, method:  new IntPtr(2678578208));
        object val_5 = DG.Tweening.TweenSettingsExtensions.OnUpdate<System.Object>(t:  198828032, action:  190734336);
        UnityEngine.Transform val_6 = this.tokenText.transform;
        UnityEngine.Vector3 val_7 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
        DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  this.tokenText, punch:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  null, vibrato:  1050253722, elasticity:  null);
    }
    public void ShowOutOfTokens()
    {
        UnityEngine.RectTransform val_12;
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.tokenTitleText, endValue:  null, duration:  null);
        this.ootDisplayBanner.alpha = null;
        UnityEngine.GameObject val_2 = this.ootDisplayBanner.gameObject;
        this.ootDisplayBanner.SetActive(value:  true);
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.ootDisplayBanner, endValue:  null, duration:  null);
        GameBehavior val_4 = App.getBehavior;
        WordForest.WFOGameEcon val_5 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        bool val_6 = GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  public System.Void System.Collections.Generic.List<FPHLetterSlotState>::.ctor().__il2cppRuntimeField_158);
        if(val_6 == true)
        {
                "fph_oot_v1" = "fph_oot_v2";
        }
        
        if(val_6 == true)
        {
                "SOLVE THE PUZZLE!" = "USE A HINT OR SOLVE!";
        }
        
        string val_7 = Localization.Localize(key:  -1616247392, defaultValue:  -1616247200, useSingularKey:  false);
        UnityEngine.Transform val_8 = this.ootDisplayBanner.transform;
        val_12 = 0;
        if(this.ootDisplayBanner != 0)
        {
                if(null != null)
        {
                val_12 = 0;
        }
        else
        {
                val_12 = this.ootDisplayBanner;
        }
        
        }
        
        UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  null, y:  null);
        val_12.anchoredPosition = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
        DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  val_12, endValue:  null, duration:  null, snapping:  false);
        object val_11 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_12, ease:  3);
    }
    private string GetLetterCostDisplay(int cost)
    {
        string val_1 = System.String.Format(format:  -1616102208, arg0:  13152256);
    }
    public FPHTokenDisplay()
    {
    
    }
    private int <UpdateState>b__9_0()
    {
        return (int)this.tokenAmount;
    }
    private void <UpdateState>b__9_1(int x)
    {
        this.tokenAmount = x;
    }
    private void <UpdateState>b__9_2()
    {
        string val_1 = this.tokenAmount.ToString();
        if(this.tokenText == 0)
        {
            
        }
    
    }

}
