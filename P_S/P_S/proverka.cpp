#include "proverka.h"
bool proverka(string str)
{
	int b = 0;
	replace(str.begin(), str.end(), ',', '.');
	if (b = find_if_not(str.begin(), str.end(), [](char c) { return c == ' ' || (c >= '.' && c <= '9'); }) != str.end())
		return false;
	else
		return true;
}
