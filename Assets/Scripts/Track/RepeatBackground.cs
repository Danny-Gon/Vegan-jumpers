using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private float startPos;
    private float repeatWidth;

    void Start()
    {
        startPos = transform.position.x;
        repeatWidth = GetComponent<BoxCollider>().size.x;
    }

    void Update()
    {
        if (transform.position.x < startPos - repeatWidth)
        {
            transform.position = new Vector3(startPos, transform.position.y, transform.position.z);
        }
    }
}
