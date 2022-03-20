using UnityEngine;

namespace RestaurantRivals
{
    public class RESFTUXPlayDemoPopup : WGHintButtonDemoPopup
    {
        // Fields
        protected UnityEngine.GameObject targetButtonObjectHolder;
        protected UnityEngine.GameObject SlotSpinMessage;
        protected UnityEngine.GameObject AttackMessage;
        protected UnityEngine.GameObject ShieldMessage;
        protected UnityEngine.GameObject RaidMessage;
        protected UnityEngine.GameObject AutoSpinMessage;
        protected UnityEngine.GameObject WatchAdMessage;
        protected UnityEngine.GameObject BetMultiplierMessage;
        protected UnityEngine.GameObject ExtraShieldMessage;
        protected UnityEngine.GameObject IncreaseRechargeableSpinMessage;
        protected UnityEngine.GameObject RevengeMessage;
        protected UnityEngine.GameObject OutOfSpinsMessage;
        protected UnityEngine.GameObject RestaurantWelcomeMessage;
        protected UnityEngine.GameObject StarInfoMessage;
        protected UnityEngine.GameObject NameAvatarMessage;
        protected UnityEngine.GameObject FinalRestaurantStepMessage;
        protected UnityEngine.GameObject KeepBuildingMessage;
        protected UnityEngine.GameObject starArrow;
        protected UnityEngine.GameObject WatchAdMessageArrow;
        protected MultiGraphicButton raidOkBtn;
        protected UnityEngine.GameObject raidPopup;
        protected UnityEngine.GameObject headChefPopup;
        protected UnityEngine.UI.Text extraShieldTxt;
        protected UnityEngine.GameObject extraShieldArrow;
        protected UnityEngine.UI.Text revengeText;
        protected UnityEngine.GameObject swipePromptHand;
        protected UnityEngine.TrailRenderer swipePromptTrail;
        protected RESSwiperActionTrigger restaurantSwiperFTUX;
        protected RESSwiperActionTrigger gameSceneSwiperFTUX;
        public System.Action OnComplete;
        private UnityEngine.Vector3 swipePromptHandLocalPos;
        private UnityEngine.Transform targetExtraButtonTransform;
        
