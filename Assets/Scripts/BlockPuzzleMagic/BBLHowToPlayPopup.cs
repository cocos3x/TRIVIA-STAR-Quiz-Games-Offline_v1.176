using UnityEngine;

namespace BlockPuzzleMagic
{
    public class BBLHowToPlayPopup : WGHowToPlayPopup
    {
        // Fields
        private UnityEngine.UI.Button closeButton;
        private UnityEngine.UI.Button backButton;
        private UnityEngine.UI.Button forwardButton;
        private UnityEngine.UI.Text forwardButtonText;
        private UnityEngine.GameObject forwardButtonArrow;
        private UnityEngine.GameObject[] pages;
        private int currentIndex;
        private System.Collections.Generic.List<UnityEngine.GameObject> processedPages;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  1218081344, method:  new IntPtr(1218033792));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  1218081344, method:  new IntPtr(1218043008));
            this.backButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  1218081344, method:  new IntPtr(1218052224));
            this.forwardButton.m_OnClick.AddListener(call:  162246656);
            this.ProcessPages();
            if(this.currentIndex > 0)
            {
                    0 = 1;
            }
            
            this.backButton.interactable = true;
            this.OpenPage(index:  this.currentIndex);
        }
        private void ProcessPages()
        {
            var val_3;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.processedPages = null;
            val_3 = 0;
            goto label_1;
            label_7:
            if(BlockPuzzleMagic.ShapeInfo.IsRotationAllowed != false)
            {
                    this.processedPages.Add(item:  this.pages[val_3]);
            }
            
            val_3 = 1;
            label_1:
            if(val_3 < this.processedPages)
            {
                goto label_7;
            }
        
        }
        private void OnBackwardPressed()
        {
            int val_2 = UnityEngine.Mathf.Max(a:  0, b:  this.currentIndex - 1);
            this.currentIndex = val_2;
            if(val_2 > 0)
            {
                    0 = 1;
            }
            
            this.backButton.interactable = true;
            this.OpenPage(index:  this.currentIndex);
        }
        private void OnForwardPressed()
        {
            bool val_3 = true;
            val_3 = val_3 - 1;
            if(this.currentIndex < val_3)
            {
                    int val_1 = this.currentIndex + 1;
                this.currentIndex = val_1;
                this.OpenPage(index:  val_1);
                return;
            }
            
            UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  1218622144, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnClosePressed()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  1218738240, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void SetForwardButtonText(int index)
        {
            System.Collections.Generic.List<UnityEngine.GameObject> val_3;
            int val_1 = index + 1;
            val_3 = this.processedPages;
            if(this.processedPages == 0)
            {
                    val_3 = this.processedPages;
            }
            
            if(val_1 < true)
            {
                    "CLOSE" = "NEXT";
            }
            
            if(val_1 < val_3)
            {
                    0 = 1;
            }
            
            this.forwardButtonArrow.SetActive(value:  true);
            string val_2 = System.String.Format(format:  1218846800, arg0:  1218834432, arg1:  13152256, arg2:  13152256);
            if(this.forwardButtonText != 0)
            {
                    return;
            }
        
        }
        private void OpenPage(int index)
        {
            var val_2 = 0;
            goto label_1;
            label_6:
            if(true <= val_2)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            index = (index - val_2) >> 5;
            (0 + 0) + 16.SetActive(value:  index);
            val_2 = 1;
            label_1:
            if(val_2 < ((0 + 0) + 16))
            {
                goto label_6;
            }
            
            this.SetForwardButtonText(index:  index);
            if(this.currentIndex > 0)
            {
                    0 = 1;
            }
            
            this.backButton.interactable = true;
        }
        public BBLHowToPlayPopup()
        {
        
        }
    
    }

}
