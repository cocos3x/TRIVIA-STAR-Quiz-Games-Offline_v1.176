using UnityEngine;

namespace RestaurantRivals
{
    public class RESTripleBundlePopup : MonoBehaviour
    {
        // Fields
        private const string ID_Bundle_01 = "restaurant_rivals_oos_paid1";
        private const string ID_Bundle_02 = "restaurant_rivals_oos_paid2";
        private const string ID_Bundle_03 = "restaurant_rivals_oos_paid3";
        private UnityEngine.UI.Button closeButton;
        private UnityEngine.Transform bundleItemRoot;
        private RESTripleBundleItem[] bundleItems;
        private UnityEngine.UI.Text bottomTipTxt;
        private System.Collections.Generic.List<twelvegigs.storage.JsonDictionary> packs;
        private int currentPurchasePackIndex;
        
        // Methods
        private void Awake()
        {
            var val_13;
            var val_14;
            System.Delegate val_15;
            var val_16;
            System.Action<twelvegigs.storage.JsonDictionary> val_17;
            System.Delegate val_18;
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  669134208, method:  new IntPtr(669040576));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
            twelvegigs.storage.JsonDictionary val_2 = PackagesManager.GetPackageById(packageId:  512971344);
            this.packs.Add(item:  512971344);
            twelvegigs.storage.JsonDictionary val_3 = PackagesManager.GetPackageById(packageId:  512971472);
            this.packs.Add(item:  512971472);
            twelvegigs.storage.JsonDictionary val_4 = PackagesManager.GetPackageById(packageId:  512971600);
            this.packs.Add(item:  512971600);
            val_13 = 4;
            goto label_8;
            label_20:
            RESTripleBundleItem val_14 = this.bundleItems[0];
            if(this.packs <= 1152921511393417568)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            string val_5 = PackagesManager.GetPackagePrice(package:  2621443);
            if(2621443 <= 1152921511393417568)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            string val_7 = 2621443.getInt(key:  -1987367328, defaultValue:  0).ToString();
            System.Action<System.Boolean, System.Int32> val_8 = new System.Action<System.Boolean, System.Int32>(object:  669134208, method:  new IntPtr(669103040));
            val_14.Setup(packageIndex:  1152921511393417568, price:  2621443, reward:  669122168, onPurchaseClick:  null);
            val_13 = 5;
            label_8:
            if((val_13 - 4) < val_14)
            {
                goto label_20;
            }
            
            val_14 = null;
            val_14 = null;
            System.Action<twelvegigs.storage.JsonDictionary> val_10 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  669134208, method:  new IntPtr(669108160));
            val_15 = PurchasesHandler.OnPurchaseCompleted;
            System.Delegate val_11 = System.Delegate.Combine(a:  val_15, b:  7401472);
            val_16 = null;
            val_17 = null;
            if(val_15 == 0)
            {
                goto label_23;
            }
            
            if(null == val_17)
            {
                goto label_24;
            }
            
            val_17 = null;
            val_16 = 1152921504898486364;
            label_23:
            val_15 = 0;
            label_24:
            PurchasesHandler.OnPurchaseCompleted = val_15;
            val_17 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  669134208, method:  new IntPtr(669109184));
            val_18 = PurchasesHandler.OnPurchaseFailure;
            System.Delegate val_13 = System.Delegate.Combine(a:  val_18, b:  7401472);
            if(val_18 != 0)
            {
                    if(null == null)
            {
                goto label_26;
            }
            
            }
            
            val_18 = 0;
            label_26:
            PurchasesHandler.OnPurchaseFailure = val_18;
            this.InvokeRepeating(methodName:  580437136, time:  null, repeatRate:  null);
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
            System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  669319936, method:  new IntPtr(669108160));
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
            val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  669319936, method:  new IntPtr(669109184));
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
        private void UpdateBottonTip()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_2 = GetRechargeableSpinTimer();
            string val_3 = System.String.Format(format:  580926208, arg0:  -1825802336);
            if(this.bottomTipTxt == 0)
            {
                
            }
        
        }
        private void onPurchaseClick(bool connected, int index)
        {
            var val_9;
            var val_10;
            if(connected != false)
            {
                    this.currentPurchasePackIndex = index;
                if(true <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                connected = connected + (index << 2);
                PurchaseModel val_1 = new PurchaseModel(json:  (connected + (index) << 2) + 16);
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
            val_9 = null;
            val_10 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            if( == 0)
            {
                    val_10 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            }
            
            SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
            UnityEngine.GameObject val_8 = this.gameObject;
            SLCWindow.CloseWindow(window:  669556224, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnPurchaseCompleted(PurchaseModel purchase)
        {
            string val_7;
            string val_8;
            val_7 = purchase.id;
            if(true <= this.currentPurchasePackIndex)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + (this.currentPurchasePackIndex << 2);
            val_8 = mem[(0 + (this.currentPurchasePackIndex) << 2) + 16];
            val_8 = (0 + (this.currentPurchasePackIndex) << 2) + 16;
            string val_1 = val_8.getString(key:  1624646480, defaultValue:  1098586544);
            if((System.String.op_Inequality(a:  val_7, b:  val_8)) == true)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_8 = 0;
            decimal val_4 = Spins;
            public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_14.StartSpinGetEffects(spins:  System.Decimal.op_Explicit(value:  new System.Decimal()), recharge:  true);
            UnityEngine.GameObject val_6 = this.gameObject;
            SLCWindow.CloseWindow(window:  669684608, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnPurchaseFailure(PurchaseModel purchase)
        {
            RestaurantRivals.RESTripleBundlePopup val_9;
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
            SLCWindow.CloseWindow(window:  669812992, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnClose()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  669929088, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public RESTripleBundlePopup()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.packs = null;
            this.currentPurchasePackIndex = 0;
        }
    
    }

}
