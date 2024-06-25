using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSroll : MonoBehaviour
{
    [SerializeField] Vector2 bienDoA;
    [SerializeField] float w;

    private void FixedUpdate()
    {
        // Tính toán vị trí mới dựa trên hàm sin với tần số w và biên độ bienDoA
        float offsetX = bienDoA.x * Mathf.Sin(Time.time * w);
        float offsetY = bienDoA.y * Mathf.Sin(Time.time * w);

        // Cập nhật vị trí của đối tượng
        transform.position = new Vector3(offsetX, offsetY, transform.position.z);
    }
}
