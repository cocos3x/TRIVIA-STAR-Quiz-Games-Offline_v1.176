using UnityEngine;
private sealed class Just2EmojisManager.<AnswerFeedback>d__26 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public bool correct;
    public SLC.Minigames.Just2Emojis.Just2EmojisManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Just2EmojisManager.<AnswerFeedback>d__26(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        SLC.Minigames.Just2Emojis.Just2EmojisManager val_13;
        int val_14;
        int val_15;
        object val_16;
        val_13 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_14 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_14;
        }
        
        this.<>1__state = 0;
        if(this.correct == false)
        {
            goto label_4;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        MarkCorrectAnswer();
        goto label_8;
        label_1:
        this.<>1__state = 0;
        if(val_13 == 0)
        {
            goto label_9;
        }
        
        val_15 = this.<>4__this._continuesUsed;
        goto label_10;
        label_2:
        this.<>1__state = 0;
        if(this.correct == false)
        {
            goto label_11;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(HandleLevelComplete() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SetLettersInteractable(on:  false);
        }
        
        val_14 = 0;
        this.<>4__this._continuesUsed = val_14;
        val_13.LoadLevel();
        return (bool)val_14;
        label_4:
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        MarkWrongAnswer();
        label_8:
        UnityEngine.WaitForSeconds val_7 = null;
        val_16 = val_7;
        val_7 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_14 = 1;
        this.<>1__state = val_14;
        goto label_24;
        label_9:
        val_13 = 44;
        val_15 = 2621448;
        label_10:
        mem[44] = 2621449;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_9 = HandleLevelFailed();
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_14 = 0;
        public static SLC.Minigames.Just2Emojis.Just2EmojisUIController MonoSingleton<SLC.Minigames.Just2Emojis.Just2EmojisUIController>::get_Instance().__il2cppRuntimeField_C.enabled = false;
        return (bool)val_14;
        label_11:
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DisplayAnswer();
        UnityEngine.WaitForSeconds val_12 = null;
        val_16 = val_12;
        val_12 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_14 = 1;
        this.<>1__state = 2;
        label_24:
        this.<>2__current = val_16;
        return (bool)val_14;
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
