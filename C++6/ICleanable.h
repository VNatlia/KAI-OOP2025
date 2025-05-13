#pragma once

// Інтерфейс для очищення пробілів
class ICleanable {
public:
    virtual void CleanSpaces() = 0;
    virtual ~ICleanable() = default;
};
