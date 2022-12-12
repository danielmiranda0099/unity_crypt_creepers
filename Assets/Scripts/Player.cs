using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    float h;
    float v;
    
    Vector3 moveDirection;

    Vector2 facingDirection;

    [SerializeField] Transform aim;
    [SerializeField] Camera camera;

    //Bullet
    [SerializeField] Transform bulletPrefab;
    float angle;
    Quaternion targetRotation;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        
        moveDirection.x = h;
        moveDirection.y = v;

        transform.position += moveDirection * Time.deltaTime * speed;

        //Movimiento de la mira
        facingDirection = camera.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        aim.position = (Vector3)facingDirection.normalized + transform.position;

        //Disparo
        if(Input.GetMouseButton(0)){
            angle = Mathf.Atan2(facingDirection.y, facingDirection.x) * Mathf.Rad2Deg;//se multiplica por rad2deg paar retornar en grados
            targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
            Instantiate(bulletPrefab, transform.position, targetRotation);
        }
    }
}
