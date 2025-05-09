using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardPrefab : MonoBehaviour
{
    [SerializeField] public Image Border;
    [SerializeField] public Image CardFront;
    [SerializeField] public Image CardBack;
    [SerializeField] public TMP_Text CardName;
    [SerializeField] public TMP_Text Mana;
    [SerializeField] public TMP_Text Attack;
    [SerializeField] public TMP_Text Health;
    
    private bool isfront;
    public Item item;

    public void Setup(Item item, bool isFront)
    {
        this.item = item;
        this.isfront = isFront;

        if (this.isfront)
        {
            CardFront.enabled = true;
            CardBack.enabled = false;
            
            CardFront.sprite = item.sprite;
            CardName.text = item.name;
            Mana.text = item.mana.ToString();
            Health.text = item.health.ToString();
            Attack.text = item.attack.ToString();
        }
        else
        {
            CardFront.enabled = false;
            CardBack.enabled = true;
            
            Border.sprite = CardBack.sprite;
            CardName.text = "";
            Mana.text = "";
            Health.text = "";
            Attack.text = "";
        }
    }
}
