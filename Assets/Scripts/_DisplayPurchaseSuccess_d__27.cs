using UnityEngine;
private sealed class WGStore_DicePacksPopup.<DisplayPurchaseSuccess>d__27 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public PurchaseModel purchase;
    public WGStore_DicePacksPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGStore_DicePacksPopup.<DisplayPurchaseSuccess>d__27(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        int val_15;
        int val_16;
        int val_17;
        int val_18;
        int val_32;
        object val_33;
        var val_34;
        var val_35;
        var val_38;
        float val_40;
        var val_41;
        int val_44;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_32 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_32;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForEndOfFrame val_1 = null;
        val_33 = val_1;
        val_1 = new UnityEngine.WaitForEndOfFrame();
        val_32 = 1;
        this.<>1__state = val_32;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        bool val_2 = this.purchase.id.Contains(value:  -1252680496);
        val_34 = 0;
        decimal val_3 = Credits;
        val_35 = null;
        val_35 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                Player val_5 = App.Player;
            decimal val_6 = Credits;
            decimal val_7 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1014477640, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
            Player val_8 = App.Player;
            this.<>4__this.AnimateCoins(fromAmount:  new System.Decimal() {mid = val_9}, toAmount:  new System.Decimal() {mid = 256}, actionOnComplete:  0);
            val_34 = 1;
        }
        
        decimal val_10 = PetsFood;
        val_38 = null;
        val_38 = null;
        val_40 = 0.9f;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                if(val_2 == true)
        {
                val_40 = 1072064102;
        }
        
            Player val_13 = App.Player;
            decimal val_14 = PetsFood;
            int val_30 = val_17;
            Player val_20 = App.Player;
            val_30 = 1 - (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_15, hi = val_16, lo = val_30, mid = val_18}));
            this.<>4__this.AnimatePurchase(animControl:  this.<>4__this + 32, fromAmount:  val_30, toAmount:  1, actionOnComplete:  0, delay:  1.8f);
            val_34 = 1;
        }
        
        val_32 = 0;
        decimal val_21 = DiceRolls;
        val_41 = null;
        val_41 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
        {
                return (bool)val_32;
        }
        
        if(val_2 == true)
        {
                0f = 1063675494;
        }
        
        int val_23 = SnakesAndLaddersEventHandler.<Instance>k__BackingField.GetDiceBalance();
        val_40 = 0f + val_40;
        if(val_34 == 0)
        {
            goto label_39;
        }
        
        decimal val_24 = DiceRolls;
        val_44 = val_23 - (System.Decimal.op_Explicit(value:  new System.Decimal()));
        goto label_42;
        label_2:
        this.<>1__state = 0;
        UnityEngine.WaitForEndOfFrame val_26 = null;
        val_33 = val_26;
        val_26 = new UnityEngine.WaitForEndOfFrame();
        val_32 = 1;
        this.<>1__state = 2;
        label_4:
        this.<>2__current = val_33;
        return (bool)val_32;
        label_39:
        decimal val_27 = DiceRolls;
        System.Action val_29 = new System.Action(object:  this.<>4__this, method:  this.<>4__this + 264);
        val_44 = val_23 - (System.Decimal.op_Explicit(value:  new System.Decimal()));
        label_42:
        this.<>4__this.AnimatePurchase(animControl:  this.<>4__this + 36, fromAmount:  val_44, toAmount:  val_23, actionOnComplete:  null, delay:  0.9f);
        return (bool)val_32;
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
