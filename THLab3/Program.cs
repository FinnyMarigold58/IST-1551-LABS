// IST 1551, Lab 3, Tegan Herring, 9/26/2025
// Pg. 45 Variable Shop challenge

// Declare variables

// Integers
byte reallySmallNumber;
short slightlyLargerNumber;
int regularInteger;
long largeNumber;

sbyte signedSmallNumber;
ushort unsignedSlightlyLargerNumber;
uint unsignedInteger;
ulong unsignedLargeNumber;

// String and Character
char tLetter;
string message;

// Floating Point numbers (numbers with decimals)
float smallestPrecission;
double twiceAsPrecise;
decimal mostPrecise;

// Bools
bool enabled;

// Assign values to variables
reallySmallNumber = 253;
slightlyLargerNumber = 32_000;
regularInteger = 2_111_000_520;
largeNumber = 5_555_555_555_555_555_555L;

signedSmallNumber = -100;
unsignedSlightlyLargerNumber = 65_000;
unsignedInteger = 4_000_000_000;
unsignedLargeNumber = 10_000_000_000_000_000_000U;

tLetter = 'T';
message = "Hello! This is a message.";

smallestPrecission = 3.1234567F;
twiceAsPrecise = 3.123456789012345;
mostPrecise = 3.1234567890123456789012345678M;

enabled = true;

// Print Variables
Console.WriteLine(reallySmallNumber);
Console.WriteLine(slightlyLargerNumber);
Console.WriteLine(regularInteger);
Console.WriteLine(largeNumber);

Console.WriteLine(signedSmallNumber);
Console.WriteLine(unsignedSlightlyLargerNumber);
Console.WriteLine(unsignedInteger);
Console.WriteLine(unsignedLargeNumber);

Console.WriteLine(tLetter);
Console.WriteLine(message);

Console.WriteLine(smallestPrecission);
Console.WriteLine(twiceAsPrecise);
Console.WriteLine(mostPrecise);

Console.WriteLine(enabled);