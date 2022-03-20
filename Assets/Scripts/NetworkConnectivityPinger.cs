using UnityEngine;
public class NetworkConnectivityPinger : MonoSingleton<NetworkConnectivityPinger>
{
    // Fields
    private static bool _LastPingSuccess;
    public const string NOTIF_NETWORK_CONNECT_RESPONSE = "OnNetworkConnectivityResponse";
    public System.Action<bool> OnPingDone;
    private float time_between_pings;
    private float time_out;
    private float time_accum;
    private bool alreadyPinging;
    private UnityEngine.Coroutine routine;
    
    // Properties
    public static bool Connected { get; }
    
    // Methods
    public static bool get_Connected()
    {
        null = null;
        return (bool)NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE;
    }
    private void OnApplicationPause(bool pauseStatus)
    {
        if(pauseStatus != false)
        {
                if(this.routine != 0)
        {
                this.StopCoroutine(routine:  this.routine);
        }
        
            this.alreadyPinging = false;
            return;
        }
        
        this.PingGoogle();
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        uint val_2 = 0;
        val_2 = this.time_accum + val_2;
        this.time_accum = val_2;
        if()
        {
                return;
        }
        
        this.PingGoogle();
    }
    public void PingGoogle()
    {
        this.time_accum = 0f;
        if(this.alreadyPinging == true)
        {
                return;
        }
        
        mem2[0] = 1;
        if((R4 + 32) != 0)
        {
                R4.StopCoroutine(routine:  R4 + 32);
        }
        
        System.Collections.IEnumerator val_1 = R4.DoPingGoogle();
        UnityEngine.Coroutine val_2 = R4.StartCoroutine(routine:  R4);
        mem2[0] = R4;
    }
    private System.Collections.IEnumerator DoPingGoogle()
    {
        object val_1 = new System.Object();
        typeof(NetworkConnectivityPinger.<DoPingGoogle>d__13).__il2cppRuntimeField_8 = 0;
        typeof(NetworkConnectivityPinger.<DoPingGoogle>d__13).__il2cppRuntimeField_10 = this;
    }
    private void DoLog(string text)
    {
    
    }
    private void OnDestroy()
    {
    
    }
    public NetworkConnectivityPinger()
    {
        this.time_between_pings = 60f;
        this.time_out = 10f;
        this.time_accum = 60f;
    }
    private static NetworkConnectivityPinger()
    {
    
    }

}
