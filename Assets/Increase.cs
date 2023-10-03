using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increase : MonoBehaviour
{
    [SerializeField] private float _speed;

    Vector3 temp;

    void Update()
    {
        temp = transform.localScale;

        temp.x += _speed;
        temp.y += _speed;
        temp.z += _speed;

        transform.localScale = temp;
    }
}
