using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sweatnesscounter : MonoBehaviour
{
    public static sweatnesscounter instance;

    public TMP_Text sweatnessText;
    public int currentSweatness = 0;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        sweatnessText.text = currentSweatness.ToString();
    }

    public void IncreaseSweatness(int v)
    {
        currentSweatness += v;
        sweatnessText.text = currentSweatness.ToString();
    }
}