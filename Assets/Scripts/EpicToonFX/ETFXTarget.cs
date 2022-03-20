using UnityEngine;

namespace EpicToonFX
{
    public class ETFXTarget : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject hitParticle;
        public UnityEngine.GameObject respawnParticle;
        private UnityEngine.Renderer targetRenderer;
        private UnityEngine.Collider targetCollider;
        
        // Methods
        private void Start()
        {
            object val_1 = this.GetComponent<System.Object>();
            this.targetRenderer = this;
            object val_2 = this.GetComponent<System.Object>();
            this.targetCollider = this;
        }
        private void SpawnTarget()
        {
            float val_5;
            float val_6;
            float val_7;
            float val_8;
            this.targetRenderer.enabled = true;
            this.targetCollider.enabled = true;
            UnityEngine.Transform val_1 = this.targetCollider.transform;
            UnityEngine.Vector3 val_2 = position;
            UnityEngine.Transform val_3 = this.targetCollider.transform;
            UnityEngine.Quaternion val_4 = rotation;
            UnityEngine.GameObject val_9 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.respawnParticle, position:  new UnityEngine.Vector3(), rotation:  new UnityEngine.Quaternion() {x = val_5, y = val_6, z = val_7, w = val_8});
            UnityEngine.Object.Destroy(obj:  this.respawnParticle, t:  val_4.x);
        }
        private void OnTriggerEnter(UnityEngine.Collider col)
        {
            float val_8;
            float val_9;
            float val_10;
            float val_11;
            float val_15;
            float val_16;
            val_15 = 35631090;
            string val_1 = col.tag;
            if((System.String.op_Equality(a:  col, b:  692043232)) == false)
            {
                    return;
            }
            
            val_16 = 1152921504765685760;
            if((UnityEngine.Object.op_Implicit(exists:  this.hitParticle)) == false)
            {
                    return;
            }
            
            UnityEngine.Transform val_4 = this.transform;
            UnityEngine.Vector3 val_5 = position;
            UnityEngine.Transform val_6 = this.transform;
            UnityEngine.Quaternion val_7 = rotation;
            val_16 = val_9;
            val_15 = val_10;
            UnityEngine.GameObject val_12 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.hitParticle, position:  new UnityEngine.Vector3(), rotation:  new UnityEngine.Quaternion() {x = val_8, y = val_16, z = val_15, w = val_11});
            UnityEngine.Object.Destroy(obj:  this.hitParticle, t:  val_7.x);
            this.targetRenderer.enabled = false;
            this.targetCollider.enabled = false;
            System.Collections.IEnumerator val_13 = this.Respawn();
            UnityEngine.Coroutine val_14 = this.StartCoroutine(routine:  692083712);
        }
        private System.Collections.IEnumerator Respawn()
        {
            object val_1 = new System.Object();
            typeof(ETFXTarget.<Respawn>d__7).__il2cppRuntimeField_8 = 0;
            typeof(ETFXTarget.<Respawn>d__7).__il2cppRuntimeField_10 = this;
        }
        public ETFXTarget()
        {
        
        }
    
    }

}
