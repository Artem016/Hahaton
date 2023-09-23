using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed = 2f; // �������� ����
    public static int direction = 1;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // ������ ��������� �������� ����
        rb.velocity = direction * transform.right * bulletSpeed;
    }
}
