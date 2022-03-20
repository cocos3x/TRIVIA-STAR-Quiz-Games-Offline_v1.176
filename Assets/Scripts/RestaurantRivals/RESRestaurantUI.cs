using UnityEngine;

namespace RestaurantRivals
{
    public class RESRestaurantUI : MonoSingleton<RestaurantRivals.RESRestaurantUI>
    {
        // Fields
        public UnityEngine.GameObject buyBtn;
        public UnityEngine.GameObject buyBtnSmall;
        public UnityEngine.GameObject titleGB;
        private UnityEngine.GameObject bottomUI;
        private UnityEngine.GameObject buyHand;
        private UnityEngine.GameObject titleObject;
        private RestaurantRivals.RESFrontUIController frontUI;
        private UnityEngine.UI.Image playerAvatar;
        private UnityEngine.UI.Text playerName;
        public RestaurantRivals.RESShortTermRestaurantProgress ShortTermProgress;
        private UnityEngine.Transform forestContentParent;
        private MultiGraphicButton buyButtonSmall;
        private MultiGraphicButton fixButtonSmall;
        private MultiGraphicButton buyButton;
        private UnityEngine.UI.Text buildCostText;
        private UnityEngine.GameObject buyNotification;
        private UnityEngine.UI.Text buyNotificationNumberTxt;
        private MultiGraphicButton fixButton;
        private UnityEngine.UI.Text fixCostText;
        private UnityEngine.GameObject fixNotification;
        private UnityEngine.UI.Text fixNotificationNumberTxt;
        private UnityEngine.UI.Button continueButton;
        private MultiGraphicButton freeCoinButton;
        private UnityEngine.UI.Text freeCoinAmountTxt;
        private UnityEngine.CanvasGroup titleGroup;
        private UnityEngine.CanvasGroup growGroup;
        private UnityEngine.CanvasGroup congratulationsGroup;
        private UnityEngine.CanvasGroup continueGroup;
        private UnityEngine.UI.Image darkOverlay;
        private UnityEngine.UI.Image bottomBackground;
        private RestaurantRivals.RESSeedParticles seedParticlesPrefab;
        private UGUINetworkedButtonMultiGraphic prefabButtonFixTree;
        private UnityEngine.ParticleSystem congratParticleLeft;
        private UnityEngine.ParticleSystem congratParticleRight;
        protected UnityEngine.GameObject swipePromptHand;
        protected UnityEngine.TrailRenderer swipePromptTrail;
        protected UnityEngine.CanvasGroup swipePromptMessage;
        private RestaurantRivals.RESRestaurantManager restaurantManager;
        private int currentHighlightedFixTreeId;
        private RestaurantRivals.RESRestaurantContent restaurantContent;
        private DG.Tweening.Tweener SwipePromptTweener;
        private int currentInterstitialSpinCounter;
        private bool isOnSwipePrompt;
        private float noActionTimer;
        
        // Properties
        public RestaurantRivals.RESFrontUIController FrontUI { get; }
        
