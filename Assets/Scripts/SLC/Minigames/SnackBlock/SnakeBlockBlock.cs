using UnityEngine;

namespace SLC.Minigames.SnackBlock
{
    public class SnakeBlockBlock : MonoBehaviour
    {
        // Fields
        public SLC.Minigames.SnackBlock.SnakeGridSpaceType myType;
        private TMPro.TextMeshPro wordText;
        
        // Methods
        public void SetupFromData(int row, int column)
        {
            var val_6;
            var val_7;
            TMPro.TextMeshPro val_8;
            var val_9;
            var val_10;
            var val_11;
            val_6 = this;
            val_7 = 35638025;
            if(this.myType != 3)
            {
                    if(this.myType != 2)
            {
                    return;
            }
            
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_8 = public static SLC.Minigames.SnackBlock.SnakeBlockManager MonoSingleton<SLC.Minigames.SnackBlock.SnakeBlockManager>::get_Instance();
                string val_2 = GetWordForRowColumnIndex(row:  row, column:  0);
                val_9 = val_8;
                val_10 = public System.Void TMPro.TMP_Text::set_text(string value);
            }
            else
            {
                    val_8 = this.wordText;
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_11 = public static SLC.Minigames.SnackBlock.SnakeBlockManager MonoSingleton<SLC.Minigames.SnackBlock.SnakeBlockManager>::get_Instance();
                column = column + 1;
                string val_4 = GetWordForRowColumnIndex(row:  row, column:  column);
                val_9 = val_11;
                val_10 = public System.Void TMPro.TMP_Text::set_text(string value);
            }
            
            val_8.text = 1022897152;
        }
        public bool RemoveLastLetter()
        {
            string val_1 = this.wordText.text;
            string val_2 = this.wordText.text;
            string val_4 = this.wordText.Remove(startIndex:  this.wordText - 1);
            this.wordText.text = this.wordText;
            string val_5 = this.wordText.text;
            return System.String.IsNullOrEmpty(value:  this.wordText);
        }
        public SnakeBlockBlock()
        {
        
        }
    
    }

}
