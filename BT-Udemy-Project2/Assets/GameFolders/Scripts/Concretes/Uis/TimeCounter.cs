using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace UdemyProject2.Uis
{
    public class TimeCounter : MonoBehaviour
    {
        TMP_Text _text;
        float _currentTime;

        void Awake()
        {
            _text = GetComponent<TMP_Text>();
        }
        void Update()
        {
            _currentTime += Time.deltaTime;
            _text.text = _currentTime.ToString("0");
        }
    }
}