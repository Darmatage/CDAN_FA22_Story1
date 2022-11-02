using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4ADialogue : MonoBehaviour {
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
		public GameObject ArtChar1c;
        public GameObject ArtChar2;   //pigeon
		public GameObject ArtChar2b;
		public GameObject ArtChar2c;
        public GameObject ArtChar3;   //Moosh
		public GameObject ArtChar3b;
		public GameObject ArtChar3c;
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
		ArtChar1c.SetActive(false);
        ArtChar2.SetActive(false);
		ArtChar2b.SetActive(false);
		ArtChar2c.SetActive(false);
        ArtChar3.SetActive(false);
        ArtChar3b.SetActive(false);
		ArtChar3c.SetActive(false);
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
                Char3speech.text = "Ten years later...";
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
                Char1speech.text = "I felt like I was back in college again for a second.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		 else if (primeInt == 5){
			 ArtChar1.SetActive(true);
                Char1name.text = "Ohzi";
                Char1speech.text = "It's probably just the nerves.";
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
                Char1speech.text = "That was 10 years ago, & you did’nt even like them at first!";
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
                Char3speech.text = "They grew on me and everyone \n else will grow to love them too.";
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
                Char3speech.text = " And? Shh! Here they come!";
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
                Char3speech.text = "What are they doing??";
		}
		else if (primeInt ==17){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "Please DON'T-";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt == 18){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Pigeon";
                 Char2speech.text = "*Squats and puffs up* \n Coo.";
				 Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt == 19){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "Don’t. You. Dare.";
                 Char2name.text = "";
                 Char2speech.text = "";
				             Char3name.text = "";
                Char3speech.text = "";

                if (GameHandler.NiceToPigeon == true){primeInt = 49;} //takes to branch
                else {primeInt = 19;}
		}
		else if (primeInt == 20){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Pigeon";
                 Char2speech.text = "*Casually poops in the middle of the isle to \n spite you, before waddling down the aisle once more.*";
				 Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt == 21){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "*Sigh* \n (Can I do this?)";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                 Char3speech.text = "";
				 Char4name.text = "";
                 Char4speech.text = "";
		}
		else if (primeInt == 22){
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
                 Char1speech.text = " Oh perfect timing! \n (At least no one else seemed to notice)";
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
                  Char4speech.text = "Uhhhmmm… Will you, Ohzi...\n Kh…mm-khoff khak khak! \n Oh, LORD- just give me a minute-";
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
                   Char4speech.text = "-AHEM! Sorry where were we? OH, RIGHT!";
           }
          else if (primeInt == 26){
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
                     Char4speech.text = "Will you Ohzi take Pigeon to be your lawfully wedded...wife??";
			}
            else if (primeInt == 28){
                     Char1name.text = "";
                     Char1speech.text = "";
                     Char2name.text = "";
                     Char2speech.text = "";
					 Char3name.text = "Moosh";
					 Char3speech.text = "Hey, that's my job! You’re LITERALLY crashing the wedding!";
                     Char4name.text = "";
                     Char4speech.text = "";
			}
            else if (primeInt == 29){
                     Char1name.text = "";
                     Char1speech.text = "";
                     Char2name.text = "";
                     Char2speech.text = "";
					 Char3name.text = "";
					 Char3speech.text = "";
                     Char4name.text = "RA";
                     Char4speech.text = "Sorry, sorry it was just a prank.";
			}
            else if (primeInt == 30){
                     Char1name.text = "";
                     Char1speech.text = "";
                     Char2name.text = "";
                     Char2speech.text = "";
					 Char3name.text = "Moosh";
					 Char3speech.text = " Ahem. Ohzi, would you like to say your vows?";
                     Char4name.text = "";
                     Char4speech.text = "";
					  // Turn off "Next" button, turn on "Choice" buttons
                             nextButton.SetActive(false);
                             allowSpace = false;
                             NextScene1Button.SetActive(true);
                             NextScene2Button.SetActive(true);
             }

             else if (primeInt == 50){
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "Pigeon";
                      Char2speech.text = "*Grunts, but has the decency to waddle \n down the isle without incident.*";
                      Char3name.text = "";
                      Char3speech.text = "";
                      Char4name.text = "";
                      Char4speech.text = "";
                      }
              else if (primeInt == 51){
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "Pigeon";
                      Char2speech.text = "Coo. Coo coo.";
                      Char3name.text = "";
                      Char3speech.text = "";
                      Char4name.text = "";
                      Char4speech.text = "";
                      primeInt = 23;
                     }

