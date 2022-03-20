using UnityEngine;

namespace WordForest
{
    public class WFOAcornInfoPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button closeButton;
        private UnityEngine.UI.Button okButton;
        private UnityEngine.UI.Text unlockLevelText;
        
        // Methods
        private void Start()
        {
            var val_7;
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  282578992, method:  new IntPtr(282541440));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  282578992, method:  new IntPtr(282541440));
            this.okButton.m_OnClick.AddListener(call:  162246656);
            WordForest.WFOGameEcon val_3 = WordForest.WFOGameEcon.Instance;
            if(0 != 0)
            {
                    WordForest.WFOGameEcon val_4 = WordForest.WFOGameEcon.Instance;
                val_7 = 786450;
            }
            else
            {
                    val_7 = 2;
            }
            
            string val_5 = Localization.Localize(key:  282550784, defaultValue:  282550656, useSingularKey:  false);
            string val_6 = System.String.Format(format:  282550784, arg0:  13152256);
            if(this.unlockLevelText != 0)
            {
                    return;
            }
        
        }
        private void CloseWindow()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  282711472, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public WFOAcornInfoPopup()
        {
        
        }
    
    }

}
