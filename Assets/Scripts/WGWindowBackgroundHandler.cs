using UnityEngine;
public class WGWindowBackgroundHandler : MonoBehaviour
{
    // Fields
    private UnityEngine.CanvasGroup alphaCanvas;
    private UnityEngine.GameObject bg_darken;
    private UnityEngine.GameObject bg_vignette;
    private UnityEngine.GameObject bg_vignette_dark;
    private UnityEngine.GameObject bg_blurred;
    private float fadeDuration;
    private DG.Tweening.Tweener fadingTween;
    private WGWindowBackgroundHandler.WGWindowBackgroundType currentState;
    
    // Methods
    public void HandleWindowShowing(SLCWindowSetting setting)
    {
        WGWindowBackgroundType val_5;
        if(setting != 0)
        {
            goto label_3;
        }
        
        label_10:
        GameBehavior val_2 = App.getBehavior;
        this.SetDarkenedBackgroundAlpha(alpha:  null);
        this.SetState(nextBackground:  1);
        return;
        label_3:
        val_5 = setting.backgroundType;
        if(val_5 != 5)
        {
            goto label_9;
        }
        
        if(UnityEngine.SystemInfo.supportedRenderTargetCount == 1)
        {
            goto label_10;
        }
        
        val_5 = setting.backgroundType;
        label_9:
        if(val_5 == 7)
        {
                if(UnityEngine.SystemInfo.supportedRenderTargetCount == 1)
        {
                this.SetState(nextBackground:  6);
            return;
        }
        
            val_5 = setting.backgroundType;
        }
        
        this.SetState(nextBackground:  val_5);
    }
    public void CloseBackgrounds()
    {
        this.SetState(nextBackground:  0);
    }
    public void SetDarkenedBackgroundAlpha(float alpha)
    {
        object val_1 = this.bg_darken.GetComponent<System.Object>();
        if((UnityEngine.Mathf.Approximately(a:  alpha, b:  null)) != false)
        {
                this.bg_darken.enabled = false;
            return;
        }
        
        this.bg_darken.enabled = true;
        UnityEngine.Color val_6 = new UnityEngine.Color(r:  alpha, g:  null, b:  null, a:  null);
        if(this.bg_darken != 0)
        {
                return;
        }
    
    }
    private void OnFadeOutComplete()
    {
        UnityEngine.GameObject val_1 = this.alphaCanvas.gameObject;
        this.alphaCanvas.SetActive(value:  false);
    }
    private void SetState(WGWindowBackgroundHandler.WGWindowBackgroundType nextBackground)
    {
        if(this.currentState == nextBackground)
        {
                return;
        }
        
        if((this.FadeOutOldDarkness(oldBackground:  this.currentState, nextBackground:  R4)) != true)
        {
                this.FadeInNextDarkness(nextBackground:  R4, duration:  null);
        }
        
        this.currentState = ;
    }
    private bool FadeOutOldDarkness(WGWindowBackgroundHandler.WGWindowBackgroundType oldBackground, WGWindowBackgroundHandler.WGWindowBackgroundType nextBackground)
    {
        float val_10;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                typeof(WGWindowBackgroundHandler.<>c__DisplayClass14_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(WGWindowBackgroundHandler.<>c__DisplayClass14_0).__il2cppRuntimeField_C = nextBackground;
        object val_2 = new System.Object();
        typeof(WGWindowBackgroundHandler.<>c__DisplayClass14_1).__il2cppRuntimeField_C = val_1;
        if(oldBackground == 4)
        {
                return false;
        }
        
        if(oldBackground == 6)
        {
                this.alphaCanvas.alpha = null;
            UnityEngine.GameObject val_3 = this.alphaCanvas.gameObject;
            this.alphaCanvas.SetActive(value:  false);
            return false;
        }
        
        val_10 = this.fadeDuration;
        typeof(WGWindowBackgroundHandler.<>c__DisplayClass14_1).__il2cppRuntimeField_8 = ;
        DG.Tweening.Core.DOGetter<System.Single> val_4 = new DG.Tweening.Core.DOGetter<System.Single>(object:  395366400, method:  new IntPtr(83553584));
        DG.Tweening.Core.DOSetter<System.Single> val_5 = new DG.Tweening.Core.DOSetter<System.Single>(object:  395366400, method:  new IntPtr(83554608));
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_6 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  null, duration:  null);
        DG.Tweening.TweenCallback val_7 = new DG.Tweening.TweenCallback(object:  395419648, method:  new IntPtr(83555632));
        object val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  198828032, action:  190734336);
        object val_9 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  198828032, autoKillOnCompletion:  true);
        this.fadingTween = null;
        return false;
    }
    private void FadeInNextDarkness(WGWindowBackgroundHandler.WGWindowBackgroundType nextBackground, float duration)
    {
        if(this.fadingTween != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.fadingTween, complete:  false);
        }
        
        this.ActivateBackgroundType(darkness:  nextBackground);
        if(nextBackground == 4)
        {
                return;
        }
        
        if(nextBackground == 6)
        {
                this.alphaCanvas.alpha = duration;
            UnityEngine.GameObject val_1 = this.alphaCanvas.gameObject;
            this.alphaCanvas.SetActive(value:  true);
            return;
        }
        
        this.alphaCanvas.alpha = duration;
        UnityEngine.GameObject val_2 = this.alphaCanvas.gameObject;
        this.alphaCanvas.SetActive(value:  true);
        DG.Tweening.Core.DOGetter<System.Single> val_3 = new DG.Tweening.Core.DOGetter<System.Single>(object:  83736688, method:  new IntPtr(83710640));
        DG.Tweening.Core.DOSetter<System.Single> val_4 = new DG.Tweening.Core.DOSetter<System.Single>(object:  83736688, method:  new IntPtr(83711664));
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_5 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  duration, duration:  null);
        object val_6 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  198828032, autoKillOnCompletion:  true);
        this.fadingTween = null;
    }
    private void ActivateBackgroundType(WGWindowBackgroundHandler.WGWindowBackgroundType darkness)
    {
        var val_4;
        var val_8;
        if(darkness > 7)
        {
                return;
        }
        
        var val_1 = 6054168 + (6054168 + (darkness) << 2);
        if(darkness == 7)
        {
                6054168 = IP * 6054168;
            6054168 = 6054168 & (((int)R8) >> 2);
            6054168 = 6054168 & 671313792;
            6054168 = 6054168 & ((((((IP * 6054168) & ((int)R8) >> 2) & 671313792)) << (32-3)) | (((((IP * 6054168) & ((int)R8) >> 2) & 671313792)) << 3));
            6054168 = 6054168 & (((int)IP) >> R2);
            6054168 = 6054168 & (6054168 >> 32);
            6054168 = 6054168 & ((IP) << R3);
            6054168 = 6054168 & (6054168 >> 32);
        }
        
        this.bg_darken.SetActive(value:  false);
        this.bg_vignette.SetActive(value:  false);
        this.bg_vignette_dark.SetActive(value:  false);
        val_4 = 1;
        this.bg_blurred.SetActive(value:  false);
        UnityEngine.GameObject val_3 = gameObject;
        val_8 = 1;
        SetActive(value:  true);
    }
    public WGWindowBackgroundHandler()
    {
        this.fadeDuration = 0.3f;
    }
    private float <FadeInNextDarkness>b__15_0()
    {
        if(this.alphaCanvas != 0)
        {
                return this.alphaCanvas.alpha;
        }
        
        return this.alphaCanvas.alpha;
    }
    private void <FadeInNextDarkness>b__15_1(float x)
    {
        this.alphaCanvas.alpha = x;
    }

}
