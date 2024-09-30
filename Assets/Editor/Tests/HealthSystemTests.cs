using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class HealthSystemTests
{
    [Test]
    public void TakingDamageReducesHealth()
    {
        //Arrange: Create a health system with a starting health of 100
        HealthSystem healthSystem = new HealthSystem(100);


        //Act: Reduce the health by 30
        healthSystem.TakeDamage(30);


        //Assert: The health should now be 70
        Assert.AreEqual(70, healthSystem.currentHealth);
    }

    [Test]
    public void HealthCannotDropBelowZero()
    {
        //Arrange
        HealthSystem healthSystem = new HealthSystem(50);

        //Act
        healthSystem.TakeDamage(100);

        //Assert
        Assert.AreEqual(0, healthSystem.currentHealth);

    }

    [Test]
    public void HealingIncreasesHealth()
    {
        //Arrange
        HealthSystem healthSystem = new HealthSystem(50);

        //Act
        healthSystem.Heal(20);

        //Arrange
        Assert.AreEqual(70, healthSystem.currentHealth);
    }

    [Test]
    public void HealthCannotGoAboveMax()
    {
        HealthSystem healthSystem = new HealthSystem(100);

        healthSystem.Heal(100);

        Assert.AreEqual(healthSystem.maxHealth, healthSystem.currentHealth);
    }

}
