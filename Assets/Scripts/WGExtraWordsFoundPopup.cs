using UnityEngine;
public class WGExtraWordsFoundPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button infoButton;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Text wordListingLabel;
    
    // Methods
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -51447008, method:  new IntPtr(4243486048));
        this.infoButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -51447008, method:  new IntPtr(4243495264));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        this.Initialize();
    }
    private void Initialize()
    {
        var val_5;
        var val_6;
        if((ExtraWord.GAMETYPE_CATEGORY_LEVELS != 0) && ((ExtraWord.GAMETYPE_CATEGORY_LEVELS + 16) != 0))
        {
                System.Collections.Generic.List<ZooTile> val_2 = new System.Collections.Generic.List<ZooTile>(collection:  ExtraWord.GAMETYPE_CATEGORY_LEVELS + 16);
            Sort();
            val_5 = 0;
            val_6 = "";
        }
        
        ExtraWord.HasViewedWordList = true;
    }
    private void OnInfoClicked()
    {
        var val_4;
        System.Action val_6;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        val_4 = null;
        val_4 = null;
        val_6 = WGExtraWordsFoundPopup.<>c.<>9__5_0;
        if(val_6 == 0)
        {
                val_6 = null;
            val_6 = new System.Action(object:  WGExtraWordsFoundPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4243745888));
            WGExtraWordsFoundPopup.<>c.<>9__5_0 = val_6;
        }
        
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_C = val_6;
        this.OnCloseClicked();
    }
    private void OnCloseClicked()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    public WGExtraWordsFoundPopup()
    {
    
    }

}
