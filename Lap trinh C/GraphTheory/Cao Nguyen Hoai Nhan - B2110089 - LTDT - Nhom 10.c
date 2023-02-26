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


//void add_edge(Graph *G, int u, int v) {
//	G->edges[G->m].u = u;
//	G->edges[G->m].v = v;
//	G->m++;
//}

// Bai tap 3.A
//void add_edge(Graph *G, int u, int v) {    
//    if(u > 0 && u <= G->n && v > 0 && v <= G->n) {
//        G->edges[G->m].u = u;
//        G->edges[G->m].v = v;
//        
//        G->m++;
//    } 
//} 

// Bai tap 3.B
void add_edge(Graph *G, int u, int v) {    
    int i;
    int check = 1;
	for (i = 0; i < G->m; i++ ) {
		if (G->edges[i].u == u && G->edges[i].v == v) {
			check = 0;
			break;
		}
	}
	if (check == 1) {
		G->edges[G->m].u = u;
    	G->edges[G->m].v = v;    
    	G->m++;
	}
} 
//
//// Bai tap 3.C
//void add_edge(Graph *G, int u, int v) {    
//    int i;
//    int check = 1;
//	for (i = 0; i < G->m; i++ ) {
//		if ((G->edges[i].u == u && G->edges[i].v == v) && (G->edges[i].u == v && G->edges[i].v == u)) {
//			check = 0;
//			break;
//		}
//	}
//	if (check == 1) {
//		G->edges[G->m].u = u;
//    	G->edges[G->m].v = v;    
//    	G->m++;
//	}
//} 
//


int main() {
	Graph G;
	init_graph(&G, 4);
	add_edge(&G, 1, 2);
	add_edge(&G, 1, 3);
	add_edge(&G, 2, 4);
	add_edge(&G, 4, 3);
	int i;
	for (i = 0; i < G.m; i++) {
		printf("%d %d", G.edges[i].u, G.edges[i].v);
		printf("\n");
	}
}
