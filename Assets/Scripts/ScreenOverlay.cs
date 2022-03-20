using UnityEngine;
public class ScreenOverlay : MonoSingleton<ScreenOverlay>
{
    // Fields
    private UnityEngine.UI.Image screenBlocker;
    
    // Methods
    private void Start()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.clear;
        this.screenBlocker.color = new UnityEngine.Color() {a = ???};
        this.screenBlocker.raycastTarget = false;
        UnityEngine.GameObject val_2 = this.screenBlocker.gameObject;
        this.screenBlocker.SetActive(value:  true);
    }
    public void ToggleDarkener(bool state, bool animated = False, float duration = 0.4)
    {
        float val_3;
        float val_4;
        float val_5;
        float val_6;
        this.screenBlocker.raycastTarget = state;
        if(state != false)
        {
                UnityEngine.Color val_1 = new UnityEngine.Color(r:  duration, g:  null, b:  null, a:  null);
            val_6 = val_1.r;
        }
        else
        {
                UnityEngine.Color val_2 = UnityEngine.Color.clear;
            val_6 = val_1.a;
        }
        
        this.ChangeColor(endColor:  new UnityEngine.Color() {r = val_3, g = val_4, b = val_5, a = val_6}, animated:  animated, duration:  val_2.r);
    }
    public void ToggleWhiteout(bool state, bool animated = True, float duration = 0.4)
    {
        var val_2;
        float val_4;
        float val_5;
        float val_6;
        float val_7;
        this.screenBlocker.raycastTarget = state;
        if(state != false)
        {
                UnityEngine.Color val_1 = UnityEngine.Color.white;
            val_7 = val_2;
        }
        else
        {
                UnityEngine.Color val_3 = new UnityEngine.Color(r:  duration, g:  null, b:  null, a:  null);
            val_7 = val_3.r;
        }
        
        this.ChangeColor(endColor:  new UnityEngine.Color() {r = val_4, g = val_5, b = val_6, a = val_7}, animated:  animated, duration:  duration);
    }
    public void SetColor(UnityEngine.Color endColor)
    {
        this.screenBlocker.color = new UnityEngine.Color() {r = endColor.r, g = endColor.g, b = endColor.b, a = endColor.a};
    }
    private void ChangeColor(UnityEngine.Color endColor, bool animated, float duration)
    {
        float val_1;
        if(animated != false)
        {
                DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOColor(target:  this.screenBlocker, endValue:  new UnityEngine.Color() {r = endColor.r, g = endColor.g, b = endColor.b, a = endColor.a}, duration:  val_1);
            return;
        }
        
        this.screenBlocker.color = new UnityEngine.Color() {r = endColor.r, g = endColor.g, b = endColor.b, a = endColor.a};
    }
    public ScreenOverlay()
    {
    
    }

}
