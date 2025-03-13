#ifndef STRING_H
#define STRING_H

#include <string>
#include <iostream>
#include <string>
class String
{
private:
    std::string value;

public:
    String();
    String(std::string val);
    String(const String& other); //конструкт. копіювання
    ~String();

    size_t getLength();
    std::string getValue();
    std::string getValue(std::string); //перевантаж. метод

    String operator+(const String& other)const; //перевантаж оператор
    String operator-(char ch) ;
};

#endif


