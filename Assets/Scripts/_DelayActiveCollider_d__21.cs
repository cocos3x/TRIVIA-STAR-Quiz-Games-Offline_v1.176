using UnityEngine;
private sealed class TwistyArrowLogic.<DelayActiveCollider>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.TwistyArrow.FlyingArrow arrow;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TwistyArrowLogic.<DelayActiveCollider>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        object val_5;
        if((this.<>1__state) != 1)
        {
                val_4 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_5 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_4 = 1;
            this.<>1__state = val_4;
            this.<>2__current = val_5;
            return (bool)val_4;
        }
        
        this.<>1__state = 0;
        val_5 = this.arrow;
        val_4 = 0;
        if(val_5 == 0)
        {
                return (bool)val_4;
        }
        
        UnityEngine.GameObject val_3 = this.arrow.gameObject;
        val_5 = this.arrow;
        val_4 = 0;
        val_5.tag = 1010075984;
        this.arrow.SetNormalColliderActive(state:  true);
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
