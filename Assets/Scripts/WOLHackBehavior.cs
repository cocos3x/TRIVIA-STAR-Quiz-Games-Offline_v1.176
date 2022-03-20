using UnityEngine;
public class WOLHackBehavior : HackBehavior
{
    // Methods
    public override SROptions GetGameSpecificSROptions()
    {
        return SuperLuckySROptionsParent<System.Object>.Instance;
    }
    public override void Hack_CompleteLevelBehavior()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1759400800) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_CompleteLevel();
    }
    public override void AppendGameLevelInfo(ref System.Text.StringBuilder builder)
    {
        var val_17;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1759400800) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Dictionary.KeyCollection<TKey, TValue> val_5 = public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_38 + 32.Keys;
            System.Collections.Generic.List<ZooTile> val_6 = new System.Collections.Generic.List<ZooTile>(collection:  public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_38 + 32);
            System.Comparison<WordForest.NewsArticle> val_7 = new System.Comparison<WordForest.NewsArticle>(object:  0, method:  new IntPtr(3606944480));
            Sort(comparison:  7933952);
            Player val_8 = App.Player;
            System.Text.StringBuilder val_9 = builder.AppendFormat(format:  -731768448, arg0:  13152256);
            string val_10 = MiniJSON.Json.Serialize(obj:  80883712);
            System.Text.StringBuilder val_11 = builder.AppendFormat(format:  -731768176, arg0:  80883712);
            string val_12 = public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_38.GridToString(wordsCounter:  false);
            System.Text.StringBuilder val_13 = builder.AppendFormat(format:  -688019744, arg0:  public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_38);
            string val_14 = public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_38.GridToString(wordsCounter:  true);
            System.Text.StringBuilder val_15 = builder.AppendFormat(format:  -688019600, arg0:  public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_38);
            return;
        }
        
        val_17 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_17 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_17 == 1)
        {
                val_17 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_17 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        System.Text.StringBuilder val_16 = builder.AppendFormat(format:  -731768576, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
    }
    public WOLHackBehavior()
    {
    
    }

}
