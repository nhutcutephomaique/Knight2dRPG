using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int StartingHealth = 3;
    private int currentHealth;
    private void Start()
    {
        currentHealth = StartingHealth;

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log(currentHealth);
        DetecDeath();
    }

    public void DetecDeath()
    {
        if (currentHealth == 0)
        {
            Destroy(gameObject);
        }
    }


}
