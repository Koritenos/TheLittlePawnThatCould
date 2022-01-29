using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

[CreateAssetMenu(fileName = "Card Blueprint Container", menuName = "Card Blueprint Container")]
public class CardBlueprintContainer : ScriptableObject
{

    [Header("Card Interface Data")]
    public string _cardName;
    public Sprite _cardSplash;
    public Color _cardColor;

    [Header("Card Abilities")]
    public bool _hasMovementAbility = false;
    public string _cardMovementClass;
    public string _cardMovementDescription;

    public bool _hasSpecialAbility = false;
    public string _cardActionClass;
    public string _cardActionDescription;

}
