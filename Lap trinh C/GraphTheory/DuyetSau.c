#include <stdio.h>
#define MAX_LENGTH 100

typedef struct 
{
    int u, v; 
}edge;

typedef struct 
{
    int n, m; 
    edge data[MAX_LENGTH];
}graph;

typedef struct 
{
    int data[MAX_LENGTH];
    int size;
}LIST;

void makeNull(LIST *L){
    L->size = 0;
}
int elementAt(LIST *L, int x){
    return L->data[x];
}
void pushLIST(LIST *L, int x){
    L->data[L->size] = x;
    L->size++;
}

void initGraph(graph *G, int n){
    G->n = n;
    G->m = 0;
    printf("Do thi G co so dinh n = %d va so canh m = %d\n", G->n, G->m);
}

void addEdge(graph *G, int u, int v){
    int i;
    for(i = 0; i<G->m; i++){
        if ((G->data[i].u == u && G->data[i].v == v) || (G->data[i].u == v && G->data[i].v == u))
        {
            printf("Canh da co trong do thi!");
            return;
        }
    }
    G->data[G->m].u = u;
    G->data[G->m].v = v;
    G->m++;
    printf("Do thi da them vao canh %d %d\n", G->data[G->m-1].u, G->data[G->m-1].v);
} 
int adjacent(graph *G, int u, int v){
    int i;
    for(i = 0; i<=G->m; i++){
        if ((G->data[i].u == u && G->data[i].v == v) || (G->data[i].v == u && G->data[i].u == v))
        {
            return 1;
        }
    }
    return 0;
}

void degree(graph *G, int x){
    int i, count = 0;
    for(i = 0; i<=G->m; i++){
        if (adjacent(G, x, i))
        {
            count++;
        }
    }
    printf("Bac cua canh %d la: %d\n", x, count);
}

LIST neighbors(graph *G, int x){
    LIST List;
    makeNull(&List);
    int i;
    for(i = 1; i<=G->n; i++){
        if (adjacent(G, x, i) == 1)
        {
            pushLIST(&List, i);
        }
    }
    return List;
}


typedef struct {
	int data[100];
	int size; 
}Stack;

void make_null_stack(Stack* S)
{
	S->size=0;
}

void push(Stack *S,int x)
{
	S->data[S->size] = x;
	S->size++;
}

int top(Stack *S)
{
	return S->data[S->size-1];
}

void pop(Stack *S)
{
	S->size--;
}

int empty(Stack *S)
{
	return S->size == 0 ;
}

void DFS(graph *G,int start,int M[100])
{
	Stack L;
	int mark[100]; 
	make_null_stack(&L);

	int i,j;
	for(i=1;i<=G->n;i++)
		mark[i] = 0;

	push(&L,start);
	while(!empty(&L)) 
	{
		int x=top(&L) ; pop(&L); 
		if(mark[x] != 0 ) continue; 
		printf("%d ",x); 
		M[x] 	= 1;
		mark[x] = 1; 

		LIST List = neighbors(G,x);

		for(j=0; j< List.size;j++)
		{
			int adj = elementAt(&List,j);
			push(&L,adj);
		}
	}
}
int main(int argc, char const *argv[])
{
    int n, m, u, v, i, j;
    scanf("%d%d", &n, &m);
    graph G;
    initGraph(&G, n);
    for(i = 1; i<=m; i++){
        scanf("%d%d", &u, &v);
        addEdge(&G, u, v);
    }
    for(i = 1; i<=n; i++){
        degree(&G, i);
    }
    for(i = 1; i<=n; i++){
        LIST l = neighbors(&G, i);
        printf("neighbor(%d): ", i);
        for(j = 0; j<l.size; j++){
            printf("%d ", elementAt(&l, j));
        }
        printf("\n");
    }

    int M[100];
    for(i=1;i<=G.n;i++)
		M[i] = 0;
    for(i=1;i<=G.n;i++)
	{
		if(M[i]==0)
		{
			printf("\nDuyet DFS cua dinh %d : ",i);
			DFS(&G,i,M);
		}
	}
    return 0;
}
