using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMove : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float cameraSpeed = 10f;

    void LateUpdate()
    {
        transform.position = player.position + offset;
    }
}
