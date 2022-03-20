using UnityEngine;

namespace WordForest
{
    public class WFORevengeListItem : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image userPicture;
        private UnityEngine.UI.Text labelBody;
        private UnityEngine.UI.Button buttonGreen;
        private UnityEngine.UI.Button buttonBlue;
        private WordForest.UserForestProfile forestProfileData;
        private UnityEngine.UI.Button activeButton;
        private System.Action<WordForest.UserForestProfile> onButtonClicked;
        
        // Methods
        public void Initialize(WordForest.UserForestProfile data, System.Action<WordForest.UserForestProfile> onBtnClicked, bool isRandomTarget = False, string buttonText)
        {
            var val_14;
            bool val_15;
            System.Action<WordForest.UserForestProfile> val_16;
            int val_17;
            UnityEngine.Events.UnityAction val_18;
            val_14 = this;
            val_15 = isRandomTarget;
            val_16 = onBtnClicked;
            this.forestProfileData = data;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_17 = this.forestProfileData.avatarId;
            UnityEngine.Sprite val_2 = public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_10.GetAvatarSpriteByID(id:  val_17);
            this.userPicture.sprite = public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_10;
            mem[1152921513536432500] = val_16;
            UnityEngine.GameObject val_3 = this.buttonBlue.gameObject;
            this.buttonBlue.SetActive(value:  val_15);
            UnityEngine.GameObject val_4 = this.buttonGreen.gameObject;
            this.buttonGreen.SetActive(value:  val_15 ^ 1);
            this.activeButton = this.buttonBlue;
            val_18 = null;
            val_18 = new UnityEngine.Events.UnityAction(object:  339650896, method:  new IntPtr(339617680));
            this.buttonBlue.m_OnClick.AddListener(call:  162246656);
            if(val_15 != true)
            {
                    if((data + 56) != 0)
            {
                    if((data + 52.CurrentForestGrowth(includeDamagedTrees:  false)) > 0)
            {
                goto label_19;
            }
            
            }
            
                UnityEngine.GameObject val_8 = this.activeButton.gameObject;
                this.activeButton.SetActive(value:  false);
            }
            
            label_19:
            if((System.String.IsNullOrEmpty(value:  buttonText)) == true)
            {
                goto label_26;
            }
            
            object val_10 = this.activeButton.GetComponentInChildren<System.Object>();
            if(this.activeButton == 0)
            {
                goto label_26;
            }
            
            if(this.activeButton != 0)
            {
                goto typeof(UnityEngine.UI.Button).__il2cppRuntimeField_314;
            }
            
            goto typeof(UnityEngine.UI.Button).__il2cppRuntimeField_314;
            label_26:
            var val_12 = FP - 28;
        }
        private void OnActiveButtonClicked()
        {
            if(this.onButtonClicked == 0)
            {
                    return;
            }
            
            this.onButtonClicked.Invoke(obj:  this.forestProfileData);
        }
        public WFORevengeListItem()
        {
        
        }
    
    }

}
