using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string name;
    public List<Instruction> InstructionList;

    public Item()
    {
        this.name = "";
        this.InstructionList = new List<Instruction>();
    }
    public void setInstructionList(List<Instruction> itemList)
    {
        InstructionList = itemList;
    }
    public List<Instruction> getInstructionList()
    {
        return InstructionList;
    }
}
