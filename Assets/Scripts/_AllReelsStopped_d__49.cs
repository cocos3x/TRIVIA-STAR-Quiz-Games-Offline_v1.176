using UnityEngine;
private sealed class RESSlotUIManager.<AllReelsStopped>d__49 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RestaurantRivals.RESSlotUIManager <>4__this;
    private RestaurantRivals.RESPayout <payout>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESSlotUIManager.<AllReelsStopped>d__49(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_19;
        RestaurantRivals.RESSpinInfoController val_59;
        object val_62;
        int val_63;
        var val_64;
        if((this.<>1__state) <= 14)
        {
                var val_1 = 5905316 + (5905316 + (this.<>1__state) << 2);
            if((this.<>1__state) == 14)
        {
                5905316 + (this.<>1__state) << 2 = (5905316 + (this.<>1__state) << 2) & ((IP) >> 5905316 + (this.<>1__state) << 2);
            5905316 + (this.<>1__state) << 2 = (5905316 + (this.<>1__state) << 2) & 139162;
            5905316 + (this.<>1__state) << 2 = (5905316 + (this.<>1__state) << 2) & ((R8) >> 12);
            5905316 + (this.<>1__state) << 2 = (5905316 + (this.<>1__state) << 2) & ((IP) >> R6);
            5905316 + (this.<>1__state) << 2 = (5905316 + (this.<>1__state) << 2) & ((5905316 + (this.<>1__state) << 2) >> 16);
            5905316 + (this.<>1__state) << 2 = (5905316 + (this.<>1__state) << 2) & (35625516 >> R8);
            5905316 + (this.<>1__state) << 2 = (5905316 + (this.<>1__state) << 2) & (((int)R8) >> 1152921513857412840);
            mem2[0] = (((((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__state) << 2) & 139162) & (R8) >> 12) & (IP) >> R6) & ((int)((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__st + 35625516;
            ((((((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__state) << 2) & 139162) & (R8) >> 12) & (IP) >> R6) & ((int)((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__st + 35625516) & (((int)IP) >> 26) = (((((((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__state) << 2) & 139162) & (R8) >> 12) & (IP) >> R6) & ((int)((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__st + 35625516) & (((int)IP) >> 26)) & ((R8) << 27);
            ((((((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__state) << 2) & 139162) & (R8) >> 12) & (IP) >> R6) & ((int)((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__st + 35625516) & (((int)IP) >> 26) = (((((((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__state) << 2) & 139162) & (R8) >> 12) & (IP) >> R6) & ((int)((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__st + 35625516) & (((int)IP) >> 26)) & ((IP) << 31);
            5905316 = (((((((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__state) << 2) & 139162) & (R8) >> 12) & (IP) >> R6) & ((int)((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__st + 35625516) & (((int)IP) >> 26)) & ((((((((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__state) << 2) & 139162) & (R8) >> 12) & (IP) >> R6) & ((int)((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__st + 35625516) & (((int)IP) >> 26)) >> 32);
            5905316 = (((((((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__state) << 2) & 139162) & (R8) >> 12) & (IP) >> R6) & ((int)((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__st + 35625516) & (((int)IP) >> 26)) & (((int)IP) >> 1);
            5905316 = (((((((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__state) << 2) & 139162) & (R8) >> 12) & (IP) >> R6) & ((int)((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__st + 35625516) & (((int)IP) >> 26)) & ((((((((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__state) << 2) & 139162) & (R8) >> 12) & (IP) >> R6) & ((int)((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__st + 35625516) & (((int)IP) >> 26)) << 5905316);
            5905316 = (((((((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__state) << 2) & 139162) & (R8) >> 12) & (IP) >> R6) & ((int)((((5905316 + (this.<>1__state) << 2 & (IP) >> 5905316 + (this.<>1__st + 35625516) & (((int)IP) >> 26)) & 1140016512;
        }
        
            this.<>1__state = 0;
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  this.<>4__this, aName:  -1275408384);
            this.<>4__this.<OnSpinConclusion>k__BackingField = true;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.<payout>5__2 = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 56;
            var val_4 = 5905612 + 4;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  660600048, clipIndex:  (this.<payout>5__2) - 1);
            Player val_8 = App.Player;
            RestaurantRivals.RESLevelDef val_9 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            decimal val_11 = new System.Decimal(value:  0);
            string val_12 = RestaurantRivals.RESGameEconHelper.FormatNumberWithLimit(num:  new System.Decimal() {flags = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 64, hi = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 68, lo = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 72, mid = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 76}, numLimit:  new System.Decimal() {flags = val_11.flags, hi = val_11.hi, lo = val_11.lo, mid = val_11.flags});
            this.<>4__this.spinInfoController.ShowPayoutInfo(payout:  public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 64);
            val_59 = this.<>4__this.spinInfoController;
            twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_15 = 2621448 * SpinBet;
            decimal val_16 = System.Decimal.op_Implicit(value:  660631208);
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_59.ShowCoinGetEffects(basePayout:  new System.Decimal() {mid = val_19}, payout:  new System.Decimal() {flags = mem[(public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 64) + (0)], hi = mem[(public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 64) + (4)], lo = mem[(public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 64) + (8)], mid = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 76});
            UnityEngine.WaitForSeconds val_20 = null;
            val_62 = val_20;
            val_20 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_63 = 8;
        }
        else
        {
                val_64 = 0;
            return (bool)val_64;
        }
        
        this.<>1__state = ;
        this.<>2__current = ;
        val_64 = 1;
        return (bool)val_64;
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
