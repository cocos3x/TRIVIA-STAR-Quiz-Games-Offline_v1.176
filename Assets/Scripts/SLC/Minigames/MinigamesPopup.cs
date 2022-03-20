using UnityEngine;

namespace SLC.Minigames
{
    public class MinigamesPopup : MonoBehaviour
    {
        // Fields
        private SLC.Minigames.MinigameButton MinigameButtonPrefab;
        private UnityEngine.Transform buttonsParent;
        public bool someMinigameLoading;
        private twelvegigs.storage.JsonDictionary knobsData;
        private System.Collections.Generic.List<SLC.Minigames.MinigameButton> myButtons;
        
        // Methods
        private void Awake()
        {
            this.Setup();
        }
        public void ToggleLoading(bool isLoading)
        {
            List.Enumerator<T> val_1 = GetEnumerator();
            label_5:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            this.someMinigameLoading = isLoading;
            val_4 + 16.interactable = isLoading ^ 1;
            goto label_5;
            label_2:
            Dispose();
        }
        public void Setup()
        {
            var val_4;
            AppConfigs val_1 = App.Configuration;
            List.Enumerator<T> val_2 = GetEnumerator();
            label_28:
            if(MoveNext() == false)
            {
                goto label_6;
            }
            
            if((val_4 + 36) == 0)
            {
                goto label_28;
            }
            
            string val_5 = val_4 + 8.ToLower();
            if((val_4 + 8.Contains(value:  911746720)) == true)
            {
                goto label_28;
            }
            
            Player val_8 = App.Player;
            if(val_4.UnlockLevel > 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if((val_4 + 32) != DeeplinkedWhichMinigame)
            {
                    if((UnityEngine.PlayerPrefs.HasKey(key:  val_4 + 8)) == false)
            {
                goto label_28;
            }
            
            }
            
            }
            
            int val_12 = val_4.UnlockLevel;
            WordPets.WPTDataParser val_13 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            UnityEngine.Sprite val_14 = GetSpriteFromBundle(bundleName:  905336192, spriteName:  val_4 + 20);
            object val_15 = UnityEngine.Object.Instantiate<System.Object>(original:  mem[1152921514108554444], parent:  mem[1152921514108554448]);
            mem[1152921514108554444].Setup(gameName:  val_4 + 8, minigameIndex:  val_4 + 32, reqLevel:  0, gameIcon:  public static ResourceLoader MonoSingletonSelfGenerating<ResourceLoader>::get_Instance(), displayGameName:  val_4 + 12, parentPopup:  this);
            mem[1152921514108554460].Add(item:  mem[1152921514108554444]);
            goto label_28;
            label_6:
            Dispose();
        }
        private int GetRequiredLevelFromKnobs(string currentMinigameName)
        {
            if((this.knobsData.Contains(key:  currentMinigameName)) == false)
            {
                    return 0;
            }
            
            twelvegigs.storage.JsonDictionary val_2 = this.knobsData.getJsonDictionary(key:  currentMinigameName);
            if((this.knobsData.Contains(key:  -1179997696)) == false)
            {
                    return 0;
            }
            
            if(this.knobsData != 0)
            {
                    return this.knobsData.getInt(key:  -1179997696, defaultValue:  0);
            }
            
            return this.knobsData.getInt(key:  -1179997696, defaultValue:  0);
        }
        public MinigamesPopup()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.myButtons = null;
        }
    
    }

}
