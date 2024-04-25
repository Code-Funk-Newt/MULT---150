using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GoalScript blue, green, red, orange;
	public ChaosGoal chaos;
	private bool isGameOver = true;	
	private bool chaosFailure = true;
	private float time = 0;




	void Update ()
	{
		
		// If all four goals are solved then the game is over
		isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;	

		chaosFailure = chaos.chaosWins;

		if(isGameOver == false){
		time += Time.deltaTime;	

		

		}
	}

	void OnGUI()
	{

		if(chaosFailure){
			Rect rect = new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
			GUI.Box (rect, "YOU HAVE LOST! \n Chaos balls scored the goal\n before you.");

		}



		if(isGameOver) {
			
			if(chaosFailure  && isGameOver){
				chaosFailure = true;
				Rect rect = new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
				GUI.Box (rect, "Game Over:");

				Rect rect2 = new Rect (Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
				GUI.Label (rect2, "Chaos Balls Win . . . ");

				Rect rect3 = new Rect(Screen.width / 2 - 65, 220, 130, 40);
				GUI.Box(rect3, "Your Time Was:  " + ((int)time).ToString());

				
			}
			else{
			Rect rect = new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
			GUI.Box (rect, "Game Over:");

			Rect rect2 = new Rect (Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
			GUI.Label (rect2, "Good Job!");

			Rect rect3 = new Rect(Screen.width / 2 - 65, 100, 130, 40);
			GUI.Box(rect3, "Your Time Was:  " + ((int)time).ToString());

			}

		}
	}
}