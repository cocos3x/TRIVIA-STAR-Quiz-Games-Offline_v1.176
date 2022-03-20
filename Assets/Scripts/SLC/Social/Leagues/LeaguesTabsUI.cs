using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesTabsUI : MonoBehaviour
    {
        // Fields
        private int desiredSiblingIndex;
        private UnityEngine.GameObject tabsBar;
        private UnityEngine.UI.Outline textOutline;
        private ThemeTextSettings selectedTabTextSetting;
        private ThemeTextSettings unselectedTabTextSetting;
        private ThemedText themedText;
        private bool selectedByDefault;
        private UnityEngine.UI.Toggle m_toggle;
        
        // Methods
        private void Start()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            object val_2 = this.GetComponent<System.Object>();
            this.m_toggle = this;
            UnityEngine.Events.UnityAction<System.Boolean> val_3 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  840874000, method:  new IntPtr(840836688));
            this.AddListener(call:  162353152);
            if(this.themedText == 0)
            {
                    return;
            }
            
            if(this.selectedByDefault == false)
            {
                    24 = 28;
            }
            
            this.themedText.ApplyThemeTextSettings(newText:  this.unselectedTabTextSetting);
        }
        public LeaguesTabsUI()
        {
            this.selectedByDefault = true;
        }
        private void <Start>b__8_0(bool arg0)
        {
            bool val_7 = arg0;
            if(this.themedText != 0)
            {
                    if(val_7 == true)
            {
                    28 = 24;
            }
            
                this.themedText.ApplyThemeTextSettings(newText:  this.selectedTabTextSetting);
            }
            else
            {
                    if((UnityEngine.Object.op_Implicit(exists:  this.textOutline)) != false)
            {
                    this.textOutline.enabled = val_7;
            }
            
            }
            
            val_7 = val_7 ^ 1;
            this.m_toggle.interactable = val_7;
            if(val_7 != true)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  this.tabsBar)) != false)
            {
                    UnityEngine.Transform val_4 = this.tabsBar.transform;
                this.tabsBar.SetAsLastSibling();
            }
            
                UnityEngine.Transform val_5 = this.transform;
                this.SetAsLastSibling();
                return;
            }
            
            UnityEngine.Transform val_6 = this.transform;
            this.SetSiblingIndex(index:  this.desiredSiblingIndex);
        }
    
    }

}
