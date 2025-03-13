#include <iostream>
#include "string.h"
#include <windows.h> 

using namespace std;

int main()
{
    std::setlocale(LC_ALL, "uk_UA.UTF-8");

    string input2, input3;
    cout << "Enter a string for S2: ";
    getline(cin, input2);

    cout << "Enter a string for S3: ";
    getline(cin, input3);

    String S2(input2);
    String S3(input3);

    // delete the character '#'
    S2 = S2 - '#'; 

    // Adding S2 + S3
    String S1 = S2 + S3;

    cout << "\nResults:\n"; 
    cout << S1.getValue("Value: ") << endl; //перевантаж +
    cout << "Length of S1: " << S1.getLength() << endl;


    return 0;
}

