using UnityEngine;
private sealed class WOLMainController.<GrantReward>d__44 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Wordlicious.WOLMainController <>4__this;
    public int randomLetters;
    private int <grantedLetters>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WOLMainController.<GrantReward>d__44(int <>1__state)
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
        var val_6;
        int val_7;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_4 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
        this.<grantedLetters>5__2 = 0;
        this.<>1__state = 0;
        this.<>4__this.hintButton.interactable = false;
        UnityEngine.WaitForSeconds val_1 = null;
        val_5 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_4 = 1;
        this.<>1__state = val_4;
        goto label_6;
        label_1:
        val_6 = this;
        val_7 = (this.<grantedLetters>5__2) + 1;
        this.<>1__state = 0;
        this.<grantedLetters>5__2 = val_7;
        goto label_7;
        label_2:
        val_6 = this;
        val_7 = this.<grantedLetters>5__2;
        this.<>1__state = 0;
        label_7:
        if(val_7 >= this.randomLetters)
        {
            goto label_8;
        }
        
        if((this.<>4__this.GrantRandomLetter()) == false)
        {
            goto label_10;
        }
        
        UnityEngine.WaitForSeconds val_3 = null;
        val_5 = val_3;
        val_3 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_4 = 1;
        this.<>1__state = 2;
        label_6:
        this.<>2__current = val_5;
        return (bool)val_4;
        label_10:
        val_7 = this.<grantedLetters>5__2;
        label_8:
        if(val_7 >= 1)
        {
                this.<>4__this.SaveLevel();
        }
        
        val_4 = 0;
        this.<>4__this.hintButton.interactable = true;
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
