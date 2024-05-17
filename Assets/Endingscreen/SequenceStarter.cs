using Course.PrototypeScripting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceStarter : MonoBehaviour
{
    [SerializeField] Sequence seq;

    // Start is called before the first frame update
    void Start()
    {
        seq.ExecuteCompleteSequence(); 
    }
}
