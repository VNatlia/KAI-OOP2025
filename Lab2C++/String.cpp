
#include "string.h"
#include <algorithm>

String::String(std::string val) : value(val) {} 

String::String(String& other) : value(other.value) {} 

String::~String()
{
    std::cout << "Деструктор викликано для: " << value << std::endl;                                                 
}

size_t String::getLength()
{  
    return value.length();
}

std::string String::reverseString()
{
    std::string reversed;
    for (size_t i = value.length(); i > 0; --i)
    {      
        reversed += value[i - 1];   
    } 
    return reversed;
}

std::string String::getValue()
{  // Повертає рядок value.
    return value;
}


