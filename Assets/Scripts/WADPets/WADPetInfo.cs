using UnityEngine;

namespace WADPets
{
    [Serializable]
    public class WADPetInfo
    {
        // Fields
        public WADPets.WADPetName Name;
        public WADPets.WADPetAbility Ability;
        public System.Collections.Generic.List<float> LevelCurveModifiers;
        public System.Collections.Generic.List<WADPets.WADPetLevelAbilityRange> LevelCurveModifierRanges;
        public UnityEngine.Sprite CardIcon;
        public UnityEngine.Sprite SadFaceIcon;
        public Spine.Unity.SkeletonDataAsset AnimIdleSkeletonDataAsset;
        
        // Methods
        public WADPetInfo()
        {
        
        }
    
    }

}
