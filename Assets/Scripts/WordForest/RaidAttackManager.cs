using UnityEngine;

namespace WordForest
{
    public class RaidAttackManager : MonoSingleton<WordForest.RaidAttackManager>
    {
        // Fields
        private const float REFRESH_REQUEST_INTERVAL = 30;
        private const float REFRESH_ECON_INTERVAL = 600;
        public static bool queueNewsPopup;
        public static bool lastAttackResult;
        public static bool lastRaidPerfect;
        public bool isEligibleForRevengeFtux;
        private SLC.Social.AvatarConfig avatarConfig;
        private WordForest.RaidAttackDataController dataController;
        private WordForest.RaidAttackServerController serverController;
        private WordForest.RaidAttackNotifyController notifyController;
        private float nextRefresh;
        private float nextRefreshEcon;
        private string currentRaidId;
        private WordForest.UserForestProfile <currentRaidOpponent>k__BackingField;
        private System.Collections.Generic.List<int> <currentRaidPickerOptions>k__BackingField;
        private WordForest.UserForestProfile <currentAttackOpponent>k__BackingField;
        
        // Properties
        public SLC.Social.AvatarConfig AvatarSpriteConfig { get; }
        public WordForest.RaidAttackDataController Data { get; }
        public WordForest.RaidAttackServerController ServerAPI { get; }
        public WordForest.RaidAttackNotifyController NotifyAPI { get; }
        public WordForest.UserForestProfile currentRaidOpponent { get; set; }
        public System.Collections.Generic.List<int> currentRaidPickerOptions { get; set; }
        public WordForest.UserForestProfile currentAttackOpponent { get; set; }
        
        // Methods
        public SLC.Social.AvatarConfig get_AvatarSpriteConfig()
        {
        
        }
        public WordForest.RaidAttackDataController get_Data()
        {
        
        }
        public WordForest.RaidAttackServerController get_ServerAPI()
        {
        
        }
        public WordForest.RaidAttackNotifyController get_NotifyAPI()
        {
        
        }
        public WordForest.UserForestProfile get_currentRaidOpponent()
        {
        
        }
        private void set_currentRaidOpponent(WordForest.UserForestProfile value)
        {
            this.<currentRaidOpponent>k__BackingField = value;
        }
        public System.Collections.Generic.List<int> get_currentRaidPickerOptions()
        {
        
        }
        private void set_currentRaidPickerOptions(System.Collections.Generic.List<int> value)
        {
            this.<currentRaidPickerOptions>k__BackingField = value;
        }
        public WordForest.UserForestProfile get_currentAttackOpponent()
        {
        
        }
        private void set_currentAttackOpponent(WordForest.UserForestProfile value)
        {
            this.<currentAttackOpponent>k__BackingField = value;
        }
        private void OnServerResponded()
        {
            if(WordForest.RaidAttackServerController.IsInitialResponseSuccess != false)
            {
                    System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  251929744, method:  new IntPtr(251903696));
                this.serverController.GetForestProfile(responseCallback:  7401472);
                return;
            }
            
