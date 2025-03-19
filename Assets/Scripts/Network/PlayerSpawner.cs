using UnityEngine;
using Photon.Pun;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private float spawnHeight = 0.5f;
    
    // [SerializeField] private Mesh floor;
    void Start()
    {
        SpawnPlayer();
    }

    private void SpawnPlayer()
    {
        Vector3 spawnPoint = transform.position;
        spawnPoint.y = spawnHeight;
        PhotonNetwork.Instantiate("Player", spawnPoint, Quaternion.identity, 0);
    }
    
    // Vector3 GetRandomPointOnMesh(Mesh mesh)
    // {
    //     // Get the vertices and triangles from the mesh
    //     Vector3[] vertices = mesh.vertices;
    //     int[] triangles = mesh.triangles;
    //
    //     // Pick a random triangle by selecting three random indices from the triangles array
    //     int triangleIndex = Random.Range(0, triangles.Length / 3) * 3;
    //
    //     // Get the three vertices that form the triangle
    //     Vector3 vertex1 = vertices[triangles[triangleIndex]];
    //     Vector3 vertex2 = vertices[triangles[triangleIndex + 1]];
    //     Vector3 vertex3 = vertices[triangles[triangleIndex + 2]];
    //
    //     // Use barycentric coordinates to pick a random point within the triangle
    //     float r1 = Random.value;
    //     float r2 = Random.value;
    //
    //     // Ensure the point is inside the triangle
    //     if (r1 + r2 > 1)
    //     {
    //         r1 = 1 - r1;
    //         r2 = 1 - r2;
    //     }
    //
    //     // Calculate the random point inside the triangle using barycentric interpolation
    //     Vector3 randomPoint = vertex1 * (1 - r1 - r2) + vertex2 * r1 + vertex3 * r2;
    //
    //     // Return the random point on the plane mesh
    //     return randomPoint;
    // }
}
