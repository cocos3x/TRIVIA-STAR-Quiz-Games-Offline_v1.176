using UnityEngine;

namespace RestaurantRivals
{
    public class RESAttackFriendsPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button closeButton;
        private RestaurantRivals.RESAttackFriendsListItem prefabListItem;
        private UnityEngine.UI.ScrollRect scrollRect;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  518432128, method:  new IntPtr(518407104));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
        }
        private void CloseWindow()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  518552320, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public void Initialize(System.Collections.Generic.List<RestaurantRivals.UserRestaurantProfile> friendsList)
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
            
                System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  518683776, method:  new IntPtr(518658752));
                this.prefabListItem.Initialize(data:  0, onBtnClicked:  7401472);
            }
            
                var val_3 = 4 + 1;
            }
            while((4 - 3) < this.prefabListItem);
        
        }
        private void OnItemClicked(RestaurantRivals.UserRestaurantProfile targetRestaurant)
        {
            object val_1 = new System.Object();
            typeof(RESAttackFriendsPopup.<>c__DisplayClass6_0).__il2cppRuntimeField_8 = targetRestaurant;
            UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  518818304, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_4 = new System.Action(object:  422842368, method:  new IntPtr(518793280));
            ExtendCurtains(sceneType:  0, onComplete:  7454720, onMiddle:  0);
        }
        public RESAttackFriendsPopup()
        {
        
        }
    
    }

}
