#include <iostream>
using namespace std;

//----------1
//int main()
//{
//	int t = 0, nums[17] = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59}, ans = 0;
//	long long n = 0;
//	cin >> t;
//	while (t--)
//	{
//		cin >> n;
//		int num = 2;
//		for (; num <= n; num++)
//		{
//			int pri = 0;
//			for (int a = 0; a <= 16; a++)
//			{
//				if (num % nums[a] == 0 && num >= nums[a])
//				{
//					pri++;
//				}
//			}
//			if (pri > ans)
//			{
//				ans = pri;
//			}
//		}
//		cout << ans << endl;
//	}
//	return 0;
//}


//----------2
//int main()
//{
//	long long n = 0, m = 0, h[1000006] = { 0 }, sum = 0, avg = 0;
//	cin >> n >> m;
//	for (int a = 0; a < n; a++)
//	{
//		cin >> h[a];
//		sum += h[a];
//	}
//	avg = sum / n;
//	sum = 0;
//	for (int a = 0; a < n; a++)
//	{
//
//	}
//}