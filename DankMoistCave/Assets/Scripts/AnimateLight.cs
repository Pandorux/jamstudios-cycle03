using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateLight : MonoBehaviour {

    public Light light;
    public AnimationCurve anim;
    public float minInten;
    public float MaxInten;
    public float diff;

    CurvePlayer test;

    void Start()
    {
        diff = MaxInten - minInten;
        test = CurvePlayer.ReadyToPlayCurve(anim);
        test.Play(true);
    }

    void Update()
    {
        light.intensity = minInten + (diff * test.Evaluate(test.time));
    }
}
