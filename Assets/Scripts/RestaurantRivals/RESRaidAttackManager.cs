using UnityEngine;

namespace RestaurantRivals
{
    public class RESRaidAttackManager : MonoSingleton<RestaurantRivals.RESRaidAttackManager>
    {
        // Fields
        private const float REFRESH_REQUEST_INTERVAL = 30;
        public static bool queueNewsPopup;
        private SLC.Social.AvatarConfig avatarConfig;
        private float nextRefresh;
        private RestaurantRivals.RESRaidAttackDataController <Data>k__BackingField;
        private RestaurantRivals.RESRaidAttackServerController <ServerAPI>k__BackingField;
        private WordForest.RaidAttackNotifyController <NotifyAPI>k__BackingField;
        private RestaurantRivals.RESRaidAttackScheduleController <ScheduleAPI>k__BackingField;
        private RestaurantRivals.UserRestaurantProfile <currentRaidOpponent>k__BackingField;
        private System.Collections.Generic.List<System.Decimal> <currentRaidPickerOptions>k__BackingField;
        private RestaurantRivals.UserRestaurantProfile <currentAttackOpponent>k__BackingField;
        
        // Properties
        public SLC.Social.AvatarConfig AvatarSpriteConfig { get; }
        public RestaurantRivals.RESRaidAttackDataController Data { get; set; }
        public RestaurantRivals.RESRaidAttackServerController ServerAPI { get; set; }
        public WordForest.RaidAttackNotifyController NotifyAPI { get; set; }
        public RestaurantRivals.RESRaidAttackScheduleController ScheduleAPI { get; set; }
        public RestaurantRivals.UserRestaurantProfile currentRaidOpponent { get; set; }
        public System.Collections.Generic.List<System.Decimal> currentRaidPickerOptions { get; set; }
        public RestaurantRivals.UserRestaurantProfile currentAttackOpponent { get; set; }
        private RestaurantRivals.RESPlayer player { get; }
        
