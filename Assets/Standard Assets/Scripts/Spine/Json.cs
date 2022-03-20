using UnityEngine;

namespace Spine
{
    public static class Json
    {
        // Methods
        public static object Deserialize(System.IO.TextReader text)
        {
            SharpJson.JsonDecoder val_1 = new SharpJson.JsonDecoder();
            typeof(SharpJson.JsonDecoder).__il2cppRuntimeField_C = 1;
            if(text != 0)
            {
                    return Decode(text:  text);
            }
            
            return Decode(text:  text);
        }
    
    }

}
