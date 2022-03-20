using UnityEngine;

namespace WordForest
{
    public class WFOWordChestDisplay : MonoBehaviour
    {
        // Fields
        private UnityEngine.CanvasGroup parentCanvasGroup;
        private UnityEngine.RectTransform chestRootTransform;
        private UnityEngine.UI.Button button;
        private UnityEngine.UI.Text labelTapToOpen;
        private UnityEngine.UI.Image lockImage;
        private UnityEngine.GameObject chestOverlay;
        private UnityEngine.GameObject unlockTooltip;
        private UnityEngine.UI.Text unlockTooltipText;
        private UnityEngine.UI.Image pointerImage;
        private UnityEngine.GameObject radialRayObject;
        private UnityEngine.UI.Image chestImageBase;
        private UnityEngine.UI.Image chestImageUpper;
        private UnityEngine.UI.Image chestImageLower;
        private UnityEngine.CanvasGroup chestLabelsCanvasGroup;
        private UnityEngine.UI.Text counterLabel;
        private UnityEngine.UI.Image meterFill;
        private UnityEngine.CanvasGroup chestCanvasGroupClosed;
        private UnityEngine.CanvasGroup chestCanvasGroupOpened;
        private UnityEngine.UI.Image chestOpenRay;
        private UnityEngine.GameObject prefabItem;
        private WordForest.WFOAcornMultiplierTrailParticle prefabItemTrailEfx;
        private WordForest.WFOAcornMultiplierTrailParticle prefabAcornMultiplierEfx;
        private UnityEngine.Sprite spriteChestGoldBase;
        private UnityEngine.Sprite spriteChestGoldUpper;
        private UnityEngine.Sprite spriteChestGoldLower;
        private UnityEngine.Sprite spriteChestSilverBase;
        private UnityEngine.Sprite spriteChestSilverUpper;
        private UnityEngine.Sprite spriteChestSilverLower;
        private UnityEngine.Sprite spriteChestBronzeBase;
        private UnityEngine.Sprite spriteChestBronzeUpper;
        private UnityEngine.Sprite spriteChestBronzeLower;
        private static bool <isChestReadyFlowActivated>k__BackingField;
        private bool isInteractable;
        private bool isAnimationActive;
        private DG.Tweening.Tweener meterFillTweener;
        private decimal creditsBeforeChestOpen;
        private System.Nullable<UnityEngine.Vector3> originalDisplayScale;
        private DG.Tweening.Tween radialRayTween;
        private UnityEngine.Transform originalParent;
        
        // Properties
        private WordForest.WFOWordChestType chestType { get; }
        public static bool isChestReadyFlowActivated { get; set; }
        private bool CanShowFtux { get; }
        protected bool IsFirstTimeOpeningChest { get; set; }
        
