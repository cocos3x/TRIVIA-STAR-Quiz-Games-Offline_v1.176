using UnityEngine;

namespace SLC.Minigames
{
    public class MinigamesRedirect_Window : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.RawImage main_game_advert;
        private UnityEngine.UI.Text rediret_text;
        private UnityEngine.UI.Button play_now_button;
        private UnityEngine.UI.Button close_button;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  912643376, method:  new IntPtr(912600544));
            this.close_button.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  912643376, method:  new IntPtr(912609760));
            this.play_now_button.m_OnClick.AddListener(call:  162246656);
            WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            UnityEngine.Texture val_4 = GetTextureFromBundle(bundleName:  905336192, textureName:  912614880);
            this.main_game_advert.texture = -676860272;
            string val_5 = Localization.Localize(key:  912619232, defaultValue:  912619104, useSingularKey:  false);
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_7 = GetMainGameName();
            string val_8 = System.String.Format(format:  912619232, arg0:  -1745297776);
            if(this.rediret_text == 0)
            {
                
            }
        
        }
        private void PlayNow()
        {
            this.play_now_button.interactable = false;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandleHomeClicked(redirectToGameplay:  true);
        }
        private void Close()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandleGameRestart();
            UnityEngine.GameObject val_2 = this.gameObject;
            this.SetActive(value:  false);
        }
        public MinigamesRedirect_Window()
        {
        
        }
    
    }

}