        // Methods
        private void Awake()
        {
            System.Action val_1 = new System.Action(object:  543308832, method:  new IntPtr(543269472));
            this.restaurantSwiperFTUX.swipeAction = null;
            System.Action val_2 = new System.Action(object:  543308832, method:  new IntPtr(543274592));
            this.gameSceneSwiperFTUX.swipeAction = null;
            UnityEngine.Transform val_3 = this.swipePromptHand.transform;
            UnityEngine.Vector3 val_4 = localPosition;
            this.HideAllMessages();
            UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  543308832, method:  new IntPtr(543283808));
            this.raidOkBtn.AddListener(call:  162246656);
        }
        protected override void Start()
        {
            var val_29;
            var val_30;
            float val_31;
            var val_32;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  543457696, method:  new IntPtr(4170710432));
            public static AdsUIController MonoSingleton<AdsUIController>::get_Instance().__il2cppRuntimeField_1C.AddListener(call:  162246656);
            val_29 = null;
            val_29 = null;
            System.Type val_3 = this.GetType();
            EnumerableExtentions.SetOrAdd<System.Type, System.Boolean>(dic:  WGHintButtonDemoPopup.shownTypeDict, key:  543457696, newValue:  true);
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            BlockRaycasts = true;
            Interactable = true;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Color val_7 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            System.Nullable<UnityEngine.Color> val_8 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.r});
            val_30 = 1048576000;
            val_31 = val_7.b;
            SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_8.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
            if((-1637058032) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_30 = null;
            UnityEngine.Transform val_11 = val_31.transform;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = val_31;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_14 = val_31;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_18 = this.targetExtraButtonTransform;
            ShowOverlay(contentToOverlay:  -2028557104);
            val_31 = 1152921505031233536;
            val_32 = null;
            val_32 = null;
            if(RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType == 2)
            {
                    UnityEngine.Transform val_12 = this.starArrow.transform;
                UnityEngine.Transform val_13 = transform;
                UnityEngine.Vector3 val_14 = val_8.HasValue.localPosition;
                UnityEngine.Transform val_15 = transform;
                UnityEngine.Vector3 val_16 = val_7.r.localPosition;
                UnityEngine.Transform val_17 = this.starArrow.transform;
                val_30 = this.starArrow;
                UnityEngine.Vector3 val_18 = localPosition;
                UnityEngine.Vector3 val_20 = new UnityEngine.Vector3(x:  val_18.x, y:  val_18.y, z:  val_18.z);
                this.starArrow.localPosition = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
                val_32 = null;
            }
            
            val_32 = null;
            if(RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType != 13)
            {
                    return;
            }
            
            UnityEngine.Transform val_21 = this.extraShieldArrow.transform;
            UnityEngine.Transform val_22 = val_30.transform;
            UnityEngine.Vector3 val_23 = val_8.HasValue.localPosition;
            UnityEngine.Transform val_24 = val_30.transform;
            UnityEngine.Vector3 val_25 = val_7.r.localPosition;
            val_30 = 0;
            UnityEngine.Transform val_26 = this.extraShieldArrow.transform;
            UnityEngine.Vector3 val_27 = localPosition;
            UnityEngine.Vector3 val_28 = new UnityEngine.Vector3(x:  val_27.x, y:  val_27.y, z:  val_27.z);
            this.extraShieldArrow.localPosition = new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z};
        }
        protected override void OnDestroy()
        {
            null = null;
            RestaurantRivals.RESFTUXManager.slotPlayDemoPopup = 0;
        }
        protected override void SetPosition()
        {
            var val_10;
            var val_11;
            UnityEngine.Transform val_12;
            val_10 = 1152921504765685760;
            if(static_value_021FBD51 == 0)
            {
                    return;
            }
            
            val_11 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_3 = R6.transform;
            val_12 = R6;
            UnityEngine.Transform val_4 = GetStandInTransformForObject(original:  val_12);
            if((-1637058032) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_7 = transform;
            UnityEngine.Vector3 val_8 = TransformPositionToOverlaySpace(objectTransform:  -1637058032);
            val_11 = 0;
            UnityEngine.Transform val_9 = this.transform;
            this.position = new UnityEngine.Vector3() {x = R5, y = R6, z = R7};
        }
        protected override void SetupButton()
        {
            var val_76;
            var val_77;
            var val_78;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            GameBehavior val_4 = App.getBehavior;
            if(0 == 2)
            {
                    UnityEngine.Transform val_5 = this.transform;
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                UnityEngine.Transform val_7 = public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_C.transform;
                val_76 = public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_C;
                UnityEngine.Vector3 val_8 = RestaurantRivals.RESManager.GetWorldPosInSelCamera(selfTransform:  543954948, targetTransform:  543966992);
            }
            
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            GameBehavior val_10 = App.getBehavior;
            val_77 = 0;
            if(val_77 == 5)
            {
                    UnityEngine.Transform val_11 = this.transform;
                val_77 = this;
                twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                UnityEngine.Transform val_13 = transform;
                val_76 = public static RestaurantRivals.RESRestaurantUI MonoSingleton<RestaurantRivals.RESRestaurantUI>::get_Instance();
                UnityEngine.Vector3 val_14 = RestaurantRivals.RESManager.GetWorldPosInSelCamera(selfTransform:  543954948, targetTransform:  543966992);
            }
            
            val_78 = null;
            val_78 = null;
            RESFTUXType val_76 = RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType;
            val_76 = val_76 - 1;
            if(val_76 <= 17)
            {
                    var val_15 = 10568512 + (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2);
                if(val_76 == 17)
            {
                    10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 = (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2) & 0;
                10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 = (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2) * (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2);
                10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 = (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2) & ((10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2) >> 3);
                10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 = (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2) & (((int)IP) >> 4);
                10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 = (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2) & 908298240;
                10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 = (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2) & (((IP) << (32-9)) | ((IP) << 9));
                10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 = (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2) & 36247492;
                10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 = (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2) & (((IP) << (32-this)) | ((IP) << this));
                10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 = (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2) & ((10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2) >> LR);
                10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 = (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2) & ((IP) >> val_76);
                10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 = (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2) & 8849;
                10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 = (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2) & ((10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2) >> 36284364);
                10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 = (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2) & 543966992;
                mem2[0] = (((((((((((((10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0) * (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0)) & ((int)((105 + (((((((((((((10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0) * (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0)) & ((int)((105;
                ((((((((((((((10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0) * (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0)) & ((int)((105 + (((((((((((((10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0) * (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0)) & ((int)((105) & 4169138176 = (((((((((((((((10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0) * (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0)) & ((int)((105 + (((((((((((((10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0) * (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0)) & ((int)((105) & 4169138176) & ((((((((((((((((10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0) * (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0)) & ((int)((105 + (((((((((((((10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0) * (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0)) & ((int)((105) & 4169138176) >> LR);
                ((((((((((((((10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0) * (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0)) & ((int)((105 + (((((((((((((10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0) * (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0)) & ((int)((105) & 4169138176 = (((((((((((((((10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0) * (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0)) & ((int)((105 + (((((((((((((10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0) * (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0)) & ((int)((105) & 4169138176) & ((((((((((((((((10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0) * (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0)) & ((int)((105 + (((((((((((((10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0) * (10568512 + ((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType - 1)) << 2 & 0)) & ((int)((105) & 4169138176) >> LR);
            }
            
                this.RestaurantWelcomeMessage.SetActive(value:  true);
                UnityEngine.Transform val_16 = this.RestaurantWelcomeMessage.transform;
            }
        
        }
        public void OnSequencyFTUXUsed()
        {
            var val_5;
            var val_6;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((UnityEngine.Object.op_Implicit(exists:  -1537803328)) != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                FinishFTUX();
            }
            
            val_5 = null;
            val_5 = null;
            int val_4 = RestaurantRivals.RESFTUXManager.CompleteFTUX(FTUXType:  RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType);
            if(this.OnComplete != 0)
            {
                    this.OnComplete.Invoke();
            }
            
            this.OnClick_UseHint();
            val_6 = null;
            val_6 = null;
            RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType = 0;
        }
        public void OnNonSequencyFTUXUsed()
        {
            var val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((UnityEngine.Object.op_Implicit(exists:  -1537803328)) != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                FinishFTUX();
            }
            
            if(this.OnComplete != 0)
            {
                    this.OnComplete.Invoke();
            }
            
            this.OnClick_UseHint();
            val_4 = null;
            val_4 = null;
            RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType = 0;
        }
        public static bool CheckFTUX(RestaurantRivals.RESFTUXManager.RESFTUXType slotPlayFTUXType)
        {
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_1 = 424439808 + -559222368(-559222368);
            int val_2 = UnityEngine.PlayerPrefs.GetInt(key:  424439808, defaultValue:  0);
            val_2 = val_2 + 1;
            val_2 = val_2 >> 5;
            return (bool)val_2;
        }
        private void SwipePrompt()
        {
            this.swipePromptHand.SetActive(value:  true);
            UnityEngine.Transform val_1 = this.swipePromptHand.transform;
            this.swipePromptHand.localPosition = new UnityEngine.Vector3() {x = mem[this.swipePromptHandLocalPos + (0)], y = mem[this.swipePromptHandLocalPos + (4)], z = mem[this.swipePromptHandLocalPos + (8)]};
            UnityEngine.Transform val_2 = this.swipePromptHand.transform;
            float val_6 = -260f;
            val_6 = S2 + val_6;
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.swipePromptHand, endValue:  val_6, duration:  null, snapping:  val_6);
            DG.Tweening.TweenCallback val_4 = new DG.Tweening.TweenCallback(object:  544604432, method:  new IntPtr(544579408));
            object val_5 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.swipePromptHand, action:  190734336);
        }
        private void HideAllMessages()
        {
            this.SlotSpinMessage.SetActive(value:  false);
            this.AttackMessage.SetActive(value:  false);
            this.ShieldMessage.SetActive(value:  false);
            this.RaidMessage.SetActive(value:  false);
            this.AutoSpinMessage.SetActive(value:  false);
            this.WatchAdMessage.SetActive(value:  false);
            this.BetMultiplierMessage.SetActive(value:  false);
            this.ExtraShieldMessage.SetActive(value:  false);
            this.IncreaseRechargeableSpinMessage.SetActive(value:  false);
            this.RevengeMessage.SetActive(value:  false);
            this.RestaurantWelcomeMessage.SetActive(value:  false);
            this.StarInfoMessage.SetActive(value:  false);
            this.NameAvatarMessage.SetActive(value:  false);
            this.FinalRestaurantStepMessage.SetActive(value:  false);
            this.KeepBuildingMessage.SetActive(value:  false);
            this.OutOfSpinsMessage.SetActive(value:  false);
        }
        public void OnclickShowMessage(string ftuxType)
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(424439808)});
            if((System.Enum.IsDefined(enumType:  424439808, value:  ftuxType)) == false)
            {
                    return;
            }
            
            System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(424439808)});
            object val_4 = System.Enum.Parse(enumType:  424439808, value:  ftuxType);
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.OnclickShowMessage(ftuxType:  null);
        }
        public void OnclickShowMessage(RestaurantRivals.RESFTUXManager.RESFTUXType ftuxType)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.IEnumerator val_2 = startShowMessage(ftuxType:  ftuxType);
            UnityEngine.Coroutine val_3 = StartCoroutine(routine:  -1079021104);
            this.OnSequencyFTUXUsed();
        }
        public RESFTUXPlayDemoPopup()
        {
        
        }
        private void <Awake>b__32_0()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  545325200, method:  new IntPtr(545300176));
            System.Collections.IEnumerator val_3 = MoveAndLoadScene(callback:  7454720);
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  -657286704);
        }
        private void <Awake>b__32_1()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  545437200, method:  new IntPtr(545300176));
            System.Collections.IEnumerator val_3 = MoveAndLoadScene(callback:  7454720);
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  -657286704);
        }
        private void <Awake>b__32_2()
        {
            this.raidPopup.SetActive(value:  false);
            this.headChefPopup.SetActive(value:  true);
        }
        private void <SetupButton>b__36_0(System.Collections.Generic.List<RestaurantRivals.UserRestaurantProfile> revengeList)
        {
            var val_3 = 35634524;
            if(true < 1)
            {
                    return;
            }
            
            string val_1 = System.String.Format(format:  545661776, arg0:  -338719117);
            if(this.revengeText == 0)
            {
                
            }
        
        }
        private void <SwipePrompt>b__40_0()
        {
            this.swipePromptTrail.Clear();
            this.swipePromptHand.SetActive(value:  false);
            this.Invoke(methodName:  543839328, time:  null);
        }
    
    }

}
