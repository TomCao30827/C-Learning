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


typedef struct{
	int data[100];
	int front , rear;
}Queue;

void make_null_queue(Queue* Q)
{
	Q->front = 0; 
	Q->rear  = -1;
}
void push(Queue* Q , int x) 
{
	Q->rear++; 
	Q->data[Q->rear] = x ;
}

int top(Queue *Q)
{
	return Q->data[Q->front];
}
int pop(Queue *Q)
{
	Q->front++;
}
int empty(Queue* Q)
{
	return Q->front > Q->rear;
}

void BFS(graph *G,int start,int M[100])
{
	
	Queue Q;
	make_null_queue(&Q);
	int mark[100];
	

	int i;
	for(i=1;i<=G->n;i++)
		mark[i] = 0;

	push(&Q,start);
	printf("%d ",start);
	M[start] = 1;
	mark[start]=1;

	while(!empty(&Q))
	{

		int x=top(&Q); pop(&Q);
		LIST List=neighbors(G,x);
		int j;
		for (j=0; j<List.size ; j++)
		{
			int label = elementAt(&List,j);
			if(mark[label]==0) 
				M[label] =1;
				push(&Q,label);
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
    printf("\nDuyet theo BFS\n");
	
	int M[100];
    for(i=1;i<=G.n;i++)
		M[i] = 0;
    for(i=1;i<=G.n;i++)
	{
		if(M[i]==0)
		{
			printf("\nDuyet BFS cua dinh %d : ",i);
			BFS(&G,i,M);
		}
		
	}
    return 0;
}

