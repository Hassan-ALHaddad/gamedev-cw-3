using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    int level;

 
    
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("Hello Hacker");
        
    }

    void ShowMainMenu(string greeting)
    {
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("What would you like, to hack into? ");
        Terminal.WriteLine("Press 1 for coded");
        Terminal.WriteLine("Press 2 for airport");
        Terminal.WriteLine("Enter your selection: ");

    }

    void OnUserInput(string input)
    {
        SetLevel(input);
    }

    void SetLevel(string selectedLevel)
    {
        if (selectedLevel == "1")
        {
            level = 1;
            Terminal.WriteLine("You have chosen level " + level);
        }

        else if (selectedLevel == "2")
        {
            level = 2;
            Terminal.WriteLine("You have chosen level " + level);
        }
        else
        {
            Terminal.WriteLine("Seriously? I said press 1 or 2 :)");
        }

    }

}


