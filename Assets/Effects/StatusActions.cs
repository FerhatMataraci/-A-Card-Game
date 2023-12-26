using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusActions : MonoBehaviour
{
    private BurnEffect burnEffect;

    public StatusActions(BurnEffect burnEffect)
    {   
        this.burnEffect = burnEffect;
    }
    int turnCount;
   


    void StatusCheck(string StatusApplied){
        if(StatusApplied == "Burn"){
            burnEffect.Burning();
        }
        if(StatusApplied == "Stun"){
            StunEffect();
        }
    }

    void StunEffect(){

    }
}