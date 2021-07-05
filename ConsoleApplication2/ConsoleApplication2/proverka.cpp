#include "proverka.h"


bool proverka_c(string str)
{
	int b = 0;
	if (b = find_if_not(str.begin(), str.end(), [](char c) { return c == ' ' || (c >= '0' && c <= '9'); }) != str.end())
		return false;
	else
		return true;
}

