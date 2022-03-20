using UnityEngine;
public class AppComponent
{
    // Fields
    protected string GAME_OBJECT_NAME;
    protected string gameName;
    protected string componentName;
    
    // Properties
    public virtual bool RunInMainThread { get; }
    
    // Methods
    public virtual bool get_RunInMainThread()
    {
        return false;
    }
    public AppComponent(string gameName, string gameObjectName)
    {
        val_1 = new System.Object();
        this.GAME_OBJECT_NAME = val_1;
        this.gameName = gameName;
        this.componentName = "AppComponent";
        App.AddComponent(component:  -1971859424);
    }
    public void initAsynchronous()
    {
        goto typeof(AppComponent).__il2cppRuntimeField_EC;
    }
    public virtual void initializeOnMainThread()
    {
    
    }
    public virtual void onStartApp()
    {
    
    }
    public virtual void onStartUpdate()
    {
    
    }
    public virtual void onInitialServerUpdate()
    {
    
    }
    public virtual void onServerUpdate()
    {
    
    }
    public virtual void onApplicationPause(bool pauseStatus)
    {
    
    }
    protected void Log(string message)
    {
    
    }

}
