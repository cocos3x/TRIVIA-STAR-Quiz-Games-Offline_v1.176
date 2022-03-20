using UnityEngine;
private sealed class FlyKeyBoardLetter.<FlyTo>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.Ladder.FlyKeyBoardLetter <>4__this;
    public UnityEngine.Vector3 posStop;
    public System.Action callback;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FlyKeyBoardLetter.<FlyTo>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        var val_11;
        UnityEngine.Vector3 val_12;
        SLC.Minigames.Ladder.FlyKeyBoardLetter val_15;
        val_10 = 0;
        if((this.<>1__state) >= 2)
        {
                return (bool)val_10;
        }
        
        this.<>1__state = 0;
        UnityEngine.Transform val_1 = this.<>4__this.transform;
        val_11 = 0;
        UnityEngine.Vector3 val_2 = position;
        val_12 = this.posStop;
        float val_3 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3(), b:  new UnityEngine.Vector3() {x = val_12, y = ???, z = this.<>4__this});
        UnityEngine.GameObject val_4 = this.<>4__this.gameObject;
        val_15 = this.<>4__this;
        if((this.<>4__this) <= 0)
        {
                val_10 = 0;
            val_15.SetActive(value:  false);
            this.callback.Invoke();
            return (bool)val_10;
        }
        
        UnityEngine.Transform val_5 = val_15.transform;
        val_12 = val_15;
        UnityEngine.Transform val_6 = this.<>4__this.transform;
        val_11 = 0;
        UnityEngine.Vector3 val_7 = position;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = 4.008767E-05f}, b:  new UnityEngine.Vector3() {y = this.posStop}, t:  val_7.x);
        val_12.position = new UnityEngine.Vector3();
        UnityEngine.WaitForEndOfFrame val_9 = null;
        val_15 = val_9;
        val_9 = new UnityEngine.WaitForEndOfFrame();
        val_10 = 1;
        this.<>1__state = val_10;
        this.<>2__current = val_15;
        return (bool)val_10;
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
