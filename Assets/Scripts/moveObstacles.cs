using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObstacles : MonoBehaviour
{
    void Update()
    {
        if (!LevelController.Instance.GetGameOverStatus() && LevelController.Instance.GetGameStartedStatus())
        {
            transform.position += Vector3.left * 4 * Time.deltaTime;
        }
        
        
    }
}
