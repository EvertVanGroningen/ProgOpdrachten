using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CreateBall : MonoBehaviour
{
    public GameObject prefab;

    private void Start()
    {
        // Maak in één keer 100 ballen aan in de Start
        for (int i = 0; i < 100; i++)
        {
            Color randColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
            Vector3 randPosition = new Vector3(Random.Range(-10f, 10f), Random.Range(1f, 10f), Random.Range(-10f, 10f));
            GameObject ball = CreateBalls(randColor, randPosition);
            DestroyBall(ball);
        }
    }

    private GameObject CreateBalls(Color c, Vector3 position)
    {

        GameObject ball = Instantiate(prefab, position, Quaternion.identity);
        Material material = ball.GetComponent<MeshRenderer>().material;
        material.SetColor("_Color", c);

        return ball;
    }

    private void DestroyBall(GameObject ball)
    {
        Destroy(ball, 3f);
    }

    private float elapsedTime = 0f;
    void Update()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color randColor = new Color(r, g, b, 1f);
        Vector3 randPosition = new Vector3(Random.Range(-10f, 10f), Random.Range(1f, 10f), Random.Range(-10f, 10f));

        elapsedTime += Time.deltaTime;

        if (elapsedTime > 1f)
        {
            GameObject ball = CreateBalls(randColor, randPosition);
            DestroyBall(ball);

            elapsedTime = 0f;
        }
    }
}
