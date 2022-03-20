using UnityEngine;

namespace SRDebugger.UI.Other
{
    public class SRTabController : SRMonoBehaviourEx
    {
        // Fields
        private readonly SRF.SRList<SRDebugger.UI.Other.SRTab> _tabs;
        private SRDebugger.UI.Other.SRTab _activeTab;
        public UnityEngine.RectTransform TabButtonContainer;
        public SRDebugger.UI.Controls.SRTabButton TabButtonPrefab;
        public UnityEngine.RectTransform TabContentsContainer;
        public UnityEngine.RectTransform TabHeaderContentContainer;
        public UnityEngine.UI.Text TabHeaderText;
        private System.Action<SRDebugger.UI.Other.SRTabController, SRDebugger.UI.Other.SRTab> ActiveTabChanged;
        
        // Properties
        public SRDebugger.UI.Other.SRTab ActiveTab { get; set; }
        public System.Collections.Generic.IList<SRDebugger.UI.Other.SRTab> Tabs { get; }
        
        // Methods
        public SRDebugger.UI.Other.SRTab get_ActiveTab()
        {
        
        }
        public void set_ActiveTab(SRDebugger.UI.Other.SRTab value)
        {
            this.MakeActive(tab:  value);
        }
        public System.Collections.Generic.IList<SRDebugger.UI.Other.SRTab> get_Tabs()
        {
            if(this._tabs != 0)
            {
                    return this._tabs.AsReadOnly();
            }
            
            return this._tabs.AsReadOnly();
        }
        public void add_ActiveTabChanged(System.Action<SRDebugger.UI.Other.SRTabController, SRDebugger.UI.Other.SRTab> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.ActiveTabChanged, b:  value);
            if(this.ActiveTabChanged == 0)
            {
                goto label_1;
            }
            
