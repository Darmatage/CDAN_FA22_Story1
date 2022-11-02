using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4cDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;   //Ohzi - player
		public GameObject ArtChar1b;
		public GameObject ArtChar1c;
        public GameObject ArtChar2;   //pigeon
		public GameObject ArtChar2b;
		public GameObject ArtChar2c; //Liar Scene
        public GameObject ArtChar3;   //Mad Scientist
		public GameObject ArtChar3b;	//excited
		public GameObject ArtChar3c;
        public GameObject ArtBG1;
		public GameObject ArtBG2;   //splash_academy
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice2a;
        public GameObject Choice2b;
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
        ArtBG1.SetActive(false);

		ArtBG2.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice2a.SetActive(false);
        Choice2b.SetActive(false);
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
                Char1speech.text = "You see, I have a secret...a secret to my success...";
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
                Char2speech.text = "Coo?";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
		    ArtChar1.SetActive(true);
			ArtChar1b.SetActive(false);
                Char1name.text = "Ohzi";
                Char1speech.text = "This little guy right here...is a PIGEON!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		 else if (primeInt == 5){
		ArtChar3c.SetActive(true);
		ArtChar2.SetActive(false);
		ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = " ";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Professor";
                Char3speech.text = "I KNEW IT! I knew I wasn’t crazy!";
        }
       else if (primeInt == 6){
		   ArtChar1.SetActive(false);
		   ArtChar1b.SetActive(true);
		   ArtChar3c.SetActive(false);
                Char1name.text = "Ohzi";
                Char1speech.text = "…Okay? Well not just that, BUT-";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 7){
		   ArtChar3c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Professor";
                Char3speech.text = "Oh, what ELSE could there possibly be??";
        }
		 else if (primeInt == 8){
                Char1name.text = "Ohzi";
                Char1speech.text = "I'm trying to tell you...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		 else if (primeInt == 9){
			 ArtChar3c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "Coo!";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 10){
		   ArtChar1b.SetActive(false);
		   ArtChar1c.SetActive(true);
                Char1name.text = "Ohzi";
                Char1speech.text = "Exactly my point. This little guy is not only a pigeon but a... \n‘Super Smart Genius Pigeon’™!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 11){
		   	ArtChar2b.SetActive(false);
			ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "Coo!!";
				Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 12){
			ArtChar1.SetActive(true);
		   ArtChar1c.SetActive(false);
                 Char1name.text = "Ohzi";
                 Char1speech.text = "To the lab!";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                 Char3speech.text = "";
		}
    //change BG to lab
        else if (primeInt == 13) {
			ArtBG1.SetActive(true);
			ArtBG2.SetActive(false);
			ArtChar2.SetActive(false);
                 Char1name.text = "Ohzi";
                 Char1speech.text = "Ah it's nice to be back here!";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "";
		}
        else if (primeInt == 14){
			ArtChar2.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Pigeon";
                 Char2speech.text = "Coo Coo!";
				 Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt == 15){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "I needed to get a break from everyone. I feel like we're the only sane ones sometimes.";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                 Char3speech.text = "";
		}
		else if (primeInt == 16){
			ArtChar2.SetActive(false);
			ArtChar2b.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Pigeon";
                 Char2speech.text = "Coo?";
				 Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt ==17){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "You know how everything feels scripted sometimes?";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt == 18){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Pigeon";
                 Char2speech.text = "...";
				 Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt == 19){
			ArtChar1b.SetActive(true);
		    ArtChar1.SetActive(false);
                 Char1name.text = "Ohzi";
                 Char1speech.text = "No huh? I know, the irony... \n To anyone else I’m just talking to a pigeon...basically talking to myself.";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt == 20){
			ArtChar2b.SetActive(false);
                 Char1name.text = "Ohzi";
                 Char1speech.text = "Not even YOU know for certain what they’re saying, do you?";
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
		else if (primeInt == 30){
			ArtChar2.SetActive(true);
			ArtChar2c.SetActive(false);
			ArtChar1b.SetActive(false);
			ArtChar1.SetActive(true);
                 Char1name.text = "Ohzi";
                 Char1speech.text = "It’s just nice to get a second of peace.";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt == 31){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Pigeon";
                 Char2speech.text = "Coo..";
				 Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt == 32){
			ArtChar3b.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "Mad Scientist";
                Char3speech.text = "HELLO my feathered friend!!";
        }

         else if (primeInt == 33){
			ArtChar2b.SetActive(true);
		    ArtChar2.SetActive(false);
			ArtChar1.SetActive(false);
			ArtChar1b.SetActive(false);
			ArtChar1c.SetActive(true);
                  Char1name.text = "Ohzi";
                  Char1speech.text = "OH LORD that cra– doctor is back!";
                  Char2name.text = "";
                  Char2speech.text = "";
				  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 34){
			  ArtChar3b.SetActive(false);
			  ArtChar3.SetActive(true);
			  ArtChar1c.SetActive(false);
			  ArtChar1b.SetActive(true);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "Mad Scientist";
                   Char3speech.text = "Thank you for letting me visit your lab.";
           }
          else if (primeInt == 35){
            ArtChar2.SetActive(true);
			ArtChar2b.SetActive(false);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Pigeon";
                  Char2speech.text = "*Blinks.* Coo.";
                  Char3name.text = "";
                  Char3speech.text = "";
            }

            else if (primeInt == 36){
			ArtChar3b.SetActive(true);
			ArtChar3.SetActive(false);
                     Char1name.text = "";
                     Char1speech.text = "";
                     Char2name.text = "";
                     Char2speech.text = "";
                     Char3name.text = "Mad Scientist";
                     Char3speech.text = "I’d like to extend an invitation to the Super Special Secret Science Society or SSSSS for short.";
             }
            else if (primeInt == 37){
			ArtChar3b.SetActive(false);
			ArtChar3.SetActive(true);
			ArtChar2.SetActive(false);
			ArtChar2b.SetActive(true);
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "Pigeon";
                    Char2speech.text = "…Coo?";
                    Char3name.text = "";
                    Char3speech.text = "";
              }

              else if (primeInt == 38){
			ArtChar3b.SetActive(true);
			ArtChar3.SetActive(false);
			ArtChar1b.SetActive(false);
			ArtChar1.SetActive(true);
                       Char1name.text = "";
                       Char1speech.text = "";
                       Char2name.text = "";
                       Char2speech.text = "";
                       Char3name.text = "Mad Scientist";
                       Char3speech.text = "We think it fits the vibe don’t you? A little spooooky even??";
               }
              else if (primeInt == 39){
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "";
                      Char2speech.text = "";
                      Char3name.text = "Pigeon";
                      Char3speech.text = "Coo coo.";
                }
                else if (primeInt == 40){
					ArtChar1.SetActive(false);
					ArtChar1b.SetActive(true);
                         Char1name.text = "Ohzi";
                         Char1speech.text = "Uh.";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "";
                         Char3speech.text = "";
				}
                else if (primeInt == 41){
				ArtChar3.SetActive(true);
				ArtChar3b.SetActive(false);
				ArtChar2.SetActive(true);
				ArtChar2b.SetActive(false);
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "Mad Scientist";
                         Char3speech.text = "We’ll workshop it.";
				}
                else if (primeInt == 42){
				ArtChar1.SetActive(true);
				ArtChar1b.SetActive(false);
                         Char1name.text = "Ohzi";
                         Char1speech.text = "Uh, am I meant to be here? Maybe I should just-";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "";
                         Char3speech.text = "";
				}
                else if (primeInt == 43){
				ArtChar3b.SetActive(true);
				ArtChar3.SetActive(false);
				ArtChar1.SetActive(false);
				ArtChar1b.SetActive(true);
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "Mad Scientist";
                         Char3speech.text = "Shhh Human! I’m speaking to the higher life form.";
				}
                else if (primeInt == 44){
				ArtChar2b.SetActive(true);
				ArtChar2.SetActive(false);
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "Pigeon";
                         Char2speech.text = "Cooo Coo Coo?";
                         Char3name.text = "";
                         Char3speech.text = "";
				}
                else if (primeInt == 45){
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "Mad Scientist";
                         Char3speech.text = " Yes, yes, we’ll get to that another time, don’t worry.";
				}
                else if (primeInt == 46){
                         Char1name.text = "Ohzi";
                         Char1speech.text = " …Uhhh.";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "";
                         Char3speech.text = "";
				}
                else if (primeInt == 47){
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "Pigeon";
                         Char2speech.text = "Coo?";
                         Char3name.text = "";
                         Char3speech.text = "";
				}
                else if (primeInt == 48){
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "Mad Scientist";
                         Char3speech.text = "Oh yes, it IS quite prestigious!";
				}
                else if (primeInt == 49){
				ArtChar2.SetActive(true);
			    ArtChar2b.SetActive(false);
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "";
                         Char2speech.text = "...Coo Coo?";
                         Char3name.text = "";
                         Char3speech.text = "";
				}
                else if (primeInt ==50){
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "Mad Scientist";
                         Char3speech.text = "Oh. Right. I’ll leave you to make your decision.";
				}
                else if (primeInt == 51){
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "Mad Scientist";
                         Char3speech.text = "...";
				}
                else if (primeInt == 52){
					ArtChar1b.SetActive(false);
					ArtChar1.SetActive(true);
                         Char1name.text = "Ohzi";
                         Char1speech.text = "You’re still here.";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "";
                         Char3speech.text = "";
				}
                else if (primeInt == 53){
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "Mad Scientist";
                         Char3speech.text = "Oh you mean leave right NOW! \n Adieu! To you both, I guess.";
						 // Turn off "Next" button, turn on "Choice" buttons
						 nextButton.SetActive(false);
						 allowSpace = false;
						 Choice2a.SetActive(true); // function Choice2aFunct()
						 Choice2b.SetActive(true); // function Choice2bFunct()
				}
                else if (primeInt == 60){
					ArtChar3b.SetActive(false);
					ArtChar3.SetActive(false);
					ArtChar1.SetActive(true);
				    ArtChar1b.SetActive(false);
				    ArtChar2.SetActive(true);
			        ArtChar2b.SetActive(false);
                         Char1name.text = "Ohzi";
                         Char1speech.text = "Do you know what you’re going to do?";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "";
                         Char3speech.text = "";
				}
                else if (primeInt == 61){
					ArtChar2b.SetActive(true);
					ArtChar2.SetActive(false);
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "Pigeon";
                         Char2speech.text = "*Blinks*";
                         Char3name.text = "";
                         Char3speech.text = "";
						 }
                else if (primeInt == 62){
					ArtChar1b.SetActive(true);
				    ArtChar1.SetActive(false);
                         Char1name.text = "Ohzi";
                         Char1speech.text = "Well...";
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

// ENCOUNTER AFTER CHOICE #1B
			else if (primeInt == 100){
                Char1name.text = "Ohzi";
                Char1speech.text = "Correct, see?";
                Char2name.text = "";
                Char2speech.text = "";
			}
			else if (primeInt == 101){
                Char1name.text = "Ohzi";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
			}
			else if (primeInt == 102){
                Char1name.text = "Ohzi";
                Char1speech.text = "Who was I talking to again?";
                Char2name.text = "";
                Char2speech.text = "";
				}
			else if (primeInt == 103){
			ArtChar1b.SetActive(false);
			ArtChar1.SetActive(true);
			ArtChar2b.SetActive(true);
                Char1name.text = "Ohzi";
                Char1speech.text = "Oh, right, Pigeon-";
                Char2name.text = "";
                Char2speech.text = "";
				 primeInt = 29;
        }

// ENCOUNTER AFTER CHOICE #1A
       else if (primeInt == 200){
		   	ArtChar1.SetActive(false);
			ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = " ";
                Char2name.text = "Pigeon";
                Char2speech.text = "Liar.";
				 primeInt = 29;
        }
// ENCOUNTER AFTER CHOICE #2A
       else if (primeInt == 300){
		Choice2a.SetActive(false);
		Choice2b.SetActive(false);
		    ArtChar3b.SetActive(false);
			ArtChar3.SetActive(false);
			ArtChar1.SetActive(true);
			ArtChar1b.SetActive(false);
			ArtChar2b.SetActive(true);
			ArtChar2.SetActive(false);
                Char1name.text = "Ohzi";
                Char1speech.text = "...You're the one who sent HIM a holiday card? How does he know you??";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		 else if (primeInt == 301){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "Coo Coo!";
				Char3name.text = "";
                Char3speech.text = "";
        }
		 else if (primeInt == 302){
                Char1name.text = "Ohzi";
                Char1speech.text = "Why didn’t I get a holiday card?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		 else if (primeInt == 303){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "...";
				Char3name.text = "";
                Char3speech.text = "";
        }
		 else if (primeInt == 304){
			ArtChar2.SetActive(true);
			ArtChar2b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "Coooo.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		 else if (primeInt == 305){
			ArtChar1b.SetActive(true);
			ArtChar1.SetActive(false);
                Char1name.text = "Ohzi";
                Char1speech.text = "Well that’s rude.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				 primeInt = 59;
        }
// ENCOUNTER AFTER CHOICE #2B
       else if (primeInt == 401){
		Choice2b.SetActive(false);
		Choice2a.SetActive(false);
		    ArtChar3b.SetActive(false);
		    ArtChar3.SetActive(false);
			ArtChar1b.SetActive(true);
			ArtChar1.SetActive(false);
			ArtChar2.SetActive(true);
			ArtChar2b.SetActive(false);
                Char1name.text = "Ohzi";
                Char1speech.text = "...How did he get in this time?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		       else if (primeInt == 402){
                Char1name.text = "Ohzi";
                Char1speech.text = "Was he here the whole time???";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		       else if (primeInt == 403){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "Coo?";
				Char3name.text = "";
                Char3speech.text = "";
        }
		       else if (primeInt == 404){
				ArtChar1.SetActive(true);
				ArtChar1b.SetActive(false);
				ArtChar2b.SetActive(true);
			    ArtChar2.SetActive(false);
                Char1name.text = "Ohzi";
                Char1speech.text = "No, everything is locked from the inside, and we have extensive alarm systems.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		       else if (primeInt == 405){
                Char1name.text = "";
                Char1speech.text = " ";
                Char2name.text = "Pigeon";
                Char2speech.text = "...";
				Char3name.text = "";
                Char3speech.text = "";
        }
		       else if (primeInt == 406){
				ArtChar1b.SetActive(true);
				ArtChar1.SetActive(false);
                Char1name.text = "Ohzi";
                Char1speech.text = "...I don’t want to know.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				primeInt = 59;
        }
}


// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                //Char1name.text = "Ohzi";
                //Char1speech.text = "No";
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
                //Char1speech.text = "Yes.";
                //Char2name.text = "";
                //Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		  public void Choice2aFunct(){
                //Char1name.text = "Ohzi";
                //Char1speech.text = " …You’re the one who sent him the holiday card.";
                //Char2name.text = "";
                //Char2speech.text = "";
                primeInt = 299;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
                //Char1name.text = "Ohzi";
                //Char1speech.text = "…How did he get in this time?";
                //Char2name.text = "";
                //Char2speech.text = "";
                primeInt = 399;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("End_Lose4c");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("End_Win4c");
        }
}
