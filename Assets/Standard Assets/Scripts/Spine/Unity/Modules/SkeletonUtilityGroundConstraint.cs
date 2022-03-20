using UnityEngine;

namespace Spine.Unity.Modules
{
    public class SkeletonUtilityGroundConstraint : SkeletonUtilityConstraint
    {
        // Fields
        public UnityEngine.LayerMask groundMask;
        public bool use2D;
        public bool useRadius;
        public float castRadius;
        public float castDistance;
        public float castOffset;
        public float groundOffset;
        public float adjustSpeed;
        private UnityEngine.Vector3 rayOrigin;
        private UnityEngine.Vector3 rayDir;
        private float hitY;
        private float lastHitY;
        
        // Methods
        protected override void OnEnable()
        {
            float val_3;
            this.OnEnable();
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = position;
            this.lastHitY = val_3;
        }
        public override void DoUpdate()
        {
            UnityEngine.Vector3 val_5;
            float val_6;
            float val_7;
            float val_29;
            float val_39;
            float val_40;
            var val_50;
            var val_51;
            var val_56;
            float val_57;
            var val_58;
            val_50 = this;
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = position;
            UnityEngine.Vector3 val_3 = new UnityEngine.Vector3(x:  val_2.x, y:  val_2.y, z:  val_2.z);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 8.163014E+34f}, b:  new UnityEngine.Vector3() {y = val_3.x, z = val_3.y});
            this.rayOrigin = val_5;
            mem[1152921510939966084] = val_6;
            mem[1152921510939966088] = val_7;
            this.hitY = 1.175494E-38f;
            if(this.use2D == false)
            {
                goto label_4;
            }
            
            if(this.useRadius == false)
            {
                goto label_5;
            }
            
