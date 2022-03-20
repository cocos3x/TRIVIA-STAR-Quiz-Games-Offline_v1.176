using UnityEngine;

namespace BlockPuzzleMagic
{
    public class BBLPowerupInfoPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button closeButton;
        private UnityEngine.UI.Text titleText;
        private UnityEngine.UI.Text infoText;
        private UnityEngine.GameObject[] pages;
        private System.Collections.Generic.Dictionary<BlockPuzzleMagic.PowerUpType, string> titleDict;
        private System.Collections.Generic.Dictionary<BlockPuzzleMagic.PowerUpType, string> infoDict;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  1219261168, method:  new IntPtr(1219236144));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
        }
        public void Initialize(BlockPuzzleMagic.PowerUpType powerupType)
        {
            var val_5 = 0;
            goto label_1;
            label_6:
            UnityEngine.GameObject val_5 = this.pages[val_5];
            val_5.SetActive(value:  (powerupType - val_5) >> 5);
            val_5 = 1;
            label_1:
            if(val_5 < val_5)
            {
                goto label_6;
            }
            
            string val_3 = this.titleDict.Item[powerupType];
            string val_4 = this.infoDict.Item[powerupType];
            if(this.infoText == 0)
            {
                
            }
        
        }
        private void OnCloseButtonClicked()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  1219690992, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public BBLPowerupInfoPopup()
        {
            System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_1 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
            if(val_1 != 0)
            {
                    Add(key:  0, value:  1219781040);
            }
            else
            {
                    Add(key:  0, value:  1219781040);
            }
            
            Add(key:  1, value:  1219781136);
            Add(key:  2, value:  1219781232);
            this.titleDict = val_1;
            System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_2 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
            if(val_2 != 0)
            {
                    Add(key:  0, value:  1219781328);
            }
            else
            {
                    Add(key:  0, value:  1219781328);
            }
            
            Add(key:  1, value:  1219781600);
            Add(key:  2, value:  1219781792);
            this.infoDict = val_2;
        }
    
    }

}
