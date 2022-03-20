using UnityEngine;
public class CoinCurrencyCollectAnimationInstantiator : CurrencyCollectAnimationInstantiator
{
    // Methods
    protected override UnityEngine.GameObject GetPrefabFromTheme()
    {
        if(R2 != 0)
        {
                ThemesHandler val_2 = App.ThemesHandler;
            if(2621443 != 0)
        {
                return 2621443.CoinCurrencyStatViewPrefab_anchored;
        }
        
            return 2621443.CoinCurrencyStatViewPrefab_anchored;
        }
        
        ThemesHandler val_3 = App.ThemesHandler;
        if(2621443 != 0)
        {
                return 2621443.CoinCurrencyStatViewPrefab;
        }
        
        return 2621443.CoinCurrencyStatViewPrefab;
    }
    protected override UnityEngine.GameObject GetParticleSystemPrefabFromTheme()
    {
        ThemesHandler val_1 = App.ThemesHandler;
        if(2621443 != 0)
        {
                return 2621443.CoinCurrencyParticleSystem;
        }
        
        return 2621443.CoinCurrencyParticleSystem;
    }
    protected override bool ShouldCreate()
    {
        return true;
    }
    protected override void OverrideStatViewPostion(UnityEngine.RectTransform rectTransform)
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public CoinCurrencyCollectAnimationInstantiator()
    {
    
    }

}
