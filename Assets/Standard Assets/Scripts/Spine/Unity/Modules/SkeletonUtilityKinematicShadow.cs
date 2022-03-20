using UnityEngine;

namespace Spine.Unity.Modules
{
    public class SkeletonUtilityKinematicShadow : MonoBehaviour
    {
        // Fields
        public bool detachedShadow;
        public UnityEngine.Transform parent;
        public bool hideShadow;
        private UnityEngine.GameObject shadowRoot;
        private readonly System.Collections.Generic.List<Spine.Unity.Modules.SkeletonUtilityKinematicShadow.TransformPair> shadowTable;
        
        // Methods
        private void Start()
        {
            float val_9;
            UnityEngine.Object val_12;
            float val_13;
            float val_14;
            float val_16;
            float val_17;
            float val_18;
            UnityEngine.Transform val_43;
            UnityEngine.Transform val_44;
            var val_45;
            Spine.Unity.Modules.SkeletonUtilityKinematicShadow val_46;
            var val_47;
            UnityEngine.GameObject val_1 = this.gameObject;
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  2038515408);
            this.shadowRoot = this;
            object val_3 = this.GetComponent<System.Object>();
            UnityEngine.Object.Destroy(obj:  2038515408);
            UnityEngine.Transform val_4 = this.shadowRoot.transform;
            UnityEngine.Transform val_5 = this.transform;
            UnityEngine.Vector3 val_6 = position;
            this.shadowRoot.position = new UnityEngine.Vector3();
            UnityEngine.Transform val_7 = this.transform;
            UnityEngine.Quaternion val_8 = rotation;
            this.shadowRoot.rotation = new UnityEngine.Quaternion() {w = val_9};
            UnityEngine.Transform val_10 = this.transform;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_15 = TransformPoint(position:  new UnityEngine.Vector3() {x = 8.390532E+34f, y = val_13, z = val_14});
            UnityEngine.Transform val_19 = this.transform;
            UnityEngine.Vector3 val_20 = position;
            float val_21 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3(), b:  new UnityEngine.Vector3() {x = val_16, y = val_17, z = val_18});
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.one;
            this.shadowRoot.localScale = new UnityEngine.Vector3();
            if(this.detachedShadow != true)
            {
                    if(this.parent == 0)
            {
                    UnityEngine.Transform val_24 = this.parent.transform;
                UnityEngine.Transform val_25 = this.root;
                val_43 = this;
            }
            else
            {
                    val_43 = this.parent;
            }
            
                this.shadowRoot.parent = val_43;
            }
            
            if(this.hideShadow != false)
            {
                    this.shadowRoot.hideFlags = 1;
            }
            
            T[] val_26 = this.shadowRoot.GetComponentsInChildren<System.Object>();
            val_44 = 0;
            val_45 = 0;
            goto label_24;
            label_31:
            UnityEngine.Vector3 val_28 = connectedAnchor;
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 8.378588E+34f}, d:  val_28.x);
            1152921504764567552.connectedAnchor = new UnityEngine.Vector3();
            val_45 = 1;
            label_24:
            if(val_45 < 1152921504764567552)
            {
                goto label_31;
            }
            
            T[] val_30 = this.GetComponentsInChildren<System.Object>();
            val_46 = this;
            T[] val_31 = this.shadowRoot + 16.GetComponentsInChildren<System.Object>();
            val_47 = 0;
            goto label_33;
            label_52:
            val_44 = this.parent;
            UnityEngine.GameObject val_32 = val_44.gameObject;
            UnityEngine.GameObject val_33 = val_44.gameObject;
            if(val_44 == 2038515408)
            {
                goto label_41;
            }
            
            val_45 = 0;
            goto label_39;
            label_49:
            val_45 = 1;
            label_39:
            if(val_45 >= this.detachedShadow)
            {
                goto label_41;
            }
            
            object val_35 = val_12.GetComponent<System.Object>();
            if((val_12 == 0) || ((System.String.op_Equality(a:  val_12 + 12, b:  null)) == false))
            {
                goto label_49;
            }
            
            UnityEngine.Transform val_38 = val_44.transform;
            val_44 = val_44;
            UnityEngine.Transform val_39 = val_12.transform;
            mem[1152921510940329708].Add(item:  new TransformPair() {dest = val_44, src = val_12});
            label_41:
            val_46 = val_46;
            val_47 = val_47 + 1;
            label_33:
            if(val_47 < this.detachedShadow)
            {
                goto label_52;
            }
            
            Spine.Unity.Modules.SkeletonUtilityKinematicShadow.DestroyComponents(components:  2038515408);
            T[] val_40 = val_44.GetComponentsInChildren<System.Object>();
            Spine.Unity.Modules.SkeletonUtilityKinematicShadow.DestroyComponents(components:  2038515408);
            T[] val_41 = val_44.GetComponentsInChildren<System.Object>();
            Spine.Unity.Modules.SkeletonUtilityKinematicShadow.DestroyComponents(components:  2038515408);
            T[] val_42 = val_44.GetComponentsInChildren<System.Object>();
            Spine.Unity.Modules.SkeletonUtilityKinematicShadow.DestroyComponents(components:  2038515408);
        }
        private static void DestroyComponents(UnityEngine.Component[] components)
        {
            var val_2;
            if(true < 1)
            {
                    return;
            }
            
            val_2 = 0;
            goto label_3;
            label_7:
            val_2 = 1;
            label_3:
            UnityEngine.Object.Destroy(obj:  R5);
            if((true - 1) != val_2)
            {
                goto label_7;
            }
        
        }
        private void FixedUpdate()
        {
            float val_6;
            object val_1 = this.shadowRoot.GetComponent<System.Object>();
            UnityEngine.Transform val_2 = this.transform;
            UnityEngine.Vector3 val_3 = position;
            this.shadowRoot.MovePosition(position:  new UnityEngine.Vector3());
            UnityEngine.Transform val_4 = this.transform;
            UnityEngine.Quaternion val_5 = rotation;
            this.shadowRoot.MoveRotation(rot:  new UnityEngine.Quaternion() {w = val_6});
            if(this < 1)
            {
                    return;
            }
            
            var val_10 = 16;
            var val_9 = 0;
            do
            {
                if(this.shadowRoot <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Vector3 val_7 = localPosition;
                2621443.localPosition = new UnityEngine.Vector3();
                UnityEngine.Quaternion val_8 = localRotation;
                2621443.localRotation = new UnityEngine.Quaternion() {w = val_6};
                val_9 = val_9 + 1;
                val_10 = val_10 + 8;
            }
            while(this != val_9);
        
        }
        public SkeletonUtilityKinematicShadow()
        {
            this.hideShadow = true;
            System.Collections.Generic.List<TransformPair> val_1 = new System.Collections.Generic.List<TransformPair>();
            this.shadowTable = null;
        }
    
    }

}
