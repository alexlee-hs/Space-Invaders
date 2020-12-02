using UnityEngine;

namespace Assets.Code.Structure
{
    public class InvaderBullet : MonoBehaviour
    {
        public float _speed;
        private Transform _tf;
        

        internal void Start() {
            _tf = GetComponent<Transform>();
        }

        internal void FixedUpdate(){
            _tf.position += Vector3.up*_speed*(-1);
            if(_tf.position.y > 20){
                Die();
            }
        }

        void OnTriggerEnter2D(Collider2D other){
            if(other.tag == "Player"){
                EndMessage.gameover = true;
                Die();
            } else if(other.tag == "Base"){
                Destroy (other.gameObject);
                Die();
            }
        }

        private void Die () {
            Destroy(gameObject);
        }
    }
}
