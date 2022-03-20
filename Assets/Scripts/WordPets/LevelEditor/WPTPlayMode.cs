using UnityEngine;

namespace WordPets.LevelEditor
{
    public class WPTPlayMode : MonoBehaviour
    {
        // Methods
        private void OnEnable()
        {
            this.ReloadLevel();
        }
        public void ReturnToEditMode()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SwitchToEditMode();
        }
        public void ReloadLevel()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Init(incData:  public static WordPets.LevelEditor.WPTLevelEditorUI MonoSingleton<WordPets.LevelEditor.WPTLevelEditorUI>::get_Instance().__il2cppRuntimeField_30);
        }
        public WPTPlayMode()
        {
        
        }
    
    }

}
