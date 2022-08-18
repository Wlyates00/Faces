using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingCircles : MonoBehaviour
{
    public Vector2 boxSize;
    public Vector3 offset;
    public LayerMask playerLayer;
    public GameObject circleOne;
    public GameObject circleTwo;
    public GameObject circleThree;
    public GameObject circleFour;
    public GameObject circleFive;
    private Animator animCircleOne;
    private Animator animCircleTwo;
    private Animator animCircleThree;
    private Animator animCircleFour;
    private Animator animCircleFive;

    // Start is called before the first frame update
    void Start()
    {
        animCircleOne = circleOne.GetComponent<Animator>();
        animCircleTwo = circleTwo.GetComponent<Animator>();
        animCircleThree = circleThree.GetComponent<Animator>();
        animCircleFour = circleFour.GetComponent<Animator>();
        animCircleFive = circleFive.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics2D.OverlapBox(transform.position + offset, boxSize, 0, playerLayer))
        {
            animCircleOne.SetBool("Triggered", true);
            animCircleTwo.SetBool("Triggered", true);
            animCircleThree.SetBool("Triggered", true);
            animCircleFour.SetBool("Triggered", true);
            animCircleFive.SetBool("Triggered", true);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(transform.position + offset, boxSize);
    }
}
