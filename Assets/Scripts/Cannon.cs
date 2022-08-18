using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LY
{
    public class Cannon : MonoBehaviour
    {
        public Vector2 boxSize;
        public LayerMask playerLayer;
        public Vector2 shotAngle;
        public float shotForce;
        public GameObject objectToShoot;
        public float shotDelay;
        public float shotLife;
        public bool canShoot = true;
        private bool setTrue;
        

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Shoot(objectToShoot);
            if (Physics2D.OverlapBox(transform.position, boxSize, 0, playerLayer))
            {
                if (!setTrue)
                {
                    setTrue = true;

                    canShoot = true;
                    
                }
            }
        }

        private void Shoot(GameObject obj)
        {

            if (canShoot)
            {
                canShoot = false;
                StartCoroutine(ShotDelay());
                GameObject shot = Instantiate(obj, transform.position, Quaternion.identity);
                shot.GetComponent<Rigidbody2D>().AddForce(Vector2.up  * shotForce + shotAngle, ForceMode2D.Impulse);
                Destroy(shot, shotLife);
            }

        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(transform.position, boxSize);
        }
        IEnumerator ShotDelay()
        {
            yield return new WaitForSeconds(shotDelay);
            canShoot = true;
        }
    }
}
