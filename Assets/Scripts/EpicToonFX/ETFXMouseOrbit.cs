using UnityEngine;

namespace EpicToonFX
{
    public class ETFXMouseOrbit : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform target;
        public float distance;
        public float xSpeed;
        public float ySpeed;
        public float yMinLimit;
        public float yMaxLimit;
        public float distanceMin;
        public float distanceMax;
        public float smoothTime;
        private float rotationYAxis;
        private float rotationXAxis;
        private float velocityX;
        private float velocityY;
        
        // Methods
        private void Start()
        {
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = eulerAngles;
            this.rotationYAxis = ;
            this.rotationXAxis = ;
            object val_3 = this.GetComponent<System.Object>();
            if((UnityEngine.Object.op_Implicit(exists:  691341680)) == false)
            {
                    return;
            }
            
            object val_5 = this.GetComponent<System.Object>();
            this.freezeRotation = true;
        }
        private void LateUpdate()
        {
            float val_7;
            uint val_8;
            float val_9;
            float val_10;
            float val_22;
            float val_23;
            float val_26;
            float val_27;
            float val_28;
            float val_36;
            float val_37;
            float val_38;
            float val_39;
            if((UnityEngine.Object.op_Implicit(exists:  this.target)) == false)
            {
                    return;
            }
            
            if((UnityEngine.Input.GetMouseButton(button:  1)) != false)
            {
                    float val_3 = UnityEngine.Input.GetAxis(axisName:  691433776);
                uint val_36 = 691433776;
                val_36 = this.xSpeed * val_36;
                val_36 = val_36 * this.distance;
                this.velocityX = this.velocityX;
                float val_4 = UnityEngine.Input.GetAxis(axisName:  691433872);
                uint val_37 = 691433872;
                val_37 = this.ySpeed * val_37;
                this.velocityY = this.velocityY;
            }
            else
            {
                    val_37 = this.velocityY;
            }
            
            float val_38 = this.rotationXAxis;
            float val_39 = this.rotationYAxis;
            val_38 = val_38 - val_37;
            val_39 = val_39 + this.velocityX;
            this.rotationYAxis = val_39;
            this.rotationXAxis = val_38;
            this.rotationXAxis = val_38;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  EpicToonFX.ETFXMouseOrbit.ClampAngle(angle:  val_39, min:  null, max:  val_38), y:  null, z:  val_38);
            float val_11 = UnityEngine.Input.GetAxis(axisName:  691433968);
            float val_12 = UnityEngine.Mathf.Clamp(value:  -5f, min:  val_6.y, max:  val_6.z);
            this.distance = this.distance;
            UnityEngine.Vector3 val_13 = position;
            UnityEngine.Transform val_14 = this.target.transform;
            UnityEngine.Vector3 val_15 = position;
            val_39 = this.distance;
            if((UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3(), end:  new UnityEngine.Vector3(), hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 4.057944E-14f, y = 0f}, m_Normal = new UnityEngine.Vector3() {z = val_9}, m_FaceID = val_8, m_Distance = val_7, m_UV = new UnityEngine.Vector2()})) != false)
            {
                    float val_17 = distance;
                val_38 = 691454184;
                val_39 = val_39 - val_38;
                this.distance = val_39;
            }
            
            float val_18 = val_39 ^ 2147483648;
            UnityEngine.Vector3 val_19 = new UnityEngine.Vector3(x:  val_38, y:  val_15.y, z:  val_15.z);
            UnityEngine.Vector3 val_20 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 4.057933E-14f, y = val_10, z = val_7, w = val_8}, point:  new UnityEngine.Vector3() {x = val_9, y = val_19.x, z = val_19.y});
            UnityEngine.Vector3 val_21 = position;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 4.057925E-14f}, b:  new UnityEngine.Vector3() {y = val_23, z = val_22});
            val_36 = val_27;
            UnityEngine.Transform val_29 = this.transform;
            this.rotation = new UnityEngine.Quaternion() {x = val_10, y = val_7, z = val_8, w = val_9};
            UnityEngine.Transform val_30 = this.transform;
            this.position = new UnityEngine.Vector3() {x = val_36, y = val_26, z = val_28};
            float val_31 = UnityEngine.Time.deltaTime;
            float val_33 = UnityEngine.Mathf.Lerp(a:  0 * this.smoothTime, b:  val_25.y, t:  val_25.z);
            this.velocityX = this.velocityX;
            float val_34 = UnityEngine.Time.deltaTime;
            float val_40 = this.smoothTime;
            val_40 = 0 * val_40;
            float val_35 = UnityEngine.Mathf.Lerp(a:  val_40, b:  val_25.y, t:  0);
            this.velocityY = this.velocityY;
        }
        public static float ClampAngle(float angle, float min, float max)
        {
            float val_2 = -360f;
            if(static_value_021FAFEC < 0)
            {
                    0 = 0 + 360f;
            }
            
            val_2 = 0 + val_2;
            if(static_value_021FAFEC > false)
            {
                    0 = val_2;
            }
            
            return UnityEngine.Mathf.Clamp(value:  360f, min:  min, max:  val_2);
        }
        public ETFXMouseOrbit()
        {
        
        }
    
    }

}
