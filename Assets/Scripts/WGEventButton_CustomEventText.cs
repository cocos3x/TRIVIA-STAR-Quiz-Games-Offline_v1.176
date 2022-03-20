using UnityEngine;
public class WGEventButton_CustomEventText : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text customEventText;
    private UnityEngine.Transform suffixGroup;
    private UnityEngine.UI.Text textSuffix;
    private UnityEngine.GameObject plusText;
    
    // Methods
    private void ResetUI()
    {
        MethodExtensionForMonoBehaviourTransform.SetActiveChildren(t:  this.suffixGroup, state:  false);
    }
    public void Setup(string eventName)
    {
        string val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        LeaderboardPlayerInfo_Self val_38;
        val_33 = eventName;
        MethodExtensionForMonoBehaviourTransform.SetActiveChildren(t:  this.suffixGroup, state:  false);
        if((System.String.op_Equality(a:  val_33, b:  -1266462880)) == false)
        {
            goto label_1;
        }
        
        var val_33 = 28396228;
        val_33 = 7231196 + val_33;
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_35 = null;
        val_35 = null;
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_36 = null;
        val_36 = null;
        string val_2 = LeaderboardEventHandler.instance.GetCurrentRankText();
        bool val_3 = LeaderboardEventHandler.instance.Contains(value:  -1467947360);
        if(val_3 != true)
        {
                string val_4 = Ordinal.AddOrdinal(num:  376516608);
        }
        
        UnityEngine.GameObject val_6 = this.textSuffix.gameObject;
        this.textSuffix.SetActive(value:  val_3 ^ 1);
        this.plusText.SetActive(value:  val_3);
        object val_7 = this.customEventText.GetComponent<System.Object>();
        UnityEngine.Rect val_8 = rect;
        float val_9 = width;
        object val_10 = this.customEventText.GetComponent<System.Object>();
        val_34 = 0;
        UnityEngine.Rect val_11 = rect;
        float val_12 = height;
        if((LeaderboardEventHandler.instance + 8) == 1)
        {
                3999702904 = 1113325568;
        }
        
        object val_13 = this.customEventText.GetComponent<System.Object>();
        val_37 = this.customEventText;
        UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  55f, y:  val_11.m_YMin);
        val_38 = LeaderboardEventHandler.instance.playerInfo;
        val_37.sizeDelta = new UnityEngine.Vector2() {x = val_14.x, y = val_14.y};
        string val_15 = Localization.Localize(key:  -295306384, defaultValue:  -295306480, useSingularKey:  false);
        if((LeaderboardEventHandler.instance + 8) == 1)
        {
                " " = "  ";
        }
        
        val_33 = "  ";
        string val_16 = -295306384(-295306384) + -295306272(-295306272) + 13152256;
        if(this.customEventText != 0)
        {
            goto label_47;
        }
        
        goto label_47;
        label_1:
        if((System.String.op_Equality(a:  val_33, b:  -1321166448)) == false)
        {
            goto label_28;
        }
        
        this.customEventText.alignment = 4;
        this.customEventText.horizontalOverflow = 0;
        object val_18 = this.customEventText.GetComponent<System.Object>();
        if(this.customEventText == 0)
        {
            goto label_35;
        }
        
        this.customEventText.SetVerticesDirty();
        this.customEventText.enabled = true;
        val_38 = 1152921510188612944;
        object val_19 = this.customEventText.GetComponent<System.Object>();
        val_33 = this.customEventText;
        UnityEngine.Vector3 val_20 = localPosition;
        object val_23 = this.customEventText.GetComponent<System.Object>();
        UnityEngine.Vector3 val_24 = new UnityEngine.Vector3(x:  val_20.x, y:  val_20.y, z:  val_20.z);
        this.customEventText.localPosition = new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z};
        object val_25 = this.customEventText.GetComponent<System.Object>();
        val_37 = 0;
        UnityEngine.Rect val_26 = val_38.rect;
        UnityEngine.Vector2 val_28 = new UnityEngine.Vector2(x:  height, y:  val_26.m_YMin);
        this.customEventText.sizeDelta = new UnityEngine.Vector2() {x = val_28.x, y = val_28.y};
        goto label_47;
        label_28:
        CompanyDevices val_29 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                string val_31 = val_33 + -295276496(-295276496);
            UnityEngine.Debug.LogError(message:  val_33);
        }
        
        label_47:
        UnityEngine.GameObject val_32 = this.gameObject;
        this.SetActive(value:  true);
        return;
        label_35:
    }
    public WGEventButton_CustomEventText()
    {
    
    }

}
