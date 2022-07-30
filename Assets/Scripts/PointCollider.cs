using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PointController.Instance.AddPoint();
    }
}
