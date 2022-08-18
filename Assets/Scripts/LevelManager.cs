using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace LY
{
    public class LevelManager : MonoBehaviour
    {
        public bool reset;
        public Vector3 offsetHalf;
        public Vector3 offsetOne;
        public Vector3 offsetOneHalf;
        public Vector3 offsetTwo;
        public Vector3 offsetTwoHalf;
        public Vector3 offsetThree;
        public Vector3 offsetThreeHalf;
        public Vector3 offsetFour;
        public Vector3 offsetFourHalf;
        public Vector3 offsetFive;
        public Vector3 offsetFiveHalf;
        private Camera cam;
        public Vector2 checkPointBoxSize;
        public bool passedCheckPointHalf;
        public bool passedCheckPointOne;
        public bool passedCheckPointOneHalf;
        public bool passedCheckPointTwo;
        public bool passedCheckPointTwoHalf;
        public bool passedCheckPointThree;
        public bool passedCheckPointThreeHalf;
        public bool passedCheckPointFour;
        public bool passedCheckPointFourHalf;
        public bool passedCheckPointFive;
        public bool passedCheckPointFiveHalf;
        public bool passedCheckPointSix;
        public Vector3 checkPointOffsetHalf;
        public Vector3 checkPointOffsetOne;
        public Vector3 checkPointOffsetOneHalf;
        public Vector3 checkPointOffsetTwo;
        public Vector3 checkPointOffsetTwoHalf;
        public Vector3 checkPointOffsetThree;
        public Vector3 checkPointOffsetThreeHalf;
        public Vector3 checkPointOffsetFour;
        public Vector3 checkPointOffsetFourHalf;
        public Vector3 checkPointOffsetFive;
        public Vector3 checkPointOffsetFiveHalf;
        public Vector3 checkPointOffsetSix;
        public Transform spawnPoint;
        public LayerMask playerLayer;
        private bool addedOffsetHalf;
        private bool addedOffsetOne;
        private bool addedOffsetOneHalf;
        private bool addedOffsetTwo;
        private bool addedOffsetTwoHalf;
        private bool addedOffsetThree;
        private bool addedOffsetThreeHalf;
        private bool addedOffsetFour;
        private bool addedOffsetFourHalf;
        private bool addedOffsetFive;
        private bool addedOffsetFiveHalf;
        private bool addedOffsetSix;
        private bool savedHalf;
        private bool savedOne;
        private bool savedOneHalf;
        private bool savedTwo;
        private bool savedTwoHalf;
        private bool savedThree;
        private bool savedThreeHalf;
        private bool savedFour;
        private bool savedFourHalf;
        private bool savedFive;
        private bool savedFiveHalf;
        private bool savedSix;

        private GameObject player;

        public GameObject blueArea;
        public GameObject greenArea;
        public GameObject yellowArea;
        public GameObject orangeArea;
        public GameObject redArea;
        public GameObject purpleArea;

        public Transform parent;

        public GameObject greenAreaPrefab;
        public GameObject yellowAreaPrefab;
        public GameObject orangeAreaPrefab;
        public GameObject redAreaPrefab;
        public GameObject purpleAreaPrefab;

        private Vector2 greenAreaPos;
        private Vector2 yellowAreaPos;
        private Vector2 orangeAreaPos;
        private Vector2 redAreaPos;
        private Vector2 purpleAreaPos;

        public GameObject boundaryKiller;
        public Vector2 boundaryoffsetOne;
        public Vector2 boundaryoffsetTwo;
        public Vector2 boundaryoffsetThree;
        public Vector2 boundaryoffsetFour;
        public Vector2 boundaryoffsetFive;

        public int winScreenIndex;

        // Start is called before the first frame update
        void Start()
        {
            greenAreaPos = greenArea.transform.position;
            yellowAreaPos = yellowArea.transform.position;
            orangeAreaPos = orangeArea.transform.position;
            redAreaPos = redArea.transform.position;
            purpleAreaPos = purpleArea.transform.position;

            Destroy(greenArea);
            Destroy(yellowArea);
            Destroy(orangeArea);
            Destroy(redArea);
            Destroy(purpleArea);
            if (reset)
            {
                passedCheckPointOne = false;
                SaveLevel();
                reset = false;
            }
            cam = Camera.main;
            player = GameObject.FindGameObjectWithTag("Player");
            LoadData();
            if (!addedOffsetHalf && passedCheckPointHalf)
            {
                addedOffsetHalf = true;
                greenArea = Instantiate(greenAreaPrefab, greenAreaPos, Quaternion.identity, parent);
                spawnPoint.position = new Vector3(spawnPoint.position.x + offsetHalf.x, spawnPoint.position.y + offsetHalf.y, spawnPoint.position.z + offsetHalf.z);
                cam.transform.position = new Vector3(spawnPoint.position.x + 4f, cam.transform.position.y, cam.transform.position.z);
                player.transform.position = spawnPoint.position;

            }
            if (!addedOffsetOne && passedCheckPointOne)
            {
                addedOffsetOne = true;
                greenArea = Instantiate(greenAreaPrefab, greenAreaPos, Quaternion.identity, parent);
                Instantiate(boundaryKiller, boundaryoffsetOne, Quaternion.identity);
                Destroy(blueArea);
                spawnPoint.position = new Vector3(spawnPoint.position.x + offsetOne.x, spawnPoint.position.y + offsetOne.y, spawnPoint.position.z + offsetOne.z);
                cam.transform.position = new Vector3(spawnPoint.position.x + 4f, cam.transform.position.y, cam.transform.position.z);
                player.transform.position = spawnPoint.position;

            }
            if (!addedOffsetOneHalf && passedCheckPointOneHalf)
            {
                addedOffsetOneHalf = true;
                greenArea = Instantiate(greenAreaPrefab, greenAreaPos, Quaternion.identity, parent);
                yellowArea = Instantiate(yellowAreaPrefab, yellowAreaPos, Quaternion.identity, parent);
                Instantiate(boundaryKiller, boundaryoffsetOne, Quaternion.identity);
                Destroy(blueArea);
                spawnPoint.position = new Vector3(spawnPoint.position.x + offsetOneHalf.x, spawnPoint.position.y + offsetOneHalf.y, spawnPoint.position.z + offsetOneHalf.z);
                cam.transform.position = new Vector3(spawnPoint.position.x + 4f, cam.transform.position.y, cam.transform.position.z);
                player.transform.position = spawnPoint.position;

            }
            if (!addedOffsetTwo && passedCheckPointTwo)
            {
                addedOffsetTwo = true;
                yellowArea = Instantiate(yellowAreaPrefab, yellowAreaPos, Quaternion.identity, parent);
                Instantiate(boundaryKiller, boundaryoffsetTwo, Quaternion.identity);
                Destroy(blueArea);
                Destroy(greenArea);
                spawnPoint.position = new Vector3(spawnPoint.position.x + offsetTwo.x, spawnPoint.position.y + offsetTwo.y, spawnPoint.position.z + offsetTwo.z);
                cam.transform.position = new Vector3(spawnPoint.position.x + 4f, cam.transform.position.y, cam.transform.position.z);
                player.transform.position = spawnPoint.position;

            }
            if (!addedOffsetTwoHalf && passedCheckPointTwoHalf)
            {
                addedOffsetTwoHalf = true;
                yellowArea = Instantiate(yellowAreaPrefab, yellowAreaPos, Quaternion.identity, parent);
                orangeArea = Instantiate(orangeAreaPrefab, orangeAreaPos, Quaternion.identity, parent);
                Instantiate(boundaryKiller, boundaryoffsetTwo, Quaternion.identity);
                Destroy(blueArea);
                Destroy(greenArea);
                spawnPoint.position = new Vector3(spawnPoint.position.x + offsetTwoHalf.x, spawnPoint.position.y + offsetTwoHalf.y, spawnPoint.position.z + offsetTwoHalf.z);
                cam.transform.position = new Vector3(spawnPoint.position.x + 4f, cam.transform.position.y, cam.transform.position.z);
                player.transform.position = spawnPoint.position;

            }
            if (!addedOffsetThree && passedCheckPointThree)
            {
                addedOffsetThree = true;
                orangeArea = Instantiate(orangeAreaPrefab, orangeAreaPos, Quaternion.identity, parent);
                Instantiate(boundaryKiller, boundaryoffsetThree, Quaternion.identity);
                Destroy(blueArea);
                Destroy(greenArea);
                Destroy(yellowArea);
                spawnPoint.position = new Vector3(spawnPoint.position.x + offsetThree.x, spawnPoint.position.y + offsetThree.y, spawnPoint.position.z + offsetThree.z);
                cam.transform.position = new Vector3(spawnPoint.position.x + 4f, cam.transform.position.y, cam.transform.position.z);
                player.transform.position = spawnPoint.position;
            }
            if (!addedOffsetThreeHalf && passedCheckPointThreeHalf)
            {
                addedOffsetThreeHalf = true;
                orangeArea = Instantiate(orangeAreaPrefab, orangeAreaPos, Quaternion.identity, parent);
                redArea = Instantiate(redAreaPrefab, redAreaPos, Quaternion.identity, parent);
                Instantiate(boundaryKiller, boundaryoffsetThree, Quaternion.identity);
                Destroy(blueArea);
                Destroy(greenArea);
                Destroy(yellowArea);
                spawnPoint.position = new Vector3(spawnPoint.position.x + offsetThreeHalf.x, spawnPoint.position.y + offsetThreeHalf.y, spawnPoint.position.z + offsetThreeHalf.z);
                cam.transform.position = new Vector3(spawnPoint.position.x + 4f, cam.transform.position.y, cam.transform.position.z);
                player.transform.position = spawnPoint.position;
            }
            if (!addedOffsetFour && passedCheckPointFour)
            {
                addedOffsetFour = true;
                redArea = Instantiate(redAreaPrefab, redAreaPos, Quaternion.identity, parent);
                Instantiate(boundaryKiller, boundaryoffsetFour, Quaternion.identity);
                Destroy(blueArea);
                Destroy(greenArea);
                Destroy(yellowArea);
                Destroy(orangeArea);
                spawnPoint.position = new Vector3(spawnPoint.position.x + offsetFour.x, spawnPoint.position.y + offsetFour.y, spawnPoint.position.z + offsetFour.z);
                cam.transform.position = new Vector3(spawnPoint.position.x + 4f, cam.transform.position.y, cam.transform.position.z);
                player.transform.position = spawnPoint.position;
            }
            if (!addedOffsetFourHalf && passedCheckPointFourHalf)
            {
                addedOffsetFourHalf = true;
                redArea = Instantiate(redAreaPrefab, redAreaPos, Quaternion.identity, parent);
                purpleArea = Instantiate(purpleAreaPrefab, purpleAreaPos, Quaternion.identity, parent);
                Instantiate(boundaryKiller, boundaryoffsetFour, Quaternion.identity);
                Destroy(blueArea);
                Destroy(greenArea);
                Destroy(yellowArea);
                Destroy(orangeArea);
                spawnPoint.position = new Vector3(spawnPoint.position.x + offsetFourHalf.x, spawnPoint.position.y + offsetFourHalf.y, spawnPoint.position.z + offsetFourHalf.z);
                cam.transform.position = new Vector3(spawnPoint.position.x + 4f, cam.transform.position.y, cam.transform.position.z);
                player.transform.position = spawnPoint.position;
            }
            if (!addedOffsetFive && passedCheckPointFive)
            {
                addedOffsetFive = true;
                purpleArea = Instantiate(purpleAreaPrefab, purpleAreaPos, Quaternion.identity, parent);
                Instantiate(boundaryKiller, boundaryoffsetFive, Quaternion.identity);
                Destroy(blueArea);
                Destroy(greenArea);
                Destroy(yellowArea);
                Destroy(orangeArea);
                Destroy(redArea);
                spawnPoint.position = new Vector3(spawnPoint.position.x + offsetFive.x, spawnPoint.position.y + offsetFive.y, spawnPoint.position.z + offsetFive.z);
                cam.transform.position = new Vector3(spawnPoint.position.x + 4f, cam.transform.position.y, cam.transform.position.z);
                player.transform.position = spawnPoint.position;
            }
            if (!addedOffsetFiveHalf && passedCheckPointFiveHalf)
            {
                addedOffsetFiveHalf = true;
                purpleArea = Instantiate(purpleAreaPrefab, purpleAreaPos, Quaternion.identity, parent);
                Instantiate(boundaryKiller, boundaryoffsetFive, Quaternion.identity);
                Destroy(blueArea);
                Destroy(greenArea);
                Destroy(yellowArea);
                Destroy(orangeArea);
                Destroy(redArea);
                spawnPoint.position = new Vector3(spawnPoint.position.x + offsetFiveHalf.x, spawnPoint.position.y + offsetFiveHalf.y, spawnPoint.position.z + offsetFiveHalf.z);
                cam.transform.position = new Vector3(spawnPoint.position.x + 4f, cam.transform.position.y, cam.transform.position.z);
                player.transform.position = spawnPoint.position;
            }
            if (passedCheckPointSix)
            {
                SceneManager.LoadScene(winScreenIndex);
            }
        }

        // Update is called once per frame
        void Update()
        {
            
            if (Physics2D.OverlapBox(transform.position + checkPointOffsetHalf, checkPointBoxSize, 0, playerLayer)) passedCheckPointHalf = true;
            if (Physics2D.OverlapBox(transform.position + checkPointOffsetOne, checkPointBoxSize, 0, playerLayer)) passedCheckPointOne = true;
            if (Physics2D.OverlapBox(transform.position + checkPointOffsetOneHalf, checkPointBoxSize, 0, playerLayer)) passedCheckPointOneHalf = true;
            if (Physics2D.OverlapBox(transform.position + checkPointOffsetTwo, checkPointBoxSize, 0, playerLayer)) passedCheckPointTwo = true;
            if (Physics2D.OverlapBox(transform.position + checkPointOffsetTwoHalf, checkPointBoxSize, 0, playerLayer)) passedCheckPointTwoHalf = true;
            if (Physics2D.OverlapBox(transform.position + checkPointOffsetThree, checkPointBoxSize, 0, playerLayer)) passedCheckPointThree = true;
            if (Physics2D.OverlapBox(transform.position + checkPointOffsetThreeHalf, checkPointBoxSize, 0, playerLayer)) passedCheckPointThreeHalf = true;
            if (Physics2D.OverlapBox(transform.position + checkPointOffsetFour, checkPointBoxSize, 0, playerLayer)) passedCheckPointFour = true;
            if (Physics2D.OverlapBox(transform.position + checkPointOffsetFourHalf, checkPointBoxSize, 0, playerLayer)) passedCheckPointFourHalf = true;
            if (Physics2D.OverlapBox(transform.position + checkPointOffsetFive, checkPointBoxSize, 0, playerLayer)) passedCheckPointFive = true;
            if (Physics2D.OverlapBox(transform.position + checkPointOffsetFiveHalf, checkPointBoxSize, 0, playerLayer)) passedCheckPointFiveHalf = true;
            if (Physics2D.OverlapBox(transform.position + checkPointOffsetSix, checkPointBoxSize, 0, playerLayer)) passedCheckPointSix = true;

            
            if (passedCheckPointHalf)
            {
                passedCheckPointHalf = true;
                if (!savedHalf)
                {
                    savedHalf = true;
                    SaveLevel();
                }
                if (greenArea == null)
                {
                    greenArea = Instantiate(greenAreaPrefab, greenAreaPos, Quaternion.identity, parent);
                }
            }
            if (passedCheckPointOne)
            {
                passedCheckPointHalf = false;
                Destroy(blueArea);
                
                passedCheckPointOne = true;
                if (!savedOne)
                {
                    Instantiate(boundaryKiller, boundaryoffsetOne, Quaternion.identity);
                    savedOne = true;
                    SaveLevel();
                }
                if (greenArea == null)
                {
                    greenArea = Instantiate(greenAreaPrefab, greenAreaPos, Quaternion.identity, parent);
                }
                
                //Destroy()
            }
            if (passedCheckPointOneHalf)
            {
                passedCheckPointOne = false;
                passedCheckPointOneHalf = true;
                if(blueArea != null)
                {
                    Destroy(blueArea);
                }

                if (!savedOneHalf)
                {
                    Instantiate(boundaryKiller, boundaryoffsetOne, Quaternion.identity);
                    savedOneHalf = true;
                    SaveLevel();
                }
                if (greenArea == null)
                {
                    greenArea = Instantiate(greenAreaPrefab, greenAreaPos, Quaternion.identity, parent);
                }
                if (yellowArea == null)
                {
                    yellowArea = Instantiate(yellowAreaPrefab, yellowAreaPos, Quaternion.identity, parent);
                }
            }
            if (passedCheckPointTwo)
            {
                passedCheckPointOne = false;
                passedCheckPointOneHalf = false;
                passedCheckPointTwo = true;

                Destroy(greenArea);
                
                if (!savedTwo)
                {
                    Instantiate(boundaryKiller, boundaryoffsetTwo, Quaternion.identity);
                    savedTwo = true;
                    SaveLevel();
                }
                if (yellowArea == null)
                {
                    yellowArea = Instantiate(yellowAreaPrefab, yellowAreaPos, Quaternion.identity, parent);
                    
                }
            }
            if (passedCheckPointTwoHalf)
            {
                passedCheckPointOne = false;
                passedCheckPointOneHalf = false;
                passedCheckPointTwo = false;
                passedCheckPointTwoHalf = true;
                if(greenArea != null)
                {
                    Destroy(greenArea);
                }
                if (!savedTwoHalf)
                {
                    Instantiate(boundaryKiller, boundaryoffsetTwo, Quaternion.identity);
                    savedTwoHalf = true;
                    SaveLevel();
                }
                if (yellowArea == null)
                {
                    yellowArea = Instantiate(yellowAreaPrefab, yellowAreaPos, Quaternion.identity, parent);
                    
                }
                if (orangeArea == null)
                {
                    orangeArea = Instantiate(orangeAreaPrefab, orangeAreaPos, Quaternion.identity, parent);
                }
            }
            if (passedCheckPointThree)
            {
                passedCheckPointOne = false;
                passedCheckPointOneHalf = false;
                passedCheckPointTwo = false;
                passedCheckPointTwoHalf = false;
                passedCheckPointThree = true;
                if (yellowArea != null)
                {
                    Destroy(yellowArea);
                }
                if (!savedThree)
                {
                    Instantiate(boundaryKiller, boundaryoffsetThree, Quaternion.identity);
                    savedThree = true;
                    SaveLevel();
                }
            }
            if (passedCheckPointThreeHalf)
            {
                passedCheckPointOne = false;
                passedCheckPointOneHalf = false;
                passedCheckPointTwo = false;
                passedCheckPointTwoHalf = false;
                passedCheckPointThree = false;
                passedCheckPointThreeHalf = true;
                if (yellowArea != null)
                {
                    Destroy(yellowArea);
                }
                if (!savedThreeHalf)
                {
                    Instantiate(boundaryKiller, boundaryoffsetThree, Quaternion.identity);
                    savedThreeHalf = true;
                    SaveLevel();
                }
                if (redArea == null)
                {
                    redArea = Instantiate(redAreaPrefab, redAreaPos, Quaternion.identity, parent);
                }
            }
            if (passedCheckPointFour)
            {
                passedCheckPointOne = false;
                passedCheckPointOneHalf = false;
                passedCheckPointTwo = false;
                passedCheckPointTwoHalf = false;
                passedCheckPointThree = false;
                passedCheckPointThreeHalf = false;
                passedCheckPointFour = true;
                Destroy(orangeArea);
                if (!savedFour)
                {
                    Instantiate(boundaryKiller, boundaryoffsetFour, Quaternion.identity);
                    savedFour = true;
                    SaveLevel();
                }
            }
            if (passedCheckPointFourHalf)
            {
                passedCheckPointOne = false;
                passedCheckPointOneHalf = false;
                passedCheckPointTwo = false;
                passedCheckPointTwoHalf = false;
                passedCheckPointThree = false;
                passedCheckPointThreeHalf = false;
                passedCheckPointFour = false;
                passedCheckPointFourHalf = true;
                if (orangeArea != null)
                {
                    Destroy(orangeArea);
                }
                if(purpleArea == null)
                {
                    purpleArea = Instantiate(purpleAreaPrefab, purpleAreaPos, Quaternion.identity, parent);
                }
                if (!savedFourHalf)
                {
                    Instantiate(boundaryKiller, boundaryoffsetFour, Quaternion.identity);
                    savedFourHalf = true;
                    SaveLevel();
                }

            }
            if (passedCheckPointFive)
            {
                passedCheckPointOne = false;
                passedCheckPointOneHalf = false;
                passedCheckPointTwo = false;
                passedCheckPointTwoHalf = false;
                passedCheckPointThree = false;
                passedCheckPointThreeHalf = false;
                passedCheckPointFour = false;
                passedCheckPointFourHalf = false;
                passedCheckPointFive = true;
                Destroy(redArea);
                if (!savedFive)
                {
                    Instantiate(boundaryKiller, boundaryoffsetFive, Quaternion.identity);
                    savedFive = true;
                    SaveLevel();
                }
            }
            if (passedCheckPointFiveHalf)
            {
                passedCheckPointOne = false;
                passedCheckPointOneHalf = false;
                passedCheckPointTwo = false;
                passedCheckPointTwoHalf = false;
                passedCheckPointThree = false;
                passedCheckPointThreeHalf = false;
                passedCheckPointFour = false;
                passedCheckPointFourHalf = false;
                passedCheckPointFive = false;
                passedCheckPointFiveHalf = true;
                if (redArea != null)
                {
                    Destroy(redArea);
                }
                if (!savedFiveHalf)
                {
                    Instantiate(boundaryKiller, boundaryoffsetFive, Quaternion.identity);
                    savedFiveHalf = true;
                    SaveLevel();
                }
            }
            if (passedCheckPointSix)
            {
                passedCheckPointOne = false;
                passedCheckPointOneHalf = false;
                passedCheckPointTwo = false;
                passedCheckPointTwoHalf = false;
                passedCheckPointThree = false;
                passedCheckPointThreeHalf = false;
                passedCheckPointFour = false;
                passedCheckPointFourHalf = false;
                passedCheckPointFive = false;
                passedCheckPointFiveHalf = false;
                SceneManager.LoadScene(winScreenIndex);
                if (redArea != null)
                {
                    Destroy(redArea);
                }
                if (!savedSix)
                {
                    
                    savedSix = true;
                    SaveLevel();
                }
            }


        }
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.magenta;
            Gizmos.DrawWireCube(transform.position + checkPointOffsetHalf, checkPointBoxSize);
            Gizmos.DrawWireCube(transform.position + checkPointOffsetOne, checkPointBoxSize);
            Gizmos.DrawWireCube(transform.position + checkPointOffsetOneHalf, checkPointBoxSize);
            Gizmos.DrawWireCube(transform.position + checkPointOffsetTwo, checkPointBoxSize);
            Gizmos.DrawWireCube(transform.position + checkPointOffsetTwoHalf, checkPointBoxSize);
            Gizmos.DrawWireCube(transform.position + checkPointOffsetThree, checkPointBoxSize);
            Gizmos.DrawWireCube(transform.position + checkPointOffsetThreeHalf, checkPointBoxSize);
            Gizmos.DrawWireCube(transform.position + checkPointOffsetFour, checkPointBoxSize);
            Gizmos.DrawWireCube(transform.position + checkPointOffsetFourHalf, checkPointBoxSize);
            Gizmos.DrawWireCube(transform.position + checkPointOffsetFive, checkPointBoxSize);
            Gizmos.DrawWireCube(transform.position + checkPointOffsetFiveHalf, checkPointBoxSize);
            Gizmos.DrawWireCube(transform.position + checkPointOffsetSix, checkPointBoxSize);
        }

        public void SaveLevel()
        {
            SaveSystem.SaveLevel(this);
        }

        public void LoadData()
        {
            LevelData data = SaveSystem.LoadData();

            passedCheckPointHalf = data.checkHalf;
            passedCheckPointOne = data.checkOne;
            passedCheckPointOneHalf = data.checkOneHalf;
            passedCheckPointTwo = data.checkTwo;
            passedCheckPointTwoHalf = data.checkTwoHalf;
            passedCheckPointThree = data.checkThree;
            passedCheckPointThreeHalf = data.checkThreeHalf;
            passedCheckPointFour = data.checkFour;
            passedCheckPointFourHalf = data.checkFourHalf;
            passedCheckPointFive = data.checkFive;
            passedCheckPointFiveHalf = data.checkFiveHalf;
            passedCheckPointSix = data.checkSix;
        }
    }
}