using UnityEngine;
public class TheLibraryAcquireBookPackPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text addedScoreText;
    private UnityEngine.GameObject libraryScoreStatView;
    private UnityEngine.UI.Button revealCollectButton;
    private UnityEngine.UI.Text buttonText;
    private UnityEngine.ParticleSystem starsParticles;
    private LibraryBookDisplay[] booksToDisplay;
    private int addedLibraryScore;
    private DG.Tweening.Sequence revealSequence;
    private System.Collections.Generic.List<BookInfo> _packPurchased;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1691443632, method:  new IntPtr(2603498640));
        this.revealCollectButton.m_OnClick.AddListener(call:  162246656);
    }
    public void Setup(System.Collections.Generic.List<BookInfo> packPurchased)
    {
        var val_25;
        var val_26;
        DG.Tweening.TweenCallback val_28;
        var val_29;
        this._packPurchased = packPurchased;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        this.revealSequence = 0;
        object val_2 = DG.Tweening.TweenExtensions.Pause<System.Object>(t:  0);
        val_25 = 4;
        goto label_3;
        label_38:
        if(R8 < 0)
        {
                typeof(TheLibraryAcquireBookPackPopup.<>c__DisplayClass10_0).__il2cppRuntimeField_10 = this;
            if(new System.Object() <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            this.booksToDisplay[0].Setup(info:  2621443);
            LibraryBookDisplay val_27 = this.booksToDisplay[0];
            UnityEngine.Transform val_4 = val_27.transform;
            DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOShakePosition(target:  val_27, duration:  null, strength:  null, vibrato:  1061158912, randomness:  null, snapping:  false, fadeOut:  true);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.revealSequence, t:  val_27);
            typeof(TheLibraryAcquireBookPackPopup.<>c__DisplayClass10_0).__il2cppRuntimeField_8 = this.booksToDisplay[0];
            DG.Tweening.TweenCallback val_7 = new DG.Tweening.TweenCallback(object:  300797952, method:  new IntPtr(2603755024));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.revealSequence, callback:  190734336);
            val_26 = null;
            val_26 = null;
            val_28 = TheLibraryAcquireBookPackPopup.<>c.<>9__10_3;
            if(val_28 == 0)
        {
                val_28 = null;
            val_28 = new DG.Tweening.TweenCallback(object:  TheLibraryAcquireBookPackPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2603760144));
            TheLibraryAcquireBookPackPopup.<>c.<>9__10_3 = val_28;
        }
        
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.revealSequence, callback:  190734336);
            LibraryBookDisplay val_29 = this.booksToDisplay[0];
            UnityEngine.Transform val_11 = val_29.transform;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -1.493859E-22f}, d:  val_12.x);
            DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  val_29, punch:  new UnityEngine.Vector3(), duration:  val_13.x, vibrato:  1056964608, elasticity:  val_13.y);
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.revealSequence, t:  val_29);
            val_29 = null;
            val_29 = null;
            if((packPurchased + 12) <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            BookEconInfo val_16 = TheLibraryLogic.BookEcon.Item[packPurchased + 8 + 16 + 20];
            typeof(TheLibraryAcquireBookPackPopup.<>c__DisplayClass10_0).__il2cppRuntimeField_C = TheLibraryLogic.BookEcon + 12;
            DG.Tweening.TweenCallback val_17 = new DG.Tweening.TweenCallback(object:  300797952, method:  new IntPtr(2603810320));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.revealSequence, callback:  190734336);
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.revealSequence, interval:  val_13.x);
        }
        else
        {
                LibraryBookDisplay val_30 = this.booksToDisplay[0];
            UnityEngine.GameObject val_20 = val_30.gameObject;
            val_30.SetActive(value:  false);
        }
        
        val_25 = 5;
        label_3:
        if((val_25 - 4) < val_30)
        {
            goto label_38;
        }
        
        DG.Tweening.TweenCallback val_22 = new DG.Tweening.TweenCallback(object:  -1691039792, method:  new IntPtr(2603897360));
        DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.revealSequence, callback:  190734336);
        DG.Tweening.TweenCallback val_24 = new DG.Tweening.TweenCallback(object:  -1691039792, method:  new IntPtr(2603902480));
        object val_25 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.revealSequence, action:  190734336);
    }
    private void BookRevealEffect(LibraryBookDisplay bookDisplay)
    {
        UnityEngine.GameObject val_1 = bookDisplay.gameObject;
        UnityEngine.Transform val_2 = bookDisplay.transform;
        UnityEngine.Transform val_3 = bookDisplay.Find(n:  -1690669168);
        UnityEngine.GameObject val_4 = bookDisplay.gameObject;
        bookDisplay.SetActive(value:  false);
        UnityEngine.GameObject val_5 = bookDisplay.gameObject;
        UnityEngine.Transform val_6 = bookDisplay.transform;
        UnityEngine.Transform val_7 = bookDisplay.Find(n:  -1690669056);
        UnityEngine.GameObject val_8 = bookDisplay.gameObject;
        bookDisplay.SetActive(value:  true);
    }
    private void UpdateAddedScoreText(int addedValue)
    {
        int val_3 = this.addedLibraryScore;
        val_3 = val_3 + addedValue;
        this.addedLibraryScore = val_3;
        string val_1 = this.addedLibraryScore.ToString();
        string val_2 = System.String.Format(format:  2128510224, arg0:  -1690524716);
        if(this.addedScoreText == 0)
        {
            
        }
    
    }
    private void DoPostRevealEffects()
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = 0;
        goto label_1;
        label_30:
        LibraryBookDisplay val_6 = this.booksToDisplay[val_6];
        UnityEngine.GameObject val_1 = val_6.gameObject;
        if(val_6.activeSelf == false)
        {
            goto label_16;
        }
        
        LibraryBookDisplay val_7 = this.booksToDisplay[val_6];
        if(this.booksToDisplay[0x0][0].bookInfo.Rarity < 2)
        {
            goto label_16;
        }
        
        LibraryBookDisplay val_8 = this.booksToDisplay[val_6];
        if(this.booksToDisplay[0x0][0].bookInfo.Rarity < 3)
        {
            goto label_16;
        }
        
        LibraryBookDisplay val_9 = this.booksToDisplay[val_6];
        val_7 = 0;
        goto label_20;
        label_28:
        if(1152921507209181152.activeSelf != false)
        {
                UnityEngine.Transform val_4 = 1152921507209181152.transform;
            val_8 = 1152921507209181152;
            object val_5 = UnityEngine.Object.Instantiate<System.Object>(original:  this.starsParticles, parent:  -1692633120);
        }
        
        val_7 = 1;
        label_20:
        if(val_7 < this.starsParticles)
        {
            goto label_28;
        }
        
        label_16:
        val_6 = 1;
        label_1:
        if(val_6 < this.starsParticles)
        {
            goto label_30;
        }
    
    }
    private void OnClick_Reveal()
    {
        this.revealCollectButton.interactable = false;
        string val_1 = Localization.Localize(key:  -1827401648, defaultValue:  -1827401552, useSingularKey:  false);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1689746768, method:  new IntPtr(2603498640));
        this.revealCollectButton.m_OnClick.RemoveListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1689746768, method:  new IntPtr(2605187312));
        this.revealCollectButton.m_OnClick.AddListener(call:  162246656);
        this.libraryScoreStatView.SetActive(value:  true);
        object val_4 = DG.Tweening.TweenExtensions.Play<System.Object>(t:  this.revealSequence);
    }
    private void OnClick_Collect()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1689599952, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TheLibraryAcquireBookPackPopup()
    {
    
    }
    private void <Setup>b__10_0()
    {
        this.DoPostRevealEffects();
    }
    private void <Setup>b__10_1()
    {
        this.revealCollectButton.interactable = true;
    }

}
