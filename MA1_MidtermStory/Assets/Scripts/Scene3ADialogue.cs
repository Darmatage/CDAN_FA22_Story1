using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3ADialogue : MonoBehaviour {
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

        public GameObject ArtChar3a;   //Moosh
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
                Char3name.text = "Moosh";
                Char3speech.text = "Hey! Welcome back Ohzi.";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Moosh";
                Char3speech.text = "I’m glad you're here, I was just working on this and–";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Moosh";
                Char3speech.text = "Wait, Is that a pigeon??";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "...";
                Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "Ohzi";
                Char2name.text = "Uhhh..maybe?";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Moosh";
                Char3speech.text = "It’s gonna eat all of my snacks!";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Moosh";
                Char3speech.text = "Where did you even get that??";
        }
        else if (primeInt == 9){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "I...";
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
                  Char1name.text = "Ohzi";
                  Char1speech.text = "ANYWAY! C’mon, it’s not that bad.";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 21){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Pigeon";
                   Char2speech.text = "Coo Coo. *Blinks twice*";
                   Char3name.text = "";
                   Char3speech.text = "";
           }
          else if (primeInt == 22){
          //  ArtChar3.SetActive(true);
                  Char1name.text = "Ohzi";
                  Char1speech.text = "See! It’s … friendly?";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
            }

            else if (primeInt == 23){
                     Char1name.text = "";
                     Char1speech.text = "";
                     Char2name.text = "";
                     Char2speech.text = "";
                     Char3name.text = "Moosh";
                     Char3speech.text = " But why did you even bring it in here?";
             }
            else if (primeInt == 24){
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "";
                    Char2speech.text = "";
                    Char3name.text = "Moosh";
                    Char3speech.text = "Didnt you know all wild birds are evil!?";
              }

              else if (primeInt == 25){
                       Char1name.text = "";
                       Char1speech.text = "";
                       Char2name.text = "";
                       Char2speech.text = "";
                       Char3name.text = "Moosh";
                       Char3speech.text = "They’ll bite you!";
               }
              else if (primeInt == 26){
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "Pigeon";
                      Char2speech.text = "...";
                      Char3name.text = "";
                      Char3speech.text = "";
                }
                else if (primeInt == 27){
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "";
                         Char2speech.text = "";
                         Char3name.text = "Moosh";
                         Char3speech.text = "Look at it! Look at the pure evil in its eyes–";
                 }
                else if (primeInt == 28){
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "Moosh";
                        Char3speech.text = "Wait, why is it eying me and my guitar?";
                  }
                  else if (primeInt == 29){
                           Char1name.text = "";
                           Char1speech.text = "";
                           Char2name.text = "Pigeon";
                           Char2speech.text = "Coo.";
                           Char3name.text = "";
                           Char3speech.text = "";
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
                Char1speech.text = "They, uh, were on sale at the supermarket?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 101){
                 Char1name.text = "Ohzi";
                 Char1speech.text = "You know… the .. the buy one Burrito, get one Pigeon free sale.";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
         }
         else if (primeInt == 102){
                  Char1name.text = "Ohzi";
                  Char1speech.text = "They have it every Thursday!";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 103){
                   Char1name.text = "Ohzi";
                   Char1speech.text = "You asked me to grab a burrito for you while I was out, remember?";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
           }
           else if (primeInt == 104){
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "";
                    Char2speech.text = "";
                    Char3name.text = "Moosh";
                    Char3speech.text = "Oh Yeah!";
            }
            else if (primeInt == 105){
                     Char1name.text = "";
                     Char1speech.text = "";
                     Char2name.text = "";
                     Char2speech.text = "";
                     Char3name.text = "Moosh";
                     Char3speech.text = "Wait.";
             }
             else if (primeInt == 106){
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "";
                      Char2speech.text = "";
                      Char3name.text = "Moosh";
                      Char3speech.text = "Where’s my burrito?";
              }
              else if (primeInt == 107){
                       Char1name.text = "Ohzi";
                       Char1speech.text = "Oh, right! They were sold out. They only had chicken.";
                       Char2name.text = "";
                       Char2speech.text = "";
                       Char3name.text = "";
                       Char3speech.text = "";
               }
               else if (primeInt == 108){
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "Moosh";
                        Char3speech.text = "But then how did you get the pigeon?";
                }
       else if (primeInt == 109){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Moosh";
                Char3speech.text = "Didn't you say the sale-";
                primeInt = 19;
        }

// ENCOUNTER AFTER CHOICE #2
       else if (primeInt == 200){
                Char1name.text = "Ohzi";
                Char1speech.text = "I just picked it up in the park!";
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
                 Char3speech.text = "You just.";
         }
         else if (primeInt == 202){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "Moosh";
                  Char3speech.text = "Picked it up and took it with you,";
          }
          else if (primeInt == 203){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "Moosh";
                   Char3speech.text = "No questions asked? ";
           }
           else if (primeInt == 204){
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "";
                    Char2speech.text = "";
                    Char3name.text = "Moosh";
                    Char3speech.text = "...Does that count as kidnapping or...?";
            }
            else if (primeInt == 205){
                     Char1name.text = "Ohzi";
                     Char1speech.text = "It wanted to come with me!";
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
                      Char3name.text = "Moosh";
                      Char3speech.text = "How did you even know that??";
              }
       else if (primeInt == 207){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Moosh";
                Char3speech.text = "What if its planning someth--";
                primeInt = 19;
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "Ohzi";
                Char1speech.text = "...got it at the store!";
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
                Char1speech.text = "...picked it up in Evans Way!";
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
               SceneManager.LoadScene(""); //Ending 3A
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene4a"); //Scene 4A
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene3b"); //Scene 3B
        }
}
