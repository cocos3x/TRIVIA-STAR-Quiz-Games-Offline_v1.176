using UnityEngine;

namespace WordPets
{
    public class WPTLevelIntroPopup : MonoBehaviour
    {
        // Fields
        private const int MAX_PORTRAITS = 8;
        private UnityEngine.UI.Text titleText;
        private UnityEngine.UI.Text infoText;
        private UnityEngine.UI.Button closeButton;
        private UnityEngine.UI.Button playButton;
        private UnityEngine.Transform petsGrid;
        private UnityEngine.GameObject petPortraitPrefab;
        
        // Methods
        private void Start()
        {
            var val_20;
            var val_21;
            var val_23;
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  208915008, method:  new IntPtr(208876528));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  208915008, method:  new IntPtr(208885744));
            this.playButton.m_OnClick.AddListener(call:  162246656);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(((public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_C4 + 16 + public static WordPets.WPTGameUIController MonoSingleton<WordPets) == 1)
            {
                    "Pets" = "Pet";
            }
            
            Player val_5 = App.Player;
            string val_6 = System.String.Format(format:  2127161280, arg0:  13152256);
            string val_7 = System.String.Format(format:  208890864, arg0:  13152256, arg1:  173213344);
            System.Collections.Generic.List<WordPets.WordPetType> val_8 = new System.Collections.Generic.List<WordPets.WordPetType>();
            val_20 = 4;
            twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            var val_14 =  - 4;
            twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordPets.WPTGameMode val_16 = currentGame;
            val_21 = 1152921513342375840;
            AddRange(collection:  public static WordPets.WordPetsController MonoSingleton<WordPets.WordPetsController>::get_Instance().__il2cppRuntimeField_1C);
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordPets.WPTGameMode val_18 = currentGame;
            AddRange(collection:  public static WordPets.WordPetsController MonoSingleton<WordPets.WordPetsController>::get_Instance().__il2cppRuntimeField_14);
            val_23 = 0;
            if( > 7)
            {
                    return;
            }
        
        }
        private void OnCloseButtonClicked()
        {
            GameBehavior val_1 = App.getBehavior;
            UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  209047488, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnPlayButtonClicked()
        {
            bool val_11;
            var val_12;
            var val_13;
            System.Action val_15;
            val_11 = static_value_021FCE51;
            if(val_11 != true)
            {
                    val_11 = true;
            }
            
            WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
            bool val_2 = val_11.RefreshPlayerLives();
            WordPets.WPTPlayer val_3 = WordPets.WPTPlayer.Instance;
            if((val_2 + 280) >= 1)
            {
                    System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                Player val_5 = App.Player;
                var val_6 = 0 + 60;
                Add(key:  -2100706000, value:  10170368);
                val_12 = null;
                val_12 = null;
                App.trackerManager.track(eventName:  -2100698896, data:  78753792);
                UnityEngine.GameObject val_7 = this.gameObject;
                SLCWindow.CloseWindow(window:  209161536, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
                return;
            }
            
            GameBehavior val_8 = App.getBehavior;
            val_13 = null;
            val_13 = null;
            val_15 = WPTLevelIntroPopup.<>c.<>9__9_0;
            if(val_15 == 0)
            {
                    val_15 = null;
                val_15 = new System.Action(object:  WPTLevelIntroPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(209136512));
                WPTLevelIntroPopup.<>c.<>9__9_0 = val_15;
            }
            
            0.Init(onCloseAction:  7454720);
            UnityEngine.GameObject val_11 = this.gameObject;
            SLCWindow.CloseWindow(window:  209161536, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public WPTLevelIntroPopup()
        {
        
        }
    
    }

}
