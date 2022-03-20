using UnityEngine;
public class FeatureMenuItem : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.UI.Image> actionableIcons;
    private UnityEngine.UI.Image featureIcon;
    private UnityEngine.UI.Text featureNameText;
    private UnityEngine.UI.Text featureUnlockLevel;
    private UnityEngine.GameObject lockImage;
    private bool itemInteractable;
    private System.Action myClickAction;
    
    // Methods
    public virtual void Setup(WGFeatureMenu.FeatureMenuItemConfig config)
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        UnityEngine.Sprite val_15 = config.itemSprite;
        this.featureIcon.sprite = val_15;
        this.itemInteractable = config.enabled;
        this.myClickAction = config.onClickAction;
        if(config.customActionableIcons > config.onClickAction)
        {
                UnityEngine.Debug.LogError(message:  -1433380032);
            return;
        }
        
        if(config.onClickAction < 1)
        {
            goto label_9;
        }
        
        val_14 = 4;
        goto label_10;
        label_26:
        val_15 = val_15 - 1;
        if(config.onClickAction <= this.actionableIcons)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(this.actionableIcons > val_15)
        {
                UnityEngine.GameObject val_1 = 2621443.gameObject;
            val_15 = 0;
        }
        else
        {
                if(0 <= this.actionableIcons)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            2621443.sprite = 2621443;
            if(2621443 <= this.actionableIcons)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.GameObject val_2 = 2621443.gameObject;
            if(config.enabled == true)
        {
                false = config.featureActionable;
        }
        
            if(false == true)
        {
                false = 1;
        }
        
            val_15 = 1;
        }
        
        2621443.SetActive(value:  true);
        val_14 = 5;
        label_10:
        if((val_14 - 4) < 2621443)
        {
            goto label_26;
        }
        
        goto label_29;
        label_9:
        if(config.onClickAction >= 1)
        {
                if(config.onClickAction == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_16 = 0;
            UnityEngine.GameObject val_4 = 2621443.gameObject;
            if(config.enabled != false)
        {
                if(config.featureActionable == true)
        {
                val_16 = 1;
        }
        
        }
        
            2621443.SetActive(value:  true);
        }
        
        label_29:
        UnityEngine.GameObject val_5 = this.lockImage.gameObject;
        this.lockImage.SetActive(value:  this.lockImage >> 5);
        string val_7 = config.featureNameText.ToUpper();
        val_17 = config.featureNameText;
        if(config.enabled != true)
        {
                string val_8 = System.String.Format(format:  -1433330688, arg0:  13152256);
            val_17 = "LVL {0}";
        }
        
        UnityEngine.Transform val_9 = this.featureUnlockLevel.transform;
        UnityEngine.Transform val_10 = this.featureUnlockLevel.parent;
        UnityEngine.GameObject val_11 = this.featureUnlockLevel.gameObject;
        this.featureUnlockLevel.SetActive(value:  (~config.featureUnlockLevel) >> 31);
        object val_13 = this.GetComponent<System.Object>();
        UnityEngine.Events.UnityAction val_14 = new UnityEngine.Events.UnityAction(object:  -1433301472, method:  new IntPtr(2861640800));
        this.AddListener(call:  162246656);
    }
    private void OnPressed()
    {
        if(this.itemInteractable == true)
        {
                this = this.myClickAction;
        }
        
        if(this == 0)
        {
                return;
        }
        
        this.Invoke();
    }
    public FeatureMenuItem()
    {
    
    }

}
