using UnityEngine;

namespace WordForest
{
    public class WFOWordChestRewardsPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button closeButton;
        private UnityEngine.UI.Button okayButton;
        private UnityEngine.Transform scrollViewParent;
        private WordForest.WFOChestRewardItem rewardItemPrefab;
        private UnityEngine.GameObject islandParadiseGroup;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  354883472, method:  new IntPtr(354850256));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  354883472, method:  new IntPtr(354850256));
            this.okayButton.m_OnClick.AddListener(call:  162246656);
        }
        private void OnEnable()
        {
            this.ToggleItemStates();
        }
        private void CloseWindow()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  355123856, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void ToggleItemStates()
        {
            if(IslandParadiseEventHandler.IsEventActive == false)
            {
                    1 = 0;
            }
            
            this.islandParadiseGroup.SetActive(value:  false);
        }
        public WFOWordChestRewardsPopup()
        {
        
        }
    
    }

}
