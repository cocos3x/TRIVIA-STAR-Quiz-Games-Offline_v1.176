using UnityEngine;
public class WGGiftRewardPopup : MonoBehaviour
{
    // Fields
    protected UnityEngine.UI.Button closedGiftBox;
    private UnityEngine.UI.Text tapToOpen;
    private UnityEngine.GameObject rewardsGroup;
    protected GiftRewardUI giftRewardUi;
    public System.Action OnGiftBoxOpened;
    
    // Methods
    public virtual void Setup(System.Collections.Generic.List<GiftReward> rewards, GiftRewardSource rewardSource)
    {
        this.SetupUI(rewardCount:  rewards);
    }
    public void Setup(GiftRewardSource rewardSource)
    {
        WADGiftRewardManager val_1 = WGGiftRewardManager<WADGiftRewardManager>.Instance;
        System.Collections.Generic.List<GiftReward> val_2 = GetRewards(rewardSource:  rewardSource);
        this.SetupUI(rewardCount:  public static WADGiftRewardManager WGGiftRewardManager<WADGiftRewardManager>::get_Instance().__il2cppRuntimeField_C);
    }
    protected void SetupUI(int rewardCount)
    {
        string val_1 = Localization.Localize(key:  -672037616, defaultValue:  -672037728, useSingularKey:  false);
        string val_2 = System.String.Format(format:  -672037616, arg0:  13152256);
        UnityEngine.GameObject val_3 = this.tapToOpen.gameObject;
        this.tapToOpen.SetActive(value:  true);
        UnityEngine.GameObject val_4 = this.closedGiftBox.gameObject;
        this.closedGiftBox.SetActive(value:  true);
        this.rewardsGroup.SetActive(value:  false);
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -32009584, method:  new IntPtr(4262932688));
        this.closedGiftBox.m_OnClick.AddListener(call:  162246656);
    }
    protected virtual void SetupRewards(System.Collections.Generic.List<GiftReward> rewards, GiftRewardSource rewardSource, bool postCollectLogic = False)
    {
        var val_5;
        WGGiftRewardPopup val_49;
        var val_50;
        var val_51;
        int val_52;
        int val_53;
        var val_54;
        var val_55;
        int val_56;
        var val_57;
        int val_58;
        int val_59;
        var val_72;
        var val_73;
        int val_74;
        int val_75;
        System.Delegate val_76;
        val_49 = this;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                typeof(WGGiftRewardPopup.<>c__DisplayClass8_0).__il2cppRuntimeField_8 = postCollectLogic;
            val_50 = 1152921504996036616;
            WGGiftRewardPopup.<>c__DisplayClass8_0.__il2cppRuntimeField_name.__il2cppRuntimeField_8 = rewardSource;
            WGGiftRewardPopup.<>c__DisplayClass8_0.__il2cppRuntimeField_name.__il2cppRuntimeField_4 = rewards;
        }
        else
        {
                mem[8] = postCollectLogic;
            val_50 = 12;
            mem[12] = rewards;
            mem[16] = rewardSource;
        }
        
        typeof(WGGiftRewardPopup.<>c__DisplayClass8_0).__il2cppRuntimeField_14 = val_49;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(val_1 != 0)
        {
                typeof(WGGiftRewardPopup.<>c__DisplayClass8_0).__il2cppRuntimeField_18 = null;
        }
        else
        {
                mem[24] = null;
        }
        
        List.Enumerator<T> val_3 = GetEnumerator();
        label_126:
        if(MoveNext() == false)
        {
            goto label_6;
        }
        
        val_51 = null;
        var val_6 = val_5 + 24;
        val_51 = null;
        val_53 = mem[(val_5 + 24) + (8)];
        if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = val_5 + 20, hi = mem[(val_5 + 24) + (0)], lo = mem[(val_5 + 24) + (4)], mid = val_53}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == true)
        {
            goto label_126;
        }
        
        if(new GiftRewardUIParams() != 0)
        {
                typeof(GiftRewardUIParams).__il2cppRuntimeField_8 = val_5;
            val_54 = val_5;
        }
        else
        {
                mem[8] = val_5;
            val_54 = mem[8];
            if(val_54 == 0)
        {
                val_54 = 0;
        }
        
        }
        
        if(mem[8] > 5)
        {
            goto label_51;
        }
        
        var val_9 = 6829344 + (6829344 + (val_5) << 2);
        if(mem[8] == 5)
        {
                6829344 + (val_5) << 2 = (6829344 + (val_5) << 2) & (1152921504617017344 << (6829344 + (val_5) << 2));
            6829344 + (val_5) << 2 = (6829344 + (val_5) << 2) & 0;
            6829344 + (val_5) << 2 = 247138688946816;
            mem[247138688946816] = 2011955444;
            36175988 = 0;
        }
        
        if(mem[8] != 0)
        {
                Player val_11 = App.Player;
            var val_49 = 0;
            val_55 = 52;
            val_49 = val_49 + 64;
            val_56 = mem[val_5 + 24];
            val_56 = val_5 + 24;
            val_52 = mem[val_5 + 28];
            val_52 = val_5 + 28;
            val_57 = mem[val_5 + 32];
            val_57 = val_5 + 32;
            val_58 = mem[(0 + 64) + (0)];
            val_57 = val_57;
            val_56 = val_56;
            val_59 = mem[(0 + 64) + (4)];
            val_55 = val_55;
            val_49 = val_49;
            decimal val_12 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -31871472, hi = 52, lo = val_58, mid = val_59}, d2:  new System.Decimal() {flags = mem[(0 + 64) + (8)], hi = val_5 + 20, lo = val_56, mid = val_52});
        }
        else
        {
                Player val_28 = App.Player;
        }
        
        if(mem[8] == 0)
        {
            goto label_82;
        }
        
        Player val_30 = App.Player;
        if(0 != 0)
        {
            goto label_118;
        }
        
        goto label_118;
        label_82:
        Player val_41 = App.Player;
        var val_51 = 0;
        var val_42 = val_5 + 20;
        val_73 = 52;
        val_51 = val_51 + 64;
        val_75 = mem[(0 + 64) + (4)];
        val_72 = mem[(val_5 + 20) + (12)];
        val_74 = mem[(0 + 64) + (0)];
        val_73 = val_73;
        decimal val_43 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -31871472, hi = 52, lo = val_74, mid = val_75}, d2:  new System.Decimal() {flags = mem[(0 + 64) + (8)], hi = mem[(val_5 + 20) + (0)], lo = mem[(val_5 + 20) + (4)], mid = mem[(val_5 + 20) + (8)]});
        label_118:
        label_51:
        Add(item:  375664640);
        goto label_126;
        label_6:
        Dispose();
        System.Action val_47 = new System.Action(object:  389189632, method:  new IntPtr(4263082880));
        val_76 = this.OnGiftBoxOpened;
        System.Delegate val_48 = System.Delegate.Combine(a:  val_76, b:  7454720);
        if(val_76 != 0)
        {
                if(null == null)
        {
            goto label_128;
        }
        
        }
        
        val_76 = 0;
        label_128:
        this.OnGiftBoxOpened = val_76;
    }
    private void OnClick_GiftBox()
    {
        this.closedGiftBox.interactable = false;
        UnityEngine.GameObject val_1 = this.closedGiftBox.gameObject;
        this.closedGiftBox.SetActive(value:  false);
        this.rewardsGroup.SetActive(value:  true);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -265729808, clipIndex:  0);
        if(this.OnGiftBoxOpened == 0)
        {
                return;
        }
        
        this.OnGiftBoxOpened.Invoke();
    }
    protected virtual void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -31590336, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGGiftRewardPopup()
    {
    
    }

}
