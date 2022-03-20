using UnityEngine;

namespace EpicToonFX
{
    public class ETFXFireProjectile : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject[] projectiles;
        public UnityEngine.Transform spawnPosition;
        public int currentProjectile;
        public float speed;
        private EpicToonFX.ETFXButtonScript selectedProjectileButton;
        private UnityEngine.RaycastHit hit;
        
        // Methods
        private void Start()
        {
            UnityEngine.GameObject val_1 = UnityEngine.GameObject.Find(name:  689292032);
            object val_2 = GetComponent<System.Object>();
            this.selectedProjectileButton = "Button";
        }
        private void Update()
        {
            float val_11;
            float val_12;
            float val_15;
            float val_20;
            float val_21;
            float val_22;
            float val_23;
            float val_34;
            float val_35;
            float val_41;
            float val_42;
            float val_48;
            float val_49;
            float val_50;
            float val_51;
            float val_52;
            var val_53;
            bool val_1 = UnityEngine.Input.GetKeyDown(key:  275);
            if(val_1 == true)
            {
                    val_1 = this;
                this.nextEffect();
            }
            
            bool val_2 = UnityEngine.Input.GetKeyDown(key:  100);
            if(val_2 == true)
            {
                    val_2 = this;
                this.nextEffect();
            }
            
            if((UnityEngine.Input.GetKeyDown(key:  97)) != true)
            {
                    if((UnityEngine.Input.GetKeyDown(key:  276)) == false)
            {
                goto label_2;
            }
            
            }
            
            this.previousEffect();
            label_2:
            if((UnityEngine.Input.GetKeyDown(key:  323)) != false)
            {
                    UnityEngine.EventSystems.EventSystem val_6 = UnityEngine.EventSystems.EventSystem.current;
                if(0.IsPointerOverGameObject() != true)
            {
                    val_52 = 0f;
                UnityEngine.Camera val_8 = UnityEngine.Camera.main;
                UnityEngine.Vector3 val_9 = UnityEngine.Input.mousePosition;
                UnityEngine.Ray val_13 = ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = val_11, z = val_12});
                if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3(), m_Direction = new UnityEngine.Vector3() {y = ???, z = val_15}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_13.m_Direction.z + 32, y = 100f, z = val_52}, m_Normal = new UnityEngine.Vector3(), m_UV = new UnityEngine.Vector2()}, maxDistance:  val_9.x)) != false)
            {
                    var val_17 = (val_13.m_Direction.z + 12) + ((val_13.m_Direction.z + 20) << 2);
                UnityEngine.Vector3 val_18 = position;
                UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.identity;
                UnityEngine.GameObject val_24 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  (val_13.m_Direction.z + 12 + (val_13.m_Direction.z + 20) << 2) + 16, position:  new UnityEngine.Vector3(), rotation:  new UnityEngine.Quaternion() {x = val_20, y = val_21, z = val_22, w = val_23});
                val_52 = 0;
                UnityEngine.Transform val_25 = (val_13.m_Direction.z + 12 + (val_13.m_Direction.z + 20) << 2) + 16.transform;
                UnityEngine.Vector3 val_26 = point;
                (val_13.m_Direction.z + 12 + (val_13.m_Direction.z + 20) << 2) + 16.LookAt(worldPosition:  new UnityEngine.Vector3());
                if(((val_13.m_Direction.z + 12 + (val_13.m_Direction.z + 20) << 2) + 16) != 0)
            {
                    object val_27 = (val_13.m_Direction.z + 12 + (val_13.m_Direction.z + 20) << 2) + 16.GetComponent<System.Object>();
                val_53 = (val_13.m_Direction.z + 12 + (val_13.m_Direction.z + 20) << 2) + 16;
            }
            else
            {
                    object val_28 = (val_13.m_Direction.z + 12 + (val_13.m_Direction.z + 20) << 2) + 16.GetComponent<System.Object>();
                val_53 = (val_13.m_Direction.z + 12 + (val_13.m_Direction.z + 20) << 2) + 16;
            }
            
                UnityEngine.Transform val_29 = (val_13.m_Direction.z + 12 + (val_13.m_Direction.z + 20) << 2) + 16.transform;
                UnityEngine.Vector3 val_30 = forward;
                UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 3.367727E-14f}, d:  val_30.x);
                val_53.AddForce(force:  new UnityEngine.Vector3());
            }
            
            }
            
            }
            
            UnityEngine.Camera val_32 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_33 = UnityEngine.Input.mousePosition;
            UnityEngine.Ray val_37 = ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = val_34, z = val_35});
            UnityEngine.Vector3 val_38 = origin;
            UnityEngine.Camera val_39 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_40 = UnityEngine.Input.mousePosition;
            UnityEngine.Ray val_44 = ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = val_41, z = val_42});
            UnityEngine.Vector3 val_45 = direction;
            UnityEngine.Vector3 val_46 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 3.367705E-14f}, d:  val_45.x);
            UnityEngine.Color val_47 = UnityEngine.Color.yellow;
            UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3(), dir:  new UnityEngine.Vector3(), color:  new UnityEngine.Color() {r = val_48, g = val_49, b = val_50, a = val_51});
        }
        public void nextEffect()
        {
            if(this.currentProjectile < 1152921513886363663)
            {
                    0 = this.currentProjectile;
                0 = 0 + 1;
            }
            
            this.currentProjectile = 0;
            this.selectedProjectileButton.getProjectileNames();
        }
        public void previousEffect()
        {
            this.currentProjectile = this.currentProjectile - 1;
            this.currentProjectile = this.currentProjectile;
            this.selectedProjectileButton.getProjectileNames();
        }
        public void AdjustSpeed(float newSpeed)
        {
            this.speed = ;
        }
        public ETFXFireProjectile()
        {
            this.speed = 500f;
        }
    
    }

}
