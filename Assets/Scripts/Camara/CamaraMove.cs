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
        Vector3 desiredPosition = player.position + offset;

        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, cameraSpeed*Time.deltaTime);

        transform.position = smoothPosition;

        transform.LookAt(player);
    }
}
