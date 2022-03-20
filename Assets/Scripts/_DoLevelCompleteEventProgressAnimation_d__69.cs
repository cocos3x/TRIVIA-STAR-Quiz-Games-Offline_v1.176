using UnityEngine;
private sealed class AttackMadnessEventHandler.<DoLevelCompleteEventProgressAnimation>d__69 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public AttackMadnessEventHandler <>4__this;
    public WGEventButtonV2 eventButton;
    public WGEventButtonV2 eventProgressUI;
    public WGLevelClearPopup popup;
    private int <currentPoints>5__2;
    private WGEventButtonV2_AttackMadness <attackMadnessButton>5__3;
    private bool <collectedReward>5__4;
    private int <pointsToReward>5__5;
    private int <lastPointsRequired>5__6;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AttackMadnessEventHandler.<DoLevelCompleteEventProgressAnimation>d__69(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_42;
        var val_43;
        WGEventButtonV2 val_44;
        int val_46;
        int val_47;
        WGEventButtonV2_AttackMadness val_48;
        object val_49;
        int val_50;
        int val_51;
        val_42 = 0;
        if((this.<>1__state) > 8)
        {
                return (bool)val_42;
        }
        
        var val_1 = 9342864 + (9342864 + (this.<>1__state) << 2);
        if((this.<>1__state) == 8)
        {
                9342864 + (this.<>1__state) << 2 = (9342864 + (this.<>1__state) << 2) & (-1);
            9342864 + (this.<>1__state) << 2 = (9342864 + (this.<>1__state) << 2) & ((((9342864 + (this.<>1__state) << 2 & -1)) << (32-R2)) | (((9342864 + (this.<>1__state) << 2 & -1)) << R2));
            9342864 + (this.<>1__state) << 2 = (9342864 + (this.<>1__state) << 2) & ((9342864 + (this.<>1__state) << 2) >> 5);
            mem2[0] = (((9342864 + (this.<>1__state) << 2 & -1) & (((9342864 + (this.<>1__state) << 2 & -1)) << (32-R2)) | (((9342864 + (this.<>1__state) << 2 & -1)) << R2)) & (((9342864 + (this.<>1__state) << 2 & -1) & (( + (((9342864 + (this.<>1__state) << 2 & -1) & (((9342864 + (this.<>1__state) << 2 & -1)) << (32-R2)) | (((9342864 + (this.<>1__state) << 2 & -1)) << R2)) & (((9342864 + (this.<>1__state) << 2 & -1) & ((;
            ((((9342864 + (this.<>1__state) << 2 & -1) & (((9342864 + (this.<>1__state) << 2 & -1)) << (32-R2)) | (((9342864 + (this.<>1__state) << 2 & -1)) << R2)) & (((9342864 + (this.<>1__state) << 2 & -1) & (( + (((9342864 + (this.<>1__state) << 2 & -1) & (((9342864 + (this.<>1__state) << 2 & -1)) << (32-R2)) | (((9342864 + (this.<>1__state) << 2 & -1)) << R2)) & (((9342864 + (this.<>1__state) << 2 & -1) & (() & (((R8) << (32-7)) | ((R8) << 7)) = (((((9342864 + (this.<>1__state) << 2 & -1) & (((9342864 + (this.<>1__state) << 2 & -1)) << (32-R2)) | (((9342864 + (this.<>1__state) << 2 & -1)) << R2)) & (((9342864 + (this.<>1__state) << 2 & -1) & (( + (((9342864 + (this.<>1__state) << 2 & -1) & (((9342864 + (this.<>1__state) << 2 & -1)) << (32-R2)) | (((9342864 + (this.<>1__state) << 2 & -1)) << R2)) & (((9342864 + (this.<>1__state) << 2 & -1) & (() & (((R8) << (32-7)) | ((R8) << 7))) & 2751075136;
            ((((9342864 + (this.<>1__state) << 2 & -1) & (((9342864 + (this.<>1__state) << 2 & -1)) << (32-R2)) | (((9342864 + (this.<>1__state) << 2 & -1)) << R2)) & (((9342864 + (this.<>1__state) << 2 & -1) & (( + (((9342864 + (this.<>1__state) << 2 & -1) & (((9342864 + (this.<>1__state) << 2 & -1)) << (32-R2)) | (((9342864 + (this.<>1__state) << 2 & -1)) << R2)) & (((9342864 + (this.<>1__state) << 2 & -1) & (() & (((R8) << (32-7)) | ((R8) << 7)) = (((((9342864 + (this.<>1__state) << 2 & -1) & (((9342864 + (this.<>1__state) << 2 & -1)) << (32-R2)) | (((9342864 + (this.<>1__state) << 2 & -1)) << R2)) & (((9342864 + (this.<>1__state) << 2 & -1) & (( + (((9342864 + (this.<>1__state) << 2 & -1) & (((9342864 + (this.<>1__state) << 2 & -1)) << (32-R2)) | (((9342864 + (this.<>1__state) << 2 & -1)) << R2)) & (((9342864 + (this.<>1__state) << 2 & -1) & (() & (((R8) << (32-7)) | ((R8) << 7))) & (((int)IP) >> 9);
            ((((9342864 + (this.<>1__state) << 2 & -1) & (((9342864 + (this.<>1__state) << 2 & -1)) << (32-R2)) | (((9342864 + (this.<>1__state) << 2 & -1)) << R2)) & (((9342864 + (this.<>1__state) << 2 & -1) & (( + (((9342864 + (this.<>1__state) << 2 & -1) & (((9342864 + (this.<>1__state) << 2 & -1)) << (32-R2)) | (((9342864 + (this.<>1__state) << 2 & -1)) << R2)) & (((9342864 + (this.<>1__state) << 2 & -1) & (() & (((R8) << (32-7)) | ((R8) << 7)) = (((((9342864 + (this.<>1__state) << 2 & -1) & (((9342864 + (this.<>1__state) << 2 & -1)) << (32-R2)) | (((9342864 + (this.<>1__state) << 2 & -1)) << R2)) & (((9342864 + (this.<>1__state) << 2 & -1) & (( + (((9342864 + (this.<>1__state) << 2 & -1) & (((9342864 + (this.<>1__state) << 2 & -1)) << (32-R2)) | (((9342864 + (this.<>1__state) << 2 & -1)) << R2)) & (((9342864 + (this.<>1__state) << 2 & -1) & (() & (((R8) << (32-7)) | ((R8) << 7))) & 2751075136;
            ((((9342864 + (this.<>1__state) << 2 & -1) & (((9342864 + (this.<>1__state) << 2 & -1)) << (32-R2)) | (((9342864 + (this.<>1__state) << 2 & -1)) << R2)) & (((9342864 + (this.<>1__state) << 2 & -1) & (( + (((9342864 + (this.<>1__state) << 2 & -1) & (((9342864 + (this.<>1__state) << 2 & -1)) << (32-R2)) | (((9342864 + (this.<>1__state) << 2 & -1)) << R2)) & (((9342864 + (this.<>1__state) << 2 & -1) & (() & (((R8) << (32-7)) | ((R8) << 7)) = (((((9342864 + (this.<>1__state) << 2 & -1) & (((9342864 + (this.<>1__state) << 2 & -1)) << (32-R2)) | (((9342864 + (this.<>1__state) << 2 & -1)) << R2)) & (((9342864 + (this.<>1__state) << 2 & -1) & (( + (((9342864 + (this.<>1__state) << 2 & -1) & (((9342864 + (this.<>1__state) << 2 & -1)) << (32-R2)) | (((9342864 + (this.<>1__state) << 2 & -1)) << R2)) & (((9342864 + (this.<>1__state) << 2 & -1) & (() & (((R8) << (32-7)) | ((R8) << 7))) & ((R8) >> 15);
        }
        
        val_43 = 0;
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
                val_43 = 1;
        }
        
        if(HasCollectedAllRewards() != false)
        {
                GameplayMode val_27 = PlayingLevel.CurrentGameplayMode;
            typeof(UnityEngine.WaitForSeconds).__il2cppRuntimeField_14 + 32.set_Item(key:  0, value:  0);
            DG.Tweening.Tweener val_28 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.eventButton.canvasGroup, endValue:  null, duration:  null);
            object val_29 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.eventButton.canvasGroup, delay:  null);
            val_44 = 0;
            UnityEngine.GameObject val_30 = this.eventProgressUI.gameObject;
            this.eventProgressUI.SetActive(value:  false);
        }
        else
        {
                val_44 = 0;
            if( == 0)
        {
                val_44 = 1;
        }
        
        }
        
        if(PointsCollectedInLevel >= 1)
        {
                if(HasCollectedAllRewards() == false)
        {
            goto label_54;
        }
        
        }
        
        UnityEngine.WaitForSeconds val_33 = null;
        val_46 = val_33;
        val_33 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_42 = 1;
        this.<>1__state = 8;
        this.<>2__current = val_46;
        return (bool)val_42;
        label_54:
        if((this.<currentPoints>5__2) >= )
        {
            goto label_57;
        }
        
        if( >= )
        {
            goto label_58;
        }
        
        val_47 = PointsCollectedInLevel;
        this.<pointsToReward>5__5 = val_47;
        if((this.<collectedReward>5__4) == false)
        {
            goto label_59;
        }
        
        val_49 = ;
        System.Collections.IEnumerator val_35 = PlayNextRewardSequence(eventButton:  this.eventButton);
        val_51 = 2;
        goto label_67;
        label_57:
        val_42 = true;
        this.<collectedReward>5__4 = val_42;
        this.<pointsToReward>5__5 = ;
        val_49 = ;
        System.Collections.IEnumerator val_38 = RewardSequence(attackMadnessButton:  this.<attackMadnessButton>5__3, eventProgressUI:  mem[null + 972], popup:  this.popup);
        val_50 = 6;
        this.<>1__state = val_50;
        goto label_66;
        label_58:
        val_47 =  - (this.<currentPoints>5__2);
        this.<pointsToReward>5__5 = val_47;
        label_59:
        val_44 = this.eventProgressUI;
        val_48 = this.<attackMadnessButton>5__3;
        val_49 = ;
        System.Collections.IEnumerator val_40 = PlayPointCollectionSequence(startValue:  this.<currentPoints>5__2, points:  val_47, attackMadnessButton:  val_48, eventProgressUI:  val_44, popup:  this.popup);
        val_51 = 3;
        label_67:
        this.<>1__state = val_51;
        val_42 = 1;
        label_66:
        this.<>2__current = val_49;
        return (bool)val_42;
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
