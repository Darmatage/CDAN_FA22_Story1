using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4bDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;   //Ohzi - player
		public GameObject ArtChar1b;	//nervous
        public GameObject ArtChar2;   //pigeon
		public GameObject ArtChar2b;	//nervous
		public GameObject ArtChar2c;	//joyful
        public GameObject ArtChar3;   //Mad Scientist
		public GameObject ArtChar3b;	//nervous
		public GameObject ArtChar3c;		//excited
        public GameObject ArtBG1;	//Lab
		public GameObject ArtBG2;   //splash_academy
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
		ArtChar2c.SetActive(false);
        ArtChar3.SetActive(false);
        ArtChar3b.SetActive(false);
		ArtChar3c.SetActive(false);
        ArtBG1.SetActive(false);
		ArtBG2.SetActive(true);


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
               ArtChar1b.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "Ohzi";
                Char1speech.text = "Uh, ANYWAY-- look it's just a little plushie I made for class see?? \n I mean, it only makes a sound when you poke it see?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "Coo.";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 4){
				ArtChar1b.SetActive(false);
				ArtChar1.SetActive(true);
                Char1name.text = "Ohzi";
                Char1speech.text = "You may say, “Ohzi but that cute little guy is too nice \n to just be for a class project, I want one too!” and you wouldn't be the only one-";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		 else if (primeInt == 5){
                Char1name.text = "Ohzi";
                Char1speech.text = "-even I was susceptible to- I mean, even I had the great idea to mass-produce them!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 6){
		   ArtChar1.SetActive(false);
		   ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "Coo!";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 7){
                Char1name.text = "Ohzi";
                Char1speech.text = "Follow me to my little factory, I want to show you the process.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				//Background change to Lab
        }
		 else if (primeInt == 8){
			ArtBG1.SetActive(true);
			ArtBG2.SetActive(false);
			ArtChar1.SetActive(true);
			ArtChar1b.SetActive(false);
                Char1name.text = "Ohzi";
                Char1speech.text = "Production has been going really well!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		 else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "Coo!";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 10){
                Char1name.text = "Ohzi";
                Char1speech.text = " Exactly! We just have to do one more inspection before we ship the plushies out and everything should be fine…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 11){
		   ArtChar1.SetActive(false);
			ArtChar1b.SetActive(true);
			ArtChar2.SetActive(false);
			ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "???";
                Char3speech.text = "*clANg, CrACk…THuD!*";
        }
        else if (primeInt == 12){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "???";
                 Char3speech.text = "Ah Ohzi!?! Perrrrfect timing!...as usual.";
		}
        else if (primeInt == 13) {
                 Char1name.text = "Ohzi";
                 Char1speech.text = "… Uhhh. No?";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "";
		}
        else if (primeInt == 14){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Pigeon";
                 Char2speech.text = "*Blinks.*";
				 Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt == 15){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "Uhh...hello?";
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
				 Char3name.text = "???";
                 Char3speech.text = "Just hold on I'm almost there- Aaa! *CRASH*";
		}
		else if (primeInt ==17){
			 ArtChar3.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "Mad Scientist";
                 Char3speech.text = "Ah, yes, there you are!";
		}
		else if (primeInt == 18){
			ArtChar2.SetActive(true);
		    ArtChar2b.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Pigeon";
                 Char2speech.text = "*Blinks.* Coo...Coo.";
				 Char3name.text = "";
                 Char3speech.text = "";
		}
		else if (primeInt == 19){
			ArtChar1.SetActive(true);
		    ArtChar1b.SetActive(false);
                 Char1name.text = "Ohzi";
                 Char1speech.text = "*Long sigh* You’re not wrong, they are a little 'CooCoo.'";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                 Char3speech.text = "";
		}
		else if (primeInt == 20){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "Mad Scientist";
                 Char3speech.text = "Did you say something?";
		}
		else if (primeInt == 21){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Pigeon";
                 Char2speech.text = "Coo?";
				 Char3name.text = "";
                 Char3speech.text = "";
		}
		else if (primeInt == 22){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "Nope.";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                 Char3speech.text = "";
		}
		else if (primeInt == 23){
			ArtChar3.SetActive(false);
		    ArtChar3b.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "Mad Scientist";
                Char3speech.text = "Yeah, actually, that's more probable, right this way!";
                 // Turn off "Next" button, turn on "Choice" buttons
                 nextButton.SetActive(false);
                 allowSpace = false;
                 Choice1a.SetActive(true); // function Choice1aFunct()
                 Choice1b.SetActive(true); // function Choice1bFunct()
        }

         else if (primeInt == 24){
				ArtChar1.SetActive(false);
				ArtChar1b.SetActive(true);
				ArtChar2b.SetActive(false);
				ArtChar2.SetActive(true);
				ArtChar3b.SetActive(true);
				ArtChar3c.SetActive(false); //crazy-Excited
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
				  Char3name.text = "Mad Scientist";
                  Char3speech.text = "Yes, yes!! Everything is going exactly according to the… ORIGINAL plan.";
          }
          else if (primeInt == 25){
			    ArtChar2.SetActive(false);
			    ArtChar2b.SetActive(true);
				ArtChar2c.SetActive(false);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Pigeon";
                   Char2speech.text = "Coo...";
                   Char3name.text = "";
                   Char3speech.text = "";
            }
          else if (primeInt == 26){
                ArtChar3.SetActive(true);
			    ArtChar3b.SetActive(false);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "Mad Scientist";
                  Char3speech.text = "Exactly, my sweet little feathered friend!";
            }
            else if (primeInt == 27){
				ArtChar2b.SetActive(false);
			    ArtChar2c.SetActive(true);
                     Char1name.text = "";
                     Char1speech.text = "";
                     Char2name.text = "Pigeon";
                     Char2speech.text = "..Coo? *Fluffs Feathers*";
                     Char3name.text = "";
                     Char3speech.text = "";
            }
            else if (primeInt == 28){
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "";
                    Char2speech.text = "";
                    Char3name.text = "Mad Scientist";
                    Char3speech.text = "Now, take a look!";
            }
              else if (primeInt == 29){
				    ArtChar1b.SetActive(false);
				    ArtChar1.SetActive(true);
                       Char1name.text = "Ohzi";
                       Char1speech.text = "Let me see…";
                       Char2name.text = "";
                       Char2speech.text = "";
                       Char3name.text = "";
                       Char3speech.text = "";
            }
              else if (primeInt == 30){
				    ArtChar2c.SetActive(false);
			        ArtChar2.SetActive(true);
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "";
                      Char2speech.text = "";
                      Char3name.text = "Pigeon";
                      Char3speech.text = " Coo! *Stomps little feets excitedly*";
            }
                else if (primeInt == 31){
                         Char1name.text = "Ohzi";
                         Char1speech.text = "Huh, that looks pretty good. I’m sorry I doubted you.";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "";
                         Char3speech.text = "";
			}
                else if (primeInt == 32){
					ArtChar3.SetActive(false);
			        ArtChar3c.SetActive(true);
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "Mad Scientist";
                         Char3speech.text = "See!! You DARE doubt MY SKILLS!!";
			}
                else if (primeInt == 33){
					ArtChar1.SetActive(false);
			        ArtChar1b.SetActive(true);
                         Char1name.text = "Ohzi";
                         Char1speech.text = "...(Something feels off?)";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "";
                         Char3speech.text = "";
			}
                else if (primeInt == 34){
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "Pigeon";
                         Char2speech.text = "Coo??";
                         Char3name.text = "";
                         Char3speech.text = "";
			}
                else if (primeInt == 35){
                         Char1name.text = "Ohzi";
                         Char1speech.text = "Huh? (Should I Ignore it? Something tells me it's for the better…)";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "";
                         Char3speech.text = "";
			}
                else if (primeInt == 36){
					ArtChar2.SetActive(false);
			        ArtChar2c.SetActive(true);
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "Pigeon";
                         Char2speech.text = " Coo!";
                         Char3name.text = "";
                         Char3speech.text = "";
			}
                else if (primeInt == 37){
                         Char1name.text = "Ohzi";
                         Char1speech.text = "Can you read my mind, it's like you're saying yes??";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "";
                         Char3speech.text = "";
			}
                else if (primeInt == 38){
					ArtChar2c.SetActive(false);
			        ArtChar2.SetActive(true);
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "Pigeon";
                         Char2speech.text = "Coo’oo Coooo.";
                         Char3name.text = "";
                         Char3speech.text = "";
			}
                else if (primeInt == 39){
                         Char1name.text = "Ohzi";
                         Char1speech.text = "…You’re Right..";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "";
                         Char3speech.text = "";
                             // Turn off "Next" button, turn on "Choice" buttons
                             nextButton.SetActive(false);
                             allowSpace = false;
                             NextScene1Button.SetActive(true);
                             NextScene2Button.SetActive(true);
            }

