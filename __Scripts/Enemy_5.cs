using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Enemy_5 : Enemy
{
    [SerializeField]
    private float _speed = 2f;

    void Movement()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
    }

    void Update()
    {
        Movement();
    }
	
}
