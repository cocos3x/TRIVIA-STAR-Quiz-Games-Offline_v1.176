using UnityEngine;

namespace RestaurantRivals
{
    public class LoadingText : MonoBehaviour
    {
        // Fields
        private string[] strings;
        private UnityEngine.UI.Text text;
        private string currentText;
        private string dots;
        
        // Methods
        private void Awake()
        {
            this.SetRandomString();
            System.Collections.IEnumerator val_1 = this.AppendDots();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  516622384);
        }
        private void SetRandomString()
        {
            if(R1 == 0)
            {
                    return;
            }
            
            this.currentText = this.strings[UnityEngine.Random.Range(min:  0, max:  0)];
        }
        private System.Collections.IEnumerator AppendDots()
        {
            object val_1 = new System.Object();
            typeof(LoadingText.<AppendDots>d__6).__il2cppRuntimeField_8 = 0;
            typeof(LoadingText.<AppendDots>d__6).__il2cppRuntimeField_10 = this;
        }
        private void LoopDots()
        {
            string val_1 = this.dots + 1297836480;
            this.dots = this.dots;
            if(this.dots.m_stringLength >= 4)
            {
                    this.dots.m_stringLength = 24762516;
                this.dots.m_stringLength = "";
                this.dots.m_stringLength = "";
                this.dots = this.dots.m_stringLength;
            }
        
        }
        public LoadingText()
        {
            this.currentText = "";
            this.dots = "...";
        }
    
    }

}
