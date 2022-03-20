using UnityEngine;
public class WordIQCellOverlay : MonoBehaviour
{
    // Fields
    public const int CellSiblingIndex = 1;
    private UnityEngine.Sprite emptyCellSprite;
    private UnityEngine.Sprite pickerHintEmptyCellSprite;
    private UnityEngine.ParticleSystem particles;
    private Cell ParentCell;
    
    // Methods
    public void SetParentCell(Cell parentCell)
    {
        System.Action val_5;
        var val_6;
        this.ParentCell = parentCell;
        System.Action val_1 = new System.Action(object:  -935003248, method:  new IntPtr(3359930832));
        System.Delegate val_2 = System.Delegate.Combine(a:  parentCell.CellClickedAction, b:  7454720);
        val_5 = parentCell.CellClickedAction;
        if(val_5 != 0)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_5 = 0;
        label_4:
        parentCell.CellClickedAction = val_5;
        object val_3 = parentCell.GetComponent<System.Object>();
        if(parentCell != 0)
        {
                val_6 = parentCell;
            val_6.spriteState = new UnityEngine.UI.SpriteState() {m_DisabledSprite = this.pickerHintEmptyCellSprite};
        }
        else
        {
                val_6 = 0;
            0.spriteState = new UnityEngine.UI.SpriteState() {m_DisabledSprite = this.pickerHintEmptyCellSprite};
        }
        
        UnityEngine.UI.Image val_4 = val_6.image;
        val_6.sprite = this.emptyCellSprite;
    }
    public void PlayFoundAnimation()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  true);
        this.particles.Play();
    }
    private void OnClicked()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public WordIQCellOverlay()
    {
    
    }

}
