using System;
using System.Collections.Generic;
using System.Text;

class Inventory
{
    private int maxCapacity;
    public List<string> items;

    public Inventory(int capacity) 
    { 
        maxCapacity = capacity;
        items = new List<string>();
    }

    public void Additem(string itemName)
    {

        if(items.Count == maxCapacity)
        {
            throw new InventoryFullException(maxCapacity, itemName, "인벤토리가 가득 찼습니다.");
        }

        items.Add(itemName);
        Console.WriteLine($"아이템 '{itemName}' 추가됨");
    }

    public void RemoveItem(string itemName)
    {
        if (items.Contains(itemName))
        {
            items.Remove(itemName);
            Console.WriteLine($"아이템 '{itemName}' 제거됨");

        }
        else
        {
            throw new ItemNotFoundException(itemName, "아이템을 찾을 수 없습니다.");
        }
    }


    public void ShowItems()
    {
        Console.WriteLine($"현재 인벤토리: {string.Join(",", items)}");
    }
}