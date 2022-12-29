using System.Collections;
using System.Collections.Generic;
using UnityEngine;
USing TMpro;

public class login : MonoBehaviour
{
    [SerializeField] private TMp_InputField usernameInputField;
    [SerializeField] private TMp_InputField usernameInputField;
    

    public void OnLoginClick()
    {
        string username = usernameInputField.text;
        string password = usernameInputField.text;

        Debug.Log($"{username} : {password}");
    }

}
