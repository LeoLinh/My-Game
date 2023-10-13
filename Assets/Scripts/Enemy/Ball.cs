using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject ballPrefab;
    public float speed;
    public float timeDuration;
    private float countdown;

    private void Awake()
    {
        countdown = timeDuration;
    }
    private void Update()
    {
        Move();
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            Instantiate(ballPrefab, new Vector3(Random.Range(-2,2),5,0),Quaternion.identity);
            countdown = timeDuration;
        }
    }
    void Move()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
}
