using UnityEngine;

namespace SLC.Minigames.WordJumble
{
    public class WordJumbleLetterTile : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text letter;
        private char <character>k__BackingField;
        private SLC.Minigames.WordJumble.WordJumbleWordArea wordAreaParent;
        private UnityEngine.UI.Button button;
        
        // Properties
        public char character { get; set; }
        public bool used { get; }
        
        // Methods
        public char get_character()
        {
            return (char)this.<character>k__BackingField;
        }
        private void set_character(char value)
        {
            this.<character>k__BackingField = value;
        }
        public bool get_used()
        {
            if(this.button != 0)
            {
                    return false;
            }
            
            return false;
        }
        private void Awake()
        {
            object val_1 = this.GetComponent<System.Object>();
            this.button = this;
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  919995024, method:  new IntPtr(919970000));
            this.AddListener(call:  162246656);
        }
        public void Init(SLC.Minigames.WordJumble.WordJumbleWordArea _wordAreaParent, char _letter)
        {
            this.wordAreaParent = _wordAreaParent;
            string val_1 = _letter.ToString();
            this.<character>k__BackingField = _letter;
        }
        private void OnLetterClick()
        {
            this.HideLetter();
            this.wordAreaParent.LetterTileClicked(letterTile:  920239504);
        }
        public void HideLetter()
        {
            this.button.interactable = false;
            twelvegigs.Autopilot.WUTAutopilotGameplay val_1 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  this.button);
            this.button.alpha = null;
        }
        public void ReshowLetter()
        {
            this.button.interactable = true;
            twelvegigs.Autopilot.WUTAutopilotGameplay val_1 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  this.button);
            this.button.alpha = null;
        }
        public WordJumbleLetterTile()
        {
        
        }
    
    }

}
