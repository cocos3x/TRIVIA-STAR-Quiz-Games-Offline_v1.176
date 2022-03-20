using UnityEngine;

namespace SLC.Minigames
{
    public class MinigameLivesDisplay : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject HeartPrefab;
        private UnityEngine.Transform HeartsContainer;
        private System.Collections.Generic.List<UnityEngine.UI.Toggle> HeartToggles;
        private bool initialized;
        
        // Methods
        private void Init(int maxHearts)
        {
            int val_4;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5;
            val_4 = maxHearts;
            this.initialized = true;
            val_5 = null;
            val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.HeartToggles = val_5;
            if(val_4 >= 1)
            {
                    int val_4 = val_4;
                do
            {
                object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.HeartPrefab, parent:  this.HeartsContainer);
                object val_3 = this.HeartPrefab.GetComponent<System.Object>();
                val_4 = this.HeartToggles;
                val_5 = this.HeartPrefab;
                val_4.Add(item:  val_5);
                val_4 = val_4 - 1;
            }
            while(val_4 != 0);
            
            }
            
            this.UpdateLivesDisplay(currentHearts:  val_4);
        }
        public void UpdateLivesDisplay(int currentHearts)
        {
            var val_1;
            if(this.initialized != true)
            {
                    this.Init(maxHearts:  currentHearts);
            }
            
            val_1 = 0;
            goto label_2;
            label_7:
            if(this <= val_1)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            if(val_1 < currentHearts)
            {
                    0 = 1;
            }
            
            (0 + 0) + 16.isOn = true;
            val_1 = 1;
            label_2:
            if(val_1 < ((0 + 0) + 16))
            {
                goto label_7;
            }
        
        }
        public MinigameLivesDisplay()
        {
        
        }
    
    }

}
