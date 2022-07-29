using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopInfinity : MonoBehaviour
{
    [Range(0.0f, 1.0f)]
    public float textureSpeed;

    void Update(){
        GetComponent<Renderer>().material.SetTextureOffset("_MainTex",GetComponent<Renderer>().material.GetTextureOffset("_MainTex") + new Vector2(textureSpeed,0)*Time.deltaTime);
    }
}
