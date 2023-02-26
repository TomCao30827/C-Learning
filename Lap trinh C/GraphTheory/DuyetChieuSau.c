#include<stdio.h>
#include"DoThi.c"
#include"DanhSachDac.c"

#define MAX_ELEMENTS 100
#define MAX_VERTEXES 100

// Khai bao stack

typedef struct {
	int data[MAX_ELEMENTS];
	int size;
}Stack;

void make_null_stack(Stack* S) {
	S->size = 0;
}

void push(Stack* S, int x) {
	S->data[S->size] = x;
	S->size++;
}

int top(Stack* S) {
	return S->data[S->size - 1];
}

void pop(Stack* S) {
	S->size--;
}

int empty(Stack* S) {
	return S->size == 0;
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

// Duyet theo chieu sau

void depth_first_search(Graph* G) {
	Stack L;
	int mark[MAX_VERTEXES];
	make_null_stack(&L);
	
	int j;
	for (j = 0; j < G->n; j++) {
		mark[j] = 0;
	}
	
	while (!empty(&L)) {
		int x = top(&L);
		pop(&L);
		if (mark[x] != 0) {
			continue;
		}
		printf("Duyet %d\n", x);
		mark[x] = 1;
		List list = neighbours(G, x);
		for (j = 1; j <= list.size; j++) {
			int y = element_at(&list, j);
			push(&L, y);
		}
	}
}

