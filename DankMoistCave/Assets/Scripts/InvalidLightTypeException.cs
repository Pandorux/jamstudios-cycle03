using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvalidLightTypeException : System.Exception {

    public InvalidLightTypeException(string msg) :
        base(msg) { }

}
