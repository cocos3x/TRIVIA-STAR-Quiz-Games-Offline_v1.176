using UnityEngine;
public class AlphabetFtuxTooltip : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button button;
    private UnityEngine.GameObject toolTipPick;
    
    // Methods
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1574688208, method:  new IntPtr(2720254064));
        this.button.m_OnClick.AddListener(call:  162246656);
    }
    public void Setup(UnityEngine.Transform toolTipBase, UnityEngine.Transform letter)
    {
        UnityEngine.Transform val_1 = this.toolTipPick.transform;
        this.toolTipPick.SetParent(parent:  letter, worldPositionStays:  false);
        UnityEngine.Transform val_2 = this.toolTipPick.transform;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.toolTipPick.localPosition = new UnityEngine.Vector3();
        UnityEngine.Transform val_4 = this.toolTipPick.transform;
        this.toolTipPick.SetParent(parent:  toolTipBase, worldPositionStays:  true);
        object val_5 = this.toolTipPick.GetComponent<System.Object>();
        PluginExtension.SetLocalY(transform:  this.toolTipPick, y:  val_3.x);
        UnityEngine.Transform val_6 = this.toolTipPick.transform;
        this.toolTipPick.SetSiblingIndex(index:  1);
        System.Collections.IEnumerator val_7 = this.DestroyAfterSeconds();
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  -1574539344);
    }
    private System.Collections.IEnumerator DestroyAfterSeconds()
    {
        object val_1 = new System.Object();
        typeof(AlphabetFtuxTooltip.<DestroyAfterSeconds>d__4).__il2cppRuntimeField_8 = 0;
        typeof(AlphabetFtuxTooltip.<DestroyAfterSeconds>d__4).__il2cppRuntimeField_10 = this;
    }
    public AlphabetFtuxTooltip()
    {
    
    }
    private void <Start>b__2_0()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  -1574174672);
    }

}
