using UnityEngine;

public class Caveira: Enemy //Herdando a classe Enemy na Unity, diminuindo bastante as linhas de c�digos
{
    protected override void Introduction() //Sobreescrevendo a fun��o Introduction() da classe Enemy
    {
        base.Introduction();
        Debug.Log("Outra frase");
    }
}
