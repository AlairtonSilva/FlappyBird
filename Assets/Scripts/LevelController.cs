using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    private bool m_GameOver = false;
    private bool m_GameStarted = false;
    [SerializeField]
    private GameObject m_GameOverScreen;
    public static LevelController Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
    }

    private void Update()
    {
        if (m_GameStarted)
        {
            m_GameOverScreen.SetActive(false);
        }

        if (m_GameOver)
        {
            m_GameOverScreen.SetActive(true);
        }
    }

    public void SetGameOverStatus(bool status)
    {
        if (status)
        {
            StartCoroutine(CallGameOver());
        }
        else
        {
            m_GameOver = status;
        }   
    }

    public void SetGameStartedStatus(bool status)
    {
        m_GameStarted = status;
    }

    public bool GetGameOverStatus()
    {
        return m_GameOver;
    }

    public bool GetGameStartedStatus()
    {
        return m_GameStarted;
    }

    private IEnumerator CallGameOver()
    {
        PointController.Instance.ResetPointController();
        yield return new WaitForSeconds(0f);
        m_GameOver = true;
    }
}
