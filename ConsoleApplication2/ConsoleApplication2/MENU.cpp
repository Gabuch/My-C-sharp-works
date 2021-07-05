#include <iostream> 
#include <string> 
#include <cctype> 
#include <algorithm> 
#include <iostream> 
#include <string> 
#include <cctype> 
#include <algorithm> 
#include <sstream> 
#include <cmath> 
#include <cstdlib>
#include "proverka.h"
#include "stroka.h"
#include "stroka1.h"
#include "stroka2.h"
#include "stroka3.h"

using namespace std;
int main()
{
	string str;
	setlocale(LC_ALL, "Russian");
	cout << "Задачи:\n " << endl;
	cout << "1. В заданной строке добавить в конец строки символ «»\n"
		<< "2. Удалить первое слово заданной строки. Разделителем слов считается пробел\n"
		<< "3. В заданной строке вместо каждого пробела поставить символ _\n"
		<< "4. В заданной строке посчитать количество русских букв А\n"
		<< "\n0.Выйти"
		<< "\nВыберите номер задачи: " << endl;

	getline(cin, str);
	if (!proverka_c(str)) {
		cout << "Ошибка! Введите целое число.\n ";
	}
	else {
		int d = 0;
		stringstream dd(str);
		dd >> d;
		if (d == 1) {
			system("cls");
			stroka();
			system("pause");
			system("cls");
			main();
		}
		if (d == 2) {
			system("cls");
			stroka1();
			system("pause");
			system("cls");
			main();
		}
		if (d == 3) {
			system("cls");
			stroka2();
			system("pause");
			system("cls");
			main();
		}
		if (d == 4) {
			system("cls");
			stroka3();
			system("pause");
			system("cls");
			main();
		}
		if (d == 0) {
			exit(1);
		}
	}
}




