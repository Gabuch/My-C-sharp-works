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
#include "P_S.h"
#include "stroka.h"
#include "stroka1.h"
#include "stroka2.h"
#include "proverka2.h"
#include "stroka3.h"
#include "krug.h"
#include "massive.h"
using namespace std;
int main()
{
	string str;
	setlocale(LC_ALL, "Russian");
	cout << "������:\n " << endl;
	cout << "1. ����� ������� � �������� �������������\n"
		<< "2. ����� ������� � ����� ����������\n"
		<< "3. ������� ������ �������\n"
		<< "4. �������� 2 � 4 ������� � ������\n"
		<< "5. ������� ��� �������\n"
		<< "6. �������� ������� ������ � ��������� ������\n"
		<< "7. �������� ������ ������ �� ������ ��������� �� �����\n"
		<< "\n0.�����"
		<< "\n�������� ����� ������: " << endl;

	getline(cin, str);
	if (!proverka(str)) {
		cout << "������! ������� ����� �����.\n ";
	}
	else {
		int d = 0;
		stringstream dd(str);
		dd >> d;
		if (d == 1) {
			system("cls");
			P_S();
			system("pause");
			system("cls");
			main();
		}
		if (d == 2) {
			system("cls");
			krug();
			system("pause");
			system("cls");
			main();
		}
		if (d == 3) {
			system("cls");
			massive();
			system("pause");
			system("cls");
			main();
		}
		if (d == 4) {
			system("cls");
			stroka();
			system("pause");
			system("cls");
			main();
		}
		if (d == 5) {
			system("cls");
			stroka1();
			system("pause");
			system("cls");
			main();
		}
		if (d == 6) {
			system("cls");
			stroka2();
			system("pause");
			system("cls");
			main();
		}
		if (d == 7) {
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






