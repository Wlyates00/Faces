using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LY
{
    public class PlayerDeath : MonoBehaviour
    {
        public float delay;
        private GameObject player;
        private bool openUI;
        public GameObject UI;
        public GameObject deathFX;
        // Start is called before the first frame update
        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        // Update is called once per frame
        void Update()
        {
            FollowPlayer();
            if(player != null)
            {
                deathFX.transform.position = player.transform.position;
            }
            if (player == null)
            {
                deathFX.gameObject.SetActive(true);
                StartCoroutine(UIDelay());
                if (openUI)
                {
                    UI.gameObject.SetActive(true);
                }
            }
        }
        private void FollowPlayer()
        {
            if(player != null)
            {
                deathFX.transform.position = player.transform.position;
            }

        }
       
        public void RetryButton()
        {
            SceneManager.LoadScene(0);
        }

        public void MenuButton()
        {
            SceneManager.LoadScene(1);
        }

        IEnumerator UIDelay()
        {
            yield return new WaitForSeconds(delay);
            openUI = true;
        }
    }
}
