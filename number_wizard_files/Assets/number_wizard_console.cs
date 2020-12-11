using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class number_wizard_console : MonoBehaviour
{
    int max = 1000;
    int min = 1;

    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
  
    }

    // Displays messages to initiate game sequence
    void StartGame()
    {
        Debug.Log("Welcome to Number Wizard :)");

        Debug.Log(string.Format("Pick a number between {0} and {1} (dont tell me the number yet!)", min, max));

        Debug.Log("Instructions: Up arrow = number is higher than guess, down arrow = number is lower than guess, enter = guess is correct");

        Debug.Log(string.Format("My initial guess is: {0}", guess));
    }

    // Updates computer guess based on min and max
    int UpdateGuess()
    {
        return (max + min) / 2;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Your number is higher!");

            min = guess;
            guess = UpdateGuess();

            Debug.Log(string.Format("My new guess is: {0}", guess));


        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Your number is lower!");

            max = guess;
            guess = UpdateGuess();

            Debug.Log(string.Format("My new guess is: {0}", guess));

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Correct number found. GG!");
        }

    }
}
