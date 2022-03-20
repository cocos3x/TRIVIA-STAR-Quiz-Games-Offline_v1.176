using UnityEngine;

namespace WordForest
{
    public class WFOForestRewardChestPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text labelQtyCoins;
        private UnityEngine.UI.Text labelQtyAcorns;
        private UnityEngine.UI.Button buttonCollect;
        private GridCoinCollectAnimationInstantiator coinsAnimControl;
        private GoldenCurrencyCollectAnimationInstantiator acornsAnimControl;
        private WordForest.WFOForestChestData chest;
        private System.Action OnCollectCallback;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  299035680, method:  new IntPtr(299010656));
            this.buttonCollect.m_OnClick.AddListener(call:  162246656);
            this.Initialize();
        }
        public void AddOnCollectCallback(System.Action callback)
        {
            System.Action val_2 = this.OnCollectCallback;
            System.Delegate val_1 = System.Delegate.Combine(a:  val_2 = this.OnCollectCallback, b:  callback);
            if(val_2 != 0)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            val_2 = 0;
            label_2:
            this.OnCollectCallback = val_2;
        }
        private void Initialize()
        {
            var val_3;
            var val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordForest.WFOForestChestData val_2 = GetCurrentChestData();
            mem2[0] = val_3;
            var val_5 = (val_2.coins.mid + 52) - 20;
            mem2[0] = val_2.newRewardTypes.SyncRoot;
            mem2[0] = val_4;
            string val_7 = (val_2.coins.mid + 52) - 16.ToString();
            string val_8 = val_2.coins.mid + 52.ToString();
            if((val_2.coins.mid + 16) != 0)
            {
                    return;
            }
        
        }
        private void OnCollectClicked()
        {
            int val_8;
            int val_9;
            int val_10;
            int val_11;
            this.buttonCollect.interactable = false;
            Player val_1 = App.Player;
            Player val_2 = App.Player;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_4 = CollectForestChest();
            Player val_5 = App.Player;
            this.coinsAnimControl.Play(fromValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, toValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, textTickTime:  null, delayBeforeComplete:  null);
            Player val_6 = App.Player;
            decimal val_7 = System.Decimal.op_Implicit(value:  299397516);
            this.acornsAnimControl.Play(fromValue:  4, toValue:  new System.Decimal() {flags = val_10, hi = val_11, lo = val_9, mid = val_8}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
            DG.Tweening.TweenCallback val_12 = new DG.Tweening.TweenCallback(object:  299409568, method:  new IntPtr(299384544));
            DG.Tweening.Tween val_13 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1069547520, ignoreTimeScale:  false);
        }
        private void CloseWindow()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  299533856, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public WFOForestRewardChestPopup()
        {
        
        }
        private void <OnCollectClicked>b__10_0()
        {
            if(this.OnCollectCallback != 0)
            {
                    this.OnCollectCallback.Invoke();
            }
            
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  299761952, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
    
    }

}
