using UnityEngine;
public class DebugMessageDisplay : MonoSingleton<DebugMessageDisplay>
{
    // Fields
    public UnityEngine.UI.Text textMessage;
    public UnityEngine.CanvasGroup canvasGroup;
    
    // Methods
    private void Start()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  -913376848);
    }
    private static void SelfInstantiate()
    {
        var val_7;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-913288848) != 0)
        {
                return;
        }
        
        val_7 = 0;
        System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(157720576)});
        UnityEngine.Object val_4 = UnityEngine.Resources.Load(path:  -913287824, systemTypeInstance:  157720576);
        if(("prefabs/DebugMessageDisplay") != 0)
        {
                if(("prefabs/DebugMessageDisplay") != null)
        {
                "prefabs/DebugMessageDisplay" = 0;
        }
        
            val_7 = "prefabs/DebugMessageDisplay";
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
        {
                object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  0);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -913287696);
    }
    public static void DisplayMessage(string msgTxt, float displayTime = 3)
    {
        DebugMessageDisplay.SelfInstantiate();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  -913288848)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowMessage(msgTxt:  msgTxt, displayTime:  displayTime);
    }
    private void ShowMessage(string msgTxt, float displayTime)
    {
        UnityEngine.GameObject val_1 = this.canvasGroup.gameObject;
        this.canvasGroup.SetActive(value:  true);
        this.FadeCanvas(from:  displayTime, to:  null, duration:  null);
        System.Collections.IEnumerator val_2 = this.WaitAndHide(displayTime:  displayTime);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  -913019040);
    }
    private void HideMessage()
    {
        this.FadeCanvas(from:  null, to:  null, duration:  null);
    }
    public void OnClick()
    {
        this.FadeCanvas(from:  null, to:  null, duration:  null);
    }
    private System.Collections.IEnumerator WaitAndHide(float displayTime)
    {
        typeof(DebugMessageDisplay.<WaitAndHide>d__8).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(DebugMessageDisplay.<WaitAndHide>d__8).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
        }
        
        typeof(DebugMessageDisplay.<WaitAndHide>d__8).__il2cppRuntimeField_10 = R1;
    }
    private void FadeCanvas(float from, float to, float duration)
    {
        this.StopAllCoroutines();
        System.Collections.IEnumerator val_1 = this.FadeCanvasCoroutine(from:  from, to:  to, duration:  duration);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -912558752);
    }
    private System.Collections.IEnumerator FadeCanvasCoroutine(float from, float to, float duration)
    {
        typeof(DebugMessageDisplay.<FadeCanvasCoroutine>d__10).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(DebugMessageDisplay.<FadeCanvasCoroutine>d__10).__il2cppRuntimeField_14 = this;
            typeof(DebugMessageDisplay.<FadeCanvasCoroutine>d__10).__il2cppRuntimeField_18 = R1;
            typeof(DebugMessageDisplay.<FadeCanvasCoroutine>d__10).__il2cppRuntimeField_1C = R2;
        }
        else
        {
                mem[20] = this;
            mem[24] = R1;
            mem[28] = R2;
        }
        
        typeof(DebugMessageDisplay.<FadeCanvasCoroutine>d__10).__il2cppRuntimeField_10 = R3;
    }
    public DebugMessageDisplay()
    {
    
    }

}
