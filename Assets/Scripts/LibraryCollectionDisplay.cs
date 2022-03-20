using UnityEngine;
public class LibraryCollectionDisplay : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button button_collection;
    private UnityEngine.UI.Text text_name;
    private UnityEngine.UI.Text text_score;
    private UnityEngine.UI.Text text_books;
    private string currentCollection;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1692511024, method:  new IntPtr(2602431248));
        this.button_collection.m_OnClick.AddListener(call:  162246656);
    }
    public void Setup(string name, int score, int numBooks)
    {
        this.currentCollection = name;
        string val_1 = name.ToUpper();
        string val_2 = score.ToString();
        string val_3 = numBooks.ToString();
        if(this.text_books != 0)
        {
                return;
        }
    
    }
    private void OnCollectionClicked()
    {
        TheLibraryUI.ShowTheLibraryCollection(collectionName:  this.currentCollection, trackLibraryAccessed:  false);
    }
    public LibraryCollectionDisplay()
    {
        this.currentCollection = "";
    }

}
