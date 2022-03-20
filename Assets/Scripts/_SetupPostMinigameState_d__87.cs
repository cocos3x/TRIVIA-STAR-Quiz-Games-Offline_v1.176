using UnityEngine;
private sealed class TRVLevelComplete.<SetupPostMinigameState>d__87 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVLevelComplete <>4__this;
    private TRVQuizProgress <progress>5__2;
    private bool <shouldAnimate>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVLevelComplete.<SetupPostMinigameState>d__87(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_76;
        var val_77;
        var val_78;
        int val_79;
        TRVQuizProgress val_80;
        var val_81;
        var val_82;
        var val_83;
        var val_84;
        System.Action<UnityEngine.GameObject> val_86;
        TRVQuizProgress val_87;
        TRVQuizProgress val_88;
        var val_89;
        var val_90;
        int val_91;
        UnityEngine.UI.Image val_92;
        float val_93;
        val_76 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_76;
        }
        
        this.<>1__state = 0;
        this.<>4__this.postMinigameNextButton.interactable = true;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.<progress>5__2 = null;
        val_77 = null;
        if((TRVSpecialCategoriesManager.IsOldSpecialQuiz(progress:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C)) == false)
        {
            goto label_9;
        }
        
        val_78 = null;
        val_79 = TRVLevelComplete.lastEventLevelCompleteAnimShownAt;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_80 = this.<progress>5__2;
        int val_5 = GetQuizProgress(progress:  val_80);
        goto label_15;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
            goto label_30;
        }
        
        goto label_30;
        label_1:
        this.<>1__state = 0;
        if((this.<shouldAnimate>5__3) == false)
        {
            goto label_19;
        }
        
        Player val_7 = App.Player;
        val_82 = 4 - (this.<progress>5__2.finalStarReward);
        goto label_24;
        label_9:
        val_83 = null;
        val_79 = TRVLevelComplete.lastLevelCompleteAnimShownAt;
        Player val_8 = App.Player;
        val_81 = 0;
        label_15:
        val_81 = val_79 - val_81;
        if(0 != 0)
        {
                val_81 = 1;
        }
        
        this.<shouldAnimate>5__3 = true;
        UnityEngine.UI.LayoutElement val_9 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.<>4__this.levelSuccessGroup);
        DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.levelSuccessGroup, endValue:  null, duration:  null);
        if((this.<shouldAnimate>5__3) != false)
        {
                UnityEngine.WaitForSeconds val_11 = null;
            val_11 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_76 = 1;
            this.<>1__state = val_76;
            this.<>2__current = val_11;
            return (bool)val_76;
        }
        
        label_30:
        UnityEngine.GameObject val_12 = this.<>4__this.levelSuccessGroup.gameObject;
        this.<>4__this.levelSuccessGroup.SetActive(value:  false);
        this.<>1__state = 2;
        this.<>2__current = 0;
        val_76 = 1;
        return (bool)val_76;
        label_19:
        Player val_13 = App.Player;
        val_82 = 4;
        label_24:
        decimal val_14 = System.Decimal.op_Implicit(value:  -503055312);
        if((this.<shouldAnimate>5__3) != false)
        {
                Player val_16 = App.Player;
            decimal val_17 = System.Decimal.op_Implicit(value:  -503055312);
            decimal val_18 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -503055328, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        }
        else
        {
                Player val_19 = App.Player;
        }
        
        val_84 = null;
        val_84 = null;
        val_86 = TRVLevelComplete.<>c.<>9__87_0;
        if(val_86 == 0)
        {
                val_86 = null;
            val_86 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  TRVLevelComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3791783952));
            TRVLevelComplete.<>c.<>9__87_0 = val_86;
        }
        
        this.<>4__this.statViews.ForEach(action:  7401472);
        UnityEngine.GameObject val_21 = this.<>4__this.homeButton.gameObject;
        this.<>4__this.homeButton.SetActive(value:  (this.<>4__this.ChapterRewardAvailable) ^ 1);
        string val_24 = Localization.Localize(key:  -503174032, defaultValue:  -503174128, useSingularKey:  false);
        val_87 = this.<progress>5__2;
        if((this.<progress>5__2) != 0)
        {
            goto label_61;
        }
        
        val_87 = this.<progress>5__2;
        if(val_87 == 0)
        {
            goto label_64;
        }
        
        label_61:
        object val_25 = new System.Object();
        typeof(TRVLevelReward).__il2cppRuntimeField_8 = "coin_reward";
        typeof(TRVLevelReward).__il2cppRuntimeField_C = this.<progress>5__2.finalCoinReward;
        typeof(TRVLevelReward).__il2cppRuntimeField_10 = 0;
        typeof(TRVLevelReward).__il2cppRuntimeField_14 = this.<progress>5__2.selectedMulitplier;
        System.Collections.IEnumerator val_26 = this.<>4__this.SetupReward(parent:  this.<>4__this.levelCompleteRewardParent, reward:  360382464, anim:  this.<shouldAnimate>5__3);
        UnityEngine.Coroutine val_27 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        string val_28 = Localization.Localize(key:  -503161648, defaultValue:  -503161552, useSingularKey:  false);
        val_80 = "star_reward";
        val_88 = this.<progress>5__2;
        if((this.<progress>5__2) != 0)
        {
            goto label_63;
        }
        
        val_88 = this.<progress>5__2;
        if(val_88 == 0)
        {
            goto label_64;
        }
        
        label_63:
        object val_29 = new System.Object();
        typeof(TRVLevelReward).__il2cppRuntimeField_8 = val_80;
        typeof(TRVLevelReward).__il2cppRuntimeField_C = this.<progress>5__2.finalStarReward;
        typeof(TRVLevelReward).__il2cppRuntimeField_10 = 1;
        typeof(TRVLevelReward).__il2cppRuntimeField_14 = this.<progress>5__2.selectedMulitplier;
        System.Collections.IEnumerator val_30 = this.<>4__this.SetupReward(parent:  this.<>4__this.levelCompleteRewardParent, reward:  360382464, anim:  this.<shouldAnimate>5__3);
        UnityEngine.Coroutine val_31 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        UnityEngine.GameObject val_32 = this.<>4__this.postMinigameNextButtonGroup.gameObject;
        this.<>4__this.postMinigameNextButtonGroup.SetActive(value:  true);
        UnityEngine.GameObject val_33 = this.<>4__this.postMinigameNextButton.gameObject;
        this.<>4__this.postMinigameNextButton.SetActive(value:  true);
        this.<>4__this.HandlePostMinigameEventSetup(animate:  this.<shouldAnimate>5__3);
        if((this.<shouldAnimate>5__3) != false)
        {
                this.<>4__this.postMinigameNextButton.interactable = false;
            if((TRVSpecialCategoriesManager.IsOldSpecialQuiz(progress:  this.<progress>5__2)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_35 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_89 = null;
            val_89 = null;
            TRVLevelComplete.lastEventLevelCompleteAnimShownAt = GetQuizProgress(progress:  this.<progress>5__2);
        }
        else
        {
                Player val_37 = App.Player;
            val_90 = null;
            val_90 = null;
            TRVLevelComplete.lastLevelCompleteAnimShownAt = 0;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_38 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -1630928224, clipIndex:  0);
            System.Collections.IEnumerator val_39 = this.<>4__this.OnRewardAnimFinished(delay:  null);
            UnityEngine.Coroutine val_40 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        }
        
        WordForest.WFOGameEcon val_41 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        string val_43 = dynamicQuizEntryCost.ToString();
        WordForest.WFOGameEcon val_44 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        var val_46 = mem[1152921512476916292] + (TRVMainController.currentMultiplier << 2);
        string val_47 = Localization.Localize(key:  -710867072, defaultValue:  -765467904, useSingularKey:  false);
        string val_48 = System.String.Format(format:  -511147232, arg0:  13152256, arg1:  -710867072);
        if((this.<>4__this.ChapterRewardAvailable) != false)
        {
                UnityEngine.Transform val_50 = this.<>4__this.postMinigameStarMultiText.transform;
            UnityEngine.Transform val_51 = this.<>4__this.postMinigameStarMultiText.parent;
            UnityEngine.GameObject val_52 = this.<>4__this.postMinigameStarMultiText.gameObject;
            this.<>4__this.postMinigameStarMultiText.SetActive(value:  false);
            UnityEngine.Transform val_53 = this.<>4__this.postMinigameTryAgainCost.transform;
            UnityEngine.Transform val_54 = this.<>4__this.postMinigameTryAgainCost.parent;
            UnityEngine.GameObject val_55 = this.<>4__this.postMinigameTryAgainCost.gameObject;
            this.<>4__this.postMinigameTryAgainCost.SetActive(value:  false);
            string val_56 = Localization.Localize(key:  -1630895248, defaultValue:  -1630895344, useSingularKey:  false);
            if((this.<>4__this.postMinigameNextGameText) != 0)
        {
            goto label_107;
        }
        
        }
        else
        {
                string val_57 = Localization.Localize(key:  -510948000, defaultValue:  -510948096, useSingularKey:  false);
            UnityEngine.Transform val_58 = this.<>4__this.postMinigameTryAgainCost.transform;
            UnityEngine.Transform val_59 = this.<>4__this.postMinigameTryAgainCost.parent;
            UnityEngine.GameObject val_60 = this.<>4__this.postMinigameTryAgainCost.gameObject;
            this.<>4__this.postMinigameTryAgainCost.SetActive(value:  true);
            UnityEngine.Transform val_61 = this.<>4__this.postMinigameStarMultiText.transform;
            UnityEngine.Transform val_62 = this.<>4__this.postMinigameStarMultiText.parent;
            UnityEngine.GameObject val_63 = this.<>4__this.postMinigameStarMultiText.gameObject;
            this.<>4__this.postMinigameStarMultiText.SetActive(value:  true);
        }
        
        label_107:
        if((this.<>4__this.CompletedChapterCycle) != false)
        {
                int val_65 = this.<>4__this.chapterLength;
        }
        else
        {
                Player val_66 = App.Player;
            val_80 = 0;
            val_91 = this.<>4__this.chapterLength;
        }
        
        int val_68 = this.<>4__this.chapterLength;
        string val_69 = System.String.Format(format:  -1222347616, arg0:  13152256, arg1:  13152256);
        val_92 = this.<>4__this.postMinigameChapterProgressBar;
        if((this.<>4__this.CompletedChapterCycle) != false)
        {
                val_93 = 1f;
        }
        else
        {
                Player val_71 = App.Player;
            val_93 = ((float)this.<>4__this.chapterLength) / ((float)this.<>4__this.chapterLength);
        }
        
        val_92.fillAmount = (float)this.<>4__this.chapterLength;
        this.<>4__this.setChestSprite(image:  this.<>4__this.postMinigameChestImage, closed:  false);
        this.<>4__this.postMinigameNextButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_74 = new UnityEngine.Events.UnityAction(object:  this.<>4__this, method:  new IntPtr(3783836544));
        this.<>4__this.postMinigameNextButton.m_OnClick.AddListener(call:  162246656);
        val_76 = 0;
        UnityEngine.GameObject val_75 = this.<>4__this.postMinigameGroup.gameObject;
        this.<>4__this.postMinigameGroup.SetActive(value:  true);
        return (bool)val_76;
        label_64:
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
