using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivideAndConquerManager : MonoBehaviour {

    int Min;
    int Max;
    int Guess;

	// Use this for initialization
	void Start () {
        Min = 1;
        Max = 1000;
        Guess = 500;

        StartGame();
	}
	
	// Update is called once per frame
	void Update () {
        RunnigGame();
	}

    void StartGame()
    {
        print("welcome to divide and conquer game :)");
        print("Pick a new number in you mind. let see how good are hiding numbers");
        print("the higthes number you can pick is" + Max);
        print("the lower number you can pick is" + Min);
        print("Is the number > or < that" + Guess);
        print("Up arrow = >, Down arrow = <, Enter = equal");

    }

    void RunnigGame(){

        if(Input.GetKeyDown(KeyCode.UpArrow)){
            print("Arrow UP");
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            print("Arrow DOWN");

        }
        else if(Input.GetKeyDown(KeyCode.Return)){
            print("ENTER");

        }
    }
}
