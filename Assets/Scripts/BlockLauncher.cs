using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockLauncher : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 launchDir;
    public float launchStrength;
    private bool launched;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!launched)
        {
            launched = true;
            rb.isKinematic = false;
            rb.AddForce(Vector2.zero + launchDir * launchStrength, ForceMode2D.Impulse);
        }
    }
}
