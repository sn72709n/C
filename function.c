#include "function.h"

double dotp(double * ptr1, double *ptr2, int size)
{
	int i;
	double dp=0;
	for(i=0;i<size;i++)
		dp = dp + ptr1[i]*ptr2[i];

	return dp;

}
