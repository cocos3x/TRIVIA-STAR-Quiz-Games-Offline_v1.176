using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPIGameplayController : MonoSingleton<SLC.MatchyPics.MPIGameplayController>
    {
        // Fields
        public const string ON_BOMB_EXPLODES = "OnBombExplodes";
        private SLC.MatchyPics.MPIUIController uiController;
        private SLC.MatchyPics.MPILevel <CurrentLevel>k__BackingField;
        private SLC.MatchyPics.MPIGameplayController.State <CurrentState>k__BackingField;
        private int <TimeElapsed>k__BackingField;
        private static bool <AdsDisplaying>k__BackingField;
        private SLC.MatchyPics.MPIBoardController boardController;
        private FrameSkipper frameSkipper;
        private int remainingTime;
        private int totalLevelTime;
        private bool isInApp;
        
        // Properties
        public SLC.MatchyPics.MPILevel CurrentLevel { get; set; }
        public SLC.MatchyPics.MPIGameplayController.State CurrentState { get; set; }
        public int TimeElapsed { get; set; }
        public int CurrentPoints { get; }
        public static bool AdsDisplaying { get; set; }
        
        // Methods
        public SLC.MatchyPics.MPILevel get_CurrentLevel()
        {
        
        }
        private void set_CurrentLevel(SLC.MatchyPics.MPILevel value)
        {
            this.<CurrentLevel>k__BackingField = value;
        }
        public SLC.MatchyPics.MPIGameplayController.State get_CurrentState()
        {
        
        }
        private void set_CurrentState(SLC.MatchyPics.MPIGameplayController.State value)
        {
            this.<CurrentState>k__BackingField = value;
        }
        public int get_TimeElapsed()
        {
            return (int)this.<TimeElapsed>k__BackingField;
        }
        private void set_TimeElapsed(int value)
        {
            this.<TimeElapsed>k__BackingField = value;
        }
        public int get_CurrentPoints()
        {
            if((this.<CurrentLevel>k__BackingField) != 0)
            {
                    this.<CurrentLevel>k__BackingField = this.<CurrentLevel>k__BackingField.Points;
            }
            
            if((this.<CurrentLevel>k__BackingField) == 0)
            {
                    this.<CurrentLevel>k__BackingField = 0;
            }
            
            return (int)this.<CurrentLevel>k__BackingField;
        }
        public static bool get_AdsDisplaying()
        {
            return (bool)SLC.MatchyPics.MPIGameplayController.<AdsDisplaying>k__BackingField;
        }
        public static void set_AdsDisplaying(bool value)
        {
            SLC.MatchyPics.MPIGameplayController.<AdsDisplaying>k__BackingField = value;
        }
        public override void InitMonoSingleton()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  767126608, name:  767102512);
        }
        private void Start()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Events.UnityAction<System.Boolean> val_2 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  767240656, method:  new IntPtr(767214608));
            public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_2C.AddListener(call:  162353152);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  767240656, method:  new IntPtr(767215632));
            public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_28.AddListener(call:  162246656);
            UnityEngine.GameObject val_5 = this.gameObject;
            UnityEngine.UI.LayoutElement val_6 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  767240656);
            this.frameSkipper = this;
            this.Init();
            this.isInApp = true;
        }
        private void OnInterstitialResponse(Notification notification)
        {
            string val_1 = notification.data.ToString();
            SLC.MatchyPics.MPIGameplayController.<AdsDisplaying>k__BackingField = System.Boolean.Parse(value:  notification.data);
            string val_3 = SLC.MatchyPics.MPIGameplayController.<AdsDisplaying>k__BackingField.ToString();
            string val_4 = 767336848 + 767348967;
            UnityEngine.Debug.Log(message:  767336848);
            if((SLC.MatchyPics.MPIGameplayController.<AdsDisplaying>k__BackingField) != false)
            {
                    this.PauseTimer();
                return;
            }
            
            this.StartTimer();
        }
        private void OnMonolithWindowOpened(bool exclusive)
        {
            this.PauseTimer();
        }
        private void OnMonolithWindowClosed()
        {
            this.StartTimer();
        }
        private void OnApplicationPause(bool pause)
        {
            if(pause != false)
            {
                    if(this.isInApp == false)
            {
                    return;
            }
            
                this.isInApp = false;
                this.PauseTimer();
                return;
            }
            
            if(this.isInApp == true)
            {
                    return;
            }
            
            this.isInApp = true;
            this.StartTimer();
        }
        private void OnApplicationFocus(bool focus)
        {
            if(focus != false)
            {
                    if(this.isInApp == true)
            {
                    return;
            }
            
                this.isInApp = true;
                this.StartTimer();
                return;
            }
            
            if(this.isInApp == false)
            {
                    return;
            }
            
            this.isInApp = false;
            this.PauseTimer();
        }
        public void Init()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.boardController = public static SLC.MatchyPics.MPIBoardController MonoSingleton<SLC.MatchyPics.MPIBoardController>::get_Instance();
            Player val_2 = App.Player;
            int val_7 = 0;
            val_7 = val_7 - 1;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.MatchyPics.MPILevel val_4 = GetNewLevel(levelIndex:  val_7);
            this.<CurrentLevel>k__BackingField = public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance();
            this.boardController.LoadLevel(level:  this.<CurrentLevel>k__BackingField);
            this.uiController.Init();
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Init();
            this.<CurrentState>k__BackingField = 0;
            this.TrackLevelStart(startEvent:  1098586544);
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.PlayRandomMusicTrack(type:  1);
        }
        public void OnBoardWasLoaded()
        {
            this.uiController.SetupFTUX();
            this.StartTimer();
        }
        public void EarnPoints(int points)
        {
            SLC.MatchyPics.MPILevel val_2;
            int val_3;
            val_2 = this.<CurrentLevel>k__BackingField;
            if(val_2 != 0)
            {
                    val_3 = this.<CurrentLevel>k__BackingField.Points;
            }
            else
            {
                    val_2 = 32;
                val_3 = 35615780;
            }
            
            mem[32] = val_3 + points;
        }
        public void OnBombExplodes()
        {
            UnityEngine.Debug.LogError(message:  768282144);
            this.<CurrentState>k__BackingField = 3;
            this.PauseTimer();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        public void CollectItem(SLC.MatchyPics.MPIGridTile tile)
        {
            SLC.MatchyPics.MPILevel val_2;
            int val_3;
            val_2 = this.<CurrentLevel>k__BackingField;
            if(val_2 != 0)
            {
                    val_3 = this.<CurrentLevel>k__BackingField.collectedCollectionItems;
            }
            else
            {
                    val_2 = 80;
                val_3 = 4;
            }
            
            mem[80] = 5;
            if(this.uiController.collectionUI == 0)
            {
                    return;
            }
            
            this.uiController.collectionUI.ShowCollectionItem(tile:  tile);
        }
        public void QA_HACK_ExplodeBomb()
        {
            this.OnBombExplodes();
        }
        public void QA_HACK_SetTime(int time)
        {
            this.frameSkipper.updateLogic = 0;
            this.<CurrentLevel>k__BackingField.timeRemaining = time;
            this.StartTimer();
        }
        public void OnLevelCompleted()
        {
            int val_12;
            var val_13;
            string val_14;
            var val_15;
            var val_16;
            if((this.<CurrentState>k__BackingField) == 1)
            {
                    return;
            }
            
            this.PauseTimer();
            this.<CurrentLevel>k__BackingField.timeRemaining = this.remainingTime;
            if((this.<CurrentLevel>k__BackingField) != 0)
            {
                    val_12 = this.<CurrentLevel>k__BackingField.Points;
            }
            else
            {
                    val_12 = 35615780;
            }
            
            this.<CurrentLevel>k__BackingField.totalStars = 35615780;
            this.uiController.uiParent.SetActive(value:  false);
            this.<CurrentState>k__BackingField = 1;
            this.TrackLevelComplete();
            val_13 = 1152921504892043264;
            Player val_1 = App.Player;
            val_14 = 0;
            var val_2 = val_14 + 1;
            GameBehavior val_3 = App.getBehavior;
            if(0 < 10)
            {
                goto label_14;
            }
            
            GameBehavior val_4 = App.getBehavior;
            if((-4294967290) != 0)
            {
                goto label_19;
            }
            
            label_14:
            var val_13 = 23148722;
            val_13 = 12476816 + val_13;
            if(val_13 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_15 = null;
            val_15 = null;
            val_16 = null;
            val_16 = null;
            GameBehavior val_5 = App.getBehavior;
            val_13 = 0;
            string val_6 = val_13.ToString();
            string val_7 = Events.LEVEL_REACHED + 2144339952 + 768839508;
            val_14 = Events.LEVEL_REACHED;
            App.trackerManager.track(eventName:  val_14);
            label_19:
            if(SLC.MatchyPics.MPICollectionsManager.ShowCompletedCollection() != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_10 = ShowUGUIMonolith<System.Object>(showNext:  false);
            }
            
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_12 = ShowUGUIMonolith<System.Object>(showNext:  false);
            this.frameSkipper.updateLogic = 0;
        }
        public void OnClickShuffle()
        {
            int val_5;
            float val_12;
            var val_13;
            SLC.MatchyPics.MPILevel val_14;
            int val_15;
            var val_16;
            var val_17;
            if((this.<CurrentState>k__BackingField) != 0)
            {
                    return;
            }
            
            if(this.boardController.IsLocked == true)
            {
                    return;
            }
            
            decimal val_2 = CurrencyController.GetBalance();
            val_12 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_13 = 0;
            decimal val_4 = System.Decimal.op_Implicit(value:  768996524);
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_5})) == false)
            {
                goto label_11;
            }
            
            val_14 = this.<CurrentLevel>k__BackingField;
            if(val_14 == 0)
            {
                goto label_12;
            }
            
            val_15 = this.<CurrentLevel>k__BackingField.shufflesUsed;
            goto label_13;
            label_11:
            var val_12 = 23146801;
            val_12 = 12479260 + val_12;
            if(val_12 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_16 = null;
            val_16 = null;
            PurchaseProxy.currentPurchasePoint = 84;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_8 = ShowUGUIMonolith<System.Object>(showNext:  false);
            Init(outOfCredits:  true, onCloseAction:  0);
            return;
            label_12:
            val_14 = 64;
            val_15 = 7.286752E-44f;
            label_13:
            mem[64] = 53;
            Player val_9 = App.Player;
            val_12 = val_12;
            val_17 = 2621448;
            if(val_17 != 0)
            {
                    val_13 = static_value_00280054;
            }
            else
            {
                    val_17 = 76;
                val_13 = 4;
            }
            
            mem[76] = 5;
            bool val_10 = CurrencyController.DebitBalance(value:  new System.Decimal() {flags = val_5, hi = ???, lo = R7, mid = R8}, source:  "Shuffle Powerup", externalParams:  0, animated:  false);
            this.boardController.ShufflePowerUp();
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.AddExtraTime(seconds:  public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance().__il2cppRuntimeField_C + 12 + 40);
        }
        public void OnClickHint()
        {
            int val_5;
            float val_12;
            var val_13;
            SLC.MatchyPics.MPILevel val_14;
            int val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            int val_20;
            var val_21;
            if((this.<CurrentState>k__BackingField) != 0)
            {
                    return;
            }
            
            if(this.boardController.IsLocked == true)
            {
                    return;
            }
            
            decimal val_2 = CurrencyController.GetBalance();
            val_12 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_13 = 0;
            decimal val_4 = System.Decimal.op_Implicit(value:  769141292);
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_5})) == false)
            {
                goto label_11;
            }
            
            val_14 = this.<CurrentLevel>k__BackingField;
            if(val_14 == 0)
            {
                goto label_12;
            }
            
            val_15 = this.<CurrentLevel>k__BackingField.hintsUsed;
            goto label_13;
            label_11:
            var val_12 = 23145585;
            val_12 = 12480476 + val_12;
            if(val_12 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_16 = null;
            val_16 = null;
            PurchaseProxy.currentPurchasePoint = 6;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_8 = ShowUGUIMonolith<System.Object>(showNext:  false);
            Init(outOfCredits:  true, onCloseAction:  0);
            return;
            label_12:
            val_14 = 60;
            val_15 = 7.286752E-44f;
            label_13:
            mem[60] = 53;
            Player val_9 = App.Player;
            val_12 = val_12;
            val_17 = 2621448;
            if(val_17 != 0)
            {
                    val_18 = 23;
            }
            else
            {
                    val_17 = 56;
                val_18 = 52;
            }
            
            mem[56] = 53;
            val_13 = 1152921504891457536;
            val_19 = null;
            val_20 = ???;
            bool val_10 = CurrencyController.DebitBalance(value:  new System.Decimal() {flags = val_5, lo = R7, mid = R8}, source:  Events.HINT_USED, externalParams:  0, animated:  false);
            this.boardController.ShowHint(isFtux:  false);
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.AddExtraTime(seconds:  public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance().__il2cppRuntimeField_C + 12 + 40);
            val_21 = null;
            val_21 = null;
            App.trackerManager.track(eventName:  Events.HINT_USED);
        }
        public void OnChangeImageSet()
        {
            int val_4;
            float val_12;
            SLC.MatchyPics.MPILevel val_13;
            SLC.MatchyPics.MPILevel val_14;
            int val_15;
            var val_16;
            var val_17;
            var val_18;
            if((this.<CurrentState>k__BackingField) != 0)
            {
                    return;
            }
            
            decimal val_1 = CurrencyController.GetBalance();
            val_12 = 1152921512345516208;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_13 = 0;
            decimal val_3 = System.Decimal.op_Implicit(value:  769290268);
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_4})) == false)
            {
                goto label_9;
            }
            
            val_14 = this.<CurrentLevel>k__BackingField;
            if(val_14 == 0)
            {
                goto label_10;
            }
            
            val_15 = this.<CurrentLevel>k__BackingField.imageChangesUsed;
            goto label_11;
            label_9:
            var val_12 = 23144405;
            val_12 = 12481656 + val_12;
            if(val_12 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_16 = null;
            val_16 = null;
            PurchaseProxy.currentPurchasePoint = 6;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_7 = ShowUGUIMonolith<System.Object>(showNext:  false);
            Init(outOfCredits:  true, onCloseAction:  0);
            return;
            label_10:
            val_14 = 68;
            val_15 = 3.587324E-43f;
            label_11:
            mem[68] = 257;
            Player val_8 = App.Player;
            val_12 = val_12;
            val_17 = 2621448;
            if(val_17 != 0)
            {
                    val_18 = static_value_00280050;
            }
            else
            {
                    val_17 = 72;
                val_18 = 256;
            }
            
            mem[72] = 257;
            bool val_9 = CurrencyController.DebitBalance(value:  new System.Decimal() {flags = val_4, hi = ???, lo = R7, mid = R8}, source:  "Change Image Powerup", externalParams:  0, animated:  false);
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_13 = this.<CurrentLevel>k__BackingField;
            ChangeImageSet(level:  val_13);
            this.boardController.UpdateImageSet();
            this.uiController.SetupCollections();
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.AddExtraTime(seconds:  public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance().__il2cppRuntimeField_C + 12 + 40);
        }
        public void NoBombsSave()
        {
            int val_4;
            var val_11;
            var val_12;
            var val_13;
            System.Action val_15;
            decimal val_1 = CurrencyController.GetBalance();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            decimal val_3 = System.Decimal.op_Implicit(value:  769428048);
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {mid = val_4})) != false)
            {
                    bool val_6 = CurrencyController.DebitBalance(value:  new System.Decimal() {flags = R5, hi = R6, lo = R7, mid = val_4}, source:  "Bomb Saver", externalParams:  0, animated:  false);
                this.<CurrentState>k__BackingField = 0;
                this.boardController.NoBombs();
                this.StartTimer();
                this.TrackLevelStart(startEvent:  769415008);
                return;
            }
            
            var val_10 = 23142617;
            val_10 = 12483444 + val_10;
            if(val_10 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_12 = null;
            val_12 = null;
            PurchaseProxy.currentPurchasePoint = 88;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_8 = ShowUGUIMonolith<System.Object>(showNext:  false);
            val_11 = 1152921505045557248;
            val_13 = null;
            val_13 = null;
            val_15 = MPIGameplayController.<>c.<>9__44_0;
            if(val_15 == 0)
            {
                    val_15 = null;
                val_15 = new System.Action(object:  MPIGameplayController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(769415088));
                MPIGameplayController.<>c.<>9__44_0 = val_15;
            }
            
            Init(outOfCredits:  true, onCloseAction:  7454720);
        }
        public void ExtraTimeSave()
        {
            int val_4;
            int val_11;
            SLC.MatchyPics.MPILevel val_12;
            var val_13;
            var val_14;
            System.Action val_16;
            decimal val_1 = CurrencyController.GetBalance();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            decimal val_3 = System.Decimal.op_Implicit(value:  769574016);
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {mid = val_4})) != false)
            {
                    bool val_6 = CurrencyController.DebitBalance(value:  new System.Decimal() {flags = R5, hi = R6, lo = R7, mid = val_4}, source:  "Extra Time", externalParams:  0, animated:  false);
                this.<CurrentState>k__BackingField = 0;
                int val_11 = this.<CurrentLevel>k__BackingField.LevelDefinition.Time;
                val_11 = val_11 + (val_11 >> 31);
                val_11 = val_11 >> 1;
                this.remainingTime = val_11;
                int val_12 = this.<CurrentLevel>k__BackingField.LevelDefinition.Time;
                val_12 = this.<CurrentLevel>k__BackingField;
                val_11 = this.remainingTime;
                val_12 = val_12 + (val_12 >> 31);
                val_12 = this.totalLevelTime + (val_12 >> 1);
                this.totalLevelTime = val_12;
                int val_13 = this.<CurrentLevel>k__BackingField.LevelDefinition.Time;
                val_13 = val_13 + (val_13 >> 31);
                this.uiController.AddExtraTime(remainingTime:  val_11, extraTime:  val_13 >> 1);
                this.StartTimer();
                this.TrackLevelStart(startEvent:  769560976);
                return;
            }
            
            var val_14 = 23141577;
            val_14 = 12484484 + val_14;
            if(val_14 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_13 = null;
            val_13 = null;
            PurchaseProxy.currentPurchasePoint = 88;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_9 = ShowUGUIMonolith<System.Object>(showNext:  false);
            val_12 = 1152921505045557248;
            val_14 = null;
            val_14 = null;
            val_16 = MPIGameplayController.<>c.<>9__45_0;
            if(val_16 == 0)
            {
                    val_16 = null;
                val_16 = new System.Action(object:  MPIGameplayController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(769561056));
                MPIGameplayController.<>c.<>9__45_0 = val_16;
            }
            
            Init(outOfCredits:  true, onCloseAction:  7454720);
        }
        public void LevelFailed()
        {
            var val_7;
            var val_8;
            var val_9;
            this.TrackLevelComplete();
            val_7 = 1152921504892043264;
            Player val_1 = App.Player;
            var val_2 = 0 + 1;
            GameBehavior val_3 = App.getBehavior;
            if(0 >= 10)
            {
                    GameBehavior val_4 = App.getBehavior;
                if((-4294967290) != 0)
            {
                    return;
            }
            
            }
            
            var val_8 = 23139406;
            val_8 = 12486132 + val_8;
            if(val_8 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_8 = null;
            val_8 = null;
            val_9 = null;
            val_9 = null;
            GameBehavior val_5 = App.getBehavior;
            val_7 = 0;
            string val_6 = val_7.ToString();
            string val_7 = Events.LEVEL_REACHED + 2144339952 + 769718820;
            App.trackerManager.track(eventName:  Events.LEVEL_REACHED);
        }
        public void PauseGame()
        {
            this.PauseTimer();
        }
        public void AddExtraTime(int seconds)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            if((this.<CurrentState>k__BackingField) != 0)
            {
                    return;
            }
            
            mem2[0] = 0;
            val_3 = mem[R4 + 16];
            val_3 = R4 + 16;
            if(val_3 != 0)
            {
                    val_4 = mem[R4 + 16 + 36];
                val_4 = R4 + 16 + 36;
            }
            else
            {
                    val_3 = 36;
                val_4 = 83886592;
            }
            
            mem[36] = val_4 + seconds;
            val_5 = mem[R4 + 16];
            val_5 = R4 + 16;
            if(val_5 != 0)
            {
                    val_6 = mem[R4 + 16 + 40];
                val_6 = R4 + 16 + 40;
            }
            else
            {
                    val_5 = 40;
                val_6 = 2097204;
            }
            
            mem[40] = val_6 + seconds;
            R4 + 12.AddExtraTime(remainingTime:  R4 + 16 + 36, extraTime:  seconds);
            R4.StartTimer();
        }
        private void StartTimer()
        {
            FrameSkipper val_6;
            SLC.MatchyPics.MPILevel val_7;
            int val_8;
            object val_1 = new System.Object();
            typeof(MPIGameplayController.<>c__DisplayClass49_0).__il2cppRuntimeField_8 = this;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C) != 0)
            {
                    return;
            }
            
            System.DateTime val_4 = DateTimeCheat.UtcNow;
            typeof(MPIGameplayController.<>c__DisplayClass49_0).__il2cppRuntimeField_10 = ???;
            if((this.<CurrentLevel>k__BackingField.timeRemaining) <= 0)
            {
                goto label_11;
            }
            
            if((this.<CurrentLevel>k__BackingField) == 0)
            {
                goto label_12;
            }
            
            this.remainingTime = this.<CurrentLevel>k__BackingField.timeRemaining;
            val_7 = this.<CurrentLevel>k__BackingField;
            goto label_13;
            label_11:
            val_8 = this.totalLevelTime;
            goto label_14;
            label_12:
            val_7 = this.<CurrentLevel>k__BackingField;
            this.remainingTime = this.<CurrentLevel>k__BackingField.timeRemaining;
            if(val_7 == 0)
            {
                goto label_15;
            }
            
            label_13:
            val_8 = this.<CurrentLevel>k__BackingField.totalTime;
            this.totalLevelTime = val_8;
            label_14:
            val_8 = val_8 - this.remainingTime;
            this.<TimeElapsed>k__BackingField = val_8;
            typeof(MPIGameplayController.<>c__DisplayClass49_0).__il2cppRuntimeField_18 = this.remainingTime;
            val_6 = this.frameSkipper;
            System.Action val_5 = new System.Action(object:  438763520, method:  new IntPtr(770071520));
            this.frameSkipper.updateLogic = null;
            return;
            label_15:
        }
        private void UpdateTimer(System.DateTime startTime, int startTimeRemaining)
        {
            var val_1;
            ulong val_3;
            var val_6;
            System.DateTime val_2 = DateTimeCheat.UtcNow;
            System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513967006728}, d2:  new System.DateTime() {dateData = val_3});
            double val_8 = val_6.TotalSeconds;
            if(System.DateTime.__il2cppRuntimeField_cctor_finished == 0)
            {
                    770225176 = 770225176;
            }
            
            int val_9 = val_1 - S0;
            this.remainingTime = val_9;
            this.<CurrentLevel>k__BackingField.timeRemaining = val_9;
            int val_12 = this.totalLevelTime;
            val_12 = val_12 - this.remainingTime;
            this.<TimeElapsed>k__BackingField = val_12;
            this.uiController.UpdateTimer(remainingTime:  this.remainingTime);
            if(this.remainingTime > 0)
            {
                    return;
            }
            
            this.frameSkipper.updateLogic = 0;
            this.<CurrentState>k__BackingField = 2;
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_11 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        private void PauseTimer()
        {
            this.frameSkipper.updateLogic = 0;
            if((this.<CurrentState>k__BackingField) != 0)
            {
                    return;
            }
            
            if((R4 + 16) == 0)
            {
                
            }
        
        }
        private void TrackLevelComplete()
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_10;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            string val_2 = Player.GetLevelForTracking();
            Add(key:  -2100706208, value:  0);
            Add(key:  770469984, value:  13152256);
            Add(key:  770474192, value:  13152256);
            Add(key:  770478416, value:  13152256);
            Add(key:  -2100067616, value:  13152256);
            if((this.<CurrentLevel>k__BackingField.ChestReward) > 0)
            {
                    0 = 1;
            }
            
            Add(key:  770486720, value:  8945664);
            if((this.<CurrentLevel>k__BackingField.collectedChestRewards) > 0)
            {
                    0 = 1;
            }
            
            Add(key:  770490912, value:  8945664);
            if((this.<CurrentLevel>k__BackingField.collectionItems) > 0)
            {
                    0 = 1;
            }
            
            Add(key:  770495120, value:  8945664);
            if((this.<CurrentLevel>k__BackingField.collectedCollectionItems) > 0)
            {
                    0 = 1;
            }
            
            val_5 = null;
            Add(key:  770499344, value:  8945664);
            State val_5 = this.<CurrentState>k__BackingField;
            if((val_5 - 1) < 3)
            {
                    0 = val_5 + 4;
            }
            
            val_5 = 0 & 7;
            if(val_5 > 7)
            {
                    return;
            }
            
            var val_4 = 12478408 + (12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2);
            if(val_5 == 7)
            {
                    12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2 = (12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2) & 39376896;
                12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2 = (12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2) & (((int)IP) >> 2);
                12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2 = (12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2) & (((int)IP) >> 2);
                12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2 = (12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2) & (((int)IP) >> 2);
                12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2 = (12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2) & (((int)IP) >> 2);
                12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2 = (12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2) & ((12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2) >> 32);
                12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2 = (12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2) & (1152921510535002416 >> (12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2));
                12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2 = (12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2) & (((null) << (32-(((((((12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2 & 39376896) & ((int)IP) >> 2) & ((int)IP) >> 2) & ((int)IP) >> 2) & ((int)IP) >> 2) & ((((((12478408 + (((this.<CurrentState>k__)) | ((null) << (((((((12478408 + (((this.<CurrentState>k__BackingField + 4) & 7)) << 2 & 39376896) & ((int)IP) >> 2) & ((int)IP) >> 2) & ((int)IP) >> 2) & ((int)IP) >> 2) & ((((((12478408 + (((this.<CurrentState>k__));
            }
            
            val_6 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            val_7 = null;
            val_8 = "Level Success";
            Add(key:  -1643554384, value:  769415008);
            val_5 = 12478624 + 23146914;
            if(val_5 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_10 = null;
            val_10 = null;
            App.trackerManager.track(eventName:  -1942299264, data:  78753792);
        }
        private void TrackLevelStart(string startEvent = "")
        {
            var val_5;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            string val_2 = Player.GetLevelForTracking();
            Add(key:  -2100706208, value:  0);
            Player val_3 = App.Player;
            var val_4 = 0 + 60;
            Add(key:  -2100706000, value:  10170368);
            if((this.<CurrentLevel>k__BackingField.ChestReward) > 0)
            {
                    0 = 1;
            }
            
            Add(key:  770486720, value:  8945664);
            if((this.<CurrentLevel>k__BackingField.collectionItems) > 0)
            {
                    0 = 1;
            }
            
            Add(key:  770495120, value:  8945664);
            if((System.String.IsNullOrEmpty(value:  startEvent)) != true)
            {
                    Add(key:  770664816, value:  startEvent);
            }
            
            var val_6 = 23151798;
            val_6 = 12473740 + val_6;
            if(val_6 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_5 = null;
            val_5 = null;
            App.trackerManager.track(eventName:  -2100698896, data:  78753792);
        }
        public MPIGameplayController()
        {
            this.remainingTime = 0;
            this.totalLevelTime = 0;
        }
    
    }

}
