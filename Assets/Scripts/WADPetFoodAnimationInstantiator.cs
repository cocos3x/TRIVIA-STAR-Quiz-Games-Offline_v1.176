using UnityEngine;
public class WADPetFoodAnimationInstantiator : CurrencyCollectAnimationInstantiator
{
    // Methods
    protected override UnityEngine.GameObject GetPrefabFromTheme()
    {
        if(R2 != 0)
        {
                ThemesHandler val_2 = App.ThemesHandler;
            if(2621443 != 0)
        {
                return 2621443.PetsFoodStatViewPrefab_anchored;
        }
        
            return 2621443.PetsFoodStatViewPrefab_anchored;
        }
        
        ThemesHandler val_3 = App.ThemesHandler;
        if(2621443 != 0)
        {
                return 2621443.PetsFoodStatViewPrefab;
        }
        
        return 2621443.PetsFoodStatViewPrefab;
    }
    protected override UnityEngine.GameObject GetParticleSystemPrefabFromTheme()
    {
        ThemesHandler val_1 = App.ThemesHandler;
        if(2621443 != 0)
        {
                return 2621443.PetsFoodCurrencyParticleSystem;
        }
        
        return 2621443.PetsFoodCurrencyParticleSystem;
    }
    public WADPetFoodAnimationInstantiator()
    {
    
    }

}
