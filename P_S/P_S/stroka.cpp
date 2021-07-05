#include "iostream"
#include "string"

#include "stroka.h"

using namespace std;

void stroka() 
{
	setlocale(LC_ALL, "Russian");
	cout << "¬ведите текст" << " ";
	string text;
	cin >> text;
	for (int i = 0; i < text.length(); i++) {
		if (i == 1 || i == 3) {
			cout << "";
		}
		else {
			cout << text[i];
		}
	}
}
