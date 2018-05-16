using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITemperate<T> {

    T GetTemp();
    void RaiseTemp(T degrees);
    void LowerTemp(T degrees);

}
