using UnityEngine;

public class Caveira: Enemy //Herdando a classe Enemy na Unity, diminuindo bastante as linhas de códigos
{
    protected override void Introduction() //Sobreescrevendo a função Introduction() da classe Enemy
    {
        base.Introduction();
        Debug.Log("Outra frase");
    }
}
