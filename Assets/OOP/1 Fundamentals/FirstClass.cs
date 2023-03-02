using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy
{
    // Properties
    // ... Some logic
    
    // Constructor
    // ... Some logic
    
    public abstract void Attack();

    public void Move()
    {
        // Move logic
    }
}

public class Troll : Enemy
{
    public override void Attack()
    {
        // Attack logic Troll
    }
}

public class Orc : Enemy
{
    public override void Attack()
    {
        // Attack logic Orc
    }
}

public class Dragon : Enemy
{
    public override void Attack()
    {
        // Attack logic Dragon
    }
}

public class Player
{
    // Properties
    private int health;
    
    // Constructor
    public Player(int health)
    {
        this.health = health;
    }

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

public interface Movable
{
    void MoveForward();
    void MoveBackward();
    void MoveLeft();
    void MoveRight();
    
}

public class Boat : Movable
{
    public void MoveForward()
    {
        // Move Forward
    }

    public void MoveBackward()
    {
        // Move Backward
    }

    public void MoveLeft()
    {
        // Move Left
    }

    public void MoveRight()
    {
        // Move Right
    }
}

public class Bike : Movable
{
    public void MoveForward()
    {
        // Move Forward
    }
    public void MoveLeft()
    {
        // Move Left
    }

    public void MoveRight()
    {
        // Move Right
    }
}

public class Car
{
    // ... Some logic
    public void Move()
    {
        // Move Forward
    }

    public void Move(Vector3 direction)
    {
        // Move in a direction
    }
    public void Move(Vector3 direction, float speed)
    {
        // Move in a direction with a speed
    }
}

public class Mario : Player
{
    private string powerUp;
    
    public Mario(int health, string powerUp) : base(health)
    {
        this.powerUp = powerUp;
    }
    
    public void Jump()
    {
        // FIRST LOGIC to jump
    }
}

public class Luigi : Player
{
    public void Jump()
    {
        // SECOND LOGIC to jump
    }
}

public class PlayerRPG
{
    // Properties
    private string name;
    private string classType;
    private int level;
    
    // Constructor
    public PlayerRPG()
    {
        this.name = "Default Name";
        this.classType = "Default Class";
        this.level = 1;
    }
    public PlayerRPG(string name)
    {
        this.name = name;
        this.classType = "Default Class";
        this.level = 1;
    }
    public PlayerRPG(string name, string classType)
    {
        this.name = name;
        this.classType = classType;
        this.level = 1;
    }
    public PlayerRPG(string name, string classType, int level)
    {
        this.name = name;
        this.classType = classType;
        this.level = level;
    }
    
    
    
    // Getters and Setters
    public void SetName(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return name;
    }
}

public class FirstClass : MonoBehaviour
{
    private void Start()
    {
        Player player = new Player(100, 0, 1, 10);
        Enemy enemy = new Enemy();
        Orc orc = new Orc();
        orc.Move();
        orc.Attack();
    }
}

























