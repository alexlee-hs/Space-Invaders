using System;
using Assets.Code.Structure;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code
{
    public class Invaders : MonoBehaviour
    {
        private Transform _tf;
        public float _speed;
        public float _minPos;
        public float _maxPos;
        public float fireRate;

        internal void Start () {
            _tf = GetComponent<Transform>();
            InvokeRepeating ("Move", 0f, 0.2f);
        }

        private void Move()
        {
            _tf.position += Vector3.right * _speed;

            foreach (Transform invader in _tf) {
                if (invader.position.x < _minPos || invader.position.x > _maxPos) {
                    _speed = -_speed * 1.1f;
                    _tf.position += Vector3.down;
                    return;
                }

                if (UnityEngine.Random.value < fireRate) {
				    (invader.gameObject.GetComponent<Gun>()).Fire(-1);
			    }

                if (invader.position.y <= -4) {
                    EndMessage.gameover = true;
                    Time.timeScale = 0;
                }
            }

            if (_tf.childCount == 0) {
                WinMessage.gameover = true;
            }
        }

    }
}