        // Methods
        private WordForest.WFOWordChestType get_chestType()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
            if((public static WordForest.WFOWordChestManager MonoSingleton<WordForest.WFOWordChestManager>::get_Instance()) != 0)
            {
                    return;
            }
        
        }
        public static bool get_isChestReadyFlowActivated()
        {
            return (bool)WordForest.WFOWordChestDisplay.<isChestReadyFlowActivated>k__BackingField;
        }
        private static void set_isChestReadyFlowActivated(bool value)
        {
            WordForest.WFOWordChestDisplay.<isChestReadyFlowActivated>k__BackingField = value;
        }
        private bool get_CanShowFtux()
        {
            var val_7;
            GameBehavior val_1 = App.getBehavior;
            val_7 = 0;
            if(0 != 2)
            {
                    return (bool)val_7;
            }
            
            WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
            val_7 = 0;
            WordForest.WFOGameEcon val_3 = WordForest.WFOGameEcon.Instance;
            if(19 != 5761501)
            {
                    return (bool)val_7;
            }
            
            WordForest.WFOPlayer val_4 = WordForest.WFOPlayer.Instance;
            val_7 = (MonoExtensions.IsBitSet(value:  213844506, bit:  1)) ^ 1;
            return (bool)val_7;
        }
        protected bool get_IsFirstTimeOpeningChest()
        {
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            if(this != 0)
            {
                    return MonoExtensions.IsBitSet(value:  346285024, bit:  6);
            }
            
            return MonoExtensions.IsBitSet(value:  346285024, bit:  6);
        }
        protected void set_IsFirstTimeOpeningChest(bool value)
        {
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
            mem[1152921513543178904] = MonoExtensions.SetUnsetBit(value:  346397024, bit:  6, isOn:  value);
        }
        protected void Start()
        {
            var val_8;
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Transform val_2 = this.transform;
            UnityEngine.Transform val_3 = this.parent;
            this.originalParent = this;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_5 = new System.Action(object:  346519264, method:  new IntPtr(346485024));
            System.Delegate val_6 = System.Delegate.Combine(a:  public static WordForest.WFOWordChestManager MonoSingleton<WordForest.WFOWordChestManager>::get_Instance().__il2cppRuntimeField_C, b:  7454720);
            val_8 = public static WordForest.WFOWordChestManager MonoSingleton<WordForest.WFOWordChestManager>::get_Instance().__il2cppRuntimeField_C;
            if(val_8 != 0)
            {
                    if(val_8 == null)
            {
                goto label_8;
            }
            
            }
            
            val_8 = 0;
            label_8:
            public static WordForest.WFOWordChestManager MonoSingleton<WordForest.WFOWordChestManager>::get_Instance().__il2cppRuntimeField_C = val_8;
            UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  346519264, method:  new IntPtr(346494240));
            this.button.m_OnClick.AddListener(call:  162246656);
            this.Initialize();
        }
        protected void OnDestroy()
        {
            var val_6;
            System.Action val_7;
            var val_8;
            val_6 = 1152921504901095424;
            val_7 = 1152921513542593568;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(345812000 == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_7 = null;
            val_7 = new System.Action(object:  346639456, method:  new IntPtr(346485024));
            System.Delegate val_5 = System.Delegate.Remove(source:  public static WordForest.WFOWordChestManager MonoSingleton<WordForest.WFOWordChestManager>::get_Instance().__il2cppRuntimeField_C, value:  7454720);
            val_8 = public static WordForest.WFOWordChestManager MonoSingleton<WordForest.WFOWordChestManager>::get_Instance().__il2cppRuntimeField_C;
            if(val_8 != 0)
            {
                    if(val_8 == null)
            {
                goto label_11;
            }
            
            }
            
            val_8 = 0;
            label_11:
            public static WordForest.WFOWordChestManager MonoSingleton<WordForest.WFOWordChestManager>::get_Instance().__il2cppRuntimeField_C = val_8;
        }
        public void SetInteractable(bool isInteractable, bool darkenLock = False)
        {
            bool val_4;
            UnityEngine.GameObject val_5;
            UnityEngine.GameObject val_1 = this.gameObject;
            this.SetActive(value:  isInteractable);
            this.isInteractable = isInteractable;
            UnityEngine.GameObject val_2 = this.lockImage.gameObject;
            val_4 = isInteractable ^ 1;
            this.lockImage.SetActive(value:  val_4);
            val_5 = this.chestOverlay;
            val_5.SetActive(value:  val_4);
            if(darkenLock == false)
            {
                    return;
            }
            
            UnityEngine.Color val_3 = new UnityEngine.Color(r:  null, g:  null, b:  null);
            this.lockImage.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_5};
        }
        private void Initialize()
        {
            this.SetInteractable(isInteractable:  false, darkenLock:  false);
        }
        private void OnWordChestUpdated()
        {
            this.UpdateChestLabels(skipAnimation:  false);
            GameBehavior val_1 = App.getBehavior;
            if(0 != 2)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(IsChestReady == false)
            {
                    return;
            }
            
            R4.BeginChestReadyFlow();
        }
        private void UpdateChestLabels(bool skipAnimation = False)
        {
            UnityEngine.UI.Text val_25;
            var val_26;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordForest.WFOPlayer val_4 = WordForest.WFOPlayer.Instance;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordForest.WFOPlayer val_7 = WordForest.WFOPlayer.Instance;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordForest.WFOPlayer val_9 = WordForest.WFOPlayer.Instance;
            float val_25 = (float)public static WordForest.WFOWordChestManager MonoSingleton<WordForest.WFOWordChestManager>::get_Instance().__il2cppRuntimeField_144;
            val_25 = this.counterLabel;
            string val_10 = (public static WordForest.WFOWordChestManager MonoSingleton<WordForest.WFOWordChestManager>::get_Instance().__il2cppRuntimeField_140 - public static WordForest.WFOWordChestManager MonoSingleton<WordFo.ToString();
            val_26;
            if(this.meterFillTweener != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.meterFillTweener, complete:  false);
            }
            
            val_25 = val_25 / ((float)public static WordForest.WFOWordChestManager MonoSingleton<WordForest.WFOWordChestManager>::get_Instance().__il2cppRuntimeField_140);
            if(skipAnimation != false)
            {
                    this.meterFill.fillAmount = public static WordForest.WFOWordChestManager MonoSingleton<WordForest.WFOWordChestManager>::get_Instance().__il2cppRuntimeField_140;
                return;
            }
            
            DG.Tweening.Sequence val_11 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Transform val_12 = this.button.transform;
            DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.button, endValue:  public static WordForest.WFOWordChestManager MonoSingleton<WordForest.WFOWordChestManager>::get_Instance().__il2cppRuntimeField_140, duration:  null);
            val_26 = 1152921509932985248;
            object val_14 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.button, ease:  27);
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.button);
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  public static WordForest.WFOWordChestManager MonoSingleton<WordForest.WFOWordChestManager>::get_Instance().__il2cppRuntimeField_140);
            UnityEngine.Transform val_17 = this.button.transform;
            DG.Tweening.Tweener val_18 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.button, endValue:  public static WordForest.WFOWordChestManager MonoSingleton<WordForest.WFOWordChestManager>::get_Instance().__il2cppRuntimeField_140, duration:  null);
            object val_19 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.button, ease:  27);
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.button);
            this.isAnimationActive = true;
            DG.Tweening.Tweener val_21 = DG.Tweening.ShortcutExtensions46.DOFillAmount(target:  this.meterFill, endValue:  public static WordForest.WFOWordChestManager MonoSingleton<WordForest.WFOWordChestManager>::get_Instance().__il2cppRuntimeField_140, duration:  null);
            object val_22 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.meterFill, ease:  1);
            val_25 = null;
            val_25 = new DG.Tweening.TweenCallback(object:  347137632, method:  new IntPtr(347112608));
            object val_24 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.meterFill, action:  190734336);
            this.meterFillTweener = this.meterFill;
        }
        private void ResetChestVisualState()
        {
            float val_8;
            float val_9;
            float val_10;
            float val_13;
            float val_14;
            float val_15;
            UnityEngine.UI.Image val_17;
            UnityEngine.UI.Image val_18;
            UnityEngine.Sprite val_19;
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Transform val_2 = this.transform;
            UnityEngine.Vector3 val_3 = Value;
            this.localScale = new UnityEngine.Vector3();
            this.chestCanvasGroupClosed.alpha = val_3.x;
            UnityEngine.GameObject val_4 = this.chestCanvasGroupClosed.gameObject;
            this.chestCanvasGroupClosed.SetActive(value:  true);
            UnityEngine.GameObject val_5 = this.chestCanvasGroupOpened.gameObject;
            this.chestCanvasGroupOpened.SetActive(value:  false);
            this.chestCanvasGroupOpened.alpha = val_3.x;
            this.chestOpenRay.fillAmount = val_3.x;
            UnityEngine.GameObject val_6 = this.chestLabelsCanvasGroup.gameObject;
            this.chestLabelsCanvasGroup.SetActive(value:  true);
            UnityEngine.Color val_7 = color;
            this.labelTapToOpen.color = new UnityEngine.Color() {r = val_8, g = val_9, b = val_10, a = 1f};
            UnityEngine.GameObject val_11 = this.labelTapToOpen.gameObject;
            this.labelTapToOpen.SetActive(value:  false);
            UnityEngine.Color val_12 = color;
            this.counterLabel.color = new UnityEngine.Color() {r = val_13, g = val_14, b = val_15, a = 1f};
            WordForest.WFOWordChestType val_16 = this.counterLabel.chestType;
            if(this.counterLabel == 1)
            {
                goto label_18;
            }
            
            if(this.counterLabel == 2)
            {
                goto label_19;
            }
            
            if(this.counterLabel != 3)
            {
                goto label_20;
            }
            
            val_17 = this;
            this.chestImageBase.sprite = this.spriteChestGoldBase;
            this.chestImageLower.sprite = this.spriteChestGoldLower;
            val_18 = this.chestImageUpper;
            val_19 = this.spriteChestGoldUpper;
            goto label_26;
            label_18:
            val_17 = this;
            this.chestImageBase.sprite = this.spriteChestBronzeBase;
            this.chestImageLower.sprite = this.spriteChestBronzeLower;
            val_18 = this.chestImageUpper;
            val_19 = this.spriteChestBronzeUpper;
            goto label_26;
            label_19:
            val_17 = this;
            this.chestImageBase.sprite = this.spriteChestSilverBase;
            this.chestImageLower.sprite = this.spriteChestSilverLower;
            val_18 = this.chestImageUpper;
            val_19 = this.spriteChestSilverUpper;
            label_26:
            val_18.sprite = val_19;
            goto label_30;
            label_20:
            val_17 = this.chestImageBase;
            label_30:
            if(this.chestImageUpper != 0)
            {
                    return;
            }
        
        }
        protected void OnChestClicked()
        {
            var val_16;
            var val_17;
            var val_18;
            val_16 = this;
            if(this.isInteractable == false)
            {
                goto label_1;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(IsChestReady != false)
            {
                    GameBehavior val_3 = App.getBehavior;
                if(0 == 2)
            {
                    WordForest.WFOPlayer val_4 = WordForest.WFOPlayer.Instance;
                this.BeginChestReadyFlow();
                return;
            }
            
            }
            
            GameBehavior val_5 = App.getBehavior;
            if(0 != 0)
            {
                goto (1179403647 + (public WordForest.WFOWordChestProgressPopup MetaGameBehavior::ShowUGUIMonolith<WordForest.WFOWordChestProgressPopup>(bool showNext).__il2cppRuntimeField_28) << 3) + 192;
            }
            
            goto (1179403647 + (public WordForest.WFOWordChestProgressPopup MetaGameBehavior::ShowUGUIMonolith<WordForest.WFOWordChestProgressPopup>(bool showNext).__il2cppRuntimeField_28) << 3) + 192;
            label_1:
            GameBehavior val_7 = App.getBehavior;
            if(0 == 5)
            {
                    WordForest.WFOGameEcon val_8 = WordForest.WFOGameEcon.Instance;
                string val_9 = System.String.Format(format:  347617184, arg0:  13152256);
                val_17 = "Reach Forest Level {0} to Unlock";
                if((R4 + 36) != 0)
            {
                    val_18 = R4 + 36.activeSelf;
            }
            else
            {
                    val_18 = 0.activeSelf;
            }
            
                R4 + 36.SetActive(value:  val_18 ^ 1);
            }
            
            var val_13 = FP - 16;
        }
        protected void BeginChestReadyFlow()
        {
            var val_3;
            if((WordForest.WFOWordChestDisplay.<isChestReadyFlowActivated>k__BackingField) == true)
            {
                    return;
            }
            
            val_3 = mem[R5 + 92];
            val_3 = R5 + 92;
            mem2[0] = 1;
            System.Collections.IEnumerator val_1 = R4.BeginChestReadyFlowCoroutine();
            UnityEngine.Coroutine val_2 = R4.StartCoroutine(routine:  R4);
        }
        protected System.Collections.IEnumerator BeginChestReadyFlowCoroutine()
        {
            object val_1 = new System.Object();
            typeof(WFOWordChestDisplay.<BeginChestReadyFlowCoroutine>d__58).__il2cppRuntimeField_8 = 0;
            typeof(WFOWordChestDisplay.<BeginChestReadyFlowCoroutine>d__58).__il2cppRuntimeField_10 = this;
        }
        private System.Collections.IEnumerator BeginChestFtuxFlow()
        {
            object val_1 = new System.Object();
            typeof(WFOWordChestDisplay.<BeginChestFtuxFlow>d__59).__il2cppRuntimeField_8 = 0;
            typeof(WFOWordChestDisplay.<BeginChestFtuxFlow>d__59).__il2cppRuntimeField_10 = this;
        }
        private System.Collections.IEnumerator DoNewChestAnimationSequence(bool isFtux = False)
        {
            typeof(WFOWordChestDisplay.<DoNewChestAnimationSequence>d__60).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(WFOWordChestDisplay.<DoNewChestAnimationSequence>d__60).__il2cppRuntimeField_10 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            typeof(WFOWordChestDisplay.<DoNewChestAnimationSequence>d__60).__il2cppRuntimeField_14 = isFtux;
        }
        protected void OnOpenChestAnimationSequenceComplete()
        {
            this.ResetChestVisualState();
            System.Collections.IEnumerator val_1 = this.DoNewChestAnimationSequence(isFtux:  false);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  348201328);
        }
        public WFOWordChestDisplay()
        {
        
        }
        private void <UpdateChestLabels>b__54_0()
        {
            this.isAnimationActive = false;
        }
        private bool <BeginChestReadyFlowCoroutine>b__58_1()
        {
            bool val_1 = this.isAnimationActive;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
    
    }

}
