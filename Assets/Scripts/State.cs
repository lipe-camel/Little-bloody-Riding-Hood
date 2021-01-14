using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//menuName será como vai aparecer na barra de clique direito, fileName é a sugestão de nomenclatura ao criar
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    //storyText é o que foi escrito no Inspector do ScriptableObject
    [TextArea(20,30)] [SerializeField] string storyText;
    //nextStates são os states escolhidos no inspector
    [SerializeField] State[] nextStates;

    //Esse método retorna ao script uma informação que está no inspector do Unity.
    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }

}
