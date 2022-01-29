using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Card Deck Container", menuName = "Card Deck Blueprint Container")]
public class CardDeckContainer : ScriptableObject
{
    [Header("Deck Settings")]
    public string _deckName;
    public Sprite _deckBacksideSprite;
    public Color _deckBacksideColor;
    [Header("Deck Elements")]
    public List<CombinedCardBlueprintContainer> _Deck = new List<CombinedCardBlueprintContainer>();
}
