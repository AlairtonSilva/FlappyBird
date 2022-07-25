using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _vel ;
    [SerializeField] private Rigidbody2D _rb;

    private void Start(){
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update(){
        if(Input.GetMouseButtonDown(0)){
            _rb.velocity = Vector2.up * _vel;
        }
    }
}
