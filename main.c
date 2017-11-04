#include <stdio.h>
#include <stdlib.h>
#include "function.h"

int main()
{
	double *vect1, *vect2;
	int i;
	int n;
	printf("Enter the number of the elements\n");
	scanf("%d",&n);
	vect1 = (double *)calloc(n,sizeof(double));
	vect2 = (double *)calloc(n,sizeof(double));
	printf("Enter the elements:\n");
	for(i=0;i<n;i++)
	{
		printf("1st, %d:",i+1);
		scanf("%lf",&vect1[i]);
		printf("2nd, %d:",i+1);
		scanf("%lf",&vect2[i]);

	}
	printf("The dotproduct of the 2 vectors is: %lf\t",dotp(vect1,vect2,n));

}
