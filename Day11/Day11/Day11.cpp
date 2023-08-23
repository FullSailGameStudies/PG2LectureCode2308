// Day11.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>
//using namespace std;

enum Powers
{
	Speed, Invisibility = 10, Telepathy, MindControl, Magnetism
};

unsigned long Factorial(unsigned int N)
{
	if (N <= 1) return 1;
	return N * Factorial(N - 1);
}

int main()
{
	unsigned long result = Factorial(5);
	std::cout << "5! = " << result << "\n";
	Powers myPower = Powers::Telepathy;
	switch (myPower)
	{
	case Speed:
		break;
	case Invisibility:
		break;
	case Telepathy:
		break;
	case MindControl:
		break;
	case Magnetism:
		break;
	default:
		break;
	}
	//std - standard namespace
	//:: -- scope resolution operator
	//cout -- console output stream
	//<< -- insertion operator

	//cout is C++ way to print
	//printf is C way to print
	std::cout << "Hello Gotham!\n";

	char best[] = "Batman";//adds a \0  (null terminator)
	char meh[] = { 'A','q','u','a','m','a','n','\0' };
	std::cout << best << "\n" << meh << "\n";
	for (int i = 0; i < sizeof(best) / sizeof(char); i++)//way to calc the size of a stack array
	{
		std::cout << best[i] << ".";
	}
	std::cout << "\n";

	//range-based for loop
	for (auto c : meh)
	{
		std::cout << c << "?";
	}
	std::cout << "\n";


	std::cout << "Random\n";
	//seed the random # generator
	srand(time(NULL));

	//get a random #
	int num = rand();//0-RAND_MAX (32767)
	//0-100
	int grade = rand() % 101;//returns the remainder of dividing by the #

	switch (num)//ONLY integral values
	{
	case 1:
		std::cout << "1";
	case 2:
		std::cout << "2\n";
		break;
	default:
		break;
	}

	std::vector<int> scores;//stack instance
	scores.push_back(rand());//adds a value to the end of the vector
	scores.push_back(rand());
	scores.push_back(rand());
	scores.push_back(rand());
	scores.push_back(rand());
	for (size_t i = 0; i < scores.size(); i++)
	{
		std::cout << scores[i] << "\n";
	}
}