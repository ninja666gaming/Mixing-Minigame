using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasdisapear : MonoBehaviour
{
    public GameObject canvas;
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
        canvas.SetActive(false);
    }

    public void addCanvas()
    {
        canvas.SetActive(true);
    }
}
