using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Card Deck Container", menuName = "Card Deck Blueprint Container")]
public class CardDeckContainer : ScriptableObject
{
    public List<CombinedCardBlueprintContainer> _Deck = new List<CombinedCardBlueprintContainer>();
}
