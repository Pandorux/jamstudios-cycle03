using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPowered<T> {

    T GetCurrentVoltage();
    T GetMaxVoltage();
    void AddPower(T p);
    void RemovePower(T p);

}
