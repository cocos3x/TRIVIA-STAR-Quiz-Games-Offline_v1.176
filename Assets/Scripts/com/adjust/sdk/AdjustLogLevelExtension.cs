using UnityEngine;

namespace com.adjust.sdk
{
    public static class AdjustLogLevelExtension
    {
        // Methods
        public static string ToLowercaseString(com.adjust.sdk.AdjustLogLevel AdjustLogLevel)
        {
            var val_2;
            if((AdjustLogLevel - 1) <= 6)
            {
                    val_2 = mem[34443696 + ((AdjustLogLevel - 1)) << 2];
                val_2 = 34443696 + ((AdjustLogLevel - 1)) << 2;
                return;
            }
            
            val_2 = "unknown";
        }
        public static string ToUppercaseString(com.adjust.sdk.AdjustLogLevel AdjustLogLevel)
        {
            var val_2;
            if((AdjustLogLevel - 1) <= 6)
            {
                    val_2 = mem[34443728 + ((AdjustLogLevel - 1)) << 2];
                val_2 = 34443728 + ((AdjustLogLevel - 1)) << 2;
                return;
            }
            
            val_2 = "UNKNOWN";
        }
    
    }

}
