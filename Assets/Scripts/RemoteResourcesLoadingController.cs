using UnityEngine;
public class RemoteResourcesLoadingController
{
    // Methods
    public static void DownloadItem(string uri, string fileName, string fileExtention, string localDirectory, System.Action<bool, byte[]> callback)
    {
        RemoteResourcesLoadingController.CreateRequest(uri:  uri, fileName:  fileName, fileExtention:  fileExtention, localDirectory:  localDirectory, callback:  callback);
    }
    private static void CreateRequest(string uri, string fileName, string fileExtention, string localDirectory, System.Action<bool, byte[]> callback)
    {
        if(new System.Object() != 0)
        {
            
        }
        else
        {
                mem[8] = fileName;
            mem[12] = fileExtention;
            mem[16] = localDirectory;
        }
        
        typeof(RemoteResourcesLoadingController.<>c__DisplayClass1_0).__il2cppRuntimeField_14 = callback;
        UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  uri);
        object val_3 = AddComponent<System.Object>();
        UnityEngine.Networking.UnityWebRequest val_4 = UnityEngine.Networking.UnityWebRequest.Get(uri:  uri);
        uri.timeout = 30;
        typeof(UnityEngine.GameObject).__il2cppRuntimeField_C = uri;
        System.Action<System.Boolean, TRVQuizProgress> val_5 = new System.Action<System.Boolean, TRVQuizProgress>(object:  377954304, method:  new IntPtr(4068622720));
        typeof(UnityEngine.GameObject).__il2cppRuntimeField_10 = null;
    }
    public RemoteResourcesLoadingController()
    {
    
    }

}
