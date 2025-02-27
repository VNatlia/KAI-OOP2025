

#include "string.h" //підключення файл з описами класу

String::String(std::string val) 
{
    value = val;  
}
size_t String::getLength() 
{
    return value.length(); 
}

std::string String::reverseString() //реалізація методу для обернення рядка
{
    std::string reversed; 
    for (size_t i = value.length(); i > 0; --i) 
    { 
        reversed += value[i - 1]; 
    }                
    return reversed;
}

std::string String::getValue()
{
    return value;
}