// ENCOUNTER AFTER CHOICE #1

		else if (primeInt == 100){
			Char1name.text = "Ohzi";
			Char1speech.text = "Oh, but it's not me I'm worried about here.";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
			Char4name.text = "";
			Char4speech.text = "";
		}
		else if (primeInt == 101){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Moosh";
			Char3speech.text = " What do you mean?";
			Char4name.text = "";
			Char4speech.text = "";
		}
		else if (primeInt == 102){
			Char1name.text = "Ohzi";
			Char1speech.text = "I'm worried I'll hurt them...";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
			Char4name.text = "";
			Char4speech.text = "";
			}
		else if (primeInt == 103){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Moosh";
			Char3speech.text = "What do you mean? You've already been taking care of them for the past ten years!";
			Char4name.text = "";
			Char4speech.text = "";
		}
		else if (primeInt == 104){
			Char1name.text = "Ohzi";
			Char1speech.text = "No, not them, I love Pigeon. I'm not worried about Pigeon.";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
			Char4name.text = "";
			Char4speech.text = "";
		}
		else if (primeInt == 105){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Moosh";
			Char3speech.text = "Then who in the world is 'them'???";
			Char4name.text = "";
			Char4speech.text = "";
		}
		else if (primeInt == 106){
			Char1name.text = "Ohzi";
			Char1speech.text = "*Sigh* \n My PARENTS Moosh!";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
			Char4name.text = "";
			Char4speech.text = "";
		}
		else if (primeInt == 107){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Moosh";
			Char3speech.text = "Oh...I have no idea what youre talking about.";
			Char4name.text = "";
			Char4speech.text = "";
		}
		else if (primeInt == 108){
			Char1name.text = "Ohzi";
			Char1speech.text = "I'm worried they won't understand, and I know Pigeon is excited to finally meet them and...and..";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
			Char4name.text = "";
			Char4speech.text = "";
		}
		else if (primeInt == 109){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Moosh";
			Char3speech.text = "Ohzi, Pigeon will be fine, you’re overreacting";
			Char4name.text = "";
			Char4speech.text = "";
		}
		else if (primeInt == 110){
			Char1name.text = "Ohzi";
			Char1speech.text = "But, But-";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
			Char4name.text = "";
			Char4speech.text = "";
			primeInt = 6;
        }


// ENCOUNTER AFTER CHOICE #2
       else if (primeInt == 200){
                Char1name.text = "Ohzi";
                Char1speech.text = "But Moosh, you don't understand. NOBODY will accept us once they all realize-";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Moosh";
				Char3speech.text = "Oh come on Ohzi! We have been friends for 10, almost 11 years now, \n you KNOW there's nothing I wouldn’t accept. \n If you have anything you need to tell me-";
        }
		 else if (primeInt == 202){
                Char1name.text = "Ohzi";
                Char1speech.text = "OH NO NO NO, you’re misunderstanding, it’s not like THAT! It's… It's different.";
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
				Char3speech.text = "... Different how? I don't think there's anything else you could tell me at this point that I’d judge you for.";
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
				Char3speech.text = "A what? Landlord? Cop? Lawyer? ...Beauty Guru?";
        }
		 else if (primeInt == 206){
                Char1name.text = "Ohzi";
                Char1speech.text = "No?...They're a...bird.";
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
				Char3speech.text = "Oh come on, they may be a bit of a bird brain-";
				primeInt = 6;
        }
	}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                //Char1name.text = "Ohzi";
                //Char1speech.text = "Oh I’m not worried about me…";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                //Char1name.text = "Ohzi";
                //Char1speech.text = "But nobody understands! Nobody will accept us!";
                //Char2name.text = "";
                //Char2speech.text = "";
				//Char3name.text = "";
                //Char3speech.text = "";
				//Char4name.text = "";
                //Char4speech.text = "";

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
