#include "string.h"
#include <algorithm>
#include <string>

String::String() : value("") {} //конструкт. за замовчуванням

String::String(std::string val) : value(val) {} //конструкт. параметр

String::String(const String& other) : value(other.value) {} //конструкт. копіювання


String::~String() //деструктор
{
    std::cout << "Деструктор викликано для: " << value << std::endl;
}

size_t String::getLength() //метод оримання довж. рядка
{
    return value.length();
}

std::string String::getValue() //метод отрим. значень рядка
{
    return value;
}
std::string String::getValue(std::string prefix) std::string String::getValue(std::string prefix) //перенавантаження метода 
{
    return prefix + value;
}

String String::operator+(const String& other) const //перевантаж. оператора+
{
    return String(value + other.value);
}
String String::operator-(char ch)
{
    std::string newValue = value;
    newValue.erase(std::remove(newValue.begin(), newValue.end(), ch), newValue.end());
    return String(newValue);
}
