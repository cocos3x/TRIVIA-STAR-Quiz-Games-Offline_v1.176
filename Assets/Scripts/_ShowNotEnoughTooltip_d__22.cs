using UnityEngine;
private sealed class WGGoldenMultiplierPopup.<ShowNotEnoughTooltip>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGGoldenMultiplierPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGGoldenMultiplierPopup.<ShowNotEnoughTooltip>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if((this.<>1__state) != 1)
        {
                val_2 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_2;
        }
        
            this.<>1__state = 0;
            val_2 = 1;
            this.<>4__this.notEnoughTooltip.SetActive(value:  true);
            this.<>4__this.addMultiplierButton.interactable = false;
            UnityEngine.WaitForSeconds val_1 = null;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            this.<>1__state = val_2;
            this.<>2__current = val_1;
            return (bool)val_2;
        }
        
        this.<>1__state = 0;
        val_2 = 0;
        this.<>4__this.notEnoughTooltip.SetActive(value:  false);
        this.<>4__this.addMultiplierButton.interactable = true;
        return (bool)val_2;
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
