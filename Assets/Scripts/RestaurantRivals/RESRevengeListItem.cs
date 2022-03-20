using UnityEngine;

namespace RestaurantRivals
{
    public class RESRevengeListItem : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image userPicture;
        private UnityEngine.UI.Text labelBody;
        private UnityEngine.UI.Button buttonGreen;
        private UnityEngine.UI.Button buttonBlue;
        private RestaurantRivals.UserRestaurantProfile restaurantProfileData;
        private UnityEngine.UI.Button activeButton;
        private System.Action<RestaurantRivals.UserRestaurantProfile> onButtonClicked;
        
        // Methods
        public void Initialize(RestaurantRivals.UserRestaurantProfile data, System.Action<RestaurantRivals.UserRestaurantProfile> onBtnClicked, bool isRandomTarget = False, string buttonText, bool isCurrentTarget = False)
        {
            var val_14;
            bool val_15;
            System.Action<RestaurantRivals.UserRestaurantProfile> val_16;
            int val_17;
            RestaurantRivals.UserRestaurantProfile val_18;
            val_14 = this;
            val_15 = isRandomTarget;
            val_16 = onBtnClicked;
            this.restaurantProfileData = data;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_17 = this.restaurantProfileData.avatarId;
            UnityEngine.Sprite val_2 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C.GetAvatarSpriteByID(id:  val_17);
            this.userPicture.sprite = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C;
            mem[1152921513838358516] = val_16;
            UnityEngine.GameObject val_3 = this.buttonBlue.gameObject;
            this.buttonBlue.SetActive(value:  val_15);
            UnityEngine.GameObject val_4 = this.buttonGreen.gameObject;
            this.buttonGreen.SetActive(value:  val_15 ^ 1);
            this.activeButton = this.buttonBlue;
            UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  641576912, method:  new IntPtr(641539600));
            this.buttonBlue.m_OnClick.AddListener(call:  162246656);
            val_18 = data;
            if(isCurrentTarget != false)
            {
                    this.activeButton.interactable = false;
            }
            
            if(val_15 != true)
            {
                    if((data + 52.ContainsAttackableObjects) != true)
            {
                    UnityEngine.GameObject val_8 = this.activeButton.gameObject;
                this.activeButton.SetActive(value:  false);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  buttonText)) == true)
            {
                goto label_27;
            }
            
            object val_10 = this.activeButton.GetComponentInChildren<System.Object>();
            if(this.activeButton == 0)
            {
                goto label_27;
            }
            
            if(this.activeButton != 0)
            {
                goto typeof(UnityEngine.UI.Button).__il2cppRuntimeField_314;
            }
            
            goto typeof(UnityEngine.UI.Button).__il2cppRuntimeField_314;
            label_27:
            var val_12 = FP - 28;
        }
        private void OnActiveButtonClicked()
        {
            if(this.onButtonClicked == 0)
            {
                    return;
            }
            
            this.onButtonClicked.Invoke(obj:  this.restaurantProfileData);
        }
        public RESRevengeListItem()
        {
        
        }
    
    }

}
