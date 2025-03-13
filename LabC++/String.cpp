#include "string.h"
#include <algorithm>
#include <string>

String::String() : value("") {} //���������. �� �������������

String::String(std::string val) : value(val) {} //���������. ��������

String::String(const String& other) : value(other.value) {} //���������. ���������

String::~String() //����������
{
    std::cout << "���������� ��������� ���: " << value << std::endl;
}

size_t String::getLength() //����� �������� ����. �����
{
    return value.length();
}

std::string String::getValue() //����� �����. ������� �����
{
    return value;
}
std::string String::getValue(std::string prefix) //���������������� ������ 
{
    return prefix + value;
}

String String::operator+(const String& other) const //����������. ���������+
{
    return String(value + other.value);
}
String String::operator-(char ch)
{
    std::string newValue = value;
    newValue.erase(std::remove(newValue.begin(), newValue.end(), ch), newValue.end());
    return String(newValue);
}
