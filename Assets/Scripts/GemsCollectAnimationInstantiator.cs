using UnityEngine;
public class GemsCollectAnimationInstantiator : CurrencyCollectAnimationInstantiator
{
    // Methods
    protected override UnityEngine.GameObject GetPrefabFromTheme()
    {
        if(R2 != 0)
        {
                ThemesHandler val_2 = App.ThemesHandler;
            if(2621443 != 0)
        {
                return 2621443.GemCurrencyStatViewPrefab_anchored;
        }
        
            return 2621443.GemCurrencyStatViewPrefab_anchored;
        }
        
        ThemesHandler val_3 = App.ThemesHandler;
        if(2621443 != 0)
        {
                return 2621443.GemCurrencyStatViewPrefab;
        }
        
        return 2621443.GemCurrencyStatViewPrefab;
    }
    protected override UnityEngine.GameObject GetParticleSystemPrefabFromTheme()
    {
        ThemesHandler val_1 = App.ThemesHandler;
        if(2621443 != 0)
        {
                return 2621443.GemCurrencyParticleSystem;
        }
        
        return 2621443.GemCurrencyParticleSystem;
    }
    protected override bool ShouldCreate()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    protected override void OverrideStatViewPostion(UnityEngine.RectTransform rectTransform)
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public GemsCollectAnimationInstantiator()
    {
    
    }

}
