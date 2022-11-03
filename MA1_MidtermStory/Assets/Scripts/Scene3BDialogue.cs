using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3BDialogue : MonoBehaviour {
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

        public GameObject ArtChar3a;   //RA
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

        ArtChar3a.SetActive(true);
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
               ArtChar3a.SetActive(false);
               ArtChar3c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "RA";
                Char3speech.text = "Hey, Ohzi, what are you doing here?";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "RA";
                Char3speech.text = "Didn’t you have class–";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
         ArtChar3c.SetActive(false);
         ArtChar3b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "RA";
                Char3speech.text = "Wait, Is that a pigeon??";
        }
       else if (primeInt == 5){
         ArtChar2a.SetActive(false);
         ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pigeon";
                Char2speech.text = "...";
                Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(true);
                Char1name.text = "Ohzi";
                Char2name.text = "Uhhh...Uhhh noo? Pshhh, why would it be–";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "RA";
                Char3speech.text = "Didn’t you listen during orientation?";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "RA";
                Char3speech.text = "No pets allowed in the dorms!";
        }
        else if (primeInt == 9){
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
           ArtChar3e.SetActive(false);
           ArtChar3d.SetActive(false);
            ArtChar3a.SetActive(false);
           ArtChar3e.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "RA";
                  Char3speech.text = " What is it then?";
          }
          else if (primeInt == 21){
            ArtChar3e.SetActive(false);
            ArtChar3a.SetActive(true);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Pigeon";
                   Char2speech.text = "*Blinks.*";
                   Char3name.text = "";
                   Char3speech.text = "";
           }
          else if (primeInt == 22){
            ArtChar1a.SetActive(false);
           ArtChar1b.SetActive(true);

          //  ArtChar3.SetActive(true);
                  Char1name.text = "Ohzi";
                  Char1speech.text = " It’s uh… a… *starts sweating*";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
            }

            else if (primeInt == 23){
              ArtChar2a.SetActive(false);
             ArtChar2d.SetActive(true);
             ArtChar3a.SetActive(false);
             ArtChar3d.SetActive(true);
                     Char1name.text = "";
                     Char1speech.text = "";
                     Char2name.text = "";
                     Char2speech.text = "";
                     Char3name.text = "RA";
                     Char3speech.text = "You’re not making a very good case for yourself.";
                             // Turn off "Next" button, turn on "Choice" buttons
                             nextButton.SetActive(false);
                             allowSpace = false;
                             NextScene1Button.SetActive(true);
                             NextScene2Button.SetActive(true);
                             NextScene3Button.SetActive(true);
                    }

// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
         ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(true);
        ArtChar2b.SetActive(false);
        ArtChar2e.SetActive(true);
        ArtChar3b.SetActive(false);
        ArtChar3e.SetActive(true);
                Char1name.text = "Ohzi";
                Char1speech.text = " IT'S NOT A PET! IT'S MUCH MORE THAN THAT!!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
           }
           else if (primeInt == 102){
             ArtChar1c.SetActive(false);
            ArtChar1a.SetActive(true);
            ArtChar2e.SetActive(false);
            ArtChar2a.SetActive(true);
            ArtChar3e.SetActive(false);
            ArtChar3a.SetActive(true);
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "";
                    Char2speech.text = "";
                    Char3name.text = "RA";
                    Char3speech.text = "O...kay...! Not sure why you're yelling...";
                primeInt = 19;
        }

// ENCOUNTER AFTER CHOICE #2
       else if (primeInt == 200){
         ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(true);
        ArtChar2b.SetActive(false);
        ArtChar2e.SetActive(true);
        ArtChar3b.SetActive(false);
        ArtChar3e.SetActive(true);
                Char1name.text = "Ohzi";
                Char1speech.text = "But it’s not *myyyyy* pet! Not my fault!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 201){
          ArtChar1c.SetActive(false);
         ArtChar1a.SetActive(true);
         ArtChar2e.SetActive(false);
         ArtChar2a.SetActive(true);
         ArtChar3e.SetActive(false);
         ArtChar3a.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "RA";
                 Char3speech.text = "Mhmmmm, Ok…";
                primeInt = 19;
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
          
                Char1name.text = "Ohzi";
                Char1speech.text = "It’s not a pet!";
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
                Char1speech.text = "But it’s not *my* pet!";
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
               SceneManager.LoadScene("End_Lose3b"); //Ending 3B
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene4b"); //Scene 4B
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene4a"); //Scene 4A
        }
}
