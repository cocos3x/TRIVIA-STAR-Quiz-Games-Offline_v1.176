using UnityEngine;

namespace SRDebugger.UI.Controls
{
    public abstract class OptionsControlBase : SRMonoBehaviourEx
    {
        // Fields
        private bool _selectionModeEnabled;
        public UnityEngine.UI.Toggle SelectionModeToggle;
        public SRDebugger.Internal.OptionDefinition Option;
        
        // Properties
        public bool SelectionModeEnabled { get; set; }
        public bool IsSelected { get; set; }
        
        // Methods
        public bool get_SelectionModeEnabled()
        {
            return (bool)this._selectionModeEnabled;
        }
        public void set_SelectionModeEnabled(bool value)
        {
            var val_4;
            UnityEngine.UI.Toggle val_5;
            float val_6;
            val_4 = 35632441;
            if(this._selectionModeEnabled == true)
            {
                    this._selectionModeEnabled = 1;
            }
            
            if(1 ^ value != true)
            {
                    return;
            }
            
            this._selectionModeEnabled = value;
            UnityEngine.GameObject val_2 = this.SelectionModeToggle.gameObject;
            if(this._selectionModeEnabled == true)
            {
                    val_4 = 1;
            }
            
            this.SelectionModeToggle.SetActive(value:  true);
            if(this.SelectionModeToggle.graphic == 0)
            {
                    return;
            }
            
            val_5 = this.SelectionModeToggle;
            if(this.SelectionModeToggle != 0)
            {
                goto label_8;
            }
            
            val_5 = this.SelectionModeToggle;
            if(val_5 == 0)
            {
                goto label_9;
            }
            
            label_8:
            if(this.SelectionModeToggle.m_IsOn != false)
            {
                    if(this._selectionModeEnabled == false)
            {
                    val_6 = 1045220557;
            }
            
                return;
            }
            
            val_6 = 0f;
            return;
            label_9:
        }
        public bool get_IsSelected()
        {
            if(this.SelectionModeToggle != 0)
            {
                    return (bool)this.SelectionModeToggle.m_IsOn;
            }
            
            return (bool)this.SelectionModeToggle.m_IsOn;
        }
        public void set_IsSelected(bool value)
        {
            UnityEngine.UI.Graphic val_2;
            float val_3;
            this.SelectionModeToggle.isOn = value;
            val_2 = this.SelectionModeToggle.graphic;
            if(val_2 == 0)
            {
                    return;
            }
            
            val_2 = this.SelectionModeToggle.graphic;
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
        protected override void Awake()
        {
            this.Awake();
            this.IsSelected = false;
            UnityEngine.GameObject val_1 = this.SelectionModeToggle.gameObject;
            this.SelectionModeToggle.SetActive(value:  false);
        }
        protected override void OnEnable()
        {
            UnityEngine.UI.Toggle val_2;
            float val_3;
            this.OnEnable();
            if(this.SelectionModeToggle.graphic == 0)
            {
                    return;
            }
            
            val_2 = this.SelectionModeToggle;
            if(this.SelectionModeToggle != 0)
            {
                goto label_5;
            }
            
            val_2 = this.SelectionModeToggle;
            if(val_2 == 0)
            {
                goto label_6;
            }
            
            label_5:
            if(this.SelectionModeToggle.m_IsOn != false)
            {
                    if(this._selectionModeEnabled == false)
            {
                    val_3 = 1045220557;
            }
            
                return;
            }
            
            val_3 = 0f;
            return;
            label_6:
        }
        public virtual void Refresh()
        {
        
        }
        protected OptionsControlBase()
        {
        
        }
    
    }

}
