using UnityEngine;
public class SlotsGameSessionEventTracker : MonoSingleton<SlotsGameSessionEventTracker>
{
    // Fields
    private static int totalSpinBets;
    private static int totalSpins;
    private static decimal coinsEarned;
    private static int lastSpinBet;
    private static int firstSpinBet;
    
    // Properties
    private static float averageSpinBet { get; }
    
    // Methods
    private static float get_averageSpinBet()
    {
        var val_1;
        int val_3;
        float val_4;
        val_1 = null;
        val_1 = null;
        val_3 = SlotsGameSessionEventTracker.totalSpins;
        if(val_3 != 0)
        {
                val_3 = SlotsGameSessionEventTracker.totalSpins;
            val_4 = (float)SlotsGameSessionEventTracker.__il2cppRuntimeField_static_fields / (float)val_3;
            return val_4;
        }
        
        val_4 = 0f;
        return val_4;
    }
    private void OnSceneLoaded(SceneType type)
    {
        if(type != 2)
        {
                return;
        }
        
        this.SessionStarted();
    }
    private void OnSceneUnloaded(SceneType type)
    {
        if(type != 2)
        {
                return;
        }
        
        this.SessionComplete();
    }
    public override void InitMonoSingleton()
    {
        var val_7;
        var val_8;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -653418480, method:  new IntPtr(3641522768));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_7 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_7 != 0)
        {
                if(val_7 == null)
        {
            goto label_6;
        }
        
        }
        
        val_7 = 0;
        label_6:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_7;
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_5 = new System.Action<Result>(object:  -653418480, method:  new IntPtr(3641523792));
        System.Delegate val_6 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10, b:  7401472);
        val_8 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_10;
        }
        
        }
        
        val_8 = 0;
        label_10:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10 = val_8;
    }
    private void OnDestroy()
    {
        var val_8;
        var val_9;
        if((MonoSingletonSelfGenerating<WordLevelGen>.InstanceExists) == false)
        {
                return;
        }
        
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_3 = new System.Action<Result>(object:  -653306480, method:  new IntPtr(3641522768));
        System.Delegate val_4 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_8 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_9;
        }
        
        }
        
        val_8 = 0;
        label_9:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_8;
        WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_6 = new System.Action<Result>(object:  -653306480, method:  new IntPtr(3641523792));
        System.Delegate val_7 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10, value:  7401472);
        val_9 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10;
        if(val_9 != 0)
        {
                if(val_9 == null)
        {
            goto label_13;
        }
        
        }
        
        val_9 = 0;
        label_13:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10 = val_9;
    }
    public static void AddCoins(decimal coins)
    {
        int val_2;
        int val_3;
        int val_4;
        var val_5;
        val_2 = coins.hi;
        val_3 = coins.lo;
        val_4 = coins.mid;
        val_5 = null;
        val_5 = null;
        val_2 = val_2;
        val_3 = val_3;
        val_4 = val_4;
        val_3 = val_3;
        val_2 = val_2;
        val_4 = val_4;
        decimal val_1 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -653206544, hi = SlotsGameSessionEventTracker.coinsEarned, lo = SlotsGameSessionEventTracker.totalSpinBets.__il2cppRuntimeField_C, mid = SlotsGameSessionEventTracker.totalSpinBets.__il2cppRuntimeField_10}, d2:  new System.Decimal() {flags = SlotsGameSessionEventTracker.totalSpinBets.__il2cppRuntimeField_14, hi = coins.flags, lo = val_2, mid = val_3});
    }
    public static void AddSpinBet(int spinBet)
    {
        var val_1;
        var val_2;
        var val_3;
        val_1 = null;
        val_1 = null;
        int val_1 = SlotsGameSessionEventTracker.totalSpinBets;
        val_1 = val_1 + spinBet;
        SlotsGameSessionEventTracker.totalSpinBets = val_1;
        val_2 = null;
        int val_2 = SlotsGameSessionEventTracker.totalSpins;
        val_2 = val_2 + 1;
        SlotsGameSessionEventTracker.totalSpins = val_2;
        if(SlotsGameSessionEventTracker.firstSpinBet == 0)
        {
                val_2 = null;
            val_3 = 1152921504955306012;
            SlotsGameSessionEventTracker.firstSpinBet = spinBet;
        }
        
        val_2 = null;
        SlotsGameSessionEventTracker.lastSpinBet = spinBet;
    }
    private void SessionStarted()
    {
        null = null;
        SlotsGameSessionEventTracker.totalSpinBets = 0;
        SlotsGameSessionEventTracker.totalSpins = 0;
        SlotsGameSessionEventTracker.lastSpinBet = 0;
        SlotsGameSessionEventTracker.firstSpinBet = 0;
    }
    private void SessionComplete()
    {
        var val_5;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        float val_2 = SlotsGameSessionEventTracker.averageSpinBet;
        Add(key:  -652882480, value:  15282176);
        Add(key:  -652882384, value:  10170368);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_4 = Spins;
        Add(key:  -652882288, value:  13152256);
        Add(key:  -652882192, value:  13152256);
        Add(key:  -652882080, value:  13152256);
        Add(key:  -652881984, value:  13152256);
        var val_5 = 19759570;
        val_5 = 15865968 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        App.trackerManager.track(eventName:  -652881872, data:  78753792);
    }
    public SlotsGameSessionEventTracker()
    {
    
    }
    private static SlotsGameSessionEventTracker()
    {
    
    }

}
