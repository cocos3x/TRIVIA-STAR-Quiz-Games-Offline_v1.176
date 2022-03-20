using UnityEngine;
private sealed class WordLadderUIController.<MoveArrow>d__24 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.Ladder.WordLadderUIController <>4__this;
    public float x;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordLadderUIController.<MoveArrow>d__24(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        int val_13;
        var val_14;
        UnityEngine.Transform val_15;
        float val_16;
        UnityEngine.Transform val_17;
        if((this.<>1__state) != 1)
        {
                val_13 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_13;
        }
        
            this.<>1__state = 0;
            UnityEngine.GameObject val_1 = this.<>4__this.Arrow.gameObject;
            this.<>4__this.Arrow.SetActive(value:  true);
        }
        else
        {
                this.<>1__state = 0;
            if((this.<>4__this) != 0)
        {
                val_14 = this.<>4__this;
            val_15 = this.<>4__this.Arrow;
            val_16 = val_15;
        }
        else
        {
                val_14 = 36;
            val_16 = 6.018898E-36f;
            val_15 = 83886592;
        }
        
            UnityEngine.Vector3 val_2 = position;
            float val_4 = UnityEngine.Mathf.Lerp(a:  val_2.x, b:  val_2.y, t:  val_2.z);
            UnityEngine.Vector3 val_5 = position;
            UnityEngine.Vector3 val_7 = position;
            UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  val_7.x, y:  val_7.y, z:  val_7.z);
            val_16.position = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        }
        
        val_17 = this.<>4__this.Arrow;
        val_13 = 0;
        UnityEngine.Vector3 val_10 = position;
        float val_13 = System.Math.Abs(val_3 - this.x);
        UnityEngine.WaitForEndOfFrame val_12 = null;
        val_17 = val_12;
        val_12 = new UnityEngine.WaitForEndOfFrame();
        val_13 = 1;
        this.<>1__state = val_13;
        this.<>2__current = val_17;
        return (bool)val_13;
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
