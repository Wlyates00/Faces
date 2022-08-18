using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LY
{
    public class CameraFollow : MonoBehaviour
    {
        private GameObject player;
        private Camera cam;
        private Vector3 newPos;
        public Vector3 offset;
        public float timing;

        // Start is called before the first frame update
        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
            cam = Camera.main;
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (player != null)
            {
                newPos = new Vector3(player.transform.position.x, transform.position.y, 0) + offset;
                FollowPlayer();
            }

        }

        public void FollowPlayer()
        {
            if (Mathf.Abs(transform.position.x + offset.x - player.transform.position.x) > 2f)
            {
                Debug.Log(">2");
                transform.position = Vector3.Lerp(transform.position, newPos + offset, Time.deltaTime * .5f);
            }
            if (Mathf.Abs(transform.position.x + offset.x - player.transform.position.x) > 2.5)
            {
                Debug.Log(">2.5");
                transform.position = Vector3.Lerp(transform.position, newPos + offset, Time.deltaTime * timing);
            }
            if (Mathf.Abs(transform.position.x + offset.x - player.transform.position.x) > 2.8)
            {
                Debug.Log(">2.8");
                transform.position = Vector3.Lerp(transform.position, newPos + offset, Time.deltaTime * .7f);
            }
            if (Mathf.Abs(transform.position.x + offset.x - player.transform.position.x) > 3)
            {
                Debug.Log(">3");
                transform.position = Vector3.Lerp(transform.position, newPos + offset, Time.deltaTime);
            }
            if (Mathf.Abs(transform.position.x + offset.x - player.transform.position.x) > 4)
            {
                Debug.Log(">4");
                transform.position = Vector3.Lerp(transform.position, newPos + offset, Time.deltaTime * .9f);
            }
        }
    }
}
