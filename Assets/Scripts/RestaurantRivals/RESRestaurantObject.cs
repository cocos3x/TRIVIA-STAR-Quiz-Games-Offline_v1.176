using UnityEngine;

namespace RestaurantRivals
{
    public class RESRestaurantObject : MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform origin;
        private UnityEngine.GameObject brokenImage;
        private UnityEngine.Color colorUnbuiltObj;
        private UnityEngine.Color colorNextObj;
        private UnityEngine.Color colorNormalObj;
        private UnityEngine.GameObject disableObjectOnBuilt;
        private int objectState;
        private UnityEngine.ParticleSystem choppedTreeSmokeEfx;
        private System.Collections.Generic.List<UnityEngine.UI.Image> images;
        
        // Properties
        public UnityEngine.Transform AttackTransform { get; }
        public int GrowthState { get; }
        
        // Methods
        public UnityEngine.Transform get_AttackTransform()
        {
        
        }
        public int get_GrowthState()
        {
            return (int)this.objectState;
        }
        private void Awake()
        {
            this.RegisterChildImages();
        }
        private void Start()
        {
        
        }
        public DG.Tweening.Sequence SetObjectState(int state, bool instant = True, bool delayGrowth = False)
        {
            int val_20;
            UnityEngine.ParticleSystem val_21;
            float val_23;
            UnityEngine.GameObject val_24;
            val_20 = state;
            object val_1 = new System.Object();
            typeof(RESRestaurantObject.<>c__DisplayClass15_0).__il2cppRuntimeField_8 = this;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            typeof(RESRestaurantObject.<>c__DisplayClass15_0).__il2cppRuntimeField_C = this.objectState;
            this.objectState = val_20;
            if(val_20 == 0)
            {
                goto label_4;
            }
            
            if(val_20 != 2)
            {
                goto label_5;
            }
            
            this.SetImageColor(color:  new UnityEngine.Color() {r = mem[this.colorNormalObj + (0)], g = mem[this.colorNormalObj + (4)], b = mem[this.colorNormalObj + (8)], a = this.objectState});
            if(this.choppedTreeSmokeEfx != 0)
            {
                goto label_8;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.GameObject val_5 = this.choppedTreeSmokeEfx.gameObject;
            UnityEngine.Transform val_6 = this.transform;
            object val_7 = UnityEngine.Object.Instantiate<System.Object>(original:  public static RestaurantRivals.RESRestaurantManager MonoSingleton<RestaurantRivals.RESRestaurantManager>::get_Instance().__il2cppRuntimeField_14, parent:  631081712);
            val_21 = public static RestaurantRivals.RESRestaurantManager MonoSingleton<RestaurantRivals.RESRestaurantManager>::get_Instance().__il2cppRuntimeField_14;
            this.choppedTreeSmokeEfx = public static RestaurantRivals.RESRestaurantManager MonoSingleton<RestaurantRivals.RESRestaurantManager>::get_Instance().__il2cppRuntimeField_14;
            goto label_15;
            label_4:
            this.SetImageColor(color:  new UnityEngine.Color() {r = mem[this.colorUnbuiltObj + (0)], g = mem[this.colorUnbuiltObj + (4)], b = mem[this.colorUnbuiltObj + (8)], a = this.objectState});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            goto label_18;
            label_5:
            val_23 = 1152921504765685760;
            if(this.disableObjectOnBuilt != 0)
            {
                    val_24 = this.disableObjectOnBuilt;
                val_24.SetActive(value:  false);
            }
            
            val_20 = this.choppedTreeSmokeEfx;
            if(val_20 == 0)
            {
                goto label_29;
            }
            
            val_24 = this.choppedTreeSmokeEfx;
            UnityEngine.GameObject val_11 = val_24.gameObject;
            val_20 = val_24;
            UnityEngine.Object.Destroy(obj:  val_20);
            goto label_29;
            label_8:
            val_21 = this.choppedTreeSmokeEfx;
            label_15:
            UnityEngine.Transform val_12 = val_21.transform;
            val_20 = val_21;
            val_23 = 0;
            UnityEngine.Vector3 val_13 = position;
            val_20.position = new UnityEngine.Vector3();
            val_24 = this.choppedTreeSmokeEfx;
            val_24.Play();
            label_29:
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
            label_18:
            if(instant == true)
            {
                    return;
            }
            
            if(delayGrowth != false)
            {
                    DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_14.x);
            }
            
            if(this.images != 0)
            {
                    DG.Tweening.TweenCallback val_16 = new DG.Tweening.TweenCallback(object:  428539904, method:  new IntPtr(631055664));
                DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            }
            
            DG.Tweening.TweenCallback val_18 = new DG.Tweening.TweenCallback(object:  428539904, method:  new IntPtr(631056688));
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        }
        public void ToggleSilhouette(bool isOn)
        {
            if(isOn != false)
            {
                    if(this.images == 0)
            {
                    return;
            }
            
                DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
                DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  631235696, method:  new IntPtr(631210672));
                DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
                return;
            }
            
