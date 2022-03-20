using UnityEngine;
public class GameStoreCategory : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject obj_category_title;
    private UnityEngine.UI.Text text_category_title;
    private UnityEngine.UI.HorizontalOrVerticalLayoutGroup layout_pack_contents;
    
    // Properties
    public UnityEngine.Transform XfmPackageContents { get; }
    
    // Methods
    public UnityEngine.Transform get_XfmPackageContents()
    {
        if(this.layout_pack_contents != 0)
        {
                return this.layout_pack_contents.transform;
        }
        
        return this.layout_pack_contents.transform;
    }
    public void Setup(string categoryTitle, bool showTitle = True)
    {
        GameBehavior val_1 = App.getBehavior;
        string val_2 = System.String.Format(format:  null, arg0:  categoryTitle);
        this.obj_category_title.SetActive(value:  showTitle);
    }
    public void SetSpacing(float verticalSpacing)
    {
        this.layout_pack_contents.spacing = verticalSpacing;
    }
    public int GetFirstAvailableSiblingIndex()
    {
        return 1;
    }
    public GameStoreCategory()
    {
    
    }

}
