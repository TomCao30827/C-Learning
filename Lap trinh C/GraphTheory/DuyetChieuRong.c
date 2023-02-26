#include<stdio.h>
#include"DoThi.c"
#include"DanhSachDac.c"


#define MAX_ELEMENTS 100
#define MAX_VERTEXES 100

// Khai bao Queue
typedef struct {
	int data[MAX_ELEMENTS];
	int front, rear;
}Queue;

void make_null_queue(Queue* Q) {
	Q->front = 0;
	Q->rear = -1;
}

void enqueue(Queue* Q, ElementType u) {
	Q->rear++;
	Q->data[Q->rear] = u;
}

void push(Queue* Q, int x) {
	Q->rear++;
	Q->data[Q->rear] = x;
}

int top(Queue* Q) {
	return Q->data[Q->front];
}

void pop(Queue* Q) {
	Q->front++;
}

int empty(Queue* Q) {
	return Q->front > Q->rear;
}


List neighbors(Graph* G, int x) {
	int y;
	List list;
	make_null(&list);
	for (y = 1; y <= G->n; y++) {
		if (adjacent(G, x, y)) {
			push_back(&list, y);
			return list;
		}
	}
}
// Duyet theo chieu rong

void breath_first_search(Graph* G, int s) {
	Queue Q; 
	make_null_queue(&Q);
	int mark[MAX_VERTEXES];
	int j;
	for (j = 0; j < G->n; j++) {
		mark[j] = 0;
	}
	enqueue (&Q, s);
	while (!empty(&Q)) {
		int u = front(&Q); dequeue(&Q);
		if(mark[u] != 0) {
			continue;
		}
		printf("Duyet %d\n", u);
		mark[u] = 1;
		int v;
		for (v = 1; v <= G->n; v++) {
			if (adjacent(G, u, v)) {
				enqueue(&Q, v);
			}
		}
	}
} 


