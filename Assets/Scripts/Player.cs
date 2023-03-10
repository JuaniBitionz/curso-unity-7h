using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int _health;

    public int Health {
        get{
            return _health;
        }
        set {
            _health = value;
        } 
    }
    //por default las properties se crean con private
    private int _power;

    public int Power
    {
        get
        {
            return _power;
        }
        set
        {
            _power = value;
        }
    }

    private string _name;

    public string Name
    {
        get
        {
            return _name;
        }
        set { 
            _name = value;
        }
    }

    public Player(int health, int power, string name)
    {
        Health = health;
        Power = power;
        Name = name;
    }

    public Player(){ }

    public virtual void Attack()
    {
        Debug.Log(Name + " is attacking");
    }

    public void Info()
    {
        Debug.Log("Health is " + Health);
        Debug.Log("Power is " + Power);
        Debug.Log("Name is " + Name);
    }

    //public void SetHealth(int health)
    //{
    //    Health = health;
    //}

    //public int GetHealth()
    //{
    //    return this.health;
    //}
}
