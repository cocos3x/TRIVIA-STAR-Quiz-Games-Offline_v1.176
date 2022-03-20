using UnityEngine;
public class TheLibraryInfoPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button button_close;
    private UnityEngine.UI.Text text_refresh;
    private UnityEngine.UI.Text text_pack_rarities;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1683747056, method:  new IntPtr(2611195216));
        this.button_close.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        var val_14;
        string val_1 = Localization.Localize(key:  -1683650688, defaultValue:  -1683650864, useSingularKey:  false);
        val_14 = null;
        val_14 = null;
        string val_2 = ToString();
        string val_3 = System.String.Format(format:  -1683650688, arg0:  300003344);
        string val_4 = Localization.Localize(key:  -1683642160, defaultValue:  -1683642384, useSingularKey:  false);
        BookEconInfo val_5 = TheLibraryLogic.BookEcon.Item[0];
        string val_6 = System.String.Format(format:  2124591920, arg0:  13152256);
        typeof(System.Object[]).__il2cppRuntimeField_10 = "{0}%";
        BookEconInfo val_7 = TheLibraryLogic.BookEcon.Item[1];
        string val_8 = System.String.Format(format:  2124591920, arg0:  13152256);
        typeof(System.Object[]).__il2cppRuntimeField_14 = "{0}%";
        BookEconInfo val_9 = TheLibraryLogic.BookEcon.Item[2];
        string val_10 = System.String.Format(format:  2124591920, arg0:  13152256);
        typeof(System.Object[]).__il2cppRuntimeField_18 = "{0}%";
        BookEconInfo val_11 = TheLibraryLogic.BookEcon.Item[3];
        string val_12 = System.String.Format(format:  2124591920, arg0:  13152256);
        typeof(System.Object[]).__il2cppRuntimeField_1C = "{0}%";
        string val_13 = System.String.Format(format:  -1683642160, args:  472754880);
        if(this.text_pack_rarities != 0)
        {
                return;
        }
    
    }
    public TheLibraryInfoPopup()
    {
    
    }
    private void <Awake>b__3_0()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1683385856, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }

}
