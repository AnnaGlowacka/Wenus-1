using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nonstopaudio : MonoBehaviour
{
    
    void Awake()
    {
      DontDestroyOnLoad(transform.gameObject);  
    }

}
