using UnityEngine;

namespace SLC.Minigames.TwistyArrow
{
    public class TwistyWheel : MonoBehaviour
    {
        // Fields
        private TMPro.TextMeshProUGUI[] WordTexts;
        private Spin WheelSpin;
        private float baseRotationSpeed;
        private float speedMultiplier;
        private const float speedMultiplierIncre = 0.25;
        private UnityEngine.AudioSource audioSource;
        private UnityEngine.AudioClip clip;
        
        // Properties
        public float SpeedMultiplier { get; }
        
        // Methods
        public float get_SpeedMultiplier()
        {
            return (float)S0;
        }
        private void Awake()
        {
            var val_6;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  1019643808, method:  new IntPtr(1019618784));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static SLC.Minigames.TwistyArrow.TwistyGameManager MonoSingleton<SLC.Minigames.TwistyArrow.TwistyGameManager>::get_Instance().__il2cppRuntimeField_14, b:  7401472);
            val_6 = public static SLC.Minigames.TwistyArrow.TwistyGameManager MonoSingleton<SLC.Minigames.TwistyArrow.TwistyGameManager>::get_Instance().__il2cppRuntimeField_14;
            if(val_6 != 0)
            {
                    if(val_6 == null)
            {
                goto label_6;
            }
            
            }
            
            val_6 = 0;
            label_6:
            public static SLC.Minigames.TwistyArrow.TwistyGameManager MonoSingleton<SLC.Minigames.TwistyArrow.TwistyGameManager>::get_Instance().__il2cppRuntimeField_14 = val_6;
            object val_4 = this.GetComponent<System.Object>();
            this.audioSource = this;
            UnityEngine.AudioClip val_5 = this.clip;
            this.clip = this;
        }
        public void Setup(string[] words, float secondsPerRotation)
        {
            var val_6;
            if(words != true)
            {
                    UnityEngine.Debug.LogError(message:  1019805536);
            }
            
            val_6 = 4;
            goto label_6;
            label_12:
            TMPro.TextMeshProUGUI val_7 = this.WordTexts[0];
            val_7.text = words[0];
            val_6 = 5;
            label_6:
            var val_1 = val_6 - 4;
            if(val_1 < val_7)
            {
                goto label_12;
            }
            
            if(val_1 > val_7)
            {
                    -1f = 1f;
            }
            
            -1f = (-1f) / R2;
            this.baseRotationSpeed = -1f;
            float val_2 = (-1f) ^ 2147483648;
            UnityEngine.Vector3 val_3 = new UnityEngine.Vector3(x:  -1f, y:  null, z:  1f);
            this.speedMultiplier = 1f;
            UnityEngine.Transform val_4 = this.transform;
            UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  UnityEngine.Random.Range(min:  -1f, max:  null), y:  null, z:  1f);
            this.localEulerAngles = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        private void OnPlayingStateChanged(bool playing)
        {
            if(playing == true)
            {
                    return;
            }
            
            this.StopSpinning();
        }
        public void StopSpinning()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            if(this.WheelSpin != 0)
            {
                    return;
            }
        
        }
        public void PlaySound()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(IsSoundMuted() == true)
            {
                    return;
            }
            
            R4 + 28.PlayOneShot(clip:  R4 + 32, volumeScale:  null);
        }
        public void IncreSpeed()
        {
            float val_3 = 0.25f;
            float val_4 = this.baseRotationSpeed;
            val_3 = this.speedMultiplier + val_3;
            val_4 = val_3 * val_4;
            this.speedMultiplier = val_3;
            float val_1 = val_4 ^ 2147483648;
            UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  val_3, y:  null, z:  val_4);
            if(this.WheelSpin != 0)
            {
                    return;
            }
        
        }
        public TwistyWheel()
        {
            this.speedMultiplier = 1f;
        }
    
    }

}
