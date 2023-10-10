using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue_Bullet_1 : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 10;
    public Rigidbody2D  rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;   
    }
    private void OnTriggerEnter2D(Collider2D Hit)
    {
        
        Yellow_Ball yellowBall = Hit.GetComponent<Yellow_Ball>();
        if (yellowBall != null)
        {
            yellowBall.TakenDamage(damage);           
        }
        Destroy(gameObject);       
    }

}
