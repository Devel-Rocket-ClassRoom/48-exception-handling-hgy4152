using System;
using System.Collections.Generic;
using System.Text;

class InventoryFullException : Exception
{
    public int Capacity;
    public string ItemName;

    public InventoryFullException()
    {

    }

    public InventoryFullException(string message) : base(message)
    {

    }

    public InventoryFullException(string message, Exception innerException) : base(message, innerException)
    {

    }

    public InventoryFullException(int capacity, string itemName, string message) : base(message) 
    {
        Capacity = capacity;
        ItemName = itemName;
    }

    public override string ToString()
    {
        return "인벤토리";
    }

}