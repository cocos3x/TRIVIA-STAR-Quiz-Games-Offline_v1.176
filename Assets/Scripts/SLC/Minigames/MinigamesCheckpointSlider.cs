using UnityEngine;

namespace SLC.Minigames
{
    public class MinigamesCheckpointSlider : MonoSingleton<SLC.Minigames.MinigamesCheckpointSlider>
    {
        // Fields
        private TMPro.TMP_Text levelText;
        private UnityEngine.UI.Text cpText;
        private UnityEngine.UI.Text rankText;
        private UnityEngine.UI.Slider checkpointSlider;
        private UnityEngine.UI.Image sliderSprite;
        private System.Collections.Generic.List<SLC.Minigames.MinigameRankSpriteDisplay> icons;
        private UnityEngine.UI.Button PauseButton;
        private UnityEngine.UI.Text coinAmountText;
        private UnityEngine.UI.Button storeButton;
        
        // Methods
        private void Start()
        {
            if(this.PauseButton != 0)
            {
                    UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  905759888, method:  new IntPtr(905721552));
                this.PauseButton.m_OnClick.AddListener(call:  162246656);
            }
            
            if(this.storeButton == 0)
            {
                    return;
            }
            
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  905759888, method:  new IntPtr(905734864));
            this.storeButton.m_OnClick.AddListener(call:  162246656);
        }
        private void OnPauseClick()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70.Invoke();
        }
        private void OnStoreButtonClick()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        public void UpdateUI()
        {
            var val_12;
            int val_13;
            int val_14;
            int val_15;
            var val_16;
            val_12 = "no rank";
            bool val_1 = UnityEngine.Object.op_Inequality(x:  this.coinAmountText, y:  0);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_13 = 0;
            val_14 = 0;
            val_15 = 0;
            val_16 = 0;
            if((-1745297776) != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_14 = mem[public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_14 + 12];
                val_14 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_14 + 12;
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_15 = GetLevelsToNextCheckpoint;
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_13 = GetPlayerLevelInCurrentRank;
                twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                SLC.Minigames.MinigameLevelRank val_11 = GetCurrentRank;
            }
            
            this.UpdateUI(currLevel:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60, currCheckpoint:  val_14, levelsToNextCheckpoint:  val_15, currentLevelInRank:  val_13, rank:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_1C);
        }
        private void UpdateUI(int currLevel, int currCheckpoint, int levelsToNextCheckpoint, int currentLevelInRank, string rank)
        {
            var val_14;
            int val_14 = currCheckpoint;
            currLevel = currLevel + 1;
            string val_1 = System.String.Format(format:  -1433330688, arg0:  13152256);
            if(this.coinAmountText != 0)
            {
                    Player val_3 = App.Player;
                GameEcon val_4 = App.getGameEcon;
                string val_5 = ToString(format:  null);
            }
            
            val_14 = currentLevelInRank - val_14;
            float val_15 = (float)levelsToNextCheckpoint;
            val_15 = (float)val_14 / val_15;
            UnityEngine.Color val_6 = UnityEngine.Color.red;
            this.sliderSprite.color = new UnityEngine.Color() {r = currLevel, a = ???};
            string val_7 = val_14.ToString();
            string val_8 = levelsToNextCheckpoint.ToString();
            string val_9 = System.String.Format(format:  -1222347616, arg0:  906278888, arg1:  906278892);
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if((rank.Equals(value:  446537728)) != false)
            {
                    val_14 = "";
            }
            else
            {
                    string val_11 = rank.ToUpper();
                val_14 = rank;
            }
            
            UnityEngine.Color val_12 = UnityEngine.Color.red;
            this.rankText.color = new UnityEngine.Color() {r = currLevel, a = ???};
            object val_13 = this.rankText.GetComponent<System.Object>();
            this.rankText.ForceUpdateRectTransforms();
        }
        public MinigamesCheckpointSlider()
        {
        
        }
    
    }

}
