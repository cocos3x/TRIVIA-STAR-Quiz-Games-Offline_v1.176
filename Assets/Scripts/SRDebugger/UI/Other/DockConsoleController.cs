using UnityEngine;

namespace SRDebugger.UI.Other
{
    public class DockConsoleController : SRMonoBehaviourEx, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
    {
        // Fields
        public const float NonFocusOpacity = 0.65;
        private bool _isDirty;
        private bool _isDragging;
        private int _pointersOver;
        public UnityEngine.GameObject BottomHandle;
        public UnityEngine.CanvasGroup CanvasGroup;
        public SRDebugger.UI.Controls.ConsoleLogControl Console;
        public UnityEngine.GameObject Dropdown;
        public UnityEngine.UI.Image DropdownToggleSprite;
        public UnityEngine.UI.Text TextErrors;
        public UnityEngine.UI.Text TextInfo;
        public UnityEngine.UI.Text TextWarnings;
        public UnityEngine.UI.Toggle ToggleErrors;
        public UnityEngine.UI.Toggle ToggleInfo;
        public UnityEngine.UI.Toggle ToggleWarnings;
        public UnityEngine.GameObject TopBar;
        public UnityEngine.GameObject TopHandle;
        
        // Properties
        public bool IsVisible { get; set; }
        
        // Methods
        public bool get_IsVisible()
        {
            UnityEngine.GameObject val_1 = this.CachedGameObject;
            if(this != 0)
            {
                    return this.activeSelf;
            }
            
            return this.activeSelf;
        }
        public void set_IsVisible(bool value)
        {
            UnityEngine.GameObject val_1 = this.CachedGameObject;
            this.SetActive(value:  value);
        }
        protected override void Start()
        {
            var val_4;
            var val_5;
            var val_6;
            this.Start();
            SRDebugger.Services.IConsoleService val_1 = SRDebugger.Internal.Service.Console;
            SRDebugger.Services.ConsoleUpdatedEventHandler val_2 = new SRDebugger.Services.ConsoleUpdatedEventHandler(object:  436612384, method:  new IntPtr(436587360));
            var val_4 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_2;
            }
            
            val_4 = 0;
            label_4:
            val_5 = 0;
            if((mem[1179403735] + 0) == null)
            {
                goto label_3;
            }
            
            val_4 = val_4 + 1;
            val_5 = (uint)val_4 & 65535;
            if(val_5 < mem[1179403825])
            {
                goto label_4;
            }
            
            label_2:
            val_6 = 0;
            goto label_5;
            label_3:
            var val_3 = mem[1179403735] + 0;
            val_4 = val_4 + (((mem[1179403735] + 0) + 4) << 3);
            val_6 = val_4 + 228;
            label_5:
            this.Refresh();
            this.RefreshAlpha();
        }
        protected override void OnDestroy()
        {
            var val_5;
            var val_6;
            val_5 = this;
            val_5.OnDestroy();
            SRDebugger.Services.IConsoleService val_1 = SRDebugger.Internal.Service.Console;
            if(0 == 0)
            {
                    return;
            }
            
            SRDebugger.Services.IConsoleService val_2 = SRDebugger.Internal.Service.Console;
            SRDebugger.Services.ConsoleUpdatedEventHandler val_3 = new SRDebugger.Services.ConsoleUpdatedEventHandler(object:  436724384, method:  new IntPtr(436587360));
            var val_5 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_3;
            }
            
            val_5 = 0;
            label_5:
            if((mem[1179403735] + 0) == null)
            {
                goto label_4;
            }
            
            val_5 = val_5 + 1;
            if(((uint)val_5 & 65535) < mem[1179403825])
            {
                goto label_5;
            }
            
