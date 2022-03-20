using UnityEngine;
public class TRVTriviaPursuitCategoryDisplay : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text category;
    private UnityEngine.UI.Text progress;
    private UnityEngine.UI.Image categoryIcon;
    private UnityEngine.UI.Image progressBar;
    private System.Action onStartAction;
    
    // Methods
    private void OnEnable()
    {
        if(this.onStartAction != 0)
        {
                this.onStartAction.Invoke();
        }
        
        this.onStartAction = 0;
    }
    public void Setup(TRVTriviaPursuitCategoryDisplayInfo info)
    {
        this.categoryIcon.sprite = info.categoryIcon;
        this.progressBar.fillAmount = null;
    }
    public void AnimateCategory(System.Collections.Generic.List<string> incCats, TRVTriviaPursuitCategoryDisplayInfo finalInfo)
    {
        System.Collections.Generic.List<System.String> val_7;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                val_7 = val_1;
            typeof(TRVTriviaPursuitCategoryDisplay.<>c__DisplayClass7_0).__il2cppRuntimeField_C = incCats;
            TRVTriviaPursuitCategoryDisplay.<>c__DisplayClass7_0.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_FFFFFFFFFFFFFFFC = this;
        }
        else
        {
                mem[8] = this;
            val_7 = 12;
            mem[12] = incCats;
        }
        
        typeof(TRVTriviaPursuitCategoryDisplay.<>c__DisplayClass7_0).__il2cppRuntimeField_10 = finalInfo;
        UnityEngine.GameObject val_2 = this.gameObject;
        if(this.activeInHierarchy != false)
        {
                System.Collections.IEnumerator val_4 = this.AnimatingCategory(incCats:  val_7, finalInfo:  typeof(TRVTriviaPursuitCategoryDisplay.<>c__DisplayClass7_0).__il2cppRuntimeField_10);
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  -406701616);
            return;
        }
        
        System.Action val_6 = new System.Action(object:  365707264, method:  new IntPtr(3888240656));
        this.onStartAction = null;
    }
    private System.Collections.IEnumerator AnimatingCategory(System.Collections.Generic.List<string> incCats, TRVTriviaPursuitCategoryDisplayInfo finalInfo)
    {
        typeof(TRVTriviaPursuitCategoryDisplay.<AnimatingCategory>d__8).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(TRVTriviaPursuitCategoryDisplay.<AnimatingCategory>d__8).__il2cppRuntimeField_10 = incCats;
        }
        else
        {
                mem[20] = this;
            mem[16] = incCats;
        }
        
        typeof(TRVTriviaPursuitCategoryDisplay.<AnimatingCategory>d__8).__il2cppRuntimeField_18 = finalInfo;
    }
    public TRVTriviaPursuitCategoryDisplay()
    {
    
    }

}
