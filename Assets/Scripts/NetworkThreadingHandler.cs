using UnityEngine;
public class NetworkThreadingHandler : MonoBehaviour
{
    // Fields
    private const int MIN_DELAY = 3;
    private const int MAX_DELAY = 4;
    public static bool HackThrottle;
    public twelvegigs.net.JsonRequest Request;
    private System.Action dequeueLogic;
    private int delayRequest;
    private int delayResponse;
    private string loadedScene;
    
    // Properties
    set; }
    
    // Methods
    public void set_DequeueLogic(System.Action value)
    {
        this.dequeueLogic = value;
    }
    private void Awake()
    {
        string val_1 = UnityEngine.Application.loadedLevelName;
        this.loadedScene = 0;
        UnityEngine.GameObject val_2 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  -1914146656);
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_3 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -1914146656, method:  new IntPtr(2380795616));
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
    }
    private System.Collections.IEnumerator Start()
    {
        object val_1 = new System.Object();
        typeof(NetworkThreadingHandler.<Start>d__12).__il2cppRuntimeField_8 = 0;
        typeof(NetworkThreadingHandler.<Start>d__12).__il2cppRuntimeField_10 = this;
    }
    private void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        if(this.Request != 0)
        {
                this.Request = this.Request._destroy;
        }
        
        if(this.Request != true)
        {
                return;
        }
        
        string val_1 = UnityEngine.Application.loadedLevelName;
        if((System.String.op_Inequality(a:  this.loadedScene, b:  null)) == false)
        {
                return;
        }
        
        mem2[0] = 0;
        if((R4 + 16) != 0)
        {
                R4 + 16.Invoke();
        }
        
        UnityEngine.GameObject val_3 = R4.gameObject;
        UnityEngine.Object.Destroy(obj:  R4);
    }
    private void Dequeue()
    {
        if(this.dequeueLogic == 0)
        {
                return;
        }
        
        this.dequeueLogic.Invoke();
    }
    private void OnDestroy()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -1913665888, method:  new IntPtr(2380795616));
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  162459648);
    }
    private System.Collections.IEnumerator SitIdle()
    {
        object val_1 = new System.Object();
        typeof(NetworkThreadingHandler.<SitIdle>d__16).__il2cppRuntimeField_8 = 0;
        typeof(NetworkThreadingHandler.<SitIdle>d__16).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator ExecuteRequest()
    {
        object val_1 = new System.Object();
        typeof(NetworkThreadingHandler.<ExecuteRequest>d__17).__il2cppRuntimeField_8 = 0;
        typeof(NetworkThreadingHandler.<ExecuteRequest>d__17).__il2cppRuntimeField_10 = this;
    }
    private void CleanupRequest()
    {
        this.Request = 0;
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  -1913325792);
        if(this.dequeueLogic == 0)
        {
                return;
        }
        
        this.dequeueLogic.Invoke();
    }
    public NetworkThreadingHandler()
    {
        this.loadedScene = System.String.alignConst;
    }
    private static NetworkThreadingHandler()
    {
    
    }

}
