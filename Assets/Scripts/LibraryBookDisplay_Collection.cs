using UnityEngine;
public class LibraryBookDisplay_Collection : LibraryBookDisplay
{
    // Fields
    private UnityEngine.GameObject obj_book_count;
    private UnityEngine.UI.Text text_book_count;
    private UnityEngine.UI.Text text_book_score_amount;
    
    // Methods
    public void Setup(BookInfo info, int bookCount)
    {
        var val_4;
        this.Setup(info:  info);
        if(bookCount > 1)
        {
                0 = 1;
        }
        
        this.obj_book_count.SetActive(value:  true);
        string val_1 = bookCount.ToString();
        val_4 = null;
        val_4 = null;
        BookEconInfo val_2 = TheLibraryLogic.BookEcon.Item[info.Rarity];
        int val_4 = bookCount;
        val_4 = val_4 * (TheLibraryLogic.BookEcon + 12);
        string val_3 = val_4.ToString();
        if(this.text_book_score_amount != 0)
        {
                return;
        }
    
    }
    public LibraryBookDisplay_Collection()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
