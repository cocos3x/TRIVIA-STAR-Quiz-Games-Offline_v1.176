using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPICollectionListItem : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text collectionName;
        private UnityEngine.UI.Text progressionText;
        private UnityEngine.GameObject completedObj;
        private UnityEngine.UI.Image bgReward;
        private bool isTitle;
        private int collectionIndex;
        private System.Action<int> onClickCollectionItem;
        
        // Methods
        public void Start()
        {
            object val_1 = this.GetComponent<System.Object>();
            if(736263360 == 0)
            {
                    return;
            }
            
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  736263360, method:  new IntPtr(736238336));
            this.AddListener(call:  162246656);
        }
        public void LoadCollection(SLC.MatchyPics.MPICollection collection, System.Action<int> onClickCollectionItem)
        {
            var val_15;
            var val_16;
            var val_17;
            int val_18;
            if(collection != 0)
            {
                    val_15 = this;
                this.collectionIndex = collection.imageSetIndex;
                mem[1152921513933202020] = onClickCollectionItem;
            }
            else
            {
                    val_15 = this;
                this.collectionIndex = 0;
                mem[1152921513933202020] = onClickCollectionItem;
            }
            
            if(this.isTitle != false)
            {
                    GameBehavior val_2 = App.getBehavior;
                string val_3 = collection.name.ToUpper();
                val_16 = 0;
                string val_4 = System.String.Format(format:  null, arg0:  collection.name);
            }
            else
            {
                    val_16 = collection.name;
                string val_5 = val_16.ToUpper();
            }
            
            val_17 = 1152921504619999232;
            string val_6 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            val_18 = 1152921504765685760;
            if(this.completedObj != 0)
            {
                    UnityEngine.GameObject val_8 = this.progressionText.gameObject;
                val_17 = collection.CollectedItems() - 16;
                if(this.progressionText != 0)
            {
                    val_17 = 1;
            }
            
                this.progressionText.SetActive(value:  true);
                UnityEngine.GameObject val_9 = this.completedObj.gameObject;
                this.completedObj.SetActive(value:  this.completedObj >> 5);
            }
            
            if(this.bgReward == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_18 = this.collectionIndex;
            UnityEngine.Sprite val_13 = GetMaskedBackground(collectionIndex:  0);
            this.bgReward.sprite = -851040240;
        }
        public void OnClickItem()
        {
            if(this.collectionIndex < 0)
            {
                    return;
            }
            
            if(this.onClickCollectionItem == 0)
            {
                    return;
            }
            
            this.onClickCollectionItem.Invoke(obj:  this.collectionIndex);
        }
        public MPICollectionListItem()
        {
            this.collectionIndex = 0;
        }
    
    }

}
