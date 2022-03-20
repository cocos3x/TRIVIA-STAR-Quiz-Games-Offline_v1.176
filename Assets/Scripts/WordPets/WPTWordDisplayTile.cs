using UnityEngine;

namespace WordPets
{
    public class WPTWordDisplayTile : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text myText;
        private UnityEngine.UI.Button myButton;
        private WordPets.WPTGameTile <myTile>k__BackingField;
        
        // Properties
        public WordPets.WPTGameTile myTile { get; set; }
        
        // Methods
        public WordPets.WPTGameTile get_myTile()
        {
        
        }
        private void set_myTile(WordPets.WPTGameTile value)
        {
            this.<myTile>k__BackingField = value;
        }
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  202603376, method:  new IntPtr(202578352));
            this.myButton.m_OnClick.AddListener(call:  162246656);
        }
        public void SetLetter(WordPets.WPTGameTile tile)
        {
            this.<myTile>k__BackingField = tile;
            string val_1 = tile.ToString();
            string val_2 = tile.ToUpper();
            if(this.myText != 0)
            {
                    return;
            }
        
        }
        private void OnClick()
        {
            WordPets.WPTLetterTile val_2;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_2 = 0;
            DeselectTile(tile:  null);
        }
        public WPTWordDisplayTile()
        {
        
        }
    
    }

}
