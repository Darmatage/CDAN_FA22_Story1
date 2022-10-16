using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2aDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;   //Ohzi - player
        public GameObject ArtChar2;   //vendor
        public GameObject ArtChar3;   //pigeon
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
               ArtChar1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "Ohzi";
                Char1speech.text = "Alright, I’m going to take you back to my dorm building.";
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
                Char2speech.text = "Coo";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "Ohzi";
                Char1speech.text = " I know, I know. I’ll give you a little bread when I get there.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "*Blinks.*";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "Ohzi";
                Char1speech.text = "bird is our friend";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 7){
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
         else if (primeInt == 20){
           ArtChar2.SetActive(false);
                  Char1name.text = "Ohzi";
                  Char1speech.text = "Any hoo-ha. I don’t know where you’re going to sleep.";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
          else if (primeInt == 21){
                   Char1name.text = "Pigeon";
                   Char1speech.text = "...Coo";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
           }
          else if (primeInt == 22){
            ArtChar3.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "Pigeon";
                  Char3speech.text = "Coo";
            }

            else if (primeInt == 23){
                     Char1name.text = "Ohzi";
                     Char1speech.text = "... That’s a pigeon.";
                     Char2name.text = "";
                     Char2speech.text = "";
                     Char3name.text = "";
                     Char3speech.text = "";
             }
            else if (primeInt == 24){
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "";
                    Char2speech.text = "";
                    Char3name.text = "Pigeon";
                    Char3speech.text = "*Blinks.*";
              }

              else if (primeInt == 25){
                       Char1name.text = "Ohzi";
                       Char1speech.text = "I’ve always wanted a pigeon. I just think they’re neat";
                       Char2name.text = "";
                       Char2speech.text = "";
                       Char3name.text = "";
                       Char3speech.text = "";
               }
              else if (primeInt == 26){
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "";
                      Char2speech.text = "";
                      Char3name.text = "Pigeon";
                      Char3speech.text = "Coo";
                }
                else if (primeInt == 27){
                         Char1name.text = "Ohzi";
                         Char1speech.text = "Are you looking at me??";
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
                           Char1speech.text = "Do you want to come with me?";
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "…Coo.";
        }
       else if (primeInt == 101){
                Char1name.text = "Ohzi";
                Char1speech.text = "Aww don't be such a baby.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19;
        }

// ENCOUNTER AFTER CHOICE #2
       else if (primeInt == 200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Vendor";
                Char2speech.text = "What do I look like, a Tour Guide?";
        }
       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Vendor";
                Char2speech.text = "It’s the first nice day in weeks, go take a hike around the block.";
                primeInt = 19;
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "Ohzi";
                Char1speech.text = "Too much will give you a stomach ache!";
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
                Char1speech.text = "Do you think I can afford that much bread?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene2c");
        }
}
