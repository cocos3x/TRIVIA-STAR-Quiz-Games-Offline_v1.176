using UnityEngine;

namespace com.adjust.sdk
{
    public static class AdjustEnvironmentExtension
    {
        // Methods
        public static string ToLowercaseString(com.adjust.sdk.AdjustEnvironment adjustEnvironment)
        {
            if(adjustEnvironment == 1)
            {
                    "unknown" = "production";
            }
            
            if(adjustEnvironment != 0)
            {
                    "sandbox" = "unknown";
            }
        
        }
    
    }

}
