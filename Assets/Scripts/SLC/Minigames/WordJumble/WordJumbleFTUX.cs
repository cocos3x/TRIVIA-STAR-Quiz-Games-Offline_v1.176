using UnityEngine;

namespace SLC.Minigames.WordJumble
{
    public class WordJumbleFTUX : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image handImage;
        private string answer;
        private int curIndex;
        private System.Collections.Generic.List<SLC.Minigames.WordJumble.WordJumbleLetterTile> tiles;
        private SLC.Minigames.WordJumble.WordJumbleLetterTile curTile;
        
        // Methods
        public void Init(SLC.Minigames.WordJumble.WordJumbleGameplayController controller)
        {
            var val_3;
            if( == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            List.Enumerator<T> val_1 = GetEnumerator();
            label_9:
            if(MoveNext() == false)
            {
                goto label_6;
            }
            
            object val_4 = val_3.GetComponent<System.Object>();
            val_3.interactable = false;
            goto label_9;
            label_6:
            Dispose();
            this.answer = static_value_00280023;
            this.FillListWithTilesSequentially(myArea:  2621443);
            this.SetHand();
            System.Action val_5 = new System.Action(object:  916610784, method:  new IntPtr(916584736));
            System.Action val_6 = new System.Action(object:  916610784, method:  new IntPtr(916585760));
            System.Collections.IEnumerator val_7 = this.FlashHand();
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  916610784);
        }
        private void FillListWithTilesSequentially(SLC.Minigames.WordJumble.WordJumbleWordArea myArea)
        {
            var val_12;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            AddRange(collection:  myArea.inputLetters);
            val_12 = 0;
            string val_2 = 916717216 + this.answer;
            UnityEngine.Debug.LogError(message:  916717216);
            goto label_5;
            label_14:
            object val_3 = new System.Object();
            typeof(WordJumbleFTUX.<>c__DisplayClass6_0).__il2cppRuntimeField_8 = this.answer.Chars[0];
            System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_5 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  447868928, method:  new IntPtr(916726528));
            object val_6 = System.Linq.Enumerable.First<System.Object>(source:  80883712, predicate:  7720960);
            string val_8 = UnityEngine.Object.op_Equality(x:  80883712, y:  0).ToString();
            string val_9 = 916729600 + 916751019;
            UnityEngine.Debug.LogError(message:  916729600);
            bool val_10 = Remove(item:  80883712);
            this.tiles.Add(item:  80883712);
            val_12 = 1;
            label_5:
            if(val_12 < this.answer.m_stringLength)
            {
                goto label_14;
            }
            
            string val_11 = 916738976 + 13152256;
            UnityEngine.Debug.LogError(message:  916738976);
        }
        private void SetHand()
        {
            if(true == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.curTile = 2621443;
            bool val_1 = this.tiles.Remove(item:  2621443);
            UnityEngine.Transform val_2 = this.handImage.transform;
            UnityEngine.Transform val_3 = this.curTile.transform;
            UnityEngine.Vector3 val_4 = position;
            this.handImage.position = new UnityEngine.Vector3();
            object val_5 = this.curTile.GetComponent<System.Object>();
            this.curTile.interactable = true;
        }
        private void OnTileClicked()
        {
            if(true != 0)
            {
                    this.SetHand();
                return;
            }
            
            UnityEngine.Debug.LogError(message:  917032688);
        }
        private void OnWordComplete()
        {
            UnityEngine.GameObject val_1 = this.handImage.gameObject;
            this.handImage.SetActive(value:  false);
            this.enabled = false;
        }
        private System.Collections.IEnumerator FlashHand()
        {
            object val_1 = new System.Object();
            typeof(WordJumbleFTUX.<FlashHand>d__10).__il2cppRuntimeField_8 = 0;
            typeof(WordJumbleFTUX.<FlashHand>d__10).__il2cppRuntimeField_10 = this;
        }
        public WordJumbleFTUX()
        {
            this.answer = "";
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.tiles = null;
        }
    
    }

}
