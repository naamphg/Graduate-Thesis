#include <stdint.h>
#include <stdbool.h>
#include <string.h>
#include <math.h>

#define PAUSE 'P'
#define STOP 'S'
#define FB 'F'

typedef struct
{
	uint32_t periodps;
	uint32_t steps;
	uint8_t dir;
}stepper;

extern stepper stepperA;
extern stepper stepperB;
extern stepper stepperC;

extern bool calib;
extern int state;

extern char buffF[20];
extern char stop[5];
extern char C1[2];
extern char C2[2];
extern char C3[2];
extern char C4[2];
extern char C5[2];
extern char C6[2];
extern char C7[2];
extern bool buzzer;

