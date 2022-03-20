using UnityEngine;
public class SpinsCollectAnimationInstantiator : CurrencyCollectAnimationInstantiator
{
    // Methods
    protected override UnityEngine.GameObject GetPrefabFromTheme()
    {
        ThemesHandler val_1 = App.ThemesHandler;
        if(2621443 != 0)
        {
                return 2621443.SpinCurrencyStatViewPrefab;
        }
        
        return 2621443.SpinCurrencyStatViewPrefab;
    }
    protected override UnityEngine.GameObject GetParticleSystemPrefabFromTheme()
    {
        ThemesHandler val_1 = App.ThemesHandler;
        if(2621443 != 0)
        {
                return 2621443.SpinCurrencyParticleSystem;
        }
        
        return 2621443.SpinCurrencyParticleSystem;
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
    public SpinsCollectAnimationInstantiator()
    {
    
    }

}
