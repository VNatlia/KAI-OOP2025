#ifndef STRING_H
#define STRING_H

#include <string>
#include <iostream>

class String
{
private:
    std::string value; 
public:
    String(std::string val);
    String(String& other);

    size_t getLength();
    std::string reverseString();
    std::string getValue();
};

#endif