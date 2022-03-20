using UnityEngine;

namespace EpicToonFX
{
    public class ETFXRotation : MonoBehaviour
    {
        // Fields
        public UnityEngine.Vector3 rotateVector;
        public EpicToonFX.ETFXRotation.spaceEnum rotateSpace;
        
        // Methods
        private void Start()
        {
        
        }
        private void Update()
        {
            spaceEnum val_7;
            UnityEngine.Vector3 val_8;
            var val_10;
            val_7 = this.rotateSpace;
            if(val_7 == 0)
            {
                    UnityEngine.Transform val_1 = this.transform;
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 4.860344E-14f, y = mem[this.rotateVector + (0)], z = mem[this.rotateVector + (4)]}, d:  UnityEngine.Time.deltaTime);
                this.Rotate(eulers:  new UnityEngine.Vector3());
                val_7 = this.rotateSpace;
            }
            
            if(val_7 != 1)
            {
                    return;
            }
            
            val_10 = 0;
            UnityEngine.Transform val_4 = this.transform;
            val_8 = this.rotateVector;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 4.860344E-14f, y = val_8, z = mem[this.rotateVector + (4)]}, d:  UnityEngine.Time.deltaTime);
            this.Rotate(eulers:  new UnityEngine.Vector3(), relativeTo:  0);
        }
        public ETFXRotation()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        }
    
    }

}
