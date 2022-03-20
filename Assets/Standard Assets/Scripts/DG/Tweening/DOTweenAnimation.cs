using UnityEngine;

namespace DG.Tweening
{
    public class DOTweenAnimation : ABSAnimationComponent
    {
        // Fields
        public float delay;
        public float duration;
        public DG.Tweening.Ease easeType;
        public UnityEngine.AnimationCurve easeCurve;
        public DG.Tweening.LoopType loopType;
        public int loops;
        public string id;
        public bool isRelative;
        public bool isFrom;
        public bool isIndependentUpdate;
        public bool autoKill;
        public bool isActive;
        public bool isValid;
        public UnityEngine.Component target;
        public DG.Tweening.Core.DOTweenAnimationType animationType;
        public DG.Tweening.Core.TargetType targetType;
        public DG.Tweening.Core.TargetType forcedTargetType;
        public bool autoPlay;
        public bool useTargetAsV3;
        public float endValueFloat;
        public UnityEngine.Vector3 endValueV3;
        public UnityEngine.Vector2 endValueV2;
        public UnityEngine.Color endValueColor;
        public string endValueString;
        public UnityEngine.Rect endValueRect;
        public UnityEngine.Transform endValueTransform;
        public bool optionalBool0;
        public float optionalFloat0;
        public int optionalInt0;
        public DG.Tweening.RotateMode optionalRotationMode;
        public DG.Tweening.ScrambleMode optionalScrambleMode;
        public string optionalString;
        private bool _tweenCreated;
        private int _playCount;
        
        // Methods
        private void Awake()
        {
            var val_2 = this;
            if(this.isActive == true)
            {
                    this.isActive = this.isValid;
                goto label_0;
            }
            
            return;
            label_0:
            if(this.animationType == 1)
            {
                    if(this.useTargetAsV3 == true)
            {
                    return;
            }
            
            }
            
            R4.CreateTween();
            mem2[0] = 1;
        }
        private void Start()
        {
            if(this._tweenCreated == true)
            {
                    return;
            }
            
            if((R4 + 88) != 0)
            {
                    R4 + 88 = mem[R4 + 89];
                R4 + 88 = R4 + 89;
                goto label_0;
            }
            
            return;
            label_0:
            R4.CreateTween();
            mem2[0] = 1;
        }
        private void OnDestroy()
        {
            if(this.endValueColor != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  2098161536, complete:  false);
            }
            
