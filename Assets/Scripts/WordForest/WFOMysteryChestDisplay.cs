using UnityEngine;

namespace WordForest
{
    public class WFOMysteryChestDisplay : MonoSingleton<WordForest.WFOMysteryChestDisplay>
    {
        // Fields
        protected UnityEngine.CanvasGroup parentCanvasGroup;
        protected UnityEngine.RectTransform chestRootTransform;
        protected UnityEngine.UI.Button button;
        protected UnityEngine.UI.Text labelTapToOpen;
        protected UnityEngine.UI.Image lockImage;
        protected UnityEngine.GameObject chestOverlay;
        protected UnityEngine.UI.Image pointerImage;
        protected UnityEngine.UI.Button buttonClose;
        protected UnityEngine.GameObject radialRayObject;
        protected UnityEngine.RectTransform questionChest;
        protected CoinCurrencyStatView coinStatViewAnimObj;
        protected WordForest.WFOShieldStatView shieldStatViewObj;
        protected WordForest.MysteryChestStatView mysteryChestStatView;
        protected WordForest.WFOGameAcornStatView acornStatViewObj;
        protected EventButtonPanel eventButtonPanelTab;
        protected UnityEngine.UI.Text acornMultiplierLabel;
        private UnityEngine.GameObject ftuxRoot;
        private FtuxTooltip ftuxTooltip;
        protected UnityEngine.UI.Image chestImageBase;
        protected UnityEngine.UI.Image chestImageUpper;
        protected UnityEngine.UI.Image chestImageUpperClose;
        protected UnityEngine.UI.Image chestImageLower;
        protected UnityEngine.CanvasGroup chestCanvasGroupClosed;
        protected UnityEngine.CanvasGroup chestCanvasGroupOpened;
        protected UnityEngine.UI.Image chestOpenRay;
        protected UnityEngine.GameObject prefabItem;
        protected WordForest.WFOAcornMultiplierTrailParticle prefabItemTrailEfx;
        protected WordForest.WFOAcornMultiplierTrailParticle prefabAcornMultiplierEfx;
        protected UnityEngine.Sprite spriteChestGoldBase;
        protected UnityEngine.Sprite spriteChestGoldUpper;
        protected UnityEngine.Sprite spriteChestGoldUpperClose;
        protected UnityEngine.Sprite spriteChestGoldLower;
        protected UnityEngine.Sprite spriteChestSilverBase;
        protected UnityEngine.Sprite spriteChestSilverUpper;
        protected UnityEngine.Sprite spriteChestSilverUpperClose;
        protected UnityEngine.Sprite spriteChestSilverLower;
        protected UnityEngine.Sprite spriteChestBronzeBase;
        protected UnityEngine.Sprite spriteChestBronzeUpper;
        protected UnityEngine.Sprite spriteChestBronzeUpperClose;
        protected UnityEngine.Sprite spriteChestBronzeLower;
        protected WordForest.WFOWordChestType currentChestType;
        protected System.Collections.Generic.List<WordForest.WFORewardData> rewardItems;
        protected System.Collections.Generic.List<WordForest.WFORewardData> rewardItemModified;
        protected System.Collections.Generic.List<WordForest.WFOWordChestType> chestTypeSet;
        protected System.Collections.Generic.List<System.Collections.Generic.List<WordForest.WFORewardData>> rewardItemsSet;
        protected System.Collections.Generic.List<DG.Tweening.Sequence> itemDisplaySeqList;
        private int rewardItemIdThatTriggeredPause;
        protected UnityEngine.GameObject tableObj;
        protected System.Collections.Generic.List<UnityEngine.Transform> itemPlacementCoords;
        protected bool isInteractable;
        protected bool isAnimationActive;
        protected bool isAwaitingPlayerInputForItems;
        protected decimal creditsBeforeChestOpen;
        protected System.Nullable<UnityEngine.Vector3> originalDisplayScale;
        protected DG.Tweening.Tween pointerSequence;
        protected DG.Tweening.Tween tapToOpenTween;
        protected System.Action onOpenChestAnimationComplete;
        private int statViewCurrentValueAcorns;
        private decimal statViewCurrentValueCoins;
        private int statViewCurrentValueShields;
        private int statViewTotalChests;
        private int chestIndex;
        
        // Properties
        protected virtual bool IsFirstTimeOpeningChest { get; set; }
        
        // Methods
        protected virtual bool get_IsFirstTimeOpeningChest()
        {
            return false;
        }
        protected virtual void set_IsFirstTimeOpeningChest(bool value)
        {
        
        }
        public override void InitMonoSingleton()
        {
            var val_8;
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  316791456, method:  typeof(WordForest.WFOMysteryChestDisplay).__il2cppRuntimeField_130);
            this.button.m_OnClick.AddListener(call:  162246656);
            WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            System.Action<Result> val_3 = new System.Action<Result>(object:  316791456, method:  typeof(WordForest.WFOMysteryChestDisplay).__il2cppRuntimeField_110);
            System.Delegate val_4 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10, b:  7401472);
            val_8 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10;
            if(val_8 != 0)
            {
                    if(val_8 == null)
            {
                goto label_8;
            }
            
            }
            
