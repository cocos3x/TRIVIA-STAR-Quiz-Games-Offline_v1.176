using UnityEngine;

namespace SLC.Minigames.ImageQuiz
{
    [Serializable]
    public class QuizUserData
    {
        // Fields
        public System.Collections.Generic.List<int> usedLevels;
        
        // Methods
        public QuizUserData()
        {
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            this.usedLevels = null;
        }
    
    }

}
