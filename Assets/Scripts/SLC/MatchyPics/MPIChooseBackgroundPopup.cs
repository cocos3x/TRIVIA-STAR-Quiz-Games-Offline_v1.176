using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPIChooseBackgroundPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.LoopVerticalScrollRect loopScroollRect;
        public UnityEngine.UI.Button closeButton;
        public SLC.MatchyPics.MPICollectionsPopup collectionsPopup;
        private SLC.MatchyPics.MPICollectionsManager manager;
        
        // Methods
        public void Start()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.manager = public static SLC.MatchyPics.MPICollectionsManager MonoSingleton<SLC.MatchyPics.MPICollectionsManager>::get_Instance();
            mem2[0] = (public static SLC.MatchyPics.MPICollectionsManager MonoSingleton<SLC.MatchyPics.MPICollectionsManager>::get_Instance().__il2cppRuntimeField_14 + 12 + 1);
            this.loopScroollRect.RefillCells(offset:  0);
        }
        public void SelectBackground(int collectionIndex)
        {
            this.manager.SetBackground(CollectionIndex:  collectionIndex);
            this.ShowCollection(collectionIndex:  collectionIndex);
        }
        public void ShowCollection(int collectionIndex)
        {
            if(this.collectionsPopup == 0)
            {
                    return;
            }
            
            this.collectionsPopup.LoadCollection(collectionIndex:  collectionIndex);
            this.collectionsPopup.ClosePopup();
        }
        public MPIChooseBackgroundPopup()
        {
        
        }
    
    }

}
