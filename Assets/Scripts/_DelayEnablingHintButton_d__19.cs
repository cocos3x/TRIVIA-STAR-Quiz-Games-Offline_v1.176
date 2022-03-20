using UnityEngine;
private sealed class Just2EmojisFTUXManager.<DelayEnablingHintButton>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Just2EmojisFTUXManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Just2EmojisFTUXManager.<DelayEnablingHintButton>d__19(int <>1__state)
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
        
        val_5 = this.<>4__this;
        this.<>1__state = 0;
        object val_2 = this.<>4__this.hintButton.GetComponent<System.Object>();
        this.<>4__this.hintButton.interactable = true;
        object val_3 = this.<>4__this.hintButton.GetComponent<System.Object>();
        this.<>4__this.hintButton.enabled = true;
        this.<>4__this.hintText.enabled = true;
        this.<>4__this.hintImage.enabled = true;
        val_4 = 0;
        this.<>4__this.coinText.enabled = true;
        this.<>4__this.coinImage.enabled = true;
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
