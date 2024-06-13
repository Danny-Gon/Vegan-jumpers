using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;

    private float startDelay = 2;
    private float repeatRate = 2;
    
    private Vector3 spawnPos = new Vector3(25, 0, 0);

    //private PlayerController playerControllerScript;

    void Start()
    {
        //playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        //Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation); Esto también mirar si es útil
    }

    void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto con el que colisionó tiene la etiqueta "ObstacleLimit"
        if (collision.gameObject.CompareTag("ObstacleLimit"))
        {
            // Imprime "Colisión" en la consola
            Debug.Log("Colisión");
        }
    }

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

        //Vector3 spawnPos = new Vector3(25, 0, 0);
        //int index = Random.Range(0, obstaclePrefab.Length);


        //Esto se puede dejar por si vamos a finalizar el juego. Por ahora, en espera de código de tiempo
        //if (playerControllerScript.gameOver == false)
        //{
        //    Instantiate(obstaclePrefab[index], spawnPos, obstaclePrefab[index].transform.rotation);
        //}
    }
}
