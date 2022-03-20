using UnityEngine;

namespace SLC.Minigames.EmojiMatch
{
    public class EmojiMatchDisplay : MonoBehaviour
    {
        // Fields
        protected UnityEngine.GameObject[] backgrounds;
        protected UnityEngine.GameObject[] circles;
        protected UnityEngine.GameObject correct_check;
        protected UnityEngine.GameObject incorrect_x;
        
        // Methods
        public UnityEngine.Vector3 GetLinePosition()
        {
            UnityEngine.Transform val_1 = R1 + 16 + 16.transform;
            UnityEngine.Vector3 val_2 = this.position;
            return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        protected virtual void SetState(SLC.Minigames.EmojiMatch.MatchDisplayState state)
        {
            var val_3 = 0;
            goto label_0;
            label_8:
            SLC.Minigames.EmojiMatch.MatchDisplayState val_2 = (state - val_3) >> 5;
            this.backgrounds[val_3].SetActive(value:  val_2);
            UnityEngine.GameObject val_4 = this.circles[val_3];
            val_4.SetActive(value:  val_2);
            val_3 = 1;
            label_0:
            if(val_3 < val_4)
            {
                goto label_8;
            }
        
        }
        public EmojiMatchDisplay()
        {
        
        }
    
    }

}
