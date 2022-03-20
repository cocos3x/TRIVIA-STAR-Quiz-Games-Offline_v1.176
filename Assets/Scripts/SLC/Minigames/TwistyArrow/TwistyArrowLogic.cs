using UnityEngine;

namespace SLC.Minigames.TwistyArrow
{
    public class TwistyArrowLogic : MonoSingleton<SLC.Minigames.TwistyArrow.TwistyArrowLogic>
    {
        // Fields
        private SLC.Minigames.TwistyArrow.TwistyWheel Wheel;
        private SLC.Minigames.TwistyArrow.WordBow bow;
        private UnityEngine.GameObject ArrowPrefab;
        private UnityEngine.Transform FlyingArrowsContainer;
        private UnityEngine.Transform StuckArrowsContainer;
        private float WheelRadius;
        private float ArrowHeight;
        private float ArrowHeadLength;
        private float FlyingArrowSpeed;
        private float distanceHit;
        private System.Collections.Generic.List<float> WordRegionRanges;
        private System.Collections.Generic.List<int> RegionsHit;
        private int badRegionIndex;
        
        // Properties
        public float SpeedMultiplier { get; }
        
        // Methods
        public float get_SpeedMultiplier()
        {
            if(this.Wheel != 0)
            {
                    return (float)S0;
            }
            
            return (float)S0;
        }
        public override void InitMonoSingleton()
        {
            float val_1 = this.WheelRadius;
            val_1 = val_1 - this.ArrowHeadLength;
            this.distanceHit = val_1;
        }
        private void Update()
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            SLC.Minigames.TwistyArrow.FlyingArrow val_13;
            var val_14;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(this.FlyingArrowsContainer.childCount < 1)
            {
                goto label_33;
            }
            
