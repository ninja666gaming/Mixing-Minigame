using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasdisapear : MonoBehaviour
{
    public GameObject canvas;
    public GameObject CuthuluOrder;
    public GameObject BlackPlagueOrder;
    public GameObject GodzillaOrder;
    public GameObject HivemindOrder;
    public GameObject AIOrder;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            removeCanvas();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            addCanvas();
        }
    }

    public void removeCanvas()
    { 
        if (drinkpress.glasslimit < 3)
        { return; }
        else
        {
            CuthuluOrder.SetActive(false);
            BlackPlagueOrder.SetActive(false);
            GodzillaOrder.SetActive(false);
            HivemindOrder.SetActive(false);
            AIOrder.SetActive(false);
            canvas.SetActive(false);
        }
        
    }

    public void addCanvas()
    {
        canvas.SetActive(true);
        if (DrinkResults.stageCounter == 1)
        {
            CuthuluOrder.SetActive(true);
        }
        if (DrinkResults.stageCounter == 2)
        {
            BlackPlagueOrder.SetActive(true);
        }
        if (DrinkResults.stageCounter == 3)
        {
            GodzillaOrder.SetActive(true);
        }
        if (DrinkResults.stageCounter == 4)
        {
            HivemindOrder.SetActive(true);
        }
        if (DrinkResults.stageCounter == 5)
        {
            AIOrder.SetActive(true);
        }
    }
}
