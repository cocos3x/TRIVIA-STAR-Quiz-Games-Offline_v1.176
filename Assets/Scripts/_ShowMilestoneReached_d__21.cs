using UnityEngine;
private sealed class WordIQLevelCompleteDisplayAnim.<ShowMilestoneReached>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordIQLevelCompleteDisplayAnim <>4__this;
    public float milestoneAmount;
    public int milestoneIndex;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordIQLevelCompleteDisplayAnim.<ShowMilestoneReached>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        int val_6;
        val_5 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
            this.<>1__state = 0;
            string val_1 = WordIQManagerUI.FormatPoints(iqPoints:  null);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -928764432, clipIndex:  0);
            this.<>4__this.milestoneDisplay.AnimateMilestoneUpdate(newMilestoneIndex:  this.milestoneIndex);
            val_6 = 1;
            val_5 = 1;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.milestoneDisplay.GetMilestoneUpdateAnimTime());
        }
        else
        {
                val_6 = 0;
        }
        
        this.<>1__state = val_6;
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
