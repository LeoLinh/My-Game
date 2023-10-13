using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBall : MonoBehaviour
{
    public GameObject ballPrefab; // Prefab của quả bóng
    public int health = 3; // Số máu của quả bóng
    public float fallSpeed = 5.0f; // Tốc độ rơi của quả bóng, có thể chỉnh sửa trong Inspector
    public float spawnInterval = 2.0f; // Thời gian giữa việc xuất hiện các quả bóng, có thể chỉnh sửa trong Inspector
    public Vector2 spawnRangeX = new Vector2(-2, 2); // Khoảng vị trí ngẫu nhiên theo trục X
    public float spawnY = 5.0f; // Vị trí Y ban đầu

    void Start()
    {
        // Bắt đầu Coroutine để xuất hiện quả bóng
        StartCoroutine(SpawnRandomPosition());
    }

    IEnumerator SpawnRandomPosition()
    {
        while (true)
        {
            float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
            Vector3 spawnPosition = new Vector3(randomX, spawnY, 0);

            GameObject newBall = Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
            YellowBall newYellowBall = newBall.GetComponent<YellowBall>();

            // Thiết lập các thuộc tính cho quả bóng mới
            newYellowBall.health = health;

            yield return new WaitForSeconds(spawnInterval); // Tạo ra quả bóng mới sau khoảng thời gian spawnInterval
        }
    }

    void Update()
    {
        // Di chuyển quả bóng xuống dưới
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
    }

    // Xử lý va chạm với collider
    void OnTriggerEnter2D(Collider2D other)
    {
        // Kiểm tra nếu va chạm với collider dưới màn hình
        if (other.CompareTag("DestroyBall"))
        {
            Destroy(gameObject); // Huỷ quả bóng
        }
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {
            Destroy(gameObject); // Huỷ quả bóng nếu hết máu
        }
    }
}