using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnGameOver : MonoBehaviour
{
    void Update()
    {
        if (LevelController.Instance.GetGameOverStatus())
        {
            Destroy(gameObject);
        }
    }
}
