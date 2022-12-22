




int a1 = 32;
int b1 = 23;
int c1 = 3;
int a2 = 12;
int b2 = 451;
int c2 = 21;
int a3 = 7;
int b3 = 63;
int c3 = 55;

int Max(int ar1, int ar2, int ar3)
{
    int result = ar1;
    if (ar2 > result) result = ar2;
    if (ar3 > result) result = ar3;
    return result;
}


// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, c2, b2);
// int max3 = Max(a3, b3, c3);

//int max = Max(max1,max2,max3);

int max = Max
             (Max(a1, b1, c1),
              Max(a2, c2, b2),
              Max(a3, b3, c3));


Console.WriteLine(max);

