using UnityEngine;

namespace LitJson
{
    internal class FsmContext
    {
        // Fields
        public bool Return;
        public int NextState;
        public LitJson.Lexer L;
        public int StateStack;
        
        // Methods
        public FsmContext()
        {
        
        }
    
    }

}
