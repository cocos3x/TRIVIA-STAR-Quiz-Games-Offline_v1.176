using UnityEngine;
private sealed class SRSceneServiceBase.<LoadCoroutine>d__11<T, TImpl> : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SRF.Service.SRSceneServiceBase<T, TImpl> <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SRSceneServiceBase.<LoadCoroutine>d__11<T, TImpl>(int <>1__state)
    {
        mem[1152921513598936968] = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_13 = this;
        val_14 = 0;
        if(true == 1)
        {
            goto label_1;
        }
        
        if(true != 0)
        {
                return (bool)val_14;
        }
        
        mem[1152921513599161272] = 0;
        val_14 = 0;
        if(static_value_021FF514 != 0)
        {
                return (bool)val_14;
        }
        
        val_15 = null;
        val_15 = null;
        int val_13 = SRF.Service.SRServiceManager.LoadingCount;
        val_13 = val_13 + 1;
        SRF.Service.SRServiceManager.LoadingCount = val_13;
        UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetSceneByName(name:  static_value_021FF4F0);
        if(val_2.m_Handle.isLoaded == true)
        {
            goto label_15;
        }
        
        val_14 = 1;
        UnityEngine.AsyncOperation val_4 = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  static_value_021FF4F0, mode:  1);
        mem[1152921513599161272] = val_14;
        mem[1152921513599161276] = true;
        return (bool)val_14;
        label_1:
        mem[1152921513599161272] = 0;
        label_15:
        UnityEngine.GameObject val_5 = UnityEngine.GameObject.Find(name:  static_value_021FF4F0);
        if(static_value_021FF4F0 != 0)
        {
                if(static_value_021FF4F0 != 0)
        {
            goto label_22;
        }
        
        }
        
        val_16 = null;
        val_16 = null;
        int val_14 = SRF.Service.SRServiceManager.LoadingCount;
        val_14 = val_14 - 1;
        SRF.Service.SRServiceManager.LoadingCount = val_14;
        val_13 = true;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_13;
        val_14 = 0;
        string val_8 = SRF.SRFStringExtensions.Fmt(formatString:  402355392, args:  472754880);
        UnityEngine.Debug.LogError(message:  402355392, context:  static_value_021FF4F0);
        static_value_021FF4F0.enabled = false;
        return (bool)val_14;
        label_22:
        UnityEngine.Transform val_9 = static_value_021FF4F0.transform;
        UnityEngine.Transform val_10 = static_value_021FF4F0.CachedTransform;
        static_value_021FF4F0.parent = static_value_021FF4F0;
        UnityEngine.Object.DontDestroyOnLoad(target:  static_value_021FF4F0);
        System.Type val_11 = static_value_021FF4F0.GetType();
        typeof(System.Object[]).__il2cppRuntimeField_10 = true;
        val_13 = true;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_13;
        string val_12 = SRF.SRFStringExtensions.Fmt(formatString:  402355536, args:  472754880);
        val_14 = 0;
        UnityEngine.Debug.Log(message:  402355536, context:  static_value_021FF4F0);
        val_17 = null;
        val_17 = null;
        int val_15 = SRF.Service.SRServiceManager.LoadingCount;
        val_15 = val_15 - 1;
        SRF.Service.SRServiceManager.LoadingCount = val_15;
        return (bool)val_14;
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
