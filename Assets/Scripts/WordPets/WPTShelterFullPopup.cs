using UnityEngine;

namespace WordPets
{
    public class WPTShelterFullPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform petTransformLeft;
        private UnityEngine.Transform petTransformRight;
        private UGUINetworkedButton lowPackageButton;
        private UGUINetworkedButton highPackageButton;
        private UnityEngine.UI.Text coinAmount1;
        private UnityEngine.UI.Text packagePrice1;
        private UnityEngine.UI.Text coinAmount2;
        private UnityEngine.UI.Text packagePrice2;
        private UnityEngine.UI.Text freeCoinAmount;
        private GridCoinCollectAnimationInstantiator coinAnimation;
        private PurchaseModel purchasePackLow;
        private PurchaseModel purchasePackHigh;
        private PurchaseModel purchasedPackage;
        
        // Methods
        private void Awake()
        {
            System.Action<System.Boolean> val_6;
            System.Action<System.Boolean> val_7;
            this.SetPets();
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  219358000, name:  219315456);
            System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  219358000, method:  new IntPtr(219323760));
            System.Delegate val_3 = System.Delegate.Combine(a:  this.lowPackageButton.OnConnectionClick, b:  7401472);
            val_6 = this.lowPackageButton.OnConnectionClick;
            if(val_6 != 0)
            {
                    if(null == null)
            {
                goto label_7;
            }
            
            }
            
            val_6 = 0;
            label_7:
            this.lowPackageButton.OnConnectionClick = val_6;
            System.Action<System.Boolean> val_4 = new System.Action<System.Boolean>(object:  219358000, method:  new IntPtr(219332976));
            System.Delegate val_5 = System.Delegate.Combine(a:  this.highPackageButton.OnConnectionClick, b:  7401472);
            val_7 = this.highPackageButton.OnConnectionClick;
            if(val_7 != 0)
            {
                    if(null == null)
            {
                goto label_11;
            }
            
            }
            
            val_7 = 0;
            label_11:
            this.highPackageButton.OnConnectionClick = val_7;
        }
        private void OnEnable()
        {
            this.SetPackagePrices();
        }
        private void OnBuyLowPackage(bool result)
        {
            this.BuyPackage(result:  result, package:  this.purchasePackLow);
        }
        private void OnBuyHighPackage(bool result)
        {
            this.BuyPackage(result:  result, package:  this.purchasePackHigh);
        }
        private void BuyPackage(bool result, PurchaseModel package)
        {
            var val_9;
            System.Func<System.Boolean> val_11;
            var val_12;
            if(result != false)
            {
                    this.purchasedPackage = package;
                WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
                Purchase(purchase:  package);
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_3 = ShowUGUIMonolith<System.Object>(showNext:  true);
            string val_4 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
            string val_5 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_6 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
            val_9 = null;
            val_9 = null;
            val_11 = WPTShelterFullPopup.<>c.<>9__17_0;
            if(val_11 == 0)
            {
                    val_11 = null;
                val_11 = new System.Func<System.Boolean>(object:  WPTShelterFullPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(219818864));
                WPTShelterFullPopup.<>c.<>9__17_0 = val_11;
            }
            
            typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_11;
            val_12 = null;
            val_12 = null;
            SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
            UnityEngine.GameObject val_8 = this.gameObject;
            this.SetActive(value:  false);
        }
        private void OnPurchaseCompleted()
        {
            int val_7;
            int val_10;
            var val_12;
            GameEcon val_1 = App.getGameEcon;
            if(0 != 0)
            {
                    val_12 = null;
            }
            
            val_12 = null;
            if((((mem[1179403747] + (WordPets.WPTGameEcon.__il2cppRuntimeField_typeHierarchyDepth) << 2) - 4)) != val_12)
            {
                    0 = 0;
            }
            
            Player val_2 = App.Player;
            0.AddCredits(amount:  new System.Decimal() {flags = 5761501, hi = 348, lo = 786450, mid = 1282}, source:  "", subSource:  0, externalParams:  0, doTrack:  true);
            System.Action val_3 = new System.Action(object:  219973296, method:  new IntPtr(219940080));
            this.coinAnimation.OnCompleteCallback = null;
            Player val_4 = App.Player;
            decimal val_5 = Credits;
            decimal val_6 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 219961228, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
            decimal val_8 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 219961212}, d2:  new System.Decimal() {flags = val_7, hi = 5761501, lo = 348, mid = 786450});
            Player val_9 = App.Player;
            this.coinAnimation.Play(fromValue:  new System.Decimal() {mid = val_10}, toValue:  new System.Decimal() {flags = 52}, textTickTime:  null, delayBeforeComplete:  null);
        }
        private void OnCoinAnimationCompleted()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            this.SetActive(value:  false);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        private void SetPackagePrices()
        {
            PurchaseModel val_9;
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            System.Collections.Generic.List<PurchaseModel> val_2 = RetrievePurchasePacks();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_9 = mem[public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance().__il2cppRuntimeField_8 + 20];
            val_9 = public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance().__il2cppRuntimeField_8 + 20;
            this.purchasePackLow = val_9;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_9 = this.purchasePackLow;
            this.purchasePackHigh = public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance().__il2cppRuntimeField_8 + 28;
            decimal val_3 = Credits;
            string val_4 = ToString();
            string val_5 = this.purchasePackLow.LocalPrice;
            decimal val_6 = Credits;
            string val_7 = ToString();
            string val_8 = this.purchasePackHigh.LocalPrice;
            if(this.packagePrice2 != 0)
            {
                    return;
            }
        
        }
        private void SetPets()
        {
            var val_16;
            var val_17;
            var val_18;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordPets.WPTGameMode val_2 = currentGame;
            System.Collections.Generic.List<WordPets.WordPetType> val_3 = new System.Collections.Generic.List<WordPets.WordPetType>(collection:  public static WordPets.WordPetsController MonoSingleton<WordPets.WordPetsController>::get_Instance().__il2cppRuntimeField_14);
            if(null != 0)
            {
                    val_16 = null;
                val_17 = UnityEngine.Random.Range(min:  0, max:  1094062064);
            }
            else
            {
                    val_16 = 12;
                val_17 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            
            if(val_16 <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(null != 0)
            {
                    bool val_6 = Remove(item:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_5) << 2) + 16);
                val_18 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            else
            {
                    bool val_8 = Remove(item:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_5) << 2) + 16);
                val_18 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            
            if(0 <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_12 = UnityEngine.Object.Instantiate<System.Object>(original:  (public static WordPets.WPTShelterController MonoSingleton<WordPets.WPTShelterController>::get_Instance().__il2cppRuntimeField_C + ((System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val + 16, parent:  this.petTransformLeft);
            (public static WordPets.WPTShelterController MonoSingleton<WordPets.WPTShelterController>::get_Instance().__il2cppRuntimeField_C + ((System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val + 16.AnimateIdle();
            twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_15 = UnityEngine.Object.Instantiate<System.Object>(original:  (public static WordPets.WPTShelterController MonoSingleton<WordPets.WPTShelterController>::get_Instance().__il2cppRuntimeField_C + ((System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val + 16, parent:  this.petTransformRight);
            (public static WordPets.WPTShelterController MonoSingleton<WordPets.WPTShelterController>::get_Instance().__il2cppRuntimeField_C + ((System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val + 16.AnimateIdle();
        }
        public void OnCloseButtonClicked()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordPets.WPTGameMode val_2 = currentGame;
            UnityEngine.GameObject val_3 = this.gameObject;
            this.SetActive(value:  false);
        }
        public WPTShelterFullPopup()
        {
        
        }
    
    }

}
