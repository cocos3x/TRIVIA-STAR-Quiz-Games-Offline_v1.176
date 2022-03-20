using UnityEngine;

namespace SLC.Minigames
{
    public class MinigamesContinue_Window : MonoBehaviour
    {
        // Fields
        private MultiGraphicButton storeButton;
        private UnityEngine.UI.Text coinAmountText;
        private UnityEngine.UI.Button useCoinsButton;
        private UnityEngine.UI.Text useCoinsButtonText;
        private UnityEngine.UI.Text useCoinsButtonText_largeCount;
        private UnityEngine.UI.Button watchVideosButton;
        private UnityEngine.GameObject watchVideosContinueGroup;
        private UnityEngine.GameObject watchVideosGroup;
        private UnityEngine.UI.Text watchVideosButtonText;
        private UnityEngine.UI.Text watchVideosButtonText_largeCount;
        private UnityEngine.UI.Button continueButton;
        private UnityEngine.UI.Text rankText;
        private System.Collections.Generic.List<SLC.Minigames.MinigameRankSpriteDisplay> rankDisplayIcons;
        private UnityEngine.UI.Text plusLivesText;
        private UnityEngine.UI.RawImage lifeDisplayImage;
        private UnityEngine.UI.RawImage snakeLivesImage;
        private UnityEngine.UI.Slider nextRankSlider;
        private UnityEngine.UI.Text sliderText;
        private UnityEngine.UI.HorizontalLayoutGroup rankTextGroup;
        private int numVideosWatched;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  907067760, method:  new IntPtr(907015088));
            this.useCoinsButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  907067760, method:  new IntPtr(907024304));
            this.watchVideosButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  907067760, method:  new IntPtr(907033520));
            this.continueButton.m_OnClick.AddListener(call:  162246656);
            if(this.storeButton == 0)
            {
                    return;
            }
            
            UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  907067760, method:  new IntPtr(907042736));
            this.storeButton.AddListener(call:  162246656);
        }
        private void OnClick_ContinueButton()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  907212528, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            this.numVideosWatched = 0;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowGameOver();
        }
        private void OnClick_StoreButton()
        {
            var val_5;
            var val_6;
            var val_7;
            System.Action val_9;
            val_5 = 12368020 + 23258041;
            if(val_5 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_6 = null;
            val_6 = null;
            PurchaseProxy.currentPurchasePoint = 22;
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  907325552, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_3 = ShowUGUIMonolith<System.Object>(showNext:  true);
            val_7 = null;
            val_7 = null;
            val_9 = MinigamesContinue_Window.<>c.<>9__22_0;
            if(val_9 == 0)
            {
                    val_9 = null;
                val_9 = new System.Action(object:  MinigamesContinue_Window.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(907300528));
                MinigamesContinue_Window.<>c.<>9__22_0 = val_9;
            }
            
            Init(outOfCredits:  true, onCloseAction:  7454720);
        }
        private void OnClick_UseCoinsButton()
        {
            int val_12;
            int val_17;
            int val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            TrackerPurchasePoints val_40;
            var val_41;
            System.Action val_43;
            Player val_1 = App.Player;
            var val_2 = 0 + 60;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            decimal val_4 = GetCurrentContinueCost;
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = mem[(0 + 60) + (0)], hi = mem[(0 + 60) + (4)], lo = mem[(0 + 60) + (8)], mid = mem[(0 + 60) + (12)]}, d2:  new System.Decimal())) == false)
            {
                goto label_9;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            decimal val_8 = GetCurrentContinueCost;
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_10 = CurrentMinigameName;
            string val_11 = System.String.Format(format:  907413552, arg0:  -1745297776);
            val_35 = val_12;
            bool val_13 = CurrencyController.DebitBalance(value:  new System.Decimal() {flags = val_35}, source:  "MG {0} CONTINUE", externalParams:  0, animated:  false);
            twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            decimal val_16 = GetCurrentContinueCost;
            Cointinue(cost:  new System.Decimal() {mid = val_17});
            twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance()) == 0)
            {
                goto label_16;
            }
            
            val_36 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance();
            goto label_17;
            label_9:
            twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_20 = CurrentMinigameId;
            if((System.String.op_Equality(a:  -1745297776, b:  907413664)) == false)
            {
                goto label_21;
            }
            
            val_38 = 1152921504899551232;
            var val_34 = 23256885;
            val_34 = 12369176 + val_34;
            if(val_34 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_39 = null;
            val_40 = 44;
            goto label_53;
            label_21:
            if((System.String.op_Equality(a:  -1745297776, b:  907413760)) == false)
            {
                goto label_26;
            }
            
            val_38 = 1152921504899551232;
            var val_35 = 23256757;
            val_35 = 12369304 + val_35;
            if(val_35 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_39 = null;
            val_40 = 39;
            goto label_53;
            label_16:
            val_36 = 16;
            val_37 = 2621443;
            label_17:
            mem[16] = 2621444;
            twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64.Invoke();
            UnityEngine.GameObject val_24 = this.gameObject;
            SLCWindow.CloseWindow(window:  907439248, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            return;
            label_26:
            if((System.String.op_Equality(a:  -1745297776, b:  907413856)) != false)
            {
                    val_38 = 1152921504899551232;
                var val_36 = 23256529;
                val_36 = 12369532 + val_36;
                if(val_36 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_39 = null;
                val_40 = 43;
            }
            else
            {
                    if((System.String.op_Equality(a:  -1745297776, b:  907413952)) != false)
            {
                    val_38 = 1152921504899551232;
                var val_37 = 23256401;
                val_37 = 12369660 + val_37;
                if(val_37 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_39 = null;
                val_40 = 41;
            }
            else
            {
                    if((System.String.op_Equality(a:  -1745297776, b:  907414048)) != false)
            {
                    val_38 = 1152921504899551232;
                var val_38 = 23256273;
                val_38 = 12369788 + val_38;
                if(val_38 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_39 = null;
                val_40 = 40;
            }
            else
            {
                    val_38 = 1152921504899551232;
                if((System.String.op_Equality(a:  -1745297776, b:  907414128)) != false)
            {
                    var val_39 = 23256137;
                val_39 = 12369924 + val_39;
                if(val_39 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_39 = null;
                val_40 = 42;
            }
            else
            {
                    var val_40 = 23256057;
                val_40 = 12370004 + val_40;
                if(val_40 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_39 = null;
                val_40 = 0;
            }
            
            }
            
            }
            
            }
            
            label_53:
            PurchaseProxy.currentPurchasePoint = val_40;
            UnityEngine.GameObject val_30 = this.gameObject;
            SLCWindow.CloseWindow(window:  907439248, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            twelvegigs.Autopilot.AutopilotManager val_31 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_32 = ShowUGUIMonolith<System.Object>(showNext:  true);
            val_35 = 1152921505053863936;
            val_41 = null;
            val_41 = null;
            val_43 = MinigamesContinue_Window.<>c.<>9__23_0;
            if(val_43 == 0)
            {
                    val_43 = null;
                val_43 = new System.Action(object:  MinigamesContinue_Window.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(907414224));
                MinigamesContinue_Window.<>c.<>9__23_0 = val_43;
            }
            
            Init(outOfCredits:  true, onCloseAction:  7454720);
        }
        private void OnClick_WatchVideosButton()
        {
            var val_15;
            var val_16;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance()) != 0)
            {
                    val_15 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance();
            }
            else
            {
                    val_15 = 12;
                val_16 = 0;
            }
            
            mem[12] = 1;
            this.numVideosWatched = 0;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64.Invoke();
            UnityEngine.GameObject val_5 = this.gameObject;
            SLCWindow.CloseWindow(window:  907552272, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private bool isContinueStyle(int index)
        {
            int val_1 = index - 1;
            if(val_1 > 13)
            {
                    val_1 = 1;
                return (bool)val_1;
            }
            
            return false;
        }
        private void OnVideoResponse(Notification notif)
        {
            System.Func<System.Boolean>[] val_13;
            var val_14;
            System.Func<System.Boolean> val_15;
            float val_16;
            System.String[] val_17;
            string val_18;
            var val_19;
            val_13 = 35637978;
            string val_1 = notif.data.ToString();
            bool val_2 = System.Boolean.Parse(value:  notif.data);
            string val_3 = val_2.ToString();
            string val_4 = 907760464 + 907773931;
            UnityEngine.Debug.Log(message:  907760464);
            if(val_2 == false)
            {
                goto label_8;
            }
            
            int val_13 = this.numVideosWatched;
            val_13 = val_13 + 1;
            this.numVideosWatched = val_13;
            this.UpdateVideoButton();
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Player val_8 = App.Player;
            val_14 = null;
            val_14 = null;
            if((CurrentMinigame - 1) > 13)
            {
                goto label_20;
            }
            
            val_18 = mem[34443616 + ((val_7 - 1)) << 2];
            val_18 = 34443616 + ((val_7 - 1)) << 2;
            goto label_21;
            label_8:
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_16 = public static SLC.Minigames.MinigamesUIController MonoSingleton<SLC.Minigames.MinigamesUIController>::get_Instance();
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            val_17 = null;
            typeof(System.String[]).__il2cppRuntimeField_10 = "TRY AGAIN";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
            val_13 = null;
            val_19 = null;
            val_19 = null;
            val_15 = MinigamesContinue_Window.<>c.<>9__26_0;
            if(val_15 == 0)
            {
                    val_15 = null;
                val_15 = new System.Func<System.Boolean>(object:  MinigamesContinue_Window.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(907760832));
                val_16 = val_16;
                MinigamesContinue_Window.<>c.<>9__26_0 = val_15;
            }
            
            typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_15;
            0.ShowMessage(titleTxt:  907760624, messageTxt:  907760704, shownButtons:  1054454320, buttonTexts:  val_17, showClose:  false, buttonCallbacks:  val_13);
            UnityEngine.GameObject val_12 = this.gameObject;
            SLCWindow.CloseWindow(window:  907785968, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            return;
            label_20:
            val_18 = "MG Continue From Ads";
            label_21:
            0.AddCredits(amount:  new System.Decimal() {flags = val_15, hi = SB, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}, source:  val_18, subSource:  0, externalParams:  0, doTrack:  true);
        }
        private void Close()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  907906160, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnEnable()
        {
            var val_36;
            SLC.Minigames.MinigamesContinue_Window val_42;
            var val_44;
            float val_45;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            val_42 = this;
            object val_1 = new System.Object();
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  908023424, name:  2128120864);
            val_44 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            typeof(MinigamesContinue_Window.<>c__DisplayClass28_0).__il2cppRuntimeField_8 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_14;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.MinigameLevelRank val_5 = GetCurrentRank;
            if(mem[1152921514104805008] != 0)
            {
                    Player val_7 = App.Player;
                GameEcon val_8 = App.getGameEcon;
                string val_9 = ToString(format:  null);
                val_42;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            float val_12 = System.Decimal.ToSingle(d:  new System.Decimal() {flags = mem[((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_18 + 8 + 8 + ((public static SLC.Minigames.MinigameManager MonoSingleton + (0)], hi = mem[((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_18 + 8 + 8 + ((public static SLC.Minigames.MinigameManager MonoSingleton + (4)], lo = mem[((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_18 + 8 + 8 + ((public static SLC.Minigames.MinigameManager MonoSingleton + (8)], mid = mem[((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_18 + 8 + 8 + ((public static SLC.Minigames.MinigameManager MonoSingleton + (12)]});
            val_45 = mem[((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_18 + 8 + 8 + ((public static SLC.Minigames.MinigameManager MonoSingleton + (0)];
            val_44 = 1152921504901095424;
            float val_13 = System.Decimal.ToSingle(d:  new System.Decimal() {flags = R4, hi = R5, lo = R6, mid = R7});
            System.Predicate<System.Int32> val_14 = new System.Predicate<System.Int32>(object:  447070208, method:  new IntPtr(907994160));
            float val_42 = (float)(public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_20 + 12 - 1);
            val_42 = ((float)public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_20.FindIndex(match:  8040448)) / val_42;
            float val_17 = UnityEngine.Mathf.Lerp(a:  val_42, b:  null, t:  (float)public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_20.FindIndex(match:  8040448));
            twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_47 = typeof(MinigamesContinue_Window.<>c__DisplayClass28_0).__il2cppRuntimeField_8;
            float val_44 = (float)public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_14 + 12;
            float val_43 = (float)public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_14 + 12;
            val_43 = (float)GetNextCheckpointLevel - val_43;
            val_44 = (float)GetPlayerLevelInCurrentRank - val_44;
            val_44 = val_44 / val_43;
            GameEcon val_22 = App.getGameEcon;
            string val_23 = 1120403456.ToString(format:  null);
            string val_24 = System.String.Format(format:  907996208, arg0:  908011372);
            twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.MinigameLevelRank val_26 = GetCurrentRank;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_1C.Equals(value:  446537728)) != false)
            {
                    val_48 = "";
            }
            else
            {
                    twelvegigs.Autopilot.AutopilotManager val_28 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                SLC.Minigames.MinigameLevelRank val_29 = GetCurrentRank;
                string val_30 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_1C.ToUpper();
                val_48 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_1C;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_31 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.MinigameLevelRank val_32 = GetCurrentRank;
            UnityEngine.Color val_33 = TitleColor;
            List.Enumerator<T> val_34 = GetEnumerator();
            label_72:
            if(MoveNext() == false)
            {
                goto label_67;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_37 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.MinigameLevelRank val_38 = GetCurrentRank;
            val_36.DisplaySprite(rank:  -1745297776);
            goto label_72;
            label_67:
            Dispose();
            mem[1152921514104805076].enabled = false;
            mem[1152921514104805076].spacing = val_33.r;
            mem[1152921514104805076].enabled = true;
            twelvegigs.Autopilot.AutopilotManager val_39 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_40 = CurrentMinigame;
            val_40 = val_40 - 1;
            if(val_40 <= 6)
            {
                    var val_41 = 12377384 + (12377384 + ((val_40 - 1)) << 2);
                if(val_40 == 6)
            {
                    12377384 + ((val_40 - 1)) << 2 = (12377384 + ((val_40 - 1)) << 2) & ((IP) << 12377384 + ((val_40 - 1)) << 2);
                12377384 + ((val_40 - 1)) << 2 = (12377384 + ((val_40 - 1)) << 2) & ((IP) >> 32);
                12377384 + ((val_40 - 1)) << 2 = (12377384 + ((val_40 - 1)) << 2) & ((IP) >> 32);
                12377384 + ((val_40 - 1)) << 2 = (12377384 + ((val_40 - 1)) << 2) & (1152921504901095424 >> (12377384 + ((val_40 - 1)) << 2));
                12377384 + ((val_40 - 1)) << 2 = (12377384 + ((val_40 - 1)) << 2) & ((IP) << ((((12377384 + ((val_40 - 1)) << 2 & (IP) << 12377384 + ((val_40 - 1)) << 2) & (IP) >> 32) & (IP) >> 32) & (1152921504901095424) >> (((12377384 + ((val_40 - 1)) << 2 & (IP) << 12377384 + ((val_40 - 1));
                12377384 + ((val_40 - 1)) << 2 = (12377384 + ((val_40 - 1)) << 2) & ((IP) << (((((12377384 + ((val_40 - 1)) << 2 & (IP) << 12377384 + ((val_40 - 1)) << 2) & (IP) >> 32) & (IP) >> 32) & (1152921504901095424) >> (((12377384 + ((val_40 - 1)) << 2 & (IP) << 12377384 + ((val_40 - 1);
                12377384 + ((val_40 - 1)) << 2 = (12377384 + ((val_40 - 1)) << 2) & ((IP) >> 32);
            }
            
                val_49 = 1;
                val_50 = 3;
                this.SetupLifeDisplay(heart:  false, numLives:  1);
            }
            
            this.UpdateCoinButton();
            this.UpdateVideoButton();
        }
        private void SetupLifeDisplay(bool heart, int numLives = 1)
        {
            if(heart != false)
            {
                    this.lifeDisplayImage.enabled = true;
                this.snakeLivesImage.enabled = false;
                this.plusLivesText.enabled = true;
                string val_1 = -1467947360(-1467947360) + 13152256;
                if(this.plusLivesText != 0)
            {
                    return;
            }
            
                return;
            }
            
            this.snakeLivesImage.enabled = true;
            this.lifeDisplayImage.enabled = false;
            this.plusLivesText.enabled = false;
        }
        private void UpdateCoinButton()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            decimal val_2 = GetCurrentContinueCost;
            GameEcon val_3 = App.getGameEcon;
            string val_4 = ToString(format:  null);
            if(this.useCoinsButtonText_largeCount != 0)
            {
                    return;
            }
        
        }
        private void UpdateVideoButton()
        {
            var val_12;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_12 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_12 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance();
            this.watchVideosContinueGroup.SetActive(value:  true);
            this.watchVideosGroup.SetActive(value:  false);
        }
        private void OnDisable()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  908611024, name:  2128120864);
        }
        public MinigamesContinue_Window()
        {
        
        }
    
    }

}
