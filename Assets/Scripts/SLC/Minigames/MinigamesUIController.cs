using UnityEngine;

namespace SLC.Minigames
{
    public class MinigamesUIController : MonoSingleton<SLC.Minigames.MinigamesUIController>
    {
        // Fields
        private const string pref_seen_game_over_count = "mini_gmovr_ct";
        private int _GameOverSeenCt;
        public System.Action<bool> ToggleExclusivePopup;
        
        // Properties
        private int GameOverSeenCt { get; set; }
        
        // Methods
        private int get_GameOverSeenCt()
        {
            if(this._GameOverSeenCt != 1)
            {
                    return (int)this._GameOverSeenCt;
            }
            
            int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  913100144, defaultValue:  0);
            mem2[0] = val_1;
            return val_1;
        }
        private void set_GameOverSeenCt(int value)
        {
            this._GameOverSeenCt = value;
        }
        public override void InitMonoSingleton()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Events.UnityAction<System.Boolean> val_2 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  913350288, method:  new IntPtr(913324240));
            public static SLC.Minigames.MinigamesWindowManager MonoSingleton<SLC.Minigames.MinigamesWindowManager>::get_Instance().__il2cppRuntimeField_2C.AddListener(call:  162353152);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  913350288, method:  new IntPtr(913325264));
            public static SLC.Minigames.MinigamesWindowManager MonoSingleton<SLC.Minigames.MinigamesWindowManager>::get_Instance().__il2cppRuntimeField_28.AddListener(call:  162246656);
        }
        private void OnMonolithWindowClosed()
        {
            if(this.ToggleExclusivePopup == 0)
            {
                    return;
            }
            
            this.ToggleExclusivePopup.Invoke(obj:  false);
        }
        private void OnMonolithWindowOpened(bool exclusive)
        {
            if(exclusive == true)
            {
                    true = this.ToggleExclusivePopup;
            }
            
            if(true == 0)
            {
                    return;
            }
            
            true.Invoke(obj:  true);
        }
        public void ShowCheckpoint()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        public void ShowRankup()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        public void ShowContinue()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        public void ShowGameOver()
        {
            int val_1 = this.GameOverSeenCt;
            val_1 = val_1 + 1;
            this._GameOverSeenCt = val_1;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        public bool ShowRedirect()
        {
            return false;
        }
        public void ShowMessage(string titleTxt, string messageTxt, bool[] shownButtons, string[] buttonTexts, bool showClose = True, System.Func<bool>[] buttonCallbacks)
        {
            var val_3;
            System.Func<System.Boolean>[] val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
            val_3 = null;
            val_3 = null;
            val_4 = buttonCallbacks;
            if((public static SLC.Minigames.MinigamesWindowManager MonoSingleton<SLC.Minigames.MinigamesWindowManager>::get_Instance()) == 0)
            {
                    val_4 = buttonCallbacks;
            }
            
            SetupMessage(titleTxt:  titleTxt, messageTxt:  messageTxt, shownButtons:  shownButtons, buttonTexts:  buttonTexts, showClose:  showClose, buttonCallbacks:  val_4, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
        }
        public MinigamesUIController()
        {
            this._GameOverSeenCt = 0;
        }
    
    }

}
