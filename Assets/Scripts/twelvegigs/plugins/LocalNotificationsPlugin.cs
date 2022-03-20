using UnityEngine;

namespace twelvegigs.plugins
{
    public class LocalNotificationsPlugin
    {
        // Fields
        private const string REGISTER_NOTIFICATION = "local_notification_register_notification";
        private static string GAME_NAME;
        private static bool initialized;
        private static bool enabled;
        private static string[] notification_messages;
        private static bool notification_status;
        private static System.Collections.Generic.List<int> single_instanced;
        private static System.Action<System.Collections.Generic.Dictionary<string, string>> notificationPoster;
        private static System.Action<string, string, string, string> notificationCanceller;
        private static System.Action notificationsKiller;
        private static System.Action notificationsEnabler;
        private static System.Action notificationsClearer;
        private static UnityEngine.AndroidJavaObject plugin;
        public static System.Collections.Generic.List<string> QAHACK_LPNsLog;
        
        // Properties
        public static bool IsInitialized { get; }
        
        // Methods
        public static void Initialize(string gameName, bool available)
        {
            bool val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            System.Action<System.Collections.Generic.Dictionary<System.String, System.String>> val_28;
            var val_29;
            System.Action<System.String, System.String, System.String, System.String> val_30;
            var val_31;
            System.Action val_32;
            var val_33;
            System.Action val_34;
            System.Action val_35;
            var val_36;
            System.Action val_37;
            System.Action val_38;
            val_22 = available;
            val_23 = null;
            val_23 = null;
            twelvegigs.plugins.LocalNotificationsPlugin.GAME_NAME = gameName;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1145718912);
            val_24 = public static T[] System.Array::Empty<System.Object>();
            val_25 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_25 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_25 == 1)
            {
                    val_25 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_25 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            twelvegigs.plugins.LocalNotificationsPlugin.plugin = null;
            if(twelvegigs.plugins.LocalNotificationsPlugin.plugin == 0)
            {
                    return;
            }
            
            string val_3 = Localization.Localize(key:  -1811651424, defaultValue:  -1827401552, useSingularKey:  false);
            string val_4 = Localization.Localize(key:  1145719088, defaultValue:  1145719184, useSingularKey:  false);
            val_26 = null;
            val_26 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = "collect";
            typeof(System.Object[]).__il2cppRuntimeField_14 = "ignore_upper";
            Call(methodName:  1145719264, args:  472754880);
            val_24 = 1152921504614248448;
            System.Action<twelvegigs.storage.JsonDictionary> val_5 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  0, method:  new IntPtr(1145719360));
            twelvegigs.plugins.LocalNotificationsPlugin.notificationPoster = null;
            val_22 = 1152921514342504000;
            null = new System.Action<System.String, System.String, System.String, System.String>(object:  0, method:  new IntPtr(1145721408));
            twelvegigs.plugins.LocalNotificationsPlugin.notificationCanceller = null;
            System.Action val_7 = new System.Action(object:  0, method:  new IntPtr(1145723456));
            twelvegigs.plugins.LocalNotificationsPlugin.notificationsKiller = null;
            System.Action val_8 = new System.Action(object:  0, method:  new IntPtr(1145724480));
            twelvegigs.plugins.LocalNotificationsPlugin.notificationsEnabler = null;
            System.Action val_9 = new System.Action(object:  0, method:  new IntPtr(1145725504));
            twelvegigs.plugins.LocalNotificationsPlugin.notificationsClearer = null;
            CompanyDevices val_10 = CompanyDevices.Instance;
            if(0.CompanyDevice() == false)
            {
                goto label_24;
            }
            
