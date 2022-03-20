using UnityEngine;
public class ExporterRuntime : MonoBehaviour
{
    // Methods
    public void ExportObj(UnityEngine.GameObject mainObj, string path, string name)
    {
        T[] val_1 = mainObj.GetComponentsInChildren<System.Object>();
        ExporterRuntimeS.ExportGOToOBJ(selection:  mainObj, mainPath:  path, filename:  name);
    }
    public ExporterRuntime()
    {
    
    }

}
