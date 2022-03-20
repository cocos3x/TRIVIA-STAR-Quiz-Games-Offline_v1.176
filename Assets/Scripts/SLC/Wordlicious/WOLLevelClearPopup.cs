using UnityEngine;

namespace SLC.Wordlicious
{
    public class WOLLevelClearPopup : LevelCompletePopup
    {
        // Methods
        public override void OnEnable()
        {
            this.Invoke(methodName:  -247212400, time:  null);
        }
        public override void ShowWithEffects()
        {
            R4.Setup(shouldBeShowing:  true);
        }
        public override void WaitAndPlayAnim()
        {
            if(R4 == 0)
            {
                
            }
        
        }
        public override void HandleWindowClose(bool chapterClear)
        {
            GameBehavior val_1 = App.getBehavior;
            UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  712176240, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_4 = ShowInterstitial(context:  2);
        }
        public WOLLevelClearPopup()
        {
        
        }
    
    }

}
