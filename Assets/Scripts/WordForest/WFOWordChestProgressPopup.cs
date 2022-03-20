using UnityEngine;

namespace WordForest
{
    public class WFOWordChestProgressPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button closeButton;
        private UnityEngine.UI.Button chestRewardsButton;
        private UnityEngine.UI.Text titleText;
        private UnityEngine.UI.Text rewardsAmountText;
        private UnityEngine.UI.Text wordsRemainingText;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  354388368, method:  new IntPtr(354341504));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  354388368, method:  new IntPtr(354350720));
            this.chestRewardsButton.m_OnClick.AddListener(call:  162246656);
            Player val_3 = App.Player;
            if(0 != 0)
            {
                    UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                string val_4 = ToUpper();
                string val_5 = System.String.Format(format:  354355840, arg0:  407879680);
                WordForest.WFOGameEcon val_6 = WordForest.WFOGameEcon.Instance;
                int val_8 = 1289.Item[1];
                string val_9 = System.String.Format(format:  354360032, arg0:  13152256);
                if(( - ) == 1)
            {
                    "s" = "";
            }
            
                string val_10 = System.String.Format(format:  354364240, arg0:  13152256, arg1:  1098586544);
                if(this.wordsRemainingText != 0)
            {
                    return;
            }
            
                return;
            }
        
        }
        private void OnCloseButtonClicked()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  354529040, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnRewardsButtonClicked()
        {
            GameBehavior val_1 = App.getBehavior;
            UnityEngine.GameObject val_3 = this.gameObject;
            SLCWindow.CloseWindow(window:  354642064, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public WFOWordChestProgressPopup()
        {
        
        }
    
    }

}
