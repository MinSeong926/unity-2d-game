// PerformanceItemSO.cs
using UnityEngine;

[CreateAssetMenu(menuName = "Shop/PerformanceItem")]
public class PerformanceItemSO : ScriptableObject
{
    public Sprite image;
    public PerformanceCategorySO category;
    public int price;
    public float speed;
    public float efficiency;
    public float capacity;

    public string itemNameKR;
    public string itemNameEN;

    [TextArea] public string descriptionKR;
    [TextArea] public string descriptionEN;

    public string DisplayName =>
        LocalizationManager.Instance.currentLanguage == Language.Korean ? itemNameKR : itemNameEN;

    public string DisplayDescription =>
        LocalizationManager.Instance.currentLanguage == Language.Korean ? descriptionKR : descriptionEN;

}