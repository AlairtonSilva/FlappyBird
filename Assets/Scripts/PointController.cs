using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointController : MonoBehaviour
{
    [SerializeField]
    private TMP_Text m_Text;
    
    private int m_CurrentPoint;

    public static PointController Instance { get; private set; }
    
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void AddPoint()
    {
        m_CurrentPoint++;
        m_Text.text = m_CurrentPoint.ToString();
    }

}
