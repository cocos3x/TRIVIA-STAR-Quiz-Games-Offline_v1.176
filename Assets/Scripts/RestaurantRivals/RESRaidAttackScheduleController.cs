using UnityEngine;

namespace RestaurantRivals
{
    public class RESRaidAttackScheduleController : MonoBehaviour
    {
        // Fields
        private const float GENERAL_CHECK_INTERVAL = 1;
        private const float INGAME_CHECK_INTERVAL = 60;
        private const float OFFGAME_CHECK_INTERVAL = 60;
        private const float INACTIVITY_THRESHOLD = 1200;
        private RestaurantRivals.RESRaidAttackSchedule inGameOffensiveSchedule;
        private System.DateTime lastInGameCheck;
        private System.DateTime lastOffGameCheck;
        private System.Collections.Generic.List<RestaurantRivals.NewsArticle> articlesToShow;
        
        // Methods
        private void OnSceneUnloaded(SceneType sceneType)
        {
            if(sceneType != 11)
            {
                    return;
            }
            
            if(true == 0)
            {
                    return;
            }
            
            RestaurantRivals.NewsArticle val_1 = this.GetNextArticle();
            if(this == 0)
            {
                    return;
            }
            
            GameBehavior val_2 = App.getBehavior;
            0.Setup(data:  597613216);
        }
        private void Awake()
        {
            var val_4;
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            System.Action<Result> val_2 = new System.Action<Result>(object:  597734432, method:  new IntPtr(597709408));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10, b:  7401472);
            val_4 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10;
            if(val_4 != 0)
            {
                    if(val_4 == null)
            {
                goto label_6;
            }
            
            }
            
            val_4 = 0;
            label_6:
            public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10 = val_4;
        }
        private void OnDestroy()
        {
            var val_4;
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            System.Action<Result> val_2 = new System.Action<Result>(object:  597846432, method:  new IntPtr(597709408));
            System.Delegate val_3 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10, value:  7401472);
            val_4 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10;
            if(val_4 != 0)
            {
                    if(val_4 == null)
            {
                goto label_6;
            }
            
            }
            
