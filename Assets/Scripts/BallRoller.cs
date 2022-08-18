using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRoller : MonoBehaviour
{
    public GameObject ballOne;
    public GameObject ballTwo;
    public GameObject ballThree;
    public GameObject ballFour;
    public GameObject ballFive;
    public GameObject ballSix;
    public GameObject ballSeven;
    public GameObject ballEight;
    private Rigidbody2D ballOneRB;
    private Rigidbody2D ballTwoRB;
    private Rigidbody2D ballThreeRB;
    private Rigidbody2D ballFourRB;
    private Rigidbody2D ballFiveRB;
    private Rigidbody2D ballSixRB;
    private Rigidbody2D ballSevenRB;
    private Rigidbody2D ballEightRB;

    public LayerMask playerLayer;
    public Vector2 boxSize;
    public Vector3 triggerOffsetOne;
    public Vector3 triggerOffsetTwo;
    public Vector3 triggerOffsetThree;
    public Vector3 triggerOffsetFour;
    public Vector3 triggerOffsetFive;
    public Vector3 triggerOffsetSix;
    // Start is called before the first frame update
    void Start()
    {
        ballOneRB = ballOne.GetComponent<Rigidbody2D>();
        ballTwoRB = ballTwo.GetComponent<Rigidbody2D>();
        ballThreeRB = ballThree.GetComponent<Rigidbody2D>();
        ballFourRB = ballFour.GetComponent<Rigidbody2D>();
        ballFiveRB = ballFive.GetComponent<Rigidbody2D>();
        ballSixRB = ballSix.GetComponent<Rigidbody2D>();
        ballSevenRB = ballSeven.GetComponent<Rigidbody2D>();
        ballEightRB = ballEight.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics2D.OverlapBox(transform.position + triggerOffsetOne, boxSize, 0, playerLayer))
        {
            ballOneRB.isKinematic = false;
        }
        if (Physics2D.OverlapBox(transform.position + triggerOffsetTwo, boxSize, 0, playerLayer))
        {
            ballTwoRB.isKinematic = false;
        }
        if (Physics2D.OverlapBox(transform.position + triggerOffsetThree, boxSize, 0, playerLayer))
        {
            ballThreeRB.isKinematic = false;
        }
        if (Physics2D.OverlapBox(transform.position + triggerOffsetFour, boxSize, 0, playerLayer))
        {
            ballFourRB.isKinematic = false;
        }
        if (Physics2D.OverlapBox(transform.position + triggerOffsetFive, boxSize, 0, playerLayer))
        {
            ballFiveRB.isKinematic = false;
            ballSixRB.isKinematic = false;
        }
        if (Physics2D.OverlapBox(transform.position + triggerOffsetSix, boxSize, 0, playerLayer))
        {
            ballSevenRB.isKinematic = false;
            ballEightRB.isKinematic = false;
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.gray;
        Gizmos.DrawWireCube(transform.position + triggerOffsetOne, boxSize);
        Gizmos.DrawWireCube(transform.position + triggerOffsetTwo, boxSize);
        Gizmos.DrawWireCube(transform.position + triggerOffsetThree, boxSize);
        Gizmos.DrawWireCube(transform.position + triggerOffsetFour, boxSize);
        Gizmos.DrawWireCube(transform.position + triggerOffsetFive, boxSize);
        Gizmos.DrawWireCube(transform.position + triggerOffsetSix, boxSize);
    }
}
