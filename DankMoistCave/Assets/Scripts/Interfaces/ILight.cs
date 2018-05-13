using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILight {

    bool IsLightOn();
    LightType GetLightType();
    void SetLightType(LightType type);
    void SetLightIntensity(int str);
    int GetLightIntensity();
    void SetWarmth(int w);
    int GetWarmth();

}
