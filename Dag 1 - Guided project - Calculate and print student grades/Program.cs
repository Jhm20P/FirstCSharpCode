﻿// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;


float totalSophiaGrade = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
float averageSophiarade = totalSophiaGrade / currentAssignments;
Console.WriteLine("This is the average grade for the Sophia: " + averageSophiarade);

float totalNicolasGrade = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
double averageNicolasGrade = totalNicolasGrade / currentAssignments;
Console.WriteLine("This is the average grade for Nicolas: " + averageNicolasGrade);

float totalZahirahGrade = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
double averageZahirahGrade = totalZahirahGrade / currentAssignments;
Console.WriteLine("This is the average grade for Zahirah: " + averageZahirahGrade);

float totalJeongGrade = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;
double averageJeongGrade = totalJeongGrade / currentAssignments;
Console.WriteLine("This is the average grade for jeong: " + averageJeongGrade);

float totalGradeClass = totalJeongGrade + totalNicolasGrade + totalSophiaGrade + totalZahirahGrade;
double averageGradeClass = totalGradeClass / (currentAssignments * 4);
Console.WriteLine("This is the average grade for the class: " + averageGradeClass);
