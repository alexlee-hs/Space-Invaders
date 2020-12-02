using System;
using Assets.Code.Structure;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code
{
    public class ScoreManager : MonoBehaviour
    {
        public static int CurrentScore;
        private static Text _scoreText;
        public static AudioClip CoinClip;
        public AudioClip clip;
        private static AudioSource _audioSource;

        // ReSharper disable once UnusedMember.Global
        internal void Start () {
            _scoreText = GetComponent<Text>();
            _audioSource = GetComponent<AudioSource>();
            CurrentScore = 0;
            CoinClip = clip;
            UpdateScore();
        }

        public static void ResetScore () {
            CurrentScore = 0;
        }

        public static void IncScore () {
            CurrentScore = CurrentScore + 1;
            _audioSource.PlayOneShot(CoinClip);
            UpdateScore();
        }

        private static void UpdateScore () {
            _scoreText.text = string.Format("Score: {0}", CurrentScore).PadLeft(4, '0');
        }
    }
}
