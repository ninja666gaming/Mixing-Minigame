using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drinkpress : MonoBehaviour
{
    public int value1;
    public int value2;
    public int value3;
    public static int glasslimit = 0;
    // Start is called before the first frame update
    void Start()
    {
        // sweatnesscounter.instance.IncreaseSweatness(value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseCounters()
    {
        if (glasslimit > 3)
        {
            return;
        }
        sweatnesscounter.instance.IncreaseSweatness(value1);
        thicknesscounter.instance.IncreaseThickness(value2);
        intensitycounter.instance.Increaseintensity(value3);
        glasslimit += 1;
       
    }
}
