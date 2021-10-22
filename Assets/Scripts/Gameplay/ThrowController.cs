using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowController : MonoBehaviour
{
    public GameObject stone;
    [SerializeField] private float launchForce;
    public Transform shotPoint;

    [SerializeField] private GameObject point;
    GameObject[] points;
    [SerializeField] private int numberOfPoints;
    [SerializeField] private float spaceBetweenpoints;
    Vector2 direction;

    private void Start()
    {
        points = new GameObject[numberOfPoints];
        for(int i = 0; i < numberOfPoints; i++)
        {
            points[i] = Instantiate(point, shotPoint.position, Quaternion.identity);
        }
    }

    void Update()
    {
        Vector2 armPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - armPosition;
        transform.right = direction;

        if (Input.GetMouseButtonDown(0))
        {
            Throw();
        }

        for (int i = 0; i < numberOfPoints; i++)
        {
            points[i].transform.position = pointPosition(i * spaceBetweenpoints);
        }
    }

    void Throw()
    {
        GameObject newStone = Instantiate(stone, shotPoint.position, shotPoint.rotation);
        newStone.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;
    }

    Vector2 pointPosition(float t)
    {
        Vector2 position = (Vector2)shotPoint.position + (direction.normalized * launchForce * t) + 0.5f * Physics2D.gravity * (t * t);
        return position;
    }
}
