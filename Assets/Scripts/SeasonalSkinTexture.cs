using UnityEngine;
public class SeasonalSkinTexture : MonoBehaviour
{
    // Fields
    private SeasonSkinnedFeature feature;
    private string textureId;
    private UnityEngine.GameObject seasonalSkinObject;
    private UnityEngine.UI.RawImage rawImage;
    private UnityEngine.GameObject[] objectsToHideWhenActive;
    
    // Methods
    private void OnEnable()
    {
        this.SetSeasonalSkin();
    }
    private void SetSeasonalSkin()
    {
        var val_3;
        var val_4;
        UnityEngine.Texture val_1 = this.TryGetSeasonalTexture();
        if((-1041009952) != 0)
        {
            goto label_3;
        }
        
        val_3 = 0;
        this.seasonalSkinObject.SetActive(value:  false);
        goto label_5;
        label_9:
        1152921507209181152.SetActive(value:  true);
        val_3 = 1;
        label_5:
        if(val_3 < 1152921507209181152)
        {
            goto label_9;
        }
        
        return;
        label_3:
        val_4 = 0;
        this.rawImage.texture = -1041009952;
        this.seasonalSkinObject.SetActive(value:  true);
        goto label_13;
        label_17:
        1152921507209181152.SetActive(value:  false);
        val_4 = 1;
        label_13:
        if(val_4 < 1152921507209181152)
        {
            goto label_17;
        }
    
    }
    private UnityEngine.Texture TryGetSeasonalTexture()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SeasonalSkin val_2 = IsSkinActive(feature:  this.feature);
        if((public static SeasonalSkinsManager MonoSingleton<SeasonalSkinsManager>::get_Instance()) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_4 = GetAssetName(textureId:  this.textureId);
        if((public static SeasonalSkinsManager MonoSingleton<SeasonalSkinsManager>::get_Instance()) != 0)
        {
                return GetTexture(assetName:  -1040835936);
        }
        
        return GetTexture(assetName:  -1040835936);
    }
    public SeasonalSkinTexture()
    {
        this.textureId = "";
    }

}
