using UnityEngine;

namespace Helpshift
{
    public class HelpshiftInternalLogger
    {
        // Fields
        private static string TAG;
        private static UnityEngine.AndroidJavaClass hsInternalLogger;
        
        // Methods
        public static void d(string message)
        {
            null = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = Helpshift.HelpshiftInternalLogger.TAG;
            typeof(System.Object[]).__il2cppRuntimeField_14 = message;
            Helpshift.HelpshiftInternalLogger.hsInternalLogger.CallStatic(methodName:  -1605007504, args:  472754880);
        }
        public static void e(string message)
        {
            null = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = Helpshift.HelpshiftInternalLogger.TAG;
            typeof(System.Object[]).__il2cppRuntimeField_14 = message;
            Helpshift.HelpshiftInternalLogger.hsInternalLogger.CallStatic(methodName:  1368917616, args:  472754880);
        }
        public static void w(string message)
        {
            null = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = Helpshift.HelpshiftInternalLogger.TAG;
            typeof(System.Object[]).__il2cppRuntimeField_14 = message;
            Helpshift.HelpshiftInternalLogger.hsInternalLogger.CallStatic(methodName:  501972448, args:  472754880);
        }
        public static void f(string message)
        {
            null = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = Helpshift.HelpshiftInternalLogger.TAG;
            typeof(System.Object[]).__il2cppRuntimeField_14 = message;
            Helpshift.HelpshiftInternalLogger.hsInternalLogger.CallStatic(methodName:  502092720, args:  472754880);
        }
        public HelpshiftInternalLogger()
        {
        
        }
        private static HelpshiftInternalLogger()
        {
            Helpshift.HelpshiftInternalLogger.TAG = "HelpshiftUnityPlugin";
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  502321008);
            Helpshift.HelpshiftInternalLogger.hsInternalLogger = null;
        }
    
    }

}
