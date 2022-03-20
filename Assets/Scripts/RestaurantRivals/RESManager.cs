using UnityEngine;

namespace RestaurantRivals
{
    public class RESManager : MonoSingleton<RestaurantRivals.RESManager>
    {
        // Fields
        public const string ON_GAME_ACTION = "OnGameAction";
        public const string ON_SWIPE_START = "OnSwipeStart";
        public const string ON_SWIPE_IN_SCREEN_DONE = "OnSwipeInScreenDone";
        public const string ON_SWIPE_OUT_SCREEN_DONE = "OnSwipeOutScreenDone";
        public const int HIGH_STAKES_INDEX = 3;
        public const int HIGH_STAKES_THRESHOLD = 51;
        public System.Collections.Generic.List<System.Collections.Generic.List<bool>> levelProgress;
        public const int SpinRechargePerHour = 5;
        private bool _isAutoSpin;
        public const int NumberOfReel = 3;
        public const int NumberOfRow = 5;
        public const int PaylineRowIndex = 2;
        private UnityEngine.Sprite symbolCoinSprite;
        private UnityEngine.Sprite symbolBagSprite;
        private UnityEngine.Sprite symbolAttackSprite;
        private UnityEngine.Sprite symbolRaidSprite;
        private UnityEngine.Sprite symbolShieldSprite;
        private UnityEngine.Sprite symbolSpinSprite;
        private UnityEngine.Sprite symbolHotNSpicySprite;
        private string[,] reelData;
        private RestaurantRivals.RESSpin <SpinResult>k__BackingField;
        private RandomSet paddingRoller;
        public System.Collections.Generic.List<int> betOptions;
        public System.Collections.Generic.List<int> spinBalanceThresholds;
        public System.Collections.Generic.List<int> betUnlockLevel;
        private int spinBetIndex;
        private bool <CanShowHighstakesReadyTip>k__BackingField;
        private int <CurrentHighSpinThreshold>k__BackingField;
        private int <CurrentHighBetOption>k__BackingField;
        public const int GameStartFtuxLength = 18;
        private static RestaurantRivals.RESManager.AttackResult _hackAttackResult;
        private System.Collections.Generic.List<string> _hackSlotResultLog;
        
        // Properties
        private static RestaurantRivals.RESPlayer player { get; }
        public static int RechargeableSpinAmount { get; }
        public bool IsAutoSpin { get; set; }
        public int Spins { get; set; }
        public int ExtraSpins { get; }
        public int MaxShieldCount { get; }
        public bool CanAddShield { get; }
        public string[,] ReelData { get; }
        public RestaurantRivals.RESSpin SpinResult { get; set; }
        public int SpinBet { get; }
        public bool AvailableSpin { get; }
        public bool CanShowHighstakesReadyTip { get; set; }
        public int CurrentHighSpinThreshold { get; set; }
        public int CurrentHighBetOption { get; set; }
        public static bool IsGameStartFtuxFinished { get; }
        public static RestaurantRivals.RESManager.AttackResult HackAttackResult { get; set; }
        public System.Collections.Generic.List<string> HackSlotResultLog { get; }
        
