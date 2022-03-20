using UnityEngine;

namespace SRDebugger.UI.Other
{
    public class CategoryGroup : SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.RectTransform Container;
        public UnityEngine.UI.Text Header;
        public UnityEngine.GameObject Background;
        public UnityEngine.UI.Toggle SelectionToggle;
        public UnityEngine.GameObject[] EnabledDuringSelectionMode;
        private bool _selectionModeEnabled;
        
        // Properties
        public bool IsSelected { get; set; }
        public bool SelectionModeEnabled { get; set; }
        
        // Methods
        public bool get_IsSelected()
        {
            if(this.SelectionToggle != 0)
            {
                    return (bool)this.SelectionToggle.m_IsOn;
            }
            
            return (bool)this.SelectionToggle.m_IsOn;
        }
        public void set_IsSelected(bool value)
        {
            UnityEngine.UI.Graphic val_2;
            float val_3;
            this.SelectionToggle.isOn = value;
            val_2 = this.SelectionToggle.graphic;
            if(val_2 == 0)
            {
                    return;
            }
            
            val_2 = this.SelectionToggle.graphic;
            if(value != false)
            {
                    if(this._selectionModeEnabled == false)
            {
                    val_3 = 1045220557;
            }
            
                return;
            }
            
            val_3 = 0f;
        }
        public bool get_SelectionModeEnabled()
        {
            return (bool)this._selectionModeEnabled;
        }
        public void set_SelectionModeEnabled(bool value)
        {
            var val_2;
            if(this._selectionModeEnabled == true)
            {
                    this._selectionModeEnabled = 1;
            }
            
            if(1 ^ value != true)
            {
                    return;
            }
            
            this._selectionModeEnabled = value;
            val_2 = 0;
            goto label_1;
            label_6:
            UnityEngine.GameObject val_2 = this.EnabledDuringSelectionMode[val_2];
            if(this._selectionModeEnabled == true)
            {
                    this._selectionModeEnabled = 1;
            }
            
            val_2.SetActive(value:  true);
            val_2 = 1;
            label_1:
            if(val_2 < val_2)
            {
                goto label_6;
            }
        
        }
        public CategoryGroup()
        {
            this.EnabledDuringSelectionMode = null;
            this._selectionModeEnabled = true;
        }
    
    }

}
