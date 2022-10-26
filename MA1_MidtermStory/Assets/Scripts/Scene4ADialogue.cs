using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4aDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
		public Text Char4name;
        public Text Char4speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;   //Ohzi - player
		public GameObject ArtChar1b;
        public GameObject ArtChar2;   //pigeon
		public GameObject ArtChar2b;
        public GameObject ArtChar3;   //moosh
		public GameObject ArtChar3b;
		public GameObject ArtChar4;   //Priest RA
		public GameObject ArtChar4b;   //panic/caugh
		public GameObject ArtChar4c;   //excitement
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar2.SetActive(false);
		ArtChar2b.SetActive(false);
        ArtChar3.SetActive(false);
        ArtChar3b.SetActive(false);
        ArtChar4.SetActive(false);
        ArtChar4b.SetActive(false);
		ArtChar4c.SetActive(false);
		
		ArtBG1.SetActive(true);
		
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        //NextScene3Button.SetActive(false);
        nextButton.SetActive(true);
   }
    
void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                }
        }
   }

//Story Units:
public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Ten 	Years 	 Later";
        }
       else if (primeInt ==3){
                Char1name.text = "???";
                Char1speech.text = "…weird";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 4){
                Char1name.text = "Ohzi";
                Char1speech.text = "I felt like I was back in college again for a second..";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		 else if (primeInt == 5){
			 ArtChar1.SetActive(true);
                Char1name.text = "Ohzi";
                Char1speech.text = "I must be nervous.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 6){
		   ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Moosh";
                Char3speech.text = "You’re gonna be fine!";
				// Turn off "Next" button, turn on "Choice" buttons
                 nextButton.SetActive(false);
                 allowSpace = false;
                 Choice1a.SetActive(true); // function Choice1aFunct()
                 Choice1b.SetActive(true); // function Choice1bFunct()
        }
       else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Moosh";
                Char3speech.text = "But remember when you introduced us?";
        }
		 else if (primeInt == 8){
                Char1name.text = "Ohzi";
                Char1speech.text = "That was 10 years ago & you did’nt even like them at first!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		 else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Moosh";
                Char3speech.text = "Your point? They grew on me and everyone \n else will grow to love them too.";
        }
       else if (primeInt == 10){
                Char1name.text = "Ohzi";
                Char1speech.text = "That's not the point.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Moosh";
                Char3speech.text = " And?– shh! Here they come!";
        }
        else if (primeInt == 12){
				ArtChar2.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Pigeon";
                 Char2speech.text = "*Starts waddling down the aisle.*";
				 Char3name.text = "";
                Char3speech.text = "";
		}
        else if (primeInt == 13) {
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "Moosh";
                Char3speech.text = "See? You were worried for nothing.";
		}
        else if (primeInt == 14){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Pigeon";
                 Char2speech.text = "*Sits in the middle of the aisle.*";
				 Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt == 15){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "Oh no…";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt == 16){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "Moosh";
                Char3speech.text = "What are they doing?";
		}
		else if (primeInt ==17){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "Please DONT-";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt == 18){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Pigeon";
                 Char2speech.text = "*Squats and puffs up* Coo";
				 Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt == 19){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "Don’t You Dare.";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt == 20){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Pigeon";
                 Char2speech.text = "*Casually poops in the middle of the isle only to \n spite you before waddling down the aisle once more*";
				 Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt == 21){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "*Sigh* (Can I do this?)";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                 Char3speech.text = "";
				 Char4name.text = "";
                 Char4speech.text = "";
		}
		else if (primeInt == 22){
			ArtChar3.SetActive(false);
			ArtChar4.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
				 Char3speech.text = "";
				 Char4name.text = "RA";
                 Char4speech.text = "…";
		}
		else if (primeInt == 23){
                 Char1name.text = "Ohzi";
                 Char1speech.text = " Oh perfect timing! (At least no one else seemed to notice)";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                 Char3speech.text = "";
				 Char4name.text = "";
                 Char4speech.text = "";
        }

         else if (primeInt == 24){
			ArtChar4.SetActive(false);
			ArtChar4b.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
				  Char3name.text = "";
                  Char3speech.text = "";
				  Char4name.text = "RA";
                  Char4speech.text = "Uheem…Will you Ohzi..\n Kh…mm-khoff khak khak! \n Oh LORD just give me a minute.";
          }
          else if (primeInt == 25){
			ArtChar4b.SetActive(false);
			ArtChar4c.SetActive(true);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
				   Char4name.text = "RA";
                   Char4speech.text = "AHEM! Sorry where were we? OH RIGHT!";
           }
          else if (primeInt == 26){
            ArtChar3.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Pigeon";
                  Char2speech.text = "*Blinks.*";
                  Char3name.text = "";
                  Char3speech.text = "";
				  Char4name.text = "";
                  Char4speech.text = "";
            }

            else if (primeInt == 27){
                     Char1name.text = "";
                     Char1speech.text = "";
                     Char2name.text = "";
                     Char2speech.text = "";
					 Char3name.text = "";
					 Char3speech.text = "";
                     Char4name.text = "RA";
                     Char4speech.text = "Will you Ohzi take Pigeon to be your lawfully wedded..wife??";
					  // Turn off "Next" button, turn on "Choice" buttons
                             nextButton.SetActive(false);
                             allowSpace = false;
                             NextScene1Button.SetActive(true);
                             NextScene2Button.SetActive(true);
             }

// ENCOUNTER AFTER CHOICE #1
		
		else if (primeInt == 100){
			Char1name.text = "Ohzi";
			Char1speech.text = "I feel bad now. You should have let me fail, I didn’t want to cheat!";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 101){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Pigeon";
			Char2speech.text = "*Grunts*";
			
		}
		else if (primeInt == 102){
			Char1name.text = "Ohzi";
			Char1speech.text = "I know, I know, you were just trying to help. *Sigh*";
			Char2name.text = "";
			Char2speech.text = "";
			primeInt = 6;
        }


// ENCOUNTER AFTER CHOICE #2
       else if (primeInt == 200){
                Char1name.text = "Ohzi";
                Char1speech.text = "But Moosh you don't understand NOBODY will \n accept us as we are once they all realize-";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Moosh";
				Char3speech.text = "Oh come on Ohzi we have been friends for 10 almost \n 11 years now, you KNOW there's nothing I wouldn’t accept, \n if you have anything you need to tell me-";
        }
		 else if (primeInt == 202){
                Char1name.text = "Ohzi";
                Char1speech.text = "OH NO NO NO you’re misunderstanding \n it’s not like THAT! It's…It's Different.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
        }
		 else if (primeInt == 203){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Moosh";
				Char3speech.text = "... Different how? I dont think there's anything else \n you could tell me at this point that I’d judge you for.";
        }
		 else if (primeInt == 204){
                Char1name.text = "Ohzi";
                Char1speech.text = "...They’re a-";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
        }
	 else if (primeInt == 205){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Moosh";
				Char3speech.text = "A what? Landlord? Cop? Lawyer? \n ...Beaty Guru?";
        }
		 else if (primeInt == 206){
                Char1name.text = "Ohzi";
                Char1speech.text = "No?...Theyre a..bird.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
        }
		 else if (primeInt == 207){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Moosh";
				Char3speech.text = "Oh come on they may be a bit of a bird brain-";
				primeInt = 6;
        }
	}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "Ohzi";
                Char1speech.text = "Oh I’m not worried about me…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "Ohzi";
                Char1speech.text = "But nobody understands! Nobody will accept us!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("End_Lose4a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("End_Win4a");
        }
}
	