            val_51 = 0;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 8.16302E+34f, y = val_5, z = val_6});
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 8.163014E+34f, y = mem[this.rayDir + (0)], z = mem[this.rayDir + (4)]});
            int val_11 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.groundMask});
            UnityEngine.RaycastHit2D val_13 = UnityEngine.Physics2D.CircleCast(origin:  new UnityEngine.Vector2() {x = 8.162996E+34f, y = val_3.x}, radius:  this.castDistance + this.groundOffset, direction:  new UnityEngine.Vector2() {x = val_3.y, y = this.castRadius}, distance:  val_10.y, layerMask:  val_5);
            goto label_10;
            label_4:
            if(this.useRadius == false)
            {
                goto label_11;
            }
            
            float val_15 = this.castDistance + this.groundOffset;
            bool val_16 = UnityEngine.Physics.SphereCast(origin:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_7}, radius:  val_15, direction:  new UnityEngine.Vector3() {x = this.castRadius, y = this.rayDir, z = 8.162996E+34f}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 8.163028E+34f, y = 8.163028E+34f, z = val_15}, m_Normal = new UnityEngine.Vector3() {x = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.groundMask}), y = 0f, z = this.castRadius}, m_UV = new UnityEngine.Vector2()}, maxDistance:  val_4.y, layerMask:  0);
            goto label_12;
            label_5:
            val_51 = 0;
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 8.16302E+34f, y = val_5, z = val_6});
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 8.163014E+34f, y = mem[this.rayDir + (0)], z = mem[this.rayDir + (4)]});
            int val_19 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.groundMask});
            UnityEngine.RaycastHit2D val_21 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = 8.162996E+34f, y = val_3.x}, direction:  new UnityEngine.Vector2() {x = val_3.y, y = val_5}, distance:  this.castDistance + this.groundOffset, layerMask:  val_6);
            label_10:
            UnityEngine.Collider2D val_22 = mem[val_21.m_Collider + (0)].collider;
            if(2038139648 == 0)
            {
                goto label_21;
            }
            
            UnityEngine.Vector2 val_24 = point;
            goto label_20;
            label_11:
            float val_26 = this.castDistance + this.groundOffset;
            label_12:
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_7}, direction:  new UnityEngine.Vector3() {x = this.rayDir, y = mem[val_21.m_Collider + (0)], z = 8.162996E+34f}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 8.163028E+34f, y = val_26, z = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.groundMask})}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = this.rayDir}, m_UV = new UnityEngine.Vector2()}, maxDistance:  val_26, layerMask:  0)) == false)
            {
                goto label_21;
            }
            
            UnityEngine.Vector3 val_28 = point;
            label_20:
            float val_48 = this.groundOffset;
            val_56 = val_29;
            val_48 = val_56 + val_48;
            this.hitY = val_48;
            if(UnityEngine.Application.isPlaying == false)
            {
                goto label_26;
            }
            
            float val_31 = UnityEngine.Time.deltaTime;
            val_57 = this.adjustSpeed * 0;
            val_58 = this.lastHitY;
            goto label_25;
            label_21:
            if(UnityEngine.Application.isPlaying == false)
            {
                goto label_26;
            }
            
            UnityEngine.Transform val_33 = val_21.m_Normal.x.transform;
            UnityEngine.Vector3 val_34 = position;
            float val_35 = UnityEngine.Time.deltaTime;
            val_58 = val_21.m_Normal.x + 76;
            val_57 = (val_21.m_Normal.x + 44) * 0;
            label_25:
            float val_36 = UnityEngine.Mathf.MoveTowards(current:  val_57, target:  val_34.y, maxDelta:  val_34.z);
            mem2[0] = val_58;
            label_26:
            UnityEngine.Transform val_37 = val_21.m_Normal.x.transform;
            UnityEngine.Vector3 val_38 = position;
            float val_42 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.Min(a:  val_38.x, b:  val_38.y), min:  val_38.y, max:  val_38.z);
            UnityEngine.Transform val_43 = val_21.m_Normal.x.transform;
            val_21.m_Normal.x.position = new UnityEngine.Vector3() {x = val_40, y = val_29, z = val_39};
            UnityEngine.Transform val_44 = val_21.m_Normal.x.transform;
            UnityEngine.Vector3 val_45 = val_3.x.localPosition;
            mem2[0] = val_3.x;
            UnityEngine.Transform val_46 = val_21.m_Normal.x.transform;
            UnityEngine.Vector3 val_47 = localPosition;
            mem2[0] = val_6;
            mem2[0] = val_21.m_Normal.x + 72;
        }
        private void OnDrawGizmos()
        {
            float val_5;
            float val_6;
            float val_7;
            float val_10;
            float val_11;
            float val_17;
            float val_18;
            float val_19;
            float val_20;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 8.2185E+34f, y = mem[this.rayDir + (0)], z = mem[this.rayDir + (4)]}, d:  UnityEngine.Mathf.Min(a:  R6 - this.hitY, b:  null));
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 8.218512E+34f, y = this.rayOrigin, z = R6}, b:  new UnityEngine.Vector3() {x = R8});
            val_17 = 0;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 8.218516E+34f, y = mem[this.rayDir + (0)], z = mem[this.rayDir + (4)]}, d:  this.castDistance);
            val_18 = val_7;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 8.218508E+34f, y = this.rayOrigin, z = mem[this.rayDir + (4)]}, b:  new UnityEngine.Vector3() {x = 0f});
            val_20 = val_5;
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = mem[this.rayOrigin + (0)], y = mem[this.rayOrigin + (4)], z = mem[this.rayOrigin + (8)]}, to:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_18});
            if(this.useRadius != false)
            {
                    float val_17 = this.castRadius;
                float val_18 = this.groundOffset;
                val_17 = val_5 - val_17;
                val_18 = val_6 - val_18;
                UnityEngine.Vector3 val_12 = new UnityEngine.Vector3(x:  val_17, y:  val_9.y, z:  val_18);
                float val_19 = this.castRadius;
                float val_20 = this.groundOffset;
                val_19 = val_19 + val_5;
                val_6 = 0;
                val_20 = val_6 - val_20;
                val_5 = 0;
                val_7 = 0;
                UnityEngine.Vector3 val_13 = new UnityEngine.Vector3(x:  val_19, y:  val_9.y, z:  val_20);
                val_17 = val_20;
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, to:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
                float val_21 = this.castRadius;
                val_21 = val_10 - val_21;
                val_7 = 0;
                UnityEngine.Vector3 val_14 = new UnityEngine.Vector3(x:  val_21, y:  val_9.y, z:  val_20);
                float val_22 = this.castRadius;
                val_22 = val_22 + val_10;
                val_11 = 0;
                val_10 = 0;
                val_5 = 0;
                UnityEngine.Vector3 val_15 = new UnityEngine.Vector3(x:  val_22, y:  val_9.y, z:  val_20);
                val_20 = val_17;
                val_18 = val_18;
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_19}, to:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            }
            
            UnityEngine.Color val_16 = UnityEngine.Color.red;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_12.x, g = val_12.y, b = val_12.z};
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_18}, to:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_20});
        }
        public SkeletonUtilityGroundConstraint()
        {
            this.castRadius = 0.1f;
            this.castDistance = 5f;
            this.adjustSpeed = 5f;
            UnityEngine.Vector3 val_1 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            this = new UnityEngine.MonoBehaviour();
        }
    
    }

}
