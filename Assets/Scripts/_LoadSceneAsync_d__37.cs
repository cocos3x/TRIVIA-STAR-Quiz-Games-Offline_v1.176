using UnityEngine;
private sealed class Bootstrapper.<LoadSceneAsync>d__37 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Bootstrapper <>4__this;
    public string sceneName;
    public string lastScene;
    public bool killManagers;
    public bool redirectToGameplay;
    private UnityEngine.AsyncOperation <asyncLoad>5__2;
    private UnityEngine.AsyncOperation <asyncUnload>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Bootstrapper.<LoadSceneAsync>d__37(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_24;
        Bootstrapper val_25;
        var val_26;
        UnityEngine.AsyncOperation val_27;
        object val_28;
        int val_29;
        UnityEngine.AsyncOperation val_30;
        var val_31;
        val_24 = 0;
        if((this.<>1__state) > 5)
        {
                return (bool)val_24;
        }
        
        val_25 = this.<>4__this;
        var val_1 = 6582820 + (6582820 + (this.<>1__state) << 2);
        if((this.<>1__state) == 5)
        {
                6582820 + (this.<>1__state) << 2 = (6582820 + (this.<>1__state) << 2) & (this << (6582820 + (this.<>1__state) << 2));
            6582820 + (this.<>1__state) << 2 = (6582820 + (this.<>1__state) << 2) & ((6582820 + (this.<>1__state) << 2) << 1);
            6582820 + (this.<>1__state) << 2 = (6582820 + (this.<>1__state) << 2) & ((6582820 + (this.<>1__state) << 2) << 2);
            mem2[0] = (((6582820 + (this.<>1__state) << 2 & (this) << 6582820 + (this.<>1__state) << 2) & ((6582820 + (this.<>1__state) << 2 & (this) << 6582820 + (this.<>1__state) << 2)) << 1) & (((6582820 + (this.<>1__st + 35626629;
            (((6582820 + (this.<>1__state) << 2 & (this) << 6582820 + (this.<>1__state) << 2) & ((6582820 + (this.<>1__state) << 2 & (this) << 6582820 + (this.<>1__state) << 2)) << 1) & (((6582820 + (this.<>1__st + 35626629 = ((((6582820 + (this.<>1__state) << 2 & (this) << 6582820 + (this.<>1__state) << 2) & ((6582820 + (this.<>1__state) << 2 & (this) << 6582820 + (this.<>1__state) << 2)) << 1) & (((6582820 + (this.<>1__st + 35626629) & 1283731456;
        }
        
        this.<>1__state = 0;
        this.<>4__this.IsLoadingScene = true;
        UnityEngine.AsyncOperation val_2 = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  this.sceneName, mode:  1);
        val_26 = this;
        val_27 = this.sceneName;
        this.<asyncLoad>5__2 = this.sceneName;
        val_28 = 0;
        if(isDone == false)
        {
            goto label_7;
        }
        
        val_27 = this.<asyncLoad>5__2;
        if(val_27.isDone == false)
        {
            goto label_9;
        }
        
        UnityEngine.WaitForSeconds val_5 = null;
        val_28 = val_5;
        val_5 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_29 = 2;
        goto label_10;
        label_9:
        UnityEngine.SceneManagement.Scene val_6 = UnityEngine.SceneManagement.SceneManager.GetSceneByName(name:  this.lastScene);
        if(val_6.m_Handle.IsValid() == false)
        {
            goto label_13;
        }
        
        UnityEngine.AsyncOperation val_8 = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName:  this.lastScene);
        val_30 = this;
        this.<asyncUnload>5__3 = this.lastScene;
        this.lastScene.allowSceneActivation = false;
        goto label_17;
        label_72:
        this.<>1__state = 4;
        val_24 = 1;
        this.<>2__current = 0;
        return (bool)val_24;
        label_17:
        val_27 = mem[this.<asyncUnload>5__3];
        if(val_27.isDone == false)
        {
            goto label_20;
        }
        
        mem2[0] = 0;
        label_13:
        if(this.killManagers != false)
        {
                T[] val_10 = UnityEngine.Object.FindObjectsOfType<System.Object>();
            val_31 = 0;
            System.Type val_11 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(341798912)});
            typeof(System.Type[]).__il2cppRuntimeField_10 = null;
            UnityEngine.GameObject val_12 = new UnityEngine.GameObject(name:  -2041843200, components:  473824320);
        }
        
        val_25 = 1152921504892043264;
        if(this.redirectToGameplay == false)
        {
            goto label_35;
        }
        
        GameBehavior val_14 = App.getBehavior;
        val_27 = 0;
        if(val_27 != 0)
        {
            goto label_62;
        }
        
        goto label_62;
        label_7:
        val_24 = 1;
        this.<>1__state = val_24;
        goto label_44;
        label_20:
        float val_15 = mem[this.<asyncUnload>5__3].progress;
        if((mem[this.<asyncUnload>5__3]) >= 0)
        {
            goto label_46;
        }
        
        val_24 = 1;
        this.<>1__state = 3;
        this.<>2__current = 0;
        return (bool)val_24;
        label_35:
        GameBehavior val_16 = App.getBehavior;
        val_30 = 0;
        val_27 = this.sceneName;
        if(val_30 == 1)
        {
                GameBehavior val_17 = App.getBehavior;
            val_30 = 0;
            val_27 = this.lastScene;
            if(val_30 == 3)
        {
                val_25 = 1152921504901095424;
            val_30 = 1152921511021137168;
            twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_27 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            if(2119322896 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_27 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            object val_21 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        
        }
        
        }
        
        label_62:
        if(val_25 != 0)
        {
                this.<>4__this.IsLoadingScene = false;
        }
        else
        {
                mem[32] = 0;
        }
        
        if((this.<>4__this.unloadAfterAsyncLoad) == 0)
        {
                return (bool)val_24;
        }
        
        UnityEngine.WaitForSeconds val_22 = null;
        val_28 = val_22;
        val_22 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_29 = 5;
        label_10:
        this.<>1__state = val_29;
        val_24 = 1;
        label_44:
        this.<>2__current = val_28;
        return (bool)val_24;
        label_46:
        float val_23 = mem[this.<asyncUnload>5__3].progress;
        if((mem[this.<asyncUnload>5__3]) < 0)
        {
            goto label_72;
        }
        
        mem[this.<asyncUnload>5__3].allowSceneActivation = true;
        goto label_72;
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
