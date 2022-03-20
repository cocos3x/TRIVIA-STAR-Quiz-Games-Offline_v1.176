using UnityEngine;

namespace SLC.Minigames
{
    public class MinigamesGameOver_Window : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Slider nextRankSlider;
        private UnityEngine.UI.Text checkpointsText;
        private UnityEngine.UI.Button collectRewardButton;
        private UnityEngine.UI.Button homeButton;
        private UnityEngine.UI.Button restartButton;
        private UnityEngine.UI.Button storeButton;
        private UnityEngine.UI.Text rewardButtonText;
        private GridCoinCollectAnimationInstantiator coinsAnimControl;
        private SLC.Minigames.MinigameRankSpriteDisplay mainRankDisplay;
        private UnityEngine.GameObject mainRankDisplayContainer;
        private UnityEngine.UI.Text rankText;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  909777104, method:  new IntPtr(909724432));
            this.collectRewardButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  909777104, method:  new IntPtr(909733648));
            this.restartButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  909777104, method:  new IntPtr(909742864));
            this.homeButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  909777104, method:  new IntPtr(909752080));
            this.storeButton.m_OnClick.AddListener(call:  162246656);
        }
        private void OnClick_RewardButton()
        {
            int val_5;
            int val_13;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            decimal val_3 = System.Decimal.op_Implicit(value:  909909916);
            decimal val_4 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 909909900, hi = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_20, lo = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_24, mid = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_28}, d2:  new System.Decimal() {flags = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_2C});
            Player val_6 = App.Player;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_8 = CurrentMinigameName;
            string val_9 = System.String.Format(format:  909897872, arg0:  -1745297776);
            0.AddCredits(amount:  new System.Decimal() {flags = val_5, hi = R6, lo = R7, mid = ???}, source:  "MG {0} REWARD", subSource:  0, externalParams:  0, doTrack:  true);
            Player val_10 = App.Player;
            decimal val_11 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 909909884, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = val_5});
            Player val_12 = App.Player;
            mem[1152921514106703576].Play(fromValue:  new System.Decimal() {mid = val_13}, toValue:  new System.Decimal() {mid = 256}, textTickTime:  null, delayBeforeComplete:  null);
            twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            mem2[0] = 0;
            twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SavePlayerDataTo_Prefs();
            mem[1152921514106703556].interactable = false;
            mem[1152921514106703564].interactable = true;
            mem[1152921514106703560].interactable = true;
        }
        private void OnClick_RestartButton()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  910033968, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandleGameRestart();
        }
        private void OnClick_HomeButton()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandleHomeClicked(redirectToGameplay:  false);
        }
        private void OnClick_StoreButton()
        {
            var val_5;
            var val_6;
            System.Action val_8;
            var val_5 = 23244721;
            val_5 = 12381340 + val_5;
            if(val_5 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_5 = null;
            val_5 = null;
            PurchaseProxy.currentPurchasePoint = 22;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
            val_6 = null;
            val_6 = null;
            val_8 = MinigamesGameOver_Window.<>c.<>9__15_0;
            if(val_8 == 0)
            {
                    val_8 = null;
                val_8 = new System.Action(object:  MinigamesGameOver_Window.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(910233968));
                MinigamesGameOver_Window.<>c.<>9__15_0 = val_8;
            }
            
            Init(outOfCredits:  false, onCloseAction:  7454720);
            UnityEngine.GameObject val_4 = this.gameObject;
            SLCWindow.CloseWindow(window:  910258992, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnEnable()
        {
            var val_23;
            var val_24;
            object val_26;
            var val_27;
            var val_28;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.MinigameLevelRank val_3 = GetCurrentRank;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.MinigameLevelRank val_5 = GetNextRank;
            if((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance()) != 0)
            {
                    val_24 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_20;
            }
            else
            {
                    val_24 = 35615780;
                val_23 = 35615780;
            }
            
            var val_23 = 3553932;
            val_23 = val_23 - 1;
            if(3553932 <= val_23)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_24 = 3553932;
            val_24 = val_24 + (val_23 << 2);
            float val_25 = (float)(3553932 + ((3553932 - 1)) << 2) + 16;
            val_25 = ((float)public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_14 + 12) / val_25;
            this.mainRankDisplay.DisplaySprite(rank:  -1745297776);
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.mainRankDisplayContainer.SetActive(value:  System.String.op_Inequality(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_1C, b:  446537728));
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_1C.Equals(value:  446537728)) != false)
            {
                    val_26 = "";
            }
            else
            {
                    string val_8 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_1C.ToUpper();
                val_26 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_1C;
            }
            
            int val_9 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_14.GetCheckpointsCompletedInRank();
            string val_10 = SLC.Minigames.MinigamesUtils.RomanNumeralize(num:  val_9);
            string val_11 = System.String.Format(format:  1592589744, arg0:  val_26, arg1:  val_9);
            string val_13 = (public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_14 + 16).ToString();
            string val_14 = System.String.Format(format:  -1225078832, arg0:  (public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_14 + 16));
            twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            decimal val_16 = System.Decimal.op_Implicit(value:  910371204);
            decimal val_17 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 910371184, hi = R6, lo = R7, mid = R8}, d2:  new System.Decimal() {flags = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_2C});
            GameEcon val_18 = App.getGameEcon;
            string val_19 = ToString(format:  null);
            string val_20 = System.String.Format(format:  -1225078832, arg0:  910371224);
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) != false)
            {
                    mem[1152921514107164868].interactable = true;
                val_27 = 1152921511451483792;
                mem[1152921514107164876].interactable = false;
                val_28 = 0;
            }
            else
            {
                    mem[1152921514107164868].interactable = false;
                val_27 = 1152921511451483792;
                mem[1152921514107164876].interactable = true;
                val_28 = 1;
            }
            
            mem[1152921514107164872].interactable = true;
            twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            TrackMinigameSessionEnd();
        }
        public MinigamesGameOver_Window()
        {
        
        }
    
    }

}
