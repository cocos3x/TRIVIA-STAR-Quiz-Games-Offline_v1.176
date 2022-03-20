using UnityEngine;

namespace RestaurantRivals
{
    public class RESSlotUIManager : MonoSingleton<RestaurantRivals.RESSlotUIManager>
    {
        // Fields
        public RestaurantRivals.RESReelsController reelsController;
        public RestaurantRivals.RESSpinButtonController spinButtonController;
        public RestaurantRivals.RESSpinInfoController spinInfoController;
        public RestaurantRivals.RESFrontUIController topUIController;
        public RestaurantRivals.RESHeadChefController headChefController;
        public RestaurantRivals.RESEventUIController eventUIController;
        protected UnityEngine.GameObject swipePromptHand;
        protected UnityEngine.TrailRenderer swipePromptTrail;
        protected UnityEngine.CanvasGroup swipePromptMessage;
        private UnityEngine.GameObject freeSpinButtonGroup;
        private UnityEngine.GameObject rechargeableSpinSliderGroup;
        private DG.Tweening.DOTweenAnimation shakeAnim;
        private bool <OnSpinConclusion>k__BackingField;
        private bool <OnFTUX>k__BackingField;
        private DG.Tweening.Tweener SwipePromptTweener;
        private int currentInterstitialSpinCounter;
        private bool isOnSwipePrompt;
        private float noActionTimer;
        private bool spinning;
        private int <InterruptCounterPostSpin1>k__BackingField;
        
        // Properties
        public UnityEngine.GameObject FreeSpinButtonGroup { get; }
        public UnityEngine.GameObject RechargeableSpinSliderGroup { get; }
        public bool OnSpinConclusion { get; set; }
        public bool OnFTUX { get; set; }
        public bool Spinning { get; }
        public int InterruptCounterPostSpin1 { get; set; }
        