// ENCOUNTER AFTER CHOICE #1
			else if (primeInt == 100){
			ArtChar1.SetActive(false);
		    ArtChar1b.SetActive(true);
                Char1name.text = "Ohzi";
                Char1speech.text = "You kept your grubby little hands off the controls while I was gone, correct?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
			}
			else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Mad Scientist";
				Char3speech.text = "...";
			}
			else if (primeInt == 102){
			ArtChar2b.SetActive(false);
		    ArtChar2c.SetActive(true);
			ArtChar2.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "Coooooo?";
				Char3name.text = "";
                Char3speech.text = "";
			}
			else if (primeInt == 103){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Mad Scientist";
				Char3speech.text = "Yes?…Yes, DEFINITELY.";
			}
			else if (primeInt == 104){
				ArtChar1.SetActive(true);
				ArtChar1b.SetActive(false);
                Char1name.text = "Ohzi";
                Char1speech.text = "Okay!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
			}
			else if (primeInt == 105){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "Coo?!";
				Char3name.text = "";
				Char3speech.text = "";
			 primeInt = 23;
        }

// ENCOUNTER AFTER CHOICE #2
       else if (primeInt == 200){
		    ArtChar3b.SetActive(false);
		    ArtChar3c.SetActive(true);
                Char1name.text = "Ohzi";
                Char1speech.text = "Thank you, everything is going as planned right?";
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
				Char3name.text = "Mad Scientist";
				Char3speech.text = "Oh Yes, yes! Don’t worry about \n A N Y T H I N G. \n Youdon’tneedtoknow.";
        }
		 else if (primeInt == 202){
			ArtChar1.SetActive(false);
		    ArtChar1b.SetActive(true);
                Char1name.text = "Ohzi";
                Char1speech.text = "What do you mean?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
        }
		 else if (primeInt == 203){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "Coo?";
				Char3name.text = "";
				Char3speech.text = "";
        }
		 else if (primeInt == 204){
			ArtChar3c.SetActive(false);
		    ArtChar3b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "Oh, NOTHING! Ahem, nothing. *Sweating*.";
				}
		 else if (primeInt == 205){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "...Cooooo coo Cooo..";
				Char3name.text = "";
				Char3speech.text = "";
				}
		 else if (primeInt == 206){
                Char1name.text = "Ohzi";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "You followed the plan, RIGHT?!";
				primeInt = 23;
        }


     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                //Char1name.text = "Ohzi";
                //Char1speech.text = "You kept your grubby hands off the controls, yes?";
                //Char2name.text = "";
                //Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                //Char1name.text = "Ohzi";
                //Char1speech.text = " Everything is going as planned?";
                //Char2name.text = "";
                //Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("End_Lose4b");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("End_Win4b");
        }
}
