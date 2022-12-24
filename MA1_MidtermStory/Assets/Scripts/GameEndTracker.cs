using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEndTracker : MonoBehaviour{
	
	public Text endDisplaytext;

	private string end1 = "";
	private string end2a = "";
	private string end2b = "";
	private string end3a = "";	
	private string end3b = "";
	private string end3c = "";	
	private string end3d = "";
	private string end4a = "";	
	private string end4b = "";
	private string end4c = "";	
	private string endwin4a = "";	
	private string endwin4b = "";
	private string endwin4c = "";	

	public int endCount = 0;

    void Start(){
        EndDisplay();
    }

    void EndDisplay(){
		if (GameHandler.gotEnd_lose1a){end1 = "Bad End #1 "; endCount++;}
		if (GameHandler.gotEnd_lose2a){end2a = "Bad End #2 "; endCount++;}
		if (GameHandler.gotEnd_lose2b){end2b = "Bad End #3 "; endCount++;}
		if (GameHandler.gotEnd_lose3a){end3a = "Bad End #4 "; endCount++;}
		if (GameHandler.gotEnd_lose3b){end3b = "Bad End #5 "; endCount++;}
		if (GameHandler.gotEnd_lose3c){end3c = "Bad End #6 "; endCount++;}
		if (GameHandler.gotEnd_lose3d){end3d = "Bad End #7 "; endCount++;}
		if (GameHandler.gotEnd_lose4a){end4a = "Bad End #8 "; endCount++;}
		if (GameHandler.gotEnd_lose4b){end4b = "Bad End #9 "; endCount++;}
		if (GameHandler.gotEnd_lose4c){end4c = "Bad End #10 "; endCount++;}
		if (GameHandler.gotEnd_win4a){endwin4a = "Good End #1 "; endCount++;}
		if (GameHandler.gotEnd_win4b){endwin4b = "Good End #2 "; endCount++;}
		if (GameHandler.gotEnd_win4c){endwin4c = "Good End #3 "; endCount++;}
		
		Text endTextTemp = endDisplaytext;
		if (endCount >= 13){
			endTextTemp.text = "YOU FOUND ALL THIRTEEN ENDINGS! \n Your dedication to pigeon love is worthy of praise.";
		} else {
			endTextTemp.text = "YOU FOUND THESE ENDINGS! (" + endCount + "/13): \n" 
				+ end1
				+ end2a 
				+ end2b 
				+ end3a 
				+ end3b 
				+ end3c 		
				+ end3d 
				+ end4a 
				+ end4b 
				+ end4c
				+ endwin4a 
				+ endwin4b 
				+ endwin4c;
		}
    }
	
	
}
