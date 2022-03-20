using UnityEngine;
public class TRVPlayerProgressWindow : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text numCrownsText;
    private UnityEngine.UI.Text totalCorrect;
    private TRVCategoryDisplay catDisplayPrefab;
    private UnityEngine.Transform categoryParent;
    
    // Methods
    private void OnEnable()
    {
    
    }
    private void DisplayCategoryData()
    {
    
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    public TRVPlayerProgressWindow()
    {
    
    }

}
