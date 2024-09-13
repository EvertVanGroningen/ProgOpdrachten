using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Cube;
    public float timer = 0;

    void Start()
    {

    }

    void Update()
    {
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("cubes");
        timer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < 100; i++)
            {
                Instantiate(Cube);
            }
        }
        if (timer >= 3)
        {
            Instantiate(Cube);
            timer = 0;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {

            foreach (GameObject cube in cubes)
                Destroy(cube);
        }

    }
}
