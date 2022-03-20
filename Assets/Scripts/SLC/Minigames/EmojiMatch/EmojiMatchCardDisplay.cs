using UnityEngine;

namespace SLC.Minigames.EmojiMatch
{
    public class EmojiMatchCardDisplay : EmojiMatchDisplay, IPointerEnterHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
    {
        // Fields
        private string[] <emojidata>k__BackingField;
        private int <index>k__BackingField;
        private UnityEngine.UI.GridLayoutGroup emoji_grid;
        public bool completed;
        
        // Properties
        public string[] emojidata { get; set; }
        public int index { get; set; }
        
        // Methods
        public string[] get_emojidata()
        {
        
        }
        private void set_emojidata(string[] value)
        {
            this.<emojidata>k__BackingField = value;
        }
        public int get_index()
        {
            return (int)this.<index>k__BackingField;
        }
        private void set_index(int value)
        {
            this.<index>k__BackingField = value;
        }
        public void Init(string emojiUnparsed, int myIndex)
        {
            int val_21;
            var val_22;
            var val_23;
            var val_24;
            val_21 = myIndex;
            this.completed = false;
            UnityEngine.GameObject val_1 = this.gameObject;
            val_22 = 1152921510536702560;
            object val_2 = this.GetComponent<System.Object>();
            if(1083001120 != 0)
            {
                    UnityEngine.GameObject val_4 = this.gameObject;
                object val_5 = this.GetComponent<System.Object>();
                UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  1083001120, method:  new IntPtr(1082888976));
                AddListener(call:  162246656);
            }
            
            this.<index>k__BackingField = val_21;
            typeof(System.Char[]).__il2cppRuntimeField_10 = 44;
            System.String[] val_7 = emojiUnparsed.Split(separator:  478563824);
            this.<emojidata>k__BackingField = emojiUnparsed;
            val_23 = 0;
            goto label_12;
            label_40:
            string val_8 = 0.ToString();
            string val_9 = 1082894096 + 1082989080;
            val_21 = "Emoji_";
            System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(160436224)});
            typeof(System.Type[]).__il2cppRuntimeField_10 = null;
            System.Type val_11 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(296910848)});
            typeof(System.Type[]).__il2cppRuntimeField_14 = null;
            UnityEngine.GameObject val_12 = new UnityEngine.GameObject(name:  1082894096, components:  473824320);
            UnityEngine.Transform val_13 = transform;
            UnityEngine.Transform val_14 = this.emoji_grid.transform;
            SetParent(p:  this.emoji_grid);
            UnityEngine.Transform val_15 = transform;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.one;
            localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_17 = transform;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
            localPosition = new UnityEngine.Vector3();
            UnityEngine.Transform val_19 = transform;
            if(val_12 != 0)
            {
                    if(null != null)
            {
                    val_24 = 0;
            }
            
            }
            else
            {
                    val_24 = 0;
            }
            
            val_24.sizeDelta = new UnityEngine.Vector2() {x = this.emoji_grid.m_CellSize, y = this.emoji_grid.m_CellSize};
            object val_20 = GetComponent<System.Object>();
            val_22 = val_12;
            DisplayEmoji(emojiID:  this.<emojidata>k__BackingField[0], addOutline:  true);
            val_23 = 1;
            label_12:
            if(val_23 < 0)
            {
                goto label_40;
            }
        
        }
        public void SelectMe()
        {
            if(this.completed == true)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SelectCard(card:  R4);
        }
        public void MaybeDeselectMe(bool isDragging)
        {
            if(this.completed == true)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            MaybeDeselectCard(card:  R5, isDragging:  R4);
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
            
            goto typeof(SLC.Minigames.EmojiMatch.EmojiMatchCardDisplay).__il2cppRuntimeField_DC;
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
            }
            
            this.SetActive(value:  true);
        }
        public EmojiMatchCardDisplay()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
