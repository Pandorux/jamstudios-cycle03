using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILight : IState<bool> {

    LightType GetLightType();
    void SetLightIntensity(float str);
    float GetLightIntensity();
    void SetWarmth(float w);
    float GetWarmth();
    void TurnOn();
    void TurnOff();
    
}
