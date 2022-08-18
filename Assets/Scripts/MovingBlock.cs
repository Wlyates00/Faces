using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour
{
    public float speed;
    private Vector2 startPoint;
    public Transform endPoint;
    private Vector2 endPos;
    private bool touched;

    public void Start()
    {
        endPos = endPoint.position;
    }

    private void Update()
    {
        if (touched && startPoint.x < endPos.x)
        {
            startPoint = transform.position;
            transform.position = Vector2.LerpUnclamped(startPoint, endPoint.position, Time.deltaTime * speed);
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            touched = true;
        }
    }
}
