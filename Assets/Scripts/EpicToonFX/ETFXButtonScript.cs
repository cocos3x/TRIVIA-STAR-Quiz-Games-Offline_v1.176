using UnityEngine;

namespace EpicToonFX
{
    public class ETFXButtonScript : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject Button;
        private UnityEngine.UI.Text MyButtonText;
        private string projectileParticleName;
        private EpicToonFX.ETFXFireProjectile effectScript;
        private ETFXProjectileScript projectileScript;
        public float buttonsX;
        public float buttonsY;
        public float buttonsSizeX;
        public float buttonsSizeY;
        public float buttonsDistance;
        
        // Methods
        private void Start()
        {
            UnityEngine.GameObject val_1 = UnityEngine.GameObject.Find(name:  688598720);
            object val_2 = GetComponent<System.Object>();
            this.effectScript = "ETFXFireProjectile";
            this.getProjectileNames();
            UnityEngine.Transform val_3 = this.Button.transform;
            UnityEngine.Transform val_4 = this.Button.Find(n:  688603952);
            object val_5 = this.Button.GetComponent<System.Object>();
            this.MyButtonText = this.Button;
            if(this.Button == 0)
            {
                
            }
        
        }
        private void Update()
        {
            if(this.MyButtonText == 0)
            {
                
            }
        
        }
        public void getProjectileNames()
        {
            if(this.effectScript != 0)
            {
                goto label_1;
            }
            
            this.effectScript = this.effectScript;
            if(this.effectScript == 0)
            {
                goto label_2;
            }
            
            label_1:
            UnityEngine.GameObject val_3 = this.effectScript.projectiles[this.effectScript.currentProjectile];
            object val_1 = val_3.GetComponent<System.Object>();
            this.projectileScript = val_3;
            string val_2 = val_3.name;
            this.projectileParticleName = val_3;
            return;
            label_2:
        }
        public bool overButton()
        {
            var val_7;
            var val_15;
            UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  this.buttonsSizeY, y:  null, width:  null, height:  null);
            float val_15 = this.buttonsX;
            UnityEngine.Rect val_2;
            val_15 = val_15 + this.buttonsDistance;
            val_2 = new UnityEngine.Rect(x:  val_15, y:  null, width:  this.buttonsSizeY, height:  null);
            UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector3 val_6 = UnityEngine.Input.mousePosition;
            float val_16 = (float)UnityEngine.Screen.height;
            val_16 = val_16 - val_7;
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_16, y:  val_6.y);
            val_15 = 1;
            if((val_1.m_XMin.Contains(point:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y})) == true)
            {
                    return (bool)val_2.m_XMin.Contains(point:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
            }
            
            UnityEngine.Vector3 val_10 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector3 val_12 = UnityEngine.Input.mousePosition;
            float val_17 = (float)UnityEngine.Screen.height;
            val_17 = val_17 - val_7;
            UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_17, y:  val_12.y);
            return (bool)val_2.m_XMin.Contains(point:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
        }
        public ETFXButtonScript()
        {
        
        }
    
    }

}
