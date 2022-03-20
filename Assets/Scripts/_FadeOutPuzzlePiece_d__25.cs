using UnityEngine;
private sealed class WGPuzzleProgressPopup.<FadeOutPuzzlePiece>d__25 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.GameObject pc;
    public WGPuzzleProgressPopup <>4__this;
    private UnityEngine.Color <newPieceColor>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGPuzzleProgressPopup.<FadeOutPuzzlePiece>d__25(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        WGPuzzleProgressPopup val_4;
        int val_5;
        UnityEngine.Color val_6;
        var val_7;
        val_4 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                val_5 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
            this.<>1__state = 0;
            object val_1 = this.pc.GetComponent<System.Object>();
            val_6 = this.<newPieceColor>5__2;
        }
        else
        {
                val_6 = this.<newPieceColor>5__2;
            this.<>1__state = 0;
            val_7 = 1152921513228584916;
        }
        
        if((this.<>1__state) <= 1)
        {
                val_5 = 0;
            this.pc.SetActive(value:  false);
            return (bool)val_5;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        mem[1152921513228584916] = ;
        object val_3 = this.pc.GetComponent<System.Object>();
        val_4 = this.pc;
        val_6 = mem[this.<newPieceColor>5__2];
        val_6 = this.<newPieceColor>5__2.r;
        val_5 = 1;
        this.<>1__state = val_5;
        this.<>2__current = 0;
        return (bool)val_5;
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
