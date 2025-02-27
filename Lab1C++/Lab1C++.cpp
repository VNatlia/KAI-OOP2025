#include <iostream>
#include "string.h" // підключення класу

using namespace std;

int main()
{
    string userInput; 
    cout << "Введіть рядок: ";
    getline(cin, userInput); 

    String myString(userInput); 

   
    cout << "Введений рядок: " << myString.getValue() << endl;  

    cout << "Довжина рядка: " << myString.getLength() << endl;

    cout << "Обернений рядок: " << myString.reverseString() << endl;

    return 0;
}