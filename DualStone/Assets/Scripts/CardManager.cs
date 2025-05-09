using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public ItemSO itemData;
    
    public GameObject cardPrefab;
    
    public Transform handZone;
    
    private Stack<Item> deck = new Stack<Item>();

    void Start()
    {
        InitializeDeck();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DrawCard();
        }
    }

    public void InitializeDeck()
    {
        List<Item> tempList = new List<Item>();

        foreach (var item in itemData.items)
        {
            tempList.Add(item);
            tempList.Add(item);
        }
        
        Shuffle(tempList);
        
        deck.Clear();
        foreach (var item in tempList)
        {
            deck.Push(item);
        }
    }

    public void DrawCard()
    {
        if (deck.Count == 0) return;
        
        Item item = deck.Pop();
        GameObject card = Instantiate(cardPrefab, handZone.position, Quaternion.identity, handZone);
        card.GetComponent<CardPrefab>().Setup(item, true);
    }
    
    private void Shuffle(List<Item> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int rand = Random.Range(i, list.Count);
            (list[i], list[rand]) = (list[rand], list[i]);
        }
    }
}
