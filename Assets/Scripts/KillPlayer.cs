using UnityEngine;

namespace LY
{
    public class KillPlayer : MonoBehaviour
    {
        private GameObject player;
        // Start is called before the first frame update
        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Black")
            {
                PlayerDeath();
            }
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Black")
            {
                PlayerDeath();
            }
        }
        private void PlayerDeath()
        {
            Destroy(player);
        }
    }
}