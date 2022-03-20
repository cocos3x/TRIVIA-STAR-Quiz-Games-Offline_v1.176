using UnityEngine;

namespace twelvegigs.Autopilot
{
    public class AutopilotButton : MonoBehaviour
    {
        // Fields
        public const string TEST_TEXT = "Hello, brave new world!!";
        private int <CameraId>k__BackingField;
        private float <CameraDepth>k__BackingField;
        public UnityEngine.Vector3 centerPos;
        private UnityEngine.UI.Selectable selectable;
        private string route;
        private string cameraName;
        private bool exclude;
        private int count;
        private int hiddenCount;
        private UnityEngine.UI.Button button;
        private UnityEngine.UI.Toggle toggle;
        private UnityEngine.UI.InputField inputField;
        private UnityEngine.UI.ScrollRect scroll;
        
        // Properties
        public int CameraId { get; set; }
        public float CameraDepth { get; set; }
        public string Route { get; }
        public UnityEngine.GameObject Target { get; }
        public bool SkipExecuteClick { get; }
        
        // Methods
        public int get_CameraId()
        {
            return (int)this.<CameraId>k__BackingField;
        }
        public void set_CameraId(int value)
        {
            this.<CameraId>k__BackingField = value;
        }
        public float get_CameraDepth()
        {
            return (float)S0;
        }
        public void set_CameraDepth(float value)
        {
            this.<CameraDepth>k__BackingField = ;
        }
        public string get_Route()
        {
        
        }
        public UnityEngine.GameObject get_Target()
        {
            UnityEngine.UI.Graphic val_3;
            if(this.selectable == 0)
            {
                    return;
            }
            
            if(this.selectable.m_Transition != 2)
            {
                    if(this.selectable.m_Transition != 1)
            {
                goto label_14;
            }
            
            }
            
            if((this.selectable.m_TargetGraphic != 0) && (this.selectable.m_TargetGraphic != 0))
            {
                    val_3 = this.selectable.m_TargetGraphic;
            }
            else
            {
                    label_14:
                val_3 = this.selectable;
            }
            
            if(val_3 != 0)
            {
                    return val_3.gameObject;
            }
            
            return val_3.gameObject;
        }
        public bool get_SkipExecuteClick()
        {
            return UnityEngine.Object.op_Inequality(x:  this.inputField, y:  0);
        }
        private void Start()
        {
            var val_19;
            object val_1 = this.GetComponent<System.Object>();
            this.selectable = this;
            if(1109137504 == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_3 = this.transform;
            string val_4 = twelvegigs.Autopilot.AutopilotTools.GetRoute(transform:  1109137504);
            this.route = this;
            if((this.Contains(value:  466780208)) != false)
            {
                    this.exclude = true;
                return;
            }
            
            if(this.selectable == 0)
            {
                goto label_11;
            }
            
            val_19 = (UnityEngine.UI.Selectable.__il2cppRuntimeField_typeHierarchy + (UnityEngine.UI.Button.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4;
            if(val_19 == null)
            {
                goto label_8;
            }
            
            val_19 = (UnityEngine.UI.Selectable.__il2cppRuntimeField_typeHierarchy + (UnityEngine.UI.Toggle.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4;
            if(val_19 == null)
            {
                goto label_10;
            }
            
            label_11:
            this.exclude = true;
            label_20:
            UnityEngine.Transform val_6 = this.transform;
            UnityEngine.Camera val_7 = twelvegigs.Autopilot.AutopilotTools.GetCamera(go:  1109137504);
            this.<CameraDepth>k__BackingField = -1f;
            if(1109137504 != 0)
            {
                    if(this != 0)
            {
                    this.<CameraId>k__BackingField = this.GetInstanceID();
                string val_10 = this.name;
                this.cameraName = this;
            }
            else
            {
                    this.<CameraId>k__BackingField = this.GetInstanceID();
                string val_12 = this.name;
                this.cameraName = this;
            }
            
                float val_13 = this.depth;
                this.<CameraDepth>k__BackingField = this;
            }
            
            this.count = this.GetCount(hidden:  false);
            this.hiddenCount = this.GetCount(hidden:  true);
            return;
            label_8:
            object val_16 = this.selectable.GetComponent<System.Object>();
            this.button = this.selectable;
            goto label_20;
            label_10:
            object val_17 = this.selectable.GetComponent<System.Object>();
            this.toggle = this.selectable;
            goto label_20;
        }
        public int GetCount(bool hidden = False)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static twelvegigs.Autopilot.AutopilotManager MonoSingleton<twelvegigs.Autopilot.AutopilotManager>::get_Instance()) != 0)
            {
                    return ButtonPressedCount(path:  this.route, hiddenCount:  hidden);
            }
            
            return ButtonPressedCount(path:  this.route, hiddenCount:  hidden);
        }
        public int GetTotalCount()
        {
            int val_2 = this.GetCount(hidden:  true);
            val_2 = val_2 + (this.GetCount(hidden:  false));
            return (int)val_2;
        }
        public System.Collections.Generic.List<UnityEngine.GameObject> GetTargets()
        {
            UnityEngine.UI.Selectable val_11;
            UnityEngine.UI.Navigation val_12;
            UnityEngine.UI.Navigation val_13;
            Mode val_14;
            var val_15;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_11 = this.selectable;
            if(val_11 == 0)
            {
                    return;
            }
            
            T[] val_3 = this.selectable.GetComponents<System.Object>();
            val_11 = this.selectable;
            val_12 = this.selectable.m_Navigation;
            val_13 = 0;
            goto label_5;
            label_13:
            val_14 = mem[this.selectable.m_Navigation + 0];
            val_14 = this.selectable.m_Navigation.m_Mode;
            if(val_14 != 0)
            {
                    UnityEngine.GameObject val_4 = val_14.gameObject;
                if((Contains(item:  val_14)) != true)
            {
                    UnityEngine.GameObject val_6 = val_14.gameObject;
                Add(item:  val_14);
            }
            
            }
            
            val_13 = 1;
            label_5:
            if(val_13 < this.selectable.m_EnableCalled)
            {
                goto label_13;
            }
            
            T[] val_7 = val_11.GetComponentsInChildren<System.Object>();
            val_12 = val_11;
            val_13 = this.selectable.m_Navigation;
            val_15 = 0;
            goto label_17;
            label_25:
            val_11 = mem[this.selectable.m_Navigation + 0];
            val_11 = this.selectable.m_Navigation.m_Mode;
            if(val_11 != 0)
            {
                    UnityEngine.GameObject val_8 = val_11.gameObject;
                val_14 = val_11;
                if((Contains(item:  val_14)) != true)
            {
                    UnityEngine.GameObject val_10 = val_11.gameObject;
                val_11 = val_11;
                Add(item:  val_11);
            }
            
            }
            
            val_15 = 1;
            label_17:
            if(val_15 < this.selectable.m_EnableCalled)
            {
                goto label_25;
            }
        
        }
        public bool CanBePressed()
        {
            if(this.selectable == 0)
            {
                    return false;
            }
            
            UnityEngine.GameObject val_2 = this.gameObject;
            bool val_3 = UnityEngine.Object.op_Equality(x:  1109629536, y:  0);
            if(val_3 == false)
            {
                    val_3 = this.exclude;
                goto label_6;
            }
            
            return false;
            label_6:
            if(this.selectable.m_Interactable == false)
            {
                    return false;
            }
            
            if(this.selectable.enabled == false)
            {
                    return false;
            }
            
            UnityEngine.GameObject val_5 = this.gameObject;
            if(this != 0)
            {
                    return this.activeInHierarchy;
            }
            
            return this.activeInHierarchy;
        }
        public UnityEngine.Vector3 GetWorldCenterPos()
        {
            UnityEngine.GameObject val_1 = R1.Target;
            UnityEngine.Vector3 val_2 = this.GetWorldCenterPos(target:  R1);
            return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public UnityEngine.Vector3 GetWorldCenterPos(UnityEngine.GameObject target)
        {
            UnityEngine.Object val_7 = R2;
            if(val_7 == 0)
            {
                goto label_3;
            }
            
            object val_2 = val_7.GetComponent<System.Object>();
            val_7 = val_7;
            if(val_7 != 0)
            {
                goto label_7;
            }
            
            label_3:
            UnityEngine.Transform val_4 = target.transform;
            UnityEngine.Vector3 val_5 = this.position;
            return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            label_7:
            val_7.GetWorldCorners(fourCornersArray:  533912224);
            UnityEngine.Vector3 val_6 = CenterOfVectors(vectors:  533912224);
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            mem[1152921514306651496] = ???;
            this = null;
            return new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        public virtual void OnValueChanged(bool value)
        {
            if(value == false)
            {
                    return;
            }
            
            goto typeof(twelvegigs.Autopilot.AutopilotButton).__il2cppRuntimeField_E4;
        }
        public virtual void OnButtonClick(bool hiddenClick = False)
        {
            if(this.inputField != 0)
            {
                    this.inputField.text = 1110082208;
            }
            
            if(hiddenClick != false)
            {
                    int val_2 = this.GetCount(hidden:  true);
                val_2 = val_2 + 1;
                this.hiddenCount = val_2;
            }
            else
            {
                    int val_3 = this.GetCount(hidden:  false);
                val_3 = val_3 + 1;
                this.count = val_3;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = this.route;
            UnityEngine.GameObject val_4 = this.gameObject;
            int val_5 = this.GetInstanceID();
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            UnityEngine.GameObject val_6 = this.gameObject;
            string val_7 = this.name;
            typeof(System.Object[]).__il2cppRuntimeField_18 = this;
            typeof(System.Object[]).__il2cppRuntimeField_1C = this.cameraName;
            typeof(System.Object[]).__il2cppRuntimeField_20 = null;
            typeof(System.Object[]).__il2cppRuntimeField_24 = null;
            typeof(System.Object[]).__il2cppRuntimeField_28 = null;
            twelvegigs.Autopilot.AutopilotTools.LogFormat(format:  1110090528, args:  472754880);
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UpdateCounter(path:  this.route, count:  this.count, hiddenCount:  this.hiddenCount);
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            TrackButtonPressed(button:  1110118896);
        }
        public override string ToString()
        {
            string val_3 = this.route.Substring(startIndex:  UnityEngine.Mathf.Max(a:  0, b:  this.route.m_stringLength - 50));
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            string val_4 = this.name;
            typeof(System.Object[]).__il2cppRuntimeField_18 = this;
            typeof(System.Object[]).__il2cppRuntimeField_1C = this.route;
            string val_5 = System.String.Format(format:  1110231472, args:  472754880);
        }
        private UnityEngine.Vector3 CenterOfVectors(UnityEngine.Vector3[] vectors)
        {
            float val_2;
            float val_3;
            float val_4;
            var val_8;
            float val_12;
            float val_13;
            float val_14;
            var val_15;
            float val_16;
            var val_17;
            var val_18;
            twelvegigs.Autopilot.AutopilotButton val_19;
            val_8 = R2;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_12 = val_2;
            if(val_8 != 0)
            {
                    0 = mem[R2 + 12];
                0 = R2 + 12;
            }
            
            val_13 = val_3;
            val_14 = val_4;
            if(0 == 0)
            {
                    mem[1152921514307190152] = val_14;
                return new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            }
            
            if(0 >= 1)
            {
                    float val_5 = val_8 + 16;
                var val_8 = 0;
                do
            {
                if(0 <= val_8)
            {
                    val_16 = val_14;
            }
            
                val_16 = val_16;
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 43.8266f, y = val_12, z = val_13}, b:  new UnityEngine.Vector3() {x = val_16, y = val_5, z = mem[(R2 + 16) + (4)]});
                val_8 = val_8;
                val_17 = val_5 + 12;
                val_12 = val_2;
                val_8 = val_8 + 1;
                val_13 = val_3;
                val_15 = mem[R2 + 12];
                val_15 = R2 + 12;
                val_18 = val_4;
            }
            while(val_8 < val_15);
            
            }
            
            val_19 = this;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = 43.87256f, y = val_12, z = val_13}, d:  (float));
            return new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        public AutopilotButton()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.route = System.String.alignConst;
            this.cameraName = System.String.alignConst;
        }
    
    }

}
