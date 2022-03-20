using UnityEngine;

namespace Spine.Unity
{
    public class SkeletonAnimator : SkeletonRenderer, ISkeletonAnimation
    {
        // Fields
        protected Spine.Unity.SkeletonAnimator.MecanimTranslator translator;
        private Spine.Unity.UpdateBonesDelegate _UpdateLocal;
        private Spine.Unity.UpdateBonesDelegate _UpdateWorld;
        private Spine.Unity.UpdateBonesDelegate _UpdateComplete;
        
        // Properties
        public Spine.Unity.SkeletonAnimator.MecanimTranslator Translator { get; }
        
        // Methods
        public Spine.Unity.SkeletonAnimator.MecanimTranslator get_Translator()
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
            if(this._UpdateLocal != 1152921510903221988)
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
            if(this._UpdateLocal != 1152921510903350372)
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
            if(this._UpdateWorld != 1152921510903478760)
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
            if(this._UpdateWorld != 1152921510903607144)
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
            if(this._UpdateComplete != 1152921510903735532)
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
            if(this._UpdateComplete != 1152921510903863916)
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
        public override void Initialize(bool overwrite)
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_4 = this;
            val_5 = overwrite;
            val_6 = 35647707;
            if(true != 0)
            {
                    if(val_5 == false)
            {
                    return;
            }
            
            }
            
            R4.Initialize(overwrite:  R5);
            if((R4 + 76) == 0)
            {
                    return;
            }
            
            val_7 = mem[R4 + 96];
            val_7 = R4 + 96;
            if(val_7 == 0)
            {
                    SkeletonAnimator.MecanimTranslator val_1 = null;
                val_7 = val_1;
                val_1 = new SkeletonAnimator.MecanimTranslator();
                mem2[0] = val_7;
            }
            
            object val_2 = R4.GetComponent<System.Object>();
            Initialize(animator:  R4, skeletonDataAsset:  R4 + 20);
        }
        public void Update()
        {
            if(this == 0)
            {
                    return;
            }
            
            this.translator.Apply(skeleton:  R5);
            if(this._UpdateLocal != 0)
            {
                    R5 = this;
                this._UpdateLocal.Invoke(animated:  2003020288);
            }
            
            R5.UpdateWorldTransform();
            if(this._UpdateWorld != 0)
            {
                    this._UpdateWorld.Invoke(animated:  2003020288);
                R5.UpdateWorldTransform();
            }
            
            if(this._UpdateComplete == 0)
            {
                    return;
            }
            
            this._UpdateComplete.Invoke(animated:  2003020288);
        }
        public SkeletonAnimator()
        {
        
        }
    
    }

}
