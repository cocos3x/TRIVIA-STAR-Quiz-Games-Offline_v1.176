using UnityEngine;
private sealed class TRVMainController.<displayAnswerResult>d__66 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public bool correct;
    public TRVMainController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVMainController.<displayAnswerResult>d__66(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_37;
        var val_38;
        var val_39;
        object val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_37 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_37;
        }
        
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SetActive(active:  true);
        val_38 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsPlaying() != true)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnLevelComplete(levelsProgressed:  this.correct);
        }
        
        if((this.<>4__this.currentGame.countedAnswers) >= (this.<>4__this.currentGame.quizLength))
        {
            goto label_17;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((IsPlaying() == false) || ((this.<>4__this.currentGame.countedAnswers) != 2))
        {
            goto label_28;
        }
        
        label_17:
        this.<>4__this.ProcessQuizComplete(success:  true);
        if(this.correct != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(IsPlaying() != true)
        {
                twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnCategoryComplete();
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnQuizComplete(quiz:  this.<>4__this.currentGame);
        }
        
        }
        
        label_28:
        val_39 = null;
        val_39 = null;
        UnityEngine.WaitForSeconds val_13 = null;
        val_40 = val_13;
        val_13 = new UnityEngine.WaitForSeconds(seconds:  0.1f = 1.5f);
        val_37 = 1;
        this.<>1__state = val_37;
        goto label_37;
        label_1:
        this.<>1__state = 0;
        val_40 = 1152921512478270368;
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsPlaying() == false)
        {
            goto label_41;
        }
        
        GameBehavior val_17 = App.getBehavior;
        twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((this.<>4__this.currentGame.quizProgressIndex) > 0)
        {
                0 = 1;
        }
        
        TRVReward val_20 = GetReward(isBonus:  true);
        val_40 = public static TRVQuestionOfTheDayManager MonoSingleton<TRVQuestionOfTheDayManager>::get_Instance();
        if((this.<>4__this.currentGame.quizProgressIndex) > 0)
        {
                0 = 1;
        }
        
        val_37 = 0;
        0.Init(reward:  -718511200, isBonus:  true);
        return (bool)val_37;
        label_2:
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SetGameplayAlpha(visible:  false);
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_40 = 0;
        SetActive(active:  false);
        if(this.correct == false)
        {
            goto label_60;
        }
        
        val_37 = 1;
        this.<>1__state = 2;
        label_37:
        this.<>2__current = val_40;
        return (bool)val_37;
        label_41:
        GameBehavior val_23 = App.getBehavior;
        twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_37 = 0;
        OnQuestionComplete(quiz:  this.<>4__this.currentGame);
        return (bool)val_37;
        label_60:
        val_38 = 1152921504901095424;
        val_40 = 1152921511712487824;
        twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TRVSubCategoryProgress val_27 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.GetSubCatProgress(subCategory:  this.<>4__this.currentGame.quizCategory);
        val_41 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28;
        val_42 = mem[public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 12];
        val_42 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 12;
        mem[12] = 1;
        twelvegigs.Autopilot.AutopilotManager val_28 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsPlaying() != false)
        {
                GameBehavior val_30 = App.getBehavior;
            val_43 = mem[12];
            val_44 = 1152921512710559024;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_31 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.freeLifeAvailable) != false)
        {
                this.<>4__this.OnExtraLifeClicked();
            GameBehavior val_33 = App.getBehavior;
            val_37 = 0;
            mem[12].Init(rewardedPopup:  false, tag:  46);
            return (bool)val_37;
        }
        
            GameBehavior val_35 = App.getBehavior;
            val_43 = mem[12];
            val_44 = 1152921512700649104;
        }
        
        val_37 = 0;
        return (bool)val_37;
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
