using UnityEngine;
public class TRVStreakManager : MonoSingleton<TRVStreakManager>
{
    // Fields
    public const string ON_STREAK_UPDATE = "OnTRVStreakUpdate";
    private const string streakKey = "trvStreak";
    
    // Properties
    private int currentStreak { get; set; }
    public int getCurrentStreak { get; }
    
    // Methods
    private int get_currentStreak()
    {
        return CPlayerPrefs.GetInt(key:  -564123776, defaultValue:  0);
    }
    private void set_currentStreak(int value)
    {
        CPlayerPrefs.SetInt(key:  -564123776, val:  value);
    }
    public int get_getCurrentStreak()
    {
        return this.currentStreak;
    }
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>(object:  -563762656, method:  new IntPtr(3731179616));
        UnityEngine.SceneManagement.SceneManager.add_activeSceneChanged(value:  162459648);
    }
    private void OnSceneChanged(UnityEngine.SceneManagement.Scene outgoing, UnityEngine.SceneManagement.Scene incoming)
    {
        var val_14;
        var val_15;
        var val_16;
        System.Action<System.Boolean> val_17;
        System.Delegate val_18;
        var val_19;
        string val_1 = outgoing.m_Handle.name;
        if((System.String.IsNullOrEmpty(value:  -563661668)) == true)
        {
            goto label_6;
        }
        
        GameBehavior val_3 = App.getBehavior;
        string val_4 = outgoing.m_Handle.name;
        val_14;
        if(0 != 2)
        {
            goto label_6;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_15 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance();
        val_16 = 1152921504614248448;
        val_17 = null;
        val_17 = new System.Action<System.Boolean>(object:  -563649632, method:  new IntPtr(3731292640));
        val_18 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_34;
        System.Delegate val_7 = System.Delegate.Remove(source:  val_18, value:  7401472);
        goto label_10;
        label_6:
        GameBehavior val_8 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        val_14 = 1152921504901095424;
        val_17 = 1152921511548963376;
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1647818192) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_15 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance();
        val_16 = 1152921504614248448;
        val_17 = null;
        val_17 = new System.Action<System.Boolean>(object:  -563649632, method:  new IntPtr(3731292640));
        val_18 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_34;
        System.Delegate val_13 = System.Delegate.Combine(a:  val_18, b:  7401472);
        label_10:
        val_19 = val_18;
        if(val_19 != 0)
        {
                if(val_19 == val_16)
        {
            goto label_26;
        }
        
        }
        
        val_19 = 0;
        label_26:
        public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_34 = val_19;
    }
    private void OnQuestionAnswered(bool correct)
    {
        if(correct == false)
        {
                return;
        }
        
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        int val_4 = UnityEngine.Mathf.Min(a:  mem[1152921512476916260], b:  currentStreak + 1);
        val_4.currentStreak = val_4;
    }
    private void OnLevelComplete(bool successfulLevel, TRVQuizProgress prog)
    {
        if(successfulLevel != false)
        {
                return;
        }
        
        this.currentStreak = 0;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -563421424, aName:  -563445536);
    }
    public void BreakStreak()
    {
        this.currentStreak.currentStreak = 0;
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -563305232, aName:  -563445536);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.InjectTrackingInfo(key:  -563329328, value:  13152256);
    }
    public int GetBonusStarReward()
    {
        return this.currentStreak;
    }
    public int AddHackedStreaks(int amount)
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        int val_4 = UnityEngine.Mathf.Min(a:  mem[1152921512476916260], b:  currentStreak + amount);
        val_4.currentStreak = val_4;
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -563081232, aName:  -563445536);
        return this.currentStreak;
    }
    public TRVStreakManager()
    {
    
    }

}
