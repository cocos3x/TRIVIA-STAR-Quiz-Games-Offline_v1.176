using UnityEngine;

namespace RestaurantRivals
{
    public class RESRaidScreenMain : MonoSingleton<RestaurantRivals.RESRaidScreenMain>
    {
        // Fields
        private const int MAX_PICK_CHANCES = 3;
        private UnityEngine.RectTransform restaurantContainer;
        private UnityEngine.RectTransform adsArea;
        private UnityEngine.GameObject restaurant;
        private UnityEngine.GameObject bottomUI;
        private UnityEngine.RectTransform topUIScale;
        private UnityEngine.RectTransform subtitleScale;
        private UnityEngine.RectTransform topMultiplierScale;
        private UnityEngine.RectTransform coinParticleParent;
        private UnityEngine.RectTransform pickerUIScale;
        private UnityEngine.RectTransform conclusionUIScale;
        private UnityEngine.RectTransform multiplierUIScale;
        private System.Collections.Generic.List<UnityEngine.UI.Image> pickerIconList;
        private UnityEngine.RectTransform opponentAvatarPos;
        private UnityEngine.UI.Image opponentAvatarImage;
        private UnityEngine.UI.Text forestLabel;
        private UnityEngine.UI.Text subtitleLabel;
        private RestaurantRivals.RaidSpotResult raidSpotResult;
        private UnityEngine.ParticleSystem prefabEfxCoinSpring;
        private UnityEngine.GameObject perfectBanner;
        private UnityEngine.UI.Text rewardMessageCoins;
        private UnityEngine.UI.Text rewardMessagePlayer;
        private UnityEngine.UI.Button buttonRewardNext;
        private UnityEngine.UI.Text topmultiplierLabel;
        private UnityEngine.UI.Text multiplierLabel;
        private UnityEngine.AnimationCurve curve;
        private UnityEngine.ParticleSystem confetti;
        private UnityEngine.GameObject ftuxRoot;
        private UnityEngine.GameObject ftuxTooltip;
        private RestaurantRivals.RaidXSpotButton ftuxHighlightedObject;
        private RestaurantRivals.UserRestaurantProfile opponent;
        private System.Collections.Generic.List<RestaurantRivals.RaidXSpotButton> pickedRaidSpots;
        private System.Collections.Generic.List<int> chosenRewardIndexes;
        private decimal coinsRaided;
        public static bool isPerfectRaid;
        private RestaurantRivals.RESRestaurantContent restaurantContent;
        private UnityEngine.Vector3 raidSpotResultOriginalPosition;
        private DG.Tweening.Tween raidSpotResultScalTween;
        private DG.Tweening.Tween raidSpotResultMoveTween;
        private DG.Tweening.Tween raidSpotResultAlphaTween;
        private DG.Tweening.Sequence raidSeq;
        
        // Properties
        private System.Collections.Generic.List<System.Decimal> pickerRewards { get; }
        public UnityEngine.RectTransform OpponentAvatarPos { get; }
        private RestaurantRivals.RESPlayer player { get; }
        
