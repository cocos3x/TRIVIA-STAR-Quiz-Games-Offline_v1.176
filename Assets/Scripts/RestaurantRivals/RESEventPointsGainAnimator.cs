using UnityEngine;

namespace RestaurantRivals
{
    public class RESEventPointsGainAnimator : MonoBehaviour
    {
        // Fields
        private UnityEngine.CanvasGroup pointsIconCanvasGroup;
        private UnityEngine.RectTransform radialRayTransform;
        private UnityEngine.RectTransform pointsIconRootTransform;
        
        // Properties
        private RestaurantRivals.RESEventProgressBar EventProgressBar { get; }
        
        // Methods
        private RestaurantRivals.RESEventProgressBar get_EventProgressBar()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        public void ShowPointGainAnimation(int qty, System.Action onAnimationComplete, bool onlyAnimateProgressBar = False)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            BlockRaycasts = true;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            RestaurantRivals.RESEventProgressBar val_3 = EventProgressBar;
            UnityEngine.Transform val_4 = transform;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = null;
            UnityEngine.Transform val_5 = this.transform;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_14 = this;
            ShowOverlay(contentToOverlay:  -2028557104);
            if(onlyAnimateProgressBar != false)
            {
                    System.Collections.IEnumerator val_6 = this.ShowProgressBarAnimationCoroutine(onAnimationComplete:  onAnimationComplete);
            }
            else
            {
                    System.Collections.IEnumerator val_7 = this.ShowPointGainAnimationCoroutine(qty:  qty, onAnimationComplete:  onAnimationComplete);
            }
            
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  533620896);
        }
        private System.Collections.IEnumerator ShowProgressBarAnimationCoroutine(System.Action onAnimationComplete)
        {
            typeof(RESEventPointsGainAnimator.<ShowProgressBarAnimationCoroutine>d__6).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(RESEventPointsGainAnimator.<ShowProgressBarAnimationCoroutine>d__6).__il2cppRuntimeField_14 = this;
            }
            else
            {
                    mem[20] = this;
            }
            
            typeof(RESEventPointsGainAnimator.<ShowProgressBarAnimationCoroutine>d__6).__il2cppRuntimeField_10 = onAnimationComplete;
        }
        private System.Collections.IEnumerator ShowPointGainAnimationCoroutine(int qty, System.Action onAnimationComplete)
        {
            typeof(RESEventPointsGainAnimator.<ShowPointGainAnimationCoroutine>d__7).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(RESEventPointsGainAnimator.<ShowPointGainAnimationCoroutine>d__7).__il2cppRuntimeField_10 = this;
                typeof(RESEventPointsGainAnimator.<ShowPointGainAnimationCoroutine>d__7).__il2cppRuntimeField_14 = qty;
            }
            else
            {
                    mem[16] = this;
                mem[20] = qty;
            }
            
            typeof(RESEventPointsGainAnimator.<ShowPointGainAnimationCoroutine>d__7).__il2cppRuntimeField_18 = onAnimationComplete;
        }
        private void OnIndividualPointIconAnimComplete(UnityEngine.GameObject pointObj)
        {
            UnityEngine.Object.Destroy(obj:  pointObj);
            RestaurantRivals.RESEventProgressBar val_1 = pointObj.EventProgressBar;
            UnityEngine.RectTransform val_2 = pointObj.rectTransform;
            UnityEngine.Vector3 val_3 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  pointObj, punch:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  null, vibrato:  1036831949, elasticity:  null);
        }
        public RESEventPointsGainAnimator()
        {
        
        }
    
    }

}
