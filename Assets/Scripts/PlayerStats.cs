using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public GameObject[] enemies; 
    private float currentHealth = 0.0f;
    private float maxHealth = 100.0f;
    // Start is called before the first frame update
    
    
    void takeDamage()
    {

    }

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
