#include "define.h"

int aa[100] = { 0 }, ag = 0;
int bb[100] = { 0 }, bg = 0;

//置空表
void SeqSetNull(Seqlist* s)
{
	s->last = -1;
	cout << "\t已置空顺序表Seqlist\n";
}

void B1SetNull(bb1* s)
{
	s->last = -1;
	cout << "\t已置空顺序表bb1\n";
}

void B2SetNull(bb2* s)
{
	s->last = -1;
	cout << "\t已置空顺序表bb2\n";
}

void LinkSetNull(LinklistC* l)
{
	l->next = NULL;
	cout << "\t已置空链表\n";
}

void LinkSetNull(LinklistN* l)
{
	l->next = NULL;
	cout << "\t已置空链表\n";
}

void StackSetNull(Stack* s)
{
	s->top = -1;
	cout << "\t已置空顺序栈\n";
}

void StackSetNull(Linkstackc* s)
{
	s->top = -1;
	cout << "\t已置空顺序栈\n";
}

Linkstacki* StackInit()
{
	Linkstacki* h = new Linkstacki;
	h->data = 1;
	h->next = NULL;
	return h;
}

//取长度
int SeqLength(Seqlist* s)
{
	return s->last + 1;
}

int B1Length(bb1* s)
{
	return s->last + 1;
}

int B2Length(bb2* s)
{
	return s->last + 1;
}

int LinkLength(LinklistC* l)
{
	LinklistC* p;
	p = l->next;
	int a = 0;
	while (p != NULL)
	{
		p = p->next;
		a++;
	}
	return a;
}

int  QueueEmpty(Linkqueue* l)
{
	return (l->front == NULL);
}

//取结点
int SeqGet(Seqlist* s, int n)
{
	if (n < 1 || n > s->last + 1)
	{
		cout << "\t节点n的位置不正确\n";
		return 0;
	}
	return s->data[n];
}

LinklistC*  LinkGet(LinklistC* l, int n)
{
	int a = 0;
	LinklistC* p = l;
	while (p->next != NULL && a < n)
	{
		p = p->next;
		a++;
	}
	if (n == a)
		return p;
	else
		return NULL;
}

//查找
int SeqLocate(Seqlist* s, int n)
{
	for (int a = 0; a <= s->last; a++)
	{
		if (s->data[a] == n)
			return a + 1;
	}
	return 0;
}

LinklistC* LinkLocate(LinklistC* l, int n)
{
	LinklistC* p = l->next;
	while (p != NULL)
	{
		if (p->data != n)
			p = p->next;
		else
			return p;
	}
}

//插入
int SeqInsert(Seqlist* s, int n, int m)
{
	if (n > 100)
	{
		cout << "\t下标溢出\n";
		return 0;
	}
	if (n < 1 || n > s->last + 2)
	{
		cout << "\t插入位置不正确\n";
		return 0;
	}
	else
	{
		for (int a = s->last; a >= n - 1; a--)
			s->data[a + 1] = s->data[a];
		s->data[n - 1] = m;
		s->last++;
	}
}

void B3Insert(bb3* s, int n, int m)
{
	if (n > 200)
	{
		cout << "\t下标溢出\n";
		exit(0);
	}
	else
	{
		s->data[n] = m;
		s->last++;
	}
}

int LinkInsert(LinklistC* l, int n, char m)
{
	LinklistC* p = l, * ne;
	int a = 0;
	while (p != NULL && a < n - 1)
	{
		p = p->next;
		a++;
	}
	if (!p)
	{
		cout << "\t插入位置错误\n";
		return 0;
	}
	else
	{
		ne = new LinklistC;
		ne->data = m;
		ne->next = p->next;
		p->next = ne;
	}
}

int LinkInsert(LinklistN* l, int n, int m)
{
	LinklistN* p = l, * ne;
	int a = 0;
	while (p != NULL && a < n - 1)
	{
		p = p->next;
		a++;
	}
	if (!p)
	{
		cout << "\t插入位置错误\n";
		return 0;
	}
	else
	{
		ne = new LinklistN;
		ne->data = m;
		ne->next = p->next;
		p->next = ne;
	}
}

