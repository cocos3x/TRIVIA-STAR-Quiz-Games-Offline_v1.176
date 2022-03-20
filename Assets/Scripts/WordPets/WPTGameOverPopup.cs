using UnityEngine;

namespace WordPets
{
    public class WPTGameOverPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject petEscapedWindow;
        private UnityEngine.GameObject noMoreWordsWindow;
        private UnityEngine.UI.Button petEscapeCloseButton;
        private UnityEngine.UI.Button bringBackButton;
        private UnityEngine.UI.Button petEscapeRetryButton;
        private UnityEngine.UI.Button petEscapeWatchVideoButton;
        private UnityEngine.UI.Text petEscapeInfoText;
        private UnityEngine.UI.Text bringBackPriceText;
        private UnityEngine.GameObject petEscapedPrefab;
        private UnityEngine.Transform petEscapedParent;
        private UnityEngine.UI.Text noMoreWordsHeaderText;
        private UnityEngine.UI.Button noMoreWordsCloseButton;
        private UnityEngine.UI.Text noMoreWordsInfoText;
        private UnityEngine.UI.Button noMoreWordsRetryButton;
        private UnityEngine.UI.Button noMoreWordsWatchVideoButton;
        private UnityEngine.UI.Button hintAddColumnButton;
        private UnityEngine.GameObject hintAddColumnCoinIcon;
        private UnityEngine.UI.Text hintAddColumnCostText;
        private UnityEngine.UI.Button hintRefreshButton;
        private UnityEngine.GameObject hintRefreshCoinIcon;
        private UnityEngine.UI.Text hintRefreshCostText;
        private UnityEngine.UI.Button hintWordButton;
        private UnityEngine.GameObject hintWordCoinIcon;
        private UnityEngine.UI.Text hintWordCostText;
        private WordPets.LoseCondition loseCondition;
        