            System.Collections.IEnumerator val_3 = this.FlyingArrowsContainer.GetEnumerator();
            label_27:
            val_9 = 0;
            val_10 = 0;
            val_9 = val_9 + 1;
            val_10 = (uint)val_9 & 65535;
            val_11 = this.FlyingArrowsContainer;
            if(this.FlyingArrowsContainer == 0)
            {
                goto label_13;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_12 = this.FlyingArrowsContainer;
            if(this.FlyingArrowsContainer != 0)
            {
                    val_13 = 0;
            }
            else
            {
                    val_13 = 0;
            }
            
            object val_6 = GetComponent<System.Object>();
            this.CheckCollision(arrow:  null);
            goto label_27;
            label_13:
            if(this.FlyingArrowsContainer != 0)
            {
                    val_9 = 0;
                val_9 = val_9 + 1;
                val_14 = this.FlyingArrowsContainer;
            }
            
            label_33:
            if((UnityEngine.Input.GetKeyDown(key:  32)) == false)
            {
                    return;
            }
            
            this.FireArrow();
        }
        public void Setup(string[] words, float secondsPerRotation)
        {
            var val_4;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            this.RegionsHit = null;
            this.badRegionIndex = 0;
            this.ClearStuckArrows();
            this.ClearFlyingArrows();
            this.Wheel.Setup(words:  words, secondsPerRotation:  secondsPerRotation);
            UnityEngine.Transform val_2 = this.Wheel.transform;
            float val_4 = this.WheelRadius;
            UnityEngine.Vector2 val_3;
            val_4 = val_4 + val_4;
            val_3 = new UnityEngine.Vector2(x:  val_4, y:  null);
            if(this.Wheel != 0)
            {
                    if(null != null)
            {
                    val_4 = 0;
            }
            
            }
            else
            {
                    val_4 = 0;
            }
            
            val_4.sizeDelta = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        }
        public void FireArrow()
        {
            this.bow.OnFire();
            object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  this.ArrowPrefab, parent:  this.FlyingArrowsContainer);
            object val_2 = this.ArrowPrefab.GetComponent<System.Object>();
            this.ArrowPrefab.SetSpeed(_speed:  null);
        }
        public void HandleHitArrow()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayGameSpecificSound(id:  1011432624, clipIndex:  0, volumeScale:  null);
            this.HandleFailure(hitBadRegion:  false);
        }
        private void CheckCollision(SLC.Minigames.TwistyArrow.FlyingArrow arrow)
        {
            var val_3;
            var val_6;
            var val_10;
            var val_19;
            UnityEngine.Transform val_1 = this.Wheel.transform;
            UnityEngine.Vector3 val_2 = localPosition;
            UnityEngine.Transform val_4 = arrow.transform;
            UnityEngine.Vector3 val_5 = localPosition;
            var val_25 = val_6;
            val_25 = val_3 - val_25;
            if(arrow > 0)
            {
                    return;
            }
            
            object val_7 = new System.Object();
            arrow.ClearRigidBody();
            this.Wheel.PlaySound();
            UnityEngine.Transform val_8 = this.Wheel.transform;
            UnityEngine.Vector3 val_9 = localEulerAngles;
            typeof(TwistyArrowLogic.<>c__DisplayClass20_0).__il2cppRuntimeField_8 = val_10;
            System.Predicate<System.Single> val_11 = new System.Predicate<System.Single>(object:  453300224, method:  new IntPtr(1011565200));
            UnityEngine.Transform val_13 = arrow.transform;
            UnityEngine.Transform val_14 = this.Wheel.transform;
            UnityEngine.Vector3 val_15 = localPosition;
            UnityEngine.Transform val_17 = this.Wheel.transform;
            UnityEngine.Vector3 val_18 = localPosition;
            float val_26 = this.distanceHit;
            val_26 = val_19 - val_26;
            UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  val_26, y:  val_18.y);
            UnityEngine.Vector3 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0.0124314f, y = val_20.x});
            arrow.localPosition = new UnityEngine.Vector3();
            UnityEngine.Transform val_22 = arrow.transform;
            arrow.SetParent(p:  this.StuckArrowsContainer);
            arrow.SetNormalColliderActive(state:  false);
            System.Collections.IEnumerator val_23 = arrow.DelayActiveCollider(arrow:  arrow);
            UnityEngine.Coroutine val_24 = arrow.StartCoroutine(routine:  arrow);
            this.HandleHitRegion(regionIndex:  this.WordRegionRanges.FindIndex(match:  8040448));
        }
        private System.Collections.IEnumerator DelayActiveCollider(SLC.Minigames.TwistyArrow.FlyingArrow arrow)
        {
            object val_1 = new System.Object();
            typeof(TwistyArrowLogic.<DelayActiveCollider>d__21).__il2cppRuntimeField_8 = 0;
            typeof(TwistyArrowLogic.<DelayActiveCollider>d__21).__il2cppRuntimeField_10 = arrow;
        }
        private void HandleHitRegion(int regionIndex)
        {
            System.Collections.Generic.List<System.Int32> val_5;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_5 = public static SLC.Minigames.TwistyArrow.TwistyGameManager MonoSingleton<SLC.Minigames.TwistyArrow.TwistyGameManager>::get_Instance();
            if(this.badRegionIndex == regionIndex)
            {
                    this.HandleFailure(hitBadRegion:  true);
                return;
            }
            
            val_5 = this.RegionsHit;
            if((val_5.Contains(item:  regionIndex)) == true)
            {
                    return;
            }
            
            val_5 = this.RegionsHit;
            val_5.Add(item:  regionIndex);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayGameSpecificSound(id:  1011853712, volumeScale:  null);
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowCheck();
            this.Wheel.IncreSpeed();
            if(this.Wheel < 4)
            {
                    return;
            }
            
            this.HandleLevelComplete();
        }
        private void HandleLevelComplete()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandleLevelComplete();
            this.ClearFlyingArrows();
        }
        private void HandleFailure(bool hitBadRegion)
        {
            if(hitBadRegion != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                HandleFailure();
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                PlayGameSpecificSound(id:  1012103408, clipIndex:  0, volumeScale:  null);
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                ShowX();
                this.ClearFlyingArrows();
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandleSoftFailure();
        }
        private void ClearStuckArrows()
        {
            float val_8;
            float val_9;
            var val_10;
            var val_11;
            var val_12;
            UnityEngine.Object val_13;
            var val_14;
            var val_15;
            var val_16;
            System.Collections.IEnumerator val_1 = this.StuckArrowsContainer.GetEnumerator();
            val_8 = 1152921504683417600;
            val_9 = 1152921504765685760;
            label_23:
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_10 = (uint)val_7 & 65535;
            val_11 = this.StuckArrowsContainer;
            if(this.StuckArrowsContainer == 0)
            {
                goto label_7;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_12 = this.StuckArrowsContainer;
            if(this.StuckArrowsContainer != 0)
            {
                    val_13 = 0;
            }
            else
            {
                    val_13 = 0;
            }
            
            UnityEngine.GameObject val_4 = gameObject;
            UnityEngine.Object.Destroy(obj:  null);
            goto label_23;
            label_7:
            val_14 = 0;
            val_15 = 1152921504619679744;
            if(this.StuckArrowsContainer != 0)
            {
                    val_10 = 0;
                val_15 = 0;
                val_10 = val_10 + 1;
                val_15 = (uint)val_10 & 65535;
                val_16 = this.StuckArrowsContainer;
            }
            
            var val_6 = FP - 28;
        }
        private void ClearFlyingArrows()
        {
            float val_8;
            float val_9;
            var val_10;
            var val_11;
            var val_12;
            UnityEngine.Object val_13;
            var val_14;
            var val_15;
            var val_16;
            System.Collections.IEnumerator val_1 = this.FlyingArrowsContainer.GetEnumerator();
            val_8 = 1152921504683417600;
            val_9 = 1152921504765685760;
            label_23:
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_10 = (uint)val_7 & 65535;
            val_11 = this.FlyingArrowsContainer;
            if(this.FlyingArrowsContainer == 0)
            {
                goto label_7;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_12 = this.FlyingArrowsContainer;
            if(this.FlyingArrowsContainer != 0)
            {
                    val_13 = 0;
            }
            else
            {
                    val_13 = 0;
            }
            
            UnityEngine.GameObject val_4 = gameObject;
            UnityEngine.Object.Destroy(obj:  null);
            goto label_23;
            label_7:
            val_14 = 0;
            val_15 = 1152921504619679744;
            if(this.FlyingArrowsContainer != 0)
            {
                    val_10 = 0;
                val_15 = 0;
                val_10 = val_10 + 1;
                val_15 = (uint)val_10 & 65535;
                val_16 = this.FlyingArrowsContainer;
            }
            
            var val_6 = FP - 28;
        }
        public TwistyArrowLogic()
        {
            var val_2;
            this.ArrowHeight = 150f;
            this.ArrowHeadLength = 15f;
            this.FlyingArrowSpeed = 15f;
            System.Collections.Generic.List<System.Single> val_1 = new System.Collections.Generic.List<System.Single>();
            if(null != 0)
            {
                    val_2 = 1152921511060597808;
                Add(item:  null);
                Add(item:  null);
                Add(item:  null);
                Add(item:  null);
            }
            else
            {
                    val_2 = 1152921511060597808;
                Add(item:  null);
                Add(item:  null);
                Add(item:  null);
                Add(item:  null);
            }
            
            Add(item:  null);
            this.WordRegionRanges = null;
        }
    
    }

}
