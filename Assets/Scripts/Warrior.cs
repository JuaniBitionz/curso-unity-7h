using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Warrior : Player
{
    public Warrior(int health, int power, string name){
        Health = health;
        Power = power;
        Name = name;
    }

    public override void Attack() {
        //sobrecargar funcion de la clase padre -> virtual ===> override
    }

    public void ThrowAxe()
    {
        Debug.Log("Axe thrown");
    }
}
