using UnityEngine;

namespace SLC.Minigames.WordQuiz
{
    public class WordQuizFTUXManager : MonoSingleton<SLC.Minigames.WordQuiz.WordQuizFTUXManager>
    {
        // Fields
        private SLC.Minigames.WordQuiz.WordQuizUIController wordQuizUIController;
        private UnityEngine.GameObject FTUXLetterTileOverlay;
        private const float WAIT_TIME = 3;
        private SLC.Minigames.WordQuiz.WordQuizLetterTile currentLetter;
        
        // Methods
        public void ShowFTUX()
        {
            this.StopAllCoroutines();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.WordQuiz.WordQuizLetterTile val_2 = this.wordQuizUIController.GetNextLetterInFTUX(index:  public static SLC.Minigames.WordQuiz.WordQuizManager MonoSingleton<SLC.Minigames.WordQuiz.WordQuizManager>::get_Instance().__il2cppRuntimeField_14);
            this.currentLetter = this.wordQuizUIController;
            UnityEngine.Transform val_3 = this.wordQuizUIController.transform;
            object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  this.FTUXLetterTileOverlay, parent:  this.wordQuizUIController);
            UnityEngine.Transform val_5 = this.FTUXLetterTileOverlay.transform;
            this.FTUXLetterTileOverlay.SetAsFirstSibling();
            this.wordQuizUIController.DisableOtherLetterTiles(currentFTUXLetterTile:  this.currentLetter);
            System.Collections.IEnumerator val_6 = this.ShowHand();
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  925526832);
        }
        public void Stop()
        {
            this.StopAllCoroutines();
        }
        private System.Collections.IEnumerator ShowHand()
        {
            object val_1 = new System.Object();
            typeof(WordQuizFTUXManager.<ShowHand>d__6).__il2cppRuntimeField_8 = 0;
            typeof(WordQuizFTUXManager.<ShowHand>d__6).__il2cppRuntimeField_10 = this;
        }
        public WordQuizFTUXManager()
        {
        
        }
    
    }

}
