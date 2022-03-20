using UnityEngine;

namespace WordPets
{
    public class WPTShelterScreen : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject pickupReadyGroup;
        private UnityEngine.GameObject pickupTimerGroup;
        private UnityEngine.UI.Text pickupTimerText;
        private UnityEngine.UI.Button pickupButton;
        private UnityEngine.UI.Text petJournalText;
        private System.Collections.Generic.List<UnityEngine.Transform> idlePetTransforms;
        private UnityEngine.Transform inventoryTransform;
        private UnityEngine.GameObject inventoryPrefab;
        
        // Methods
        public WPTShelterScreen()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.idlePetTransforms = null;
        }
    
    }

}
