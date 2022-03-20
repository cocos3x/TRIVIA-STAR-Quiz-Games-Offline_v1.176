using UnityEngine;

namespace WordPets
{
    public class WPTStoredPetDisplay : WPTCapturedPetDisplay
    {
        // Fields
        protected UnityEngine.UI.Text petAmount;
        
        // Methods
        public void Setup(WordPets.WordPetType type, int amount)
        {
            this.SetPet(type:  type);
            this.SetAmount(amount:  amount);
        }
        public void SetAmount(int amount)
        {
            string val_1 = amount.ToString();
            if(this.petAmount != 0)
            {
                    return;
            }
        
        }
        public WPTStoredPetDisplay()
        {
        
        }
    
    }

}
