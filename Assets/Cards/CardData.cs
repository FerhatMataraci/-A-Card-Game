using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "-A-Card-Game/Create Card", order = 1)]
public class CardData : ScriptableObject {
    public string cardName;
    public int cardCost;
    public CardElement cardElement;

    public void PlayCard
    {
   
    }

}
