using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDirection : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
