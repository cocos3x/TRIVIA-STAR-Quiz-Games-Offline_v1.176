using UnityEngine;
private sealed class RESGamePlaySceneSwiper.<MoveAndLoadScene>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RestaurantRivals.RESGamePlaySceneSwiper <>4__this;
    public System.Action callback;
    private DG.Tweening.Tweener <touchTweener>5__2;
    private UnityEngine.AsyncOperation <loadSlotsSceneAsync>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESGamePlaySceneSwiper.<MoveAndLoadScene>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.AsyncOperation val_22;
        int val_23;
        float val_24;
        DG.Tweening.Tweener val_25;
        var val_26;
        var val_27;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_23 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_23;
        }
        
        this.<>1__state = 0;
        val_24 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1537803328) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_23 = 0;
        }
        
        NotificationCenter val_4 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  this.<>4__this, aName:  560223792);
        UnityEngine.Transform val_5 = this.<>4__this.movingObject.transform;
        val_24 = this.<>4__this.movingObject;
        object val_6 = this.<>4__this.movingObject.GetComponent<System.Object>();
        UnityEngine.Rect val_7 = rect;
        float val_8 = height;
        float val_21 = (float)this.<>4__this.sceneMoveMultiplyer;
        val_21 = 560269624 * val_21;
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  val_24, endValue:  val_21, duration:  val_7.m_YMin, snapping:  val_21);
        DG.Tweening.TweenCallback val_10 = new DG.Tweening.TweenCallback(object:  this.<>4__this, method:  new IntPtr(560232080));
        object val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  val_24, action:  190734336);
        val_25 = this;
        this.<touchTweener>5__2 = val_24;
        GameBehavior val_12 = App.getBehavior;
        ThemesHandler val_13 = App.ThemesHandler;
        string val_14 = 0.CurrentThemeName;
        string val_15 = null + 2144339952 + null;
        val_22 = 0;
        UnityEngine.AsyncOperation val_16 = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  null);
        this.<loadSlotsSceneAsync>5__3 = val_22;
        val_22.allowSceneActivation = false;
        val_26 = null;
        val_26 = null;
        RestaurantRivals.RESGamePlaySceneSwiper.InTransition = true;
        goto label_30;
        label_1:
        this.<>1__state = 0;
        goto label_32;
        label_2:
        val_25 = this.<touchTweener>5__2;
        this.<>1__state = 0;
        label_30:
        if((DG.Tweening.TweenExtensions.IsPlaying(t:  mem[this.<touchTweener>5__2])) != false)
        {
                val_23 = 1;
            this.<>1__state = val_23;
            this.<>2__current = 0;
            return (bool)val_23;
        }
        
        label_32:
        val_23 = 0;
        if((this.<loadSlotsSceneAsync>5__3.isDone) == true)
        {
                return (bool)val_23;
        }
        
        val_24 = 0;
        float val_19 = this.<loadSlotsSceneAsync>5__3.progress;
        if((this.<loadSlotsSceneAsync>5__3) >= 0)
        {
                if(this.callback != 0)
        {
                this.callback.Invoke();
        }
        
            GameBehavior val_20 = App.getBehavior;
            val_22 = 1152921504951095296;
            if(0 != 0)
        {
                val_27 = null;
        }
        
            val_27 = null;
            if((((mem[1179403747] + (RESMetaGameBehavior.__il2cppRuntimeField_typeHierarchyDepth) << 2) - 4)) == val_27)
        {
                8 = 0 + 8;
        }
        
            mem2[0] = this.<>4__this.currentScene;
            this.<loadSlotsSceneAsync>5__3.allowSceneActivation = true;
        }
        
        val_23 = 1;
        this.<>1__state = 2;
        this.<>2__current = val_24;
        return (bool)val_23;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
