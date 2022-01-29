using UnityEngine;
[CreateAssetMenu(fileName = "Combined Card Container", menuName = "Combined Card Container Blueprint")]
public class CombinedCardBlueprintContainer : ScriptableObject
{
    public CardBlueprintContainer _whiteCard;
    public CardBlueprintContainer _blackCard;
}
