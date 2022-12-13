using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int health = 1;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    //PUBLIC para acceder a este metodo
    public void TakeDamage() {
        health--;
    }
}
