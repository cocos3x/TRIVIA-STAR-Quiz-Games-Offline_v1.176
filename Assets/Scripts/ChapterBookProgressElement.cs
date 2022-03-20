using UnityEngine;
public class ChapterBookProgressElement : MonoBehaviour
{
    // Fields
    private UnityEngine.Sprite sprite_leftSideBar;
    private UnityEngine.Sprite sprite_middleBar;
    private UnityEngine.Sprite sprite_rightSideBar;
    private UnityEngine.UI.Image extraProgressImage;
    private ExtraProgressFlexible extraProgress;
    private UnityEngine.UI.Text chapterText;
    private UnityEngine.GameObject checkMark;
    private UnityEngine.GameObject divider;
    private UnityEngine.GameObject coinGroup;
    private UnityEngine.GameObject coinReward;
    private UnityEngine.GameObject coinRewardGlow;
    
    // Methods
    public void Setup(int chapter, float completeProgress, int lastChapterInBook, bool isCurrentChapter)
    {
        UnityEngine.Sprite val_4;
        this.extraProgress.target = 1f;
        this.extraProgress.current = completeProgress;
        if(chapter == 1)
        {
                val_4 = this.sprite_leftSideBar;
        }
        else
        {
                if((chapter == isCurrentChapter) && ((UnityEngine.Mathf.Approximately(a:  completeProgress, b:  null)) != false))
        {
                val_4 = this.sprite_rightSideBar;
        }
        else
        {
                val_4 = this.sprite_middleBar;
        }
        
        }
        
        this.extraProgressImage.sprite = val_4;
        string val_2 = this.extraProgressImage.RomanNumeralize(num:  chapter);
        UnityEngine.GameObject val_3 = this.chapterText.gameObject;
        if(this.chapterText < 0)
        {
                0 = 1;
        }
        
        this.chapterText.SetActive(value:  true);
        if(this.checkMark >= 0)
        {
                0 = 1;
        }
        
        this.checkMark.SetActive(value:  true);
        this.divider.SetActive(value:  false);
        this.coinGroup.SetActive(value:  false);
    }
    public void SetupAsDivider(bool lastElement)
    {
        UnityEngine.GameObject val_1 = this.chapterText.gameObject;
        this.chapterText.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.checkMark.gameObject;
        this.checkMark.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.extraProgress.gameObject;
        this.extraProgress.SetActive(value:  false);
        this.divider.SetActive(value:  lastElement ^ 1);
        this.coinGroup.SetActive(value:  false);
    }
    public void SetupAsCoin(int chapter, float completeProgress, int lastChapterInBook, bool isCurrentChapter)
    {
        var val_1;
        bool val_8;
        bool val_9;
        UnityEngine.GameObject val_2 = this.chapterText.gameObject;
        this.chapterText.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.checkMark.gameObject;
        this.checkMark.SetActive(value:  false);
        UnityEngine.GameObject val_4 = this.extraProgress.gameObject;
        this.extraProgress.SetActive(value:  false);
        val_8 = 0;
        this.divider.SetActive(value:  false);
        this.coinGroup.SetActive(value:  true);
        if(chapter != isCurrentChapter)
        {
                if(chapter < 0)
        {
                0 = 1;
        }
        
            val_8 = 1 | val_1;
        }
        
        val_9 = 0;
        this.coinReward.SetActive(value:  val_8);
        if((val_8 & val_1) == 1)
        {
                val_9 = UnityEngine.Mathf.Approximately(a:  1f, b:  null);
        }
        
        this.coinRewardGlow.SetActive(value:  val_9);
    }
    private string RomanNumeralize(int num)
    {
        var val_4;
        int val_1 = num - 1;
        if(val_1 <= 4)
        {
                var val_2 = 14309352 + (14309352 + ((num - 1)) << 2);
            if(val_1 == 4)
        {
                14309352 + ((num - 1)) << 2 = (14309352 + ((num - 1)) << 2) & (num << (14309352 + ((num - 1)) << 2));
            14309352 + ((num - 1)) << 2 = (14309352 + ((num - 1)) << 2) & ((14309352 + ((num - 1)) << 2) >> (14309352 + ((num - 1)) << 2));
            14309352 + ((num - 1)) << 2 = (14309352 + ((num - 1)) << 2) & ((IP) >> ((14309352 + ((num - 1)) << 2 & (num) << 14309352 + ((num - 1)) << 2) & ((14309352 + ((num - 1)) << 2 & (num) << 14309352 + ((num - 1)) << 2)) >> (14309352 + ((num - 1)) << 2 & (num) << 14309352 + ((n);
            14309352 + ((num - 1)) << 2 = (14309352 + ((num - 1)) << 2) & (((int)R8) >> 32);
            14309352 + ((num - 1)) << 2 = (14309352 + ((num - 1)) << 2) & (num >> (14309352 + ((num - 1)) << 2));
        }
        
            val_4 = "I";
            return;
        }
        
        string val_3 = num.ToString();
    }
    public ChapterBookProgressElement()
    {
    
    }

}
