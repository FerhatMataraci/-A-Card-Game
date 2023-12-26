using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnEffect : Effect
{   private Player player;

    public BurnEffect(Player player)
    {
        this.player = player;
        effectCount = 0;

    }
    

      public void Burning(){
        
        if (effectCount > 0 && effectCount <3){ 
            effectPower = "DemonFire";
            player.TakeDamage(2);
        }
        else if(effectCount >= 3 && effectCount<7){
            effectPower = "HellFire";
            player.TakeDamage(5);
        }
        else if(effectCount >= 10){
            effectPower = "DarkFire";
            player.TakeDamage(effectCount);
        }
}
}
