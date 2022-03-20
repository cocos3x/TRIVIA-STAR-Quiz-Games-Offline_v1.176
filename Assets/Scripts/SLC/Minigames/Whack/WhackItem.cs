using UnityEngine;

namespace SLC.Minigames.Whack
{
    public class WhackItem : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text word;
        private UnityEngine.GameObject checkMark;
        private UnityEngine.GameObject xMark;
        private UnityEngine.GameObject emptySlot;
        private UnityEngine.GameObject melonSlot;
        private UnityEngine.GameObject winningSprite;
        private UnityEngine.GameObject losingSprite;
        private UnityEngine.GameObject hitSprite;
        private UnityEngine.GameObject victoryArmGroup;
        public SLC.Minigames.Whack.WhackWord wordDefinition;
        
        // Methods
        private void Awake()
        {
            this.melonSlot.SetActive(value:  false);
            this.winningSprite.SetActive(value:  false);
            this.losingSprite.SetActive(value:  false);
            this.hitSprite.SetActive(value:  false);
            this.victoryArmGroup.SetActive(value:  false);
            UnityEngine.Transform val_1 = this.word.transform;
            UnityEngine.Transform val_2 = this.word.parent;
            UnityEngine.GameObject val_3 = this.word.gameObject;
            this.word.SetActive(value:  false);
            this.checkMark.SetActive(value:  false);
            this.xMark.SetActive(value:  false);
        }
        public void Setup(SLC.Minigames.Whack.WhackWord wordDefinition)
        {
            var val_2 = this;
            this.wordDefinition = wordDefinition;
            if(wordDefinition != 0)
            {
                    this.SetDisplayState(state:  1);
                if(this.word != 0)
            {
                goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
            }
            
            }
            else
            {
                    R4 + 28.SetActive(value:  false);
            }
        
        }
        public void SetInteractable(bool state)
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            object val_2 = this.GetComponent<System.Object>();
            this.interactable = state;
        }
        public void SetDisplayState(SLC.Minigames.Whack.MelonState state)
        {
            UnityEngine.GameObject val_10;
            var val_13;
            SLC.Minigames.Whack.MelonState val_1 = state - 1;
            if(val_1 > 6)
            {
                    return;
            }
            
            var val_2 = 13282676 + (13282676 + ((state - 1)) << 2);
            if(val_1 == 6)
            {
                    13282676 + ((state - 1)) << 2 = (13282676 + ((state - 1)) << 2) & ((IP) << 13282676 + ((state - 1)) << 2);
                13282676 + ((state - 1)) << 2 = IP * (13282676 + ((state - 1)) << 2);
                13282676 + ((state - 1)) << 2 = (13282676 + ((state - 1)) << 2) & 502738808;
                13282676 + ((state - 1)) << 2 = (13282676 + ((state - 1)) << 2) & ((IP) << 2);
                13282676 + ((state - 1)) << 2 = (13282676 + ((state - 1)) << 2) & (((int)IP) >> 13282676);
                13282676 + ((state - 1)) << 2 = (13282676 + ((state - 1)) << 2) & (((((((IP * (13282676 + ((state - 1)) << 2 & (IP) << 13282676 + ((state - 1)) << 2)) & 502738808) & (IP) << 2) & ((int)IP) >> 13282676)) << (32-3)) | ((((((IP * (13282676 + ((state - 1)) << 2 & (IP) << 13282676 + ((state - 1)) << 2)) & 502738808) & (IP) << 2) & ((int)IP) >> 13282676)) << 3));
                13282676 + ((state - 1)) << 2 = (13282676 + ((state - 1)) << 2) & ((IP) << R2);
            }
            
            UnityEngine.Transform val_3 = this.word.transform;
            UnityEngine.Transform val_4 = this.word.parent;
            UnityEngine.GameObject val_5 = this.word.gameObject;
            this.word.SetActive(value:  true);
            val_10 = this.melonSlot;
            val_13 = 1;
            SetActive(value:  false);
        }
        public void OnClick()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ItemClicked(item:  1005602928);
        }
        public void UpdateOnLevelComplete(bool correctAnswer)
        {
            if(this.wordDefinition == 0)
            {
                    return;
            }
            
            this.melonSlot.SetActive(value:  false);
            if(correctAnswer == true)
            {
                    this = this.winningSprite;
            }
            
            this.SetActive(value:  true);
        }
        public WhackItem()
        {
        
        }
    
    }

}
