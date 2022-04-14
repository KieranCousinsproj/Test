using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InstructionController : MonoBehaviour
{
    private List<string> TextList = new List<string>();
    public Text instructionText;
    public void buttonUpPressed()
    {
        TextList.Add("UP");
    }
    public void buttonDownPressed()
    {
        TextList.Add("DOWN");
    }
    public void buttonLeftPressed()
    {
        TextList.Add("LEFT");
    }
    public void buttonRightPressed()
    {
        TextList.Add("RIGHT");
    }
    public void buttonSpacePressed()
    {
        TextList.Add("SPACE");
    }
    private string getInstructionList()
    {
        string val  = string.Join(", ", TextList.ToArray());
        return val;
    }
    // Start is called before the first frame update
    void Start()
    {
        TextList = GameData.current.getInstructionList();
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("OfflineScene");

    }
    // Update is called once per frame
    void Update()
    {
        instructionText.text = getInstructionList();
    }
    private void save()
    {
        List<string> newList = new List<string>();
        foreach (string ele in TextList)
        {
            newList.Add(ele);
        }
        GameData.current.setInstructionList(newList);
        SaveLoad.Save();
    }
}
