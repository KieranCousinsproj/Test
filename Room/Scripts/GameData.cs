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
    public void setInstructionList(List<string> item)
    {
        InstructionList.setInstructionList(item);
    }
    public List<string> getInstructionList()
    {
        return InstructionList.getInstructionList();
    }
}
