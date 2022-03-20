using UnityEngine;
public class TRVHackBehavior : HackBehavior
{
    // Methods
    public override SROptions GetGameSpecificSROptions()
    {
        return SuperLuckySROptionsParent<System.Object>.Instance;
    }
    public override void AppendGameLevelInfo(ref System.Text.StringBuilder builder)
    {
        var val_26;
        System.Text.StringBuilder val_27;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1647818192) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Text.StringBuilder val_5 = builder.AppendLine(value:  -724947760);
            string val_6 = -724947648(-724947648) + public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 8(public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 8);
            System.Text.StringBuilder val_7 = builder.AppendLine(value:  -724947648);
            int val_8 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.countedAnswers;
            val_8 = val_8 + 1;
            string val_9 = -724947552(-724947552) + 13152256;
            System.Text.StringBuilder val_10 = builder.AppendLine(value:  -724947552);
            string val_11 = MiniJSON.Json.Serialize(obj:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 88);
            string val_12 = -724947440(-724947440) + public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 88(public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 88);
            val_26 = "current difficulty array : ";
            System.Text.StringBuilder val_13 = builder.AppendLine(value:  -724947440);
            val_27 = builder;
            string val_14 = -724947312(-724947312) + 13152256;
            System.Text.StringBuilder val_15 = val_27.AppendLine(value:  -724947312);
            System.Text.StringBuilder val_16 = builder.AppendLine(value:  -724947200);
            System.Text.StringBuilder val_17 = builder.AppendLine(value:  -724947120);
            twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_26 = mem[public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20];
            val_26 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20;
            string val_21 = -724947008(-724947008) + public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 8(public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 8);
            val_27 = "question ID ";
            System.Text.StringBuilder val_22 = builder.AppendLine(value:  -724947008);
            string val_23 = -724946912(-724946912) + 13152256;
            System.Text.StringBuilder val_24 = builder.AppendLine(value:  -724946912);
            return;
        }
        
        System.Text.StringBuilder val_25 = builder.AppendLine(value:  -770980256);
    }
    public override void AppendCategoriesInfo(ref System.Text.StringBuilder builder)
    {
        UnityEngine.Material val_5;
        var val_17;
        var val_18;
        UnityEngine.Material val_19;
        var val_20;
        var val_21;
        Player val_1 = App.Player;
        string val_2 = System.String.Format(format:  -724826784, arg0:  13152256);
        System.Text.StringBuilder val_3 = builder.AppendLine(value:  -724826784);
        val_17 = null;
        val_17 = null;
        List.Enumerator<T> val_4 = GetEnumerator();
        val_18 = 1152921512370649248;
        goto label_13;
        label_24:
        val_19 = val_5;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_7 = getAvailableSubCategories;
        val_20 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance();
        if((ContainsKey(key:  val_19)) != false)
        {
                System.Text.StringBuilder val_9 = builder.AppendLine();
            System.Text.StringBuilder val_10 = builder.AppendLine(value:  val_19);
            val_21 = 0;
            string val_16 = Item[null];
        }
        
        label_13:
        if(MoveNext() == true)
        {
            goto label_24;
        }
        
        Dispose();
    }
    public TRVHackBehavior()
    {
    
    }

}
