using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkResults : MonoBehaviour
{
    public int targetIntensity;
    public int targetThickness;
    public int targetSweatness;
    public intensitycounter intensitylevel;
    public sweatnesscounter sweatnesslevel;
    public thicknesscounter thicknesslevel;

    public int benchmark = 0;

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
        if ((intensitylevel.currentintensity == targetIntensity) && (sweatnesslevel.currentSweatness == targetSweatness) && (thicknesslevel.currentThickness == targetThickness))
        {

        }
        else
        {

        }
    }
}
