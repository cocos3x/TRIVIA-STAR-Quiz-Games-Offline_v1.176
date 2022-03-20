using UnityEngine;

namespace WordPets
{
    public class WPTPetJournalPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject prefabPetEntry;
        private UnityEngine.UI.Button buttonClose;
        private UnityEngine.UI.Text labelSubtitle;
        private UnityEngine.UI.LoopScrollRect loopScrollRect;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  214535088, method:  new IntPtr(214510064));
            this.buttonClose.m_OnClick.AddListener(call:  162246656);
            this.Initialize();
        }
        public void CloseWindow()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  214655280, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void Initialize()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.loopScrollRect.totalCount = public static WordPets.WPTShelterController MonoSingleton<WordPets.WPTShelterController>::get_Instance().__il2cppRuntimeField_C + 12;
            this.loopScrollRect.RefillCells(offset:  0);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_4 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            if(this.labelSubtitle != 0)
            {
                    return;
            }
        
        }
        public WPTPetJournalPopup()
        {
        
        }
    
    }

}
