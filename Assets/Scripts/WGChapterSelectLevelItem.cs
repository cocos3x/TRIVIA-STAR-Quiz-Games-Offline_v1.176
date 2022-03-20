using UnityEngine;
public class WGChapterSelectLevelItem : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button playbutton;
    private UnityEngine.UI.Text levelText;
    private UnityEngine.GameObject checkmarkGroup;
    private UnityEngine.GameObject checkmark;
    private UnityEngine.GameObject playButtonGroup;
    private UnityEngine.GameObject darkOverlay;
    private UnityEngine.GameObject[] letterContainers;
    private TheLibraryBookProgressPopup _ProgressPopup;
    private System.Action<int> PlayLevelCallback;
    private int thisLevel;
    private static System.Collections.Generic.List<string> defaultLetters;
    
    // Properties
    private TheLibraryBookProgressPopup ProgressPopup { get; }
    
    // Methods
    private TheLibraryBookProgressPopup get_ProgressPopup()
    {
        if(this._ProgressPopup != 0)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = this.transform;
        object val_3 = this.GetComponentInParent<System.Object>();
        this._ProgressPopup = this;
    }
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1672962384, method:  new IntPtr(2621979888));
        this.playbutton.m_OnClick.AddListener(call:  162246656);
    }
    private void ScrollCellIndex(int index)
    {
        TheLibraryBookProgressPopup val_1 = this.ProgressPopup;
        this.SetupGridItem(gridItem:  -1672842192, i:  index);
    }
    public void Setup(int levelName, int currentLevel, string levelWord, System.Action<int> playLevelCallback)
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  (~levelName) >> 31);
        if(levelName < 0)
        {
                return;
        }
        
        this.PlayLevelCallback = playLevelCallback;
        this.thisLevel = levelName;
        this.SetState(levelName:  levelName, currentLevel:  currentLevel);
        if(levelName > currentLevel)
        {
                levelWord = "";
        }
        
        this.SetWord(levelWord:  1098586544);
        string val_3 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
        this = "level_#_upper";
        string val_4 = System.String.Format(format:  -1672741904, arg0:  13152256);
    }
    private void SetState(int levelName, int currentLevel)
    {
        var val_1;
        var val_2;
        if(levelName >= currentLevel)
        {
            goto label_0;
        }
        
        this.checkmarkGroup.SetActive(value:  true);
        this.checkmark.SetActive(value:  true);
        val_1 = 0;
        goto label_4;
        label_0:
        if(levelName != currentLevel)
        {
            goto label_6;
        }
        
        this.checkmarkGroup.SetActive(value:  false);
        val_1 = 1;
        label_4:
        this.playButtonGroup.SetActive(value:  true);
        val_2 = 0;
        goto label_9;
        label_6:
        this.checkmarkGroup.SetActive(value:  true);
        this.checkmark.SetActive(value:  false);
        this.playButtonGroup.SetActive(value:  false);
        val_2 = 1;
        label_9:
        this.darkOverlay.SetActive(value:  true);
    }
    private void SetWord(string levelWord)
    {
        string val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        val_16 = levelWord;
        if((System.String.IsNullOrEmpty(value:  val_16)) != false)
        {
                val_17 = null;
            val_17 = null;
            if(WGChapterSelectLevelItem.defaultLetters != 0)
        {
                val_18 = WGChapterSelectLevelItem.defaultLetters;
            val_19 = UnityEngine.Random.Range(min:  0, max:  WGChapterSelectLevelItem.defaultLetters + 12);
        }
        else
        {
                val_18 = 12;
            val_19 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
            if(val_18 <= val_19)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_15 = WGChapterSelectLevelItem.defaultLetters + 8;
            val_15 = val_15 + (val_19 << 2);
            val_16 = mem[(WGChapterSelectLevelItem.defaultLetters + 8 + (val_3) << 2) + 16];
            val_16 = (WGChapterSelectLevelItem.defaultLetters + 8 + (val_3) << 2) + 16;
        }
        
        string val_4 = val_16.Replace(oldValue:  -2100450224, newValue:  1098586544);
        System.Char[] val_5 = val_16.ToCharArray();
        val_20 = ((WGChapterSelectLevelItem.defaultLetters + 8 + (val_3) << 2) + 16 + 12) - 3;
        val_21 = 0;
        UnityEngine.GameObject val_16 = this.letterContainers[val_20];
        goto label_12;
        label_17:
        UnityEngine.GameObject val_17 = this.letterContainers[val_21];
        val_17.SetActive(value:  (val_20 - val_21) >> 5);
        val_21 = 1;
        label_12:
        if(val_21 < val_17)
        {
            goto label_17;
        }
        
        var val_8 = val_16 + 16;
        val_22 = 0;
        goto label_18;
        label_27:
        UnityEngine.Transform val_9 = val_16.transform;
        UnityEngine.Transform val_10 = val_16.GetChild(index:  0);
        object val_11 = val_16.GetComponentInChildren<System.Object>();
        string val_12 = val_8.ToString();
        val_20 = val_8;
        val_8 = val_8 + 2;
        val_22 = 1;
        label_18:
        UnityEngine.Transform val_13 = val_16.transform;
        if(val_22 < val_16.childCount)
        {
            goto label_27;
        }
    
    }
    private void OnClickPlayLevel()
    {
        if(this.PlayLevelCallback == 0)
        {
                return;
        }
        
        this.PlayLevelCallback.Invoke(obj:  this.thisLevel);
        this.PlayLevelCallback = 0;
    }
    public WGChapterSelectLevelItem()
    {
    
    }
    private static WGChapterSelectLevelItem()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(null != 0)
        {
                Add(item:  -1671841840);
        }
        else
        {
                Add(item:  -1671841840);
        }
        
        Add(item:  -1671841760);
        if(null != 0)
        {
                Add(item:  -1671841680);
        }
        else
        {
                Add(item:  -1671841680);
        }
        
        Add(item:  -1671841600);
        Add(item:  -1671841520);
        WGChapterSelectLevelItem.defaultLetters = null;
    }

}
