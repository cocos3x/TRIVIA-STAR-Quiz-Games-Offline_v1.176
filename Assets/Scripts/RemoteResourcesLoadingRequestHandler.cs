using UnityEngine;
public class RemoteResourcesLoadingRequestHandler : MonoBehaviour
{
    // Fields
    public UnityEngine.Networking.UnityWebRequest req;
    public System.Action<bool, byte[]> callback;
    
    // Methods
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  -225694400);
    }
    private System.Collections.IEnumerator Start()
    {
        object val_1 = new System.Object();
        typeof(RemoteResourcesLoadingRequestHandler.<Start>d__3).__il2cppRuntimeField_8 = 0;
        typeof(RemoteResourcesLoadingRequestHandler.<Start>d__3).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator ExecuteRequest()
    {
        object val_1 = new System.Object();
        typeof(RemoteResourcesLoadingRequestHandler.<ExecuteRequest>d__4).__il2cppRuntimeField_8 = 0;
        typeof(RemoteResourcesLoadingRequestHandler.<ExecuteRequest>d__4).__il2cppRuntimeField_10 = this;
    }
    private void CleanupRequest()
    {
        this.req = 0;
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  -225358400);
    }
    public RemoteResourcesLoadingRequestHandler()
    {
    
    }

}
