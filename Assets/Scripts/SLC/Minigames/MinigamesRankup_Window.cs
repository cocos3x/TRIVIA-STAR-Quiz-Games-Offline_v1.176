using UnityEngine;

namespace SLC.Minigames
{
    public class MinigamesRankup_Window : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text titleText;
        private UnityEngine.UI.Button continueButton;
        private SLC.Minigames.MinigameRankSpriteDisplay rankSpriteDisplay;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  912143680, method:  new IntPtr(912118656));
            this.continueButton.m_OnClick.AddListener(call:  162246656);
        }
        private void OnClick_ContinueButton()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C.Invoke();
            UnityEngine.GameObject val_2 = this.gameObject;
            this.SetActive(value:  false);
            UnityEngine.GameObject val_3 = this.gameObject;
            SLCWindow.CloseWindow(window:  912263872, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnEnable()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.MinigameLevelRank val_3 = GetCurrentRank;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.MinigameLevelRank val_5 = GetNextRank;
            string val_6 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_1C.ToUpper();
            string val_7 = System.String.Format(format:  912355968, arg0:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_1C);
            this.rankSpriteDisplay.DisplaySprite(rank:  -1745297776);
        }
        public MinigamesRankup_Window()
        {
        
        }
    
    }

}
