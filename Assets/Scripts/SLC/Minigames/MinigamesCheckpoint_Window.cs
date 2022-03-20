using UnityEngine;

namespace SLC.Minigames
{
    public class MinigamesCheckpoint_Window : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text descText;
        private UnityEngine.UI.Button continueButton;
        private UnityEngine.UI.Slider nextRankSlider;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  906566128, method:  new IntPtr(906541104));
            this.continueButton.m_OnClick.AddListener(call:  162246656);
        }
        private void OnClick_ContinueButton()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C.Invoke();
            UnityEngine.GameObject val_2 = this.gameObject;
            this.SetActive(value:  false);
            UnityEngine.GameObject val_3 = this.gameObject;
            SLCWindow.CloseWindow(window:  906686320, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnEnable()
        {
            var val_14;
            var val_15;
            float val_16;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.MinigameLevelRank val_3 = GetCurrentRank;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.MinigameLevelRank val_5 = GetNextRank;
            if((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance()) != 0)
            {
                    val_14 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance();
                val_16 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_20;
            }
            else
            {
                    val_14 = 32;
                val_16 = 1.171481E-37f;
                val_15 = 35615780;
            }
            
            var val_14 = 3553932;
            val_14 = val_14 - 1;
            if(3553932 <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_15 = 3553932;
            val_15 = val_15 + (val_14 << 2);
            float val_16 = (float)(3553932 + ((3553932 - 1)) << 2) + 16;
            val_16 = ((float)public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_14 + 12) / val_16;
            int val_7 = 3553932 - (public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_14.GetCheckpointsCompletedInRank());
            if(val_7 > 1)
            {
                    "Only {0} checkpoint until {1}{2}{3}" = "Only {0} checkpoints until {1}{2}{3}";
            }
            
            string val_8 = val_7.ToString();
            typeof(System.Object[]).__il2cppRuntimeField_10 = ;
            UnityEngine.Color val_9 = TitleColor;
            UnityEngine.Color32 val_10 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color());
            string val_11 = SLC.Minigames.MinigamesUtils.ColorToHex(color:  new UnityEngine.Color32() {r = val_10.r, g = val_10.g, b = val_10.b, a = val_10.a});
            string val_12 = System.String.Format(format:  906778704, arg0:  val_10.r);
            typeof(System.Object[]).__il2cppRuntimeField_14 = "<color=#{0}>";
            typeof(System.Object[]).__il2cppRuntimeField_18 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_1C;
            typeof(System.Object[]).__il2cppRuntimeField_1C = "</color>";
            string val_13 = System.String.Format(format:  906778416, args:  472754880);
            if(mem[1152921514103584380] != 0)
            {
                    return;
            }
        
        }
        public MinigamesCheckpoint_Window()
        {
        
        }
    
    }

}