        // Methods
        private static RestaurantRivals.RESPlayer get_player()
        {
            return RestaurantRivals.RESPlayer.Instance;
        }
        public static int get_RechargeableSpinAmount()
        {
            Player val_1 = App.Player;
            if(0 <= 74)
            {
                    RestaurantRivals.RESGameEcon val_3 = RestaurantRivals.RESGameEcon.Instance;
                if(0 != 0)
            {
                    return 1282;
            }
            
                return 1282;
            }
            
            RestaurantRivals.RESGameEcon val_4 = RestaurantRivals.RESGameEcon.Instance;
            var val_5 = 1282;
            val_5 = val_5 + 10;
            return (int)val_5;
        }
        public bool get_IsAutoSpin()
        {
            return (bool)this._isAutoSpin;
        }
        public void set_IsAutoSpin(bool value)
        {
            this._isAutoSpin = value;
            if(value != false)
            {
                    return;
            }
            
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  564915392, aName:  564891280);
        }
        public int get_Spins()
        {
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            if(null != 0)
            {
                    return (int)typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_120;
            }
            
            return (int)typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_120;
        }
        private void set_Spins(int value)
        {
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_120 = value;
            UpdateTimerState();
            this.UpdateSpinRechargeLPN();
            Player val_2 = App.Player;
            0.SaveState();
        }
        public int get_ExtraSpins()
        {
            int val_2 = RestaurantRivals.RESManager.RechargeableSpinAmount;
            val_2 = this.Spins - val_2;
            return (int)val_2;
        }
        public int get_MaxShieldCount()
        {
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESGameEcon val_2 = RestaurantRivals.RESGameEcon.Instance;
            if(null >= 18)
            {
                    return 4;
            }
            
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESGameEcon val_4 = RestaurantRivals.RESGameEcon.Instance;
            if(null < 1289)
            {
                    5 = 3;
            }
            
            return 3;
        }
        public bool get_CanAddShield()
        {
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            if(typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_128 < MaxShieldCount)
            {
                    0 = 1;
            }
            
            return true;
        }
        public string[,] get_ReelData()
        {
        
        }
        public RestaurantRivals.RESSpin get_SpinResult()
        {
        
        }
        private void set_SpinResult(RestaurantRivals.RESSpin value)
        {
            this.<SpinResult>k__BackingField = value;
        }
        private void InitBetsFromKnobs()
        {
        
        }
        public int get_SpinBet()
        {
            if(true <= this.spinBetIndex)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (this.spinBetIndex << 2);
            return (int)(0 + (this.spinBetIndex) << 2) + 16;
        }
        public bool get_AvailableSpin()
        {
            if(this.Spins >= this.SpinBet)
            {
                    0 = 1;
            }
            
            return true;
        }
        public void SetSpinBet(int i)
        {
            this.spinBetIndex = UnityEngine.Mathf.Clamp(value:  i, min:  0, max:  this.betOptions - 1);
        }
        public bool get_CanShowHighstakesReadyTip()
        {
            return (bool)this.<CanShowHighstakesReadyTip>k__BackingField;
        }
        private void set_CanShowHighstakesReadyTip(bool value)
        {
            this.<CanShowHighstakesReadyTip>k__BackingField = value;
        }
        public int get_CurrentHighSpinThreshold()
        {
            return (int)this.<CurrentHighSpinThreshold>k__BackingField;
        }
        private void set_CurrentHighSpinThreshold(int value)
        {
            this.<CurrentHighSpinThreshold>k__BackingField = value;
        }
        public int get_CurrentHighBetOption()
        {
            return (int)this.<CurrentHighBetOption>k__BackingField;
        }
        private void set_CurrentHighBetOption(int value)
        {
            this.<CurrentHighBetOption>k__BackingField = value;
        }
        public static bool get_IsGameStartFtuxFinished()
        {
            return RestaurantRivals.RESFTUXManager.IsCompleteFTUX(FTUXType:  9);
        }
        public static RestaurantRivals.RESManager.AttackResult get_HackAttackResult()
        {
            null = null;
        }
        public static void set_HackAttackResult(RestaurantRivals.RESManager.AttackResult value)
        {
            null = null;
            RestaurantRivals.RESManager._hackAttackResult = value;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            RestaurantRivals.RESManager._hackAttackResult = ;
            string val_1 = 567353984 + 425504768;
            UnityEngine.Debug.LogError(message:  567353984);
        }
        public System.Collections.Generic.List<string> get_HackSlotResultLog()
        {
        
        }
        public void HackAddSlotResultLog(string str)
        {
            System.Collections.Generic.List<System.String> val_2 = this._hackSlotResultLog;
            if(val_2 != 0)
            {
                goto label_1;
            }
            
            val_2 = null;
            val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this._hackSlotResultLog = val_2;
            if(val_2 == 0)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = this._hackSlotResultLog;
            val_2.RemoveAt(index:  0);
            this._hackSlotResultLog.Add(item:  str);
            return;
            label_2:
        }
        public override void InitMonoSingleton()
        {
            var val_4;
            this.spinBetIndex = 0;
            this.IsAutoSpin = false;
            this.<CanShowHighstakesReadyTip>k__BackingField = 0;
            this.paddingRoller.replacement = 0;
            var val_4 = 23927874;
            val_4 = 11697668 + val_4;
            if(val_4 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_4 = null;
            val_4 = null;
            var val_6 = 0;
            this.paddingRoller.addIntRange(lowest:  0, highest:  (RestaurantRivals.RESSymbol.currentOrdered + 12) - 1);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.levelProgress = null;
            do
            {
                var val_5 = 5;
                do
            {
                Add(item:  false);
                val_5 = val_5 - 1;
            }
            while((new System.Collections.Generic.List<System.Boolean>()) != 0);
            
                this.levelProgress.Add(item:  80883712);
                val_6 = val_6 + 1;
            }
            while(val_6 != 5);
        
        }
        private void Start()
        {
            var val_8;
            var val_10;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Init();
            this.RecalcSession();
            this.RechargeSpins();
            do
            {
                this.paddingRoller.reset();
                var val_8 = 23927242;
                val_8 = 11698300 + val_8;
                val_8 = null;
                val_8 = null;
                var val_9 = 0;
                val_9 = RestaurantRivals.RESSymbol.currentOrdered * val_9;
                var val_13 = 0;
                this.paddingRoller.use(item:  RestaurantRivals.RESSymbol.currentOrdered.IndexOf(item:  this.reelData[val_9]));
                do
            {
                var val_11 = 23926954;
                val_11 = 11698588 + val_11;
                val_10 = null;
                val_10 = null;
                int val_3 = this.paddingRoller.roll(unweighted:  false);
                if((RestaurantRivals.RESSymbol.currentOrdered + 12) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_12 = RestaurantRivals.RESSymbol.currentOrdered + 8;
                val_12 = val_12 + (val_3 << 2);
                val_13 = val_13 + 1;
                this.reelData[0] = (RestaurantRivals.RESSymbol.currentOrdered + 8 + (val_3) << 2) + 16;
            }
            while(val_13 != 5);
            
            }
            while(1 != 3);
            
            if((RestaurantRivals.RESFTUXManager.IsCompleteFTUX(FTUXType:  16)) == true)
            {
                    return;
            }
            
            RestaurantRivals.RESPlayer val_5 = RestaurantRivals.RESPlayer.Instance;
            if((val_4 + 292) < 18)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_7 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        public bool IsHighStakesReady()
        {
            var val_3;
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            if(null <= 3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = 0;
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            if(null <= 3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(null >= 52)
            {
                    val_3 = 1;
            }
            
            return true;
        }
        public void IncreaseSpinBet()
        {
            int val_5;
            System.Collections.Generic.List<System.Int32> val_6;
            val_5 = this.spinBetIndex + 1;
            this.spinBetIndex = val_5;
            if(val_5 == this.spinBetIndex)
            {
                goto label_8;
            }
            
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            val_6 = this.spinBalanceThresholds;
            val_5 = this.spinBetIndex;
            if(null <= val_5)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + (val_5 << 2);
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            val_5 = this.betUnlockLevel;
            val_6 = this.spinBetIndex;
            if(null <= val_6)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + (val_6 << 2);
            if(null >= ((0 + (this.spinBetIndex) << 2) + 16))
            {
                goto label_14;
            }
            
            label_8:
            this.spinBetIndex = 0;
            label_14:
            this.RecalcSession();
            NotificationCenter val_3 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  568330672, aName:  -1275408160);
        }
        public void DecreaseSpinBet()
        {
            var val_5;
            System.Collections.Generic.List<System.Int32> val_6;
            val_5 = 5;
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            val_6 = this.betUnlockLevel;
            var val_2 = val_5 - 4;
            if(null <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            int val_3 = val_5 - 5;
            if(null >= 1)
            {
                    RestaurantRivals.RESPlayer val_4 = RestaurantRivals.RESPlayer.Instance;
                val_6 = this.spinBalanceThresholds;
                if(null <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(val_3 < this.spinBetIndex)
            {
                    if(this.spinBetIndex <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                RestaurantRivals.RESPlayer val_5 = RestaurantRivals.RESPlayer.Instance;
                val_5 = val_5 + 1;
            }
            
            }
            
            this.spinBetIndex = val_3;
            this.RecalcSession();
            NotificationCenter val_6 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  568467248, aName:  -1275408160);
        }
        public void AwardSpins(int amount, string source = "", bool notify = True)
        {
            var val_6;
            string val_7;
            val_6 = notify;
            amount = this.Spins + amount;
            this.Spins = amount;
            Player val_2 = App.Player;
            val_7 = 0;
            val_7.SaveState();
            if(val_6 != false)
            {
                    NotificationCenter val_3 = NotificationCenter.DefaultCenter;
                val_6 = 0;
                val_6.PostNotification(aSender:  568595632, aName:  -1275408272);
            }
            
            if((System.String.IsNullOrEmpty(value:  source)) != true)
            {
                    val_7 = 0;
                Player val_5 = App.Player;
                val_6 = 0;
                val_6.TrackNonCoinReward(source:  source, subSource:  null, rewardType:  -837290080, rewardAmount:  val_7, additionalParams:  val_7);
            }
            
            this.RecalcSession();
            this.CheckCanShowHighstakesReadyTip();
        }
        public void DebitSpins(int amount, bool notify = True)
        {
            this.Spins = UnityEngine.Mathf.Max(a:  0, b:  this.Spins - amount);
            this.<CanShowHighstakesReadyTip>k__BackingField = false;
            if(notify == false)
            {
                    return;
            }
            
            NotificationCenter val_4 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  568711728, aName:  -1275408272);
        }
        public void AwardWelcomeBonus()
        {
            this.AwardSpins(amount:  50, source:  1098586544, notify:  false);
            decimal val_1 = new System.Decimal(value:  1000000);
            CurrencyController.CreditBalance(value:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.flags}, source:  "", externalParams:  0, animated:  true);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_14.StartSpinGetEffects(spins:  0, recharge:  false);
            int val_3 = RestaurantRivals.RESFTUXManager.CompleteFTUX(FTUXType:  16);
            RestaurantRivals.RESPlayer val_4 = RestaurantRivals.RESPlayer.Instance;
            SaveState();
        }
        public string GetRechargeableSpinTimer()
        {
            var val_3;
            var val_13;
            var val_18;
            var val_19;
            this.RechargeSpins();
            val_18 = 1152921505032298496;
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            System.DateTime val_2 = Date;
            val_19 = null;
            val_19 = null;
            System.DateTime val_5 = Date;
            if((val_3.Equals(value:  new System.DateTime() {dateData = 1152921513765705248})) != false)
            {
                    return;
            }
            
            RestaurantRivals.RESPlayer val_9 = RestaurantRivals.RESPlayer.Instance;
            System.DateTime val_10 = AddHours(value:  null);
            System.DateTime val_11 = DateTimeCheat.UtcNow;
            System.TimeSpan val_12 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513765705224}, d2:  new System.DateTime());
            int val_15 = val_13.Minutes;
            val_18 = 1152921504619999232;
            int val_16 = val_13.Seconds;
            string val_17 = System.String.Format(format:  2133722016, arg0:  13152256, arg1:  13152256);
        }
        public UnityEngine.Sprite GetSymbolSprite(string symbol)
        {
            UnityEngine.Sprite val_8;
            var val_9;
            if((System.String.op_Equality(a:  symbol, b:  569027824)) != false)
            {
                    val_8 = this.symbolCoinSprite;
            }
            else
            {
                    if((System.String.op_Equality(a:  symbol, b:  569027904)) != false)
            {
                    val_8 = this.symbolBagSprite;
            }
            else
            {
                    if((System.String.op_Equality(a:  symbol, b:  249556880)) != false)
            {
                    val_8 = this.symbolAttackSprite;
            }
            else
            {
                    if((System.String.op_Equality(a:  symbol, b:  -1202791792)) != false)
            {
                    val_8 = this.symbolRaidSprite;
            }
            else
            {
                    if((System.String.op_Equality(a:  symbol, b:  569027984)) != false)
            {
                    val_8 = this.symbolShieldSprite;
            }
            else
            {
                    val_9 = 0;
                if((System.String.op_Equality(a:  symbol, b:  -1987367408)) != false)
            {
                    val_8 = this.symbolSpinSprite;
            }
            else
            {
                    if((System.String.op_Equality(a:  symbol, b:  569028064)) == false)
            {
                    return;
            }
            
                val_8 = this.symbolHotNSpicySprite;
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            val_9 = mem[this.symbolHotNSpicySprite];
        }
        public string GetRandomSymbol()
        {
            var val_2;
            var val_2 = 23919882;
            val_2 = 11705660 + val_2;
            if(val_2 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_2 = null;
            val_2 = null;
            int val_1 = UnityEngine.Random.Range(min:  0, max:  RestaurantRivals.RESSymbol.currentOrdered + 12);
            if((RestaurantRivals.RESSymbol.currentOrdered + 12) <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = RestaurantRivals.RESSymbol.currentOrdered + 8;
            val_3 = val_3 + (val_1 << 2);
        }
        public void SpinPressed()
        {
            var val_18;
            var val_19;
            var val_20;
            RestaurantRivals.RESSpin val_21;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(getSpinsRemaining == 0)
            {
                    UnityEngine.Debug.LogError(message:  569256240);
                this.RecalcSession();
            }
            
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_4 = RestaurantRivals.RESPlayer.Instance;
            val_18 = 0;
            typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_124 = val_18;
            RestaurantRivals.RESPlayer val_5 = RestaurantRivals.RESPlayer.Instance;
            val_19 = null;
            val_19 = null;
            if(1030672 < (RestaurantRivals.RESGameEcon.FTUXScripts + 12))
            {
                    val_20 = null;
                val_20 = null;
                RestaurantRivals.RESPlayer val_6 = RestaurantRivals.RESPlayer.Instance;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_21 = public static RestaurantRivals.RESSlotMachine MonoSingleton<RestaurantRivals.RESSlotMachine>::get_Instance();
                RestaurantRivals.RESSpin val_8 = getNextSpinByType(payoutType:  (RestaurantRivals.RESGameEcon.FTUXScripts + 8 + (RestaurantRivals.RESGameEcon.DailyBonusRewardTypeChances.__il2cppRuntimeField_124) << 2) + 16 + 12);
            }
            else
            {
                    twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_21 = public static RestaurantRivals.RESSlotMachine MonoSingleton<RestaurantRivals.RESSlotMachine>::get_Instance();
                RestaurantRivals.RESSpin val_10 = getNextSpin;
            }
            
            this.<SpinResult>k__BackingField = val_21;
            this.DebitSpins(amount:  this.SpinBet, notify:  true);
            SlotsGameSessionEventTracker.AddSpinBet(spinBet:  this.SpinBet);
            this.<CanShowHighstakesReadyTip>k__BackingField = false;
            this.PrepareReelsData();
            RestaurantRivals.RESPlayer val_13 = RestaurantRivals.RESPlayer.Instance;
            SaveState();
            string val_14 = this.<SpinResult>k__BackingField.reel1Result;
            string val_15 = this.<SpinResult>k__BackingField.reel2Result;
            string val_16 = this.<SpinResult>k__BackingField.reel3Result;
            string val_17 = System.String.Format(format:  569268848, arg0:  this.<SpinResult>k__BackingField, arg1:  this.<SpinResult>k__BackingField, arg2:  this.<SpinResult>k__BackingField);
            this.HackAddSlotResultLog(str:  569268848);
        }
        public bool DoAttackAction()
        {
            int val_14;
            int val_15;
            int val_16;
            int val_17;
            var val_21;
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            val_21 = 0;
            if((MonoExtensions.IsBitSet(value:  typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_12C, bit:  6)) != false)
            {
                    RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
                val_21 = (MonoExtensions.IsBitSet(value:  typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_12C, bit:  7)) ^ 1;
            }
            
            RestaurantRivals.RESPlayer val_5 = RestaurantRivals.RESPlayer.Instance;
            if((MonoExtensions.IsBitSet(value:  typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_12C, bit:  7)) != false)
            {
                    bool val_7 = RestaurantRivals.RESManager.IsGameStartFtuxFinished;
            }
            
            if(val_21 == false)
            {
                    1 = 0;
            }
            
            if(val_7 ^ 1 == false)
            {
                goto label_14;
            }
            
            label_24:
            RestaurantRivals.RESPlayer val_9 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESLevelDef val_10 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  425451520);
            int val_11 = this.SpinBet;
            decimal val_13 = System.Decimal.op_Implicit(value:  569405180);
            RestaurantRivals.RESPlayer val_18 = RestaurantRivals.RESPlayer.Instance;
            typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_170 = ((uint)((typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_170>>1) & 0x1F) | 16);
            this.SetRaidAttackResults(winnings:  new System.Decimal() {flags = val_14, hi = val_15, lo = val_16, mid = val_17});
            return (bool)1;
            label_14:
            bool val_19 = val_7.RollAttackResult();
            goto label_24;
        }
        public void SetRaidAttackResults(decimal winnings)
        {
            int val_2;
            if((this.<SpinResult>k__BackingField) == 0)
            {
                    return;
            }
            
            val_2 = winnings.mid;
            val_2 = val_2;
            if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = mem[this.<SpinResult>k__BackingField.coinGain + (0)], hi = mem[this.<SpinResult>k__BackingField.coinGain + (4)], lo = mem[this.<SpinResult>k__BackingField.coinGain + (8)], mid = mem[this.<SpinResult>k__BackingField.coinGain + (12)]}, d2:  new System.Decimal() {flags = winnings.flags, hi = winnings.hi, lo = winnings.lo, mid = val_2})) == true)
            {
                    return;
            }
            
            this.<SpinResult>k__BackingField.SetRaidAttackResults(winnings:  new System.Decimal() {flags = winnings.flags, hi = winnings.hi, lo = winnings.lo, mid = val_2});
        }
        public void EndSpin()
        {
            if(this.AwardPayout().Spins >= this.SpinBet)
            {
                    return;
            }
            
            R4.IsAutoSpin = false;
        }
        public void RecalcSession()
        {
            int val_5;
            int val_6;
            int val_7;
            int val_8;
            int val_14;
            int val_15;
            int val_16;
            UnityEngine.Debug.LogWarning(message:  569745616);
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESLevelDef val_2 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  425451520);
            var val_17 = 0;
            val_14 = 0;
            val_15 = 0;
            val_16 = 0;
            do
            {
                var val_16 = 0;
                do
            {
                if((mem[1152921513766551372] + 12) <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_14 = mem[1152921513766551372] + 8;
                val_14 = val_14 + 0;
                if(((mem[1152921513766551372] + 8 + 0) + 16 + 12) <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_15 = (mem[1152921513766551372] + 8 + 0) + 16 + 8;
                val_15 = val_15 + val_16;
                if((((mem[1152921513766551372] + 8 + 0) + 16 + 8 + 0) + 16) != 0)
            {
                    decimal val_3 = getBuildCost(category:  425451520, tier:  0);
                decimal val_4 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 569757724}, d2:  new System.Decimal() {flags = val_14});
                val_16 = val_5;
                val_15 = val_6;
                val_14 = val_7;
            }
            
                val_16 = val_16 + 1;
            }
            while(val_16 != 5);
            
                val_17 = val_17 + 1;
            }
            while(val_17 != 5);
            
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_10 = this.SpinBet;
            RestaurantRivals.RESPlayer val_12 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_13 = RestaurantRivals.RESPlayer.Instance;
            CalculateSessionOutcome(spinBet:  val_10, spinBalance:  val_10.Spins, coinBalance:  new System.Decimal() {flags = 425451520, hi = RestaurantRivals.RESManager.__il2cppRuntimeField_fields, lo = RestaurantRivals.RESManager.__il2cppRuntimeField_events, mid = RestaurantRivals.RESManager.__il2cppRuntimeField_properties}, shieldBalance:  IL2CPP_Property{name:player, type: RestaurantRivals.RESPlayer, class: RestaurantRivals.RESPlayer, IsStatic}.__il2cppRuntimeField_128, currentLevel:  null, levelProgress:  new System.Decimal() {flags = val_16, hi = val_15, lo = val_8, mid = val_14});
        }
        public void RestPlayerDataOnIncompletedFTUX()
        {
            var val_45;
            UnityEngine.PlayerPrefs.DeleteAll();
            ReturnGameGiftManager.Reset();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_18.ResetForest();
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_12C = 0;
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_130 = 0;
            RestaurantRivals.RESPlayer val_4 = RestaurantRivals.RESPlayer.Instance;
            typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_134 = 0;
            RestaurantRivals.RESPlayer val_5 = RestaurantRivals.RESPlayer.Instance;
            typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_138 = 0;
            RestaurantRivals.RESPlayer val_6 = RestaurantRivals.RESPlayer.Instance;
            typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_13C = 0;
            RestaurantRivals.RESPlayer val_7 = RestaurantRivals.RESPlayer.Instance;
            typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_140 = 0;
            RestaurantRivals.RESPlayer val_8 = RestaurantRivals.RESPlayer.Instance;
            typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_144 = 0;
            RestaurantRivals.RESPlayer val_9 = RestaurantRivals.RESPlayer.Instance;
            typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_148 = 0;
            RestaurantRivals.RESPlayer val_10 = RestaurantRivals.RESPlayer.Instance;
            typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_120 = 8;
            RestaurantRivals.RESPlayer val_11 = RestaurantRivals.RESPlayer.Instance;
            mem[300] = 0;
            RestaurantRivals.RESPlayer val_12 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_13 = RestaurantRivals.RESPlayer.Instance;
            mem[296] = 0;
            RestaurantRivals.RESPlayer val_14 = RestaurantRivals.RESPlayer.Instance;
            0.ResetPlayerCredits();
            RestaurantRivals.RESPlayer val_15 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.Map val_16 = RestaurantRivals.RESGameEconHelper.CreateStartingMap();
            mem[348] = 0;
            RestaurantRivals.RESPlayer val_17 = RestaurantRivals.RESPlayer.Instance;
            val_45 = null;
            val_45 = null;
            mem[352] = System.DateTime.MaxValue;
            mem[356] = System.DateTime.DateDataField.__il2cppRuntimeField_14;
            RestaurantRivals.RESPlayer val_18 = RestaurantRivals.RESPlayer.Instance;
            GameBehavior val_19 = App.getBehavior;
            stars = 0;
            RestaurantRivals.RESPlayer val_20 = RestaurantRivals.RESPlayer.Instance;
            string val_22 = UnityEngine.Random.Range(min:  1000, max:  10000).ToString();
            string val_23 = System.String.Format(format:  -731651520, arg0:  569869752);
            System.DateTime.DateDataField.__il2cppRuntimeField_154 = "Guest_{0}";
            RestaurantRivals.RESPlayer val_24 = RestaurantRivals.RESPlayer.Instance;
            twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            "Guest_{0}".__il2cppRuntimeField_150 = UnityEngine.Random.Range(min:  0, max:  public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C.AvatarSpritesCount);
            RestaurantRivals.RESPlayer val_28 = RestaurantRivals.RESPlayer.Instance;
            mem2[0] = 0;
            twelvegigs.Autopilot.AutopilotManager val_29 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            RestaurantRivals.RESPlayer val_30 = RestaurantRivals.RESPlayer.Instance;
            System.Nullable<System.Int32> val_31 = new System.Nullable<System.Int32>(value:  -835497904);
            RestaurantRivals.RESPlayer val_32 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_33 = RestaurantRivals.RESPlayer.Instance;
            System.Nullable<System.Int32> val_34 = new System.Nullable<System.Int32>(value:  mem[null..ctor(value:  -835497904) + 348] + 76);
            RestaurantRivals.RESPlayer val_35 = RestaurantRivals.RESPlayer.Instance;
            System.Nullable<System.Int32> val_36 = new System.Nullable<System.Int32>(value:  mem[null..ctor(value:  mem[null..ctor(value:  -835497904) + 348] + 76) + 296]);
            RestaurantRivals.RESPlayer val_37 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_38 = RestaurantRivals.RESPlayer.Instance;
            System.Nullable<System.Int32> val_39 = new System.Nullable<System.Int32>(value:  mem[null..ctor(value:  mem[null..ctor(value:  mem[null..ctor(value:  -835497904) + 348] + 76) + 296]) + 336]);
            public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_18.SetMapProfile(level:  new System.Nullable<System.Int32>() {HasValue = val_31.HasValue}, map:  0, stars:  new System.Nullable<System.Int32>() {HasValue = mem[null..ctor(value:  -835497904) + 348]}, shields:  new System.Nullable<System.Int32>() {HasValue = val_34.HasValue}, name:  val_34.HasValue, avatarid:  new System.Nullable<System.Int32>() {HasValue = false}, responseCallback:  0);
            NotificationCenter val_40 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  0, aName:  -2092882624);
            SLC.Social.Leagues.LeaguesDataController val_41 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(0 != 0)
            {
                    SLC.Social.Leagues.LeaguesDataController val_43 = SLC.Social.Leagues.LeaguesManager.DAO;
                0.UpdateLocalProfile();
            }
            
            Player val_44 = App.Player;
            0.SaveState();
        }
        private void PrepareReelsData()
        {
            var val_6;
            RandomSet val_10;
            var val_11;
            System.Collections.Generic.List<System.String> val_12;
            System.Collections.Generic.List<System.String> val_14;
            var val_15;
            val_6 = this;
            string val_1 = this.<SpinResult>k__BackingField.reel1Result;
            this.reelData[2] = this.<SpinResult>k__BackingField;
            string val_2 = this.<SpinResult>k__BackingField.reel2Result;
            this.reelData[this.<SpinResult>k__BackingField.spinBet] = this.<SpinResult>k__BackingField;
            string val_3 = this.<SpinResult>k__BackingField.reel3Result;
            this.reelData[(this.<SpinResult>k__BackingField.spinBet) << 3] = this.<SpinResult>k__BackingField;
            do
            {
                this.paddingRoller.reset();
                val_10 = this.paddingRoller;
                var val_6 = 23918026;
                val_6 = 11707516 + val_6;
                val_11 = null;
                val_11 = null;
                val_12 = RestaurantRivals.RESSymbol.currentOrdered;
                val_14 = RestaurantRivals.RESSymbol.currentOrdered;
                var val_7 = 0;
                val_7 = val_14 * val_7;
                var val_11 = 0;
                val_10.use(item:  val_12.IndexOf(item:  this.reelData[val_7]));
                do
            {
                if(val_11 != 2)
            {
                    val_12 = this.reelData;
                var val_9 = 23917730;
                val_9 = 11707812 + val_9;
                val_15 = null;
                val_15 = null;
                val_10 = val_6;
                int val_5 = this.paddingRoller.roll(unweighted:  false);
                if((RestaurantRivals.RESSymbol.currentOrdered + 12) <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_10 = RestaurantRivals.RESSymbol.currentOrdered + 8;
                val_10 = val_10 + (val_5 << 2);
                val_6 = val_10;
                val_14 = mem[(RestaurantRivals.RESSymbol.currentOrdered + 8 + (val_5) << 2) + 8];
                val_14 = (RestaurantRivals.RESSymbol.currentOrdered + 8 + (val_5) << 2) + 8;
                val_12[0] = (RestaurantRivals.RESSymbol.currentOrdered + 8 + (val_5) << 2) + 16;
            }
            
                val_11 = val_11 + 1;
            }
            while(val_11 != 5);
            
            }
            while(1 != 3);
        
        }
        private bool AwardPayout()
        {
            RestaurantRivals.RESManager val_23;
            float val_24;
            decimal val_25;
            var val_26;
            var val_28;
            FieldInfo* val_29;
            string val_30;
            string val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            val_23 = this;
            if((this.<SpinResult>k__BackingField) == 0)
            {
                goto label_1;
            }
            
            RestaurantRivals.RESSpin val_1 = (this.<SpinResult>k__BackingField) + 68;
            val_24 = 1152921504617017344;
            val_25 = this.<SpinResult>k__BackingField.coinGain;
            val_26 = null;
            val_26 = null;
            val_28 = 0;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_25, hi = mem[(this.<SpinResult>k__BackingField + 68) + (0)], lo = mem[(this.<SpinResult>k__BackingField + 68) + (4)], mid = mem[(this.<SpinResult>k__BackingField + 68) + (8)]}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
            {
                goto label_4;
            }
            
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            if((this.<SpinResult>k__BackingField) == 0)
            {
                    val_29 = val_29;
            }
            
            val_30 = RestaurantRivals.RESManager.__il2cppRuntimeField_events;
            val_23 = val_23;
            if((System.Decimal.op_Inequality(d1:  new System.Decimal() {flags = 425451520, hi = 425463808, lo = 425480192, mid = 425472000}, d2:  new System.Decimal() {flags = mem[this.<SpinResult>k__BackingField.coinBalance + (0)], hi = mem[this.<SpinResult>k__BackingField.coinBalance + (4)], lo = mem[this.<SpinResult>k__BackingField.coinBalance + (8)], mid = this.<SpinResult>k__BackingField})) != false)
            {
                    val_29 = 0;
                UnityEngine.Debug.LogWarning(message:  570515968);
            }
            
            if((this.<SpinResult>k__BackingField.payout) != 7)
            {
                goto label_15;
            }
            
            val_31 = "Attack";
            goto label_16;
            label_1:
            val_32 = 0;
            return (bool)val_32;
            label_15:
            val_29 = this.<SpinResult>k__BackingField.payout;
            val_30 = "Raid";
            label_16:
            CurrencyController.CreditBalance(value:  new System.Decimal() {flags = mem[this.<SpinResult>k__BackingField.coinGain + (0)], hi = mem[this.<SpinResult>k__BackingField.coinGain + (4)], lo = mem[this.<SpinResult>k__BackingField.coinGain + (8)], mid = mem[this.<SpinResult>k__BackingField.coinGain + (12)]}, source:  val_31 = val_30, externalParams:  0, animated:  true);
            SlotsGameSessionEventTracker.AddCoins(coins:  new System.Decimal() {flags = mem[this.<SpinResult>k__BackingField.coinGain + (0)], hi = mem[this.<SpinResult>k__BackingField.coinGain + (4)], lo = mem[this.<SpinResult>k__BackingField.coinGain + (8)], mid = mem[this.<SpinResult>k__BackingField.coinGain + (12)]});
            val_28 = 1;
            label_4:
            if((this.<SpinResult>k__BackingField.shieldGain) >= 1)
            {
                    RestaurantRivals.RESPlayer val_5 = RestaurantRivals.RESPlayer.Instance;
                int val_6 = MaxShieldCount;
                RestaurantRivals.RESPlayer val_9 = RestaurantRivals.RESPlayer.Instance;
                typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_128 = MaxShieldCount;
                val_28 = 1;
            }
            
            if((this.<SpinResult>k__BackingField.spinGain) >= 1)
            {
                    this.AwardSpins(amount:  this.<SpinResult>k__BackingField.spinGain, source:  1098586544, notify:  false);
                val_28 = 1;
            }
            
            if((this.<SpinResult>k__BackingField.eventSymbolGain) < 1)
            {
                    0 = 1;
            }
            
            if(val_28 == 1)
            {
                    RestaurantRivals.RESPlayer val_12 = RestaurantRivals.RESPlayer.Instance;
                typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_16C = 0;
                RestaurantRivals.RESPlayer val_13 = RestaurantRivals.RESPlayer.Instance;
                typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_168 = 0;
            }
            
            RestaurantRivals.RESPlayer val_14 = RestaurantRivals.RESPlayer.Instance;
            if(null != 0)
            {
                    val_33 = null;
            }
            else
            {
                    val_33 = 292;
                val_34 = 1030672;
            }
            
            mem[292] = 1030673;
            if(RestaurantRivals.RESManager.IsGameStartFtuxFinished != true)
            {
                    RestaurantRivals.RESPlayer val_16 = RestaurantRivals.RESPlayer.Instance;
                int val_17 = RestaurantRivals.RESFTUXManager.CompleteFTUX(FTUXType:  9);
                Player val_18 = App.Player;
                0.SaveState();
                WGBonusRewardsHandler val_19 = DefaultHandler<WGBonusRewardsHandler>.Instance;
                RequestDataFlush(immediate:  false, reset:  false);
            }
            
            var val_23 = 23914112;
            val_23 = 11711428 + val_23;
            if(val_23 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_35 = null;
            val_35 = null;
            RestaurantRivals.RESPlayer val_20 = RestaurantRivals.RESPlayer.Instance;
            val_36 = null;
            val_36 = null;
            this.RecalcSession();
            if((this.<SpinResult>k__BackingField.payout) == 8)
            {
                    twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                ResetRaidOpponent();
            }
            
            this.<SpinResult>k__BackingField = 0;
            Player val_22 = App.Player;
            0.SaveState();
            val_32 = 1;
            return (bool)val_32;
        }
        private bool RollAttackResult()
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_6 = 23928049;
            val_6 = 11708956 + val_6;
            if(val_6 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_6 = null;
            val_6 = null;
            val_7 = 1;
            if(RestaurantRivals.RESManager._hackAttackResult == 1)
            {
                    return (bool)val_7;
            }
            
            if(val_6 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_8 = null;
            val_8 = null;
            val_7 = 0;
            if(RestaurantRivals.RESManager._hackAttackResult == 2)
            {
                    return (bool)val_7;
            }
            
            float val_1 = UnityEngine.Random.Range(min:  null, max:  null);
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESGameEcon val_4 = RestaurantRivals.RESGameEcon.Instance;
            val_9 = 0 + 1388;
            if(0 <= 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        private void CheckCanShowHighstakesReadyTip()
        {
            var val_3;
            var val_4;
            val_3 = 0;
            val_4 = 4;
            goto label_1;
            label_11:
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            if(null <= R6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(null >= 2621443)
            {
                    if(this.Spins <= R6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = val_3;
            }
            
            val_4 = 5;
            label_1:
            if((val_4 - 4) < 2621443)
            {
                goto label_11;
            }
            
            if(val_3 >= 3)
            {
                    if(false <= val_3)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4 = val_4 + 0;
                if(((0 + 0) + 16) > (this.<CurrentHighSpinThreshold>k__BackingField))
            {
                    this.<CanShowHighstakesReadyTip>k__BackingField = true;
            }
            
            }
            else
            {
                    this.<CanShowHighstakesReadyTip>k__BackingField = false;
            }
            
            if(false <= val_3)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            this.<CurrentHighSpinThreshold>k__BackingField = (0 + 0) + 16;
            if(((0 + 0) + 16) <= val_3)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 0;
            this.<CurrentHighBetOption>k__BackingField = (0 + 0) + 16;
        }
        private void RechargeSpins()
        {
            ulong val_3;
            var val_4;
            var val_6;
            var val_34;
            var val_35;
            var val_37;
            int val_38;
            var val_39;
            this.UpdateTimerState();
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            System.DateTime val_2 = Date;
            val_34 = 1152921504616751104;
            val_35 = null;
            val_35 = null;
            System.DateTime val_5 = Date;
            bool val_8 = val_3.Equals(value:  new System.DateTime() {dateData = 1152921513767728200});
            if(val_8 == true)
            {
                    return;
            }
            
            if(val_8.Spins >= RestaurantRivals.RESManager.RechargeableSpinAmount)
            {
                    return;
            }
            
            System.DateTime val_11 = DateTimeCheat.UtcNow;
            RestaurantRivals.RESPlayer val_12 = RestaurantRivals.RESPlayer.Instance;
            System.TimeSpan val_13 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513767728184}, d2:  new System.DateTime() {dateData = val_3});
            double val_14 = val_6.TotalHours;
            if(System.DateTime.__il2cppRuntimeField_cctor_finished == 0)
            {
                    570946648 = 570946648;
            }
            
            if(S0 < 1)
            {
                    return;
            }
            
            var val_32 = val_6.Spins;
            val_38 = S0 + (S0 << 2);
            val_32 = val_32 + val_38;
            if(val_32 > RestaurantRivals.RESManager.RechargeableSpinAmount)
            {
                    int val_17 = RestaurantRivals.RESManager.RechargeableSpinAmount;
                val_38 = val_17 - val_17.Spins;
            }
            
            RestaurantRivals.RESPlayer val_19 = RestaurantRivals.RESPlayer.Instance;
            val_37 = 0;
            System.DateTime val_20 = Date;
            val_39 = null;
            val_39 = null;
            System.DateTime val_21 = Date;
            if((val_3.Equals(value:  new System.DateTime() {dateData = 1152921513767728200})) != true)
            {
                    RestaurantRivals.RESPlayer val_23 = RestaurantRivals.RESPlayer.Instance;
                RestaurantRivals.RESPlayer val_24 = RestaurantRivals.RESPlayer.Instance;
                val_34 = null;
                System.DateTime val_26 = AddHours(value:  val_6.TotalHours);
                typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_160 = val_3;
                typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_164 = val_4;
                Player val_27 = App.Player;
                val_37 = 0;
                val_37.SaveState();
            }
            
            if(RestaurantRivals.RESManager.IsGameStartFtuxFinished == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_29 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_37 = public static RestaurantRivals.RESRaidAttackScreenUI MonoSingleton<RestaurantRivals.RESRaidAttackScreenUI>::get_Instance();
            if(522423488 == 0)
            {
                    this.AwardSpins(amount:  val_38, source:  1098586544, notify:  false);
                twelvegigs.Autopilot.AutopilotManager val_31 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_14.StartSpinGetEffects(spins:  val_38, recharge:  true);
                return;
            }
            
            this.AwardSpins(amount:  val_38, source:  1098586544, notify:  true);
        }
        private void UpdateTimerState()
        {
            var val_5;
            var val_6;
            var val_23;
            System.DateTime val_25;
            var val_26;
            var val_28;
            if(this.Spins < RestaurantRivals.RESManager.RechargeableSpinAmount)
            {
                goto label_3;
            }
            
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            System.DateTime val_4 = Date;
            val_23 = null;
            val_23 = null;
            System.DateTime val_7 = Date;
            if((val_5.Equals(value:  new System.DateTime() {dateData = 1152921513767840344})) == false)
            {
                goto label_9;
            }
            
            label_3:
            RestaurantRivals.RESPlayer val_11 = RestaurantRivals.RESPlayer.Instance;
            System.DateTime val_12 = Date;
            val_25 = 1152921504616751104;
            val_26 = null;
            val_26 = null;
            System.DateTime val_13 = Date;
            bool val_14 = val_5.Equals(value:  new System.DateTime() {dateData = 1152921513767840344});
            if((val_14 == false) || (val_14.Spins >= RestaurantRivals.RESManager.RechargeableSpinAmount))
            {
                goto label_18;
            }
            
            RestaurantRivals.RESPlayer val_17 = RestaurantRivals.RESPlayer.Instance;
            System.DateTime val_18 = DateTimeCheat.UtcNow;
            typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_160 = val_5;
            typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_164 = val_6;
            goto label_24;
            label_9:
            RestaurantRivals.RESPlayer val_19 = RestaurantRivals.RESPlayer.Instance;
            val_28 = null;
            val_28 = null;
            val_25 = System.DateTime.MaxValue;
            typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_160 = val_25;
            typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_164 = System.DateTime.DateDataField.__il2cppRuntimeField_14;
            label_24:
            Player val_20 = App.Player;
            0.SaveState();
            label_18:
            if((UnityEngine.PlayerPrefs.HasKey(key:  571046688)) == true)
            {
                    return;
            }
            
            Player val_22 = App.Player;
            0.SaveState();
        }
        private void UpdateSpinRechargeLPN()
        {
            ulong val_6;
            twelvegigs.plugins.NotificationInterval val_24;
            var val_33;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_35;
            string val_36;
            twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  31);
            if(this.Spins >= RestaurantRivals.RESManager.RechargeableSpinAmount)
            {
                    return;
            }
            
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            System.DateTime val_4 = 0.Date;
            val_33 = null;
            val_33 = null;
            System.DateTime val_5 = Date;
            if((0.Equals(value:  new System.DateTime() {dateData = 1152921513767952472})) == true)
            {
                    return;
            }
            
            System.DateTime val_9 = System.DateTime.UtcNow;
            System.DateTime val_10 = DateTimeCheat.UtcNow;
            RestaurantRivals.RESPlayer val_11 = RestaurantRivals.RESPlayer.Instance;
            System.TimeSpan val_12 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513767952456}, d2:  new System.DateTime() {dateData = val_6});
            System.DateTime val_15 = System.DateTime.op_Subtraction(d:  new System.DateTime() {dateData = 1152921513767952448}, t:  new System.TimeSpan() {_ticks = System.DateTime.MaxValue});
            int val_18 = RestaurantRivals.RESManager.RechargeableSpinAmount;
            float val_33 = (float)val_18 - val_18.Spins;
            val_33 = val_33 / 5f;
            int val_21 = UnityEngine.Mathf.CeilToInt(f:  val_33);
            System.DateTime val_22 = AddHours(value:  null);
            val_35 = 11695328 + 23941488;
            val_36 = "Restaurant Rivals";
            if(val_35 == 0)
            {
                    mem2[0] = 1;
            }
            
            twelvegigs.plugins.LocalNotificationsPlugin.PostNotification(tipo:  31, when:  new System.DateTime() {dateData = 1}, interval:  val_24, optTitle:  0, optMessage:  val_36, extraData:  "Your spins are full. Come back and PLAY!", priority:  0, useTimeModifier:  false);
            int val_26 = RestaurantRivals.RESManager.RechargeableSpinAmount;
            val_26 = val_26 + (val_26 >> 31);
            if(this.Spins >= (val_26 >> 1))
            {
                    return;
            }
            
            int val_27 = RestaurantRivals.RESManager.RechargeableSpinAmount;
            int val_29 = val_27 + (val_27 >> 31);
            val_29 = (val_29 >> 1) - val_27.Spins;
            float val_34 = (float)val_29;
            val_34 = val_34 / 5f;
            int val_30 = UnityEngine.Mathf.CeilToInt(f:  val_34);
            System.DateTime val_31 = System.DateTime.MaxValue.AddHours(value:  null);
            val_36 = "Restaurant Rivals";
            string val_32 = GetHalfSpinReadyLPNMessage();
            val_35 = "Restaurant Rivals";
            twelvegigs.plugins.LocalNotificationsPlugin.PostNotification(tipo:  31, when:  new System.DateTime() {dateData = 1}, interval:  System.DateTime.__il2cppRuntimeField_cctor_finished, optTitle:  0, optMessage:  val_36, extraData:  val_35, priority:  0, useTimeModifier:  false);
        }
        private string GetSpinReadyLPNTitle()
        {
        
        }
        private string GetSpinReadyLPNMessage()
        {
        
        }
        private string GetHalfSpinReadyLPNMessage()
        {
            int val_1 = RestaurantRivals.RESManager.RechargeableSpinAmount;
            int val_2 = val_1 + (val_1 >> 31);
            val_2 = val_2 >> 1;
            string val_3 = System.String.Format(format:  571494976, arg0:  13152256);
        }
        public static UnityEngine.Camera GetCameraByTransform(UnityEngine.Transform obTranform)
        {
            UnityEngine.Object val_6;
            UnityEngine.Object val_7;
            val_6 = obTranform;
            goto label_7;
            label_12:
            UnityEngine.Transform val_1 = val_6.parent;
            val_7 = 0;
            if(val_6 == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_3 = val_6.parent;
            val_6 = val_6;
            label_7:
            object val_4 = val_6.GetComponent<System.Object>();
            val_7 = val_6;
            if(val_7 == 0)
            {
                goto label_12;
            }
        
        }
        public static UnityEngine.Vector3 GetWorldPosInSelCamera(UnityEngine.Transform selfTransform, UnityEngine.Transform targetTransform)
        {
            float val_5;
            float val_6;
            float val_8;
            float val_9;
            UnityEngine.Camera val_1 = RestaurantRivals.RESManager.GetCameraByTransform(obTranform:  targetTransform);
            UnityEngine.Camera val_2 = RestaurantRivals.RESManager.GetCameraByTransform(obTranform:  R2);
            UnityEngine.Vector3 val_3 = position;
            UnityEngine.Vector3 val_7 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = R2, y = val_5, z = val_6});
            UnityEngine.Vector3 val_11 = selfTransform.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = targetTransform, y = val_8, z = val_9});
            return new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        }
        public static void SkipFTUX()
        {
            int val_18;
            var val_54;
            var val_55;
            val_54 = null;
            val_54 = null;
            if(RestaurantRivals.RESFTUXManager.slotPlayDemoPopup != 0)
            {
                    val_55 = null;
                val_55 = null;
                RestaurantRivals.RESFTUXManager.slotPlayDemoPopup.OnNonSequencyFTUXUsed();
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_18.ResetForest();
            var val_54 = 1;
            do
            {
                RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
                RestaurantRivals.RESPlayer val_4 = RestaurantRivals.RESPlayer.Instance;
                typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_12C = MonoExtensions.SetBit(value:  typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_12C, bit:  1);
                val_54 = val_54 + 1;
            }
            while(val_54 != 10);
            
            RestaurantRivals.RESPlayer val_7 = RestaurantRivals.RESPlayer.Instance;
            typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_120 = 0;
            RestaurantRivals.RESPlayer val_8 = RestaurantRivals.RESPlayer.Instance;
            mem[292] = 18;
            RestaurantRivals.RESPlayer val_9 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_10 = RestaurantRivals.RESPlayer.Instance;
            mem[314] = 1;
            RestaurantRivals.RESPlayer val_11 = RestaurantRivals.RESPlayer.Instance;
            decimal val_12 = new System.Decimal(value:  597000);
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 262144, hi = 65536}, d2:  new System.Decimal() {flags = val_12.flags, hi = val_12.hi, lo = val_12.lo, mid = val_12.mid})) != false)
            {
                    RestaurantRivals.RESPlayer val_14 = RestaurantRivals.RESPlayer.Instance;
                decimal val_15;
                val_15 = new System.Decimal(value:  597000);
                RestaurantRivals.RESPlayer val_16 = RestaurantRivals.RESPlayer.Instance;
                decimal val_17 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 571867736, hi = val_15.flags, lo = val_15.hi, mid = val_15.lo}, d2:  new System.Decimal() {flags = val_15.mid, hi = mem[val_12.flags..ctor(value:  597000) + 60], lo = mem[val_12.flags..ctor(value:  597000) + 64], mid = mem[val_12.flags..ctor(value:  597000) + 68]});
                AddCredits(amount:  new System.Decimal() {mid = val_18}, source:  "FTUX hack", subSource:  0, externalParams:  0, doTrack:  true);
            }
            
            RestaurantRivals.RESPlayer val_19 = RestaurantRivals.RESPlayer.Instance;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            mem2[0] = 1;
            RestaurantRivals.RESPlayer val_20 = RestaurantRivals.RESPlayer.Instance;
            1.stars = 1;
            RestaurantRivals.RESPlayer val_21 = RestaurantRivals.RESPlayer.Instance;
            if((System.String.IsNullOrEmpty(value:  null)) != false)
            {
                    RestaurantRivals.RESPlayer val_23 = RestaurantRivals.RESPlayer.Instance;
                string val_25 = UnityEngine.Random.Range(min:  1000, max:  10000).ToString();
                string val_26 = System.String.Format(format:  -731651520, arg0:  571867768);
                typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_154 = "Guest_{0}";
            }
            
            RestaurantRivals.RESPlayer val_27 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_28 = RestaurantRivals.RESPlayer.Instance;
            twelvegigs.Autopilot.AutopilotManager val_29 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            typeof(RestaurantRivals.RESManager).__il2cppRuntimeField_150 = UnityEngine.Random.Range(min:  0, max:  public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C.AvatarSpritesCount);
            twelvegigs.Autopilot.AutopilotManager val_32 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            RestaurantRivals.RESPlayer val_33 = RestaurantRivals.RESPlayer.Instance;
            System.Nullable<System.Int32> val_34 = new System.Nullable<System.Int32>(value:  425451520);
            RestaurantRivals.RESPlayer val_35 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_36 = RestaurantRivals.RESPlayer.Instance;
            System.Nullable<System.Int32> val_37 = new System.Nullable<System.Int32>(value:  mem[null..ctor(value:  425451520) + 348] + 76);
            RestaurantRivals.RESPlayer val_38 = RestaurantRivals.RESPlayer.Instance;
            System.Nullable<System.Int32> val_39 = new System.Nullable<System.Int32>(value:  mem[null..ctor(value:  mem[null..ctor(value:  425451520) + 348] + 76) + 296]);
            RestaurantRivals.RESPlayer val_40 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_41 = RestaurantRivals.RESPlayer.Instance;
            System.Nullable<System.Int32> val_42 = new System.Nullable<System.Int32>(value:  mem[null..ctor(value:  mem[null..ctor(value:  mem[null..ctor(value:  425451520) + 348] + 76) + 296]) + 336]);
            public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_18.SetMapProfile(level:  new System.Nullable<System.Int32>() {HasValue = val_34.HasValue}, map:  0, stars:  new System.Nullable<System.Int32>() {HasValue = mem[null..ctor(value:  425451520) + 348]}, shields:  new System.Nullable<System.Int32>() {HasValue = val_37.HasValue}, name:  val_37.HasValue, avatarid:  new System.Nullable<System.Int32>() {HasValue = false}, responseCallback:  0);
            NotificationCenter val_43 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  0, aName:  -2092882624);
            SLC.Social.Leagues.LeaguesDataController val_44 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(0 != 0)
            {
                    SLC.Social.Leagues.LeaguesDataController val_46 = SLC.Social.Leagues.LeaguesManager.DAO;
                0.UpdateLocalProfile();
            }
            
            Player val_47 = App.Player;
            0.SaveState();
            GameBehavior val_48 = App.getBehavior;
            ThemesHandler val_49 = App.ThemesHandler;
            string val_50 = 0.CurrentThemeName;
            string val_51 = null + 2144339952 + null;
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  null);
            twelvegigs.Autopilot.AutopilotManager val_52 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_53 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        public RESManager()
        {
            this.reelData = null;
            this.paddingRoller = new RandomSet();
            System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
            if(val_2 != 0)
            {
                    Add(item:  1);
                Add(item:  2);
                Add(item:  3);
                Add(item:  5);
                Add(item:  10);
                Add(item:  20);
                Add(item:  40);
                Add(item:  80);
                Add(item:  100);
                Add(item:  200);
                Add(item:  500);
            }
            else
            {
                    Add(item:  1);
                Add(item:  2);
                Add(item:  3);
                Add(item:  5);
                Add(item:  10);
                Add(item:  20);
                Add(item:  40);
                Add(item:  80);
                Add(item:  100);
                Add(item:  200);
                Add(item:  500);
            }
            
            Add(item:  1000);
            this.betOptions = val_2;
            System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
            if(val_3 != 0)
            {
                    Add(item:  0);
                Add(item:  0);
                Add(item:  0);
                Add(item:  51);
                Add(item:  150);
                Add(item:  250);
                Add(item:  500);
                Add(item:  1000);
                Add(item:  2500);
                Add(item:  5000);
                Add(item:  10000);
            }
            else
            {
                    Add(item:  0);
                Add(item:  0);
                Add(item:  0);
                Add(item:  51);
                Add(item:  150);
                Add(item:  250);
                Add(item:  500);
                Add(item:  1000);
                Add(item:  2500);
                Add(item:  5000);
                Add(item:  10000);
            }
            
            Add(item:  20000);
            this.spinBalanceThresholds = val_3;
            System.Collections.Generic.List<System.Int32> val_4 = new System.Collections.Generic.List<System.Int32>();
            if(val_4 != 0)
            {
                    Add(item:  0);
                Add(item:  3);
                Add(item:  3);
                Add(item:  10);
                Add(item:  15);
                Add(item:  20);
                Add(item:  25);
                Add(item:  30);
                Add(item:  35);
                Add(item:  40);
                Add(item:  45);
            }
            else
            {
                    Add(item:  0);
                Add(item:  3);
                Add(item:  3);
                Add(item:  10);
                Add(item:  15);
                Add(item:  20);
                Add(item:  25);
                Add(item:  30);
                Add(item:  35);
                Add(item:  40);
                Add(item:  45);
            }
            
            Add(item:  50);
            this.betUnlockLevel = val_4;
        }
        private static RESManager()
        {
        
        }
    
    }

}
