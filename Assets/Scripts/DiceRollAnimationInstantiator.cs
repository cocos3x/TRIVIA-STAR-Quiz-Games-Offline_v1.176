using UnityEngine;
public class DiceRollAnimationInstantiator : CurrencyCollectAnimationInstantiator
{
    // Methods
    protected override UnityEngine.GameObject GetPrefabFromTheme()
    {
        if(R2 != 0)
        {
                ThemesHandler val_2 = App.ThemesHandler;
            if(2621443 != 0)
        {
                return 2621443.DiceRollStatViewPrefab_anchored;
        }
        
            return 2621443.DiceRollStatViewPrefab_anchored;
        }
        
        ThemesHandler val_3 = App.ThemesHandler;
        if(2621443 != 0)
        {
                return 2621443.DiceRollStatViewPrefab;
        }
        
        return 2621443.DiceRollStatViewPrefab;
    }
    protected override UnityEngine.GameObject GetParticleSystemPrefabFromTheme()
    {
        ThemesHandler val_1 = App.ThemesHandler;
        if(2621443 != 0)
        {
                return 2621443.DiceRollCurrencyParticleSystem;
        }
        
        return 2621443.DiceRollCurrencyParticleSystem;
    }
    public DiceRollAnimationInstantiator()
    {
    
    }

}
