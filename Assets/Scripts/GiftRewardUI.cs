using UnityEngine;
public class GiftRewardUI : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text tapToOpen;
    protected UnityEngine.UI.Button tapArea;
    protected UnityEngine.UI.GridLayoutGroup upperLayout;
    private int maxRevealedRewards;
    private UnityEngine.GameObject coinRewardPrefab;
    private UnityEngine.GameObject foodRewardPrefab;
    private UnityEngine.GameObject petCardRewardPrefab;
    private UnityEngine.GameObject petCoinsRewardPrefab;
    private UnityEngine.GameObject diceRollPrefab;
    protected GridCoinCollectAnimationInstantiator coinAnim;
    private WADPetFoodAnimationInstantiator foodAnim;
    private DiceRollAnimationInstantiator diceAnim;
    public System.Collections.Generic.List<GiftRewardRevealInfo> rewardsToReveal;
    private System.Collections.Generic.List<UnityEngine.GameObject> revealedRewardObjects;
    protected bool waitingForCollectAnim;
    
    // Methods
    public virtual void Setup(System.Collections.Generic.List<GiftRewardUIParams> rewardsParams, System.Action onAllRewardsRevealed)
    {
        mem2[0] = 0;
        this.rewardsToReveal = this;
        this.FinishSetup(onAllRewardsRevealed:  onAllRewardsRevealed);
    }
    protected virtual System.Collections.Generic.List<GiftRewardRevealInfo> CreateRewardReveals(System.Collections.Generic.List<GiftRewardUIParams> rewardsParams, System.Action onAllRewardsRevealed)
    {
        var val_33;
        float val_34;
        System.Action val_35;
        var val_36;
        label_50:
        if(0 >= (new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()))
        {
                return;
        }
        
        typeof(GiftRewardUI.<>c__DisplayClass16_0).__il2cppRuntimeField_C = this;
        if(new System.Object() <= 0)
        {
                var val_34 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_34 = val_34 + 0;
        typeof(GiftRewardUI.<>c__DisplayClass16_0).__il2cppRuntimeField_8 = (0 + 0) + 16;
        UnityEngine.Transform val_3 = this.upperLayout.transform;
        object val_4 = new System.Object();
        if(((0 + 0) + 16 + 8 + 8) <= 4)
        {
                var val_5 = 6507820 + (6507820 + ((0 + 0) + 16 + 8 + 8) << 2);
            if(((0 + 0) + 16 + 8 + 8) == 4)
        {
                6507820 + ((0 + 0) + 16 + 8 + 8) << 2 = (6507820 + ((0 + 0) + 16 + 8 + 8) << 2) & (((0 + 0) + 16 + 8) << (6507820 + ((0 + 0) + 16 + 8 + 8) << 2));
            6507820 + ((0 + 0) + 16 + 8 + 8) << 2 = (6507820 + ((0 + 0) + 16 + 8 + 8) << 2) & (((int)IP) >> 6507820);
            6507820 + ((0 + 0) + 16 + 8 + 8) << 2 = (6507820 + ((0 + 0) + 16 + 8 + 8) << 2) & (((0 + 0) + 16 + 8) >> 5);
            6507820 + ((0 + 0) + 16 + 8 + 8) << 2 = (6507820 + ((0 + 0) + 16 + 8 + 8) << 2) & (((IP) << (32-7)) | ((IP) << 7));
            6507820 + ((0 + 0) + 16 + 8 + 8) << 2 = (6507820 + ((0 + 0) + 16 + 8 + 8) << 2) & 1466608;
        }
        
            object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  this.coinRewardPrefab, parent:  this.upperLayout);
            object val_7 = this.coinRewardPrefab.GetComponent<System.Object>();
            this.coinRewardPrefab.Setup(value:  new System.Decimal() {flags = (0 + 0) + 16 + 8 + 20, hi = (0 + 0) + 16 + 8 + 24, lo = (0 + 0) + 16 + 8 + 28, mid = (0 + 0) + 16 + 8 + 32});
            UnityEngine.UI.LayoutElement val_8 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.coinRewardPrefab);
            this.coinRewardPrefab.alpha = null;
            object val_9 = null;
            val_33 = val_9;
            val_9 = new System.Object();
            val_34 = null;
            typeof(GiftRewardRevealInfo).__il2cppRuntimeField_8 = this.coinRewardPrefab;
            val_35 = null;
            val_36 = 1152921512930726384;
             = new System.Action(object:  375451648, method:  new IntPtr(4028918256));
            typeof(GiftRewardRevealInfo).__il2cppRuntimeField_C = ;
            Add(item:  375717888);
        }
        
        var val_35 = 0;
        val_35 = val_35 + 1;
        goto label_50;
    }
    protected void FinishSetup(System.Action onAllRewardsRevealed)
    {
        if(new System.Object() != 0)
        {
                typeof(GiftRewardUI.<>c__DisplayClass17_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(GiftRewardUI.<>c__DisplayClass17_0).__il2cppRuntimeField_C = onAllRewardsRevealed;
        string val_2 = Localization.Localize(key:  -672037616, defaultValue:  -672037728, useSingularKey:  false);
        string val_3 = System.String.Format(format:  -672037616, arg0:  13152256);
        this.OnClick_RevealReward(onAllRewardsRevealed:  typeof(GiftRewardUI.<>c__DisplayClass17_0).__il2cppRuntimeField_C);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  375558144, method:  new IntPtr(4029070192));
        this.tapArea.m_OnClick.AddListener(call:  162246656);
    }
    public void OnClick_RevealReward(System.Action onAllRewardsRevealed)
    {
        if(true == 0)
        {
                return;
        }
        
        this.tapArea.interactable = false;
        if(this.tapArea == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((this.rewardsToReveal.Remove(item:  2621443)) != false)
        {
                string val_2 = Localization.Localize(key:  -672037616, defaultValue:  -672037728, useSingularKey:  false);
            string val_3 = System.String.Format(format:  -672037616, arg0:  13152256);
            if(this.tapToOpen != 0)
        {
            goto label_11;
        }
        
        }
        else
        {
                UnityEngine.Transform val_4 = this.tapToOpen.transform;
            UnityEngine.Transform val_5 = this.tapToOpen.parent;
            UnityEngine.GameObject val_6 = this.tapToOpen.gameObject;
            this.tapToOpen.SetActive(value:  false);
        }
        
        label_11:
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -265729808, clipIndex:  0);
        System.Collections.IEnumerator val_8 = this.StartRevealingReward(reward:  2621443, onAllRewardsRevealed:  onAllRewardsRevealed);
        UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  -265705712);
    }
    private System.Collections.IEnumerator StartRevealingReward(GiftRewardRevealInfo reward, System.Action onAllRewardsRevealed)
    {
        typeof(GiftRewardUI.<StartRevealingReward>d__19).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(GiftRewardUI.<StartRevealingReward>d__19).__il2cppRuntimeField_10 = this;
            typeof(GiftRewardUI.<StartRevealingReward>d__19).__il2cppRuntimeField_14 = reward;
        }
        else
        {
                mem[16] = this;
            mem[20] = reward;
        }
        
        typeof(GiftRewardUI.<StartRevealingReward>d__19).__il2cppRuntimeField_18 = onAllRewardsRevealed;
    }
    public GiftRewardUI()
    {
        this.maxRevealedRewards = 4;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.revealedRewardObjects = null;
    }
    private void <CreateRewardReveals>b__16_6()
    {
        this.waitingForCollectAnim = false;
    }
    private void <CreateRewardReveals>b__16_7()
    {
        this.waitingForCollectAnim = false;
    }
    private void <CreateRewardReveals>b__16_8()
    {
        this.waitingForCollectAnim = false;
    }
    private void <CreateRewardReveals>b__16_9()
    {
        this.waitingForCollectAnim = false;
    }

}
