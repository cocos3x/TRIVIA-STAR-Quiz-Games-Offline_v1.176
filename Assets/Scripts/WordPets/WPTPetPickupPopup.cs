using UnityEngine;

namespace WordPets
{
    public class WPTPetPickupPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button collectButton;
        private UnityEngine.GameObject timerGroup;
        private UnityEngine.UI.Text timerText;
        private UnityEngine.UI.Text rewardText;
        private UnityEngine.GameObject closeButton;
        private UnityEngine.Transform petGrid;
        private GridCoinCollectAnimationInstantiator coinAnimation;
        private WordPets.WPTCapturedPetDisplay petPrefab;
        
        // Methods
        public WPTPetPickupPopup()
        {
        
        }
    
    }

}
