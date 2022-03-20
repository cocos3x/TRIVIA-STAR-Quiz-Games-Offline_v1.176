using UnityEngine;
public class MPIGiftRewardUI : MonoBehaviour
{
    // Fields
    private const int MAX_REWARDS = 5;
    private UnityEngine.UI.Text tapToOpen;
    private UnityEngine.UI.Button tapArea;
    private UnityEngine.UI.GridLayoutGroup upperLayout;
    private UnityEngine.UI.GridLayoutGroup lowerLayout;
    private UnityEngine.GameObject coinRewardPrefab;
    private UnityEngine.GameObject collectionItemPrefab;
    private GridCoinCollectAnimationInstantiator coinAnim;
    private SLC.MatchyPics.MPICollectionUI collectionUI;
    private System.Collections.Generic.List<MPIGiftRewardUI.GiftRewardRevealInfo> rewardsToReveal;
    private System.Collections.Generic.List<GiftRewardUIParams> pendingRewards;
    private bool giftOpened;
    private System.Action onAllRewardsRevealed;
    private MPIGiftRewardUI.GiftRewardRevealInfo currentReward;
    private UnityEngine.Coroutine rewardCoroutine;
    
    // Properties
    private int TotalRewards { get; }
    
    // Methods
    private int get_TotalRewards()
    {
        if(this.pendingRewards == 0)
        {
                this.pendingRewards = 0;
        }
        
        return 1;
    }
    public void Setup(System.Collections.Generic.List<GiftRewardUIParams> rewardsParams, System.Action onAllRewardsRevealed)
    {
        object val_8;
        MPIGiftRewardUI val_28;
        System.Collections.Generic.List<GiftRewardUIParams> val_29;
        System.Collections.Generic.List<GiftRewardUIParams> val_30;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_32;
        var val_33;
        var val_34;
        System.Action<System.Boolean> val_35;
        object val_36;
        var val_37;
        var val_38;
        var val_39;
        val_28 = this;
        val_29 = rewardsParams;
        this.ResetUI();
        mem2[0] = 0;
        val_30 = 0;
        UnityEngine.GameObject val_1 = this.collectionUI.gameObject;
        this.collectionUI.SetActive(value:  false);
        this.onAllRewardsRevealed = onAllRewardsRevealed;
        this.pendingRewards = val_30;
        if(this.collectionUI >= 6)
        {
                SLC.MatchyPics.MPICollectionUI val_2 = this.collectionUI - 5;
            System.Collections.Generic.List<T> val_3 = val_29.GetRange(index:  5, count:  val_2);
            this.pendingRewards = val_29;
            val_29.RemoveRange(index:  5, count:  val_2);
        }
        
        if(val_29 == 3)
        {
                UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  null, y:  null);
            this.upperLayout.spacing = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        }
        
        val_32 = null;
        val_32 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(val_32 < 1)
        {
            goto label_9;
        }
        
