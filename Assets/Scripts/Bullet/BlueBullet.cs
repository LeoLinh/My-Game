using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBullet : MonoBehaviour
{
    public float bulletSpeed = 10f; // Tốc độ của viên đạn
    public int damage = 1;

    void Update()
    {
        // Di chuyển viên đạn theo hướng đã quy định
        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
    }

    // Xử lý va chạm với trigger collider
    void OnTriggerEnter2D(Collider2D other)
    {
        // Kiểm tra nếu va chạm với collider được đặt sau Camera
        if (other.CompareTag("DestroyZone"))
        {
            DestroyBullet();
        }
        YellowBall yellowBall = other.GetComponent<YellowBall>();
        if (yellowBall != null)
        {
            // Gọi hàm xử lý va chạm trên quả bóng
            yellowBall.TakeDamage(damage);
            DestroyBullet();
        }
    }

    public void DestroyBullet()
    {
        // Huỷ viên đạn khi va chạm với collider
        Destroy(gameObject);
    }
}