using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 3f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
    }
}
