using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyProject2.Managers;
using System;

namespace UdemyProject2.Uis
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] GameOverPanel _gameOverPanel;

        private void Awake()
        {
            _gameOverPanel.gameObject.SetActive(false);
        }
        void OnEnable()
        {
            GameManager.Instance.OnGameStop += HandleOnGameStop;
        }
        void OnDisable()
        {
            GameManager.Instance.OnGameStop -= HandleOnGameStop;
        }
        private void HandleOnGameStop()
        {
            _gameOverPanel.gameObject.SetActive(true);
        }
    }
}