using UnityEngine;

[System.Serializable]
public class Item
{
    public string name;
    public int attack;
    public int health;
    public Sprite sprite;
    public int mana;
}
[CreateAssetMenu(fileName = "ItemSO", menuName = "ScriptableObjects/ItemSO")]
public class ItemSO : ScriptableObject
{
    public Item[] items;
}
