using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroyObject : MonoBehaviour
{
    public static DoNotDestroyObject Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Optional
            gameObject.SetActive(false);
        }
        else 
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