            mem[1152921510999975860] = 0;
        }
        public void CreateTween()
        {
            DG.Tweening.Core.TargetType val_51;
            if(this.target == 0)
            {
                    UnityEngine.GameObject val_2 = this.target.gameObject;
                string val_3 = this.name;
                string val_4 = System.String.Format(format:  2098253632, arg0:  2098425824);
                UnityEngine.GameObject val_5 = this.gameObject;
                UnityEngine.Debug.LogWarning(message:  2098253632, context:  2098425824);
                return;
            }
            
            val_51 = this.forcedTargetType;
            if(val_51 == 0)
            {
                goto label_7;
            }
            
            label_22:
            this.targetType = val_51;
            goto label_8;
            label_7:
            val_51 = this.targetType;
            if(val_51 == 0)
            {
                goto label_9;
            }
            
            label_8:
            DG.Tweening.Core.DOTweenAnimationType val_52 = this.animationType;
            val_52 = val_52 - 1;
            if(val_52 > 20)
            {
                goto label_131;
            }
            
            var val_6 = 14499100 + (14499100 + ((this.animationType - 1)) << 2);
            if(val_52 == 20)
            {
                    val_51 = val_51 & (this >> val_51);
                val_51 = val_51 & ((IP) << 3);
                val_51 = val_51 & (val_51 >> 3);
                val_51 = val_51 & (((int)IP) >> 14499100);
                val_51 = val_51 * 14499100;
                1152921504821862400 & 16393951 = (1152921504821862400 & 16393951) & ((1152921504821862400 & 16393951) >> 1152921511000240096);
                1152921504821862400 & 16393951 = (1152921504821862400 & 16393951) & 4098487;
                1152921504821862400 & 16393951 = (1152921504821862400 & 16393951) & (((R8) << (32-10)) | ((R8) << 10));
                1152921504821862400 & 16393951 = (1152921504821862400 & 16393951) & 1024621;
                1152921504821862400 & 16393951 = (1152921504821862400 & 16393951) & ((((((((1152921504821862400 & 16393951) & ((1152921504821862400 & 16393951)) >> this) & 4098487) & ((R8) << (32-10)) | ((R8) << 10)) & 1024621)) << (32-11)) | (((((((1152921504821862400 & 16393951) & ((1152921504821862400 & 16393951)) >> this) & 4098487) & ((R8) << (32-10)) | ((R8) << 10)) & 1024621)) << 11));
                1152921504821862400 & 16393951 = (1152921504821862400 & 16393951) & 1845231616;
                1152921504821862400 & 16393951 = (1152921504821862400 & 16393951) & (((int)R8) >> 13);
                1152921504821862400 & 16393951 = (1152921504821862400 & 16393951) & ((IP) << 14);
                1152921504821862400 & 16393951 = (1152921504821862400 & 16393951) & 2098425824;
                1152921504821862400 & 16393951 = (1152921504821862400 & 16393951) & ((1152921504821862400 & 16393951) >> 15);
                1152921504821862400 & 16393951 = (1152921504821862400 & 16393951) & (((R8) << (32-15)) | ((R8) << 15));
                1152921504821862400 & 16393951 = (1152921504821862400 & 16393951) & ((1152921504821862400 & 16393951) >> R8);
                1152921504821862400 & 16393951 = (1152921504821862400 & 16393951) & (((IP) << (32-R8)) | ((IP) << R8));
                1152921504821862400 & 16393951 = (1152921504821862400 & 16393951) & (((int)R8) >> 17);
            }
            
            if(this.useTargetAsV3 == false)
            {
                goto label_11;
            }
            
            this.isRelative = false;
            if(this.endValueTransform != 0)
            {
                goto label_14;
            }
            
            UnityEngine.GameObject val_8 = this.endValueTransform.gameObject;
            string val_9 = this.name;
            string val_10 = System.String.Format(format:  2098270512, arg0:  2098425824);
            UnityEngine.GameObject val_11 = this.gameObject;
            UnityEngine.Debug.LogWarning(message:  2098270512, context:  2098425824);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            goto label_20;
            label_9:
            System.Type val_13 = this.target.GetType();
            DG.Tweening.Core.TargetType val_14 = DG.Tweening.DOTweenAnimation.TypeToDOTargetType(t:  this.target);
            goto label_22;
            label_14:
            if(this.targetType != 5)
            {
                goto label_96;
            }
            
            if(this.endValueTransform == 0)
            {
                goto label_97;
            }
            
            if(null != null)
            {
                    this.endValueTransform = 0;
            }
            
            goto label_98;
            label_96:
            UnityEngine.Vector3 val_49 = val_21.x.position;
            label_20:
            this.endValueV3 = val_21.x;
            mem[1152921511000240216] = val_21.y;
            mem[1152921511000240220] = val_21.z;
            label_11:
            DG.Tweening.Core.TargetType val_53 = this.targetType;
            val_53 = val_53 - 5;
            if(val_53 <= 6)
            {
                    var val_50 = 14502724 + 4;
                var val_51 = val_50 + ((14502724 + 4) + ((this.targetType - 5)) << 2);
                if(val_53 == 6)
            {
                    (14502724 + 4) + ((this.targetType - 5)) << 2 = ((14502724 + 4) + ((this.targetType - 5)) << 2) & ((IP) << (14502724 + 4) + ((this.targetType - 5)) << 2);
                (14502724 + 4) + ((this.targetType - 5)) << 2 = ((14502724 + 4) + ((this.targetType - 5)) << 2) & (((int)R8) >> 1152921504765685760);
                (14502724 + 4) + ((this.targetType - 5)) << 2 = ((14502724 + 4) + ((this.targetType - 5)) << 2) & (((int)R8) >> 1152921504765685760);
                (14502724 + 4) + ((this.targetType - 5)) << 2 = ((14502724 + 4) + ((this.targetType - 5)) << 2) & (((this) << (32-((((14502724 + 4) + ((this.targetType - 5)) << 2 & (IP) << (14502724 + 4) + ((this.targetType - 5)) << 2) & ((int)R8) >> 1152921504765685760) & ((int)R8) >> 1152921504765685760))) | ((this) << ((((14502724 + 4) + ((this.targetType - 5)) << 2 & (IP) << (14502724 + 4) + ((this.targetType - 5)) << 2) & ((int)R8) >> 1152921504765685760) & ((int)R8) >> 1152921504765685760)));
                (14502724 + 4) + ((this.targetType - 5)) << 2 = ((14502724 + 4) + ((this.targetType - 5)) << 2) & ((R8) << 2);
                (14502724 + 4) + ((this.targetType - 5)) << 2 = ((14502724 + 4) + ((this.targetType - 5)) << 2) & (((int)R8) >> 1152921504765685760);
                (14502724 + 4) + ((this.targetType - 5)) << 2 = this * val_50;
            }
            
                if(this.target != 0)
            {
                    if(null != null)
            {
                
            }
            
            }
            
            }
        
        }
        public override void DOPlay()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.Play(targetOrId:  2098689376);
        }
        public override void DOPlayBackwards()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.PlayBackwards(targetOrId:  2098801376);
        }
        public override void DOPlayForward()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.PlayForward(targetOrId:  2098913376);
        }
        public override void DOPause()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.Pause(targetOrId:  2099025376);
        }
        public override void DOTogglePause()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.TogglePause(targetOrId:  2099137376);
        }
        public override void DORewind()
        {
            var val_5;
            var val_6;
            this._playCount = 0;
            UnityEngine.GameObject val_1 = this.gameObject;
            T[] val_2 = this.GetComponents<System.Object>();
            if(1152921511001064671 < 0)
            {
                    return;
            }
            
            val_5 = 1152921511001064675;
            goto label_4;
            label_11:
            val_5 = 1152921511001064674;
            label_4:
            val_6 = 1152921511001064670;
            if((R7 + 52) != 0)
            {
                    bool val_3 = DG.Tweening.TweenExtensions.IsInitialized(t:  R7 + 52);
                if(val_3 != false)
            {
                    DG.Tweening.TweenExtensions.Rewind(t:  val_3, includeDelay:  true);
            }
            
            }
            
            if(1152921511001064669 >= 0)
            {
                goto label_11;
            }
        
        }
        public override void DORestart(bool fromHere = False)
        {
            this._playCount = 0;
            if(true != 0)
            {
                    if(fromHere == true)
            {
                    true = this.isRelative;
            }
            
                if(true == true)
            {
                    true = this;
                this.ReEvaluateRelativeTween();
            }
            
                UnityEngine.GameObject val_1 = this.gameObject;
                int val_2 = DG.Tweening.DOTween.Restart(targetOrId:  2099362400, includeDelay:  true, changeDelayTo:  null);
                return;
            }
            
            if(DG.Tweening.Core.Debugger.logPriority < 2)
            {
                    return;
            }
            
            DG.Tweening.Core.Debugger.LogNullTween(t:  0);
        }
        public override void DOComplete()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.Complete(targetOrId:  2099474400, withCallbacks:  false);
        }
        public override void DOKill()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.Kill(targetOrId:  2099586400, complete:  false);
            mem[1152921511001400724] = 0;
        }
        public void DOPlayById(string id)
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.Play(target:  2099702496, id:  id);
        }
        public void DOPlayAllById(string id)
        {
            int val_1 = DG.Tweening.DOTween.Play(targetOrId:  id);
        }
        public void DOPauseAllById(string id)
        {
            int val_1 = DG.Tweening.DOTween.Pause(targetOrId:  id);
        }
        public void DOPlayBackwardsById(string id)
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.PlayBackwards(target:  2100063072, id:  id);
        }
        public void DOPlayBackwardsAllById(string id)
        {
            int val_1 = DG.Tweening.DOTween.PlayBackwards(targetOrId:  id);
        }
        public void DOPlayForwardById(string id)
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.PlayForward(target:  2100303456, id:  id);
        }
        public void DOPlayForwardAllById(string id)
        {
            int val_1 = DG.Tweening.DOTween.PlayForward(targetOrId:  id);
        }
        public void DOPlayNext()
        {
            T[] val_1 = this.GetComponents<System.Object>();
            do
            {
                if(this._playCount >= 1152921511002355039)
            {
                    return;
            }
            
                int val_2 = this._playCount + 1;
                this._playCount = val_2;
                DG.Tweening.DOTweenAnimation val_3 = this + (val_2 << 2);
            }
            while((val_2 == 0) || (((this._playCount + 1) + 52) == 0));
            
            if((DG.Tweening.TweenExtensions.IsPlaying(t:  (this._playCount + 1) + 52)) != true)
            {
                    if((DG.Tweening.TweenExtensions.IsComplete(t:  (this._playCount + 1) + 52)) != true)
            {
                    object val_7 = DG.Tweening.TweenExtensions.Play<System.Object>(t:  (this._playCount + 1) + 52);
            }
            
            }
        
        }
        public void DORewindAndPlayNext()
        {
            this._playCount = 0;
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.Rewind(targetOrId:  2100652768, includeDelay:  true);
            this.DOPlayNext();
        }
        public void DORestartById(string id)
        {
            this._playCount = 0;
            UnityEngine.GameObject val_1 = this.gameObject;
            int val_2 = DG.Tweening.DOTween.Restart(target:  2100768864, id:  id, includeDelay:  true, changeDelayTo:  null);
        }
        public void DORestartAllById(string id)
        {
            this._playCount = 0;
            int val_1 = DG.Tweening.DOTween.Restart(targetOrId:  id, includeDelay:  true, changeDelayTo:  null);
        }
        public System.Collections.Generic.List<DG.Tweening.Tween> GetTweens()
        {
            var val_3;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            T[] val_2 = this.GetComponents<System.Object>();
            val_3 = 0;
            goto label_1;
            label_6:
            Add(item:  R6 + 52);
            val_3 = 1;
            label_1:
            if(val_3 < null)
            {
                goto label_6;
            }
        
        }
        public static DG.Tweening.Core.TargetType TypeToDOTargetType(System.Type t)
        {
            string val_8;
            string val_9;
            val_8 = t;
            int val_1 = val_8.LastIndexOf(value:  1297836480);
            if(val_1 != 1)
            {
                    string val_3 = val_8.Substring(startIndex:  val_1 + 1);
                val_8 = val_8;
            }
            
            if((val_8.IndexOf(value:  2101097248)) != 1)
            {
                    if((System.String.op_Inequality(a:  val_8, b:  2101097344)) == false)
            {
                    val_9 = val_8;
            }
            
            }
            else
            {
                    val_9 = val_8;
            }
            
            System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(215015424)});
            object val_7 = System.Enum.Parse(enumType:  215015424, value:  val_9);
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        }
        private void ReEvaluateRelativeTween()
        {
            var val_9;
            var val_10;
            float val_11;
            var val_12;
            var val_13;
            bool val_14;
            if(this.animationType == 2)
            {
                goto label_1;
            }
            
            if(this.animationType != 1)
            {
                    return;
            }
            
            UnityEngine.Transform val_1 = this.transform;
            val_10 = 0;
            UnityEngine.Vector3 val_2 = position;
            val_11 = 1152921504762171392;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 1.580277E+37f}, b:  new UnityEngine.Vector3() {y = this.endValueV3, z = this});
            val_13 = null;
            if(35641871 == 0)
            {
                goto label_6;
            }
            
            val_12 = 1152921504803225600;
            goto label_11;
            label_1:
            UnityEngine.Transform val_6 = this.transform;
            val_10 = 0;
            UnityEngine.Vector3 val_7 = localPosition;
            val_11 = 1152921504762171392;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 1.580277E+37f}, b:  new UnityEngine.Vector3() {y = this.endValueV3, z = this});
            val_13 = null;
            val_12 = 1152921504803225600;
            val_14 = static_value_021FDA0F;
            label_6:
            label_11:
            val_9 = 0;
        }
        public DOTweenAnimation()
        {
            this.duration = 1f;
            this.easeType = 6;
            UnityEngine.Keyframe val_1 = new UnityEngine.Keyframe(time:  null, value:  null);
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_20 = val_1.m_WeightedMode;
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_24 = val_1.m_InWeight;
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_28 = val_1.m_Time;
            UnityEngine.Keyframe val_2 = new UnityEngine.Keyframe(time:  null, value:  null);
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_3C = val_2.m_WeightedMode;
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_40 = val_2.m_Time;
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_44 = val_2.m_Time;
            this.easeCurve = new UnityEngine.AnimationCurve(keys:  1544414176);
            this.loops = 1;
            this.id = "";
            this.autoKill = true;
            this.isActive = true;
            this.autoPlay = 1;
            UnityEngine.Color val_4 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            this.endValueString = "";
            UnityEngine.Rect val_5 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            this._playCount = 0;
        }
        private void <CreateTween>b__37_0()
        {
            mem[1152921511003284052] = 0;
        }
    
    }

}
