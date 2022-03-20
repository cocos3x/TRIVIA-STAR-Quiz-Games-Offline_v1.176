using UnityEngine;
public class WADPetProfile : FrameSkipper
{
    // Fields
    private UnityEngine.UI.Text petName;
    private UnityEngine.UI.Text description;
    private UnityEngine.GameObject thinkBubble;
    private UnityEngine.UI.Image petImage;
    private Spine.Unity.SkeletonGraphic petAnim;
    private UnityEngine.GameObject levelupAnim;
    private UnityEngine.GameObject foodIcon;
    private UnityEngine.UI.Text feedButtonText;
    private UnityEngine.UI.Button feedButton;
    private UnityEngine.Transform feedArrow;
    private UnityEngine.GameObject unlockNow;
    private UnityEngine.GameObject upgradeCostGroup;
    private UnityEngine.UI.Text upgradeCost;
    private UnityEngine.UI.Text upgradeProgressText;
    private UnityEngine.UI.Button upgradeButton;
    private UnityEngine.Transform upgradeArrow;
    private WADPets.WADPet thisPet;
    private DG.Tweening.Sequence feedArrowSequence;
    private DG.Tweening.Sequence upgradeArrowSequence;
    private DG.Tweening.Tweener foodIconTweener;
    
    // Methods
    public void Setup(WADPets.WADPet pet)
    {
        this.ResetUI();
        mem[1152921512218802440] = 0;
        this.thisPet = pet;
        this.UpdatePetBasicInfo(pet:  pet);
        this.UpdatePetStatus(pet:  pet);
    }
    private System.Collections.IEnumerator ShowLevelupAnim()
    {
        object val_1 = new System.Object();
        typeof(WADPetProfile.<ShowLevelupAnim>d__21).__il2cppRuntimeField_8 = 0;
        typeof(WADPetProfile.<ShowLevelupAnim>d__21).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator ShowUpgradeArrow()
    {
        object val_1 = new System.Object();
        typeof(WADPetProfile.<ShowUpgradeArrow>d__22).__il2cppRuntimeField_8 = 0;
        typeof(WADPetProfile.<ShowUpgradeArrow>d__22).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator ShowFeedArrow()
    {
        object val_1 = new System.Object();
        typeof(WADPetProfile.<ShowFeedArrow>d__23).__il2cppRuntimeField_8 = 0;
        typeof(WADPetProfile.<ShowFeedArrow>d__23).__il2cppRuntimeField_10 = this;
    }
    private void UpdateTimer()
    {
        var val_3;
        var val_20;
        var val_21;
        var val_22;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.TimeSpan val_2 = GetTimeCountdownToNextFeed();
        double val_5 = val_3.TotalDays;
        if((public static WADPetsManager MonoSingleton<WADPetsManager>::get_Instance()) == 0)
        {
                3317432384 = 3317432384;
        }
        
        if(S0 != 0)
        {
                string val_7 = val_3.Days.ToString(format:  1254115712);
            val_21 = ;
            string val_9 = val_3.Hours.ToString(format:  -1827641632);
            string val_11 = val_3.Minutes.ToString(format:  -1827641632);
            val_22 = "{0}d {1}h {2}m";
            string val_12 = System.String.Format(format:  -1410608784, arg0:  -977534916, arg1:  -977534916, arg2:  -977534916);
        }
        else
        {
                string val_14 = val_3.Hours.ToString(format:  -1827641632);
            val_20 = ;
            string val_16 = val_3.Minutes.ToString(format:  -1827641632);
            val_22 = "{0}h {1}m";
            string val_17 = System.String.Format(format:  -977546960, arg0:  -977534916, arg1:  -977534916);
        }
        
        double val_18 = val_3.TotalSeconds;
        if(this.feedButtonText >= 0)
        {
                return;
        }
        
        mem[1152921512219258728] = 0;
        twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Refresh(highlightPet:  0);
    }
    private void ResetUI()
    {
        UnityEngine.GameObject val_1 = this.petImage.gameObject;
        this.petImage.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.petAnim.gameObject;
        this.petAnim.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.upgradeProgressText.gameObject;
        this.upgradeProgressText.SetActive(value:  false);
        this.upgradeCostGroup.SetActive(value:  false);
        this.unlockNow.SetActive(value:  false);
        this.thinkBubble.SetActive(value:  false);
        UnityEngine.GameObject val_4 = this.feedArrow.gameObject;
        this.feedArrow.SetActive(value:  false);
        UnityEngine.GameObject val_5 = this.upgradeArrow.gameObject;
        this.upgradeArrow.SetActive(value:  false);
        this.feedButton.interactable = false;
        this.StopAllCoroutines();
        int val_6 = DG.Tweening.DOTween.Kill(targetOrId:  this.foodIconTweener, complete:  false);
        int val_7 = DG.Tweening.DOTween.Kill(targetOrId:  this.upgradeArrowSequence, complete:  false);
        int val_8 = DG.Tweening.DOTween.Kill(targetOrId:  this.feedArrowSequence, complete:  false);
    }
    private void UpdatePetBasicInfo(WADPets.WADPet pet)
    {
        UnityEngine.UI.Text val_3;
        WADPets.WADPetName val_4;
        var val_5;
        val_3 = this.petName;
        val_4 = pet.Info.Name;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem2[0] = ;
        var val_3 = 27921447;
        val_3 = 7704340 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        if(App.game == 1)
        {
                val_3 = this.petName;
            val_4 = pet.Info.Name;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem2[0] = ;
            string val_1 = System.String.Format(format:  -977199984, arg0:  431575040);
        }
        
        string val_2 = WADPetsManager.GetAbilityDescription(pet:  pet);
        if(this.description == 0)
        {
            
        }
    
    }
    private void UpdatePetStatus(WADPets.WADPet pet)
    {
        Spine.Unity.SkeletonDataAsset val_31;
        var val_32;
        Spine.Unity.SkeletonGraphic val_33;
        Spine.Unity.SkeletonGraphic val_34;
        Spine.Unity.SkeletonGraphic val_35;
        Spine.Unity.SkeletonGraphic val_36;
        UnityEngine.GameObject val_37;
        if(new System.Object() != 0)
        {
                typeof(WADPetProfile.<>c__DisplayClass27_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(WADPetProfile.<>c__DisplayClass27_0).__il2cppRuntimeField_C = pet;
        this.feedButtonText.horizontalOverflow = 0;
        this.feedButtonText.resizeTextMaxSize = 35;
        UnityEngine.Transform val_2 = this.foodIcon.transform;
        UnityEngine.Vector3 val_3 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
        this.foodIcon.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        if(WADPetsManager.IsAnyPetUnlocked() == false)
        {
            goto label_7;
        }
        
        if(WADPetsManager.IsAnyPetHungry() == false)
        {
            goto label_9;
        }
        
        this.foodIcon.SetActive(value:  true);
        string val_6 = Localization.Localize(key:  -977034544, defaultValue:  -977034640, useSingularKey:  false);
        this.feedButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  -976810368, method:  new IntPtr(3317949264));
        this.feedButton.m_OnClick.AddListener(call:  162246656);
        this.feedButton.interactable = true;
        goto label_19;
        label_7:
        this.foodIcon.SetActive(value:  true);
        string val_8 = Localization.Localize(key:  -977034544, defaultValue:  -977034640, useSingularKey:  false);
        if(this.feedButtonText != 0)
        {
            goto label_19;
        }
        
        goto label_19;
        label_9:
        this.foodIcon.SetActive(value:  false);
        this.feedButtonText.horizontalOverflow = 1;
        this.feedButtonText.resizeTextMaxSize = 40;
        System.Action val_9 = new System.Action(object:  -976810368, method:  new IntPtr(3317970768));
        mem[1152921512219971224] = null;
        label_19:
        WADPets.WADPetUpgradeRequirement val_10 = WADPetsManager.GetUpgradeRequirement(levelIndex:  pet + 12);
        if((pet + 20) >= (pet + 12 + 8))
        {
                0 = 1;
        }
        
        this.upgradeButton.interactable = true;
        this.upgradeButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_11 = new UnityEngine.Events.UnityAction(object:  335302656, method:  new IntPtr(3317992272));
        this.upgradeButton.m_OnClick.AddListener(call:  162246656);
        string val_12 = Localization.Localize(key:  -976973904, defaultValue:  -976974000, useSingularKey:  false);
        if((pet + 16) == 0)
        {
            goto label_31;
        }
        
        if((typeof(WADPetProfile.<>c__DisplayClass27_0).__il2cppRuntimeField_C.IsActive()) == false)
        {
            goto label_32;
        }
        
        UnityEngine.GameObject val_14 = this.petAnim.gameObject;
        this.petAnim.SetActive(value:  true);
        val_31 = mem[pet + 8 + 32];
        val_31 = pet + 8 + 32;
        this.petAnim.skeletonDataAsset = val_31;
        val_32 = 0;
        this.petAnim.Initialize(overwrite:  true);
        this.petAnim.startingAnimation = "Idle";
        val_33 = this.petAnim;
        if(this.petAnim != 0)
        {
            goto label_40;
        }
        
        val_33 = this.petAnim;
        if(val_33 == 0)
        {
            goto label_56;
        }
        
        label_40:
        Spine.TrackEntry val_15 = this.petAnim.state.SetAnimation(trackIndex:  0, animationName:  this.petAnim.startingAnimation, loop:  true);
        this.petAnim.skeleton.SetSlotsToSetupPose();
        UnityEngine.Color val_16 = UnityEngine.Color.white;
        this.petAnim.color = new UnityEngine.Color() {r = val_3.x, g = val_3.y, b = val_3.z, a = ???};
        this.petAnim.freeze = false;
        goto label_72;
        label_31:
        UnityEngine.GameObject val_17 = this.petAnim.gameObject;
        this.petAnim.SetActive(value:  true);
        val_31 = mem[pet + 8 + 32];
        val_31 = pet + 8 + 32;
        this.petAnim.skeletonDataAsset = val_31;
        val_32 = 0;
        this.petAnim.Initialize(overwrite:  true);
        this.petAnim.startingAnimation = "Idle";
        val_34 = this.petAnim;
        if(this.petAnim != 0)
        {
            goto label_55;
        }
        
        val_34 = this.petAnim;
        if(val_34 == 0)
        {
            goto label_56;
        }
        
        label_55:
        Spine.TrackEntry val_18 = this.petAnim.state.SetAnimation(trackIndex:  0, animationName:  this.petAnim.startingAnimation, loop:  false);
        this.petAnim.skeleton.SetSlotsToSetupPose();
        val_35 = this.petAnim;
        UnityEngine.Color val_19 = UnityEngine.Color.black;
        val_35.color = new UnityEngine.Color() {r = val_3.x, g = val_3.y, b = val_3.z, a = ???};
        this.petAnim.freeze = true;
        val_36 = this.petAnim;
        if((pet + 20) < (pet + 12 + 8))
        {
            goto label_63;
        }
        
        this.unlockNow.SetActive(value:  true);
        System.Collections.IEnumerator val_20 = this.ShowUpgradeArrow();
        UnityEngine.Coroutine val_21 = this.StartCoroutine(routine:  -976810368);
        return;
        label_32:
        this.petImage.sprite = pet + 8 + 28;
        UnityEngine.GameObject val_22 = this.petImage.gameObject;
        this.petImage.SetActive(value:  true);
        this.thinkBubble.SetActive(value:  true);
        goto label_72;
        label_63:
        string val_23 = Localization.Localize(key:  -976854944, defaultValue:  -976855024, useSingularKey:  false);
        label_72:
        UnityEngine.GameObject val_24 = this.upgradeButton.gameObject;
        val_35 = this.upgradeButton;
        twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WADPets.WADPet val_31 = typeof(WADPetProfile.<>c__DisplayClass27_0).__il2cppRuntimeField_C;
        val_31 = (IsPetMaxLevel(pet:  val_31)) ^ 1;
        val_35.SetActive(value:  val_31);
        if((pet + 20) < (pet + 12 + 8))
        {
            goto label_78;
        }
        
        var val_27 = (pet + 12) + 12;
        string val_28 = val_27.ToString();
        val_36 = val_27;
        val_37 = this.upgradeCostGroup;
        if(val_37 != 0)
        {
            goto label_85;
        }
        
        goto label_81;
        label_78:
        val_35 = 1152921504619999232;
        string val_29 = System.String.Format(format:  -1128214576, arg0:  -976854944, arg1:  13152256, arg2:  13152256);
        val_36 = "{0}\n{1}/{2}";
        UnityEngine.GameObject val_30 = this.upgradeProgressText.gameObject;
        val_37 = this.upgradeProgressText;
        if(this.upgradeProgressText != 0)
        {
            goto label_85;
        }
        
        label_81:
        label_85:
        val_37.SetActive(value:  true);
        return;
        label_56:
    }
    private void OnClick_FeedAllPets()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(FeedAllPets() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_4 = GetWindow<System.Object>();
            if(isActiveAndEnabled != false)
        {
                UnityEngine.GameObject val_6 = gameObject;
            SLCWindow.CloseWindow(window:  2119322896, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Refresh(highlightPet:  this.thisPet);
            return;
        }
        
        GameBehavior val_8 = App.getBehavior;
        0.Init(type:  0);
    }
    public WADPetProfile()
    {
    
    }

}
