using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPICollectionCompletePopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject windowComplete;
        private UnityEngine.UI.Image collectionIcon;
        private UnityEngine.UI.Button collectButton;
        private UnityEngine.UI.Text completedText;
        private UnityEngine.UI.Text coinRewardText;
        private UnityEngine.GameObject windowSetBackground;
        private UnityEngine.UI.RawImage bgRwdImage;
        private UnityEngine.UI.Button setBackgroundButton;
        private UnityEngine.UI.Button closeButton;
        private UnityEngine.UI.Text bgDescText;
        private GridCoinCollectAnimationInstantiator coinAnim;
        private SLC.MatchyPics.MPICollectionsManager cmanager;
        private int collectionIndex;
        
        // Methods
        public void Start()
        {
            mem2[0] = 0;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.cmanager = public static SLC.MatchyPics.MPICollectionsManager MonoSingleton<SLC.MatchyPics.MPICollectionsManager>::get_Instance();
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  735267904, method:  new IntPtr(735224448));
            this.collectButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  735267904, method:  new IntPtr(735233664));
            this.setBackgroundButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  735267904, method:  new IntPtr(735242880));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
            this.LoadCompletedCollection();
        }
        private void LoadCompletedCollection()
        {
            int val_15;
            var val_16;
            int val_1 = this.cmanager.GetCompletedCollectionIndex();
            this.collectionIndex = val_1;
            if(val_1 <= 1)
            {
                goto label_2;
            }
            
            val_15 = val_1;
            if(this.cmanager == 0)
            {
                    val_15 = this.collectionIndex;
            }
            
            if(val_1 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = R1 + (val_15 << 2);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(((R1 + (this.collectionIndex) << 2) + 16) == 0)
            {
                goto label_8;
            }
            
            val_16 = mem[(R1 + (this.collectionIndex) << 2) + 16 + 8];
            val_16 = (R1 + (this.collectionIndex) << 2) + 16 + 8;
            goto label_9;
            label_2:
            UnityEngine.GameObject val_4 = this.gameObject;
            SLCWindow.CloseWindow(window:  735458240, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            return;
            label_8:
            val_16 = 0;
            label_9:
            UnityEngine.Sprite val_5 = GetSprite(imageSetIndex:  0, spriteIndex:  (R1 + (this.collectionIndex) << 2) + 16 + 16 + 16);
            this.collectionIcon.sprite = -851265360;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Texture val_7 = GetBackground(collectionIndex:  this.collectionIndex);
            this.bgRwdImage.texture = -851040240;
            string val_8 = Localization.Localize(key:  735409296, defaultValue:  735409152, useSingularKey:  false);
            string val_9 = System.String.Format(format:  735409296, arg0:  (R1 + (this.collectionIndex) << 2) + 16 + 12);
            string val_10 = Localization.Localize(key:  735413648, defaultValue:  735413504, useSingularKey:  false);
            string val_11 = System.String.Format(format:  735413648, arg0:  (R1 + (this.collectionIndex) << 2) + 16 + 12);
            string val_13 = (R1 + (this.collectionIndex) << 2) + 16.CoinReward().ToString();
            this.collectButton.interactable = true;
            UnityEngine.GameObject val_14 = this.coinAnim.gameObject;
            this.coinAnim.SetActive(value:  true);
            this.windowComplete.SetActive(value:  true);
            this.windowSetBackground.SetActive(value:  false);
        }
        private void OnCollectButton()
        {
            int val_8;
            this.collectButton.interactable = false;
            if(this.collectButton <= this.collectionIndex)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + (this.collectionIndex << 2);
            this.cmanager.CollectCollectionCompleted(CollectionIndex:  this.collectionIndex);
            if(((0 + (this.collectionIndex) << 2) + 16.CoinReward()) >= 1)
            {
                    System.Action val_2 = new System.Action(object:  735644992, method:  new IntPtr(735615872));
                this.coinAnim.OnCompleteCallback = null;
                Player val_3 = App.Player;
                var val_4 = 0 + 60;
                decimal val_5 = System.Decimal.op_Implicit(value:  735632940);
                decimal val_6 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 735632924, hi = mem[(0 + 60) + (0)], lo = mem[(0 + 60) + (4)], mid = mem[(0 + 60) + (8)]}, d2:  new System.Decimal() {flags = 256});
                Player val_7 = App.Player;
                this.coinAnim.Play(fromValue:  new System.Decimal() {mid = val_8}, toValue:  new System.Decimal() {}, textTickTime:  null, delayBeforeComplete:  null);
                return;
            }
            
            this.OnCoinAnimCompleted();
        }
        private void OnCoinAnimCompleted()
        {
            UnityEngine.GameObject val_1 = this.coinAnim.gameObject;
            this.coinAnim.SetActive(value:  false);
            this.windowComplete.SetActive(value:  false);
            this.windowSetBackground.SetActive(value:  true);
        }
        private void OnSetBackgroundButton()
        {
            this.cmanager.SetBackground(CollectionIndex:  this.collectionIndex);
            this.LoadCompletedCollection();
        }
        private void OnClose()
        {
            this.LoadCompletedCollection();
        }
        public MPICollectionCompletePopup()
        {
        
        }
    
    }

}
