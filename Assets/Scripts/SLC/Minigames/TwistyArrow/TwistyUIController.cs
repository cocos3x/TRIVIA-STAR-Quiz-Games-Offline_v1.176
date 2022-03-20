using UnityEngine;

namespace SLC.Minigames.TwistyArrow
{
    public class TwistyUIController : MonoSingleton<SLC.Minigames.TwistyArrow.TwistyUIController>
    {
        // Fields
        private UnityEngine.CanvasGroup MainCanvas;
        private UnityEngine.GameObject GameScreen;
        private UnityEngine.GameObject PauseScreen;
        private UnityEngine.UI.Text InfoText;
        private UnityEngine.UI.Button TapArea;
        private UnityEngine.GameObject CheckMark;
        private UnityEngine.GameObject XMark;
        private SLC.Minigames.MinigameLivesDisplay HeartsDisplay;
        private UnityEngine.UI.Button ButtonContinue;
        private UnityEngine.UI.Button ButtonQuit;
        private UnityEngine.UI.Button ButtonResume;
        
        // Methods
        public override void InitMonoSingleton()
        {
            var val_20;
            var val_21;
            var val_22;
            System.Action val_23;
            var val_24;
            var val_25;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  1017669440, method:  new IntPtr(1017604480));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78, b:  7401472);
            val_20 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78;
            if(val_20 != 0)
            {
                    if(val_20 == null)
            {
                goto label_6;
            }
            
            }
            
            val_20 = 0;
            label_6:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78 = val_20;
            val_21 = 1152921512348668176;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  1017669440, method:  new IntPtr(1017605504));
            System.Delegate val_6 = System.Delegate.Combine(a:  public static SLC.Minigames.TwistyArrow.TwistyGameManager MonoSingleton<SLC.Minigames.TwistyArrow.TwistyGameManager>::get_Instance().__il2cppRuntimeField_14, b:  7401472);
            val_22 = public static SLC.Minigames.TwistyArrow.TwistyGameManager MonoSingleton<SLC.Minigames.TwistyArrow.TwistyGameManager>::get_Instance().__il2cppRuntimeField_14;
            val_23 = 1152921504901095424;
            if(val_22 != 0)
            {
                    if(val_22 == null)
            {
                goto label_12;
            }
            
            }
            
            val_22 = 0;
            label_12:
            public static SLC.Minigames.TwistyArrow.TwistyGameManager MonoSingleton<SLC.Minigames.TwistyArrow.TwistyGameManager>::get_Instance().__il2cppRuntimeField_14 = val_22;
            UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  1017669440, method:  new IntPtr(1017614720));
            this.TapArea.m_OnClick.AddListener(call:  162246656);
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Events.UnityAction val_9 = new UnityEngine.Events.UnityAction(object:  1017669440, method:  new IntPtr(1017623936));
            this.ButtonContinue.m_OnClick.AddListener(call:  162246656);
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745297776) == 0)
            {
                goto label_23;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_21 = 1152921504614301696;
            System.Action val_13 = new System.Action(object:  1017669440, method:  new IntPtr(1017624960));
            System.Delegate val_14 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70, b:  7454720);
            val_24 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70;
            if(val_24 != 0)
            {
                    if(val_24 == null)
            {
                goto label_29;
            }
            
            }
            
            val_24 = 0;
            label_29:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70 = val_24;
            twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_23 = null;
            val_23 = new System.Action(object:  1017669440, method:  new IntPtr(1017625984));
            System.Delegate val_17 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68, b:  7454720);
            val_25 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68;
            if(val_25 != 0)
            {
                    if(val_25 == null)
            {
                goto label_33;
            }
            
            }
            
            val_25 = 0;
            label_33:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68 = val_25;
            label_23:
            UnityEngine.Events.UnityAction val_18 = new UnityEngine.Events.UnityAction(object:  1017669440, method:  new IntPtr(1017635200));
            this.ButtonQuit.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_19 = new UnityEngine.Events.UnityAction(object:  1017669440, method:  new IntPtr(1017644416));
            this.ButtonResume.m_OnClick.AddListener(call:  162246656);
        }
        public void SetActiveInfoText(bool active)
        {
            UnityEngine.GameObject val_1 = this.InfoText.gameObject;
            this.InfoText.SetActive(value:  active);
        }
        public void UpdateUIHearts(int currentHearts)
        {
            UnityEngine.GameObject val_1 = this.ButtonContinue.gameObject;
            this.ButtonContinue.SetActive(value:  false);
            this.HeartsDisplay.UpdateLivesDisplay(currentHearts:  currentHearts);
        }
        public void ShowCheck()
        {
            if(this.CheckMark.activeSelf != false)
            {
                    return;
            }
            
            if(this.XMark.activeSelf == true)
            {
                    return;
            }
            
            R4 + 32.SetActive(value:  true);
            R4.Invoke(methodName:  1018046976, time:  null);
        }
        public void ShowX()
        {
            if(this.CheckMark.activeSelf != false)
            {
                    return;
            }
            
            if(this.XMark.activeSelf == true)
            {
                    return;
            }
            
            R4 + 36.SetActive(value:  true);
            R4.Invoke(methodName:  1018046976, time:  null);
        }
        public void HideFeedbacks()
        {
            this.XMark.SetActive(value:  false);
            this.CheckMark.SetActive(value:  false);
        }
        private void OnTapped()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            FireArrow();
            UnityEngine.GameObject val_3 = this.InfoText.gameObject;
            if(this.InfoText.activeSelf == false)
            {
                    return;
            }
            
            R4.SetActiveInfoText(active:  false);
        }
        private void OnPauseClicked()
        {
            this.GameScreen.SetActive(value:  false);
            this.PauseScreen.SetActive(value:  true);
        }
        private void OnQuitButtonClicked()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((UnityEngine.Object.op_Implicit(exists:  899829136)) == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowGameOver();
        }
        private void OnRestartClicked()
        {
            this.PauseScreen.SetActive(value:  false);
            this.GameScreen.SetActive(value:  true);
        }
        private void OnResumeButtonClicked()
        {
            this.PauseScreen.SetActive(value:  false);
            this.GameScreen.SetActive(value:  true);
        }
        private void OnContinueButtonClicked()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            StartNewLevel();
        }
        private void OnPlayingStateChanged(bool isPlaying)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(isPlaying != false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = this.ButtonContinue.gameObject;
            this.ButtonContinue.SetActive(value:  true);
        }
        private void TogglePopupWindow(bool showing)
        {
            if(showing == true)
            {
                    1f = 0;
            }
            
            this.MainCanvas.alpha = 0f;
        }
        public TwistyUIController()
        {
        
        }
    
    }

}
