using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCapacityExceededException : System.Exception {

    public InventoryCapacityExceededException(string msg) :
        base(msg) { }

}