            val_27 = null;
            val_27 = null;
            System.Action<twelvegigs.storage.JsonDictionary> val_12 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  0, method:  new IntPtr(1145726528));
            val_28 = twelvegigs.plugins.LocalNotificationsPlugin.notificationPoster;
            System.Delegate val_13 = System.Delegate.Combine(a:  7401472, b:  7401472);
            val_29 = null;
            if(val_28 == 0)
            {
                goto label_27;
            }
            
            val_24 = val_22;
            if(null == null)
            {
                goto label_28;
            }
            
            val_29 = 1152921505066164316;
            goto label_29;
            label_27:
            val_24 = val_22;
            label_29:
            val_28 = 0;
            label_28:
            val_22 = 1152921504614461440;
            twelvegigs.plugins.LocalNotificationsPlugin.notificationPoster = val_28;
            System.Action<System.String, System.String, System.String, System.String> val_14 = new System.Action<System.String, System.String, System.String, System.String>(object:  0, method:  new IntPtr(1145727552));
            val_30 = twelvegigs.plugins.LocalNotificationsPlugin.notificationCanceller;
            System.Delegate val_15 = System.Delegate.Combine(a:  7614464, b:  7614464);
            val_31 = null;
            if(val_30 == 0)
            {
                goto label_30;
            }
            
            if(null == null)
            {
                goto label_31;
            }
            
            val_31 = 1152921505066164316;
            label_30:
            val_30 = 0;
            label_31:
            twelvegigs.plugins.LocalNotificationsPlugin.notificationCanceller = val_30;
            System.Action val_16 = new System.Action(object:  0, method:  new IntPtr(1145728576));
            val_32 = twelvegigs.plugins.LocalNotificationsPlugin.notificationsKiller;
            System.Delegate val_17 = System.Delegate.Combine(a:  7454720, b:  7454720);
            val_33 = null;
            val_34 = null;
            if(val_32 == 0)
            {
                goto label_32;
            }
            
            if(null == val_34)
            {
                goto label_33;
            }
            
            val_34 = null;
            val_33 = 1152921505066164316;
            label_32:
            val_32 = 0;
            label_33:
            twelvegigs.plugins.LocalNotificationsPlugin.notificationsKiller = val_32;
            val_34 = new System.Action(object:  0, method:  new IntPtr(1145729600));
            val_35 = twelvegigs.plugins.LocalNotificationsPlugin.notificationsEnabler;
            System.Delegate val_19 = System.Delegate.Combine(a:  7454720, b:  7454720);
            val_36 = null;
            val_37 = null;
            if(val_35 == 0)
            {
                goto label_34;
            }
            
            if(null == val_37)
            {
                goto label_35;
            }
            
            val_37 = null;
            val_36 = 1152921505066164316;
            label_34:
            val_35 = 0;
            label_35:
            twelvegigs.plugins.LocalNotificationsPlugin.notificationsEnabler = val_35;
            val_37 = new System.Action(object:  0, method:  new IntPtr(1145730624));
            val_38 = twelvegigs.plugins.LocalNotificationsPlugin.notificationsClearer;
            System.Delegate val_21 = System.Delegate.Combine(a:  7454720, b:  7454720);
            if(val_38 != 0)
            {
                    if(null == null)
            {
                goto label_37;
            }
            
            }
            
            val_38 = 0;
            label_37:
            twelvegigs.plugins.LocalNotificationsPlugin.notificationsClearer = val_38;
            label_24:
            twelvegigs.plugins.LocalNotificationsPlugin.Setup();
            twelvegigs.plugins.LocalNotificationsPlugin.initialized = true;
            twelvegigs.plugins.LocalNotificationsPlugin.enabled = val_22;
        }
        private static void Setup()
        {
            var val_2 = null;
            if((UnityEngine.PlayerPrefs.GetInt(key:  1145847744, defaultValue:  2)) > 1)
            {
                    0 = 1;
            }
            
            twelvegigs.plugins.LocalNotificationsPlugin.notification_status = true;
        }
        private static System.DateTime OfficeHours(System.DateTime proposedTime)
        {
            var val_2;
            ulong val_6;
            var val_7;
            System.DateTime val_1 = proposedTime.dateData.ToLocalTime();
            val_6 = proposedTime.dateData;
            val_7 = val_2;
            goto label_1;
            label_4:
            System.DateTime val_3 = proposedTime.dateData.AddHours(value:  null);
            val_6 = proposedTime.dateData;
            val_7 = val_2;
            label_1:
            if((twelvegigs.plugins.LocalNotificationsPlugin.AtNight(time:  new System.DateTime() {dateData = val_6})) == true)
            {
                goto label_4;
            }
            
            System.DateTime val_5 = proposedTime.ToUniversalTime();
            return new System.DateTime() {dateData = val_5.dateData};
        }
        private static bool AtNight(System.DateTime time)
        {
            if(time.dateData.Hour > 7)
            {
                    return true;
            }
            
            if(time.dateData.Hour > 22)
            {
                    0 = 1;
            }
            
            return true;
        }
        public static void PostNotification(twelvegigs.plugins.NotificationType tipo, System.DateTime when, string optMessage, System.Collections.Generic.Dictionary<string, object> extraData)
        {
            string val_1;
            twelvegigs.plugins.LocalNotificationsPlugin.PostNotif(tipo:  tipo, when:  new System.DateTime() {dateData = 1}, interval:  optMessage, optTitle:  0, optMessage:  0, useTimeModifier:  extraData, extraData:  1, imgUrl:  val_1, priority:  0);
        }
        public static void PostNotification(twelvegigs.plugins.NotificationType tipo, System.DateTime when, string optTitle, string optMessage, System.Collections.Generic.Dictionary<string, object> extraData)
        {
            string val_1;
            twelvegigs.plugins.LocalNotificationsPlugin.PostNotif(tipo:  tipo, when:  new System.DateTime() {dateData = 1}, interval:  optTitle, optTitle:  0, optMessage:  optMessage, useTimeModifier:  extraData, extraData:  1, imgUrl:  val_1, priority:  0);
        }
        public static void PostNotification(twelvegigs.plugins.NotificationType tipo, System.DateTime when, twelvegigs.plugins.NotificationInterval interval, string optTitle, string optMessage, System.Collections.Generic.Dictionary<string, object> extraData, twelvegigs.plugins.NotificationPriority priority = 0, bool useTimeModifier = True)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2;
            bool val_3;
            val_2 = val_1;
            val_3 = useTimeModifier;
            val_2 = val_1;
            val_3 = useTimeModifier;
            twelvegigs.plugins.LocalNotificationsPlugin.PostNotif(tipo:  tipo, when:  new System.DateTime() {dateData = twelvegigs.plugins.LocalNotificationsPlugin.__il2cppRuntimeField_cctor_finished}, interval:  interval, optTitle:  optTitle, optMessage:  optMessage, useTimeModifier:  extraData, extraData:  val_2, imgUrl:  priority, priority:  0);
        }
        public static void PostRandomizedNotification(twelvegigs.plugins.NotificationType tipo, System.DateTime when, string optMessage, System.Collections.Generic.Dictionary<string, object> extraData)
        {
            string val_1;
            var val_3;
            twelvegigs.plugins.NotificationInterval val_12;
            System.DateTime val_2 = twelvegigs.plugins.LocalNotificationsPlugin.OfficeHours(proposedTime:  new System.DateTime() {dateData = 1152921514343432144});
            System.DateTime val_8 = new System.DateTime(year:  val_3.Year, month:  val_3.Month, day:  val_3.Day, hour:  9, minute:  0, second:  0);
            float val_9 = UnityEngine.Random.Range(min:  null, max:  null);
            System.DateTime val_10 = AddHours(value:  null);
            twelvegigs.plugins.LocalNotificationsPlugin.PostNotif(tipo:  tipo, when:  new System.DateTime() {dateData = 1152921514343432152}, interval:  val_12, optTitle:  0, optMessage:  0, useTimeModifier:  extraData, extraData:  0, imgUrl:  val_1, priority:  0);
        }
        public static void PostNotifWithImage(twelvegigs.plugins.NotificationType type, System.DateTime when, twelvegigs.plugins.NotificationInterval interval = 0, string title, string message, System.Collections.Generic.Dictionary<string, object> extraData, string imageUrl, twelvegigs.plugins.NotificationPriority priority = 0, bool useTimeModifier = True)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2;
            bool val_3;
            val_2 = val_1;
            val_3 = useTimeModifier;
            val_2 = val_1;
            val_3 = useTimeModifier;
            twelvegigs.plugins.LocalNotificationsPlugin.PostNotif(tipo:  type, when:  new System.DateTime() {dateData = twelvegigs.plugins.LocalNotificationsPlugin.__il2cppRuntimeField_cctor_finished}, interval:  interval, optTitle:  0, optMessage:  message, useTimeModifier:  extraData, extraData:  val_2, imgUrl:  imageUrl, priority:  priority);
        }
        private static void PostNotif(twelvegigs.plugins.NotificationType tipo, System.DateTime when, twelvegigs.plugins.NotificationInterval interval, string optTitle, string optMessage, bool useTimeModifier = True, System.Collections.Generic.Dictionary<string, object> extraData, string imgUrl, twelvegigs.plugins.NotificationPriority priority = 0)
        {
            ulong val_5;
            var val_10;
            var val_11;
            var val_14;
            var val_15;
            var val_27;
            twelvegigs.plugins.NotificationType val_29;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_30;
            string val_31;
            var val_32;
            var val_33;
            bool val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            val_29 = tipo;
            val_30 = 1152921505066164224;
            if(twelvegigs.plugins.LocalNotificationsPlugin.Available() == false)
            {
                    return;
            }
            
            if(twelvegigs.plugins.LocalNotificationsPlugin.IsNotificationEnabled() == false)
            {
                    return;
            }
            
            if((twelvegigs.plugins.LocalNotificationsPlugin.IsSingleInstanced(tipo:  val_29)) != false)
            {
                    twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  val_29);
            }
            
            if(optTitle > null)
            {
                    0 = 1;
            }
            
            val_31 = optMessage;
            System.DateTime val_4 = ToUniversalTime();
            if(extraData != 0)
            {
                    System.DateTime val_7 = twelvegigs.plugins.LocalNotificationsPlugin.OfficeHours(proposedTime:  new System.DateTime() {dateData = 1152921514343755744});
                System.DateTime val_8 = System.DateTime.UtcNow;
                System.TimeSpan val_9 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921514343755728}, d2:  new System.DateTime());
                val_32 = val_10;
                val_33 = val_11;
            }
            else
            {
                    System.DateTime val_12 = System.DateTime.UtcNow;
                System.TimeSpan val_13 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921514343755736}, d2:  new System.DateTime() {dateData = val_5});
                val_32 = val_14;
                val_33 = val_15;
            }
            
            double val_16 = val_32.TotalSeconds;
            val_34 = useTimeModifier;
            if(System.DateTime.__il2cppRuntimeField_cctor_finished == 0)
            {
                    1146974192 = 1146974192;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_31)) != false)
            {
                    val_35 = null;
                val_35 = null;
                val_31 = twelvegigs.plugins.LocalNotificationsPlugin.GAME_NAME;
            }
            
            if(val_34 != true)
            {
                    val_36 = null;
                val_36 = null;
                if((twelvegigs.plugins.LocalNotificationsPlugin.notification_messages + 12) > val_29)
            {
                    val_37 = null;
                val_37 = null;
                System.String[] val_18 = twelvegigs.plugins.LocalNotificationsPlugin.notification_messages + (val_29 << 2);
                string val_19 = twelvegigs.plugins.LocalNotificationsPlugin.LocalizeString(message:  (twelvegigs.plugins.LocalNotificationsPlugin.notification_messages + (tipo) << 2) + 16);
                val_34 = (twelvegigs.plugins.LocalNotificationsPlugin.notification_messages + (tipo) << 2) + 16;
            }
            else
            {
                    val_34 = "";
            }
            
            }
            
            if(imgUrl != null)
            {
                    string val_20 = MiniJSON.Json.Serialize(obj:  imgUrl);
                val_38 = imgUrl;
            }
            else
            {
                    val_38 = "{}";
            }
            
            val_39 = null;
            val_39 = null;
            val_30 = null;
            val_30 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if(val_30 != 0)
            {
                    Add(key:  1610240272, value:  val_31);
            }
            else
            {
                    Add(key:  1610240272, value:  val_31);
            }
            
            Add(key:  1495692992, value:  1098586544);
            string val_22 = optTitle.ToString();
            Add(key:  -1179997600, value:  1146974188);
            string val_23 = val_29.ToString();
            Add(key:  1350676976, value:  1146974188);
            string val_24 = 1.ToString();
            string val_25 = 1.ToLower();
            Add(key:  1146960944, value:  1146974207);
            if( >= 0f)
            {
                    string val_26 = ToString();
                val_40;
            }
            else
            {
                    val_40 = "0";
            }
            
            val_29 = val_27;
            if(val_30 != 0)
            {
                    Add(key:  -1898403488, value:  1254115712);
                Add(key:  1146961040, value:  -2040381152);
            }
            else
            {
                    Add(key:  -1898403488, value:  1254115712);
                Add(key:  1146961040, value:  -2040381152);
            }
            
            Add(key:  -1852101328, value:  priority);
            string val_28 = val_29.ToString();
            Add(key:  1146961136, value:  1146974188);
            twelvegigs.plugins.LocalNotificationsPlugin.notificationPoster.Invoke(obj:  78753792);
        }
        public static void EnableNotification(twelvegigs.plugins.NotificationType tipo)
        {
            string val_2;
            var val_3;
            var val_4;
            var val_5;
            twelvegigs.plugins.LocalNotificationsPlugin.ToggleNotification(val:  true);
            val_2 = 1152921504892043264;
            var val_2 = 9590946;
            val_2 = 26034592 + val_2;
            if(val_2 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_3 = null;
            val_3 = null;
            if(tipo != 2)
            {
                    return;
            }
            
            if(App.trackerManager == 0)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1147107024, value:  8945664);
            if(val_2 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_4 = null;
            val_4 = null;
            val_5 = null;
            val_5 = null;
            val_2 = Events.NOTIFICATAION_BONUS_CREDITS;
            App.trackerManager.track(eventName:  val_2, data:  78753792);
        }
        public static void DisableNotification(twelvegigs.plugins.NotificationType tipo)
        {
            string val_2;
            var val_3;
            var val_4;
            var val_5;
            twelvegigs.plugins.LocalNotificationsPlugin.ToggleNotification(val:  false);
            twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  tipo);
            val_2 = 1152921504892043264;
            var val_2 = 9590094;
            val_2 = 26035444 + val_2;
            if(val_2 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_3 = null;
            val_3 = null;
            if(tipo != 2)
            {
                    return;
            }
            
            if(App.trackerManager == 0)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1147107024, value:  8945664);
            if(val_2 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_4 = null;
            val_4 = null;
            val_5 = null;
            val_5 = null;
            val_2 = Events.NOTIFICATAION_BONUS_CREDITS;
            App.trackerManager.track(eventName:  val_2, data:  78753792);
        }
        public static void Clear()
        {
            var val_2;
            if(twelvegigs.plugins.LocalNotificationsPlugin.Available() == false)
            {
                    return;
            }
            
            val_2 = mem[R4];
            val_2 = R4;
            if((((R4 + 187) & 2) == 0) && ((R4 + 116) == 0))
            {
                    val_2 = mem[R4];
                val_2 = R4;
            }
            
            R4 + 92 + 36.Invoke();
        }
        public static void EnableNotifications()
        {
            var val_3;
            var val_5;
            var val_6;
            val_3 = null;
            val_3 = null;
            if(twelvegigs.plugins.LocalNotificationsPlugin.initialized == false)
            {
                    return;
            }
            
            twelvegigs.plugins.LocalNotificationsPlugin.notificationsEnabler.Invoke();
            twelvegigs.plugins.LocalNotificationsPlugin.ToggleNotification(val:  true);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1147455456, value:  8945664);
            var val_3 = 9589074;
            val_3 = 26036464 + val_3;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_5 = null;
            val_5 = null;
            val_6 = null;
            val_6 = null;
            App.trackerManager.track(eventName:  Events.NOTIFICATAION_ALL, data:  78753792);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  0, aName:  1147455584);
        }
        public static void DisableNotifications()
        {
            var val_4;
            var val_5;
            var val_6;
            if(twelvegigs.plugins.LocalNotificationsPlugin.Available() == false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            twelvegigs.plugins.LocalNotificationsPlugin.notificationsKiller.Invoke();
            twelvegigs.plugins.LocalNotificationsPlugin.ToggleNotification(val:  false);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1147455456, value:  8945664);
            var val_4 = 9588398;
            val_4 = 26037140 + val_4;
            if(val_4 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_5 = null;
            val_5 = null;
            val_6 = null;
            val_6 = null;
            App.trackerManager.track(eventName:  Events.NOTIFICATAION_ALL, data:  78753792);
            twelvegigs.plugins.LocalNotificationsPlugin.Clear();
            NotificationCenter val_3 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  0, aName:  1147455584);
        }
        public static void KillNotification(twelvegigs.plugins.NotificationType tipo)
        {
            System.Action<System.String, System.String, System.String, System.String> val_5;
            var val_6;
            string val_7;
            var val_8;
            var val_9;
            val_5 = 1152921505066164224;
            if(twelvegigs.plugins.LocalNotificationsPlugin.Available() == false)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            val_7 = 0;
            if((twelvegigs.plugins.LocalNotificationsPlugin.notification_messages + 12) > tipo)
            {
                    val_8 = null;
                val_8 = null;
                System.String[] val_2 = twelvegigs.plugins.LocalNotificationsPlugin.notification_messages + (tipo << 2);
                string val_3 = twelvegigs.plugins.LocalNotificationsPlugin.LocalizeString(message:  (twelvegigs.plugins.LocalNotificationsPlugin.notification_messages + (tipo) << 2) + 16);
                val_7 = (twelvegigs.plugins.LocalNotificationsPlugin.notification_messages + (tipo) << 2) + 16;
            }
            
            val_9 = null;
            val_9 = null;
            val_5 = twelvegigs.plugins.LocalNotificationsPlugin.notificationCanceller;
            string val_4 = tipo.ToString();
            val_5.Invoke(arg1:  1147696796, arg2:  twelvegigs.plugins.LocalNotificationsPlugin.GAME_NAME, arg3:  val_7, arg4:  "1");
        }
        private static bool IsSingleInstanced(twelvegigs.plugins.NotificationType tipo)
        {
            null = null;
            if(twelvegigs.plugins.LocalNotificationsPlugin.single_instanced != 0)
            {
                    return twelvegigs.plugins.LocalNotificationsPlugin.single_instanced.Contains(item:  tipo);
            }
            
            return twelvegigs.plugins.LocalNotificationsPlugin.single_instanced.Contains(item:  tipo);
        }
        private static void ToggleNotification(bool val)
        {
            null = null;
            if(val == true)
            {
                    1 = 2;
            }
            
            twelvegigs.plugins.LocalNotificationsPlugin.notification_status = val;
            UnityEngine.PlayerPrefs.SetInt(key:  1145847744, value:  2);
            bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
        }
        public static bool IsNotificationEnabled()
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            if(twelvegigs.plugins.LocalNotificationsPlugin.Available() != false)
            {
                    val_2 = null;
                val_2 = null;
                if(twelvegigs.plugins.LocalNotificationsPlugin.notification_status != true)
            {
                    val_3 = null;
                val_3 = null;
                typeof(System.Object[]).__il2cppRuntimeField_10 = null;
                UnityEngine.Debug.LogErrorFormat(format:  1148033120, args:  472754880);
                val_2 = null;
            }
            
                val_2 = null;
                if(twelvegigs.plugins.LocalNotificationsPlugin.notification_status == true)
            {
                    val_4 = 1;
            }
            
                return (bool)val_4;
            }
            
            val_5 = null;
            val_5 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            UnityEngine.Debug.LogErrorFormat(format:  1148033248, args:  472754880);
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            val_4 = 0;
            UnityEngine.Debug.LogErrorFormat(format:  1148033376, args:  472754880);
            return (bool)val_4;
        }
        public static bool Available()
        {
            var val_1 = null;
            if(twelvegigs.plugins.LocalNotificationsPlugin.enabled == false)
            {
                    return false;
            }
            
            if(twelvegigs.plugins.LocalNotificationsPlugin.initialized == true)
            {
                    twelvegigs.plugins.LocalNotificationsPlugin.initialized = 1;
            }
            
            return true;
        }
        public static bool get_IsInitialized()
        {
            null = null;
            return (bool)twelvegigs.plugins.LocalNotificationsPlugin.initialized;
        }
        public static bool AllOn()
        {
            null = null;
            return (bool)twelvegigs.plugins.LocalNotificationsPlugin.notification_status;
        }
        private static string Repeats(twelvegigs.plugins.NotificationType tipo)
        {
        
        }
        public static void RequestNotificationAccess()
        {
        
        }
        public static bool PermissionRequested()
        {
            return true;
        }
        private static void GeneralNotificationPosterLog(System.Collections.Generic.Dictionary<string, string> _params)
        {
            var val_11;
            string val_1 = _params.Item[1350676976];
            if(_params != 0)
            {
                    string val_2 = _params.Item[1610240272];
            }
            else
            {
                    string val_3 = _params.Item[1610240272];
            }
            
            string val_4 = _params.Item[1495692992];
            string val_5 = _params.Item[-1898403488];
            if(_params != 0)
            {
                    string val_6 = _params.Item[1146960944];
            }
            else
            {
                    string val_7 = _params.Item[1146960944];
            }
            
            string val_8 = _params.Item[-1179997600];
            val_11 = null;
            val_11 = null;
            int val_9 = System.Int32.Parse(s:  _params);
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_10 = System.String.Format(format:  1148829792, arg0:  459157504, arg1:  _params);
            twelvegigs.plugins.LocalNotificationsPlugin.QAHACK_LPNsLog.Add(item:  1148829792);
        }
        private static void GeneralNotificationCancellerLog(string tipo, string title, string message, string repeats)
        {
            null = null;
            int val_1 = System.Int32.Parse(s:  tipo);
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_2 = System.String.Format(format:  1148962448, arg0:  459157504);
            twelvegigs.plugins.LocalNotificationsPlugin.QAHACK_LPNsLog.Add(item:  1148962448);
        }
        private static void GeneralNotificationsDisablerLog()
        {
            null = null;
            twelvegigs.plugins.LocalNotificationsPlugin.QAHACK_LPNsLog.Add(item:  1149090992);
        }
        private static void GeneralNotificationsEnablerLog()
        {
            null = null;
            twelvegigs.plugins.LocalNotificationsPlugin.QAHACK_LPNsLog.Add(item:  1149203104);
        }
        private static void GeneralNotificationsClearerLog()
        {
            null = null;
            twelvegigs.plugins.LocalNotificationsPlugin.QAHACK_LPNsLog.Add(item:  1149315216);
        }
        private static void AndroidNotificationPoster(System.Collections.Generic.Dictionary<string, string> _params)
        {
            var val_12;
            string val_1 = _params.Item[1350676976];
            string val_2 = _params.Item[1610240272];
            string val_3 = _params.Item[1495692992];
            string val_4 = _params.Item[-1898403488];
            string val_5 = _params.Item[1146960944];
            string val_6 = _params.Item[-1179997600];
            string val_7 = _params.Item[1146961040];
            string val_8 = _params.Item[-1852101328];
            string val_9 = _params.Item[1146961136];
            string val_10 = Localization.Localize(key:  -1811651424, defaultValue:  -1827401552, useSingularKey:  false);
            string val_11 = Localization.Localize(key:  1145719088, defaultValue:  1145719184, useSingularKey:  false);
            val_12 = null;
            val_12 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = _params;
            typeof(System.Object[]).__il2cppRuntimeField_14 = _params;
            typeof(System.Object[]).__il2cppRuntimeField_18 = _params;
            typeof(System.Object[]).__il2cppRuntimeField_1C = _params;
            typeof(System.Object[]).__il2cppRuntimeField_20 = _params;
            typeof(System.Object[]).__il2cppRuntimeField_24 = _params;
            typeof(System.Object[]).__il2cppRuntimeField_28 = _params;
            typeof(System.Object[]).__il2cppRuntimeField_2C = _params;
            typeof(System.Object[]).__il2cppRuntimeField_30 = _params;
            twelvegigs.plugins.LocalNotificationsPlugin.plugin.Call(methodName:  1149431424, args:  472754880);
        }
        private static void AndroidNotificationCanceller(string tipo, string title, string message, string repeats)
        {
            null = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = tipo;
            typeof(System.Object[]).__il2cppRuntimeField_14 = title;
            typeof(System.Object[]).__il2cppRuntimeField_18 = message;
            typeof(System.Object[]).__il2cppRuntimeField_1C = repeats;
            twelvegigs.plugins.LocalNotificationsPlugin.plugin.Call(methodName:  1149564016, args:  472754880);
        }
        private static void AndroidNotificationsDisabler()
        {
            null = null;
            twelvegigs.plugins.LocalNotificationsPlugin.plugin.Call(methodName:  1149692512, args:  472754880);
        }
        private static void AndroidNotificationsEnabler()
        {
            null = null;
            twelvegigs.plugins.LocalNotificationsPlugin.enabled = true;
            twelvegigs.plugins.LocalNotificationsPlugin.plugin.Call(methodName:  1149804624, args:  472754880);
        }
        private static void AndroidNotificationsClearer()
        {
        
        }
        private static string LocalizeString(string message)
        {
            return Localization.Localize(key:  message, defaultValue:  1098586544, useSingularKey:  false);
        }
        public static twelvegigs.plugins.NotificationType ConvertIdToNotification(string id)
        {
            return System.Int32.Parse(s:  id);
        }
        public LocalNotificationsPlugin()
        {
        
        }
        private static LocalNotificationsPlugin()
        {
            var val_3;
            twelvegigs.plugins.LocalNotificationsPlugin.GAME_NAME = "";
            twelvegigs.plugins.LocalNotificationsPlugin.initialized = false;
            twelvegigs.plugins.LocalNotificationsPlugin.enabled = false;
            typeof(System.String[]).__il2cppRuntimeField_10 = "ALL_NOTS";
            typeof(System.String[]).__il2cppRuntimeField_14 = "GENERAL";
            typeof(System.String[]).__il2cppRuntimeField_18 = "NM_BONUS";
            typeof(System.String[]).__il2cppRuntimeField_1C = "";
            typeof(System.String[]).__il2cppRuntimeField_20 = "";
            typeof(System.String[]).__il2cppRuntimeField_24 = "NM_FREE_HINT_48";
            typeof(System.String[]).__il2cppRuntimeField_28 = "NM_FREE_HINT_1";
            typeof(System.String[]).__il2cppRuntimeField_2C = "POST_AD";
            typeof(System.String[]).__il2cppRuntimeField_30 = "";
            typeof(System.String[]).__il2cppRuntimeField_34 = "";
            typeof(System.String[]).__il2cppRuntimeField_38 = "";
            typeof(System.String[]).__il2cppRuntimeField_3C = "";
            typeof(System.String[]).__il2cppRuntimeField_40 = "";
            typeof(System.String[]).__il2cppRuntimeField_44 = "";
            typeof(System.String[]).__il2cppRuntimeField_48 = "INSTALL_RECAPTURE";
            typeof(System.String[]).__il2cppRuntimeField_4C = "LEVEL_ANSWER";
            typeof(System.String[]).__il2cppRuntimeField_50 = "DC_REMINDER_M";
            typeof(System.String[]).__il2cppRuntimeField_54 = "DC_REMINDER_E";
            typeof(System.String[]).__il2cppRuntimeField_58 = "PB_REMINDER";
            typeof(System.String[]).__il2cppRuntimeField_5C = "GT_FREE_TRIAL";
            typeof(System.String[]).__il2cppRuntimeField_60 = "";
            typeof(System.String[]).__il2cppRuntimeField_64 = "LIVES_REMINDER";
            typeof(System.String[]).__il2cppRuntimeField_68 = "";
            typeof(System.String[]).__il2cppRuntimeField_6C = "";
            typeof(System.String[]).__il2cppRuntimeField_70 = "FEED_YOUR_PET";
            typeof(System.String[]).__il2cppRuntimeField_74 = "EXTRA_LIFE_READY";
            typeof(System.String[]).__il2cppRuntimeField_78 = "";
            typeof(System.String[]).__il2cppRuntimeField_7C = "";
            typeof(System.String[]).__il2cppRuntimeField_80 = "TOURNAMENTS_ENDED";
            typeof(System.String[]).__il2cppRuntimeField_84 = "";
            typeof(System.String[]).__il2cppRuntimeField_88 = "";
            typeof(System.String[]).__il2cppRuntimeField_8C = "";
            typeof(System.String[]).__il2cppRuntimeField_90 = "";
            twelvegigs.plugins.LocalNotificationsPlugin.notification_messages = null;
            twelvegigs.plugins.LocalNotificationsPlugin.notification_status = true;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            if(null != 0)
            {
                    val_3 = 1152921510720759024;
                Add(item:  2);
                Add(item:  5);
                Add(item:  6);
                Add(item:  7);
                Add(item:  14);
                Add(item:  15);
                Add(item:  16);
                Add(item:  17);
                Add(item:  25);
                Add(item:  26);
            }
            else
            {
                    val_3 = 1152921510720759024;
                Add(item:  2);
                Add(item:  5);
                Add(item:  6);
                Add(item:  7);
                Add(item:  14);
                Add(item:  15);
                Add(item:  16);
                Add(item:  17);
                Add(item:  25);
                Add(item:  26);
            }
            
            Add(item:  28);
            twelvegigs.plugins.LocalNotificationsPlugin.single_instanced = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            twelvegigs.plugins.LocalNotificationsPlugin.QAHACK_LPNsLog = null;
        }
    
    }

}
