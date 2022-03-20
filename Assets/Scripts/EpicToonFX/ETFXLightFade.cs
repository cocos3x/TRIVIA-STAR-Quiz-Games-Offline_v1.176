using UnityEngine;

namespace EpicToonFX
{
    public class ETFXLightFade : MonoBehaviour
    {
        // Fields
        public float life;
        public bool killAfterLife;
        private UnityEngine.Light li;
        private float initIntensity;
        
        // Methods
        private void Start()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            object val_2 = this.GetComponent<System.Object>();
            UnityEngine.GameObject val_4 = this.gameObject;
            if((UnityEngine.Object.op_Implicit(exists:  693137920)) != false)
            {
                    object val_5 = this.GetComponent<System.Object>();
                this.li = this;
                float val_6 = this.intensity;
                this.initIntensity = this;
                return;
            }
            
            string val_7 = this.name;
            string val_8 = 693113792 + 693137920;
            UnityEngine.MonoBehaviour.print(message:  693113792);
        }
        private void Update()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            object val_2 = this.GetComponent<System.Object>();
            if((UnityEngine.Object.op_Implicit(exists:  693258112)) == false)
            {
                    return;
            }
            
            float val_4 = this.li.intensity;
            float val_5 = UnityEngine.Time.deltaTime;
            this.li.intensity = 0 / this.life;
            if(this.killAfterLife == false)
            {
                    return;
            }
            
            float val_7 = this.li.intensity;
            if(this.li > 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_8 = this.li.gameObject;
            object val_9 = this.GetComponent<System.Object>();
            UnityEngine.Object.Destroy(obj:  693258112);
        }
        public ETFXLightFade()
        {
            this.killAfterLife = true;
            this.life = 0.2f;
        }
    
    }

}
