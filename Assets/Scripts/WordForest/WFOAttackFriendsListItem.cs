using UnityEngine;

namespace WordForest
{
    public class WFOAttackFriendsListItem : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image userPicture;
        private UnityEngine.UI.Text labelBody;
        private UnityEngine.UI.Button buttonAttack;
        private WordForest.UserForestProfile forestProfileData;
        private System.Action<WordForest.UserForestProfile> onButtonClicked;
        
        // Methods
        public void Initialize(WordForest.UserForestProfile data, System.Action<WordForest.UserForestProfile> onBtnClicked)
        {
            this.forestProfileData = data;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Sprite val_2 = public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_10.GetAvatarSpriteByID(id:  this.forestProfileData.avatarId);
            this.userPicture.sprite = public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_10;
            this.onButtonClicked = onBtnClicked;
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  283197520, method:  new IntPtr(283172496));
            this.buttonAttack.m_OnClick.AddListener(call:  162246656);
        }
        private void OnActiveButtonClicked()
        {
            if(this.onButtonClicked == 0)
            {
                    return;
            }
            
            this.onButtonClicked.Invoke(obj:  this.forestProfileData);
        }
        public WFOAttackFriendsListItem()
        {
        
        }
    
    }

}
