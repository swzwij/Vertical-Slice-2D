using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeBall : MonoBehaviour
{
    public GameObject ball;

    public Transform target;

    public float speed;

    private bool shouldMove;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SpawnBall();
        }

        float step = speed * Time.deltaTime;

        transform.Rotate(0, 0, 300 * Time.deltaTime);

        if (shouldMove)
        {
            ball.SetActive(true);
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

    public void SpawnBall()
    {
        shouldMove = true;
    }
}
