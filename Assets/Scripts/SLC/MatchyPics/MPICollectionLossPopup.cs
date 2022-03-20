using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPICollectionLossPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button goBackButton;
        private UnityEngine.UI.Button confirmButton;
        private SLC.MatchyPics.MPICollectionUI collectionUI;
        private UnityEngine.UI.Text currentProgress;
        private int collectionIndex;
        
        // Methods
        public void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  736828096, method:  new IntPtr(736793856));
            this.goBackButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  736828096, method:  new IntPtr(736803072));
            this.confirmButton.m_OnClick.AddListener(call:  162246656);
        }
        public void OnEnable()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.collectionIndex = public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 56;
            this.collectionUI.LoadCollection(collectionIndex:  public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 56);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.MatchyPics.MPICollection val_3 = GetCollection(imageSetIndex:  this.collectionIndex);
            int val_4 = CollectedItems();
            string val_5 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            if(this.currentProgress != 0)
            {
                    return;
            }
        
        }
        private void GoBackClick()
        {
            GameBehavior val_1 = App.getBehavior;
            UnityEngine.GameObject val_3 = this.gameObject;
            SLCWindow.CloseWindow(window:  737085888, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void ConfirmResetClick()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ResetProgress(setIndex:  this.collectionIndex);
            GameBehavior val_2 = App.getBehavior;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            0.SetupStars(gainedStars:  public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 32);
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            LevelFailed();
            UnityEngine.GameObject val_6 = this.gameObject;
            SLCWindow.CloseWindow(window:  737198912, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public MPICollectionLossPopup()
        {
        
        }
    
    }

}