            val_4 = 0;
            label_6:
            public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10 = val_4;
        }
        private void Start()
        {
            ulong val_3;
            var val_4;
            var val_15;
            ulong val_16;
            var val_17;
            var val_18;
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  597934432, defaultValue:  1098586544);
            val_15 = null;
            val_15 = null;
            System.DateTime val_2 = SLCDateTime.ParseInvariant(dateTime:  597946696, defaultValue:  new System.DateTime() {dateData = 1152921513794716000});
            val_16 = val_3;
            val_17 = val_4;
            string val_5 = 597934544 + 9904128;
            val_16 = val_16;
            val_17 = val_17;
            UnityEngine.Debug.LogError(message:  597934544);
            if((System.DateTime.op_Inequality(d1:  new System.DateTime() {dateData = val_16}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) != false)
            {
                    System.DateTime val_7 = DateTimeCheat.UtcNow;
                System.DateTime val_8 = val_16.AddSeconds(value:  null);
                bool val_9 = System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_3}, t2:  new System.DateTime() {dateData = val_16});
                if(val_9 == true)
            {
                    val_9 = this;
                this.ExecuteOffGameOffensiveActions();
            }
            
            }
            
            val_18 = null;
            val_18 = null;
            if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_16}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) != false)
            {
                    System.DateTime val_11 = DateTimeCheat.UtcNow;
                string val_12 = SLCDateTime.SerializeInvariant(dateTime:  new System.DateTime() {dateData = val_3});
                UnityEngine.PlayerPrefs.SetString(key:  597934432, value:  val_3);
            }
            
            this.SchedulInGameOffensiveActions();
            this.ScheduleOffGameOffensiveActions();
            System.DateTime val_13 = DateTimeCheat.UtcNow;
            this.lastInGameCheck = val_3;
            System.DateTime val_14 = DateTimeCheat.UtcNow;
            this.lastOffGameCheck = val_16;
            this.InvokeRepeating(methodName:  597934656, time:  null, repeatRate:  null);
        }
        private void OnApplicationFocus(bool focus)
        {
            this.OnPauseGame(isPaused:  focus);
        }
        private void OnApplicationPause(bool pause)
        {
            this.OnPauseGame(isPaused:  pause);
        }
        private void OnApplicationQuit()
        {
            this.ScheduleOffGameOffensiveActions();
        }
        private void OnPauseGame(bool isPaused)
        {
            ulong val_3;
            var val_4;
            var val_10;
            var val_11;
            ulong val_12;
            val_10 = 35636919;
            if(isPaused != false)
            {
                    this.ScheduleOffGameOffensiveActions();
                return;
            }
            
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  597934432, defaultValue:  1098586544);
            val_11 = null;
            val_11 = null;
            System.DateTime val_2 = SLCDateTime.ParseInvariant(dateTime:  598394704, defaultValue:  new System.DateTime() {dateData = 1152921513794716000});
            val_12 = val_3;
            val_10 = val_4;
            string val_5 = 597934544 + 9904128;
            val_12 = val_12;
            val_10 = val_10;
            UnityEngine.Debug.LogError(message:  597934544);
            if((System.DateTime.op_Inequality(d1:  new System.DateTime() {dateData = val_12}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) == false)
            {
                    return;
            }
            
            System.DateTime val_7 = DateTimeCheat.UtcNow;
            System.DateTime val_8 = val_12.AddSeconds(value:  null);
            if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_3}, t2:  new System.DateTime() {dateData = val_12})) == false)
            {
                    return;
            }
            
            this.ExecuteOffGameOffensiveActions();
            this.ScheduleOffGameOffensiveActions();
            this.SchedulInGameOffensiveActions();
        }
        public RestaurantRivals.NewsArticle GetNextArticle()
        {
            var val_1 = 0;
            if(R1 == 0)
            {
                    return;
            }
            
            val_1 = mem[R2 + 16];
            val_1 = R2 + 16;
            this.articlesToShow.Clear();
        }
        private void SlowUpdate()
        {
            ulong val_2;
            ulong val_6;
            long val_10;
            long val_12;
            var val_23 = 1152921504888102912;
            System.DateTime val_1 = DateTimeCheat.UtcNow;
            string val_4 = SLCDateTime.SerializeInvariant(dateTime:  new System.DateTime() {dateData = val_2});
            UnityEngine.PlayerPrefs.SetString(key:  597934432, value:  val_2);
            System.DateTime val_5 = DateTimeCheat.UtcNow;
            System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513795421760}, d2:  new System.DateTime() {dateData = val_6});
            System.TimeSpan val_9 = System.TimeSpan.FromSeconds(value:  null);
            if((System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_12}, t2:  new System.TimeSpan() {_ticks = val_10})) == false)
            {
                goto label_18;
            }
            
            System.DateTime val_15 = DateTimeCheat.UtcNow;
            this.lastInGameCheck = val_2;
            if(this.inGameOffensiveSchedule == 0)
            {
                goto label_10;
            }
            
            System.DateTime val_16 = DateTimeCheat.UtcNow;
            if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = this.inGameOffensiveSchedule.time})) == false)
            {
                goto label_16;
            }
            
            this.ExecuteInGameOffensiveActions();
            this.SchedulInGameOffensiveActions();
            val_23 = val_23;
            goto label_18;
            label_16:
            val_23 = val_23;
            if(this.inGameOffensiveSchedule != 0)
            {
                goto label_18;
            }
            
            label_10:
            this.SchedulInGameOffensiveActions();
            label_18:
            System.DateTime val_18 = DateTimeCheat.UtcNow;
            System.TimeSpan val_19 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513795421768}, d2:  new System.DateTime() {dateData = val_2});
            System.TimeSpan val_20 = System.TimeSpan.FromSeconds(value:  null);
            if((System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_6}, t2:  new System.TimeSpan() {_ticks = val_12})) == false)
            {
                    return;
            }
            
            System.DateTime val_22 = DateTimeCheat.UtcNow;
            this.lastOffGameCheck = val_2;
            this.ScheduleOffGameOffensiveActions();
        }
        private void UpdateOffGameSchedule()
        {
            this.ScheduleOffGameOffensiveActions();
        }
        private void SchedulInGameOffensiveActions()
        {
            var val_16;
            var val_17;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            if((this.PlayerCanBeAttacked(potentialAttacks:  0)) != true)
            {
                    val_19 = 1152921504617017344;
                val_20 = null;
                val_20 = null;
                bool val_2 = System.Decimal.Powers10.__il2cppRuntimeField_10.PlayerCanBeRaided(potentialRaids:  0, potentialLoss:  new System.Decimal() {flags = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
                if(val_2 == false)
            {
                    return;
            }
            
            }
            
            float val_3 = UnityEngine.Random.Range(min:  null, max:  null);
            val_21 = null;
            if(val_2 > false)
            {
                    0 = 1;
            }
            
            bool val_5 = this.PlayerCanBeAttacked(potentialAttacks:  0);
            val_21 = null;
            val_22 = 0;
            bool val_6 = System.Decimal.Powers10.__il2cppRuntimeField_10.PlayerCanBeRaided(potentialRaids:  0, potentialLoss:  new System.Decimal() {flags = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
            val_6 = val_6 ^ 1;
            RestaurantRivals.RESPlayer val_7 = RestaurantRivals.RESPlayer.Instance;
            if(((val_6 ^ 1) + 296) >= 1)
            {
                    1152921504617017344 = 2;
            }
            
            val_22 = 1152921504617017344;
            RestaurantRivals.RESGameEcon val_8 = RestaurantRivals.RESGameEcon.Instance;
            RestaurantRivals.RESGameEcon val_9 = RestaurantRivals.RESGameEcon.Instance;
            float val_11 = ((float)UnityEngine.Random.Range(min:  0, max:  0)) * 60f;
            System.DateTime val_12 = DateTimeCheat.UtcNow;
            System.DateTime val_15 = AddSeconds(value:  null);
            val_19 = val_16;
            typeof(RestaurantRivals.RESRaidAttackSchedule).__il2cppRuntimeField_8 = val_19;
            typeof(RestaurantRivals.RESRaidAttackSchedule).__il2cppRuntimeField_C = val_17;
            typeof(RestaurantRivals.RESRaidAttackSchedule).__il2cppRuntimeField_10 = val_22;
            this.inGameOffensiveSchedule = new System.Object();
        }
        private void ScheduleOffGameOffensiveActions()
        {
            int val_9;
            twelvegigs.plugins.NotificationInterval val_18;
            string val_30;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_31;
            float val_32;
            var val_33;
            var val_34;
            RestaurantRivals.RESGameEcon val_1 = RestaurantRivals.RESGameEcon.Instance;
            val_30 = 0;
            RestaurantRivals.RESGameEcon val_2 = RestaurantRivals.RESGameEcon.Instance;
            float val_31 = 0f;
            val_31 = 0;
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            var val_33 = 1030672;
            twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  30);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            var val_5 = val_31 * val_30;
            if(val_5 >= 1)
            {
                    val_32 = 0;
                val_31 = 86400f / val_31;
                val_33 = 0;
                do
            {
                if((this.PlayerCanBeAttacked(potentialAttacks:  0)) != true)
            {
                    if((this.PlayerCanBeRaided(potentialRaids:  0, potentialLoss:  new System.Decimal())) == false)
            {
                goto label_10;
            }
            
            }
            
                System.DateTime val_8 = System.DateTime.UtcNow;
                System.DateTime val_11 = AddSeconds(value:  null);
                float val_32 = 0f;
                val_32 = val_31 * val_32;
                System.DateTime val_14 = AddSeconds(value:  null);
                float val_15 = UnityEngine.Random.Range(min:  val_32, max:  null);
                System.DateTime val_16 = AddSeconds(value:  null);
                float val_19 = UnityEngine.Random.Range(min:  0, max:  null);
                bool val_21 = this.PlayerCanBeRaided(potentialRaids:  0, potentialLoss:  new System.Decimal());
                val_21 = val_21 ^ 1;
                if(System.DateTime.__il2cppRuntimeField_cctor_finished > 0)
            {
                    0 = 1;
            }
            
                val_21 = (1 & (this.PlayerCanBeAttacked(potentialAttacks:  0))) | val_21;
                if((val_33 >= 1) && (val_21 != false))
            {
                    val_33 = val_33 - 1;
                val_34 = 2;
            }
            else
            {
                    if(val_21 != false)
            {
                    val_32 = val_32 + 1;
                val_34 = 1;
            }
            else
            {
                    Player val_23 = App.Player;
                Player val_24 = App.Player;
                decimal val_25 = RestaurantRivals.RESGameEconHelper.GetPotentialRaidValue(level:  598990624, playerCredits:  new System.Decimal() {hi = 52, lo = 52, mid = 256});
                var val_34 = 0;
                val_34 = 0;
                val_34 = val_34 + 1;
                decimal val_26 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 598990608}, d2:  new System.Decimal() {mid = val_9});
            }
            
            }
            
                object val_27 = new System.Object();
                Add(item:  427155456);
                val_30 = "Restaurant Rivals";
                string val_28 = GetOffensiveActionLPNMessage(action:  0);
                val_31 = "Restaurant Rivals";
                twelvegigs.plugins.LocalNotificationsPlugin.PostNotification(tipo:  30, when:  new System.DateTime() {dateData = twelvegigs.plugins.LocalNotificationsPlugin.__il2cppRuntimeField_cctor_finished}, interval:  val_18, optTitle:  0, optMessage:  val_30, extraData:  val_31, priority:  0, useTimeModifier:  false);
                val_33 = val_33 + 1;
                val_32 = val_34;
            }
            while(val_33 < val_5);
            
            }
            
            label_10:
            string val_29 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  80883712);
            UnityEngine.PlayerPrefs.SetString(key:  598978592, value:  80883712);
            bool val_30 = PrefsSerializationManager.SavePlayerPrefs();
        }
        private string GetOffensiveActionLPNTitle()
        {
        
        }
        private string GetOffensiveActionLPNMessage(RestaurantRivals.RESOffensiveAction action)
        {
            var val_1;
            if(action <= 2)
            {
                    val_1 = mem[34443604 + (action) << 2];
                val_1 = 34443604 + (action) << 2;
                return;
            }
            
            val_1 = "";
        }
        private void ExecuteInGameOffensiveActions()
        {
            bool val_4 = static_value_021FC6BE;
            if(val_4 != true)
            {
                    val_4 = true;
            }
            
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            string val_3 = System.String.Format(format:  599322896, arg0:  13152256, arg1:  13152256);
            UnityEngine.Debug.LogError(message:  599322896);
            if(this.inGameOffensiveSchedule.action == 2)
            {
                goto label_6;
            }
            
            if(this.inGameOffensiveSchedule.action != 1)
            {
                goto label_7;
            }
            
            this.ExecuteAttackOnPlayer(schedule:  this.inGameOffensiveSchedule, showFlyout:  true);
            return;
            label_6:
            this.ExecuteAttackBlockedOnPlayer(schedule:  this.inGameOffensiveSchedule, showFlyout:  true);
            return;
            label_7:
            this.ExecuteRaidOnPlayer(schedule:  this.inGameOffensiveSchedule, showFlyout:  true);
        }
        private void ExecuteOffGameOffensiveActions()
        {
            ulong val_2;
            RestaurantRivals.RESRaidAttackSchedule val_12;
            System.DateTime val_1 = DateTimeCheat.UtcNow;
            UnityEngine.Debug.LogError(message:  9904128);
            RestaurantRivals.RESPlayer val_4 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_5 = RestaurantRivals.RESPlayer.Instance;
            string val_6 = System.String.Format(format:  599322896, arg0:  13152256, arg1:  13152256);
            UnityEngine.Debug.LogError(message:  599322896);
            string val_7 = UnityEngine.PlayerPrefs.GetString(key:  598978592, defaultValue:  1098586544);
            if((System.String.IsNullOrEmpty(value:  598978592)) == true)
            {
                    return;
            }
            
            object val_9 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  598978592);
            if("RES_OffensiveActions" != 0)
            {
                    public static System.Collections.Generic.List<RestaurantRivals.RESRaidAttackSchedule> Newtonsoft.Json.JsonConvert::DeserializeObject<System.Collections.Generic.List<RestaurantRivals.RESRaidAttackSchedule>>(string value) = "RES_OffensiveActions";
            }
            
            List.Enumerator<T> val_10 = GetEnumerator();
            label_22:
            if(MoveNext() == false)
            {
                goto label_11;
            }
            
            System.DateTime val_13 = DateTimeCheat.UtcNow;
            if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = val_12 + 8})) == false)
            {
                goto label_22;
            }
            
            if((val_12 + 16) == 1)
            {
                goto label_18;
            }
            
            if((val_12 + 16) != 2)
            {
                goto label_19;
            }
            
            this.ExecuteAttackBlockedOnPlayer(schedule:  val_12, showFlyout:  false);
            goto label_22;
            label_18:
            this.ExecuteAttackOnPlayer(schedule:  val_12, showFlyout:  false);
            goto label_22;
            label_19:
            this.ExecuteRaidOnPlayer(schedule:  val_12, showFlyout:  false);
            goto label_22;
            label_11:
            Dispose();
        }
        private void ExecuteAttackOnPlayer(RestaurantRivals.RESRaidAttackSchedule schedule, bool showFlyout = False)
        {
            bool val_21;
            var val_22;
            RestaurantRivals.UserRestaurantProfile val_23;
            RestaurantRivals.UserRestaurantProfile val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            val_21 = showFlyout;
            val_22 = 35636928;
            bool val_1 = RestaurantRivals.RESFTUXManager.IsCompleteFTUX(FTUXType:  17);
            if(val_1 == false)
            {
                    return;
            }
            
            if((val_1.PlayerCanBeAttacked(potentialAttacks:  0)) == false)
            {
                    return;
            }
            
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            if((val_2 + 296) >= 1)
            {
                    this.ExecuteAttackBlockedOnPlayer(schedule:  schedule, showFlyout:  val_21);
                return;
            }
            
            RestaurantRivals.RESPlayer val_4 = RestaurantRivals.RESPlayer.Instance;
            val_23 = val_2 + 296;
            RestaurantRivals.RESPlayer val_5 = RestaurantRivals.RESPlayer.Instance;
            int val_8 = UnityEngine.Random.Range(min:  val_23 - 1, max:  (val_2 + 296) + 2);
            RestaurantRivals.UserRestaurantProfile val_9 = RestaurantRivals.UserRestaurantProfile.CreateDummyProfile(baseLevel:  val_8, forAttack:  false, objectAmount:  0);
            val_24 = val_8;
            RestaurantRivals.RESPlayer val_10 = RestaurantRivals.RESPlayer.Instance;
            val_22 = mem[val_8 + 348];
            val_22 = val_8 + 348;
            RestaurantRivals.MapItem val_11 = val_22.GetRandomObjectForAttack();
            if(val_22 == 0)
            {
                    return;
            }
            
            mem2[0] = 2;
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            DebitBalance(debitAmount:  1, source:  599596224, additionalParams:  0);
            NotificationCenter val_13 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  599620592, aName:  -2092882624);
            NotificationCenter val_14 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  599620592, aName:  599596320);
            RestaurantRivals.RESPlayer val_15 = RestaurantRivals.RESPlayer.Instance;
            if(0 != 0)
            {
                    val_25 = 0;
                val_26 = 0;
            }
            else
            {
                    val_25 = 364;
                val_26 = 0;
            }
            
            mem[364] = val_26 + 1;
            val_24.ProgressMapForAttack();
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_14.AddRevengeOpponent(profile:  val_24);
            val_27 = null;
            val_23 = val_24;
            val_28 = val_21;
            val_24 = System.Decimal.Zero;
            RestaurantRivals.NewsArticle val_18 = new RestaurantRivals.NewsArticle(_user:  null, _action:  1, _time:  new System.DateTime(), _amount:  new System.Decimal() {flags = schedule + 8 + 4, hi = val_24});
            twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_21 = this;
            public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_14.AddToNewsArticles(news:  426942464);
            if( != false)
            {
                    this.SaveOrShowNews(article:  426942464);
            }
            
            val_22 = null;
            string val_20 = System.String.Format(format:  599596432, arg0:  val_8 + 16, arg1:  13152256, arg2:  9904128);
            UnityEngine.Debug.LogError(message:  599596432);
            Player val_21 = App.Player;
            0.SaveState();
        }
        private void ExecuteAttackBlockedOnPlayer(RestaurantRivals.RESRaidAttackSchedule schedule, bool showFlyout = False)
        {
            RestaurantRivals.RESRaidAttackScheduleController val_18;
            bool val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            val_18 = this;
            val_19 = showFlyout;
            bool val_1 = this.PlayerCanBeAttacked(potentialAttacks:  0);
            if(val_1 == false)
            {
                    return;
            }
            
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            if((val_1 + 296) <= 0)
            {
                goto label_4;
            }
            
            RestaurantRivals.RESPlayer val_4 = RestaurantRivals.RESPlayer.Instance;
            int val_7 = UnityEngine.Random.Range(min:  val_1 - 1, max:  val_1 + 2);
            RestaurantRivals.UserRestaurantProfile val_8 = RestaurantRivals.UserRestaurantProfile.CreateDummyProfile(baseLevel:  val_7, forAttack:  false, objectAmount:  0);
            RestaurantRivals.RESPlayer val_9 = RestaurantRivals.RESPlayer.Instance;
            if(val_7 == 0)
            {
                goto label_6;
            }
            
            val_20 = val_7;
            val_21 = mem[val_7 + 296];
            val_21 = val_7 + 296;
            goto label_7;
            label_4:
            mem2[0] = 0;
            this.ExecuteAttackOnPlayer(schedule:  schedule, showFlyout:  val_19);
            Player val_10 = App.Player;
            0.SaveState();
            return;
            label_6:
            val_20 = 296;
            val_21 = 1030672;
            label_7:
            mem[296] = 1030671;
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            RecalcSession();
            val_7.ProgressMapForAttack();
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_14.AddRevengeOpponent(profile:  val_7);
            val_22 = null;
            val_22 = null;
            val_19 = System.Decimal.Zero;
            RestaurantRivals.NewsArticle val_13 = new RestaurantRivals.NewsArticle(_user:  val_7, _action:  2, _time:  new System.DateTime(), _amount:  new System.Decimal() {flags = schedule + 8 + 4, hi = val_19, lo = System.Decimal.Powers10.__il2cppRuntimeField_8, mid = System.Decimal.Powers10.__il2cppRuntimeField_C});
            twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_23 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_14;
            val_23.AddToNewsArticles(news:  426942464);
            if(val_19 != false)
            {
                    val_23 = val_18;
                this.SaveOrShowNews(article:  426942464);
            }
            
            RestaurantRivals.RESPlayer val_15 = RestaurantRivals.RESPlayer.Instance;
            string val_16 = System.String.Format(format:  599716784, arg0:  val_7 + 16, arg1:  13152256, arg2:  9904128);
            UnityEngine.Debug.LogError(message:  599716784);
            Player val_17 = App.Player;
            0.SaveState();
        }
        private void ExecuteRaidOnPlayer(RestaurantRivals.RESRaidAttackSchedule schedule, bool showFlyout = False)
        {
            int val_10;
            int val_11;
            int val_12;
            int val_13;
            int val_21;
            int val_22;
            int val_23;
            int val_24;
            RestaurantRivals.RESRaidAttackScheduleController val_31;
            bool val_32;
            float val_33;
            var val_34;
            int val_35;
            int val_36;
            int val_37;
            int val_38;
            var val_41;
            var val_42;
            val_31 = this;
            val_32 = showFlyout;
            val_33 = 1152921504617017344;
            val_34 = null;
            val_34 = null;
            bool val_1 = System.Decimal.Powers10.__il2cppRuntimeField_10.PlayerCanBeRaided(potentialRaids:  0, potentialLoss:  new System.Decimal() {flags = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
            if(val_1 == false)
            {
                    return;
            }
            
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            int val_6 = UnityEngine.Random.Range(min:  val_1 - 1, max:  val_1 + 2);
            RestaurantRivals.UserRestaurantProfile val_7 = RestaurantRivals.UserRestaurantProfile.CreateDummyProfile(baseLevel:  val_6, forAttack:  false, objectAmount:  0);
            RestaurantRivals.RESPlayer val_8 = RestaurantRivals.RESPlayer.Instance;
            decimal val_9 = RestaurantRivals.RESGameEconHelper.GetRaidTreasureAmount(level:  599849240, maxValueLimit:  new System.Decimal() {flags = val_6 + 24, hi = val_6 + 60, lo = val_6 + 64, mid = val_6 + 68});
            val_35 = val_10;
            val_36 = val_11;
            val_37 = val_12;
            val_38 = val_13;
            int val_14 = UnityEngine.Random.Range(min:  0, max:  4);
            if(val_14 != 0)
            {
                    if(val_14 > 2)
            {
                    decimal val_15 = new System.Decimal(value:  3);
                decimal val_16 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 599849240, hi = val_35, lo = val_36, mid = val_37}, d2:  new System.Decimal() {flags = val_38, hi = val_15.flags, lo = val_15.hi, mid = val_15.lo});
                val_35 = val_15.flags;
                val_36 = val_15.hi;
                val_37 = val_15.lo;
                val_38 = val_15.mid;
            }
            else
            {
                    decimal val_17 = new System.Decimal(value:  5);
                decimal val_18 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 599849240, hi = val_35, lo = val_36, mid = val_37}, d2:  new System.Decimal() {flags = val_38, hi = val_17.flags, lo = val_17.hi, mid = val_17.lo});
                decimal val_19 = new System.Decimal(value:  6);
                decimal val_20 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 599849208, hi = val_17.flags, lo = val_17.hi, mid = val_17.lo}, d2:  new System.Decimal() {flags = val_17.mid, hi = val_19.flags, lo = val_19.hi, mid = val_19.lo});
                val_35 = val_21;
                val_36 = val_22;
                val_37 = val_23;
                val_38 = val_24;
            }
            
            }
            
            bool val_25 = CurrencyController.DebitBalance(value:  new System.Decimal() {flags = val_35, hi = val_36, lo = val_37, mid = val_38}, source:  "Raided", externalParams:  0, animated:  true);
            val_32 = val_37;
            twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_31 = val_35;
            RecalcSession();
            RestaurantRivals.RESPlayer val_27 = RestaurantRivals.RESPlayer.Instance;
            if((public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance()) != 0)
            {
                    val_41 = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance();
            }
            else
            {
                    val_41 = 360;
                val_42 = 0;
            }
            
            mem[360] = 1;
            val_33 = schedule + 8;
            RestaurantRivals.NewsArticle val_28 = new RestaurantRivals.NewsArticle(_user:  val_6, _action:  0, _time:  new System.DateTime() {dateData = val_38}, _amount:  new System.Decimal() {flags = schedule + 8 + 4, hi = val_31, lo = val_36, mid = val_32});
            twelvegigs.Autopilot.AutopilotManager val_29 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_14.AddToNewsArticles(news:  426942464);
            if(val_32 != false)
            {
                    this.SaveOrShowNews(article:  426942464);
            }
            
            val_11 = val_36;
            val_10 = val_31;
            val_12 = val_32;
            val_13 = val_38;
            val_11 = val_38;
            val_10 = val_33;
            string val_30 = System.String.Format(format:  599837168, arg0:  val_6 + 16, arg1:  10170368, arg2:  9904128);
            UnityEngine.Debug.LogError(message:  599837168);
        }
        private bool PlayerCanBeAttacked(int potentialAttacks = 0)
        {
            bool val_6 = static_value_021FC6C3;
            if(val_6 != true)
            {
                    val_6 = true;
            }
            
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            if(RestaurantRivals.RESManager.IsGameStartFtuxFinished == false)
            {
                    return false;
            }
            
            if(val_6 <= 2)
            {
                    if(100667322 == 0)
            {
                    return false;
            }
            
            }
            
            if(0.ContainsAttackableObjects == false)
            {
                    return false;
            }
            
            RestaurantRivals.RESGameEcon val_4 = RestaurantRivals.RESGameEcon.Instance;
            if((0 + potentialAttacks) < 1302)
            {
                    0 = 1;
            }
            
            return true;
        }
        private bool PlayerCanBeRaided(int potentialRaids = 0, decimal potentialLoss)
        {
            int val_6;
            int val_7;
            int val_8;
            int val_9;
            int val_12;
            int val_13;
            bool val_14;
            int val_15;
            int val_16;
            val_12 = potentialLoss.flags;
            val_13 = potentialRaids;
            val_14 = static_value_021FC6C4;
            if(val_14 != true)
            {
                    val_14 = true;
            }
            
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            if(RestaurantRivals.RESManager.IsGameStartFtuxFinished == false)
            {
                    return false;
            }
            
            if(val_14 < 3)
            {
                    return false;
            }
            
            var val_3 = val_14 + 60;
            val_15 = potentialLoss.mid;
            val_16 = potentialLoss.lo;
            val_16 = potentialLoss.lo;
            val_15 = potentialLoss.mid;
            decimal val_4 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 600077356, hi = mem[(val_14 + 60) + (0)], lo = mem[(val_14 + 60) + (4)], mid = mem[(val_14 + 60) + (8)]}, d2:  new System.Decimal() {flags = 67108865, hi = val_12, lo = potentialLoss.hi, mid = val_16});
            decimal val_5 = RestaurantRivals.RESGameEconHelper.GetBaseRaidCoinsValue(level:  600077340);
            val_13 = val_7;
            val_12 = val_13;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_6, hi = val_13, lo = val_8, mid = val_9})) != false)
            {
                    return false;
            }
            
            RestaurantRivals.RESGameEcon val_11 = RestaurantRivals.RESGameEcon.Instance;
            if((0 + val_12) < 18)
            {
                    0 = 1;
            }
            
            return true;
        }
        private void SaveOrShowNews(RestaurantRivals.NewsArticle article)
        {
            var val_3;
            var val_4;
            var val_5;
            if(article == 0)
            {
                    return;
            }
            
            val_3 = 11781864 + 23855142;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_4 = null;
            val_4 = null;
            if(RestaurantRivals.RESRaidAttackFlyout.isShowing == true)
            {
                goto label_7;
            }
            
            val_3 = 11782000 + 23847549;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_5 = null;
            val_5 = null;
            if(SceneDictator.lastOverlayedScene != 11)
            {
                goto label_13;
            }
            
            label_7:
            this.articlesToShow.Clear();
            this.articlesToShow.Add(item:  article);
            return;
            label_13:
            GameBehavior val_1 = App.getBehavior;
            0.Setup(data:  article);
        }
        public void HackTriggerAttack()
        {
            System.DateTime val_1 = DateTimeCheat.UtcNow;
            object val_2 = new System.Object();
            typeof(RestaurantRivals.RESRaidAttackSchedule).__il2cppRuntimeField_8 = ???;
            typeof(RestaurantRivals.RESRaidAttackSchedule).__il2cppRuntimeField_C = ???;
            typeof(RestaurantRivals.RESRaidAttackSchedule).__il2cppRuntimeField_10 = 1;
            this.ExecuteAttackOnPlayer(schedule:  427155456, showFlyout:  true);
        }
        public void HackTriggerRaid()
        {
            var val_2;
            var val_3;
            System.DateTime val_1 = DateTimeCheat.UtcNow;
            object val_4 = new System.Object();
            typeof(RestaurantRivals.RESRaidAttackSchedule).__il2cppRuntimeField_8 = val_2;
            typeof(RestaurantRivals.RESRaidAttackSchedule).__il2cppRuntimeField_C = val_3;
            typeof(RestaurantRivals.RESRaidAttackSchedule).__il2cppRuntimeField_10 = 0;
            this.ExecuteRaidOnPlayer(schedule:  427155456, showFlyout:  true);
        }
        public bool Hack_CanBeAttacked()
        {
            return this.PlayerCanBeAttacked(potentialAttacks:  0);
        }
        public bool Hack_CanBeRaided()
        {
            null = null;
            return (bool)System.Decimal.Powers10.__il2cppRuntimeField_10.PlayerCanBeRaided(potentialRaids:  0, potentialLoss:  new System.Decimal() {flags = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
        }
        public string RaidAttackProtectionInfo()
        {
            var val_5;
            var val_7;
            int val_10;
            int val_20;
            int val_21;
            int val_22;
            int val_23;
            var val_31;
            var val_39;
            var val_40;
            float val_41;
            var val_44;
            var val_45;
            var val_46;
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            val_39 = "";
            if(RestaurantRivals.RESManager.IsGameStartFtuxFinished != true)
            {
                    string val_3 = 1098586544 + 600761984;
                val_39 = val_39;
            }
            
            if(( <= 2) && (val_5 == 0))
            {
                    string val_6 = 1098586544 + 600762144;
                val_39 = val_39;
            }
            
            if(val_7.ContainsAttackableObjects != true)
            {
                    string val_9 = 1098586544 + 600762336;
                val_39 = val_39;
            }
            
            RestaurantRivals.RESGameEcon val_11 = RestaurantRivals.RESGameEcon.Instance;
            if(val_10 >= 1302)
            {
                    RestaurantRivals.RESGameEcon val_12 = RestaurantRivals.RESGameEcon.Instance;
                string val_13 = System.String.Format(format:  600762512, arg0:  13152256, arg1:  13152256);
                string val_14 = 1098586544 + 600762512;
                val_39 = val_39;
            }
            
            if((System.String.IsNullOrEmpty(value:  1098586544)) != false)
            {
                    val_40 = "<b>Player can be attacked.</b>\n";
            }
            else
            {
                    val_40 = "<b>Player cannot be attacked:</b>\n";
                string val_16 = 600762848 + 1098586544;
            }
            
            val_41 = "";
            if(RestaurantRivals.RESManager.IsGameStartFtuxFinished != true)
            {
                    string val_18 = 1098586544 + 600762992;
                val_41 = val_41;
            }
            
            if( <= 2)
            {
                    string val_19 = 1098586544 + 600763152;
                val_41 = val_41;
            }
            
            decimal val_24 = RestaurantRivals.RESGameEconHelper.GetBaseRaidCoinsValue(level:  600775824);
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_20, hi = val_21, lo = val_22, mid = val_23}, d2:  new System.Decimal() {flags = val_10})) != false)
            {
                    decimal val_26 = RestaurantRivals.RESGameEconHelper.GetBaseRaidCoinsValue(level:  600775824);
                GameEcon val_27 = App.getGameEcon;
                val_44 = 1152921505031819264;
                string val_28 = ToString(format:  null);
                string val_29 = System.String.Format(format:  600763280, arg0:  600775848);
                string val_30 = 1098586544 + 600763280;
                val_41 = val_41;
            }
            else
            {
                    val_44 = 1152921505031819264;
            }
            
            val_45 = val_31;
            RestaurantRivals.RESGameEcon val_32 = RestaurantRivals.RESGameEcon.Instance;
            if(val_45 >= 18)
            {
                    val_45 = 1152921504619999232;
                RestaurantRivals.RESGameEcon val_33 = RestaurantRivals.RESGameEcon.Instance;
                string val_34 = System.String.Format(format:  600763456, arg0:  13152256, arg1:  13152256);
                string val_35 = 1098586544 + 600763456;
                val_41 = val_41;
            }
            
            if((System.String.IsNullOrEmpty(value:  1098586544)) != false)
            {
                    val_46 = "<b>Player can be raided.</b>\n";
            }
            else
            {
                    string val_37 = 600763760 + 1098586544;
                val_46 = "<b>Player cannot be raided:</b>\n";
            }
            
            string val_38 = 600762848 + 1269544832 + 600763760;
        }
        public RESRaidAttackScheduleController()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.articlesToShow = null;
        }
    
    }

}
