using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public CharacterData id;
    private Rigidbody playerRb;
    public float jumpForce = 10;
    public bool isOnGround = true;
    //private float speed = 30; -- Sobra, hace parte del movimiendo


    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.useGravity = true;
        
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
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Imprime "Colisión" en la consola
            Debug.Log("Obstacle");
        }
    }



}
