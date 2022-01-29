using UnityEngine;
[CreateAssetMenu(fileName = "Combined Card Container", menuName = "Combined Card Container Blueprint")]
public class CombinedCardBlueprintContainer : ScriptableObject
{
    [Header("White Side Settings")]
    public CardBlueprintContainer _whiteCard;
    public Sprite _whiteCardBackgroundSprite;
    public Color _whiteCardBackgroundColor = Color.white;

    [Header("Black Side Settings")]
    public CardBlueprintContainer _blackCard;
    public Sprite _blackCardBackgroundSprite;
    public Color _blackCardBackgroundColor;
}
