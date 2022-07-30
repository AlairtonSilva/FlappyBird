using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverPointShow : MonoBehaviour
{
    [SerializeField]
    private TMP_Text m_Text;
    private void OnEnable()
    {
        m_Text.text = PlayerPrefs.GetInt("Points").ToString();
    }
}
