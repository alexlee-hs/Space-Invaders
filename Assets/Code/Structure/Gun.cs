using UnityEngine;

namespace Assets.Code.Structure
{
    /// <inheritdoc />
    /// <summary>
    /// Fires bullets. Don't ask questions, kid.
    /// </summary>
    public class Gun : MonoBehaviour
    {
        public float cooldown;
        public GameObject Blt;
        public Transform shooter;
        private float _lastfire;
        public AudioClip MissileClip;
        private AudioSource _audioSource;

        internal void Start(){
             _audioSource = GetComponent<AudioSource>();
        }

        public void Fire (int direction) {
            float time = Time.time;
            if (time < _lastfire + cooldown) { return; }
            _lastfire = time;
            _audioSource.PlayOneShot(MissileClip);
            GameObject blt = Instantiate(Blt,shooter.position + Vector3.up*direction, shooter.rotation);
            blt.transform.parent = (GameObject.Find("BulletManager")).transform;
        }
    }
}
