using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public static GameData current;
    public Item InstructionList;

    public GameData()
    {
        InstructionList = new Item();
    }
    public void setInstructionList(List<Instruction> item)
    {
        InstructionList.setInstructionList(item);
    }
    public List<Instruction> getInstructionList()
    {
        return InstructionList.getInstructionList();
    }
}

