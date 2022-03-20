using UnityEngine;

namespace WordForest
{
    public class RaidScreenMain : MonoSingleton<WordForest.RaidScreenMain>
    {
        // Fields
        private const int MAX_PICK_CHANCES = 3;
        private UnityEngine.RectTransform forestContainer;
        private UnityEngine.RectTransform adsArea;
        private UnityEngine.CanvasGroup uiStatePicking;
        private UnityEngine.CanvasGroup uiStateReward;
        private System.Collections.Generic.List<UnityEngine.UI.Image> pickerIconList;
        private UnityEngine.UI.Image opponentAvatarImage;
        private UnityEngine.UI.Text forestLabel;
        private UnityEngine.UI.Text subtitleLabel;
        private WordForest.WFODigAnimation digAnimation;
        private UnityEngine.GameObject prefabSpotResultLabel;
        private UnityEngine.ParticleSystem prefabEfxAcornSpring;
        private UnityEngine.GameObject perfectBanner;
        private UnityEngine.UI.Text rewardBodyLabel;
        private UnityEngine.UI.Button buttonRewardOkay;
        private UnityEngine.GameObject ftuxRoot;
        private UnityEngine.UI.Button ftuxButtonClose;
        private FtuxTooltip ftuxTooltip;
        private UnityEngine.UI.Text ftuxText;
        private UnityEngine.GameObject ftuxCursorPrefab;
        private WordForest.UserForestProfile opponent;
        private System.Collections.Generic.List<int> chosenRewardIndexes;
        private int acornsRaided;
        private bool isPerfectRaid;
        private int spotsRaided;
        private bool areRaidSpotsInteractable;
        private WordForest.WFOForestContent forestContent;
        private bool isFtux;
        private System.Collections.Generic.List<UnityEngine.GameObject> ftuxCursors;
        private UnityEngine.Coroutine ftuxCoroutine;
        
        // Properties
        private System.Collections.Generic.List<int> pickerRewards { get; }
        
