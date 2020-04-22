using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

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


            void Update()
            {
                //Aqui o código está ligeiramente diferente do original da aula
                ManageState();
            }

// antes era "private void ManageState()" e acusava erro (rauL)
            void ManageState(){
                var nextStates=state.GetNextStates();

                if(Input.GetKeyDown(KeyCode.Alpha1))
                {
                    state = nextStates[0];
                }
            }
  

    }
}
