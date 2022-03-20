using UnityEngine;
[Serializable]
private sealed class WADPetsScreenUI.<>c__8<T>
{
    // Fields
    public static readonly WADPetsScreenUI.<>c__8<T> <>9;
    public static System.Action <>9__8_0;
    
    // Methods
    private static WADPetsScreenUI.<>c__8<T>()
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
    public WADPetsScreenUI.<>c__8<T>()
    {
        if(this != 0)
        {
                return;
        }
    
    }
    internal void <ShowScreen>b__8_0()
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Stack.Enumerator<T> val_2 = GetEnumerator();
        label_9:
        if(MoveNext() == false)
        {
            goto label_5;
        }
        
        object val_4 = Current;
        val_12 = ;
        val_11 = val_12;
        if((UnityEngine.Object.op_Implicit(exists:  -961874264)) == false)
        {
            goto label_9;
        }
        
        val_13 = 0;
        SetActive(value:  true);
        val_14 = -961874304;
        val_15 = 136;
        goto label_11;
        label_5:
        val_14 = -961874304;
        val_15 = 78;
        val_13 = 0;
        label_11:
        val_12 = 0;
        val_11 = 0;
        val_12 = val_12 + 1;
        val_11 = (uint)val_12 & 65535;
        if(val_13 != 1)
        {
                if(val_15 == 136)
        {
                return;
        }
        
        }
        
        val_11 = 1152921504901095424;
        val_12 = 1152921512216719840;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_7 = public static WADPetsScreenUI MonoSingleton<WADPetsScreenUI>::get_Instance().__il2cppRuntimeField_C.gameObject;
        if((public static WADPetsScreenUI MonoSingleton<WADPetsScreenUI>::get_Instance().__il2cppRuntimeField_C.activeSelf) != true)
        {
                public static WADPetsScreenUI MonoSingleton<WADPetsScreenUI>::get_Instance().__il2cppRuntimeField_C.SetActive(value:  true);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WADPetsScreenUI MonoSingleton<WADPetsScreenUI>::get_Instance().__il2cppRuntimeField_10.Push(item:  public static WADPetsScreenUI MonoSingleton<WADPetsScreenUI>::get_Instance().__il2cppRuntimeField_C);
    }

}
