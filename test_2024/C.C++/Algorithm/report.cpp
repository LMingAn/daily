#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;


//1
//int main()
//{
//	vector<int> num1, num2, nums;
//	int in = 0;
//	cout << "输入num1数据：";
//	while (cin >> in)
//	{
//		num1.push_back(in);
//		if (cin.get() == '\n')
//			break;
//	}
//	cout << "输入num2数据：";
//	while (cin >> in)
//	{
//		num2.push_back(in);
//		if (cin.get() == '\n')
//			break;
//	}
//	num1.insert(num1.end(), num2.begin(), num2.end());
//	sort(num1.begin(), num1.end());
//	cout << '[';
//	for (in = 0; in < num1.size(); in++)
//	{
//		cout << num1[in];
//		if (in != num1.size() - 1)
//			cout << ", ";
//	}
//	cout << ']';
//	return 0;
//}


//2
//int main()
//{
//	int num = 0, ans = 0;
//	vector<int> nums = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59 };
//	long long n = 0;
//	cin >> num;
//	cout << num << "=";
//	while (num != 1)
//	{
//		for (int a = 0; a < nums.size(); a++)
//		{
//			if (num % nums[a] == 0)
//			{
//				num /= nums[a];
//				cout << nums[a];
//				break;
//			}
//		}
//		if (num != 1)
//			cout << "*";
//	}
//	return 0;
//}


//3
//int main()
//{
//	vector<int> nums;
//	int n = 0, a = 0, b = 0, c = 0;
//	cin >> n;
//	for (a = 0; a < n; a++)
//	{
//		cin >> b;
//		nums.push_back(b);
//	}
//	sort(nums.begin(), nums.end());
//	cout << "[";
//	for (a = 0; a < n; a++)
//	{
//		if (a > 0 && nums[a] == nums[a - 1])
//			continue;
//		for (b = a + 1; b < n; b++)
//		{
//			for (c = b + 1; c < n; c++)
//			{
//				if (nums[a] + nums[b] + nums[c] == 0)
//					cout << "[" << nums[a] << ", " << nums[b] << ", " << nums[c] << "] ";
//			}
//		}
//	}
//	cout << "]";
//}


//4
//int main()
//{
//	int m = 0, n = 0;
//	cout << "m = ";
//	cin >> m;
//	cout << "n = ";
//	cin >> n;
//	int a = m, b = n;
//	while (b)
//	{
//		int c = b;
//		b = a % b;
//		a = c;
//	}
//	cout << "最大公约数：" << a << endl;
//	cout << "最小公倍数：" << (m / a * n) << endl;
//	return 0;
//}


//5
//int taking(int n)
//{
//	if (n == 1)
//		return 10;
//	else
//		return taking(n - 1) + 2;
//}
//
//int main()
//{
//	int n = 5, ans = 0;
//	cout << taking(n);
//	return 0;
//}


//6
void makeSched(int n, vector<vector<pair<int, int>>>& sched)
{
	int players = 1 << n;
	for (int day = 0; day < (n - 1); day++)//遍历比赛天数
	{
		for (int player = 0; player < players; player++)//遍历选手编号
		{
			//选取对应天数 day 所选维度 1<<day ，再通过异或操作将第 day 位翻转，保证双方选手仅第 day 位不同 -- “超立方体维度”
			int opponent = player ^ (1 << day);//对手编号
			if (player < opponent)
				sched[day].push_back({ player + 1, opponent + 1 });
		}
	}
}

void printSched(vector<vector<pair<int, int>>>& sched)
{
	cout << "比赛日程表:" << endl;
	for (int day = 0; day < sched.size(); day++)
	{
		cout << "第" << day + 1 << "天：";
		for (const auto& match : sched[day])
		{
			cout << "(" << match.first << " vs " << match.second << ")";
		}
		cout << endl;
	}
}

int main()
{
	int n = 0;
	cout << "输入n（选手数为2^n，n不能小于2）:";
	cin >> n;
	if (n < 2)
		cout << "n值小于2，结束程序";
	int size = 1 << n;
	vector<vector<pair<int, int>>> sched(n - 1);
	makeSched(n, sched);
	printSched(sched);
	return 0;
}