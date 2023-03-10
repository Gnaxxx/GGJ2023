using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public GameObject[] enemies; 
    private float currentHealth = 0.0f;
    private float maxHealth = 100.0f;
    public GameObject HealthBar;
    // Start is called before the first frame update
    
    
    public void takeDamage(float dmg)
    {
        currentHealth -= dmg;
        HealthBar.transform.localScale = new Vector3(0.01f * currentHealth, 1.0f, 1.0f);
    }

    void Start()
    {
        currentHealth = maxHealth;
        HealthBar.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
    //

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0.0f)
        {
            SceneManager.LoadScene("GameOverScreen");
        }
        Debug.Log(currentHealth);
    }
}
