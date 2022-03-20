using UnityEngine;
public class UGUINetworkedButtonMultiGraphic : UGUINetworkedButton
{
    // Methods
    protected override void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant)
    {
        float val_4;
        var val_5;
        var val_6;
        val_4 = 1f;
        val_5 = 0;
        UnityEngine.GameObject val_1 = this.gameObject;
        bool val_2 = this.activeInHierarchy;
        if(val_2 == false)
        {
                return;
        }
        
        if(val_2 == false)
        {
            goto label_3;
        }
        
        val_6 = 0;
        bool val_3 = instant + 16;
        goto label_4;
        label_8:
        (instant + 16) + 0.enabled = false;
        val_6 = 1;
        label_4:
        if(val_6 < (instant + 12))
        {
            goto label_8;
        }
        
        goto label_9;
        label_3:
        this.SetAlpha(targetAlpha:  null, instant:  1f);
        label_9:
        this.DoStateTransition(state:  state, instant:  instant);
    }
    public UGUINetworkedButtonMultiGraphic()
    {
    
    }

}
