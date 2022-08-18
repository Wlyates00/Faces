using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LY
{
    public class SpawnSmallBalls : MonoBehaviour
    {
        public int spawnCount;
        public GameObject smallBall;
        public LayerMask playerLayer;
        public Vector2 boxSize;
        public Vector3 offset;
        public bool canTrigger = true;
        public Transform strayCircles;
        public float delay;
        private bool wait = true;
        public bool touched;
        
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Physics2D.OverlapBox(transform.position + offset, boxSize, 0, playerLayer) && canTrigger)
            {
                touched = true;
                StartCoroutine(DropDelay());
            }
            if (touched)
            {
                SpawnBalls(smallBall);
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(transform.position + offset, boxSize);

        }

        private void SpawnBalls(GameObject ball)
        {

            if (!wait)
            {
                for (int i = 0; i < spawnCount; i++)
                {
                    Vector2 spawnPos = transform.position + new Vector3(Random.Range(-1.4f, 1.3f), Random.Range(-1.5f, 1.7f), 0);
                    Instantiate(ball, spawnPos, Quaternion.identity, strayCircles);
                }
                canTrigger = false;
                touched = false;
                wait = true;
            }

        }

        IEnumerator DropDelay()
        {
            yield return new WaitForSeconds(delay);
            wait = false;
        }
    }
}
