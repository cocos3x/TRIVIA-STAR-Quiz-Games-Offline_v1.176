using UnityEngine;

namespace WordPets.LevelEditor
{
    public class WPTDiffDisplay : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text diffText;
        
        // Methods
        private void OnEnable()
        {
            var val_5;
            UnityEngine.UI.Text val_6;
            var val_7;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_2 = getDiff();
            val_5 = public static WordPets.LevelEditor.WPTLevelEditorUI MonoSingleton<WordPets.LevelEditor.WPTLevelEditorUI>::get_Instance();
            val_6 = this.diffText;
            val_7 = System.String.op_Equality(a:  226449024, b:  System.String.alignConst);
            if(val_7 != false)
            {
                
            }
        
        }
        public WPTDiffDisplay()
        {
        
        }
    
    }

}
