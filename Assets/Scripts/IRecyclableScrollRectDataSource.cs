using UnityEngine;
public interface IRecyclableScrollRectDataSource
{
    // Methods
    public abstract int GetItemCount(); // 0
    public abstract void SetCell(ICell cell, int index); // 0
    public abstract int GetStartPos(); // 0

}
