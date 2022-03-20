using UnityEngine;
public class WebGLDeeplinkComponent : DeeplinkComponent
{
    // Fields
    private bool deeplinkParsed;
    
    // Methods
    public WebGLDeeplinkComponent(string gameName, string gameObjectName)
    {
        mem[1152921511252164928] = "WebGLDeeplinkComponent";
        gameObjectName.m_firstChar = this;
        mem[2] = 35863;
    }
    protected override void PerformAction()
    {
        this.deeplinkParsed = true;
        DeeplinkAction val_1 = DeeplinkPlugin.GetAction();
        this.ParseDeeplink(action:  0, source:  4);
    }
    public override void onApplicationPause(bool pauseStatus)
    {
        if(pauseStatus == true)
        {
                return;
        }
        
        goto typeof(WebGLDeeplinkComponent).__il2cppRuntimeField_114;
    }
    private void CheckForDeeplinkInURL()
    {
        this.deeplinkParsed = true;
        DeeplinkAction val_1 = DeeplinkPlugin.GetAction();
        this.ParseDeeplink(action:  0, source:  4);
    }

}
