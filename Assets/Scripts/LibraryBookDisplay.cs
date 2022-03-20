using UnityEngine;
public class LibraryBookDisplay : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text text_book_title;
    private UnityEngine.UI.Text text_book_author;
    private UnityEngine.UI.Text text_book_collection;
    private UnityEngine.GameObject[] obj_stars_rarity;
    private UnityEngine.UI.Image image_book;
    private UnityEngine.Sprite[] sprites_book_rarity;
    private Gradient[] bookGradients;
    private BookInfo bookInfo;
    
    // Properties
    public BookInfo GetBookInfo { get; }
    public UnityEngine.GameObject[] GetStarObjects { get; }
    
    // Methods
    public BookInfo get_GetBookInfo()
    {
    
    }
    public UnityEngine.GameObject[] get_GetStarObjects()
    {
    
    }
    public void Setup(BookInfo info)
    {
        UnityEngine.UI.Image val_5;
        var val_6;
        UnityEngine.GameObject[] val_7;
        var val_8;
        this.bookInfo = info;
        val_5 = 1152921504765685760;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.text_book_collection, y:  0);
        val_6 = 0;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  this.image_book, y:  0);
        if((val_2 == false) || (val_2 == false))
        {
            goto label_16;
        }
        
        val_5 = this.image_book;
        val_5.sprite = this.sprites_book_rarity[info.Rarity];
        goto label_16;
        label_21:
        UnityEngine.GameObject val_6 = this.obj_stars_rarity[val_6];
        if(val_6 <= info.Rarity)
        {
                0 = 1;
        }
        
        val_6.SetActive(value:  true);
        val_6 = 1;
        label_16:
        val_7 = this.obj_stars_rarity;
        if(val_6 < val_6)
        {
            goto label_21;
        }
        
        val_8 = 0;
        goto label_22;
        label_28:
        val_7 = this.bookGradients[val_8];
        val_7.enabled = (val_8 - info.Rarity) >> 5;
        val_8 = 1;
        label_22:
        if(val_8 < val_7)
        {
            goto label_28;
        }
    
    }
    public LibraryBookDisplay()
    {
    
    }

}
