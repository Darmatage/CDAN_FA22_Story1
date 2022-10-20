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

        public GameObject ArtChar2a;   //pigeon

        //public GameObject ArtChar3;
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
          ArtChar1a.SetActive(false);
        ArtChar2a.SetActive(false);
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
           Char1name.text = "";
           Char1speech.text = "";
           Char2name.text = "Pigeon";
           Char2speech.text = " …Coo?";
   }
   else if (primeInt == 21){
            Char1name.text = "Ohzi";
            Char1speech.text = "Haha of course I’ll help you register, you just need a few credits to graduate with a degree afterall. In this game college is as free as a bird.";
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
             Char1speech.text = "Well I guess you could actually have a different opinion about that I realize.";
             Char2name.text = "";
             Char2speech.text = "";
   }
   else if (primeInt == 24){
             Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "Pigeon";
             Char2speech.text = "Coo";
   }
   else if (primeInt == 25){
             Char1name.text = "Ohzi";
             Char1speech.text = "Alright well, what class did you want to go to?";
             Char2name.text = "";
             Char2speech.text = "";
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
} }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
 public void Choice1aFunct() {
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
             SceneManager.LoadScene("End_Lose"); //Art Class -> Ending 2B
      }
      public void SceneChange2(){
              SceneManager.LoadScene("Scene3c"); //Philosophy Class --> Scene 3C
      }
      public void SceneChange3(){
              SceneManager.LoadScene("Scene3d"); //Science Class --> Scene 3D
      }
  }
