using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        function(1);
    }

    int function(int parameter)
    {
        parameter = parameter + 1;

        return parameter;
    }
}



