using UnityEngine;
private sealed class ScreenFader.<LoadTheSceneAsync>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public ScreenFader <>4__this;
    public string sceneName;
    private UnityEngine.AsyncOperation <asyncLoad>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ScreenFader.<LoadTheSceneAsync>d__11(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        UnityEngine.AsyncOperation val_4;
        if((this.<>1__state) != 1)
        {
                val_3 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 0;
            this.<>4__this.isLoadingScene = true;
            UnityEngine.AsyncOperation val_1 = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  this.sceneName, mode:  0);
            val_4 = this.sceneName;
            this.<asyncLoad>5__2 = this.sceneName;
        }
        else
        {
                val_4 = this.<asyncLoad>5__2;
            this.<>1__state = 0;
        }
        
        val_3 = 0;
        if(val_4.isDone == true)
        {
                return (bool)val_3;
        }
        
        val_3 = 1;
        this.<>1__state = val_3;
        this.<>2__current = 0;
        return (bool)val_3;
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