void LinkInsert(LinklistS* l, char id[], int* n)
{
	int chi = 0, ma = 0, en = 0, ph = 0, che = 0, a = 0;
	LinklistS* p = l, * s;
	cout << "\t请输入语文成绩：";
	cin >> chi;
	cout << "\t请输入数学成绩：";
	cin >> ma;
	cout << "\t请输入英语成绩：";
	cin >> en;
	cout << "\t请输入物理成绩：";
	cin >> ph;
	cout << "\t请输入化学成绩：";
	cin >> che;
	while (p->next != NULL)
	{
		if (strcmp(p->next->id, id) == 0)
		{
			a = 1;
			break;
		}
		p = p->next;
	}
	if (a == 1)
	{
		p->next->chinese = chi;
		p->next->math = ma;
		p->next->english = en;
		p->next->physics = ph;
		p->next->chemistry = che;
	}
	else
	{
		s = new LinklistS;
		strcpy(s->id, id);
		s->chinese = chi;
		s->math = ma;
		s->english = en;
		s->physics = ph;
		s->chemistry = che;
		p->next = s;
		p = s;
		s->next = NULL;
		*n += 1;
	}
}

void LinkInsert(LinklistG* l, char id[], int* n)
{
	int sa = 0, pr = 0, co = 0, a = 0;
	LinklistG* p = l, * s;
	cout << "\t请输入销售量：";
	cin >> sa;
	cout << "\t请输入价格：";
	cin >> pr;
	cout << "\t请输入产地代号：";
	cin >> co;
	while (p->next != NULL)
	{
		if (strcmp(p->next->id, id) == 0)
		{
			a = 1;
			break;
		}
		p = p->next;
	}
	if (a == 1)
	{
		p->next->sale = sa;
		p->next->price = pr;
		p->next->code = co;
	}
	else
	{
		s = new LinklistG;
		strcpy(s->id, id);
		s->sale = sa;
		s->price = pr;
		s->code = co;
		p->next = s;
		p = s;
		s->next = NULL;
		*n += 1;
	}
}

//删除
int SeqDelete(Seqlist* s, int n)
{
	if (n < 1 || n > s->last + 1)
	{
		cout << "\t删除位置错误\n";
		return 0;
	}
	else
	{
		for (int a = n; a <= s->last; a++)
			s->data[n - 1] = s->data[n];
		s->last--;
	}
	return 1;
}

void LinkDelete(LinklistC* l, int n)
{
	LinklistC* p = l, * ne;
	int a = 0;
	while (p->next != NULL && a < n - 1)
	{
		p = p->next;
		a++;
	}
	if (!p->next)
		cout << "\t删除结点的位置错误\n";
	else
	{
		cout << "\t删除的数据元素是：" << p->next->data << endl;
		ne = p->next;
		p->next = p->next->next;
		int de = ne->data;
		free(ne);
		cout << "\t成功删除结点\n";
	}
}

void LinkDelete(LinklistN* l, int n)
{
	LinklistN* p = l, * ne;
	int a = 0;
	while (p->next != NULL && a < n - 1)
	{
		p = p->next;
		a++;
	}
	if (!p->next)
		cout << "\t删除结点的位置错误\n";
	else
	{
		cout << "\t删除的数据元素是：" << p->next->data << endl;
		ne = p->next;
		p->next = p->next->next;
		int de = ne->data;
		free(ne);
		cout << "\t成功删除结点\n";
	}
}

int LinkDelete(LinklistS* l, char id[], int* n)
{
	LinklistS* p = l, * s;
	if (p->next == NULL)
	{
		cout << "\t学生表中没有任何学生记录\n";
		return 0;
	}
	else
	{
		while (p != NULL)
		{
			s = p->next;
			if (s != NULL)
			{
				if (strcmp(s->id, id) == 0)
				{
					p->next = s->next;
					*n -= 1;
					break;
				}
			}
			p = p->next;
		}
		cout << "\t学生表中没有该学生记录\n";
		return 0;
	}
}

int LinkDelete(LinklistG* l, char id[], int* n)
{
	LinklistG* p = l, * s;
	if (p->next == NULL)
	{
		cout << "\t商品表中没有任何商品记录\n";
		return 0;
	}
	else
	{
		while (p != NULL)
		{
			s = p->next;
			if (s != NULL)
			{
				if (strcmp(s->id, id) == 0)
				{
					p->next = s->next;
					*n -= 1;
					return 1;
				}
			}
			p = p->next;
		}
		return 0;
	}
}