        // Methods
        private System.Collections.Generic.List<int> get_pickerRewards()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance()) != 0)
            {
                    return;
            }
        
        }
        private void Start()
        {
            int val_11;
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  266491632, method:  new IntPtr(266445104));
            this.buttonRewardOkay.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  266491632, method:  new IntPtr(266454320));
            this.ftuxButtonClose.m_OnClick.AddListener(call:  162246656);
            UnityEngine.GameObject val_3 = this.digAnimation.gameObject;
            this.digAnimation.SetActive(value:  false);
            UnityEngine.GameObject val_4 = this.prefabSpotResultLabel.gameObject;
            this.prefabSpotResultLabel.SetActive(value:  false);
            UnityEngine.GameObject val_5 = this.prefabEfxAcornSpring.gameObject;
            val_11 = 0;
            this.prefabEfxAcornSpring.SetActive(value:  false);
            WordForest.WFOPlayer val_6 = WordForest.WFOPlayer.Instance;
            bool val_7 = MonoExtensions.IsBitSet(value:  132, bit:  9);
            this.isFtux = val_7 ^ 1;
            if(val_7 != true)
            {
                    WordForest.WFOGameEcon val_9 = WordForest.WFOGameEcon.Instance;
                val_11 = 18.Item[9];
            }
            
            this.Initialize(initDestroyedTrees:  val_11);
            this.CheckShowFtux();
        }
        private void OnEnable()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(2124183120 == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_4 = GetBannerAdHeight();
            UnityEngine.GameObject val_5 = this.adsArea.gameObject;
            if(this.adsArea > 0)
            {
                    0 = 1;
            }
            
            this.adsArea.SetActive(value:  true);
        }
        private void Initialize(int initDestroyedTrees)
        {
            WordForest.Map val_13;
            WordForest.WFOForestContent val_14;
            var val_15;
            int val_13 = initDestroyedTrees;
            this.BeginRaid();
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            this.isPerfectRaid = true;
            this.chosenRewardIndexes = null;
            this.RefreshOpponentLabel();
            this.RefreshSubtitle();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Sprite val_3 = public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_10.GetAvatarSpriteByID(id:  this.opponent.avatarId);
            this.opponentAvatarImage.sprite = public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_10;
            if(this.forestContent != 0)
            {
                    UnityEngine.GameObject val_5 = this.forestContent.gameObject;
                UnityEngine.Object.Destroy(obj:  this.forestContent);
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordForest.WFOForestContent val_7 = GetForestLayout(forestId:  this.opponent.level);
            object val_8 = UnityEngine.Object.Instantiate<System.Object>(original:  -1425082880, parent:  this.forestContainer);
            this.forestContent = public static WordForest.WFOForestManager MonoSingleton<WordForest.WFOForestManager>::get_Instance();
            val_13 = this.opponent.map;
            Initialize(forestMap:  val_13);
            val_14 = this.forestContent;
            val_14.ToggleRaidXSpots(isVisible:  true);
            if(val_13 < 1)
            {
                goto label_28;
            }
            
            RandomSet val_9 = null;
            val_14 = val_9;
            val_13 = 0;
            val_9 = new RandomSet();
            goto label_23;
            label_27:
            add(item:  0, weight:  null);
            val_13 = 1;
            label_23:
            if(val_13 < val_14)
            {
                goto label_27;
            }
            
            if(val_13 >= 1)
            {
                    do
            {
                val_13 = this.forestContent.trees[roll(unweighted:  false)];
                DG.Tweening.Sequence val_11 = val_13.SetGrowthState(state:  2, instant:  true, delayGrowth:  false, shadowParent:  0);
                val_13 = val_13 - 1;
            }
            while(val_13 != 0);
            
            }
            
            label_28:
            val_15 = 0;
            goto label_36;
            label_40:
            val_13 = null;
            val_13 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  266918384, method:  new IntPtr(266893360));
            1152921508137843376.Initialize(id:  0, onClicked:  7401472);
            val_15 = 1;
            label_36:
            if(val_15 < 1152921508137843376)
            {
                goto label_40;
            }
        
        }
        private void RefreshOpponentLabel()
        {
            bool val_4 = static_value_021FBC97;
            if(val_4 != true)
            {
                    val_4 = true;
            }
            
            System.Collections.Generic.List<System.Int32> val_1 = this.pickerRewards;
            int val_2 = System.Linq.Enumerable.Sum(source:  1);
            string val_3 = System.String.Format(format:  267182512, arg0:  this.opponent.name, arg1:  13152256);
            if(this.forestLabel != 0)
            {
                    return;
            }
        
        }
        private void RefreshSubtitle()
        {
            string val_1 = System.String.Format(format:  -1104433312, arg0:  13152256);
            if(this.subtitleLabel != 0)
            {
                    return;
            }
        
        }
        private void OnRaidXSpotClicked(WordForest.RaidXSpotButton spotButton)
        {
            System.Collections.Generic.List<System.Int32> val_60;
            int val_61;
            DG.Tweening.TweenCallback val_62;
            var val_63;
            var val_64;
            DG.Tweening.TweenCallback val_66;
            DG.Tweening.TweenCallback val_67;
            if(new System.Object() != 0)
            {
                    typeof(RaidScreenMain.<>c__DisplayClass37_0).__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[8] = this;
            }
            
            typeof(RaidScreenMain.<>c__DisplayClass37_0).__il2cppRuntimeField_C = spotButton;
            val_60 = this.chosenRewardIndexes;
            if(8 > 2)
            {
                    return;
            }
            
            if(this.areRaidSpotsInteractable == false)
            {
                    return;
            }
            
            spotButton + 12.interactable = false;
            this.areRaidSpotsInteractable = false;
            this.chosenRewardIndexes.Add(item:  spotButton + 20);
            System.Collections.Generic.List<System.Int32> val_2 = this.chosenRewardIndexes.pickerRewards;
            if(this.isFtux != false)
            {
                    val_61 = this.spotsRaided;
                this.spotsRaided = val_61 + 1;
            }
            else
            {
                    val_61 = mem[spotButton + 20];
                val_61 = spotButton + 20;
            }
            
            if(this.chosenRewardIndexes <= val_61)
            {
                    var val_60 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_60 = val_60 + (val_61 << 2);
            int val_61 = this.acornsRaided;
            val_61 = val_61 + ((0 + (spotButton + 20) << 2) + 16);
            if(((0 + (spotButton + 20) << 2) + 16) <= 0)
            {
                    (0 + (spotButton + 20) << 2) + 16 = false;
            }
            
            this.acornsRaided = val_61;
            if(((0 + (spotButton + 20) << 2) + 16) <= 0)
            {
                    this.isPerfectRaid = (0 + (spotButton + 20) << 2) + 16;
            }
            
            if(((0 + (spotButton + 20) << 2) + 16) >= 3)
            {
                    (0 + (spotButton + 20) << 2) + 16 = this;
                this.EndRaid();
            }
            
            System.Collections.Generic.List<UnityEngine.UI.Image> val_62 = this.pickerIconList;
            val_62 = val_62 - ((0 + (spotButton + 20) << 2) + 16);
            if((val_62 >= 0) && (val_62 < ((0 + (spotButton + 20) << 2) + 16)))
            {
                    if(((0 + (spotButton + 20) << 2) + 16) <= val_62)
            {
                    var val_63 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_63 = val_63 + (val_62 << 2);
                UnityEngine.Transform val_4 = (0 + ((this.pickerIconList - this)) << 2) + 16.transform;
                DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOScale(target:  (0 + ((this.pickerIconList - this)) << 2) + 16, endValue:  null, duration:  null);
                object val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  (0 + ((this.pickerIconList - this)) << 2) + 16, ease:  26);
            }
            
            UnityEngine.Transform val_7 = this.uiStatePicking.transform;
            object val_8 = UnityEngine.Object.Instantiate<System.Object>(original:  this.digAnimation, parent:  this.uiStatePicking);
            typeof(RaidScreenMain.<>c__DisplayClass37_0).__il2cppRuntimeField_10 = this.digAnimation;
            UnityEngine.Transform val_9 = this.digAnimation.transform;
            UnityEngine.Transform val_10 = typeof(RaidScreenMain.<>c__DisplayClass37_0).__il2cppRuntimeField_C.transform;
            UnityEngine.Vector3 val_11 = position;
            this.digAnimation.position = new UnityEngine.Vector3();
            UnityEngine.GameObject val_12 = typeof(RaidScreenMain.<>c__DisplayClass37_0).__il2cppRuntimeField_10.gameObject;
            typeof(RaidScreenMain.<>c__DisplayClass37_0).__il2cppRuntimeField_10.SetActive(value:  true);
            UnityEngine.Transform val_13 = this.uiStatePicking.transform;
            object val_14 = UnityEngine.Object.Instantiate<System.Object>(original:  this.prefabSpotResultLabel, parent:  this.uiStatePicking);
            UnityEngine.Transform val_15 = this.prefabSpotResultLabel.transform;
            UnityEngine.Transform val_16 = typeof(RaidScreenMain.<>c__DisplayClass37_0).__il2cppRuntimeField_C.transform;
            UnityEngine.Vector3 val_17 = position;
            this.prefabSpotResultLabel.position = new UnityEngine.Vector3();
            UnityEngine.Transform val_18 = this.prefabSpotResultLabel.transform;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.zero;
            this.prefabSpotResultLabel.localScale = new UnityEngine.Vector3();
            object val_20 = this.prefabSpotResultLabel.GetComponentInChildren<System.Object>();
            string val_21 = (0 + (spotButton + 20) << 2) + 16.ToString();
            this.prefabSpotResultLabel.SetActive(value:  true);
            UnityEngine.Transform val_22 = this.uiStatePicking.transform;
            object val_23 = UnityEngine.Object.Instantiate<System.Object>(original:  this.prefabEfxAcornSpring, parent:  this.uiStatePicking);
            typeof(RaidScreenMain.<>c__DisplayClass37_0).__il2cppRuntimeField_14 = this.prefabEfxAcornSpring;
            UnityEngine.Transform val_24 = this.prefabEfxAcornSpring.transform;
            UnityEngine.Transform val_25 = typeof(RaidScreenMain.<>c__DisplayClass37_0).__il2cppRuntimeField_C.transform;
            UnityEngine.Vector3 val_26 = position;
            this.prefabEfxAcornSpring.position = new UnityEngine.Vector3();
            UnityEngine.GameObject val_27 = typeof(RaidScreenMain.<>c__DisplayClass37_0).__il2cppRuntimeField_14.gameObject;
            typeof(RaidScreenMain.<>c__DisplayClass37_0).__il2cppRuntimeField_14.SetActive(value:  true);
            DG.Tweening.Sequence val_28 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Transform val_29 = typeof(RaidScreenMain.<>c__DisplayClass37_0).__il2cppRuntimeField_C.transform;
            DG.Tweening.Tweener val_30 = DG.Tweening.ShortcutExtensions.DOScale(target:  typeof(RaidScreenMain.<>c__DisplayClass37_0).__il2cppRuntimeField_C, endValue:  val_26.x, duration:  val_26.y);
            object val_31 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  typeof(RaidScreenMain.<>c__DisplayClass37_0).__il2cppRuntimeField_C, ease:  26);
            DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  typeof(RaidScreenMain.<>c__DisplayClass37_0).__il2cppRuntimeField_C);
            val_62 = 1152921504797581312;
            DG.Tweening.TweenCallback val_33 = new DG.Tweening.TweenCallback(object:  405270528, method:  new IntPtr(267485520));
            DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            if(((0 + (spotButton + 20) << 2) + 16) >= 1)
            {
                    DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_26.x);
                DG.Tweening.TweenCallback val_36 = new DG.Tweening.TweenCallback(object:  405270528, method:  new IntPtr(267486544));
                DG.Tweening.Sequence val_37 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
                val_63 = 1152921505012170752;
                val_64 = null;
                val_64 = null;
                val_63 = val_63;
                val_66 = RaidScreenMain.<>c.<>9__37_2;
                if(val_66 == 0)
            {
                    val_66 = null;
                val_62 = 1152921504797581312;
                val_66 = new DG.Tweening.TweenCallback(object:  RaidScreenMain.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(267487568));
                RaidScreenMain.<>c.<>9__37_2 = val_66;
            }
            
                DG.Tweening.Sequence val_39 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            }
            else
            {
                
            }
            
            DG.Tweening.Sequence val_40 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_26.x);
            val_67 = val_62;
            val_67 = new DG.Tweening.TweenCallback(object:  typeof(RaidScreenMain.<>c__DisplayClass37_0).__il2cppRuntimeField_10, method:  new IntPtr(267488592));
            DG.Tweening.Sequence val_42 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Sequence val_43 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_26.x);
            UnityEngine.Transform val_44 = this.prefabSpotResultLabel.transform;
            DG.Tweening.Tweener val_45 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.prefabSpotResultLabel, endValue:  val_26.x, duration:  val_26.y);
            object val_46 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.prefabSpotResultLabel, ease:  27);
            DG.Tweening.Sequence val_47 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.prefabSpotResultLabel);
            DG.Tweening.TweenCallback val_48 = new DG.Tweening.TweenCallback(object:  267610896, method:  new IntPtr(267489616));
            DG.Tweening.Sequence val_49 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            val_60 = null;
            val_60 = new DG.Tweening.TweenCallback(object:  405270528, method:  new IntPtr(267490640));
            DG.Tweening.Sequence val_51 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            if(this.isFtux != false)
            {
                    if(this.ftuxCoroutine != 0)
            {
                    this.StopCoroutine(routine:  this.ftuxCoroutine);
            }
            
                System.Collections.IEnumerator val_52 = this.ContinueFtuxCoroutine();
                UnityEngine.Coroutine val_53 = this.StartCoroutine(routine:  267610896);
                this.ftuxCoroutine = this;
            }
            
            if(this < 3)
            {
                    return;
            }
            
            val_67 = 0;
            goto label_67;
            label_74:
            WordForest.RaidXSpotButton val_64 = this.forestContent.raidXButtons[val_67];
            UnityEngine.Transform val_54 = val_64.transform;
            DG.Tweening.Tweener val_55 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_64, endValue:  val_26.x, duration:  val_26.y);
            object val_56 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_64, ease:  26);
            val_67 = 1;
            label_67:
            val_60 = this.forestContent.raidXButtons;
            if(val_67 < val_64)
            {
                goto label_74;
            }
            
            DG.Tweening.Sequence val_57 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_26.x);
            DG.Tweening.TweenCallback val_58 = new DG.Tweening.TweenCallback(object:  267610896, method:  new IntPtr(267585872));
            object val_59 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        }
        private void BeginRaid()
        {
            if(this.isFtux != false)
            {
                    WordForest.WFOGameEcon val_1 = WordForest.WFOGameEcon.Instance;
                float val_2 = 0.Item[9];
                WordForest.WFOGameEcon val_3 = WordForest.WFOGameEcon.Instance;
                WordForest.UserForestProfile val_5 = WordForest.UserForestProfile.CreateDummyProfile(baseLevel:  3, flexibleBaseLevel:  false, minTreesNormalized:  0.Item[9], maxTreesNormalized:  null);
                this.opponent = 3;
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                System.Action val_7 = new System.Action(object:  267879568, method:  new IntPtr(267850448));
                InitializeFtuxRaid(onInitialized:  7454720);
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordForest.UserForestProfile val_9 = GetRaidRandomOpponent();
            this.opponent = public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance();
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_11 = new System.Action(object:  267879568, method:  new IntPtr(267850448));
            InitializeRaid(opponentId:  this.opponent.serverId, onInitialized:  7454720);
        }
        private void EndRaid()
        {
            var val_11;
            var val_12;
            int val_13;
            var val_14;
            int val_15;
            var val_16;
            var val_17;
            var val_18;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ConcludeRaid(chosenRewardIndexes:  this.chosenRewardIndexes);
            val_11 = null;
            val_11 = null;
            WordForest.RaidAttackManager.lastRaidPerfect = this.isPerfectRaid;
            System.Collections.Hashtable val_2 = new System.Collections.Hashtable();
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_1C.Notify(note:  2, data:  75878400);
            WordForest.WFOPlayer val_4 = WordForest.WFOPlayer.Instance;
            if(0 != 0)
            {
                    val_12 = 0.starsLevelBalance;
                val_13 = this.acornsRaided;
            }
            else
            {
                    val_12 = 0.starsLevelBalance;
                val_13 = this.acornsRaided;
            }
            
            0.starsLevelBalance = val_12 + val_13;
            WordForest.WFOPlayer val_8 = WordForest.WFOPlayer.Instance;
            if(0 != 0)
            {
                    val_14 = 0;
                val_15 = this.acornsRaided;
                val_16 = 6;
            }
            else
            {
                    val_14 = 300;
                val_15 = this.acornsRaided;
                val_16 = 6;
            }
            
            mem[300] = val_16 + val_15;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_10 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if(this.opponent.isDummyAccount == false)
            {
                    this.opponent.isDummyAccount = this.opponent.<autoCreated>k__BackingField;
                goto label_14;
            }
            
            label_30:
            var val_11 = 25135846;
            val_11 = 10489692 + val_11;
            if(val_11 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_17 = null;
            val_17 = null;
            val_18 = 0;
            App.trackerManager.track(eventName:  -1103004192, data:  78753792);
            if(this.forestContent.raidXButtons != null)
            {
                    return;
            }
            
            return;
            label_14:
            Add(key:  -1103004096, value:  13152256);
            goto label_30;
        }
        private void ShowResultScreen()
        {
            string val_1 = System.String.Format(format:  268198352, arg0:  13152256, arg1:  this.opponent.name);
            UnityEngine.GameObject val_2 = this.perfectBanner.gameObject;
            if(this.isPerfectRaid == true)
            {
                    this.isPerfectRaid = 1;
            }
            
            this.perfectBanner.SetActive(value:  true);
            this.uiStateReward.alpha = null;
            UnityEngine.GameObject val_3 = this.uiStateReward.gameObject;
            this.uiStateReward.SetActive(value:  true);
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.uiStateReward, endValue:  null, duration:  null);
        }
        private void OnExitScreenClicked()
        {
            this.buttonRewardOkay.interactable = false;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            BackButtonPressed();
        }
        private void CheckShowFtux()
        {
            var val_11;
            int val_12;
            var val_13;
            if(this.isFtux == false)
            {
                    return;
            }
            
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            if(0 != 0)
            {
                    val_11 = 0;
                val_12 = MonoExtensions.SetBit(value:  132, bit:  9);
            }
            else
            {
                    val_11 = 312;
                val_12 = MonoExtensions.SetBit(value:  132, bit:  9);
            }
            
            mem[312] = val_12;
            this.UpdateFtuxText();
            this.ftuxRoot.SetActive(value:  true);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.ftuxCursors = null;
            val_13 = 0;
            goto label_5;
            label_21:
            WordForest.RaidXSpotButton val_11 = this.forestContent.raidXButtons[val_13];
            UnityEngine.Transform val_5 = val_11.transform;
            object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  this.ftuxCursorPrefab, parent:  val_11);
            UnityEngine.Transform val_7 = this.ftuxCursorPrefab.transform;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            this.ftuxCursorPrefab.localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_9 = this.ftuxCursorPrefab.transform;
            UnityEngine.Vector3 val_10;
            val_10 = new UnityEngine.Vector3(x:  val_8.x, y:  val_8.y);
            this.ftuxCursorPrefab.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            this.ftuxCursors.Add(item:  this.ftuxCursorPrefab);
            val_13 = 1;
            label_5:
            if(val_13 < this.ftuxCursors)
            {
                goto label_21;
            }
        
        }
        private System.Collections.IEnumerator ContinueFtuxCoroutine()
        {
            object val_1 = new System.Object();
            typeof(RaidScreenMain.<ContinueFtuxCoroutine>d__43).__il2cppRuntimeField_8 = 0;
            typeof(RaidScreenMain.<ContinueFtuxCoroutine>d__43).__il2cppRuntimeField_10 = this;
        }
        private void UpdateFtuxText()
        {
            string val_1 = System.String.Format(format:  268908624, arg0:  this.opponent.name);
            if(this.ftuxText == 0)
            {
                
            }
        
        }
        private void CloseFtux()
        {
            this.ftuxRoot.SetActive(value:  false);
        }
        public RaidScreenMain()
        {
            this.areRaidSpotsInteractable = true;
            this.isPerfectRaid = true;
        }
    
    }

}
