using UnityEngine;
public class GoldenCurrencyCollectAnimationInstantiator : CurrencyCollectAnimationInstantiator
{
    // Methods
    protected override UnityEngine.GameObject GetPrefabFromTheme()
    {
        if(R2 != 0)
        {
                ThemesHandler val_2 = App.ThemesHandler;
            if(2621443 != 0)
        {
                return 2621443.GoldenCurrencyStatViewPrefab_anchored;
        }
        
            return 2621443.GoldenCurrencyStatViewPrefab_anchored;
        }
        
        ThemesHandler val_3 = App.ThemesHandler;
        if(2621443 != 0)
        {
                return 2621443.GoldenCurrencyStatViewPrefab;
        }
        
        return 2621443.GoldenCurrencyStatViewPrefab;
    }
    protected override UnityEngine.GameObject GetParticleSystemPrefabFromTheme()
    {
        ThemesHandler val_1 = App.ThemesHandler;
        if(2621443 != 0)
        {
                return 2621443.GoldCurrencyParticleSystem;
        }
        
        return 2621443.GoldCurrencyParticleSystem;
    }
    protected override void OverrideStatViewPostion(UnityEngine.RectTransform rectTransform)
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public GoldenCurrencyCollectAnimationInstantiator()
    {
    
    }

}
