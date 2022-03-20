using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPICollectionUI : MonoBehaviour, CollectAnimation
    {
        // Fields
        private const int DEFAULT_ITEM_SIZE = 130;
        private UnityEngine.UI.Button uiButton;
        private UnityEngine.UI.Text collectionName;
        private UnityEngine.UI.Text progressionText;
        private UnityEngine.UI.Text coinPrizeText;
        private UnityEngine.Transform itemsParent;
        private AnimatedCoin item;
        private float flyToDuration;
        private bool <ShowPopupOnClick>k__BackingField;
        private SLC.MatchyPics.MPICollection currentCollection;
        private int collectionIndex;
        
        // Properties
        public bool ShowPopupOnClick { get; set; }
        
        // Methods
        public bool get_ShowPopupOnClick()
        {
            return (bool)this.<ShowPopupOnClick>k__BackingField;
        }
        public void set_ShowPopupOnClick(bool value)
        {
            this.<ShowPopupOnClick>k__BackingField = value;
        }
        public void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  738561424, method:  new IntPtr(738536400));
            this.uiButton.m_OnClick.AddListener(call:  162246656);
        }
        public void LoadCollection(int collectionIndex)
        {
            this.collectionIndex = collectionIndex;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.MatchyPics.MPICollection val_2 = GetCollection(imageSetIndex:  collectionIndex);
            this.currentCollection = public static SLC.MatchyPics.MPICollectionsManager MonoSingleton<SLC.MatchyPics.MPICollectionsManager>::get_Instance();
            string val_3 = public static SLC.MatchyPics.MPICollectionsManager MonoSingleton<SLC.MatchyPics.MPICollectionsManager>::get_Instance().__il2cppRuntimeField_C.ToUpper();
            int val_4 = this.currentCollection.CollectedItems();
            string val_5 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            UnityEngine.Transform val_7 = this.coinPrizeText.transform;
            UnityEngine.Transform val_8 = this.coinPrizeText.parent;
            UnityEngine.GameObject val_9 = this.coinPrizeText.gameObject;
            if(this.currentCollection.CoinReward() > 0)
            {
                    0 = 1;
            }
            
            this.coinPrizeText.SetActive(value:  true);
            string val_11 = this.currentCollection.CoinReward().ToString();
            if(this.coinPrizeText != 0)
            {
                    return;
            }
        
        }
        public void UpdateCurrentCollection()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(Unlocked == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-852051584) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.collectionIndex = public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 56;
            this.LoadCollection(collectionIndex:  public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 56);
        }
        public void OnSparkle()
        {
        
        }
        public void OnCoinDeposited()
        {
            this.LoadCollection(collectionIndex:  this.collectionIndex);
        }
        public void ShowCollectionItem(SLC.MatchyPics.MPIGridTile tile)
        {
            float val_6;
            float val_7;
            float val_13;
            float val_17;
            float val_18;
            var val_19;
            var val_20;
            val_19 = 1152921512344616960;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_20 = public static SLC.MatchyPics.MPIBoardController MonoSingleton<SLC.MatchyPics.MPIBoardController>::get_Instance();
            if((-852164608) == 0)
            {
                    return;
            }
            
            if(this.itemsParent == 0)
            {
                    UnityEngine.Debug.LogError(message:  739171152);
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Vector3 val_5 = GetWordPosition(tile:  -852164608);
            UnityEngine.Transform val_9 = this.itemsParent.transform;
            UnityEngine.Vector3 val_10 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = this.itemsParent, y = val_6, z = val_7});
            object val_11 = tile.GetComponent<System.Object>();
            UnityEngine.Vector2 val_12 = sizeDelta;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 2.034518E-12f, y = val_13});
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 2.034517E-12f});
            this.ItemAnimation(relativePos:  new UnityEngine.Vector3() {x = R6, y = R7, z = R8}, itemSize:  new UnityEngine.Vector2() {x = val_18, y = val_17}, spriteIndex:  tile.<tileData>k__BackingField.SpriteIndex);
        }
        public void ShowCollectionItem(int imageSet, int itemIndex)
        {
            float val_3;
            float val_6;
            float val_7;
            this.LoadCollection(collectionIndex:  imageSet);
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.one;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 2.062363E-12f, y = val_3}, d:  val_2.x);
            this.ItemAnimation(relativePos:  new UnityEngine.Vector3(), itemSize:  new UnityEngine.Vector2() {x = val_7, y = val_6}, spriteIndex:  itemIndex);
        }
        private void ItemAnimation(UnityEngine.Vector3 relativePos, UnityEngine.Vector2 itemSize, int spriteIndex)
        {
            float val_18;
            int val_19;
            UnityEngine.UI.Text val_20;
            AnimatedCoin val_21;
            UnityEngine.Transform val_22;
            val_18 = relativePos.x;
            val_19 = spriteIndex;
            int val_1 = this.currentCollection.GetItems(itemIndex:  val_19);
            if(val_1 <= 1)
            {
                goto label_2;
            }
            
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.item, parent:  this.itemsParent);
            UnityEngine.GameObject val_3 = this.item.gameObject;
            val_19 = relativePos.z;
            this.item.SetActive(value:  true);
            if(this.item == 0)
            {
                goto label_7;
            }
            
            this.item.Reset(grid:  739493264);
            goto label_8;
            label_2:
            val_20 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = val_20;
            typeof(System.Object[]).__il2cppRuntimeField_14 = this.currentCollection;
            UnityEngine.Debug.LogErrorFormat(format:  739436304, args:  472754880);
            return;
            label_7:
            this.item.Reset(grid:  739493264);
            label_8:
            UnityEngine.Transform val_4 = this.item.transform;
            this.item.localPosition = new UnityEngine.Vector3() {x = val_18, y = relativePos.y, z = val_19};
            if(val_1 == 1)
            {
                    int val_5 = this.currentCollection.CollectedItems();
                val_5 = val_5 - 1;
                string val_6 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
                object val_7 = this.item.GetComponentInChildren<System.Object>();
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                UnityEngine.Sprite val_9 = GetSprite(imageSetIndex:  this.currentCollection.imageSetIndex, spriteIndex:  spriteIndex);
                val_21 = this.item;
                this.item.sprite = -851265360;
                val_19 = itemSize.y;
                val_18 = itemSize.x;
                object val_10 = val_21.GetComponent<System.Object>();
                val_21.sizeDelta = new UnityEngine.Vector2() {x = val_18, y = val_19};
                val_20 = this.progressionText;
                val_22 = val_20;
                UnityEngine.Transform val_11 = val_22.transform;
            }
            else
            {
                    int val_12 = this.currentCollection.CoinReward();
                val_12 = val_12 - 1;
                string val_13 = val_12.ToString();
                val_21 = this.item;
                val_18;
                UnityEngine.Transform val_14 = this.coinPrizeText.transform;
                UnityEngine.Transform val_15 = this.coinPrizeText.parent;
                UnityEngine.GameObject val_16 = this.coinPrizeText.gameObject;
                this.coinPrizeText.SetActive(value:  true);
                val_20 = this.coinPrizeText;
                val_22 = val_20;
                UnityEngine.RectTransform val_17 = val_22.rectTransform;
            }
            
            this.AnimationSequence(item:  val_21, endPos:  val_22);
        }
        private void AnimationSequence(AnimatedCoin item, UnityEngine.Transform endPos)
        {
            UnityEngine.Transform val_1 = item.transform;
            UnityEngine.Vector3 val_2 = position;
            UnityEngine.Vector3 val_3 = position;
            float val_4 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3(), b:  new UnityEngine.Vector3());
            float val_12 = R0;
            if(item != 0)
            {
                    item.PlaySparkle(delay:  val_4);
            }
            else
            {
                    0.PlaySparkle(delay:  val_4);
            }
            
            val_12 = val_12 * this.flyToDuration;
            UnityEngine.Transform val_5 = item.transform;
            UnityEngine.Vector3 val_6 = position;
            DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOMove(target:  item, endValue:  new UnityEngine.Vector3(), duration:  val_6.x, snapping:  val_12);
            object val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  item, ease:  12);
            DG.Tweening.TweenCallback val_9 = new DG.Tweening.TweenCallback(object:  item, method:  new IntPtr(107266816));
            object val_10 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  item, action:  190734336);
            object val_11 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  item, delay:  val_6.x);
        }
        private void OnCollectionClick()
        {
            if((this.<ShowPopupOnClick>k__BackingField) == false)
            {
                    return;
            }
            
            GameBehavior val_1 = App.getBehavior;
            0.LoadCollection(collectionIndex:  this.collectionIndex);
        }
        public MPICollectionUI()
        {
            this.flyToDuration = 0.25f;
        }
    
    }

}
