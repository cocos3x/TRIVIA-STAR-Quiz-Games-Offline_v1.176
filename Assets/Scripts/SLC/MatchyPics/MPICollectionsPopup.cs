using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPICollectionsPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject listGroup;
        private UnityEngine.GameObject collectionGroup;
        private UnityEngine.UI.Text titleText;
        private UnityEngine.UI.Button infoButton;
        private UnityEngine.UI.Button backButton;
        private SLC.MatchyPics.MPICollectionListItem headerItem;
        private UnityEngine.Transform listParent;
        private SLC.MatchyPics.MPICollectionListItem listItemPrefab;
        private SLC.MatchyPics.MPICollectionBackground bg;
        private SLC.MatchyPics.MPICollectionScreen collectionScreen;
        private UnityEngine.UI.Button prevCollection;
        private UnityEngine.UI.Button nextCollection;
        private UnityEngine.GameObject popupParent;
        private SLC.MatchyPics.MPIChooseBackgroundPopup chooseBGPopup;
        private UnityEngine.GameObject infoPopup;
        private SLC.MatchyPics.MPICollectionsManager cmanager;
        private System.Collections.Generic.List<SLC.MatchyPics.MPICollectionListItem> cItemsList;
        private int currentCollectionIndex;
        private bool backToList;
        private UnityEngine.GameObject currentPopup;
        private UnityEngine.UI.Text prevButtonText;
        private UnityEngine.UI.Text nextButtonText;
        
        // Methods
        public void Awake()
        {
            System.Action val_9;
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  745778320, method:  new IntPtr(745708240));
            this.prevCollection.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  745778320, method:  new IntPtr(745717456));
            this.nextCollection.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  745778320, method:  new IntPtr(745726672));
            this.infoButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  745778320, method:  new IntPtr(745735888));
            this.backButton.m_OnClick.AddListener(call:  162246656);
            System.Action val_5 = new System.Action(object:  745778320, method:  new IntPtr(745745104));
            System.Delegate val_6 = System.Delegate.Combine(a:  this.collectionScreen.onBackgroundClick, b:  7454720);
            val_9 = this.collectionScreen.onBackgroundClick;
            if(val_9 != 0)
            {
                    if(null == null)
            {
                goto label_12;
            }
            
            }
            
            val_9 = 0;
            label_12:
            this.collectionScreen.onBackgroundClick = val_9;
            object val_7 = this.prevCollection.GetComponentInChildren<System.Object>();
            this.prevButtonText = this.prevCollection;
            object val_8 = this.nextCollection.GetComponentInChildren<System.Object>();
            this.nextButtonText = this.nextCollection;
        }
        public void Start()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.cmanager = public static SLC.MatchyPics.MPICollectionsManager MonoSingleton<SLC.MatchyPics.MPICollectionsManager>::get_Instance();
            int val_2 = this.currentCollectionIndex + 1;
            val_2 = val_2 >> 5;
            this.backToList = val_2;
            this.SetupUI();
        }
        public void LoadCollectionList()
        {
            var val_5;
            var val_6;
            var val_7;
            if(true != 0)
            {
                goto label_2;
            }
            
            val_5 = 0;
            val_6 = 1152921513942813136;
            goto label_3;
            label_11:
            UnityEngine.GameObject val_1 = this.listItemPrefab.gameObject;
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.listItemPrefab, parent:  this.listParent);
            object val_3 = this.listItemPrefab.GetComponent<System.Object>();
            this.cItemsList.Add(item:  this.listItemPrefab);
            val_5 = 1;
            label_3:
            if(val_5 < this.cItemsList)
            {
                goto label_11;
            }
            
            label_2:
            val_7 = 4;
            goto label_12;
            label_21:
            if(this.cItemsList <= this.cItemsList)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(0 <= this.cItemsList)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.Action<System.Int32> val_4 = null;
            val_6 = val_4;
            val_4 = new System.Action<System.Int32>(object:  746111888, method:  new IntPtr(746054096));
            2621443.LoadCollection(collection:  this.listItemPrefab.progressionText, onClickCollectionItem:  7401472);
            val_7 = 5;
            label_12:
            if((val_7 - 4) < 2621443)
            {
                goto label_21;
            }
            
            this.bg.SetBackground(collectionIndex:  this.cmanager.backgroundIndex);
        }
        public void LoadCollection(int collectionIndex)
        {
            this.currentCollectionIndex = collectionIndex;
            if(this.cmanager == 0)
            {
                    return;
            }
            
            this.SetupUI();
        }
        private void SetupUI()
        {
            if(this.currentCollectionIndex >= true)
            {
                    this.currentCollectionIndex = 0;
                this.currentCollectionIndex = this.currentCollectionIndex;
            }
            
            this.listGroup.SetActive(value:  false);
            UnityEngine.GameObject val_1 = this.infoButton.gameObject;
            this.infoButton.SetActive(value:  false);
            UnityEngine.GameObject val_2 = this.titleText.gameObject;
            this.titleText.SetActive(value:  false);
            UnityEngine.GameObject val_3 = this.collectionGroup.gameObject;
            this.collectionGroup.SetActive(value:  false);
            UnityEngine.GameObject val_4 = this.headerItem.gameObject;
            this.headerItem.SetActive(value:  false);
            if(this.currentCollectionIndex >= 0)
            {
                    if(this.headerItem <= this.currentCollectionIndex)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_5 = val_5 + (this.currentCollectionIndex << 2);
                this.collectionScreen.LoadCollection(collection:  (0 + (this.currentCollectionIndex) << 2) + 16);
                this.headerItem.LoadCollection(collection:  (0 + (this.currentCollectionIndex) << 2) + 16, onClickCollectionItem:  0);
                this.SetupPageButtons();
                return;
            }
            
            this.LoadCollectionList();
        }
        private void OnBackButtonClick()
        {
            if((this.backToList != false) && (this.currentCollectionIndex >= 0))
            {
                    this.currentCollectionIndex = 0;
                this.SetupUI();
                return;
            }
            
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  746603536, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void SetupPageButtons()
        {
            System.Collections.Generic.List<SLC.MatchyPics.MPICollection> val_10;
            int val_11;
            int val_12;
            int val_13;
            UnityEngine.GameObject val_1 = this.prevCollection.gameObject;
            if(this.currentCollectionIndex > 0)
            {
                    0 = 1;
            }
            
            this.prevCollection.SetActive(value:  true);
            UnityEngine.GameObject val_2 = this.nextCollection.gameObject;
            if(this.currentCollectionIndex < ((this.cmanager.<collections>k__BackingField) - 1))
            {
                    0 = 1;
            }
            
            this.nextCollection.SetActive(value:  true);
            val_11 = this.currentCollectionIndex;
            if(val_11 >= 1)
            {
                    if(this.cmanager == 0)
            {
                    val_12 = this.currentCollectionIndex;
            }
            
                val_10 = this.cmanager.<collections>k__BackingField;
                val_12 = val_12 - 1;
                if(this.nextCollection <= val_12)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_9 = val_9 + (val_12 << 2);
                string val_4 = (0 + ((this.currentCollectionIndex - 1)) << 2) + 16 + 12.ToUpper();
                string val_5 = 746720208 + (0 + ((this.currentCollectionIndex - 1)) << 2) + 16 + 12((0 + ((this.currentCollectionIndex - 1)) << 2) + 16 + 12);
                UnityEngine.UI.Text val_10 = this.prevButtonText;
                val_13 = this.currentCollectionIndex;
            }
            
            val_10 = val_10 - 1;
            if(val_13 >= val_10)
            {
                    return;
            }
            
            int val_6 = this.currentCollectionIndex + 1;
            if(val_10 <= val_6)
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_11 = val_11 + (val_6 << 2);
            string val_7 = (0 + ((this.currentCollectionIndex + 1)) << 2) + 16 + 12.ToUpper();
            string val_8 = (0 + ((this.currentCollectionIndex + 1)) << 2) + 16 + 12((0 + ((this.currentCollectionIndex + 1)) << 2) + 16 + 12) + 746740768;
            if(this.nextButtonText == 0)
            {
                
            }
        
        }
        private void OnClickNextCollection()
        {
            int val_1 = this.currentCollectionIndex;
            val_1 = val_1 + 1;
            this.LoadCollection(collectionIndex:  val_1);
        }
        private void OnClickPrevCollection()
        {
            int val_1 = this.currentCollectionIndex;
            val_1 = val_1 - 1;
            this.LoadCollection(collectionIndex:  val_1);
        }
        private void ShowInfoPopup()
        {
            UnityEngine.GameObject val_1 = this.OpenPopup(go:  this.infoPopup);
            object val_2 = this.GetComponentInChildren<System.Object>();
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  747155120, method:  new IntPtr(747130096));
            this.AddListener(call:  162246656);
        }
        private void OnChooseBgButton()
        {
            UnityEngine.GameObject val_1 = this.chooseBGPopup.gameObject;
            UnityEngine.GameObject val_2 = this.OpenPopup(go:  this.chooseBGPopup);
            object val_3 = this.GetComponent<System.Object>();
            if(this != 0)
            {
                    this.titleText = this;
            }
            else
            {
                    mem[20] = this;
            }
            
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  747280432, method:  new IntPtr(747130096));
            this.collectionGroup.AddListener(call:  162246656);
        }
        private UnityEngine.GameObject OpenPopup(UnityEngine.GameObject go)
        {
            this.popupParent.SetActive(value:  true);
            object val_1 = this.popupParent.GetComponentInChildren<System.Object>();
            this.popupParent.alpha = null;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.popupParent, endValue:  null, duration:  null);
            UnityEngine.Transform val_3 = this.popupParent.transform;
            object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  go, parent:  this.popupParent);
            this.currentPopup = go;
            go.SetActive(value:  true);
        }
        public void ClosePopup()
        {
            if(this.currentPopup != 0)
            {
                    this.currentPopup.SetActive(value:  false);
                UnityEngine.Object.Destroy(obj:  this.currentPopup);
                this.currentPopup = 0;
            }
            
            this.popupParent.SetActive(value:  false);
        }
        public MPICollectionsPopup()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.cItemsList = null;
            this.currentCollectionIndex = 0;
        }
    
    }

}
