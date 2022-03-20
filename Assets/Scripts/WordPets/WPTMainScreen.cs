using UnityEngine;

namespace WordPets
{
    public class WPTMainScreen : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text levelText;
        private bool doneThisBefore;
        
        // Methods
        private void Awake()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  210073920, name:  -2037002944);
        }
        private void Start()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.Play(type:  0, trackIndex:  0);
        }
        private void OnDeferredReady()
        {
            if(this.doneThisBefore == true)
            {
                    return;
            }
            
            this.doneThisBefore = true;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Reset();
            Player val_2 = App.Player;
            string val_3 = 0.ToString();
            string val_4 = System.String.Format(format:  -2101083200, arg0:  210289996);
        }
        public void OnPlayButtonClicked()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            LoadGame(mode:  0);
        }
        public void OnShelterButtonClicked()
        {
            GameBehavior val_1 = App.getBehavior;
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  null, mode:  1);
        }
        public WPTMainScreen()
        {
        
        }
    
    }

}
