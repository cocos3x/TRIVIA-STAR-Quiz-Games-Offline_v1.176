using UnityEngine;
public class NotificationCenter : MonoBehaviour
{
    // Fields
    private static bool isQuitting;
    private static NotificationCenter defaultCenter;
    private static UnityEngine.GameObject objectContainer;
    private System.Collections.Hashtable notifications;
    
    // Properties
    public static NotificationCenter DefaultCenter { get; }
    
    // Methods
    private void Awake()
    {
        UnityEngine.GameObject val_6;
        var val_7;
        var val_8;
        val_6 = 1152921504866058240;
        val_7 = null;
        val_7 = null;
        if(NotificationCenter.objectContainer != 0)
        {
                UnityEngine.GameObject val_2 = this.gameObject;
            val_8 = null;
            val_8 = null;
            val_6 = NotificationCenter.objectContainer;
            if(1809369408 != val_6)
        {
                UnityEngine.GameObject val_4 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  1809369408);
            return;
        }
        
        }
        
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_5 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  1809369408, method:  new IntPtr(1809344384));
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
    }
    private void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        null = null;
        UnityEngine.GameObject val_1 = this.gameObject;
        if(NotificationCenter.objectContainer == 1809485504)
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  1809485504);
    }
    private void OnDestroy()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  1809601600, method:  new IntPtr(1809344384));
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  162459648);
    }
    public static NotificationCenter get_DefaultCenter()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        if(UnityEngine.Application.isPlaying != false)
        {
                val_5 = null;
            val_5 = null;
            if((UnityEngine.Object.op_Implicit(exists:  NotificationCenter.defaultCenter)) != true)
        {
                val_6 = null;
            val_6 = null;
            if(NotificationCenter.isQuitting != true)
        {
                UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  1809689600);
            val_7 = null;
            val_7 = null;
            NotificationCenter.objectContainer = null;
            object val_4 = AddComponent<System.Object>();
            NotificationCenter.defaultCenter = NotificationCenter.objectContainer;
            UnityEngine.Object.DontDestroyOnLoad(target:  157720576);
        }
        
        }
        
        }
        
        val_8 = null;
        val_8 = null;
    }
    public void OnApplicationQuit()
    {
        null = null;
        NotificationCenter.isQuitting = true;
    }
    public void AddObserver(UnityEngine.Component observer, string name)
    {
        this.AddObserver(observer:  observer, name:  name, sender:  null);
    }
    public void AddObserver(UnityEngine.Component observer, string name, UnityEngine.Component sender)
    {
        if((System.String.IsNullOrEmpty(value:  name)) == true)
        {
                return;
        }
        
        if(this.notifications == 0)
        {
                System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        }
        
        if((0.Contains(item:  observer)) != false)
        {
                return;
        }
        
        0.Add(item:  observer);
    }
    public void RemoveObserver(UnityEngine.Component observer, string name)
    {
        ZooTile val_4;
        System.Collections.Hashtable val_5;
        val_4 = observer;
        val_5 = this.notifications;
        if(val_5 == 0)
        {
                return;
        }
    
    }
    public void PostNotificationDelayed(UnityEngine.Component aSender, string aName, System.Collections.Hashtable aData, float delay = 1)
    {
        float val_1;
        System.Collections.IEnumerator val_2 = this.PostNotificationDelay(aSender:  aSender, aName:  aName, aData:  aData, delay:  val_1);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  1810381248);
    }
    private System.Collections.IEnumerator PostNotificationDelay(UnityEngine.Component aSender, string aName, System.Collections.Hashtable aData, float delay = 1)
    {
        float val_1;
        typeof(NotificationCenter.<PostNotificationDelay>d__14).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(NotificationCenter.<PostNotificationDelay>d__14).__il2cppRuntimeField_20 = aData;
        }
        else
        {
                mem[20] = this;
            mem[24] = aSender;
            mem[28] = aName;
            mem[32] = aData;
        }
        
        typeof(NotificationCenter.<PostNotificationDelay>d__14).__il2cppRuntimeField_10 = val_1;
    }
    public void PostNotification(UnityEngine.Component aSender, string aName)
    {
        this.PostNotification(aSender:  aSender, aName:  aName, aData:  0);
    }
    public void PostNotification(UnityEngine.Component aSender, string aName, System.Collections.Hashtable aData)
    {
        object val_1 = new System.Object();
        typeof(Notification).__il2cppRuntimeField_8 = aSender;
        typeof(Notification).__il2cppRuntimeField_C = aName;
        typeof(Notification).__il2cppRuntimeField_10 = aData;
        this.PostNotification(aNotification:  259317760);
    }
    public void PostNotification(Notification aNotification)
    {
        com.adjust.sdk.JSONNode val_6;
        if((System.String.IsNullOrEmpty(value:  aNotification.name)) == true)
        {
                return;
        }
        
        35653815 = aNotification.name;
        if(this.notifications == 0)
        {
                return;
        }
        
        return;
        label_19:
        if(MoveNext() == false)
        {
            goto label_18;
        }
        
        bool val_7 = this.notifications.Remove(item:  val_6);
        goto label_19;
        label_18:
        Dispose();
    }
    public NotificationCenter()
    {
        this.notifications = new System.Collections.Hashtable();
    }
    private static NotificationCenter()
    {
    
    }

}
