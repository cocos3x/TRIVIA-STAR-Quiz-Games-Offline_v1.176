using UnityEngine;
[Serializable]
private sealed class CategoryPacksMenuUI.<>c__10<T>
{
    // Fields
    public static readonly CategoryPacksMenuUI.<>c__10<T> <>9;
    public static System.Action <>9__10_0;
    
    // Methods
    private static CategoryPacksMenuUI.<>c__10<T>()
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
    public CategoryPacksMenuUI.<>c__10<T>()
    {
        if(this != 0)
        {
                return;
        }
    
    }
    internal void <ShowScreen>b__10_0()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_2 = public static CategoryPacksMenuUI MonoSingleton<CategoryPacksMenuUI>::get_Instance().__il2cppRuntimeField_C.gameObject;
        if((public static CategoryPacksMenuUI MonoSingleton<CategoryPacksMenuUI>::get_Instance().__il2cppRuntimeField_C.activeSelf) != true)
        {
                public static CategoryPacksMenuUI MonoSingleton<CategoryPacksMenuUI>::get_Instance().__il2cppRuntimeField_C.SetActive(value:  true);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static CategoryPacksMenuUI MonoSingleton<CategoryPacksMenuUI>::get_Instance().__il2cppRuntimeField_10.Push(item:  public static CategoryPacksMenuUI MonoSingleton<CategoryPacksMenuUI>::get_Instance().__il2cppRuntimeField_C);
    }

}
