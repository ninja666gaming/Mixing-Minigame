using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIALOGUE
{
    public class DialogueParser
    {
        public static DIALOGUE_LINE Parse(string rawline)
        {
            Debug.Log($"Parsing line - '{rawline}'");

            (string speaker, string dialogue, string commands) = RipContent(rawline);

            return new DIALOGUE_LINE(speaker, dialogue, commands);

        }

        private static (string, string, string) RipContent(string rawline)
        {
            string speaker = "", dialogue = "", commands = "";

            int dialogueStart = -1;
            int dialogueEnd = -1;
            bool isEscaped = false;

            for (int i = 0; i < rawline.Length; i++)
            {
                char current = rawline[i];
                if (current == '\\')
                    isEscaped = !isEscaped;
                else if (current == '"' && !isEscaped)
                {
                    if (dialogueStart == -1)
                        dialogueStart = i;
                    else if (dialogueEnd == -1)
                        dialogueEnd = i;
                }
                else
                    isEscaped = false;
            }

            Debug.Log(rawline.Substring(dialogueStart + 1, dialogueEnd - dialogueStart));

            return (speaker, dialogue, commands);
        }
    }
}
