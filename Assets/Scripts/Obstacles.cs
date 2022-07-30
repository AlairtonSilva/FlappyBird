using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    
    public float height;
    public float maxTime;
    private float timer=0f;
    public GameObject pipe;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject newPipe=Instantiate(pipe);
        //znewPipe.transform.position=transform.position+ new Vector3(0, Random.Range(-height,height),0);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(timer > maxTime && !LevelController.Instance.GetGameOverStatus() && LevelController.Instance.GetGameStartedStatus()){
            GameObject newPipe=Instantiate(pipe);
            newPipe.transform.position=transform.position+ new Vector3(0, Random.Range(-height,height),0);
            Destroy(newPipe,10);
            timer=0;
        }
       
        timer+=Time.deltaTime;
    }
}
