using UnityEngine;

namespace WordPets
{
    public class WordPet : MonoBehaviour
    {
        // Fields
        private const string IDLE_ANIMATION_NAME = "Idle";
        private const string FALL_ANIMATION_NAME = "Fall";
        private const string SQUASH_ANIMATION_NAME = "Squash";
        private const string RUN_ANIMATION_NAME = "Run";
        public bool disappear;
        private WordPets.WordPetRarity rarity;
        private WordPets.WordPetType type;
        private string petName;
        private float runSpeed;
        private float fallSpeed;
        private Spine.Unity.SkeletonGraphic skeletonGraphic;
        private Spine.Unity.SkeletonDataAsset idleAsset;
        private float idleTimeScale;
        private Spine.Unity.SkeletonDataAsset fallAsset;
        private float fallTimeScale;
        private Spine.Unity.SkeletonDataAsset runAsset;
        private float runTimeScale;
        private UnityEngine.Sprite portraitAsset;
        
        // Properties
        public WordPets.WordPetRarity getRarity { get; }
        public WordPets.WordPetType getType { get; }
        public string getName { get; }
        public float GetRunSpeed { get; }
        public float GetFallSpeed { get; }
        public float LandingDelay { get; }
        public UnityEngine.Sprite GetPortrait { get; }
        
        // Methods
        public WordPets.WordPetRarity get_getRarity()
        {
        
        }
        public WordPets.WordPetType get_getType()
        {
        
        }
        public string get_getName()
        {
        
        }
        public float get_GetRunSpeed()
        {
            return (float)S0;
        }
        public float get_GetFallSpeed()
        {
            return (float)S0;
        }
        public float get_LandingDelay()
        {
            Spine.SkeletonData val_1 = this.skeletonGraphic.skeletonDataAsset.GetSkeletonData(quiet:  true);
            Spine.Animation val_2 = this.skeletonGraphic.skeletonDataAsset.FindAnimation(animationName:  116792144);
            if(this.skeletonGraphic.skeletonDataAsset != 0)
            {
                    return (float)S0;
            }
            
            return (float)S0;
        }
        public UnityEngine.Sprite get_GetPortrait()
        {
        
        }
        public void AnimateIdle()
        {
            this.SwapSkeletonData(asset:  this.idleAsset, startAnimation:  -978841760, timescaleSpeed:  null);
        }
        public void AnimateFall()
        {
            this.SwapSkeletonData(asset:  this.fallAsset, startAnimation:  224430944, timescaleSpeed:  null);
        }
        public void AnimateSquash()
        {
            this.SwapSkeletonData(asset:  this.fallAsset, startAnimation:  116792144, timescaleSpeed:  null);
        }
        public void AnimateRun()
        {
            this.SwapSkeletonData(asset:  this.runAsset, startAnimation:  224671408, timescaleSpeed:  null);
        }
        public void Flip(bool faceRight)
        {
            this.skeletonGraphic.initialFlipX = faceRight ^ 1;
        }
        public void SetLooping(bool loop)
        {
            if(this.skeletonGraphic != 0)
            {
                goto label_0;
            }
            
            this.skeletonGraphic = this.skeletonGraphic;
            if(this.skeletonGraphic == 0)
            {
                goto label_1;
            }
            
            label_0:
            Spine.TrackEntry val_1 = this.skeletonGraphic.state.SetAnimation(trackIndex:  0, animationName:  this.skeletonGraphic.startingAnimation, loop:  loop);
            return;
            label_1:
        }
        private void SwapSkeletonData(Spine.Unity.SkeletonDataAsset asset, string startAnimation, float timescaleSpeed = 1)
        {
            this.skeletonGraphic.timeScale = R3;
            this.skeletonGraphic.skeletonDataAsset = asset;
            Spine.Unity.AtlasAsset val_1 = asset.atlasAssets[0];
            this.skeletonGraphic.material = asset.atlasAssets[0].materials[0];
            this.skeletonGraphic.startingAnimation = startAnimation;
            this.skeletonGraphic.Initialize(overwrite:  true);
        }
        public WordPet()
        {
            this.runSpeed = 900f;
            this.fallSpeed = 1400f;
            this.idleTimeScale = 1f;
            this.fallTimeScale = 1f;
            this.runTimeScale = 1f;
        }
    
    }

}