            DG.Tweening.Sequence val_4 = this.SetObjectState(state:  this.objectState, instant:  true, delayGrowth:  false);
        }
        public UnityEngine.Vector3 GetAveragePosition()
        {
            float val_3;
            float val_4;
            float val_5;
            var val_7;
            float val_11;
            float val_12;
            var val_13;
            RestaurantRivals.RESRestaurantObject val_16;
            float val_20;
            float val_21;
            val_16 = this;
            if((R1 + 80) != 0)
            {
                    R1 + 80 = mem[R1 + 80 + 12];
                R1 + 80 = R1 + 80 + 12;
                goto label_1;
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            return new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
            label_1:
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            val_16 = val_3;
            val_20 = val_4;
            val_21 = val_5;
            List.Enumerator<T> val_6 = GetEnumerator();
            goto label_8;
            label_13:
            UnityEngine.Transform val_8 = val_7.transform;
            UnityEngine.Vector3 val_9 = position;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 2.801223E-16f, y = val_16, z = val_20}, b:  new UnityEngine.Vector3() {x = val_21});
            val_16 = val_11;
            val_20 = val_12;
            val_21 = val_13;
            label_8:
            if(MoveNext() == true)
            {
                goto label_13;
            }
            
            Dispose();
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = 2.80442E-16f, y = val_16, z = val_20}, d:  (float)R1 + 80 + 12);
            return new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
        }
        private void RegisterChildImages()
        {
            float val_11;
            float val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            mem[1152921513828245440] = null;
            UnityEngine.Transform val_2 = this.transform;
            System.Collections.IEnumerator val_3 = this.GetEnumerator();
            val_11 = 1152921504683417600;
            val_12 = 1152921504767496192;
            label_25:
            RestaurantRivals.RESRestaurantObject val_10 = this;
            if(R2 == 0)
            {
                goto label_3;
            }
            
            val_13 = 0;
            label_5:
            if((R3 + 0) == null)
            {
                goto label_4;
            }
            
            val_13 = val_13 + 1;
            if(((uint)val_13 & 65535) < R2)
            {
                goto label_5;
            }
            
            label_3:
            val_14 = this;
            goto label_6;
            label_4:
            var val_4 = R3 + 0;
            val_10 = val_10 + (((R3 + 0) + 4) << 3);
            val_14 = val_10 + 188;
            label_6:
            if(this == 0)
            {
                goto label_7;
            }
            
            RestaurantRivals.RESRestaurantObject val_12 = this;
            if(null == 0)
            {
                goto label_9;
            }
            
            var val_11 = 0;
            label_11:
            if((R3 + 0) == null)
            {
                goto label_10;
            }
            
            val_11 = val_11 + 1;
            if(((uint)val_11 & 65535) < null)
            {
                goto label_11;
            }
            
            label_9:
            val_15 = this;
            goto label_12;
            label_10:
            var val_5 = R3 + 0;
            val_12 = val_12 + (((R3 + 0) + 4) << 3);
            val_15 = val_12 + 196;
            label_12:
            if(this != 0)
            {
                    if(null == null)
            {
                goto label_15;
            }
            
            }
            
            if(this == 0)
            {
                goto label_16;
            }
            
            label_15:
            if(null == null)
            {
                goto label_18;
            }
            
            val_16 = 0;
            goto label_20;
            label_16:
            val_16 = 0;
            goto label_20;
            label_18:
            val_16 = this;
            label_20:
            object val_6 = this.GetComponent<System.Object>();
            if(631463792 == 0)
            {
                goto label_25;
            }
            
            Add(item:  631463792);
            goto label_25;
            label_7:
            val_17 = 0;
            val_18 = 1152921504619679744;
            if(this == 0)
            {
                goto label_26;
            }
            
            RestaurantRivals.RESRestaurantObject val_13 = this;
            if(null == 0)
            {
                goto label_27;
            }
            
            val_13 = 0;
            label_29:
            val_18 = 0;
            if((R3 + 0) == null)
            {
                goto label_28;
            }
            
            val_13 = val_13 + 1;
            val_18 = (uint)val_13 & 65535;
            if(val_18 < null)
            {
                goto label_29;
            }
            
            label_27:
            val_19 = this;
            goto label_30;
            label_28:
            var val_8 = R3 + 0;
            val_13 = val_13 + (((R3 + 0) + 4) << 3);
            val_19 = val_13 + 188;
            label_30:
            label_26:
            var val_9 = FP - 28;
        }
        private void SetImageColor(UnityEngine.Color color)
        {
            var val_3;
            var val_4;
            System.Collections.Generic.List<UnityEngine.UI.Image> val_5;
            val_4 = 35625406;
            val_5 = this.images;
            if(631572152 != 0)
            {
                goto label_1;
            }
            
            this.RegisterChildImages();
            val_5 = this.images;
            if(val_5 == 0)
            {
                goto label_3;
            }
            
            label_1:
            if(this == 0)
            {
                goto label_3;
            }
            
            List.Enumerator<T> val_1 = GetEnumerator();
            label_6:
            if(MoveNext() == false)
            {
                goto label_4;
            }
            
            if(val_3 != 0)
            {
                goto label_6;
            }
            
            goto label_6;
            label_3:
            UnityEngine.Debug.LogError(message:  631559984);
            return;
            label_4:
            Dispose();
        }
        public RESRestaurantObject()
        {
            UnityEngine.Color val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            UnityEngine.Color val_2 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            UnityEngine.Color val_3 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        }
        private void <ToggleSilhouette>b__16_0()
        {
            UnityEngine.UI.Image val_3;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_3:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOColor(target:  val_3, endValue:  new UnityEngine.Color() {r = mem[this.colorNextObj + (0)], g = mem[this.colorNextObj + (4)], b = mem[this.colorNextObj + (8)], a = mem[this.colorNextObj + (12)]}, duration:  null);
            object val_5 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_3, ease:  12);
            goto label_3;
            label_2:
            Dispose();
        }
    
    }

}
