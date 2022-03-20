using UnityEngine;

namespace WordForest
{
    public class AttackScreenMain : MonoSingleton<WordForest.AttackScreenMain>
    {
        // Fields
        private UnityEngine.RectTransform forestContainer;
        private UnityEngine.RectTransform adsArea;
        private UGUINetworkedButtonMultiGraphic buttonRevenge;
        private UGUINetworkedButtonMultiGraphic buttonFriends;
        private UnityEngine.CanvasGroup uiStatePicking;
        private UnityEngine.CanvasGroup uiStateReward;
        private UnityEngine.UI.Image opponentAvatarImage;
        private UnityEngine.UI.Text forestLabel;
        private UnityEngine.UI.Button prefabButtonAttackSpot;
        private UnityEngine.ParticleSystem efxChopAction;
        private UnityEngine.UI.RawImage blockShieldImage;
        private UnityEngine.UI.RawImage axeImage;
        private UnityEngine.UI.Text rewardBodyLabel;
        private UnityEngine.UI.Button buttonRewardOkay;
        private UnityEngine.GameObject ftuxRoot;
        private UnityEngine.UI.Button ftuxButtonClose;
        private UnityEngine.UI.Text ftuxText;
        private UnityEngine.GameObject ftuxCursorPrefab;
        private UnityEngine.GameObject revengeFtux;
        private UGUINetworkedButtonMultiGraphic revengeFtuxButton;
        private UnityEngine.UI.Button ftuxHighlightedObject;
        private UnityEngine.GameObject ftuxCursor;
        private WordForest.UserForestProfile opponent;
        private WordForest.AttackScreenMain.AttackOpponentType opponentType;
        private WordForest.WFOForestContent forestContent;
        private System.Collections.Generic.List<UnityEngine.UI.Button> buttonAttackSpots;
        private System.Collections.Generic.List<DG.Tweening.Tween> buttonAttackSpotsIdleSeq;
        private System.Collections.Generic.List<DG.Tweening.Tween> buttonAttackSpotsIdle2Seq;
        private WordForest.UserForestProfile initialRandomOpponent;
        private bool isSuccessful;
        private int acornsRewarded;
        private bool isAttackFtux;
        private bool isAttackBlockedFtux;
        private bool isReadyToShowRevengeFtux;
        
        // Methods
        private void OnAttackSpotClicked(int treeId)
        {
            UnityEngine.GameObject val_2;
            this.buttonFriends.interactable = false;
            this.buttonRevenge.interactable = false;
            val_2 = this.ftuxCursor;
            if((UnityEngine.Object.op_Implicit(exists:  val_2)) != false)
            {
                    val_2 = this.ftuxCursor;
                val_2.SetActive(value:  false);
            }
            
            this.EndAttack(treeId:  treeId);
        }
        private void OnRevengeButtonClicked(bool isConnected)
        {
            this.revengeFtux.SetActive(value:  false);
            if(isConnected != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  244162656, method:  new IntPtr(244136608));
                GetRevengeOpponentPool(onRevengeListRetrieved:  7401472);
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowConnectionRequired();
        }
        private void OnFriendsButtonClicked(bool isConnected)
        {
            var val_4;
            var val_5;
            System.Action<System.Collections.Generic.List<WordForest.UserForestProfile>> val_7;
            if(isConnected != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                var val_4 = 25209208;
                val_4 = 10425180 + val_4;
                if(val_4 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_4 = null;
                val_4 = null;
                val_5 = null;
                val_5 = null;
                val_7 = AttackScreenMain.<>c.<>9__37_0;
                if(val_7 == 0)
            {
                    val_7 = null;
                val_7 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  AttackScreenMain.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(244254752));
                AttackScreenMain.<>c.<>9__37_0 = val_7;
            }
            
                GetFriendsOpponentPool(friendFbidList:  FacebookPlugin.appFriendsIdsArray, onListRetrieved:  7401472);
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowConnectionRequired();
        }
        private void Start()
        {
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  244434784, method:  new IntPtr(244371872));
            System.Delegate val_2 = System.Delegate.Combine(a:  static_value_021FBC22, b:  7401472);
            val_22 = 35634210;
            val_22 = 0;
            mem2[0] = val_22;
            System.Action<System.Boolean> val_3 = new System.Action<System.Boolean>(object:  244434784, method:  new IntPtr(244371872));
            System.Delegate val_4 = System.Delegate.Combine(a:  0, b:  7401472);
            val_23 = val_22;
            if(val_23 != 0)
            {
                    if(1179403647 == null)
            {
                goto label_8;
            }
            
            }
            
            val_23 = 0;
            label_8:
            mem2[0] = val_23;
            System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  244434784, method:  new IntPtr(244381088));
            System.Delegate val_6 = System.Delegate.Combine(a:  0, b:  7401472);
            val_24 = val_23;
            if(val_24 != 0)
            {
                    if(1179403647 == null)
            {
                goto label_12;
            }
            
            }
            