//创建
void SeqCreate(Seqlist* s)
{
	int n = 0, m = 0;
	cout << "\t输入表的长度:";
	cin >> n;
	s->last = n - 1;
	cout << "\t依次输入表中的数据（整数）:\n";
	for (m = 0; m < n; m++)
	{
		printf("\t第%d个元素是:", m + 1);
		cin >> s->data[m];
	}
}

void B1Create(bb1* s)
{
	int n = 0, m = 0;
	cout << "\t输入表bb1的长度:";
	cin >> n;
	s->last = n - 1;
	cout << "\t依次输入表中的数据（整数）:\n";
	for (m = 0; m < n; m++)
	{
		printf("\t第%d个元素是:", m + 1);
		cin >> s->data[m];
	}
}

void B2Create(bb2* s)
{
	int n = 0, m = 0;
	cout << "\t输入表bb2的长度:";
	cin >> n;
	s->last = n - 1;
	cout << "\t依次输入表中的数据（整数）:\n";
	for (m = 0; m < n; m++)
	{
		printf("\t第%d个元素是:", m + 1);
		cin >> s->data[m];
	}
}

void LinkCreateH(LinklistC* head)//头插法--不带头结点
{
	char in = 0;
	head = NULL;
	LinklistC* l;
	cout << "\t输入表的内容（以#结束）：";
	getchar();
	in = getchar();
	while (in != '#')
	{
		l = new LinklistC;
		l->data = in;
		l->next = head;
		head = l;
		in = getchar();
	}
}

void LinkCreateR(LinklistC* head)//尾插法--带头结点
{
	char in = 0;
	LinklistC* p, * l = head;
	cout << "\t输入表的内容（以#结束）：";
	getchar();
	in = getchar();
	while (in != '#')
	{
		p = new LinklistC;
		p->data = in;
		l->next = p;
		l = p;
		in = getchar();
	}
	l->next = NULL;
}

void LinkCreateR(LinklistN* head)//尾插法--带头结点
{
	LinklistN* p, * l = head;
	int n = 0, m = 0;
	cout << "\t输入表的长度:";
	cin >> n;
	cout << "\t依次输入表中的数据（整数）:\n";
	for (m = 0; m < n; m++)
	{
		p = new LinklistN;
		cout << "\t第" << m + 1 << "个元素是:";
		cin >> p->data;
		l->next = p;
		l = p;
	}
	l->next = NULL;
}

void LinkCreate(LinklistS* l, int *n)
{
	char id[100] = { 0 };
	int chi = 0, ma = 0, en = 0, ph = 0, che = 0, a = 1;
	LinklistS* p = l, * s;
	cout << "\t请输入学生学号，以0结束输入：";
	cin >> id;
	while (1)
	{
		if (strcmp(id, "0") == 0)
			break;
		s = new LinklistS;
		strcpy(s->id, id);
		cout << "\t请输入语文成绩：";
		cin >> chi;
		s->chinese = chi;
		cout << "\t请输入数学成绩：";
		cin >> ma;
		s->math = ma;
		cout << "\t请输入英语成绩：";
		cin >> en;
		s->english = en;
		cout << "\t请输入物理成绩：";
		cin >> ph;
		s->physics = ph;
		cout << "\t请输入化学成绩：";
		cin >> che;
		s->chemistry = che;
		p->next = s;
		p = s;
		s->next = NULL;
		*n += 1;
		cout << "\t请输入学生的学号，输入0结束输入：";
		cin >> id;
	}
}

void LinkCreate(LinklistG* l, int* n)
{
	char id[100] = { 0 };
	int sa = 0, pr = 0, co = 0, a = 1;
	LinklistG* p = l, * s;
	cout << "\t请输入商品编号，以0结束输入：";
	cin >> id;
	while (1)
	{
		if (strcmp(id, "0") == 0)
			break;
		s = new LinklistG;
		strcpy(s->id, id);
		cout << "\t请输入销售量：";
		cin >> sa;
		s->sale = sa;
		cout << "\t请输入价格：";
		cin >> pr;
		s->price = pr;
		cout << "\t请输入产地代号：";
		cin >> co;
		s->code = co;
		p->next = s;
		p = s;
		s->next = NULL;
		*n += 1;
		cout << "\t请输入商品的编号，输入0结束输入：";
		cin >> id;
	}
}

Linkqueue* QueueCreate()
{
	Linkqueue* plq = new Linkqueue;
	if (plq != NULL)
		plq->front = plq->rear = NULL;
	else
	{
		cout << "\t内存不足\n";
		return NULL;
	}
	cout << "\t创建空链队完成\n";
	return plq;
}

