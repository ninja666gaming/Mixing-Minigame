using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkResults : MonoBehaviour
{
    private int targetPower1 = 2;
    private int targetAnger1 = 0;
    private int targetLethality2 = 0;
    private int targetPower2 = 1;
    private int targetAnger2 = -1;
    private int targetLethality3 = 0;
    private int targetPower3 = 0;
    private int targetAnger3 = -2;
    private int targetLethality4 = 3;
    private int targetPower4 = 2;
    private int targetAnger4 = 2;
    private int targetLethality5 = 1;
    private int targetPower5 = 2;
    private int targetAnger5 = -1;
    public intensitycounter intensitylevel;
    public sweatnesscounter sweatnesslevel;
    public thicknesscounter thicknesslevel;
    public resetbutton resetfunction;
    public static int stageCounter = 1;
    [SerializeField] GameObject badTaste;
    [SerializeField] GameObject goodTaste;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void DrinkFinshed()
    {
        if (drinkpress.glasslimit < 3)
        { return; }
        else
        {
            if (stageCounter == 5)
            {
                if ((intensitylevel.currentintensity >= targetLethality5) && (sweatnesslevel.currentSweatness <= targetAnger5) && (thicknesslevel.currentThickness >= targetPower5))
                {
                    if ((intensitylevel.currentintensity == targetLethality5) && (sweatnesslevel.currentSweatness == targetAnger5) && (thicknesslevel.currentThickness == targetPower5))
                    {
                        Debug.Log("Superwin_5");
                        goodTaste.SetActive(true);
                    }
                    else
                    {
                        Debug.Log("Halfwin_5");
                        goodTaste.SetActive(true);
                    }
                }
                else
                {
                    Debug.Log("Lose_5");
                    badTaste.SetActive(true);
                }
            }
            if (stageCounter == 4)
            {
                if ((thicknesslevel.currentThickness == targetPower4) && (sweatnesslevel.currentSweatness < targetAnger4))
                {
                    if (intensitylevel.currentintensity == targetLethality4)
                    {
                        Debug.Log("Superwin_4");
                        goodTaste.SetActive(true);
                    }
                    else
                    {
                        Debug.Log("Halfwin_4");
                        goodTaste.SetActive(true);
                    }
                }
                else
                {
                    Debug.Log("Lose_4");
                    badTaste.SetActive(true);
                }
                stageCounter += 1;
            }
            if (stageCounter == 3)
            {
                if ((intensitylevel.currentintensity == targetLethality3) && (sweatnesslevel.currentSweatness == targetAnger3))
                {
                    if (thicknesslevel.currentThickness > targetPower3)
                    {
                        Debug.Log("Superwin_3");
                        goodTaste.SetActive(true);
                    }
                    else
                    {
                        Debug.Log("Halfwin_3");
                        goodTaste.SetActive(true);
                    }
                }
                else
                {
                    Debug.Log("Lose_3");
                    badTaste.SetActive(true);
                }
                stageCounter += 1;
            }
            if (stageCounter == 2)
            {
                if ((intensitylevel.currentintensity > targetLethality2) && (sweatnesslevel.currentSweatness == targetAnger2))
                {
                    if (thicknesslevel.currentThickness > targetPower2)
                    {
                        Debug.Log("Superwin_2");
                        goodTaste.SetActive(true);
                    }
                    else
                    {
                        Debug.Log("Halfwin_2");
                        goodTaste.SetActive(true);
                    }
                }
                else
                {
                    Debug.Log("Lose_2");
                    badTaste.SetActive(true);
                }
                stageCounter += 1;
            }
            if (stageCounter == 1)
            {
                if (thicknesslevel.currentThickness > targetPower1)
                {
                    if (targetAnger1 < sweatnesslevel.currentSweatness)
                    {
                        //superwin
                        goodTaste.SetActive(true);
                        Debug.Log("Superwin_1");
                    }
                    else
                    {
                        goodTaste.SetActive(true);
                        Debug.Log("Halfwin_1");
                    }
                }
                else
                {
                    badTaste.SetActive(true);
                    Debug.Log("Lose_1");
                }
            stageCounter += 1;
            }
        }
    }
    resetbutton.resetpressed()
}
