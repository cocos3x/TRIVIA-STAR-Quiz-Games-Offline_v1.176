using UnityEngine;
public class UGUIDynamicPlacementManager : MonoSingleton<UGUIDynamicPlacementManager>
{
    // Fields
    private PrefabsFromFolder prefabsFromFolder;
    private System.Collections.Generic.Dictionary<DynamicPlacementLocation, DynamicPlacementPoint> placementPoints;
    
    // Methods
    public T PlaceGameObject<T>(DynamicPlacementLocation loc = 0)
    {
        UnityEngine.GameObject val_10;
        System.Collections.Generic.Dictionary<DynamicPlacementLocation, DynamicPlacementPoint> val_11;
        var val_12;
        val_10 = this;
        val_11 = __RuntimeMethodHiddenParam;
        if(this.prefabsFromFolder == 0)
        {
                System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 8});
            val_12 = 0;
            string val_3 = -2001561680(-2001561680) + __RuntimeMethodHiddenParam + 24 + 8(__RuntimeMethodHiddenParam + 24 + 8) + 2012205360;
            UnityEngine.Debug.LogError(message:  -2001561680);
            return;
        }
        
        if(loc == 0)
        {
            goto label_11;
        }
        
        val_11 = this.placementPoints;
        if((val_11.ContainsKey(key:  loc)) == false)
        {
            goto label_13;
        }
        
        DynamicPlacementPoint val_5 = this.placementPoints.Item[loc];
        UnityEngine.GameObject val_6 = this.prefabsFromFolder.gameObject;
        val_10 = this.prefabsFromFolder;
        this.placementPoints.PlaceObject(obj:  val_10);
        goto label_17;
        label_11:
        UnityEngine.Transform val_7 = this.prefabsFromFolder.transform;
        this.prefabsFromFolder.SetParent(p:  0);
        label_17:
        val_12 = this.prefabsFromFolder;
        return;
        label_13:
        string val_8 = null.ToString();
        string val_9 = -2001551344(-2001551344) + -2001539132(-2001539132) + -2001551200(-2001551200);
        val_10 = "No placement point found/set at ";
        val_12 = 0;
        UnityEngine.Debug.LogError(message:  -2001551344);
        UnityEngine.Object.Destroy(obj:  this.prefabsFromFolder);
    }
    public void TryToAddPlacementPoint(DynamicPlacementPoint dPP, DynamicPlacementLocation dPL)
    {
        if((this.placementPoints.ContainsKey(key:  dPL)) != false)
        {
                UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_2 = -2001410416(-2001410416) + 283652096;
            UnityEngine.Debug.LogError(message:  -2001410416);
            return;
        }
        
        this.placementPoints.Add(key:  dPL, value:  dPP);
    }
    public void RemovePlacementPoint(DynamicPlacementPoint dPP, DynamicPlacementLocation dPL)
    {
        if((this.placementPoints.ContainsKey(key:  dPL)) != false)
        {
                bool val_2 = this.placementPoints.Remove(key:  dPL);
            return;
        }
        
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        string val_3 = -2001259344(-2001259344) + 283652096 + -2001259216(-2001259216);
        UnityEngine.Debug.LogError(message:  -2001259344);
    }
    public UGUIDynamicPlacementManager()
    {
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_1 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        this.placementPoints = null;
    }

}
