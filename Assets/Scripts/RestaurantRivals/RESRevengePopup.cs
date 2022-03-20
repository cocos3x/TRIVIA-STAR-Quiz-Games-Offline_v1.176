using UnityEngine;

namespace RestaurantRivals
{
    public class RESRevengePopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button closeButton;
        private RestaurantRivals.RESRevengeListItem prefabListItem;
        private UnityEngine.UI.ScrollRect scrollRect;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  641995856, method:  new IntPtr(641970832));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
        }
        private void CloseWindow()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  642116048, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public void Initialize(RestaurantRivals.UserRestaurantProfile randomUser, System.Collections.Generic.List<RestaurantRivals.UserRestaurantProfile> revengeUserList)
        {
            RestaurantRivals.UserRestaurantProfile val_7;
            System.Action<twelvegigs.storage.JsonDictionary> val_8;
            bool val_9;
            val_7 = randomUser;
            if(revengeUserList == 0)
            {
                    return;
            }
            
            object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  this.prefabListItem, parent:  this.scrollRect.m_Content);
            val_8 = null;
            val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  642263888, method:  new IntPtr(642225552));
            val_9 = val_8.IsCurrentOpponent(profile:  val_7);
            this.prefabListItem.Initialize(data:  val_7, onBtnClicked:  7401472, isRandomTarget:  true, buttonText:  "RANDOM", isCurrentTarget:  val_9);
            if(this.prefabListItem < 1)
            {
                    return;
            }
            
            do
            {
                val_8 = 0;
                if(this.prefabListItem <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(2621443 != 0)
            {
                    object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  this.prefabListItem, parent:  this.scrollRect.m_Content);
                val_9 = this.prefabListItem;
                if(this.prefabListItem <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((new System.Action<twelvegigs.storage.JsonDictionary>(object:  642263888, method:  new IntPtr(642238864))) <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_8 = this.IsCurrentOpponent(profile:  2621443);
                val_9.Initialize(data:  val_7, onBtnClicked:  7401472, isRandomTarget:  false, buttonText:  "REVENGE", isCurrentTarget:  val_8);
            }
            
                var val_7 = 4 + 1;
            }
            while((4 - 3) < val_9);
        
        }
        private void OnItemRandomClicked(RestaurantRivals.UserRestaurantProfile targetRestaurant)
        {
            var val_6;
            System.Action val_8;
            object val_1 = new System.Object();
            typeof(RESRevengePopup.<>c__DisplayClass6_0).__il2cppRuntimeField_8 = targetRestaurant;
            UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  642414800, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = null;
            val_6 = null;
            val_8 = RESRevengePopup.<>c.<>9__6_0;
            if(val_8 == 0)
            {
                    val_8 = null;
                val_8 = new System.Action(object:  RESRevengePopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(642388752));
                RESRevengePopup.<>c.<>9__6_0 = val_8;
            }
            
            System.Action val_5 = new System.Action(object:  428965888, method:  new IntPtr(642389776));
            ExtendCurtains(sceneType:  0, onComplete:  7454720, onMiddle:  7454720);
        }
        private void OnItemRevengeClicked(RestaurantRivals.UserRestaurantProfile targetRestaurant)
        {
            var val_6;
            System.Action val_8;
            object val_1 = new System.Object();
            typeof(RESRevengePopup.<>c__DisplayClass7_0).__il2cppRuntimeField_8 = targetRestaurant;
            UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  642537040, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = null;
            val_6 = null;
            val_8 = RESRevengePopup.<>c.<>9__7_0;
            if(val_8 == 0)
            {
                    val_8 = null;
                val_8 = new System.Action(object:  RESRevengePopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(642510992));
                RESRevengePopup.<>c.<>9__7_0 = val_8;
            }
            
            System.Action val_5 = new System.Action(object:  429072384, method:  new IntPtr(642512016));
            ExtendCurtains(sceneType:  0, onComplete:  7454720, onMiddle:  7454720);
        }
        private bool IsCurrentOpponent(RestaurantRivals.UserRestaurantProfile profile)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(519134400 == 0)
            {
                    return false;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static RestaurantRivals.RESAttackScreenMain MonoSingleton<RestaurantRivals.RESAttackScreenMain>::get_Instance()) != 0)
            {
                    return IsCurrentOpponent(profile:  profile);
            }
            
            return IsCurrentOpponent(profile:  profile);
        }
        public RESRevengePopup()
        {
        
        }
    
    }

}
