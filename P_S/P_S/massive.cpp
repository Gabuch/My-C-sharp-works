#include "massive.h"
#include <iostream>
#include <fstream>
#include <time.h>
using namespace std;


void massive()
{

	setlocale(LC_ALL, "Russian");
	string str;
	cout << "¬ведите размер массива:" << " ";
	getline(cin, str);
	if (!proverka(str)) {
		cout << "¬ведите действительное число" << '\n';
		massive();
	}
	if (str.find("/") == -1 and str.find(".") == str.rfind(".")) {
		int f = 0.0;
		stringstream dd(str);
		dd >> f;
		int* mass = new int[f];
		for (int i = 0; i < f; i++)
		{
			mass[i] = (i * 2) + 1;
			cout << mass[i] << " ";
		}

	}
}





