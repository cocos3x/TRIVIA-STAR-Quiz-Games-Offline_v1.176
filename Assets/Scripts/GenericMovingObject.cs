using UnityEngine;
public class GenericMovingObject : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject itemGroup;
    private UnityEngine.GameObject item;
    private UnityEngine.ParticleSystem particle;
    private float flyToPreDelay;
    private float flyToDuration;
    private float flyToAfterDelay;
    private DG.Tweening.Ease easeX;
    private DG.Tweening.Ease easeY;
    public UnityEngine.GameObject eventButton;
    
    // Methods
    public void Init(UnityEngine.GameObject eventButton)
    {
        this.eventButton = eventButton;
    }
    public void ShiftToCell(Cell newParent)
    {
        if(newParent == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Transform val_3 = newParent.transform;
        this.SetParent(p:  newParent);
        object val_4 = this.GetComponent<System.Object>();
        PluginExtension.SetLocalX(transform:  -1381173232, x:  null);
        object val_5 = this.GetComponent<System.Object>();
        PluginExtension.SetLocalY(transform:  -1381173232, y:  null);
    }
    public void Collect()
    {
        if(this.eventButton == 0)
        {
                return;
        }
        
        System.Collections.IEnumerator val_2 = R4.FlyAndHide();
        UnityEngine.Coroutine val_3 = R4.StartCoroutine(routine:  R4);
    }
    public void Remove()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  -1380936944);
    }
    private System.Collections.IEnumerator FlyAndHide()
    {
        object val_1 = new System.Object();
        typeof(GenericMovingObject.<FlyAndHide>d__13).__il2cppRuntimeField_8 = 0;
        typeof(GenericMovingObject.<FlyAndHide>d__13).__il2cppRuntimeField_10 = this;
    }
    public GenericMovingObject()
    {
        this.flyToPreDelay = 0.2f;
        this.flyToDuration = 1f;
        this.flyToAfterDelay = 0.2f;
    }

}
