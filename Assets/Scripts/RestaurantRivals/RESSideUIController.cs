using UnityEngine;

namespace RestaurantRivals
{
    public class RESSideUIController : ARESUIController
    {
        // Fields
        private UnityEngine.UI.Button spinBuyButton;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  649375856, name:  -843944304);
        }
        private void Start()
        {
            this.UpdateUI();
        }
        private void UpdateUI()
        {
            Player val_1 = App.Player;
            RestaurantRivals.RESGameEcon val_2 = RestaurantRivals.RESGameEcon.Instance;
            UnityEngine.GameObject val_3 = this.spinBuyButton.gameObject;
            if(0 >= 0)
            {
                    0 = 1;
            }
            
            if(0 < 0)
            {
                    0 = 0;
            }
            
            this.spinBuyButton.SetActive(value:  false);
        }
        private void OnLevelUp()
        {
            this.UpdateUI();
        }
        public RESSideUIController()
        {
        
        }
    
    }

}
