using UnityEngine;

namespace Spine.Unity
{
    public class SkeletonAnimation : SkeletonRenderer, ISkeletonAnimation, IAnimationStateComponent
    {
        // Fields
        public Spine.AnimationState state;
        private Spine.Unity.UpdateBonesDelegate _UpdateLocal;
        private Spine.Unity.UpdateBonesDelegate _UpdateWorld;
        private Spine.Unity.UpdateBonesDelegate _UpdateComplete;
        private string _animationName;
        public bool loop;
        public float timeScale;
        
        // Properties
        public Spine.AnimationState AnimationState { get; }
        public string AnimationName { get; set; }
        
        // Methods
        public Spine.AnimationState get_AnimationState()
        {
        
        }
        protected void add__UpdateLocal(Spine.Unity.UpdateBonesDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this._UpdateLocal, b:  value);
            if(this._UpdateLocal == 0)
            {
                goto label_1;
            }
            
            val_2 = this._UpdateLocal;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this._UpdateLocal != 1152921510900460420)
            {
                goto label_3;
            }
        
        }
        protected void remove__UpdateLocal(Spine.Unity.UpdateBonesDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this._UpdateLocal, value:  value);
            if(this._UpdateLocal == 0)
            {
                goto label_1;
            }
            
            val_2 = this._UpdateLocal;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this._UpdateLocal != 1152921510900588804)
            {
                goto label_3;
            }
        
        }
        protected void add__UpdateWorld(Spine.Unity.UpdateBonesDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this._UpdateWorld, b:  value);
            if(this._UpdateWorld == 0)
            {
                goto label_1;
            }
            
            val_2 = this._UpdateWorld;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this._UpdateWorld != 1152921510900717192)
            {
                goto label_3;
            }
        
        }
        protected void remove__UpdateWorld(Spine.Unity.UpdateBonesDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this._UpdateWorld, value:  value);
            if(this._UpdateWorld == 0)
            {
                goto label_1;
            }
            
            val_2 = this._UpdateWorld;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this._UpdateWorld != 1152921510900845576)
            {
                goto label_3;
            }
        
        }
        protected void add__UpdateComplete(Spine.Unity.UpdateBonesDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this._UpdateComplete, b:  value);
            if(this._UpdateComplete == 0)
            {
                goto label_1;
            }
            
            val_2 = this._UpdateComplete;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this._UpdateComplete != 1152921510900973964)
            {
                goto label_3;
            }
        
        }
        protected void remove__UpdateComplete(Spine.Unity.UpdateBonesDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this._UpdateComplete, value:  value);
            if(this._UpdateComplete == 0)
            {
                goto label_1;
            }
            
            val_2 = this._UpdateComplete;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this._UpdateComplete != 1152921510901102348)
            {
                goto label_3;
            }
        
        }
        public void add_UpdateLocal(Spine.Unity.UpdateBonesDelegate value)
        {
            this.add__UpdateLocal(value:  value);
        }
        public void remove_UpdateLocal(Spine.Unity.UpdateBonesDelegate value)
        {
            this.remove__UpdateLocal(value:  value);
        }
        public void add_UpdateWorld(Spine.Unity.UpdateBonesDelegate value)
        {
            this.add__UpdateWorld(value:  value);
        }
        public void remove_UpdateWorld(Spine.Unity.UpdateBonesDelegate value)
        {
            this.remove__UpdateWorld(value:  value);
        }
        public void add_UpdateComplete(Spine.Unity.UpdateBonesDelegate value)
        {
            this.add__UpdateComplete(value:  value);
        }
        public void remove_UpdateComplete(Spine.Unity.UpdateBonesDelegate value)
        {
            this.remove__UpdateComplete(value:  value);
        }
        public string get_AnimationName()
        {
            float val_2;
            if(true != 0)
            {
                    val_2 = 0;
                Spine.TrackEntry val_1 = this.state.GetCurrent(trackIndex:  0);
                if(this.state == 0)
            {
                    return;
            }
            
                val_2 = this.state.data.defaultMix;
                return;
            }
            
            val_2 = 0;
            UnityEngine.Debug.LogWarning(message:  2000113504);
        }
        public void set_AnimationName(string value)
        {
            bool val_1 = System.String.op_Equality(a:  this._animationName, b:  value);
            if(val_1 == true)
            {
                    return;
            }
            
            this._animationName = value;
            if(val_1 == false)
            {
                goto label_2;
            }
            
            35647697 = this.state;
            if((System.String.IsNullOrEmpty(value:  value)) == false)
            {
                goto label_3;
            }
            
            35647697.ClearTrack(trackIndex:  0);
            return;
            label_2:
            UnityEngine.Debug.LogWarning(message:  2000246288);
            return;
            label_3:
            if(this.loop == true)
            {
                    this.loop = 1;
            }
            
            Spine.TrackEntry val_3 = 35647697.SetAnimation(trackIndex:  0, animationName:  value, loop:  true);
        }
        public static Spine.Unity.SkeletonAnimation AddToGameObject(UnityEngine.GameObject gameObject, Spine.Unity.SkeletonDataAsset skeletonDataAsset)
        {
            return Spine.Unity.SkeletonRenderer.AddSpineComponent<System.Object>(gameObject:  gameObject, skeletonDataAsset:  skeletonDataAsset);
        }
        public static Spine.Unity.SkeletonAnimation NewSkeletonAnimationGameObject(Spine.Unity.SkeletonDataAsset skeletonDataAsset)
        {
            return Spine.Unity.SkeletonRenderer.NewSpineGameObject<System.Object>(skeletonDataAsset:  skeletonDataAsset);
        }
        protected override void ClearState()
        {
            this.ClearState();
            if(this.state == 0)
            {
                    return;
            }
            
            this.state.ClearTracks();
        }
        public override void Initialize(bool overwrite)
        {
            Spine.AnimationStateData val_5 = 35647700;
            if(true != 0)
            {
                    if(overwrite == false)
            {
                    return;
            }
            
            }
            
            this.Initialize(overwrite:  overwrite);
            if(this == 0)
            {
                    return;
            }
            
            val_5 = mem[overwrite + 48];
            val_5 = overwrite + 48;
            if(val_5 == 0)
            {
                    Spine.SkeletonData val_1 = overwrite.GetSkeletonData(quiet:  false);
                val_5 = mem[overwrite + 48];
                val_5 = overwrite + 48;
            }
            
            this.state = new Spine.AnimationState(data:  val_5);
            if((System.String.IsNullOrEmpty(value:  this._animationName)) != false)
            {
                    return;
            }
            
            if(this.loop == true)
            {
                    this.loop = 1;
            }
            
            Spine.TrackEntry val_4 = this.state.SetAnimation(trackIndex:  0, animationName:  this._animationName, loop:  true);
            this.Update(deltaTime:  null);
        }
        private void Update()
        {
            this.Update(deltaTime:  UnityEngine.Time.deltaTime);
        }
        public void Update(float deltaTime)
        {
            if(this == 0)
            {
                    return;
            }
            
            float val_1 = this.timeScale * R1;
            R6.Update(delta:  R1);
            this.state.Update(delta:  R1);
            bool val_2 = this.state.Apply(skeleton:  val_1);
            if(this._UpdateLocal != 0)
            {
                    val_1 = this;
                this._UpdateLocal.Invoke(animated:  2001034752);
            }
            
            val_1.UpdateWorldTransform();
            if(this._UpdateWorld != 0)
            {
                    this._UpdateWorld.Invoke(animated:  2001034752);
                val_1.UpdateWorldTransform();
            }
            
            if(this._UpdateComplete == 0)
            {
                    return;
            }
            
            this._UpdateComplete.Invoke(animated:  2001034752);
        }
        public SkeletonAnimation()
        {
            this.timeScale = 1f;
        }
    
    }

}
