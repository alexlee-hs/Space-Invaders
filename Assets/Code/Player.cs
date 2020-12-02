using System;
using Assets.Code.Structure;
using UnityEngine;

namespace Assets.Code
{
    public class Player : MonoBehaviour
    {
        private Transform _tf;
        private Gun _gun;
        public float _speed;
        public float _minPos;
        public float _maxPos;

        internal void Start () {
            _tf = GetComponent<Transform>();
            _gun = GetComponent<Gun>();
        }

        internal void FixedUpdate () {
            Move(Input.GetAxis("Horizontal"));
        }

        private void Move (float direction) {
            if ((_tf.position.x <= _minPos && direction < -0.02f) 
            || (_tf.position.x >= _maxPos && direction > 0.02f)) { return; }
            _tf.position += Vector3.right*direction*_speed;
        }

        internal void Update () {
            if(Input.GetButton("Fire1")){
                _gun.Fire(1);
            }
        }

    }
}
