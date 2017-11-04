all: scalar

scalar: main.o function.o
	gcc main.o function.o -o scalar

main.o:	main.c
	gcc -c main.c

function.o: function.c
	gcc -c function.c

clean:
	rm -rf *o scalar
