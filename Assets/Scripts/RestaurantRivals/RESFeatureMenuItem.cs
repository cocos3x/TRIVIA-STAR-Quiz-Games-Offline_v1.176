using UnityEngine;

namespace RestaurantRivals
{
    public class RESFeatureMenuItem : FeatureMenuItem
    {
        // Fields
        private UnityEngine.Transform NotiMessage;
        private UnityEngine.UI.Text NotiMessageTxt;
        
        // Methods
        public override void Setup(WGFeatureMenu.FeatureMenuItemConfig config)
        {
            var val_4;
            this.Setup(config:  config);
            if(config == 0)
            {
                goto label_3;
            }
            
            UnityEngine.GameObject val_1 = this.NotiMessage.gameObject;
            val_4 = this.NotiMessage;
            if(R7 == 0)
            {
                goto label_6;
            }
            
            val_4.SetActive(value:  true);
            if(this.NotiMessageTxt != 0)
            {
                goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
            }
            
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
            label_6:
            this.NotiMessageTxt.SetActive(value:  false);
            return;
            label_3:
        }
        public RESFeatureMenuItem()
        {
        
        }
    
    }

}
