using UnityEngine;
//Use this to access the the CustomMessageBox scripts.
using CustomMessageBoxes;

class CreateMessageBoxOnStart : MonoBehaviour {

    //Set this in the Unity Inspector or using code.
    public MessageStyle myStyle;

    void Start()
    {
        //This creates the message box with the given style.
       // MessageBoxCreator.CreateMessageBox(myStyle);

        //This would create a message box and override the text whilst keeping to the style.
        MessageBoxCreator.CreateMessageBox(myStyle, "Bienvenido(a): "+Menu.nombre, "La compañia Xim-Miners puso unas vigas para delimitar la zona en la que tienes que minar. Mucha Suerte ", "Aceptar");
    }
}
