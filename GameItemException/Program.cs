using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.



Inventory inventory = new Inventory(3);


Console.WriteLine("=== 인벤토리 테스트 ===");
Add("검");
Add("포션");
Add("방패");
Add("활");



void Add(string itemName)
{
    try
    {
        inventory.Additem(itemName);
    }
    catch(InventoryFullException e)
    {
        Console.WriteLine($"[{e} 오류] {e.Message} (용량: {e.Capacity}, 아이템: {e.ItemName})");
    }
}

inventory.ShowItems();

Remove("포션");
Remove("도끼");

void Remove(string itemName)
{
    try
    {
        inventory.RemoveItem(itemName);
    }
    catch (ItemNotFoundException e)
    {
        Console.WriteLine($"[{e} 오류] {e.Message} (아이템: {e.ItemName})");
    }
}

inventory.ShowItems();
