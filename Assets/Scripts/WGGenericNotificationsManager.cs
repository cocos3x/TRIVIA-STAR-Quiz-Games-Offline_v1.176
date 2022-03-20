using UnityEngine;
public class WGGenericNotificationsManager : MonoSingleton<WGGenericNotificationsManager>
{
    // Fields
    private const string PREFS_1_HOUR = "1_hour_engagement_notif";
    public static bool hint48Enabled;
    public static bool hint1Enabled;
    public static bool dailyBonusEnable;
    public static bool postAdEnabled;
    public static bool levelAnswerEnabled;
    private static int hint1Hours;
    private static int hint2Hours;
    private static string urlEngagementImg;
    private static string urlEngagementBase;
    private static int levelAnswerHours;
    private static string urlDailyBonusImg;
    public static bool dcMorningReminderEnabled;
    public static bool dcEveningReminderEnabled;
    private static string urlPostAdImg;
    private static bool postedNotif;
    private WGRecaptureNotifications recaptureNotifications;
    private WGNotificationLifecycle lifecycle;
    private static string <LastNextWord>k__BackingField;
    
    // Properties
    public static string UrlDailyBonusImg { get; }
    public static string LastNextWord { get; set; }
    
    // Methods
    public static string get_UrlDailyBonusImg()
    {
        null = null;
    }
    public override void InitMonoSingleton()
    {
        var val_4;
        GameBehavior val_1 = App.getBehavior;
        val_4 = null;
        val_4 = null;
        WGGenericNotificationsManager.urlDailyBonusImg = 0;
        GameBehavior val_2 = App.getBehavior;
        WGGenericNotificationsManager.urlPostAdImg = 0;
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -238466416, name:  -1898880160);
    }
    private void Start()
    {
        WGGenericNotificationsManager.ReadFromKnobs();
        if(WGNotificationLifecycle.IsEnabled() == false)
        {
                return;
        }
        
        if(this.lifecycle != 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.WUTAutopilotGameplay val_3 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  R4);
        mem2[0] = R4;
        R4.Init();
    }
    private void OnServerSync()
    {
        WGGenericNotificationsManager.ReadFromKnobs();
    }
    public static void ReadFromKnobs()
    {
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_23 = 28810791;
        val_23 = 6816624 + val_23;
        if(val_23 == 0)
        {
                mem2[0] = 1;
        }
        
        val_23 = null;
        val_23 = null;
        System.Collections.IDictionary val_1 = getGenericNofications();
        if(App.storageManager.knobsModel == 0)
        {
                return;
        }
        
        if(((mem[null + 100] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                App.storageManager.knobsModel = 0;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
        val_24 = "word_addict_notifications";
        label_14:
        label_13:
        if(0.MoveNext() == false)
        {
            goto label_12;
        }
        
        if((System.String.op_Equality(a:  null, b:  -238145200)) == false)
        {
            goto label_13;
        }
        
        twelvegigs.storage.JsonDictionary val_6 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  R7);
        goto label_14;
        label_12:
        0.Dispose();
        if(0 == 0)
        {
                return;
        }
        
        val_24 = 1152921504984215552;
        val_25 = null;
        val_25 = null;
        WGGenericNotificationsManager.hint48Enabled = 0.getBool(key:  -238145072);
        WGGenericNotificationsManager.hint1Enabled = 0.getBool(key:  -238144960);
        WGGenericNotificationsManager.dailyBonusEnable = 0.getBool(key:  -238144848);
        WGGenericNotificationsManager.postAdEnabled = 0.getBool(key:  -238144736);
        WGGenericNotificationsManager.levelAnswerEnabled = 0.getBool(key:  -238144640);
        WGGenericNotificationsManager.dcMorningReminderEnabled = 0.getBool(key:  -238144528);
        val_26 = null;
        WGGenericNotificationsManager.dcEveningReminderEnabled = 0.getBool(key:  -238144400);
        if(WGGenericNotificationsManager.hint48Enabled != true)
        {
                WGGenericNotificationsManager.CancelDisabledNotification(type:  5);
            val_26 = null;
        }
        
        val_26 = null;
        if(WGGenericNotificationsManager.hint1Enabled != true)
        {
                WGGenericNotificationsManager.CancelDisabledNotification(type:  6);
            val_26 = null;
        }
        
        val_26 = null;
        if(WGGenericNotificationsManager.dailyBonusEnable != true)
        {
                WGGenericNotificationsManager.CancelDisabledNotification(type:  2);
            val_26 = null;
        }
        
        val_26 = null;
        if(WGGenericNotificationsManager.postAdEnabled != true)
        {
                WGGenericNotificationsManager.CancelDisabledNotification(type:  7);
            val_26 = null;
        }
        
        val_26 = null;
        if(WGGenericNotificationsManager.levelAnswerEnabled != true)
        {
                WGGenericNotificationsManager.CancelDisabledNotification(type:  15);
            val_26 = null;
        }
        
        val_26 = null;
        if(WGGenericNotificationsManager.dcMorningReminderEnabled != true)
        {
                WGGenericNotificationsManager.CancelDisabledNotification(type:  16);
            val_26 = null;
        }
        
        val_26 = null;
        if(WGGenericNotificationsManager.dcEveningReminderEnabled != true)
        {
                WGGenericNotificationsManager.CancelDisabledNotification(type:  17);
            val_26 = null;
        }
        
        val_26 = null;
        WGGenericNotificationsManager.hint1Hours = 0.getInt(key:  -238144272, defaultValue:  WGGenericNotificationsManager.hint1Hours);
        WGGenericNotificationsManager.hint2Hours = 0.getInt(key:  -238144176, defaultValue:  WGGenericNotificationsManager.hint2Hours);
        string val_16 = 0.getString(key:  -238144080, defaultValue:  WGGenericNotificationsManager.urlEngagementImg);
        WGGenericNotificationsManager.urlEngagementImg = 0;
        string val_17 = 0.getString(key:  -238143968, defaultValue:  WGGenericNotificationsManager.urlEngagementBase);
        WGGenericNotificationsManager.urlEngagementBase = 0;
        WGGenericNotificationsManager.levelAnswerHours = 0.getInt(key:  -238143856, defaultValue:  WGGenericNotificationsManager.levelAnswerHours);
        string val_19 = 0.getString(key:  -238143744, defaultValue:  WGGenericNotificationsManager.urlDailyBonusImg);
        WGGenericNotificationsManager.urlDailyBonusImg = 0;
        string val_20 = 0.getString(key:  -238143632, defaultValue:  WGGenericNotificationsManager.urlPostAdImg);
        WGGenericNotificationsManager.urlPostAdImg = 0;
        NotificationCenter val_21 = NotificationCenter.DefaultCenter;
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        0.RemoveObserver(observer:  -238143536, name:  -1898880160);
    }
    public static void SendEngagementNotifications(bool QAHACK_Force = False)
    {
        var val_3;
        var val_8;
        twelvegigs.plugins.NotificationInterval val_9;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_24;
        var val_25;
        var val_26;
        string val_27;
        var val_28;
        var val_29;
        var val_30;
        val_20 = 1152921504984215552;
        val_21 = null;
        val_21 = null;
        if(QAHACK_Force != false)
        {
                if(QAHACK_Force != false)
        {
                val_22 = val_20;
            System.DateTime val_2 = DateTimeCheat.Now;
            System.DateTime val_5 = AddSeconds(value:  null);
        }
        else
        {
                System.DateTime val_6 = DateTimeCheat.Now;
            val_23 = null;
            val_23 = null;
            val_22 = val_20;
            System.DateTime val_7 = AddHours(value:  null);
        }
        
            val_24 = null;
            val_24 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            val_25 = 1;
            val_3 = val_25;
            Add(key:  -1953384464, value:  13152256);
            val_8 = val_25;
            if(val_24 != 0)
        {
                Add(key:  1638199088, value:  13152256);
        }
        else
        {
                Add(key:  1638199088, value:  13152256);
        }
        
            val_20 = val_22;
            Add(key:  -1953384384, value:  -238030512);
            val_26 = null;
            val_26 = null;
            GameBehavior val_11 = App.getBehavior;
            val_27 = 0;
            string val_12 = System.String.Format(format:  -238030400, arg0:  WGGenericNotificationsManager.urlEngagementBase, arg1:  13152256);
            twelvegigs.plugins.LocalNotificationsPlugin.PostNotifWithImage(type:  5, when:  new System.DateTime() {dateData = 1}, interval:  val_9, title:  val_27, message:  val_27, extraData:  "Almost there! Here’s a FREE Hint to keep you going!", imageUrl:  val_24, priority:  "{0}{1}.png", useTimeModifier:  false);
            val_21 = null;
        }
        
        if(QAHACK_Force == false)
        {
                return;
        }
        
        if(QAHACK_Force != false)
        {
                System.DateTime val_14 = DateTimeCheat.Now;
            System.DateTime val_15 = val_8.AddSeconds(value:  null);
        }
        else
        {
                System.DateTime val_16 = DateTimeCheat.Now;
            val_29 = null;
            val_29 = null;
            System.DateTime val_17 = val_8.AddHours(value:  null);
        }
        
        val_27 = val_9;
        if((CPlayerPrefs.HasKey(key:  -238030128)) != false)
        {
                if(QAHACK_Force == false)
        {
                return;
        }
        
        }
        
        val_22 = val_20;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_19 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_28 = 1;
        val_25 = 1152921504619999232;
        val_3 = val_28;
        Add(key:  -1953384464, value:  13152256);
        val_8 = val_28;
        if(null != 0)
        {
                Add(key:  1638199088, value:  13152256);
        }
        else
        {
                Add(key:  1638199088, value:  13152256);
        }
        
        Add(key:  -1953384384, value:  -238030000);
        val_30 = null;
        val_24 = 1152921504882458624;
        val_30 = null;
        twelvegigs.plugins.LocalNotificationsPlugin.PostNotifWithImage(type:  6, when:  new System.DateTime() {dateData = 1152921512958751840}, interval:  val_27, title:  0, message:  "Free Welcome Hint to help you get started", extraData:  "Good luck!", imageUrl:  null, priority:  WGGenericNotificationsManager.urlEngagementImg, useTimeModifier:  false);
        CPlayerPrefs.SetBool(key:  -238030128, value:  true);
        CPlayerPrefs.Save();
    }
    public static void SendPostAdNotification(bool QAHACK_Force = False)
    {
        var val_3;
        twelvegigs.plugins.NotificationInterval val_9;
        var val_11;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_12;
        var val_13;
        if(QAHACK_Force != false)
        {
                System.DateTime val_2 = DateTimeCheat.Now;
            System.DateTime val_5 = AddSeconds(value:  null);
        }
        else
        {
                System.DateTime val_6 = DateTimeCheat.Now;
            System.DateTime val_7 = AddMinutes(value:  null);
        }
        
        val_11 = null;
        val_11 = null;
        if(QAHACK_Force == false)
        {
                return;
        }
        
        val_12 = null;
        val_12 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_3 = 1;
        if(val_12 != 0)
        {
                Add(key:  -1953384464, value:  13152256);
        }
        else
        {
                Add(key:  -1953384464, value:  13152256);
        }
        
        Add(key:  -1953384384, value:  -237917632);
        val_13 = null;
        val_13 = null;
        twelvegigs.plugins.LocalNotificationsPlugin.PostNotifWithImage(type:  7, when:  new System.DateTime() {dateData = 1152921512958864128}, interval:  val_9, title:  0, message:  "YOU\'RE ALMOST THERE", extraData:  "Come back to finish the level!", imageUrl:  val_12, priority:  WGGenericNotificationsManager.urlPostAdImg, useTimeModifier:  true);
    }
    public static void SendDailyBonusNotification(bool QAHACK_Force = False)
    {
        twelvegigs.plugins.NotificationInterval val_10;
        var val_14;
        var val_15;
        val_14 = null;
        val_14 = null;
        if(QAHACK_Force == false)
        {
                return;
        }
        
        if(QAHACK_Force != false)
        {
                System.DateTime val_2 = DateTimeCheat.Now;
            System.DateTime val_5 = AddSeconds(value:  null);
        }
        else
        {
                System.DateTime val_6 = DateTimeCheat.Now;
            GameEcon val_7 = App.getGameEcon;
            System.DateTime val_8 = AddHours(value:  null);
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_11 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1953384384, value:  -237805312);
        GameBehavior val_12 = App.getBehavior;
        GameBehavior val_13 = App.getBehavior;
        var val_14 = 28804900;
        val_14 = 6822516 + val_14;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        val_15 = null;
        val_15 = null;
        twelvegigs.plugins.LocalNotificationsPlugin.PostNotifWithImage(type:  2, when:  new System.DateTime() {dateData = 1}, interval:  val_10, title:  0, message:  0, extraData:  0, imageUrl:  null, priority:  WGGenericNotificationsManager.urlDailyBonusImg, useTimeModifier:  false);
    }
    public static string get_LastNextWord()
    {
        null = null;
    }
    private static void set_LastNextWord(string value)
    {
        null = null;
        WGGenericNotificationsManager.<LastNextWord>k__BackingField = value;
    }
    public static void SendLevelAnwserNotification(string nextWord, bool QAHACK_Force = False)
    {
        var val_4;
        var val_9;
        ulong val_10;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_24;
        var val_25;
        float val_26;
        var val_27;
        bool val_28;
        twelvegigs.plugins.NotificationInterval val_29;
        var val_30;
        var val_32;
        var val_33;
        val_24 = 35627152;
        val_25 = null;
        val_25 = null;
        if((WGGenericNotificationsManager.levelAnswerEnabled == false) || ((System.String.IsNullOrEmpty(value:  nextWord)) == true))
        {
            goto label_23;
        }
        
        val_26 = 1152921504888102912;
        if(QAHACK_Force != false)
        {
                System.DateTime val_3 = DateTimeCheat.Now;
            System.DateTime val_6 = AddSeconds(value:  null);
        }
        else
        {
                System.DateTime val_7 = DateTimeCheat.Now;
            val_27 = null;
            val_27 = null;
            System.DateTime val_8 = AddHours(value:  null);
        }
        
        val_28 = "last_level_answer_time";
        string val_11 = UnityEngine.PlayerPrefs.GetString(key:  -237456928);
        val_29 = 1152921504616751104;
        val_30 = null;
        val_30 = null;
        System.DateTime val_12 = SLCDateTime.Parse(dateTime:  -237444256, defaultValue:  new System.DateTime() {dateData = 1152921512959324640});
        System.DateTime val_13 = DateTimeCheat.Now;
        if((val_9.CompareTo(value:  new System.DateTime() {dateData = val_10})) < 1)
        {
            goto label_17;
        }
        
        System.DateTime val_15 = DateTimeCheat.Now;
        System.DateTime val_16 = AddDays(value:  null);
        if((val_4.CompareTo(value:  new System.DateTime() {dateData = 1152921512959337336})) <= 1)
        {
            goto label_20;
        }
        
        label_17:
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_18 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_4 = 1;
        val_24 = null;
        if(null != 0)
        {
                Add(key:  -1953384464, value:  13152256);
        }
        else
        {
                Add(key:  -1953384464, value:  13152256);
        }
        
        Add(key:  -1953384384, value:  -237456816);
        if((System.String.op_Inequality(a:  nextWord, b:  System.String.alignConst)) != false)
        {
                string val_20 = val_9.ToString();
            UnityEngine.PlayerPrefs.SetString(key:  -237456928, value:  -237444224);
            val_29 = val_10;
            GameBehavior val_21 = App.getBehavior;
            val_26 = 0;
            string val_22 = 0.ToString();
            string val_23 = System.String.Format(format:  -237456704, arg0:  -237444244, arg1:  nextWord);
            val_24 = "Clear level {0}, the answer is {1}!";
            val_28 = true;
            twelvegigs.plugins.LocalNotificationsPlugin.PostNotification(tipo:  15, when:  new System.DateTime() {dateData = twelvegigs.plugins.LocalNotificationsPlugin.__il2cppRuntimeField_cctor_finished}, interval:  val_29, optTitle:  val_26, optMessage:  "HERE\'S A HINT", extraData:  val_24, priority:  null, useTimeModifier:  true);
            val_32 = null;
            val_32 = null;
            WGGenericNotificationsManager.postedNotif = val_28;
        }
        
        label_23:
        var val_24 = 28803053;
        val_24 = 6824364 + val_24;
        if(val_24 == 0)
        {
                mem2[0] = 1;
        }
        
        val_33 = null;
        val_33 = null;
        WGGenericNotificationsManager.<LastNextWord>k__BackingField = nextWord;
        return;
        label_20:
        UnityEngine.Debug.LogWarning(message:  -237456464);
    }
    public static void SendDailyChallengeMorningReminder(int hour, bool QAHACK_Force = False)
    {
        var val_2;
        var val_5;
        twelvegigs.plugins.NotificationInterval val_6;
        var val_8;
        var val_9;
        var val_11;
        var val_12;
        var val_25;
        twelvegigs.plugins.NotificationInterval val_26;
        var val_27;
        var val_28;
        val_25 = null;
        val_25 = null;
        if(QAHACK_Force == false)
        {
                return;
        }
        
        WGGenericNotificationsManager.CancelDailyChallengeNotification();
        System.DateTime val_1 = DateTimeCheat.Now;
        System.DateTime val_4 = DateTimeCheat.Today;
        System.DateTime val_7 = AddHours(value:  null);
        System.DateTime val_10 = AddMinutes(value:  null);
        if((val_2.CompareTo(value:  new System.DateTime() {dateData = 1152921512959453832})) >= 0)
        {
                System.DateTime val_15 = DateTimeCheat.Today;
            System.DateTime val_16 = AddDays(value:  null);
            System.DateTime val_17 = AddHours(value:  null);
            val_27 = SB;
            System.DateTime val_18 = AddMinutes(value:  null);
            val_28 = val_11;
            val_26 = val_12;
        }
        else
        {
                System.DateTime val_19 = DateTimeCheat.Today;
            System.DateTime val_20 = AddHours(value:  null);
            val_27 = SB;
            System.DateTime val_21 = AddMinutes(value:  null);
            val_28 = val_8;
            val_26 = val_9;
        }
        
        if(QAHACK_Force != false)
        {
                System.DateTime val_22 = DateTimeCheat.Now;
            System.DateTime val_23 = AddSeconds(value:  null);
            val_28 = val_5;
            val_26 = val_6;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_24 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_2 = 1;
        if(null != 0)
        {
                Add(key:  -1953384832, value:  8945664);
        }
        else
        {
                Add(key:  -1953384832, value:  8945664);
        }
        
        Add(key:  -1953384384, value:  -237340080);
        if(QAHACK_Force == true)
        {
                86400 = 0;
        }
        
        twelvegigs.plugins.LocalNotificationsPlugin.PostNotification(tipo:  16, when:  new System.DateTime() {dateData = 1152921512959441728}, interval:  val_26, optTitle:  0, optMessage:  "MORNING CHALLENGE ENDING", extraData:  "Hurry, the Morning Challenge ends soon!", priority:  null, useTimeModifier:  false);
    }
    public static void SendDailyChallengeEveningReminder(int hour, bool QAHACK_Force = False)
    {
        var val_2;
        var val_5;
        twelvegigs.plugins.NotificationInterval val_6;
        var val_8;
        var val_9;
        var val_20;
        var val_21;
        var val_22;
        twelvegigs.plugins.NotificationInterval val_23;
        val_20 = null;
        val_20 = null;
        if(QAHACK_Force == false)
        {
                return;
        }
        
        WGGenericNotificationsManager.CancelDailyChallengeEveningNotification();
        System.DateTime val_1 = DateTimeCheat.Now;
        System.DateTime val_4 = DateTimeCheat.Today;
        System.DateTime val_7 = AddHours(value:  null);
        if((val_2.CompareTo(value:  new System.DateTime() {dateData = 1152921512959566240})) >= 0)
        {
                System.DateTime val_12 = DateTimeCheat.Today;
            System.DateTime val_13 = AddDays(value:  null);
            val_21 = hour;
            System.DateTime val_14 = AddHours(value:  null);
            val_22 = val_8;
            val_23 = val_9;
        }
        else
        {
                System.DateTime val_15 = DateTimeCheat.Today;
            val_21 = hour;
            System.DateTime val_16 = AddHours(value:  null);
            val_22 = val_5;
            val_23 = val_6;
        }
        
        if(QAHACK_Force != false)
        {
                System.DateTime val_17 = DateTimeCheat.Now;
            System.DateTime val_18 = AddSeconds(value:  null);
            val_22 = val_5;
            val_23 = val_6;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_19 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_2 = 1;
        if(null != 0)
        {
                Add(key:  -1953384832, value:  8945664);
        }
        else
        {
                Add(key:  -1953384832, value:  8945664);
        }
        
        Add(key:  -1953384384, value:  -237227680);
        if(QAHACK_Force == true)
        {
                86400 = 0;
        }
        
        twelvegigs.plugins.LocalNotificationsPlugin.PostNotification(tipo:  17, when:  new System.DateTime() {dateData = 1152921512959554128}, interval:  val_23, optTitle:  0, optMessage:  "EVENING CHALLENGE ENDING", extraData:  "The Evening Challenge is wrapping up soon!", priority:  null, useTimeModifier:  false);
    }
    public static void CancelLevelAnswerNotification()
    {
        twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  15);
    }
    public static void CancelPostAdNotification()
    {
        twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  7);
    }
    public static void CancelDailyChallengeNotification()
    {
        twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  16);
    }
    public static void CancelDailyChallengeEveningNotification()
    {
        twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  17);
    }
    public static void CancelDisabledNotification(twelvegigs.plugins.NotificationType type)
    {
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        string val_1 = -236663184(-236663184) + 459157504;
        UnityEngine.Debug.Log(message:  -236663184);
        twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  null);
    }
    public WGGenericNotificationsManager()
    {
    
    }
    private static WGGenericNotificationsManager()
    {
        WGGenericNotificationsManager.hint48Enabled = false;
        WGGenericNotificationsManager.hint1Enabled = false;
        WGGenericNotificationsManager.dailyBonusEnable = true;
        WGGenericNotificationsManager.postAdEnabled = true;
        WGGenericNotificationsManager.levelAnswerEnabled = true;
        WGGenericNotificationsManager.hint1Hours = true;
        WGGenericNotificationsManager.hint2Hours = 48;
        WGGenericNotificationsManager.urlEngagementImg = "https://s3-us-west-1.amazonaws.com/12gcontent/WordAddictRpnImg/FreeHint1hr.png";
        WGGenericNotificationsManager.urlEngagementBase = "https://s3-us-west-1.amazonaws.com/12gcontent/WordAddictRpnImg/levels/";
        WGGenericNotificationsManager.levelAnswerHours = true;
        WGGenericNotificationsManager.dcMorningReminderEnabled = true;
        WGGenericNotificationsManager.dcEveningReminderEnabled = true;
        WGGenericNotificationsManager.postedNotif = false;
    }

}
