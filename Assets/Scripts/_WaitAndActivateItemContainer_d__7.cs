using UnityEngine;
private sealed class LimitedTimeBundlesPackDisplayManager.<WaitAndActivateItemContainer>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LimitedTimeBundlesPackDisplayManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LimitedTimeBundlesPackDisplayManager.<WaitAndActivateItemContainer>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        var val_8;
        if((this.<>1__state) != 1)
        {
                val_7 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
            this.<>1__state = 0;
            val_7 = 1;
            this.<>1__state = val_7;
            this.<>2__current = new UnityEngine.WaitForEndOfFrame();
            return (bool)val_7;
        }
        
        this.<>1__state = 0;
        UnityEngine.Transform val_2 = this.<>4__this.itemContainer.transform;
        UnityEngine.Transform val_3 = this.<>4__this.itemContainer.parent;
        UnityEngine.GameObject val_4 = this.<>4__this.itemContainer.gameObject;
        this.<>4__this.itemContainer.SetActive(value:  true);
        UnityEngine.Transform val_5 = this.<>4__this.itemContainer.transform;
        val_8 = 0;
        UnityEngine.Transform val_6 = this.<>4__this.itemContainer.parent;
        if((this.<>4__this.itemContainer) != 0)
        {
                if(null != null)
        {
                this.<>4__this.itemContainer = 0;
        }
        
            val_8 = this.<>4__this.itemContainer;
        }
        
        val_7 = 0;
        UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(layoutRoot:  0);
        return (bool)val_7;
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
