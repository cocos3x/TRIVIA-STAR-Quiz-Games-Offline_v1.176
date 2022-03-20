using UnityEngine;

namespace EpicToonFX
{
    public class ETFXPitchRandomizer : MonoBehaviour
    {
        // Fields
        public float randomPercent;
        
        // Methods
        private void Start()
        {
            UnityEngine.Transform val_1 = this.transform;
            object val_2 = this.GetComponent<System.Object>();
            float val_3 = this.pitch;
            float val_5 = -100f;
            float val_6 = this.randomPercent;
            val_5 = val_6 / val_5;
            val_6 = val_6 / 100f;
            float val_4 = UnityEngine.Random.Range(min:  val_5, max:  null);
            float val_7 = 1f;
            val_7 = val_5 + val_7;
            val_7 = 693490304 * val_7;
            this.pitch = val_7;
        }
        public ETFXPitchRandomizer()
        {
            this.randomPercent = 10f;
        }
    
    }

}
