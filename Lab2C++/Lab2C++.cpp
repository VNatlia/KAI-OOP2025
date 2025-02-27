#include <iostream>
#include "string.h"

using namespace std;

int main()
{
    std::setlocale(LC_ALL, "uk_UA.UTF-8"); 

    string userInput;
    cout << "Введіть рядок: "; 
    getline(cin, userInput);

    String myString(userInput); 

    cout << "Введений рядок: " << myString.getValue() << endl;

    cout << "Довжина рядка: " << myString.getLength() << endl;

    cout << "Обернений рядок: " << myString.reverseString() << endl;
}