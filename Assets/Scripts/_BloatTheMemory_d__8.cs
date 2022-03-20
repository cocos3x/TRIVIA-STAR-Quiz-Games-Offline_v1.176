using UnityEngine;
private sealed class SRDebugger_Instantiator.<BloatTheMemory>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SRDebugger_Instantiator <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SRDebugger_Instantiator.<BloatTheMemory>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if((this.<>1__state) > 1)
        {
                return (bool)0;
        }
        
        this.<>1__state = 0;
        UnityEngine.Texture2D val_1 = new UnityEngine.Texture2D(width:  512, height:  512, textureFormat:  5, mipChain:  false);
        this.<>4__this.wastedMemory.Add(item:  154206208);
        0 = 1;
        this.<>1__state = 0;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
        return (bool)0;
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
