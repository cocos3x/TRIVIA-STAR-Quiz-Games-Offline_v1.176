using UnityEngine;
private sealed class AutopilotRequester.<Screenshot>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public twelvegigs.Autopilot.AutopilotRequester <>4__this;
    public long actionTimestamp;
    public string uniqueTag;
    public string game;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AutopilotRequester.<Screenshot>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        string val_5;
        if((this.<>1__state) != 1)
        {
                val_4 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForEndOfFrame val_1 = null;
            val_5 = val_1;
            val_1 = new UnityEngine.WaitForEndOfFrame();
            val_4 = 1;
            this.<>1__state = 682893477872140289;
            return (bool)val_4;
        }
        
        this.<>1__state = 0;
        System.Byte[] val_2 = twelvegigs.Autopilot.AutopilotTools.TakeScreenshot();
        val_5 = this.uniqueTag;
        this.<>4__this.AddScreenShoot(actionTimestamp:  0, uniqueTag:  SB, game:  val_5, file:  this.game);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_4 = 0;
        PauseAutomation(pause:  false);
        return (bool)val_4;
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
