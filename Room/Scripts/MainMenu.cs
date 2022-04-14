using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{

    public enum Menu
    {
        MainMenu,
        NewGame,
        Continue
    }

    public Menu currentMenu;

    void OnGUI()
    {

        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.BeginVertical();
        GUILayout.FlexibleSpace();

        if (currentMenu == Menu.MainMenu)
        {

            GUILayout.Box("Last Fantasy");
            GUILayout.Space(10);

            if (GUILayout.Button("New Game"))
            {
                GameData.current = new GameData();
                currentMenu = Menu.NewGame;
            }

            if (GUILayout.Button("Continue"))
            {
                SaveLoad.Load();
                currentMenu = Menu.Continue;
            }

            if (GUILayout.Button("Quit"))
            {
                Application.Quit();
            }
        }

        else if (currentMenu == Menu.NewGame)
        {

            GUILayout.Box("Name Your List");
            GUILayout.Space(10);

            GUILayout.Label("InstructionList");
            GameData.current.InstructionList.name = GUILayout.TextField(GameData.current.InstructionList.name, 20);


            if (GUILayout.Button("Save"))
            {
                //Save the current Game as a new saved Game
                SaveLoad.Save();
                //Move on to game...
                Application.LoadLevel(1);
            }

            GUILayout.Space(10);
            if (GUILayout.Button("Cancel"))
            {
                currentMenu = Menu.MainMenu;
            }

        }

        else if (currentMenu == Menu.Continue)
        {

            GUILayout.Box("Select Save File");
            GUILayout.Space(10);

            foreach (GameData g in SaveLoad.InstructionList)
            {
                if (GUILayout.Button(g.InstructionList.name))
                {
                    GameData.current = g;
                    //Move on to game...
                    Application.LoadLevel(1);
                }

            }

            GUILayout.Space(10);
            if (GUILayout.Button("Cancel"))
            {
                currentMenu = Menu.MainMenu;
            }

        }

        GUILayout.FlexibleSpace();
        GUILayout.EndVertical();
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
        GUILayout.EndArea();

    }
}
