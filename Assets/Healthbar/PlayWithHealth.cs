using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWithHealth : MonoBehaviour
{
    public HealthBar health;

    int maxHealth = 20;
    int currenthealth;

    private void Start()
    {
        health.SetMaxHealth(maxHealth);
        currenthealth = maxHealth;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TakeDamage(2);
        }
    }
    public void TakeDamage(int dmg)
    {
        currenthealth -= dmg;
        health.SetHealth(currenthealth);
        Debug.Log(currenthealth);
    }
}
