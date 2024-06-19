using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralStorage : MonoBehaviour
{
    public int lives = 3;

    public int round = 1;

    public void ButtomOnePressed()
    {
        if (round == 2 || round == 3 || round == 4)
        {
            round = round + 1;
        }
        else
        {
            lives = lives - 1;
        }
    }

    public void ButtomTwoPressed()
    {
        if (round == 5)
        {
            round = round + 1;
        }
        else
        {
            lives = lives - 1;
        }
    }

    public void ButtomThreePressed()
    {
        if (round == 1 || round == 5)
        {
            round = round + 1;
        }
        else
        {
            lives = lives - 1;
        }
    }

    public void Update()
    {
        if (lives < 1)
        {
            Debug.Log("QuitGame");
            Application.Quit();
        }
    }
}
