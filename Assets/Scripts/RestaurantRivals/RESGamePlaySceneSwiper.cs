using UnityEngine;

namespace RestaurantRivals
{
    public class RESGamePlaySceneSwiper : MonoSingleton<RestaurantRivals.RESGamePlaySceneSwiper>, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
    {
        // Fields
        protected static bool InTransition;
        private SceneType currentScene;
        private SceneType gotoScene;
        private UnityEngine.GameObject movingObject;
        private int sceneMoveMultiplyer;
        private UnityEngine.Vector2 touchDownPos;
        private UnityEngine.Vector2 moveDir;
        
        // Methods
        public override void InitMonoSingleton()
        {
            UnityEngine.Vector2 val_6;
            var val_7;
            var val_18;
            var val_20;
            DG.Tweening.TweenCallback val_21;
            var val_22;
            val_18 = 1152921504892043264;
            GameBehavior val_1 = App.getBehavior;
            if(0 != 0)
            {
                    val_20 = null;
            }
            
            val_20 = null;
            if(0 != 5)
            {
                    GameBehavior val_2 = App.getBehavior;
                val_21 = 0;
                if(0 != 0)
            {
                    val_22 = null;
            }
            
                val_22 = null;
                if((((mem[1179403747] + (RESMetaGameBehavior.__il2cppRuntimeField_typeHierarchyDepth) << 2) - 4)) == val_22)
            {
                    8 = 0 + 8;
            }
            
                if(8 != 2)
            {
                    return;
            }
            
            }
            
            if(this.currentScene == 2)
            {
                    UnityEngine.Vector2 val_4 = UnityEngine.Vector2.up;
            }
            else
            {
                    UnityEngine.Vector2 val_5 = UnityEngine.Vector2.down;
            }
            
            this.moveDir = val_6;
            mem[1152921513755863096] = val_7;
            UnityEngine.Transform val_8 = this.movingObject.transform;
            object val_9 = this.movingObject.GetComponent<System.Object>();
            val_18 = this.movingObject;
            UnityEngine.Rect val_10 = rect;
            float val_11 = height;
            float val_17 = (float)this.sceneMoveMultiplyer;
            val_17 = 559069440 * val_17;
            UnityEngine.Vector3 val_12 = new UnityEngine.Vector3(x:  val_17, y:  val_10.m_YMin, z:  559069440);
            this.movingObject.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            UnityEngine.Transform val_13 = this.movingObject.transform;
            DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.movingObject, endValue:  val_17, duration:  val_10.m_YMin, snapping:  false);
            val_21 = null;
            val_21 = new DG.Tweening.TweenCallback(object:  559081488, method:  new IntPtr(559056464));
            object val_16 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.movingObject, action:  190734336);
        }
        public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = 35636758;
            if(RestaurantRivals.RESManager.IsGameStartFtuxFinished == false)
            {
                    return;
            }
            
            val_3 = 1152921505031233536;
            val_4 = null;
            val_4 = null;
            if(RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType == 17)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            if(RestaurantRivals.RESGamePlaySceneSwiper.InTransition == true)
            {
                    return;
            }
            
            mem2[0] = R5 + 176;
            mem2[0] = R5 + 180;
        }
        public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            float val_3;
            float val_4;
            var val_9;
            var val_10;
            var val_11;
            UnityEngine.Vector2 val_12;
            var val_13;
            val_9 = 35636759;
            if(RestaurantRivals.RESManager.IsGameStartFtuxFinished == false)
            {
                    return;
            }
            
            val_9 = 1152921505031233536;
            val_10 = null;
            val_10 = null;
            if(RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType == 17)
            {
                    return;
            }
            
            val_9 = 1152921505032085504;
            val_11 = null;
            val_11 = null;
            if(RestaurantRivals.RESGamePlaySceneSwiper.InTransition == true)
            {
                    return;
            }
            
            val_9 = this;
            val_12 = this.touchDownPos;
            val_13 = 0;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 7.27019E-19f, y = eventData.<position>k__BackingField}, b:  new UnityEngine.Vector2() {x = SL, y = val_12});
            float val_5 = UnityEngine.Vector2.Angle(from:  new UnityEngine.Vector2() {x = val_3, y = val_4}, to:  new UnityEngine.Vector2() {x = this.moveDir, y = val_12});
            float val_9 = System.Math.Abs(val_3);
            float val_6 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = eventData.<position>k__BackingField, y = SL}, b:  new UnityEngine.Vector2() {x = val_12, y = R8});
            System.Collections.IEnumerator val_7 = this.MoveAndLoadScene(callback:  0);
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  559334160);
        }
        public System.Collections.IEnumerator MoveAndLoadScene(System.Action callback)
        {
            typeof(RESGamePlaySceneSwiper.<MoveAndLoadScene>d__10).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(RESGamePlaySceneSwiper.<MoveAndLoadScene>d__10).__il2cppRuntimeField_10 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            typeof(RESGamePlaySceneSwiper.<MoveAndLoadScene>d__10).__il2cppRuntimeField_14 = callback;
        }
        public RESGamePlaySceneSwiper()
        {
            UnityEngine.Vector2 val_2;
            var val_3;
            this.currentScene = 5;
            this.gotoScene = 2;
            this.sceneMoveMultiplyer = 1;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.touchDownPos = val_2;
            mem[1152921513756353072] = val_3;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.up;
            this.moveDir = new UnityEngine.Vector2();
            mem[1152921513756353080] = ???;
        }
        private static RESGamePlaySceneSwiper()
        {
        
        }
        private void <InitMonoSingleton>b__7_0()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  559795584, aName:  559771472);
        }
        private void <MoveAndLoadScene>b__10_0()
        {
            var val_2;
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  559907696, aName:  559883584);
            val_2 = null;
            val_2 = null;
            RestaurantRivals.RESGamePlaySceneSwiper.InTransition = false;
        }
    
    }

}
