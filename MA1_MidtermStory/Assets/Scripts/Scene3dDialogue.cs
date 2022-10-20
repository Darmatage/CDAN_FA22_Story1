using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3dDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;   //Ohzi - player
        public GameObject ArtChar2;   //pigeon
        public GameObject ArtChar3;   //professor
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtChar3.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        NextScene3Button.SetActive(false);
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
               ArtChar2.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Professor";
                Char3speech.text = "Hey Ohzi can I speak with you before you head out?";
        }
       else if (primeInt ==3){
                ArtChar2.SetActive(true);
                Char1name.text = "Ohzi";
                Char1speech.text = "What?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = " ";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Professor";
                Char3speech.text = "I was going to try to talk to you about today's test results";
        }
		 else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = " ";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Professor";
                Char3speech.text = "I’ve never seen answers like these before…";
        }
       else if (primeInt == 6){
                Char1name.text = "Ohzi";
                Char1speech.text = "*Sweating* Uh, what do you mean??";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Professor";
                Char3speech.text = "Most of this test was meant to make everyone fail!";
        }
		 else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "professor";
                Char3speech.text = "I haven’t taught this subject yet in class–";
        }
		 else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Professor";
                Char3speech.text = "Yet you seemed to have mastered it before I even began!";
        }
       else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "Coo";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Professor";
                Char3speech.text = "…Was that a pigeon??";
        }
        else if (primeInt == 12){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Pigeon";
                 Char2speech.text = "...";
				 Char3name.text = "";
                Char3speech.text = "";
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
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "Professor";
                Char3speech.text = "Alright! I'll see you at the ceremony tonight, right?";
		}
		else if (primeInt == 15){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "Oh right of course! Totally.";
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
				 Char3name.text = "Professor";
                Char3speech.text = "Haha you better– I’ll hold you accountable–";
		}
		else if (primeInt ==17){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "Professor";
                Char3speech.text = "And dock your grade otherwise.";
		}
		else if (primeInt == 18){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "Professor";
                Char3speech.text = "After today you completely bumped Sam out of their top spot in class.";
		}
		else if (primeInt == 19){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "Professor";
                Char3speech.text = " I HAVE to brag! *leaves*";
		}
		else if (primeInt == 20){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "Okayyy then…";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "";
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
                 Char1speech.text = "Oh hey you were so quiet, I almost forgot you were there.";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt == 23){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "I can’t believe you helped me on that test!";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "";
                 // Turn off "Next" button, turn on "Choice" buttons
                 nextButton.SetActive(false);
                 allowSpace = false;
                 Choice1a.SetActive(true); // function Choice1aFunct()
                 Choice1b.SetActive(true); // function Choice1bFunct()
        }

         else if (primeInt == 24){
           ArtChar2.SetActive(false);
                  Char1name.text = "Ohzi";
                  Char1speech.text = "Wow, the weather is really nice today!";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
          else if (primeInt == 25){
                   Char1name.text = "Ohzi";
                   Char1speech.text = "All of the leaves are turning different colors, and the birds are out…";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
           }
          else if (primeInt == 26){
            ArtChar3.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "Pigeon";
                  Char3speech.text = "Coo";
            }

            else if (primeInt == 27){
                     Char1name.text = "Ohzi";
                     Char1speech.text = "... That’s a pigeon.";
                     Char2name.text = "";
                     Char2speech.text = "";
                     Char3name.text = "";
                     Char3speech.text = "";
             }
            else if (primeInt == 28){
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "";
                    Char2speech.text = "";
                    Char3name.text = "Pigeon";
                    Char3speech.text = "*Blinks.*";
              }

              else if (primeInt == 29){
                       Char1name.text = "Ohzi";
                       Char1speech.text = "I’ve always wanted a pigeon. I just think they’re neat";
                       Char2name.text = "";
                       Char2speech.text = "";
                       Char3name.text = "";
                       Char3speech.text = "";
               }
              else if (primeInt == 30){
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "";
                      Char2speech.text = "";
                      Char3name.text = "Pigeon";
                      Char3speech.text = "Coo";
                }
                else if (primeInt == 31){
                         Char1name.text = "Ohzi";
                         Char1speech.text = "Are you looking at me??";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "";
                         Char3speech.text = "";
                 }
                else if (primeInt == 32){
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "Pigeon";
                        Char3speech.text = "*Blinks.*";
                  }
                  else if (primeInt == 33){
                           Char1name.text = "Ohzi";
                           Char1speech.text = "Do you want to come with me?";
                           Char2name.text = "";
                           Char2speech.text = "";
                           Char3name.text = "";
                           Char3speech.text = "";
                   }
                  else if (primeInt == 34){
                          Char1name.text = "";
                          Char1speech.text = "";
                          Char2name.text = "";
                          Char2speech.text = "";
                          Char3name.text = "Pigeon";
                          Char3speech.text = "Coo";
                    }
                    else if (primeInt == 35){
                             Char1name.text = "";
                             Char1speech.text = "";
                             Char2name.text = "";
                             Char2speech.text = "";
                             // Turn off "Next" button, turn on "Choice" buttons
                             nextButton.SetActive(false);
                             allowSpace = false;
                             NextScene1Button.SetActive(true);
                             NextScene2Button.SetActive(true);
                             NextScene3Button.SetActive(true);
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
                primeInt = 19;
        }
		else if (primeInt == 102){
                Char1name.text = "Ohzi";
                Char1speech.text = "I know, I know, you were just trying to help. *Sigh*";
                Char2name.text = "";
                Char2speech.text = "";
        }

// ENCOUNTER AFTER CHOICE #2
       else if (primeInt == 200){
                Char1name.text = "Ohzi";
                Char1speech.text = " I really appreciate the help even if it was cheating haha.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "CooCoo!";
                primeInt = 19;
        }
		 else if (primeInt == 202){
                Char1name.text = "Ohzi";
                Char1speech.text = "Poor Sam.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		 else if (primeInt == 203){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
		 else if (primeInt == 203){
                Char1name.text = "Ohzi";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "Ohzi";
                Char1speech.text = "You should have let me fail, I didn’t want to cheat.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "Ohzi";
                Char1speech.text = "I really appreciate it, even if it was cheating.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene4c");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene4b");
        }
        public void SceneChange3(){
                SceneManager.LoadScene("End_LoseD2");
        }
}