            val_24 = 0;
            label_12:
            mem2[0] = val_24;
            val_25 = 1152921504769093632;
            UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  244434784, method:  new IntPtr(244390304));
            this.buttonRewardOkay.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  244434784, method:  new IntPtr(244399520));
            this.ftuxButtonClose.m_OnClick.AddListener(call:  162246656);
            WordForest.WFOPlayer val_9 = WordForest.WFOPlayer.Instance;
            bool val_10 = MonoExtensions.IsBitSet(value:  132, bit:  10);
            val_10 = val_10 ^ 1;
            this.isAttackFtux = val_10;
            WordForest.WFOPlayer val_11 = WordForest.WFOPlayer.Instance;
            bool val_12 = MonoExtensions.IsBitSet(value:  132, bit:  11);
            val_12 = val_12 ^ 1;
            this.isAttackBlockedFtux = val_12;
            if(val_12 != false)
            {
                    this.isReadyToShowRevengeFtux = false;
            }
            else
            {
                    WordForest.WFOPlayer val_13 = WordForest.WFOPlayer.Instance;
                bool val_14 = MonoExtensions.IsBitSet(value:  132, bit:  12);
                this.isReadyToShowRevengeFtux = val_14 ^ 1;
                if(val_14 != true)
            {
                    this.ftuxButtonClose.m_OnClick.RemoveAllListeners();
            }
            
            }
            
            if(this.isAttackFtux == false)
            {
                goto label_25;
            }
            
            WordForest.WFOGameEcon val_16 = WordForest.WFOGameEcon.Instance;
            val_26 = 0;
            val_27 = 10;
            val_28 = 10;
            val_29 = 1152921513441190304;
            goto label_28;
            label_25:
            if(this.isAttackBlockedFtux == false)
            {
                goto label_29;
            }
            
            WordForest.WFOGameEcon val_17 = WordForest.WFOGameEcon.Instance;
            val_26 = 0;
            val_27 = 11;
            val_28 = 11;
            val_29 = 1152921513441190304;
            label_28:
            WordForest.WFOGameEcon val_19 = WordForest.WFOGameEcon.Instance;
            val_25 = 18;
            val_30 = val_25.Item[11];
            if(this.isAttackFtux == false)
            {
                    this.isAttackFtux = this.isAttackBlockedFtux;
                goto label_34;
            }
            
            WordForest.UserForestProfile val_21 = WordForest.UserForestProfile.CreateDummyProfile(baseLevel:  2, flexibleBaseLevel:  false, minTreesNormalized:  val_26.Item[11], maxTreesNormalized:  null);
            val_31 = 2;
            goto label_35;
            label_29:
            val_30 = 0;
            label_34:
            val_31 = 0;
            label_35:
            this.ShowUserForest(targetForest:  0, opponType:  0, initDestroyedTrees:  0);
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
        public void ShowUserForest(WordForest.UserForestProfile targetForest, WordForest.AttackScreenMain.AttackOpponentType opponType = 0, int initDestroyedTrees = 0)
        {
            WordForest.UserForestProfile val_11;
            var val_12;
            int val_12 = initDestroyedTrees;
            this.Clear();
            this.opponentType = opponType;
            if(targetForest != 0)
            {
                    this.opponent = targetForest;
            }
            else
            {
                    val_11 = this.initialRandomOpponent;
                if(val_11 == 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_11 = public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance();
                WordForest.UserForestProfile val_2 = GetAttackRandomOpponent();
                this.initialRandomOpponent = val_11;
            }
            
                this.opponent = val_11;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordForest.WFOForestContent val_4 = GetForestLayout(forestId:  this.opponent.level);
            object val_5 = UnityEngine.Object.Instantiate<System.Object>(original:  -1425082880, parent:  this.forestContainer);
            this.forestContent = public static WordForest.WFOForestManager MonoSingleton<WordForest.WFOForestManager>::get_Instance();
            Initialize(forestMap:  this.opponent.map);
            if(val_12 < 1)
            {
                goto label_21;
            }
            
            RandomSet val_6 = null;
            val_12 = 0;
            val_6 = new RandomSet();
            goto label_16;
            label_20:
            add(item:  0, weight:  null);
            val_12 = 1;
            label_16:
            if(val_12 < val_6)
            {
                goto label_20;
            }
            
            if(val_12 >= 1)
            {
                    do
            {
                WordForest.WFOTree val_11 = this.forestContent.trees[roll(unweighted:  false)];
                DG.Tweening.Sequence val_8 = val_11.SetGrowthState(state:  2, instant:  true, delayGrowth:  false, shadowParent:  0);
                val_12 = val_12 - 1;
            }
            while(val_11 != 0);
            
            }
            
            label_21:
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Sprite val_10 = public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_10.GetAvatarSpriteByID(id:  this.opponent.avatarId);
            this.opponentAvatarImage.sprite = public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_10;
            this.InitializeAttackSpots();
        }
        private void Clear()
        {
            DG.Tweening.Tween val_3;
            UnityEngine.Object val_8;
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
            if(this.buttonAttackSpotsIdle2Seq == 0)
            {
                goto label_4;
            }
            
            List.Enumerator<T> val_4 = GetEnumerator();
            label_6:
            if(MoveNext() == false)
            {
                goto label_5;
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  val_3, complete:  false);
            goto label_6;
            label_5:
            Dispose();
            label_4:
            if(this.buttonAttackSpots == 0)
            {
                goto label_7;
            }
            
            List.Enumerator<T> val_6 = GetEnumerator();
            label_12:
            if(MoveNext() == false)
            {
                goto label_8;
            }
            
            UnityEngine.GameObject val_9 = val_8.gameObject;
            UnityEngine.Object.Destroy(obj:  val_8);
            goto label_12;
            label_8:
            Dispose();
            label_7:
            if(this.forestContent == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_11 = this.forestContent.gameObject;
            UnityEngine.Object.Destroy(obj:  this.forestContent);
        }
        private void InitializeAttackSpots()
        {
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.buttonAttackSpots = null;
            this.buttonAttackSpotsIdleSeq = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.buttonAttackSpotsIdle2Seq = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_31 = 4;
            val_32 = 1152921505010520064;
            goto label_1;
            label_32:
            object val_4 = null;
            val_33 = val_4;
            val_4 = new System.Object();
            typeof(AttackScreenMain.<>c__DisplayClass42_0).__il2cppRuntimeField_C = this;
            WordForest.WFOTree val_32 = this.forestContent.trees[0];
            if(this.forestContent.trees[0].growthState != 1)
            {
                goto label_7;
            }
            
            typeof(AttackScreenMain.<>c__DisplayClass42_0).__il2cppRuntimeField_8 = 1152921509926735968;
            object val_5 = UnityEngine.Object.Instantiate<System.Object>(original:  this.prefabButtonAttackSpot, parent:  this.forestContainer);
            WordForest.WFOTree val_33 = this.forestContent.trees[0];
            UnityEngine.Transform val_6 = val_33.transform;
            if(val_33 == 0)
            {
                goto label_14;
            }
            
            val_34 = val_33;
            if(null == null)
            {
                goto label_15;
            }
            
            label_14:
            val_34 = 0;
            label_15:
            UnityEngine.Transform val_7 = this.prefabButtonAttackSpot.transform;
            UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            UnityEngine.Vector3 val_9 = TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_8.x, z = val_8.y});
            this.prefabButtonAttackSpot.position = new UnityEngine.Vector3();
            UnityEngine.Transform val_10 = this.prefabButtonAttackSpot.transform;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
            this.prefabButtonAttackSpot.localScale = new UnityEngine.Vector3();
            UnityEngine.Events.UnityAction val_12 = new UnityEngine.Events.UnityAction(object:  403673088, method:  new IntPtr(245321632));
            this.prefabButtonAttackSpot.m_OnClick.AddListener(call:  162246656);
            this.buttonAttackSpots.Add(item:  this.prefabButtonAttackSpot);
            DG.Tweening.Sequence val_13 = DG.Tweening.DOTween.Sequence();
            object val_14 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  0, loops:  0, loopType:  0);
            UnityEngine.Transform val_15 = this.prefabButtonAttackSpot.transform;
            float val_16 = UnityEngine.Random.Range(min:  val_11.x, max:  val_11.y);
            uint val_34 = 1061997773;
            val_34 = val_34 * 2.5f;
            DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.prefabButtonAttackSpot, endValue:  val_34, duration:  val_11.y);
            object val_18 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.prefabButtonAttackSpot, ease:  1);
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.prefabButtonAttackSpot);
            UnityEngine.Transform val_20 = this.prefabButtonAttackSpot.transform;
            float val_21 = UnityEngine.Random.Range(min:  val_34, max:  val_11.y);
            uint val_35 = 1061997773;
            val_35 = val_35 * 0.25f;
            DG.Tweening.Tweener val_22 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.prefabButtonAttackSpot, endValue:  val_35, duration:  val_11.y);
            object val_23 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.prefabButtonAttackSpot, ease:  27);
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.prefabButtonAttackSpot);
            val_33 = 1152921509927012192;
            this.buttonAttackSpotsIdleSeq.Add(item:  0);
            UnityEngine.Transform val_25 = this.prefabButtonAttackSpot.transform;
            UnityEngine.Vector3 val_26 = new UnityEngine.Vector3(x:  val_35, y:  val_11.y, z:  val_11.z);
            float val_27 = UnityEngine.Random.Range(min:  val_35, max:  val_11.y);
            uint val_36 = 1061158912;
            val_36 = val_36 * 16f;
            DG.Tweening.Tweener val_28 = DG.Tweening.ShortcutExtensions.DORotate(target:  this.prefabButtonAttackSpot, endValue:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, duration:  val_36, mode:  val_36);
            object val_29 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.prefabButtonAttackSpot, ease:  1);
            object val_30 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.prefabButtonAttackSpot, loops:  0, loopType:  0);
            this.buttonAttackSpotsIdle2Seq.Add(item:  this.prefabButtonAttackSpot);
            val_32 = 1152921505010520064;
            label_7:
            val_31 = val_31 + 1;
            label_1:
            if((val_31 - 4) < this.buttonAttackSpotsIdle2Seq)
            {
                goto label_32;
            }
        
        }
        private void EndAttack(int treeId)
        {
            int val_5;
            float val_10;
            float val_11;
            float val_18;
            var val_58;
            WordForest.WFOTree val_60;
            float val_61;
            var val_62;
            var val_63;
            int val_64;
            var val_65;
            var val_66;
            object val_1 = new System.Object();
            typeof(AttackScreenMain.<>c__DisplayClass43_0).__il2cppRuntimeField_8 = this;
            typeof(AttackScreenMain.<>c__DisplayClass43_0).__il2cppRuntimeField_C = this.forestContent.trees[treeId];
            WordForest.WFOGameEcon val_2 = WordForest.WFOGameEcon.Instance;
            if(this.opponent.isDummyAccount == false)
            {
                    this.opponent.isDummyAccount = this.opponent.<autoCreated>k__BackingField;
                goto label_6;
            }
            
            if(this.isAttackFtux == false)
            {
                    this.opponent.isDummyAccount = this.isAttackBlockedFtux;
            }
            
            if(this.opponent.isDummyAccount == false)
            {
                goto label_7;
            }
            
            label_98:
            this.isSuccessful = this.isAttackFtux;
            val_58 = null;
            val_58 = null;
            WordForest.RaidAttackManager.lastAttackResult = this.isAttackFtux;
            Dictionary.Enumerator<TKey, TValue> val_3 = GetEnumerator();
            label_15:
            if(MoveNext() == false)
            {
                goto label_12;
            }
            
            int val_6 = UnityEngine.Mathf.Max(a:  val_5, b:  0);
            goto label_15;
            label_12:
            Dispose();
            WordForest.WFOPlayer val_7 = WordForest.WFOPlayer.Instance;
            if(19 > 0)
            {
                    19 = 0;
            }
            
            if((1296.ContainsKey(key:  0)) != false)
            {
                    if(this.isSuccessful != 0)
            {
                    UnityEngine.Vector2Int val_9 = Item[1296];
                int val_12 = val_10.y;
            }
            else
            {
                    UnityEngine.Vector2Int val_13 = Item[1296];
            }
            
                this.acornsRewarded = val_10.x;
            }
            
            UnityEngine.Transform val_15 = this.efxChopAction.transform;
            if(this.isSuccessful != false)
            {
                    val_60 = typeof(AttackScreenMain.<>c__DisplayClass43_0).__il2cppRuntimeField_C;
            }
            else
            {
                    val_60 = this.blockShieldImage;
            }
            
            UnityEngine.Transform val_16 = val_60.transform;
            UnityEngine.Vector3 val_17 = position;
            this.efxChopAction.position = new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_18};
            if(this.opponent.isDummyAccount == false)
            {
                goto label_31;
            }
            
            val_62 = null;
            goto label_36;
            label_31:
            val_62 = null;
            if((this.opponent.<autoCreated>k__BackingField) == false)
            {
                goto label_34;
            }
            
            label_36:
            twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_10 = 0;
            System.Nullable<System.Boolean> val_21 = new System.Nullable<System.Boolean>(value:  this.isSuccessful);
            label_93:
            ResolveAttack(opponentId:  this.opponent.serverId, treeId:  treeId, autoSuccess:  new System.Nullable<System.Boolean>() {HasValue = val_21.HasValue});
            System.Collections.Hashtable val_22 = new System.Collections.Hashtable();
            val_10 = this.acornsRewarded;
            twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_1C.Notify(note:  4, data:  75878400);
            WordForest.WFOPlayer val_24 = WordForest.WFOPlayer.Instance;
            if(0 != 0)
            {
                    val_63 = 0.starsLevelBalance;
                val_64 = this.acornsRewarded;
            }
            else
            {
                    val_63 = 0.starsLevelBalance;
                val_64 = this.acornsRewarded;
            }
            
            0.starsLevelBalance = val_63 + val_64;
            WordForest.WFOPlayer val_28 = WordForest.WFOPlayer.Instance;
            string val_29 = this.acornsRewarded.ToString();
            0.TrackNonCoinReward(source:  245713280, subSource:  null, rewardType:  -1238435648, rewardAmount:  this.acornsRewarded, additionalParams:  0);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_30 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if(this.opponent.isDummyAccount == false)
            {
                    this.opponent.isDummyAccount = this.opponent.<autoCreated>k__BackingField;
                goto label_48;
            }
            
            label_96:
            val_10 = this.isSuccessful;
            Add(key:  245717456, value:  8945664);
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem2[0] = ;
            Add(key:  1297334992, value:  403566592);
            var val_61 = 25202934;
            val_61 = 10422604 + val_61;
            if(val_61 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_65 = null;
            val_65 = null;
            App.trackerManager.track(eventName:  245717568, data:  78753792);
            val_66 = 4;
            goto label_59;
            label_81:
            if(App.trackerManager <= App.trackerManager)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            2621443.interactable = false;
            if(App.trackerManager < 2621443)
            {
                    if(2621443 <= App.trackerManager)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(2621443 != 0)
            {
                    if(2621443 <= App.trackerManager)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                DG.Tweening.TweenExtensions.Kill(t:  2621443, complete:  false);
            }
            
            }
            
            if(App.trackerManager < 2621443)
            {
                    if(2621443 <= App.trackerManager)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(2621443 != 0)
            {
                    if(2621443 <= App.trackerManager)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                DG.Tweening.TweenExtensions.Kill(t:  2621443, complete:  false);
            }
            
            }
            
            if(2621443 <= App.trackerManager)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.Transform val_31 = 2621443.transform;
            float val_32 = UnityEngine.Random.Range(min:  val_17.x, max:  val_17.y);
            val_61 = 1065353216 * 0.1f;
            DG.Tweening.Tweener val_33 = DG.Tweening.ShortcutExtensions.DOScale(target:  2621443, endValue:  val_61, duration:  val_17.y);
            object val_34 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  2621443, ease:  26);
            val_66 = 5;
            label_59:
            if((val_66 - 4) < 2621443)
            {
                goto label_81;
            }
            
            DG.Tweening.Sequence val_36 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Transform val_37 = this.axeImage.transform;
            val_11 = 0;
            val_10 = 0;
            val_18 = 0;
            UnityEngine.Vector3 val_38 = new UnityEngine.Vector3(x:  val_61, y:  val_17.y, z:  val_17.z);
            DG.Tweening.Tweener val_39 = DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  this.axeImage, endValue:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, duration:  val_61, mode:  1060320051);
            object val_40 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.axeImage, ease:  7);
            DG.Tweening.Sequence val_41 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.axeImage);
            UnityEngine.Transform val_42 = this.axeImage.transform;
            UnityEngine.Vector3 val_43 = new UnityEngine.Vector3(x:  val_61, y:  val_17.y, z:  val_17.z);
            DG.Tweening.Tweener val_44 = DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  this.axeImage, endValue:  new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z}, duration:  val_61, mode:  1040522936);
            object val_45 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.axeImage, ease:  6);
            DG.Tweening.Sequence val_46 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.axeImage);
            DG.Tweening.TweenCallback val_47 = new DG.Tweening.TweenCallback(object:  403726336, method:  new IntPtr(245762736));
            DG.Tweening.Sequence val_48 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            UnityEngine.Transform val_49 = this.axeImage.transform;
            UnityEngine.Vector3 val_50 = new UnityEngine.Vector3(x:  val_61, y:  val_17.y, z:  val_17.z);
            DG.Tweening.Tweener val_51 = DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  this.axeImage, endValue:  new UnityEngine.Vector3() {x = val_50.x, y = val_50.y, z = val_50.z}, duration:  val_61, mode:  1051931443);
            object val_52 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.axeImage, ease:  27);
            DG.Tweening.Sequence val_53 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.axeImage);
            DG.Tweening.Sequence val_54 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_61);
            DG.Tweening.TweenCallback val_55 = new DG.Tweening.TweenCallback(object:  245805280, method:  new IntPtr(245767856));
            object val_56 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
            return;
            label_6:
            if(this.opponent.shields < 1)
            {
                    0 = 1;
            }
            
            goto label_98;
            label_34:
            twelvegigs.Autopilot.AutopilotManager val_57 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance()) != 0)
            {
                goto label_93;
            }
            
            goto label_93;
            label_48:
            val_10 = this.opponent.serverId;
            Add(key:  245781168, value:  13152256);
            goto label_96;
            label_7:
            int val_58 = UnityEngine.Random.Range(min:  0, max:  101);
            var val_59 = 0 + 1392;
            if(0 >= 0)
            {
                    0 = 1;
            }
            
            if(val_58 != 0)
            {
                    val_58 = 1;
            }
            
            goto label_98;
        }
        private void ShowResultScreen()
        {
            var val_4;
            var val_5;
            if(this.isSuccessful != false)
            {
                    val_4 = null;
                val_5 = "You attacked {0}\'s village and won {1} Acorns.";
            }
            else
            {
                    val_4 = null;
                val_5 = "{0} blocked your attack. You won {1} Acorns.";
            }
            
            string val_1 = System.String.Format(format:  246036816, arg0:  this.opponent.name, arg1:  13152256);
            this.uiStateReward.alpha = null;
            UnityEngine.GameObject val_2 = this.uiStateReward.gameObject;
            this.uiStateReward.SetActive(value:  true);
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.uiStateReward, endValue:  null, duration:  null);
        }
        private void OnExitScreenClicked()
        {
            this.buttonRewardOkay.interactable = false;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            BackButtonPressed();
        }
        private void CheckShowFtux()
        {
            var val_16;
            int val_17;
            var val_18;
            var val_19;
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            val_16 = 0;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(this.isReadyToShowRevengeFtux == true)
            {
                goto label_4;
            }
            
            if(this.isAttackFtux == false)
            {
                    this.isAttackFtux = this.isAttackBlockedFtux;
                return;
            }
            
            UnityEngine.GameObject val_3 = this.buttonRevenge.gameObject;
            this.buttonRevenge.SetActive(value:  false);
            UnityEngine.GameObject val_4 = this.buttonFriends.gameObject;
            this.buttonFriends.SetActive(value:  false);
            if(this.isAttackFtux == false)
            {
                goto label_11;
            }
            
            mem[312] = MonoExtensions.SetBit(value:  132, bit:  10);
            string val_6 = System.String.Format(format:  246322416, arg0:  this.opponent.name);
            if(this.ftuxText != 0)
            {
                goto label_14;
            }
            
            goto label_14;
            label_4:
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_C = 0;
            if(val_16 == 0)
            {
                goto label_18;
            }
            
            val_17 = MonoExtensions.SetBit(value:  mem[312], bit:  12);
            goto label_19;
            label_11:
            mem[312] = MonoExtensions.SetBit(value:  132, bit:  11);
            label_14:
            this.ftuxRoot.SetActive(value:  true);
            if(this.buttonAttackSpots != 0)
            {
                    val_18 = this.buttonAttackSpots;
                val_19 = UnityEngine.Random.Range(min:  0, max:  1);
            }
            else
            {
                    val_18 = 12;
                val_19 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            
            if(val_18 <= val_19)
            {
                    var val_16 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_16 = val_16 + (val_19 << 2);
            this.ftuxHighlightedObject = (0 + (val_11) << 2) + 16;
            UnityEngine.Events.UnityAction val_12 = new UnityEngine.Events.UnityAction(object:  246368112, method:  new IntPtr(244399520));
            (0 + (val_11) << 2) + 16 + 172.AddListener(call:  162246656);
            DG.Tweening.TweenCallback val_13 = new DG.Tweening.TweenCallback(object:  246368112, method:  new IntPtr(246338992));
            DG.Tweening.Tween val_14 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1028443341, ignoreTimeScale:  false);
            return;
            label_18:
            val_16 = 312;
            val_17 = MonoExtensions.SetBit(value:  mem[312], bit:  12);
            label_19:
            mem[312] = val_17;
            this.revengeFtux.SetActive(value:  true);
        }
        private void OnFtuxButtonClicked()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.ftuxHighlightedObject)) != false)
            {
                    UnityEngine.Transform val_2 = this.ftuxHighlightedObject.transform;
                this.ftuxHighlightedObject.SetParent(p:  this.forestContainer);
            }
            
            this.ftuxRoot.SetActive(value:  false);
        }
        public AttackScreenMain()
        {
        
        }
        private void <OnRevengeButtonClicked>b__36_0(System.Collections.Generic.List<WordForest.UserForestProfile> revengeList)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
            Initialize(randomUser:  this.initialRandomOpponent, revengeUserList:  revengeList);
        }
        private void <CheckShowFtux>b__46_0()
        {
            UnityEngine.Transform val_1 = this.ftuxHighlightedObject.transform;
            UnityEngine.Transform val_2 = this.ftuxRoot.transform;
            this.ftuxHighlightedObject.SetParent(p:  this.ftuxRoot);
            if(this.ftuxCursor != 0)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  this.ftuxCursor);
            }
            
            UnityEngine.Transform val_4 = this.ftuxHighlightedObject.transform;
            object val_5 = UnityEngine.Object.Instantiate<System.Object>(original:  this.ftuxCursorPrefab, parent:  this.ftuxHighlightedObject);
            this.ftuxCursor = this.ftuxCursorPrefab;
            UnityEngine.Transform val_6 = this.ftuxCursorPrefab.transform;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            this.ftuxCursorPrefab.localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_8 = this.ftuxCursor.transform;
            UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  val_7.x, y:  val_7.y);
            this.ftuxCursor.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Transform val_10 = this.ftuxCursor.transform;
            UnityEngine.Transform val_11 = this.ftuxRoot.transform;
            this.ftuxCursor.parent = this.ftuxRoot;
        }
    
    }

}
