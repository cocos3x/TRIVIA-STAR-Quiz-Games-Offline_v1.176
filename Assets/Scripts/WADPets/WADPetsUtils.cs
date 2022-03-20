using UnityEngine;

namespace WADPets
{
    public class WADPetsUtils : ScriptableObject
    {
        // Fields
        private System.Collections.Generic.List<WADPets.WADPetInfo> PetsInfo;
        public System.Collections.Generic.List<WADPets.WADPetUpgradeRequirement> UpgradeRequirements;
        private static System.Collections.Generic.List<WADPets.WADPet> allPetsInfo;
        
        // Properties
        public System.Collections.Generic.List<WADPets.WADPet> AllPetsInfo { get; }
        
        // Methods
        public System.Collections.Generic.List<WADPets.WADPet> get_AllPetsInfo()
        {
            WADPets.WADPetInfo val_4;
            var val_6;
            val_6 = 1152921505038741504;
            if(WADPets.WADPetsUtils.allPetsInfo != 0)
            {
                    return;
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            WADPets.WADPetsUtils.allPetsInfo = null;
            List.Enumerator<T> val_2 = GetEnumerator();
            label_5:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            WADPets.WADPet val_5 = new WADPets.WADPet(info:  val_4);
            Add(item:  431468544);
            goto label_5;
            label_3:
            Dispose();
            val_6 = 1152921505038741504;
        }
        public static void QHACK_ResetWADPetsCollection()
        {
            WADPets.WADPetsUtils.allPetsInfo = 0;
        }
        public WADPetsUtils()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.PetsInfo = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.UpgradeRequirements = null;
        }
    
    }

}
