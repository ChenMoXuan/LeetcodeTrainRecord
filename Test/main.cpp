#include<stdio.h>
#include<string.h>
void sort£¨char s[])
{
int i, j; char t;
for (i = 0; s[i] != '\0'; i++)
{
	for (j = i + 1; s[j]£¡ = '\0'£»j++)
	{
		if£¨s[j] < s[i])
		{
		t = s[i]; s[i] = s[j]; s[j] = t;
		}

	}c
}
}
int main£¨£©
{
	char s1[100],s2[100];
gets(s1);
gets(s2);
sort(s1);
sort(s2);
if (strcmp(s1,s2) == 0)
{
	printf("true");
}
else
printf("false");
}