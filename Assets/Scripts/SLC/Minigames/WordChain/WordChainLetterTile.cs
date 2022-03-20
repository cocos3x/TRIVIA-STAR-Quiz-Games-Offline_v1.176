using UnityEngine;

namespace SLC.Minigames.WordChain
{
    public class WordChainLetterTile : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text letter;
        public UnityEngine.UI.Button btn;
        public UnityEngine.CanvasGroup canvasGroup;
        public int keyboardIndex;
        public int answerIndex;
        public bool locked;
        public bool submitted;
        
        // Methods
        public WordChainLetterTile()
        {
        
        }
    
    }

}
