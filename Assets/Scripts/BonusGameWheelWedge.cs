using UnityEngine;
public class BonusGameWheelWedge : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI label;
    private UnityEngine.UI.Image icon;
    private UnityEngine.UI.Image wedgeHighlighter;
    private UnityEngine.Color wedgeColor;
    private float fitToWidth;
    private DG.Tweening.Tween flashSeq;
    
    // Methods
    public void Init(string rewardText, UnityEngine.Sprite rewardIcon)
    {
        var val_4;
        var val_5;
        UnityEngine.Color val_1 = color;
        this.label.text = rewardText;
        this.icon.sprite = rewardIcon;
        UnityEngine.Rect val_2 = rect;
        UnityEngine.Vector2 val_3 = size;
        var val_8 = val_4;
        val_8 = val_5 / val_8;
        UnityEngine.RectTransform val_7 = this.icon.rectTransform;
        this.icon.sizeDelta = new UnityEngine.Vector2() {x = this.fitToWidth, y = this.fitToWidth * val_8};
    }
    public void Flash(UnityEngine.Color flashColor, float flashDuration = 0.3, float startDelay = 0, float endDelay = 0)
    {
        DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.PrependInterval(s:  0, interval:  flashDuration);
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOColor(target:  this.wedgeHighlighter, endValue:  new UnityEngine.Color() {r = flashColor.r, g = flashColor.g, b = flashColor.b, a = flashColor.a}, duration:  flashDuration);
        object val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.wedgeHighlighter, ease:  32, amplitude:  flashDuration, period:  startDelay);
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.wedgeHighlighter);
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  flashDuration);
        object val_10 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  0, loops:  0, loopType:  0);
        object val_11 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  0, ease:  1);
        this.flashSeq = 0;
    }
    public void StopFlash()
    {
        DG.Tweening.TweenExtensions.Kill(t:  this.flashSeq, complete:  false);
        if((mem[this.wedgeHighlighter + (0)]) != 0)
        {
                return;
        }
    
    }
    public BonusGameWheelWedge()
    {
        this.fitToWidth = 96f;
    }

}
