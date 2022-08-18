using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LY
{
    public class TrackingCannon : MonoBehaviour
    {
        public float shotForce;
        private GameObject player;
        public GameObject objectToFire;
        private Rigidbody2D objectRB;
        private bool canShoot = true;
        public float shotDelay;
        public Vector3 aimOffest;

        public Vector3 offset;
        public Vector2 boxSize;
        public LayerMask playerLayer;

        // Start is called before the first frame update
        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
            objectRB = objectToFire.GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            
            if (Physics2D.OverlapBox(transform.position + offset, boxSize, 0, playerLayer))
            {
                Debug.Log("YE");
                FireAtPlayer();
            }

        }

        private void FireAtPlayer()
        {
            Vector2 target = transform.position - player.transform.position + aimOffest;
            
            if (canShoot)
            {
                canShoot = false;
                StartCoroutine(ShotDelay());
                GameObject shot = Instantiate(objectToFire, transform.position, Quaternion.identity);
                shot.GetComponent<Rigidbody2D>().AddForce(target * shotForce, ForceMode2D.Impulse);
                Destroy(shot, 5);
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.black;
            Gizmos.DrawWireCube(transform.position + offset, boxSize);
        }

        IEnumerator ShotDelay()
        {
            yield return new WaitForSeconds(shotDelay);
            canShoot = true;
        }
    }
}