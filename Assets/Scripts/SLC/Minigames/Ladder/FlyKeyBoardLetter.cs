using UnityEngine;

namespace SLC.Minigames.Ladder
{
    public class FlyKeyBoardLetter : MonoBehaviour
    {
        // Fields
        private SLC.Minigames.Ladder.WordLadderKeyboardLetter keyboardLettet;
        
        // Methods
        private void Start()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            this.SetActive(value:  false);
        }
        public void setUp(string letter, UnityEngine.Vector2 posStart, UnityEngine.Vector2 posStop, System.Action callback)
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Transform val_2 = this.transform;
            UnityEngine.GameObject val_3 = this.gameObject;
            UnityEngine.Transform val_4 = this.transform;
            UnityEngine.Vector3 val_5 = position;
            UnityEngine.Vector3 val_7 = new UnityEngine.Vector3(x:  val_5.x, y:  val_5.y, z:  val_5.z);
            this.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            UnityEngine.GameObject val_8 = this.gameObject;
            this.SetActive(value:  true);
            mem2[0] = 0;
            mem2[0] = letter;
            UnityEngine.Transform val_9 = this.transform;
            UnityEngine.Vector3 val_10 = position;
            UnityEngine.Vector3 val_12 = new UnityEngine.Vector3(x:  val_10.x, y:  val_10.y, z:  val_10.z);
            System.Collections.IEnumerator val_13 = this.FlyTo(posStop:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, callback:  callback);
            UnityEngine.Coroutine val_14 = this.StartCoroutine(routine:  941578096);
        }
        private System.Collections.IEnumerator FlyTo(UnityEngine.Vector3 posStop, System.Action callback)
        {
            typeof(FlyKeyBoardLetter.<FlyTo>d__3).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(FlyKeyBoardLetter.<FlyTo>d__3).__il2cppRuntimeField_10 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            typeof(FlyKeyBoardLetter.<FlyTo>d__3).__il2cppRuntimeField_14 = posStop.x;
            typeof(FlyKeyBoardLetter.<FlyTo>d__3).__il2cppRuntimeField_18 = posStop.y;
            typeof(FlyKeyBoardLetter.<FlyTo>d__3).__il2cppRuntimeField_1C = posStop.z;
            typeof(FlyKeyBoardLetter.<FlyTo>d__3).__il2cppRuntimeField_20 = callback;
        }
        public FlyKeyBoardLetter()
        {
        
        }
    
    }

}
