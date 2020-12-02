using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code{
    public class Base : MonoBehaviour
    {
        private Transform _base;

        void Start()
        {
            _base = GetComponent<Transform>();
        }

        // Update is called once per frame
        void Update()
        {
            if(_base.childCount == 0){
                EndMessage.gameover = true;
            }
        }
    }
}