using UnityEngine;

namespace SLC.Minigames.Bubbles
{
    public class WordBubblesBubble : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text myLetter;
        private UnityEngine.UI.Image image;
        private string <Text>k__BackingField;
        private UnityEngine.Color <color>k__BackingField;
        public int Index;
        
        // Properties
        public string Text { get; set; }
        public UnityEngine.Color color { get; set; }
        
        // Methods
        public string get_Text()
        {
        
        }
        private void set_Text(string value)
        {
            this.<Text>k__BackingField = value;
        }
        public UnityEngine.Color get_color()
        {
            var val_1 = R1 + 24;
            return new UnityEngine.Color();
        }
        private void set_color(UnityEngine.Color value)
        {
        
        }
        private void Awake()
        {
            object val_1 = this.GetComponent<System.Object>();
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  970520656, method:  typeof(SLC.Minigames.Bubbles.WordBubblesBubble).__il2cppRuntimeField_E0);
            this.AddListener(call:  162246656);
        }
        public virtual void OnClick()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.Bubbles.WordBubblesController MonoSingleton<SLC.Minigames.Bubbles.WordBubblesController>::get_Instance().__il2cppRuntimeField_22) != 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ChooseWordElement(bubble:  R4);
        }
        public void Setup(string text, UnityEngine.Color c, int index = -1)
        {
            string val_3;
            int val_4;
            float val_5;
            val_3 = text;
            val_4 = index;
            if(this.image != 0)
            {
                    val_5 = c.a;
                if(this.image == 0)
            {
                    val_5 = val_5;
            }
            
                this.image.color = new UnityEngine.Color() {r = c.r, g = c.g, b = c.b, a = val_5};
                this.<color>k__BackingField = c;
                mem[1152921514167546732] = c.g;
                mem[1152921514167546736] = c.b;
                mem[1152921514167546740] = val_5;
                val_3 = val_3;
                val_4 = index;
                if(this.myLetter != 0)
            {
                    this.<Text>k__BackingField = val_3;
            }
            
            }
            
            if(val_4 != 1)
            {
                    this.Index = val_4;
            }
        
        }
        public WordBubblesBubble()
        {
        
        }
    
    }

}
