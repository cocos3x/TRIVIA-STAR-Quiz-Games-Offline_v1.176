using UnityEngine;
public class WADPetCardAnimationInstantiator : CurrencyCollectAnimationInstantiator
{
    // Methods
    protected override UnityEngine.GameObject GetPrefabFromTheme()
    {
        if(R2 != 0)
        {
                ThemesHandler val_2 = App.ThemesHandler;
            if(2621443 != 0)
        {
                return 2621443.PetCardsStatViewPrefab_anchored;
        }
        
            return 2621443.PetCardsStatViewPrefab_anchored;
        }
        
        ThemesHandler val_3 = App.ThemesHandler;
        if(2621443 != 0)
        {
                return 2621443.PetsCardStatViewPrefab;
        }
        
        return 2621443.PetsCardStatViewPrefab;
    }
    protected override UnityEngine.GameObject GetParticleSystemPrefabFromTheme()
    {
        ThemesHandler val_1 = App.ThemesHandler;
        if(2621443 != 0)
        {
                return 2621443.PetsCardCurrencyParticleSystem;
        }
        
        return 2621443.PetsCardCurrencyParticleSystem;
    }
    public WADPetCardAnimationInstantiator()
    {
    
    }

}
