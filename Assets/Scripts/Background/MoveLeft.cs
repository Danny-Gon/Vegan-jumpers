using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 25;
    private PlayerController playerController;
    private float leftBound = -15;

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {

        transform.Translate(Vector3.left * Time.deltaTime * speed);

        /*if (playerControllerScript.gameOver == false) --- Esto si vamos a finalizar el juego cuando chcoca con un objeto
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }*/

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
