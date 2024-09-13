using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed;
    void Start()
    {

    }

    void Update()
    {
        transform.position = transform.position += new Vector3(0, 0, speed);
    }
}
