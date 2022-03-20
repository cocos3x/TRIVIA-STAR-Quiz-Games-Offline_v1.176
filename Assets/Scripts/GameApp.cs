using UnityEngine;
public struct InstalledAppsPlugin.GameApp
{
    // Fields
    private string uniqueName;
    private string packageName;
    private string assetName;
    public bool isInstalled;
    
    // Methods
    public InstalledAppsPlugin.GameApp(string gameName, string packageName, string assetName)
    {
        this = gameName;
        this.isInstalled = twelvegigs.plugins.InstalledAppsPlugin.IsInstalled(packageToCheck:  packageName);
    }
    public string GetGameName()
    {
    
    }
    public string GetPackageName()
    {
    
    }
    public string GetAssetName()
    {
    
    }

}
