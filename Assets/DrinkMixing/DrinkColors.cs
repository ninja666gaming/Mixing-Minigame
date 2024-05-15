using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkColors : MonoBehaviour
{
    public GameObject DrinkColor;
    private SpriteRenderer DrinkColorRenderer;
    bool IsActivated = false;
    Color InitialColor;
    // Start is called before the first frame update
    void Start()
    {
        DrinkColorRenderer = DrinkColor.GetComponent<SpriteRenderer>();
        InitialColor = new Color(DrinkColorRenderer.color.r, DrinkColorRenderer.color.g, DrinkColorRenderer.color.b, DrinkColorRenderer.color.a);
        DrinkColor.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void removeColor()
    {
        DrinkColorRenderer.color = new Color(InitialColor.r, InitialColor.g, InitialColor.b, InitialColor.a);
        IsActivated = false;
        DrinkColor.SetActive(false);
    }
    public void addcolor()
    {
        if (drinkpress.glasslimit > 3)
        { return; }
        else
        {
            DrinkColor.SetActive(true);
            if (IsActivated)
            {
                Color NewColor = DrinkColorRenderer.color;
                NewColor.a += 0.35f;
                DrinkColorRenderer.color = NewColor;
            }
            IsActivated = true;
        }
    }
}