using UnityEngine;

namespace SLC.Wordlicious
{
    public struct Letter
    {
        // Fields
        public char letter;
        public int dist;
        
        // Methods
        public Letter(char letter, int dist)
        {
            this.dist = dist;
            this = letter;
        }
    
    }

}
