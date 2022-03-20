using UnityEngine;

namespace RestaurantRivals
{
    public class RaidXSpotButton : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image buttonGraphic;
        private UnityEngine.Sprite normalSprite;
        private UnityEngine.Sprite openedSprite;
        private UnityEngine.Transform coinSpawnPoint;
        private UnityEngine.UI.Button button;
        private System.Action<RestaurantRivals.RaidXSpotButton> onButtonClicked;
        private int <SpotId>k__BackingField;
        
        // Properties
        public UnityEngine.UI.Button Button { get; }
        public int SpotId { get; set; }
        public bool Interactable { get; set; }
        public UnityEngine.Transform CoinSpawnPoint { get; }
        
        // Methods
        public UnityEngine.UI.Button get_Button()
        {
        
        }
        public int get_SpotId()
        {
            return (int)this.<SpotId>k__BackingField;
        }
        private void set_SpotId(int value)
        {
            this.<SpotId>k__BackingField = value;
        }
        public bool get_Interactable()
        {
            if(this.button != 0)
            {
                    return (bool)this;
            }
            
            return (bool)this;
        }
        public void set_Interactable(bool value)
        {
            this.button.interactable = value;
        }
        public UnityEngine.Transform get_CoinSpawnPoint()
        {
        
        }
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            object val_2 = this.GetComponent<System.Object>();
            this.button = this;
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  671252224, method:  new IntPtr(671227200));
            this.AddListener(call:  162246656);
        }
        public void Initialize(int id, System.Action<RestaurantRivals.RaidXSpotButton> onClicked)
        {
            System.Action<RestaurantRivals.RaidXSpotButton> val_2 = this.onButtonClicked;
            this.<SpotId>k__BackingField = id;
            System.Delegate val_1 = System.Delegate.Combine(a:  val_2 = this.onButtonClicked, b:  onClicked);
            if(val_2 != 0)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            val_2 = 0;
            label_2:
            this.onButtonClicked = val_2;
            this.buttonGraphic.sprite = this.normalSprite;
        }
        private void OnClicked()
        {
            this.buttonGraphic.sprite = this.openedSprite;
            this.button.interactable = false;
            if(this.onButtonClicked == 0)
            {
                    return;
            }
            
            this.onButtonClicked.Invoke(obj:  671526400);
        }
        public RaidXSpotButton()
        {
        
        }
    
    }

}
