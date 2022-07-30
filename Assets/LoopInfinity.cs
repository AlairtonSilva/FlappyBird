using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopInfinity : MonoBehaviour
{
    [Range(0.0f, 1.0f)]
    public float textureSpeed;

    private Renderer m_Renderer;

    private void Awake()
    {
        m_Renderer = GetComponent<Renderer>();
    }
    void Update(){

        if (!LevelController.Instance.GetGameOverStatus() && LevelController.Instance.GetGameStartedStatus())
        {
            m_Renderer.material.SetTextureOffset("_MainTex", GetComponent<Renderer>().material.GetTextureOffset("_MainTex") + new Vector2(textureSpeed, 0) * Time.deltaTime);
        }
        
       
    }
}
