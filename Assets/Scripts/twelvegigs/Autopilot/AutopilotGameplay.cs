using UnityEngine;

namespace twelvegigs.Autopilot
{
    public class AutopilotGameplay : MonoBehaviour
    {
        // Fields
        private int <LevelsToTest>k__BackingField;
        
        // Properties
        public int LevelsToTest { get; set; }
        
        // Methods
        public int get_LevelsToTest()
        {
            return (int)this.<LevelsToTest>k__BackingField;
        }
        public void set_LevelsToTest(int value)
        {
            this.<LevelsToTest>k__BackingField = value;
        }
        public virtual bool IsExecutable()
        {
            return false;
        }
        public virtual void RunAction()
        {
        
        }
        public virtual void OnSceneLoaded(SceneType sceneType)
        {
        
        }
        public virtual void OnSceneUnloaded(SceneType sceneType)
        {
        
        }
        public AutopilotGameplay()
        {
        
        }
    
    }

}
