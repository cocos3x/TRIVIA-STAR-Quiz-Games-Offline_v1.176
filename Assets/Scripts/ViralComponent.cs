using UnityEngine;
public class ViralComponent : AppComponent
{
    // Fields
    private bool initializedInstalledAppsPlugin;
    
    // Properties
    public override bool RunInMainThread { get; }
    public bool InstalledAppsPluginInitialized { get; }
    
    // Methods
    public override bool get_RunInMainThread()
    {
        return true;
    }
    public bool get_InstalledAppsPluginInitialized()
    {
        return (bool)this.initializedInstalledAppsPlugin;
    }
    public void InitializeInstalledAppsPlugin()
    {
        twelvegigs.plugins.InstalledAppsPlugin.Init();
        AppIndexingPlugin.LogStartSession();
        this.initializedInstalledAppsPlugin = true;
    }
    public ViralComponent(string gameName, string gameObjectName)
    {
        mem[1152921511251924432] = "ViralComponent";
    }
    public override void initializeOnMainThread()
    {
        if(this.initializedInstalledAppsPlugin == true)
        {
                return;
        }
        
        this.InitializeInstalledAppsPlugin();
    }

}
