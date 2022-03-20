using UnityEngine;

namespace DG.Tweening
{
    public class DOTextAnimationAfterLocalization : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text text;
        private float duration;
        private float delay;
        private DG.Tweening.Ease ease;
        private DG.Tweening.ScrambleMode scrambleMode;
        private string customScramble;
        private bool richText;
        
        // Methods
        private void Start()
        {
            object val_1 = this.GetComponent<System.Object>();
            this.text = this;
            System.Collections.IEnumerator val_2 = this.PlayAfterOneFrame();
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  242920800);
        }
        private System.Collections.IEnumerator PlayAfterOneFrame()
        {
            object val_1 = new System.Object();
            typeof(DOTextAnimationAfterLocalization.<PlayAfterOneFrame>d__8).__il2cppRuntimeField_8 = 0;
            typeof(DOTextAnimationAfterLocalization.<PlayAfterOneFrame>d__8).__il2cppRuntimeField_10 = this;
        }
        public DOTextAnimationAfterLocalization()
        {
            this.ease = 1;
            this.duration = 1f;
            this.customScramble = System.String.alignConst;
        }
    
    }

}
