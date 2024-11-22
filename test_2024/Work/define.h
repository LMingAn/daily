#pragma once
#include <iostream>
#include <cstring>
using namespace std;

//定义
typedef struct
{
	int data[100];
	int last;//下标
}Seqlist;

typedef struct
{
	int data[100];
	int last;
}bb1;

typedef struct
{
	int data[100];
	int last;
}bb2;

typedef struct
{
	int data[200];
	int last;
}bb3;

typedef struct nodea
{
	char data;
	struct nodea* next;
}LinklistC;

typedef struct nodeb
{
	int data;
	struct nodeb* next;
}LinklistN;

typedef struct nodec
{
	char id[100];
	int chinese;
	int math;
	int english;
	int physics;
	int chemistry;
	struct nodec* next;
}LinklistS;

typedef struct noded
{
	char id[100];//商品编号
	int sale;//销售量  
	int price;//价格 
	int code;//产地代号
	float discount;//折扣
	struct noded* next;
}LinklistG;

typedef struct
{
	int data[100];
	int top;
}Stack;

typedef struct nodee
{
	int data;
	struct nodee* next;
}Linkstacki;

typedef struct nodef
{
	char data[100];
	int top;
}Linkstackc;

typedef struct nodeg
{
	int info;
	struct nodeg* next;
}nodeg;

typedef struct
{
	struct nodeg* front;
	struct nodeg* rear;
}Linkqueue;

typedef struct node
{
	int data;
	struct node* next;
}LinkStack;

//函数
void SeqSetNull(Seqlist* s);
void B1SetNull(bb1* s);
void B2SetNull(bb2* s);
void LinkSetNull(LinklistC* l);
void LinkSetNull(LinklistN* l);
void StackSetNull(Stack* s);
void StackSetNull(Linkstackc* s);

Linkstacki* StackInit();

int SeqLength(Seqlist* s);
int B1Length(bb1* s);
int B2Length(bb2* s);
int LinkLength(LinklistC* l);
int QueueEmpty(Linkqueue* l);

int SeqGet(Seqlist* s, int n);
LinklistC*  LinkGet(LinklistC* l, int n);

int SeqLocate(Seqlist* s, int n);
LinklistC* LinkLocate(LinklistC* l, int n);

int SeqInsert(Seqlist* s, int n, int m);
void B3Insert(bb3* s, int n, int m);
int LinkInsert(LinklistC* l, int n, char m);
int LinkInsert(LinklistN* l, int n, int m);
void LinkInsert(LinklistS* l, char id[], int* n);
void LinkInsert(LinklistG* l, char id[], int* n);

int SeqDelete(Seqlist* s, int n);
void LinkDelete(LinklistC* l, int n);
void LinkDelete(LinklistN* l, int n);
int LinkDelete(LinklistS* l, char id[], int* n);
int LinkDelete(LinklistG* l, char id[], int* n);

void SeqCreate(Seqlist* s);
void B1Create(bb1* s);
void B2Create(bb2* s);
void LinkCreateH(LinklistC* l);
void LinkCreateR(LinklistC* l);
void LinkCreateR(LinklistN* l);
void LinkCreate(LinklistS* l, int *n);
void LinkCreate(LinklistG* l, int* n);
Linkqueue* QueueCreate();
void QueueInput(Linkqueue* l, int n);
void QueueInput(Linkqueue* q1, Linkqueue* q2, int d, int pri);
int QueueOutput(Linkqueue* l, int* n);
int QueueOutput(Linkqueue* q1, Linkqueue* q2);

int StackPush(Stack* s, int n);
int StackPop(Stack* s, int* n);
Linkstacki* StackPush(Linkstacki* s, int n);
int StackGetPop(Linkstacki* s);
Linkstacki* StackPop(Linkstacki* s, int* n);
void StackEmpty(Linkstacki* s);
int StackEmpty(Linkstackc* s);
int StackPush(Linkstackc* s, char n);
int StackPop(Linkstackc* s, char* n);

void SeqPrint(Seqlist* s);
void B3Print(bb3* s);
void SeqPrintAB();
void LinkPrint(LinklistC* l);
void LinkPrint(LinklistN* l);
void LinkPrint(LinklistS* l);
void LinkPrint(LinklistG* l);
void StackPrint(Stack* s);

void SeqGroup(Seqlist* s);


void SeqFind(Seqlist* s);

void BAdd(bb1* s1, bb2* s2);

void BMerge(bb1* s1, bb2* s2, bb3* s3);

int LinkInter(LinklistC* a, LinklistC* b, LinklistC* c);
int LinkInter(LinklistN* a, LinklistN* b, LinklistN* c);

void LinkUnion(LinklistC* a, LinklistC* b, LinklistC* c);
void LinkUnion(LinklistN* a, LinklistN* b, LinklistN* c);

void LinkDiscount(LinklistG* l);

int StackCorrect(char* s);

void HospitalMockSystem();
void RepastMockSystem();

LinkStack* IntConverDToB(int t, LinkStack* s);
LinkStack* LStackPush(LinkStack* ls, int x);
void DecConverDToB(float f, Linkqueue* l);
int LStackIsEmpty(LinkStack* ls);
int LStackGetTop(LinkStack* ls);
LinkStack* LStackPop(LinkStack* ls, int* e);
int  LQueueIsEmpty(Linkqueue* plq);
int  LQueueDeQueue(Linkqueue* plq, int* x);
int StringSplit(const char* chs, char* chs1, char* chs2);
void GetRadixPoint(const char* chs, int* pos, int* len);
int IntConverBToD(char* chs, LinkStack* s);
float DecConverBToD(char* chs, Linkqueue* l);