            label_3:
            val_6 = 0;
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 236);
            label_4:
            var val_4 = mem[1179403735] + 0;
            val_5 = val_5 + (((mem[1179403735] + 0) + 4) << 3);
            val_6 = val_5 + 236;
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 236);
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this._isDragging = false;
            this._pointersOver = false;
            this.RefreshAlpha();
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            this._pointersOver = 0;
        }
        protected override void Update()
        {
            this.Update();
            if(this._isDirty == false)
            {
                    return;
            }
            
            this.Refresh();
        }
        private void ConsoleOnUpdated(SRDebugger.Services.IConsoleService console)
        {
            this._isDirty = true;
        }
        public void SetDropdownVisibility(bool visible)
        {
            float val_3;
            this.Dropdown.SetActive(value:  visible);
            if(visible == true)
            {
                    180f = 0;
            }
            
            UnityEngine.RectTransform val_1 = this.DropdownToggleSprite.rectTransform;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(x:  0f, y:  null, z:  null);
            this.DropdownToggleSprite.localRotation = new UnityEngine.Quaternion() {w = val_3};
        }
        public void SetAlignmentMode(SRDebugger.ConsoleAlignment alignment)
        {
            float val_12;
            float val_13;
            float val_14;
            float val_15;
            var val_16;
            var val_17;
            val_16 = 35632511;
            if(alignment != 1)
            {
                    if(alignment != 0)
            {
                    return;
            }
            
                UnityEngine.Transform val_1 = this.TopBar.transform;
                this.TopBar.SetSiblingIndex(index:  0);
                UnityEngine.Transform val_2 = this.Dropdown.transform;
                this.Dropdown.SetSiblingIndex(index:  2);
                this.TopHandle.SetActive(value:  false);
                this.BottomHandle.SetActive(value:  true);
                UnityEngine.Transform val_3 = this.transform;
                this.SetSiblingIndex(index:  0);
                UnityEngine.RectTransform val_4 = this.DropdownToggleSprite.rectTransform;
                UnityEngine.Transform val_5 = this.DropdownToggleSprite.parent;
                val_17 = this.DropdownToggleSprite;
            }
            else
            {
                    UnityEngine.Transform val_6 = this.Dropdown.transform;
                this.Dropdown.SetSiblingIndex(index:  0);
                UnityEngine.Transform val_7 = this.TopBar.transform;
                this.TopBar.SetSiblingIndex(index:  2);
                this.TopHandle.SetActive(value:  true);
                this.BottomHandle.SetActive(value:  false);
                UnityEngine.Transform val_8 = this.transform;
                this.SetSiblingIndex(index:  1);
                UnityEngine.RectTransform val_9 = this.DropdownToggleSprite.rectTransform;
                UnityEngine.Transform val_10 = this.DropdownToggleSprite.parent;
                val_17 = this.DropdownToggleSprite;
            }
            
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Euler(x:  null, y:  null, z:  null);
            val_16 = 0;
            val_17.localRotation = new UnityEngine.Quaternion() {x = val_12, y = val_13, z = val_14, w = val_15};
        }
        private void Refresh()
        {
            var val_10;
            var val_11;
            var val_12;
            SRDebugger.Services.IConsoleService val_1 = SRDebugger.Internal.Service.Console;
            var val_11 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_2;
            }
            
            var val_10 = 0;
            label_4:
            if((mem[1179403735] + 0) == null)
            {
                goto label_3;
            }
            
            val_10 = val_10 + 1;
            if(((uint)val_10 & 65535) < mem[1179403825])
            {
                goto label_4;
            }
            
            label_2:
            val_10 = 0;
            goto label_5;
            label_3:
            var val_2 = mem[1179403735] + 0;
            val_11 = val_11 + (((mem[1179403735] + 0) + 4) << 3);
            val_10 = val_11 + 204;
            label_5:
            string val_3 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  0, max:  999, exceedsMaxString:  425984512);
            SRDebugger.Services.IConsoleService val_4 = SRDebugger.Internal.Service.Console;
            var val_13 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_8;
            }
            
            var val_12 = 0;
            label_10:
            if((mem[1179403735] + 0) == null)
            {
                goto label_9;
            }
            
            val_12 = val_12 + 1;
            if(((uint)val_12 & 65535) < mem[1179403825])
            {
                goto label_10;
            }
            
            label_8:
            val_11 = 0;
            goto label_11;
            label_9:
            var val_5 = mem[1179403735] + 0;
            val_13 = val_13 + (((mem[1179403735] + 0) + 4) << 3);
            val_11 = val_13 + 196;
            label_11:
            string val_6 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  0, max:  999, exceedsMaxString:  425984512);
            SRDebugger.Services.IConsoleService val_7 = SRDebugger.Internal.Service.Console;
            var val_15 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_14;
            }
            
            var val_14 = 0;
            label_16:
            if((mem[1179403735] + 0) == null)
            {
                goto label_15;
            }
            
            val_14 = val_14 + 1;
            if(((uint)val_14 & 65535) < mem[1179403825])
            {
                goto label_16;
            }
            
            label_14:
            val_12 = 0;
            goto label_17;
            label_15:
            var val_8 = mem[1179403735] + 0;
            val_15 = val_15 + (((mem[1179403735] + 0) + 4) << 3);
            val_12 = val_15 + 188;
            label_17:
            string val_9 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  0, max:  999, exceedsMaxString:  425984512);
            this._isDirty = false;
        }
        private void RefreshAlpha()
        {
            if(this._isDragging != true)
            {
                    if(this._pointersOver < 1)
            {
                goto label_1;
            }
            
            }
            
            label_4:
            this.CanvasGroup.alpha = null;
            return;
            label_1:
            goto label_4;
        }
        public void ToggleDropdownVisible()
        {
            this.SetDropdownVisibility(visible:  this.Dropdown.activeSelf ^ 1);
        }
        public void MenuButtonPressed()
        {
            var val_3;
            SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
            if(mem[1179403825] == 0)
            {
                goto label_2;
            }
            
            var val_3 = 0;
            label_4:
            if((mem[1179403735] + 0) == null)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            if(((uint)val_3 & 65535) < mem[1179403825])
            {
                goto label_4;
            }
            
            label_2:
            val_3 = 0;
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 260);
            label_3:
            var val_2 = mem[1179403735] + 0;
            var val_4 = (mem[1179403735] + 0) + 4;
            val_4 = 1179403647 + (val_4 << 3);
            val_3 = val_4 + 260;
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 260);
        }
        public void ClearButtonPressed()
        {
            var val_3;
            SRDebugger.Services.IConsoleService val_1 = SRDebugger.Internal.Service.Console;
            if(mem[1179403825] == 0)
            {
                goto label_2;
            }
            
            var val_3 = 0;
            label_4:
            if((mem[1179403735] + 0) == null)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            if(((uint)val_3 & 65535) < mem[1179403825])
            {
                goto label_4;
            }
            
            label_2:
            val_3 = 0;
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 244);
            label_3:
            var val_2 = mem[1179403735] + 0;
            var val_4 = (mem[1179403735] + 0) + 4;
            val_4 = 1179403647 + (val_4 << 3);
            val_3 = val_4 + 244;
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 244);
        }
        public void TogglesUpdated()
        {
            this.Console._isDirty = true;
            this.Console._showErrors = this.ToggleErrors.m_IsOn;
            this.Console._isDirty = true;
            this.Console._showWarnings = this.ToggleWarnings.m_IsOn;
            this.Console._isDirty = true;
            this.Console._showInfo = this.ToggleInfo.m_IsOn;
            this.SetDropdownVisibility(visible:  true);
        }
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData e)
        {
            this._pointersOver = 1;
            this.RefreshAlpha();
        }
        public void OnPointerExit(UnityEngine.EventSystems.PointerEventData e)
        {
            this._pointersOver = 0;
            this.RefreshAlpha();
        }
        public void OnBeginDrag()
        {
            this._isDragging = true;
            this.RefreshAlpha();
        }
        public void OnEndDrag()
        {
            this._pointersOver = 0;
            this._isDragging = 0;
            this.RefreshAlpha();
        }
        public DockConsoleController()
        {
        
        }
    
    }

}
