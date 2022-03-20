using UnityEngine;
public class WFOForestMenuButton : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button forestButton;
    
    // Methods
    private void Awake()
    {
        var val_7;
        UnityEngine.Events.UnityAction val_9;
        UnityEngine.GameObject val_1 = this.gameObject;
        object val_2 = this.GetComponent<System.Object>();
        this.forestButton = this;
        if((-373804464) == 0)
        {
                this.enabled = false;
            return;
        }
        
        if(WordForest.WFOForestManager.IsFeatureUnlocked != true)
        {
                this.forestButton.interactable = false;
            UnityEngine.GameObject val_5 = this.gameObject;
            this.SetActive(value:  false);
        }
        
        val_7 = null;
        val_7 = null;
        val_9 = WFOForestMenuButton.<>c.<>9__1_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new UnityEngine.Events.UnityAction(object:  WFOForestMenuButton.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3921137808));
            WFOForestMenuButton.<>c.<>9__1_0 = val_9;
        }
        
        this.forestButton.m_OnClick.AddListener(call:  162246656);
    }
    public WFOForestMenuButton()
    {
    
    }

}
