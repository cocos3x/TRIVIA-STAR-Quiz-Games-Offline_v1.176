using UnityEngine;

namespace SLC.Minigames.EmojiMatch
{
    public class EmojiMatchPhraseDisplay : EmojiMatchDisplay, IPointerEnterHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
    {
        // Fields
        private string <phrase>k__BackingField;
        private int <index>k__BackingField;
        private UnityEngine.UI.Text phraseText;
        private bool completed;
        
        // Properties
        public string phrase { get; set; }
        public int index { get; set; }
        
        // Methods
        public string get_phrase()
        {
        
        }
        private void set_phrase(string value)
        {
            this.<phrase>k__BackingField = value;
        }
        public int get_index()
        {
            return (int)this.<index>k__BackingField;
        }
        private void set_index(int value)
        {
            this.<index>k__BackingField = value;
        }
        public void Init(string myPhrase, int myIndex)
        {
            var val_7;
            this.completed = false;
            UnityEngine.GameObject val_1 = this.gameObject;
            val_7 = 1152921510536702560;
            object val_2 = this.GetComponent<System.Object>();
            if(1086729376 != 0)
            {
                    UnityEngine.GameObject val_4 = this.gameObject;
                object val_5 = this.GetComponent<System.Object>();
                UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  1086729376, method:  new IntPtr(1086700256));
                AddListener(call:  162246656);
            }
            
            this.<phrase>k__BackingField = myPhrase;
            this.<index>k__BackingField = myIndex;
            this.SetState(state:  0);
        }
        public void SelectMe()
        {
            if(this.completed == true)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SelectPhrase(phrase:  R4);
        }
        public void MaybeDeselectMe(bool isDragging)
        {
            if(this.completed == true)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            MaybeDeselectPhrase(phrase:  R5, isDragging:  R4);
        }
        public void DisplaySelectedState(bool selected)
        {
            if(selected == false)
            {
                    selected = 0;
            }
            
            if(selected == true)
            {
                    selected = 1;
            }
            
            this.SetState(state:  1);
        }
        private void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if((eventData.<dragging>k__BackingField) == false)
            {
                    return;
            }
            
            this.SelectMe();
        }
        public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.SelectMe();
        }
        public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if((eventData.<dragging>k__BackingField) == true)
            {
                    return;
            }
            
            R4.MaybeDeselectMe(isDragging:  false);
        }
        private void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.MaybeDeselectMe(isDragging:  eventData.<dragging>k__BackingField);
        }
        public void CompleteMe(bool matched)
        {
            if(matched != false)
            {
                    this.completed = true;
                this.SetState(state:  2);
            }
            else
            {
                    this.SetState(state:  3);
            }
            
            this.SetActive(value:  true);
        }
        public EmojiMatchPhraseDisplay()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
