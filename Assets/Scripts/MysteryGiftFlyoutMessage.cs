using UnityEngine;
public class MysteryGiftFlyoutMessage : MonoSingleton<MysteryGiftFlyoutMessage>
{
    // Fields
    private UnityEngine.GameObject message_group;
    private UnityEngine.UI.Text message_text;
    private bool isMessageShowing;
    
    // Methods
    private void Start()
    {
        this.message_group.SetActive(value:  false);
    }
    public bool ShowMessage(string message)
    {
        if(this.isMessageShowing == true)
        {
                return (bool)0;
        }
        
        this.isMessageShowing = true;
        0 = 1;
        this.message_group.SetActive(value:  true);
        System.Collections.IEnumerator val_1 = this.AnimateMessage();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1151794336);
        return (bool)0;
    }
    private System.Collections.IEnumerator AnimateMessage()
    {
        object val_1 = new System.Object();
        typeof(MysteryGiftFlyoutMessage.<AnimateMessage>d__5).__il2cppRuntimeField_8 = 0;
        typeof(MysteryGiftFlyoutMessage.<AnimateMessage>d__5).__il2cppRuntimeField_10 = this;
    }
    private void OnMessageHideComplete()
    {
        this.message_group.SetActive(value:  false);
        this.isMessageShowing = false;
    }
    public MysteryGiftFlyoutMessage()
    {
    
    }

}
