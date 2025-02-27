
#ifndef STRING_H 
#define STRING_H 
#include <string> 

class String 
{
public:
    String(std::string val); 

    size_t getLength(); 

    std::string reverseString(); 
    std::string getValue(); 
    std::string value;
};

#endif
if


