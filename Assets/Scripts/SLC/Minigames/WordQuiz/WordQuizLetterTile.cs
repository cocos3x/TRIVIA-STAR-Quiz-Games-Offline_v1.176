using UnityEngine;

namespace SLC.Minigames.WordQuiz
{
    public class WordQuizLetterTile : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text letter;
        public UnityEngine.UI.Button btn;
        public UnityEngine.CanvasGroup canvasGroup;
        private UnityEngine.Sprite hiddenTileSprite;
        private UnityEngine.Sprite shownSprite;
        private UnityEngine.UI.Outline textOutline;
        private UnityEngine.Color hintColor;
        public int keyboardIndex;
        public int answerIndex;
        public bool locked;
        public bool submitted;
        
        // Methods
        public void SetHiddenState(bool hidden)
        {
            UnityEngine.UI.Image val_1 = this.btn.image;
            if(hidden == true)
            {
                    this = this.hiddenTileSprite;
            }
            
            this.btn.sprite = this;
        }
        public void SetHinted()
        {
            UnityEngine.UI.Image val_1 = this.btn.image;
            this.btn.enabled = false;
            this.letter.color = new UnityEngine.Color() {r = this.hintColor, g = SL, b = R8, a = ???};
            this.textOutline.enabled = true;
        }
        public WordQuizLetterTile()
        {
        
        }
    
    }

}
