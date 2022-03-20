using UnityEngine;
private sealed class UGUIPageDisplay.<EnableControlsGroupAfterFrame>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UGUIPageDisplay <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UGUIPageDisplay.<EnableControlsGroupAfterFrame>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        UGUIPageDisplay val_4;
        val_3 = 0;
        val_4 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 0;
            UnityEngine.GameObject val_1 = this.<>4__this.dotControlGroup.gameObject;
            val_3 = 1;
            this.<>4__this.dotControlGroup.SetActive(value:  true);
            UnityEngine.WaitForEndOfFrame val_2 = null;
            val_4 = val_2;
            val_2 = new UnityEngine.WaitForEndOfFrame();
            this.<>1__state = val_3;
            this.<>2__current = val_4;
            return (bool)val_3;
        }
        
        this.<>1__state = 0;
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
