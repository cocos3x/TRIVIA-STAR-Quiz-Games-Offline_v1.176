using UnityEngine;

namespace SLC.Minigames.WordMemory
{
    public class CardItem : MyButton
    {
        // Fields
        private UnityEngine.UI.Text label;
        private UnityEngine.UI.Image back;
        private UnityEngine.UI.Image face;
        private UnityEngine.GameObject content;
        private int index;
        private bool faceUp;
        
        // Methods
        public void Init(int _index, string _word)
        {
            this.index = _index;
            this.FaceDown();
        }
        public void FaceDown()
        {
            this.back.enabled = true;
            this.faceUp = false;
        }
        public void FaceUp()
        {
            this.back.enabled = false;
            this.faceUp = true;
        }
        public override void OnButtonClick()
        {
            if(this.faceUp != false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.WordMemory.WordMemoryManager MonoSingleton<SLC.Minigames.WordMemory.WordMemoryManager>::get_Instance().__il2cppRuntimeField_45) != 0)
            {
                    return;
            }
            
            if((R5 + 68) == 0)
            {
                    return;
            }
            
            R4.FaceUp();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            R7.FaceUpCard(index:  R4 + 36);
        }
        public void Hide()
        {
            this.content.SetActive(value:  false);
        }
        private void Update()
        {
        
        }
        public CardItem()
        {
        
        }
    
    }

}
