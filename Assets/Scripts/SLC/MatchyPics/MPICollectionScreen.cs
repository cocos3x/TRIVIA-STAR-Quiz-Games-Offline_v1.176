using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPICollectionScreen : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject progressObj;
        private UnityEngine.GameObject completedObj;
        private UnityEngine.UI.Image backgroudReward;
        private UnityEngine.UI.Text coinRewardText;
        private UnityEngine.Transform itemsParent;
        private UnityEngine.Color disableColor;
        private UnityEngine.UI.Button chooseBckgdButton;
        private UnityEngine.UI.Button selectedButton;
        private SLC.MatchyPics.MPICollectionBackground bgImage;
        public System.Action onBackgroundClick;
        private bool completed;
        private SLC.MatchyPics.MPICollection collection;
        
        // Methods
        public void Awake()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  737440320, method:  new IntPtr(737407104));
            this.selectedButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  737440320, method:  new IntPtr(737407104));
            this.chooseBckgdButton.m_OnClick.AddListener(call:  162246656);
        }
        public void LoadCollection(SLC.MatchyPics.MPICollection collection)
        {
            UnityEngine.GameObject val_10;
            var val_11;
            this.collection = collection;
            int val_1 = collection.CollectedItems();
            val_1 = val_1 >> 5;
            this.completed = val_1;
            if(val_1 != 16)
            {
                    val_1 - 16 = 1;
            }
            
            this.progressObj.SetActive(value:  true);
            val_10 = this.completedObj;
            if(this.completed == true)
            {
                    val_11 = 1;
            }
            
            val_10.SetActive(value:  true);
            if(this.completed != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                UnityEngine.GameObject val_4 = this.selectedButton.gameObject;
                this.selectedButton.SetActive(value:  this.selectedButton >> 5);
                UnityEngine.GameObject val_7 = this.chooseBckgdButton.gameObject;
                val_10 = this.chooseBckgdButton;
                if((public static SLC.MatchyPics.MPICollectionsManager MonoSingleton<SLC.MatchyPics.MPICollectionsManager>::get_Instance().__il2cppRuntimeField_1C) != collection.imageSetIndex)
            {
                    val_11 = 1;
            }
            
                val_10.SetActive(value:  true);
                this.bgImage.SetBackground(collectionIndex:  collection.imageSetIndex);
            }
            else
            {
                    this.LoadProgression();
            }
            
            CompanyDevices val_8 = CompanyDevices.Instance;
            if(0.CompanyDevice() == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  collection);
        }
        private void LoadProgression()
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            SLC.MatchyPics.MPICollectionScreen val_13;
            var val_14;
            SLC.MatchyPics.MPICollection val_15;
            UnityEngine.Color val_16;
            var val_17;
            var val_18;
            var val_19;
            val_13 = this;
            T[] val_1 = this.itemsParent.GetComponentsInChildren<System.Object>();
            if(this.itemsParent != 16)
            {
                goto label_3;
            }
            
            val_14 = 4;
            goto label_4;
            label_23:
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_15 = this.collection;
            if(this.collection != 0)
            {
                goto label_8;
            }
            
            val_15 = this.collection;
            if(val_15 == 0)
            {
                goto label_9;
            }
            
            label_8:
            UnityEngine.Sprite val_3 = GetSprite(imageSetIndex:  this.collection.imageSetIndex, spriteIndex:  this.collection.itemIndexes[0]);
            R7.sprite = -851265360;
            if(this.collection.itemProgression[0] > 0)
            {
                    UnityEngine.Color val_4 = UnityEngine.Color.white;
                val_16 = val_5;
                val_17 = val_6;
                val_18 = val_7;
                val_19 = val_8;
            }
            else
            {
                    val_16 = this.disableColor;
            }
            
            val_13 = val_13;
            val_14 = 5;
            label_4:
            if((val_14 - 4) < (this.itemsParent + 16))
            {
                goto label_23;
            }
            
            string val_11 = this.collection.CoinReward().ToString();
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Sprite val_13 = GetMaskedBackground(collectionIndex:  this.collection.imageSetIndex);
            mem[1152921513934638628].sprite = -851040240;
            return;
            label_3:
            UnityEngine.Debug.LogError(message:  737832832);
            return;
            label_9:
        }
        private void OnClickBckButton()
        {
            if(this.onBackgroundClick == 0)
            {
                    return;
            }
            
            this.onBackgroundClick.Invoke();
        }
        public MPICollectionScreen()
        {
        
        }
    
    }

}
