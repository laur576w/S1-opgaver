int a = 1;
int b = 2;
int c = 3;
int x;

//opgave 9.1
if (a == 1)
    x = 1;
if (b == 1)
    x = 2;
if (c == 3) //ding
    x = 3;


//opgave 9.2
if (a != 1)
    x = 1;
else if (b == 2) // ding
    x = 2;
else if (c == 3)
    x = 3;


//opgave 9.3 None of them
if (a == 2) {
    x = 1;
    if (b == 2)
        x = 2;
}
else if (c == 1)
    x = 3;


//opgave 9.4
if (a + b == b)
    x = 1;
else {
    if (b - a == a) //ding
        x = 2;
    if (c - b == b)
        x = 3;
}
