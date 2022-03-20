using UnityEngine;

namespace RestaurantRivals
{
    public class RESOutOfSpinPopup : MonoBehaviour
    {
        // Fields
        private const string ID_OOS1 = "restaurant_rivals_oos_free1";
        private const string ID_OOS2 = "restaurant_rivals_oos_free2";
        private UGUINetworkedButtonMultiGraphic purchaseButton;
        private UnityEngine.UI.Button closeButton;
        private UnityEngine.UI.Text spinsAmount;
        private UnityEngine.UI.Text priceLabel;
        private UnityEngine.UI.Text bottomTipTxt;
        private twelvegigs.storage.JsonDictionary package;
        private RestaurantRivals.RESOutOfSpinPopup.Source source;
        
        // Methods
        private void OnPurchaseOOS(bool connected)
        {
            var val_9;
            var val_10;
            var val_11;
            if(connected != false)
            {
                    if(this.source == 1)
            {
                    112 = 111;
            }
            
                var val_9 = 23889805;
                val_9 = 11736256 + val_9;
                if(val_9 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_9 = null;
                val_9 = null;
                PurchaseProxy.currentPurchasePoint = 111;
                PurchaseModel val_1 = new PurchaseModel(json:  this.package);
                bool val_2 = PurchaseProxy.Purchase(purchase:  292597760);
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_4 = ShowUGUIMonolith<System.Object>(showNext:  true);
            string val_5 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
            string val_6 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_7 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
            val_10 = null;
            val_11 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            if( == 0)
            {
                    val_11 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            }
            
            SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
            UnityEngine.GameObject val_8 = this.gameObject;
            SLCWindow.CloseWindow(window:  579938384, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnPurchaseCompleted(PurchaseModel purchase)
        {
            var val_7 = 35636855;
            if((System.String.op_Inequality(a:  purchase.id, b:  512971088)) != false)
            {
                    if((System.String.op_Inequality(a:  purchase.id, b:  512971216)) == true)
            {
                    return;
            }
            
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            decimal val_4 = Spins;
            public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_14.StartSpinGetEffects(spins:  System.Decimal.op_Explicit(value:  new System.Decimal()), recharge:  true);
            UnityEngine.GameObject val_6 = this.gameObject;
            SLCWindow.CloseWindow(window:  580070864, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnPurchaseFailure(PurchaseModel purchase)
        {
            RestaurantRivals.RESOutOfSpinPopup val_9;
            var val_10;
            var val_11;
            var val_12;
            decimal val_14;
            decimal val_15;
            var val_16;
            val_9 = this;
            val_10 = 0;
            decimal val_1 = Keys;
            val_11 = 1152921504617017344;
            val_12 = null;
            val_12 = null;
            val_14 = System.Decimal.Zero;
            if((System.Decimal.op_Equality(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_14})) == true)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_4 = ShowUGUIMonolith<System.Object>(showNext:  true);
            val_10 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            string val_5 = Localization.Localize(key:  -1349324784, defaultValue:  -1349324896, useSingularKey:  false);
            string val_6 = Localization.Localize(key:  -1349324672, defaultValue:  -1349324544, useSingularKey:  false);
            val_9 = null;
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            val_14 = null;
            string val_7 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
            val_16 = null;
            val_16 = null;
            val_15 = System.Decimal.MinusOne;
            SetupMessage(titleTxt:  -1349324784, messageTxt:  -1349324672, shownButtons:  1054454320, buttonTexts:  val_14, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = val_15, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
            UnityEngine.GameObject val_8 = this.gameObject;
            SLCWindow.CloseWindow(window:  580199248, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnClose()
        {
            bool val_23;
            var val_24;
            System.Action val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            val_23 = static_value_021FC679;
            if(val_23 != true)
            {
                    val_23 = true;
            }
            
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            if(16777216 != 0)
            {
                goto label_11;
            }
            
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            val_24 = 436207621;
            RestaurantRivals.RESGameEcon val_3 = RestaurantRivals.RESGameEcon.Instance;
            if(val_24 < 4)
            {
                goto label_11;
            }
            
            WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if(VideoEnabledAndUnlocked() == false)
            {
                goto label_11;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            RestaurantRivals.RESGameEcon val_8 = RestaurantRivals.RESGameEcon.Instance;
            if(Spins <= 0)
            {
                goto label_18;
            }
            
            label_11:
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_25 = Spins;
            if(val_25 >= SpinBet)
            {
                goto label_42;
            }
            
            val_25 = 1152921504901201920;
            val_24 = 1152921511026388688;
            WordPets.WPTDataParser val_12 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if(VideoEnabledAndUnlocked() == false)
            {
                goto label_42;
            }
            
            WordPets.WPTDataParser val_14 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if(rewardVideoCapReached == true)
            {
                goto label_42;
            }
            
            GameBehavior val_16 = App.getBehavior;
            if(this.source == 1)
            {
                    112 = 111;
            }
            
            HeyZapAdTag val_18 = AdsUIController.GetTagForPurchasePoint(entryPoint:  111);
            val_26 = 111;
            val_27 = null;
            if(this.source == 1)
            {
                    val_28 = null;
                val_29 = 1152921504891461992;
            }
            else
            {
                    val_30 = null;
                val_29 = 1152921504891461988;
            }
            
            if(0 != 0)
            {
                goto label_42;
            }
            
            goto label_42;
            label_18:
            twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_26 = 1152921505032937472;
            val_31 = null;
            val_31 = null;
            val_25 = RESOutOfSpinPopup.<>c.<>9__13_0;
            if(val_25 == 0)
            {
                    val_25 = null;
                val_25 = new System.Action(object:  RESOutOfSpinPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(580299536));
                RESOutOfSpinPopup.<>c.<>9__13_0 = val_25;
            }
            
            ShowFTUX(FTUXType:  11, onComplete:  7454720);
            label_42:
            UnityEngine.GameObject val_22 = this.gameObject;
            SLCWindow.CloseWindow(window:  580324560, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void Awake()
        {
            var val_7;
            System.Delegate val_8;
            var val_9;
            System.Action<twelvegigs.storage.JsonDictionary> val_10;
            System.Action<PurchaseModel> val_11;
            System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  580461248, method:  new IntPtr(580424848));
            mem2[0] = null;
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  580461248, method:  new IntPtr(580434064));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
            val_7 = null;
            val_7 = null;
            System.Action<twelvegigs.storage.JsonDictionary> val_3 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  580461248, method:  new IntPtr(580435088));
            val_8 = PurchasesHandler.OnPurchaseCompleted;
            System.Delegate val_4 = System.Delegate.Combine(a:  val_8, b:  7401472);
            val_9 = null;
            val_10 = null;
            if(val_8 == 0)
            {
                goto label_6;
            }
            
            if(null == val_10)
            {
                goto label_7;
            }
            
            val_10 = null;
            val_9 = 1152921504898486364;
            label_6:
            val_8 = 0;
            label_7:
            PurchasesHandler.OnPurchaseCompleted = val_8;
            val_10 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  580461248, method:  new IntPtr(580436112));
            System.Delegate val_6 = System.Delegate.Combine(a:  PurchasesHandler.OnPurchaseFailure, b:  7401472);
            val_11 = 0;
            if(PurchasesHandler.OnPurchaseFailure != 0)
            {
                    if(null != null)
            {
                    val_11 = 0;
            }
            else
            {
                    val_11 = PurchasesHandler.OnPurchaseFailure;
            }
            
            }
            
            PurchasesHandler.OnPurchaseFailure = val_11;
            this.InvokeRepeating(methodName:  580437136, time:  null, repeatRate:  null);
        }
        private void OnEnable()
        {
            bool val_7;
            var val_8;
            val_7 = static_value_021FC67B;
            if(val_7 != true)
            {
                    val_7 = true;
            }
            
            twelvegigs.storage.JsonDictionary val_1 = this.GetOOSPack();
            this.package = val_7;
            val_8 = null;
            val_8 = null;
            decimal val_2 = getDecimal(key:  1, defaultValue:  new System.Decimal() {flags = -1987367328, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_8, mid = System.Decimal.Powers10.__il2cppRuntimeField_C});
            decimal val_3 = new System.Decimal(value:  999999999);
            string val_4 = RestaurantRivals.RESGameEconHelper.FormatNumberWithLimit(num:  new System.Decimal(), numLimit:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.flags});
            string val_5 = -1467947360(-1467947360) + R0;
            string val_6 = PackagesManager.GetPackagePrice(package:  this.package);
            if(this.priceLabel != 0)
            {
                    return;
            }
        
        }
        private void OnDestroy()
        {
            var val_5;
            System.Delegate val_6;
            var val_7;
            System.Action<twelvegigs.storage.JsonDictionary> val_8;
            System.Delegate val_9;
            val_5 = null;
            val_5 = null;
            System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  580722112, method:  new IntPtr(580435088));
            val_6 = PurchasesHandler.OnPurchaseCompleted;
            System.Delegate val_2 = System.Delegate.Remove(source:  val_6, value:  7401472);
            val_7 = null;
            val_8 = null;
            if(val_6 == 0)
            {
                goto label_3;
            }
            
            if(null == val_8)
            {
                goto label_4;
            }
            
            val_8 = null;
            val_7 = 1152921504898486364;
            label_3:
            val_6 = 0;
            label_4:
            PurchasesHandler.OnPurchaseCompleted = val_6;
            val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  580722112, method:  new IntPtr(580436112));
            val_9 = PurchasesHandler.OnPurchaseFailure;
            System.Delegate val_4 = System.Delegate.Remove(source:  val_9, value:  7401472);
            if(val_9 != 0)
            {
                    if(null == null)
            {
                goto label_6;
            }
            
            }
            
            val_9 = 0;
            label_6:
            PurchasesHandler.OnPurchaseFailure = val_9;
        }
        public void Setup(bool isSpinButton)
        {
            this.source = isSpinButton;
        }
        private void UpdateBottonTip()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_2 = GetRechargeableSpinTimer();
            string val_3 = System.String.Format(format:  580926208, arg0:  -1825802336);
            if(this.bottomTipTxt == 0)
            {
                
            }
        
        }
        private twelvegigs.storage.JsonDictionary GetOOSPack()
        {
            var val_3;
            Player val_1 = App.Player;
            if(0 <= 4)
            {
                    val_3 = "restaurant_rivals_oos_free1";
                return PackagesManager.GetPackageById(packageId:  512971216);
            }
            
            val_3 = "restaurant_rivals_oos_free2";
            return PackagesManager.GetPackageById(packageId:  512971216);
        }
        public RESOutOfSpinPopup()
        {
        
        }
    
    }

}
