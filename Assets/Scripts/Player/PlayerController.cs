using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isOnGround = true;
    //private float speed = 30; -- Sobra, hace parte del movimiendo


    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        
    }

   
    void Update()
    {
        //transform.Translate(Vector3.left * Time.deltaTime * speed); -- Sobra es la del mov de frente

        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }    
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
