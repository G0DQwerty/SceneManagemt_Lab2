using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{

    public Color TeamColor;
    public static MainManager Instance;

    private void Awake()
    {
        //Instance = this;
        //DontDestroyOnLoad(gameObject);

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
