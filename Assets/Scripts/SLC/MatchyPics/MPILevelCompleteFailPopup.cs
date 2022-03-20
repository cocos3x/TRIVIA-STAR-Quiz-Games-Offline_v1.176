using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPILevelCompleteFailPopup : MonoBehaviour
    {
        // Fields
        private const float ANIM_PROGRESS_DURATION = 0.8;
        private UnityEngine.UI.Text chestRewardsText;
        private UnityEngine.UI.Text starProgressText;
        private UnityEngine.RectTransform progressBar;
        private UnityEngine.RectTransform progressBarImage;
        private UGUINetworkedButton keepStarsButton;
        private UnityEngine.UI.Button loseStarsButton;
        private UnityEngine.UI.Text loseStarsText;
        private SLC.MatchyPics.MPITreasureChestController chestController;
        private float originalLengthBar;
        private float startValueBar;
        private int gainedStars;
        private int startProgress;
        private int chestStarReq;
        
        // Methods
        private void Start()
        {
            var val_9;
            System.Action<System.Boolean> val_10;
            System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  776972832, method:  new IntPtr(776933472));
            this.keepStarsButton.OnConnectionClick = null;
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  776972832, method:  new IntPtr(776942688));
            this.loseStarsButton.m_OnClick.AddListener(call:  162246656);
            val_9 = 1152921504901095424;
            val_10 = 1152921511451249552;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(IsVideoAvailable() == true)
            {
                goto label_7;
            }
            
            this.keepStarsButton.WaitingStatus(waiting:  true);
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_10 = null;
            val_10 = new System.Action<System.Boolean>(object:  776972832, method:  new IntPtr(776947808));
            System.Delegate val_7 = System.Delegate.Combine(a:  public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C, b:  7401472);
            val_9 = public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C;
            if(val_9 != 0)
            {
                    if(val_9 == null)
            {
                goto label_14;
            }
            
            }
            
            val_9 = 0;
            label_14:
            public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C = val_9;
            label_7:
            NotificationCenter val_8 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  776972832, name:  2128120864);
        }
        public void SetupStars(int gainedStars)
        {
            SLC.MatchyPics.MPITreasureChestController val_6;
            int val_7;
            float val_8;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.chestController = public static SLC.MatchyPics.MPITreasureChestController MonoSingleton<SLC.MatchyPics.MPITreasureChestController>::get_Instance();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.chestStarReq = public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance().__il2cppRuntimeField_C + 12 + 76;
            this.gainedStars = UnityEngine.Mathf.Min(a:  gainedStars, b:  this.chestController.<CurrentStars>k__BackingField);
            string val_4 = this.chestController.<TotalRewards>k__BackingField.ToString();
            string val_5 = 1359327184 + 13152256;
            val_6 = this.chestController;
            if(val_6 != 0)
            {
                    val_7 = this.chestController.<CurrentStars>k__BackingField;
            }
            else
            {
                    val_7 = this.chestController.<CurrentStars>k__BackingField;
                val_6 = this.chestController;
                if(val_6 == 0)
            {
                    val_6 = 0;
            }
            
            }
            
            if(1 != 0)
            {
                    val_8 = 0f;
            }
            else
            {
                    val_8 = 0f;
            }
            
            this.InitStarProgess(stars:  val_7, progress:  val_8);
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
        private void SetStarProgress(int stars, float progress)
        {
            float val_1 = UnityEngine.Mathf.Min(a:  progress, b:  null);
            DG.Tweening.Core.DOGetter<UnityEngine.Vector2> val_2 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  777404064, method:  new IntPtr(777374944));
            DG.Tweening.Core.DOSetter<UnityEngine.Vector2> val_3 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  777404064, method:  new IntPtr(777375968));
            uint val_13 = 1065353216;
            val_13 = val_13 * this.originalLengthBar;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_13, y:  null);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, duration:  val_13);
            object val_6 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  198828032, delay:  val_13);
            DG.Tweening.TweenCallback val_7 = new DG.Tweening.TweenCallback(object:  777404064, method:  new IntPtr(777376992));
            object val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  198828032, action:  190734336);
            DG.Tweening.Core.DOSetter<System.Single> val_9 = new DG.Tweening.Core.DOSetter<System.Single>(object:  777404064, method:  new IntPtr(777379040));
            DG.Tweening.Tweener val_10 = DG.Tweening.DOTween.To(setter:  198881280, startValue:  (float)this.startProgress, endValue:  null, duration:  (float)stars);
            object val_11 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  198881280, delay:  (float)this.startProgress);
            object val_12 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  198881280, autoKillOnCompletion:  true);
        }
        private void OnClick_KeepStars(bool success)
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
            
            var val_3 = 23119361;
            val_3 = 12506700 + val_3;
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
        private void OnClick_LoseStars()
        {
            SLC.MatchyPics.MPITreasureChestController val_2;
            int val_3;
            float val_4;
            this.ButtonsInteractable(interactable:  false);
            this.chestController.AddStarProgress(stars:  0 - this.gainedStars, incentiveVideoReward:  false);
            val_2 = this.chestController;
            if(val_2 != 0)
            {
                    val_3 = this.chestController.<CurrentStars>k__BackingField;
            }
            else
            {
                    val_3 = this.chestController.<CurrentStars>k__BackingField;
                val_2 = this.chestController;
                if(val_2 == 0)
            {
                    val_2 = 0;
            }
            
            }
            
            if(1 != 0)
            {
                    val_4 = 0f;
            }
            else
            {
                    val_4 = 0f;
            }
            
            this.SetStarProgress(stars:  val_3, progress:  val_4);
        }
        private void OnVideoResponse(Notification notif)
        {
            string val_1 = notif.data.ToString();
            if((System.Boolean.Parse(value:  notif.data)) != false)
            {
                    this.HandleWindowClose();
                return;
            }
            
            this.ButtonsInteractable(interactable:  true);
        }
        private void OnCompleteStarProgress()
        {
            this.HandleWindowClose();
        }
        private void OnRewardedVideoLoaded(bool success)
        {
            UGUINetworkedButton val_4;
            var val_5;
            bool val_4 = success;
            val_4 = this.keepStarsButton;
            val_4 = val_4 ^ 1;
            val_4.WaitingStatus(waiting:  val_4);
            if(val_4 == true)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  778009120, method:  new IntPtr(776947808));
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
            val_9 = MPILevelCompleteFailPopup.<>c.<>9__23_0;
            if(val_9 == 0)
            {
                    val_9 = null;
                val_9 = new System.Func<System.Boolean>(object:  MPILevelCompleteFailPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(778101216));
                MPILevelCompleteFailPopup.<>c.<>9__23_0 = val_9;
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
            val_6 = MPILevelCompleteFailPopup.<>c.<>9__24_0;
            if(val_6 == 0)
            {
                    val_6 = null;
                val_6 = new System.Func<System.Boolean>(object:  MPILevelCompleteFailPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(778214240));
                MPILevelCompleteFailPopup.<>c.<>9__24_0 = val_6;
            }
            
            typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_6;
            0.SetupInternetRequired(buttonCallbacks:  2129277568);
        }
        private void HandleWindowClose()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  778351264, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            GameBehavior val_2 = App.getBehavior;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_4 = ShowInterstitial(context:  2);
        }
        private void ButtonsInteractable(bool interactable)
        {
            this.keepStarsButton.interactable = interactable;
            this.loseStarsButton.interactable = interactable;
        }
        private string ProgressFormat(int stars)
        {
            string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        }
        public MPILevelCompleteFailPopup()
        {
        
        }
        private UnityEngine.Vector2 <SetStarProgress>b__17_0()
        {
            UnityEngine.Vector2 val_1 = this.sizeDelta;
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        private void <SetStarProgress>b__17_1(UnityEngine.Vector2 x)
        {
            this.progressBar.sizeDelta = new UnityEngine.Vector2() {x = x.x, y = x.y};
        }
        private void <SetStarProgress>b__17_2()
        {
            this.Invoke(methodName:  779023840, time:  null);
        }
        private void <SetStarProgress>b__17_3(float x)
        {
            string val_1 = this.ProgressFormat(stars:  R1);
            if(this.starProgressText == 0)
            {
                
            }
        
        }
    
    }

}
