using UnityEngine;
[Serializable]
private sealed class RESRaidAttackScreenUI.<>c__11<T>
{
    // Fields
    public static readonly RestaurantRivals.RESRaidAttackScreenUI.<>c__11<T> <>9;
    public static System.Action <>9__11_2;
    
    // Methods
    private static RESRaidAttackScreenUI.<>c__11<T>()
    {
        var val_1;
        var val_2;
        val_1 = mem[__RuntimeMethodHiddenParam + 12 + 186];
        val_1 = __RuntimeMethodHiddenParam + 12 + 186;
        val_2 = __RuntimeMethodHiddenParam + 12;
        if(val_1 == 1)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 12];
            val_2 = __RuntimeMethodHiddenParam + 12;
            val_1 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 186;
        }
        
        mem2[0] = __RuntimeMethodHiddenParam + 12 + 96;
    }
    public RESRaidAttackScreenUI.<>c__11<T>()
    {
        if(this != 0)
        {
                return;
        }
    
    }
    internal void <ShowScreen>b__11_2()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_2 = public static RestaurantRivals.RESRaidAttackScreenUI MonoSingleton<RestaurantRivals.RESRaidAttackScreenUI>::get_Instance().__il2cppRuntimeField_C.gameObject;
        if((public static RestaurantRivals.RESRaidAttackScreenUI MonoSingleton<RestaurantRivals.RESRaidAttackScreenUI>::get_Instance().__il2cppRuntimeField_C.activeSelf) != true)
        {
                public static RestaurantRivals.RESRaidAttackScreenUI MonoSingleton<RestaurantRivals.RESRaidAttackScreenUI>::get_Instance().__il2cppRuntimeField_C.SetActive(value:  true);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static RestaurantRivals.RESRaidAttackScreenUI MonoSingleton<RestaurantRivals.RESRaidAttackScreenUI>::get_Instance().__il2cppRuntimeField_14.Push(item:  public static RestaurantRivals.RESRaidAttackScreenUI MonoSingleton<RestaurantRivals.RESRaidAttackScreenUI>::get_Instance().__il2cppRuntimeField_C);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Invoke(methodName:  605996016, time:  null);
    }

}