        // Methods
        public RestaurantRivals.RESFrontUIController get_FrontUI()
        {
        
        }
        private void Start()
        {
            var val_27;
            var val_28;
            var val_29;
            val_27 = null;
            val_27 = null;
            RestaurantRivals.RESReelsController.spinStatus = 0;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.restaurantManager = public static RestaurantRivals.RESRestaurantManager MonoSingleton<RestaurantRivals.RESRestaurantManager>::get_Instance();
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  632467856, method:  new IntPtr(632389360));
            this.buyButton.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  632467856, method:  new IntPtr(632389360));
            this.buyButtonSmall.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  632467856, method:  new IntPtr(632398576));
            this.fixButton.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  632467856, method:  new IntPtr(632398576));
            this.fixButtonSmall.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  632467856, method:  new IntPtr(632411888));
            this.continueButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  632467856, method:  new IntPtr(632417008));
            this.freeCoinButton.AddListener(call:  162246656);
            NotificationCenter val_8 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  632467856, name:  404738048);
            NotificationCenter val_9 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  632467856, name:  -843944304);
            this.InitializeRestaurantLayout();
            UnityEngine.Transform val_10 = this.titleGroup.transform;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
            this.titleGroup.localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_12 = this.ShortTermProgress.transform;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
            this.ShortTermProgress.localScale = new UnityEngine.Vector3();
            this.ShortTermProgress.Invoke(methodName:  632426224, time:  val_13.x);
            this.ShortTermProgress.Invoke(methodName:  632426320, time:  val_13.x);
            this.buyHand.SetActive(value:  false);
            if(RestaurantRivals.RESManager.IsGameStartFtuxFinished == false)
            {
                goto label_32;
            }
            
            if((RestaurantRivals.RESFTUXManager.IsCompleteFTUX(FTUXType:  17)) == false)
            {
                goto label_35;
            }
            
            UnityEngine.Transform val_16 = this.bottomUI.transform;
            val_28 = 0;
            if(this.bottomUI != 0)
            {
                    if(null != null)
            {
                    this.bottomUI = 0;
            }
            
                val_28 = this.bottomUI;
            }
            
            DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  0, endValue:  val_13.x, duration:  val_13.y, snapping:  false);
            goto label_38;
            label_32:
            val_29 = this;
            System.Collections.IEnumerator val_18 = this.ShowWelcomeFTUXPopup();
            goto label_39;
            label_35:
            val_29 = this;
            System.Collections.IEnumerator val_19 = this.ShowKeepBuildingFTUXPopup();
            label_39:
            UnityEngine.Coroutine val_20 = this.StartCoroutine(routine:  632467856);
            label_38:
            this.InitializeUI();
            this.UpdateFreeCoinUI();
            this.UpdateForestInfo(animated:  false, skipButtonStates:  false);
            this.FinishSwipePrompt();
            if(this.restaurantManager.CurrentRestaurantStage >= this.restaurantManager.CurrentMaxGrowth)
            {
                    bool val_23 = this.restaurantManager.IsAtLastLevel;
                if(val_23 == false)
            {
                    val_23 = this;
                this.OnContinueButtonClicked();
            }
            
            }
            
            System.Action val_24 = new System.Action(object:  632467856, method:  new IntPtr(632442832));
            DeviceKeypressManager.AddBackAction(backAction:  7454720);
            NotificationCenter val_25 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  632467856, name:  2128120864);
            NotificationCenter val_26 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  632467856, name:  560223792);
        }
        private void OnDestroy()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.RemoveObserver(observer:  632633104, name:  404738048);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  632633104, name:  -843944304);
            NotificationCenter val_3 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  632633104, name:  2128120864);
        }
        private void OnDisable()
        {
            System.Action val_1 = new System.Action(object:  632745104, method:  new IntPtr(632442832));
            DeviceKeypressManager.RemoveBackAction(backAction:  7454720);
        }
        private void Update()
        {
            Player val_1 = App.Player;
            if(0 > 1)
            {
                    return;
            }
            
            if((RestaurantRivals.RESFTUXManager.IsCompleteFTUX(FTUXType:  4)) == false)
            {
                    return;
            }
            
            float val_3 = UnityEngine.Time.deltaTime;
            uint val_5 = 0;
            val_5 = this.noActionTimer + val_5;
            this.noActionTimer = val_5;
            if(this.CanSwipeUp() == false)
            {
                    return;
            }
            
            this.isOnSwipePrompt = true;
            this.SwipePrompt();
        }
        private System.Collections.IEnumerator ShowWelcomeFTUXPopup()
        {
            object val_1 = new System.Object();
            typeof(RESRestaurantUI.<ShowWelcomeFTUXPopup>d__50).__il2cppRuntimeField_8 = 0;
            typeof(RESRestaurantUI.<ShowWelcomeFTUXPopup>d__50).__il2cppRuntimeField_10 = this;
        }
        private System.Collections.IEnumerator ShowKeepBuildingFTUXPopup()
        {
            object val_1 = new System.Object();
            typeof(RESRestaurantUI.<ShowKeepBuildingFTUXPopup>d__51).__il2cppRuntimeField_8 = 0;
            typeof(RESRestaurantUI.<ShowKeepBuildingFTUXPopup>d__51).__il2cppRuntimeField_10 = this;
        }
        private bool CanSwipeUp()
        {
            var val_17;
            var val_18;
            var val_19;
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
                goto label_27;
            }
            
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            }
            
            val_17 = GetNumOfCanBuyRestaurantItems();
            label_27:
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_18 = 0;
            int val_12 = Spins;
            if(val_12 < 1)
            {
                    return true;
            }
            
            if(val_12 <= 1)
            {
                    return true;
            }
            
            if((RestaurantRivals.RESNewsPopup.UnseenNewsCount + val_17) > 0)
            {
                    return true;
            }
            
            if(this.isOnSwipePrompt == true)
            {
                    return true;
            }
            
            val_19 = null;
            val_19 = null;
            if(RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType != 0)
            {
                    return true;
            }
            
            val_17 = RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType.CurrentRestaurantStage;
            if(val_17 < this.restaurantManager.CurrentMaxGrowth)
            {
                    val_18 = 1;
            }
            
            return true;
        }
        private void OnPlayerDataUpdated()
        {
            this.InitializeRestaurantLayout();
            this.InitializeUI();
            this.UpdateForestInfo(animated:  false, skipButtonStates:  false);
        }
        private void OnLevelUp()
        {
            this.UpdateFreeCoinUI();
        }
        private void OnBuyButtonClicked()
        {
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            float val_26;
            var val_27;
            System.String[] val_28;
            var val_29;
            var val_33;
            var val_34;
            var val_35;
            val_19 = this;
            val_20 = null;
            val_20 = null;
            if(RestaurantRivals.RESFTUXManager.slotPlayDemoPopup != 0)
            {
                    val_21 = null;
                val_21 = null;
                if(RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType == 1)
            {
                    this.buyHand.SetActive(value:  false);
                val_22 = null;
                val_22 = null;
                RestaurantRivals.RESFTUXManager.slotPlayDemoPopup.OnSequencyFTUXUsed();
                this.Invoke(methodName:  633517392, time:  null);
            }
            
            }
            
            val_23 = null;
            val_23 = null;
            if(RestaurantRivals.RESFTUXManager.slotPlayDemoPopup != 0)
            {
                    val_24 = null;
                val_24 = null;
                if(RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType == 17)
            {
                    this.buyHand.SetActive(value:  false);
                val_25 = null;
                val_25 = null;
                RestaurantRivals.RESFTUXManager.slotPlayDemoPopup.OnSequencyFTUXUsed();
            }
            
            }
            
            this.OnGameAction();
            val_26 = 1152921504892043264;
            if(this.restaurantManager.CurrentForestContainsDamagedTrees != false)
            {
                    GameBehavior val_5 = App.getBehavior;
                val_27 = 0;
                typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
                val_28 = null;
                typeof(System.String[]).__il2cppRuntimeField_10 = "Urghhhh…OK";
                typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
                val_26 = null;
                System.Func<System.Boolean> val_7 = new System.Func<System.Boolean>(object:  633584928, method:  new IntPtr(633525792));
                if(null != 0)
            {
                    val_27 = val_27;
                if(null == 0)
            {
                    val_27 = val_27;
            }
            
            }
            
                val_27 = val_27;
                typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
                val_29 = null;
                val_27 = val_27;
                val_29 = null;
                if(val_27 == 0)
            {
                    val_27 = val_27;
            }
            
                val_27.SetupMessage(titleTxt:  633527056, messageTxt:  633526816, shownButtons:  1054454320, buttonTexts:  val_28, showClose:  false, buttonCallbacks:  val_26, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
                return;
            }
            
            Player val_8 = App.Player;
            decimal val_9 = CurrentGrowthCost;
            bool val_10 = System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal());
            if(val_10 != false)
            {
                    GameBehavior val_11 = App.getBehavior;
                if(0 != 0)
            {
                    return;
            }
            
                return;
            }
            
            if(val_10.CurrentRestaurantStage >= this.restaurantManager.CurrentMaxGrowth)
            {
                goto label_61;
            }
            
            this.restaurantManager.AddGrowth(damagedTreeIdToFix:  0);
            this.buyButton.interactable = false;
            val_33 = 0;
            this.buyButtonSmall.interactable = false;
            System.Collections.Generic.List<UnityEngine.Transform> val_15 = this.restaurantContent.AddGrowth(addGrowth:  1);
            goto label_66;
            label_69:
            if(this.restaurantContent <= val_33)
            {
                    var val_19 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_19 = val_19 + 0;
            this.PlayPlantingAnimation(treeTransform:  (0 + 0) + 16);
            val_33 = 1;
            label_66:
            if(val_33 < this.restaurantContent.levelId)
            {
                goto label_69;
            }
            
            if(this.restaurantContent.levelId.CurrentRestaurantStage >= this.restaurantManager.CurrentMaxGrowth)
            {
                    DG.Tweening.Sequence val_18 = this.DoCompleteReataurantSequence();
                this.restaurantContent.AddAnimationSequence(nextSequence:  633584928);
                this.FinishSwipePrompt();
            }
            
            val_34 = 0;
            val_35 = 0;
            goto label_73;
            label_61:
            val_34 = 0;
            val_35 = 1;
            label_73:
            this.UpdateForestInfo(animated:  false, skipButtonStates:  true);
        }
        private void ShowStarInfoFTUX()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowMessageByName(ftuxType:  2);
        }
        private void OnFixButtonClicked()
        {
            var val_12;
            if(this.currentHighlightedFixTreeId <= 1)
            {
                goto label_1;
            }
            
            Player val_1 = App.Player;
            decimal val_2 = CurrentGrowthCost;
            bool val_3 = System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal());
            if(val_3 == false)
            {
                goto label_8;
            }
            
            GameBehavior val_4 = App.getBehavior;
            if(0 != 0)
            {
                    return;
            }
            
            return;
            label_1:
            this.UpdateForestInfo(animated:  false, skipButtonStates:  false);
            return;
            label_8:
            int val_6 = val_3.CurrentRestaurantStage;
            int val_7 = this.restaurantManager.CurrentMaxGrowth;
            this.fixButton.interactable = false;
            this.fixButtonSmall.interactable = false;
            this.restaurantManager.AddGrowth(damagedTreeIdToFix:  this.currentHighlightedFixTreeId);
            UnityEngine.Transform val_8 = this.restaurantContent.FixTree(treeIndex:  this.currentHighlightedFixTreeId);
            this.PlayPlantingAnimation(treeTransform:  this.restaurantContent);
            val_12 = this.restaurantManager.CurrentRestaurantStage;
            if(val_12 >= this.restaurantManager.CurrentMaxGrowth)
            {
                    DG.Tweening.Sequence val_11 = this.DoCompleteReataurantSequence();
                val_12 = this;
                this.restaurantContent.AddAnimationSequence(nextSequence:  633886752);
            }
            
            this.UpdateForestInfo(animated:  false, skipButtonStates:  false);
        }
        private void OnContinueButtonClicked()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            object val_2 = this.bottomUI.GetComponent<System.Object>();
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.bottomUI, endValue:  null, duration:  null, snapping:  false);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.bottomUI);
            object val_5 = this.congratulationsGroup.GetComponent<System.Object>();
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.congratulationsGroup, endValue:  null, duration:  null, snapping:  false);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.congratulationsGroup);
            DG.Tweening.TweenCallback val_8 = new DG.Tweening.TweenCallback(object:  634040736, method:  new IntPtr(634015712));
            object val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        }
        private void OnAndroidBackButtonClicked()
        {
            GameBehavior val_1 = App.getBehavior;
            if(0 == 0)
            {
                
            }
        
        }
        private void OnFreeCoinButtonClick()
        {
            var val_3;
            GameBehavior val_1 = App.getBehavior;
            val_3 = null;
            val_3 = null;
            if(0 != 0)
            {
                    return;
            }
        
        }
        private void OnVideoResponse(Notification notif)
        {
            this.UpdateFreeCoinUI();
        }
        private void OnSwipeStart()
        {
            var val_3;
            UnityEngine.Transform val_1 = this.bottomUI.transform;
            val_3 = 0;
            if(this.bottomUI != 0)
            {
                    if(null != null)
            {
                    this.bottomUI = 0;
            }
            
                val_3 = this.bottomUI;
            }
            
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  0, endValue:  null, duration:  null, snapping:  false);
        }
        public void OnChestButtonClicked()
        {
            this.InitializeUI();
        }
        public void ShowNamePopup()
        {
            UnityEngine.Transform val_1 = this.titleGroup.transform;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.titleGroup, endValue:  null, duration:  null);
            object val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.titleGroup, ease:  27);
        }
        public void HideNamePopup()
        {
            UnityEngine.Transform val_1 = this.titleGroup.transform;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.titleGroup, endValue:  null, duration:  null);
            object val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.titleGroup, ease:  27);
        }
        public void ShowshortTermProgressPopup()
        {
            UnityEngine.Transform val_1 = this.ShortTermProgress.transform;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.ShortTermProgress, endValue:  null, duration:  null);
            object val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.ShortTermProgress, ease:  27);
        }
        private void InitializeUI()
        {
            bool val_14;
            this.ResetUIPositions();
            int val_1 = this.restaurantManager.CurrentRestaurantStage;
            int val_2 = this.restaurantManager.CurrentMaxGrowth;
            val_14 = 0;
            if(val_1 >= val_2)
            {
                    val_14 = this.restaurantManager.IsAtLastLevel ^ 1;
            }
            
            if(this.restaurantManager.IsForestChestCollected == true)
            {
                    0 = 1f;
            }
            
            if(val_1 >= val_2)
            {
                    0 = 1f;
            }
            
            if(val_14 == true)
            {
                    0 = 1f;
            }
            
            if(val_1 >= val_2)
            {
                    1f = 0;
                0 = 0;
            }
            
            this.congratulationsGroup.alpha = 0f;
            UnityEngine.GameObject val_5 = this.darkOverlay.gameObject;
            if(val_1 >= val_2)
            {
                    0 = 1;
            }
            
            this.darkOverlay.SetActive(value:  true);
            PluginExtension.SetColorAlpha(graphic:  this.darkOverlay, a:  0f);
            this.continueGroup.alpha = 0f;
            this.continueGroup.blocksRaycasts = val_14;
            this.titleGroup.alpha = 0f;
            this.titleObject.SetActive(value:  false);
            if((RestaurantRivals.RESFTUXManager.IsCompleteFTUX(FTUXType:  3)) != false)
            {
                    this.titleObject.SetActive(value:  true);
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                RestaurantRivals.RESPlayer val_8 = RestaurantRivals.RESPlayer.Instance;
                UnityEngine.Sprite val_9 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C.GetAvatarSpriteByID(id:  0);
                this.playerAvatar.sprite = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C;
                RestaurantRivals.RESPlayer val_10 = RestaurantRivals.RESPlayer.Instance;
            }
            
            this.growGroup.alpha = 0f;
            if(val_1 < val_2)
            {
                    0 = 1;
            }
            
            this.growGroup.blocksRaycasts = true;
            PluginExtension.SetColorAlpha(graphic:  this.bottomBackground, a:  0f);
            if(val_1 >= val_2)
            {
                    0 = 1;
            }
            
            if(val_1 != val_2)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_12 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        private void ResetUIPositions()
        {
            object val_1 = this.congratulationsGroup.GetComponent<System.Object>();
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.congratulationsGroup, endValue:  null, duration:  null, snapping:  true);
            object val_3 = this.bottomUI.GetComponent<System.Object>();
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.bottomUI, endValue:  null, duration:  null, snapping:  false);
        }
        private void UpdateFreeCoinUI()
        {
            int val_9;
            int val_10;
            ulong val_13;
            ulong val_15;
            int val_22;
            int val_23;
            int val_27;
            var val_28;
            var val_29;
            bool val_31;
            int val_32;
            val_27 = this;
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            val_28 = 0;
            if(VideoEnabledAndUnlocked() != false)
            {
                    Player val_3 = App.Player;
                val_28 = 0;
                RestaurantRivals.RESGameEcon val_4 = RestaurantRivals.RESGameEcon.Instance;
                if(0 >= 786466)
            {
                    WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
                val_28 = rewardVideoCapReached ^ 1;
            }
            
            }
            
            string val_7 = UnityEngine.PlayerPrefs.GetString(key:  628907104, defaultValue:  1098586544);
            val_29 = null;
            val_29 = null;
            System.DateTime val_8 = SLCDateTime.Parse(dateTime:  635466488, defaultValue:  new System.DateTime() {dateData = 1152921513825688672});
            System.DateTime val_11 = AddHours(value:  null);
            System.DateTime val_12 = DateTimeCheat.UtcNow;
            val_31 = val_28 & ((System.DateTime.Compare(t1:  new System.DateTime() {dateData = val_15}, t2:  new System.DateTime() {dateData = val_13})) >> 31);
            UnityEngine.GameObject val_18 = this.freeCoinButton.gameObject;
            val_32 = this.freeCoinButton;
            val_32.SetActive(value:  val_31);
            if(val_31 == false)
            {
                    return;
            }
            
            Player val_19 = App.Player;
            RestaurantRivals.RESLevelDef val_20 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            decimal val_21 = System.Decimal.op_Implicit(value:  635466488);
            decimal val_24;
            val_31 = val_10;
            val_32 = val_9;
            val_27 = val_23;
            val_24 = new System.Decimal(value:  999);
            string val_25 = RestaurantRivals.RESGameEconHelper.FormatNumberWithLimit(num:  new System.Decimal() {flags = val_31, hi = val_32, lo = val_22, mid = val_27}, numLimit:  new System.Decimal() {flags = val_24.flags, hi = val_24.hi, lo = val_24.lo, mid = val_24.flags});
        }
        private void InitializeRestaurantLayout()
        {
            if(this.restaurantContent != 0)
            {
                    UnityEngine.GameObject val_2 = this.restaurantContent.gameObject;
                UnityEngine.Object.Destroy(obj:  this.restaurantContent);
                this.restaurantContent = 0;
            }
            
            RestaurantRivals.RESRestaurantContent val_3 = this.restaurantManager.GetCurrentRestaurantLayout();
            object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  this.restaurantManager, parent:  this.forestContentParent);
            this.restaurantContent = this.restaurantManager;
            RestaurantRivals.RESPlayer val_5 = RestaurantRivals.RESPlayer.Instance;
            if((RestaurantRivals.RESFTUXManager.IsCompleteFTUX(FTUXType:  17)) != true)
            {
                    0.HackToFixAllBrokenItems();
            }
            
            this.restaurantContent.Initialize(restaurantMap:  0);
            this.ShortTermProgress.SetProgress(restaurantContent:  this.restaurantContent);
        }
        private void UpdateForestInfo(bool animated = False, bool skipButtonStates = False)
        {
            UnityEngine.UI.Text val_42;
            var val_43;
            float val_44;
            RestaurantRivals.RESRestaurantObject[] val_45;
            RestaurantRivals.RESRestaurantObject val_46;
            object val_1 = new System.Object();
            typeof(RESRestaurantUI.<>c__DisplayClass71_0).__il2cppRuntimeField_8 = this;
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            typeof(RESRestaurantUI.<>c__DisplayClass71_0).__il2cppRuntimeField_C = this.restaurantManager.CurrentRestaurantStage;
            typeof(RESRestaurantUI.<>c__DisplayClass71_0).__il2cppRuntimeField_10 = this.restaurantManager.CurrentMaxGrowth;
            if(skipButtonStates != true)
            {
                    DG.Tweening.TweenCallback val_6 = new DG.Tweening.TweenCallback(object:  428752896, method:  new IntPtr(635756384));
                DG.Tweening.Tween val_7 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1075838976, ignoreTimeScale:  false);
            }
            
            if(this.restaurantManager.CurrentForestContainsDamagedTrees == false)
            {
                goto label_7;
            }
            
            val_42 = this.fixCostText;
            decimal val_8 = CurrentGrowthCost;
            val_43 = 0;
            decimal val_9 = new System.Decimal(value:  999999999);
            string val_10 = RestaurantRivals.RESGameEconHelper.FormatNumberWithLimit(num:  new System.Decimal(), numLimit:  new System.Decimal() {flags = val_9.flags, hi = val_9.hi, lo = val_9.lo, mid = val_9.flags});
            this.restaurantContent.ToggleNextItemSilhouette(isOn:  false);
            UnityEngine.GameObject val_11 = this.fixButton.gameObject;
            this.fixButton.SetActive(value:  true);
            UnityEngine.GameObject val_12 = this.fixButtonSmall.gameObject;
            this.fixButtonSmall.SetActive(value:  true);
            UnityEngine.GameObject val_13 = this.buyButton.gameObject;
            this.buyButton.SetActive(value:  false);
            UnityEngine.GameObject val_14 = this.buyButtonSmall.gameObject;
            this.buyButtonSmall.SetActive(value:  false);
            this.buyNotification.SetActive(value:  false);
            this.fixButton.interactable = true;
            this.fixButtonSmall.interactable = true;
            UnityEngine.GameObject val_15 = this.fixNotification.gameObject;
            this.fixNotification.SetActive(value:  true);
            string val_17 = this.restaurantManager.GetCurrentNumOfDamagedRestaurantItems().ToString();
            this.currentHighlightedFixTreeId = this.restaurantManager.FirstDamagedItemId;
            UnityEngine.Transform val_19 = this.fixButtonSmall.transform;
            RestaurantRivals.RESRestaurantObject val_42 = this.restaurantContent.objects[this.currentHighlightedFixTreeId];
            val_44 = 0;
            UnityEngine.Transform val_20 = val_42.transform;
            UnityEngine.Vector3 val_21 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            val_45 = 1152921504767283200;
            if(val_42 != 0)
            {
                    if(null == null)
            {
                goto label_33;
            }
            
            }
            
            if(val_42 == 0)
            {
                goto label_36;
            }
            
            label_33:
            if(null == null)
            {
                goto label_35;
            }
            
            val_44 = 0;
            goto label_36;
            label_7:
            val_42 = this.buildCostText;
            decimal val_22 = CurrentGrowthCost;
            val_43 = 0;
            decimal val_23 = new System.Decimal(value:  999999999);
            string val_24 = RestaurantRivals.RESGameEconHelper.FormatNumberWithLimit(num:  new System.Decimal(), numLimit:  new System.Decimal() {flags = val_23.flags, hi = val_23.hi, lo = val_23.lo, mid = val_23.flags});
            this.restaurantContent.ToggleNextItemSilhouette(isOn:  true);
            UnityEngine.GameObject val_25 = this.fixButton.gameObject;
            this.fixButton.SetActive(value:  false);
            UnityEngine.GameObject val_26 = this.fixButtonSmall.gameObject;
            this.fixButtonSmall.SetActive(value:  false);
            UnityEngine.GameObject val_27 = this.fixNotification.gameObject;
            this.fixNotification.SetActive(value:  false);
            UnityEngine.GameObject val_28 = this.buyButton.gameObject;
            if(this.buyButton.CurrentRestaurantStage < this.restaurantManager.CurrentMaxGrowth)
            {
                    0 = 1;
            }
            
            this.buyButton.SetActive(value:  true);
            UnityEngine.GameObject val_31 = this.buyButtonSmall.gameObject;
            val_45 = this.buyButtonSmall.CurrentRestaurantStage;
            if(val_45 < this.restaurantManager.CurrentMaxGrowth)
            {
                    0 = 1;
            }
            
            this.buyButtonSmall.SetActive(value:  true);
            val_46 = this.buyButtonSmall.CurrentRestaurantStage;
            if(val_46 >= this.restaurantManager.CurrentMaxGrowth)
            {
                    return;
            }
            
            int val_36 = this.restaurantManager.GetNumOfCanBuyRestaurantItems();
            if(val_36 > 0)
            {
                    0 = 1;
            }
            
            this.buyNotification.SetActive(value:  true);
            string val_37 = val_36.ToString();
            UnityEngine.Transform val_38 = this.buyButtonSmall.transform;
            val_45 = this.restaurantContent.objects;
            val_46 = val_45[this.restaurantManager.CurrentRestaurantStage];
            UnityEngine.Vector3 val_40 = GetAveragePosition();
            this.buyButtonSmall.position = new UnityEngine.Vector3();
            this.currentHighlightedFixTreeId = 0;
            return;
            label_35:
            val_44 = val_42;
            label_36:
            val_46 = 0;
            UnityEngine.Vector3 val_41 = TransformPoint(position:  new UnityEngine.Vector3() {x = val_44, y = val_21.x, z = val_21.y});
            this.fixButtonSmall.position = new UnityEngine.Vector3();
        }
        private void UnlockNewRestaurant()
        {
            bool val_1 = this.restaurantManager.ContinueNextRestaurant();
            this.InitializeRestaurantLayout();
            this.InitializeUI();
            this.UpdateForestInfo(animated:  false, skipButtonStates:  false);
        }
        private void TrackAmplitudeInitialForestEntry()
        {
            var val_3;
            var val_4;
            var val_3 = 29757695;
            val_3 = 5867844 + val_3;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_3 = null;
            val_3 = null;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            FeatureAccessPoints val_2 = AmplitudePluginHelper.lastFeatureAccessPoint - 97;
            Add(key:  303411264, value:  8945664);
            var val_4 = 29757438;
            val_4 = 5868100 + val_4;
            if(val_4 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_4 = null;
            val_4 = null;
            App.trackerManager.track(eventName:  303411392, data:  78753792);
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
            DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  636589472, method:  new IntPtr(636564448));
            object val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.swipePromptHand, action:  190734336);
            this.SwipePromptTweener = this.swipePromptHand;
        }
        private void FinishSwipePrompt()
        {
            if(this.SwipePromptTweener != 0)
            {
                    DG.Tweening.TweenExtensions.Complete(t:  this.SwipePromptTweener);
                DG.Tweening.TweenExtensions.Kill(t:  this.SwipePromptTweener, complete:  false);
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
        private DG.Tweening.Sequence DoCompleteReataurantSequence()
        {
            DG.Tweening.TweenCallback val_35;
            RestaurantRivals.RESRestaurantManager val_36;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  637014560, method:  new IntPtr(636950624));
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.titleGroup, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.titleGroup);
            object val_7 = this.ShortTermProgress.GetComponent<System.Object>();
            DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.ShortTermProgress, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.ShortTermProgress);
            DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.darkOverlay, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.darkOverlay);
            DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.growGroup, endValue:  null, duration:  null);
            val_35 = null;
            val_35 = new DG.Tweening.TweenCallback(object:  637014560, method:  new IntPtr(636968032));
            object val_14 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.growGroup, action:  190734336);
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.growGroup);
            DG.Tweening.Tweener val_16 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.congratulationsGroup, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.congratulationsGroup);
            DG.Tweening.TweenCallback val_18 = new DG.Tweening.TweenCallback(object:  637014560, method:  new IntPtr(636973152));
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.TweenCallback val_20 = new DG.Tweening.TweenCallback(object:  637014560, method:  new IntPtr(636974176));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            val_36 = this.restaurantManager;
            if(val_36.IsAtLastLevel != false)
            {
                    GameBehavior val_23 = App.getBehavior;
                if(0 != 0)
            {
                    return;
            }
            
                return;
            }
            
            DG.Tweening.Tweener val_25 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.continueGroup, endValue:  null, duration:  null);
            val_35 = null;
            val_35 = new DG.Tweening.TweenCallback(object:  637014560, method:  new IntPtr(636984416));
            object val_27 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.continueGroup, action:  190734336);
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.continueGroup);
            DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            DG.Tweening.Tweener val_31 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.darkOverlay, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.darkOverlay);
            val_36 = null;
            val_36 = new DG.Tweening.TweenCallback(object:  637014560, method:  new IntPtr(636989536));
            DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        }
        private void PlayPlantingAnimation(UnityEngine.Transform treeTransform)
        {
            UnityEngine.Transform val_1 = this.buyButton.transform;
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.seedParticlesPrefab, parent:  this.buyButton);
            UnityEngine.Vector3 val_3 = position;
            this.seedParticlesPrefab.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  3);
        }
        public void Hack_CompleteRestaurant()
        {
            DG.Tweening.Sequence val_1 = this.DoCompleteReataurantSequence();
            this.restaurantContent.AddAnimationSequence(nextSequence:  637301024);
            this.InitializeRestaurantLayout();
            this.UpdateForestInfo(animated:  false, skipButtonStates:  false);
        }
        public RESRestaurantUI()
        {
            this.currentHighlightedFixTreeId = 0;
        }
        private void <ShowWelcomeFTUXPopup>b__50_0()
        {
            this.buyHand.SetActive(value:  true);
            UnityEngine.Transform val_1 = this.buyHand.transform;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.buyHand, endValue:  null, duration:  null);
            object val_3 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.buyHand, loops:  0, loopType:  1);
        }
        private void <ShowKeepBuildingFTUXPopup>b__51_0()
        {
            this.buyHand.SetActive(value:  true);
            UnityEngine.Transform val_1 = this.buyHand.transform;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.buyHand, endValue:  null, duration:  null);
            object val_3 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.buyHand, loops:  0, loopType:  1);
        }
        private bool <OnBuyButtonClicked>b__55_0()
        {
            this.InitializeRestaurantLayout();
            this.InitializeUI();
            this.UpdateForestInfo(animated:  false, skipButtonStates:  true);
            return true;
        }
        private void <OnContinueButtonClicked>b__58_0()
        {
            GameBehavior val_1 = App.getBehavior;
            0.SetUnlockNewRestaurant();
            System.Action val_3 = new System.Action(object:  637899936, method:  new IntPtr(637874912));
            0.SetOnTweenInCompleteCallback(callback:  7454720);
        }
        private void <SwipePrompt>b__74_0()
        {
            this.swipePromptTrail.Clear();
            this.swipePromptHand.SetActive(value:  false);
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.swipePromptMessage, endValue:  null, duration:  null);
            DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  638025248, method:  new IntPtr(638000224));
            object val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.swipePromptMessage, action:  190734336);
            this.SwipePromptTweener = this.swipePromptMessage;
        }
        private void <SwipePrompt>b__74_1()
        {
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.swipePromptMessage, endValue:  null, duration:  null);
            DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  638154656, method:  new IntPtr(638129632));
            object val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.swipePromptMessage, action:  190734336);
            this.SwipePromptTweener = this.swipePromptMessage;
        }
        private void <SwipePrompt>b__74_2()
        {
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.swipePromptMessage, endValue:  null, duration:  null);
            DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  638275872, method:  new IntPtr(638250848));
            object val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.swipePromptMessage, action:  190734336);
            this.SwipePromptTweener = this.swipePromptMessage;
        }
        private void <SwipePrompt>b__74_3()
        {
            this.SwipePromptTweener = 0;
            if(static_value_021F99E4 <= false)
            {
                    return;
            }
            
            R4.Invoke(methodName:  543839328, time:  2f);
        }
        private void <DoCompleteReataurantSequence>b__77_0()
        {
            UnityEngine.GameObject val_1 = this.darkOverlay.gameObject;
            this.darkOverlay.SetActive(value:  true);
            this.frontUI.Hide();
        }
        private void <DoCompleteReataurantSequence>b__77_1()
        {
            this.growGroup.blocksRaycasts = false;
        }
        private void <DoCompleteReataurantSequence>b__77_2()
        {
            this.congratParticleLeft.Play();
        }
        private void <DoCompleteReataurantSequence>b__77_3()
        {
            this.congratParticleRight.Play();
        }
        private void <DoCompleteReataurantSequence>b__77_4()
        {
            this.continueGroup.blocksRaycasts = true;
        }
        private void <DoCompleteReataurantSequence>b__77_5()
        {
            UnityEngine.GameObject val_1 = this.darkOverlay.gameObject;
            this.darkOverlay.SetActive(value:  false);
        }
    
    }

}
