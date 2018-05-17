using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITemperate<T> {

    T GetCurrentTemp();
    T GetNormalTemp();
    void RaiseTemp(T degrees);
    void LowerTemp(T degrees);

}