        // Methods
        private void Awake()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  205361520, name:  2128120864);
        }
        private void OnDestroy()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  205473520, name:  2128120864);
        }
        public void Setup(WordPets.LoseCondition loseCond)
        {
            this.loseCondition = loseCond;
            if(loseCond == 3)
            {
                goto label_2;
            }
            
            if(loseCond == 2)
            {
                goto label_1;
            }
            
            if(loseCond == 1)
            {
                    this.SetupEscapedPets();
                return;
            }
            
            label_2:
            this.SetupVoluntaryFail();
            return;
            label_1:
            this.SetupNoMoreWords();
        }
        private void SetupEscapedPets()
        {
            this.loseCondition = 1;
            this.petEscapedWindow.SetActive(value:  true);
            this.noMoreWordsWindow.SetActive(value:  false);
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordPets.WPTGameMode val_2 = currentGame;
            object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  this.petEscapedPrefab, parent:  this.petEscapedParent);
            object val_4 = this.petEscapedPrefab.GetComponent<System.Object>();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            this.petEscapedPrefab.Setup(type:  public static WordPets.WordPetsController MonoSingleton<WordPets.WordPetsController>::get_Instance().__il2cppRuntimeField_18 + 8 + 16, isNew:  false);
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            string val_7 = System.String.Format(format:  205698096, arg0:  (public static WordPets.WPTShelterController MonoSingleton<WordPets.WPTShelterController>::get_Instance().__il2cppRuntimeField_C + (public static WordPets.WordPetsController MonoSingleton<WordPets.Wor + 16 + 24);
            UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  205770400, method:  new IntPtr(205710560));
            this.bringBackButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_9 = new UnityEngine.Events.UnityAction(object:  205770400, method:  new IntPtr(205719776));
            this.petEscapeRetryButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_10 = new UnityEngine.Events.UnityAction(object:  205770400, method:  new IntPtr(205719776));
            this.petEscapeCloseButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_11 = new UnityEngine.Events.UnityAction(object:  205770400, method:  new IntPtr(205737184));
            this.petEscapeWatchVideoButton.m_OnClick.AddListener(call:  162246656);
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.petEscapeWatchVideoButton.interactable = VideoAdsAllowed;
            WordPets.WPTGameEcon val_14 = WordPets.WPTGameEcon.Instance;
            UnityEngine.UI.Button val_15 = this.petEscapeWatchVideoButton + 1396;
            string val_16 = ToString();
            if(this.bringBackPriceText != 0)
            {
                    return;
            }
        
        }
        private void SetupNoMoreWords()
        {
            this.loseCondition = 2;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.noMoreWordsWindow.SetActive(value:  true);
            this.petEscapedWindow.SetActive(value:  false);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  206002560, method:  new IntPtr(205719776));
            this.noMoreWordsRetryButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  206002560, method:  new IntPtr(205944416));
            this.noMoreWordsCloseButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  206002560, method:  new IntPtr(205737184));
            this.noMoreWordsWatchVideoButton.m_OnClick.AddListener(call:  162246656);
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.petEscapeWatchVideoButton.interactable = VideoAdsAllowed;
            this.InitializeHintButtons();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_7 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            bool val_9 = GetTilesWithSelectableLetters(tilesWithProperty: out  System.Collections.Generic.List<WordPets.WPTGameTile> val_8 = 205990524);
            UnityEngine.Transform val_10 = this.hintAddColumnButton.transform;
            UnityEngine.Transform val_11 = this.hintAddColumnButton.parent;
            UnityEngine.GameObject val_12 = this.hintAddColumnButton.gameObject;
            if((public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_70 + 12) < 7)
            {
                    0 = 1;
            }
            
            this.hintAddColumnButton.SetActive(value:  true);
            UnityEngine.Transform val_13 = this.hintRefreshButton.transform;
            UnityEngine.Transform val_14 = this.hintRefreshButton.parent;
            UnityEngine.GameObject val_15 = this.hintRefreshButton.gameObject;
            if((System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze) > 2)
            {
                    0 = 1;
            }
            
            this.hintRefreshButton.SetActive(value:  true);
            UnityEngine.Transform val_16 = this.hintWordButton.transform;
            UnityEngine.Transform val_17 = this.hintWordButton.parent;
            UnityEngine.GameObject val_18 = this.hintWordButton.gameObject;
            this.hintWordButton.SetActive(value:  false);
            if(this.noMoreWordsInfoText != 0)
            {
                    return;
            }
        
        }
        private void SetupVoluntaryFail()
        {
            this.loseCondition = 3;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.noMoreWordsWindow.SetActive(value:  true);
            this.petEscapedWindow.SetActive(value:  false);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  206229552, method:  new IntPtr(205719776));
            this.noMoreWordsRetryButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  206229552, method:  new IntPtr(205944416));
            this.noMoreWordsCloseButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  206229552, method:  new IntPtr(205737184));
            this.noMoreWordsWatchVideoButton.m_OnClick.AddListener(call:  162246656);
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.petEscapeWatchVideoButton.interactable = VideoAdsAllowed;
            this.InitializeHintButtons();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_7 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            bool val_9 = GetTilesWithSelectableLetters(tilesWithProperty: out  System.Collections.Generic.List<WordPets.WPTGameTile> val_8 = 206217516);
            UnityEngine.Transform val_10 = this.hintAddColumnButton.transform;
            UnityEngine.Transform val_11 = this.hintAddColumnButton.parent;
            UnityEngine.GameObject val_12 = this.hintAddColumnButton.gameObject;
            if((public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_70 + 12) < 7)
            {
                    0 = 1;
            }
            
            this.hintAddColumnButton.SetActive(value:  true);
            UnityEngine.Transform val_13 = this.hintRefreshButton.transform;
            UnityEngine.Transform val_14 = this.hintRefreshButton.parent;
            UnityEngine.GameObject val_15 = this.hintRefreshButton.gameObject;
            if((System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze) > 2)
            {
                    0 = 1;
            }
            
            this.hintRefreshButton.SetActive(value:  true);
            UnityEngine.Transform val_16 = this.hintWordButton.transform;
            UnityEngine.Transform val_17 = this.hintWordButton.parent;
            UnityEngine.GameObject val_18 = this.hintWordButton.gameObject;
            if((System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze) > 2)
            {
                    0 = 1;
            }
            
            this.hintWordButton.SetActive(value:  true);
            if(this.noMoreWordsInfoText != 0)
            {
                    return;
            }
        
        }
        private void InitializeHintButtons()
        {
            var val_23;
            var val_25;
            var val_26;
            var val_28;
            var val_29;
            var val_31;
            var val_32;
            WordPets.WPTGameEcon val_1 = WordPets.WPTGameEcon.Instance;
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  206451120, method:  new IntPtr(206383088));
            this.hintAddColumnButton.m_OnClick.AddListener(call:  162246656);
            decimal val_3 = PowerupCostAddColumn;
            val_23 = null;
            val_23 = null;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
            {
                    decimal val_5 = PowerupCostAddColumn;
                string val_6 = ToString();
                val_25;
            }
            else
            {
                    val_25 = "FREE";
            }
            
            decimal val_7 = PowerupCostAddColumn;
            val_26 = null;
            val_26 = null;
            this.hintAddColumnCoinIcon.SetActive(value:  System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero}));
            UnityEngine.Events.UnityAction val_9 = new UnityEngine.Events.UnityAction(object:  206451120, method:  new IntPtr(206400496));
            this.hintRefreshButton.m_OnClick.AddListener(call:  162246656);
            decimal val_10 = PowerupCostRefresh;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) != false)
            {
                    decimal val_12 = PowerupCostRefresh;
                string val_13 = ToString();
                val_28;
            }
            else
            {
                    val_28 = "FREE";
            }
            
            decimal val_14 = PowerupCostRefresh;
            val_29 = null;
            val_29 = null;
            this.hintRefreshCoinIcon.SetActive(value:  System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero}));
            UnityEngine.Events.UnityAction val_16 = new UnityEngine.Events.UnityAction(object:  206451120, method:  new IntPtr(206417904));
            this.hintWordButton.m_OnClick.AddListener(call:  162246656);
            decimal val_17 = PowerupCostWordHint;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) != false)
            {
                    decimal val_19 = PowerupCostWordHint;
                string val_20 = ToString();
                val_31;
            }
            else
            {
                    val_31 = "FREE";
            }
            
            decimal val_21 = PowerupCostWordHint;
            val_32 = null;
            val_32 = null;
            this.hintWordCoinIcon.SetActive(value:  System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}));
        }
        private void OnVideoResponse(Notification notif)
        {
            var val_5;
            var val_6;
            if(this.loseCondition == 1)
            {
                goto label_1;
            }
            
            val_5 = 0;
            if(this.loseCondition != 2)
            {
                goto label_2;
            }
            
            val_6 = "Out of Words Ads";
            goto label_3;
            label_1:
            val_6 = "Pet Escaped Ads";
            label_3:
            label_2:
            string val_1 = notif.data.ToString();
            if((System.Boolean.Parse(value:  notif.data)) == false)
            {
                    return;
            }
            
            WordPets.WPTPlayer val_3 = WordPets.WPTPlayer.Instance;
            int val_4 = 0.CreditLife(amount:  1, source:  206596576);
        }
        private void OnCloseButtonClicked()
        {
            if(this.loseCondition != 3)
            {
                    if(this.loseCondition != 2)
            {
                    return;
            }
            
                R4.OnRetryClicked();
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ResumePlay();
            UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  206753168, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnBringBackClicked()
        {
            var val_10;
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  206870288, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            Player val_2 = App.Player;
            WordPets.WPTGameEcon val_3 = WordPets.WPTGameEcon.Instance;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal() {hi = 18, lo = 1335, mid = 3572200})) != false)
            {
                    var val_10 = 23946301;
                val_10 = 11679760 + val_10;
                if(val_10 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_10 = null;
                val_10 = null;
                PurchaseProxy.currentPurchasePoint = 85;
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_6 = ShowUGUIMonolith<System.Object>(showNext:  true);
                System.Action val_7 = new System.Action(object:  206870288, method:  new IntPtr(206845264));
                Init(outOfCredits:  true, onCloseAction:  7454720);
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordPets.WPTGameMode val_9 = currentGame;
            BringBackPets();
        }
        private void OnHintAddColumnClicked()
        {
            var val_11;
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  206983312, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            Player val_2 = App.Player;
            WordPets.WPTGameEcon val_3 = WordPets.WPTGameEcon.Instance;
            decimal val_4 = PowerupCostAddColumn;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal())) != false)
            {
                    var val_10 = 23945533;
                val_10 = 11680528 + val_10;
                if(val_10 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_11 = null;
                val_11 = null;
                PurchaseProxy.currentPurchasePoint = 83;
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_7 = ShowUGUIMonolith<System.Object>(showNext:  true);
                System.Action val_8 = new System.Action(object:  206983312, method:  new IntPtr(206958288));
                Init(outOfCredits:  true, onCloseAction:  7454720);
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnAddColumnClicked();
        }
        private void OnHintRefreshClicked()
        {
            var val_11;
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  207096336, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            Player val_2 = App.Player;
            WordPets.WPTGameEcon val_3 = WordPets.WPTGameEcon.Instance;
            decimal val_4 = PowerupCostRefresh;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal())) != false)
            {
                    var val_10 = 23944789;
                val_10 = 11681272 + val_10;
                if(val_10 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_11 = null;
                val_11 = null;
                PurchaseProxy.currentPurchasePoint = 84;
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_7 = ShowUGUIMonolith<System.Object>(showNext:  true);
                System.Action val_8 = new System.Action(object:  207096336, method:  new IntPtr(207071312));
                Init(outOfCredits:  true, onCloseAction:  7454720);
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnRefreshHintClicked();
        }
        private void OnHintWordClicked()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  207209360, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            Player val_2 = App.Player;
            WordPets.WPTGameEcon val_3 = WordPets.WPTGameEcon.Instance;
            decimal val_4 = PowerupCostWordHint;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal())) != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_7 = ShowUGUIMonolith<System.Object>(showNext:  true);
                System.Action val_8 = new System.Action(object:  207209360, method:  new IntPtr(207184336));
                Init(outOfCredits:  true, onCloseAction:  7454720);
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnHintClicked();
        }
        private void OnRetryClicked()
        {
            this.TrackLevelFail(loseCond:  this.loseCondition);
            WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
            int val_2 = 0.DebitLife(amount:  1);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordPets.WPTGameMode val_4 = currentGame;
            UnityEngine.GameObject val_5 = this.gameObject;
            SLCWindow.CloseWindow(window:  207325456, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void TrackLevelFail(WordPets.LoseCondition loseCond)
        {
            var val_5;
            var val_6;
            var val_7;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if(loseCond == 1)
            {
                goto label_1;
            }
            
            if(loseCond == 3)
            {
                goto label_2;
            }
            
            if(loseCond != 2)
            {
                goto label_3;
            }
            
            val_5 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            val_6 = "Out of Words";
            goto label_7;
            label_1:
            val_5 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            val_6 = "Balloon Escape";
            goto label_7;
            label_2:
            val_5 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            val_6 = "Retried Level";
            label_7:
            Add(key:  -1643554384, value:  207421840);
            label_3:
            int val_2 = WordPets.WPTGameUIController.HintsUsed;
            Add(key:  -487709424, value:  13152256);
            int val_3 = WordPets.WPTGameUIController.NewColumnsUsed;
            Add(key:  166014432, value:  13152256);
            int val_4 = WordPets.WPTGameUIController.ShufflesUsed;
            Add(key:  166014544, value:  13152256);
            var val_5 = 23942674;
            val_5 = 11682864 + val_5;
            if(val_5 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_7 = null;
            val_7 = null;
            App.trackerManager.track(eventName:  -1942299264, data:  78753792);
        }
        private void OnWatchVideoClicked()
        {
            if(this.loseCondition == 2)
            {
                    0 = 26;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_2 = ShowIncentivizedVideo(tag:  27, adCapExempt:  false);
        }
        public WPTGameOverPopup()
        {
        
        }
        private void <OnBringBackClicked>b__34_0()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
            Setup(loseCond:  this.loseCondition);
        }
        private void <OnHintAddColumnClicked>b__35_0()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
            Setup(loseCond:  this.loseCondition);
        }
        private void <OnHintRefreshClicked>b__36_0()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
            Setup(loseCond:  this.loseCondition);
        }
        private void <OnHintWordClicked>b__37_0()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
            Setup(loseCond:  this.loseCondition);
        }
    
    }

}