        // Methods
        private System.Collections.Generic.List<System.Decimal> get_pickerRewards()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance()) != 0)
            {
                    return;
            }
        
        }
        public UnityEngine.RectTransform get_OpponentAvatarPos()
        {
        
        }
        private RestaurantRivals.RESPlayer get_player()
        {
            return RestaurantRivals.RESPlayer.Instance;
        }
        public override void InitMonoSingleton()
        {
            this.restaurant.SetActive(value:  false);
            this.bottomUI.SetActive(value:  false);
        }
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  610429872, method:  new IntPtr(610396656));
            this.buttonRewardNext.m_OnClick.AddListener(call:  162246656);
            UnityEngine.GameObject val_2 = this.raidSpotResult.gameObject;
            this.raidSpotResult.SetActive(value:  false);
            UnityEngine.GameObject val_3 = this.prefabEfxCoinSpring.gameObject;
            this.prefabEfxCoinSpring.SetActive(value:  false);
            this.Initialize();
        }
        private void OnEnable()
        {
            var val_40;
            var val_41;
            UnityEngine.Vector2 val_1 = anchoredPosition;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_1.x, y:  val_1.y);
            this.topUIScale.anchoredPosition = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            UnityEngine.Vector2 val_4 = anchoredPosition;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_4.x, y:  val_4.y);
            this.subtitleScale.anchoredPosition = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            UnityEngine.Vector2 val_7 = val_6.x.anchoredPosition;
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_7.x, y:  val_7.y);
            this.topMultiplierScale.anchoredPosition = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
            UnityEngine.Vector2 val_9 = anchoredPosition;
            UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_9.x, y:  val_9.y);
            this.multiplierUIScale.anchoredPosition = new UnityEngine.Vector2() {x = val_11.x, y = val_11.y};
            UnityEngine.Vector2 val_12 = anchoredPosition;
            UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  val_12.x, y:  val_12.y);
            this.conclusionUIScale.anchoredPosition = new UnityEngine.Vector2() {x = val_14.x, y = val_14.y};
            this.confetti.Stop();
            UnityEngine.Transform val_15 = this.raidSpotResult.transform;
            UnityEngine.Vector3 val_16 = localPosition;
            UnityEngine.GameObject val_17 = this.topMultiplierScale.gameObject;
            twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(SpinBet > 1)
            {
                    0 = 1;
            }
            
            this.topMultiplierScale.SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_21 = SpinBet;
            string val_22 = 520034112 + 13152256;
            UnityEngine.GameObject val_23 = this.multiplierUIScale.gameObject;
            twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(SpinBet > 1)
            {
                    0 = 1;
            }
            
            this.multiplierUIScale.SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_27 = SpinBet;
            string val_28 = 520034112 + 13152256;
            UnityEngine.GameObject val_29 = this.perfectBanner.gameObject;
            this.perfectBanner.SetActive(value:  false);
            UnityEngine.GameObject val_30 = this.opponentAvatarPos.gameObject;
            this.opponentAvatarPos.SetActive(value:  false);
            UnityEngine.GameObject val_31 = this.subtitleScale.gameObject;
            this.subtitleScale.SetActive(value:  false);
            UnityEngine.GameObject val_32 = this.topMultiplierScale.gameObject;
            this.topMultiplierScale.SetActive(value:  false);
            DG.Tweening.Tweener val_33 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.topUIScale, endValue:  val_16.x, duration:  val_16.y, snapping:  false);
            this.Invoke(methodName:  610599792, time:  val_16.x);
            this.Invoke(methodName:  610599888, time:  val_16.x);
            val_40 = 1152921511025997392;
            twelvegigs.Autopilot.AutopilotManager val_34 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_41 = 0;
            if(2124183120 == 0)
            {
                goto label_44;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_36 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_37 = GetBannerAdHeight();
            val_40 = public static AdsUIController MonoSingleton<AdsUIController>::get_Instance();
            UnityEngine.GameObject val_38 = this.adsArea.gameObject;
            if(this.adsArea > 0)
            {
                    0 = 1;
            }
            
            this.adsArea.SetActive(value:  true);
            goto label_44;
            label_50:
            if(this.adsArea <= val_41)
            {
                    var val_40 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_40 = val_40 + 0;
            UnityEngine.GameObject val_39 = (0 + 0) + 16.gameObject;
            (0 + 0) + 16.SetActive(value:  false);
            val_41 = 1;
            label_44:
            if(val_41 < ((0 + 0) + 16))
            {
                goto label_50;
            }
        
        }
        private void ShowTopUI()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  610828160, method:  new IntPtr(610802112));
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  610828160, method:  new IntPtr(610803136));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        }
        private void HideTopUI()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.topMultiplierScale, endValue:  null, duration:  null, snapping:  false);
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.topMultiplierScale);
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.subtitleScale, endValue:  null, duration:  null, snapping:  false);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.subtitleScale);
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.topUIScale, endValue:  null, duration:  null, snapping:  false);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.topUIScale);
        }
        private void HidePickerUI()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.pickerUIScale, endValue:  null, duration:  null, snapping:  false);
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.pickerUIScale);
        }
        private void ShowRewardUI()
        {
            var val_26;
            DG.Tweening.TweenCallback val_27;
            val_26 = null;
            val_26 = null;
            if(RestaurantRivals.RESRaidScreenMain.isPerfectRaid == true)
            {
                    RestaurantRivals.RESRaidScreenMain.isPerfectRaid = 1;
            }
            
            this.perfectBanner.SetActive(value:  true);
            UnityEngine.Transform val_1 = this.perfectBanner.transform;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.perfectBanner.localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_3 = this.perfectBanner.transform;
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.perfectBanner, endValue:  val_2.x, duration:  val_2.y);
            DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.conclusionUIScale, endValue:  val_2.x, duration:  val_2.y, snapping:  false);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.conclusionUIScale);
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_27 = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance();
            if(SpinBet < 2)
            {
                    return;
            }
            
            DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.multiplierUIScale, endValue:  val_2.x, duration:  val_2.y, snapping:  false);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.multiplierUIScale);
            DG.Tweening.TweenCallback val_12 = new DG.Tweening.TweenCallback(object:  611235840, method:  new IntPtr(611193408));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_2.x);
            UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  val_2.x, y:  val_2.y);
            DG.Tweening.Tweener val_16 = DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.multiplierUIScale, endValue:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, duration:  val_2.x, snapping:  true);
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.multiplierUIScale);
            DG.Tweening.Tweener val_18 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.multiplierUIScale, endValue:  val_2.x, duration:  val_2.y);
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.multiplierUIScale);
            UnityEngine.Transform val_20 = this.rewardMessageCoins.transform;
            DG.Tweening.Tweener val_21 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.rewardMessageCoins, endValue:  val_2.x, duration:  val_2.y);
            object val_22 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.rewardMessageCoins, animCurve:  this.curve);
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.rewardMessageCoins);
            val_27 = null;
            val_27 = new DG.Tweening.TweenCallback(object:  611235840, method:  new IntPtr(611210816));
            DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  0, atPosition:  val_2.x, callback:  1067030938);
        }
        private void HideRewardUI()
        {
            UnityEngine.Transform val_1 = this.perfectBanner.transform;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.perfectBanner, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.multiplierUIScale, endValue:  null, duration:  null, snapping:  false);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.multiplierUIScale);
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.conclusionUIScale, endValue:  null, duration:  null, snapping:  false);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.conclusionUIScale);
        }
        private void ShowRestaurantWindow()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  public static RestaurantRivals.RESRaidAttackScreenTransition MonoSingleton<RestaurantRivals.RESRaidAttackScreenTransition>::get_Instance().__il2cppRuntimeField_20, endValue:  null, duration:  null);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_4 = new System.Action(object:  611522304, method:  new IntPtr(611497280));
            ShowReavelAnimation(onMiddle:  7454720);
        }
        private void Initialize()
        {
            var val_14;
            RestaurantRivals.UserRestaurantProfile val_15;
            this.BeginRaid();
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            this.chosenRewardIndexes = null;
            val_14 = null;
            val_14 = null;
            RestaurantRivals.RESRaidScreenMain.isPerfectRaid = true;
            val_15 = this.opponent;
            if(this.opponent != 0)
            {
                goto label_3;
            }
            
            val_15 = this.opponent;
            if(val_15 == 0)
            {
                goto label_4;
            }
            
            label_3:
            RestaurantRivals.UserRestaurantProfile val_2 = val_15 + 32;
            decimal val_3 = new System.Decimal(value:  999999999);
            string val_4 = RestaurantRivals.RESGameEconHelper.FormatNumberWithLimit(num:  new System.Decimal() {flags = this.opponent.credits, hi = mem[(this.opponent + 32) + (0)], lo = mem[(this.opponent + 32) + (4)], mid = mem[(this.opponent + 32) + (8)]}, numLimit:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.flags});
            string val_5 = System.String.Format(format:  611626688, arg0:  this.opponent.name, arg1:  this.opponent.credits);
            this.RefreshSubtitle();
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Sprite val_7 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C.GetAvatarSpriteByID(id:  this.opponent.avatarId);
            this.opponentAvatarImage.sprite = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C;
            if(this.restaurantContent != 0)
            {
                    UnityEngine.GameObject val_9 = this.restaurantContent.gameObject;
                UnityEngine.Object.Destroy(obj:  this.restaurantContent);
            }
            
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            RestaurantRivals.RESRestaurantContent val_11 = GetRestaurantLayout(forestId:  this.opponent.level);
            object val_12 = UnityEngine.Object.Instantiate<System.Object>(original:  -732109616, parent:  this.restaurantContainer);
            this.restaurantContent = public static RestaurantRivals.RESRestaurantManager MonoSingleton<RestaurantRivals.RESRestaurantManager>::get_Instance();
            Initialize(restaurantMap:  this.opponent.map);
            System.Collections.Generic.List<RestaurantRivals.RaidXSpotButton> val_13 = this.restaurantContent.PickRaidSpotButtons();
            this.pickedRaidSpots = this.restaurantContent;
            return;
            label_4:
        }
        private System.Collections.IEnumerator ShowPickedRaidSpots()
        {
            RESRaidScreenMain.<ShowPickedRaidSpots>d__57 val_1 = new RESRaidScreenMain.<ShowPickedRaidSpots>d__57(<>1__state:  0);
            typeof(RESRaidScreenMain.<ShowPickedRaidSpots>d__57).__il2cppRuntimeField_10 = this;
        }
        private void RefreshSubtitle()
        {
            decimal val_1 = new System.Decimal(value:  999999999);
            string val_2 = RestaurantRivals.RESGameEconHelper.FormatNumberWithLimit(num:  new System.Decimal() {flags = mem[this.coinsRaided + (0)], hi = mem[this.coinsRaided + (4)], lo = mem[this.coinsRaided + (8)], mid = mem[this.coinsRaided + (12)]}, numLimit:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.flags});
            string val_3 = System.String.Format(format:  -1104433312, arg0:  mem[this.coinsRaided + (0)]);
            if(this.subtitleLabel != 0)
            {
                    return;
            }
        
        }
        private void OnRaidXSpotClicked(RestaurantRivals.RaidXSpotButton spotButton)
        {
            RestaurantRivals.RaidXSpotButton val_58;
            DG.Tweening.TweenCallback val_59;
            float val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            DG.Tweening.TweenCallback val_66;
            var val_67;
            object val_68;
            val_58 = spotButton;
            typeof(RESRaidScreenMain.<>c__DisplayClass59_0).__il2cppRuntimeField_C = this;
            if(this.raidSeq != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.raidSeq, complete:  false);
                this.raidSeq = 0;
            }
            
            this.ftuxRoot.SetActive(value:  false);
            UnityEngine.GameObject val_2 = this.raidSpotResult.gameObject;
            val_59 = this.raidSpotResult;
            val_59.SetActive(value:  false);
            if(val_59 > 2)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  612081616, clipIndex:  0);
            val_58.Interactable = false;
            this.ToggleRaidXButtonsActive(active:  false);
            int val_58 = spotButton.<SpotId>k__BackingField;
            this.chosenRewardIndexes.Add(item:  val_58);
            System.Collections.Generic.List<System.Decimal> val_4 = this.chosenRewardIndexes.pickerRewards;
            System.Collections.Generic.List<System.Int32> val_5 = this.chosenRewardIndexes - 1;
            if(this.chosenRewardIndexes <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_58 = val_58 + (val_5 << 4);
            decimal val_6 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 612244272, hi = this.coinsRaided, lo = R2, mid = R3}, d2:  new System.Decimal() {flags = ???, hi = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 16, lo = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 20, mid = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 24});
            val_60 = new RESRaidScreenMain.<>c__DisplayClass59_0();
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 16, hi = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 20, lo = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 24, mid = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 28}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  612089904, clipIndex:  0);
            }
            
            if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 16, hi = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 20, lo = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 24, mid = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 28}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
            {
                    val_61 = null;
                val_61 = null;
                RestaurantRivals.RESRaidScreenMain.isPerfectRaid = false;
            }
            
            if(RestaurantRivals.RESRaidScreenMain.__il2cppRuntimeField_static_fields >= 3)
            {
                    RestaurantRivals.RESRaidScreenMain.__il2cppRuntimeField_static_fields = this;
                this.EndRaid();
            }
            
            val_62 = public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            UnityEngine.Transform val_11 = (0 + ((public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C - false)) << 2) + 16.transform;
            DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions.DOScale(target:  (0 + ((public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C - false)) << 2) + 16, endValue:  null, duration:  null);
            object val_13 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  (0 + ((public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C - false)) << 2) + 16, ease:  26);
            UnityEngine.Transform val_14 = this.raidSpotResult.transform;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
            this.raidSpotResult.localScale = new UnityEngine.Vector3();
            this.raidSpotResult.Setup(amount:  new System.Decimal() {flags = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 16, hi = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 20, lo = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 24, mid = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 28});
            object val_16 = UnityEngine.Object.Instantiate<System.Object>(original:  this.prefabEfxCoinSpring, parent:  this.coinParticleParent);
            typeof(RESRaidScreenMain.<>c__DisplayClass59_0).__il2cppRuntimeField_8 = this.prefabEfxCoinSpring;
            UnityEngine.Transform val_17 = this.prefabEfxCoinSpring.transform;
            UnityEngine.Vector3 val_18 = position;
            this.prefabEfxCoinSpring.position = new UnityEngine.Vector3();
            UnityEngine.GameObject val_19 = typeof(RESRaidScreenMain.<>c__DisplayClass59_0).__il2cppRuntimeField_8.gameObject;
            val_63 = 0;
            typeof(RESRaidScreenMain.<>c__DisplayClass59_0).__il2cppRuntimeField_8.SetActive(value:  true);
            if(this.raidSpotResultMoveTween != 0)
            {
                    val_63 = 0;
                DG.Tweening.TweenExtensions.Kill(t:  this.raidSpotResultMoveTween, complete:  false);
            }
            
            if(this.raidSpotResultScalTween != 0)
            {
                    val_63 = 0;
                DG.Tweening.TweenExtensions.Kill(t:  this.raidSpotResultScalTween, complete:  false);
            }
            
            if(this.raidSpotResultAlphaTween != 0)
            {
                    val_63 = 0;
                DG.Tweening.TweenExtensions.Kill(t:  this.raidSpotResultAlphaTween, complete:  false);
            }
            
            this.raidSpotResultScalTween = 0;
            this.raidSpotResultMoveTween = 0;
            this.raidSpotResultAlphaTween = 0;
            DG.Tweening.Sequence val_20 = DG.Tweening.DOTween.Sequence();
            this.raidSeq = 0;
            val_64 = null;
            val_64 = null;
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.raidSeq, interval:  val_18.x);
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 16, hi = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 20, lo = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 24, mid = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 28}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
            {
                    DG.Tweening.TweenCallback val_23 = new DG.Tweening.TweenCallback(object:  427954176, method:  new IntPtr(612139152));
                DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.raidSeq, callback:  190734336);
                DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.raidSeq, interval:  val_18.x);
            }
            
            DG.Tweening.TweenCallback val_26 = new DG.Tweening.TweenCallback(object:  427954176, method:  new IntPtr(612148368));
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.raidSeq, callback:  190734336);
            val_58 = 0;
            UnityEngine.Transform val_28 = this.raidSpotResult.transform;
            DG.Tweening.Tweener val_29 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.raidSpotResult, endValue:  val_18.x, duration:  val_18.y);
            object val_30 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.raidSpotResult, ease:  27);
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.raidSeq, t:  this.raidSpotResult);
            DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.raidSeq, interval:  val_18.x);
            DG.Tweening.TweenCallback val_33 = new DG.Tweening.TweenCallback(object:  427954176, method:  new IntPtr(612165776));
            DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.raidSeq, callback:  190734336);
            val_65 = null;
            val_65 = null;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 16, hi = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 20, lo = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 24, mid = (spotButton.<SpotId>k__BackingField + ((this.chosenRewardIndexes - 1)) << 4) + 28}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
            {
                    val_58 = 16025;
                val_58 = 1050253722;
                DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.raidSeq, interval:  val_18.x);
                DG.Tweening.TweenCallback val_37 = new DG.Tweening.TweenCallback(object:  427954176, method:  new IntPtr(612174992));
                DG.Tweening.Sequence val_38 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.raidSeq, callback:  190734336);
                DG.Tweening.TweenCallback val_39 = new DG.Tweening.TweenCallback(object:  427954176, method:  new IntPtr(612180112));
                DG.Tweening.Sequence val_40 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.raidSeq, callback:  190734336);
                DG.Tweening.Sequence val_41 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.raidSeq, interval:  val_18.x);
                DG.Tweening.TweenCallback val_42 = new DG.Tweening.TweenCallback(object:  612256336, method:  new IntPtr(612189328));
                DG.Tweening.Sequence val_43 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.raidSeq, callback:  190734336);
            }
            else
            {
                    DG.Tweening.Sequence val_44 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.raidSeq, interval:  val_18.x);
                DG.Tweening.TweenCallback val_45 = new DG.Tweening.TweenCallback(object:  427954176, method:  new IntPtr(612194448));
                DG.Tweening.Sequence val_46 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.raidSeq, callback:  190734336);
                DG.Tweening.Sequence val_47 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.raidSeq, interval:  val_18.x);
            }
            
            if(this.raidSeq < 3)
            {
                    val_66 = null;
                val_66 = new DG.Tweening.TweenCallback(object:  427954176, method:  new IntPtr(612207760));
                object val_49 = DG.Tweening.TweenSettingsExtensions.OnKill<System.Object>(t:  this.raidSeq, action:  190734336);
                val_59 = null;
                val_59 = new DG.Tweening.TweenCallback(object:  427954176, method:  new IntPtr(612213904));
                val_67 = public static DG.Tweening.Sequence DG.Tweening.TweenSettingsExtensions::OnComplete<DG.Tweening.Sequence>(DG.Tweening.Sequence t, DG.Tweening.TweenCallback action);
                val_68 = this.raidSeq;
            }
            else
            {
                    val_60 = 1152921504797581312;
                var val_60 = 0;
                val_58 = 15897;
                val_58 = 1041865114;
                do
            {
                val_66 = this.chosenRewardIndexes;
                bool val_51 = val_66.Contains(item:  0);
                if(val_51 != true)
            {
                    if(val_51 <= val_60)
            {
                    var val_59 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_59 = val_59 + 0;
                val_66 = mem[(0 + 0) + 16];
                val_66 = (0 + 0) + 16;
                UnityEngine.Transform val_52 = val_66.transform;
                DG.Tweening.Tweener val_53 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_66, endValue:  val_18.x, duration:  val_18.y);
                object val_54 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_66, ease:  26);
            }
            
                val_60 = val_60 + 1;
            }
            while(val_60 != 4);
            
                DG.Tweening.Sequence val_55 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.raidSeq, interval:  val_18.x);
                val_59 = null;
                val_59 = new DG.Tweening.TweenCallback(object:  612256336, method:  new IntPtr(612231312));
                val_67 = public static DG.Tweening.Sequence DG.Tweening.TweenSettingsExtensions::OnComplete<DG.Tweening.Sequence>(DG.Tweening.Sequence t, DG.Tweening.TweenCallback action);
                val_68 = this.raidSeq;
            }
            
            object val_57 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  val_68, action:  190734336);
        }
        private void ToggleRaidXButtonsActive(bool active)
        {
            this.restaurantContent.graphicRaycaster.enabled = active;
        }
        private void BeginRaid()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.opponent = null;
        }
        private void EndRaid()
        {
            int val_8;
            var val_11;
            var val_12;
            System.Collections.Hashtable val_1 = new System.Collections.Hashtable();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_1C.Notify(note:  2, data:  75878400);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_5 = SpinBet;
            decimal val_6 = System.Decimal.op_Implicit(value:  612772776);
            decimal val_7 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 612772760, hi = this.coinsRaided, lo = -1825802336, mid = R8}, d2:  new System.Decimal() {flags = ???});
            SetRaidAttackResults(winnings:  new System.Decimal() {mid = val_8});
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_9 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if(this.opponent.IsDummyAccount != true)
            {
                    Add(key:  -1103004096, value:  13152256);
            }
            
            var val_11 = 23815926;
            val_11 = 11809612 + val_11;
            if(val_11 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_11 = null;
            val_11 = null;
            val_12 = 0;
            App.trackerManager.track(eventName:  -1103004192, data:  78753792);
            goto label_22;
            label_27:
            if(App.trackerManager <= val_12)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + 0;
            (0 + 0) + 16.Interactable = false;
            val_12 = 1;
            label_22:
            if(val_12 < ((0 + 0) + 16))
            {
                goto label_27;
            }
        
        }
        private void ShowResultScreen()
        {
            decimal val_1 = new System.Decimal(value:  999999999);
            string val_2 = RestaurantRivals.RESGameEconHelper.FormatNumberWithLimit(num:  new System.Decimal() {flags = this.coinsRaided, hi = R7, lo = R8, mid = SB}, numLimit:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.flags});
            string val_3 = System.String.Format(format:  612901520, arg0:  this.opponent.name);
            this.HideTopUI();
            this.HidePickerUI();
            this.ShowRewardUI();
            this.confetti.Play();
        }
        private void OnExitScreenClicked()
        {
            this.HideRewardUI();
            this.buttonRewardNext.interactable = false;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            BackButtonPressed();
        }
        private void CheckShowFtux()
        {
            bool val_9;
            var val_10;
            var val_11;
            val_9 = static_value_021FC706;
            if(val_9 != true)
            {
                    val_9 = true;
            }
            
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            if((MonoExtensions.IsBitSet(value:  268435456, bit:  8)) == false)
            {
                    return;
            }
            
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            if((val_2 + 292) > 17)
            {
                    return;
            }
            
            Player val_4 = App.Player;
            0.SaveState();
            this.ftuxRoot.SetActive(value:  true);
            if(this.pickedRaidSpots != 0)
            {
                    val_10 = this.pickedRaidSpots;
                val_11 = UnityEngine.Random.Range(min:  0, max:  1);
            }
            else
            {
                    val_10 = 12;
                val_11 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            
            if(val_10 <= val_11)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + (val_11 << 2);
            this.ftuxHighlightedObject = (0 + (val_6) << 2) + 16;
            this.ftuxTooltip.SetActive(value:  false);
            DG.Tweening.TweenCallback val_7 = new DG.Tweening.TweenCallback(object:  613199792, method:  new IntPtr(613174768));
            DG.Tweening.Tween val_8 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1028443341, ignoreTimeScale:  false);
        }
        public RESRaidScreenMain()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.pickedRaidSpots = null;
        }
        private static RESRaidScreenMain()
        {
            RestaurantRivals.RESRaidScreenMain.isPerfectRaid = true;
        }
        private void <ShowTopUI>b__50_0()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            MoveOpponentAvatarPosTo(targetPos:  this.opponentAvatarPos);
        }
        private void <ShowTopUI>b__50_1()
        {
            UnityEngine.GameObject val_1 = this.opponentAvatarPos.gameObject;
            this.opponentAvatarPos.SetActive(value:  true);
        }
        private void <ShowRewardUI>b__53_0()
        {
            UnityEngine.Transform val_1 = this.multiplierUIScale.transform;
            UnityEngine.Transform val_2 = this.rewardMessageCoins.transform;
            this.multiplierUIScale.SetParent(p:  this.rewardMessageCoins);
        }
        private void <ShowRewardUI>b__53_1()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_2 = SpinBet;
            decimal val_3 = System.Decimal.op_Implicit(value:  613910940);
            decimal val_4 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 613910924, hi = this.coinsRaided, lo = 35637002, mid = SL}, d2:  new System.Decimal() {flags = ???});
            decimal val_5 = new System.Decimal(value:  999999999);
            string val_6 = RestaurantRivals.RESGameEconHelper.FormatNumberWithLimit(num:  new System.Decimal(), numLimit:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.flags});
            if(this.rewardMessageCoins != 0)
            {
                    return;
            }
        
        }
        private void <ShowRestaurantWindow>b__55_0()
        {
            this.restaurant.SetActive(value:  true);
            this.bottomUI.SetActive(value:  true);
            this.CheckShowFtux();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_1C + 40.SetActive(value:  true);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            DG.Tweening.TweenCallback val_4 = new DG.Tweening.TweenCallback(object:  614056496, method:  new IntPtr(614023280));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.subtitleScale, endValue:  null, duration:  null, snapping:  true);
            object val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.subtitleScale, ease:  27);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.subtitleScale);
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(SpinBet >= 2)
            {
                    DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.topMultiplierScale, endValue:  null, duration:  null, snapping:  false);
                DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.topMultiplierScale);
            }
            
            System.Collections.IEnumerator val_13 = this.ShowPickedRaidSpots();
            UnityEngine.Coroutine val_14 = this.StartCoroutine(routine:  614056496);
        }
        private void <ShowRestaurantWindow>b__55_1()
        {
            UnityEngine.GameObject val_1 = this.subtitleScale.gameObject;
            this.subtitleScale.SetActive(value:  true);
            UnityEngine.GameObject val_2 = this.topMultiplierScale.gameObject;
            this.topMultiplierScale.SetActive(value:  true);
        }
        private void <CheckShowFtux>b__65_0()
        {
            UnityEngine.Transform val_1 = this.ftuxRoot.transform;
            UnityEngine.Transform val_2 = this.ftuxHighlightedObject.transform;
            this.ftuxRoot.SetParent(p:  this.ftuxHighlightedObject);
            UnityEngine.Transform val_3 = this.ftuxRoot.transform;
            UnityEngine.Transform val_4 = this.ftuxHighlightedObject.transform;
            this.ftuxRoot.SetSiblingIndex(index:  this.ftuxHighlightedObject.childCount - 1);
            this.ftuxTooltip.SetActive(value:  true);
            UnityEngine.Transform val_7 = this.ftuxRoot.transform;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            this.ftuxRoot.localPosition = new UnityEngine.Vector3();
            UnityEngine.Transform val_9 = this.ftuxTooltip.transform;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            this.ftuxTooltip.localPosition = new UnityEngine.Vector3();
            UnityEngine.Transform val_11 = this.ftuxTooltip.transform;
            DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.ftuxTooltip, endValue:  val_10.x, duration:  val_10.y);
            object val_13 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.ftuxTooltip, loops:  0, loopType:  1);
        }
    
    }

}
