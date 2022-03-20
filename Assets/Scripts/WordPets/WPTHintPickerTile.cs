using UnityEngine;

namespace WordPets
{
    public class WPTHintPickerTile : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image highlight;
        private UnityEngine.UI.Text letterText;
        private UnityEngine.CanvasGroup canvasGroup;
        private System.Action<int, int> OnClickAction;
        private int column;
        private int row;
        
        // Methods
        public void Setup(UnityEngine.Vector3 position, char letter, int column, int row, System.Action<int, int> onClickAction)
        {
            System.Action<System.Int32, System.Int32> val_5;
            UnityEngine.Transform val_1 = this.transform;
            this.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            string val_2 = letter.ToString();
            string val_3 = letter.ToUpper();
            val_5 = this.OnClickAction;
            this.column = column;
            this.row = row;
            System.Delegate val_4 = System.Delegate.Combine(a:  val_5, b:  onClickAction);
            if(val_5 != 0)
            {
                    if(null == null)
            {
                goto label_5;
            }
            
            }
            
            val_5 = 0;
            label_5:
            this.OnClickAction = val_5;
        }
        public void ToggleFade(bool fade)
        {
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  0f = 1f, duration:  null);
            this.canvasGroup.interactable = fade;
        }
        public void ToggleHighlight(bool highlight = True)
        {
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.highlight, endValue:  0f = 1f, duration:  null);
        }
        public void OnTileClicked()
        {
            this.OnClickAction.Invoke(arg1:  this.column, arg2:  this.row);
        }
        public WPTHintPickerTile()
        {
        
        }
    
    }

}
