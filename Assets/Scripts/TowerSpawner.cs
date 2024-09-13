using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    public GameObject Torentje;
    public Vector3 minSpawnPosition = new Vector3(-10f, 0f, -10f);
    public Vector3 maxSpawnPosition = new Vector3(10f, 0f, 10f);
    void PlaatsToren()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(minSpawnPosition.x, maxSpawnPosition.x),
            Random.Range(minSpawnPosition.y, maxSpawnPosition.y),
            Random.Range(minSpawnPosition.z, maxSpawnPosition.z)
        );
        Instantiate(Torentje, randomPosition, Quaternion.identity);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlaatsToren();
        }
    }
}
