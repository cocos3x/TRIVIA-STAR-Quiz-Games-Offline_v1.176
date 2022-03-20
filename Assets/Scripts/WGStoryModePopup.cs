using UnityEngine;
public class WGStoryModePopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject letter_group;
    private UnityEngine.UI.Text title;
    private UnityEngine.UI.Text message;
    private UnityEngine.UI.Button close_button;
    private UnityEngine.UI.Text close_text_no_thanks;
    private UnityEngine.UI.Text close_text_just_for_puzzles;
    private UnityEngine.UI.Button[] response_buttons;
    private UnityEngine.UI.Text[] response_buttons_text;
    private UnityEngine.GameObject feedback_group;
    private UnityEngine.UI.Button continue_button;
    private UnityEngine.UI.Text feedback_message;
    
    // Methods
    private void Awake()
    {
        var val_7;
        ButtonClickedEvent val_8;
        this.PrepFeedback();
        val_7 = 0;
        goto label_1;
        label_9:
        if(new System.Object() != 0)
        {
                typeof(WGStoryModePopup.<>c__DisplayClass11_0).__il2cppRuntimeField_C = this;
        }
        else
        {
                mem[12] = this;
        }
        
        typeof(WGStoryModePopup.<>c__DisplayClass11_0).__il2cppRuntimeField_8 = val_7;
        UnityEngine.UI.Button val_7 = this.response_buttons[val_7];
        val_8 = this.response_buttons[0x0][0].m_OnClick;
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  394567680, method:  new IntPtr(71608208));
        val_8.AddListener(call:  162246656);
        val_7 = 1;
        label_1:
        if(val_7 < val_8)
        {
            goto label_9;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.close_button)) != false)
        {
                val_8 = null;
            val_8 = new UnityEngine.Events.UnityAction(object:  71741776, method:  new IntPtr(71703440));
            this.close_button.m_OnClick.AddListener(call:  162246656);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.continue_button)) == false)
        {
                return;
        }
        
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  71741776, method:  new IntPtr(71716752));
        this.continue_button.m_OnClick.AddListener(call:  162246656);
    }
    public void OnDialogClick(int index)
    {
        var val_5;
        var val_6;
        val_5 = 35633585;
        if(index <= 3)
        {
                var val_1 = 10094012 + (10094012 + (index) << 2);
            if(index == 3)
        {
                10094012 = 10094012;
            10094012 = 10094012 & (((10094012) << (32-as. 
            
        
        
        
        
        
           
        )) | ((10094012) << as. 
            
        
        
        
        
        
           
        ));
            mem2[0] = (10094012 & ((10094012) << (32-as. 
            
        
        
        
        
        
           
        )) | ((10094012) << as. 
            
        
        
        
        
        
           
        )) + (10094012 & ((10094012) << (32-as. 
            
        
        
        
        
        
           
        )) | ((10094012) << as. 
            
        
        
        
        
        
           
        ));
        }
        
            Player val_2 = App.Player;
            val_6 = 2621448;
            val_5 = "Mystery";
        }
        
        this.OnFeedbackSelected();
    }
    public void OnDialogDismiss()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  72072560, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public void PrepFeedback()
    {
        var val_18 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  this.close_button)) == false)
        {
            goto label_6;
        }
        
        UnityEngine.GameObject val_2 = this.close_button.gameObject;
        this.close_button.SetActive(value:  true);
        goto label_6;
        label_12:
        UnityEngine.UI.Button val_18 = this.response_buttons[val_18];
        UnityEngine.GameObject val_3 = val_18.gameObject;
        val_18.SetActive(value:  true);
        val_18 = 1;
        label_6:
        if(val_18 < val_18)
        {
            goto label_12;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.title)) != false)
        {
                string val_5 = Localization.Localize(key:  72250784, defaultValue:  72250672, useSingularKey:  false);
            val_18 = "mysterious_letter_upper";
        }
        
        if(this.title >= 3)
        {
                UnityEngine.UI.Text val_19 = this.response_buttons_text[0];
            string val_6 = Localization.Localize(key:  72328832, defaultValue:  72328736, useSingularKey:  false);
            UnityEngine.UI.Text val_20 = this.response_buttons_text[1];
            string val_7 = Localization.Localize(key:  72369984, defaultValue:  72369888, useSingularKey:  false);
            UnityEngine.UI.Text val_21 = this.response_buttons_text[2];
            string val_8 = Localization.Localize(key:  72411152, defaultValue:  72411056, useSingularKey:  false);
            val_18 = "romance_upper";
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.message)) != false)
        {
                string val_10 = Localization.Localize(key:  72423536, defaultValue:  72423664, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "story_mode_popup_text_1";
            typeof(System.String[]).__il2cppRuntimeField_14 = "\n\n";
            string val_11 = Localization.Localize(key:  72424128, defaultValue:  72423904, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_18 = "story_mode_popup_text_2";
            typeof(System.String[]).__il2cppRuntimeField_1C = "\n\n";
            string val_12 = Localization.Localize(key:  72424400, defaultValue:  72424256, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_20 = "story_mode_popup_text_3";
            string val_13 = +477709520;
            val_18 = null;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.close_text_no_thanks)) != false)
        {
                string val_15 = Localization.Localize(key:  72428720, defaultValue:  72428624, useSingularKey:  false);
            val_18 = "no_thanks";
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.close_text_just_for_puzzles)) != false)
        {
                string val_17 = Localization.Localize(key:  72437136, defaultValue:  72437008, useSingularKey:  false);
            val_18 = "just_for_puzzles";
        }
        
        this.letter_group.SetActive(value:  true);
        this.feedback_group.SetActive(value:  false);
    }
    private void OnFeedbackSelected()
    {
        this.letter_group.SetActive(value:  false);
        if((UnityEngine.Object.op_Implicit(exists:  this.feedback_message)) != false)
        {
                string val_2 = Localization.Localize(key:  72856576, defaultValue:  72856448, useSingularKey:  false);
            string val_3 = Localization.Localize(key:  72860784, defaultValue:  72860896, useSingularKey:  false);
            string val_4 = 72856576 + 1269544832 + 72860784;
        }
        
        this.feedback_group.SetActive(value:  true);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  73017504, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGStoryModePopup()
    {
    
    }
    private void <Awake>b__11_0()
    {
        this.OnDialogClick(index:  3);
    }
    private void <Awake>b__11_1()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  73353504, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }

}
