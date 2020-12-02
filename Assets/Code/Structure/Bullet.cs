using UnityEngine;

namespace Assets.Code.Structure
{
    public class Bullet : MonoBehaviour
    {
        public float _speed;
        private Transform _tf;
        

        internal void Start() {
            _tf = GetComponent<Transform>();
        }

        internal void FixedUpdate(){
            _tf.position += Vector3.up*_speed;
            if(_tf.position.y > 20){
                Die();
            }
        }

        void OnTriggerEnter2D(Collider2D other){
            if(other.tag == "Invader"){
                Destroy (other.gameObject);
                ScoreManager.IncScore();
                Die();
            } else if(other.tag == "Base"){
                Die();
            }
        }

        private void Die () {
            Destroy(gameObject);
        }
    }
}
