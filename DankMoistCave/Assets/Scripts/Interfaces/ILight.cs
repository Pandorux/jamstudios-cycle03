using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILight : IState<bool> {

    LightType GetLightType();
    void SetLightIntensity(int str);
    int GetLightIntensity();
    void SetWarmth(int w);
    int GetWarmth();
    
}
