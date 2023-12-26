using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour,IDamageable
{
    int PlayerHP;
    int PlayerEnergy;
    int Luck;
    int AttPower;
    int Defense;
    int Regen;

    public void TakeDamage(int dmgAmount){
        PlayerHP -= dmgAmount;
    }

 


    void PoisonEffect(string PoisonType){

    }
    void ArmorBrokenEffect(){
        
    }


}
