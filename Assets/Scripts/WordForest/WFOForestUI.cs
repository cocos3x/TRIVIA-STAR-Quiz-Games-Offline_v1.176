using UnityEngine;

namespace WordForest
{
    public class WFOForestUI : MonoSingleton<WordForest.WFOForestUI>
    {
        // Fields
        private UnityEngine.CanvasGroup titleGroup;
        private UnityEngine.CanvasGroup eventButtonsGroup;
        private UnityEngine.CanvasGroup growGroup;
        private UnityEngine.CanvasGroup congratulationsGroup;
        private UnityEngine.CanvasGroup continueGroup;
        private UnityEngine.UI.Image darkOverlay;
        private UnityEngine.UI.Image bottomBackground;
        private UnityEngine.ParticleSystem congratParticleLeft;
        private UnityEngine.ParticleSystem congratParticleRight;
        private UnityEngine.Transform forestContentParent;
        private UnityEngine.UI.Text forestNameText;
        private UnityEngine.UI.Text growthProgressText;
        private UnityEngine.UI.Slider growthProgress;
        private UnityEngine.UI.Text growthCostText;
        private UnityEngine.UI.Text currentLevelText;
        private UnityEngine.UI.Button homeButton;
        private UnityEngine.UI.Button forestInfoButton;
        private UGUINetworkedButtonMultiGraphic growButton;
        private UnityEngine.UI.Text growButtonText;
        private UnityEngine.UI.Button playButton;
        private UnityEngine.UI.Button forestNameButton;
        private UnityEngine.UI.Button continueButton;
        private UnityEngine.UI.Button forestChestButton;
        private WordForest.WFOForestContent forestContent;
        private UnityEngine.GameObject FTUXTooltip_1;
        private UnityEngine.GameObject FTUXTooltip_3;
        private UnityEngine.GameObject FTUXPointer;
        private UnityEngine.UI.Image growButtonGlow;
        private UnityEngine.UI.Button tooltipContinueButton;
        private UnityEngine.Transform forestChestPointerScaler;
        private UnityEngine.UI.Image continueButtonGlow;
        private UnityEngine.Transform continueButtonPointerScaler;
        private WordForest.WFOSeedParticles seedParticlesPrefab;
        private UGUINetworkedButtonMultiGraphic prefabButtonFixTree;
        private DG.Tweening.Sequence forestChestPointerSequence;
        private WordForest.WFOForestManager forestManager;
        private UGUINetworkedButtonMultiGraphic buttonFixTree;
        private int currentHighlightedFixTreeId;
        
