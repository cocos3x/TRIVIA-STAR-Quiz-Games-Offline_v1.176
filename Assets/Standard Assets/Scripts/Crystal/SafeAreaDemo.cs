using UnityEngine;

namespace Crystal
{
    public class SafeAreaDemo : MonoBehaviour
    {
        // Fields
        private UnityEngine.KeyCode KeySafeArea;
        private UnityEngine.KeyCode KeyLayout;
        private UnityEngine.KeyCode KeyDisplay;
        private Crystal.SafeArea.SimDevice[] Sims;
        private int SimIdx;
        private UnityEngine.GameObject safeAreaLayout;
        private UnityEngine.UI.Image phoneLayout;
        private UnityEngine.GameObject text;
        
        // Methods
        private void Awake()
        {
            SafeArea.SimDevice[] val_5;
            var val_6;
            if(UnityEngine.Application.isEditor != true)
            {
                    UnityEngine.GameObject val_2 = this.gameObject;
                UnityEngine.Object.Destroy(obj:  2050621712);
            }
            
            val_5 = 0;
            System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(270606336)});
            val_6 = null;
            System.Array val_4 = System.Enum.GetValues(enumType:  270606336);
            if(val_6 != 0)
            {
                    val_6 = val_6;
                val_5 = val_6;
                if(val_6 == 0)
            {
                    val_5 = 0;
            }
            
            }
            
            this.Sims = val_5;
        }
        private void Update()
        {
            bool val_1 = UnityEngine.Input.GetKeyDown(key:  this.KeySafeArea);
            if(val_1 == true)
            {
                    val_1 = this;
                this.ToggleSafeArea();
            }
            
            bool val_2 = UnityEngine.Input.GetKeyDown(key:  this.KeyLayout);
            if(val_2 == true)
            {
                    val_2 = this;
                this.TogglePhoneLayout();
            }
            
            if((UnityEngine.Input.GetKeyDown(key:  this.KeyDisplay)) == false)
            {
                    return;
            }
            
            R4.ToggleTipDisplay();
        }
        private void ToggleSafeArea()
        {
            var val_2;
            int val_1 = this.SimIdx + 1;
            this.SimIdx = val_1;
            if(val_1 >= this.SimIdx)
            {
                    this.Sims = 0;
                this.SimIdx = this.Sims;
            }
            
            if(val_1 < this.SimIdx)
            {
                    this.Sims = this.SimIdx;
            }
            
            val_2 = null;
            val_2 = null;
            Crystal.SafeArea.Sim = this.Sims[this.Sims];
            SafeArea.SimDevice val_3 = this.Sims[this.SimIdx];
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            UnityEngine.Debug.LogFormat(format:  2050969168, args:  472754880);
        }
        private void TogglePhoneLayout()
        {
            UnityEngine.GameObject val_2 = this.safeAreaLayout;
            val_2 = val_2.activeSelf ^ 1;
            this.safeAreaLayout.SetActive(value:  val_2);
            this.phoneLayout.enabled = val_2;
        }
        private void ToggleTipDisplay()
        {
            var val_5;
            if((UnityEngine.Object.op_Implicit(exists:  this.text)) == false)
            {
                    return;
            }
            
            if((R4 + 40) != 0)
            {
                    val_5 = R4 + 40.activeSelf;
            }
            else
            {
                    val_5 = 0.activeSelf;
            }
            
            R4 + 40.SetActive(value:  val_5 ^ 1);
        }
        public SafeAreaDemo()
        {
            this.KeySafeArea = 97;
            this.KeyLayout = 115;
            this.KeyDisplay = 100;
        }
    
    }

}
