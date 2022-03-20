using UnityEngine;
public class HintMeterGameplayUI : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image[] fillImages;
    
    // Methods
    private void Start()
    {
        System.Action<System.Int32> val_5;
        HintMeterHandler val_6;
        System.Action<System.Int32> val_7;
        val_5 = 14442244 + 21199578;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = 1152921504931713024;
        if(HintMeterHandler._Instance == 0)
        {
                return;
        }
        
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        this.UpdateHintMeterHints(progress:  HintMeterHandler._Instance.progressTowardsFreeHint);
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = HintMeterHandler._Instance;
        val_5 = null;
        val_5 = new System.Action<System.Int32>(object:  -1206922848, method:  new IntPtr(3088019424));
        System.Delegate val_4 = System.Delegate.Combine(a:  7401472, b:  7401472);
        val_7 = HintMeterHandler._Instance.hintMeterUpdate;
        if(val_7 != 0)
        {
                if(null == null)
        {
            goto label_11;
        }
        
        }
        
        val_7 = 0;
        label_11:
        HintMeterHandler._Instance.hintMeterUpdate = val_7;
    }
    private void UpdateHintMeterHints(int progress)
    {
        var val_9;
        UnityEngine.UI.Image[] val_10;
        val_9 = 0;
        goto label_1;
        label_8:
        val_10 = this.fillImages;
        if(val_10 != null)
        {
            
        }
        else
        {
                val_10 = 0;
        }
        
        if(val_9 >= (R6 + 12))
        {
            goto label_4;
        }
        
        label_9:
        var val_1 = val_10 + 0;
        UnityEngine.GameObject val_2 = (val_10 + 0) + 16.gameObject;
        if(val_9 < progress)
        {
                0 = 1;
        }
        
        (val_10 + 0) + 16.SetActive(value:  true);
        val_9 = 1;
        label_1:
        val_10 = this.fillImages;
        if(val_10 == null)
        {
            goto label_8;
        }
        
        if(val_9 < ((val_10 + 0) + 16))
        {
            goto label_9;
        }
        
        label_4:
        if(((val_10 + 0) + 16) == progress)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -1206761120, clipIndex:  0);
            System.Collections.IEnumerator val_4 = this.AnimateFills();
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  -1206659200);
            return;
        }
        
        if(progress != 0)
        {
                return;
        }
        
        this.StopAllCoroutines();
        UnityEngine.Transform val_6 = this.transform;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        this.localScale = new UnityEngine.Vector3();
        val_9 = 0;
        goto label_19;
        label_27:
        UnityEngine.UI.Image val_10 = this.fillImages[val_9];
        UnityEngine.Transform val_8 = val_10.transform;
        val_10 = val_10;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        val_10.localScale = new UnityEngine.Vector3();
        val_9 = 1;
        label_19:
        if(val_9 < val_10)
        {
            goto label_27;
        }
    
    }
    private System.Collections.IEnumerator AnimateFills()
    {
        object val_1 = new System.Object();
        typeof(HintMeterGameplayUI.<AnimateFills>d__3).__il2cppRuntimeField_8 = 0;
        typeof(HintMeterGameplayUI.<AnimateFills>d__3).__il2cppRuntimeField_10 = this;
    }
    private void OnDestroy()
    {
        System.Action<System.Int32> val_3;
        var val_3 = 21198034;
        val_3 = 14443788 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        System.Action<System.Int32> val_1 = new System.Action<System.Int32>(object:  -1206283648, method:  new IntPtr(3088019424));
        System.Delegate val_2 = System.Delegate.Remove(source:  7401472, value:  7401472);
        val_3 = HintMeterHandler._Instance.hintMeterUpdate;
        if(val_3 != 0)
        {
                if(null == null)
        {
            goto label_5;
        }
        
        }
        
        val_3 = 0;
        label_5:
        HintMeterHandler._Instance.hintMeterUpdate = val_3;
    }
    public HintMeterGameplayUI()
    {
    
    }

}
