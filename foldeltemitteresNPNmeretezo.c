#include <stdio.h>
#include <stdlib.h>
#include <math.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
//bazisoszto
printf("\n Ez a program az elektronika tantArgy hAzifeladatait hivatott gyorsan megoldani.\n Kesobb fejlesztek rajt.\n");
printf("kérem a tapfesz erteket:(V)\n");
double tap;
scanf("%lf",& tap);
printf("kerem a kollektoraramot (mA)\n");
double kolli;
scanf("%lf",& kolli);
printf("kerem az emitterfeszt (V)\n");
double UE;
scanf("%lf",& UE);
printf("kerem a terhelo ellenallas erteket (kOhm)\n");
double RT;
scanf("%lf",& RT);
printf("kerem a betat:\n");
double beta;
scanf("%lf",& beta);
printf("kerem a frekvenciat\n");
double frek;
scanf("%lf",& frek);
double RE;
RE=UE/kolli;
//Iemitter kb egyenlõ Icollector
//double UCe;
printf("egyenaramu meretezes:\n");

printf("Az emitter ellenallas erteke:(kOhm) %lf\n", RE);
double URC;
//double UCe = tap;
URC = 0.5*tap-UE;
//printf("UE%lf\n",UE);

double RC;
RC=URC/kolli;

//printf("kolláram: %lf\n", kolli);
//printf("URC: %lf\n", URC);
printf("A kollektor ellenallas:(kOhm) %lf\n", RC);
double IB;
IB = kolli/beta;
double I2;
I2= 10*IB;
double R2;
printf("a kettes ellenallas(felso) erteke: (kOhm) %lf\n", (UE+0.6)/I2);

printf("az egyes ellenalla(also) erteke: (KOhm) %lf\n", (tap-(UE+0.6))/(11*IB));

printf("\nvaltakozo aramu meretezes\n");
//printf("RC: %lf\n ",((RC*RT)/(RC+RT)));
double Au=-1*(kolli/26)*((RC*RT)/(RC+RT));
printf("Au: %lf\n", Au);

double rbe;
rbe=26/IB;
printf("rbe: %lf\n",rbe);
printf("rki %lf\n ", RC);
printf("kondenzatorok:\n");
printf("bemeneti kapacitas:(uF) %lf\n",1/(6.28*frek*rbe)*1000000);
printf("kimeneti kapacitas:(nF) %lf\n",1/((6.28*frek*(RC+RT)))*1000000);
printf("hidegito kapacitas:(uF) %lf\n",10/((6.28*frek*RE))*1000);







	return 0;
}
