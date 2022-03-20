using UnityEngine;

namespace RestaurantRivals
{
    public class RESFrontUIController : ARESUIController
    {
        // Fields
        private CurrencyCollectAnimationInstantiator starAnimControl;
        private RestaurantRivals.RESShieldsTopUI _shieldsTopUI;
        private UnityEngine.RectTransform top;
        private UnityEngine.RectTransform bottom;
        private UnityEngine.RectTransform left;
        private UnityEngine.RectTransform right;
        private UnityEngine.GameObject settingNitification;
        private UnityEngine.UI.Text settingNitificationCountTxt;
        private UnityEngine.GameObject statViewAddButton;
        private UnityEngine.GameObject settingButton;
        public RestaurantRivals.RESStatViewStarCurrency StarCurrency;
        
        // Properties
        public RestaurantRivals.RESShieldsTopUI ShieldsTopUI { get; }
        
        // Methods
        public RestaurantRivals.RESShieldsTopUI get_ShieldsTopUI()
        {
        
        }
        public void Show()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.top)) != false)
            {
                    DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.top, endValue:  null, duration:  null, snapping:  false);
                object val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.top, ease:  27);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.bottom)) != false)
            {
                    DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.bottom, endValue:  null, duration:  null, snapping:  false);
                object val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.bottom, ease:  27);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.left)) != false)
            {
                    DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.left, endValue:  null, duration:  null, snapping:  false);
                object val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.left, ease:  27);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.right)) == false)
            {
                    return;
            }
            
            DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.right, endValue:  null, duration:  null, snapping:  false);
            object val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.right, ease:  27);
        }
        public void Hide()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.top)) != false)
            {
                    DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.top, endValue:  null, duration:  null, snapping:  false);
                object val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.top, ease:  26);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.bottom)) != false)
            {
                    DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  this.bottom, endValue:  null, duration:  null, snapping:  false);
                object val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.bottom, ease:  26);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.left)) != false)
            {
                    DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.left, endValue:  null, duration:  null, snapping:  false);
                object val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.left, ease:  26);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.right)) == false)
            {
                    return;
            }
            
            DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  this.right, endValue:  null, duration:  null, snapping:  false);
            object val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.right, ease:  26);
        }
        private void Start()
        {
            this.UpdateRestaurantNotification();
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  548887648, name:  548855328);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  548887648, name:  404738048);
            this.statViewAddButton.SetActive(value:  RestaurantRivals.RESManager.IsGameStartFtuxFinished);
            this.settingButton.SetActive(value:  RestaurantRivals.RESManager.IsGameStartFtuxFinished);
        }
        private void OnNewsStatusUpdated()
        {
            this.UpdateRestaurantNotification();
        }
        private void UpdateRestaurantNotification()
        {
            int val_13;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(CurrentForestContainsDamagedTrees == false)
            {
                goto label_4;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_5 = GetCurrentNumOfDamagedRestaurantItems();
            goto label_8;
            label_4:
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_13 = 0;
            if(GetNumOfCanBuyRestaurantItems() < 1)
            {
                goto label_12;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            label_8:
            val_13 = GetNumOfCanBuyRestaurantItems();
            label_12:
            val_13 = RestaurantRivals.RESNewsPopup.UnseenNewsCount + val_13;
            if(val_13 > 0)
            {
                    0 = 1;
            }
            
            this.settingNitification.SetActive(value:  true);
            string val_11 = val_13.ToString();
            if(this.settingNitificationCountTxt != 0)
            {
                    return;
            }
        
        }
        protected override void OnSpinEnded()
        {
            this.statViewAddButton.SetActive(value:  RestaurantRivals.RESManager.IsGameStartFtuxFinished);
            this.settingButton.SetActive(value:  RestaurantRivals.RESManager.IsGameStartFtuxFinished);
            this.UpdateRestaurantNotification();
        }
        public RESFrontUIController()
        {
        
        }
    
    }

}
