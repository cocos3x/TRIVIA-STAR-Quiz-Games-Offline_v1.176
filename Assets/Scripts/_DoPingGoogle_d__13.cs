using UnityEngine;
private sealed class NetworkConnectivityPinger.<DoPingGoogle>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public NetworkConnectivityPinger <>4__this;
    private UnityEngine.WWW <ping>5__2;
    private float <timePassed>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NetworkConnectivityPinger.<DoPingGoogle>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_27;
        float val_28;
        UnityEngine.WWW val_29;
        bool val_30;
        var val_31;
        var val_32;
        val_27 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_27;
        }
        
            this.<>1__state = 0;
            this.<>4__this.alreadyPinging = true;
            val_28 = 0f;
            UnityEngine.WWW val_1 = new UnityEngine.WWW(url:  -1915251440);
            val_29 = this;
            this.<ping>5__2 = null;
            string val_2 = url;
            string val_3 = -1915251328(-1915251328) + 190255104;
            this.<timePassed>5__3 = val_28;
        }
        else
        {
                val_29 = this.<ping>5__2;
            this.<>1__state = 0;
        }
        
        if((mem[this.<ping>5__2].isDone) == false)
        {
            goto label_7;
        }
        
        if((this.<>4__this) != 0)
        {
            goto label_9;
        }
        
        goto label_9;
        label_7:
        if((this.<>4__this) < 0)
        {
            goto label_11;
        }
        
        label_9:
        if((this.<>4__this) >= 0)
        {
                0 = 1;
        }
        
        typeof(System.String[]).__il2cppRuntimeField_10 = "PING: ";
        float val_5 = mem[this.<ping>5__2].progress;
        float val_27 = 100f;
        val_27 = (mem[this.<ping>5__2]) * val_27;
        string val_6 = val_27.ToString();
        typeof(System.String[]).__il2cppRuntimeField_14 = ;
        typeof(System.String[]).__il2cppRuntimeField_18 = "% ";
        string val_7 = this.<timePassed>5__3.ToString();
        typeof(System.String[]).__il2cppRuntimeField_1C = this.<timePassed>5__3;
        typeof(System.String[]).__il2cppRuntimeField_20 = "s timeOut: ";
        string val_8 = 1.ToString();
        typeof(System.String[]).__il2cppRuntimeField_24 = ;
        string val_9 = +477709520;
        if(1 != 0)
        {
            goto label_64;
        }
        
        string val_10 = mem[this.<ping>5__2].error;
        if((System.String.IsNullOrEmpty(value:  mem[this.<ping>5__2])) == false)
        {
            goto label_34;
        }
        
        typeof(System.String[]).__il2cppRuntimeField_10 = "Ping Response\ntext: ";
        string val_12 = mem[this.<ping>5__2].text;
        typeof(System.String[]).__il2cppRuntimeField_14 = mem[this.<ping>5__2];
        typeof(System.String[]).__il2cppRuntimeField_18 = "\nsize: ";
        string val_14 = mem[this.<ping>5__2].size.ToString();
        typeof(System.String[]).__il2cppRuntimeField_1C = ;
        typeof(System.String[]).__il2cppRuntimeField_20 = "\nbytesDownloaded: ";
        string val_16 = mem[this.<ping>5__2].bytesDownloaded.ToString();
        typeof(System.String[]).__il2cppRuntimeField_24 = ;
        typeof(System.String[]).__il2cppRuntimeField_28 = "\nerror: ";
        string val_17 = mem[this.<ping>5__2].error;
        typeof(System.String[]).__il2cppRuntimeField_2C = mem[this.<ping>5__2];
        string val_18 = +477709520;
        goto label_64;
        label_11:
        float val_19 = UnityEngine.Time.deltaTime;
        uint val_28 = 0;
        val_28 = (this.<timePassed>5__3) + val_28;
        this.<timePassed>5__3 = val_28;
        val_27 = 1;
        this.<>1__state = val_27;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        return (bool)val_27;
        label_34:
        string val_21 = mem[this.<ping>5__2].error;
        string val_22 = -1915250560(-1915250560) + mem[this.<ping>5__2](mem[this.<ping>5__2]);
        label_64:
        val_30 = 0;
        if(((mem[this.<ping>5__2].isDone) != false) && (1 == 0))
        {
                string val_24 = mem[this.<ping>5__2].error;
            val_30 = System.String.IsNullOrEmpty(value:  mem[this.<ping>5__2]);
        }
        
        val_28 = 1152921504894439424;
        val_31 = null;
        val_31 = null;
        NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE = val_30;
        this.<>4__this.alreadyPinging = false;
        mem[this.<ping>5__2].Dispose();
        val_27 = 0;
        NotificationCenter val_26 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  this.<>4__this, aName:  -1915250464);
        if((this.<>4__this.OnPingDone) == 0)
        {
                return (bool)val_27;
        }
        
        val_32 = null;
        val_32 = null;
        this.<>4__this.OnPingDone.Invoke(obj:  NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE);
        return (bool)val_27;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