void QueueInput(Linkqueue* l, int n)
{
	nodeg* p = new nodeg;
	if (p == NULL)
		printf("\t内存分配失败!\n");
	else
	{
		p->info = n;
		p->next = NULL;
		if (l->front == NULL)/*原来为空队*/
			l->front = p;
		else
			l->rear->next = p;
		l->rear = p;
	}
}

void QueueInput(Linkqueue* q1, Linkqueue* q2, int d, int pri)
{
	if (pri == 1)
		QueueInput(q1, d);
	else
		QueueInput(q2, d);
}

int QueueOutput(Linkqueue* l, int* n)
{
	nodeg* p;
	if (l->front == NULL)
	{
		cout << "\t队列空\n";
		return -1;
	}
	else
	{
		p = l->front;
		*n = p->info;
		l->front = l->front->next;
		free(p);
		return 1;
	}
}

int QueueOutput(Linkqueue* q1, Linkqueue* q2)
{
	int e;
	if (!QueueEmpty(q2))

	{
		QueueOutput(q2, &e);
	}
	else
	{
		if (!QueueEmpty(q1))
		{
			QueueOutput(q1, &e);
		}
		else
		{
			return 1;
		}
	}
	return e;
}


//入栈出栈
int StackPush(Stack* s, int data)
{
	if (s->top == 100 - 1)
	{
		cout << "\t栈上溢出\n";
		return 0;
	}
	else
	{
		s->top += 1;
		s->data[s->top] = data;
		return 1;
	}
}

int StackPop(Stack* s, int* n)
{
	if (s->top == -1)
	{
		printf("\t栈下溢出!\n");
		return 0;
	}
	else
	{
		*n = s->data[s->top];
		s->top--;
		return 1;
	}
}

Linkstacki* StackPush(Linkstacki* s, int n)
{
	Linkstacki* p = new Linkstacki;
	p->data = n;
	p->next = s;
	s = p;
	return s;
}

int StackGetPop(Linkstacki* s)
{
	if (!s)
	{
		cout << "\t栈是空的\n";
		return 0;
	}
	return s->data;
}

Linkstacki* StackPop(Linkstacki* s, int* n)
{
	Linkstacki* p = s;
	if (!s)
	{
		cout << "\n链栈是空的\n";
		return NULL;
	}
	*n = p->data;
	s = s->next;
	free(p);
	return s;
}

int StackPush(Linkstackc* s, char x)
{
	if (s->top == 99)
	{
		printf("\t栈上溢出!\n");
		return 0;
	}
	else
	{
		s->top = s->top + 1;
		s->data[s->top] = x;
		return 1;
	}
}

int StackPop(Linkstackc* s, char* x)
{
	if (s->top == -1)
	{
		printf("\t栈下溢出!\n");
		return 0;
	}
	else
	{
		*x = s->data[s->top];
		s->top--;
		return 1;
	}
}

void StackEmpty(Linkstacki* s)
{
	int a = s->next ? 0 : 1;
	if (a == 0)
		cout << "\t当前链栈为非空链栈\n";
	else
		cout << "\t当前链栈为空链栈\n";
}

int StackEmpty(Linkstackc* s)
{
	return (s->top < 0 ? 1 : 0);
}


//输出
void StackPrint(Stack* s)
{
	int p;
	if (s->top < 0)
		cout << "\t栈空\n";
	else
	{
		cout << "\t栈数据元素如下:\n";
		p = s->top;
		while (p >= 0)
		{
			cout << "\t" <<  s->data[p];
			p--;
		}
		cout << endl;
	}
}

void SeqPrint(Seqlist* s)
{
	if (s->last == 0)
	{
		cout << "\t表空!\n";
		exit(0);
	}
	else
	{
		cout << "\t表中的数据如下:\n\t";
		for (int a = 0; a <= s->last; a++)
			cout << s->data[a] << "  ";
		cout << endl;
	}
}

void B3Print(bb3* s)
{
	if (s->last == 0)
	{
		cout << "\t表空!\n";
		exit(0);
	}
	else
	{
		cout << "\t表中的数据如下:\n\t";
		for (int a = 0; a <= s->last; a++)
			cout << s->data[a] << "  ";
		cout << endl;
	}
}

