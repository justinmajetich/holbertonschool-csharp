using System;

class Character
{
    public static bool IsLower(char c) {
        // If character is lowercase return true
        if (c >= 'a' && c <= 'z') {
            return true;
        } else {
            return false;
        }
    }
}