            val_8 = 0;
            label_8:
            public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10 = val_8;
            NotificationCenter val_5 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  316791456, name:  404738048);
            NotificationCenter val_6 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  316791456, name:  404738048);
            UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  316791456, method:  typeof(WordForest.WFOMysteryChestDisplay).__il2cppRuntimeField_128);
            this.buttonClose.m_OnClick.AddListener(call:  162246656);
        }
        protected virtual void Start()
        {
            UnityEngine.GameObject val_1 = this.buttonClose.gameObject;
            this.buttonClose.SetActive(value:  false);
            UnityEngine.Transform val_2 = this.buttonClose.transform;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.buttonClose.localScale = new UnityEngine.Vector3();
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  316904032, clipIndex:  0);
            this.InitTopUI();
            this.Invoke(methodName:  316904128, time:  val_3.x);
        }
        protected virtual void OnDestroy()
        {
            System.Delegate val_6;
            var val_7;
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            System.Action<Result> val_2 = new System.Action<Result>(object:  317048432, method:  typeof(WordForest.WFOMysteryChestDisplay).__il2cppRuntimeField_110);
            val_6 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10;
            System.Delegate val_3 = System.Delegate.Remove(source:  val_6, value:  7401472);
            if(val_6 != 0)
            {
                    if(val_6 == null)
            {
                goto label_6;
            }
            
            }
            
            val_6 = 0;
            label_6:
            public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10 = val_6;
            NotificationCenter val_4 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.RemoveObserver(observer:  317048432, name:  404738048);
            NotificationCenter val_5 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.RemoveObserver(observer:  317048432, name:  404738048);
            this.StopAnimatedPointer();
            val_7 = null;
            val_7 = null;
            MonoSingleton<T>.searchedFailed = false;
            MonoSingleton<T>.searchedFailed.__il2cppRuntimeField_0 = 0;
        }
        protected virtual void OnSceneUnloaded(SceneType scene)
        {
            if(scene != 11)
            {
                    return;
            }
            
            this.ResumeAllOpenChestSequences();
        }
        protected virtual void OnRaidSent(Notification notif)
        {
            int val_3 = 35641034;
            if(notif.data == 0)
            {
                    return;
            }
            
            val_3 = "acornsEarned";
            if(notif.data == 0)
            {
                    return;
            }
            
            notif.data.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(notif.data <= this.rewardItemIdThatTriggeredPause)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (((this.rewardItemIdThatTriggeredPause << 3) - this.rewardItemIdThatTriggeredPause) << 2);
            if(((0 + (((this.rewardItemIdThatTriggeredPause) << 3 - this.rewardItemIdThatTriggeredPause)) << 2) + 20) == 5)
            {
                    WordForest.WFORewardData val_2 = new WordForest.WFORewardData(rType:  5, rAmt:  75878400);
                val_3 = val_2.amount.lo;
                this.rewardItemModified.set_Item(index:  this.rewardItemIdThatTriggeredPause, value:  new WordForest.WFORewardData() {id = val_2.id, rewardType = val_2.rewardType, amount = new System.Decimal() {flags = val_2.amount.flags, hi = val_2.amount.hi, lo = val_3, mid = val_2.amount.mid}, transformToId = val_2.transformToId});
                return;
            }
            
            UnityEngine.Debug.LogError(message:  317278128);
        }
        protected virtual void OnAttackSent(Notification notif)
        {
            int val_3 = 35641035;
            if(notif.data == 0)
            {
                    return;
            }
            
            val_3 = "acornsEarned";
            if(notif.data == 0)
            {
                    return;
            }
            
            notif.data.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(notif.data <= this.rewardItemIdThatTriggeredPause)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (((this.rewardItemIdThatTriggeredPause << 3) - this.rewardItemIdThatTriggeredPause) << 2);
            if(((0 + (((this.rewardItemIdThatTriggeredPause) << 3 - this.rewardItemIdThatTriggeredPause)) << 2) + 20) == 6)
            {
                    WordForest.WFORewardData val_2 = new WordForest.WFORewardData(rType:  6, rAmt:  75878400);
                val_3 = val_2.amount.lo;
                this.rewardItemModified.set_Item(index:  this.rewardItemIdThatTriggeredPause, value:  new WordForest.WFORewardData() {id = val_2.id, rewardType = val_2.rewardType, amount = new System.Decimal() {flags = val_2.amount.flags, hi = val_2.amount.hi, lo = val_3, mid = val_2.amount.mid}, transformToId = val_2.transformToId});
                return;
            }
            
            UnityEngine.Debug.LogError(message:  317431392);
        }
        protected virtual void OnCloseClicked()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ToggleDarkener(state:  false, animated:  false, duration:  null);
            this.isAnimationActive = false;
            UnityEngine.GameObject val_2 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  317592272);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GetRaidOpponentPool();
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GetAttackOpponentPool();
            if(this.onOpenChestAnimationComplete != 0)
            {
                    this.onOpenChestAnimationComplete.Invoke();
            }
            
            NotificationCenter val_5 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  317592272, aName:  -1275409824);
            WordRegion val_6 = WordRegion.instance;
            0.RemoveLevelCompleteBlocker(blocker:  0);
        }
        public void SetInteractable(bool isInteractable, bool darkenLock = False)
        {
            bool val_3;
            UnityEngine.GameObject val_4;
            this.isInteractable = isInteractable;
            UnityEngine.GameObject val_1 = this.lockImage.gameObject;
            val_3 = isInteractable ^ 1;
            this.lockImage.SetActive(value:  val_3);
            val_4 = this.chestOverlay;
            val_4.SetActive(value:  val_3);
            if(darkenLock == false)
            {
                    return;
            }
            
            UnityEngine.Color val_2 = new UnityEngine.Color(r:  null, g:  null, b:  null);
            this.lockImage.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_4};
        }
        public void Setup(WordForest.WFOWordChestType rarityType = 0, System.Collections.Generic.List<WordForest.WFORewardData> itemData, int collectedChestCount = 1, int totalChestCount = 1, System.Action onComplete)
        {
            WordForest.WFOMysteryChestDisplay val_27;
            var val_28;
            if(itemData == 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_27 = this;
                System.Collections.Generic.List<System.Collections.Generic.List<WordForest.WFORewardData>> val_3 = OpenMysteryChest(chestCount:  collectedChestCount, chestTypeSet: out  System.Collections.Generic.List<WordForest.WFOWordChestType> val_2 = 317859464);
                mem[1152921513514641036] = public static WordForest.WFOMysteryChestManager MonoSingleton<WordForest.WFOMysteryChestManager>::get_Instance();
            }
            else
            {
                    mem[1152921513514641032].Add(item:  rarityType);
                val_27 = this;
                Add(item:  itemData);
            }
            
            mem[1152921513514641100] = onComplete;
            if(collectedChestCount >= 1)
            {
                    var val_30 = 0;
                do
            {
                val_28 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_30 = val_30 + 1;
            }
            while(val_30 != collectedChestCount);
            
            }
            
            WordForest.WFOPlayer val_14 = WordForest.WFOPlayer.Instance;
            int val_15 = 0.starsLevelBalance;
            val_15 = val_15 - 0;
            mem[1152921513514641104] = val_15;
            WordForest.WFOPlayer val_16 = WordForest.WFOPlayer.Instance;
            decimal val_17 = System.Decimal.op_Implicit(value:  317847216);
            decimal val_18 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 317847200, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
            WordForest.WFOPlayer val_19 = WordForest.WFOPlayer.Instance;
            var val_31 = 8;
            val_31 = val_31 - 0;
            mem[1152921513514641124] = val_31;
            mem[1152921513514641128] = totalChestCount;
            this.SetInteractable(isInteractable:  true, darkenLock:  false);
            if(mem[1152921513514641088] != true)
            {
                    UnityEngine.Vector3 val_20 = localScale;
                System.Nullable<UnityEngine.Vector3> val_21 = new System.Nullable<UnityEngine.Vector3>(value:  new UnityEngine.Vector3());
            }
            
            UnityEngine.GameObject val_22 = mem[1152921513514640872].gameObject;
            mem[1152921513514640872].SetActive(value:  false);
            this.TakeNextChestData();
            this.ResetChestVisualState();
            UnityEngine.GameObject val_23 = mem[1152921513514640868].gameObject;
            mem[1152921513514640868].SetActive(value:  false);
            UnityEngine.GameObject val_24 = mem[1152921513514640896].gameObject;
            mem[1152921513514640896].SetActive(value:  false);
            twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GetRaidOpponentPool();
            twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GetAttackOpponentPool();
        }
        private bool IsNextChestAvailable()
        {
            if(R1 > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        private void TakeNextChestData()
        {
            if(true < 1)
            {
                    return;
            }
            
            if(true == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.currentChestType = 2621443;
            this.chestTypeSet.RemoveAt(index:  0);
            if(this.chestTypeSet == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.rewardItems = 2621443;
            if(2621443 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.Collections.Generic.List<WordForest.WFORewardData> val_1 = new System.Collections.Generic.List<WordForest.WFORewardData>(collection:  2621443);
            this.rewardItemModified = null;
            this.rewardItemsSet.RemoveAt(index:  0);
        }
        private void ResetChestVisualState()
        {
            float val_6;
            float val_7;
            float val_8;
            UnityEngine.UI.Image val_10;
            UnityEngine.UI.Image val_11;
            UnityEngine.Sprite val_12;
            if(this.tableObj != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.tableObj);
                this.tableObj = 0;
            }
            
            UnityEngine.Vector3 val_2 = Value;
            this.chestRootTransform.localScale = new UnityEngine.Vector3();
            this.chestCanvasGroupClosed.alpha = val_2.x;
            UnityEngine.GameObject val_3 = this.chestCanvasGroupClosed.gameObject;
            this.chestCanvasGroupClosed.SetActive(value:  true);
            UnityEngine.GameObject val_4 = this.chestCanvasGroupOpened.gameObject;
            this.chestCanvasGroupOpened.SetActive(value:  false);
            this.chestCanvasGroupOpened.alpha = val_2.x;
            this.chestOpenRay.fillAmount = val_2.x;
            UnityEngine.Color val_5 = color;
            this.labelTapToOpen.color = new UnityEngine.Color() {r = val_6, g = val_7, b = val_8, a = 1f};
            UnityEngine.GameObject val_9 = this.labelTapToOpen.gameObject;
            this.labelTapToOpen.SetActive(value:  false);
            if(this.currentChestType == 1)
            {
                goto label_18;
            }
            
            if(this.currentChestType == 2)
            {
                goto label_19;
            }
            
            if(this.currentChestType != 3)
            {
                goto label_20;
            }
            
            val_10 = this;
            this.chestImageBase.sprite = this.spriteChestGoldBase;
            this.chestImageLower.sprite = this.spriteChestGoldLower;
            this.chestImageUpper.sprite = this.spriteChestGoldUpper;
            val_11 = this.chestImageUpperClose;
            val_12 = this.spriteChestGoldUpperClose;
            goto label_28;
            label_18:
            val_10 = this;
            this.chestImageBase.sprite = this.spriteChestBronzeBase;
            this.chestImageLower.sprite = this.spriteChestBronzeLower;
            this.chestImageUpper.sprite = this.spriteChestBronzeUpper;
            val_11 = this.chestImageUpperClose;
            val_12 = this.spriteChestBronzeUpperClose;
            goto label_28;
            label_19:
            val_10 = this;
            this.chestImageBase.sprite = this.spriteChestSilverBase;
            this.chestImageLower.sprite = this.spriteChestSilverLower;
            this.chestImageUpper.sprite = this.spriteChestSilverUpper;
            val_11 = this.chestImageUpperClose;
            val_12 = this.spriteChestSilverUpperClose;
            label_28:
            val_11.sprite = val_12;
            goto label_33;
            label_20:
            val_10 = this.chestImageBase;
            label_33:
            if(this.chestImageUpper != 0)
            {
                    return;
            }
        
        }
        protected virtual void OnChestClicked()
        {
            if(this.isInteractable == false)
            {
                    return;
            }
            
            if(this.isAnimationActive != false)
            {
                    if(this.isAwaitingPlayerInputForItems == true)
            {
                    this.isAwaitingPlayerInputForItems = false;
                this.isAwaitingPlayerInputForItems = this.isAwaitingPlayerInputForItems;
            }
            
                this.StopAnimatedPointer();
                return;
            }
            
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            var val_2 = 0 + 60;
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  318691280);
        }
        protected virtual void BeginChestReadyFlow()
        {
            UnityEngine.Coroutine val_1 = this.StartCoroutine(routine:  318803280);
        }
        protected virtual System.Collections.IEnumerator BeginChestReadyFlowCoroutine()
        {
            object val_1 = new System.Object();
            typeof(WFOMysteryChestDisplay.<BeginChestReadyFlowCoroutine>d__79).__il2cppRuntimeField_8 = 0;
            typeof(WFOMysteryChestDisplay.<BeginChestReadyFlowCoroutine>d__79).__il2cppRuntimeField_10 = this;
        }
        protected virtual void DoRevealChestAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.labelTapToOpen, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.labelTapToOpen);
            DG.Tweening.TweenCallback val_4 = new DG.Tweening.TweenCallback(object:  319053904, method:  new IntPtr(319007376));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            float val_6 = this.chestCanvasGroupOpened.alpha;
            if(this.chestCanvasGroupOpened < 0)
            {
                goto label_4;
            }
            
            UnityEngine.GameObject val_7 = this.chestCanvasGroupOpened.gameObject;
            if(this.chestCanvasGroupOpened.activeInHierarchy == true)
            {
                goto label_7;
            }
            
            label_4:
            DG.Tweening.TweenCallback val_9 = new DG.Tweening.TweenCallback(object:  319053904, method:  new IntPtr(319016592));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            label_7:
            UnityEngine.GameObject val_11 = this.chestCanvasGroupOpened.gameObject;
            UnityEngine.Transform val_12 = this.chestCanvasGroupOpened.transform;
            UnityEngine.Vector3 val_13 = new UnityEngine.Vector3(x:  1f, y:  null, z:  this.chestCanvasGroupOpened);
            DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.chestCanvasGroupOpened, endValue:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, duration:  1f);
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.chestCanvasGroupOpened);
            UnityEngine.GameObject val_16 = this.chestCanvasGroupOpened.gameObject;
            UnityEngine.Transform val_17 = this.chestCanvasGroupOpened.transform;
            UnityEngine.Vector3 val_18 = new UnityEngine.Vector3(x:  1f, y:  null, z:  this.chestCanvasGroupOpened);
            DG.Tweening.Tweener val_19 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.chestCanvasGroupOpened, endValue:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, duration:  1f);
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.chestCanvasGroupOpened);
            UnityEngine.GameObject val_21 = this.chestCanvasGroupOpened.gameObject;
            UnityEngine.Transform val_22 = this.chestCanvasGroupOpened.transform;
            UnityEngine.Vector3 val_23 = new UnityEngine.Vector3(x:  1f, y:  null, z:  this.chestCanvasGroupOpened);
            DG.Tweening.Tweener val_24 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.chestCanvasGroupOpened, endValue:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, duration:  1f);
            DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.chestCanvasGroupOpened);
        }
        protected void InitTopUI()
        {
            int val_5;
            UnityEngine.Transform val_1 = this.questionChest.parent;
            this.questionChest.SetSiblingIndex(index:  this.questionChest.childCount - 1);
            mem2[0] = 0;
            mem2[0] = 0;
            decimal val_4 = System.Decimal.op_Implicit(value:  319223484);
            this.acornStatViewObj.SetBalanceNow(newBalance:  new System.Decimal() {mid = val_5});
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_8 = TotalAdditionalMultipliers;
            val_8 = val_8 + WordStreak.CurrentStreak;
            string val_9 = System.String.Format(format:  -588332288, arg0:  13152256);
            this.coinStatViewAnimObj.SetBalanceNow(newBalance:  new System.Decimal() {flags = this.statViewCurrentValueCoins, lo = R8, mid = "x{0}"});
            this.mysteryChestStatView.autoUpdate = false;
            this.mysteryChestStatView.SetBalanceNow(collected:  this.rewardItemsSet + 1, total:  this.statViewTotalChests);
            this.shieldStatViewObj.artificalTargetBalance = this.statViewCurrentValueShields;
            this.shieldStatViewObj.UpdateUI(instantly:  true);
        }
        protected void ToggleTapToOpenLabel(bool isVisible)
        {
            if(this.tapToOpenTween != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.tapToOpenTween, complete:  false);
            }
            
            if(isVisible != false)
            {
                    DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.labelTapToOpen, endValue:  null, duration:  null);
                this.tapToOpenTween = this.labelTapToOpen;
                UnityEngine.GameObject val_2 = this.button.gameObject;
                this.DoAnimatedPointer(pointAt:  this.button, delayedShow:  true);
                return;
            }
            
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.labelTapToOpen, endValue:  null, duration:  null);
            this.tapToOpenTween = this.labelTapToOpen;
            this.StopAnimatedPointer();
        }
        protected void DoChestSquashStretchBounce()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.GameObject val_2 = this.chestCanvasGroupOpened.gameObject;
            UnityEngine.Transform val_3 = this.chestCanvasGroupOpened.transform;
            UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.chestCanvasGroupOpened, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  null);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.chestCanvasGroupOpened);
            UnityEngine.GameObject val_7 = this.chestCanvasGroupOpened.gameObject;
            UnityEngine.Transform val_8 = this.chestCanvasGroupOpened.transform;
            UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.chestCanvasGroupOpened, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  null);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.chestCanvasGroupOpened);
            UnityEngine.GameObject val_12 = this.chestCanvasGroupOpened.gameObject;
            UnityEngine.Transform val_13 = this.chestCanvasGroupOpened.transform;
            UnityEngine.Vector3 val_14 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.chestCanvasGroupOpened, endValue:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, duration:  null);
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.chestCanvasGroupOpened);
        }
        private void PauseAllOpenChestSequences(int triggerItemIndex)
        {
            var val_2;
            this.rewardItemIdThatTriggeredPause = triggerItemIndex;
            this.button.interactable = false;
            this.buttonClose.interactable = false;
            val_2 = 4;
            goto label_3;
            label_10:
            if(this.buttonClose <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(2621443 != 0)
            {
                    if(2621443 <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                object val_1 = DG.Tweening.TweenExtensions.Pause<System.Object>(t:  2621443);
            }
            
            val_2 = 5;
            label_3:
            if((val_2 - 4) < 2621443)
            {
                goto label_10;
            }
        
        }
        private void ResumeAllOpenChestSequences()
        {
            var val_2;
            this.buttonClose.interactable = true;
            this.button.interactable = true;
            val_2 = 4;
            goto label_3;
            label_10:
            if(this.button <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(2621443 != 0)
            {
                    if(2621443 <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                object val_1 = DG.Tweening.TweenExtensions.Play<System.Object>(t:  2621443);
            }
            
            val_2 = 5;
            label_3:
            if((val_2 - 4) < 2621443)
            {
                goto label_10;
            }
        
        }
        protected virtual System.Collections.IEnumerator DoOpenChestAnimationSequence()
        {
            object val_1 = new System.Object();
            typeof(WFOMysteryChestDisplay.<DoOpenChestAnimationSequence>d__86).__il2cppRuntimeField_8 = 0;
            typeof(WFOMysteryChestDisplay.<DoOpenChestAnimationSequence>d__86).__il2cppRuntimeField_10 = this;
        }
        private void ExecutePerChestCallbacks()
        {
            var val_7;
            System.Predicate<WordForest.WFORewardData> val_9;
            var val_10;
            var val_11;
            System.Predicate<WordForest.WFORewardData> val_13;
            var val_14;
            val_7 = null;
            val_7 = null;
            val_9 = WFOMysteryChestDisplay.<>c.<>9__87_0;
            if(val_9 == 0)
            {
                    val_9 = null;
                val_9 = new System.Predicate<WordForest.WFORewardData>(object:  WFOMysteryChestDisplay.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(320063760));
                WFOMysteryChestDisplay.<>c.<>9__87_0 = val_9;
            }
            
            if((this.rewardItems.FindIndex(match:  8040448)) != 1)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_10 = null;
                val_10 = null;
                if(WordForest.RaidAttackManager.lastAttackResult == true)
            {
                    val_9 = 1;
            }
            
                NotifyAttackCompleted(isAttackSuccessful:  true);
            }
            
            val_11 = null;
            val_11 = null;
            val_13 = WFOMysteryChestDisplay.<>c.<>9__87_1;
            if(val_13 == 0)
            {
                    val_13 = null;
                val_13 = new System.Predicate<WordForest.WFORewardData>(object:  WFOMysteryChestDisplay.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(320070928));
                WFOMysteryChestDisplay.<>c.<>9__87_1 = val_13;
            }
            
            if((this.rewardItems.FindIndex(match:  8040448)) == 1)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_14 = null;
            val_14 = null;
            if(WordForest.RaidAttackManager.lastRaidPerfect == true)
            {
                    WordForest.RaidAttackManager.lastRaidPerfect = 1;
            }
            
            NotifyRaidCompleted(isRaidPerfect:  true);
        }
        private DG.Tweening.Sequence CreateMiniSeqSegmentShowItemIntro(int itemIndex)
        {
            if(new System.Object() != 0)
            {
                    typeof(WFOMysteryChestDisplay.<>c__DisplayClass88_0).__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[8] = this;
            }
            
            typeof(WFOMysteryChestDisplay.<>c__DisplayClass88_0).__il2cppRuntimeField_C = itemIndex;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            typeof(WFOMysteryChestDisplay.<>c__DisplayClass88_0).__il2cppRuntimeField_10 = 0;
            DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  408571904, method:  new IntPtr(320192144));
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        }
        private DG.Tweening.Sequence CreateMiniSeqSegmentShowItemOuttro(int itemIndex)
        {
            int val_5 = itemIndex;
            if(new System.Object() != 0)
            {
                    typeof(WFOMysteryChestDisplay.<>c__DisplayClass89_0).__il2cppRuntimeField_10 = val_5;
                typeof(WFOMysteryChestDisplay.<>c__DisplayClass89_0).__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[8] = this;
                mem[16] = val_5;
                val_5 = mem[16];
            }
            
            typeof(WFOMysteryChestDisplay.<>c__DisplayClass89_0).__il2cppRuntimeField_C = val_5;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  408625152, method:  new IntPtr(320305168));
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        }
        private WordForest.WFOWordChestItemIcon InstantiateObjectItem(WordForest.WFORewardData rewardData, int itemIndex, bool forOutro = False)
        {
            int val_19;
            int val_20;
            int val_21;
            if(true <= itemIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            rewardData.id = rewardData.id + (itemIndex << 2);
            object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  this.prefabItem, parent:  (rewardData.id + (itemIndex) << 2) + 16);
            UnityEngine.Transform val_2 = this.prefabItem.transform;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            this.prefabItem.localScale = new UnityEngine.Vector3();
            val_19 = rewardData.transformToId;
            object val_4 = this.prefabItem.GetComponent<System.Object>();
            this.prefabItem.Initialize(rewardData:  new WordForest.WFORewardData() {id = rewardData.id, rewardType = rewardData.rewardType, amount = new System.Decimal() {flags = rewardData.amount.flags, hi = val_20, lo = val_21, mid = rewardData.amount.mid}, transformToId = val_19});
            if(forOutro == true)
            {
                    return;
            }
            
            UnityEngine.Transform val_5 = this.prefabItem.transform;
            val_19 = this.prefabItem;
            UnityEngine.Transform val_6 = mem[1152921513517232996].transform;
            UnityEngine.Vector3 val_7 = position;
            UnityEngine.Transform val_9 = mem[1152921513517232996].transform;
            UnityEngine.Vector3 val_10 = position;
            val_21 = 0;
            UnityEngine.Transform val_12 = this.prefabItem.transform;
            UnityEngine.Vector3 val_13 = position;
            UnityEngine.Vector3 val_14 = new UnityEngine.Vector3(x:  val_13.x, y:  val_13.y, z:  val_13.z);
            val_19.position = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            val_20 = 0;
            UnityEngine.Transform val_15 = this.prefabItem.transform;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
            DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.prefabItem, endValue:  new UnityEngine.Vector3(), duration:  val_16.x, snapping:  true);
            object val_18 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.prefabItem, ease:  27);
        }
        protected void DoAnimatedPointer(UnityEngine.GameObject pointAt, bool delayedShow)
        {
            float val_5;
            float val_6;
            float val_7;
            DG.Tweening.TweenCallback val_28;
            object val_1 = new System.Object();
            typeof(WFOMysteryChestDisplay.<>c__DisplayClass91_0).__il2cppRuntimeField_8 = this;
            this.StopAnimatedPointer();
            UnityEngine.Transform val_2 = pointAt.transform;
            UnityEngine.Vector3 val_3 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            UnityEngine.Vector3 val_4 = TransformPoint(position:  new UnityEngine.Vector3() {x = pointAt, y = val_3.x, z = val_3.y});
            UnityEngine.Transform val_8 = this.pointerImage.transform;
            this.pointerImage.position = new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_7};
            DG.Tweening.Sequence val_9 = DG.Tweening.DOTween.Sequence();
            this.pointerSequence = 0;
            DG.Tweening.Sequence val_10 = DG.Tweening.DOTween.Sequence();
            typeof(WFOMysteryChestDisplay.<>c__DisplayClass91_0).__il2cppRuntimeField_C = 0;
            UnityEngine.Transform val_11 = this.pointerImage.transform;
            UnityEngine.Transform val_12 = this.pointerImage.transform;
            UnityEngine.Vector3 val_13 = new UnityEngine.Vector3(x:  val_4.x, y:  val_4.y, z:  val_4.z);
            UnityEngine.Vector3 val_14 = TransformPoint(position:  new UnityEngine.Vector3() {x = this.pointerImage, y = val_13.x, z = val_13.y});
            DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.pointerImage, endValue:  new UnityEngine.Vector3(), duration:  val_14.x, snapping:  true);
            object val_16 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.pointerImage, ease:  7);
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.pointerImage);
            UnityEngine.Transform val_18 = this.pointerImage.transform;
            DG.Tweening.Tweener val_19 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.pointerImage, endValue:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_7}, duration:  val_14.x, snapping:  true);
            object val_20 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.pointerImage, ease:  7);
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.pointerImage);
            object val_22 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  0, loops:  0, loopType:  0);
            object val_23 = DG.Tweening.TweenExtensions.Pause<System.Object>(t:  0);
            if(delayedShow != false)
            {
                    val_28 = null;
                val_28 = new DG.Tweening.TweenCallback(object:  408731648, method:  new IntPtr(320568080));
                DG.Tweening.Tween val_25 = DG.Tweening.DOVirtual.DelayedCall(delay:  val_14.x, callback:  1073741824, ignoreTimeScale:  false);
                this.pointerSequence = 1073741824;
                return;
            }
            
            UnityEngine.GameObject val_26 = this.pointerImage.gameObject;
            val_28 = this.pointerImage;
            val_28.SetActive(value:  true);
            this.pointerSequence = typeof(WFOMysteryChestDisplay.<>c__DisplayClass91_0).__il2cppRuntimeField_C;
            object val_27 = DG.Tweening.TweenExtensions.Play<System.Object>(t:  0);
        }
        protected void StopAnimatedPointer()
        {
            if(this.pointerSequence != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.pointerSequence, complete:  false);
            }
            
            UnityEngine.GameObject val_1 = this.pointerImage.gameObject;
            this.pointerImage.SetActive(value:  false);
        }
        private void InitItemCardPlacementCoords(int itemsToShow)
        {
            float val_8;
            float val_9;
            float val_12;
            var val_30;
            var val_31;
            WordForest.WFOMysteryChestDisplay val_32;
            System.Collections.Generic.List<System.Int32> val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            int val_30 = itemsToShow;
            if(this.tableObj != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.tableObj);
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.itemPlacementCoords = null;
            WordRegion val_3 = WordRegion.instance;
            UnityEngine.Rect val_4 = getSafeAreaRect;
            WordRegion val_5 = WordRegion.instance;
            UnityEngine.Transform val_6 = 0.transform;
            UnityEngine.Vector3 val_7 = position;
            UnityEngine.Transform val_10 = this.transform;
            UnityEngine.Vector3 val_11 = position;
            UnityEngine.Transform val_13 = this.transform;
            UnityEngine.GameObject val_14 = this.CreateTableRoot(parent:  320870352);
            this.tableObj = this;
            val_30 = 0;
            UnityEngine.Transform val_15 = this.transform;
            if(this != 0)
            {
                    if(this == null)
            {
                goto label_14;
            }
            
            }
            
            val_31 = 1;
            goto label_15;
            label_14:
            val_31 = 0;
            val_30 = this;
            label_15:
            this.position = new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_12};
            this.SetSizeWithCurrentAnchors(axis:  0, size:  width);
            val_32 = this;
            this.SetSizeWithCurrentAnchors(axis:  1, size:  height);
            if(val_30 == 7)
            {
                goto label_18;
            }
            
            if(val_30 == 5)
            {
                goto label_19;
            }
            
            if(val_30 != 3)
            {
                goto label_20;
            }
            
            val_33 = null;
            val_33 = new System.Collections.Generic.List<System.Int32>();
            val_34 = 3;
            val_35 = 1152921510720759024;
            goto label_22;
            label_18:
            val_33 = null;
            val_33 = new System.Collections.Generic.List<System.Int32>();
            if(val_33 == 0)
            {
                goto label_23;
            }
            
            Add(item:  2);
            val_36 = public System.Void System.Collections.Generic.List<System.Int32>::Add(System.Int32 item);
            goto label_24;
            label_19:
            val_33 = null;
            val_33 = new System.Collections.Generic.List<System.Int32>();
            if(val_33 == 0)
            {
                goto label_25;
            }
            
            val_36 = public System.Void System.Collections.Generic.List<System.Int32>::Add(System.Int32 item);
            label_24:
            Add(item:  3);
            goto label_26;
            label_20:
            val_33 = null;
            val_33 = new System.Collections.Generic.List<System.Int32>();
            if(val_30 < 1)
            {
                goto label_32;
            }
            
            do
            {
                int val_22 = UnityEngine.Mathf.Min(a:  val_30, b:  3);
                val_30 = val_30 - val_22;
                Add(item:  val_22);
            }
            while(val_30 > 0);
            
            goto label_32;
            label_23:
            Add(item:  2);
            val_37 = public System.Void System.Collections.Generic.List<System.Int32>::Add(System.Int32 item);
            goto label_33;
            label_25:
            val_37 = public System.Void System.Collections.Generic.List<System.Int32>::Add(System.Int32 item);
            label_33:
            Add(item:  3);
            label_26:
            val_34 = 2;
            val_35 = 1152921510720759024;
            label_22:
            Add(item:  2);
            label_32:
            val_38 = 0;
            if( != 0)
            {
                    return;
            }
        
        }
        private UnityEngine.GameObject CreateTableRoot(UnityEngine.Transform parent)
        {
            var val_5;
            var val_6;
            UnityEngine.GameObject val_1 = CreateEmptyGameObject(gName:  320970640, gParent:  parent);
            UnityEngine.Transform val_2 = transform;
            val_5 = 0;
            if("ItemTable" != 0)
            {
                    if("ItemTable" != null)
            {
                    "ItemTable" = 0;
            }
            
                val_5 = "ItemTable";
            }
            
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  0, endValue:  null, duration:  null, snapping:  false);
            object val_4 = AddComponent<System.Object>();
            if("ItemTable" != 0)
            {
                    val_6 = "ItemTable";
                childAlignment = 4;
                childControlHeight = true;
                childControlWidth = true;
            }
            else
            {
                    val_6 = 0;
                0.childAlignment = 4;
                0.childControlHeight = true;
                0.childControlWidth = true;
            }
            
            val_6.childForceExpandWidth = true;
        }
        private UnityEngine.GameObject CreateTableRow(UnityEngine.Transform parent)
        {
            var val_3;
            UnityEngine.GameObject val_1 = CreateEmptyGameObject(gName:  321091952, gParent:  parent);
            object val_2 = AddComponent<System.Object>();
            if("Row" != 0)
            {
                    val_3 = "Row";
                childAlignment = 4;
                childControlWidth = false;
            }
            else
            {
                    val_3 = 0;
                0.childAlignment = 4;
                0.childControlWidth = false;
            }
            
            val_3.childForceExpandWidth = false;
        }
        private UnityEngine.GameObject CreateEmptyGameObject(string gName, UnityEngine.Transform gParent)
        {
            var val_9;
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  gName);
            val_9 = 0;
            if(gParent != 0)
            {
                    UnityEngine.Transform val_3 = transform;
                val_9 = 0;
                SetParent(p:  gParent);
            }
            
            UnityEngine.Transform val_4 = transform;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_6 = transform;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            localPosition = new UnityEngine.Vector3();
            object val_8 = AddComponent<System.Object>();
        }
        private void ShowFtux(WordForest.FtuxId ftuxId)
        {
            int val_8;
            var val_9;
            object val_1 = new System.Object();
            if(val_1 != 0)
            {
                    val_8 = val_1;
                typeof(WFOMysteryChestDisplay.<>c__DisplayClass97_0).__il2cppRuntimeField_8 = ftuxId;
                WFOMysteryChestDisplay.<>c__DisplayClass97_0.__il2cppRuntimeField_name.__il2cppRuntimeField_4 = this;
                WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
                val_9 = 0;
                WFOMysteryChestDisplay.<>c__DisplayClass97_0.__il2cppRuntimeField_name.__il2cppRuntimeField_8 = 0;
            }
            else
            {
                    val_8 = 8;
                mem[8] = ftuxId;
                mem[12] = this;
                WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
                mem[16] = 0;
                val_9 = mem[16];
            }
            
            if((MonoExtensions.IsBitSet(value:  132, bit:  val_8)) != false)
            {
                    return;
            }
            
            if(this.ftuxRoot != 0)
            {
                    mem[8] - 11 = 1;
            }
            
            this.ftuxRoot.SetActive(value:  true);
            DG.Tweening.TweenCallback val_6 = new DG.Tweening.TweenCallback(object:  408784896, method:  new IntPtr(321345728));
            DG.Tweening.Tween val_7 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1017370378, ignoreTimeScale:  false);
        }
        private void OnFtuxButtonClicked()
        {
            this.ftuxRoot.SetActive(value:  false);
            this.ResumeAllOpenChestSequences();
        }
        public WFOMysteryChestDisplay()
        {
            System.Collections.Generic.List<WordPets.WordPetType> val_1 = new System.Collections.Generic.List<WordPets.WordPetType>();
            this.chestTypeSet = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.rewardItemsSet = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.itemDisplaySeqList = null;
            this.rewardItemIdThatTriggeredPause = 0;
        }
        private bool <BeginChestReadyFlowCoroutine>b__79_0()
        {
            bool val_1 = this.isAnimationActive;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        private void <BeginChestReadyFlowCoroutine>b__79_1()
        {
            this.button.interactable = true;
        }
        private void <DoRevealChestAnimation>b__80_0()
        {
            this.StopAnimatedPointer();
        }
        private void <DoRevealChestAnimation>b__80_1()
        {
            this.chestCanvasGroupClosed.alpha = null;
            UnityEngine.GameObject val_1 = this.chestCanvasGroupOpened.gameObject;
            this.chestCanvasGroupOpened.SetActive(value:  true);
            this.chestCanvasGroupOpened.alpha = null;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFillAmount(target:  this.chestOpenRay, endValue:  null, duration:  null);
        }
    
    }

}
