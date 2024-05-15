using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DIALOGUE;

namespace TESTING
{
    public class TestingA : MonoBehaviour
    {
        DialogueSystem ds;
        TextArchitect architect;

        public TextArchitect.BuildMethod bm = TextArchitect.BuildMethod.fade;


        // Start is called before the first frame update
        void Start()
        {
            ds = DialogueSystem.instance;
            architect = new TextArchitect(ds.dialogueContainer.dialogueText);
            architect.buildMethod = TextArchitect.BuildMethod.fade;
            architect.speed = 0.5f;
        }

        // Update is called once per frame
        void Update()
        {
            if (bm != architect.buildMethod)
            {
                architect.buildMethod = bm;
                architect.Stop();
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                architect.Stop();
            }

            string longLine = "this is a very long line thats makes no sense: asjdaskj ajksdhasjdhjasjdaj asjhdhaskfhlsdk adsfs sdf asdfsdf sadfasdf asdfsdf dfdfghtrurddf sdfg fhzrju fgtzuit rgeassdfer rwgqergfdgsdfdgd fdgsfgsrg dfgshtrrtsfdger dsrtztzdgfhtzh fgjhstssgfhzj jrz htrh";
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (architect.isBuilding)
                {
                    if (!architect.hurryUp)
                        architect.hurryUp = true;
                    else
                        architect.ForceComplete();
                }
                else
                    architect.Build(longLine);
                //architect.Build(lines[Random.Range(0, lines.Length)]);
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                architect.Append(longLine);
                //architect.Append(lines[Random.Range(0, lines.Length)]);
            }
        }
    }
}
