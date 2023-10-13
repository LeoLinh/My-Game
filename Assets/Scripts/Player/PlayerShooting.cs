using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab của viên đạn
    public Transform firePoint; // Điểm nổ súng
    //public float bulletSpeed = 10f; // Tốc độ của viên đạn

    void Update()
    {
        // Kiểm tra nếu người chơi nhấn nút bắn (ví dụ: Space)
        if (Input.GetMouseButtonDown(0))
        {
            Shoot(); // Gọi hàm bắn đạn
        }
    }

    void Shoot()
    {
        // Tạo một viên đạn từ prefab
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Lấy Component Rigidbody2D của viên đạn
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        // Đặt tốc độ di chuyển cho viên đạn
        //rb.velocity = firePoint.up * bulletSpeed;
    }
}
