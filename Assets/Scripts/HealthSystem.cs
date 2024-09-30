using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HealthSystem
{
    public int currentHealth {  get; private set; }
    public int maxHealth;

    public HealthSystem(int startingHealth)
    {
        currentHealth = startingHealth;
        maxHealth = 100;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if(currentHealth < 0)
        {
            currentHealth = 0;
        }
    }

    public void Heal(int heal)
    {
        currentHealth += heal;
        if(currentHealth > maxHealth) 
        {
            currentHealth = maxHealth;
        }
    }
}
