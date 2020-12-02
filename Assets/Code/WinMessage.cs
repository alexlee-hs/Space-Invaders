using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Assets.Code
{
    public class WinMessage : MonoBehaviour {

        public static bool gameover = false;
        private Text message;

        internal void Start () {
            message = GetComponent<Text>();
            message.enabled = false;
        }

        internal void Update(){
            if (gameover && !message.enabled){
                Time.timeScale = 0;
                message.enabled = true;
            }
        }

    }
}