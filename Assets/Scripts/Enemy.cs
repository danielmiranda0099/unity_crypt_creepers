using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int health = 1;
    [SerializeField] int speed = 1;

    Vector2 direction;

    Transform player;

    void Start()
    {
        player = FindObjectOfType<Player>().transform; //Busqueda dinamica (los enemigos se ban a crear 
                                                    //dinamicamente en tiempo de ejecucuion por eso buiscan al player de este modo)
    }

    
    void Update()
    {
        direction = player.position - transform.position;//Obtener vector de direccion del jugador
        transform.position += (Vector3)direction * Time.deltaTime * speed;
    }

    public void TakeDamage() {
        health--;
    }
}
