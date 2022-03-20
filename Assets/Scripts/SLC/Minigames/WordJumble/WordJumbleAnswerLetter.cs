using UnityEngine;

namespace SLC.Minigames.WordJumble
{
    public class WordJumbleAnswerLetter : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text letter;
        private SLC.Minigames.WordJumble.WordJumbleWordArea wordAreaParent;
        private SLC.Minigames.WordJumble.WordJumbleLetterTile letterTile;
        private UnityEngine.UI.Button button;
        private bool <confirmed>k__BackingField;
        
        // Properties
        public char character { get; }
        public bool confirmed { get; set; }
        public bool IsLetterSet { get; }
        
        // Methods
        public char get_character()
        {
            if(this.letterTile != 0)
            {
                    return (char)this.letterTile.<character>k__BackingField;
            }
            
            return (char)this.letterTile.<character>k__BackingField;
        }
        public bool get_confirmed()
        {
            return (bool)this.<confirmed>k__BackingField;
        }
        private void set_confirmed(bool value)
        {
            this.<confirmed>k__BackingField = value;
        }
        private void Awake()
        {
            object val_1 = this.GetComponent<System.Object>();
            this.button = this;
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  918816656, method:  new IntPtr(918791632));
            this.AddListener(call:  162246656);
        }
        public void Init(SLC.Minigames.WordJumble.WordJumbleWordArea _wordAreaParent)
        {
            this.wordAreaParent = _wordAreaParent;
            if(this.letter == 0)
            {
                
            }
        
        }
        public bool get_IsLetterSet()
        {
            if(typeof(UnityEngine.UI.Text).__il2cppRuntimeField_310 > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public void SetLetter(SLC.Minigames.WordJumble.WordJumbleLetterTile _letterTile, bool confirm = False)
        {
            string val_1 = _letterTile.<character>k__BackingField.ToString();
            this.<confirmed>k__BackingField = confirm;
            this.letterTile = _letterTile;
        }
        public void OnLetterClick()
        {
            this.wordAreaParent.AnswerLetterClicked(answerLetter:  919309712);
        }
        public void ResetLetter()
        {
            if((this.<confirmed>k__BackingField) == true)
            {
                    return;
            }
            
            if((R4 + 20) != 0)
            {
                    R4 + 20.ReshowLetter();
                mem2[0] = 0;
            }
            
            if((R4 + 12) == 0)
            {
                
            }
        
        }
        public WordJumbleAnswerLetter()
        {
        
        }
    
    }

}
