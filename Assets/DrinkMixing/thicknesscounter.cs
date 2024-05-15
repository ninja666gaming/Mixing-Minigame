using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class thicknesscounter : MonoBehaviour
{
    public static thicknesscounter instance;

    public TMP_Text ThicknessText;
    public int currentThickness = 0;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        ThicknessText.text = "Power: " + currentThickness.ToString();
    }

    public void IncreaseThickness(int v)
    {
        currentThickness += v;
        ThicknessText.text = "Power: " + currentThickness.ToString();
    }
}