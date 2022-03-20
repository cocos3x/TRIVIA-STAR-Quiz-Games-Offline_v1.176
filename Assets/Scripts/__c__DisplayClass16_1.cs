using UnityEngine;
private sealed class GiftRewardUI.<>c__DisplayClass16_1
{
    // Fields
    public UnityEngine.GameObject petCardGroup;
    public WADPets.WADPet pet;
    public float endProgressValue;
    public WADPets.WADPetUpgradeRequirement upgradeRequirement;
    
    // Methods
    public GiftRewardUI.<>c__DisplayClass16_1()
    {
    
    }
    internal void <CreateRewardReveals>b__3()
    {
        object val_1 = this.petCardGroup.GetComponent<System.Object>();
        this.petCardGroup.OnPetCardRewardAction(pet:  this.pet, endProgressValue:  null, upgradeRequirement:  this.endProgressValue);
    }
    internal void <CreateRewardReveals>b__4()
    {
        if((this.endProgressValue.Equals(obj:  null)) != false)
        {
                if(this.pet.IsUnlocked == false)
        {
            goto label_14;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WADPets.WADPet val_3 = GetAnyUpgradeablePet(onlyUnlockable:  true);
        label_14:
        if((public static WADPetsManager MonoSingleton<WADPetsManager>::get_Instance()) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowPetUnlockedPopup(pet:  -1929661328);
        }
        
        if(WADPetsManager.IsAnyPetHungry() == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowFeedYourPetsPopup();
    }

}
