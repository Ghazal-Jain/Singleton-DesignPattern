using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMonobehavior : MonoBehaviour
{
    // Static field that holds ONE instance of class Singleton
    private static SingletonMonobehavior _instance;

    // OTHER VARIABLES

    // Instance property returns the instance of the SingletonMonobehavior Class
    // It adds it to a new GameObject called Singleton
    public static SingletonMonobehavior Instance
    {
        get
        {
            // Check to see if any instance exists, if not then one is created
            if (_instance == null)
            {
                GameObject newGameObject = new GameObject("Singleton");
                newGameObject.AddComponent<SingletonMonobehavior>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(gameObject);
    }


    // OTHER METHODS
}
