using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2bDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
    //    public Text Char3name;
    //    public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;   //Ohzi - player
        //public GameObject ArtChar1b;
        //public GameObject ArtChar1c;
        //public GameObject ArtChar1d;
        //public GameObject ArtChar1e;

        public GameObject ArtChar2a;   //pigeon
        //public GameObject ArtChar2b;
        //public GameObject ArtChar2c;
        //public GameObject ArtChar2d;
        //public GameObject ArtChar2e;
        //public GameObject ArtChar3;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        //public GameObject Choice2a;
        //public GameObject Choice2b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        //ArtChar1b.SetActive(false);
        //ArtChar1c.SetActive(false);
        //ArtChar1d.SetActive(false);
        //ArtChar1e.SetActive(false);

        ArtChar2a.SetActive(false);
        //ArtChar2b.SetActive(false);
        //ArtChar2c.SetActive(false);
        //ArtChar2d.SetActive(false);
        //ArtChar2e.SetActive(false);
      //  ArtChar3.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        //Choice2a.SetActive(false);
        //Choice2b.SetActive(false);
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
           DialogueDisplay.SetActive(true);
                Char1name.text = "Ohzi";
                Char1speech.text = " Alright then, I guess I’m going to take you to class with me!";
                Char2name.text = "";
                Char2speech.text = "";
                //Char3name.text = "";
                //Char3speech.text = "";
        }
        else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "CooCoo! *Flutters wings.*";
                //Char3name.text = "";
                //Char3speech.text = "";
        }
       else if (primeInt == 4){
                Char1name.text = "Ohzi";
                Char1speech.text = "I mean, of course you can read right?";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "*Blinks.*";
        }
       else if (primeInt == 6){
         Char1name.text = "";
         Char1speech.text = "";
         Char2name.text = "";
         Char2speech.text = "";
        // Turn off "Next" button, turn on "Choice" buttons
        nextButton.SetActive(false);
        allowSpace = false;
        Choice1a.SetActive(true); // function Choice1aFunct()
        Choice1b.SetActive(true); // function Choice1bFunct()

        }



// Dialogue after choice 1

         else if (primeInt == 20){
                    Char1name.text = "Ohzi";
                    Char1speech.text = "You just have to stay quiet until we are in the dorm.";
                    Char2name.text = "";
                    Char2speech.text = "";
            }
            else if (primeInt == 21){
                     Char1name.text = "Ohzi";
                     Char1speech.text = "We don't want to get caught by security.";
                     Char2name.text = "";
                     Char2speech.text = "";
            }
            else if (primeInt == 22){
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "Pigeon";
                      Char2speech.text = "*Blinks.*";
            }
            else if (primeInt == 23){
                      Char1name.text = "Ohzi";
                      Char1speech.text = "What? You don’t trust me yet?";
                      Char2name.text = "";
                      Char2speech.text = "";
            }
            else if (primeInt == 24){
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "Pigeon";
                      Char2speech.text = "Cooo…";
            }
            else if (primeInt == 25){
                      Char1name.text = "Ohzi";
                      Char1speech.text = "Okay, okay how much bread do you need?";
                      Char2name.text = "";
                      Char2speech.text = "";
            }
            else if (primeInt == 26){
                      Char1name.text = "Ohzi";
                      Char1speech.text = "*It can't be that bad, they’re only a tiny guy.*";
                      Char2name.text = "";
                      Char2speech.text = "";
            }
            else if (primeInt == 27){
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "Pigeon";
                      Char2speech.text = "CooCOO coooo coo!";
                     // Turn off "Next" button, turn on "Choice" buttons

             }


