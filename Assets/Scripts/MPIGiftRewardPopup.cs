using UnityEngine;
public class MPIGiftRewardPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button closedGiftBox;
    private UnityEngine.UI.Text tapToOpen;
    private UnityEngine.GameObject rewardsGroup;
    private MPIGiftRewardUI giftRewardUi;
    public System.Action OnGiftBoxOpened;
    
    // Methods
    public void Setup(System.Collections.Generic.List<GiftReward> rewards, GiftRewardSource rewardSource)
    {
        var val_11;
        var val_25;
        var val_26;
        var val_27;
        System.Delegate val_28;
        object val_1 = new System.Object();
        typeof(MPIGiftRewardPopup.<>c__DisplayClass5_0).__il2cppRuntimeField_8 = this;
        string val_2 = Localization.Localize(key:  -672037616, defaultValue:  -672037728, useSingularKey:  false);
        string val_3 = System.String.Format(format:  -672037616, arg0:  13152256);
        UnityEngine.GameObject val_4 = this.tapToOpen.gameObject;
        this.tapToOpen.SetActive(value:  true);
        UnityEngine.GameObject val_5 = this.closedGiftBox.gameObject;
        this.closedGiftBox.SetActive(value:  true);
        this.rewardsGroup.SetActive(value:  false);
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -671988928, method:  new IntPtr(3622950272));
        this.closedGiftBox.m_OnClick.AddListener(call:  162246656);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_7 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        typeof(MPIGiftRewardPopup.<>c__DisplayClass5_0).__il2cppRuntimeField_C = null;
        Player val_8 = App.Player;
        List.Enumerator<T> val_9 = GetEnumerator();
        val_25 = val_1;
        label_34:
        if(MoveNext() == false)
        {
            goto label_14;
        }
        
        GiftRewardUIParams val_12 = new GiftRewardUIParams();
        if(val_12 != 0)
        {
                val_26 = val_12;
            val_27 = val_11;
            typeof(GiftRewardUIParams).__il2cppRuntimeField_8 = val_11;
        }
        else
        {
                mem[8] = val_11;
            val_26 = 8;
            val_27 = mem[8];
        }
        
        if((val_11 + 8) == 0)
        {
            goto label_18;
        }
        
        if(((val_11 + 8) != 6) || ((val_11 + 12 + 16) == 0))
        {
            goto label_23;
        }
        
        typeof(GiftRewardUIParams).__il2cppRuntimeField_C = 52;
        typeof(GiftRewardUIParams).__il2cppRuntimeField_10 = 7.286752E-44f;
        typeof(GiftRewardUIParams).__il2cppRuntimeField_14 = 256;
        typeof(GiftRewardUIParams).__il2cppRuntimeField_18 = 3.587324E-43f;
        var val_13 = val_11 + 20;
        decimal val_14 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -672001008, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = mem[(val_11 + 20) + (0)], lo = mem[(val_11 + 20) + (4)], mid = mem[(val_11 + 20) + (8)]});
        var val_15 = val_11 + 20;
        val_25 = val_1;
        decimal val_16 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -672001024, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = mem[(val_11 + 20) + (0)], lo = mem[(val_11 + 20) + (4)], mid = mem[(val_11 + 20) + (8)]});
        goto label_28;
        label_18:
        typeof(GiftRewardUIParams).__il2cppRuntimeField_C = 52;
        typeof(GiftRewardUIParams).__il2cppRuntimeField_10 = 7.286752E-44f;
        typeof(GiftRewardUIParams).__il2cppRuntimeField_14 = 256;
        typeof(GiftRewardUIParams).__il2cppRuntimeField_18 = 3.587324E-43f;
        decimal val_17 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -672001008, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = val_11 + 20, lo = val_11 + 24, mid = val_11 + 28});
        var val_18 = val_11 + 20;
        val_25 = val_1;
        decimal val_19 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -672001024, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = mem[(val_11 + 20) + (0)], lo = mem[(val_11 + 20) + (4)], mid = mem[(val_11 + 20) + (8)]});
        label_28:
        label_23:
        Add(item:  375664640);
        goto label_34;
        label_14:
        Dispose();
        System.Action val_23 = new System.Action(object:  346697728, method:  new IntPtr(3622953344));
        val_28 = mem[1152921512524792668];
        System.Delegate val_24 = System.Delegate.Combine(a:  val_28, b:  7454720);
        if(val_28 != 0)
        {
                if(val_28 == null)
        {
            goto label_36;
        }
        
        }
        
        val_28 = 0;
        label_36:
        mem[1152921512524792668] = val_28;
    }
    public void Setup(GiftRewardSource rewardSource)
    {
        var val_11;
        float val_20;
        var val_21;
        var val_22;
        int val_23;
        int val_24;
        System.Delegate val_25;
        object val_1 = null;
        val_20 = val_1;
        val_1 = new System.Object();
        typeof(MPIGiftRewardPopup.<>c__DisplayClass6_0).__il2cppRuntimeField_8 = this;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        string val_3 = Localization.Localize(key:  -672037616, defaultValue:  -672037728, useSingularKey:  false);
        string val_4 = System.String.Format(format:  -672037616, arg0:  13152256);
        UnityEngine.GameObject val_5 = this.tapToOpen.gameObject;
        this.tapToOpen.SetActive(value:  true);
        UnityEngine.GameObject val_6 = this.closedGiftBox.gameObject;
        this.closedGiftBox.SetActive(value:  true);
        this.rewardsGroup.SetActive(value:  false);
        UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  -671814464, method:  new IntPtr(3622950272));
        this.closedGiftBox.m_OnClick.AddListener(call:  162246656);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_8 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        typeof(MPIGiftRewardPopup.<>c__DisplayClass6_0).__il2cppRuntimeField_C = null;
        List.Enumerator<T> val_9 = GetEnumerator();
        label_29:
        if(MoveNext() == false)
        {
            goto label_11;
        }
        
        val_21 = null;
        val_21 = null;
        if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = val_11 + 20, hi = val_11 + 24, lo = val_11 + 28, mid = val_11 + 32}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == true)
        {
            goto label_29;
        }
        
        if(new GiftRewardUIParams() != 0)
        {
                typeof(GiftRewardUIParams).__il2cppRuntimeField_8 = val_11;
            val_22 = val_11;
        }
        else
        {
                mem[8] = val_11;
            val_22 = mem[8];
            if(val_22 == 0)
        {
                val_22 = 0;
        }
        
        }
        
        if(mem[8] == 0)
        {
                Player val_14 = App.Player;
            Player val_15 = App.Player;
            var val_20 = 0;
            var val_16 = val_11 + 24;
            val_20 = val_20 + 64;
            val_24 = mem[(0 + 64) + (4)];
            val_23 = mem[(0 + 64) + (0)];
            decimal val_17 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -671826544, hi = 52, lo = val_23, mid = val_24}, d2:  new System.Decimal() {flags = mem[(0 + 64) + (8)], hi = val_11 + 20, lo = mem[(val_11 + 24) + (0)], mid = mem[(val_11 + 24) + (4)]});
            val_20 = val_20;
        }
        
        Add(item:  375664640);
        goto label_29;
        label_11:
        Dispose();
        System.Action val_18 = new System.Action(object:  346750976, method:  new IntPtr(3623127808));
        val_25 = mem[1152921512524967132];
        System.Delegate val_19 = System.Delegate.Combine(a:  val_25, b:  7454720);
        if(val_25 != 0)
        {
                if(val_25 == null)
        {
            goto label_31;
        }
        
        }
        
        val_25 = 0;
        label_31:
        mem[1152921512524967132] = val_25;
    }
    private void OnClick_GiftBox()
    {
        this.closedGiftBox.interactable = false;
        UnityEngine.GameObject val_1 = this.closedGiftBox.gameObject;
        this.closedGiftBox.SetActive(value:  false);
        this.rewardsGroup.SetActive(value:  true);
        if(this.OnGiftBoxOpened == 0)
        {
                return;
        }
        
        this.OnGiftBoxOpened.Invoke();
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -671529024, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public MPIGiftRewardPopup()
    {
    
    }

}
