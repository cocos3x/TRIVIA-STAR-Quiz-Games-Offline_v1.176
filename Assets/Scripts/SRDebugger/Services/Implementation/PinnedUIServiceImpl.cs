using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    public class PinnedUIServiceImpl : SRServiceBase<SRDebugger.Services.IPinnedUIService>, IPinnedUIService
    {
        // Fields
        private readonly System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase> _controlList;
        private readonly System.Collections.Generic.Dictionary<SRDebugger.Internal.OptionDefinition, SRDebugger.UI.Controls.OptionsControlBase> _pinnedObjects;
        private bool _queueRefresh;
        private SRDebugger.UI.Other.PinnedUIRoot _uiRoot;
        private System.Action<SRDebugger.Internal.OptionDefinition, bool> OptionPinStateChanged;
        
        // Properties
        public SRDebugger.UI.Other.DockConsoleController DockConsoleController { get; }
        public bool IsProfilerPinned { get; set; }
        
        // Methods
        public SRDebugger.UI.Other.DockConsoleController get_DockConsoleController()
        {
            bool val_1 = UnityEngine.Object.op_Equality(x:  this._uiRoot, y:  0);
            if(val_1 == true)
            {
                    val_1 = this;
                this.Load();
            }
            
            if(this._uiRoot != 0)
            {
                    return;
            }
        
        }
        public void add_OptionPinStateChanged(System.Action<SRDebugger.Internal.OptionDefinition, bool> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.OptionPinStateChanged, b:  value);
            if(this.OptionPinStateChanged == 0)
            {
                goto label_1;
            }
            
            val_2 = this.OptionPinStateChanged;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.OptionPinStateChanged != 1152921513674050484)
            {
                goto label_3;
            }
        
        }
        public void remove_OptionPinStateChanged(System.Action<SRDebugger.Internal.OptionDefinition, bool> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.OptionPinStateChanged, value:  value);
            if(this.OptionPinStateChanged == 0)
            {
                goto label_1;
            }
            
            val_2 = this.OptionPinStateChanged;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.OptionPinStateChanged != 1152921513674178868)
            {
                goto label_3;
            }
        
        }
        public bool get_IsProfilerPinned()
        {
            if(this._uiRoot == 0)
            {
                    return false;
            }
            
            if(this._uiRoot.Profiler != 0)
            {
                    return this._uiRoot.Profiler.activeSelf;
            }
            
            return this._uiRoot.Profiler.activeSelf;
        }
        public void set_IsProfilerPinned(bool value)
        {
            bool val_1 = UnityEngine.Object.op_Equality(x:  this._uiRoot, y:  0);
            if(val_1 == true)
            {
                    val_1 = this;
                this.Load();
            }
            
            this._uiRoot.Profiler.SetActive(value:  value);
        }
        public void Pin(SRDebugger.Internal.OptionDefinition obj, int order = -1)
        {
            bool val_1 = UnityEngine.Object.op_Equality(x:  this._uiRoot, y:  0);
            if(val_1 == true)
            {
                    val_1 = this;
                this.Load();
            }
            
            if((this._pinnedObjects.ContainsKey(key:  obj)) != false)
            {
                    return;
            }
            
            SRDebugger.UI.Controls.OptionsControlBase val_3 = SRDebugger.Internal.OptionControlFactory.CreateControl(from:  obj, categoryPrefix:  null);
            UnityEngine.Transform val_4 = obj.CachedTransform;
            obj.SetParent(parent:  this._uiRoot.Container, worldPositionStays:  false);
            if(order >= 0)
            {
                    UnityEngine.Transform val_5 = obj.CachedTransform;
                obj.SetSiblingIndex(index:  order);
            }
            
            this._pinnedObjects.Add(key:  obj, value:  obj);
            this._controlList.Add(item:  obj);
            this.OnPinnedStateChanged(option:  obj, isPinned:  true);
        }
        public void Unpin(SRDebugger.Internal.OptionDefinition obj)
        {
            if((this._pinnedObjects.ContainsKey(key:  obj)) == false)
            {
                    return;
            }
            
            SRDebugger.UI.Controls.OptionsControlBase val_2 = this._pinnedObjects.Item[obj];
            bool val_3 = this._pinnedObjects.Remove(key:  obj);
            bool val_4 = this._controlList.Remove(item:  this._pinnedObjects);
            UnityEngine.GameObject val_5 = this._pinnedObjects.CachedGameObject;
            UnityEngine.Object.Destroy(obj:  this._pinnedObjects);
            this.OnPinnedStateChanged(option:  obj, isPinned:  false);
        }
        private void OnPinnedStateChanged(SRDebugger.Internal.OptionDefinition option, bool isPinned)
        {
            if(this.OptionPinStateChanged == 0)
            {
                    return;
            }
            
            this.OptionPinStateChanged.Invoke(arg1:  option, arg2:  isPinned);
        }
        public void UnpinAll()
        {
            Dictionary.Enumerator<TKey, TValue> val_1 = 0.GetEnumerator();
            label_6:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            UnityEngine.GameObject val_3 = 0.CachedGameObject;
            UnityEngine.Object.Destroy(obj:  0);
            goto label_6;
            label_2:
            0.Dispose();
            this._pinnedObjects.Clear();
            this._controlList.Clear();
        }
        public bool HasPinned(SRDebugger.Internal.OptionDefinition option)
        {
            if(this._pinnedObjects != 0)
            {
                    return this._pinnedObjects.ContainsKey(key:  option);
            }
            
            return this._pinnedObjects.ContainsKey(key:  option);
        }
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Transform val_1 = this.CachedTransform;
            UnityEngine.Transform val_2 = SRF.Hierarchy.Get(key:  466780208);
            this.SetParent(p:  466780208);
        }
        private void Load()
        {
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            object val_1 = UnityEngine.Resources.Load<System.Object>(path:  478599360);
            if(478599360 == 0)
            {
                    UnityEngine.Debug.LogError(message:  478599488);
                return;
            }
            
            UnityEngine.RectTransform val_3 = SRInstantiate.Instantiate<UnityEngine.RectTransform>(prefab:  478599360);
            UnityEngine.Transform val_4 = CachedTransform;
            val_15 = "SRDebugger/UI/Prefabs/PinnedUI";
            UnityEngine.Transform val_5 = this.CachedTransform;
            val_16 = this;
            SetParent(parent:  478627744, worldPositionStays:  false);
            this._uiRoot = "SRDebugger/UI/Prefabs/PinnedUI";
            this.UpdateAnchors();
            SRDebugger.Services.IDebugService val_6 = SRDebug.Instance;
            SRDebugger.VisibilityChangedDelegate val_7 = new SRDebugger.VisibilityChangedDelegate(object:  478627744, method:  new IntPtr(478600672));
            val_16 = 0;
            val_16 = val_16 + 1;
            val_17 = this;
            SRDebugger.Services.IOptionsService val_9 = SRDebugger.Internal.Service.Options;
            System.EventHandler val_10 = new System.EventHandler(object:  478627744, method:  new IntPtr(478601696));
            val_16 = 0;
            val_16 = val_16 + 1;
            val_18 = this;
            SRDebugger.Services.IOptionsService val_12 = SRDebugger.Internal.Service.Options;
            System.EventHandler<System.Object> val_13 = new System.EventHandler<System.Object>(object:  478627744, method:  new IntPtr(478602720));
            val_16 = 0;
            val_16 = val_16 + 1;
            val_19 = this;
            goto mem[(1152921505027186688 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private void UpdateAnchors()
        {
            var val_7;
            var val_8;
            var val_9;
            SRDebugger.Settings val_1 = SRDebugger.Settings.Instance;
            if(4 <= 5)
            {
                    if((21 & 1) == 0)
            {
                    UnityEngine.Transform val_2 = this._uiRoot.Profiler.transform;
                val_7 = 0;
            }
            else
            {
                    UnityEngine.Transform val_3 = this._uiRoot.Profiler.transform;
                val_7 = 1;
            }
            
                this._uiRoot.Profiler.SetSiblingIndex(index:  1);
            }
            
            SRDebugger.Settings val_4 = SRDebugger.Settings.Instance;
            if(4 > 5)
            {
                goto label_30;
            }
            
            if(3 != 1)
            {
                goto label_12;
            }
            
            if((12 & 1) != 0)
            {
                goto label_13;
            }
            
            val_8 = 7;
            goto label_19;
            label_12:
            val_8 = 1;
            goto label_19;
            label_13:
            val_8 = 4;
            label_19:
            this._uiRoot.ProfilerVerticalLayoutGroup.childAlignment = 4;
            label_30:
            SRDebugger.Settings val_5 = SRDebugger.Settings.Instance;
            this._uiRoot.ProfilerHandleManager.SetAlignment(alignment:  4);
            SRDebugger.Settings val_6 = SRDebugger.Settings.Instance;
            if(1 > 7)
            {
                    return;
            }
            
            if(1 == 7)
            {
                    88 = 88;
            }
            
            if(1 == 7)
            {
                    88 = 88 & 957577888;
                mem2[0] = (88 & 957577888) + (88 & 957577888);
                (88 & 957577888) + (88 & 957577888) = ((88 & 957577888) + (88 & 957577888)) & ((R8) << 2);
                (88 & 957577888) + (88 & 957577888) = ((88 & 957577888) + (88 & 957577888)) & 478788944;
                (88 & 957577888) + (88 & 957577888) = ((88 & 957577888) + (88 & 957577888)) & ((((((88 & 957577888) + (88 & 957577888) & (R8) << 2) & 478788944)) << (32-2)) | (((((88 & 957577888) + (88 & 957577888) & (R8) << 2) & 478788944)) << 2));
            }
            
            val_9 = 0;
            R4 + 52 + 52 + 52 + 52 + 52 + 52 + 52.childAlignment = 7;
        }
        protected override void Update()
        {
            this.Update();
            if(this._queueRefresh == false)
            {
                    return;
            }
            
            this._queueRefresh = false;
            this.Refresh();
        }
        private void OnOptionsUpdated(object sender, System.EventArgs eventArgs)
        {
            SRDebugger.Internal.OptionDefinition val_5;
            var val_9;
            var val_10;
            Dictionary.KeyCollection<TKey, TValue> val_1 = mem[1152921513675853896].Keys;
            System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<System.Object>(source:  mem[1152921513675853896]);
            List.Enumerator<T> val_3 = GetEnumerator();
            label_15:
            bool val_4 = MoveNext();
            if(val_4 == false)
            {
                goto label_3;
            }
            
            SRDebugger.Services.IOptionsService val_6 = SRDebugger.Internal.Service.Options;
            var val_10 = val_4;
            if((val_4 + 178) == 0)
            {
                goto label_5;
            }
            
            var val_9 = 0;
            label_7:
            if((val_4 + 88 + 0) == null)
            {
                goto label_6;
            }
            
            val_9 = val_9 + 1;
            if(((uint)val_9 & 65535) < (val_4 + 178))
            {
                goto label_7;
            }
            
            label_5:
            val_9 = val_4;
            goto label_8;
            label_6:
            var val_7 = (val_4 + 88) + 0;
            val_10 = val_10 + (((val_4 + 88 + 0) + 4) << 3);
            val_9 = val_10 + 220;
            label_8:
            var val_12 = val_4;
            if((val_4 + 178) == 0)
            {
                goto label_10;
            }
            
            var val_11 = 0;
            label_12:
            if((val_4 + 88 + 0) == null)
            {
                goto label_11;
            }
            
            val_11 = val_11 + 1;
            if(((uint)val_11 & 65535) < (val_4 + 178))
            {
                goto label_12;
            }
            
            label_10:
            val_10 = val_4;
            goto label_13;
            label_11:
            var val_8 = (val_4 + 88) + 0;
            val_12 = val_12 + (((val_4 + 88 + 0) + 4) << 3);
            val_10 = val_12 + 220;
            label_13:
            if(val_4 == true)
            {
                goto label_15;
            }
            
            this.Unpin(obj:  val_5);
            goto label_15;
            label_3:
            Dispose();
        }
        private void OptionsOnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs)
        {
            this._queueRefresh = true;
        }
        private void OnDebugPanelVisibilityChanged(bool isVisible)
        {
            if(isVisible == false)
            {
                    isVisible = true;
                this._queueRefresh = isVisible;
            }
        
        }
        private void Refresh()
        {
            var val_1 = 0;
            goto label_1;
            label_6:
            if(true <= val_1)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            val_1 = 1;
            label_1:
            if(val_1 < ((0 + 0) + 16))
            {
                goto label_6;
            }
        
        }
        public PinnedUIServiceImpl()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this._controlList = null;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this._pinnedObjects = null;
        }
    
    }

}
