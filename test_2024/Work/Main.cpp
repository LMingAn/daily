#include "define.h"

int main()
{
	bb1* b1 = new bb1;
	bb2* b2 = new bb2;
	bb3* b3 = new bb3;
	Seqlist* s = new Seqlist;
	LinklistC* c = new LinklistC, * a = new LinklistC, * b = new LinklistC;
	LinklistN* n = new LinklistN, * l = new LinklistN, * m = new LinklistN;
	LinklistS* d = new LinklistS;
	LinklistG* e = new LinklistG;
	Stack* f = new Stack;
	Linkstacki* g = new Linkstacki, * h = new Linkstacki;
	Linkstackc* i = new Linkstackc;
	Linkqueue* j = new Linkqueue;
	d->next = NULL;
	e->next = NULL;
	char id[100] = { 0 }, *str = new char;
	int in = 0, in1 = 0, in2 = 0, in3 = 0, in4 = 0, in5 = 0, in6 = 0, in7 = 0, in8 = 0, data = 0, datas = 0, datag = 0, check = 0, k = 0;
	char chs[100] = { 0 }, chs1[100] = { 0 }, chs2[100] = { 0 };
	do
	{
		cout << "\t请输入要进行的实验\n";
		cout << "\t====================\n";
		cout << "\t1 -------- 实验一\n";
		cout << "\t2 -------- 实验二\n";
		cout << "\t3 -------- 实验三\n";
		cout << "\t4 -------- 实验四\n";
		cout << "\t5 -------- 实验五\n";
		cout << "\t6 -------- 实验六\n";
		cout << "\t7 -------- 实验七\n";
		cout << "\t8 -------- 实验八\n";
		cout << "\t0 -------- 退出\n";
		cout << "\t请输入指令：";
		cin >> in;
		switch (in)
		{
		case 1:
			do
			{
				int loc = 0, ins = 0, data = 0;
				cout << "\t关于顺序表的操作\n";
				cout << "\t====================\n";
				cout << "\t1 -------- 置空并建表\n";
				cout << "\t2 -------- 求表长\n";
				cout << "\t3 -------- 取结点\n";
				cout << "\t4 -------- 查找\n";
				cout << "\t5 -------- 插入\n";
				cout << "\t6 -------- 删除\n";
				cout << "\t7 -------- 输出\n";
				cout << "\t8 -------- 奇偶数分组\n";
				cout << "\t9 -------- 输出奇数组与偶数组\n";
				cout << "\t10 ------- 寻找最大值与最小值并输出\n";
				cout << "\t0 -------- 返回\n";
				cout << "\t请输入指令：";
				cin >> in1;
				switch (in1)
				{
				case 1:
					SeqSetNull(s);
					SeqCreate(s);
					break;
				case 2:
					cout << "\t表的长度是：" << SeqLength(s) << endl;
					break;
				case 3:
					cout << "\t取结点的位置是：";
					cin >> loc;
					data = SeqGet(s, loc);
					if (data)
						cout << "\t第" << loc << "个结点是：" << data << endl;
					break;
				case 4:
					cout << "\t定位的数据元素是：";
					cin >> data;
					loc = SeqLocate(s, data);
					if (loc)
						cout << "\t定位的数据元素位置是：" << loc << endl;
					break;
				case 5:
					cout << "\t插入的位置是：";
					cin >> loc;
					cout << "\t插入的数据元素是：";
					cin >> ins;
					data = SeqInsert(s, loc, ins);
					if (data)
					{
						cout << "\t插入后的数据元素是：\n";
						SeqPrint(s);
					}
					break;
				case 6:
					cout << "\t删除的位置是：";
					cin >> loc;
					data = SeqDelete(s, loc);
					if (data)
						cout << "\t删除后的数据元素是：\n";
					SeqPrint(s);
					break;
				case 7:
					SeqPrint(s);
					break;
				case 8:
					SeqGroup(s);
					break;
				case 9:
					SeqPrintAB();
					break;
				case 10:
					SeqFind(s);
					break;
				}
			} while (in1);
			break;
		case 2:
			do
			{
				cout << "\t关于顺序表的操作\n";
				cout << "\t====================\n";
				cout << "\t1 -------- 置空并建表\n";
				cout << "\t2 -------- 两表总和\n";
				cout << "\t3 -------- 合并两表并排序\n";
				cout << "\t0 -------- 返回\n";
				cout << "\t请输入指令：";
				cin >> in2;
				switch (in2)
				{
				case 1:
					B1SetNull(b1);
					B2SetNull(b2);
					B1Create(b1);
					B2Create(b2);					
					break;
				case 2:
					BAdd(b1, b2);
					break;
				case 3:
					BMerge(b1, b2, b3);
					B3Print(b3);
					break;
				}
			} while (in2);
			break;
		case 3:
			do
			{
				int loc = 0, insi = 0, a = 0;
				char insc = 0;
				LinklistC* data;
				cout << "\t关于链表的操作\n";
				cout << "\t====================\n";
				cout << "\t1 -------- 置空并创建字符链表\n";
				cout << "\t2 -------- 置空并创建整型链表\n";
				cout << "\t3 -------- 输出字符链表\n";
				cout << "\t4 -------- 输出整型链表\n";
				cout << "\t5 -------- 字符链表求长\n";
				cout << "\t6 -------- 字符链表取结点\n";
				cout << "\t7 -------- 字符链表插入\n";
				cout << "\t8 -------- 整型链表插入\n";
				cout << "\t9 -------- 字符链表删除\n";
				cout << "\t10 ------- 整型链表删除\n";
				cout << "\t0 -------- 返回\n";
				cout << "\t请输入指令：";
				cin >> in3;
				switch (in3)
				{
				case 1:
					LinkSetNull(c);
					LinkCreateR(c);
					break;
				case 2:
					LinkSetNull(n);
					LinkCreateR(n);
					break;
				case 3:
					LinkPrint(c);
					break;
				case 4:
					LinkPrint(n);
					break;
				case 5:
					cout << "\t表的长度是：" << LinkLength(c) << endl;
					break;
				case 6:
					cout << "\t取结点的位置是：";
					cin >> loc;
					data = LinkGet(c, loc);
					if (data != NULL)
						cout << "\t第" << loc << "个结点是：" << data->data << endl;
					break;
				case 7:
					cout << "\t插入的位置是：";
					cin >> loc;
					cout << "\t插入的数据元素是：";
					cin >> insc;
					a = LinkInsert(c, loc, insc);
					if (a)
					{
						cout << "\t插入后的数据元素是：\n";
						LinkPrint(c);
					}
					break;
				case 8:
					cout << "\t插入的位置是：";
					cin >> loc;
					cout << "\t插入的数据元素是：";
					cin >> insi;
					a = LinkInsert(n, loc, insi);
					if (a)
					{
						cout << "\t插入后的数据元素是：\n";
						LinkPrint(n);
					}
					break;
				case 9:
					cout << "\t删除的位置是：";
					cin >> loc;
					LinkDelete(c, loc);
					break;
				case 10:
					cout << "\t删除的位置是：";
					cin >> loc;
					LinkDelete(n, loc);
					break;
				}
			} while (in3);
			break;
		case 4:
			do
			{
				int data = 0;
				cout << "\t关于链表的操作\n";
				cout << "\t====================\n";
				cout << "\t1 -------- 置空并创建字符链表A B\n";
				cout << "\t2 -------- 置空并创建整型链表A B\n";
				cout << "\t3 -------- 输出字符链表C\n";
				cout << "\t4 -------- 输出整型链表C\n";
				cout << "\t5 -------- 交合字符链表A B到C\n";
				cout << "\t6 -------- 交合整型链表A B到C\n";
				cout << "\t7 -------- 并合字符链表A B到C\n";
				cout << "\t8 -------- 并合整型链表A B到C\n";
				cout << "\t0 -------- 返回\n";
				cout << "\t请输入指令：";
				cin >> in4;
				switch (in4)
				{
				case 1:
					LinkSetNull(a);
					LinkSetNull(b);
					LinkCreateR(a);
					LinkCreateR(b);
					break;
				case 2:
					LinkSetNull(l);
					LinkSetNull(m);
					LinkCreateR(l);
					LinkCreateR(m);
					break;
				case 3:
					LinkPrint(c);
					break;
				case 4:
					LinkPrint(n);
					break;
				case 5:
					data = LinkInter(a, b, c);
					if (data)
						cout << "\t字符链表A和B的交集\tC";
					LinkPrint(c);
					break;
				case 6:
					data = LinkInter(l, m, n);
					if (data)
						cout << "\t整型链表A和B的交集\tC";
					LinkPrint(n);
					break;
				case 7:
					LinkUnion(a, b, c);
					cout << "\t字符链表A和B的并集\tC";
					LinkPrint(c);
					break;
				case 8:
					LinkUnion(l, m, n);
					cout << "\t整型链表A和B的并集\tC";
					LinkPrint(n);
					break;
				}
			} while (in4);
			break;
		case 5:
			do
			{
				cout << "\t关于链表的操作\n";
				cout << "\t====================\n";
				cout << "\t1 -------- 建立学生表\n";
				cout << "\t2 -------- 插入学生信息\n";
				cout << "\t3 -------- 删除学生信息\n";
				cout << "\t4 -------- 浏览学生信息\n";
				cout << "\t5 -------- 建立商品表\n";
				cout << "\t6 -------- 插入商品信息\n";
				cout << "\t7 -------- 删除商品信息\n";
				cout << "\t8 -------- 浏览商品信息\n";
				cout << "\t9 -------- 商品打折处理\n";
				cout << "\t0 -------- 退出\n";
				cout << "\t请输入指令：";
				cin >> in5;
				switch (in5)
				{
				case 1:
					LinkCreate(d, &datas);
					cout << "\t学生总数为：" << datas << endl;
					break;
				case 2:
					cout << "\t请输入要插入的学生的学号，以0结束：";
					cin >> id;
					while (1)
					{
						if (strcmp(id, "0") == 0)
							break;
						LinkInsert(d, id, &datas);
						cout << "\t学生总数为：" << datas << endl;
						LinkPrint(d);
						cout << "\t请输入要插入的学生的学号，以0结束：";
						cin >> id;
					}
					break;
				case 3:
					cout << "\t请输入要删除的学生的学号，以0结束：";
					cin >> id;
					while (1)
					{
						if (strcmp(id, "0") == 0)
							break;
						int a = LinkDelete(d, id, &datas);
						cout << "\t学生总数为：" << datas << endl;
						LinkPrint(d);
						cout << "\t请输入要删除的学生的学号，以0结束：";
						cin >> id;
					}
					break;
				case 4:
					if (d->next != NULL)
						LinkPrint(d);
					else
						cout << "\t学生表为空\n";
					break;
				case 5:
					LinkCreate(e, &datag);
					cout << "\t商品总数为：" << datag << endl;
					break;
				case 6:
					cout << "\t请输入要插入的商品的编号，以0结束：";
					cin >> id;
					while (1)
					{
						if (strcmp(id, "0") == 0)
							break;
						LinkInsert(e, id, &datag);
						cout << "\t商品总数为：" << datag << endl;
						LinkPrint(e);
						cout << "\t请输入要插入的商品的编号，以0结束：";
						cin >> id;
					}
					break;
				case 7:
					cout << "\t请输入要删除的商品的编号，以0结束：";
					cin >> id;
					while (1)
					{
						if (strcmp(id, "0") == 0)
							break;
						int a = LinkDelete(e, id, &datag);
						if (a == 0)
							cout << "\t商品表中没有该商品记录\n";
						else
						{
							cout << "\t商品总数为：" << datag << endl;
							LinkPrint(e);
						}
						cout << "\t请输入要删除的商品的编号，以0结束：";
						cin >> id;
					}
					break;
				case 8:
					if (e->next != NULL)
						LinkPrint(e);
					else
						cout << "\t商品表为空\n";
					break;
				case 9:
					LinkDiscount(e);
					break;
				}
			} while (in5);
			break;
		case 6:
			do
			{
				data = 0, check = 0;
				cout << "\t关于栈的操作\n";
				cout << "\t====================\n";
				cout << "\t1 -------- 置空顺序栈\n";
				cout << "\t2 -------- 顺序栈入栈\n";
				cout << "\t3 -------- 顺序栈出栈\n";
				cout << "\t4 -------- 顺序栈输出\n";
				cout << "\t5 -------- 初始化链栈\n";
				cout << "\t6 -------- 链栈入栈\n";
				cout << "\t7 -------- 取链栈栈顶元素\n";
				cout << "\t8 -------- 链栈栈顶出栈\n";
				cout << "\t9 -------- 置空并创建括号匹配栈并输出结果：\n";
				cout << "\t0 -------- 退出\n";
				cout << "\t请输入指令：";
				cin >> in6;
				getchar();
				switch (in6)
				{
				case 1:
					StackSetNull(f);
					break;
				case 2:
					cout << "\t输入入栈数据元素：";
					cin >> data;
					getchar();
					check = StackPush(f, data);
					break;
				case 3:
					if (StackPop(f, &data) != 0)
						cout << "\t出栈数据元素是：" << data << endl;
					break;
				case 4:
					StackPrint(f);
					break;
				case 5:
					g = StackInit();
					break;
				case 6:
					cout << "\t输入入栈数据元素：";
					cin >> data;
					getchar();
					g = StackPush(g, data);
					break;
				case 7:
					data = StackGetPop(g);
					if (data != 0)
						cout << "\t栈顶数据元素是：" << data << endl;
					break;
				case 8:
					g = StackPop(g, &data);
					cout << "\t出栈后的栈顶数据是：" << StackGetPop(g) << endl;
					StackEmpty(g);
					break;
				case 9:
					cout << "\t请输入带括号（()、[]和{}）的表达式(输入#退出)；";
					while (cin >> str && strcmp(str, "#"))
					{
						if (StackCorrect(str))
							cout << "\t表达式括号匹配\n";
						else
							cout << "\t表达式括号不匹配\n";
						cout << "\t请输入带括号（()、[]和{}）的表达式(输入#退出)；";
					}
					break;
				}
			} while (in6);
			break;
		case 7:
			do
			{
				cout << "\t关于链队列的操作\n";
				cout << "\t====================\n";
				cout << "\t1 -------- 创建空链队\n";
				cout << "\t2 -------- 入链队\n";
				cout << "\t3 -------- 出链队\n";
				cout << "\t4 -------- 出部分链队\n";
				cout << "\t5 -------- 排队看病模拟系统\n";
				cout << "\t6 -------- 就餐等候模拟系统\n";
				cout << "\t0 -------- 退出\n";
				cout << "\t请输入指令：";
				cin >> in7;
				switch (in7)
				{
				case 1:
					j = QueueCreate();
					break;
				case 2:
					cout << "\t请输入链队长度：";
					cin >> data;
					for (int a = 0; a < data; a++)
					{
						int check = 0;
						cout << "\t输入第" << a + 1 << "位数据：";
						cin >> check;
						QueueInput(j, check);
					}
					break;
				case 3:
					cout << "\t链队中数据为：\n\t";
					for (int a = 0; a < data; a++)
					{
						if (QueueOutput(j, &check))
							cout << check << " ";
					}
					cout << endl;
					break;
				case 4:
					cout << "\t输入要输出链队数据的个数：";
					cin >> data;
					cout << "\t";
					for (int a = 0; a < data; a++)
					{
						if (QueueOutput(j, &check))
							cout << check << " ";
					}
					cout << endl;
					break;
				case 5:
					HospitalMockSystem();
					break;
				case 6:
					RepastMockSystem();
					break;
				}
			} while (in7);
			break;
		case 8:
			do
			{
				j = QueueCreate();
				LinkStack* s = new LinkStack;
				s->data = 1;
				s->next = NULL;
				cout << "\t进制转换\n";
				cout << "\t================\n";
				cout << "\t1 ---- 10-2进制小数转换\n";
				cout << "\t2 ---- 2-10进制小数转换\n";
				cout << "\t0 ---- 退出\n";
				cout << "\t请输入指令：";
				cin >> in8;
				switch (in8)
				{
				case 1:
					getchar();
					printf("\t请输入需要转换的数字：");
					cin >> data;
					if (data > 1.0 && data != (int)data)
					{/* 如果输入的不是一个整数并且大于1 */
						s = IntConverDToB((int)data, s);
						DecConverDToB(data - (int)data, j);
						cout << "\t转化后的二进制小数为：" << data;
						while (!LStackIsEmpty(s))
						{
							printf("%d", LStackGetTop(s)); /* 输出整数部分 */
							s = LStackPop(s, &check);
						}
						cout << "." << data;
						while (!LQueueIsEmpty(j)) /* 输出小数部分 */
						{
							LQueueDeQueue(j, &datas);
							printf("%d", datas);
						}
						printf("\n");
					}
					else
					{
						if (data == (int)data) /* 如果输入的是一个整数 */
						{
							cout << data << "\t转化后的二进制小数为：";
							s = IntConverDToB((int)data, s);
							while (!LStackIsEmpty(s)) /* 输出整数部分 */
							{
								printf("%d", LStackGetTop(s));
								s = LStackPop(s, &check);
							}
							printf(".0\n");
						}
						else /* 如果输入的是一个小于1的小数 */
						{
							printf("\t----------\n");
							cout << "\t转化后的二进制小数为：" << data;
							DecConverDToB(data, j);
							cout << "0." << data;
							while (!LQueueIsEmpty(j))  /* 输出小数部分 */
							{
								LQueueDeQueue(j, &datas);
								printf("%d", datas);
							}
							printf("\n");
							getchar();
						}
					}
					break;
				case 2:
					getchar();
					printf("\t请输入需要转换的二进制数字：\n");
					gets_s(chs);
					k = StringSplit(chs, chs1, chs2);
					if (k != -1)
					{
						float num = IntConverBToD(chs1, s);
						float f = DecConverBToD(chs2, j);
						if (-1 != num && f != -1)
							printf("\t转化后的十进制形式为：%f\n", (float)num + f);
						else
							printf("\t输入格式错误\n");
					}
					else
					{
						float num = IntConverBToD(chs, s);
						if (-1 != num)
							printf("\t转化后的十进制形式为：%f\n", (float)num);
						else
							printf("\t输入格式错误\n");
					}

					break;
				case 3: /* 退出 */
					return 0;
				default: /* 输入不满足要求，提示输入错误 */
					printf("\t输入错误，请重新输入！\n");
					continue;
				}
			} while (in8);
			break;
		}
	} while (in);
}