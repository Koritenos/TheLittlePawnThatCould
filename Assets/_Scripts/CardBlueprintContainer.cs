using UnityEngine;

[CreateAssetMenu(fileName = "Card Blueprint Container",menuName = "Card Blueprint Container")]
public class CardBlueprintContainer : ScriptableObject
{

    public string _cardName;
    public Sprite _cardSplash;
    public string _cardMovementClass;
    public string _cardActionClass;

}
