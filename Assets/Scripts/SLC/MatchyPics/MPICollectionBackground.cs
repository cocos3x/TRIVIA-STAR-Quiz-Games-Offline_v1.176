using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPICollectionBackground : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.RawImage bgImage;
        
        // Methods
        public void Awake()
        {
            object val_1 = this.GetComponent<System.Object>();
            this.bgImage = this;
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  734659776, name:  734635664);
        }
        public void Start()
        {
            this.OnBackgroundChanged();
        }
        public void SetBackground(int collectionIndex)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Texture val_2 = GetBackground(collectionIndex:  collectionIndex);
            this.bgImage.texture = -851040240;
        }
        public void OnBackgroundChanged()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Texture val_3 = GetBackground(collectionIndex:  public static SLC.MatchyPics.MPICollectionsManager MonoSingleton<SLC.MatchyPics.MPICollectionsManager>::get_Instance().__il2cppRuntimeField_1C);
            this.bgImage.texture = -851040240;
        }
        public MPICollectionBackground()
        {
        
        }
    
    }

}
