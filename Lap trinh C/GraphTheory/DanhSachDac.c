#include<stdio.h>
#define MAX_ELEMENTS 100

typedef int ElementType;

typedef struct {
	ElementType data[MAX_ELEMENTS];
	int size;
}List;

void make_null_list(List* L) {
	L->size = 0;
}

void push_back(List *L, ElementType x) {
	L->data[L->size] = x; L->size++;
}

ElementType element_at(List *L, int i) {
	return L->data[i];
}

int count_list(List *L) {
	return L->size;
}

