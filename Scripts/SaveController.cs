using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveController : MonoBehaviour
{

    private List<Instruction> saveList = new List<Instruction>();
    public InstructionManager manager;
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void save()
    {
        float temp = 0;
        GameObject[] Items = GameObject.FindGameObjectsWithTag("Item");
        foreach (GameObject item in Items)
        {
            temp = GridRanking(item.transform.position);
            Instruction newIns = new Instruction(item.name,0,0,temp,item.transform.position.x,manager.getID(item.name));
            saveList.Add(newIns);
        }
        GameData.current.setInstructionList(saveList);
        SaveLoad.Save();
    }
    private float GridRanking(Vector3 pos)
    {
        return pos.x + 10000 * (10000+pos.y);
    }
}
