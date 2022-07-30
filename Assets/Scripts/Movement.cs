using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _vel ;
    [SerializeField] private Rigidbody2D _rb;

    [SerializeField] private float bicoUp;
    [SerializeField] private float bicoDown;

    [SerializeField] private float velocidadeAtual;

    private Vector3 m_StartPosition;
    

    private void Start(){
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update(){
        

        if (!LevelController.Instance.GetGameOverStatus() && LevelController.Instance.GetGameStartedStatus())
        {
            _rb.simulated = true;
            velocidadeAtual = _rb.velocity.y;

            Quaternion rotation = Quaternion.Euler(0, 0, Mathf.Lerp(bicoDown, bicoUp, velocidadeAtual));

            gameObject.transform.rotation = rotation;

            if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump"))
            {
                _rb.velocity = Vector2.up * _vel;
            }
        }
        else {
            
            if (LevelController.Instance.GetGameOverStatus())
            {
                transform.position = m_StartPosition;
                transform.rotation = new Quaternion(0,0,0,0);
                _rb.simulated = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("Call GameOverScreenn");
        }
        LevelController.Instance.SetGameOverStatus(true);
    }
}
