using UnityEngine;

namespace SLC.Social.Leagues
{
    public class WGClubMultiplierPopup : MonoBehaviour
    {
        // Fields
        private static readonly decimal maxMultiplier;
        private TweenCoinsText statviewText;
        private UnityEngine.UI.Text currentMultiplierText;
        private UnityEngine.UI.Text[] multiplierTexts;
        private UnityEngine.UI.Text[] costTexts;
        private UGUINetworkedButtonMultiGraphic[] multiplierButtons;
        private UnityEngine.UI.Button closeButton;
        private UnityEngine.UI.Button storeButton;
        private UnityEngine.ParticleSystem trailParticles;
        private UnityEngine.ParticleSystem burstParticles;
        private UnityEngine.UI.Image currentMultiplierOverlay;
        private decimal costScale;
        private decimal currentMultiplier;
        private System.Decimal[] multiplierValues;
        private int currentIndex;
        private TrackerPurchasePoints purchasePoint;
        
        // Methods
        private void Awake()
        {
            var val_8;
            UGUINetworkedButtonMultiGraphic val_9;
            var val_10;
            val_8 = null;
            val_8 = null;
            this.multiplierValues = SLC.Social.Leagues.LeaguesEconomy.MultiplierOptions;
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  889617648, method:  new IntPtr(889300784));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  889617648, method:  new IntPtr(889310000));
            this.storeButton.m_OnClick.AddListener(call:  162246656);
            UGUINetworkedButtonMultiGraphic val_8 = this.multiplierButtons[0];
            System.Action<System.Boolean> val_3 = new System.Action<System.Boolean>(object:  889617648, method:  new IntPtr(889351984));
            mem2[0] = null;
            UGUINetworkedButtonMultiGraphic val_9 = this.multiplierButtons[1];
            System.Action<System.Boolean> val_4 = new System.Action<System.Boolean>(object:  889617648, method:  new IntPtr(889393968));
            mem2[0] = null;
            UGUINetworkedButtonMultiGraphic val_10 = this.multiplierButtons[2];
            System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  889617648, method:  new IntPtr(889435952));
            mem2[0] = null;
            val_9 = this.multiplierButtons[3];
            System.Action<System.Boolean> val_6 = new System.Action<System.Boolean>(object:  889617648, method:  new IntPtr(889477936));
            mem2[0] = null;
            val_10 = 0;
            goto label_19;
            label_26:
            decimal val_12 = this.multiplierValues[val_10];
            string val_7 = val_12.FormatMultiplierString(multiplier:  new System.Decimal() {flags = mem[this.multiplierValues[0x0][0x10] + (0)], hi = mem[this.multiplierValues[0x0][0x10] + (4)], lo = mem[this.multiplierValues[0x0][0x10] + (8)], mid = val_12});
            val_9 = val_12;
            val_10 = 1;
            label_19:
            if(val_10 < this.multiplierTexts[val_10])
            {
                goto label_26;
            }
            
            this.UpdateCurrentMultiplier(animate:  false);
            this.UpdateMultiplierCosts();
            this.ToggleButtonsInteractable(buttonInteractable:  true);
        }
        private void OnMultiplierButton1Clicked(bool connection)
        {
            this.purchasePoint = 70;
            this.ContributeMultiplier(multiplierIndex:  0, connection:  connection);
        }
        private void OnMultiplierButton2Clicked(bool connection)
        {
            this.purchasePoint = 71;
            this.ContributeMultiplier(multiplierIndex:  1, connection:  connection);
        }
        private void OnMultiplierButton3Clicked(bool connection)
        {
            this.purchasePoint = 72;
            this.ContributeMultiplier(multiplierIndex:  2, connection:  connection);
        }
        private void OnMultiplierButton4Clicked(bool connection)
        {
            this.purchasePoint = 73;
            this.ContributeMultiplier(multiplierIndex:  3, connection:  connection);
        }
        private void ContributeMultiplier(int multiplierIndex, bool connection)
        {
            int val_5;
            SLC.Social.Leagues.WGClubMultiplierPopup val_22;
            decimal val_23;
            decimal val_24;
            int val_25;
            var val_26;
            System.Func<System.Boolean> val_28;
            var val_29;
            val_22 = this;
            if(connection == false)
            {
                goto label_1;
            }
            
            this.currentIndex = multiplierIndex;
            val_23 = this.multiplierValues[multiplierIndex];
            val_24 = this.multiplierValues[multiplierIndex];
            decimal val_1 = CalculateMultiplierCost(multiplierIncrease:  new System.Decimal() {flags = 890511472, hi = val_23, lo = this.multiplierValues[multiplierIndex], mid = val_24});
            val_25 = 1152921504892043264;
            GameBehavior val_6 = App.getBehavior;
            if(0 == 0)
            {
                goto label_8;
            }
            
            Player val_8 = App.Player;
            val_25 = 52;
            val_24 = 52;
            goto label_14;
            label_1:
            GameBehavior val_9 = App.getBehavior;
            string val_11 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
            string val_12 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_13 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
            val_26 = null;
            val_26 = null;
            val_28 = WGClubMultiplierPopup.<>c.<>9__21_0;
            if(val_28 == 0)
            {
                    val_28 = null;
                val_28 = new System.Func<System.Boolean>(object:  WGClubMultiplierPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(890485424));
                WGClubMultiplierPopup.<>c.<>9__21_0 = val_28;
            }
            
            typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_28;
            val_29 = null;
            val_29 = null;
            0.SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
            UnityEngine.GameObject val_15 = this.gameObject;
            SLCWindow.CloseWindow(window:  890511472, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            return;
            label_8:
            Player val_16 = App.Player;
            decimal val_17 = System.Decimal.op_Implicit(value:  890499420);
            label_14:
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = -1725760224, hi = -1725759984, lo = 1054454320, mid = val_5}, d2:  new System.Decimal())) != false)
            {
                    this.RedirectToStore();
                return;
            }
            
            val_24 = val_22;
            SLC.Social.Leagues.LeaguesDataController val_19 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_22 = 0;
            val_25 = this.currentIndex;
            val_23 = null;
            val_23 = new System.Action<System.Boolean>(object:  890511472, method:  new IntPtr(890486448));
            val_22.ContributeMultiplier(multiplierOption:  val_25 + 1, multiplierToContribute:  new System.Decimal() {flags = val_23, lo = val_24, mid = this.multiplierValues[multiplierIndex]}, multiplierCost:  new System.Decimal() {flags = "internet_required_upper", hi = "connection_required_explanation", mid = val_5}, resultAction:  val_23);
            this.ToggleButtonsInteractable(buttonInteractable:  false);
        }
        private void OnAddMultiplierSuccess(bool success)
        {
            int val_6;
            int val_7;
            int val_8;
            int val_9;
            int val_18;
            int val_19;
            int val_20;
            int val_21;
            this.UpdateMultiplierCosts();
            this.ToggleButtonsInteractable(buttonInteractable:  true);
            GameBehavior val_1 = App.getBehavior;
            if(0 != 0)
            {
                    Player val_3 = App.Player;
                val_18 = 52;
                val_19 = 52;
                val_20 = 256;
                val_21 = 256;
            }
            else
            {
                    Player val_4 = App.Player;
                decimal val_5 = System.Decimal.op_Implicit(value:  890743512);
                val_18 = val_6;
                val_19 = val_7;
                val_20 = val_8;
                val_21 = val_9;
            }
            
            this.statviewText.Set(instantValue:  new System.Decimal() {flags = val_18, hi = val_19, lo = val_20, mid = val_21});
            UnityEngine.Transform val_10 = this.trailParticles.transform;
            UnityEngine.Transform val_11 = this.multiplierButtons[this.currentIndex].transform;
            UnityEngine.Vector3 val_12 = position;
            this.trailParticles.position = new UnityEngine.Vector3();
            decimal val_13 = new System.Decimal(value:  10);
            decimal val_14 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 890743484, hi = this.multiplierValues[this.currentIndex], lo = this.multiplierValues[this.currentIndex], mid = this.multiplierValues[this.currentIndex]}, d2:  new System.Decimal() {flags = this.multiplierValues[this.currentIndex], hi = val_13.flags, lo = val_13.hi, mid = val_13.lo});
            this.trailParticles.Emit(count:  System.Decimal.op_Explicit(value:  new System.Decimal()));
            this.burstParticles.Play();
            DG.Tweening.TweenCallback val_16 = new DG.Tweening.TweenCallback(object:  890755568, method:  new IntPtr(890730544));
            DG.Tweening.Tween val_17 = DG.Tweening.DOVirtual.DelayedCall(delay:  val_12.x, callback:  1061158912, ignoreTimeScale:  false);
        }
        private void UpdateCurrentMultiplier(bool animate = False)
        {
            UnityEngine.UI.Text val_10;
            int val_11;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = 0.MyGuild;
            val_10 = this.currentMultiplierText;
            mem[1152921514087756736] = 4;
            string val_3 = this.FormatMultiplierString(multiplier:  new System.Decimal() {flags = 256, hi = 256, lo = 4, mid = 4});
            val_11 = 4;
            if(animate == false)
            {
                    return;
            }
            
            UnityEngine.Transform val_4 = this.currentMultiplierText.transform;
            UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            val_11 = 16102;
            val_11 = 1055286886;
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  this.currentMultiplierText, punch:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  null, vibrato:  val_11, elasticity:  null);
            DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.currentMultiplierOverlay, endValue:  null, duration:  null);
            val_10 = null;
            val_10 = new DG.Tweening.TweenCallback(object:  890975088, method:  new IntPtr(890950064));
            object val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.currentMultiplierOverlay, action:  190734336);
        }
        private void UpdateMultiplierCosts()
        {
            var val_6;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_6 = 0;
            SLC.Social.Leagues.Guild val_2 = 0.MyGuild;
            if(0 != 0)
            {
                goto label_5;
            }
            
            goto label_5;
            label_12:
            decimal val_9 = this.multiplierValues[val_6];
            decimal val_3 = CalculateMultiplierCost(multiplierIncrease:  new System.Decimal() {flags = 891214064, hi = this.multiplierValues[val_6], lo = this.multiplierValues[val_6], mid = this.multiplierValues[val_6]});
            string val_4 = ToString();
            val_6 = 1;
            label_5:
            if(val_6 < this.costTexts[val_6])
            {
                goto label_12;
            }
        
        }
        private void OnCloseClicked()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  891440752, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnStoreButtonClicked()
        {
            this.purchasePoint = 74;
            this.RedirectToStore();
        }
        private void RedirectToStore()
        {
            var val_4;
            var val_4 = 24401365;
            val_4 = 11224696 + val_4;
            if(val_4 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_4 = null;
            val_4 = null;
            PurchaseProxy.currentPurchasePoint = this.purchasePoint;
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            GameBehavior val_2 = App.getBehavior;
            if(0 != 0)
            {
                    "GEMS" = "";
            }
            
            System.Action<System.Boolean, System.Boolean> val_3 = new System.Action<System.Boolean, System.Boolean>(object:  891669872, method:  new IntPtr(891644848));
            ShowStore(categoryFocus:  1098586544, storeCloseCallback:  7507968);
        }
        private void OnCloseCallback(bool purchased, bool forcedClose)
        {
            var val_9;
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  891785968, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  891785968, aName:  70334112);
            if(forcedClose != false)
            {
                    return;
            }
            
            GameBehavior val_3 = App.getBehavior;
            if(0 != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if(2124183120 == 0)
            {
                    return;
            }
            
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                var val_9 = 24399396;
                val_9 = 11226664 + val_9;
                if(val_9 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_9 = null;
                val_9 = null;
                TryShowPromptVideo(entryPoint:  PurchaseProxy.currentPurchasePoint, showAsFlyout:  false);
                return;
            }
            
            GameBehavior val_7 = App.getBehavior;
            if(0 != 0)
            {
                    return;
            }
        
        }
        private void ToggleButtonsInteractable(bool buttonInteractable)
        {
            SLC.Social.Leagues.WGClubMultiplierPopup val_4;
            bool val_5;
            var val_6;
            bool val_7;
            val_4 = this;
            val_5 = buttonInteractable;
            val_6 = 0;
            goto label_1;
            label_11:
            val_7 = 0;
            UGUINetworkedButtonMultiGraphic val_4 = this.multiplierButtons[val_6];
            if(val_5 != false)
            {
                    decimal val_8 = this.multiplierValues[val_6];
                decimal val_1 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 891963736, hi = this.currentMultiplier, lo = this.currentMultiplier, mid = this.currentMultiplier}, d2:  new System.Decimal() {flags = this.currentMultiplier, hi = this.multiplierValues[val_6], lo = this.multiplierValues[val_6], mid = this.multiplierValues[val_6]});
                decimal val_2 = new System.Decimal(value:  999);
                val_5 = val_5;
                val_7 = System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.flags});
                val_4 = val_4;
            }
            
            val_4.interactable = val_7;
            val_6 = 1;
            label_1:
            if(val_6 < val_4)
            {
                goto label_11;
            }
            
            mem[1152921514088757392].interactable = val_5;
            mem[1152921514088757396].interactable = val_5;
        }
        private decimal CalculateMultiplierCost(decimal multiplierIncrease)
        {
            int val_2;
            int val_4;
            int val_9;
            int val_10;
            int val_1 = multiplierIncrease.flags + 68;
            val_9 = val_2;
            val_10 = multiplierIncrease.mid;
            val_9 = val_2;
            val_10 = multiplierIncrease.mid;
            decimal val_3 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 892153564, hi = multiplierIncrease.hi, lo = multiplierIncrease.lo, mid = val_10}, d2:  new System.Decimal() {flags = val_9, hi = mem[(multiplierIncrease.flags + 68) + (0)], lo = mem[(multiplierIncrease.flags + 68) + (4)], mid = mem[(multiplierIncrease.flags + 68) + (8)]});
            decimal val_5 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 892153548}, d2:  new System.Decimal() {flags = val_4, hi = multiplierIncrease.flags + 68, lo = multiplierIncrease.flags + 72, mid = multiplierIncrease.flags + 76});
            decimal val_6 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 892153532}, d2:  new System.Decimal() {flags = ???, hi = multiplierIncrease.flags + 52, lo = multiplierIncrease.flags + 56, mid = multiplierIncrease.flags + 60});
            decimal val_8 = System.Decimal.Ceiling(d:  new System.Decimal() {flags = 892165616});
            return new System.Decimal() {flags = val_8.flags, hi = val_8.hi, lo = val_8.lo, mid = val_8.mid};
        }
        private string FormatMultiplierString(decimal multiplier)
        {
            string val_1 = System.String.Format(format:  -588332288, arg0:  10170368);
        }
        public WGClubMultiplierPopup()
        {
            decimal val_1 = new System.Decimal(lo:  10, mid:  0, hi:  0, isNegative:  false, scale:  1);
        }
        private void <OnAddMultiplierSuccess>b__22_0()
        {
            this.UpdateCurrentMultiplier(animate:  true);
        }
        private void <UpdateCurrentMultiplier>b__23_0()
        {
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.currentMultiplierOverlay, endValue:  null, duration:  null);
        }
        private static WGClubMultiplierPopup()
        {
             = new System.Decimal(value:  999);
        }
    
    }

}
