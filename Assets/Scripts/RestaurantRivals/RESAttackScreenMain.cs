using UnityEngine;

namespace RestaurantRivals
{
    public class RESAttackScreenMain : MonoSingleton<RestaurantRivals.RESAttackScreenMain>
    {
        // Fields
        private UnityEngine.GameObject rootScale;
        private UnityEngine.RectTransform restaurantContainer;
        private UnityEngine.RectTransform adsArea;
        private UnityEngine.UI.Button buttonRevenge;
        public UnityEngine.GameObject topUI;
        public UnityEngine.GameObject RevengeBtnGo;
        private UnityEngine.RectTransform attackSpotContainer;
        private UnityEngine.RectTransform topUIScale;
        private UnityEngine.RectTransform bottomUIScale;
        private UnityEngine.RectTransform conclusionUIScale;
        private UnityEngine.RectTransform multiplierUIScale;
        private UnityEngine.RectTransform topMultiplierUIScale;
        private UnityEngine.UI.Image opponentAvatarImage;
        private UnityEngine.UI.Text restaurantLabel;
        private UnityEngine.UI.Button prefabButtonAttackSpot;
        private UnityEngine.UI.Image attackBg;
        private AttackStartLightning attackStartLightning;
        private RESAttackExplosionEffects attackExplosionEffects;
        private UnityEngine.GameObject blockShield;
        private UnityEngine.Transform hammerTransform;
        private UnityEngine.GameObject successGroup;
        private UnityEngine.UI.Text successMessageOpponent;
        private UnityEngine.UI.Text successMessageCoins;
        private UnityEngine.GameObject blockedGroup;
        private UnityEngine.UI.Text blockedMessageOpponent;
        private UnityEngine.UI.Text blockedMessageCoins;
        private UnityEngine.UI.Button buttonRewardNext;
        private UnityEngine.UI.Text multiplierLabel;
        private UnityEngine.UI.Text topMultiplierLabel;
        private UnityEngine.AnimationCurve rewardCoinCurve;
        private UnityEngine.GameObject ftuxRoot;
        private UnityEngine.GameObject ftuxTooltip;
        private UnityEngine.UI.Button ftuxHighlightedObject;
        private RestaurantRivals.UserRestaurantProfile opponent;
        private RestaurantRivals.RESAttackScreenMain.AttackOpponentType opponentType;
        private RestaurantRivals.RESRestaurantContent restaurantContent;
        private System.Collections.Generic.List<UnityEngine.UI.Button> buttonAttackSpots;
        private System.Collections.Generic.List<DG.Tweening.Tween> buttonAttackSpotsIdleSeq;
        private RestaurantRivals.UserRestaurantProfile initialRandomOpponent;
        private bool isSuccessful;
        private decimal rawCoinsRewarded;
        private bool isFirstAttackFTUX;
        private bool isSecondAttackFTUX;
        
        // Properties
        private RestaurantRivals.RESPlayer player { get; }
        private UnityEngine.UI.Text conclusionMessageCoins { get; }
        public RestaurantRivals.UserRestaurantProfile CurrentOponent { get; }
        