        // Methods
        private void OnPlayerDataUpdated()
        {
            this.InitialiseForestLayout();
            this.InitializeUI();
            this.UpdateForestInfo(animated:  false, skipButtonStates:  false);
        }
        private void Start()
        {
            var val_15;
            var val_35;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.forestManager = public static WordForest.WFOForestManager MonoSingleton<WordForest.WFOForestManager>::get_Instance();
            if(this.forestInfoButton != 0)
            {
                    UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  300054560, method:  new IntPtr(299978336));
                this.forestInfoButton.m_OnClick.AddListener(call:  162246656);
            }
            
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  300054560, method:  new IntPtr(299983456));
            this.growButton.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  300054560, method:  new IntPtr(299992672));
            this.forestNameButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  300054560, method:  new IntPtr(300001888));
            this.continueButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  300054560, method:  new IntPtr(300011104));
            this.forestChestButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  300054560, method:  new IntPtr(300020320));
            this.tooltipContinueButton.m_OnClick.AddListener(call:  162246656);
            NotificationCenter val_9 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  300054560, name:  404738048);
            Player val_10 = App.Player;
            string val_11 = 0.ToString();
            string val_12 = System.String.Format(format:  2127161280, arg0:  300042504);
            this.InitialiseForestLayout();
            this.InitializeUI();
            this.UpdateForestInfo(animated:  false, skipButtonStates:  false);
            val_35 = this.forestManager.CurrentForestGrowth;
            WordForest.WFOForestData val_14 = CurrentForestData;
            if(val_35 >= val_15)
            {
                    bool val_16 = val_14.stages + 152.IsAtLastForest;
                if(val_16 == false)
            {
                    val_16 = val_14.stages;
                val_16.OnContinueButtonClicked();
            }
            
            }
            
            if((val_14.stages + 152.IsForestChestCollected) != true)
            {
                    val_14.stages.CueForestChestPointerAnim(delay:  null);
            }
            
            WordForest.WFOPlayer val_18 = WordForest.WFOPlayer.Instance;
            if((MonoExtensions.IsBitSet(value:  132, bit:  2)) != false)
            {
                    if((MonoExtensions.IsBitSet(value:  132, bit:  3)) == true)
            {
                goto label_37;
            }
            
            }
            
            if(19 > 1)
            {
                goto label_35;
            }
            
            val_35 = 0;
            if((val_35.CurrentForestGrowth(includeDamagedTrees:  true)) < 1)
            {
                goto label_37;
            }
            
            label_35:
            int val_22 = MonoExtensions.SetBit(value:  132, bit:  5);
            mem[312] = val_22;
            int val_23 = MonoExtensions.SetBit(value:  val_22, bit:  2);
            mem[312] = val_23;
            mem[312] = MonoExtensions.SetBit(value:  val_23, bit:  3);
            label_37:
            WordForest.WFOPlayer val_25 = WordForest.WFOPlayer.Instance;
            if((MonoExtensions.IsBitSet(value:  mem[312], bit:  2)) == false)
            {
                goto label_39;
            }
            
            WordForest.WFOPlayer val_27 = WordForest.WFOPlayer.Instance;
            if((MonoExtensions.IsBitSet(value:  mem[312], bit:  3)) == false)
            {
                goto label_41;
            }
            
            WordForest.WFOPlayer val_29 = WordForest.WFOPlayer.Instance;
            if((MonoExtensions.IsBitSet(value:  mem[312], bit:  4)) == true)
            {
                goto label_49;
            }
            
            Player val_31 = App.Player;
            val_35 = 4;
            int val_33 = val_14.stages + 152.GetGrowOrFixCost(growthLevel:  0.CurrentForestGrowth);
            if(4 >= val_33)
            {
                    val_33 = val_14.stages;
                val_33.StartFTUX_3();
            }
            
            goto label_49;
            label_39:
            val_14.stages.StartFTUX_1();
            goto label_49;
            label_41:
            val_14.stages.StartFTUX_2();
            label_49:
            System.Action val_34 = new System.Action(object:  val_14.stages, method:  new IntPtr(300029536));
            DeviceKeypressManager.AddBackAction(backAction:  7454720);
        }
        private void OnDestroy()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.RemoveObserver(observer:  300223904, name:  404738048);
        }
        private void OnDisable()
        {
            System.Action val_1 = new System.Action(object:  300335904, method:  new IntPtr(300029536));
            DeviceKeypressManager.RemoveBackAction(backAction:  7454720);
        }
        private DG.Tweening.Sequence DoCompleteForestSequence()
        {
            var val_52;
            var val_53;
            DG.Tweening.TweenCallback val_55;
            var val_56;
            float val_57;
            WordForest.WFOForestManager val_58;
            val_52 = 1152921504797741056;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.titleGroup, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.titleGroup);
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.eventButtonsGroup, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.eventButtonsGroup);
            val_53 = null;
            val_53 = null;
            val_55 = WFOForestUI.<>c.<>9__42_0;
            if(val_55 == 0)
            {
                    val_55 = null;
                val_55 = new DG.Tweening.TweenCallback(object:  WFOForestUI.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(300432096));
                WFOForestUI.<>c.<>9__42_0 = val_55;
            }
            
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.darkOverlay, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.darkOverlay);
            DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.congratulationsGroup, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.congratulationsGroup);
            val_57 = 1152921504797581312;
            DG.Tweening.TweenCallback val_12 = new DG.Tweening.TweenCallback(object:  300500128, method:  new IntPtr(300441312));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.TweenCallback val_14 = new DG.Tweening.TweenCallback(object:  300500128, method:  new IntPtr(300442336));
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            val_58 = this.forestManager;
            if(val_58.IsAtLastForest != false)
            {
                    GameBehavior val_17 = App.getBehavior;
                if(0 != 0)
            {
                    return;
            }
            
                return;
            }
            
            DG.Tweening.Tweener val_19 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.continueGroup, endValue:  null, duration:  null);
            DG.Tweening.TweenCallback val_20 = new DG.Tweening.TweenCallback(object:  300500128, method:  new IntPtr(300452576));
            object val_21 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.continueGroup, action:  190734336);
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.continueGroup);
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            DG.Tweening.Tweener val_25 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.darkOverlay, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.darkOverlay);
            DG.Tweening.TweenCallback val_27 = new DG.Tweening.TweenCallback(object:  300500128, method:  new IntPtr(300457696));
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.TweenCallback val_29 = new DG.Tweening.TweenCallback(object:  300500128, method:  new IntPtr(300458720));
            DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Sequence val_31 = DG.Tweening.DOTween.Sequence();
            val_52 = 0;
            DG.Tweening.Tweener val_32 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.continueButtonGlow, endValue:  null, duration:  null);
            val_57 = 1152921509932985248;
            object val_33 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.continueButtonGlow, ease:  7);
            DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.continueButtonGlow);
            DG.Tweening.Tweener val_35 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.continueButtonGlow, endValue:  null, duration:  null);
            object val_36 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.continueButtonGlow, ease:  7);
            DG.Tweening.Sequence val_37 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.continueButtonGlow);
            object val_38 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  0, loops:  999, loopType:  0);
            DG.Tweening.Sequence val_39 = DG.Tweening.DOTween.Sequence();
            val_58 = this.continueButtonPointerScaler;
            val_56 = 0;
            UnityEngine.Transform val_40 = val_58.transform;
            DG.Tweening.Tweener val_41 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_58, endValue:  null, duration:  null);
            object val_42 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_58, ease:  5);
            DG.Tweening.Sequence val_43 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  val_58);
            UnityEngine.Transform val_44 = this.continueButtonPointerScaler.transform;
            DG.Tweening.Tweener val_45 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.continueButtonPointerScaler, endValue:  null, duration:  null);
            object val_46 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.continueButtonPointerScaler, ease:  5);
            DG.Tweening.Sequence val_47 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.continueButtonPointerScaler);
            DG.Tweening.Sequence val_48 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            object val_49 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  0, loops:  999, loopType:  0);
            DG.Tweening.Sequence val_50 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  0);
            DG.Tweening.Sequence val_51 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  0);
        }
        private void StartFTUX_1()
        {
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            if((MonoExtensions.IsBitSet(value:  132, bit:  5)) != true)
            {
                    WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
                WordForest.WFOPlayer val_4 = WordForest.WFOPlayer.Instance;
                int val_5 = MonoExtensions.SetBit(value:  132, bit:  5);
                mem[312] = val_5;
                val_5.TrackAmplitudeInitialForestEntry();
            }
            
            this.FTUXTooltip_1.SetActive(value:  true);
            this.FTUXPointer.SetActive(value:  true);
            UnityEngine.GameObject val_6 = this.growButtonGlow.gameObject;
            this.growButtonGlow.SetActive(value:  true);
            this.homeButton.interactable = false;
            if(this.forestInfoButton != 0)
            {
                    this.forestInfoButton.interactable = false;
            }
            
            this.forestNameButton.interactable = false;
            this.playButton.interactable = false;
            this.StartGrowButtonPointerAnim();
        }
        private void EndFTUX_1()
        {
            this.FTUXTooltip_1.SetActive(value:  false);
            this.FTUXPointer.SetActive(value:  false);
            UnityEngine.GameObject val_1 = this.growButtonGlow.gameObject;
            this.growButtonGlow.SetActive(value:  false);
            this.growButton.interactable = false;
            WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
            WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
            mem[312] = MonoExtensions.SetBit(value:  132, bit:  2);
            DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  300852128, method:  new IntPtr(300827104));
            DG.Tweening.Tween val_6 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1075838976, ignoreTimeScale:  false);
        }
        private void StartFTUX_2()
        {
            this.growButton.interactable = true;
            UnityEngine.GameObject val_1 = this.growButtonGlow.gameObject;
            this.growButtonGlow.SetActive(value:  true);
            this.FTUXPointer.SetActive(value:  true);
            this.homeButton.interactable = false;
            if(this.forestInfoButton != 0)
            {
                    this.forestInfoButton.interactable = false;
            }
            
            this.forestNameButton.interactable = false;
            this.playButton.interactable = false;
            this.StartGrowButtonPointerAnim();
        }
        private void EndFTUX_2()
        {
            this.FTUXPointer.SetActive(value:  false);
            this.growButton.interactable = false;
            UnityEngine.GameObject val_1 = this.growButtonGlow.gameObject;
            this.growButtonGlow.SetActive(value:  false);
            WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
            WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
            mem[312] = MonoExtensions.SetBit(value:  132, bit:  3);
            DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  301171360, method:  new IntPtr(301146336));
            DG.Tweening.Tween val_6 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1075838976, ignoreTimeScale:  false);
        }
        private void StartFTUX_3()
        {
            this.FTUXTooltip_3.SetActive(value:  true);
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
            mem[312] = MonoExtensions.SetBit(value:  132, bit:  4);
        }
        private void InitializeUI()
        {
            var val_3;
            float val_9;
            float val_10;
            var val_11;
            float val_12;
            var val_13;
            int val_1 = this.forestManager.CurrentForestGrowth;
            WordForest.WFOForestData val_2 = CurrentForestData;
            bool val_4 = val_2.stages + 152.IsForestChestCollected;
            if(val_1 >= val_3)
            {
                    bool val_5 = val_2.stages + 152.IsAtLastForest;
                val_9 = 1f;
                val_10 = 0f;
                val_11 = val_5 ^ 1;
                val_12 = 0;
                if(val_5 == true)
            {
                    val_13 = 0;
            }
            
            }
            else
            {
                    val_12 = 1f;
                val_9 = 0f;
                val_11 = 0;
                val_13 = 0;
                if(val_4 == true)
            {
                    val_10 = 1f;
            }
            
            }
            
            val_2.stages + 24.alpha = null;
            PluginExtension.SetColorAlpha(graphic:  val_2.stages + 32, a:  null);
            val_2.stages + 28.alpha = null;
            val_2.stages + 28.blocksRaycasts = false;
            val_2.stages + 12.alpha = null;
            val_2.stages + 16.alpha = null;
            val_2.stages + 20.alpha = null;
            if(val_1 < val_3)
            {
                    0 = 1;
            }
            
            val_2.stages + 20.blocksRaycasts = true;
            PluginExtension.SetColorAlpha(graphic:  val_2.stages + 36, a:  null);
            UnityEngine.GameObject val_7 = val_2.stages + 100.gameObject;
            val_2.stages + 100.SetActive(value:  val_4 ^ 1);
        }
        private void InitialiseForestLayout()
        {
            int val_4;
            if(this.forestContent != 0)
            {
                    UnityEngine.GameObject val_2 = this.forestContent.gameObject;
                UnityEngine.Object.Destroy(obj:  this.forestContent);
                this.forestContent = 0;
            }
            
            WordForest.WFOForestData val_3 = CurrentForestData;
            WordForest.WFOForestContent val_5 = val_3.bgType.GetForestLayout(forestId:  val_4);
            object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  val_3.bgType, parent:  val_3.stages + 48);
            mem2[0] = val_3.bgType;
            WordForest.WFOPlayer val_7 = WordForest.WFOPlayer.Instance;
            val_3.bgType.Initialize(forestMap:  0);
        }
        private void UpdateForestInfo(bool animated = False, bool skipButtonStates = False)
        {
            var val_4;
            int val_7;
            object val_10;
            var val_38;
            float val_39;
            var val_40;
            var val_41;
            float val_42;
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            int val_2 = this.forestManager.CurrentForestGrowth;
            WordForest.WFOForestData val_3 = CurrentForestData;
            val_38 = val_4;
            val_39 = val_3.stages + 152.CurrentForestContainsDamagedTrees;
            val_3.stages + 80.WaitingStatus(waiting:  false);
            if(val_3.bgType == 0)
            {
                    if(val_2 < val_38)
            {
                    0 = 1;
            }
            
                val_3.stages + 80.interactable = true;
                if(val_2 >= val_38)
            {
                    0 = 1;
            }
            
                val_3.stages + 96.interactable = true;
            }
            
            WordForest.WFOForestData val_6 = CurrentForestData;
            string val_8 = val_7.ToString();
            WordForest.WFOForestData val_9 = CurrentForestData;
            string val_11 = System.String.Format(format:  291109824, arg0:  301670876, arg1:  val_10);
            val_7 = val_2;
            string val_12 = System.String.Format(format:  301656800, arg0:  13152256, arg1:  13152256);
            GameEcon val_15 = App.getGameEcon;
            string val_16 = val_9.stages + 152.GetGrowOrFixCost(growthLevel:  val_9.stages + 56.CurrentForestGrowth).ToString(format:  null);
            if((val_9.stages + 152.GetGrowOrFixCost(growthLevel:  val_9.stages + 64.CurrentForestGrowth)) >= 1000)
            {
                    0 = 1;
            }
            
            val_9.stages + 64.alignByGeometry = true;
            val_40 = mem[val_9.stages + 84];
            val_40 = val_9.stages + 84;
            if(val_39 == true)
            {
                    "GROW" = "FIX";
            }
            
            if(animated != false)
            {
                    float val_38 = (float)val_38;
                val_38 = (float)val_2 / val_38;
                DG.Tweening.Tweener val_19 = DG.Tweening.ShortcutExtensions46.DOValue(target:  val_9.stages + 60, endValue:  val_38, duration:  null, snapping:  val_38);
            }
            else
            {
                    float val_39 = (float)val_38;
                val_39 = (float)val_2 / val_39;
            }
            
            val_41 = 1152921504765685760;
            if(val_39 == false)
            {
                goto label_24;
            }
            
            if((val_9.stages + 156) == 0)
            {
                    UnityEngine.GameObject val_22 = val_9.stages.gameObject;
                UnityEngine.Transform val_23 = val_9.stages.transform;
                object val_24 = UnityEngine.Object.Instantiate<System.Object>(original:  val_9.stages + 144, parent:  val_9.stages);
                mem2[0] = val_9.stages + 144;
                UnityEngine.Events.UnityAction val_25 = new UnityEngine.Events.UnityAction(object:  val_9.stages, method:  new IntPtr(301657920));
                val_9.stages + 144 + 172.AddListener(call:  162246656);
            }
            
            val_9.stages + 156.interactable = true;
            val_9.stages + 156.WaitingStatus(waiting:  false);
            UnityEngine.Transform val_26 = val_9.stages + 156.transform;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.zero;
            val_9.stages + 156.localScale = new UnityEngine.Vector3() {x = val_7};
            UnityEngine.Transform val_28 = val_9.stages + 156.transform;
            UnityEngine.Vector3 val_29 = new UnityEngine.Vector3(x:  val_27.x, y:  val_27.y, z:  val_27.z);
            DG.Tweening.Tweener val_30 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_9.stages + 156, endValue:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, duration:  val_27.x);
            object val_31 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_9.stages + 156, ease:  27);
            val_41 = 4;
            goto label_40;
            label_48:
            if((val_9.stages + 104 + 24 + 16 + 44) == 2)
            {
                goto label_45;
            }
            
            val_41 = 5;
            label_40:
            val_40 = val_41 - 4;
            if(val_40 < (val_9.stages + 104 + 24 + 12))
            {
                goto label_48;
            }
            
            return;
            label_24:
            if((val_9.stages + 156) != 0)
            {
                    UnityEngine.GameObject val_33 = val_9.stages + 156.gameObject;
                UnityEngine.Object.Destroy(obj:  val_9.stages + 156);
            }
            
            mem2[0] = 0;
            return;
            label_45:
            UnityEngine.Transform val_34 = val_9.stages + 156.transform;
            val_38 = val_9.stages + 156;
            val_42 = 0;
            UnityEngine.Transform val_35 = val_9.stages + 104 + 24 + 16.transform;
            val_10 = val_42;
            val_7 = val_42;
            UnityEngine.Vector3 val_36 = new UnityEngine.Vector3(x:  val_27.x, y:  val_27.y, z:  val_27.z);
            val_39 = 1152921504767283200;
            if((val_9.stages + 104 + 24 + 16) != 0)
            {
                    if((val_9.stages + 104 + 24 + 16) == null)
            {
                goto label_63;
            }
            
            }
            
            if((val_9.stages + 104 + 24 + 16) != 0)
            {
                    label_63:
                if((val_9.stages + 104 + 24 + 16) != null)
            {
                    val_42 = 0;
            }
            else
            {
                    val_42 = val_9.stages + 104 + 24 + 16;
            }
            
            }
            
            val_41 = 0;
            UnityEngine.Vector3 val_37 = val_29.x.TransformPoint(position:  new UnityEngine.Vector3() {x = val_42, y = val_36.x, z = val_36.y});
            val_38.position = new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z};
            mem2[0] = 0;
        }
        private void PlayPlantingAnimation(UnityEngine.Transform treeTransform)
        {
            UnityEngine.Transform val_1 = this.growButton.transform;
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.seedParticlesPrefab, parent:  this.growButton);
            UnityEngine.Vector3 val_3 = position;
            this.seedParticlesPrefab.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  3);
        }
        private void OnForestInfoButtonClicked()
        {
            GameBehavior val_1 = App.getBehavior;
            if(0 == 0)
            {
                
            }
        
        }
        private void OnGrowButtonClicked()
        {
            var val_9;
            WordForest.WFOForestUI val_32;
            bool val_33;
            var val_34;
            DG.Tweening.Sequence val_35;
            DG.Tweening.TweenCallback val_37;
            val_32 = this;
            object val_1 = new System.Object();
            typeof(WFOForestUI.<>c__DisplayClass53_0).__il2cppRuntimeField_8 = val_32;
            if(this.currentHighlightedFixTreeId >= 0)
            {
                    this.OnFixTreeButtonClicked();
                return;
            }
            
            WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
            if(4 >= (this.forestManager.GetGrowOrFixCost(growthLevel:  0.CurrentForestGrowth)))
            {
                goto label_5;
            }
            
            GameBehavior val_5 = App.getBehavior;
            if(0 != 0)
            {
                goto (1179403647 + (public WordForest.WFONotEnoughAcornsPopup MetaGameBehavior::ShowUGUIMonolith<WordForest.WFONotEnoughAcornsPopup>(bool showNext).__il2cppRuntimeField_28) << 3) + 192;
            }
            
            goto (1179403647 + (public WordForest.WFONotEnoughAcornsPopup MetaGameBehavior::ShowUGUIMonolith<WordForest.WFONotEnoughAcornsPopup>(bool showNext).__il2cppRuntimeField_28) << 3) + 192;
            label_5:
            WordForest.WFOForestData val_8 = 1152921513498828448.CurrentForestData;
            if(0.CurrentForestGrowth >= val_9)
            {
                goto label_11;
            }
            
            val_8.stages + 152.AddGrowth(damagedTreeIdToFix:  0, onServerResponse:  0);
            WordForest.WFOPlayer val_10 = WordForest.WFOPlayer.Instance;
            val_33 = 1;
            if((MonoExtensions.IsBitSet(value:  132, bit:  2)) != false)
            {
                    WordForest.WFOPlayer val_12 = WordForest.WFOPlayer.Instance;
                val_33 = (MonoExtensions.IsBitSet(value:  132, bit:  3)) ^ 1;
            }
            
            mem2[0] = val_33;
            val_8.stages + 80.interactable = false;
            val_34 = 0;
            val_8.stages + 80.WaitingStatus(waiting:  true);
            System.Collections.Generic.List<UnityEngine.Transform> val_14 = val_8.stages + 104.AddGrowth(addGrowth:  1);
            goto label_19;
            label_22:
            if((val_8.stages + 104) <= val_34)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_29 = val_8.stages + 104 + 8;
            val_29 = val_29 + 0;
            val_8.stages.PlayPlantingAnimation(treeTransform:  (val_8.stages + 104 + 8 + 0) + 16);
            val_34 = 1;
            label_19:
            if(val_34 < (val_8.stages + 104 + 12))
            {
                goto label_22;
            }
            
            val_35 = val_8.stages + 104 + 12.CurrentForestGrowth;
            WordForest.WFOForestData val_16 = 1152921513498828448.CurrentForestData;
            if(val_35 >= val_9)
            {
                    val_16.stages + 116.SetActive(value:  false);
                DG.Tweening.Sequence val_17 = val_16.stages.DoCompleteForestSequence();
                val_35 = val_16.stages;
                val_16.stages + 104.AddAnimationSequence(nextSequence:  val_35);
                val_16.stages + 20.blocksRaycasts = false;
                DG.Tweening.Tweener val_18 = DG.Tweening.ShortcutExtensions46.DOFade(target:  val_16.stages + 20, endValue:  null, duration:  null);
            }
            
            val_37 = null;
            val_37 = new DG.Tweening.TweenCallback(object:  val_16.bgType, method:  new IntPtr(302033856));
            DG.Tweening.Tween val_20 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1073741824, ignoreTimeScale:  false);
            WordForest.WFOPlayer val_21 = WordForest.WFOPlayer.Instance;
            if((MonoExtensions.IsBitSet(value:  132, bit:  2)) == false)
            {
                goto label_29;
            }
            
            WordForest.WFOPlayer val_23 = WordForest.WFOPlayer.Instance;
            if((MonoExtensions.IsBitSet(value:  132, bit:  3)) == false)
            {
                goto label_31;
            }
            
            var val_25 = FP - 16;
            return;
            label_11:
            var val_26 = FP - 16;
            label_29:
            var val_27 = (mem[(FP - 16) + (16)]) - 16;
            label_31:
            var val_28 = (mem[(mem[(FP - 16) + (16)] - 16) + (16)]) - 16;
        }
        private void UnlockNewForest()
        {
            bool val_1 = this.forestManager.ContinueNextForest();
            this.InitialiseForestLayout();
            this.InitializeUI();
            this.UpdateForestInfo(animated:  false, skipButtonStates:  false);
        }
        private void OnForestNameClicked()
        {
            GameBehavior val_1 = App.getBehavior;
            System.Action val_3 = new System.Action(object:  302298240, method:  new IntPtr(302272192));
            0.SetOnTweenInCompleteCallback(callback:  7454720);
            System.Action val_4 = new System.Action(object:  302298240, method:  new IntPtr(302273216));
            0.SetOnTweenOutBeginCallback(callback:  7454720);
        }
        private void OnContinueButtonClicked()
        {
            GameBehavior val_1 = App.getBehavior;
            mem[44] = 1;
            System.Action val_3 = new System.Action(object:  302411264, method:  new IntPtr(302386240));
            0.SetOnTweenInCompleteCallback(callback:  7454720);
            this.CueForestChestPointerAnim(delay:  null);
        }
        private void OnChestButtonClicked()
        {
            var val_10;
            var val_11;
            var val_13;
            System.Action val_14;
            var val_15;
            this.StopForestChestPointerAnim();
            val_10 = 1152921504922075136;
            if((((ForestMasterEventHandler.<Instance>k__BackingField) == 0) || (ForestMasterEventHandler.IsEventActive == false)) || ((ForestMasterEventHandler.<Instance>k__BackingField.GetAcornReward(showCurrentLevel:  false)) < 1))
            {
                goto label_11;
            }
            
            decimal val_3 = GetCoinReward(showCurrentLevel:  ForestMasterEventHandler.<Instance>k__BackingField);
            val_11 = null;
            val_11 = null;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
            {
                goto label_11;
            }
            
            GameBehavior val_5 = App.getBehavior;
            val_13 = 0;
            val_14 = null;
            val_15 = 1152921513499281856;
            goto label_16;
            label_11:
            GameBehavior val_7 = App.getBehavior;
            val_13 = 0;
            val_14 = null;
            val_15 = 1152921513499282880;
            label_16:
            val_14 = new System.Action(object:  302526336, method:  new IntPtr(302501312));
            val_13.AddOnCollectCallback(callback:  7454720);
        }
        private void OnFixTreeButtonClicked()
        {
            var val_8;
            var val_24;
            DG.Tweening.Sequence val_25;
            val_24 = this;
            if(this.currentHighlightedFixTreeId < 0)
            {
                goto label_1;
            }
            
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            if(4 >= (this.forestManager.GetGrowOrFixCost(growthLevel:  0.CurrentForestGrowth)))
            {
                goto label_4;
            }
            
            GameBehavior val_4 = App.getBehavior;
            if(0 != 0)
            {
                goto (1179403647 + (public WordForest.WFONotEnoughAcornsPopup MetaGameBehavior::ShowUGUIMonolith<WordForest.WFONotEnoughAcornsPopup>(bool showNext).__il2cppRuntimeField_28) << 3) + 192;
            }
            
            goto (1179403647 + (public WordForest.WFONotEnoughAcornsPopup MetaGameBehavior::ShowUGUIMonolith<WordForest.WFONotEnoughAcornsPopup>(bool showNext).__il2cppRuntimeField_28) << 3) + 192;
            label_4:
            WordForest.WFOForestData val_7 = CurrentForestData;
            if(0.CurrentForestGrowth >= val_8)
            {
                goto label_10;
            }
            
            val_7.stages + 80.interactable = false;
            val_7.stages + 156.interactable = false;
            val_7.stages + 156.WaitingStatus(waiting:  true);
            val_7.stages + 80.WaitingStatus(waiting:  true);
            UnityEngine.Transform val_9 = val_7.stages + 156.transform;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_7.stages + 156, endValue:  new UnityEngine.Vector3(), duration:  val_10.x);
            object val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_7.stages + 156, ease:  26);
            object val_13 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  val_7.stages + 156, delay:  val_10.x);
            val_7.stages + 152.AddGrowth(damagedTreeIdToFix:  val_7.stages + 160, onServerResponse:  0);
            UnityEngine.Transform val_14 = val_7.stages + 104.FixTree(treeIndex:  val_7.stages + 160);
            val_7.stages.PlayPlantingAnimation(treeTransform:  val_7.stages + 104);
            val_25 = val_7.stages.CurrentForestGrowth;
            WordForest.WFOForestData val_16 = CurrentForestData;
            if(val_25 >= val_8)
            {
                    DG.Tweening.Sequence val_17 = val_16.stages.DoCompleteForestSequence();
                val_25 = val_16.stages;
                val_16.stages + 104.AddAnimationSequence(nextSequence:  val_25);
            }
            
            DG.Tweening.TweenCallback val_18 = new DG.Tweening.TweenCallback(object:  val_16.stages, method:  new IntPtr(302618432));
            DG.Tweening.Tween val_19 = DG.Tweening.DOVirtual.DelayedCall(delay:  val_10.x, callback:  1073741824, ignoreTimeScale:  false);
            label_1:
            var val_20 = FP - 16;
            return;
            label_10:
            var val_21 = FP - 16;
        }
        private void OnAndroidBackButtonClicked()
        {
            GameBehavior val_1 = App.getBehavior;
            if(0 == 0)
            {
                
            }
        
        }
        private void StartGrowButtonPointerAnim()
        {
            int val_1 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.growButtonGlow, complete:  false);
            PluginExtension.SetColorAlpha(graphic:  this.growButtonGlow, a:  null);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.growButtonGlow, endValue:  null, duration:  null);
            object val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.growButtonGlow, ease:  7);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.growButtonGlow);
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.growButtonGlow, endValue:  null, duration:  null);
            object val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.growButtonGlow, ease:  7);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.growButtonGlow);
            object val_9 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  0, loops:  0, loopType:  0);
            UnityEngine.Transform val_10 = this.FTUXPointer.transform;
            int val_11 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.FTUXPointer, complete:  false);
            DG.Tweening.Sequence val_12 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Transform val_13 = this.FTUXPointer.transform;
            DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.FTUXPointer, endValue:  null, duration:  null);
            object val_15 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.FTUXPointer, ease:  5);
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.FTUXPointer);
            UnityEngine.Transform val_17 = this.FTUXPointer.transform;
            DG.Tweening.Tweener val_18 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.FTUXPointer, endValue:  null, duration:  null);
            object val_19 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.FTUXPointer, ease:  5);
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.FTUXPointer);
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            object val_22 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  0, loops:  0, loopType:  0);
        }
        private void CueForestChestPointerAnim(float delay = 0)
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            this.forestChestPointerSequence = 0;
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  delay);
            DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  303058304, method:  new IntPtr(303020992));
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.forestChestPointerSequence, callback:  190734336);
            DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.forestChestPointerScaler, endValue:  delay, duration:  null);
            object val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.forestChestPointerScaler, ease:  5);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.forestChestPointerScaler);
            DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.forestChestPointerScaler, endValue:  delay, duration:  null);
            object val_10 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.forestChestPointerScaler, ease:  6);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.forestChestPointerScaler);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  delay);
            object val_13 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  0, loops:  999, loopType:  0);
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.forestChestPointerSequence, t:  0);
        }
        private void StopForestChestPointerAnim()
        {
            DG.Tweening.TweenExtensions.Kill(t:  this.forestChestPointerSequence, complete:  false);
            UnityEngine.GameObject val_1 = this.forestChestPointerScaler.gameObject;
            this.forestChestPointerScaler.SetActive(value:  false);
        }
        private void OnTooltipContinueButtonClicked()
        {
            this.FTUXTooltip_3.SetActive(value:  false);
        }
        private void TrackAmplitudeInitialForestEntry()
        {
            var val_3;
            var val_4;
            var val_3 = 21600827;
            val_3 = 14024712 + val_3;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_3 = null;
            val_3 = null;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            FeatureAccessPoints val_2 = AmplitudePluginHelper.lastFeatureAccessPoint - 97;
            Add(key:  303411264, value:  8945664);
            var val_4 = 21600570;
            val_4 = 14024968 + val_4;
            if(val_4 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_4 = null;
            val_4 = null;
            App.trackerManager.track(eventName:  303411392, data:  78753792);
        }
        public WFOForestUI()
        {
            this.currentHighlightedFixTreeId = 0;
        }
        private void <DoCompleteForestSequence>b__42_1()
        {
            this.congratParticleLeft.Play();
        }
        private void <DoCompleteForestSequence>b__42_2()
        {
            this.congratParticleRight.Play();
        }
        private void <DoCompleteForestSequence>b__42_3()
        {
            this.continueGroup.blocksRaycasts = true;
        }
        private void <DoCompleteForestSequence>b__42_4()
        {
            UnityEngine.GameObject val_1 = this.continueButtonGlow.gameObject;
            this.continueButtonGlow.SetActive(value:  true);
        }
        private void <DoCompleteForestSequence>b__42_5()
        {
            UnityEngine.GameObject val_1 = this.continueButtonPointerScaler.gameObject;
            this.continueButtonPointerScaler.SetActive(value:  true);
        }
        private void <EndFTUX_2>b__46_0()
        {
            this.growButton.interactable = true;
            this.homeButton.interactable = true;
            if(this.forestInfoButton != 0)
            {
                    this.forestInfoButton.interactable = true;
            }
            
            this.forestNameButton.interactable = true;
            this.playButton.interactable = true;
        }
        private void <OnForestNameClicked>b__55_0()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            this.SetActive(value:  false);
        }
        private void <OnForestNameClicked>b__55_1()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            this.SetActive(value:  true);
        }
        private void <OnChestButtonClicked>b__57_0()
        {
            ForestMasterEventHandler.<Instance>k__BackingField.ShowRewardCollection();
            this.InitializeUI();
        }
        private void <OnFixTreeButtonClicked>b__58_0()
        {
            this.UpdateForestInfo(animated:  true, skipButtonStates:  false);
        }
        private void <CueForestChestPointerAnim>b__61_0()
        {
            UnityEngine.GameObject val_1 = this.forestChestPointerScaler.gameObject;
            this.forestChestPointerScaler.SetActive(value:  true);
        }
    
    }

}
