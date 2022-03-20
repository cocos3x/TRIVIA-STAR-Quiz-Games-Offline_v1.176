using UnityEngine;

namespace SLC.Minigames.WordChain
{
    public class WordChainFTUX : MonoSingleton<SLC.Minigames.WordChain.WordChainFTUX>
    {
        // Fields
        private SLC.Minigames.WordChain.WordChainUIController wordChainUIController;
        private const float WAIT_TIME = 3;
        private SLC.Minigames.WordChain.WordChainLetterTile currentLetter;
        
        // Methods
        public void ShowFTUX()
        {
            this.StopAllCoroutines();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.WordChain.WordChainLetterTile val_2 = this.wordChainUIController.GetNextLetterInFTUX(index:  public static SLC.Minigames.WordChain.WordChainManager MonoSingleton<SLC.Minigames.WordChain.WordChainManager>::get_Instance().__il2cppRuntimeField_14);
            this.currentLetter = this.wordChainUIController;
            this.wordChainUIController.DisableOtherLetterTiles(currentFTUXLetterTile:  this.wordChainUIController);
            System.Collections.IEnumerator val_3 = this.ShowHand();
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  963470288);
        }
        public void Stop()
        {
            this.StopAllCoroutines();
        }
        private System.Collections.IEnumerator ShowHand()
        {
            object val_1 = new System.Object();
            typeof(WordChainFTUX.<ShowHand>d__5).__il2cppRuntimeField_8 = 0;
            typeof(WordChainFTUX.<ShowHand>d__5).__il2cppRuntimeField_10 = this;
        }
        public WordChainFTUX()
        {
        
        }
    
    }

}
