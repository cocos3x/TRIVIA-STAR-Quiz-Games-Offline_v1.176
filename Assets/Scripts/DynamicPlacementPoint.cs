using UnityEngine;
public class DynamicPlacementPoint : MonoBehaviour
{
    // Fields
    private DynamicPlacementLocation myLocation;
    
    // Methods
    private void Start()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2009104640) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TryToAddPlacementPoint(dPP:  -2009075520, dPL:  this.myLocation);
    }
    public void PlaceObject(UnityEngine.GameObject obj)
    {
        float val_9;
        UnityEngine.Transform val_1 = obj.transform;
        UnityEngine.Transform val_2 = this.transform;
        obj.SetParent(p:  -2008955328);
        UnityEngine.Transform val_3 = obj.transform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        obj.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_5 = obj.transform;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        obj.localPosition = new UnityEngine.Vector3();
        UnityEngine.Transform val_7 = obj.transform;
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.identity;
        obj.localRotation = new UnityEngine.Quaternion() {w = val_9};
        UnityEngine.GameObject val_10 = obj.gameObject;
        obj.SetActive(value:  true);
    }
    private void OnDestroy()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2009104640) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        RemovePlacementPoint(dPP:  -2008835136, dPL:  this.myLocation);
    }
    public DynamicPlacementPoint()
    {
    
    }

}