        // Methods
        public UnityEngine.GameObject get_FreeSpinButtonGroup()
        {
        
        }
        public UnityEngine.GameObject get_RechargeableSpinSliderGroup()
        {
        
        }
        public bool get_OnSpinConclusion()
        {
            return (bool)this.<OnSpinConclusion>k__BackingField;
        }
        private void set_OnSpinConclusion(bool value)
        {
            this.<OnSpinConclusion>k__BackingField = value;
        }
        public bool get_OnFTUX()
        {
            return (bool)this.<OnFTUX>k__BackingField;
        }
        private void set_OnFTUX(bool value)
        {
            this.<OnFTUX>k__BackingField = value;
        }
        public bool get_Spinning()
        {
            return (bool)this.spinning;
        }
        public int get_InterruptCounterPostSpin1()
        {
            return (int)this.<InterruptCounterPostSpin1>k__BackingField;
        }
        private void set_InterruptCounterPostSpin1(int value)
        {
            this.<InterruptCounterPostSpin1>k__BackingField = value;
        }
        public void IncrementInterruptCounterPostSpin1()
        {
            int val_1 = this.<InterruptCounterPostSpin1>k__BackingField;
            val_1 = val_1 + 1;
            this.<InterruptCounterPostSpin1>k__BackingField = val_1;
        }
        public void DecrementInterruptCounterPostSpin1()
        {
            int val_1 = this.<InterruptCounterPostSpin1>k__BackingField;
            val_1 = val_1 - 1;
            this.<InterruptCounterPostSpin1>k__BackingField = val_1;
        }
        public override void InitMonoSingleton()
        {
            this.spinning = false;
            this.<OnSpinConclusion>k__BackingField = false;
            this.<OnFTUX>k__BackingField = false;
        }
        private void Start()
        {
            var val_13;
            var val_14;
            var val_15;
            System.Action val_17;
            if(RestaurantRivals.RESManager.IsGameStartFtuxFinished == true)
            {
                goto label_3;
            }
            
            val_13 = 1152921504892043264;
            GameBehavior val_2 = App.getBehavior;
            if(0 != 0)
            {
                    val_14 = null;
            }
            
            val_14 = null;
            if(0 != 5)
            {
                goto label_10;
            }
            
            label_3:
            this.FinishSwipePrompt();
            NotificationCenter val_3 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  656001536, name:  655976416);
            NotificationCenter val_4 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  656001536, name:  559771472);
            NotificationCenter val_5 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  656001536, name:  -1275408272);
            goto label_16;
            label_10:
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            RestPlayerDataOnIncompletedFTUX();
            GameBehavior val_7 = App.getBehavior;
            ThemesHandler val_8 = App.ThemesHandler;
            val_13 = 0;
            string val_9 = val_13.CurrentThemeName;
            string val_10 = null + 2144339952 + null;
            UnityEngine.AsyncOperation val_11 = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  null);
            label_16:
            this.GetRaidOpponent();
            val_15 = null;
            val_15 = null;
            val_17 = RESSlotUIManager.<>c.<>9__38_0;
            if(val_17 == 0)
            {
                    val_17 = null;
                val_17 = new System.Action(object:  RESSlotUIManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(655976512));
                RESSlotUIManager.<>c.<>9__38_0 = val_17;
            }
            
            MonoExtensions.DelayedCallEndOfFrame(monoBehaviour:  656001536, callback:  7454720);
        }
        private void Update()
        {
            Player val_1 = App.Player;
            if(0 > 1)
            {
                    return;
            }
            
            float val_2 = UnityEngine.Time.deltaTime;
            uint val_4 = 0;
            val_4 = this.noActionTimer + val_4;
            this.noActionTimer = val_4;
            if(this.CanSwipeUp() != false)
            {
                    this.isOnSwipePrompt = true;
                this.SwipePrompt();
                return;
            }
            
            this.FinishSwipePrompt();
        }
        private bool CanSwipeUp()
        {
            var val_14;
            var val_15;
            var val_17;
            val_14 = null;
            val_14 = null;
            val_15 = 0;
            if(RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType == 18)
            {
                    return (bool)val_15;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(CurrentForestContainsDamagedTrees != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                int val_5 = GetCurrentNumOfDamagedRestaurantItems();
            }
            else
            {
                    twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if(GetNumOfCanBuyRestaurantItems() < 1)
            {
                goto label_28;
            }
            
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            }
            
            label_28:
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_15 = 0;
            int val_12 = Spins;
            if(val_12 > 0)
            {
                    return (bool)val_15;
            }
            
            if(val_12 <= 0)
            {
                    return (bool)val_15;
            }
            
            if((RestaurantRivals.RESNewsPopup.UnseenNewsCount + GetNumOfCanBuyRestaurantItems()) < 1)
            {
                    return (bool)val_15;
            }
            
            if(this.isOnSwipePrompt == true)
            {
                    return (bool)val_15;
            }
            
            val_17 = null;
            val_17 = null;
            if(RestaurantRivals.RESReelsController.spinStatus == 1)
            {
                    RestaurantRivals.RESReelsController.spinStatus = this.<OnFTUX>k__BackingField;
            }
            
            if(RestaurantRivals.RESReelsController.spinStatus == 1)
            {
                    val_15 = RestaurantRivals.RESReelsController.spinStatus >> 5;
            }
            
            return (bool)val_15;
        }
        public void ResetRaidOpponent()
        {
            this.GetRaidOpponent();
        }
        private void GetRaidOpponent()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            RestaurantRivals.UserRestaurantProfile val_2 = GetRaidRandomOpponent();
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            InitializeRaid(opponentId:  public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_8);
            this.headChefController.ChangeHeadChef();
        }
        public void Spin()
        {
            var val_18;
            var val_19;
            var val_20;
            val_18 = null;
            val_18 = null;
            if(RestaurantRivals.RESReelsController.spinStatus != 1)
            {
                    return;
            }
            
            goto label_4;
            label_15:
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(SpinBet == 1)
            {
                goto label_8;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            DecreaseSpinBet();
            label_4:
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(AvailableSpin == false)
            {
                goto label_15;
            }
            
            label_8:
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(AvailableSpin != false)
            {
                    this.spinInfoController.HidePayoutInfo();
                this.spinning = true;
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                SpinPressed();
                int val_18 = this.currentInterstitialSpinCounter;
                val_18 = val_18 + 1;
                this.currentInterstitialSpinCounter = val_18;
                val_19 = null;
                val_19 = null;
                if(RestaurantRivals.RESFTUXManager.slotPlayDemoPopup != 0)
            {
                    val_20 = null;
                val_20 = null;
                if(RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType == 5)
            {
                    RestaurantRivals.RESFTUXManager.__il2cppRuntimeField_static_fields.OnSequencyFTUXUsed();
            }
            
            }
            
                NotificationCenter val_10 = NotificationCenter.DefaultCenter;
                0.PostNotification(aSender:  656575968, aName:  -1275408672);
                twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  656549824, clipIndex:  0);
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_15 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        public void ReelStoped(int reel)
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            System.Collections.Hashtable val_2 = new System.Collections.Hashtable();
            0.PostNotification(aSender:  656692144, aName:  -1275408480, aData:  75878400);
            if(reel != 2)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_3 = this.AllReelsStopped();
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  656692144);
        }
        public void FinishSpinConclusion()
        {
            this.<OnSpinConclusion>k__BackingField = false;
        }
        public void FinishFTUX()
        {
            this.<OnFTUX>k__BackingField = false;
        }
        public void StartFTUX()
        {
            this.<OnFTUX>k__BackingField = true;
        }
        public void ShakeScreen()
        {
            if(this.shakeAnim == 0)
            {
                
            }
        
        }
        private System.Collections.IEnumerator AllReelsStopped()
        {
            object val_1 = new System.Object();
            typeof(RESSlotUIManager.<AllReelsStopped>d__49).__il2cppRuntimeField_8 = 0;
            typeof(RESSlotUIManager.<AllReelsStopped>d__49).__il2cppRuntimeField_10 = this;
        }
        private void SwipePrompt()
        {
            if(this.isOnSwipePrompt == false)
            {
                    return;
            }
            
            this.swipePromptHand.SetActive(value:  true);
            this.swipePromptMessage.alpha = null;
            UnityEngine.Transform val_1 = this.swipePromptHand.transform;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.swipePromptHand.localPosition = new UnityEngine.Vector3();
            UnityEngine.Transform val_3 = this.swipePromptHand.transform;
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.swipePromptHand, endValue:  val_2.x, duration:  val_2.y, snapping:  false);
            DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  657389744, method:  new IntPtr(657364720));
            object val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.swipePromptHand, action:  190734336);
            this.SwipePromptTweener = this.swipePromptHand;
        }
        private void FinishSwipePrompt()
        {
            if(this.SwipePromptTweener != 0)
            {
                    DG.Tweening.TweenExtensions.Complete(t:  this.SwipePromptTweener);
            }
            
            this.noActionTimer = 0f;
            this.swipePromptMessage.alpha = null;
            this.isOnSwipePrompt = 0f;
            this.swipePromptHand.SetActive(value:  false);
        }
        private void OnGameAction()
        {
            Player val_1 = App.Player;
            if(0 > 1)
            {
                    return;
            }
            
            mem2[0] = 0;
            R4.FinishSwipePrompt();
        }
        private void OnSpinAmountUpdate()
        {
            Player val_1 = App.Player;
            if(0 > 1)
            {
                    return;
            }
            
            mem2[0] = 0;
            R4.FinishSwipePrompt();
        }
        private void OnSwipeInScreenDone()
        {
            this.CheckBetMultiplierFTUX();
            this.CheckSlotSpinFTUX();
            this.CheckExtraShieldFTUX();
            this.CheckIncreaseRechargeableSpinAmountFTUX();
        }
        private void CheckBetMultiplierFTUX()
        {
            var val_7;
            System.Action val_9;
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESGameEcon val_2 = RestaurantRivals.RESGameEcon.Instance;
            if(0 < 0)
            {
                    return;
            }
            
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            if(1 != 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_7 = null;
            val_7 = null;
            val_9 = RESSlotUIManager.<>c.<>9__55_0;
            if(val_9 == 0)
            {
                    val_9 = null;
                val_9 = new System.Action(object:  RESSlotUIManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(657966704));
                RESSlotUIManager.<>c.<>9__55_0 = val_9;
            }
            
            ShowFTUX(FTUXType:  12, onComplete:  7454720);
        }
        private void CheckSlotSpinFTUX()
        {
            if((RestaurantRivals.RESFTUXManager.IsCompleteFTUX(FTUXType:  5)) != false)
            {
                    return;
            }
            
            if(RestaurantRivals.RESManager.IsGameStartFtuxFinished == true)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowFTUX(FTUXType:  5, onComplete:  0);
        }
        private void CheckIncreaseRechargeableSpinAmountFTUX()
        {
            Player val_1 = App.Player;
            if(0 != 75)
            {
                    return;
            }
            
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            if(19 != 0)
            {
                    return;
            }
            
            mem2[0] = 1;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_4 = new System.Action(object:  R4, method:  new IntPtr(658191728));
            ShowFTUX(FTUXType:  14, onComplete:  7454720);
        }
        private void CheckExtraShieldFTUX()
        {
            var val_11;
            var val_12;
            System.Action val_14;
            var val_15;
            System.Action val_17;
            Player val_1 = App.Player;
            val_11 = 1152921505031819264;
            RestaurantRivals.RESGameEcon val_2 = RestaurantRivals.RESGameEcon.Instance;
            if(0 == 18)
            {
                    RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
                if(1919184449 == 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_12 = null;
                val_12 = null;
                val_14 = RESSlotUIManager.<>c.<>9__58_0;
                if(val_14 == 0)
            {
                    val_14 = null;
                val_14 = new System.Action(object:  RESSlotUIManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(658304752));
                RESSlotUIManager.<>c.<>9__58_0 = val_14;
            }
            
                ShowFTUX(FTUXType:  13, onComplete:  7454720);
            }
            
            }
            
            Player val_6 = App.Player;
            RestaurantRivals.RESGameEcon val_7 = RestaurantRivals.RESGameEcon.Instance;
            if(0 != 1289)
            {
                    return;
            }
            
            RestaurantRivals.RESPlayer val_8 = RestaurantRivals.RESPlayer.Instance;
            if(6580591 != 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_15 = null;
            val_15 = null;
            val_17 = RESSlotUIManager.<>c.<>9__58_1;
            if(val_17 == 0)
            {
                    val_17 = null;
                val_17 = new System.Action(object:  RESSlotUIManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(658305776));
                RESSlotUIManager.<>c.<>9__58_1 = val_17;
            }
            
            ShowFTUX(FTUXType:  13, onComplete:  7454720);
        }
        public RESSlotUIManager()
        {
        
        }
        private bool <AllReelsStopped>b__49_0()
        {
            bool val_1 = this.<OnFTUX>k__BackingField;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        private bool <AllReelsStopped>b__49_1()
        {
            bool val_1 = this.<OnFTUX>k__BackingField;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        private bool <AllReelsStopped>b__49_2()
        {
            bool val_1 = this.<OnFTUX>k__BackingField;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        private bool <AllReelsStopped>b__49_3()
        {
            bool val_1 = this.<OnSpinConclusion>k__BackingField;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        private bool <AllReelsStopped>b__49_4()
        {
            if((this.<InterruptCounterPostSpin1>k__BackingField) < 1)
            {
                    0 = 1;
            }
            
            return true;
        }
        private void <SwipePrompt>b__50_0()
        {
            this.swipePromptTrail.Clear();
            this.swipePromptHand.SetActive(value:  false);
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.swipePromptMessage, endValue:  null, duration:  null);
            DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  659129136, method:  new IntPtr(659104112));
            object val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.swipePromptMessage, action:  190734336);
            this.SwipePromptTweener = this.swipePromptMessage;
        }
        private void <SwipePrompt>b__50_1()
        {
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.swipePromptMessage, endValue:  null, duration:  null);
            DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  659258544, method:  new IntPtr(659233520));
            object val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.swipePromptMessage, action:  190734336);
            this.SwipePromptTweener = this.swipePromptMessage;
        }
        private void <SwipePrompt>b__50_2()
        {
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.swipePromptMessage, endValue:  null, duration:  null);
            DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  659379760, method:  new IntPtr(659354736));
            object val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.swipePromptMessage, action:  190734336);
            this.SwipePromptTweener = this.swipePromptMessage;
        }
        private void <SwipePrompt>b__50_3()
        {
            this.SwipePromptTweener = 0;
            if(static_value_021F9A25 <= false)
            {
                    return;
            }
            
            R4.Invoke(methodName:  543839328, time:  2f);
        }
        private void <CheckIncreaseRechargeableSpinAmountFTUX>b__57_0()
        {
            this.<OnFTUX>k__BackingField = false;
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            mem[328] = 1;
            Player val_2 = App.Player;
            0.SaveState();
        }
    
    }

}
