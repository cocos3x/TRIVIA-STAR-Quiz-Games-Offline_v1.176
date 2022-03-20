using UnityEngine;
public class WGManagerLoader : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject[] managers;
    public static bool hasLoadedManagers;
    
    // Methods
    private void Awake()
    {
        var val_13;
        var val_14;
        val_13 = null;
        val_13 = null;
        if(WGManagerLoader.hasLoadedManagers != false)
        {
                UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  13458000);
            return;
        }
        
        val_14 = 0;
        goto label_7;
        label_29:
        if(this.managers[0] == 0)
        {
                string val_3 = 0.ToString();
            string val_4 = 13356048 + 13445960;
            UnityEngine.Debug.LogError(message:  13356048, context:  13458000);
        }
        else
        {
                UnityEngine.GameObject val_14 = this.managers[0];
            UnityEngine.Transform val_5 = this.transform;
            object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  val_14, parent:  13458000);
            string val_7 = val_14.tag;
            if((val_14.Contains(value:  13314976)) != false)
        {
                UnityEngine.Transform val_9 = val_14.transform;
            val_14.parent = 0;
            UnityEngine.GameObject val_10 = val_14.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  val_14);
        }
        
        }
        
        val_14 = 0 + 1;
        label_7:
        if(val_14 < 0)
        {
            goto label_29;
        }
        
        UnityEngine.Transform val_11 = this.transform;
        this.SetParent(p:  0);
        UnityEngine.GameObject val_12 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  13458000);
    }
    private void Start()
    {
        null = null;
        WGManagerLoader.hasLoadedManagers = true;
    }
    public void KillYourself()
    {
        null = null;
        WGManagerLoader.hasLoadedManagers = false;
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  13800784);
    }
    public WGManagerLoader()
    {
    
    }
    private static WGManagerLoader()
    {
    
    }

}
