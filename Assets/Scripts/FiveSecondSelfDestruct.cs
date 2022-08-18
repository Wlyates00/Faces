using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LY
{
    public class FiveSecondSelfDestruct : MonoBehaviour
    {
        public void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.gameObject.tag == "Black")
            {
                Destroy(collision.gameObject);
            }
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Black")
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
