using UnityEngine;
public interface IStoreUI
{
    // Methods
    public abstract void RefreshPackItemDisplays(); // 0
    public abstract void CreatePackItems(); // 0
    public abstract void MakeStoreItem(int index, UnityEngine.Transform parentXfm); // 0
    public abstract void PurchaseItemModel(PurchaseModel pack); // 0
    public abstract void ShowConnectionRequired(); // 0
    public abstract void Close(); // 0

}