void LinkPrint(LinklistC* l)//带头结点
{
	LinklistC* p = l->next;
	cout << "\t字符单链表内容是：\n\t";
	while (p != NULL)
	{
		cout << p->data << " ";
		p = p->next;
	}
	cout << endl;
}

void LinkPrint(LinklistN* l)//带头结点
{
	LinklistN* p = l->next;
	cout << "\t整型单链表内容是：\n\t";
	while (p != NULL)
	{
		cout << p->data << " ";
		p = p->next;
	}
	cout << endl;
}

void LinkPrint(LinklistS* l)
{
	LinklistS* h = l->next;
	cout << "\t学号    语文    数学    英语    物理    化学\n";
	while (h != NULL)
	{
		cout << "\t" << h->id << "\t" << h->chinese << "\t" << h->math << "\t" << h->english << "\t" << h->physics << "\t" << h->chemistry << endl;
		h = h->next;
	}
}

void LinkPrint(LinklistG* l)
{
	LinklistG* h = l->next;
	cout << "\t商品编号    销售量    价格    产地代号\n";
	while (h != NULL)
	{
		cout << "\t" << h->id << "\t    " << h->sale << "\t      " << h->price << "\t" << h->code << endl;
		h = h->next;
	}
}

//输出奇数组与偶数组
void SeqPrintAB()
{
	if (ag == 0)
		cout << "\t偶数组为空\n";
	else
	{
		cout << "\t偶数组为：\n";
		for (int a = 0; a < ag; a++)
			cout << "\t" << aa[a];
		cout << endl;
	}
	if (bg == 0)
		cout << "\t奇数组为空\n";
	else
	{
		cout << "\t奇数组为：\n";
		for (int a = 0; a < bg; a++)
			cout << "\t" << bb[a];
		cout << endl;
	}
}

//奇偶数分组
void SeqGroup(Seqlist* s)
{
	if (s->last == 0)
	{
		cout << "\t表空!\n";
		exit(0);
	}
	else
	{
		for (int a = 0; a <= s->last; a++)
		{
			if (s->data[a] % 2 == 0)
			{
				aa[ag] = s->data[a];
				ag++;
			}
			else
			{
				bb[bg] = s->data[a];
				bg++;
			}
		}
	}
	cout << "\t奇偶数分组已完成\n";
}

//寻找最大值与最小值
void SeqFind(Seqlist* s)
{
	int max = s->data[0], min = max, ma = 0, mi = 0;
	if (s->last == 0)
		cout << "\t表空!\n";
	else
	{
		for (int a = 1; a <= s->last; a++)
		{
			if (s->data[a] > max)
			{
				max = s->data[a];
				ma = a;
			}
			else if (s->data[a] < min)
			{
				min = s->data[a];
				mi = a;
			}
		}
	}
	cout << "\t最大值的下标为：" << ma << "\n\t最小值的下标为：" << mi << endl;
}

//两表总和
void BAdd(bb1* s1, bb2* s2)
{
	int sum = 0;
	for (int a = 0; a <= 10; a++)
		sum += (s1->data[a] + s2->data[a]);
	cout << "\t总和是：" << sum << endl;
}

//两表合并
void BMerge(bb1* s1, bb2* s2, bb3* s3)
{
	if (s1->last == 0 && s2->last == 0)
		cout << "\t两表为空!\n";
	else
	{
		int b1 = 0, b2 = 0;
		while (b1 <= s1->last && b2 <= s2->last)
		{
			if (s1->data[b1] <= s2->data[b2])
				B3Insert(s3, s3->last, s1->data[b1++]);
			else
				B3Insert(s3, s3->last, s2->data[b2++]);
		}
		if (b1 > s1->last && b2 <= s2->last)
			B3Insert(s3, s3->last, s2->data[b2++]);
		else if (b1 <= s1->last && b2 > s2->last)
			B3Insert(s3, s3->last, s1->data[b1++]);
	}
	s3->last--;
}

//两表交集
int LinkInter(LinklistC* a, LinklistC* b, LinklistC* c)
{
	int re = 0;
	LinklistC* p, * q, * r = c, * s, * B = b;
	for (p = a->next; p != NULL; p = p->next)
	{
		for (q = B->next; q != NULL; q = q->next)
		{
			if (p->data == q->data)
			{
				s = new LinklistC;
				s->data = p->data;
				r->next = s;
				r = s;
				s->next = NULL;
				re = 1;
				B = B->next;
			}
		}
	}
	return re;
}

