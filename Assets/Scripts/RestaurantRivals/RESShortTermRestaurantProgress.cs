using UnityEngine;

namespace RestaurantRivals
{
    public class RESShortTermRestaurantProgress : MonoBehaviour
    {
        // Fields
        public GoldenApplesParticles ShortTermProgressEffects;
        private UnityEngine.UI.Text shortTermProgressText;
        private UnityEngine.UI.Slider progressBarSlider;
        private UnityEngine.CanvasGroup glow;
        private RestaurantRivals.RESRestaurantContent restaurantContent;
        private int activeObjects;
        private int totalNeeds;
        
        // Methods
        public void PlayEffects(UnityEngine.GameObject origin, int particlesAmount)
        {
            this.ShortTermProgressEffects.SetOrigin(originObject:  origin);
            this.ShortTermProgressEffects.PlayParticles(particleCount:  particlesAmount, animateStatView:  true);
            System.Collections.IEnumerator val_1 = this.CollectStartToProgressBar(dealy:  null);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  646868208);
        }
        public void PlayFixEffects(UnityEngine.GameObject origin, int particlesAmount)
        {
            this.ShortTermProgressEffects.SetOrigin(originObject:  origin);
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_2 = public static RestaurantRivals.RESRestaurantUI MonoSingleton<RestaurantRivals.RESRestaurantUI>::get_Instance().__il2cppRuntimeField_24 + 52.transform;
            UnityEngine.Vector3 val_3 = position;
            this.ShortTermProgressEffects.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  particlesAmount, animateStatView:  true);
            System.Collections.IEnumerator val_4 = this.ShortTermProgressEffects.CollectStartToTop(dealy:  val_3.x);
            UnityEngine.Coroutine val_5 = this.ShortTermProgressEffects.StartCoroutine(routine:  this.ShortTermProgressEffects);
        }
        public void SetProgress(RestaurantRivals.RESRestaurantContent restaurantContent)
        {
            this.restaurantContent = restaurantContent;
            this.GetProgressNumber();
            string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            float val_2 = (float)this.totalNeeds;
            val_2 = (float)this.activeObjects / val_2;
        }
        private System.Collections.IEnumerator CollectStartToProgressBar(float dealy = 0)
        {
            typeof(RESShortTermRestaurantProgress.<CollectStartToProgressBar>d__10).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(RESShortTermRestaurantProgress.<CollectStartToProgressBar>d__10).__il2cppRuntimeField_10 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            typeof(RESShortTermRestaurantProgress.<CollectStartToProgressBar>d__10).__il2cppRuntimeField_14 = R1;
        }
        private System.Collections.IEnumerator CollectStartToTop(float dealy = 0)
        {
            object val_1 = new System.Object();
            typeof(RESShortTermRestaurantProgress.<CollectStartToTop>d__11).__il2cppRuntimeField_8 = 0;
            typeof(RESShortTermRestaurantProgress.<CollectStartToTop>d__11).__il2cppRuntimeField_10 = R1;
        }
        private void GetProgressNumber()
        {
            RestaurantRivals.RESRestaurantContent val_6;
            int val_7;
            int val_8;
            int val_9;
            val_6 = this.restaurantContent;
            if(val_6 != 0)
            {
                    val_7 = this.restaurantContent.<NumObjectsActive>k__BackingField;
            }
            else
            {
                    val_7 = this.restaurantContent.<NumObjectsActive>k__BackingField;
                val_6 = this.restaurantContent;
                if(val_6 == 0)
            {
                goto label_13;
            }
            
            }
            
            label_13:
            int val_1 = val_6.TotalObjectsToGetCustomer(customerIndex:  this.restaurantContent.<NumCustomerStagesActive>k__BackingField);
            val_1 = val_7 - val_1;
            this.activeObjects = val_1;
            if(this.restaurantContent != 0)
            {
                    val_8 = this.restaurantContent.<NumCustomerStagesActive>k__BackingField;
            }
            else
            {
                    val_8 = 2621448;
            }
            
            if(this.restaurantContent != 0)
            {
                    val_9 = this.restaurantContent.<NumCustomerStagesActive>k__BackingField;
            }
            else
            {
                    val_9 = 2621448;
            }
            
            int val_3 = this.restaurantContent.TotalObjectsToGetCustomer(customerIndex:  2621448);
            val_3 = (this.restaurantContent.TotalObjectsToGetCustomer(customerIndex:  2621449)) - val_3;
            this.totalNeeds = val_3;
            RestaurantRivals.RESPlayer val_4 = RestaurantRivals.RESPlayer.Instance;
            mem[12] = this.activeObjects;
            Player val_5 = App.Player;
            0.SaveState();
        }
        public RESShortTermRestaurantProgress()
        {
        
        }
        private void <CollectStartToProgressBar>b__10_0()
        {
            UnityEngine.Transform val_1 = this.shortTermProgressText.transform;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.shortTermProgressText, endValue:  null, duration:  null);
        }
        private void <CollectStartToProgressBar>b__10_1()
        {
            UnityEngine.Transform val_1 = this.shortTermProgressText.transform;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.shortTermProgressText, endValue:  null, duration:  null);
        }
    
    }

}
