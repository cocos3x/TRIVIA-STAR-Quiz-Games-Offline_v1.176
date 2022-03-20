using UnityEngine;

namespace LitJson
{
    public class JsonException : ApplicationException
    {
        // Methods
        public JsonException()
        {
        
        }
        internal JsonException(LitJson.ParserToken token)
        {
            string val_1 = System.String.Format(format:  2064397600, arg0:  272363520);
        }
        internal JsonException(LitJson.ParserToken token, System.Exception inner_exception)
        {
            string val_1 = System.String.Format(format:  2064397600, arg0:  272363520);
        }
        internal JsonException(int c)
        {
            string val_1 = System.String.Format(format:  2064642224, arg0:  9158656);
        }
        internal JsonException(int c, System.Exception inner_exception)
        {
            string val_1 = System.String.Format(format:  2064642224, arg0:  9158656);
        }
        public JsonException(string message)
        {
        
        }
        public JsonException(string message, System.Exception inner_exception)
        {
        
        }
    
    }

}
