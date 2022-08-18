using LY;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelData
{
    public bool checkHalf;
    public bool checkOne;
    public bool checkOneHalf;
    public bool checkTwo;
    public bool checkTwoHalf;
    public bool checkThree;
    public bool checkThreeHalf;
    public bool checkFour;
    public bool checkFourHalf;
    public bool checkFive;
    public bool checkFiveHalf;
    public bool checkSix;

    public LevelData (LevelManager level)
    {
        if (!level.reset)
        {
            checkHalf = level.passedCheckPointHalf;
            checkOne = level.passedCheckPointOne;
            checkOneHalf = level.passedCheckPointOneHalf;
            checkTwo = level.passedCheckPointTwo;
            checkTwoHalf = level.passedCheckPointTwoHalf;
            checkThree = level.passedCheckPointThree;
            checkThreeHalf = level.passedCheckPointThreeHalf;
            checkFour = level.passedCheckPointFour;
            checkFourHalf = level.passedCheckPointFourHalf;
            checkFive = level.passedCheckPointFive;
            checkFiveHalf = level.passedCheckPointFiveHalf;
            checkSix = level.passedCheckPointSix;
        }
        if (level.reset)
        {
            checkHalf = false;
            checkOne = false;
            checkOneHalf = false;
            checkTwo = false;
            checkTwoHalf = false;
            checkThree = false;
            checkThreeHalf = false;
            checkFour = false;
            checkFourHalf = false;
            checkFive = false;
            checkFiveHalf = false;
            checkSix = false;
        }

    }
}
