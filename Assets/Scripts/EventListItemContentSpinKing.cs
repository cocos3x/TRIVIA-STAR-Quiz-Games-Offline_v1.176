using UnityEngine;
public class EventListItemContentSpinKing : EventListItemContentProgressbar
{
    // Fields
    private UnityEngine.UI.Text collectedSpinAmount;
    private UnityEngine.GameObject maxTag;
    
    // Methods
    public void SetupCollectedSpins(string amount, bool isMax)
    {
        this.maxTag.SetActive(value:  isMax);
    }
    public EventListItemContentSpinKing()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
