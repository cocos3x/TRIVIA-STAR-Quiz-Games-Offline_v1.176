using UnityEngine;

namespace SLC.Minigames.TwistyArrow
{
    public class FlyingArrow : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image arrowimage;
        private UnityEngine.Sprite normalSprite;
        private UnityEngine.Sprite brokenSprite;
        private UnityEngine.Collider2D normalColl;
        private UnityEngine.Collider2D brokenColl;
        private float speed;
        private UnityEngine.Rigidbody2D rb;
        private bool hit;
        
        // Methods
        private void Awake()
        {
            object val_1 = this.GetComponent<System.Object>();
            this.rb = this;
            object val_2 = this.GetComponent<System.Object>();
            this.arrowimage = this;
            this.rb.bodyType = 0;
            this.rb.collisionDetectionMode = 1;
            this.rb.gravityScale = null;
            this.arrowimage.sprite = this.normalSprite;
            this.normalColl.enabled = true;
            this.brokenColl.enabled = false;
            this.hit = false;
        }
        private void OnCollisionEnter2D(UnityEngine.Collision2D col)
        {
            if(this.hit == true)
            {
                    return;
            }
            
            UnityEngine.GameObject val_1 = col.gameObject;
            string val_2 = col.tag;
            if((System.String.op_Equality(a:  col, b:  1010075984)) == false)
            {
                    return;
            }
            
            this.hit = true;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.down;
            this.rb.AddForce(force:  new UnityEngine.Vector2());
            this.rb.gravityScale = val_4.x;
            35638092 = this.brokenSprite;
            this.arrowimage.sprite = 35638092;
            this.normalColl.enabled = false;
            this.brokenColl.enabled = true;
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandleHitArrow();
        }
        public void SetSpeed(float _speed)
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  _speed, y:  null);
            this.rb.velocity = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        public void ClearRigidBody()
        {
            UnityEngine.Object.Destroy(obj:  this.rb);
            this.rb = 0;
        }
        public void SetNormalColliderActive(bool state)
        {
            if(this.brokenColl.enabled != false)
            {
                    return;
            }
            
            this.normalColl.enabled = state;
        }
        public FlyingArrow()
        {
            this.speed = 1f;
        }
    
    }

}
