using UnityEngine;

namespace SLC.Minigames.SnackBlock
{
    public class SnakeBlockUIController : MonoBehaviour
    {
        // Fields
        private InputEventsHandler dragInput;
        private UnityEngine.CanvasGroup mainCanvasGroup;
        private UnityEngine.Canvas mainCanvas;
        private UnityEngine.Canvas pauseCanvas;
        private UnityEngine.UI.Button quitCanvasButton;
        private UnityEngine.UI.Button resumeCanvasButton;
        private UnityEngine.GameObject FtuxUI;
        private bool showingFtux;
        
        // Properties
        public InputEventsHandler GetDragInput { get; }
        
        // Methods
        public InputEventsHandler get_GetDragInput()
        {
        
        }
        public void UpdateUI(bool paused)
        {
            this.pauseCanvas.enabled = paused;
        }
        public void HideUIForPopup(bool showingPopup)
        {
            if(showingPopup == true)
            {
                    1f = 0;
            }
            
            this.mainCanvasGroup.alpha = 0f;
        }
        public void ShowFTUX()
        {
            this.FtuxUI.SetActive(value:  true);
            this.showingFtux = true;
        }
        private void Start()
        {
            System.Action<System.Single> val_9;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745297776) != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                System.Action val_4 = new System.Action(object:  1032638480, method:  new IntPtr(1032585808));
                public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70 = null;
            }
            
            UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  1032638480, method:  new IntPtr(1032595024));
            this.quitCanvasButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  1032638480, method:  new IntPtr(1032604240));
            this.resumeCanvasButton.m_OnClick.AddListener(call:  162246656);
            System.Action<System.Single> val_7 = new System.Action<System.Single>(object:  1032638480, method:  new IntPtr(1032613456));
            System.Delegate val_8 = System.Delegate.Combine(a:  this.dragInput.HandleDragAction, b:  7401472);
            val_9 = this.dragInput.HandleDragAction;
            if(val_9 != 0)
            {
                    if(null == null)
            {
                goto label_16;
            }
            
            }
            
            val_9 = 0;
            label_16:
            this.dragInput.HandleDragAction = val_9;
        }
        private void DragInput_HandleDragAction(float obj)
        {
            if(this.showingFtux == false)
            {
                    return;
            }
            
            this.FtuxUI.SetActive(value:  false);
            this.showingFtux = false;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnPauseInput();
        }
        private void OnClick_Fail()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandleFailed();
        }
        private void OnClick_Win()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandleComplete();
        }
        private void OnClick_Pause()
        {
            if(this.showingFtux != true)
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                OnPauseInput();
            }
            
            this.pauseCanvas.enabled = true;
        }
        private void OnClick_Resume()
        {
            if(this.showingFtux != true)
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                OnPauseInput();
            }
            
            this.pauseCanvas.enabled = false;
        }
        private void OnClick_Quit()
        {
            this.pauseCanvas.enabled = false;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((UnityEngine.Object.op_Implicit(exists:  899829136)) == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowGameOver();
        }
        public SnakeBlockUIController()
        {
        
        }
    
    }

}
