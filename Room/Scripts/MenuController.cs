using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [Header("Available Instruction sets")]
    public string _newInstructionSet;
    private string instructionToLoad;
    private string selectedInstruction;
    [SerializeField] private GameObject noInstructionsDialog = null;

    public void setActive(string element)
    {
        selectedInstruction = element;
    }

    public void NewInstructionDialogYes()
    {
        SceneManager.LoadScene(_newInstructionSet);
    }
    public void LoadInstructionDialogYes()
    {
        if (PlayerPrefs.HasKey("SavedInstruction"))
        {
            instructionToLoad = PlayerPrefs.GetString("SavedInstruction");
            SceneManager.LoadScene(instructionToLoad);
        }
        else
        {
            noInstructionsDialog.SetActive(true);
        }
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
