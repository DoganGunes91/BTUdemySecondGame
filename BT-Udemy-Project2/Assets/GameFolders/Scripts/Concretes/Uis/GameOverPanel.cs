using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UdemyProject2.Managers;

namespace UdemyProject2.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButton()
        {
            GameManager.Instance.LoadScene("Game");
        }
        public void NoButton()
        {
            GameManager.Instance.LoadScene("Menu");
        }
    }
}