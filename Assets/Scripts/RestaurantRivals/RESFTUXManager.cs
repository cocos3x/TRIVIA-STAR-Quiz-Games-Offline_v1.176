using UnityEngine;

namespace RestaurantRivals
{
    public class RESFTUXManager : MonoSingleton<RestaurantRivals.RESFTUXManager>
    {
        // Fields
        public static RestaurantRivals.RESFTUXPlayDemoPopup slotPlayDemoPopup;
        public static RestaurantRivals.RESFTUXManager.RESFTUXType CurrentSlotPlayFTUXType;
        
        // Methods
        public override void InitMonoSingleton()
        {
            null = null;
            RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType = 0;
        }
        public void ShowFTUX(RestaurantRivals.RESFTUXManager.RESFTUXType FTUXType, System.Action onComplete)
        {
            null = null;
            RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType = FTUXType;
            System.Collections.IEnumerator val_1 = ShowPopup(onComplete:  onComplete);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  424390656);
        }
        public static int CompleteFTUX(RestaurantRivals.RESFTUXManager.RESFTUXType FTUXType)
        {
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            mem[300] = MonoExtensions.SetBit(value:  6, bit:  FTUXType);
            Player val_4 = App.Player;
            0.SaveState();
            RestaurantRivals.RESPlayer val_5 = RestaurantRivals.RESPlayer.Instance;
            if(0 != 0)
            {
                    return (int)mem[300];
            }
            
            return (int)mem[300];
        }
        public static bool IsCompleteFTUX(RestaurantRivals.RESFTUXManager.RESFTUXType FTUXType)
        {
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            if(0 != 0)
            {
                    return MonoExtensions.IsBitSet(value:  6, bit:  FTUXType);
            }
            
            return MonoExtensions.IsBitSet(value:  6, bit:  FTUXType);
        }
        private System.Collections.IEnumerator ShowPopup(System.Action onComplete)
        {
            object val_1 = new System.Object();
            typeof(RESFTUXManager.<ShowPopup>d__7).__il2cppRuntimeField_8 = 0;
            typeof(RESFTUXManager.<ShowPopup>d__7).__il2cppRuntimeField_10 = onComplete;
        }
        public void ShowMessageByName(RestaurantRivals.RESFTUXManager.RESFTUXType ftuxType)
        {
            System.Collections.IEnumerator val_1 = this.startShowMessage(ftuxType:  ftuxType);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  541415456);
        }
        private System.Collections.IEnumerator startShowMessage(RestaurantRivals.RESFTUXManager.RESFTUXType ftuxType)
        {
            typeof(RESFTUXManager.<startShowMessage>d__9).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(RESFTUXManager.<startShowMessage>d__9).__il2cppRuntimeField_14 = this;
            }
            else
            {
                    mem[20] = this;
            }
            
            typeof(RESFTUXManager.<startShowMessage>d__9).__il2cppRuntimeField_10 = ftuxType;
        }
        public RESFTUXManager()
        {
        
        }
        private static RESFTUXManager()
        {
        
        }
    
    }

}
