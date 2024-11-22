#include "define.h"

int aa[100] = { 0 }, ag = 0;
int bb[100] = { 0 }, bg = 0;

//�ÿձ�
void SeqSetNull(Seqlist* s)
{
	s->last = -1;
	cout << "\t���ÿ�˳���Seqlist\n";
}

void B1SetNull(bb1* s)
{
	s->last = -1;
	cout << "\t���ÿ�˳���bb1\n";
}

void B2SetNull(bb2* s)
{
	s->last = -1;
	cout << "\t���ÿ�˳���bb2\n";
}

void LinkSetNull(LinklistC* l)
{
	l->next = NULL;
	cout << "\t���ÿ�����\n";
}

void LinkSetNull(LinklistN* l)
{
	l->next = NULL;
	cout << "\t���ÿ�����\n";
}

void StackSetNull(Stack* s)
{
	s->top = -1;
	cout << "\t���ÿ�˳��ջ\n";
}

void StackSetNull(Linkstackc* s)
{
	s->top = -1;
	cout << "\t���ÿ�˳��ջ\n";
}

Linkstacki* StackInit()
{
	Linkstacki* h = new Linkstacki;
	h->data = 1;
	h->next = NULL;
	return h;
}

//ȡ����
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

//ȡ���
int SeqGet(Seqlist* s, int n)
{
	if (n < 1 || n > s->last + 1)
	{
		cout << "\t�ڵ�n��λ�ò���ȷ\n";
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

//����
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

//����
int SeqInsert(Seqlist* s, int n, int m)
{
	if (n > 100)
	{
		cout << "\t�±����\n";
		return 0;
	}
	if (n < 1 || n > s->last + 2)
	{
		cout << "\t����λ�ò���ȷ\n";
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
		cout << "\t�±����\n";
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
		cout << "\t����λ�ô���\n";
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
		cout << "\t����λ�ô���\n";
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
	cout << "\t���������ĳɼ���";
	cin >> chi;
	cout << "\t��������ѧ�ɼ���";
	cin >> ma;
	cout << "\t������Ӣ��ɼ���";
	cin >> en;
	cout << "\t����������ɼ���";
	cin >> ph;
	cout << "\t�����뻯ѧ�ɼ���";
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
	cout << "\t��������������";
	cin >> sa;
	cout << "\t������۸�";
	cin >> pr;
	cout << "\t��������ش��ţ�";
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

//ɾ��
int SeqDelete(Seqlist* s, int n)
{
	if (n < 1 || n > s->last + 1)
	{
		cout << "\tɾ��λ�ô���\n";
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
		cout << "\tɾ������λ�ô���\n";
	else
	{
		cout << "\tɾ��������Ԫ���ǣ�" << p->next->data << endl;
		ne = p->next;
		p->next = p->next->next;
		int de = ne->data;
		free(ne);
		cout << "\t�ɹ�ɾ�����\n";
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
		cout << "\tɾ������λ�ô���\n";
	else
	{
		cout << "\tɾ��������Ԫ���ǣ�" << p->next->data << endl;
		ne = p->next;
		p->next = p->next->next;
		int de = ne->data;
		free(ne);
		cout << "\t�ɹ�ɾ�����\n";
	}
}

int LinkDelete(LinklistS* l, char id[], int* n)
{
	LinklistS* p = l, * s;
	if (p->next == NULL)
	{
		cout << "\tѧ������û���κ�ѧ����¼\n";
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
		cout << "\tѧ������û�и�ѧ����¼\n";
		return 0;
	}
}

int LinkDelete(LinklistG* l, char id[], int* n)
{
	LinklistG* p = l, * s;
	if (p->next == NULL)
	{
		cout << "\t��Ʒ����û���κ���Ʒ��¼\n";
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

//����
void SeqCreate(Seqlist* s)
{
	int n = 0, m = 0;
	cout << "\t�����ĳ���:";
	cin >> n;
	s->last = n - 1;
	cout << "\t����������е����ݣ�������:\n";
	for (m = 0; m < n; m++)
	{
		printf("\t��%d��Ԫ����:", m + 1);
		cin >> s->data[m];
	}
}

void B1Create(bb1* s)
{
	int n = 0, m = 0;
	cout << "\t�����bb1�ĳ���:";
	cin >> n;
	s->last = n - 1;
	cout << "\t����������е����ݣ�������:\n";
	for (m = 0; m < n; m++)
	{
		printf("\t��%d��Ԫ����:", m + 1);
		cin >> s->data[m];
	}
}

void B2Create(bb2* s)
{
	int n = 0, m = 0;
	cout << "\t�����bb2�ĳ���:";
	cin >> n;
	s->last = n - 1;
	cout << "\t����������е����ݣ�������:\n";
	for (m = 0; m < n; m++)
	{
		printf("\t��%d��Ԫ����:", m + 1);
		cin >> s->data[m];
	}
}

void LinkCreateH(LinklistC* head)//ͷ�巨--����ͷ���
{
	char in = 0;
	head = NULL;
	LinklistC* l;
	cout << "\t���������ݣ���#��������";
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

void LinkCreateR(LinklistC* head)//β�巨--��ͷ���
{
	char in = 0;
	LinklistC* p, * l = head;
	cout << "\t���������ݣ���#��������";
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

void LinkCreateR(LinklistN* head)//β�巨--��ͷ���
{
	LinklistN* p, * l = head;
	int n = 0, m = 0;
	cout << "\t�����ĳ���:";
	cin >> n;
	cout << "\t����������е����ݣ�������:\n";
	for (m = 0; m < n; m++)
	{
		p = new LinklistN;
		cout << "\t��" << m + 1 << "��Ԫ����:";
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
	cout << "\t������ѧ��ѧ�ţ���0�������룺";
	cin >> id;
	while (1)
	{
		if (strcmp(id, "0") == 0)
			break;
		s = new LinklistS;
		strcpy(s->id, id);
		cout << "\t���������ĳɼ���";
		cin >> chi;
		s->chinese = chi;
		cout << "\t��������ѧ�ɼ���";
		cin >> ma;
		s->math = ma;
		cout << "\t������Ӣ��ɼ���";
		cin >> en;
		s->english = en;
		cout << "\t����������ɼ���";
		cin >> ph;
		s->physics = ph;
		cout << "\t�����뻯ѧ�ɼ���";
		cin >> che;
		s->chemistry = che;
		p->next = s;
		p = s;
		s->next = NULL;
		*n += 1;
		cout << "\t������ѧ����ѧ�ţ�����0�������룺";
		cin >> id;
	}
}

void LinkCreate(LinklistG* l, int* n)
{
	char id[100] = { 0 };
	int sa = 0, pr = 0, co = 0, a = 1;
	LinklistG* p = l, * s;
	cout << "\t��������Ʒ��ţ���0�������룺";
	cin >> id;
	while (1)
	{
		if (strcmp(id, "0") == 0)
			break;
		s = new LinklistG;
		strcpy(s->id, id);
		cout << "\t��������������";
		cin >> sa;
		s->sale = sa;
		cout << "\t������۸�";
		cin >> pr;
		s->price = pr;
		cout << "\t��������ش��ţ�";
		cin >> co;
		s->code = co;
		p->next = s;
		p = s;
		s->next = NULL;
		*n += 1;
		cout << "\t��������Ʒ�ı�ţ�����0�������룺";
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
		cout << "\t�ڴ治��\n";
		return NULL;
	}
	cout << "\t�������������\n";
	return plq;
}

void QueueInput(Linkqueue* l, int n)
{
	nodeg* p = new nodeg;
	if (p == NULL)
		printf("\t�ڴ����ʧ��!\n");
	else
	{
		p->info = n;
		p->next = NULL;
		if (l->front == NULL)/*ԭ��Ϊ�ն�*/
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
		cout << "\t���п�\n";
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


//��ջ��ջ
int StackPush(Stack* s, int data)
{
	if (s->top == 100 - 1)
	{
		cout << "\tջ�����\n";
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
		printf("\tջ�����!\n");
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
		cout << "\tջ�ǿյ�\n";
		return 0;
	}
	return s->data;
}

Linkstacki* StackPop(Linkstacki* s, int* n)
{
	Linkstacki* p = s;
	if (!s)
	{
		cout << "\n��ջ�ǿյ�\n";
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
		printf("\tջ�����!\n");
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
		printf("\tջ�����!\n");
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
		cout << "\t��ǰ��ջΪ�ǿ���ջ\n";
	else
		cout << "\t��ǰ��ջΪ����ջ\n";
}

int StackEmpty(Linkstackc* s)
{
	return (s->top < 0 ? 1 : 0);
}


//���
void StackPrint(Stack* s)
{
	int p;
	if (s->top < 0)
		cout << "\tջ��\n";
	else
	{
		cout << "\tջ����Ԫ������:\n";
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
		cout << "\t���!\n";
		exit(0);
	}
	else
	{
		cout << "\t���е���������:\n\t";
		for (int a = 0; a <= s->last; a++)
			cout << s->data[a] << "  ";
		cout << endl;
	}
}

void B3Print(bb3* s)
{
	if (s->last == 0)
	{
		cout << "\t���!\n";
		exit(0);
	}
	else
	{
		cout << "\t���е���������:\n\t";
		for (int a = 0; a <= s->last; a++)
			cout << s->data[a] << "  ";
		cout << endl;
	}
}

void LinkPrint(LinklistC* l)//��ͷ���
{
	LinklistC* p = l->next;
	cout << "\t�ַ������������ǣ�\n\t";
	while (p != NULL)
	{
		cout << p->data << " ";
		p = p->next;
	}
	cout << endl;
}

void LinkPrint(LinklistN* l)//��ͷ���
{
	LinklistN* p = l->next;
	cout << "\t���͵����������ǣ�\n\t";
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
	cout << "\tѧ��    ����    ��ѧ    Ӣ��    ����    ��ѧ\n";
	while (h != NULL)
	{
		cout << "\t" << h->id << "\t" << h->chinese << "\t" << h->math << "\t" << h->english << "\t" << h->physics << "\t" << h->chemistry << endl;
		h = h->next;
	}
}

void LinkPrint(LinklistG* l)
{
	LinklistG* h = l->next;
	cout << "\t��Ʒ���    ������    �۸�    ���ش���\n";
	while (h != NULL)
	{
		cout << "\t" << h->id << "\t    " << h->sale << "\t      " << h->price << "\t" << h->code << endl;
		h = h->next;
	}
}

//�����������ż����
void SeqPrintAB()
{
	if (ag == 0)
		cout << "\tż����Ϊ��\n";
	else
	{
		cout << "\tż����Ϊ��\n";
		for (int a = 0; a < ag; a++)
			cout << "\t" << aa[a];
		cout << endl;
	}
	if (bg == 0)
		cout << "\t������Ϊ��\n";
	else
	{
		cout << "\t������Ϊ��\n";
		for (int a = 0; a < bg; a++)
			cout << "\t" << bb[a];
		cout << endl;
	}
}

//��ż������
void SeqGroup(Seqlist* s)
{
	if (s->last == 0)
	{
		cout << "\t���!\n";
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
	cout << "\t��ż�����������\n";
}

//Ѱ�����ֵ����Сֵ
void SeqFind(Seqlist* s)
{
	int max = s->data[0], min = max, ma = 0, mi = 0;
	if (s->last == 0)
		cout << "\t���!\n";
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
	cout << "\t���ֵ���±�Ϊ��" << ma << "\n\t��Сֵ���±�Ϊ��" << mi << endl;
}

//�����ܺ�
void BAdd(bb1* s1, bb2* s2)
{
	int sum = 0;
	for (int a = 0; a <= 10; a++)
		sum += (s1->data[a] + s2->data[a]);
	cout << "\t�ܺ��ǣ�" << sum << endl;
}

//����ϲ�
void BMerge(bb1* s1, bb2* s2, bb3* s3)
{
	if (s1->last == 0 && s2->last == 0)
		cout << "\t����Ϊ��!\n";
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

//������
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

//������
void LinkUnion(LinklistC* a, LinklistC* b, LinklistC* c)
{
	LinklistC* p, * q, * r, * s;
	int flag = 0;
	r = c;
	for (p = a->next; p != NULL; p = p->next) /* �ȰѼ���A�����е�Ԫ�ظ�������C */
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
	for (p = a->next; p != NULL; p = p->next) /* �ȰѼ���A�����е�Ԫ�ظ�������C */
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
	cout << "\t�ۿ���Ʒ���    ���ش���    �ۿ�\n";
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
	for (i = 0; s[i] != '\0'; i++)/*���ַ����ĵ�һ���ַ���ʼ������ж�*/
	{
		switch (s[i])
		{
		case '(':/*�����"("����ջ*/
			StackPush(st, '(');
			break;
		case '[':
			StackPush(st, '[');
			break;
		case '{':
			StackPush(st, '{');
			break;
		case '��':
			StackPush(st, '��');
			break;
		case '<':
			StackPush(st, '<');
			break;
		case '��':
			StackPush(st, '��');
			break;
		case ')':/* �����")"����"("��ջ */
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
		case '��':
			if (!(StackPop(st, &x) && x == '��'))
				flag = 0;
			break;
		case '>':
			if (!(StackPop(st, &x) && x == '<'))
				flag = 0;
			break;
		case '��':
			if (!(StackPop(st, &x) && x == '��'))
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


//ģ��ϵͳ
void HospitalMockSystem()
{
	Linkqueue* q1;  /* ���ȼ��͵Ĳ��˶��� */
	Linkqueue* q2;  /* ���ȼ��ߵĲ��˶��� */
	int menu;       /* �洢�û�ѡ��Ĳ˵���� */
	int priority;   /* ���˿��������ȼ��� */
	int id;    /* ���ղ��˵���ҽԺ���Ⱥ���ȡ�ĺ����� */
	int e;     /* ���˿��������ȼ��� */
	int n = 0;
	q1 = QueueCreate();
	q2 = QueueCreate();
	id = 1;
	cout << "\t****************��ӭ�����Ŷӿ���ģ��ϵͳ*******\n";
	cout << "\t********* 1: �µĲ��˼�����к���      ********\n";
	cout << "\t********* 2: ҽ���������ȼ���Ϊ��������********\n";
	cout << "\t********* 3: �˳�ϵͳ                  ********\n";
	cout << "\t***********************************************\n";
	while (1)
	{
		cout << "\t------------------------------------------------------------\n";
		cout << "\t********�밴�˵����ѡ����Ӧ�Ĳ���(ϵͳֻ������ֵ������):*********\n";
		cin >> menu;
		if (1 == menu)  /* ������µĲ����������� */
		{
			printf("\t�����벡�˵����ȼ���(��ģ��ϵͳֻ�����������ȼ���:1��2):");
			cin >> priority;
			////
			printf("\t�����벡�˵���λid��:");
			cin >> id;

			////
			if (1 == priority || 2 == priority)  /* ��������������ȷ */
			{
				//  printf("***�ò��˵�IDΪ��%d***\n",id);
				QueueInput(q1, q2, id, priority);
			}
			else  /* �����������Ĳ���ȷ */
			{
				cout << "\n\t�����벡�˵����ȼ���(��ģ��ϵͳֻ�����������ȼ���:1��2)\n";
			}
		}
		else if (2 == menu)  /* ����в��˳�Ժ */
		{
			e = QueueOutput(q1, q2);
			if (-1 != e)     /* ������в�Ϊ�� */
			{
				printf("\t***��ǰ�����εĲ��˵�IDΪ��%d***\n", e);
			}
			else        /* �������Ϊ�� */
			{
				printf("\t***�޲���,����Ϊ��***\n");
			}

		}
		else if (3 == menu)
		{
			break;
		}
		else  /* ��������ʽ����Ϊ�� */
		{
			printf("\t����,�밴�˵��������\n");
		}
	}
}

void RepastMockSystem()
{
	Linkqueue* q1;  /* ���ȼ��͵ľͲͶ��� */
	Linkqueue* q2;  /* ���ȼ��ߵľͲͶ��� */
	int menu;       /* �洢�û�ѡ��Ĳ˵���� */
	int priority;   /* �Ͳ͵����ȼ��� */
	int id;    /* �����û�����ҽԺ���Ⱥ���ȡ�ĺ����� */
	int e;     /* �Ͳ͵����ȼ��� */
	int n = 0;
	q1 = QueueCreate();
	q2 = QueueCreate();
	id = 1;
	cout << "\t****************��ӭ����Ͳ͵Ⱥ�ģ��ϵͳ*******\n";
	cout << "\t********* 1: �µ��û�������к���      ********\n";
	cout << "\t********* 2: ʳ�ø������ȼ���Ϊ���˾Ͳ�********\n";
	cout << "\t********* 3: �˳�ϵͳ                  ********\n";
	cout << "\t***********************************************\n";
	while (1)
	{
		cout << "\t------------------------------------------------------------\n";
		cout << "\t********�밴�˵����ѡ����Ӧ�Ĳ���(ϵͳֻ������ֵ������):*********\n";
		cin >> menu;
		if (1 == menu)  /* ������µĲ����������� */
		{
			printf("\t�������û������ȼ���(��ģ��ϵͳֻ�����������ȼ���:1��60)��");
			cin >> priority;
			////
			printf("\t�������û�����λid�ţ�");
			cin >> id;

			////
			if (1 == priority || 2 == priority)  /* ��������������ȷ */
			{
				//  printf("***�ò��˵�IDΪ��%d***\n",id);
				QueueInput(q1, q2, id, priority);
			}
			else  /* �����������Ĳ���ȷ */
			{
				cout << "\n\t�������û������ȼ���(��ģ��ϵͳֻ�����������ȼ���:1��60)��";
			}
		}
		else if (2 == menu)  /* ����в��˳�Ժ */
		{
			e = QueueOutput(q1, q2);
			if (-1 != e)     /* ������в�Ϊ�� */
			{
				printf("\t***��ǰ׼���Ͳ͵��û���IDΪ��%d***\n", e);
			}
			else        /* �������Ϊ�� */
			{
				printf("\t***���û�,����Ϊ��***\n");
			}

		}
		else if (3 == menu)
		{
			break;
		}
		else  /* ��������ʽ����Ϊ�� */
		{
			printf("\t����,�밴�˵��������\n");
		}
	}
}

LinkStack* IntConverDToB(int t, LinkStack* s)/*ʮ���Ƶ���������������ת������*/
{
	while (t != 0)
	{
		s = LStackPush(s, t % 2);
		t /= 2;
	}
	return s;
}

LinkStack* LStackPush(LinkStack* ls, int x)/*��ջ*/
{
	LinkStack* p;
	p = (LinkStack*)malloc(sizeof(LinkStack));/*����ռ�*/
	p->data = x;         /*�����½���ֵ*/
	p->next = ls;       /*����Ԫ�ز���ջ��*/
	ls = p;             /*����Ԫ����Ϊջ��*/
	return ls;
}

void DecConverDToB(float f, Linkqueue* l)/* ʮ���Ƶ�������С������ת������*/
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

int LStackIsEmpty(LinkStack* ls)/*�б��ջ*/
{
	return (ls->next ? 0 : 1);
}

int LStackGetTop(LinkStack* ls)/*ȡջ��Ԫ��*/
{
	if (!ls)
	{
		printf("\tջ�ǿյ�\n");
		return 0;
	}
	return ls->data;
}

LinkStack* LStackPop(LinkStack* ls, int* e)/*��ջ*/
{
	LinkStack* p;
	if (!ls)/*�ж��Ƿ�Ϊ��ջ*/
	{
		printf("\n��ջ�ǿյ�!");
		return NULL;
	}
	p = ls;  /*ָ��ɾ����ջ��*/
	*e = p->data;/*����ջ��Ԫ��*/
	ls = ls->next; /*�޸�ջ��ָ��*/
	free(p);
	return ls;
}

int  LQueueIsEmpty(Linkqueue* plq)/*�ж����ӱ�ʾ�����Ƿ�Ϊ�ն���*/
{
	return (plq->front == NULL);
}

int  LQueueDeQueue(Linkqueue* plq, int* x)/*������*/
{
	nodeg* p;
	if (plq->front == NULL)
	{
		printf("���п�!!\n ");
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

int StringSplit(const char* chs, char* chs1, char* chs2) /* ����ַ���chs���ֳ���������chs1��С������chs2 */
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

void GetRadixPoint(const char* chs, int* pos, int* len) /* ��ȡС����λ���Լ����ĳ��� */
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

int IntConverBToD(char* chs, LinkStack* s)/* �����Ƶ�ʮ������������ת������*/
{
	int i = 0;
	int sum = 0;
	int k = 1;
	int temp = 0;
	int tt = 0;/*��ʱ���ջԪ��ʹ��*/
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

float DecConverBToD(char* chs, Linkqueue* l)/* �����Ƶ�ʮ����С������ת������*/
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