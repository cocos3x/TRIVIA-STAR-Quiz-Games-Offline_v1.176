using UnityEngine;

namespace SLC.Minigames.Ladder
{
    public class WordLadderLetter : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text myLetter;
        private UnityEngine.UI.Image image;
        private int index;
        private string letter;
        
        // Properties
        public string Letter { get; }
        
        // Methods
        public string get_Letter()
        {
        
        }
        private void Awake()
        {
            object val_1 = this.GetComponent<System.Object>();
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  945318144, method:  typeof(SLC.Minigames.Ladder.WordLadderLetter).__il2cppRuntimeField_E0);
            this.AddListener(call:  162246656);
        }
        public void Setup(string letter, int myIndex)
        {
            this.index = myIndex;
            this.letter = letter;
        }
        public virtual void OnClick()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.Ladder.WordLadderController MonoSingleton<SLC.Minigames.Ladder.WordLadderController>::get_Instance().__il2cppRuntimeField_1C) != 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            LetterChosen(clickedIndex:  R4 + 20);
        }
        public void SetSpriteAndText(UnityEngine.Sprite s, int textSize)
        {
            UnityEngine.Sprite val_3;
            UnityEngine.UI.Image val_4;
            val_3 = s;
            val_4 = this.image;
            if(val_4 == 0)
            {
                    return;
            }
            
            val_4 = this.image;
            val_4.sprite = val_3;
            val_3 = this.myLetter;
            if(val_3 == 0)
            {
                    return;
            }
            
            this.myLetter.fontSize = textSize;
        }
        public WordLadderLetter()
        {
        
        }
    
    }

}
