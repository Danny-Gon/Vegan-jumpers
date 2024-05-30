using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionTrigger : MonoBehaviour
{
    public List<GameObject> roadSection;
    
    private float zPos = 424f;
    public int secNum;  
  
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            
            secNum = Random.Range(0,5);
            Instantiate(roadSection[secNum], new Vector3(0f,0f,zPos), Quaternion.identity);
        }
    }

    
}
