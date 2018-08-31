using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
	int maxGuessesAllowed = 10; 
 	
 	public Text text;
 	
	void Start () {
		startGame();
	}
	
	void startGame(){
		max =  1000;  
		min  = 1;
		NextGuess();
	//	guess = 500;
	//	max++;
	}

	public void GuessLower(){
		max = guess;
		NextGuess(); 
	}	
	public void GuessHigher(){
		min = guess;
		NextGuess();
	}
	
	void NextGuess(){
		guess = Random.Range(min, max+1);
	//	guess = (min+max)/2;
		text.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed-1;
		if(maxGuessesAllowed<=0){
			Application.LoadLevel("win");
		}
	}
	
}


// Update is called once per frame
/*	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){ 
		//	print("Up arrow pressed"); 
			min = guess;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)){
		//	print("Down arrow pressed");
			max = guess;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.Return)){
			print("I Won!!");
			startGame();
		}
	}
*/










