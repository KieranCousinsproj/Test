using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{

    public string name;
    public List<string> InstructionList;

    public Item()
    {
        this.name = "";
        this.InstructionList = new List<string>();
    }
    public void setInstructionList(List<string> text)
    {
        InstructionList = text;
    }
    public List<string> getInstructionList()
    {
        return InstructionList;
    }
}
