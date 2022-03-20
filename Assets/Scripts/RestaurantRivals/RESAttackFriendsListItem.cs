using UnityEngine;

namespace RestaurantRivals
{
    public class RESAttackFriendsListItem : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image userPicture;
        private UnityEngine.UI.Text labelBody;
        private UnityEngine.UI.Button buttonAttack;
        private RestaurantRivals.UserRestaurantProfile mapProfileData;
        private System.Action<RestaurantRivals.UserRestaurantProfile> onButtonClicked;
        
        // Methods
        public void Initialize(RestaurantRivals.UserRestaurantProfile data, System.Action<RestaurantRivals.UserRestaurantProfile> onBtnClicked)
        {
            this.mapProfileData = data;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Sprite val_2 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C.GetAvatarSpriteByID(id:  this.mapProfileData.avatarId);
            this.userPicture.sprite = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C;
            this.onButtonClicked = onBtnClicked;
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  518032640, method:  new IntPtr(518007616));
            this.buttonAttack.m_OnClick.AddListener(call:  162246656);
        }
        private void OnActiveButtonClicked()
        {
            if(this.onButtonClicked == 0)
            {
                    return;
            }
            
            this.onButtonClicked.Invoke(obj:  this.mapProfileData);
        }
        public RESAttackFriendsListItem()
        {
        
        }
    
    }

}
