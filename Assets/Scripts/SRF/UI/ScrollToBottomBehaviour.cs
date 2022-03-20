using UnityEngine;

namespace SRF.UI
{
    public class ScrollToBottomBehaviour : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.ScrollRect _scrollRect;
        private UnityEngine.CanvasGroup _canvasGroup;
        
        // Methods
        public void Start()
        {
            var val_4;
            if(this._scrollRect != 0)
            {
                goto label_3;
            }
            
            val_4 = "[ScrollToBottomBehaviour] ScrollRect not set";
            goto label_6;
            label_3:
            if(this._canvasGroup != 0)
            {
                goto label_9;
            }
            
            val_4 = "[ScrollToBottomBehaviour] CanvasGroup not set";
            label_6:
            UnityEngine.Debug.LogError(message:  389013680);
            return;
            label_9:
            UnityEngine.Events.UnityAction<UnityEngine.Vector2> val_3 = new UnityEngine.Events.UnityAction<UnityEngine.Vector2>(object:  389047056, method:  new IntPtr(389022032));
            this._scrollRect.m_OnValueChanged.AddListener(call:  162353152);
            this.Refresh();
        }
        private void OnEnable()
        {
            this.Refresh();
        }
        public void Trigger()
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  null, y:  null);
            this._scrollRect.normalizedPosition = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        private void OnScrollRectValueChanged(UnityEngine.Vector2 position)
        {
            this.Refresh();
        }
        private void Refresh()
        {
            if(this._scrollRect == 0)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_2 = normalizedPosition;
            if(this._scrollRect >= 0)
            {
                    this._scrollRect = 1;
            }
            
            if(this._scrollRect < 0)
            {
                    this._scrollRect = 0;
            }
            
            this.SetVisible(truth:  false);
        }
        private void SetVisible(bool truth)
        {
            var val_1;
            if(truth != false)
            {
                    this._canvasGroup.alpha = null;
                this._canvasGroup.interactable = true;
                val_1 = 1;
            }
            else
            {
                    this._canvasGroup.alpha = null;
                this._canvasGroup.interactable = false;
                val_1 = 0;
            }
            
            this._canvasGroup.blocksRaycasts = false;
        }
        public ScrollToBottomBehaviour()
        {
        
        }
    
    }

}
