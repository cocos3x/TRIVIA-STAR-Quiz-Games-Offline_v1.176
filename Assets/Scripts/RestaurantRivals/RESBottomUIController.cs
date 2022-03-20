using UnityEngine;

namespace RestaurantRivals
{
    public class RESBottomUIController : ARESUIController
    {
        // Fields
        private UnityEngine.UI.Button freeSpinBtn;
        
        // Methods
        private void Start()
        {
            var val_2;
            UnityEngine.Events.UnityAction val_4;
            val_2 = null;
            val_2 = null;
            val_4 = RESBottomUIController.<>c.<>9__1_0;
            if(val_4 == 0)
            {
                    val_4 = null;
                val_4 = new UnityEngine.Events.UnityAction(object:  RESBottomUIController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(528048880));
                RESBottomUIController.<>c.<>9__1_0 = val_4;
            }
            
            this.freeSpinBtn.m_OnClick.AddListener(call:  162246656);
            this.UpdateUI();
        }
        private void UpdateUI()
        {
            var val_12;
            bool val_13;
            UnityEngine.GameObject val_1 = this.freeSpinBtn.gameObject;
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            val_12 = 1030672;
            RestaurantRivals.RESGameEcon val_3 = RestaurantRivals.RESGameEcon.Instance;
            val_13 = 0;
            WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            val_12 = public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance();
            val_13 = 0;
            if(VideoEnabledAndUnlocked() != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_12 = Spins;
                RestaurantRivals.RESGameEcon val_8 = RestaurantRivals.RESGameEcon.Instance;
                val_13 = 0;
                WordPets.WPTDataParser val_9 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
                val_13 = rewardVideoCapReached ^ 1;
            }
            
            this.freeSpinBtn.SetActive(value:  val_13);
        }
        protected override void OnSpinAmountUpdate()
        {
            this.UpdateUI();
        }
        public RESBottomUIController()
        {
        
        }
    
    }

}
