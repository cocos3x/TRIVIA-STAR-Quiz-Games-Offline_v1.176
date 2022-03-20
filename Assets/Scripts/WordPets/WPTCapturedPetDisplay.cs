using UnityEngine;

namespace WordPets
{
    public class WPTCapturedPetDisplay : MonoBehaviour
    {
        // Fields
        protected UnityEngine.UI.Image petImage;
        protected UnityEngine.GameObject newText;
        
        // Methods
        public void Setup(WordPets.WordPetType type, bool isNew = False)
        {
            this.SetPet(type:  type);
            this.newText.SetActive(value:  isNew);
        }
        public void SetPet(WordPets.WordPetType type)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.petImage.sprite = (public static WordPets.WPTShelterController MonoSingleton<WordPets.WPTShelterController>::get_Instance().__il2cppRuntimeField_C + (type) << 2) + 16 + 64;
        }
        public WPTCapturedPetDisplay()
        {
        
        }
    
    }

}
