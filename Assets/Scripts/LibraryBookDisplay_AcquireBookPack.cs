using UnityEngine;
public class LibraryBookDisplay_AcquireBookPack : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text Title;
    private UnityEngine.UI.Text desc;
    private UnityEngine.UI.Text cost;
    private UnityEngine.UI.Button button_purchase;
    private System.Action<LibraryBookDisplay_AcquireBookPack> bookClickedAction;
    private int _packSize;
    
    // Properties
    public int PackSize { get; }
    
    // Methods
    public int get_PackSize()
    {
        return (int)this._packSize;
    }
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1695470096, method:  new IntPtr(2599472176));
        this.button_purchase.m_OnClick.AddListener(call:  162246656);
    }
    public void Setup(string bookpack, string packdescription, int packcost, int packSize, System.Action<LibraryBookDisplay_AcquireBookPack> onBookClicked)
    {
        string val_1 = packcost.ToString();
        this.bookClickedAction = onBookClicked;
        this._packSize = packSize;
    }
    private void OnPurchaseClicked()
    {
        if(this.bookClickedAction == 0)
        {
                return;
        }
        
        this.bookClickedAction.Invoke(obj:  -1695183632);
    }
    public LibraryBookDisplay_AcquireBookPack()
    {
    
    }

}
