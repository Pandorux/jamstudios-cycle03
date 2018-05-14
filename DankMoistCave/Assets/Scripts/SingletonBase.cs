using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SingletonBase<T> : MonoBehaviour {

    /// <summary>
    /// Singleton
    /// </summary>
    public static T instance = default(T);

    protected virtual void Awake()
    {
        if (instance == null)
            instance = gameObject.GetComponent<T>();
        else
            Destroy(gameObject);
    }

}