int LinkInter(LinklistN* a, LinklistN* b, LinklistN* c)
{
	int re = 0;
	LinklistN* p, * q, * r = c, * s, * B = b;
	for (p = a->next; p != NULL; p = p->next)
	{
		for (q = B->next; q != NULL; q = q->next)
		{
			if (p->data == q->data)
			{
				s = new LinklistN;
				s->data = p->data;
				r->next = s;
				r = s;
				s->next = NULL;
				re = 1;
				B = B->next;
			}
		}
	}
	return re;
}

//两表并集
void LinkUnion(LinklistC* a, LinklistC* b, LinklistC* c)
{
	LinklistC* p, * q, * r, * s;
	int flag = 0;
	r = c;
	for (p = a->next; p != NULL; p = p->next) /* 先把集合A中所有的元素付给集合C */
	{
		s = new LinklistC;
		s->data = p->data;
		r->next = s;
		r = s;
		s->next = NULL;
	}
	for (p = b->next; p != NULL; p = p->next)
	{
		for (q = a->next; q != NULL; q = q->next)
		{
			if (p->data == q->data)
			{
				flag = 1;
				break;
			}
		}
		if (flag == 0)
		{
			s = new LinklistC;
			s->data = p->data;
			r->next = s;
			r = s;
			s->next = NULL;
		}
		flag = 0;
	}
}

void LinkUnion(LinklistN* a, LinklistN* b, LinklistN* c)
{
	LinklistN* p, * q, * r, * s;
	int flag = 0;
	r = c;
	for (p = a->next; p != NULL; p = p->next) /* 先把集合A中所有的元素付给集合C */
	{
		s = new LinklistN;
		s->data = p->data;
		r->next = s;
		r = s;
		s->next = NULL;
	}
	for (p = b->next; p != NULL; p = p->next)
	{
		for (q = a->next; q != NULL; q = q->next)
		{
			if (p->data == q->data)
			{
				flag = 1;
				break;
			}
		}
		if (flag == 0)
		{
			s = new LinklistN;
			s->data = p->data;
			r->next = s;
			r = s;
			s->next = NULL;
		}
		flag = 0;
	}
}

void LinkDiscount(LinklistG* l)
{
	LinklistG* h = l->next;
	while (h != NULL)
	{
		if (h->sale > 200)
			h->discount = 0.6;
		else if (h->sale > 100)
			h->discount = 0.8;
		else
			h->discount = 0;
		h = h->next;
	}
	h = l->next;
	cout << "\t折扣商品编号    产地代号    折扣\n";
	while (h != NULL)
	{
		if (h->discount != 0)
		cout << "\t" << h->id << "\t        " << h->code << "\t    " << h->discount << endl;
		h = h->next;
	}
}

int StackCorrect(char* s)
{
	Linkstackc* st = new Linkstackc;
	char x;
	int i, flag = 1;
	StackSetNull(st);
	for (i = 0; s[i] != '\0'; i++)/*从字符串的第一个字符开始，逐个判断*/
	{
		switch (s[i])
		{
		case '(':/*如果是"("，入栈*/
			StackPush(st, '(');
			break;
		case '[':
			StackPush(st, '[');
			break;
		case '{':
			StackPush(st, '{');
			break;
		case '《':
			StackPush(st, '《');
			break;
		case '<':
			StackPush(st, '<');
			break;
		case '“':
			StackPush(st, '“');
			break;
		case ')':/* 如果是")"，则"("出栈 */
			if (!(StackPop(st, &x) && x == '('))
				flag = 0;
			break;
		case ']':
			if (!(StackPop(st, &x) && x == '['))
				flag = 0;
			break;
		case '}':
			if (!(StackPop(st, &x) && x == '{'))
				flag = 0;
			break;
		case '》':
			if (!(StackPop(st, &x) && x == '《'))
				flag = 0;
			break;
		case '>':
			if (!(StackPop(st, &x) && x == '<'))
				flag = 0;
			break;
		case '”':
			if (!(StackPop(st, &x) && x == '“'))
				flag = 0;
			break;
		}
		if (!flag)
			break;
	}
	if (StackEmpty(st) && flag)
		return 1;
	else
		return 0;
}


