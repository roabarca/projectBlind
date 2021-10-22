using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float Speed;

    private Rigidbody2D Rigidbody2D;
    private Vector3 Direction;
    public Vector2 Force;

    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Rigidbody2D.AddForce(Force);
    }

    private void FixedUpdate()
    {
    }

    public void SetDirection(Vector3 direction)
    {
        Direction = direction;
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }

    private void OnColissionEnter2D(Collision2D other)
    {
        DestroyBullet();
    }

}