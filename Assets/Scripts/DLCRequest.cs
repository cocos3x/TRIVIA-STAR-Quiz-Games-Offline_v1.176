using UnityEngine;
public class DLCManager.DLCRequest
{
    // Fields
    public string asset;
    public string assetPath;
    public int assetVersion;
    public System.Action<UnityEngine.AssetBundle> OnDownloadedCallback;
    
    // Methods
    public DLCManager.DLCRequest(string bundleName, string bundlePath, int bundleVersion, System.Action<UnityEngine.AssetBundle> onDownloadedCallback)
    {
        val_1 = new System.Object();
        this.asset = bundleName;
        this.assetPath = val_1;
        this.assetVersion = bundleVersion;
        this.OnDownloadedCallback = onDownloadedCallback;
    }

}
