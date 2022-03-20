using UnityEngine;

namespace SLC.Minigames.SnackBlock
{
    public class SnakeBlockController : MonoBehaviour
    {
        // Fields
        private UnityEngine.Camera snakeBlockCamera;
        public int ticksPerTail;
        private System.Collections.Generic.List<UnityEngine.Vector3> prevXPos;
        private System.Collections.Generic.List<UnityEngine.GameObject> myTails;
        private int _livesUsed;
        private UnityEngine.GameObject tailPrefab;
        private float speed;
        private float cachedSpeed;
        private float startingXPos;
        private float startingXPixelPos;
        private bool alreadyTouching;
        private float minXValue;
        private float maxXValue;
        private float _liveDeductionInterval;
        private System.Collections.IEnumerator losingLife;
        private SLC.Minigames.SnackBlock.SnakeBlockBlock curCollidingWith;
        private UnityEngine.RaycastHit2D[] hitStuff;
        private UnityEngine.RaycastHit2D[] hitStuffVert;
        private bool hittingBlock;
        private int startingLifes;
        private float removeTailProgress;
        private UnityEngine.Transform tailparent;
        private bool resetting;
        private bool usePhysTails;
        private float snakeRadius;
        private UnityEngine.GameObject tailDeathParticles;
        private float worldWidth;
        private float worldMin;
        private float worldMax;
        private SLC.Minigames.SnackBlock.SnakeBlockBlock currentForwardCollisionBlock;
        private float cameraYOffset;
        private float xInputThisFrame;
        private UnityEngine.Rigidbody2D myRigidBody2D;
        
        // Properties
        private int livesRemaining { get; }
        public int LivesUsed { get; }
        private float liveDeductionInterval { get; }
        
        // Methods
        private int get_livesRemaining()
        {
            if(this.myTails != 0)
            {
                    return (int)true;
            }
            
            return (int)true;
        }
        public int get_LivesUsed()
        {
            return (int)this._livesUsed;
        }
        private float get_liveDeductionInterval()
        {
            float val_6;
            var val_7;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_1C.Contains(key:  -1125333760)) != false)
            {
                    twelvegigs.storage.JsonDictionary val_3 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_1C.getJsonDictionary(key:  -1125333760);
                val_7 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_1C;
            }
            
            if((val_7.Contains(key:  1023507328)) != false)
            {
                    float val_5 = val_7.getFloat(key:  1023507328, defaultValue:  this._liveDeductionInterval);
                val_6 = val_7;
            }
            else
            {
                    val_6 = 0.33f;
            }
            