//模拟系统
void HospitalMockSystem()
{
	Linkqueue* q1;  /* 优先级低的病人队列 */
	Linkqueue* q2;  /* 优先级高的病人队列 */
	int menu;       /* 存储用户选择的菜单编号 */
	int priority;   /* 病人看病的优先级别 */
	int id;    /* 按照病人到达医院的先后，领取的号码牌 */
	int e;     /* 病人看病的优先级别 */
	int n = 0;
	q1 = QueueCreate();
	q2 = QueueCreate();
	id = 1;
	cout << "\t****************欢迎进入排队看病模拟系统*******\n";
	cout << "\t********* 1: 新的病人加入队列候诊      ********\n";
	cout << "\t********* 2: 医生根据优先级别为病人诊治********\n";
	cout << "\t********* 3: 退出系统                  ********\n";
	cout << "\t***********************************************\n";
	while (1)
	{
		cout << "\t------------------------------------------------------------\n";
		cout << "\t********请按菜单编号选择相应的操作(系统只处理数值型数据):*********\n";
		cin >> menu;
		if (1 == menu)  /* 如果有新的病人则加入队列 */
		{
			printf("\t请输入病人的优先级别(本模拟系统只设置两个优先级别:1或2):");
			cin >> priority;
			////
			printf("\t请输入病人的三位id号:");
			cin >> id;

			////
			if (1 == priority || 2 == priority)  /* 如果级别输入的正确 */
			{
				//  printf("***该病人的ID为：%d***\n",id);
				QueueInput(q1, q2, id, priority);
			}
			else  /* 如果级别输入的不正确 */
			{
				cout << "\n\t请输入病人的优先级别(本模拟系统只设置两个优先级别:1或2)\n";
			}
		}
		else if (2 == menu)  /* 如果有病人出院 */
		{
			e = QueueOutput(q1, q2);
			if (-1 != e)     /* 如果队列不为空 */
			{
				printf("\t***当前被诊治的病人的ID为：%d***\n", e);
			}
			else        /* 如果队列为空 */
			{
				printf("\t***无病人,队列为空***\n");
			}

		}
		else if (3 == menu)
		{
			break;
		}
		else  /* 如果输入格式错误不为空 */
		{
			printf("\t错误,请按菜单编号输入\n");
		}
	}
}

void RepastMockSystem()
{
	Linkqueue* q1;  /* 优先级低的就餐队列 */
	Linkqueue* q2;  /* 优先级高的就餐队列 */
	int menu;       /* 存储用户选择的菜单编号 */
	int priority;   /* 就餐的优先级别 */
	int id;    /* 按照用户到达医院的先后，领取的号码牌 */
	int e;     /* 就餐的优先级别 */
	int n = 0;
	q1 = QueueCreate();
	q2 = QueueCreate();
	id = 1;
	cout << "\t****************欢迎进入就餐等候模拟系统*******\n";
	cout << "\t********* 1: 新的用户加入队列候诊      ********\n";
	cout << "\t********* 2: 食堂根据优先级别为老人就餐********\n";
	cout << "\t********* 3: 退出系统                  ********\n";
	cout << "\t***********************************************\n";
	while (1)
	{
		cout << "\t------------------------------------------------------------\n";
		cout << "\t********请按菜单编号选择相应的操作(系统只处理数值型数据):*********\n";
		cin >> menu;
		if (1 == menu)  /* 如果有新的病人则加入队列 */
		{
			printf("\t请输入用户的优先级别(本模拟系统只设置两个优先级别:1或60)：");
			cin >> priority;
			////
			printf("\t请输入用户的三位id号：");
			cin >> id;

			////
			if (1 == priority || 2 == priority)  /* 如果级别输入的正确 */
			{
				//  printf("***该病人的ID为：%d***\n",id);
				QueueInput(q1, q2, id, priority);
			}
			else  /* 如果级别输入的不正确 */
			{
				cout << "\n\t请输入用户的优先级别(本模拟系统只设置两个优先级别:1或60)：";
			}
		}
		else if (2 == menu)  /* 如果有病人出院 */
		{
			e = QueueOutput(q1, q2);
			if (-1 != e)     /* 如果队列不为空 */
			{
				printf("\t***当前准备就餐的用户的ID为：%d***\n", e);
			}
			else        /* 如果队列为空 */
			{
				printf("\t***无用户,队列为空***\n");
			}

		}
		else if (3 == menu)
		{
			break;
		}
		else  /* 如果输入格式错误不为空 */
		{
			printf("\t错误,请按菜单编号输入\n");
		}
	}
}

