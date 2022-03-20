using UnityEngine;

namespace BlockPuzzleMagic
{
    public class BBLTrashShapeButton : BBLPowerupShapeButton
    {
        // Fields
        private UnityEngine.RectTransform hitboxDragIn;
        private shake trashIconShake;
        
        // Properties
        public UnityEngine.RectTransform HitboxDragIn { get; }
        
        // Methods
        public UnityEngine.RectTransform get_HitboxDragIn()
        {
        
        }
        public void Shake()
        {
            this.trashIconShake.ShakeNow();
        }
        public void Show()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            this.SetActive(value:  true);
            this.RefreshPriceLabel();
            System.Action val_2 = new System.Action(object:  1223300528, method:  new IntPtr(1220986000));
            MonoExtensions.DelayedCallEndOfFrame(monoBehaviour:  1223300528, callback:  7454720);
        }
        protected override void OnLevelInitialized(BlockPuzzleMagic.Level level)
        {
            this.Show();
        }
        protected override void OnModeEntered()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Interactable = false;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.GameObject val_3 = gameObject;
            UnityEngine.Transform val_4 = transform;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = public static BlockPuzzleMagic.BlockShapeSpawner MonoSingleton<BlockPuzzleMagic.BlockShapeSpawner>::get_Instance();
            UnityEngine.GameObject val_5 = this.gameObject;
            UnityEngine.Transform val_6 = this.transform;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_14 = this;
            BlockPuzzleMagic.BBLGameplayUIHelper.ShowGameplayOverlay(contentToShow:  -2028557104);
        }
        protected override void OnModeExit()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Interactable = true;
            this.OnModeExit();
        }
        public BBLTrashShapeButton()
        {
            mem[1152921514420538337] = 1;
            mem[1152921514420538304] = 1069547520;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