        var val_29 = 0;
        goto label_68;
        label_54:
        object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  this.collectionItemPrefab, parent:  0);
        UnityEngine.UI.LayoutElement val_7 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.collectionItemPrefab);
        this.collectionItemPrefab.alpha = null;
        object val_9 = this.collectionItemPrefab.GetComponent<System.Object>();
        mem2[0] = MPICollectionUI.__il2cppRuntimeField_8 + 12;
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SLC.MatchyPics.MPICollection val_11 = GetCollection(imageSetIndex:  val_8 + 8 + 8);
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_33 = val_8 + 8;
        if((val_8 + 8) != 0)
        {
            goto label_26;
        }
        
        val_33 = mem[val_8 + 8];
        val_33 = val_8 + 8;
        if(val_33 == 0)
        {
            goto label_27;
        }
        
        label_26:
        UnityEngine.Sprite val_13 = GetSprite(imageSetIndex:  val_8 + 8 + 8, spriteIndex:  val_8 + 8 + 12);
        val_30 = this.collectionItemPrefab;
        val_30.sprite = -851265360;
        val_28 = val_28;
        object val_14 = this.collectionItemPrefab.GetComponentInChildren<System.Object>();
        MPIGiftRewardUI.GiftRewardRevealInfo val_15 = null;
        val_34 = val_15;
        val_15 = new MPIGiftRewardUI.GiftRewardRevealInfo();
        typeof(MPIGiftRewardUI.GiftRewardRevealInfo).__il2cppRuntimeField_8 = this.collectionItemPrefab;
        val_29 = val_29;
        if((val_8 + 8 + 16) != 0)
        {
                val_30 = mem[this.collectionUI];
            val_30 = this.collectionUI;
            val_35 = null;
            val_36 = val_30;
            val_37 = System.Void MPIGiftRewardUI.<>c__DisplayClass16_0::<Setup>b__2(bool instant);
            val_38 = 1152921511020114880;
        }
        else
        {
                val_35 = null;
            val_36 = val_8;
            val_37 = System.Void MPIGiftRewardUI.<>c__DisplayClass16_1::<Setup>b__3(bool instant);
            val_38 = 1152921511020114880;
        }
        
        val_35 = new System.Action<System.Boolean>(object:  val_36, method:  new IntPtr(3624309888));
        val_32 = val_32;
        typeof(MPIGiftRewardUI.GiftRewardRevealInfo).__il2cppRuntimeField_C = val_35;
        if(val_32 != 0)
        {
            goto label_67;
        }
        
        goto label_38;
        label_68:
        MPIGiftRewardUI.<>c__DisplayClass16_0 val_17 = new MPIGiftRewardUI.<>c__DisplayClass16_0();
        typeof(MPIGiftRewardUI.<>c__DisplayClass16_0).__il2cppRuntimeField_C = val_28;
        if(val_17 <= val_29)
        {
                var val_28 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_28 = val_28 + 0;
        typeof(MPIGiftRewardUI.<>c__DisplayClass16_0).__il2cppRuntimeField_8 = (0 + 0) + 16;
        UnityEngine.Transform val_18 = this.upperLayout.transform;
        val_30 = this.upperLayout;
        if(val_29 >= 2)
        {
                if(this.upperLayout == 4)
        {
            goto label_43;
        }
        
        }
        
        if((val_29 >= 3) && (this.upperLayout == 5))
        {
                label_43:
            UnityEngine.Transform val_19 = this.lowerLayout.transform;
            val_30 = this.lowerLayout;
            UnityEngine.GameObject val_20 = this.lowerLayout.gameObject;
            this.lowerLayout.SetActive(value:  true);
        }
        
        MPIGiftRewardUI.<>c__DisplayClass16_1 val_21 = new MPIGiftRewardUI.<>c__DisplayClass16_1();
        val_8 = val_21;
        if(val_21 != 0)
        {
                typeof(MPIGiftRewardUI.<>c__DisplayClass16_1).__il2cppRuntimeField_C = val_17;
            val_39 = 1152921504953810956;
        }
        else
        {
                mem[12] = val_17;
            val_39 = 12;
        }
        
        if(((0 + 0) + 16 + 8 + 8) == 6)
        {
            goto label_54;
        }
        
        if(((0 + 0) + 16 + 8 + 8) != 0)
        {
            goto label_55;
        }
        
        object val_22 = UnityEngine.Object.Instantiate<System.Object>(original:  this.coinRewardPrefab, parent:  val_30);
        object val_23 = this.coinRewardPrefab.GetComponent<System.Object>();
        this.coinRewardPrefab.Setup(value:  new System.Decimal() {flags = (0 + 0) + 16 + 8 + 20, hi = (0 + 0) + 16 + 8 + 24, lo = (0 + 0) + 16 + 8 + 28, mid = (0 + 0) + 16 + 8 + 32});
        UnityEngine.UI.LayoutElement val_24 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.coinRewardPrefab);
        this.coinRewardPrefab.alpha = null;
        MPIGiftRewardUI.GiftRewardRevealInfo val_25 = null;
        val_34 = val_25;
        val_25 = new MPIGiftRewardUI.GiftRewardRevealInfo();
        val_29 = val_29;
        val_32 = val_32;
        typeof(MPIGiftRewardUI.GiftRewardRevealInfo).__il2cppRuntimeField_8 = this.coinRewardPrefab;
        val_30 = null;
        val_30 = new System.Action<System.Boolean>(object:  346910720, method:  new IntPtr(3624328320));
        val_28 = val_28;
        typeof(MPIGiftRewardUI.GiftRewardRevealInfo).__il2cppRuntimeField_C = val_30;
        if(val_32 != 0)
        {
            goto label_67;
        }
        
        label_38:
        label_67:
        Add(item:  346857472);
        label_55:
        val_29 = val_29 + 1;
        if(val_29 < (rewardsParams + 12))
        {
            goto label_68;
        }
        
        label_9:
        mem[1152921512526169708] = val_32;
        if(mem[1152921512526169716] == false)
        {
                mem[1152921512526169716] = val_28;
            this.OnClick_RevealReward();
        }
        
        UnityEngine.Events.UnityAction val_27 = new UnityEngine.Events.UnityAction(object:  -670611904, method:  new IntPtr(3624330368));
        mem[1152921512526169680] + 172.AddListener(call:  162246656);
        mem[1152921512526169716] = 1;
        return;
        label_27:
    }
    private void ResetUI()
    {
        UnityEngine.GameObject val_1 = this.lowerLayout.gameObject;
        this.lowerLayout.SetActive(value:  false);
    }
    private void OnClick_RevealReward()
    {
        System.Collections.Generic.List<GiftRewardRevealInfo> val_11;
        if(this.currentReward != 0)
        {
                this.StopCoroutine(routine:  this.rewardCoroutine);
            if(this.currentReward.rewardAction != 0)
        {
                this.currentReward.rewardAction.Invoke(obj:  true);
        }
        
            this.OnRewardRevealed();
        }
        
        if(this == 0)
        {
                return;
        }
        
        if(this == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_11 = this.rewardsToReveal;
        this.currentReward = 2621443;
        bool val_1 = val_11.Remove(item:  2621443);
        if(this.TotalRewards != 0)
        {
                string val_3 = Localization.Localize(key:  -672037616, defaultValue:  -672037728, useSingularKey:  false);
            int val_4 = this.TotalRewards;
            string val_5 = System.String.Format(format:  -672037616, arg0:  13152256);
            val_11 = "tap_to_open_num_upper";
            if(this.tapToOpen != 0)
        {
            goto label_13;
        }
        
        }
        else
        {
                UnityEngine.Transform val_6 = this.tapToOpen.transform;
            UnityEngine.Transform val_7 = this.tapToOpen.parent;
            UnityEngine.GameObject val_8 = this.tapToOpen.gameObject;
            this.tapToOpen.SetActive(value:  false);
        }
        
        label_13:
        System.Collections.IEnumerator val_9 = this.StartRevealingReward(reward:  this.currentReward);
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  -670292672);
        this.rewardCoroutine = this;
    }
    private System.Collections.IEnumerator StartRevealingReward(MPIGiftRewardUI.GiftRewardRevealInfo reward)
    {
        if((new MPIGiftRewardUI.<StartRevealingReward>d__21(<>1__state:  0)) != 0)
        {
                typeof(MPIGiftRewardUI.<StartRevealingReward>d__21).__il2cppRuntimeField_18 = this;
        }
        else
        {
                mem[24] = this;
        }
        
        typeof(MPIGiftRewardUI.<StartRevealingReward>d__21).__il2cppRuntimeField_14 = reward;
    }
    private void OnRewardRevealed()
    {
        if(((true == 0) && (this.pendingRewards != 0)) && (this.pendingRewards >= 1))
        {
                System.Collections.IEnumerator val_1 = this.RemoveAndLoadRewards();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -670007232);
        }
        
        if(this.TotalRewards != 0)
        {
                return;
        }
        
        if((R4 + 56) == 0)
        {
                return;
        }
        
        R4 + 56.Invoke();
    }
    private System.Collections.IEnumerator RemoveAndLoadRewards()
    {
        MPIGiftRewardUI.<RemoveAndLoadRewards>d__23 val_1 = new MPIGiftRewardUI.<RemoveAndLoadRewards>d__23(<>1__state:  0);
        typeof(MPIGiftRewardUI.<RemoveAndLoadRewards>d__23).__il2cppRuntimeField_10 = this;
    }
    private void EnableRewardUI(GiftRewardType type)
    {
        UnityEngine.GameObject val_1 = this.coinAnim.gameObject;
        this.coinAnim.SetActive(value:  this.coinAnim >> 5);
        UnityEngine.GameObject val_3 = this.collectionUI.gameObject;
        this.collectionUI.SetActive(value:  (type - 6) >> 5);
    }
    public MPIGiftRewardUI()
    {
    
    }
    private void <Setup>b__16_0()
    {
        this.OnClick_RevealReward();
    }

}
