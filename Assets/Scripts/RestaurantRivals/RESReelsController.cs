using UnityEngine;

namespace RestaurantRivals
{
    public class RESReelsController : ARESUIController
    {
        // Fields
        private Scroller[] reels;
        public UnityEngine.Transform reelsRoot;
        public static RestaurantRivals.RESReelsController.ReelsStatus spinStatus;
        private System.Collections.Generic.Queue<RestaurantRivals.RESSymbolItemData> RESSymbolItemDataArray;
        private string[,] ReelData;
        private string[,] previousReelData;
        
        // Methods
        protected override void Awake()
        {
            var val_1;
            this.Awake();
            val_1 = null;
            val_1 = null;
            RestaurantRivals.RESReelsController.spinStatus = 1;
        }
        private void Start()
        {
            var val_6;
            var val_7;
            this.GetRealData();
            this.SetPreviousReelData();
            var val_6 = 0;
            do
            {
                this.reels[val_6].Init();
                val_6 = val_6 + 1;
            }
            while(val_6 != 3);
            
            this.Invoke(methodName:  617474928, time:  null);
            GameBehavior val_1 = App.getBehavior;
            val_6 = 1152921504951095296;
            if(0 != 0)
            {
                    val_7 = null;
            }
            
            val_7 = null;
            if((((mem[1179403747] + (RESMetaGameBehavior.__il2cppRuntimeField_typeHierarchyDepth) << 2) - 4)) == val_7)
            {
                    8 = 0 + 8;
            }
            
            if(8 != 0)
            {
                    return;
            }
            
            val_6 = 0;
            UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            this.reelsRoot.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.reelsRoot, endValue:  null, duration:  null, snapping:  false);
            object val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.reelsRoot, ease:  30);
        }
        private void GetRealData()
        {
            var val_2;
            var val_3 = 0;
            do
            {
                var val_2 = 0;
                do
            {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_2 = mem[public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_30 + 8];
                val_2 = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_30 + 8;
                if(val_2 <= val_3)
            {
                    val_2 = mem[public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_30 + 8];
                val_2 = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_30 + 8;
            }
            
                val_2 = val_2 + 1;
                this.ReelData[(public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_30 + (public static RestaurantRivals.RESManager MonoSingleton<RestaurantRival] = (public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_30 + (public static RestaurantRivals.RESManager MonoSingleton<RestaurantRival + 16;
            }
            while(val_2 != 5);
            
                val_3 = val_3 + 1;
            }
            while(val_3 != 3);
        
        }
        private void InitReelSymbols()
        {
            var val_6 = 0;
            do
            {
                var val_4 = 0;
                do
            {
                RestaurantRivals.RESSymbolItemData val_2 = this.GetRESSymbolItemDataObject(symbol:  this.ReelData[new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()]);
                Add(item:  617939104);
                val_4 = val_4 + 1;
            }
            while(val_4 != 5);
            
                this.reels[val_6].InitScrollerIteam<System.Object>(data:  80883712);
                val_6 = val_6 + 1;
            }
            while(val_6 != 3);
        
        }
        protected override void OnSpinStarted()
        {
            null = null;
            RestaurantRivals.RESReelsController.spinStatus = 2;
            this.SetPreviousReelData();
            this.GetRealData();
            System.Collections.IEnumerator val_1 = this.ActualSpinStart();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  618133024);
        }
        protected override void OnSpinEnded()
        {
            null = null;
            RestaurantRivals.RESReelsController.spinStatus = 1;
        }
        protected override void OnReelStopped(Notification notif)
        {
            null = null;
            RestaurantRivals.RESReelsController.spinStatus = 3;
        }
        protected override void OnAllReelsStopped()
        {
            null = null;
            RestaurantRivals.RESReelsController.spinStatus = 4;
        }
        private void SetPreviousReelData()
        {
            var val_3 = 0;
            do
            {
                var val_2 = 0;
                do
            {
                val_2 = val_2 + 1;
                this.previousReelData[this.ReelData[this]] = this.ReelData[this];
            }
            while(val_2 != 5);
            
                val_3 = val_3 + 1;
            }
            while(val_3 != 3);
        
        }
        private System.Collections.IEnumerator ActualSpinStart()
        {
            object val_1 = new System.Object();
            typeof(RESReelsController.<ActualSpinStart>d__16).__il2cppRuntimeField_8 = 0;
            typeof(RESReelsController.<ActualSpinStart>d__16).__il2cppRuntimeField_10 = this;
        }
        private RestaurantRivals.RESSymbolItemData GetRESSymbolItemDataObject(string symbol)
        {
            var val_3;
            if(true >= 1)
            {
                    RestaurantRivals.RESSymbolItemData val_1 = this.RESSymbolItemDataArray.Dequeue();
                val_3 = this.RESSymbolItemDataArray;
            }
            else
            {
                    RestaurantRivals.RESSymbolItemData val_2 = null;
                val_3 = val_2;
                val_2 = new RestaurantRivals.RESSymbolItemData();
            }
            
            typeof(RestaurantRivals.RESSymbolItemData).__il2cppRuntimeField_8 = symbol;
        }
        public void RecycleRESSymbolItemData(RestaurantRivals.RESSymbolItemData itemData)
        {
            this.RESSymbolItemDataArray.Enqueue(item:  itemData);
        }
        public RESReelsController()
        {
            System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> val_1 = new System.Collections.Generic.Queue<twelvegigs.net.JsonRequest>();
            this.RESSymbolItemDataArray = null;
            this.ReelData = null;
            this.previousReelData = null;
        }
        private static RESReelsController()
        {
        
        }
    
    }

}
