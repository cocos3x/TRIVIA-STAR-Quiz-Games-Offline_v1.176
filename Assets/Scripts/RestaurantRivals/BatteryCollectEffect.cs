using UnityEngine;

namespace RestaurantRivals
{
    public class BatteryCollectEffect : MonoBehaviour
    {
        // Fields
        private UnityEngine.ParticleSystem batteryParticles;
        private UnityEngine.GameObject windField;
        private float windFieldDelay;
        private float showTextDelay;
        private int spinGain;
        
        // Methods
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.windField.gameObject;
            this.windField.SetActive(value:  false);
        }
        public void Play(int spins = 0, UnityEngine.Transform origin)
        {
            var val_7;
            UnityEngine.GameObject val_1 = this.windField.gameObject;
            val_7 = this.windField;
            val_7.SetActive(value:  false);
            if(origin != 0)
            {
                    UnityEngine.Transform val_3 = this.batteryParticles.transform;
                val_7 = this.batteryParticles;
                UnityEngine.Vector3 val_4 = position;
                val_7.position = new UnityEngine.Vector3();
            }
            
            System.Collections.IEnumerator val_5 = this.PlayBatteryCollectEffect();
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  514480400);
            this.spinGain = spins;
        }
        private System.Collections.IEnumerator PlayBatteryCollectEffect()
        {
            object val_1 = new System.Object();
            typeof(BatteryCollectEffect.<PlayBatteryCollectEffect>d__7).__il2cppRuntimeField_8 = 0;
            typeof(BatteryCollectEffect.<PlayBatteryCollectEffect>d__7).__il2cppRuntimeField_10 = this;
        }
        private void ShowSpinGainAmount(int spins)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_14.ShowAddSpinTipAndNotify(amount:  spins);
        }
        private void UpdateSpinAmount()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  514828688, aName:  -1275408272);
        }
        public BatteryCollectEffect()
        {
            this.windFieldDelay = 0.8f;
            this.showTextDelay = 0.5f;
        }
    
    }

}