        // Methods
        public SLC.Social.AvatarConfig get_AvatarSpriteConfig()
        {
        
        }
        public RestaurantRivals.RESRaidAttackDataController get_Data()
        {
        
        }
        private void set_Data(RestaurantRivals.RESRaidAttackDataController value)
        {
            this.<Data>k__BackingField = value;
        }
        public RestaurantRivals.RESRaidAttackServerController get_ServerAPI()
        {
        
        }
        private void set_ServerAPI(RestaurantRivals.RESRaidAttackServerController value)
        {
            this.<ServerAPI>k__BackingField = value;
        }
        public WordForest.RaidAttackNotifyController get_NotifyAPI()
        {
        
        }
        private void set_NotifyAPI(WordForest.RaidAttackNotifyController value)
        {
            this.<NotifyAPI>k__BackingField = value;
        }
        public RestaurantRivals.RESRaidAttackScheduleController get_ScheduleAPI()
        {
        
        }
        private void set_ScheduleAPI(RestaurantRivals.RESRaidAttackScheduleController value)
        {
            this.<ScheduleAPI>k__BackingField = value;
        }
        public RestaurantRivals.UserRestaurantProfile get_currentRaidOpponent()
        {
        
        }
        private void set_currentRaidOpponent(RestaurantRivals.UserRestaurantProfile value)
        {
            this.<currentRaidOpponent>k__BackingField = value;
        }
        public System.Collections.Generic.List<System.Decimal> get_currentRaidPickerOptions()
        {
        
        }
        private void set_currentRaidPickerOptions(System.Collections.Generic.List<System.Decimal> value)
        {
            this.<currentRaidPickerOptions>k__BackingField = value;
        }
        public RestaurantRivals.UserRestaurantProfile get_currentAttackOpponent()
        {
        
        }
        private void set_currentAttackOpponent(RestaurantRivals.UserRestaurantProfile value)
        {
            this.<currentAttackOpponent>k__BackingField = value;
        }
        private RestaurantRivals.RESPlayer get_player()
        {
            return RestaurantRivals.RESPlayer.Instance;
        }
        private void OnServerResponded()
        {
            if(RestaurantRivals.RESRaidAttackServerController.IsInitialResponseSuccess != false)
            {
                    this.Refresh(forced:  true);
                return;
            }
            
            this.<ServerAPI>k__BackingField.InitialRequest(responseCallback:  0);
        }
        public override void InitMonoSingleton()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            object val_2 = this.AddComponent<System.Object>();
            this.<Data>k__BackingField = this;
            UnityEngine.GameObject val_3 = this.gameObject;
            object val_4 = this.AddComponent<System.Object>();
            this.<ServerAPI>k__BackingField = this;
            UnityEngine.GameObject val_5 = this.gameObject;
            object val_6 = this.AddComponent<System.Object>();
            this.<NotifyAPI>k__BackingField = this;
            UnityEngine.GameObject val_7 = this.gameObject;
            object val_8 = this.AddComponent<System.Object>();
            this.<ScheduleAPI>k__BackingField = this;
            NotificationCenter val_9 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  591366208, name:  -1976323520);
        }
        private void OnDestroy()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  591478208, name:  -1976323520);
        }
        public void SetShields(int amount)
        {
            System.Nullable<System.Int32> val_1 = new System.Nullable<System.Int32>(value:  amount);
            this.<ServerAPI>k__BackingField.SetMapProfile(level:  new System.Nullable<System.Int32>() {HasValue = false}, map:  0, stars:  new System.Nullable<System.Int32>() {HasValue = false}, shields:  new System.Nullable<System.Int32>() {HasValue = false}, name:  null, avatarid:  new System.Nullable<System.Int32>() {HasValue = false}, responseCallback:  0);
        }
        public RestaurantRivals.UserRestaurantProfile GetRaidRandomOpponent()
        {
            bool val_9;
            var val_10;
            var val_11;
            var val_12;
            val_9 = static_value_021FC6AB;
            if(val_9 != true)
            {
                    val_9 = true;
            }
            
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESFTUXLevel val_2 = RestaurantRivals.RESGameEconHelper.GetNextRaidLevel(totalSpinned:  268439482);
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            val_10 = mem[268439774];
            val_11 = null;
            val_11 = null;
            if(268439482 != 0)
            {
                    val_12 = mem[RestaurantRivals.RESGameEcon.FTUXScripts + 12];
                val_12 = RestaurantRivals.RESGameEcon.FTUXScripts + 12;
                if(val_10 < val_12)
            {
                    RestaurantRivals.UserRestaurantProfile val_4 = RestaurantRivals.UserRestaurantProfile.CreateDummyProfile(baseLevel:  mem[268439522], forAttack:  false, objectAmount:  mem[268439526]);
                val_10 = mem[268439522];
                this.<currentRaidOpponent>k__BackingField = mem[268439522];
                var val_5 = 268439482 + 20;
                var val_6 = val_10 + 28;
                return;
            }
            
            }
            
            RestaurantRivals.RESPlayer val_7 = RestaurantRivals.RESPlayer.Instance;
            int val_8 = UnityEngine.Random.Range(min:  424976382, max:  424976387);
            RestaurantRivals.UserRestaurantProfile val_9 = RestaurantRivals.UserRestaurantProfile.CreateDummyProfile(baseLevel:  val_8, forAttack:  false, objectAmount:  0);
            this.<currentRaidOpponent>k__BackingField = val_8;
        }
        public void InitializeRaid(int opponentId)
        {
            bool val_7;
            var val_8;
            var val_9;
            string val_10;
            val_7 = static_value_021FC6AC;
            if(val_7 != true)
            {
                    val_7 = true;
            }
            
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESFTUXLevel val_2 = RestaurantRivals.RESGameEconHelper.GetNextRaidLevel(totalSpinned:  268439482);
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            val_8 = null;
            val_8 = null;
            var val_6 = RestaurantRivals.RESGameEcon.FTUXScripts + 12;
            if(mem[268439774] >= val_6)
            {
                    0 = 1;
            }
            
            val_6 = val_6 >> 5;
            val_9 = val_6 | 1;
            if(val_9 != 0)
            {
                    val_10 = 0;
                System.Collections.Generic.List<System.Decimal> val_4 = RestaurantRivals.RESGameEconHelper.GeneratePickerOptions(treasureAmount:  new System.Decimal() {flags = mem[this.<currentRaidOpponent>k__BackingField.credits + (0)], hi = mem[this.<currentRaidOpponent>k__BackingField.credits + (4)], lo = mem[this.<currentRaidOpponent>k__BackingField.credits + (8)], mid = mem[this.<currentRaidOpponent>k__BackingField.credits + (12)]});
            }
            else
            {
                    val_10 = mem[268439518];
                val_9 = 0;
                System.Collections.Generic.List<System.Decimal> val_5 = RestaurantRivals.RESGameEconHelper.GenerateRiggedPickerOptions(treasureAmount:  new System.Decimal() {flags = mem[this.<currentRaidOpponent>k__BackingField.credits + (0)], hi = mem[this.<currentRaidOpponent>k__BackingField.credits + (4)], lo = mem[this.<currentRaidOpponent>k__BackingField.credits + (8)], mid = mem[this.<currentRaidOpponent>k__BackingField.credits + (12)]}, result:  val_10);
            }
            
            this.<currentRaidPickerOptions>k__BackingField = null;
        }
        public RestaurantRivals.UserRestaurantProfile GetAttackRandomOpponent()
        {
            bool val_9;
            var val_10;
            var val_11;
            RestaurantRivals.UserRestaurantProfile val_12;
            val_9 = static_value_021FC6AD;
            if(val_9 != true)
            {
                    val_9 = true;
            }
            
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            val_10 = null;
            val_10 = null;
            if(268439482 < (RestaurantRivals.RESGameEcon.FTUXScripts + 12))
            {
                    val_11 = null;
                val_11 = null;
                RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_12 = mem[(RestaurantRivals.RESGameEcon.FTUXScripts + 8 + (RestaurantRivals.RESGameEcon.DailyBonusRewardTypeChances.__il2cppRuntimeField_124) << 2) + 16 + 40];
                val_12 = (RestaurantRivals.RESGameEcon.FTUXScripts + 8 + (RestaurantRivals.RESGameEcon.DailyBonusRewardTypeChances.__il2cppRuntimeField_124) << 2) + 16 + 40;
            }
            else
            {
                    RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
                int val_6 = UnityEngine.Random.Range(min:  (RestaurantRivals.RESGameEcon.FTUXScripts + 12) - 1, max:  (RestaurantRivals.RESGameEcon.FTUXScripts + 12) + 2);
                RestaurantRivals.UserRestaurantProfile val_7 = RestaurantRivals.UserRestaurantProfile.CreateDummyProfile(baseLevel:  val_6, forAttack:  true, objectAmount:  0);
                this.<currentAttackOpponent>k__BackingField = val_6;
                return;
            }
            
            RestaurantRivals.UserRestaurantProfile val_8 = RestaurantRivals.UserRestaurantProfile.CreateDummyProfile(baseLevel:  2097204, forAttack:  true, objectAmount:  (RestaurantRivals.RESGameEcon.FTUXScripts + 8 + (RestaurantRivals.RESGameEcon.DailyBonusRewardTypeChances.__il2cppRuntimeField_124) << 2) + 16 + 44);
            this.<currentAttackOpponent>k__BackingField = ;
            if(((RestaurantRivals.RESGameEcon.FTUXScripts + 8 + (RestaurantRivals.RESGameEcon.DailyBonusRewardTypeChances.__il2cppRuntimeField_124) << 2) + 16 + 16) == 0)
            {
                    1 = 2;
            }
            
            RestaurantRivals.RESManager.HackAttackResult = 2;
        }
        public void GetRevengeOpponentPool(System.Action<System.Collections.Generic.List<RestaurantRivals.UserRestaurantProfile>> onRevengeListRetrieved)
        {
            System.Collections.Generic.List<RestaurantRivals.UserRestaurantProfile> val_1 = this.<Data>k__BackingField.RevengeList;
            onRevengeListRetrieved.Invoke(obj:  this.<Data>k__BackingField);
        }
        public void FlushPlayerData()
        {
            this.Refresh(forced:  true);
        }
        public void ShowConnectionRequired()
        {
            var val_6;
            GameBehavior val_1 = App.getBehavior;
            string val_3 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
            string val_4 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
            val_6 = null;
            val_6 = null;
            0.SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
        }
        public static void HandleDeeplinkShowNews()
        {
            bool val_5;
            var val_6;
            var val_7;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-835497904) == 0)
            {
                goto label_5;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_5 = false;
            if(2119322896 != 0)
            {
                goto label_10;
            }
            
            label_5:
            val_5 = 1;
            val_6 = 1152921505033416704;
            goto label_11;
            label_10:
            val_6 = 1152921505033416704;
            label_11:
            val_7 = null;
            RestaurantRivals.RESRaidAttackManager.queueNewsPopup = val_5;
        }
        private void Refresh(bool forced = False)
        {
            var val_10 = 35636913;
            float val_1 = UnityEngine.Time.time;
            if(forced == false)
            {
                    return;
            }
            
            float val_2 = UnityEngine.Time.time;
            float val_10 = 30f;
            val_10 = 0 + val_10;
            this.nextRefresh = val_10;
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            System.Nullable<System.Int32> val_4 = new System.Nullable<System.Int32>(value:  0);
            if(0 != 0)
            {
                
            }
            
            System.Nullable<System.Int32> val_5 = new System.Nullable<System.Int32>(value:  4);
            System.Nullable<System.Int32> val_6 = new System.Nullable<System.Int32>(value:  1030672);
            RestaurantRivals.RESPlayer val_7 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_8 = RestaurantRivals.RESPlayer.Instance;
            System.Nullable<System.Int32> val_9 = new System.Nullable<System.Int32>(value:  mem[null..ctor(value:  1030672) + 336]);
            this.<ServerAPI>k__BackingField.SetMapProfile(level:  new System.Nullable<System.Int32>() {HasValue = val_4.HasValue}, map:  0, stars:  new System.Nullable<System.Int32>() {HasValue = false}, shields:  new System.Nullable<System.Int32>() {HasValue = val_5.HasValue}, name:  val_5.HasValue, avatarid:  new System.Nullable<System.Int32>() {HasValue = false}, responseCallback:  0);
        }
        public void Hack_TriggerAttack()
        {
            this.<ScheduleAPI>k__BackingField.HackTriggerAttack();
        }
        public void Hack_TriggerRaid()
        {
            this.<ScheduleAPI>k__BackingField.HackTriggerRaid();
        }
        public bool PlayerCanBeAttacked()
        {
            if((this.<ScheduleAPI>k__BackingField) != 0)
            {
                    return this.<ScheduleAPI>k__BackingField.PlayerCanBeAttacked(potentialAttacks:  0);
            }
            
            return this.<ScheduleAPI>k__BackingField.PlayerCanBeAttacked(potentialAttacks:  0);
        }
        public bool PlayerCanBeRaided()
        {
            if((this.<ScheduleAPI>k__BackingField) != 0)
            {
                    return this.<ScheduleAPI>k__BackingField.Hack_CanBeRaided();
            }
            
            return this.<ScheduleAPI>k__BackingField.Hack_CanBeRaided();
        }
        public string RaidAttackProtectionInfo()
        {
            if((this.<ScheduleAPI>k__BackingField) == 0)
            {
                    return this.<ScheduleAPI>k__BackingField.RaidAttackProtectionInfo();
            }
            
            return this.<ScheduleAPI>k__BackingField.RaidAttackProtectionInfo();
        }
        public RESRaidAttackManager()
        {
        
        }
        private static RESRaidAttackManager()
        {
        
        }
    
    }

}
