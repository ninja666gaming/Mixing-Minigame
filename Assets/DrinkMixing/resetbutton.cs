using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetbutton : MonoBehaviour
{
    public intensitycounter intensityreset;
    public sweatnesscounter sweatnessreset;
    public thicknesscounter thicknessreset;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void resetpressed()
    {
        drinkpress.glasslimit = 0;
        intensityreset.currentintensity = 0;
        intensityreset.intensityText.text = "Lethality: " + intensityreset.currentintensity.ToString();
        thicknessreset.currentThickness = 0;
        thicknessreset.ThicknessText.text = "Power: " + thicknessreset.currentThickness.ToString();
        sweatnessreset.currentSweatness = 0;
        sweatnessreset.sweatnessText.text = "Anger: " + sweatnessreset.currentSweatness.ToString();
    }
}