        // Methods
        private RestaurantRivals.RESPlayer get_player()
        {
            return RestaurantRivals.RESPlayer.Instance;
        }
        private UnityEngine.UI.Text get_conclusionMessageCoins()
        {
            if(this.isSuccessful == false)
            {
                    100 = 112;
            }
        
        }
        public RestaurantRivals.UserRestaurantProfile get_CurrentOponent()
        {
        
        }
        private void OnAttackSpotClicked(int treeId)
        {
            this.HideTopUI();
            this.buttonRevenge.interactable = false;
            this.ftuxRoot.SetActive(value:  false);
            this.EndAttack(restaurantId:  treeId);
        }
        private void OnRevengeButtonClicked()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  519762432, method:  new IntPtr(519736384));
            GetRevengeOpponentPool(onRevengeListRetrieved:  7401472);
        }
        private void Start()
        {
            bool val_12;
            bool val_13;
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  519896960, method:  new IntPtr(519858624));
            this.buttonRevenge.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  519896960, method:  new IntPtr(519867840));
            val_12 = 0;
            this.buttonRewardNext.m_OnClick.AddListener(call:  162246656);
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            if((MonoExtensions.IsBitSet(value:  6, bit:  6)) != false)
            {
                    RestaurantRivals.RESPlayer val_5 = RestaurantRivals.RESPlayer.Instance;
                val_12 = (MonoExtensions.IsBitSet(value:  6, bit:  7)) ^ 1;
            }
            
            this.isFirstAttackFTUX = val_12;
            val_13 = 0;
            RestaurantRivals.RESPlayer val_7 = RestaurantRivals.RESPlayer.Instance;
            if((MonoExtensions.IsBitSet(value:  6, bit:  7)) != false)
            {
                    val_13 = RestaurantRivals.RESManager.IsGameStartFtuxFinished ^ 1;
            }
            
            this.isSecondAttackFTUX = val_13;
            this.ShowUserRestaurant(targetRestaurant:  0, opponType:  0);
            this.rootScale.SetActive(value:  false);
        }
        private void OnEnable()
        {
            var val_6;
            UnityEngine.Vector2 val_1 = pivot;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_1.x, y:  val_1.y);
            this.topUIScale.pivot = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            twelvegigs.Autopilot.WUTAutopilotGameplay val_4 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  this.topUIScale);
            this.topUIScale.alpha = val_1.x;
            UnityEngine.Vector2 val_5 = anchoredPosition;
            val_6 = 0;
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_5.x, y:  val_5.y);
            this.bottomUIScale.anchoredPosition = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            UnityEngine.Vector2 val_8 = anchoredPosition;
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_8.x, y:  val_8.y);
            this.conclusionUIScale.anchoredPosition = new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
            UnityEngine.Vector2 val_11 = anchoredPosition;
            UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_11.x, y:  val_11.y);
            this.multiplierUIScale.anchoredPosition = new UnityEngine.Vector2() {x = val_13.x, y = val_13.y};
            UnityEngine.Vector2 val_14 = anchoredPosition;
            UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  val_14.x, y:  val_14.y);
            this.topMultiplierUIScale.anchoredPosition = new UnityEngine.Vector2() {x = val_16.x, y = val_16.y};
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_18 = SpinBet;
            string val_19 = 520034112 + 13152256;
            UnityEngine.GameObject val_20 = this.topMultiplierUIScale.gameObject;
            twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(SpinBet > 1)
            {
                    0 = 1;
            }
            
            this.topMultiplierUIScale.SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_24 = SpinBet;
            string val_25 = 520034112 + 13152256;
            System.Collections.IEnumerator val_26 = this.ShowStartUI();
            UnityEngine.Coroutine val_27 = this.StartCoroutine(routine:  520070480);
            twelvegigs.Autopilot.AutopilotManager val_28 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(2124183120 == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_30 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_31 = GetBannerAdHeight();
            UnityEngine.GameObject val_32 = this.adsArea.gameObject;
            if(this.adsArea > 0)
            {
                    0 = 1;
            }
            
            this.adsArea.SetActive(value:  true);
        }
        public void ShowUserRestaurant(RestaurantRivals.UserRestaurantProfile targetRestaurant, RestaurantRivals.RESAttackScreenMain.AttackOpponentType opponType = 0)
        {
            RestaurantRivals.UserRestaurantProfile val_9;
            this.Clear();
            this.opponentType = opponType;
            if(targetRestaurant != 0)
            {
                    this.opponent = targetRestaurant;
            }
            else
            {
                    val_9 = this.initialRandomOpponent;
                if(val_9 == 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_9 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance();
                RestaurantRivals.UserRestaurantProfile val_2 = GetAttackRandomOpponent();
                this.initialRandomOpponent = val_9;
            }
            
                this.opponent = val_9;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            RestaurantRivals.RESRestaurantContent val_4 = GetRestaurantLayout(forestId:  this.opponent.level);
            object val_5 = UnityEngine.Object.Instantiate<System.Object>(original:  -732109616, parent:  this.restaurantContainer);
            this.restaurantContent = public static RestaurantRivals.RESRestaurantManager MonoSingleton<RestaurantRivals.RESRestaurantManager>::get_Instance();
            Initialize(restaurantMap:  this.opponent.map);
            string val_6 = this.opponent.name + 520237328;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Sprite val_8 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C.GetAvatarSpriteByID(id:  this.opponent.avatarId);
            this.opponentAvatarImage.sprite = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C;
            this.InitializeAttackSpots();
        }
        public bool IsCurrentOpponent(RestaurantRivals.UserRestaurantProfile profile)
        {
            if(profile != 0)
            {
                    this = this.opponent;
            }
            
            if(this != 0)
            {
                    0 = profile.serverId;
                profile = this.opponent.serverId;
                0 = profile - 0;
            }
            
            if(this != 0)
            {
                    0 = 0 >> 5;
            }
            
            return (bool)0;
        }
        private System.Collections.IEnumerator ShowStartUI()
        {
            object val_1 = new System.Object();
            typeof(RESAttackScreenMain.<ShowStartUI>d__56).__il2cppRuntimeField_8 = 0;
            typeof(RESAttackScreenMain.<ShowStartUI>d__56).__il2cppRuntimeField_10 = this;
        }
        public System.Collections.IEnumerator ShowAttackSpots(float delay)
        {
            typeof(RESAttackScreenMain.<ShowAttackSpots>d__57).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(RESAttackScreenMain.<ShowAttackSpots>d__57).__il2cppRuntimeField_14 = this;
            }
            else
            {
                    mem[20] = this;
            }
            
            typeof(RESAttackScreenMain.<ShowAttackSpots>d__57).__il2cppRuntimeField_10 = R1;
        }
        private void ShowTopUI()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOPivotY(target:  this.topUIScale, endValue:  null, duration:  null);
            DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  520800544, method:  new IntPtr(520767328));
            object val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.topUIScale, action:  190734336);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.topUIScale);
            twelvegigs.Autopilot.WUTAutopilotGameplay val_6 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  this.topUIScale);
            DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.topUIScale, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.topUIScale);
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(SpinBet < 2)
            {
                    return;
            }
            
            DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.topMultiplierUIScale, endValue:  null, duration:  null, snapping:  false);
            object val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.topMultiplierUIScale, ease:  27);
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.topMultiplierUIScale);
        }
        private void HideTopUI()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOPivotY(target:  this.topUIScale, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.topUIScale);
            twelvegigs.Autopilot.WUTAutopilotGameplay val_4 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  this.topUIScale);
            DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.topUIScale, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.topUIScale);
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(SpinBet < 2)
            {
                    return;
            }
            
            DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.topMultiplierUIScale, endValue:  null, duration:  null, snapping:  false);
            object val_10 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.topMultiplierUIScale, ease:  26);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.topMultiplierUIScale);
        }
        private void ShowRewardUI()
        {
            DG.Tweening.TweenCallback val_22;
            var val_23;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.conclusionUIScale, endValue:  null, duration:  null, snapping:  false);
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.conclusionUIScale);
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_22 = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance();
            val_23 = 0;
            if(SpinBet < 2)
            {
                    return;
            }
            
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.multiplierUIScale, endValue:  null, duration:  null, snapping:  false);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.multiplierUIScale);
            DG.Tweening.TweenCallback val_8 = new DG.Tweening.TweenCallback(object:  521088032, method:  new IntPtr(521045600));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  null, y:  null);
            val_23 = 16025;
            val_23 = 1050253722;
            DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.multiplierUIScale, endValue:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, duration:  null, snapping:  true);
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.multiplierUIScale);
            DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.multiplierUIScale, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.multiplierUIScale);
            if(this.isSuccessful == false)
            {
                    100 = 112;
            }
            
            UnityEngine.Transform val_16 = this.blockedMessageCoins.transform;
            DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.blockedMessageCoins, endValue:  null, duration:  null);
            object val_18 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.blockedMessageCoins, animCurve:  this.rewardCoinCurve);
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.blockedMessageCoins);
            val_22 = null;
            val_22 = new DG.Tweening.TweenCallback(object:  521088032, method:  new IntPtr(521063008));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  0, atPosition:  null, callback:  1067030938);
        }
        private void HideRewardUI()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.conclusionUIScale, endValue:  null, duration:  null, snapping:  false);
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.conclusionUIScale);
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.multiplierUIScale, endValue:  null, duration:  null, snapping:  false);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.multiplierUIScale);
        }
        private void Clear()
        {
            DG.Tweening.Tween val_3;
            UnityEngine.Object val_6;
            if(this.buttonAttackSpotsIdleSeq == 0)
            {
                goto label_1;
            }
            
            List.Enumerator<T> val_1 = GetEnumerator();
            label_3:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  val_3, complete:  false);
            goto label_3;
            label_2:
            Dispose();
            label_1:
            if(this.buttonAttackSpots == 0)
            {
                goto label_4;
            }
            
            List.Enumerator<T> val_4 = GetEnumerator();
            label_9:
            if(MoveNext() == false)
            {
                goto label_5;
            }
            
            UnityEngine.GameObject val_7 = val_6.gameObject;
            UnityEngine.Object.Destroy(obj:  val_6);
            goto label_9;
            label_5:
            Dispose();
            label_4:
            if(this.restaurantContent == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_9 = this.restaurantContent.gameObject;
            UnityEngine.Object.Destroy(obj:  this.restaurantContent);
        }
        private void InitializeAttackSpots()
        {
            RestaurantRivals.RESAttackScreenMain val_13;
            var val_14;
            UnityEngine.Transform val_15;
            var val_16;
            val_13 = this;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.buttonAttackSpots = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.buttonAttackSpotsIdleSeq = null;
            val_14 = 4;
            goto label_1;
            label_30:
            object val_3 = new System.Object();
            typeof(RESAttackScreenMain.<>c__DisplayClass63_0).__il2cppRuntimeField_C = val_13;
            RestaurantRivals.RESRestaurantObject val_13 = this.restaurantContent.objects[0];
            if(this.restaurantContent.objects[0].objectState != 1)
            {
                goto label_7;
            }
            
            typeof(RESAttackScreenMain.<>c__DisplayClass63_0).__il2cppRuntimeField_8 = ???;
            object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  this.prefabButtonAttackSpot, parent:  this.attackSpotContainer);
            RestaurantRivals.RESRestaurantObject val_14 = this.restaurantContent.objects[0];
            var val_15 = val_14;
            val_15 = this.restaurantContent.objects[0].origin;
            if(val_15 == 0)
            {
                goto label_14;
            }
            
            val_16 = 0;
            if(null == null)
            {
                goto label_16;
            }
            
            val_15 = 0;
            goto label_16;
            label_14:
            val_15 = 0;
            val_16 = 0;
            label_16:
            UnityEngine.Transform val_5 = this.prefabButtonAttackSpot.transform;
            UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            UnityEngine.Vector3 val_7 = TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_6.x, z = val_6.y});
            this.prefabButtonAttackSpot.position = new UnityEngine.Vector3();
            val_13 = val_13;
            UnityEngine.Transform val_8 = this.prefabButtonAttackSpot.transform;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 3.206931E-20f}, d:  val_9.x);
            this.prefabButtonAttackSpot.localScale = new UnityEngine.Vector3();
            UnityEngine.Events.UnityAction val_11 = new UnityEngine.Events.UnityAction(object:  423108608, method:  new IntPtr(521580256));
            this.prefabButtonAttackSpot.m_OnClick.AddListener(call:  162246656);
            UnityEngine.GameObject val_12 = this.prefabButtonAttackSpot.gameObject;
            this.prefabButtonAttackSpot.SetActive(value:  false);
            Add(item:  this.prefabButtonAttackSpot);
            label_7:
            val_14 = val_15 + 1;
            label_1:
            val_15 = val_14 - 4;
            if(val_15 < this.buttonAttackSpots)
            {
                goto label_30;
            }
        
        }
        private void EndAttack(int restaurantId)
        {
            float val_12;
            float val_13;
            float val_14;
            float val_57;
            var val_58;
            var val_59;
            float val_60;
            var val_61;
            DG.Tweening.TweenCallback val_62;
            var val_63;
            object val_1 = new System.Object();
            typeof(RESAttackScreenMain.<>c__DisplayClass64_0).__il2cppRuntimeField_8 = this;
            typeof(RESAttackScreenMain.<>c__DisplayClass64_0).__il2cppRuntimeField_C = this.restaurantContent.objects[restaurantId];
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.isSuccessful = DoAttackAction();
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_7 = SpinBet;
            decimal val_8 = System.Decimal.op_Implicit(value:  522002184);
            decimal val_9 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 522002168, hi = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 64, lo = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 68, mid = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 72}, d2:  new System.Decimal() {flags = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 76});
            UnityEngine.Transform val_10 = this.attackExplosionEffects.transform;
            if(this.isSuccessful == false)
            {
                goto label_15;
            }
            
            if((this.restaurantContent.objects[restaurantId][0] + 12) != 0)
            {
                goto label_63;
            }
            
            label_64:
            label_63:
            UnityEngine.Vector3 val_11 = position;
            this.attackExplosionEffects.position = new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14};
            System.Collections.Hashtable val_15 = new System.Collections.Hashtable();
            twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_14.RemoveRevengeOpponent(profile:  this.opponent);
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_1C.Notify(note:  4, data:  75878400);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_18 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if(this.opponent.IsDummyAccount != true)
            {
                    val_12 = this.opponent.serverId;
                Add(key:  245781168, value:  13152256);
            }
            
            val_12 = this.isSuccessful;
            Add(key:  245717456, value:  8945664);
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem2[0] = ;
            Add(key:  1297334992, value:  422948864);
            var val_59 = 25105322;
            val_59 = 10520216 + val_59;
            if(val_59 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_58 = null;
            val_58 = null;
            App.trackerManager.track(eventName:  245717568, data:  78753792);
            val_59 = 4;
            val_60 = 1152921509932985248;
            goto label_40;
            label_55:
            if(App.trackerManager <= val_59)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            2621443.interactable = false;
            if(val_59 < 2621443)
            {
                    if(2621443 <= val_59)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(2621443 != 0)
            {
                    if(2621443 <= val_59)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                DG.Tweening.TweenExtensions.Kill(t:  2621443, complete:  false);
            }
            
            }
            
            if(2621443 <= val_59)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.Transform val_20 = 2621443.transform;
            float val_21 = UnityEngine.Random.Range(min:  val_11.x, max:  val_11.y);
            val_57 = 1065353216 * 0.1f;
            DG.Tweening.Tweener val_22 = DG.Tweening.ShortcutExtensions.DOScale(target:  2621443, endValue:  val_57, duration:  val_11.y);
            object val_23 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  2621443, ease:  26);
            val_59 = 5;
            label_40:
            if((val_59 - 4) < 2621443)
            {
                goto label_55;
            }
            
            UnityEngine.GameObject val_25 = this.attackBg.gameObject;
            val_61 = 0;
            this.attackBg.SetActive(value:  true);
            PluginExtension.SetColorAlpha(graphic:  this.attackBg, a:  val_57);
            DG.Tweening.Tweener val_26 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.attackBg, endValue:  val_57, duration:  val_11.y);
            DG.Tweening.Sequence val_27 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.TweenCallback val_28 = new DG.Tweening.TweenCallback(object:  423161856, method:  new IntPtr(521971808));
            DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_57);
            DG.Tweening.TweenCallback val_31 = new DG.Tweening.TweenCallback(object:  423161856, method:  new IntPtr(521972832));
            DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_57);
            DG.Tweening.TweenCallback val_34 = new DG.Tweening.TweenCallback(object:  423161856, method:  new IntPtr(521973856));
            DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_57);
            val_13 = val_61;
            val_12 = val_61;
            val_14 = val_61;
            UnityEngine.Vector3 val_37 = new UnityEngine.Vector3(x:  val_57, y:  val_11.y, z:  val_11.z);
            DG.Tweening.Tweener val_38 = DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  this.hammerTransform, endValue:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, duration:  val_57, mode:  1040522936);
            object val_39 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.hammerTransform, ease:  6);
            DG.Tweening.Sequence val_40 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.hammerTransform);
            DG.Tweening.TweenCallback val_41 = new DG.Tweening.TweenCallback(object:  423161856, method:  new IntPtr(521978976));
            DG.Tweening.Sequence val_42 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.TweenCallback val_43 = new DG.Tweening.TweenCallback(object:  423161856, method:  new IntPtr(521980000));
            DG.Tweening.Sequence val_44 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            if(this.isSuccessful == false)
            {
                goto label_60;
            }
            
            DG.Tweening.Sequence val_45 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_57);
            val_62 = null;
            val_62 = new DG.Tweening.TweenCallback(object:  423161856, method:  new IntPtr(521981024));
            goto label_67;
            label_15:
            UnityEngine.Transform val_47 = this.blockShield.transform;
            if(this.blockShield != 0)
            {
                goto label_63;
            }
            
            goto label_64;
            label_60:
            DG.Tweening.TweenCallback val_48 = new DG.Tweening.TweenCallback(object:  423161856, method:  new IntPtr(521986144));
            DG.Tweening.Sequence val_49 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Sequence val_50 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_57);
            val_60 = 1152921505030062080;
            val_63 = null;
            val_63 = null;
            val_62 = RESAttackScreenMain.<>c.<>9__64_7;
            if(val_62 == 0)
            {
                    val_62 = null;
                val_62 = new DG.Tweening.TweenCallback(object:  RESAttackScreenMain.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(521987168));
                RESAttackScreenMain.<>c.<>9__64_7 = val_62;
            }
            
            label_67:
            DG.Tweening.Sequence val_52 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Sequence val_53 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_57);
            DG.Tweening.TweenCallback val_54 = new DG.Tweening.TweenCallback(object:  423161856, method:  new IntPtr(521988192));
            DG.Tweening.Sequence val_55 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.TweenCallback val_56 = new DG.Tweening.TweenCallback(object:  522014240, method:  new IntPtr(521989216));
            object val_57 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        }
        private void ShowResultScreen()
        {
            UnityEngine.UI.Text val_11;
            decimal val_12;
            decimal val_15;
            int val_16;
            int val_17;
            UnityEngine.GameObject val_1 = this.successGroup.gameObject;
            if(this.isSuccessful != false)
            {
                    this.successGroup.SetActive(value:  true);
                UnityEngine.GameObject val_2 = this.blockedGroup.gameObject;
                this.blockedGroup.SetActive(value:  false);
                string val_3 = System.String.Format(format:  522225120, arg0:  this.opponent.name);
                val_11 = this.successMessageCoins;
                val_12 = this.rawCoinsRewarded;
                decimal val_4 = new System.Decimal(value:  999999999);
                val_16 = R5;
                val_17 = val_12;
            }
            else
            {
                    this.successGroup.SetActive(value:  false);
                UnityEngine.GameObject val_5 = this.blockedGroup.gameObject;
                this.blockedGroup.SetActive(value:  true);
                string val_6 = System.String.Format(format:  522245712, arg0:  this.opponent.name);
                val_11 = this.blockedMessageCoins;
                val_15 = this.rawCoinsRewarded;
                decimal val_7 = new System.Decimal(value:  999999999);
                val_16 = R7;
                val_17 = val_15;
            }
            
            string val_8 = RestaurantRivals.RESGameEconHelper.FormatNumberWithLimit(num:  new System.Decimal() {flags = val_17, hi = val_16, lo = SB, mid = SL}, numLimit:  new System.Decimal() {flags = val_7.flags, hi = val_7.hi, lo = val_7.lo, mid = val_7.flags});
            string val_9 = System.String.Format(format:  522254016, arg0:  val_17);
            DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.bottomUIScale, endValue:  null, duration:  null, snapping:  false);
            this.ShowRewardUI();
        }
        private void OnExitScreenClicked()
        {
            this.buttonRewardNext.interactable = false;
            this.HideRewardUI();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            BackButtonPressed();
        }
        private void CheckShowFtux()
        {
            var val_8;
            var val_9;
            var val_11;
            System.Action<System.Collections.Generic.List<RestaurantRivals.UserRestaurantProfile>> val_13;
            if(this.isFirstAttackFTUX == false)
            {
                    this.isFirstAttackFTUX = this.isSecondAttackFTUX;
                goto label_7;
            }
            
            this.ftuxRoot.SetActive(value:  true);
            if(this.buttonAttackSpots != 0)
            {
                    val_8 = this.buttonAttackSpots;
                val_9 = UnityEngine.Random.Range(min:  0, max:  1);
            }
            else
            {
                    val_8 = 12;
                val_9 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            
            if(val_8 <= val_9)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + (val_9 << 2);
            this.ftuxHighlightedObject = (0 + (val_2) << 2) + 16;
            this.ftuxTooltip.SetActive(value:  false);
            DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  522578944, method:  new IntPtr(522552896));
            DG.Tweening.Tween val_4 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1028443341, ignoreTimeScale:  false);
            if(this.isFirstAttackFTUX != false)
            {
                    return;
            }
            
            label_7:
            RestaurantRivals.RESPlayer val_5 = RestaurantRivals.RESPlayer.Instance;
            if(8 != 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_11 = null;
            val_11 = null;
            val_13 = RESAttackScreenMain.<>c.<>9__67_1;
            if(val_13 == 0)
            {
                    val_13 = null;
                val_13 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  RESAttackScreenMain.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(522553920));
                RESAttackScreenMain.<>c.<>9__67_1 = val_13;
            }
            
            GetRevengeOpponentPool(onRevengeListRetrieved:  7401472);
        }
        public RESAttackScreenMain()
        {
        
        }
        private void <OnRevengeButtonClicked>b__51_0(System.Collections.Generic.List<RestaurantRivals.UserRestaurantProfile> revengeList)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType == 15) && (RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType >= 1))
            {
                    val_4 = null;
                val_4 = null;
                RestaurantRivals.RESFTUXManager.slotPlayDemoPopup.OnNonSequencyFTUXUsed();
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
            Initialize(randomUser:  this.initialRandomOpponent, revengeUserList:  revengeList);
        }
        private void <ShowStartUI>b__56_0()
        {
            this.rootScale.SetActive(value:  true);
        }
        private void <ShowTopUI>b__58_0()
        {
            this.CheckShowFtux();
        }
        private void <ShowRewardUI>b__60_0()
        {
            UnityEngine.Transform val_1 = this.multiplierUIScale.transform;
            if(this.isSuccessful == false)
            {
                    100 = 112;
            }
            
            UnityEngine.Transform val_2 = this.blockedMessageCoins.transform;
            this.multiplierUIScale.SetParent(p:  this.blockedMessageCoins);
        }
        private void <ShowRewardUI>b__60_1()
        {
            if(this.isSuccessful == false)
            {
                    100 = 112;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_2 = SpinBet;
            decimal val_3 = System.Decimal.op_Implicit(value:  523298284);
            decimal val_4 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 523298268, hi = this.rawCoinsRewarded, lo = SB, mid = R7}, d2:  new System.Decimal() {flags = ???});
            decimal val_5 = new System.Decimal(value:  999999999);
            string val_6 = RestaurantRivals.RESGameEconHelper.FormatNumberWithLimit(num:  new System.Decimal(), numLimit:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.flags});
            if(this.blockedMessageCoins != 0)
            {
                    return;
            }
        
        }
        private void <CheckShowFtux>b__67_0()
        {
            UnityEngine.Transform val_1 = this.ftuxHighlightedObject.transform;
            UnityEngine.Transform val_2 = this.ftuxRoot.transform;
            this.ftuxHighlightedObject.SetParent(p:  this.ftuxRoot);
            UnityEngine.Transform val_3 = this.ftuxHighlightedObject.transform;
            UnityEngine.Transform val_4 = this.ftuxRoot.transform;
            this.ftuxHighlightedObject.SetSiblingIndex(index:  this.ftuxRoot.childCount - 2);
            this.ftuxTooltip.SetActive(value:  true);
            UnityEngine.Transform val_7 = this.ftuxTooltip.transform;
            UnityEngine.Transform val_8 = this.ftuxHighlightedObject.transform;
            UnityEngine.Vector3 val_9 = position;
            this.ftuxTooltip.position = new UnityEngine.Vector3();
            UnityEngine.Transform val_10 = this.ftuxTooltip.transform;
            DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.ftuxTooltip, endValue:  val_9.x, duration:  val_9.y);
            object val_12 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.ftuxTooltip, loops:  0, loopType:  1);
        }
    
    }

}
