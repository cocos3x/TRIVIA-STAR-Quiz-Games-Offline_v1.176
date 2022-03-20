using UnityEngine;
public class WGNotificationLifecycle : MonoBehaviour
{
    // Fields
    private const int GIFT_SMALL = 120;
    private System.Collections.Generic.List<string> FeatureTeaser;
    private int[] FeaureLevels;
    private System.Collections.Generic.Dictionary<string, string[]> eventsNotifications;
    private System.DateTime localInstalledDate;
    private bool initialized;
    private bool knobEnabled;
    
    // Methods
    public static bool IsEnabled()
    {
        ulong val_8;
        ulong val_10;
        var val_13;
        GameBehavior val_1 = App.getBehavior;
        val_13 = 0;
        if(0 == 0)
        {
                return (bool)System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_10}, t2:  new System.DateTime() {dateData = val_8});
        }
        
        Player val_2 = App.Player;
        System.DateTime val_3 = ToLocalTime();
        System.DateTime val_6 = AddDays(value:  null);
        System.DateTime val_7 = DateTimeCheat.Now;
        return (bool)System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_10}, t2:  new System.DateTime() {dateData = val_8});
    }
    public void Init()
    {
        var val_8;
        bool val_9;
        if(this.initialized == true)
        {
                return;
        }
        
        var val_8 = 27075599;
        val_8 = 8551816 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        twelvegigs.storage.JsonDictionary val_1 = getGameplayKnobs();
        if(App.storageManager.knobsModel == 0)
        {
                return;
        }
        
        if(null != null)
        {
                val_9 = 1;
        }
        
        if((0.ContainsKey(key:  -236209488)) != false)
        {
                string val_3 = 0.Item[-236209488];
            val_9 = this.knobEnabled;
            bool val_5 = System.Boolean.TryParse(value:  null, result: out  val_9);
        }
        
        Player val_6 = App.Player;
        System.DateTime val_7 = ToLocalTime();
        this.localInstalledDate = new System.DateTime();
        this.initialized = true;
    }
    private void OnApplicationPause(bool pause)
    {
        var val_5;
        var val_8 = 35630630;
        if(this.knobEnabled == false)
        {
                return;
        }
        
        val_8 = 0;
        System.DateTime val_1 = DateTimeCheat.Now;
        System.TimeSpan val_4 = Subtract(value:  new System.DateTime() {dateData = 1152921512960696176});
        double val_7 = val_5.TotalDays;
        val_8;
        this.ScheduleDripNotification(pause:  pause, totalDays:  val_7);
        this.ScheduleConditionalNotification(pause:  pause, totalDays:  val_7);
    }
    private void ScheduleDripNotification(bool pause, double totalDays)
    {
        var val_3;
        string val_4;
        string val_10;
        twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  22);
        if(pause == false)
        {
                return;
        }
        
        Player val_1 = App.Player;
        if(34483956 <= 0)
        {
                System.DateTime val_2 = System.DateTime.Now;
            System.DateTime val_5 = val_3.AddMinutes(value:  totalDays);
            SendNotification(when:  new System.DateTime() {dateData = 1152921512960796416}, message:  val_4, ampTag:  "Welcome! QUICK FACT: Playing every day can improve your memory!", extraData:  "drip1_pnl", ntype:  0);
        }
        
        System.DateTime val_6 = AddDays(value:  totalDays);
        System.DateTime val_7 = val_3.Date;
        System.DateTime val_8 = AddHours(value:  totalDays);
        35630631 = 22;
        SendNotification(when:  new System.DateTime() {dateData = 1152921512960796704}, message:  val_10, ampTag:  "Keep it up! Puzzles become more challenging at higher levels!", extraData:  "drip2_pnl", ntype:  0);
    }
    private void ScheduleConditionalNotification(bool pause, double totalDays)
    {
        ulong val_8;
        var val_9;
        ulong val_11;
        twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  23);
        if(pause == false)
        {
                return;
        }
        
        Player val_1 = App.Player;
        if(34483956 <= 0)
        {
                System.DateTime val_2 = DateTimeCheat.Now;
            this.ConditionalNotifications(day:  1, when:  new System.DateTime());
        }
        
        System.DateTime val_3 = 0.AddDays(value:  totalDays);
        System.DateTime val_4 = Date;
        System.DateTime val_7 = AddHours(value:  totalDays);
        35630632 = val_9;
        System.DateTime val_10 = DateTimeCheat.Now;
        if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_11}, t2:  new System.DateTime() {dateData = val_8})) == false)
        {
                return;
        }
        
        this.ConditionalNotifications(day:  2, when:  new System.DateTime() {dateData = val_8});
    }
    private void ConditionalNotifications(int day, System.DateTime when)
    {
        ulong val_7;
        var val_8;
        var val_17;
        int val_18;
        int val_19;
        var val_20;
        var val_21;
        Player val_1 = App.Player;
        decimal val_2 = new System.Decimal(value:  120);
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid})) != false)
        {
                System.DateTime val_4 = val_2.flags.AddHours(value:  null);
            val_4.dateData.GenericNotification(genericType:  1, when:  new System.DateTime() {dateData = val_2.flags});
            Player val_5 = App.Player;
            val_17 = 0;
            System.DateTime val_6 = AddHours(value:  null);
            val_18 = val_7;
            val_19 = val_8;
        }
        else
        {
                Player val_9 = App.Player;
            val_17 = 0;
            System.DateTime val_10 = val_2.flags.AddHours(value:  null);
            val_18 = val_2.flags;
            val_19 = val_2.hi;
        }
        
        this.FeatureNotification(level:  0, when:  new System.DateTime() {dateData = val_18});
        val_20 = 0;
        System.DateTime val_11 = val_2.flags.AddHours(value:  null);
        this.EventsNotification(when:  new System.DateTime() {dateData = 1152921512961032752});
        System.DateTime val_12 = AddHours(value:  null);
        val_12.dateData.GenericNotification(genericType:  0, when:  new System.DateTime() {dateData = val_7});
        if(day != 2)
        {
                return;
        }
        
        var val_16 = 27075342;
        val_16 = 8555380 + val_16;
        if(val_16 == 0)
        {
                mem2[0] = 1;
        }
        
        val_21 = null;
        val_21 = null;
        val_20 = 0;
        if((System.String.IsNullOrEmpty(value:  WGGenericNotificationsManager.<LastNextWord>k__BackingField)) != true)
        {
                System.DateTime val_14 = val_2.flags.AddHours(value:  null);
            val_14.dateData.SendLevelAnwserNotification(when:  new System.DateTime() {dateData = 1152921512961032752}, nextWord:  val_2.hi);
        }
        
        System.DateTime val_15 = val_2.flags.AddHours(value:  null);
        val_15.dateData.GenericNotification(genericType:  2, when:  new System.DateTime() {dateData = val_2.flags});
    }
    private void GenericNotification(WGNotificationLifecycle.GenericType genericType, System.DateTime when)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3;
        var val_4;
        var val_5;
        var val_6;
        string val_7;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_8;
        val_3 = genericType;
        val_4 = 35630634;
        if(val_3 == 0)
        {
            goto label_1;
        }
        
        if(val_3 == 2)
        {
            goto label_2;
        }
        
        if(val_3 != 1)
        {
                return;
        }
        
        val_3 = null;
        val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_4 = null;
        Add(key:  2129282688, value:  13152256);
        string val_2 = System.String.Format(format:  -235644672, arg0:  13152256);
        val_5 = 23;
        val_6 = "coins_sml_pnl";
        goto label_5;
        label_1:
        val_7 = "Looking for a bigger challenge? Take on the Daily Challenge twice a day to earn EXCLUSIVE PRIZES!";
        val_8 = "daily_ch_pnl";
        goto label_6;
        label_2:
        val_7 = "Which one of your friends is playing? Join a Club to find out!";
        val_8 = "soc_pnl";
        label_6:
        val_5 = 23;
        label_5:
        SendNotification(when:  new System.DateTime() {dateData = 1152921512961137728}, message:  R3, ampTag:  val_7, extraData:  val_8, ntype:  0);
    }
    private void FeatureNotification(int level, System.DateTime when)
    {
        var val_2;
        var val_3;
        System.Int32[] val_4;
        val_2 = 0;
        val_3 = 0;
        goto label_1;
        label_5:
        int val_3 = this.FeaureLevels[val_3];
        if(val_3 < level)
        {
                val_2 = val_3;
        }
        
        val_3 = 1;
        label_1:
        val_4 = this.FeaureLevels;
        if(val_3 < val_3)
        {
            goto label_5;
        }
        
        if(val_2 < 0)
        {
                return;
        }
        
        if(val_2 >= val_3)
        {
                return;
        }
        
        var val_1 = val_2 + 1;
        string val_2 = System.String.Format(format:  -235449824, arg0:  13152256);
        val_4 = "feat_unlk{0}_pnl";
        if("feat_unlk{0}_pnl" <= val_2)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + 0;
        (0 + 0) + 16.SendNotification(when:  new System.DateTime() {dateData = 23}, message:  R3, ampTag:  (0 + 0) + 16, extraData:  val_4, ntype:  0);
    }
    private void EventsNotification(System.DateTime when)
    {
        var val_10;
        string val_11;
        string val_12;
        GameBehavior val_1 = App.getBehavior;
        val_10 = 0;
        if(val_10 == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        List.Enumerator<T> val_3 = GetEnumerator();
        label_25:
        if(MoveNext() == false)
        {
            goto label_10;
        }
        
        if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = R2}, t2:  new System.DateTime() {dateData = val_5 + 24})) == true)
        {
            goto label_25;
        }
        
        if(((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = R2}, t2:  new System.DateTime() {dateData = val_5 + 32})) == true) || ((mem[1152921512961555940].ContainsKey(key:  val_5 + 56)) == false))
        {
            goto label_25;
        }
        
        val_11 = val_5 + 56;
        string val_9 = mem[1152921512961555940].Item[val_11];
        if(mem[1152921512961555940] == 0)
        {
            goto label_25;
        }
        
        if((mem[1152921512961555940] + 12) >= 2)
        {
                val_12 = mem[mem[1152921512961555940] + 20];
            val_12 = mem[1152921512961555940] + 20;
        }
        else
        {
                val_11 = 0;
            val_12 = mem[mem[1152921512961555940] + 20];
            val_12 = mem[1152921512961555940] + 20;
            if((mem[1152921512961555940] + 12) == 0)
        {
                val_11 = 0;
        }
        
        }
        
        this.SendNotification(when:  new System.DateTime(), message:  R3, ampTag:  val_12, extraData:  mem[1152921512961555940] + 16, ntype:  0);
        goto label_25;
        label_10:
        Dispose();
    }
    private void SendLevelAnwserNotification(System.DateTime when, string nextWord)
    {
        object val_3;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1953384464, value:  13152256);
        GameBehavior val_2 = App.getBehavior;
        string val_4 = 0.ToString();
        string val_5 = System.String.Format(format:  -235133552, arg0:  -235121412, arg1:  val_3);
        SendNotification(when:  new System.DateTime() {dateData = 1152921512959324752}, message:  nextWord, ampTag:  "HERE\'S A HINT Clear level {0}, the answer is {1}!", extraData:  "levelcomplete_answer", ntype:  null);
    }
    private void SendNotification(System.DateTime when, string message, string ampTag, System.Collections.Generic.Dictionary<string, object> extraData, twelvegigs.plugins.NotificationType ntype = 23)
    {
        twelvegigs.plugins.NotificationType val_1;
        twelvegigs.plugins.NotificationType val_5;
        twelvegigs.plugins.NotificationType val_6;
        val_5 = val_1;
        val_6 = ntype;
        if(val_6 == 0)
        {
                val_6 = null;
            val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if(val_6 == 0)
        {
                val_6 = 0;
        }
        
        }
        
        val_6.Add(key:  -1953384384, value:  extraData);
        CompanyDevices val_3 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_1 = ;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            typeof(System.Object[]).__il2cppRuntimeField_14 = ampTag;
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            UnityEngine.Debug.LogFormat(format:  -235000896, args:  472754880);
            val_5 = val_1;
        }
        
        twelvegigs.plugins.LocalNotificationsPlugin.PostNotification(tipo:  val_5, when:  new System.DateTime() {dateData = 1}, interval:  message, optTitle:  0, optMessage:  0, extraData:  ampTag, priority:  val_6, useTimeModifier:  true);
    }
    public WGNotificationLifecycle()
    {
        var val_3;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(null != 0)
        {
                Add(item:  -234872400);
        }
        else
        {
                Add(item:  -234872400);
        }
        
        Add(item:  -234872240);
        if(null != 0)
        {
                Add(item:  -234872048);
        }
        else
        {
                Add(item:  -234872048);
        }
        
        Add(item:  -234871920);
        Add(item:  -234871712);
        this.FeatureTeaser = null;
        this.FeaureLevels = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        typeof(System.String[]).__il2cppRuntimeField_10 = "wild_wknd_pnl";
        typeof(System.String[]).__il2cppRuntimeField_14 = "Wild Word Weekend is available. Beat levels to earn a big prize!";
        Add(key:  -1280644912, value:  477709520);
        typeof(System.String[]).__il2cppRuntimeField_10 = "level_ch_pnl";
        typeof(System.String[]).__il2cppRuntimeField_14 = "A special Level Challenge event is now active!";
        Add(key:  -1322387776, value:  477709520);
        typeof(System.String[]).__il2cppRuntimeField_10 = "word_hnt_pnl";
        typeof(System.String[]).__il2cppRuntimeField_14 = "The monthly Word Hunt event is now available! Come play!";
        Add(key:  -1298909328, value:  477709520);
        typeof(System.String[]).__il2cppRuntimeField_10 = "light_wrd_pnl";
        typeof(System.String[]).__il2cppRuntimeField_14 = "The Lightning Words event is now active! Beat the timer to earn prizes!";
        Add(key:  -1321166448, value:  477709520);
        typeof(System.String[]).__il2cppRuntimeField_10 = "puzzle_cl_pnl";
        typeof(System.String[]).__il2cppRuntimeField_14 = "The Puzzle Challenge is live! Find all the pieces to earn a big prize!";
        Add(key:  -1306784064, value:  477709520);
        typeof(System.String[]).__il2cppRuntimeField_10 = "leadrbrd_pnl";
        typeof(System.String[]).__il2cppRuntimeField_14 = "Leaderboards are active! Come compete to earn coins!";
        Add(key:  -1266462880, value:  477709520);
        typeof(System.String[]).__il2cppRuntimeField_10 = "sup_stk_pnl";
        typeof(System.String[]).__il2cppRuntimeField_14 = "The Super Streak event is now live!";
        Add(key:  -1266462496, value:  477709520);
        typeof(System.String[]).__il2cppRuntimeField_10 = "hot_stk_pnl";
        typeof(System.String[]).__il2cppRuntimeField_14 = "The Hot Streaks event is now live!";
        Add(key:  -1266462400, value:  477709520);
        typeof(System.String[]).__il2cppRuntimeField_10 = "extra_chp_pnl";
        typeof(System.String[]).__il2cppRuntimeField_14 = "Extra Chapter Rewards are now available! Earn DOUBLE the coins for every Chapter completed!";
        Add(key:  -1266462992, value:  477709520);
        this.eventsNotifications = null;
        val_3 = null;
        val_3 = null;
        this.localInstalledDate = System.DateTime.MinValue;
    }

}