            System.Action<twelvegigs.storage.JsonDictionary> val_3 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  251929744, method:  new IntPtr(251904720));
            this.serverController.InitialRequest(responseCallback:  7401472);
        }
        public override void InitMonoSingleton()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            object val_2 = this.AddComponent<System.Object>();
            this.dataController = this;
            UnityEngine.GameObject val_3 = this.gameObject;
            object val_4 = this.AddComponent<System.Object>();
            this.serverController = this;
            UnityEngine.GameObject val_5 = this.gameObject;
            object val_6 = this.AddComponent<System.Object>();
            this.notifyController = this;
            NotificationCenter val_7 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  252048912, name:  -1976323520);
            NotificationCenter val_8 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  252048912, name:  -843271104);
            NotificationCenter val_9 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  252048912, name:  404738048);
        }
        private void OnDestroy()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  252160912, name:  -1976323520);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  252160912, name:  -843271104);
        }
        private void OnApplicationPause(bool pause)
        {
            if(pause == true)
            {
                    return;
            }
            
            if(WordForest.RaidAttackServerController.IsInitialResponseSuccess == false)
            {
                    return;
            }
            
            System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  252278032, method:  new IntPtr(252253008));
            this.serverController.GetForestProfile(responseCallback:  7401472);
        }
        public void GrowTree(int treeId, int growthCost, System.Action<bool, System.Collections.Generic.Dictionary<string, object>> responseCallback)
        {
            this.serverController.GrowTree(treeId:  treeId, growthCost:  growthCost, responseCallback:  responseCallback);
        }
        public void SetShields(int amount)
        {
            System.Nullable<System.Int32> val_1 = new System.Nullable<System.Int32>(value:  amount);
            this.serverController.SetForestProfile(forestLevel:  new System.Nullable<System.Int32>() {HasValue = false}, map:  0, acorns:  new System.Nullable<System.Int32>() {HasValue = false}, shields:  new System.Nullable<System.Int32>() {HasValue = false}, fbid:  null, responseCallback:  0);
        }
        public void GetEcon()
        {
            this.serverController.GetEcon();
        }
        public void GetRaidOpponentPool()
        {
            object val_1 = new System.Object();
            typeof(RaidAttackManager.<>c__DisplayClass40_0).__il2cppRuntimeField_C = this;
            WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            typeof(RaidAttackManager.<>c__DisplayClass40_0).__il2cppRuntimeField_8 = null;
            int val_4 = UnityEngine.Random.Range(min:  18, max:  21);
            WordForest.UserForestProfile val_5 = WordForest.UserForestProfile.CreateDummyProfile(baseLevel:  val_4, flexibleBaseLevel:  true, minTreesNormalized:  null, maxTreesNormalized:  null);
            Add(item:  val_4);
            this.dataController.CacheRaidOpponents(profiles:  80883712, isDummies:  true);
            System.Action<twelvegigs.storage.JsonDictionary> val_6 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  403939328, method:  new IntPtr(252747088));
            this.serverController.GetRaidOpponentPool(responseCallback:  7401472);
        }
        public bool CanAttack()
        {
            WordForest.UserForestProfile val_1 = this.dataController.GetRandomAttackOpponent();
            if(this.dataController != 0)
            {
                    this.dataController = 1;
            }
            
            return true;
        }
        public bool CanRaid()
        {
            WordForest.UserForestProfile val_1 = this.dataController.GetRandomRaidOpponent();
            if(this.dataController != 0)
            {
                    this.dataController = 1;
            }
            
            return true;
        }
        public WordForest.UserForestProfile GetRaidRandomOpponent()
        {
            WordForest.UserForestProfile val_1 = this.dataController.GetRandomRaidOpponent();
            this.<currentRaidOpponent>k__BackingField = this.dataController;
        }
        public void InitializeFtuxRaid(System.Action onInitialized)
        {
            UnityEngine.Vector2Int val_1 = WordForest.WFOGameEconHelper.GetRaidEligibleAcornsMinMax(forestLevel:  253244936);
            System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
            if(null != 0)
            {
                    Add(item:  715827883);
                Add(item:  0);
            }
            else
            {
                    Add(item:  R5 + ((R5) >> 31));
                Add(item:  0);
            }
            
            int val_5 = 0.y << 1;
            Add(item:  val_5 + (val_5 >> 31));
            Add(item:  0);
            this.<currentRaidPickerOptions>k__BackingField = null;
            if(onInitialized == 0)
            {
                    return;
            }
            
            onInitialized.Invoke();
        }
        public void InitializeRaid(int opponentId, System.Action onInitialized)
        {
            if(new System.Object() != 0)
            {
                    typeof(RaidAttackManager.<>c__DisplayClass45_0).__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[8] = this;
            }
            
            typeof(RaidAttackManager.<>c__DisplayClass45_0).__il2cppRuntimeField_C = onInitialized;
            WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
            int val_3 = WordForest.WFOGameEconHelper.GetRandomRaidEligibleAcorns(forestLevel:  19);
            System.Collections.Generic.List<System.Int32> val_4 = WordForest.WFOGameEconHelper.GeneratePickerOptionsFromEligibleAcorns(eligibleAcorns:  val_3);
            this.<currentRaidPickerOptions>k__BackingField = val_3;
            System.Action<twelvegigs.storage.JsonDictionary> val_5 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  403992576, method:  new IntPtr(253357264));
            this.serverController.InitializeRaid(opponentId:  opponentId, responseCallback:  7401472);
        }
        public void ConcludeRaid(System.Collections.Generic.List<int> chosenRewardIndexes)
        {
            if((System.String.IsNullOrEmpty(value:  this.currentRaidId)) == true)
            {
                    return;
            }
            
            this.serverController.ConcludeRaid(raidId:  this.currentRaidId, chosenRewardIndexes:  chosenRewardIndexes, responseCallback:  0);
        }
        public void GetAttackOpponentPool()
        {
            object val_1 = new System.Object();
            typeof(RaidAttackManager.<>c__DisplayClass47_0).__il2cppRuntimeField_C = this;
            WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            typeof(RaidAttackManager.<>c__DisplayClass47_0).__il2cppRuntimeField_8 = null;
            int val_4 = UnityEngine.Random.Range(min:  18, max:  21);
            WordForest.UserForestProfile val_5 = WordForest.UserForestProfile.CreateDummyProfile(baseLevel:  val_4, flexibleBaseLevel:  true, minTreesNormalized:  null, maxTreesNormalized:  null);
            Add(item:  val_4);
            this.dataController.CacheAttackOpponents(profiles:  80883712, isDummies:  true);
            System.Action<twelvegigs.storage.JsonDictionary> val_6 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  404045824, method:  new IntPtr(253631440));
            this.serverController.GetAttackOpponentPool(responseCallback:  7401472);
        }
        public WordForest.UserForestProfile GetAttackRandomOpponent()
        {
            WordForest.UserForestProfile val_1 = this.dataController.GetRandomAttackOpponent();
            this.<currentAttackOpponent>k__BackingField = this.dataController;
        }
        public void GetRevengeOpponentPool(System.Action<System.Collections.Generic.List<WordForest.UserForestProfile>> onRevengeListRetrieved)
        {
            object val_1 = new System.Object();
            typeof(RaidAttackManager.<>c__DisplayClass49_0).__il2cppRuntimeField_8 = onRevengeListRetrieved;
            System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  404099072, method:  new IntPtr(253881040));
            this.serverController.GetRevengeOpponentPool(responseCallback:  7401472);
        }
        public void GetFriendsOpponentPool(string[] friendFbidList, System.Action<System.Collections.Generic.List<WordForest.UserForestProfile>> onListRetrieved)
        {
            object val_1 = new System.Object();
            typeof(RaidAttackManager.<>c__DisplayClass50_0).__il2cppRuntimeField_8 = onListRetrieved;
            System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  404152320, method:  new IntPtr(254047312));
            this.serverController.GetFriendsOpponentPool(fbidList:  friendFbidList, responseCallback:  7401472);
        }
        public void ResolveAttack(int opponentId, int treeId, System.Nullable<bool> autoSuccess)
        {
            var val_2;
            System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = RaidAttackManager.<>c.<>9__51_0;
            if(val_4 == 0)
            {
                    val_4 = null;
                val_4 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  RaidAttackManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(254209488));
                RaidAttackManager.<>c.<>9__51_0 = val_4;
            }
            
            this.serverController.ResolveAttack(opponentId:  opponentId, treeId:  treeId, autoSuccess:  new System.Nullable<System.Boolean>() {HasValue = (uint)autoSuccess.HasValue & 65535}, responseCallback:  val_4);
        }
        public void FlushPlayerData()
        {
            this.Refresh(forced:  true);
        }
        private void OnAttackReceived()
        {
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            bool val_2 = MonoExtensions.IsBitSet(value:  132, bit:  12);
            if(val_2 == false)
            {
                    val_2 = true;
                this.isEligibleForRevengeFtux = val_2;
            }
        
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
            bool val_7;
            var val_8;
            var val_9;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-812289776) == 0)
            {
                goto label_5;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(2119322896 != 0)
            {
                goto label_10;
            }
            
            label_5:
            val_7 = 1;
            val_8 = 1152921505010733056;
            goto label_11;
            label_10:
            GameBehavior val_5 = App.getBehavior;
            val_7 = false;
            val_8 = 1152921505010733056;
            label_11:
            val_9 = null;
            WordForest.RaidAttackManager.queueNewsPopup = val_7;
        }
        private void Refresh(bool forced = False)
        {
            var val_11;
            var val_12;
            val_11 = 35634274;
            float val_1 = UnityEngine.Time.time;
            if(forced != false)
            {
                    float val_2 = UnityEngine.Time.time;
                float val_11 = 30f;
                val_11 = 0 + val_11;
                this.nextRefresh = val_11;
                WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
                System.Nullable<System.Int32> val_4 = new System.Nullable<System.Int32>(value:  19);
                if(0 != 0)
            {
                    val_12 = 0;
            }
            else
            {
                    val_12 = 0;
            }
            
                System.Nullable<System.Int32> val_6 = new System.Nullable<System.Int32>(value:  0.acorns);
                System.Nullable<System.Int32> val_7 = new System.Nullable<System.Int32>(value:  8);
                Player val_8 = App.Player;
                val_11 = 0;
                this.serverController.SetForestProfile(forestLevel:  new System.Nullable<System.Int32>() {HasValue = val_4.HasValue}, map:  0, acorns:  new System.Nullable<System.Int32>() {HasValue = false}, shields:  new System.Nullable<System.Int32>() {HasValue = val_6.HasValue}, fbid:  val_6.HasValue, responseCallback:  0);
            }
            
            float val_9 = UnityEngine.Time.time;
            if(this.serverController <= 0)
            {
                    return;
            }
            
            float val_10 = UnityEngine.Time.time;
            float val_12 = 600f;
            val_12 = 0 + val_12;
            this.nextRefreshEcon = val_12;
            this.serverController.GetEcon();
        }
        private void OnStarsChanged()
        {
            this.Refresh(forced:  true);
        }
        public RaidAttackManager()
        {
        
        }
        private static RaidAttackManager()
        {
        
        }
        private void <OnServerResponded>b__33_0(System.Collections.Generic.Dictionary<string, object> resp)
        {
            this.GetRaidOpponentPool();
            this.GetAttackOpponentPool();
        }
        private void <OnServerResponded>b__33_1(System.Collections.Generic.Dictionary<string, object> resp)
        {
            this.GetRaidOpponentPool();
            this.GetAttackOpponentPool();
            this.Refresh(forced:  true);
        }
        private void <OnApplicationPause>b__36_0(System.Collections.Generic.Dictionary<string, object> resp)
        {
            this.GetRaidOpponentPool();
            this.GetAttackOpponentPool();
        }
    
    }

}
