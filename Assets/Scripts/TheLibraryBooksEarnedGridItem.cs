using UnityEngine;
public class TheLibraryBooksEarnedGridItem : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject obj_book_mystery;
    private LibraryBookDisplay book_display;
    private TheLibraryBookProgressDisplay progress_display;
    private UnityEngine.UI.Button button_view_chapter_progress;
    private int displayedBookIndex;
    private TheLibraryBooksEarnedScreen _BooksEarnedScreenParent;
    private System.Action<int, int> OnClickedGridItem;
    
    // Properties
    private TheLibraryBooksEarnedScreen BooksEarnedScreenParent { get; }
    
    // Methods
    private TheLibraryBooksEarnedScreen get_BooksEarnedScreenParent()
    {
        if(this._BooksEarnedScreenParent != 0)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = this.transform;
        object val_3 = this.GetComponentInParent<System.Object>();
        this._BooksEarnedScreenParent = this;
    }
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1676346672, method:  new IntPtr(2618595600));
        this.button_view_chapter_progress.m_OnClick.AddListener(call:  162246656);
    }
    public void SetupGridItem(int bookIndex, System.Action<int, int> onClickedGridItem)
    {
        this.OnClickedGridItem = onClickedGridItem;
        this.SetupGridItem(bookIndex:  bookIndex);
    }
    public void SetupGridItem(int bookIndex)
    {
        TheLibraryBookProgressDisplay val_21;
        var val_22;
        System.Action<System.Int32, System.Int32> val_23;
        int val_24;
        var val_25;
        var val_26;
        var val_27;
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  (~bookIndex) >> 31);
        if(bookIndex < 0)
        {
                return;
        }
        
        this.displayedBookIndex = bookIndex;
        int val_3 = ChapterBookLogic.GetCurrentBook(playerLevel:  0);
        val_21 = bookIndex + 1;
        System.Collections.Generic.List<System.String> val_4 = TheLibraryLogic.SkusGrantedForCompletedBooks;
        System.Collections.Generic.List<System.String> val_6 = TheLibraryLogic.SkusGrantedForCompletedBooks;
        System.Collections.Generic.Dictionary<System.String, BookInfo> val_7 = BookList.BookInfos;
        System.Collections.Generic.List<System.String> val_8 = TheLibraryLogic.SkusGrantedForCompletedBooks;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        string val_9 = 0.Item[(TheLibraryLogic.__il2cppRuntimeField_name + (((TheLibraryLogic.__il2cppRuntimeField_namespaze - val_3) + (bookIndex + 1))) << 2) + 16];
        val_22 = 0;
        val_21 = this.progress_display;
        val_23 = null;
        val_23 = new System.Action<System.Int32, System.Int32>(object:  -1676072496, method:  new IntPtr(2618841104));
        val_24 = bookIndex;
        val_25 = 0;
        val_26 = val_23;
        Setup(bookIndex:  null, state:  1, onChapterItemClicked:  7507968);
        val_27 = 1;
        this.button_view_chapter_progress.interactable = false;
        this.obj_book_mystery.SetActive(value:  this.button_view_chapter_progress >> 5);
        UnityEngine.GameObject val_19 = this.book_display.gameObject;
        if( != 0)
        {
                 = 1;
        }
        
        this.book_display.SetActive(value:  true);
        if( == 0)
        {
                return;
        }
        
        this.book_display.Setup(info:  0);
    }
    public void ToggleChapterSelected(int chapter)
    {
        this.progress_display.ToggleChapterSelected(chapter:  chapter);
    }
    private void ScrollCellIndex(int index)
    {
        TheLibraryBooksEarnedScreen val_1 = this.BooksEarnedScreenParent;
        index = this.obj_book_mystery + index;
        this.SetupGridItem(bookIndex:  index);
    }
    private void OnClickViewProgress()
    {
        this.ExecuteProgressDisplayClick(bookIndex:  this.displayedBookIndex, chapter:  1);
    }
    private void ExecuteProgressDisplayClick(int bookIndex, int chapter)
    {
        if(this.OnClickedGridItem != 0)
        {
                this.OnClickedGridItem.Invoke(arg1:  bookIndex, arg2:  chapter);
            return;
        }
        
        TheLibraryBooksEarnedScreen val_1 = this.BooksEarnedScreenParent;
        if((UnityEngine.Object.op_Implicit(exists:  -1675571248)) == false)
        {
                return;
        }
        
        TheLibraryBooksEarnedScreen val_3 = this.BooksEarnedScreenParent;
        this.OnGridItemBookClicked(bookIndex:  bookIndex, chapter:  chapter);
    }
    public TheLibraryBooksEarnedGridItem()
    {
        this.displayedBookIndex = 0;
    }

}
