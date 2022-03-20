using UnityEngine;

namespace RestaurantRivals
{
    public class RESEventPointCollectionRewardPopup : MonoBehaviour
    {
        // Fields
        public System.Action onClose;
        public System.Action onRewardCollect;
        private UnityEngine.GameObject titleObject;
        private UnityEngine.UI.Text rewardText;
        private UnityEngine.UI.Image rewardIcon;
        private UnityEngine.UI.Text rewardQtyText;
        private UnityEngine.UI.Button collectButton;
        private UnityEngine.Transform RewardIconDestinationTransform;
        private UnityEngine.UI.Image screenBlocker;
        private GridCoinCollectAnimationInstantiator coinsAnim;
        private GoldenCurrencyCollectAnimationInstantiator goldAnim;
        private SpinsCollectAnimationInstantiator spinsAnim;
        private UnityEngine.GameObject rewardObject;
        private System.Collections.Generic.List<RESEventRewardData> rewardDataList;
        private string trackingSource;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  532597168, method:  new IntPtr(532572144));
            this.collectButton.m_OnClick.AddListener(call:  162246656);
        }
        public void InitReward(System.Collections.Generic.List<RESEventRewardData> _rewardDataList, System.Action onCollectClicked, string source = "")
        {
            var val_4;
            System.Action val_6;
            this.rewardDataList = _rewardDataList;
            if(true < 1)
            {
                    return;
            }
            
            if("" < 2)
            {
                    if("" == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4 = "spins";
            }
            else
            {
                    val_4 = "reward";
            }
            
            this.trackingSource = source;
            string val_1 = System.String.Format(format:  532722032, arg0:  -1987496016);
            if(this.rewardText == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            string val_3 = 2621443 + 16.ToString(format:  -1539606768);
            val_6 = this.onRewardCollect;
            System.Delegate val_4 = System.Delegate.Combine(a:  val_6, b:  onCollectClicked);
            if(val_6 != 0)
            {
                    if(null == null)
            {
                goto label_20;
            }
            
            }
            
            val_6 = 0;
            label_20:
            this.onRewardCollect = val_6;
            this.DoRevealSequence();
        }
        private void DoRevealSequence()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.rewardIcon.sprite = public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_20 + 16 + 24 + 108;
            UnityEngine.Color val_2 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            this.screenBlocker.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
            UnityEngine.Transform val_3 = this.rewardIcon.transform;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            this.rewardIcon.localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_5 = this.titleObject.transform;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            this.titleObject.localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_7 = this.rewardText.transform;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            this.rewardText.localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_9 = this.collectButton.transform;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            this.collectButton.localScale = new UnityEngine.Vector3();
            DG.Tweening.Sequence val_11 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Color val_12 = new UnityEngine.Color(r:  val_10.x, g:  val_10.y, b:  val_10.z, a:  null);
            DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions46.DOColor(target:  this.screenBlocker, endValue:  new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.r}, duration:  val_10.x);
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.screenBlocker);
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_10.x);
            UnityEngine.Transform val_16 = this.rewardIcon.transform;
            DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.rewardIcon, endValue:  val_10.x, duration:  val_10.y);
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.rewardIcon);
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_10.x);
            UnityEngine.Transform val_20 = this.titleObject.transform;
            DG.Tweening.Tweener val_21 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.titleObject, endValue:  val_10.x, duration:  val_10.y);
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.titleObject);
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_10.x);
            UnityEngine.Transform val_24 = this.rewardText.transform;
            DG.Tweening.Tweener val_25 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.rewardText, endValue:  val_10.x, duration:  val_10.y);
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.rewardText);
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_10.x);
            UnityEngine.Transform val_28 = this.collectButton.transform;
            DG.Tweening.Tweener val_29 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.collectButton, endValue:  val_10.x, duration:  val_10.y);
            DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.collectButton);
        }
        private void OnCollectButtonClicked()
        {
            int val_12;
            int val_18;
            int val_28;
            int val_29;
            int val_30;
            RestaurantRivals.RESEventPointCollectionRewardPopup val_46;
            System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_47;
            var val_48;
            var val_49;
            System.Int32Enum val_50;
            var val_51;
            val_46 = this;
            UnityEngine.GameObject val_1 = this.collectButton.gameObject;
            this.collectButton.SetActive(value:  false);
            this.collectButton.interactable = false;
            val_47 = null;
            val_47 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
            if(val_47 != 0)
            {
                    Add(key:  1, value:  0);
                Add(key:  3, value:  0);
            }
            else
            {
                    Add(key:  1, value:  0);
                Add(key:  3, value:  0);
            }
            
            Add(key:  2, value:  0);
            val_48 = 4;
            val_49 = 1152921513729881312;
            goto label_6;
            label_23:
            if(val_47 <= R5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            bool val_3 = ContainsKey(key:  static_value_0028000B);
            if(val_3 != false)
            {
                    if(val_3 <= R5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_50 = static_value_0028000B;
                int val_4 = Item[val_50];
                if(val_4 <= R5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_5 = 2621443 + 16;
                int val_47 = mem[(2621443 + 16) + (8)];
                val_47 = val_47;
                val_49 = 1152921513729881312;
                val_47 = (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = mem[(2621443 + 16) + (0)], hi = mem[(2621443 + 16) + (4)], lo = val_47, mid = mem[(2621443 + 16) + (12)]})) + val_4;
                set_Item(key:  val_50, value:  val_47);
                val_46 = val_46;
            }
            
            val_48 = 5;
            label_6:
            if((val_48 - 4) < val_47)
            {
                goto label_23;
            }
            
            if(Item[1] < 1)
            {
                goto label_25;
            }
            
            Player val_9 = App.Player;
            int val_10 = Item[1];
            decimal val_11 = System.Decimal.op_Implicit(value:  533128076);
            0.AddCredits(amount:  new System.Decimal() {mid = val_12}, source:  mem[1152921513729921764], subSource:  0, externalParams:  0, doTrack:  true);
            Player val_13 = App.Player;
            int val_14 = Item[1];
            decimal val_15 = System.Decimal.op_Implicit(value:  533128060);
            decimal val_16 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 533128044, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
            Player val_17 = App.Player;
            val_50 = 49024;
            val_50 = 3212836864;
            mem[1152921513729921744].Play(fromValue:  new System.Decimal() {mid = val_18}, toValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, textTickTime:  null, delayBeforeComplete:  null);
            val_48 = 1152921504614301696;
            System.Action val_19 = new System.Action(object:  533140128, method:  new IntPtr(533115104));
            System.Delegate val_20 = System.Delegate.Combine(a:  mem[1152921513729921744] + 100, b:  7454720);
            val_49 = mem[1152921513729921744] + 100;
            if(val_49 != 0)
            {
                    if(val_49 == null)
            {
                goto label_39;
            }
            
            }
            
            val_49 = 0;
            label_39:
            mem2[0] = val_49;
            val_47 = val_47;
            label_25:
            if(Item[3] < 1)
            {
                goto label_41;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_23 = Item[3];
            val_50 = mem[1152921513729921748];
            Player val_24 = App.Player;
            Player val_26 = App.Player;
            decimal val_27 = System.Decimal.op_Implicit(value:  533128076);
            val_50.Play(fromValue:  4 - Item[3], toValue:  new System.Decimal() {flags = val_29, hi = val_30, lo = val_28, mid = val_12}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  1065353216);
            val_48 = 1152921504614301696;
            System.Action val_32 = new System.Action(object:  533140128, method:  new IntPtr(533115104));
            System.Delegate val_33 = System.Delegate.Combine(a:  mem[1152921513729921748] + 68, b:  7454720);
            val_49 = mem[1152921513729921748] + 68;
            if(val_49 != 0)
            {
                    if(val_49 == null)
            {
                goto label_57;
            }
            
            }
            
            val_49 = 0;
            label_57:
            mem2[0] = val_49;
            val_47 = val_47;
            label_41:
            if(Item[2] < 1)
            {
                goto label_59;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_35 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AwardSpins(amount:  Item[2], source:  mem[1152921513729921764], notify:  true);
            twelvegigs.Autopilot.AutopilotManager val_37 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_48 = Spins;
            val_50 = Item[2];
            twelvegigs.Autopilot.AutopilotManager val_40 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_41 = Spins;
            decimal val_42 = System.Decimal.op_Implicit(value:  533128076);
            mem[1152921513729921752].Play(fromValue:  val_48 - val_50, toValue:  new System.Decimal() {flags = val_29, hi = val_30, lo = val_28, mid = val_12}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  1065353216);
            val_49 = mem[1152921513729921752];
            val_47 = 1152921504614301696;
            System.Action val_44 = new System.Action(object:  533140128, method:  new IntPtr(533115104));
            System.Delegate val_45 = System.Delegate.Combine(a:  mem[1152921513729921752] + 68, b:  7454720);
            val_51 = mem[1152921513729921752] + 68;
            if(val_51 != 0)
            {
                    if(val_51 == null)
            {
                goto label_73;
            }
            
            }
            
            val_51 = 0;
            label_73:
            mem2[0] = val_51;
            label_59:
            if(mem[1152921513729921712] != 0)
            {
                    mem[1152921513729921712].Invoke();
            }
            
            twelvegigs.Autopilot.AutopilotManager val_46 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_20 + 16.UpdateValue(animated:  true);
        }
        private void Close()
        {
            if(this.onClose != 0)
            {
                    this.onClose.Invoke();
                this.onClose = 0;
            }
            
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  533276704, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public RESEventPointCollectionRewardPopup()
        {
            this.trackingSource = "";
        }
    
    }

}
