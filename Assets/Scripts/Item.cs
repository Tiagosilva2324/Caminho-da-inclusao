using UnityEngine;

public enum SlotTag {None}

[CreateAssetMenu(menuName = "CI/item")]
public class Item : ScriptableObject
{
    public Sprite sprite;
    public SlotTag itemTag;
}
