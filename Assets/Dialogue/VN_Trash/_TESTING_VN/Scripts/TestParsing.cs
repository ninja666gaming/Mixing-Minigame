using DIALOGUE;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TESTING
{
    public class TestParsing : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            string line = "Speaker \"Dialogue Goes in Here\"";

            DialogueParser.Parse(line);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
