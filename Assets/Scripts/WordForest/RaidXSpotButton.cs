using UnityEngine;

namespace WordForest
{
    public class RaidXSpotButton : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button button;
        private System.Action<WordForest.RaidXSpotButton> onButtonClicked;
        private int <SpotId>k__BackingField;
        
        // Properties
        public UnityEngine.UI.Button Button { get; }
        public int SpotId { get; set; }
        public bool Interactable { get; set; }
        
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
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            object val_2 = this.GetComponent<System.Object>();
            this.button = this;
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  271525600, method:  new IntPtr(271500576));
            this.AddListener(call:  162246656);
        }
        public void Initialize(int id, System.Action<WordForest.RaidXSpotButton> onClicked)
        {
            System.Action<WordForest.RaidXSpotButton> val_2 = this.onButtonClicked;
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
        }
        private void OnClicked()
        {
            if(this.onButtonClicked == 0)
            {
                    return;
            }
            
            this.onButtonClicked.Invoke(obj:  271771104);
        }
        public RaidXSpotButton()
        {
        
        }
    
    }

}
