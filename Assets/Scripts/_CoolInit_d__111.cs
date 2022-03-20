using UnityEngine;
private sealed class WPTGameUIController.<CoolInit>d__111 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPets.WPTGameUIController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTGameUIController.<CoolInit>d__111(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        object val_10;
        if((this.<>1__state) <= 3)
        {
                var val_1 = 12953908 + (12953908 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                12953908 + (this.<>1__state) << 2 = (12953908 + (this.<>1__state) << 2) & ((12953908 + (this.<>1__state) << 2) << (12953908 + (this.<>1__state) << 2));
            12953908 + (this.<>1__state) << 2 = (12953908 + (this.<>1__state) << 2) & (((R8) << (32-(12953908 + (this.<>1__state) << 2 & (12953908 + (this.<>1__state) << 2) << 12953908 + (this.<>1__state) << 2))) | ((R8) << (12953908 + (this.<>1__state) << 2 & (12953908 + (this.<>1__state) << 2) << 12953908 + (this.<>1__state) << 2)));
            12953908 + (this.<>1__state) << 2 = (12953908 + (this.<>1__state) << 2) & ((R8) >> 1);
            12953908 + (this.<>1__state) << 2 = (12953908 + (this.<>1__state) << 2) & (((R8) << (32-1)) | ((R8) << 1));
        }
        
            this.<>1__state = 0;
            this.<>4__this.mainLayoutCanvasGroup.interactable = false;
            val_9 = 1;
            this.<>4__this.ToggleAllUI(active:  true);
            this.<>4__this.UpdateProgressUI(skipAnimation:  true);
            val_10 = this.<>4__this;
            System.Collections.IEnumerator val_2 = val_10.ClearCurrentGrid();
            this.<>1__state = val_9;
        }
        else
        {
                val_9 = 0;
            return (bool);
        }
        
        this.<>2__current = ;
        return (bool);
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
