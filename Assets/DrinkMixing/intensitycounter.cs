using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class intensitycounter : MonoBehaviour
{
    public static intensitycounter instance;

    public TMP_Text intensityText;
    public int currentintensity = 0;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        intensityText.text = currentintensity.ToString();
    }

    public void Increaseintensity(int v)
    {
        currentintensity += v;
        intensityText.text = currentintensity.ToString();
    }
}