using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviourScript : MonoBehaviour
{
    //Iniciar Variaveis
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletRotation;
    [SerializeField] private float waitTimeToShoot;
    private float countTimeToShoot;
        

    // Start is called before the first frame update
    void Start()
    {
        countTimeToShoot = 0;
    }
    void Update()
    {
        countTimeToShoot += Time.deltaTime;
        Debug.Log(countTimeToShoot);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(countTimeToShoot > waitTimeToShoot) 
            {
                Shoot();
            }
            
        }
    }

    private void Shoot()
    {
        Instantiate(bullet, transform.position, bulletRotation.rotation);
        countTimeToShoot = 0;
    }

}
