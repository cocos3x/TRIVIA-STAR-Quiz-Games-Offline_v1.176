using UnityEngine;

namespace WordForest
{
    public class WFOAttackFriendsPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button closeButton;
        private WordForest.WFOAttackFriendsListItem prefabListItem;
        private UnityEngine.UI.ScrollRect scrollRect;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  283597008, method:  new IntPtr(283571984));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
        }
        private void CloseWindow()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  283717200, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public void Initialize(System.Collections.Generic.List<WordForest.UserForestProfile> friendsList)
        {
            var val_3;
            if(friendsList == 0)
            {
                    return;
            }
            
            if(true < 1)
            {
                    return;
            }
            
            do
            {
                val_3 = 0;
                if(true <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(2621443 != 0)
            {
                    object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  this.prefabListItem, parent:  this.scrollRect.m_Content);
                if(this.prefabListItem <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  283848656, method:  new IntPtr(283823632));
                this.prefabListItem.Initialize(data:  0, onBtnClicked:  7401472);
            }
            
                var val_3 = 4 + 1;
            }
            while((4 - 3) < this.prefabListItem);
        
        }
        private void OnItemClicked(WordForest.UserForestProfile targetForest)
        {
            object val_1 = new System.Object();
            typeof(WFOAttackFriendsPopup.<>c__DisplayClass6_0).__il2cppRuntimeField_8 = targetForest;
            UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  283983184, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_4 = new System.Action(object:  406335488, method:  new IntPtr(283958160));
            ExtendCurtains(sceneType:  0, onComplete:  7454720);
        }
        public WFOAttackFriendsPopup()
        {
        
        }
    
    }

}
