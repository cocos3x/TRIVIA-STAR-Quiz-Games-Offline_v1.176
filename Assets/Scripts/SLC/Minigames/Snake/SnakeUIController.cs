using UnityEngine;

namespace SLC.Minigames.Snake
{
    public class SnakeUIController : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text pauseText;
        private UnityEngine.UI.Text levelText;
        private UnityEngine.UI.Text objText;
        private UnityEngine.UI.Button failButton;
        private UnityEngine.UI.Button winButton;
        private UnityEngine.UI.Button objButton;
        private UnityEngine.UI.Button pauseButton;
        
        // Methods
        public void UpdateUI(bool paused, int currLevel, int currObjs, int reqObjs)
        {
            if(paused == true)
            {
                    "" = "PAUSED";
            }
            
            string val_1 = System.String.Format(format:  1034739024, arg0:  13152256);
            string val_2 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            if(this.objText != 0)
            {
                    return;
            }
        
        }
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  1034928368, method:  new IntPtr(1034875696));
            this.failButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  1034928368, method:  new IntPtr(1034884912));
            this.winButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  1034928368, method:  new IntPtr(1034894128));
            this.objButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  1034928368, method:  new IntPtr(1034903344));
            this.pauseButton.m_OnClick.AddListener(call:  162246656);
        }
        private void OnClick_Fail()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandleFailed();
        }
        private void OnClick_Win()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.Snake.SnakeGameManager MonoSingleton<SLC.Minigames.Snake.SnakeGameManager>::get_Instance().__il2cppRuntimeField_14 = public static SLC.Minigames.Snake.SnakeGameManager MonoSingleton<SLC.Minigames.Snake.SnakeGameManager>::get_Instance().__il2cppRuntimeField_18;
            HandleCollectedObjective();
        }
        private void OnClick_Obj()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandleCollectedObjective();
        }
        private void OnClick_Pause()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnPauseInput();
        }
        public SnakeUIController()
        {
        
        }
    
    }

}
