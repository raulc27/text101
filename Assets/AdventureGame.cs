using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

//codigo modificado
//**

public class AdventureGame : MonoBehaviour
{


    [SerializeField] Text textComponent;
    [SerializeField] State startingState;


    State state;


    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();

    }
            void Update()
            {
                //voltando ao código original
                ManageState();
            }

// consertado erro do  "private void ManageState()", antes acusava erro (rauL)
            private void ManageState(){
                var nextStates=state.GetNextStates();

                if(Input.GetKeyDown(KeyCode.Alpha1))
                {
                    state = nextStates[0];
                }
                else if(Input.GetKeyDown(KeyCode.Alpha2))
                {
                    state = nextStates[1];
                }
                else if(Input.GetKeyDown(KeyCode.Alpha3))
                {
                    state = nextStates[2];
                }

                textComponent.text=state.GetStateStory();
            }
  

    
}
