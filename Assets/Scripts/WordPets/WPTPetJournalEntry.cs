using UnityEngine;

namespace WordPets
{
    public class WPTPetJournalEntry : WPTStoredPetDisplay
    {
        // Fields
        protected UnityEngine.UI.Text petName;
        
        // Methods
        private void ScrollCellIndex(int index)
        {
            UnityEngine.UI.Text val_15;
            var val_16;
            var val_18;
            val_15 = index;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(121280000 == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_4 = new System.Object();
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(val_4 != 0)
            {
                    val_16 = val_4;
                typeof(WPTPetJournalEntry.<>c__DisplayClass1_0).__il2cppRuntimeField_8 = (public static WordPets.WPTShelterController MonoSingleton<WordPets.WPTShelterController>::get_Instance().__il2cppRuntimeField_C + (index) << 2) + 16;
            }
            else
            {
                    val_16 = 8;
                mem[8] = (public static WordPets.WPTShelterController MonoSingleton<WordPets.WPTShelterController>::get_Instance().__il2cppRuntimeField_C + (index) << 2) + 16;
            }
            
            this.Setup(type:  (public static WordPets.WPTShelterController MonoSingleton<WordPets.WPTShelterController>::get_Instance().__il2cppRuntimeField_C + (index) << 2) + 16 + 20, isNew:  false);
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Predicate<WordPets.PetData> val_8 = new System.Predicate<WordPets.PetData>(object:  401756160, method:  new IntPtr(214020080));
            if((public static WordPets.WPTShelterController MonoSingleton<WordPets.WPTShelterController>::get_Instance().__il2cppRuntimeField_14.FindIndex(match:  8040448)) >= 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                UnityEngine.Color val_11 = UnityEngine.Color.white;
                val_18 = this;
                val_15 = this.petName;
                string val_12 = MonoSingleton<T>.__il2cppRuntimeField_cctor_finished.ToString();
                if(mem[8] != 0)
            {
                goto label_32;
            }
            
            }
            else
            {
                    UnityEngine.Color val_13 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
                val_18 = this;
            }
            
            label_32:
            UnityEngine.GameObject val_14 = val_15.gameObject;
            val_15.SetActive(value:  true);
        }
        public WPTPetJournalEntry()
        {
        
        }
    
    }

}
