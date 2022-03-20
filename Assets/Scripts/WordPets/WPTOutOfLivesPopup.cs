using UnityEngine;

namespace WordPets
{
    public class WPTOutOfLivesPopup : FixedIntervalUpdater
    {
        // Fields
        private const int LIVES_CREDITED_PER_ADVIEW = 1;
        private const int LIVES_CREDITED_PER_PURCHASE = 5;
        private UnityEngine.UI.Button buttonClose;
        private GridCoinCollectAnimationInstantiator coinsAnimControl;
        private UnityEngine.GameObject lifeCountDisplay;
        private UnityEngine.UI.Text lifeCountLabel;
        private UnityEngine.UI.Text lifeTimerValueLabel;
        private UGUINetworkedButton buttonWatchAd;
        private UnityEngine.UI.Text buttonWatchAdLifeQtyLabel;
        private UnityEngine.UI.Button buttonPurchaseLives;
        private UnityEngine.UI.Text buttonPurchaseLivesQtyLabel;
        private UnityEngine.UI.Text buttonPurchaseLivesCostLabel;
        private System.TimeSpan timerCooldownInterval;
        private int prevLifeCount;
        private System.Action onPopupClosed;
        
        // Methods
        private void Awake()
        {
            System.TimeSpan val_5;
            WordPets.WPTGameEcon val_1 = WordPets.WPTGameEcon.Instance;
            var val_2 = 0 + 1376;
            System.TimeSpan val_3 = System.TimeSpan.FromMinutes(value:  null);
            this.timerCooldownInterval = val_5;
            UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  211607360, method:  new IntPtr(211568000));
            this.buttonClose.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  211607360, method:  new IntPtr(211577216));
            this.buttonPurchaseLives.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  211607360, method:  new IntPtr(211582336));
            this.buttonWatchAd.AddListener(call:  162246656);
            NotificationCenter val_9 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  211607360, name:  2128120864);
            this.UpdateView();
        }
        private void OnDestroy()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  211739840, name:  2128120864);
        }
        private void OnDisable()
        {
            if(this.onPopupClosed != 0)
            {
                    this.onPopupClosed.Invoke();
            }
            
            this.onPopupClosed = 0;
        }
        public void Init(System.Action onCloseAction)
        {
            System.Action val_2 = this.onPopupClosed;
            System.Delegate val_1 = System.Delegate.Combine(a:  val_2 = this.onPopupClosed, b:  onCloseAction);
            if(val_2 != 0)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            val_2 = 0;
            label_2:
            this.onPopupClosed = val_2;
        }
        private void UpdateView()
        {
            bool val_7 = static_value_021FCE60;
            if(val_7 != true)
            {
                    val_7 = true;
            }
            
            WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
            string val_2 = 281.ToString();
            string val_3 = System.String.Format(format:  2128510224, arg0:  13152256);
            string val_4 = System.String.Format(format:  2128510224, arg0:  13152256);
            WordPets.WPTGameEcon val_5 = WordPets.WPTGameEcon.Instance;
            var val_6 = 0 + 1380;
            string val_7 = ToString();
            if(this.buttonPurchaseLivesCostLabel != 0)
            {
                    return;
            }
        
        }
        protected override void UpdateLogic()
        {
            ulong val_6;
            long val_12;
            bool val_17;
            UnityEngine.UI.Text val_18;
            long val_19;
            val_17 = static_value_021FCE61;
            if(val_17 != true)
            {
                    val_17 = true;
            }
            
            WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
            if(val_17.IsLivesMaxed() != false)
            {
                    val_18 = this.lifeTimerValueLabel;
                val_19 = "max_upper";
                string val_3 = Localization.Localize(key:  2128646960, defaultValue:  2128646880, useSingularKey:  false);
            }
            else
            {
                    System.DateTime val_4 = DateTimeCheat.UtcNow;
                WordPets.WPTPlayer val_5 = WordPets.WPTPlayer.Instance;
                System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513409022896}, d2:  new System.DateTime() {dateData = val_6});
                System.TimeSpan val_11 = System.TimeSpan.op_Subtraction(t1:  new System.TimeSpan() {_ticks = 1152921513409022888}, t2:  new System.TimeSpan() {_ticks = this.timerCooldownInterval});
                val_19 = val_12;
                val_18 = this.lifeTimerValueLabel;
                string val_14 = GenericStringExtentions.ToString(span:  new System.TimeSpan() {_ticks = val_19}, formatted:  true);
            }
            
            WordPets.WPTPlayer val_15 = WordPets.WPTPlayer.Instance;
            if(this.prevLifeCount == val_18)
            {
                    return;
            }
            
            this.UpdateView();
            WordPets.WPTPlayer val_16 = WordPets.WPTPlayer.Instance;
            this.prevLifeCount = this;
        }
        private void CreditLife(int amt, string source)
        {
            WordPets.WPTOutOfLivesPopup val_23;
            UnityEngine.Transform val_24;
            int val_25;
            var val_26;
            val_23 = this;
            object val_1 = new System.Object();
            if(val_1 != 0)
            {
                    typeof(WPTOutOfLivesPopup.<>c__DisplayClass21_0).__il2cppRuntimeField_8 = val_23;
            }
            else
            {
                    mem[8] = val_23;
            }
            
            typeof(WPTOutOfLivesPopup.<>c__DisplayClass21_0).__il2cppRuntimeField_C = amt;
            this.ToggleAllButtonsInteractable(isInteractable:  false);
            WordPets.WPTPlayer val_2 = WordPets.WPTPlayer.Instance;
            val_24 = val_23;
            val_25 = typeof(WPTOutOfLivesPopup.<>c__DisplayClass21_0).__il2cppRuntimeField_C;
            int val_3 = this.CreditLife(amount:  val_25, source:  source);
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            val_26 = 0;
            var val_23 = 0;
            if(new System.Object() != 0)
            {
                    typeof(WPTOutOfLivesPopup.<>c__DisplayClass21_1).__il2cppRuntimeField_C = val_1;
            }
            else
            {
                    mem[12] = val_1;
            }
            
            val_25 = val_23;
            typeof(WPTOutOfLivesPopup.<>c__DisplayClass21_1).__il2cppRuntimeField_8 = val_23;
            float val_6 = 0f * 0.15f;
            UnityEngine.Transform val_7 = this.lifeCountDisplay.transform;
            UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  0f, y:  null, z:  null);
            DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.lifeCountDisplay, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  0f);
            object val_10 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.lifeCountDisplay, ease:  1);
            val_26 = val_26;
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  0f, t:  val_6);
            DG.Tweening.TweenCallback val_12 = new DG.Tweening.TweenCallback(object:  401596416, method:  new IntPtr(212357760));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  0, atPosition:  0f, callback:  val_6);
            val_23 = val_25;
            UnityEngine.Transform val_14 = this.lifeCountDisplay.transform;
            val_24 = this.lifeCountDisplay;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
            DG.Tweening.Tweener val_16 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_24, endValue:  new UnityEngine.Vector3(), duration:  val_15.x);
            object val_17 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_24, ease:  1);
            float val_18 = val_6 + 0.01f;
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_18, t:  val_18);
            val_23 = val_23 + 1;
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_18);
            DG.Tweening.TweenCallback val_21 = new DG.Tweening.TweenCallback(object:  212386880, method:  new IntPtr(211568000));
            object val_22 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        }
        private void ToggleAllButtonsInteractable(bool isInteractable)
        {
            this.buttonPurchaseLives.interactable = isInteractable;
            this.buttonWatchAd.interactable = isInteractable;
            this.buttonClose.interactable = isInteractable;
        }
        private void CloseWindow()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  212647744, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnPurchaseClicked()
        {
            var val_12;
            System.Action val_14;
            Player val_1 = App.Player;
            var val_2 = 0 + 64;
            WordPets.WPTGameEcon val_3 = WordPets.WPTGameEcon.Instance;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = mem[(0 + 64) + (0)], lo = mem[(0 + 64) + (4)], mid = mem[(0 + 64) + (8)]}, d2:  new System.Decimal() {lo = 18, mid = 1308})) != false)
            {
                    GameBehavior val_5 = App.getBehavior;
                val_12 = null;
                val_12 = null;
                val_14 = WPTOutOfLivesPopup.<>c.<>9__24_0;
                if(val_14 == 0)
            {
                    val_14 = null;
                val_14 = new System.Action(object:  WPTOutOfLivesPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(212735744));
                WPTOutOfLivesPopup.<>c.<>9__24_0 = val_14;
            }
            
                0.Init(outOfCredits:  true, onCloseAction:  7454720);
                UnityEngine.GameObject val_8 = this.gameObject;
                SLCWindow.CloseWindow(window:  212760768, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
                return;
            }
            
            WordPets.WPTGameEcon val_9 = WordPets.WPTGameEcon.Instance;
            bool val_10 = CurrencyController.DebitBalance(value:  new System.Decimal() {lo = 18, mid = 1308}, source:  "Max Lives", externalParams:  0, animated:  false);
            this.CreditLife(amt:  5, source:  null);
            Player val_11 = App.Player;
            mem[1152921513409542360].Set(instantValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256});
        }
        private void OnWatchAdClicked()
        {
            var val_10;
            System.Func<System.Boolean> val_12;
            var val_13;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((ShowIncentivizedVideo(tag:  28, adCapExempt:  false)) != false)
            {
                    return;
            }
            
            GameBehavior val_3 = App.getBehavior;
            string val_5 = Localization.Localize(key:  2129276784, defaultValue:  2129276896, useSingularKey:  false);
            string val_6 = Localization.Localize(key:  2129276992, defaultValue:  2129277104, useSingularKey:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_7 = Localization.Localize(key:  2129277264, defaultValue:  2129277376, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "try_again_later_upper";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
            val_10 = null;
            val_10 = null;
            val_12 = WPTOutOfLivesPopup.<>c.<>9__25_0;
            if(val_12 == 0)
            {
                    val_12 = null;
                val_12 = new System.Func<System.Boolean>(object:  WPTOutOfLivesPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(212848768));
                WPTOutOfLivesPopup.<>c.<>9__25_0 = val_12;
            }
            
            typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_12;
            val_13 = null;
            val_13 = null;
            0.SetupMessage(titleTxt:  2129276784, messageTxt:  2129276992, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
            UnityEngine.GameObject val_9 = this.gameObject;
            SLCWindow.CloseWindow(window:  212873792, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnVideoResponse(Notification notif)
        {
            string val_1 = notif.data.ToString();
            if((System.Boolean.Parse(value:  notif.data)) == false)
            {
                    return;
            }
            
            this.CreditLife(amt:  1, source:  212969984);
        }
        public WPTOutOfLivesPopup()
        {
        
        }
    
    }

}
