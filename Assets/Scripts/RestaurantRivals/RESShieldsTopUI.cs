using UnityEngine;

namespace RestaurantRivals
{
    public class RESShieldsTopUI : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject[] shield_objects;
        private UnityEngine.UI.Image[] shield_icons;
        private UnityEngine.ParticleSystem shieldBrokenAnimation;
        
        // Methods
        private void OnEnable()
        {
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            this.UpdateShieldsIcon(shieldCount:  1030672, showBrokenAnima:  false);
        }
        public UnityEngine.Transform GetShieldIcon(int index)
        {
            if(index < 0)
            {
                    return;
            }
            
            if(this < index)
            {
                    return;
            }
            
            UnityEngine.UI.Image val_1 = this.shield_icons[index];
            if(val_1 != 0)
            {
                    return val_1.transform;
            }
            
            return val_1.transform;
        }
        public void UpdateShieldsIcon(int shieldCount, bool showBrokenAnima)
        {
            var val_4;
            UnityEngine.UI.Image val_5;
            var val_6;
            val_4 = 0;
            goto label_1;
            label_10:
            UnityEngine.GameObject val_4 = this.shield_objects[val_4];
            UnityEngine.GameObject val_1 = val_4.gameObject;
            val_5 = val_4;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(val_4 < MaxShieldCount)
            {
                    0 = 1;
            }
            
            val_5.SetActive(value:  true);
            val_4 = 1;
            label_1:
            if(val_4 < val_5)
            {
                goto label_10;
            }
            
            val_6 = 0;
            goto label_11;
            label_16:
            val_5 = this.shield_icons[val_6];
            if(val_6 < shieldCount)
            {
                    0 = 1;
            }
            
            val_5.enabled = true;
            val_6 = 1;
            label_11:
            if(val_6 < val_5)
            {
                goto label_16;
            }
            
            if(showBrokenAnima == false)
            {
                    return;
            }
            
            this.shieldBrokenAnimation.Play();
        }
        public RESShieldsTopUI()
        {
        
        }
    
    }

}
