using System.Numerics;



Console.WriteLine("Hello, World!");



Random random = new Random();

int[] vector = new int[50];



for (int i = 0; i < vector.Length; i++)
{
    vector[i] = random.Next(1, 10);
}


int numeroModa = -1;

int seRepite = -1;

int aux, aux2 = -1;

for (int j = 0; j < vector.Length; j++)

{

    aux2 = vector[j];

    int contador = 0;

    for (int k = 0; k < vector.Length; k++)
    {

        aux = vector[k];

        if (aux2 == aux)
        {

            contador++;

        }

    }





    if (seRepite < contador)
    {
        seRepite = contador;

        numeroModa = aux2;

    }



}



Console.WriteLine("el numero moda es: " + numeroModa + " y se repite: " + seRepite + " veces");



for (int i = 0; i < vector.Length; i++)
{

    Console.Write(vector[i] + "\t");

}


