using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public float speed = 5f; // Tốc độ di chuyển của đám mây

    void Update()
    {
        // Di chuyển đám mây theo hướng x với tốc độ đã định
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        // Nếu đám mây đi ra khỏi màn hình, đặt lại vị trí để nó quay lại từ bên trái
        if (transform.position.x > 20f)
        {
            transform.position = new Vector3(-20f, transform.position.y, transform.position.z);
        }
    }
}
