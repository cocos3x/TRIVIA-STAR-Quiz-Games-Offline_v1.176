using UnityEngine;

namespace BlockPuzzleMagic
{
    public class BBLGotoSceneButton : ButtonGotoScene
    {
        // Fields
        private UnityEngine.UI.Text buttonLabel;
        
        // Methods
        protected override void Start()
        {
            this.Start();
            if(this == 2)
            {
                goto label_1;
            }
            
            if(this != 9)
            {
                goto label_2;
            }
            
            Player val_1 = App.Player;
            string val_2 = 33449456.ToLower();
            bool val_3 = System.String.op_Equality(a:  33449456, b:  1217569120);
            if(R6 != 0)
            {
                    R6.interactable = val_3;
            }
            
            UnityEngine.GameObject val_5 = this.gameObject;
            this.SetActive(value:  val_3);
            return;
            label_1:
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((HasSavedGame(gameMode:  2)) == true)
            {
                goto label_20;
            }
            
            GameBehavior val_8 = App.getBehavior;
            if(0 >= 2)
            {
                goto label_20;
            }
            
            string val_9 = Localization.Localize(key:  1217569296, defaultValue:  1217569200, useSingularKey:  false);
            if(this.buttonLabel != 0)
            {
                goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
            }
            
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
            label_20:
            GameBehavior val_10 = App.getBehavior;
            string val_11 = System.String.Format(format:  -2101083200, arg0:  13152256);
            label_2:
            var val_12 = FP - 16;
        }
        public override void OnButtonClick()
        {
            if(true == 2)
            {
                    if(this.CanProceedToGame() == false)
            {
                goto label_2;
            }
            
            }
            
            this.OnButtonClick();
            return;
            label_2:
            GameBehavior val_2 = App.getBehavior;
            if(0 == 0)
            {
                
            }
        
        }
        private bool CanProceedToGame()
        {
            BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
            bool val_2 = this.RefreshPlayerLives();
            BestBlocksPlayer val_3 = BestBlocksPlayer.Instance;
            if((val_2 + 284) > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public BBLGotoSceneButton()
        {
        
        }
    
    }

}
