Console.WriteLine("Hello, World!");

Random random = new Random();

int[] vector = new int[50];

for (int i = 0; i < vector.Length; i++)
{
    vector[i] = random.Next(1, 10);

}

Dictionary<int, int> seRepite = new Dictionary<int, int>();

foreach (int i in vector)
{
    //esta clasula if verifica si el numero ya se encuentra en el diccionario, si es asi, le suma 1 a su valor, si no, lo agrega con valor 1
    if (seRepite.ContainsKey(i))
    {
        seRepite[i]++;
    }
    else
    {
        seRepite[i] = 1;
    }

    //la clausula "seRepite[i]++" asigna en "[i]" el valor de la clave (key) y luevo suma 1 en el "value" del diccionario en caso de que se
    //repita en el recorrido del vector.

    //el diccionario se divide en <"key" y "value">, el "key" es el numero que se repite y el "value" es la cantidad de veces que se repite.

}

int cantidad = 0, moda = -1;


foreach (KeyValuePair<int, int> n in seRepite)
{
    if (n.Value > cantidad)
    {
        cantidad = n.Value;
        moda = n.Key;
    }
}

Console.WriteLine("el numero moda es: " + moda + " y se repite: " + cantidad + " veces");

foreach (int j in vector)
{
    Console.Write(j + "\t");
}
