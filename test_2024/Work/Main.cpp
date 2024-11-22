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
		cout << "\t������Ҫ���е�ʵ��\n";
		cout << "\t====================\n";
		cout << "\t1 -------- ʵ��һ\n";
		cout << "\t2 -------- ʵ���\n";
		cout << "\t3 -------- ʵ����\n";
		cout << "\t4 -------- ʵ����\n";
		cout << "\t5 -------- ʵ����\n";
		cout << "\t6 -------- ʵ����\n";
		cout << "\t7 -------- ʵ����\n";
		cout << "\t8 -------- ʵ���\n";
		cout << "\t0 -------- �˳�\n";
		cout << "\t������ָ�";
		cin >> in;
		switch (in)
		{
		case 1:
			do
			{
				int loc = 0, ins = 0, data = 0;
				cout << "\t����˳���Ĳ���\n";
				cout << "\t====================\n";
				cout << "\t1 -------- �ÿղ�����\n";
				cout << "\t2 -------- ���\n";
				cout << "\t3 -------- ȡ���\n";
				cout << "\t4 -------- ����\n";
				cout << "\t5 -------- ����\n";
				cout << "\t6 -------- ɾ��\n";
				cout << "\t7 -------- ���\n";
				cout << "\t8 -------- ��ż������\n";
				cout << "\t9 -------- �����������ż����\n";
				cout << "\t10 ------- Ѱ�����ֵ����Сֵ�����\n";
				cout << "\t0 -------- ����\n";
				cout << "\t������ָ�";
				cin >> in1;
				switch (in1)
				{
				case 1:
					SeqSetNull(s);
					SeqCreate(s);
					break;
				case 2:
					cout << "\t��ĳ����ǣ�" << SeqLength(s) << endl;
					break;
				case 3:
					cout << "\tȡ����λ���ǣ�";
					cin >> loc;
					data = SeqGet(s, loc);
					if (data)
						cout << "\t��" << loc << "������ǣ�" << data << endl;
					break;
				case 4:
					cout << "\t��λ������Ԫ���ǣ�";
					cin >> data;
					loc = SeqLocate(s, data);
					if (loc)
						cout << "\t��λ������Ԫ��λ���ǣ�" << loc << endl;
					break;
				case 5:
					cout << "\t�����λ���ǣ�";
					cin >> loc;
					cout << "\t���������Ԫ���ǣ�";
					cin >> ins;
					data = SeqInsert(s, loc, ins);
					if (data)
					{
						cout << "\t����������Ԫ���ǣ�\n";
						SeqPrint(s);
					}
					break;
				case 6:
					cout << "\tɾ����λ���ǣ�";
					cin >> loc;
					data = SeqDelete(s, loc);
					if (data)
						cout << "\tɾ���������Ԫ���ǣ�\n";
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
				cout << "\t����˳���Ĳ���\n";
				cout << "\t====================\n";
				cout << "\t1 -------- �ÿղ�����\n";
				cout << "\t2 -------- �����ܺ�\n";
				cout << "\t3 -------- �ϲ���������\n";
				cout << "\t0 -------- ����\n";
				cout << "\t������ָ�";
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
				cout << "\t��������Ĳ���\n";
				cout << "\t====================\n";
				cout << "\t1 -------- �ÿղ������ַ�����\n";
				cout << "\t2 -------- �ÿղ�������������\n";
				cout << "\t3 -------- ����ַ�����\n";
				cout << "\t4 -------- �����������\n";
				cout << "\t5 -------- �ַ�������\n";
				cout << "\t6 -------- �ַ�����ȡ���\n";
				cout << "\t7 -------- �ַ��������\n";
				cout << "\t8 -------- �����������\n";
				cout << "\t9 -------- �ַ�����ɾ��\n";
				cout << "\t10 ------- ��������ɾ��\n";
				cout << "\t0 -------- ����\n";
				cout << "\t������ָ�";
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
					cout << "\t��ĳ����ǣ�" << LinkLength(c) << endl;
					break;
				case 6:
					cout << "\tȡ����λ���ǣ�";
					cin >> loc;
					data = LinkGet(c, loc);
					if (data != NULL)
						cout << "\t��" << loc << "������ǣ�" << data->data << endl;
					break;
				case 7:
					cout << "\t�����λ���ǣ�";
					cin >> loc;
					cout << "\t���������Ԫ���ǣ�";
					cin >> insc;
					a = LinkInsert(c, loc, insc);
					if (a)
					{
						cout << "\t����������Ԫ���ǣ�\n";
						LinkPrint(c);
					}
					break;
				case 8:
					cout << "\t�����λ���ǣ�";
					cin >> loc;
					cout << "\t���������Ԫ���ǣ�";
					cin >> insi;
					a = LinkInsert(n, loc, insi);
					if (a)
					{
						cout << "\t����������Ԫ���ǣ�\n";
						LinkPrint(n);
					}
					break;
				case 9:
					cout << "\tɾ����λ���ǣ�";
					cin >> loc;
					LinkDelete(c, loc);
					break;
				case 10:
					cout << "\tɾ����λ���ǣ�";
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
				cout << "\t��������Ĳ���\n";
				cout << "\t====================\n";
				cout << "\t1 -------- �ÿղ������ַ�����A B\n";
				cout << "\t2 -------- �ÿղ�������������A B\n";
				cout << "\t3 -------- ����ַ�����C\n";
				cout << "\t4 -------- �����������C\n";
				cout << "\t5 -------- �����ַ�����A B��C\n";
				cout << "\t6 -------- ������������A B��C\n";
				cout << "\t7 -------- �����ַ�����A B��C\n";
				cout << "\t8 -------- ������������A B��C\n";
				cout << "\t0 -------- ����\n";
				cout << "\t������ָ�";
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
						cout << "\t�ַ�����A��B�Ľ���\tC";
					LinkPrint(c);
					break;
				case 6:
					data = LinkInter(l, m, n);
					if (data)
						cout << "\t��������A��B�Ľ���\tC";
					LinkPrint(n);
					break;
				case 7:
					LinkUnion(a, b, c);
					cout << "\t�ַ�����A��B�Ĳ���\tC";
					LinkPrint(c);
					break;
				case 8:
					LinkUnion(l, m, n);
					cout << "\t��������A��B�Ĳ���\tC";
					LinkPrint(n);
					break;
				}
			} while (in4);
			break;
		case 5:
			do
			{
				cout << "\t��������Ĳ���\n";
				cout << "\t====================\n";
				cout << "\t1 -------- ����ѧ����\n";
				cout << "\t2 -------- ����ѧ����Ϣ\n";
				cout << "\t3 -------- ɾ��ѧ����Ϣ\n";
				cout << "\t4 -------- ���ѧ����Ϣ\n";
				cout << "\t5 -------- ������Ʒ��\n";
				cout << "\t6 -------- ������Ʒ��Ϣ\n";
				cout << "\t7 -------- ɾ����Ʒ��Ϣ\n";
				cout << "\t8 -------- �����Ʒ��Ϣ\n";
				cout << "\t9 -------- ��Ʒ���۴���\n";
				cout << "\t0 -------- �˳�\n";
				cout << "\t������ָ�";
				cin >> in5;
				switch (in5)
				{
				case 1:
					LinkCreate(d, &datas);
					cout << "\tѧ������Ϊ��" << datas << endl;
					break;
				case 2:
					cout << "\t������Ҫ�����ѧ����ѧ�ţ���0������";
					cin >> id;
					while (1)
					{
						if (strcmp(id, "0") == 0)
							break;
						LinkInsert(d, id, &datas);
						cout << "\tѧ������Ϊ��" << datas << endl;
						LinkPrint(d);
						cout << "\t������Ҫ�����ѧ����ѧ�ţ���0������";
						cin >> id;
					}
					break;
				case 3:
					cout << "\t������Ҫɾ����ѧ����ѧ�ţ���0������";
					cin >> id;
					while (1)
					{
						if (strcmp(id, "0") == 0)
							break;
						int a = LinkDelete(d, id, &datas);
						cout << "\tѧ������Ϊ��" << datas << endl;
						LinkPrint(d);
						cout << "\t������Ҫɾ����ѧ����ѧ�ţ���0������";
						cin >> id;
					}
					break;
				case 4:
					if (d->next != NULL)
						LinkPrint(d);
					else
						cout << "\tѧ����Ϊ��\n";
					break;
				case 5:
					LinkCreate(e, &datag);
					cout << "\t��Ʒ����Ϊ��" << datag << endl;
					break;
				case 6:
					cout << "\t������Ҫ�������Ʒ�ı�ţ���0������";
					cin >> id;
					while (1)
					{
						if (strcmp(id, "0") == 0)
							break;
						LinkInsert(e, id, &datag);
						cout << "\t��Ʒ����Ϊ��" << datag << endl;
						LinkPrint(e);
						cout << "\t������Ҫ�������Ʒ�ı�ţ���0������";
						cin >> id;
					}
					break;
				case 7:
					cout << "\t������Ҫɾ������Ʒ�ı�ţ���0������";
					cin >> id;
					while (1)
					{
						if (strcmp(id, "0") == 0)
							break;
						int a = LinkDelete(e, id, &datag);
						if (a == 0)
							cout << "\t��Ʒ����û�и���Ʒ��¼\n";
						else
						{
							cout << "\t��Ʒ����Ϊ��" << datag << endl;
							LinkPrint(e);
						}
						cout << "\t������Ҫɾ������Ʒ�ı�ţ���0������";
						cin >> id;
					}
					break;
				case 8:
					if (e->next != NULL)
						LinkPrint(e);
					else
						cout << "\t��Ʒ��Ϊ��\n";
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
				cout << "\t����ջ�Ĳ���\n";
				cout << "\t====================\n";
				cout << "\t1 -------- �ÿ�˳��ջ\n";
				cout << "\t2 -------- ˳��ջ��ջ\n";
				cout << "\t3 -------- ˳��ջ��ջ\n";
				cout << "\t4 -------- ˳��ջ���\n";
				cout << "\t5 -------- ��ʼ����ջ\n";
				cout << "\t6 -------- ��ջ��ջ\n";
				cout << "\t7 -------- ȡ��ջջ��Ԫ��\n";
				cout << "\t8 -------- ��ջջ����ջ\n";
				cout << "\t9 -------- �ÿղ���������ƥ��ջ����������\n";
				cout << "\t0 -------- �˳�\n";
				cout << "\t������ָ�";
				cin >> in6;
				getchar();
				switch (in6)
				{
				case 1:
					StackSetNull(f);
					break;
				case 2:
					cout << "\t������ջ����Ԫ�أ�";
					cin >> data;
					getchar();
					check = StackPush(f, data);
					break;
				case 3:
					if (StackPop(f, &data) != 0)
						cout << "\t��ջ����Ԫ���ǣ�" << data << endl;
					break;
				case 4:
					StackPrint(f);
					break;
				case 5:
					g = StackInit();
					break;
				case 6:
					cout << "\t������ջ����Ԫ�أ�";
					cin >> data;
					getchar();
					g = StackPush(g, data);
					break;
				case 7:
					data = StackGetPop(g);
					if (data != 0)
						cout << "\tջ������Ԫ���ǣ�" << data << endl;
					break;
				case 8:
					g = StackPop(g, &data);
					cout << "\t��ջ���ջ�������ǣ�" << StackGetPop(g) << endl;
					StackEmpty(g);
					break;
				case 9:
					cout << "\t����������ţ�()��[]��{}���ı��ʽ(����#�˳�)��";
					while (cin >> str && strcmp(str, "#"))
					{
						if (StackCorrect(str))
							cout << "\t���ʽ����ƥ��\n";
						else
							cout << "\t���ʽ���Ų�ƥ��\n";
						cout << "\t����������ţ�()��[]��{}���ı��ʽ(����#�˳�)��";
					}
					break;
				}
			} while (in6);
			break;
		case 7:
			do
			{
				cout << "\t���������еĲ���\n";
				cout << "\t====================\n";
				cout << "\t1 -------- ����������\n";
				cout << "\t2 -------- ������\n";
				cout << "\t3 -------- ������\n";
				cout << "\t4 -------- ����������\n";
				cout << "\t5 -------- �Ŷӿ���ģ��ϵͳ\n";
				cout << "\t6 -------- �Ͳ͵Ⱥ�ģ��ϵͳ\n";
				cout << "\t0 -------- �˳�\n";
				cout << "\t������ָ�";
				cin >> in7;
				switch (in7)
				{
				case 1:
					j = QueueCreate();
					break;
				case 2:
					cout << "\t���������ӳ��ȣ�";
					cin >> data;
					for (int a = 0; a < data; a++)
					{
						int check = 0;
						cout << "\t�����" << a + 1 << "λ���ݣ�";
						cin >> check;
						QueueInput(j, check);
					}
					break;
				case 3:
					cout << "\t����������Ϊ��\n\t";
					for (int a = 0; a < data; a++)
					{
						if (QueueOutput(j, &check))
							cout << check << " ";
					}
					cout << endl;
					break;
				case 4:
					cout << "\t����Ҫ����������ݵĸ�����";
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
				cout << "\t����ת��\n";
				cout << "\t================\n";
				cout << "\t1 ---- 10-2����С��ת��\n";
				cout << "\t2 ---- 2-10����С��ת��\n";
				cout << "\t0 ---- �˳�\n";
				cout << "\t������ָ�";
				cin >> in8;
				switch (in8)
				{
				case 1:
					getchar();
					printf("\t��������Ҫת�������֣�");
					cin >> data;
					if (data > 1.0 && data != (int)data)
					{/* �������Ĳ���һ���������Ҵ���1 */
						s = IntConverDToB((int)data, s);
						DecConverDToB(data - (int)data, j);
						cout << "\tת����Ķ�����С��Ϊ��" << data;
						while (!LStackIsEmpty(s))
						{
							printf("%d", LStackGetTop(s)); /* ����������� */
							s = LStackPop(s, &check);
						}
						cout << "." << data;
						while (!LQueueIsEmpty(j)) /* ���С������ */
						{
							LQueueDeQueue(j, &datas);
							printf("%d", datas);
						}
						printf("\n");
					}
					else
					{
						if (data == (int)data) /* ����������һ������ */
						{
							cout << data << "\tת����Ķ�����С��Ϊ��";
							s = IntConverDToB((int)data, s);
							while (!LStackIsEmpty(s)) /* ����������� */
							{
								printf("%d", LStackGetTop(s));
								s = LStackPop(s, &check);
							}
							printf(".0\n");
						}
						else /* ����������һ��С��1��С�� */
						{
							printf("\t----------\n");
							cout << "\tת����Ķ�����С��Ϊ��" << data;
							DecConverDToB(data, j);
							cout << "0." << data;
							while (!LQueueIsEmpty(j))  /* ���С������ */
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
					printf("\t��������Ҫת���Ķ��������֣�\n");
					gets_s(chs);
					k = StringSplit(chs, chs1, chs2);
					if (k != -1)
					{
						float num = IntConverBToD(chs1, s);
						float f = DecConverBToD(chs2, j);
						if (-1 != num && f != -1)
							printf("\tת�����ʮ������ʽΪ��%f\n", (float)num + f);
						else
							printf("\t�����ʽ����\n");
					}
					else
					{
						float num = IntConverBToD(chs, s);
						if (-1 != num)
							printf("\tת�����ʮ������ʽΪ��%f\n", (float)num);
						else
							printf("\t�����ʽ����\n");
					}

					break;
				case 3: /* �˳� */
					return 0;
				default: /* ���벻����Ҫ����ʾ������� */
					printf("\t����������������룡\n");
					continue;
				}
			} while (in8);
			break;
		}
	} while (in);
}