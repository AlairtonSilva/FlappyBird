using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObstacles : MonoBehaviour
{
    // Start is called before the first frame update
    private bool m_CanMove;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!LevelController.Instance.GetGameOverStatus())
        {
            transform.position += Vector3.left * 4 * Time.deltaTime;
        }
        
        
    }

   
}
