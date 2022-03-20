using UnityEngine;
public class WGSnakesAndLaddersBoardProgressUI : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject inProgressGroup;
    private UnityEngine.UI.Text progressText;
    private UnityEngine.GameObject notInProgressGroup;
    private UnityEngine.GameObject checkMark;
    private UnityEngine.UI.Text boardIndex;
    
    // Methods
    public void Setup(int boardNum, bool isCurrentBoard, int percentProgress)
    {
        var val_4;
        UnityEngine.GameObject val_5;
        UnityEngine.GameObject val_6;
        val_4 = 35627635;
        if(isCurrentBoard != false)
        {
                string val_1 = System.String.Format(format:  2124591920, arg0:  13152256);
            val_5 = "{0}%";
            this.inProgressGroup.SetActive(value:  true);
            val_6 = this.notInProgressGroup;
        }
        else
        {
                bool val_2 = percentProgress.Equals(obj:  100);
            if(val_2 != false)
        {
                val_4 = "";
        }
        else
        {
                string val_3 = boardNum.ToString();
            val_4;
        }
        
            val_5 = this.checkMark;
            val_5.SetActive(value:  val_2);
            this.notInProgressGroup.SetActive(value:  true);
            val_6 = this.inProgressGroup;
        }
        
        val_6.SetActive(value:  false);
    }
    public WGSnakesAndLaddersBoardProgressUI()
    {
    
    }

}