LinkStack* IntConverDToB(int t, LinkStack* s)/*十进制到二进制整数部分转换函数*/
{
	while (t != 0)
	{
		s = LStackPush(s, t % 2);
		t /= 2;
	}
	return s;
}

LinkStack* LStackPush(LinkStack* ls, int x)/*入栈*/
{
	LinkStack* p;
	p = (LinkStack*)malloc(sizeof(LinkStack));/*分配空间*/
	p->data = x;         /*设置新结点的值*/
	p->next = ls;       /*将新元素插入栈中*/
	ls = p;             /*将新元素设为栈顶*/
	return ls;
}

void DecConverDToB(float f, Linkqueue* l)/* 十进制到二进制小数部分转换函数*/
{
	int i = 0;
	while (i <= 6 && f != 0)
	{
		f = f * 2;
		if (f >= 1)
		{
			f -= 1;
			QueueInput(l, 1);
		}
		else
			QueueInput(l, 0);
		i++;
	}
}

int LStackIsEmpty(LinkStack* ls)/*判别空栈*/
{
	return (ls->next ? 0 : 1);
}

int LStackGetTop(LinkStack* ls)/*取栈顶元素*/
{
	if (!ls)
	{
		printf("\t栈是空的\n");
		return 0;
	}
	return ls->data;
}

LinkStack* LStackPop(LinkStack* ls, int* e)/*出栈*/
{
	LinkStack* p;
	if (!ls)/*判断是否为空栈*/
	{
		printf("\n链栈是空的!");
		return NULL;
	}
	p = ls;  /*指向被删除的栈顶*/
	*e = p->data;/*返回栈顶元素*/
	ls = ls->next; /*修改栈顶指针*/
	free(p);
	return ls;
}

int  LQueueIsEmpty(Linkqueue* plq)/*判断链接表示队列是否为空队列*/
{
	return (plq->front == NULL);
}

int  LQueueDeQueue(Linkqueue* plq, int* x)/*出链队*/
{
	nodeg* p;
	if (plq->front == NULL)
	{
		printf("队列空!!\n ");
		return 0;
	}
	else
	{
		p = plq->front;
		*x = p->info;
		plq->front = plq->front->next;
		free(p);
		return 1;
	}
}

int StringSplit(const char* chs, char* chs1, char* chs2) /* 拆分字符串chs，分成整数部分chs1和小数部分chs2 */
{
	int pos = 0, len = 0;
	int i = 0;
	int k = 0;
	GetRadixPoint(chs, &pos, &len);
	if (pos != -1)
	{
		for (i = 0; i < pos; i++)
			chs1[i] = chs[i];
		chs1[i] = '\0';
		for (i = pos + 1; i < len; i++)
			chs2[k++] = chs[i];
		chs2[k] = '\0';
	}
	else
		return 0;
	return 1;
}

void GetRadixPoint(const char* chs, int* pos, int* len) /* 获取小数点位置以及串的长度 */
{
	int i = 0;
	int flag = 0;
	while ('\0' != chs[i])
	{
		if (chs[i] == '.')
		{
			*pos = i;
			flag = 1;
		}
		i++;
	}
	if (flag)
		*len = i;
	else
	{
		*pos = -1;
		*len = i;
	}
}

int IntConverBToD(char* chs, LinkStack* s)/* 二进制到十进制整数部分转换函数*/
{
	int i = 0;
	int sum = 0;
	int k = 1;
	int temp = 0;
	int tt = 0;/*临时输出栈元素使用*/
	while ('\0' != chs[i])
	{
		s = LStackPush(s, chs[i] - '0');
		i++;
	}
	i = 0;
	while (!LStackIsEmpty(s))
	{
		temp = LStackGetTop(s);
		s = LStackPop(s, &tt);
		if (temp != 1 && temp != 0)
			return 0;
		if (0 == i)
			sum += temp;
		else
		{
			k *= 2;
			sum += temp * k;
		}
		i++;
	}
	return sum;
}

float DecConverBToD(char* chs, Linkqueue* l)/* 二进制到十进制小数部分转换函数*/
{
	int i = 0;
	float sum = 0;
	float k = 1;
	int temp = 0;
	while ('\0' != chs[i])
	{
		QueueInput(l, chs[i] - '0');
		i++;
	}
	while (!LQueueIsEmpty(l))
	{
		LQueueDeQueue(l, &temp);
		if (temp != 1 && temp != 0)
			return 0;
		k /= 2;
		sum += temp * k;
		i++;
	}
	return sum;
}