            val_2 = this.ActiveTabChanged;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.ActiveTabChanged != 1152921513637558080)
            {
                goto label_3;
            }
        
        }
        public void remove_ActiveTabChanged(System.Action<SRDebugger.UI.Other.SRTabController, SRDebugger.UI.Other.SRTab> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.ActiveTabChanged, value:  value);
            if(this.ActiveTabChanged == 0)
            {
                goto label_1;
            }
            
            val_2 = this.ActiveTabChanged;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.ActiveTabChanged != 1152921513637686464)
            {
                goto label_3;
            }
        
        }
        public void AddTab(SRDebugger.UI.Other.SRTab tab, bool visibleInSidebar = True)
        {
            SRDebugger.UI.Other.SRTab val_10;
            var val_11;
            UnityEngine.RectTransform val_12;
            val_10 = tab;
            object val_1 = new System.Object();
            if(val_1 != 0)
            {
                    val_11 = val_1;
                typeof(SRTabController.<>c__DisplayClass15_0).__il2cppRuntimeField_C = val_10;
                SRTabController.<>c__DisplayClass15_0.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_FFFFFFFFFFFFFFFC = this;
            }
            else
            {
                    mem[8] = this;
                val_11 = 12;
                mem[12] = val_10;
                val_10 = mem[12];
            }
            
            UnityEngine.Transform val_2 = val_10.CachedTransform;
            val_12 = this.TabContentsContainer;
            val_10.SetParent(parent:  val_12, worldPositionStays:  false);
            UnityEngine.GameObject val_3 = val_11.CachedGameObject;
            val_11.SetActive(value:  false);
            if(visibleInSidebar != false)
            {
                    UnityEngine.RectTransform val_4 = SRInstantiate.Instantiate<UnityEngine.RectTransform>(prefab:  this.TabButtonPrefab);
                UnityEngine.Transform val_5 = this.TabButtonPrefab.CachedTransform;
                this.TabButtonPrefab.SetParent(parent:  this.TabButtonContainer, worldPositionStays:  false);
                string val_6 = tab + 60.ToUpper();
                if((tab + 44) != 0)
            {
                    UnityEngine.RectTransform val_8 = SRInstantiate.Instantiate<UnityEngine.RectTransform>(prefab:  tab + 44);
                tab + 44.SetParent(parent:  this.TabButtonPrefab.ExtraContentContainer, worldPositionStays:  false);
            }
            
                this.TabButtonPrefab.IconStyleComponent.StyleKey = tab + 48;
                this.TabButtonPrefab.ActiveToggle.enabled = false;
                val_12 = this.TabButtonPrefab.Button.m_OnClick;
                UnityEngine.Events.UnityAction val_9 = new UnityEngine.Events.UnityAction(object:  417091584, method:  new IntPtr(441043008));
                val_12.AddListener(call:  162246656);
                mem2[0] = this.TabButtonPrefab;
            }
            
            this._tabs.Add(item:  mem[12]);
            this.SortTabs();
            if(this != 1)
            {
                    return;
            }
            
            this.MakeActive(tab:  mem[12]);
        }
        private void MakeActive(SRDebugger.UI.Other.SRTab tab)
        {
            SRDebugger.UI.Other.SRTab val_14;
            if((this._tabs.Contains(item:  tab)) != false)
            {
                    val_14 = this._activeTab;
                if(val_14 != 0)
            {
                    UnityEngine.GameObject val_3 = this._activeTab.CachedGameObject;
                this._activeTab.SetActive(value:  false);
                if(this._activeTab.TabButton != 0)
            {
                    this._activeTab.TabButton.ActiveToggle.enabled = false;
            }
            
                val_14 = this._activeTab.HeaderExtraContent;
                if(val_14 != 0)
            {
                    UnityEngine.GameObject val_6 = this._activeTab.HeaderExtraContent.gameObject;
                val_14 = this._activeTab.HeaderExtraContent;
                val_14.SetActive(value:  false);
            }
            
            }
            
                this._activeTab = tab;
                if(tab != 0)
            {
                    UnityEngine.GameObject val_8 = this._activeTab.CachedGameObject;
                this._activeTab.SetActive(value:  true);
                if((System.String.IsNullOrEmpty(value:  this._activeTab._longTitle)) == true)
            {
                    64 = 60;
            }
            
                val_14 = this._activeTab._title;
                if(this._activeTab.TabButton != 0)
            {
                    this._activeTab.TabButton.ActiveToggle.enabled = true;
            }
            
                if(this._activeTab.HeaderExtraContent != 0)
            {
                    val_14 = this._activeTab.HeaderExtraContent;
                val_14.SetParent(parent:  this.TabHeaderContentContainer, worldPositionStays:  false);
                UnityEngine.GameObject val_12 = this._activeTab.HeaderExtraContent.gameObject;
                this._activeTab.HeaderExtraContent.SetActive(value:  true);
            }
            
            }
            
                if(this.ActiveTabChanged == 0)
            {
                    return;
            }
            
                this.ActiveTabChanged.Invoke(arg1:  441372784, arg2:  this._activeTab);
                return;
            }
            
            System.ArgumentException val_13 = new System.ArgumentException(message:  441347520, paramName:  441347680);
        }
        private void SortTabs()
        {
            var val_6;
            System.Comparison<SRDebugger.UI.Other.SRTab> val_8;
            var val_9;
            val_6 = null;
            val_6 = null;
            val_8 = SRTabController.<>c.<>9__17_0;
            if(val_8 == 0)
            {
                    val_8 = null;
                val_8 = new System.Comparison<WordForest.NewsArticle>(object:  SRTabController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(441595952));
                SRTabController.<>c.<>9__17_0 = val_8;
            }
            
            this._tabs.Sort(comparer:  7933952);
            val_9 = 0;
            goto label_7;
            label_18:
            SRDebugger.UI.Other.SRTab val_2 = this._tabs.Item[0];
            if(this._tabs != 0)
            {
                    SRDebugger.UI.Other.SRTab val_4 = this._tabs.Item[0];
                UnityEngine.Transform val_5 = this._tabs.CachedTransform;
                this._tabs.SetSiblingIndex(index:  0);
            }
            
            val_9 = 1;
            label_7:
            if(val_9 < this._tabs)
            {
                goto label_18;
            }
        
        }
        public SRTabController()
        {
            SRF.SRList<System.Object> val_1 = new SRF.SRList<System.Object>();
            this._tabs = null;
        }
    
    }

}
