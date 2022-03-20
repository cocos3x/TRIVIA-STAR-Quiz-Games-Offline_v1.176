using UnityEngine;

namespace RestaurantRivals
{
    public class RESHeadChefController : ARESUIController
    {
        // Fields
        public UnityEngine.RectTransform HeadshotPos;
        private UnityEngine.Transform headChefObj;
        private UnityEngine.UI.Image headshotImage;
        private UnityEngine.UI.Text nameTxt;
        private UnityEngine.UI.Text coinAmountTxt;
        private UnityEngine.GameObject bet;
        private UnityEngine.UI.Text betTxt;
        private UnityEngine.GameObject Profile_head;
        
        // Methods
        private void OnEnable()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(SpinBet == 1)
            {
                    this.HideBet();
            }
            else
            {
                    this.ShowBet();
            }
            
            this.Profile_head.SetActive(value:  true);
        }
        private void SetupHeadChef(UnityEngine.Sprite headshot, string name, decimal coinAmount)
        {
            this.headshotImage.sprite = headshot;
            decimal val_1 = new System.Decimal(value:  999999999);
            string val_2 = RestaurantRivals.RESGameEconHelper.FormatNumberWithLimit(num:  new System.Decimal() {flags = coinAmount.flags, hi = coinAmount.hi, lo = coinAmount.lo, mid = coinAmount.mid}, numLimit:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.flags});
            if(this.coinAmountTxt != 0)
            {
                    return;
            }
        
        }
        public void ChangeHeadChef()
        {
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.headChefObj, endValue:  null, duration:  null, snapping:  false);
            object val_2 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.headChefObj, ease:  26);
            DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  561062224, method:  new IntPtr(561037200));
            object val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.headChefObj, action:  190734336);
        }
        public void HideBet()
        {
            this.bet.SetActive(value:  false);
        }
        public void ShowBet()
        {
            this.bet.SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_3 = SpinBet.ToString();
            string val_4 = 520034112 + 561294684;
            if(this.betTxt != 0)
            {
                    return;
            }
        
        }
        public void ShowProfileHead(bool show)
        {
            this.Profile_head.SetActive(value:  show);
        }
        public RESHeadChefController()
        {
        
        }
        private void <ChangeHeadChef>b__10_0()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Sprite val_3 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C.GetAvatarSpriteByID(id:  public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_24 + 12);
            this.SetupHeadChef(headshot:  public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C, name:  public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_24 + 16, coinAmount:  new System.Decimal() {flags = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_24 + 28, hi = mem[(public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_24 + 32) + (0)], lo = mem[(public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_24 + 32) + (4)], mid = mem[(public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_24 + 32) + (8)]});
            DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.headChefObj, endValue:  null, duration:  null, snapping:  false);
            object val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.headChefObj, ease:  27);
        }
    
    }

}
