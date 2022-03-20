using UnityEngine;

namespace SLC.Minigames.WordDrop
{
    public class IceCreamController : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.GameObject> myTails;
        private UnityEngine.GameObject tailPrefab;
        private float startingXPos;
        private float startingXPixelPos;
        private bool alreadyTouching;
        private float minXValue;
        private float maxXValue;
        private WordScoopBehavior curCollidingWith;
        private UnityEngine.Transform tailparent;
        private UnityEngine.GameObject coneObject;
        private bool usePhysTails;
        private float worldWidth;
        private float worldMin;
        private float worldMax;
        
        // Methods
        private void Awake()
        {
            this.InitCone();
        }
        private void Start()
        {
            float val_4;
            float val_5;
            float val_7;
            float val_11;
            float val_12;
            float val_14;
            float val_18;
            float val_19;
            float val_21;
            float val_26;
            var val_30;
            UnityEngine.Camera val_1 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_6 = ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_4, z = val_5});
            this.minXValue = val_7;
            UnityEngine.Camera val_8 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_13 = ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_11, z = val_12});
            this.maxXValue = val_14;
            UnityEngine.Camera val_15 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_20 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_18, z = val_19});
            this.worldMin = val_21;
            UnityEngine.Camera val_22 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_24 = new UnityEngine.Vector3(x:  (float)UnityEngine.Screen.width, y:  val_20.y, z:  val_20.z);
            UnityEngine.Vector3 val_25 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_24.x, z = val_24.y});
            float val_30 = this.worldMin;
            val_30 = val_26 - val_30;
            this.worldMax = val_26;
            this.worldWidth = val_30;
            twelvegigs.Autopilot.AutopilotManager val_27 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Single> val_28 = new System.Action<System.Single>(object:  961457024, method:  new IntPtr(961430976));
            System.Delegate val_29 = System.Delegate.Combine(a:  public static WordDropUIController MonoSingleton<WordDropUIController>::get_Instance().__il2cppRuntimeField_30 + 12, b:  7401472);
            val_30 = public static WordDropUIController MonoSingleton<WordDropUIController>::get_Instance().__il2cppRuntimeField_30 + 12;
            if(val_30 != 0)
            {
                    if(val_30 == null)
            {
                goto label_13;
            }
            
            }
            
            val_30 = 0;
            label_13:
            mem2[0] = val_30;
        }
        private void HandleHorizInput(float screenDragAmount)
        {
            float val_5;
            var val_12;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_12 = public static WordDropManager MonoSingleton<WordDropManager>::get_Instance();
            float val_2 = this.worldWidth * R1;
            UnityEngine.Transform val_3 = this.transform;
            UnityEngine.Vector3 val_4 = position;
            this.startingXPos = val_5;
            val_2 = val_2 + val_5;
            float val_6 = UnityEngine.Mathf.Clamp(value:  val_5, min:  val_4.y, max:  val_4.z);
            val_12 = val_2;
            UnityEngine.Transform val_7 = this.transform;
            UnityEngine.Transform val_8 = this.transform;
            UnityEngine.Vector3 val_9 = position;
            UnityEngine.Vector3 val_11 = new UnityEngine.Vector3(x:  val_9.x, y:  val_9.y);
            this.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        }
        private void InitCone()
        {
            float val_4;
            float val_5;
            object val_1 = this.coneObject.AddComponent<System.Object>();
            object val_2 = this.coneObject.AddComponent<System.Object>();
            if(this.coneObject != 0)
            {
                    this.coneObject.drag = null;
                this.coneObject.angularDrag = null;
            }
            else
            {
                    this.coneObject.drag = null;
                this.coneObject.angularDrag = null;
            }
            
            this.coneObject.gravityScale = null;
            this.coneObject.autoConfigureConnectedAnchor = false;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            this.coneObject.anchor = new UnityEngine.Vector2() {x = val_4, y = val_5};
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_3.x, y:  val_3.y);
            this.coneObject.connectedAnchor = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            object val_7 = this.GetComponent<System.Object>();
            this.coneObject.connectedBody = 961689216;
        }
        public void Init(bool reset)
        {
            this.myTails.Clear();
            MethodExtensionForMonoBehaviourTransform.DestroyChildren(t:  this.tailparent);
            object val_1 = this.coneObject.GetComponent<System.Object>();
            object val_2 = this.GetComponent<System.Object>();
            this.coneObject.connectedBody = 961822720;
        }
        private void Update()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_2 = UnityEngine.Input.GetKeyDown(key:  116);
            if(val_2 == false)
            {
                    return;
            }
            
            string val_3 = val_2.ToString();
            this.AddTail(word:  961939084, sprite:  0);
        }
        private void OnTriggerEnter2D(UnityEngine.Collider2D col)
        {
            var val_15;
            UnityEngine.GameObject val_1 = col.gameObject;
            object val_2 = col.GetComponent<System.Object>();
            if(col == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_4 = col.gameObject;
            object val_5 = col.GetComponent<System.Object>();
            val_15 = col;
            this.curCollidingWith = col;
            if(col != 0)
            {
                    UnityEngine.GameObject val_6 = col.gameObject;
                object val_7 = col.GetComponent<System.Object>();
                UnityEngine.GameObject val_8 = col.gameObject;
                object val_9 = col.GetComponent<System.Object>();
                UnityEngine.Sprite val_10 = col.ScoopSprite;
                this.AddTail(word:  col, sprite:  col);
                val_15 = 1152921511456192016;
                twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                AddScoop();
                twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                HandleLevelComplete();
            }
            else
            {
                    twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                HandleFail();
            }
            
            UnityEngine.GameObject val_14 = this.curCollidingWith.gameObject;
            UnityEngine.Object.Destroy(obj:  this.curCollidingWith);
        }
        private void AddTail(string word, UnityEngine.Sprite sprite)
        {
            float val_13;
            float val_14;
            var val_22;
            var val_23;
            UnityEngine.Rigidbody2D val_24;
            var val_25;
            var val_26;
            object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  this.tailPrefab, parent:  this.tailparent);
            this.myTails.Insert(index:  0, item:  this.tailPrefab);
            UnityEngine.Transform val_2 = this.tailPrefab.transform;
            UnityEngine.Transform val_3 = this.transform;
            UnityEngine.Vector3 val_4 = position;
            this.tailPrefab.position = new UnityEngine.Vector3();
            object val_5 = this.tailPrefab.GetComponentInChildren<System.Object>();
            object val_6 = this.tailPrefab.GetComponent<System.Object>();
            this.tailPrefab.sprite = sprite;
            object val_7 = this.tailPrefab.GetComponent<System.Object>();
            this.tailPrefab.sortingOrder = 1152921514158974656;
            string val_8 = 962202304 + 13152256;
            val_23 = "tail ";
            this.tailPrefab.name = 962202304;
            if(this.usePhysTails == false)
            {
                    return;
            }
            
            if(this.tailPrefab != 0)
            {
                    object val_9 = this.tailPrefab.AddComponent<System.Object>();
                val_24 = this.tailPrefab;
            }
            else
            {
                    object val_10 = this.tailPrefab.AddComponent<System.Object>();
                val_24 = this.tailPrefab;
            }
            
            object val_11 = this.tailPrefab.AddComponent<System.Object>();
            if(val_24 != 0)
            {
                    val_24.drag = val_4.x;
                val_24.angularDrag = val_4.x;
            }
            else
            {
                    val_24.drag = val_4.x;
                val_24.angularDrag = val_4.x;
            }
            
            val_24.gravityScale = val_4.x;
            this.tailPrefab.autoConfigureConnectedAnchor = false;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.zero;
            this.tailPrefab.anchor = new UnityEngine.Vector2() {x = val_13, y = val_14};
            UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  val_12.x, y:  val_12.y);
            this.tailPrefab.connectedAnchor = new UnityEngine.Vector2() {x = val_15.x, y = val_15.y};
            object val_16 = this.GetComponent<System.Object>();
            val_22 = this;
            this.tailPrefab.connectedBody = 962246864;
            if(this.tailPrefab >= 2)
            {
                    if(this.tailPrefab <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_22 = 1152921514158579264;
                object val_17 = 1.GetComponent<System.Object>();
                1.connectedBody = val_24;
                if(1 <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                object val_18 = 1.GetComponent<System.Object>();
                val_14 = 0;
                val_13 = 0;
                UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  val_12.x, y:  val_12.y);
                1.connectedAnchor = new UnityEngine.Vector2() {x = val_19.x, y = val_19.y};
            }
            
            object val_20 = this.coneObject.GetComponent<System.Object>();
            if(this.myTails != 0)
            {
                    val_26 = this.coneObject;
            }
            else
            {
                    val_22 = 12;
                val_26 = 0;
                val_25 = 0;
            }
            
            val_23 = -1;
            if(val_25 <= val_23)
            {
                    var val_22 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_22 = val_22 + 4294967292;
            object val_21 = (0 + 4294967292) + 16.GetComponent<System.Object>();
            this.coneObject.connectedBody = (0 + 4294967292) + 16;
        }
        public void DeleteWordScoops()
        {
            System.Collections.IEnumerator val_1 = this.BreakJoints();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  962408016);
        }
        private System.Collections.IEnumerator BreakJoints()
        {
            object val_1 = new System.Object();
            typeof(IceCreamController.<BreakJoints>d__23).__il2cppRuntimeField_8 = 0;
            typeof(IceCreamController.<BreakJoints>d__23).__il2cppRuntimeField_10 = this;
        }
        public IceCreamController()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.usePhysTails = true;
            this.myTails = null;
        }
    
    }

}
