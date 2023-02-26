#include<stdio.h>
#define MAX_M 500

typedef struct {
	int u, v;
}Edge;

typedef struct {
	int n, m;
	Edge edges[MAX_M];
}Graph;


void init_graph(Graph *G, int n) {
	G->n = n;
	G->m = 0;
}

void add_edge(Graph *G, int u, int v) {
	G->edges[G->m].u = u;
	G->edges[G->m].v = v;
	G->m++;
}
int adjacent(Graph *G, int u, int v) {
	int e;
	for (e = 0; e < G->m; e++) {
		if((G->edges[e].u == u && G->edges[e].v == v) || (G->edges[e].u == v && G->edges[e].v == u)) {
			return 1;
		}
	}
	return 0;
}

//int neighbours(Graph* G, int u) {
//	int v;
//	for (v = 1; v <= G->n; v++) {
//		if (adjacent(G, u, v) != 0) {
//			printf("%d ", v); 
//		}
//	}
//}

int degree(Graph *pG, int u) {
	int e, deg_u = 0;
		for (e = 0; e < pG->m; e++) {
			if (pG->edges[e].u == u)
				deg_u++;
			if (pG->edges[e].v == u)
				deg_u++;
	}
	return deg_u;
}
