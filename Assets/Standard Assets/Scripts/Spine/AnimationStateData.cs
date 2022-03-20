using UnityEngine;

namespace Spine
{
    public class AnimationStateData
    {
        // Fields
        internal Spine.SkeletonData skeletonData;
        private readonly System.Collections.Generic.Dictionary<Spine.AnimationStateData.AnimationPair, float> animationToMixTime;
        internal float defaultMix;
        
        // Properties
        public Spine.SkeletonData SkeletonData { get; }
        public float DefaultMix { get; set; }
        
        // Methods
        public Spine.SkeletonData get_SkeletonData()
        {
        
        }
        public float get_DefaultMix()
        {
            return (float)S0;
        }
        public void set_DefaultMix(float value)
        {
            this.defaultMix = ;
        }
        public AnimationStateData(Spine.SkeletonData skeletonData)
        {
            var val_4;
            Spine.SkeletonData val_2 = skeletonData;
            val_4 = null;
            val_4 = null;
            System.Collections.Generic.Dictionary<AnimationPair, System.Single> val_1 = new System.Collections.Generic.Dictionary<AnimationPair, System.Single>(comparer:  AnimationStateData.AnimationPairComparer.Instance);
            this.animationToMixTime = null;
            val_2 = new System.Object();
            if(val_2 != 0)
            {
                    this.skeletonData = val_2;
                return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  1882721888);
        }
        public void SetMix(string fromName, string toName, float duration)
        {
            string val_5;
            var val_6;
            Spine.Animation val_1 = this.skeletonData.FindAnimation(animationName:  fromName);
            if(this.skeletonData == 0)
            {
                goto label_2;
            }
            
            Spine.Animation val_2 = this.skeletonData.FindAnimation(animationName:  toName);
            if(this.skeletonData == 0)
            {
                goto label_4;
            }
            
            this.SetMix(from:  this.skeletonData, to:  this.skeletonData, duration:  duration);
            return;
            label_2:
            val_5 = fromName;
            val_6 = "Animation not found: ";
            goto label_5;
            label_4:
            val_5 = toName;
            val_6 = "Animation not found: ";
            label_5:
            string val_3 = 1869090752 + val_5;
            System.ArgumentException val_4 = new System.ArgumentException(message:  1869090752);
        }
        public void SetMix(Spine.Animation from, Spine.Animation to, float duration)
        {
            System.ArgumentNullException val_3;
            var val_4;
            var val_5;
            if(from == 0)
            {
                goto label_1;
            }
            
            if(to == 0)
            {
                goto label_2;
            }
            
            bool val_1 = this.animationToMixTime.Remove(key:  new AnimationPair() {a1 = from, a2 = to});
            this.animationToMixTime.Add(key:  new AnimationPair() {a1 = from, a2 = to}, value:  duration);
            return;
            label_1:
            val_3 = null;
            val_4 = "from";
            val_5 = "from cannot be null.";
            goto label_5;
            label_2:
            val_3 = null;
            val_4 = "to";
            val_5 = "to cannot be null.";
            label_5:
            val_3 = new System.ArgumentNullException(paramName:  1603926368, message:  1883003552);
        }
        public float GetMix(Spine.Animation from, Spine.Animation to)
        {
            System.ArgumentNullException val_4;
            var val_5;
            var val_6;
            if(from == 0)
            {
                goto label_1;
            }
            
            if(to == 0)
            {
                goto label_2;
            }
            
            bool val_2 = this.animationToMixTime.TryGetValue(key:  new AnimationPair() {a1 = from, a2 = to}, value: out  float val_1 = 2.361143E+29f);
            return (float)S0;
            label_1:
            val_4 = null;
            val_5 = "from";
            val_6 = "from cannot be null.";
            goto label_4;
            label_2:
            val_4 = null;
            val_5 = "to";
            val_6 = "to cannot be null.";
            label_4:
            val_4 = new System.ArgumentNullException(paramName:  1603926368, message:  1883003552);
        }
    
    }

}
