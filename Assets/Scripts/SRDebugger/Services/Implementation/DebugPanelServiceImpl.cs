using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    public class DebugPanelServiceImpl : ScriptableObject, IDebugPanelService
    {
        // Fields
        private SRDebugger.UI.DebugPanelRoot _debugPanelRootObject;
        private System.Action<SRDebugger.Services.IDebugPanelService, bool> VisibilityChanged;
        private bool _isVisible;
        private System.Nullable<bool> _cursorWasVisible;
        private System.Nullable<UnityEngine.CursorLockMode> _cursorLockMode;
        
        // Properties
        public SRDebugger.UI.DebugPanelRoot RootObject { get; }
        public bool IsLoaded { get; }
        public bool IsVisible { get; set; }
        public System.Nullable<SRDebugger.DefaultTabs> ActiveTab { get; }
        
        // Methods
        public void add_VisibilityChanged(System.Action<SRDebugger.Services.IDebugPanelService, bool> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.VisibilityChanged, b:  value);
            if(this.VisibilityChanged == 0)
            {
                goto label_1;
            }
            
            val_2 = this.VisibilityChanged;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.VisibilityChanged != 1152921513666657344)
            {
                goto label_3;
            }
        
        }
        public void remove_VisibilityChanged(System.Action<SRDebugger.Services.IDebugPanelService, bool> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.VisibilityChanged, value:  value);
            if(this.VisibilityChanged == 0)
            {
                goto label_1;
            }
            
            val_2 = this.VisibilityChanged;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.VisibilityChanged != 1152921513666785728)
            {
                goto label_3;
            }
        
        }
        public SRDebugger.UI.DebugPanelRoot get_RootObject()
        {
        
        }
        public bool get_IsLoaded()
        {
            return UnityEngine.Object.op_Inequality(x:  this._debugPanelRootObject, y:  0);
        }
        public bool get_IsVisible()
        {
            if(this.IsLoaded == false)
            {
                    return true;
            }
            
            if(this._isVisible == true)
            {
                    0 = 1;
            }
            
            return true;
        }
        public void set_IsVisible(bool value)
        {
            UnityEngine.CanvasGroup val_10;
            var val_11;
            val_10 = 35636214;
            bool val_10 = this._isVisible;
            val_10 = val_10 >> 5;
            if(val_10 != value)
            {
                    return;
            }
            
            bool val_1 = this.IsLoaded;
            if(value == false)
            {
                goto label_2;
            }
            
            if(val_1 == false)
            {
                    val_1 = this;
                this.Load();
            }
            
            bool val_2 = SRDebugger.Internal.SRDebuggerUtil.EnsureEventSystemExists();
            this._debugPanelRootObject.CanvasGroup.alpha = null;
            this._debugPanelRootObject.CanvasGroup.interactable = true;
            val_11 = 0;
            this._debugPanelRootObject.CanvasGroup.blocksRaycasts = true;
            System.Nullable<System.Boolean> val_4 = new System.Nullable<System.Boolean>(value:  UnityEngine.Cursor.visible);
            this._cursorWasVisible = val_4.HasValue;
            UnityEngine.CursorLockMode val_5 = UnityEngine.Cursor.lockState;
            System.Nullable<com.adjust.sdk.AdjustLogLevel> val_6 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  0);
            this._cursorLockMode = val_6.HasValue;
            mem[1152921513667314636] = val_11;
            SRDebugger.Settings val_7 = SRDebugger.Settings.Instance;
            val_10 = 0;
            if(88 == 0)
            {
                goto label_20;
            }
            
            UnityEngine.Cursor.visible = true;
            UnityEngine.Cursor.lockState = 0;
            goto label_20;
            label_2:
            if(val_1 != false)
            {
                    this._debugPanelRootObject.CanvasGroup.alpha = null;
                this._debugPanelRootObject.CanvasGroup.interactable = false;
                val_10 = this._debugPanelRootObject.CanvasGroup;
                val_10.blocksRaycasts = false;
            }
            
            if(val_10 != 0)
            {
                    val_10 = this._cursorWasVisible;
                bool val_8 = val_10.Value;
                val_11 = 0;
                UnityEngine.Cursor.visible = val_8;
                mem2[0] = val_11;
            }
            
            if(val_8 != false)
            {
                    val_10 = this._cursorLockMode;
                UnityEngine.CursorLockMode val_9 = val_10.Value;
                val_11 = 0;
                UnityEngine.Cursor.lockState = val_10;
                mem2[0] = val_11;
                mem2[0] = val_11;
            }
            
            label_20:
            this._isVisible = value;
            if(this.VisibilityChanged == 0)
            {
                    return;
            }
            
            this.VisibilityChanged.Invoke(arg1:  470533040, arg2:  value);
        }
        public System.Nullable<SRDebugger.DefaultTabs> get_ActiveTab()
        {
            bool val_1 = UnityEngine.Object.op_Equality(x:  R1 + 12, y:  0);
            if(val_1 != false)
            {
                    this = 0;
                mem[1152921513667479860] = 0;
                return (System.Nullable<SRDebugger.DefaultTabs>)val_1;
            }
            
            System.Nullable<SRDebugger.DefaultTabs> val_2 = this.ActiveTab;
            return (System.Nullable<SRDebugger.DefaultTabs>)val_2.HasValue;
        }
        public void OpenTab(SRDebugger.DefaultTabs tab)
        {
            bool val_1 = this.IsLoaded;
            if(val_1 == true)
            {
                    val_1 = this._isVisible;
                goto label_0;
            }
            
            this.IsVisible = true;
            label_0:
            bool val_2 = this._debugPanelRootObject.TabController.OpenTab(tab:  tab);
        }
        public void Unload()
        {
            if(this._debugPanelRootObject == 0)
            {
                    return;
            }
            
            this.IsVisible = false;
            UnityEngine.GameObject val_2 = this._debugPanelRootObject.CachedGameObject;
            this._debugPanelRootObject.SetActive(value:  false);
            UnityEngine.GameObject val_3 = this._debugPanelRootObject.CachedGameObject;
            UnityEngine.Object.Destroy(obj:  this._debugPanelRootObject);
            this._debugPanelRootObject = 0;
        }
        private void Load()
        {
            object val_1 = UnityEngine.Resources.Load<System.Object>(path:  471060464);
            if(471060464 == 0)
            {
                    UnityEngine.Debug.LogError(message:  471060608);
                return;
            }
            
            UnityEngine.RectTransform val_3 = SRInstantiate.Instantiate<UnityEngine.RectTransform>(prefab:  471060464);
            this._debugPanelRootObject = "SRDebugger/UI/Prefabs/DebugPanel";
            name = 471061792;
            UnityEngine.Object.DontDestroyOnLoad(target:  this._debugPanelRootObject);
            UnityEngine.Transform val_4 = this._debugPanelRootObject.CachedTransform;
            UnityEngine.Transform val_5 = SRF.Hierarchy.Get(key:  466780208);
            this._debugPanelRootObject.SetParent(parent:  466780208, worldPositionStays:  true);
            bool val_6 = SRDebugger.Internal.SRDebuggerUtil.EnsureEventSystemExists();
        }
        public DebugPanelServiceImpl()
        {
        
        }
    
    }

}
