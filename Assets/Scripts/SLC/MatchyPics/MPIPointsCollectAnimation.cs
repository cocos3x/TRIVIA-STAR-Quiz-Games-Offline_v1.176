using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPIPointsCollectAnimation : MonoSingleton<SLC.MatchyPics.MPIPointsCollectAnimation>, CollectAnimation
    {
        // Fields
        private const int INITIAL_POINTS_GO = 6;
        private UnityEngine.GameObject pointsParent;
        private AnimatedCoin pointSprite;
        private UnityEngine.GameObject chestReward;
        private TweenCoinsText pointsText;
        private UnityEngine.Transform CollectTarget;
        private float flyToDuration;
        private System.Collections.Generic.List<AnimatedCoin> currentPoints;
        private DG.Tweening.Sequence sequence;
        private bool updatingPointStats;
        
        // Methods
        public void Init()
        {
            int val_3;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10) != 0)
            {
                    public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance() = mem[public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 32];
                public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance() = public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 32;
            }
            
            if((public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10) == 0)
            {
                    public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance() = 0;
            }
            
            decimal val_2 = System.Decimal.op_Implicit(value:  794081608);
            this.pointsText.Set(instantValue:  new System.Decimal() {mid = val_3});
            SG.ResourceManager val_4 = SG.ResourceManager.Instance;
            UnityEngine.GameObject val_5 = this.pointSprite.gameObject;
            0.InitPool(poolPrefab:  this.pointSprite, size:  6, type:  1);
        }
        public void Play(System.Collections.Generic.List<UnityEngine.Vector3> pointsPath)
        {
            float val_11;
            float val_12;
            float val_13;
            SLC.MatchyPics.MPIPointsCollectAnimation val_15;
            var val_16;
            var val_17;
            val_15 = this;
            this.updatingPointStats = false;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.currentPoints = null;
            val_16 = 0;
            val_17 = 0;
            goto label_1;
            label_20:
            SG.ResourceManager val_2 = SG.ResourceManager.Instance;
            UnityEngine.GameObject val_3 = this.pointSprite.gameObject;
            UnityEngine.GameObject val_4 = 0.GetObjectFromPool(poolPrefab:  this.pointSprite, autoActive:  true, autoCreate:  0);
            object val_5 = 0.GetComponent<System.Object>();
            UnityEngine.Transform val_6 = 0.transform;
            UnityEngine.Transform val_7 = this.pointsParent.transform;
            0.SetParent(parent:  this.pointsParent, worldPositionStays:  false);
            UnityEngine.GameObject val_8 = 0.gameObject;
            0.SetActive(value:  true);
            0.Reset(grid:  794231248);
            UnityEngine.Transform val_9 = this.pointsParent.transform;
            if(this.pointsParent <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.Vector3 val_10 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.pointsParent, y = 13073.37f, z = 9.219563E-41f});
            UnityEngine.Transform val_14 = 0.transform;
            0.localPosition = new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_13};
            val_15 = val_15;
            Add(item:  0);
            val_17 = val_17 + 1;
            val_16 = 12;
            label_1:
            if(val_17 < this.currentPoints)
            {
                goto label_20;
            }
            
            this.AnimationSequence(stars:  80883712);
        }
        public void OnSparkle()
        {
        
        }
        public void OnCoinDeposited()
        {
            int val_3;
            if(this.updatingPointStats == true)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10) != 0)
            {
                    public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance() = mem[public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 32];
                public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance() = public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 32;
            }
            
            if((public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10) == 0)
            {
                    public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance() = 0;
            }
            
            decimal val_2 = System.Decimal.op_Implicit(value:  794463688);
            this.pointsText.CountUp(endValue:  new System.Decimal() {mid = val_3}, seconds:  null);
        }
        public void ShowRewardCollected(SLC.MatchyPics.MPIGridTile tile)
        {
            float val_4;
            float val_5;
            float val_9;
            float val_10;
            float val_11;
            var val_20;
            var val_21;
            object val_1 = new System.Object();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Vector3 val_3 = GetWordPosition(tile:  -852164608);
            UnityEngine.Transform val_7 = this.pointsParent.transform;
            UnityEngine.Vector3 val_8 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.pointsParent, y = val_4, z = val_5});
            UnityEngine.Transform val_12 = this.pointsParent.transform;
            object val_13 = UnityEngine.Object.Instantiate<System.Object>(original:  this.chestReward, parent:  this.pointsParent);
            if(val_1 != 0)
            {
                    val_20 = val_1;
                typeof(MPIPointsCollectAnimation.<>c__DisplayClass14_0).__il2cppRuntimeField_8 = this.chestReward;
            }
            else
            {
                    val_20 = 8;
                mem[8] = this.chestReward;
            }
            
            UnityEngine.Transform val_14 = val_20.transform;
            val_20.localPosition = new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_11};
            object val_15 = mem[8].GetComponent<System.Object>();
            DG.Tweening.Tweener val_16 = DG.Tweening.ShortcutExtensions46.DOFade(target:  mem[8], endValue:  val_8.x, duration:  val_8.y);
            object val_17 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  mem[8], delay:  val_8.x);
            DG.Tweening.TweenCallback val_18 = new DG.Tweening.TweenCallback(object:  439934976, method:  new IntPtr(794584208));
            System.Delegate val_19 = System.Delegate.Combine(a:  this.chestReward + 68, b:  190734336);
            val_21 = this.chestReward + 68;
            if(val_21 != 0)
            {
                    if(val_21 == null)
            {
                goto label_18;
            }
            
            }
            
            val_21 = 0;
            label_18:
            mem2[0] = val_21;
        }
        private void AnimationSequence(System.Collections.Generic.List<AnimatedCoin> stars)
        {
            float val_6;
            float val_7;
            float val_8;
            var val_20;
            var val_21;
            var val_23;
            if(new System.Object() != 0)
            {
                    typeof(MPIPointsCollectAnimation.<>c__DisplayClass15_0).__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[8] = this;
            }
            
            typeof(MPIPointsCollectAnimation.<>c__DisplayClass15_0).__il2cppRuntimeField_C = stars;
            val_20 = 0;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            this.sequence = 0;
            val_21 = 4;
            goto label_5;
            label_23:
            if((stars + 12) <= 35638289)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.Transform val_3 = stars + 8 + 16.transform;
            UnityEngine.Vector3 val_4 = position;
            UnityEngine.Vector3 val_5 = position;
            float val_9 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3(), b:  new UnityEngine.Vector3() {x = val_6, y = val_8, z = val_7});
            float val_21 = this.flyToDuration;
            if((stars + 12) <= 35638289)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_21 = R0 * val_21;
            stars + 8 + 16.PlaySparkle(delay:  0.25f);
            if((stars + 12) <= 35638289)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.Transform val_10 = stars + 8 + 16.transform;
            UnityEngine.Vector3 val_11 = position;
            DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions.DOMove(target:  stars + 8 + 16, endValue:  new UnityEngine.Vector3(), duration:  val_11.x, snapping:  val_21);
            object val_13 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  stars + 8 + 16, ease:  5);
            if((stars + 12) <= 35638289)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            DG.Tweening.TweenCallback val_14 = new DG.Tweening.TweenCallback(object:  stars + 8 + 16, method:  new IntPtr(107266816));
            object val_15 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  stars + 8 + 16, action:  190734336);
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.sequence, atPosition:  val_11.x, t:  0);
            val_21 = 5;
            val_20 = 0;
            label_5:
            System.Delegate val_17 = val_21 - 4;
            if(val_17 < (stars + 12))
            {
                goto label_23;
            }
            
            object val_18 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.sequence, delay:  val_11.x);
            DG.Tweening.TweenCallback val_19 = new DG.Tweening.TweenCallback(object:  439988224, method:  new IntPtr(794738192));
            System.Delegate val_20 = System.Delegate.Combine(a:  val_17, b:  190734336);
            val_23 = val_17;
            if(val_23 != 0)
            {
                    if(val_23 == null)
            {
                goto label_27;
            }
            
            }
            
            val_23 = 0;
            label_27:
            mem2[0] = val_23;
        }
        private void ReturnToPool(System.Collections.Generic.List<AnimatedCoin> stars)
        {
            UnityEngine.GameObject val_3;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_7:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            SG.ResourceManager val_4 = SG.ResourceManager.Instance;
            UnityEngine.GameObject val_5 = val_3.gameObject;
            0.ReturnObjectToPool(go:  val_3);
            goto label_7;
            label_2:
            Dispose();
        }
        public MPIPointsCollectAnimation()
        {
            this.flyToDuration = 0.25f;
        }
    
    }

}
