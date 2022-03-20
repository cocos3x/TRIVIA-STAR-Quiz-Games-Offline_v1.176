using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPIBgRewardUI : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.RawImage bgRwdImage;
        private UnityEngine.UI.Button rewardButton;
        private UnityEngine.UI.Text title;
        private UnityEngine.UI.Text progressItemsText;
        private UnityEngine.GameObject selectedObj;
        private UnityEngine.GameObject lockedObj;
        private UnityEngine.Color lockedColor;
        private SLC.MatchyPics.MPIChooseBackgroundPopup _popupParent;
        private int collectionIndex;
        private bool isCompleted;
        private bool isSelected;
        
        // Properties
        private SLC.MatchyPics.MPIChooseBackgroundPopup PopupParent { get; }
        
        // Methods
        private SLC.MatchyPics.MPIChooseBackgroundPopup get_PopupParent()
        {
            if(this._popupParent != 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = this.transform;
            object val_3 = this.GetComponentInParent<System.Object>();
            this._popupParent = this;
        }
        public void Awake()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  733375728, method:  new IntPtr(733350704));
            this.rewardButton.m_OnClick.AddListener(call:  162246656);
        }
        private void ScrollCellIndex(int index)
        {
            this.collectionIndex = index - 1;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_4 = ((public static SLC.MatchyPics.MPICollectionsManager MonoSingleton<SLC.MatchyPics.MPICollectionsManager>::get_Instance().__il2cppRuntimeField_1C - this.collectionIndex)) >> 5;
            this.isSelected = val_4;
            if(this.collectionIndex >= 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                this.SetupCollectionRwd(collection:  (public static SLC.MatchyPics.MPICollectionsManager MonoSingleton<SLC.MatchyPics.MPICollectionsManager>::get_Instance().__il2cppRuntimeField_14 + 8 + (this.collectionIndex) << 2) + 16, selected:  this.isSelected);
                return;
            }
            
            this.SetupDefaultBG(selected:  val_4);
        }
        private void SetupCollectionRwd(SLC.MatchyPics.MPICollection collection, bool selected)
        {
            int val_6;
            var val_7;
            var val_8;
            var val_9;
            UnityEngine.Color val_12;
            var val_13;
            var val_14;
            var val_15;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Texture val_2 = GetBackground(collectionIndex:  collection.imageSetIndex);
            this.bgRwdImage.texture = -851040240;
            int val_3 = collection.CollectedItems();
            val_3 = val_3 >> 5;
            this.isCompleted = val_3;
            if(val_3 != 16)
            {
                    val_3 - 16 = 1;
            }
            
            this.lockedObj.SetActive(value:  true);
            if(this.isCompleted != false)
            {
                    UnityEngine.Color val_5 = UnityEngine.Color.white;
                val_12 = val_6;
                val_13 = val_7;
                val_14 = val_8;
                val_15 = val_9;
            }
            else
            {
                    val_12 = this.lockedColor;
            }
            
            this.bgRwdImage.color = new UnityEngine.Color() {r = val_12, g = SB, b = this.lockedObj, a = collection};
            this.selectedObj.SetActive(value:  selected);
            if(this.isCompleted == true)
            {
                    return;
            }
            
            val_14 = 1152921504619999232;
            val_6 = collection.CollectedItems();
            string val_11 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        }
        private void SetupDefaultBG(bool selected)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            var val_3 = 25659636;
            val_3 = 9973820 + val_3;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            this.bgRwdImage.texture = public static SLC.MatchyPics.MPICollectionsManager MonoSingleton<SLC.MatchyPics.MPICollectionsManager>::get_Instance().__il2cppRuntimeField_C;
            this.isCompleted = true;
            this.lockedObj.SetActive(value:  false);
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            this.bgRwdImage.color = new UnityEngine.Color() {a = ???};
            this.selectedObj.SetActive(value:  selected);
        }
        private void OnSelectBackground()
        {
            SLC.MatchyPics.MPIChooseBackgroundPopup val_1 = this.PopupParent;
            bool val_2 = UnityEngine.Object.op_Equality(x:  733938512, y:  0);
            if(val_2 == false)
            {
                    val_2 = this.isSelected;
                goto label_3;
            }
            
            return;
            label_3:
            SLC.MatchyPics.MPIChooseBackgroundPopup val_3 = this.PopupParent;
            if(this.isCompleted != false)
            {
                    this.SelectBackground(collectionIndex:  this.collectionIndex);
                return;
            }
            
            this.ShowCollection(collectionIndex:  this.collectionIndex);
        }
        public MPIBgRewardUI()
        {
            this.collectionIndex = 0;
        }
    
    }

}
