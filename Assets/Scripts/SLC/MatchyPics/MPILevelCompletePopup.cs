using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPILevelCompletePopup : LevelCompletePopup
    {
        // Fields
        private const float ANIM_PROGRESS_DURATION = 0.8;
        private UnityEngine.UI.Text levelText;
        private UnityEngine.UI.Text chestRewardsText;
        private UnityEngine.UI.Text starProgressText;
        private UnityEngine.RectTransform progressBar;
        private UnityEngine.RectTransform progressBarImage;
        private UnityEngine.UI.Button collectRewardsButton;
        private UGUINetworkedButton incentiveButton;
        private UnityEngine.UI.Button skipIncentiveButton;
        private UnityEngine.UI.Text chestRewardsButtonText;
        private UnityEngine.UI.Text incentiveButtonText;
        private UnityEngine.UI.Text skipButtonText;
        private UnityEngine.GameObject parentGO;
        private UnityEngine.GameObject chestIconAnim;
        private UnityEngine.GameObject starIconAnim;
        private UnityEngine.Transform[] buttonStarPos;
        private UnityEngine.Transform targetStarTransform;
        private SLC.MatchyPics.MPILevel currentLevel;
        private SLC.MatchyPics.MPITreasureChestController chestController;
        private float originalLengthBar;
        private float startValueBar;
        private int startProgress;
        private int chestStarReq;
        private const string PLUS_CHAR = "+";
        
        // Methods
        private void Start()
        {
            var val_11;
            System.Action<System.Boolean> val_12;
            UnityEngine.GameObject val_1 = this.chestIconAnim.gameObject;
            this.chestIconAnim.SetActive(value:  false);
            mem2[0] = this;
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  779760912, method:  new IntPtr(779716432));
            this.collectRewardsButton.m_OnClick.AddListener(call:  162246656);
            System.Action<System.Boolean> val_3 = new System.Action<System.Boolean>(object:  779760912, method:  new IntPtr(779721552));
            this.incentiveButton.OnConnectionClick = null;
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  779760912, method:  new IntPtr(779730768));
            this.skipIncentiveButton.m_OnClick.AddListener(call:  162246656);
            val_11 = 1152921504901095424;
            val_12 = 1152921511451249552;
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(IsVideoAvailable() == true)
            {
                goto label_12;
            }
            
            this.incentiveButton.WaitingStatus(waiting:  true);
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_12 = null;
            val_12 = new System.Action<System.Boolean>(object:  779760912, method:  new IntPtr(779735888));
            System.Delegate val_9 = System.Delegate.Combine(a:  public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C, b:  7401472);
            val_11 = public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C;
            if(val_11 != 0)
            {
                    if(val_11 == null)
            {
                goto label_19;
            }
            
            }
            
            val_11 = 0;
            label_19:
            public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C = val_11;
            label_12:
            NotificationCenter val_10 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  779760912, name:  2128120864);
        }
        public override void OnEnable()
        {
            this.Invoke(methodName:  -247212400, time:  null);
        }
        public void Init()
        {
            SLC.MatchyPics.MPITreasureChestController val_7;
            int val_8;
            float val_9;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.chestController = public static SLC.MatchyPics.MPITreasureChestController MonoSingleton<SLC.MatchyPics.MPITreasureChestController>::get_Instance();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.currentLevel = null;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.chestStarReq = public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance().__il2cppRuntimeField_C + 12 + 76;
            string val_4 = Localization.Localize(key:  779993680, defaultValue:  -372706032, useSingularKey:  false);
            int val_7 = this.currentLevel.LevelIndex;
            val_7 = val_7 + 1;
            string val_5 = System.String.Format(format:  779993680, arg0:  13152256);
            string val_6 = this.chestController.<TotalRewards>k__BackingField.ToString();
            val_7 = this.chestController;
            if(val_7 != 0)
            {
                    val_8 = this.chestController.<CurrentStars>k__BackingField;
            }
            else
            {
                    val_8 = this.chestController.<CurrentStars>k__BackingField;
                val_7 = this.chestController;
                if(val_7 == 0)
            {
                    val_7 = 0;
            }
            
            }
            
            if(1 != 0)
            {
                    val_9 = 0f;
            }
            else
            {
                    val_9 = 0f;
            }
            
            this.InitStarProgess(stars:  val_8, progress:  val_9);
            this.SetupButtons();
        }
        public override void ShowWithEffects()
        {
            R5.Setup(shouldBeShowing:  true);
            this.Init();
        }
        public override void WaitAndPlayAnim()
        {
            if(R4 == 0)
            {
                
            }
        
        }
        public override void HandleWindowClose(bool chapterClear)
        {
            GameBehavior val_1 = App.getBehavior;
            UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  780398848, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.MatchyPics.MPIGameplayController.<AdsDisplaying>k__BackingField = ShowInterstitial(context:  2);
        }
        private void OnClick_CollectRewards()
        {
            this.collectRewardsButton.interactable = false;
            int val_3 = this.chestController.<TotalRewards>k__BackingField;
            val_3 = val_3 + this.currentLevel.collectedChestRewards;
            this.chestController.<TotalRewards>k__BackingField = val_3;
            this.chestController.SaveToJson();
            this.currentLevel.collectedChestRewards = 0;
            System.Collections.IEnumerator val_1 = this.ChestCollectAnimation();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  780527232);
        }
        private System.Collections.IEnumerator ChestCollectAnimation()
        {
            object val_1 = new System.Object();
            typeof(MPILevelCompletePopup.<ChestCollectAnimation>d__30).__il2cppRuntimeField_8 = 0;
            typeof(MPILevelCompletePopup.<ChestCollectAnimation>d__30).__il2cppRuntimeField_10 = this;
        }
        private void OnClick_IncentiveReward(bool success)
        {
            var val_3;
            if(success == false)
            {
                goto label_1;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_2 = ShowIncentivizedVideo(tag:  24, adCapExempt:  false);
            if(val_2 == false)
            {
                goto label_5;
            }
            
            var val_3 = 23111613;
            val_3 = 12514448 + val_3;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_3 = null;
            val_3 = null;
            PurchaseProxy.currentPurchasePoint = 18;
            return;
            label_1:
            this.ShowConnectionRequired();
            return;
            label_5:
            val_2.ShowVideoUnavailable();
        }
        private void OnClick_SkipIncentiveReward()
        {
            SLC.MatchyPics.MPITreasureChestController val_5;
            float val_6;
            this.ButtonsInteractable(interactable:  false);
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AddStarProgress(stars:  this.currentLevel.totalStars, incentiveVideoReward:  false);
            val_5 = this.chestController;
            if(this.chestController != 0)
            {
                goto label_5;
            }
            
            val_5 = this.chestController;
            if(val_5 == 0)
            {
                goto label_6;
            }
            
            label_5:
            if(this.chestController.econ != 0)
            {
                    val_6 = ((float)this.chestController.<CurrentStars>k__BackingField) / (float)this.chestController.econ.ChestStarReq;
            }
            else
            {
                    val_6 = 0f;
            }
            
            UnityEngine.Transform val_4 = this.buttonStarPos[1];
            System.Collections.IEnumerator val_2 = this.SetStarProgress(stars:  this.chestController.<CurrentStars>k__BackingField, progress:  null, starParent:  0);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  780936960);
            return;
            label_6:
        }
        private void InitStarProgess(int stars, float progress)
        {
            this.startProgress = stars;
            string val_1 = this.ProgressFormat(stars:  stars);
            UnityEngine.Rect val_2 = rect;
            this.originalLengthBar = ;
            float val_4 = UnityEngine.Mathf.Min(a:  width, b:  val_2.m_YMin);
            uint val_6 = 1065353216;
            val_6 = val_6 * this.originalLengthBar;
            this.startValueBar = 1f;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_6, y:  val_2.m_YMin);
            this.progressBar.sizeDelta = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        }
        private System.Collections.IEnumerator SetStarProgress(int stars, float progress, UnityEngine.Transform starParent)
        {
            typeof(MPILevelCompletePopup.<SetStarProgress>d__34).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(MPILevelCompletePopup.<SetStarProgress>d__34).__il2cppRuntimeField_1C = stars;
                typeof(MPILevelCompletePopup.<SetStarProgress>d__34).__il2cppRuntimeField_10 = this;
                typeof(MPILevelCompletePopup.<SetStarProgress>d__34).__il2cppRuntimeField_18 = starParent;
            }
            else
            {
                    mem[16] = this;
                mem[28] = stars;
                mem[24] = starParent;
            }
            
            typeof(MPILevelCompletePopup.<SetStarProgress>d__34).__il2cppRuntimeField_14 = R3;
        }
        private void OnCompleteStarProgress()
        {
            var val_19;
            var val_20;
            float val_21;
            val_19 = this;
            val_20 = 1152921504901095424;
            val_21 = 1152921512345291008;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            goto typeof(SLC.MatchyPics.MPILevelCompletePopup).__il2cppRuntimeField_EC;
        }
        private void OnVideoResponse(Notification notif)
        {
            UnityEngine.Transform[] val_7;
            SLC.MatchyPics.MPITreasureChestController val_8;
            int val_9;
            float val_10;
            val_7 = 35638248;
            string val_1 = notif.data.ToString();
            bool val_2 = System.Boolean.Parse(value:  notif.data);
            string val_3 = val_2.ToString();
            string val_4 = 781464384 + 781533815;
            UnityEngine.Debug.LogError(message:  781464384);
            if(val_2 == false)
            {
                goto label_8;
            }
            
            this.ButtonsInteractable(interactable:  false);
            this.chestController.AddStarProgress(stars:  this.currentLevel.totalStars, incentiveVideoReward:  true);
            val_8 = this.chestController;
            if(val_8 == 0)
            {
                goto label_11;
            }
            
            val_9 = this.chestController.<CurrentStars>k__BackingField;
            goto label_14;
            label_8:
            this.SetupButtons();
            return;
            label_11:
            val_9 = this.chestController.<CurrentStars>k__BackingField;
            val_8 = this.chestController;
            if(val_8 == 0)
            {
                    val_8 = 0;
            }
            
            label_14:
            if(1 != 0)
            {
                    val_10 = 0f;
            }
            else
            {
                    val_10 = 0f;
            }
            
            val_7 = this.buttonStarPos;
            UnityEngine.Transform val_7 = val_7[0];
            System.Collections.IEnumerator val_5 = this.SetStarProgress(stars:  val_9, progress:  null, starParent:  0);
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  781545840);
        }
        private void SetupButtons()
        {
            int val_14;
            UnityEngine.UI.Text val_15;
            string val_16;
            var val_17;
            UnityEngine.GameObject val_1 = this.collectRewardsButton.gameObject;
            if(this.currentLevel.collectedChestRewards > 0)
            {
                    0 = 1;
            }
            
            this.collectRewardsButton.SetActive(value:  true);
            UnityEngine.GameObject val_2 = this.incentiveButton.gameObject;
            this.incentiveButton.SetActive(value:  this.incentiveButton >> 5);
            UnityEngine.GameObject val_4 = this.skipIncentiveButton.gameObject;
            this.skipIncentiveButton.SetActive(value:  this.skipIncentiveButton >> 5);
            UnityEngine.GameObject val_6 = this.starProgressText.gameObject;
            val_14 = this.currentLevel.collectedChestRewards;
            this.starProgressText.SetActive(value:  this.starProgressText >> 5);
            this.ButtonsInteractable(interactable:  true);
            if(this.currentLevel.collectedChestRewards >= 1)
            {
                    val_15 = this.chestRewardsButtonText;
                string val_8 = this.currentLevel.collectedChestRewards.ToString();
                val_16 = this.currentLevel.collectedChestRewards;
                val_17 = "+";
            }
            else
            {
                    twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                string val_10 = (this.currentLevel.totalStars + public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance().__il2cppRuntimeField_C + 12 + 72).ToString();
                string val_11 = -1467947360(-1467947360) + 781772788;
                val_14 = "+";
                val_15 = this.skipButtonText;
                string val_12 = this.currentLevel.totalStars.ToString();
                val_16 = this.currentLevel.totalStars;
                val_17 = "+";
            }
            
            string val_13 = -1467947360(-1467947360) + val_16;
            if(val_15 != 0)
            {
                    return;
            }
        
        }
        private void OnRewardedVideoLoaded(bool success)
        {
            UGUINetworkedButton val_4;
            var val_5;
            bool val_4 = success;
            val_4 = this.incentiveButton;
            val_4 = val_4 ^ 1;
            val_4.WaitingStatus(waiting:  val_4);
            if(val_4 == true)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  781962352, method:  new IntPtr(779735888));
            System.Delegate val_3 = System.Delegate.Remove(source:  public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C, value:  7401472);
            val_5 = public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C;
            if(val_5 != 0)
            {
                    if(val_5 == null)
            {
                goto label_8;
            }
            
            }
            
            val_5 = 0;
            label_8:
            public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C = val_5;
        }
        private void ShowVideoUnavailable()
        {
            var val_7;
            System.Func<System.Boolean> val_9;
            var val_10;
            GameBehavior val_1 = App.getBehavior;
            string val_3 = Localization.Localize(key:  2129276784, defaultValue:  2129276896, useSingularKey:  false);
            string val_4 = Localization.Localize(key:  2129276992, defaultValue:  2129277104, useSingularKey:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_5 = Localization.Localize(key:  2129277264, defaultValue:  2129277376, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "try_again_later_upper";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
            val_7 = null;
            val_7 = null;
            val_9 = MPILevelCompletePopup.<>c.<>9__40_0;
            if(val_9 == 0)
            {
                    val_9 = null;
                val_9 = new System.Func<System.Boolean>(object:  MPILevelCompletePopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(782054448));
                MPILevelCompletePopup.<>c.<>9__40_0 = val_9;
            }
            
            typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_9;
            val_10 = null;
            val_10 = null;
            0.SetupMessage(titleTxt:  2129276784, messageTxt:  2129276992, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        }
        private void ShowConnectionRequired()
        {
            var val_4;
            System.Func<System.Boolean> val_6;
            GameBehavior val_1 = App.getBehavior;
            val_4 = null;
            val_4 = null;
            val_6 = MPILevelCompletePopup.<>c.<>9__41_0;
            if(val_6 == 0)
            {
                    val_6 = null;
                val_6 = new System.Func<System.Boolean>(object:  MPILevelCompletePopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(782167472));
                MPILevelCompletePopup.<>c.<>9__41_0 = val_6;
            }
            
            typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_6;
            0.SetupInternetRequired(buttonCallbacks:  2129277568);
        }
        private void ButtonsInteractable(bool interactable)
        {
            this.collectRewardsButton.interactable = interactable;
            this.incentiveButton.interactable = interactable;
            this.skipIncentiveButton.interactable = interactable;
        }
        private string ProgressFormat(int stars)
        {
            string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        }
        public MPILevelCompletePopup()
        {
        
        }
        private void <ChestCollectAnimation>b__30_0()
        {
            UnityEngine.GameObject val_1 = this.chestIconAnim.gameObject;
            this.chestIconAnim.SetActive(value:  false);
            string val_2 = this.chestController.<TotalRewards>k__BackingField.ToString();
            UnityEngine.Transform val_3 = this.chestRewardsText.transform;
            UnityEngine.Transform val_4 = this.chestRewardsText.parent;
            DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOShakeScale(target:  this.chestRewardsText, duration:  null, strength:  null, vibrato:  1056964608, randomness:  null, fadeOut:  false);
        }
        private void <SetStarProgress>b__34_3()
        {
            UnityEngine.Transform val_1 = this.starIconAnim.transform;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOShakeScale(target:  this.starIconAnim, duration:  null, strength:  null, vibrato:  1056964608, randomness:  null, fadeOut:  false);
        }
        private UnityEngine.Vector2 <SetStarProgress>b__34_0()
        {
            UnityEngine.Vector2 val_1 = this.sizeDelta;
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        private void <SetStarProgress>b__34_1(UnityEngine.Vector2 x)
        {
            this.progressBar.sizeDelta = new UnityEngine.Vector2() {x = x.x, y = x.y};
        }
        private void <SetStarProgress>b__34_2(float x)
        {
            string val_1 = this.ProgressFormat(stars:  R1);
            if(this.starProgressText == 0)
            {
                
            }
        
        }
        private void <OnCompleteStarProgress>b__35_0()
        {
            goto typeof(SLC.MatchyPics.MPILevelCompletePopup).__il2cppRuntimeField_EC;
        }
        private void <OnCompleteStarProgress>b__35_2()
        {
            goto typeof(SLC.MatchyPics.MPILevelCompletePopup).__il2cppRuntimeField_EC;
        }
        private void <OnCompleteStarProgress>b__35_1()
        {
            goto typeof(SLC.MatchyPics.MPILevelCompletePopup).__il2cppRuntimeField_EC;
        }
    
    }

}
