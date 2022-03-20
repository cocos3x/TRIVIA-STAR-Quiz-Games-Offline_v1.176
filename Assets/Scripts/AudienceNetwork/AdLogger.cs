using UnityEngine;

namespace AudienceNetwork
{
    internal static class AdLogger
    {
        // Fields
        private static AudienceNetwork.AdLogger.AdLogLevel logLevel;
        private static readonly string logPrefix;
        
        // Methods
        internal static void Log(string message)
        {
            var val_2 = null;
            if(AudienceNetwork.AdLogger.logLevel < 4)
            {
                    return;
            }
            
            var val_2 = 21012846;
            val_2 = 14629240 + val_2;
            if(val_2 == 0)
            {
                    mem2[0] = 1;
            }
            
            string val_1 = AudienceNetwork.AdLogger.logPrefix + 1287261616 + message;
            UnityEngine.Debug.Log(message:  AudienceNetwork.AdLogger.logPrefix);
        }
        internal static void LogWarning(string message)
        {
            var val_2 = null;
            if(AudienceNetwork.AdLogger.logLevel < 3)
            {
                    return;
            }
            
            var val_2 = 21012410;
            val_2 = 14629676 + val_2;
            if(val_2 == 0)
            {
                    mem2[0] = 1;
            }
            
            string val_1 = AudienceNetwork.AdLogger.logPrefix + 1287381904 + message;
            UnityEngine.Debug.LogWarning(message:  AudienceNetwork.AdLogger.logPrefix);
        }
        internal static void LogError(string message)
        {
            var val_2 = null;
            if(AudienceNetwork.AdLogger.logLevel < 2)
            {
                    return;
            }
            
            var val_2 = 21012090;
            val_2 = 14629996 + val_2;
            if(val_2 == 0)
            {
                    mem2[0] = 1;
            }
            
            string val_1 = AudienceNetwork.AdLogger.logPrefix + 1287502192 + message;
            UnityEngine.Debug.LogError(message:  AudienceNetwork.AdLogger.logPrefix);
        }
        private static string LevelAsString(AudienceNetwork.AdLogger.AdLogLevel logLevel)
        {
            var val_2;
            if((logLevel - 2) <= 4)
            {
                    val_2 = mem[34443824 + ((logLevel - 2)) << 2];
                val_2 = 34443824 + ((logLevel - 2)) << 2;
                return;
            }
            
            val_2 = "";
        }
        private static AdLogger()
        {
            AudienceNetwork.AdLogger.logLevel = 4;
            AudienceNetwork.AdLogger.logPrefix = "Audience Network Unity ";
        }
    
    }

}
