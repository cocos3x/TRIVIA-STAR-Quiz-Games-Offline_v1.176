using UnityEngine;

namespace Spine.Unity.Modules
{
    public class SkeletonUtilityEyeConstraint : SkeletonUtilityConstraint
    {
        // Fields
        public UnityEngine.Transform[] eyes;
        public float radius;
        public UnityEngine.Transform target;
        public UnityEngine.Vector3 targetPosition;
        public float speed;
        private UnityEngine.Vector3[] origins;
        private UnityEngine.Vector3 centerPoint;
        
        // Methods
        protected override void OnEnable()
        {
            float val_4;
            float val_5;
            float val_6;
            UnityEngine.Vector3 val_9;
            UnityEngine.Vector3 val_10;
            UnityEngine.Vector3 val_11;
            Spine.Unity.Modules.SkeletonUtilityEyeConstraint val_14;
            float val_15;
            var val_16;
            val_14 = this;
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            val_14.OnEnable();
            UnityEngine.Transform val_14 = this.eyes[0];
            UnityEngine.Vector3 val_2 = localPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_15 = val_4;
            UnityEngine.Bounds val_7 = new UnityEngine.Bounds(center:  new UnityEngine.Vector3(), size:  new UnityEngine.Vector3() {x = val_5, y = val_15, z = val_6});
            this.origins = null;
            val_16 = 0;
            goto label_8;
            label_17:
            UnityEngine.Transform val_15 = this.eyes[0];
            UnityEngine.Vector3 val_8 = localPosition;
            val_15 = 0;
            val_14 = val_14;
            this.origins[val_15] = val_9;
            this.origins[val_15] = val_10;
            this.origins[val_15] = val_11;
            val_7.m_Center.x.Encapsulate(point:  new UnityEngine.Vector3() {x = mem[(UnityEngine.Vector3[].__il2cppRuntimeField_namespaze + 16) + (0)], y = mem[(UnityEngine.Vector3[].__il2cppRuntimeField_namespaze + 16) + (4)], z = mem[(UnityEngine.Vector3[].__il2cppRuntimeField_namespaze + 16) + (8)]});
            val_16 = 1;
            label_8:
            if(val_16 < 2037096368)
            {
                goto label_17;
            }
            
            UnityEngine.Vector3 val_13 = center;
        }
        protected override void OnDisable()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            R4.OnDisable();
        }
        public override void DoUpdate()
        {
            float val_3;
            float val_4;
            UnityEngine.Vector3 val_5;
            float val_9;
            float val_17;
            float val_18;
            var val_21;
            var val_22;
            UnityEngine.Transform val_23;
            var val_24;
            var val_25;
            if(this.target != 0)
            {
                    UnityEngine.Vector3 val_2 = position;
                val_21 = val_3;
                val_22 = val_4;
                this.targetPosition = val_5;
                mem[1152921510939466228] = val_21;
                mem[1152921510939466232] = val_22;
            }
            
            UnityEngine.Transform val_6 = this.target.transform;
            UnityEngine.Vector3 val_7 = TransformPoint(position:  new UnityEngine.Vector3() {x = 7.921525E+34f, y = mem[this.centerPoint + (0)], z = mem[this.centerPoint + (4)]});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 7.915543E+34f, y = this.targetPosition, z = SB}, b:  new UnityEngine.Vector3() {x = 1.175056E-37f});
            float val_10 = val_9.magnitude;
            val_9.Normalize();
            val_24 = 4;
            val_25 = 0;
            goto label_10;
            label_23:
            UnityEngine.Transform val_11 = this.transform;
            UnityEngine.Vector3 val_24 = this.origins[val_25];
            UnityEngine.Vector3 val_12 = TransformPoint(position:  new UnityEngine.Vector3() {x = 7.921525E+34f, y = this.origins[val_25], z = this.origins[val_25]});
            val_23 = this.eyes[0];
            UnityEngine.Transform val_25 = this.eyes[0];
            UnityEngine.Vector3 val_13 = position;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 7.915537E+34f, y = val_9, z = 0f}, d:  val_13.x);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 7.915531E+34f, y = val_5, z = val_3}, b:  new UnityEngine.Vector3() {x = val_4});
            float val_16 = UnityEngine.Time.deltaTime;
            uint val_26 = 0;
            val_26 = this.speed * val_26;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = 7.915525E+34f}, target:  new UnityEngine.Vector3() {y = val_18, z = val_17}, maxDistanceDelta:  val_26);
            val_23.position = new UnityEngine.Vector3();
            val_24 = 5;
            val_25 = 12;
            label_10:
            if((val_24 - 4) < val_23)
            {
                goto label_23;
            }
        
        }
        public SkeletonUtilityEyeConstraint()
        {
            this.speed = 10f;
            this.radius = 0.5f;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
