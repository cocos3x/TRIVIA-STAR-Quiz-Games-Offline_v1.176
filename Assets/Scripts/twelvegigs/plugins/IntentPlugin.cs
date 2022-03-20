using UnityEngine;

namespace twelvegigs.plugins
{
    public class IntentPlugin : MonoBehaviour
    {
        // Fields
        private static twelvegigs.plugins.IntentPlugin.Goal[] availableTask;
        public static GlobalGameNames.GameNames[] VIPEarlyUnlockGames;
        
        // Properties
        public static twelvegigs.plugins.IntentPlugin.Goal[] AvailableTask { get; }
        
        // Methods
        public static twelvegigs.plugins.IntentPlugin.Goal[] get_AvailableTask()
        {
            null = null;
        }
        public static bool isTaskAvailable(twelvegigs.plugins.IntentPlugin.Goal goal)
        {
            null = null;
            var val_1 = 0;
            do
            {
                if(val_1 >= (twelvegigs.plugins.IntentPlugin.availableTask + 12))
            {
                    return false;
            }
            
                val_1 = val_1 + 1;
            }
            while((R6 + 0) != goal);
            
            return true;
        }
        public static void showCalendar(string machineName, string machineDisplayName)
        {
        
        }
        public static void showIntent(twelvegigs.plugins.IntentPlugin.Network network, string text = "", string filePath, System.Collections.Generic.Dictionary<string, object> intentParams)
        {
            var val_4;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_1 = ToUpper();
            UnityEngine.AndroidJavaClass val_2 = new UnityEngine.AndroidJavaClass(className:  1144996736);
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_4 == 1)
            {
                    val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_3 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            typeof(System.Object[]).__il2cppRuntimeField_14 = text;
            typeof(System.Object[]).__il2cppRuntimeField_18 = filePath;
            Call(methodName:  1144996880, args:  472754880);
        }
        public static bool isAppInstalledInDevice(twelvegigs.plugins.IntentPlugin.Network network)
        {
            var val_3;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1144996736);
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_3 == 1)
            {
                    val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            if(network != 0)
            {
                    return false;
            }
            
            if(null != 0)
            {
                    return Call<System.Boolean>(methodName:  1145129456, args:  472754880);
            }
            
            return Call<System.Boolean>(methodName:  1145129456, args:  472754880);
        }
        private static string defaultMachineName(string key)
        {
            var val_3;
            if((System.String.op_Equality(a:  key, b:  1145249760)) != false)
            {
                    val_3 = "Richard III";
                return;
            }
            
            if((System.String.op_Equality(a:  key, b:  1145249952)) == false)
            {
                    return System.Text.RegularExpressions.Regex.Replace(input:  key, pattern:  1145250224, replacement:  1145250144);
            }
            
            val_3 = "Much Ado About Nothing";
        }
        public static void mediaScanIntent(string filePath)
        {
            var val_3;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1144996736);
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_3 == 1)
            {
                    val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            typeof(System.Object[]).__il2cppRuntimeField_10 = filePath;
            Call(methodName:  1145370512, args:  472754880);
        }
        public IntentPlugin()
        {
        
        }
        private static IntentPlugin()
        {
            twelvegigs.plugins.IntentPlugin.availableTask = null;
            typeof(GlobalGameNames.GameNames[]).__il2cppRuntimeField_10 = 4;
            twelvegigs.plugins.IntentPlugin.VIPEarlyUnlockGames = null;
        }
    
    }

}
