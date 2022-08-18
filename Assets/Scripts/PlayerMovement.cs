using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace LY
{
    public class PlayerMovement : MonoBehaviour
    {
        public float speed;
        private float moveDir;
        public float jumpForce;
        public Rigidbody2D rb;
        private GameObject player;
        private bool isGrounded;
        private bool grounded;
        private bool delayed;

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            player = GameObject.FindGameObjectWithTag("Player");
        }
        private void OnCollisionStay2D(Collision2D collision)
        {
            if (!delayed)
            {
                StartCoroutine(GroundedDelay());
                delayed = true;
            }

            if (isGrounded)
            {
                rb.AddForce(Vector2.up * jumpForce / 25, ForceMode2D.Impulse);
            }
        }
        private void OnCollisionEnter2D(Collision2D collider)
        {
            if (collider.gameObject.tag == "Ground")
            {
                isGrounded = true;
                rb.constraints = RigidbodyConstraints2D.FreezePositionY;
                Bounce();
                rb.constraints = ~RigidbodyConstraints2D.None;
                rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }
        private void OnCollisionExit2D(Collision2D collision)
        {
            isGrounded = false;
        }


        private void FixedUpdate()
        {
            Vector2 dir = new Vector2(rb.position.x + moveDir * speed * Time.deltaTime, rb.position.y);
            rb.velocity = new Vector2(moveDir * speed, rb.velocity.y);
        }
        public void Move(InputAction.CallbackContext context)
        {
            //reading axis value as a float
            moveDir = context.ReadValue<float>();
            
        }

        public void Bounce()
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        IEnumerator GroundedDelay()
        {
            yield return new WaitForSeconds(.2f);
            delayed = false;
        }
    }
}
