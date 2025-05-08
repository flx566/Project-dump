int[,,] mas = {
    { {1,2}, {3,4} },
    { {4,5}, {6,7} },
    { {7,8}, {9,10} },
    { {10,11}, {12,13} }
};
for (int i = 0; i < 4; i++)
{
    Console.Write("{{");
    for (int j = 0; j < 2; j++)
    {
        Console.Write("{");
        for (int k = 0; k < 2; k++)
        {
            Console.Write(mas[i,j,k]);
            if (k < 1) Console.Write(" , ");
        }
        Console.Write("}");
        if (j < 1) Console.Write(" , ");
    }
    Console.Write("}}, ");
}

