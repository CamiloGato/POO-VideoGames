using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    // Properties
    private int health;
    private int experience;
    private int level;
    private int speed;
    
    // Getters and Setters
    public void SetHealth(int health)
    {
        this.health = health;
    }
    public int GetHealth()
    {
        //... some logic
        return health;
    }
    
}

public class FirstClass : MonoBehaviour
{
    private void Start()
    {
        Player player = new Player();
    }
}
