using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesTrigger : MonoBehaviour
{
    public Vector2 boxSize;
    public Vector3 offset;
    public LayerMask playerLayer;
    public GameObject spikes;
    private Animator spikesAnim;

    // Start is called before the first frame update
    void Start()
    {
        spikesAnim = spikes.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapBox(transform.position + offset, boxSize, 0, playerLayer))
        {
            spikesAnim.SetBool("Triggered", true);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(transform.position + offset, boxSize);
    }
}
