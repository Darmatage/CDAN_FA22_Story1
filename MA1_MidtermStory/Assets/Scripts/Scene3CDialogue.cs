using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3CDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;   //Ohzi - player
        public GameObject ArtChar1b;
        public GameObject ArtChar1c;
        public GameObject ArtChar1d;
        public GameObject ArtChar1e;

        public GameObject ArtChar2a;   //pigeon
        public GameObject ArtChar2b;
        public GameObject ArtChar2c;
        public GameObject ArtChar2d;
        public GameObject ArtChar2e;

        public GameObject ArtChar3a;   //Professor
        public GameObject ArtChar3b;
        public GameObject ArtChar3c;
        public GameObject ArtChar3d;
        public GameObject ArtChar3e;

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
        DialogueDisplay.SetActive(true);
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
        ArtChar1d.SetActive(false);
        ArtChar1e.SetActive(false);

        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        ArtChar2c.SetActive(false);
        ArtChar2d.SetActive(false);
        ArtChar2e.SetActive(false);

        ArtChar3a.SetActive(false);
        ArtChar3b.SetActive(false);
        ArtChar3c.SetActive(false);
        ArtChar3d.SetActive(false);
        ArtChar3e.SetActive(false);

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
               ArtChar1a.SetActive(true);
               ArtChar2a.SetActive(true);
               ArtChar3a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Professor";
                Char3speech.text = "Hey, Ohzi, can you come over here?";
        }
       else if (primeInt == 3){
                Char1name.text = "Ohzi";
                Char1speech.text = "Uh, yeah. Did I do something wrong?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 4){
                Char1name.text = "Ohzi";
                Char1speech.text = "I’m not failing anything am I?!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Professor";
                Char3speech.text = "No, don’t worry, you're not at risk of failing.";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Professor";
                Char3speech.text = "It's just… *Sigh*.";
        }
       else if (primeInt == 7){
                Char1name.text = "Ohzi";
                Char1speech.text = "What?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 8){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "Professor";
                 Char3speech.text = "Is that a pigeon??";
         }
         else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "...";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 10){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "...Uhhh. No?";
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
                Char3name.text = "Professor";
                Char3speech.text = "Ohzi you are not the first– ";
        }
        else if (primeInt == 12){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "Professor";
                 Char3speech.text = "-although I wish you were–";
         }
         else if (primeInt == 13){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "Professor";
                  Char3speech.text = "-and certainly won’t be the last student to try to bring a pet to class.";
          }
          else if (primeInt == 14){
                   Char1name.text = "Ohzi";
                   Char1speech.text = "Oh wait, Professor, it's not a pet!";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
           }
           else if (primeInt == 15){
                    Char1name.text = "Ohzi";
                    Char1speech.text = "It wanted to learn so I thought-";
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
                     Char3speech.text = "You thought you’d try to use my class to teach it meditation?";
             }
             else if (primeInt == 17){
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "";
                      Char2speech.text = "";
                      Char3name.text = "Professor";
                      Char3speech.text = "Do I have nothing else to offer?!";
              }
        else if (primeInt == 18){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "...";
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
//After dialogue options
         else if (primeInt == 20){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "Professor";
                  Char3speech.text = "Ahem, ANYWAY!";
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
                Char1speech.text = "I meannn, it's not like your class is good for much else anyway…";
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
                    Char3name.text = "Professor";
                    Char3speech.text = "...";
               }
               else if (primeInt == 102){
                        Char1name.text = "Ohzi";
                        Char1speech.text = "...";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "";
                   }
                   else if (primeInt == 103){
                            Char1name.text = "";
                            Char1speech.text = "";
                            Char2name.text = "";
                            Char2speech.text = "";
                            Char3name.text = "Professor";
                            Char3speech.text = "...Really?";
                       }
                       else if (primeInt == 104){
                                Char1name.text = "";
                                Char1speech.text = "";
                                Char2name.text = "Pigeon";
                                Char2speech.text = "Coo!";
                                Char3name.text = "";
                                Char3speech.text = "";
                           }
           else if (primeInt == 105){
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "";
                    Char2speech.text = "";
                    Char3name.text = "Professor";
                    Char3speech.text = "Nobody asked for your opinion!!";
                primeInt = 19;
        }

// ENCOUNTER AFTER CHOICE #2
       else if (primeInt == 200){
                Char1name.text = "Ohzi";
                Char1speech.text = "I can explain, just let me–";
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
                 Char3name.text = "Professor";
                 Char3speech.text = "No, I see how it is.";
         }
         else if (primeInt == 202){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "Professor";
                  Char3speech.text = "You don't appreciate my skill as your professor.";
          }
          else if (primeInt == 203){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "Professor";
                   Char3speech.text = "MAYBE I'LL JUST QUIT!";
           }
           else if (primeInt == 204){
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "Pigeon";
                    Char2speech.text = "CooCoo.";
                    Char3name.text = "";
                    Char3speech.text = "";
            }
            else if (primeInt == 205){
                     Char1name.text = "Ohzi";
                     Char1speech.text = "Shh– quiet!!";
                     Char2name.text = "";
                     Char2speech.text = "";
                     Char3name.text = "";
                     Char3speech.text = "";
             }
             else if (primeInt == 206){
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "";
                      Char2speech.text = "";
                      Char3name.text = "Professor";
                      Char3speech.text = "What? What did you say?";
              }
              else if (primeInt == 207){
                       Char1name.text = "Ohzi";
                       Char1speech.text = "Nothing!! Nothing.";
                       Char2name.text = "";
                       Char2speech.text = "";
                       Char3name.text = "";
                       Char3speech.text = "";
               }
               else if (primeInt == 200){
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "Professor";
                        Char3speech.text = "No, not you. Pigeon...do you… Believe in me?";
                }
                else if (primeInt == 208){
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "Pigeon";
                         Char2speech.text = "*Blinks.*";
                         Char3name.text = "";
                         Char3speech.text = "";
                 }
        else if (primeInt == 209){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "Uh...";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
                primeInt = 19;
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "Ohzi";
                Char1speech.text = "It’s not like your class is *that* good.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "Ohzi";
                Char1speech.text = "I can explain–";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene4b"); //Ending 3c
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene4c"); //Scene 4B
        }
        public void SceneChange3(){
                SceneManager.LoadScene("End_Lose3c"); //Scene 4A
        }
}
