using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//menuName ser� como vai aparecer na barra de clique direito, fileName � a sugest�o de nomenclatura ao criar
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    //storyText � o que foi escrito no Inspector do ScriptableObject
    [TextArea(20,30)] [SerializeField] string storyText;
    //nextStates s�o os states escolhidos no inspector
    [SerializeField] State[] nextStates;

    //Esse m�todo retorna ao script uma informa��o que est� no inspector do Unity.
    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }

}
