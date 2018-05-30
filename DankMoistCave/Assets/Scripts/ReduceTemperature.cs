using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReduceTemperature : MonoBehaviour {

    public float m_heatReduction;

    void OnTriggerStay2D(Collider2D c)
    {
        if (c.gameObject.tag == "Player")
        {
            c.gameObject
                .GetComponent<PlayerController>()
                .m_BodyTemperature
                .LowerTemp(m_heatReduction * Time.deltaTime);
        }
    }

}
