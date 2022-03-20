using UnityEngine;
private sealed class GameStoreManager.<LoadStoreScene>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public GameStoreManager <>4__this;
    public System.Action<bool, bool> storeCloseCallback;
    private UnityEngine.AsyncOperation <asyncLoad>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameStoreManager.<LoadStoreScene>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        UnityEngine.AsyncOperation val_5;
        if((this.<>1__state) != 1)
        {
                val_4 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            GameBehavior val_1 = App.getBehavior;
            UnityEngine.AsyncOperation val_2 = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  null, mode:  1);
            val_5 = 0;
            this.<asyncLoad>5__2 = 0;
        }
        else
        {
                val_5 = this.<asyncLoad>5__2;
            this.<>1__state = 0;
        }
        
        if(val_5.isDone != false)
        {
                if((this.<>4__this.currentStoreCloseCallback) != 0)
        {
                this.<>4__this.currentStoreCloseCallback.Invoke(arg1:  false, arg2:  false);
        }
        
            this.<>4__this.currentStoreCloseCallback = this.storeCloseCallback;
            val_4 = 0;
            return (bool)val_4;
        }
        
        this.<>1__state = 1;
        this.<>2__current = 0;
        return true;
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