            this._liveDeductionInterval = val_6;
            return val_6;
        }
        private void Start()
        {
            float val_5;
            float val_6;
            float val_8;
            float val_11;
            float val_13;
            float val_22;
            float val_23;
            float val_25;
            float val_29;
            var val_33;
            float val_1 = this.snakeBlockCamera.aspect;
            float val_33 = 5.5f;
            val_33 = (0.5625f / this.snakeBlockCamera) * val_33;
            this.snakeBlockCamera.orthographicSize = val_33;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_7 = ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = this.snakeBlockCamera, y = val_5, z = val_6});
            this.minXValue = val_8;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_12 = ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = this.snakeBlockCamera, y = val_11, z = val_8});
            this.maxXValue = val_13;
            object val_14 = this.snakeBlockCamera.GetComponent<System.Object>();
            float val_34 = this.snakeRadius;
            this.myRigidBody2D = this;
            val_34 = val_34 + val_34;
            UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  val_34, y:  val_12.y);
            UnityEngine.GameObject val_16 = this.snakeBlockCamera.gameObject;
            object val_17 = this.GetComponent<System.Object>();
            this.size = new UnityEngine.Vector2() {x = val_15.x, y = val_15.y};
            UnityEngine.GameObject val_18 = this.gameObject;
            object val_19 = this.GetComponent<System.Object>();
            this.size = new UnityEngine.Vector2() {x = val_15.x, y = val_15.y};
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_24 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = this.snakeBlockCamera, y = val_22, z = val_23});
            this.worldMin = val_25;
            UnityEngine.Vector3 val_27 = new UnityEngine.Vector3(x:  (float)UnityEngine.Screen.width, y:  val_24.y, z:  val_24.z);
            UnityEngine.Vector3 val_28 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = this.snakeBlockCamera, y = val_27.x, z = val_27.y});
            float val_35 = this.worldMin;
            val_35 = val_29 - val_35;
            this.worldMax = val_29;
            this.worldWidth = val_35;
            twelvegigs.Autopilot.AutopilotManager val_30 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Single> val_31 = new System.Action<System.Single>(object:  1023670032, method:  new IntPtr(1023645008));
            System.Delegate val_32 = System.Delegate.Combine(a:  public static SLC.Minigames.SnackBlock.SnakeBlockManager MonoSingleton<SLC.Minigames.SnackBlock.SnakeBlockManager>::get_Instance().__il2cppRuntimeField_30 + 12 + 12, b:  7401472);
            val_33 = public static SLC.Minigames.SnackBlock.SnakeBlockManager MonoSingleton<SLC.Minigames.SnackBlock.SnakeBlockManager>::get_Instance().__il2cppRuntimeField_30 + 12 + 12;
            if(val_33 != 0)
            {
                    if(val_33 == null)
            {
                goto label_20;
            }
            
            }
            
            val_33 = 0;
            label_20:
            mem2[0] = val_33;
        }
        public void Init(bool reset)
        {
            var val_11;
            System.Collections.Generic.List<UnityEngine.GameObject> val_17;
            int val_18;
            System.Collections.Generic.List<UnityEngine.Vector3> val_1 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.prevXPos = null;
            this.enabled = true;
            UnityEngine.Transform val_2 = this.transform;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.position = new UnityEngine.Vector3();
            if(reset != false)
            {
                    val_17 = this.myTails;
                val_18 = this.startingLifes;
            }
            else
            {
                    val_17 = this;
                val_18 = this.myTails + 12;
            }
            
            null.Clear();
            MethodExtensionForMonoBehaviourTransform.DestroyChildren(t:  this.tailparent);
            if(null >= 1)
            {
                    do
            {
                this.AddTail();
                System.Collections.Generic.List<UnityEngine.GameObject> val_4 = 1152921504687730688 - 1;
            }
            while(null != 1);
            
            }
            
            if(reset == true)
            {
                    this = 0;
                this._livesUsed = this;
            }
            
            float val_5 = this.liveDeductionInterval;
            this.removeTailProgress = this;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_7 = getSpeedForLevel;
            this.speed = public static SLC.Minigames.SnackBlock.SnakeBlockManager MonoSingleton<SLC.Minigames.SnackBlock.SnakeBlockManager>::get_Instance();
            this.cachedSpeed = public static SLC.Minigames.SnackBlock.SnakeBlockManager MonoSingleton<SLC.Minigames.SnackBlock.SnakeBlockManager>::get_Instance();
            UnityEngine.Transform val_8 = this.snakeBlockCamera.transform;
            UnityEngine.Transform val_9 = this.snakeBlockCamera.transform;
            UnityEngine.Vector3 val_10 = position;
            UnityEngine.Transform val_12 = this.snakeBlockCamera.transform;
            UnityEngine.Vector3 val_13 = position;
            UnityEngine.Vector3 val_16 = new UnityEngine.Vector3(x:  val_11 + this.cameraYOffset, y:  val_13.y, z:  val_13.z);
            this.snakeBlockCamera.position = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        }
        public System.Collections.IEnumerator Continue()
        {
            object val_1 = new System.Object();
            typeof(SnakeBlockController.<Continue>d__41).__il2cppRuntimeField_8 = 0;
            typeof(SnakeBlockController.<Continue>d__41).__il2cppRuntimeField_10 = this;
        }
        private void FixedUpdate()
        {
            float val_4;
            float val_6;
            float val_7;
            float val_11;
            float val_12;
            float val_15;
            float val_18;
            float val_20;
            float val_23;
            float val_24;
            float val_30;
            float val_32;
            float val_33;
            float val_36;
            var val_41;
            var val_42;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Vector2 val_2 = DesiredXMovementVector(xInput:  null);
            UnityEngine.Vector2 val_3 = DesiredYMovementVector();
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 0.03387484f}, b:  new UnityEngine.Vector2() {y = val_4});
            UnityEngine.Vector2 val_8 = position;
            UnityEngine.Vector2 val_9 = normalized;
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 0.03387481f, y = val_6}, d:  val_9.x);
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 0.03387478f, y = val_12}, b:  new UnityEngine.Vector2() {x = val_11, y = val_12});
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.up;
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 0.03387472f}, b:  new UnityEngine.Vector2() {y = val_15});
            UnityEngine.Vector2 val_17 = position;
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 0.03387466f}, b:  new UnityEngine.Vector2() {y = val_18});
            UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0.03387462f, y = val_20});
            float val_25 = this.myRigidBody2D.rotation;
            float val_26 = UnityEngine.Time.fixedDeltaTime;
            float val_42 = 7f;
            float val_41 = -90f;
            val_41 = 0f + val_41;
            val_42 = 0 * val_42;
            this.myRigidBody2D.MoveRotation(angle:  UnityEngine.Mathf.LerpAngle(a:  val_42, b:  val_22.y, t:  val_41));
            UnityEngine.Vector2 val_28 = position;
            UnityEngine.Vector2 val_31 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 0.03387456f, y = val_6}, b:  new UnityEngine.Vector2() {x = val_7, y = val_30});
            this.myRigidBody2D.MovePosition(position:  new UnityEngine.Vector2() {x = val_32, y = val_33});
            this.xInputThisFrame = 0f;
            this.CalcuateTailStuff();
            if(this.usePhysTails != false)
            {
                    return;
            }
            
            if(this.usePhysTails != true)
            {
                    int val_43 = this.ticksPerTail;
                val_43 = val_43 + (val_43 << 1);
                if(val_32 > val_43)
            {
                    return;
            }
            
            }
            
            UnityEngine.Transform val_34 = this.transform;
            UnityEngine.Vector3 val_35 = position;
            this.prevXPos.Insert(index:  0, item:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_36});
            if(this.prevXPos == 0)
            {
                    return;
            }
            
            val_41 = 0;
            goto label_24;
            label_34:
            int val_37 = this.ticksPerTail * val_41;
            if(val_37 <= (-1))
            {
                    if(val_37 <= val_41)
            {
                    var val_44 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_44 = val_44 + 0;
                UnityEngine.Transform val_38 = (0 + 0) + 16.transform;
                int val_45 = this.ticksPerTail;
                val_45 = val_45 * val_41;
                if(((0 + 0) + 16) <= val_45)
            {
                    var val_46 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_46 = val_46 + ((val_45 + (val_45 << 1)) << 2);
                var val_47 = (0 + 0) + 16;
                val_47.position = new UnityEngine.Vector3() {x = (0 + (((this.ticksPerTail * val_41) + ((this.ticksPerTail * val_41)) << 1)) << 2) + 16, y = (0 + (((this.ticksPerTail * val_41) + ((this.ticksPerTail * val_41)) << 1)) << 2) + 20, z = (0 + (((this.ticksPerTail * val_41) + ((this.ticksPerTail * val_41)) << 1)) << 2) + 24};
            }
            
            val_41 = 1;
            label_24:
            if(val_41 < val_47)
            {
                goto label_34;
            }
            
            val_47 = val_47 * this.ticksPerTail;
            if(this.prevXPos <= val_47)
            {
                    return;
            }
            
            if(this.prevXPos != 0)
            {
                
            }
            else
            {
                    val_42 = 0;
            }
            
            this.prevXPos.RemoveAt(index:  val_42 - 1);
        }
        private UnityEngine.Vector2 DesiredYMovementVector()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            return new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        }
        private UnityEngine.Vector2 DesiredXMovementVector(float xInput)
        {
            float val_5;
            UnityEngine.RaycastHit2D[] val_10;
            float val_34;
            UnityEngine.Object val_35;
            float val_36;
            float val_38;
            float val_39;
            val_34 = R2;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_35 = public static SLC.Minigames.SnackBlock.SnakeBlockManager MonoSingleton<SLC.Minigames.SnackBlock.SnakeBlockManager>::get_Instance();
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            return new UnityEngine.Vector2() {x = val_36, y = val_32.y};
            label_34:
            UnityEngine.Object val_17 = (R1 + 76) + ;
            UnityEngine.Transform val_18 = val_17.transform;
            object val_19 = val_17.GetComponent<System.Object>();
            val_35 = val_17;
            if(val_35 == 0)
            {
                goto label_28;
            }
            
            var val_21 = (R1 + 76) + ;
            UnityEngine.Transform val_22 = val_21.transform;
            object val_23 = val_21.GetComponent<System.Object>();
            val_35 = val_21;
            var val_35 = (R1 + 76 + 16) + 12;
            val_35 = val_35 | 2;
            if(val_35 == 3)
            {
                goto label_33;
            }
            
            label_28:
             =  + 1;
             =  + 36;
            if( < )
            {
                goto label_34;
            }
            
            goto label_41;
            label_33:
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.right;
            val_35 = mem[R1 + 76];
            val_35 = R1 + 76;
            val_34 = val_5.Equals(other:  new UnityEngine.Vector2() {x = val_5, y = val_10});
            if(val_34 != false)
            {
                    var val_26 = val_35 + ;
                UnityEngine.Vector2 val_27 = point;
                val_39 = mem[R1 + 104];
                val_39 = R1 + 104;
                val_38 = val_5;
            }
            else
            {
                    var val_28 = val_35 + ;
                UnityEngine.Vector2 val_29 = point;
                val_39 = mem[R1 + 104];
                val_39 = R1 + 104;
                val_38 = val_5;
            }
            
            label_41:
             =  + val_5;
            float val_30 = UnityEngine.Mathf.Clamp(value:  val_39, min:  val_29.y, max:  val_38);
            UnityEngine.Transform val_31 = R1.transform;
            UnityEngine.Vector3 val_32 = position;
            val_36 =  - val_5;
            this = 0;
            mem[1152921514221194900] = 0;
            this = new UnityEngine.Vector2(x:  val_36, y:  val_32.y);
            return new UnityEngine.Vector2() {x = val_36, y = val_32.y};
        }
        private void Update()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.SnackBlock.SnakeBlockManager MonoSingleton<SLC.Minigames.SnackBlock.SnakeBlockManager>::get_Instance().__il2cppRuntimeField_28) != 0)
            {
                    return;
            }
            
            if((UnityEngine.Input.GetKeyDown(key:  116)) == false)
            {
                    return;
            }
            
            R4.AddTail();
        }
        private void LateUpdate()
        {
            var val_5;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_2 = this.snakeBlockCamera.transform;
            UnityEngine.Transform val_3 = this.snakeBlockCamera.transform;
            UnityEngine.Vector3 val_4 = position;
            UnityEngine.Transform val_6 = this.snakeBlockCamera.transform;
            UnityEngine.Vector3 val_7 = position;
            UnityEngine.Vector3 val_10 = new UnityEngine.Vector3(x:  val_5 + this.cameraYOffset, y:  val_7.y, z:  val_7.z);
            this.snakeBlockCamera.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        private void HandleHorizInput(float screenDragAmount)
        {
            this.xInputThisFrame = ;
        }
        private bool ForwardCollision()
        {
            float val_6;
            float val_7;
            float val_8;
            UnityEngine.RaycastHit2D[] val_9;
            var val_16;
            var val_17;
            UnityEngine.RaycastHit2D[] val_18;
            int val_19;
            var val_20;
            float val_21;
            float val_22;
            val_16 = this;
            this.currentForwardCollisionBlock = 0;
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = position;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0.03714509f});
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.up;
            float val_5 = UnityEngine.Time.fixedDeltaTime;
            float val_16 = 1f;
            val_17 = 0;
            val_18 = val_9;
            val_16 = val_16 / this.speed;
            val_16 = val_16 * 0;
            int val_10 = UnityEngine.Physics2D.CircleCastNonAlloc(origin:  new UnityEngine.Vector2() {x = val_6, y = val_7}, radius:  val_16, direction:  new UnityEngine.Vector2() {x = this.snakeRadius, y = val_8}, results:  val_18, distance:  val_4.y);
            if(val_10 >= 0)
            {
                    if(val_10 != 0)
            {
                    val_19 = val_10;
                val_18 = 16;
                val_20 = 0;
                val_21 = 1152921514221169872;
                do
            {
                UnityEngine.Transform val_11 = this.hitStuffVert[val_18].transform;
                UnityEngine.Object val_17 = this.hitStuffVert[val_18];
                object val_12 = val_17.GetComponent<System.Object>();
                if(val_17 != 0)
            {
                    UnityEngine.Transform val_14 = this.hitStuffVert[val_18].transform;
                SLC.Minigames.SnackBlock.SnakeBlockBlock val_18 = this.hitStuffVert[val_18];
                object val_15 = val_18.GetComponent<System.Object>();
                this.currentForwardCollisionBlock = val_18;
                val_17 = 1;
                if(val_18 == 1)
            {
                    return (bool)val_17;
            }
            
                val_21 = this.currentForwardCollisionBlock;
                if(this.currentForwardCollisionBlock.myType == 3)
            {
                    return (bool)val_17;
            }
            
                val_21 = 1152921514221169872;
                if(this.currentForwardCollisionBlock.myType == 2)
            {
                    return (bool)val_17;
            }
            
                val_19 = val_10;
                this.currentForwardCollisionBlock = 0;
                val_16 = val_16;
            }
            
                val_20 = val_20 + 1;
                val_18 = val_18 + 36;
            }
            while(val_20 < val_19);
            
            }
            
                val_22 = this.cachedSpeed;
                val_17 = 0;
            }
            else
            {
                    val_22 = this.cachedSpeed;
            }
            
            this.speed = val_22;
            return (bool)val_17;
        }
        private void CalcuateTailStuff()
        {
            float val_12;
            float val_13;
            float val_14;
            float val_15;
            System.Collections.Generic.List<UnityEngine.GameObject> val_26;
            var val_27;
            var val_28;
            if(this.resetting == true)
            {
                    return;
            }
            
            val_26 = 1152921504765685760;
            if(this.currentForwardCollisionBlock == 0)
            {
                    float val_2 = this.liveDeductionInterval;
                this.removeTailProgress = this;
                return;
            }
            
            if(this.currentForwardCollisionBlock.myType == 2)
            {
                    label_43:
                this.OnWordBlockCollision();
                UnityEngine.Transform val_3 = this.currentForwardCollisionBlock.transform;
                UnityEngine.Transform val_4 = this.currentForwardCollisionBlock.parent;
                UnityEngine.GameObject val_5 = this.currentForwardCollisionBlock.gameObject;
                this.currentForwardCollisionBlock.SetActive(value:  false);
            }
            else
            {
                    float val_26 = this.removeTailProgress;
                float val_6 = UnityEngine.Time.deltaTime;
                val_26 = val_26 + 0;
                this.removeTailProgress = val_26;
                float val_7 = this.liveDeductionInterval;
                if((this.currentForwardCollisionBlock.myType >= 2) && (this >= 1))
            {
                    this.removeTailProgress = 0f;
                if(this.myTails != 0)
            {
                    val_28 = 0f;
            }
            else
            {
                    val_28 = 0;
                val_27 = 0;
            }
            
                if(val_27 <= (-1))
            {
                    var val_27 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_27 = val_27 + 4294967292;
                UnityEngine.Transform val_8 = (0 + 4294967292) + 16.transform;
                UnityEngine.Vector3 val_9 = position;
                UnityEngine.Transform val_10 = (0 + 4294967292) + 16.transform;
                UnityEngine.Quaternion val_11 = rotation;
                UnityEngine.GameObject val_16 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.tailDeathParticles, position:  new UnityEngine.Vector3(), rotation:  new UnityEngine.Quaternion() {x = val_12, y = val_13, z = val_14, w = val_15});
                val_26 = this.myTails;
                bool val_17 = val_26.Remove(item:  (0 + 4294967292) + 16);
                int val_28 = this._livesUsed;
                val_28 = val_28 + 1;
                this._livesUsed = val_28;
                UnityEngine.GameObject val_18 = (0 + 4294967292) + 16.gameObject;
                UnityEngine.Object.Destroy(obj:  (0 + 4294967292) + 16);
                twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                PlayGameSpecificSound(id:  1025252432, clipIndex:  0, volumeScale:  val_11.x);
                if(this.livesRemaining <= 0)
            {
                    this.enabled = false;
                twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                HandleFailed();
                if(this.currentForwardCollisionBlock.myType != 3)
            {
                    UnityEngine.Transform val_22 = this.currentForwardCollisionBlock.transform;
                UnityEngine.Transform val_23 = this.currentForwardCollisionBlock.parent;
                UnityEngine.GameObject val_24 = this.currentForwardCollisionBlock.gameObject;
                this.currentForwardCollisionBlock.SetActive(value:  false);
            }
            
            }
            
                if(this.currentForwardCollisionBlock.myType == 3)
            {
                    if(this.currentForwardCollisionBlock.RemoveLastLetter() == true)
            {
                goto label_43;
            }
            
            }
            
            }
            
            }
            
            this.currentForwardCollisionBlock = 0;
        }
        private void OnTriggerEnter2D(UnityEngine.Collider2D col)
        {
            UnityEngine.GameObject val_1 = col.gameObject;
            object val_2 = col.GetComponent<System.Object>();
            if(col == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_4 = col.gameObject;
            object val_5 = col.GetComponent<System.Object>();
            this.curCollidingWith = col;
            if(col != 4)
            {
                    if(col != 2)
            {
                    return;
            }
            
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if((public static SLC.Minigames.SnackBlock.SnakeBlockManager MonoSingleton<SLC.Minigames.SnackBlock.SnakeBlockManager>::get_Instance().__il2cppRuntimeField_40) != 0)
            {
                    return;
            }
            
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                R6.DisableAvoidText();
                return;
            }
            
            UnityEngine.GameObject val_8 = col.gameObject;
            col.SetActive(value:  false);
            this.AddTail();
        }
        private void OnWordBlockCollision()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayGameSpecificSound(id:  1011853712, clipIndex:  0, volumeScale:  null);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandleComplete();
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_4 = getSpeedForLevel;
            this.speed = public static SLC.Minigames.SnackBlock.SnakeBlockManager MonoSingleton<SLC.Minigames.SnackBlock.SnakeBlockManager>::get_Instance();
            this.cachedSpeed = public static SLC.Minigames.SnackBlock.SnakeBlockManager MonoSingleton<SLC.Minigames.SnackBlock.SnakeBlockManager>::get_Instance();
        }
        private void AddTail()
        {
            float val_12;
            float val_13;
            float val_16;
            float val_17;
            float val_18;
            float val_21;
            float val_22;
            float val_23;
            UnityEngine.GameObject val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayGameSpecificSound(id:  1025679664, clipIndex:  0, volumeScale:  null);
            float val_33 = this.snakeRadius;
            float val_34 = 0.75f;
            val_33 = val_33 * val_34;
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.tailPrefab, parent:  this.tailparent);
            val_33 = this.tailPrefab;
            object val_3 = val_33.GetComponent<System.Object>();
            val_34 = val_33 + val_33;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  null, y:  null);
            val_33.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            object val_5 = val_33.GetComponent<System.Object>();
            val_33.radius = null;
            this.myTails.Add(item:  val_33);
            object val_6 = val_33.GetComponent<System.Object>();
            val_33.sortingOrder = ~this.myTails;
            UnityEngine.Transform val_7 = val_33.transform;
            val_34 = val_33;
            if(this.myTails == 1)
            {
                    val_35 = this;
                UnityEngine.Transform val_8 = this.transform;
            }
            else
            {
                    if(this.myTails != 0)
            {
                    val_37 = val_33;
            }
            else
            {
                    val_37 = 0;
                val_36 = 0;
            }
            
                if(val_36 <= (-2))
            {
                    var val_35 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_35 = val_35 + 4294967288;
                val_35 = (0 + 4294967288) + 16;
                UnityEngine.Transform val_9 = val_35.transform;
            }
            
            UnityEngine.Vector3 val_10 = val_4.x.position;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0.03990948f, y = val_12, z = val_13}, d:  val_11.x);
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0.03990944f, y = val_4.x, z = val_4.y}, b:  new UnityEngine.Vector3() {x = val_18, y = val_17, z = val_16});
            val_34.position = new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23};
            if(this.usePhysTails == false)
            {
                    return;
            }
            
            object val_24 = val_33.AddComponent<System.Object>();
            val_34 = val_33;
            if(val_33 != 0)
            {
                    val_34.drag = val_20.x;
                val_34.angularDrag = val_20.x;
            }
            else
            {
                    val_34.drag = val_20.x;
                val_34.angularDrag = val_20.x;
            }
            
            val_34.gravityScale = val_20.x;
            if(val_34 >= 1)
            {
                    object val_25 = val_33.AddComponent<System.Object>();
                val_34 = val_33;
                if(val_33 != 0)
            {
                    val_34.maxDistanceOnly = true;
                val_34.autoConfigureDistance = false;
            }
            else
            {
                    val_34.maxDistanceOnly = true;
                val_34.autoConfigureDistance = false;
            }
            
                val_34.autoConfigureConnectedAnchor = false;
                UnityEngine.Vector2 val_26 = UnityEngine.Vector2.zero;
                val_34.anchor = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
                UnityEngine.Vector2 val_27 = UnityEngine.Vector2.zero;
                val_34.connectedAnchor = new UnityEngine.Vector2() {x = val_12, y = val_13};
                float val_36 = (float)this.myTails;
                val_36 = val_34 * val_36;
                val_34.distance = val_36;
                object val_28 = this.GetComponent<System.Object>();
                val_34.connectedBody = 1025746768;
            }
            
            if(val_34 < 2)
            {
                    return;
            }
            
            object val_29 = val_33.AddComponent<System.Object>();
            val_33 = val_33;
            if(val_33 != 0)
            {
                    val_33.maxDistanceOnly = true;
                val_33.autoConfigureDistance = false;
            }
            else
            {
                    val_33.maxDistanceOnly = true;
                val_33.autoConfigureDistance = false;
            }
            
            val_33.autoConfigureConnectedAnchor = false;
            UnityEngine.Vector2 val_30 = UnityEngine.Vector2.zero;
            val_33.anchor = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            UnityEngine.Vector2 val_31 = UnityEngine.Vector2.zero;
            if(val_33 != 0)
            {
                    val_33.connectedAnchor = new UnityEngine.Vector2() {x = val_12, y = val_13};
            }
            else
            {
                    val_33.connectedAnchor = new UnityEngine.Vector2() {x = val_12, y = val_13};
            }
            
            val_33.distance = val_31.x;
            if(this.myTails != 0)
            {
                    val_39 = val_33;
            }
            else
            {
                    val_34 = 12;
                val_39 = 0;
                val_38 = 0;
            }
            
            if(val_38 <= (-2))
            {
                    var val_37 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_37 = val_37 + 4294967288;
            object val_32 = (0 + 4294967288) + 16.GetComponent<System.Object>();
            val_33.connectedBody = (0 + 4294967288) + 16;
        }
        public SnakeBlockController()
        {
            this.ticksPerTail = 10;
            System.Collections.Generic.List<UnityEngine.Vector3> val_1 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.prevXPos = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.speed = 0.02f;
            this.myTails = null;
            this._liveDeductionInterval = -1f;
            this.hitStuff = null;
            this.hitStuffVert = null;
            this.startingLifes = 3;
            this.usePhysTails = true;
            this.snakeRadius = 0.3f;
            this.cameraYOffset = -3f;
        }
    
    }

}
