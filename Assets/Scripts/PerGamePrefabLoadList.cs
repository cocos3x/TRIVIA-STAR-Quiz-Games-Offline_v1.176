using UnityEngine;
public class PerGamePrefabLoadList : MonoBehaviour
{
    // Fields
    public string description;
    public string prefabPrefix;
    public string subPath;
    public System.Collections.Generic.List<string> prefabList;
    
    // Methods
    public PerGamePrefabLoadList()
    {
        this.description = "";
        this.subPath = "ui";
    }

}
