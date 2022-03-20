using UnityEngine;
private sealed class WGDailyChallengeLevelComplete.<Start>d__49 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGDailyChallengeLevelComplete <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGDailyChallengeLevelComplete.<Start>d__49(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_3 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.dcRevamp) == false)
        {
            goto label_5;
        }
        
        System.Collections.IEnumerator val_1 = this.<>4__this.PlayNewStarAnimation();
        val_3 = 1;
        this.<>1__state = val_3;
        this.<>2__current = this.<>4__this;
        return (bool)val_3;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.button_continue_completed.interactable = true;
        this.<>4__this.button_continue_less_stars.interactable = true;
        val_3 = 0;
        this.<>4__this.button_retry_less_stars.interactable = true;
        this.<>4__this.button_gala_rewards.interactable = true;
        return (bool)val_3;
        label_2:
        this.<>1__state = 0;
        label_5:
        val_3 = 1;
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
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
