using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseButtons : MonoBehaviour
{

    public enum Menu
    {
        MainMenu,
    }

    public Menu currentMenu;

    void OnGUI()
    {

        GUILayout.BeginArea(new Rect(0, 0, 250, Screen.height));
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.BeginVertical();
        GUILayout.FlexibleSpace();

        if (currentMenu == Menu.MainMenu)
        {

            GUILayout.Space(10);

            if (GUILayout.Button("FLEX WRIST"))
            {
                
            }
            GUILayout.Space(10);
            if (GUILayout.Button("EXTEND WRIST"))
            {
                
            }
            GUILayout.Space(10);
            if (GUILayout.Button("ROLL WRIST OUT"))
            {
                
            }
            GUILayout.Space(10);
            if (GUILayout.Button("ROLL WRIST IN"))
            {
                
            }
            GUILayout.Space(10);
            if (GUILayout.Button("TILT WRIST LEFT"))
            {
                
            }
            GUILayout.Space(10);
            if (GUILayout.Button("TILT WRIST RIGHT"))
            {
                
            }
        }

        GUILayout.FlexibleSpace();
        GUILayout.EndVertical();
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
        GUILayout.EndArea();

    }
}
