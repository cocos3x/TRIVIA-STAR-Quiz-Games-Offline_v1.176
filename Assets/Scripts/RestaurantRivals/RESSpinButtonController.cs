using UnityEngine;

namespace RestaurantRivals
{
    public class RESSpinButtonController : ARESUIController
    {
        // Fields
        public UnityEngine.GameObject SpinButtonGroup;
        private UnityEngine.GameObject spinButton;
        private UnityEngine.UI.Image buttonText;
        private UnityEngine.GameObject auto_spin_txt;
        private UnityEngine.CanvasGroup auto_spin_highlight;
        private UnityEngine.Sprite spinSprite;
        private UnityEngine.Sprite stopSprite;
        private UnityEngine.GameObject ftuxHand;
        private float pressTime;
        private bool validClick;
        private DG.Tweening.Tweener ftuxHandTweener;
        
        // Methods
        private void Start()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  661133264, name:  564891280);
            this.auto_spin_highlight.alpha = null;
            this.ShowFTUXHand(show:  false, inButton:  false);
            this.CheckAutoSpinUnlock();
        }
        private void Update()
        {
            UnityEngine.Sprite val_8;
            var val_9;
            if(this.validClick == false)
            {
                    return;
            }
            
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            val_8 = 1030672;
            RestaurantRivals.RESGameEcon val_2 = RestaurantRivals.RESGameEcon.Instance;
            if(val_8 < 786450)
            {
                    return;
            }
            
            float val_3 = UnityEngine.Time.deltaTime;
            uint val_8 = 0;
            val_8 = this.pressTime + val_8;
            this.pressTime = val_8;
            if(val_8 < 786450)
            {
                    return;
            }
            
            val_8 = this.stopSprite;
            this.buttonText.sprite = val_8;
            UnityEngine.GameObject val_4 = this.auto_spin_highlight.gameObject;
            this.auto_spin_highlight.SetActive(value:  true);
            DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.auto_spin_highlight, endValue:  val_8, duration:  null);
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            IsAutoSpin = true;
            val_9 = null;
            val_9 = null;
            if(RestaurantRivals.RESReelsController.spinStatus != 1)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Spin();
        }
        public void ShowFTUXHand(bool show, bool inButton = False)
        {
            var val_10;
            var val_11;
            val_10 = inButton;
            this.ftuxHand.SetActive(value:  show);
            if(show == false)
            {
                goto label_2;
            }
            
            UnityEngine.Transform val_1 = this.ftuxHand.transform;
            if(val_10 == false)
            {
                goto label_4;
            }
            
            val_11 = this.SpinButtonGroup;
            UnityEngine.Transform val_2 = val_11.transform;
            goto label_6;
            label_2:
            if(this.ftuxHandTweener == 0)
            {
                    return;
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  this.ftuxHandTweener, complete:  false);
            DG.Tweening.TweenExtensions.Complete(t:  this.ftuxHandTweener);
            this.ftuxHandTweener = 0;
            return;
            label_4:
            UnityEngine.Transform val_3 = this.transform;
            val_11 = this;
            UnityEngine.Transform val_4 = this.parent;
            label_6:
            this.ftuxHand.SetParent(p:  661422800);
            UnityEngine.Transform val_5 = this.ftuxHand.transform;
            val_10 = 0;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            this.ftuxHand.localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_7 = this.ftuxHand.transform;
            DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.ftuxHand, endValue:  val_6.x, duration:  val_6.y);
            object val_9 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.ftuxHand, loops:  0, loopType:  1);
            this.ftuxHandTweener = this.ftuxHand;
        }
        public void OnPointerDown()
        {
            var val_6;
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  0, aName:  655976416);
            val_6 = null;
            val_6 = null;
            if(RestaurantRivals.RESReelsController.spinStatus == 1)
            {
                    RestaurantRivals.RESReelsController.spinStatus = 0f;
                this.pressTime = RestaurantRivals.RESReelsController.spinStatus;
                RestaurantRivals.RESReelsController.spinStatus = true;
                this.validClick = RestaurantRivals.RESReelsController.spinStatus;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_3 = this.spinButton.transform;
            UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.spinButton, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  null, snapping:  true);
        }
        public void OnPointerUp()
        {
            UnityEngine.Sprite val_13;
            var val_14;
            float val_15;
            UnityEngine.Transform val_16;
            float val_17;
            float val_18;
            float val_19;
            this.ShowFTUXHand(show:  false, inButton:  false);
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  0, aName:  655976416);
            val_13 = 1152921504901095424;
            val_14 = 1152921511370979232;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(this.validClick == false)
            {
                goto label_8;
            }
            
            val_15 = 1f;
            if(this.validClick >= 0)
            {
                goto label_9;
            }
            
            label_8:
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            IsAutoSpin = false;
            val_13 = this.spinSprite;
            val_14 = 0;
            this.buttonText.sprite = val_13;
            UnityEngine.Transform val_4 = this.spinButton.transform;
            val_16 = this.spinButton;
            UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  val_15, y:  null, z:  this.pressTime);
            goto label_15;
            label_9:
            val_15 = 1f;
            if(this.validClick >= 0)
            {
                goto label_22;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_13 = 0;
            Spin();
            UnityEngine.Transform val_7 = this.spinButton.transform;
            UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  val_15, y:  null, z:  this.pressTime);
            DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.spinButton, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  val_15, snapping:  true);
            if(this.validClick == true)
            {
                goto label_22;
            }
            
            val_13 = 0;
            UnityEngine.Transform val_10 = this.spinButton.transform;
            val_16 = this.spinButton;
            UnityEngine.Vector3 val_11 = new UnityEngine.Vector3(x:  val_15, y:  null, z:  this.pressTime);
            label_15:
            DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_16, endValue:  new UnityEngine.Vector3() {x = val_17, y = val_18, z = val_19}, duration:  val_15, snapping:  true);
            label_22:
            this.validClick = false;
        }
        protected override void OnSpinEnded()
        {
            this.CheckAutoSpinUnlock();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_10) != 0)
            {
                    return;
            }
            
            R4.OnAutoSpinStopped();
        }
        protected override void OnSpinAmountUpdate()
        {
            if(RestaurantRivals.RESManager.IsGameStartFtuxFinished == false)
            {
                    return;
            }
            
            R4.ShowFTUXHand(show:  false, inButton:  false);
        }
        private void OnAutoSpinStopped()
        {
            this.buttonText.sprite = this.spinSprite;
            UnityEngine.Transform val_1 = this.spinButton.transform;
            UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.spinButton, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  null, snapping:  true);
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.auto_spin_highlight, endValue:  null, duration:  null);
            DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  662078032, method:  new IntPtr(662053008));
            object val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.auto_spin_highlight, action:  190734336);
        }
        private void CheckAutoSpinUnlock()
        {
            var val_9;
            System.Action val_11;
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESGameEcon val_2 = RestaurantRivals.RESGameEcon.Instance;
            if(1030672 >= 786450)
            {
                    0 = 1;
            }
            
            this.auto_spin_txt.SetActive(value:  true);
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESGameEcon val_4 = RestaurantRivals.RESGameEcon.Instance;
            if(1030672 != 786450)
            {
                    return;
            }
            
            RestaurantRivals.RESPlayer val_5 = RestaurantRivals.RESPlayer.Instance;
            if(16 != 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_9 = null;
            val_9 = null;
            val_11 = RESSpinButtonController.<>c.<>9__19_0;
            if(val_11 == 0)
            {
                    val_11 = null;
                val_11 = new System.Action(object:  RESSpinButtonController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(662186512));
                RESSpinButtonController.<>c.<>9__19_0 = val_11;
            }
            
            ShowFTUX(FTUXType:  10, onComplete:  7454720);
        }
        public RESSpinButtonController()
        {
        
        }
        private void <OnAutoSpinStopped>b__18_0()
        {
            UnityEngine.GameObject val_1 = this.auto_spin_highlight.gameObject;
            this.auto_spin_highlight.SetActive(value:  false);
        }
    
    }

}
