using UnityEngine;

namespace WordPets
{
    internal struct Letter
    {
        // Fields
        public char letter;
        public int probability;
        public int numToBeat;
        
        // Methods
        public Letter(char incLet, int incProb)
        {
            this = incLet;
            this.probability = incProb;
            this.numToBeat = 0;
        }
    
    }

}
