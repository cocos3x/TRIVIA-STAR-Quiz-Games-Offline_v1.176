using UnityEngine;
public abstract class UIListViewController : MonoBehaviour
{
    // Fields
    private System.Collections.IEnumerator creating;
    private System.Collections.IEnumerator populating;
    protected int curr_total;
    protected UnityEngine.Transform gridRootTransform;
    protected System.Collections.Generic.List<UnityEngine.GameObject> memberGridItems;
    public System.Action<bool> OnToggleLoadingUI;
    public System.Action<bool> OnFinishedUIUpdate;
    public System.Action<bool> OnFinishedUISetup;
    
    // Methods
    protected abstract UnityEngine.GameObject GetMemberItemPrefab(); // 0
    private void UICoroutineStart(ref System.Collections.IEnumerator coroutineRef, System.Collections.IEnumerator target)
    {
        if(coroutineRef != 0)
        {
                this.StopCoroutine(routine:  coroutineRef);
            coroutineRef = 0;
        }
        
        coroutineRef = target;
        UnityEngine.Coroutine val_1 = this.StartCoroutine(routine:  target);
    }
    private void UICoroutineStop(ref System.Collections.IEnumerator coroutineRef)
    {
        if(coroutineRef == 0)
        {
                return;
        }
        
        this.StopCoroutine(routine:  coroutineRef);
        coroutineRef = 0;
    }
    protected void StopCoroutines()
    {
        if(this.populating != 0)
        {
                this.StopCoroutine(routine:  this.populating);
            this.populating = 0;
        }
        
        if(this.creating == 0)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.creating);
        this.creating = 0;
    }
    private void ToggleLoadingPopup(bool state)
    {
        if(this.OnToggleLoadingUI != 0)
        {
                this.OnToggleLoadingUI.Invoke(obj:  state);
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  -1997268544, context:  -1997244432);
    }
    protected void OnDisable()
    {
        if(this.creating == 0)
        {
                this.creating = this.populating;
            return;
        }
        
        this.ToggleLoadingPopup(state:  false);
        if(this.populating != 0)
        {
                this.StopCoroutine(routine:  this.populating);
            this.populating = 0;
        }
        
        if(this.creating == 0)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.creating);
        this.creating = 0;
    }
    protected void UpdateMembersGrid()
    {
        var val_7;
        System.Collections.Generic.List<UnityEngine.GameObject> val_8;
        var val_9;
        System.Collections.IEnumerator val_10;
        val_7 = this;
        UnityEngine.GameObject val_1 = this.gameObject;
        if(this.activeInHierarchy == false)
        {
            goto label_2;
        }
        
        val_8 = this.memberGridItems;
        val_9 = val_7;
        if(0 >= this.curr_total)
        {
            goto label_4;
        }
        
        if(this.creating != 0)
        {
                return;
        }
        
        val_10 = val_7;
        System.Collections.IEnumerator val_3 = this.CreateGridItems();
        goto label_6;
        label_2:
        UnityEngine.Debug.LogWarning(message:  -1996999376);
        return;
        label_4:
        if(this.creating != 0)
        {
                return;
        }
        
        if(this.populating != 0)
        {
                return;
        }
        
        val_10 = R4;
        System.Collections.IEnumerator val_4 = val_10.SetupExistingGridItems();
        label_6:
        R4.UICoroutineStart(coroutineRef: ref  R5, target:  val_10);
    }
    private System.Collections.IEnumerator CreateGridItems()
    {
        object val_1 = new System.Object();
        typeof(UIListViewController.<CreateGridItems>d__15).__il2cppRuntimeField_8 = 0;
        typeof(UIListViewController.<CreateGridItems>d__15).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator SetupExistingGridItems()
    {
        object val_1 = new System.Object();
        typeof(UIListViewController.<SetupExistingGridItems>d__16).__il2cppRuntimeField_8 = 0;
        typeof(UIListViewController.<SetupExistingGridItems>d__16).__il2cppRuntimeField_10 = this;
    }
    protected virtual void SetupGridItem(int i)
    {
        UnityEngine.Debug.LogError(message:  -1996646832, context:  -1996622704);
    }
    protected UIListViewController()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.memberGridItems = null;
    }

}
