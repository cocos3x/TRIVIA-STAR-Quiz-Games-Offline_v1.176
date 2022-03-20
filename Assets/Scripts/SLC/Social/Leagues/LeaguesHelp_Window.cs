using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesHelp_Window : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button closeButton;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  881777584, method:  new IntPtr(881752560));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
        }
        public LeaguesHelp_Window()
        {
        
        }
        private void <Start>b__1_0()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  882009776, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
    
    }

}