//dialogue after choice 2
                  else if (primeInt == 30){
                          Char1name.text = "";
                          Char1speech.text = "";
                          Char2name.text = "";
                          Char2speech.text = "";
                          //Char3name.text = "";
                          //Char3speech.text = "";
                    }
                    else if (primeInt == 31){
                            Char1name.text = "";
                            Char1speech.text = "";
                            Char2name.text = "";
                            Char2speech.text = "";
                    }
                    else if (primeInt == 32){
                            Char1name.text = "";
                            Char1speech.text = "";
                            Char2name.text = "";
                            Char2speech.text = "";
                    }
                    else if (primeInt == 33){
                            Char1name.text = "";
                            Char1speech.text = "";
                            Char2name.text = "";
                            Char2speech.text = "";
                    }
                    else if (primeInt == 34){
                            Char1name.text = "";
                            Char1speech.text = "";
                            Char2name.text = "";
                            Char2speech.text = "";
                    }
                    else if (primeInt == 35){
                            Char1name.text = "";
                            Char1speech.text = "";
                            Char2name.text = "";
                            Char2speech.text = "";
                    }
                    else if (primeInt == 36){
                            Char1name.text = "";
                            Char1speech.text = "";
                            Char2name.text = "";
                            Char2speech.text = "";
                    }
                    else if (primeInt == 37){
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

// ENCOUNTER AFTER CHOICE #1A
       else if (primeInt == 100){
                Char1name.text = "Ohzi";
                Char1speech.text = "I just haven’t met anybirdy as smart as you before, I want to see what you can do in college!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "Coo cooo.";
        }
        else if (primeInt == 102){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "Aww you're welcome";
                 Char2name.text = "";
                 Char2speech.text = "";
                primeInt = 19;
         }

// ENCOUNTER AFTER CHOICE #1B
       else if (primeInt == 200){
                Char1name.text = "Ohzi";
                Char1speech.text = "Uhm Did I say I thought you were stupid? No?";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 201){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "pigeon";
                 Char2speech.text = "*Grunts.*";
        }
       else if (primeInt == 202){
                  Char1name.text = "Ohzi";
                  Char1speech.text = "Most birds aren't that smart come on, that is a logical question!";
                  Char2name.text = "";
                  Char2speech.text = "";
        }
       else if (primeInt == 203){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "*Flaps wings & grunts.*";

        }
        else if (primeInt == 204){
                 Char1name.text = "Ohzi";
                 Char1speech.text = " Okay okay you're right I’m sorry I shouldn’t have assumed.";
                 Char2name.text = "";
                 Char2speech.text = "";
                 primeInt = 19;
         }


     // ENCOUNTER AFTER CHOICE #2A
            else if (primeInt == 300){
                     Char1name.text = "";
                     Char1speech.text = "";
                     Char2name.text = "";
                     Char2speech.text = "";
             }
            else if (primeInt == 301){
                     Char1name.text = "";
                     Char1speech.text = "";
                     Char2name.text = "";
                     Char2speech.text = "";
             }
             else if (primeInt == 302){
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "";
                      Char2speech.text = "";
              }
              else if (primeInt == 303){
                       Char1name.text = "";
                       Char1speech.text = "";
                       Char2name.text = "";
                       Char2speech.text = "...";
               }
             else if (primeInt == 304){
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
              }
              else if (primeInt == 306){
                       Char1name.text = "";
                       Char1speech.text = "";
                       Char2name.text = "";
                       Char2speech.text = "";
               }
               else if (primeInt == 307){
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 308){
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "";
                         Char2speech.text = "";
                 }
                 else if (primeInt == 309){
                          Char1name.text = "";
                          Char1speech.text = "";
                          Char2name.text = "";
                          Char2speech.text = "";
                  }
              else if (primeInt == 310){
                       Char1name.text = "";
                       Char1speech.text = "";
                       Char2name.text = "";
                       Char2speech.text = "";
                     primeInt = 29;
             }

     // ENCOUNTER AFTER CHOICE #2B
            else if (primeInt == 400){
                     Char1name.text = "";
                     Char1speech.text = "";
                     Char2name.text = "";
                     Char2speech.text = "";
             }
             else if (primeInt == 401){
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "";
                      Char2speech.text = "";
             }
            else if (primeInt == 402){
                       Char1name.text = "";
                       Char1speech.text = "";
                       Char2name.text = "";
                       Char2speech.text = "";
             }
             else if (primeInt == 404){
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "";
                      Char2speech.text = "";
              }
              else if (primeInt == 405){
                       Char1name.text = "";
                       Char1speech.text = " ";
                       Char2name.text = "";
                       Char2speech.text = "";
               }
               else if (primeInt == 406){
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
            else if (primeInt == 407){
                     Char1name.text = "";
                     Char1speech.text = "";
                     Char2name.text = "";
                     Char2speech.text = "";
                     primeInt = 29;
             }
          }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "Ohzi";
                Char1speech.text = "I just haven’t met a bird as smart as you.";
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
                Char1speech.text = "Did I say I thought you were stupid?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }


        public void SceneChange1(){
               SceneManager.LoadScene("Scene2d");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2e");
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene2f");
        }
}
