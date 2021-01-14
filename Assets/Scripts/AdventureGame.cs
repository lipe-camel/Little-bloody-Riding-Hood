using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    //No unity essa parte se linka com o bloco de texto que vai ser usado. Nesse caso, o componente Text do GameObject "Game Text"
    [SerializeField] Text textComponent;
    //Isso é para escolher qual state vai iniciar o jogo
    [SerializeField] State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        //Com o GameObject linkado, agora é possível escolher o que vai ser escrito programaticamente
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        for(int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextStates[i];
            }
        }
        textComponent.text = state.GetStateStory();
    }
}
