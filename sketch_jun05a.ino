int latch = 8;
int clock = 13;
int data = 11;
byte off = B11111111;
int count = 0;

byte sequence[] = {
  B11111111,  B11111111, B11111110,
  B11111111,  B11111111, B11111101,
  B11111111,  B11111111, B11111011,
  B11111111,  B11111111, B11110111,
  B11111111,  B11111111, B11101111,
  B11111111,  B11111111, B11011111,
  B11111111,  B11111111, B10111111,
  B11111111,  B11111111, B01111111,
  B11111111,  B11111110, B11111111,
  B11111111,  B11111101, B11111111,
  B11111111,  B11111011, B11111111,
  B11111111,  B11110111, B11111111,
  B11111111,  B11101111, B11111111,
  B11111111,  B11011111, B11111111,
  B11111111,  B10111111, B11111111,
  B11111111,  B01111111, B11111111,
  B11111110,  B11111111, B11111111,
  B11111101,  B11111111, B11111111,
  B11111011,  B11111111, B11111111,
  B11110111,  B11111111, B11111111,
  B11101111,  B11111111, B11111111,
  B11011111,  B11111111, B11111111,
  B10111111,  B11111111, B11111111,
  B01111111,  B11111111, B11111111
};


void setup()
{
 pinMode(latch, OUTPUT);
 pinMode(clock, OUTPUT);
 pinMode(data, OUTPUT); 
}

void loop()
{
    digitalWrite(latch, LOW);
    shiftOut(data, clock, MSBFIRST, off);
    shiftOut(data, clock, MSBFIRST, off);
    shiftOut(data, clock, MSBFIRST, off);
    digitalWrite(latch, HIGH);
    delay(1);
    
    for(int i = 0; i <= 72; i+=3)
    {
      digitalWrite(latch, LOW);
      shiftOut(data, clock, MSBFIRST, sequence[i]);
      shiftOut(data, clock, MSBFIRST, sequence[i+1]); 
      shiftOut(data, clock, MSBFIRST, sequence[i+2]);
      digitalWrite(latch, HIGH);
      delay(500);
    }
}
