using UnityEngine;

namespace RestaurantRivals
{
    public class RESEventUIController : ARESUIController
    {
        // Fields
        private RestaurantRivals.RESEventIconListPanel eventListPanel;
        private RestaurantRivals.RESEventProgressBar eventProgressBar;
        private RestaurantRivals.RESEventPointsGainAnimator pointsGainedAnimator;
        private UnityEngine.Sprite iconAttackMadness;
        private UnityEngine.Sprite iconRaidMadness;
        private UnityEngine.Sprite iconHotNSpicy;
        private UnityEngine.Sprite iconRestaurantMaster;
        
        // Properties
        public RestaurantRivals.RESEventProgressBar EventProgressBar { get; }
        public UnityEngine.Sprite IconAttackMadness { get; }
        public UnityEngine.Sprite IconRaidMadness { get; }
        public UnityEngine.Sprite IconHotNSpicy { get; }
        public UnityEngine.Sprite IconRestaurantMaster { get; }
        
        // Methods
        public RestaurantRivals.RESEventProgressBar get_EventProgressBar()
        {
        
        }
        public UnityEngine.Sprite get_IconAttackMadness()
        {
        
        }
        public UnityEngine.Sprite get_IconRaidMadness()
        {
        
        }
        public UnityEngine.Sprite get_IconHotNSpicy()
        {
        
        }
        public UnityEngine.Sprite get_IconRestaurantMaster()
        {
        
        }
        public void QueuePointGainAnimation(int qty, System.Action onAnimationComplete, bool onlyAnimateProgressBar = False)
        {
            this.pointsGainedAnimator.ShowPointGainAnimation(qty:  qty, onAnimationComplete:  onAnimationComplete, onlyAnimateProgressBar:  onlyAnimateProgressBar);
        }
        public RESEventUIController()
        {
        
        }
    
    }

}
