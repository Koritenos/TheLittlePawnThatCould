using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

[CreateAssetMenu(fileName = "Card Blueprint Container", menuName = "Card Blueprint Container")]
public class CardBlueprintContainer : ScriptableObject
{
    [Header("Card Settings")]
    public bool _hasSpecialAbility = false;
    public bool _hasMovementAbility = false;

    [Header("Card Interface Data")]
    public string _cardName;
    public string _cardMovementDescription;
    public string _cardActionDescription;

    [Header("Card Graphics Settings")]
    public Sprite _cardSplash;
    public Color _cardColor;

    [Header("Card Abilities")]
    public string _cardMovementClass;
    public string _cardActionClass;

}

[CustomEditor(typeof(CardBlueprintContainer))]
public class CardBlueprintContainerEditor : UnityEditor.Editor
{
    public override void OnInspectorGUI()
    {
        var _cardBlueprintScript = target as CardBlueprintContainer;
        EditorGUILayout.LabelField("Card Settings");
        EditorGUILayout.Space();
        EditorGUILayout.BeginVertical();
        _cardBlueprintScript._cardName = EditorGUILayout.TextField("Card Name", _cardBlueprintScript._cardName);
        _cardBlueprintScript._cardColor = EditorGUILayout.ColorField("Card Color", _cardBlueprintScript._cardColor);
        _cardBlueprintScript._cardSplash = (Sprite)EditorGUILayout.ObjectField("Sprite", _cardBlueprintScript._cardSplash, typeof(Sprite), false, GUILayout.Height(EditorGUIUtility.singleLineHeight));
        EditorGUILayout.EndVertical();

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("Card Abilities");
        EditorGUILayout.Space();
        EditorGUILayout.BeginVertical();
        _cardBlueprintScript._hasMovementAbility = EditorGUILayout.ToggleLeft("Movement Ability", _cardBlueprintScript._hasMovementAbility);
        if (_cardBlueprintScript._hasMovementAbility)
        {
            _cardBlueprintScript._cardMovementClass = EditorGUILayout.TextField("Card Movement Class:", _cardBlueprintScript._cardMovementClass);
            _cardBlueprintScript._cardMovementDescription = EditorGUILayout.TextField("Card Movement Description:", _cardBlueprintScript._cardMovementDescription);
        }

        _cardBlueprintScript._hasSpecialAbility = EditorGUILayout.ToggleLeft("Special Ability", _cardBlueprintScript._hasSpecialAbility);
        if (_cardBlueprintScript._hasSpecialAbility)
        {
            _cardBlueprintScript._cardActionClass = EditorGUILayout.TextField("Card Special Ability Class:", _cardBlueprintScript._cardActionClass);
            _cardBlueprintScript._cardActionDescription = EditorGUILayout.TextField("Card Special Ability Description:", _cardBlueprintScript._cardActionDescription);
        }
        EditorGUILayout.EndVertical();
    }

}
