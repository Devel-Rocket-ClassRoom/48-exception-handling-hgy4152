using System;
using System.Collections.Generic;
using System.Text;

class ItemNotFoundException : Exception
{
    public string ItemName;
    public ItemNotFoundException()
    {

    }

    public ItemNotFoundException(string message) : base(message)
    {
        
    }

    public ItemNotFoundException(string message, Exception innerException) : base(message, innerException)
    {

    }


    public ItemNotFoundException(string name, string message) : base (message)
    {
        ItemName = name;
    }

    public override string ToString()
    {
        return "인벤토리";
    }

}